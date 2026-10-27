using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DAF RID: 23983
	public class RoleBuffView : BattleVisibleChildView
	{
		// Token: 0x0603CE90 RID: 249488 RVA: 0x00EA1BA0 File Offset: 0x00E9FDA0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603CE91 RID: 249489 RVA: 0x00EA1C0C File Offset: 0x00E9FE0C
		protected override void OnStart()
		{
			base.OnStart();
			base.InitChildType(EBattleUiChild.Ignore);
			this.InitExceedTipItem();
			int value = ConfigCommonParamById.GetIntConfig("RoleBuffItemCount").Value;
			this.BuffItemContainer.Init(base.GetItem(1), value, false, true, false, this.ExceedTipItem.GetRootItem());
		}

		// Token: 0x0603CE92 RID: 249490 RVA: 0x00EA1C61 File Offset: 0x00E9FE61
		protected override void OnBeforeDestroy()
		{
			this.Refresh(null);
			this.ClearAllEnvironmentItem();
			this.DestroyExceedTipItem();
		}

		// Token: 0x0603CE93 RID: 249491 RVA: 0x00EA1C76 File Offset: 0x00E9FE76
		private void InitExceedTipItem()
		{
			this.ExceedTipItem = new BuffItem(base.GetItem(1));
			this.ExceedTipItem.ActivateExceedTip();
		}

		// Token: 0x0603CE94 RID: 249492 RVA: 0x00EA1C95 File Offset: 0x00E9FE95
		private void DestroyExceedTipItem()
		{
			if (this.ExceedTipItem != null)
			{
				this.ExceedTipItem.DestroyCompatible();
				this.ExceedTipItem = null;
			}
		}

		// Token: 0x0603CE95 RID: 249493 RVA: 0x00EA1CB4 File Offset: 0x00E9FEB4
		[NullableContext(2)]
		public void Refresh(BattleUiRoleData roleData)
		{
			if (roleData == null)
			{
				this.EntityId = null;
				this.BuffItemContainer.ClearAll();
				return;
			}
			EntityHandle entityHandle = roleData.EntityHandle;
			this.EntityId = ((entityHandle != null) ? new int?(entityHandle.Id) : null);
			this.BuffItemContainer.RefreshBuff(roleData.EntityHandle);
		}

		// Token: 0x0603CE96 RID: 249494 RVA: 0x00EA1D12 File Offset: 0x00E9FF12
		public int? GetEntityId()
		{
			return this.EntityId;
		}

		// Token: 0x0603CE97 RID: 249495 RVA: 0x00EA1D1A File Offset: 0x00E9FF1A
		public void Tick(float delta)
		{
			this.BuffItemContainer.Tick(delta);
			this.UpdateEnvironmentProperty();
		}

		// Token: 0x0603CE98 RID: 249496 RVA: 0x00EA1D2E File Offset: 0x00E9FF2E
		public void AddBuff(GameplayCue buffCueConfig, int handleId)
		{
			this.BuffItemContainer.AddBuffByCue(buffCueConfig, handleId, true);
		}

		// Token: 0x0603CE99 RID: 249497 RVA: 0x00EA1D3E File Offset: 0x00E9FF3E
		public void RemoveBuff(GameplayCue buffCueConfig, int handleId)
		{
			this.BuffItemContainer.RemoveBuffByCue(buffCueConfig, handleId, true);
		}

		// Token: 0x0603CE9A RID: 249498 RVA: 0x00EA1D50 File Offset: 0x00E9FF50
		private void UpdateEnvironmentProperty()
		{
			float num = 0f;
			foreach (int num2 in BattleUiModel.Instance.FormationData.EnvironmentPropertyList)
			{
				float value = FormationAttributeModel.Instance.GetValue((EFormationAttributeId)num2);
				if (value > num)
				{
					num = value;
				}
				EnvironmentItem environmentItem = this.EnvironmentItemMap.GetValueOrDefault(num2);
				if (environmentItem == null)
				{
					if (value > 0f)
					{
						UUIItem item = base.GetItem(0);
						AActor environmentItem2 = BattleUiControl.Instance.Pool.GetEnvironmentItem(item);
						environmentItem = new EnvironmentItem();
						environmentItem.InitPropertyId(num2);
						float max = FormationAttributeModel.Instance.GetMax((EFormationAttributeId)num2);
						environmentItem.SetPercent(value, max);
						environmentItem.CreateThenShowByActorAsync(environmentItem2, null, false).Forget();
						this.EnvironmentItemMap[num2] = environmentItem;
					}
				}
				else
				{
					float max2 = FormationAttributeModel.Instance.GetMax((EFormationAttributeId)num2);
					environmentItem.SetPercent(value, max2);
				}
			}
		}

		// Token: 0x0603CE9B RID: 249499 RVA: 0x00EA1E58 File Offset: 0x00EA0058
		private void ClearAllEnvironmentItem()
		{
			foreach (EnvironmentItem environmentItem in this.EnvironmentItemMap.Values)
			{
				BattleUiControl.Instance.Pool.RecycleEnvironmentItem(environmentItem.GetRootActor());
				environmentItem.Destroy(null);
			}
			this.EnvironmentItemMap.Clear();
		}

		// Token: 0x0401FB87 RID: 129927
		private int? EntityId;

		// Token: 0x0401FB88 RID: 129928
		[Nullable(1)]
		private readonly Dictionary<int, EnvironmentItem> EnvironmentItemMap = new Dictionary<int, EnvironmentItem>();

		// Token: 0x0401FB89 RID: 129929
		[Nullable(1)]
		private readonly BuffItemContainer BuffItemContainer = new BuffItemContainer();

		// Token: 0x0401FB8A RID: 129930
		[Nullable(2)]
		private BuffItem ExceedTipItem;

		// Token: 0x0200C08F RID: 49295
		private enum EChildComponentType
		{
			// Token: 0x0403A1B6 RID: 238006
			EnvironmentHorizontalItem,
			// Token: 0x0403A1B7 RID: 238007
			BuffHorizontalItem
		}
	}
}

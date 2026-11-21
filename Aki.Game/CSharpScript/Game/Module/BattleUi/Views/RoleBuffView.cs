using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D93 RID: 19859
	public class RoleBuffView : BattleVisibleChildView
	{
		// Token: 0x06031E07 RID: 204295 RVA: 0x00DF2A74 File Offset: 0x00DF0C74
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

		// Token: 0x06031E08 RID: 204296 RVA: 0x00DF2AE0 File Offset: 0x00DF0CE0
		protected override void OnStart()
		{
			base.OnStart();
			base.InitChildType(EBattleUiChild.Ignore);
			this.InitExceedTipItem();
			int value = ConfigCommonParamById.GetIntConfig("RoleBuffItemCount").Value;
			this.BuffItemContainer.Init(base.GetItem(1), value, false, true, false, this.ExceedTipItem.GetRootItem());
		}

		// Token: 0x06031E09 RID: 204297 RVA: 0x00DF2B35 File Offset: 0x00DF0D35
		protected override void OnBeforeDestroy()
		{
			this.Refresh(null);
			this.ClearAllEnvironmentItem();
			this.DestroyExceedTipItem();
		}

		// Token: 0x06031E0A RID: 204298 RVA: 0x00DF2B4A File Offset: 0x00DF0D4A
		private void InitExceedTipItem()
		{
			this.ExceedTipItem = new BuffItem(base.GetItem(1));
			this.ExceedTipItem.ActivateExceedTip();
		}

		// Token: 0x06031E0B RID: 204299 RVA: 0x00DF2B69 File Offset: 0x00DF0D69
		private void DestroyExceedTipItem()
		{
			if (this.ExceedTipItem != null)
			{
				this.ExceedTipItem.DestroyCompatible();
				this.ExceedTipItem = null;
			}
		}

		// Token: 0x06031E0C RID: 204300 RVA: 0x00DF2B88 File Offset: 0x00DF0D88
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

		// Token: 0x06031E0D RID: 204301 RVA: 0x00DF2BE6 File Offset: 0x00DF0DE6
		public int? GetEntityId()
		{
			return this.EntityId;
		}

		// Token: 0x06031E0E RID: 204302 RVA: 0x00DF2BEE File Offset: 0x00DF0DEE
		public void Tick(float delta)
		{
			this.BuffItemContainer.Tick(delta);
			this.UpdateEnvironmentProperty();
		}

		// Token: 0x06031E0F RID: 204303 RVA: 0x00DF2C02 File Offset: 0x00DF0E02
		public void AddBuff(GameplayCue buffCueConfig, int handleId)
		{
			this.BuffItemContainer.AddBuffByCue(buffCueConfig, handleId, true);
		}

		// Token: 0x06031E10 RID: 204304 RVA: 0x00DF2C12 File Offset: 0x00DF0E12
		public void RemoveBuff(GameplayCue buffCueConfig, int handleId)
		{
			this.BuffItemContainer.RemoveBuffByCue(buffCueConfig, handleId, true);
		}

		// Token: 0x06031E11 RID: 204305 RVA: 0x00DF2C24 File Offset: 0x00DF0E24
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

		// Token: 0x06031E12 RID: 204306 RVA: 0x00DF2D2C File Offset: 0x00DF0F2C
		private void ClearAllEnvironmentItem()
		{
			foreach (EnvironmentItem environmentItem in this.EnvironmentItemMap.Values)
			{
				BattleUiControl.Instance.Pool.RecycleEnvironmentItem(environmentItem.GetRootActor());
				environmentItem.Destroy(null);
			}
			this.EnvironmentItemMap.Clear();
		}

		// Token: 0x0401A644 RID: 108100
		private int? EntityId;

		// Token: 0x0401A645 RID: 108101
		[Nullable(1)]
		private readonly Dictionary<int, EnvironmentItem> EnvironmentItemMap = new Dictionary<int, EnvironmentItem>();

		// Token: 0x0401A646 RID: 108102
		[Nullable(1)]
		private readonly BuffItemContainer BuffItemContainer = new BuffItemContainer();

		// Token: 0x0401A647 RID: 108103
		[Nullable(2)]
		private BuffItem ExceedTipItem;

		// Token: 0x0200AA98 RID: 43672
		private enum EChildComponentType
		{
			// Token: 0x04034B88 RID: 215944
			EnvironmentHorizontalItem,
			// Token: 0x04034B89 RID: 215945
			BuffHorizontalItem
		}
	}
}

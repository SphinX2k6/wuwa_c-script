using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DFC RID: 19964
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarZheZhi : SpecialEnergyBarSlot
	{
		// Token: 0x0603239F RID: 205727 RVA: 0x00E143B0 File Offset: 0x00E125B0
		protected override UniTask InitSlotItem(UUIItem slotItem)
		{
			SpecialEnergyBarZheZhi.<InitSlotItem>d__4 <InitSlotItem>d__;
			<InitSlotItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSlotItem>d__.<>4__this = this;
			<InitSlotItem>d__.slotItem = slotItem;
			<InitSlotItem>d__.<>1__state = -1;
			<InitSlotItem>d__.<>t__builder.Start<SpecialEnergyBarZheZhi.<InitSlotItem>d__4>(ref <InitSlotItem>d__);
			return <InitSlotItem>d__.<>t__builder.Task;
		}

		// Token: 0x060323A0 RID: 205728 RVA: 0x00E143FC File Offset: 0x00E125FC
		protected override void OnInitData()
		{
			base.OnInitData();
			BattleUiRoleData roleData = this.RoleData;
			CreatureDataComponent creatureDataComponent = (roleData != null) ? roleData.CreatureDataComponent : null;
			if (creatureDataComponent == null)
			{
				return;
			}
			IList<long> customServerEntityIds = creatureDataComponent.CustomServerEntityIds;
			int num = 0;
			while (num < 3 && num <= customServerEntityIds.Count - 1)
			{
				EntityHandle entity = CreatureModel.Instance.GetEntity(customServerEntityIds[num]);
				if (entity == null || !entity.IsInit)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Battle;
					ELogAuthor author = ELogAuthor.CFT;
					string message = "折枝能量条读取伴生物实体时异常";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("creatureDataId", customServerEntityIds[num]);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					this.SummonedList.Add(entity);
				}
				num++;
			}
		}

		// Token: 0x060323A1 RID: 205729 RVA: 0x00E144AC File Offset: 0x00E126AC
		protected override void AddEvents()
		{
			base.AddEvents();
			foreach (EntityHandle entityHandle in this.SummonedList)
			{
				WorldEntity entity = entityHandle.Entity;
				BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
				if (baseTagComponent != null)
				{
					ITagTask tagTask = baseTagComponent.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["角色.R2T1ZhezhiMd10011.状态.飞鹤可触发"]), new BaseTagComponent.TTagSwitchedCallback(this.OnSummonedTagChange), null);
					if (tagTask != null)
					{
						this.TagTaskList.Add(tagTask);
					}
				}
			}
		}

		// Token: 0x060323A2 RID: 205730 RVA: 0x00E1454C File Offset: 0x00E1274C
		private void OnSummonedTagChange(int tagId, bool bTagExists)
		{
			this.UpdateSummonedEnableCount();
			this.RefreshBarPercent(false);
		}

		// Token: 0x060323A3 RID: 205731 RVA: 0x00E1455C File Offset: 0x00E1275C
		private void UpdateSummonedEnableCount()
		{
			this.SummonedEnableCount = 0;
			foreach (EntityHandle entityHandle in this.SummonedList)
			{
				WorldEntity entity = entityHandle.Entity;
				BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
				if (baseTagComponent != null && baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1ZhezhiMd10011.状态.飞鹤可触发"]))
				{
					this.SummonedEnableCount++;
				}
			}
		}

		// Token: 0x060323A4 RID: 205732 RVA: 0x00E145EC File Offset: 0x00E127EC
		protected override void OnStart()
		{
			for (int i = 0; i < this.SlotItemList.Count; i++)
			{
				(this.SlotItemList[i] as SpecialEnergyBarZheZhiSlotItem).SetEffectItemNiagaraParam("Color_Offset", SpecialEnergyBarZheZhi.ExtraEnergyEffectParams[i]);
			}
			this.UpdateSummonedEnableCount();
			base.OnStart();
		}

		// Token: 0x060323A5 RID: 205733 RVA: 0x00E14640 File Offset: 0x00E12840
		protected override void RefreshBarPercent(bool isStart = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			bool keyEnable = this.GetKeyEnable();
			for (int i = 0; i < this.SlotItemList.Count; i++)
			{
				SpecialEnergyBarZheZhiSlotItem specialEnergyBarZheZhiSlotItem = this.SlotItemList[i] as SpecialEnergyBarZheZhiSlotItem;
				if (i < this.SummonedEnableCount)
				{
					specialEnergyBarZheZhiSlotItem.UpdatePercent(0f, false, true);
					specialEnergyBarZheZhiSlotItem.SetEffectItemVisible(true);
				}
				else
				{
					specialEnergyBarZheZhiSlotItem.UpdatePercent(curPercent * (float)this.SlotNum - (float)(i - this.SummonedEnableCount), keyEnable, true);
					specialEnergyBarZheZhiSlotItem.SetEffectItemVisible(false);
				}
			}
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshKeyEnable(keyEnable, isStart);
		}

		// Token: 0x0401A9DF RID: 109023
		private const int SUMMON_NUM = 3;

		// Token: 0x0401A9E0 RID: 109024
		[StaticVariableRuleIgnore]
		private static readonly float[] ExtraEnergyEffectParams = new float[]
		{
			0.1f,
			0.3f,
			0.6f
		};

		// Token: 0x0401A9E1 RID: 109025
		private readonly List<EntityHandle> SummonedList = new List<EntityHandle>();

		// Token: 0x0401A9E2 RID: 109026
		private int SummonedEnableCount;
	}
}

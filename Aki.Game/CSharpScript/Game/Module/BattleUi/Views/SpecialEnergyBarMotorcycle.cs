using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DAA RID: 19882
	public class SpecialEnergyBarMotorcycle : SpecialEnergyBarBase
	{
		// Token: 0x06031F80 RID: 204672 RVA: 0x00DFB974 File Offset: 0x00DF9B74
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031F81 RID: 204673 RVA: 0x00DFB9FE File Offset: 0x00DF9BFE
		[NullableContext(1)]
		public void InitMotorcycleData(EntityHandle entityHandle, SpecialEnergyBarInfo config)
		{
			this.EntityHandle = entityHandle;
			this.Config = config;
			this.TagComponent = entityHandle.Entity.GetComponent<BaseTagComponent>();
			this.OnInitData();
			this.PercentMachine.Init(0f);
			base.InitKeyEnableTag();
		}

		// Token: 0x06031F82 RID: 204674 RVA: 0x00DFBA3C File Offset: 0x00DF9C3C
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarMotorcycle.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarMotorcycle.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031F83 RID: 204675 RVA: 0x00DFBA80 File Offset: 0x00DF9C80
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarMotorcycle.<InitBarItem>d__9 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarMotorcycle.<InitBarItem>d__9>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x06031F84 RID: 204676 RVA: 0x00DFBAC3 File Offset: 0x00DF9CC3
		protected override void OnInitData()
		{
			this.CountMax = (int)this.Config.ExtraFloatParams[0];
		}

		// Token: 0x06031F85 RID: 204677 RVA: 0x00DFBAE0 File Offset: 0x00DF9CE0
		protected override void OnStart()
		{
			int tagCount = this.TagComponent.GetTagCount(SpecialEnergyBarMotorcycle.CountTag);
			this.PercentMachine.SetTargetPercent(MathF.Min(1f, (float)tagCount / (float)this.CountMax));
			base.OnStart();
		}

		// Token: 0x06031F86 RID: 204678 RVA: 0x00DFBB23 File Offset: 0x00DF9D23
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagCountChanged(SpecialEnergyBarMotorcycle.CountTag, new BaseTagComponent.TTagChangedCallback(this.OnCountTagChange));
		}

		// Token: 0x06031F87 RID: 204679 RVA: 0x00DFBB42 File Offset: 0x00DF9D42
		private void OnCountTagChange(int count, int tagId, int exactTagId, int oldCount)
		{
			this.PercentMachine.SetTargetPercent(MathF.Min(1f, (float)count / (float)this.CountMax));
			this.RefreshBarPercent(false);
		}

		// Token: 0x06031F88 RID: 204680 RVA: 0x00DFBB6A File Offset: 0x00DF9D6A
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarMotorcycleSlot barItem = this.BarItem;
			if (barItem == null)
			{
				return;
			}
			barItem.Tick(delta);
		}

		// Token: 0x06031F89 RID: 204681 RVA: 0x00DFBB84 File Offset: 0x00DF9D84
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x06031F8A RID: 204682 RVA: 0x00DFBB90 File Offset: 0x00DF9D90
		protected void RefreshBarPercent(bool isStart = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			bool keyEnable = this.GetKeyEnable();
			SpecialEnergyBarMotorcycleSlot barItem = this.BarItem;
			if (barItem != null)
			{
				barItem.UpdatePercent(curPercent, keyEnable, isStart);
			}
			this.SetFullState(keyEnable, isStart);
		}

		// Token: 0x06031F8B RID: 204683 RVA: 0x00DFBBCC File Offset: 0x00DF9DCC
		private void SetFullState(bool isFull, bool isStart = false)
		{
			if (this.IsFull == isFull && !isStart)
			{
				return;
			}
			this.IsFull = isFull;
			base.GetItem(2).SetUIActive(isFull);
			base.GetItem(1).SetUIActive(!isFull);
		}

		// Token: 0x0401A73F RID: 108351
		[StaticVariableRuleIgnore]
		private static readonly int CountTag = GameplayTagDefine.EGameplayTagId["关卡.沙虫BOSS战.脉冲炮子弹"];

		// Token: 0x0401A740 RID: 108352
		[Nullable(2)]
		private EntityHandle EntityHandle;

		// Token: 0x0401A741 RID: 108353
		[Nullable(2)]
		private SpecialEnergyBarMotorcycleSlot BarItem;

		// Token: 0x0401A742 RID: 108354
		private bool IsFull;

		// Token: 0x0401A743 RID: 108355
		private int CountMax = 100;

		// Token: 0x0200AAD4 RID: 43732
		private enum EChildType
		{
			// Token: 0x04034C7F RID: 216191
			SlotBarItem,
			// Token: 0x04034C80 RID: 216192
			NormalItem,
			// Token: 0x04034C81 RID: 216193
			FullItem
		}
	}
}

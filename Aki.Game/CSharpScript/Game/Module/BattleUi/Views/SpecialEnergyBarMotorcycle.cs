using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DC6 RID: 24006
	public class SpecialEnergyBarMotorcycle : SpecialEnergyBarBase
	{
		// Token: 0x0603D009 RID: 249865 RVA: 0x00EAAA98 File Offset: 0x00EA8C98
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

		// Token: 0x0603D00A RID: 249866 RVA: 0x00EAAB22 File Offset: 0x00EA8D22
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

		// Token: 0x0603D00B RID: 249867 RVA: 0x00EAAB60 File Offset: 0x00EA8D60
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarMotorcycle.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarMotorcycle.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D00C RID: 249868 RVA: 0x00EAABA4 File Offset: 0x00EA8DA4
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarMotorcycle.<InitBarItem>d__9 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarMotorcycle.<InitBarItem>d__9>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D00D RID: 249869 RVA: 0x00EAABE7 File Offset: 0x00EA8DE7
		protected override void OnInitData()
		{
			this.CountMax = (int)this.Config.ExtraFloatParams[0];
		}

		// Token: 0x0603D00E RID: 249870 RVA: 0x00EAAC04 File Offset: 0x00EA8E04
		protected override void OnStart()
		{
			int tagCount = this.TagComponent.GetTagCount(SpecialEnergyBarMotorcycle.CountTag);
			this.PercentMachine.SetTargetPercent(MathF.Min(1f, (float)tagCount / (float)this.CountMax));
			base.OnStart();
		}

		// Token: 0x0603D00F RID: 249871 RVA: 0x00EAAC47 File Offset: 0x00EA8E47
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagCountChanged(SpecialEnergyBarMotorcycle.CountTag, new BaseTagComponent.TTagChangedCallback(this.OnCountTagChange));
		}

		// Token: 0x0603D010 RID: 249872 RVA: 0x00EAAC66 File Offset: 0x00EA8E66
		private void OnCountTagChange(int count, int tagId, int exactTagId, int oldCount)
		{
			this.PercentMachine.SetTargetPercent(MathF.Min(1f, (float)count / (float)this.CountMax));
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603D011 RID: 249873 RVA: 0x00EAAC8E File Offset: 0x00EA8E8E
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

		// Token: 0x0603D012 RID: 249874 RVA: 0x00EAACA8 File Offset: 0x00EA8EA8
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603D013 RID: 249875 RVA: 0x00EAACB4 File Offset: 0x00EA8EB4
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

		// Token: 0x0603D014 RID: 249876 RVA: 0x00EAACF0 File Offset: 0x00EA8EF0
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

		// Token: 0x0401FC82 RID: 130178
		[StaticVariableRuleIgnore]
		private static readonly int CountTag = GameplayTagDefine.EGameplayTagId["关卡.沙虫BOSS战.脉冲炮子弹"];

		// Token: 0x0401FC83 RID: 130179
		[Nullable(2)]
		private EntityHandle EntityHandle;

		// Token: 0x0401FC84 RID: 130180
		[Nullable(2)]
		private SpecialEnergyBarMotorcycleSlot BarItem;

		// Token: 0x0401FC85 RID: 130181
		private bool IsFull;

		// Token: 0x0401FC86 RID: 130182
		private int CountMax = 100;

		// Token: 0x0200C0CB RID: 49355
		private enum EChildType
		{
			// Token: 0x0403A2AD RID: 238253
			SlotBarItem,
			// Token: 0x0403A2AE RID: 238254
			NormalItem,
			// Token: 0x0403A2AF RID: 238255
			FullItem
		}
	}
}

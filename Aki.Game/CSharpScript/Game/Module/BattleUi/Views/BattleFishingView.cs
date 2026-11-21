using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CB6 RID: 19638
	public class BattleFishingView : BattleVisibleChildView
	{
		// Token: 0x06031172 RID: 201074 RVA: 0x00DB4FE4 File Offset: 0x00DB31E4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031173 RID: 201075 RVA: 0x00DB508F File Offset: 0x00DB328F
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			base.InitChildType(EBattleUiChild.TopButton);
		}

		// Token: 0x06031174 RID: 201076 RVA: 0x00DB50A0 File Offset: 0x00DB32A0
		[NullableContext(2)]
		protected override UniTask InitializeAsync(object param = null)
		{
			BattleFishingView.<InitializeAsync>d__5 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<BattleFishingView.<InitializeAsync>d__5>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031175 RID: 201077 RVA: 0x00DB50E3 File Offset: 0x00DB32E3
		public override void Reset()
		{
			this.ButtonList.Clear();
			base.Reset();
		}

		// Token: 0x06031176 RID: 201078 RVA: 0x00DB50F8 File Offset: 0x00DB32F8
		[NullableContext(1)]
		private UniTask NewFishingButton(BattleFishingView.EChildType childType, string actionName)
		{
			BattleFishingView.<NewFishingButton>d__7 <NewFishingButton>d__;
			<NewFishingButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewFishingButton>d__.<>4__this = this;
			<NewFishingButton>d__.childType = childType;
			<NewFishingButton>d__.actionName = actionName;
			<NewFishingButton>d__.<>1__state = -1;
			<NewFishingButton>d__.<>t__builder.Start<BattleFishingView.<NewFishingButton>d__7>(ref <NewFishingButton>d__);
			return <NewFishingButton>d__.<>t__builder.Task;
		}

		// Token: 0x06031177 RID: 201079 RVA: 0x00DB514B File Offset: 0x00DB334B
		public void SetDriveFishingShipVisible(bool visible)
		{
			base.SetVisible(7, visible);
		}

		// Token: 0x06031178 RID: 201080 RVA: 0x00DB5158 File Offset: 0x00DB3358
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length != 2)
			{
				return null;
			}
			int num;
			if (!int.TryParse(configParams[1], out num) || num < 0 || num >= this.BtnBindInfo.Count)
			{
				return null;
			}
			UUIButtonComponent button = base.GetButton(num);
			UUIItem uuiitem = (button != null) ? button.GetRootComponent() : null;
			if (uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}

		// Token: 0x0401A04E RID: 106574
		[Nullable(1)]
		private readonly List<FishingButton> ButtonList = new List<FishingButton>();

		// Token: 0x0200A92A RID: 43306
		private enum EChildType
		{
			// Token: 0x0403443E RID: 214078
			DockyardButton,
			// Token: 0x0403443F RID: 214079
			QuestButton,
			// Token: 0x04034440 RID: 214080
			TechButton,
			// Token: 0x04034441 RID: 214081
			HandBookButton
		}

		// Token: 0x0200A92B RID: 43307
		private enum EVisibleReason
		{
			// Token: 0x04034443 RID: 214083
			DriveFishingShip = 7
		}
	}
}

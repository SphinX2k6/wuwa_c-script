using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CD4 RID: 23764
	public class BattleFishingView : BattleVisibleChildView
	{
		// Token: 0x0603C21C RID: 246300 RVA: 0x00E64A08 File Offset: 0x00E62C08
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

		// Token: 0x0603C21D RID: 246301 RVA: 0x00E64AB3 File Offset: 0x00E62CB3
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			base.InitChildType(EBattleUiChild.TopButton);
		}

		// Token: 0x0603C21E RID: 246302 RVA: 0x00E64AC4 File Offset: 0x00E62CC4
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

		// Token: 0x0603C21F RID: 246303 RVA: 0x00E64B07 File Offset: 0x00E62D07
		public override void Reset()
		{
			this.ButtonList.Clear();
			base.Reset();
		}

		// Token: 0x0603C220 RID: 246304 RVA: 0x00E64B1C File Offset: 0x00E62D1C
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

		// Token: 0x0603C221 RID: 246305 RVA: 0x00E64B6F File Offset: 0x00E62D6F
		public void SetDriveFishingShipVisible(bool visible)
		{
			base.SetVisible(7, visible);
		}

		// Token: 0x0603C222 RID: 246306 RVA: 0x00E64B7C File Offset: 0x00E62D7C
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

		// Token: 0x0401F595 RID: 128405
		[Nullable(1)]
		private readonly List<FishingButton> ButtonList = new List<FishingButton>();

		// Token: 0x0200BF24 RID: 48932
		private enum EChildType
		{
			// Token: 0x04039A7C RID: 236156
			DockyardButton,
			// Token: 0x04039A7D RID: 236157
			QuestButton,
			// Token: 0x04039A7E RID: 236158
			TechButton,
			// Token: 0x04039A7F RID: 236159
			HandBookButton
		}

		// Token: 0x0200BF25 RID: 48933
		private enum EVisibleReason
		{
			// Token: 0x04039A81 RID: 236161
			DriveFishingShip = 7
		}
	}
}

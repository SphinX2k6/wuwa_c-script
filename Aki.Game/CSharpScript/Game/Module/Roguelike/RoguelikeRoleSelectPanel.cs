using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DE0 RID: 19936
	public class RoguelikeRoleSelectPanel : UiPanelBase
	{
		// Token: 0x0603374E RID: 210766 RVA: 0x00C05D6C File Offset: 0x00C03F6C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickEntrance));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603374F RID: 210767 RVA: 0x00C05E96 File Offset: 0x00C04096
		private void OnClickEntrance()
		{
			Action clickEntranceFunc = this.ClickEntranceFunc;
			if (clickEntranceFunc == null)
			{
				return;
			}
			clickEntranceFunc();
		}

		// Token: 0x06033750 RID: 210768 RVA: 0x00C05EA8 File Offset: 0x00C040A8
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeRoleSelectPanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeRoleSelectPanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033751 RID: 210769 RVA: 0x00C05EEC File Offset: 0x00C040EC
		[NullableContext(1)]
		public void Refresh(RoguelikeEntranceViewModel viewModel)
		{
			List<int> formationIdList = viewModel.FormationIdList;
			for (int i = 0; i < 3; i++)
			{
				this.RoleSelectItemList[i].Refresh(formationIdList[i]);
			}
		}

		// Token: 0x06033752 RID: 210770 RVA: 0x00C05F24 File Offset: 0x00C04124
		public void ShowNewUnlockRole(bool isShow)
		{
			this.RoleSelectItemList[0].ShowNewUnlockRole(isShow);
		}

		// Token: 0x0401B50D RID: 111885
		[Nullable(1)]
		private readonly List<RoguelikeRoleSelectItem> RoleSelectItemList = new List<RoguelikeRoleSelectItem>();

		// Token: 0x0401B50E RID: 111886
		[Nullable(2)]
		public Action<int> ClickRoleItemFunc;

		// Token: 0x0401B50F RID: 111887
		[Nullable(2)]
		public Action ClickEntranceFunc;

		// Token: 0x0200AF65 RID: 44901
		private class EComponents
		{
			// Token: 0x04035425 RID: 218149
			public const int TexLevel = 0;

			// Token: 0x04035426 RID: 218150
			public const int TxtLevel = 1;

			// Token: 0x04035427 RID: 218151
			public const int RoleItem1 = 2;

			// Token: 0x04035428 RID: 218152
			public const int RoleItem2 = 3;

			// Token: 0x04035429 RID: 218153
			public const int RoleItem3 = 4;

			// Token: 0x0403542A RID: 218154
			public const int BtnEntrance = 5;
		}
	}
}

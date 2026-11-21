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
	// Token: 0x02003DA9 RID: 15785
	public class RoguelikeRoleSelectPanel : UiPanelBase
	{
		// Token: 0x060285B9 RID: 165305 RVA: 0x00B4F27C File Offset: 0x00B4D47C
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

		// Token: 0x060285BA RID: 165306 RVA: 0x00B4F3A6 File Offset: 0x00B4D5A6
		private void OnClickEntrance()
		{
			Action clickEntranceFunc = this.ClickEntranceFunc;
			if (clickEntranceFunc == null)
			{
				return;
			}
			clickEntranceFunc();
		}

		// Token: 0x060285BB RID: 165307 RVA: 0x00B4F3B8 File Offset: 0x00B4D5B8
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeRoleSelectPanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeRoleSelectPanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060285BC RID: 165308 RVA: 0x00B4F3FC File Offset: 0x00B4D5FC
		[NullableContext(1)]
		public void Refresh(RoguelikeEntranceViewModel viewModel)
		{
			List<int> formationIdList = viewModel.FormationIdList;
			for (int i = 0; i < 3; i++)
			{
				this.RoleSelectItemList[i].Refresh(formationIdList[i]);
			}
		}

		// Token: 0x060285BD RID: 165309 RVA: 0x00B4F434 File Offset: 0x00B4D634
		public void ShowNewUnlockRole(bool isShow)
		{
			this.RoleSelectItemList[0].ShowNewUnlockRole(isShow);
		}

		// Token: 0x04015EE0 RID: 89824
		[Nullable(1)]
		private readonly List<RoguelikeRoleSelectItem> RoleSelectItemList = new List<RoguelikeRoleSelectItem>();

		// Token: 0x04015EE1 RID: 89825
		[Nullable(2)]
		public Action<int> ClickRoleItemFunc;

		// Token: 0x04015EE2 RID: 89826
		[Nullable(2)]
		public Action ClickEntranceFunc;

		// Token: 0x0200999A RID: 39322
		private class EComponents
		{
			// Token: 0x0402FE58 RID: 196184
			public const int TexLevel = 0;

			// Token: 0x0402FE59 RID: 196185
			public const int TxtLevel = 1;

			// Token: 0x0402FE5A RID: 196186
			public const int RoleItem1 = 2;

			// Token: 0x0402FE5B RID: 196187
			public const int RoleItem2 = 3;

			// Token: 0x0402FE5C RID: 196188
			public const int RoleItem3 = 4;

			// Token: 0x0402FE5D RID: 196189
			public const int BtnEntrance = 5;
		}
	}
}

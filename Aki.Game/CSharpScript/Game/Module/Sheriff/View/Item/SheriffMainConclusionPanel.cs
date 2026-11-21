using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View.Item
{
	// Token: 0x02003C1F RID: 15391
	public class SheriffMainConclusionPanel : UiTabViewBase
	{
		// Token: 0x060276E4 RID: 161508 RVA: 0x00B0E680 File Offset: 0x00B0C880
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickBtnSkyEyeConfirm));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickBtnSkyEyeConfirmWhile));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060276E5 RID: 161509 RVA: 0x00B0E78C File Offset: 0x00B0C98C
		protected override void OnStart()
		{
			this.Proxy = (this.ExtraParams as SheriffMainProxy);
			UUIButtonComponent button = base.GetButton(2);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(false);
			}
			this.InfoScrollView = new GenericScrollViewNew<SheriffMainConclusionInfo, int>(base.GetScrollViewWithScrollbar(0), new Func<SheriffMainConclusionInfo>(this.CreateInfoItem), null, false, null);
			List<int> questionList = this.Proxy.GetQuestionList();
			this.InfoScrollView.RefreshByData(questionList, null, true);
		}

		// Token: 0x060276E6 RID: 161510 RVA: 0x00B0E808 File Offset: 0x00B0CA08
		protected override void OnBeforeShow()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlayOrReplaySequenceByName("Start", false, null);
		}

		// Token: 0x060276E7 RID: 161511 RVA: 0x00B0E834 File Offset: 0x00B0CA34
		[NullableContext(1)]
		private SheriffMainConclusionInfo CreateInfoItem()
		{
			return new SheriffMainConclusionInfo(this.Proxy);
		}

		// Token: 0x060276E8 RID: 161512 RVA: 0x00B0E841 File Offset: 0x00B0CA41
		private void OnClickBtnSkyEyeConfirm()
		{
			this.Proxy.RestartGameplay();
		}

		// Token: 0x060276E9 RID: 161513 RVA: 0x00B0E84E File Offset: 0x00B0CA4E
		private void OnClickBtnSkyEyeConfirmWhile()
		{
			this.Proxy.RequestConfirm().Then(delegate(bool value)
			{
				if (value)
				{
					this.Proxy.CloseGameplay();
				}
			});
		}

		// Token: 0x040157F5 RID: 88053
		[Nullable(2)]
		protected SheriffMainProxy Proxy;

		// Token: 0x040157F6 RID: 88054
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<SheriffMainConclusionInfo, int> InfoScrollView;

		// Token: 0x0200983F RID: 38975
		private static class EDefine
		{
			// Token: 0x0402F7C8 RID: 194504
			public const int SvMulti = 0;

			// Token: 0x0402F7C9 RID: 194505
			public const int PanelClue = 1;

			// Token: 0x0402F7CA RID: 194506
			public const int BtnSkyEyeConfirm = 2;

			// Token: 0x0402F7CB RID: 194507
			public const int BtnSkyEyeConfirmWhile = 3;
		}
	}
}

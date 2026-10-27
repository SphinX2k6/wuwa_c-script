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
	// Token: 0x02004C6E RID: 19566
	public class SheriffMainConclusionPanel : UiTabViewBase
	{
		// Token: 0x06032931 RID: 207153 RVA: 0x00BC9A1C File Offset: 0x00BC7C1C
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

		// Token: 0x06032932 RID: 207154 RVA: 0x00BC9B28 File Offset: 0x00BC7D28
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

		// Token: 0x06032933 RID: 207155 RVA: 0x00BC9BA4 File Offset: 0x00BC7DA4
		protected override void OnBeforeShow()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlayOrReplaySequenceByName("Start", false, null);
		}

		// Token: 0x06032934 RID: 207156 RVA: 0x00BC9BD0 File Offset: 0x00BC7DD0
		[NullableContext(1)]
		private SheriffMainConclusionInfo CreateInfoItem()
		{
			return new SheriffMainConclusionInfo(this.Proxy);
		}

		// Token: 0x06032935 RID: 207157 RVA: 0x00BC9BDD File Offset: 0x00BC7DDD
		private void OnClickBtnSkyEyeConfirm()
		{
			this.Proxy.RestartGameplay();
		}

		// Token: 0x06032936 RID: 207158 RVA: 0x00BC9BEA File Offset: 0x00BC7DEA
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

		// Token: 0x0401AE98 RID: 110232
		[Nullable(2)]
		protected SheriffMainProxy Proxy;

		// Token: 0x0401AE99 RID: 110233
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<SheriffMainConclusionInfo, int> InfoScrollView;

		// Token: 0x0200AE21 RID: 44577
		private static class EDefine
		{
			// Token: 0x04034E23 RID: 216611
			public const int SvMulti = 0;

			// Token: 0x04034E24 RID: 216612
			public const int PanelClue = 1;

			// Token: 0x04034E25 RID: 216613
			public const int BtnSkyEyeConfirm = 2;

			// Token: 0x04034E26 RID: 216614
			public const int BtnSkyEyeConfirmWhile = 3;
		}
	}
}

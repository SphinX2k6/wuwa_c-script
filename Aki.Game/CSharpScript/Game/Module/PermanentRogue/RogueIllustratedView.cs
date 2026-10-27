using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x0200531C RID: 21276
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueIllustratedView : UiViewBase
	{
		// Token: 0x06036695 RID: 222869 RVA: 0x00CE0BF5 File Offset: 0x00CDEDF5
		[NullableContext(1)]
		public RogueIllustratedView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06036696 RID: 222870 RVA: 0x00CE0C00 File Offset: 0x00CDEE00
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(4, new Action(this.OnClickPrev)),
				new ValueTuple<int, Delegate>(5, new Action(this.OnClickNext))
			};
		}

		// Token: 0x06036697 RID: 222871 RVA: 0x00CE0CD8 File Offset: 0x00CDEED8
		protected override UniTask OnBeforeStartAsync()
		{
			RogueIllustratedView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueIllustratedView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036698 RID: 222872 RVA: 0x00CE0D1C File Offset: 0x00CDEF1C
		protected override void OnStart()
		{
			base.GetButton(4).RootUIComp.Get().SetUIActive(false);
			base.GetButton(5).RootUIComp.Get().SetUIActive(false);
		}

		// Token: 0x06036699 RID: 222873 RVA: 0x00CE0D5D File Offset: 0x00CDEF5D
		protected override void OnBeforeShow()
		{
			this.RefreshBtn();
			this.BindRedDot();
		}

		// Token: 0x0603669A RID: 222874 RVA: 0x00CE0D6B File Offset: 0x00CDEF6B
		protected override void OnBeforeHide()
		{
			this.UnbindRedDot();
		}

		// Token: 0x0603669B RID: 222875 RVA: 0x00CE0D73 File Offset: 0x00CDEF73
		protected override void OnBeforeDestroy()
		{
			this.CaptionItem = null;
			this.BtnToken = null;
			this.BtnNormal = null;
			this.BtnMap = null;
		}

		// Token: 0x0603669C RID: 222876 RVA: 0x00CE0D91 File Offset: 0x00CDEF91
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.PermanentRogueRewardUpdate, new Action(this.OnRefreshAward));
		}

		// Token: 0x0603669D RID: 222877 RVA: 0x00CE0DAF File Offset: 0x00CDEFAF
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.PermanentRogueRewardUpdate, new Action(this.OnRefreshAward));
		}

		// Token: 0x0603669E RID: 222878 RVA: 0x00CE0DCD File Offset: 0x00CDEFCD
		private void OnClickBack()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603669F RID: 222879 RVA: 0x00CE0DD6 File Offset: 0x00CDEFD6
		private void OnClickToken()
		{
			UiManager.Instance.OpenView(EUiViewName.RogueTokenIllustratedView, null, null);
		}

		// Token: 0x060366A0 RID: 222880 RVA: 0x00CE0DE9 File Offset: 0x00CDEFE9
		private void OnClickNormal()
		{
			UiManager.Instance.OpenView(EUiViewName.RogueEventIllustratedView, true, null);
		}

		// Token: 0x060366A1 RID: 222881 RVA: 0x00CE0E01 File Offset: 0x00CDF001
		private void OnClickMap()
		{
			UiManager.Instance.OpenView(EUiViewName.RogueEventIllustratedView, false, null);
		}

		// Token: 0x060366A2 RID: 222882 RVA: 0x00CE0E19 File Offset: 0x00CDF019
		private void OnClickPrev()
		{
		}

		// Token: 0x060366A3 RID: 222883 RVA: 0x00CE0E1B File Offset: 0x00CDF01B
		private void OnClickNext()
		{
		}

		// Token: 0x060366A4 RID: 222884 RVA: 0x00CE0E1D File Offset: 0x00CDF01D
		private void OnRefreshAward()
		{
			this.UnbindRedDot();
			this.BindRedDot();
			this.RefreshBtn();
		}

		// Token: 0x060366A5 RID: 222885 RVA: 0x00CE0E34 File Offset: 0x00CDF034
		public void RefreshBtn()
		{
			Dictionary<int, int[]> typeIllustratedCountInfo = ActivityPermanentRogueModel.Instance.GetTypeIllustratedCountInfo();
			string multiTextByKey = TextConfig.Instance.GetMultiTextByKey("Rogue_Collection_Progress", "Rogue_Collection_Progress");
			int[] array;
			typeIllustratedCountInfo.TryGetValue(0, out array);
			string num = StringUtils.Format(multiTextByKey ?? "", new string[]
			{
				(array != null) ? array[0].ToString() : "0",
				(array != null) ? array[1].ToString() : "0"
			});
			RogueButtonItemCollection btnToken = this.BtnToken;
			if (btnToken != null)
			{
				btnToken.SetNum(num);
			}
			RogueButtonItemCollection btnToken2 = this.BtnToken;
			if (btnToken2 != null)
			{
				btnToken2.SetButtonDone(array == null || array[0] == array[1]);
			}
			int[] array2;
			typeIllustratedCountInfo.TryGetValue(1, out array2);
			string num2 = StringUtils.Format(multiTextByKey ?? "", new string[]
			{
				(array2 != null) ? array2[0].ToString() : "0",
				(array2 != null) ? array2[1].ToString() : "0"
			});
			RogueButtonItemCollection btnNormal = this.BtnNormal;
			if (btnNormal != null)
			{
				btnNormal.SetNum(num2);
			}
			RogueButtonItemCollection btnNormal2 = this.BtnNormal;
			if (btnNormal2 != null)
			{
				btnNormal2.SetButtonDone(array2 == null || array2[0] == array2[1]);
			}
			int[] array3;
			typeIllustratedCountInfo.TryGetValue(2, out array3);
			string num3 = StringUtils.Format(multiTextByKey ?? "", new string[]
			{
				(array3 != null) ? array3[0].ToString() : "0",
				(array3 != null) ? array3[1].ToString() : "0"
			});
			RogueButtonItemCollection btnMap = this.BtnMap;
			if (btnMap != null)
			{
				btnMap.SetNum(num3);
			}
			RogueButtonItemCollection btnMap2 = this.BtnMap;
			if (btnMap2 == null)
			{
				return;
			}
			btnMap2.SetButtonDone(array3 == null || array3[0] == array3[1]);
		}

		// Token: 0x060366A6 RID: 222886 RVA: 0x00CE0FFC File Offset: 0x00CDF1FC
		public void BindRedDot()
		{
			RogueButtonItemCollection btnToken = this.BtnToken;
			if (btnToken != null)
			{
				btnToken.BindRedDot(ERedDotName.RogueResIllustratedTokenTab, new int?(0));
			}
			RogueButtonItemCollection btnNormal = this.BtnNormal;
			if (btnNormal != null)
			{
				btnNormal.BindRedDot(ERedDotName.RogueResIllustratedNormalTab, new int?(0));
			}
			RogueButtonItemCollection btnMap = this.BtnMap;
			if (btnMap == null)
			{
				return;
			}
			btnMap.BindRedDot(ERedDotName.RogueResIllustratedMapTab, new int?(0));
		}

		// Token: 0x060366A7 RID: 222887 RVA: 0x00CE1056 File Offset: 0x00CDF256
		public void UnbindRedDot()
		{
			this.BtnToken.UnBindRedDot();
			this.BtnNormal.UnBindRedDot();
			this.BtnMap.UnBindRedDot();
		}

		// Token: 0x0401CC28 RID: 117800
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401CC29 RID: 117801
		private RogueButtonItemCollection BtnToken;

		// Token: 0x0401CC2A RID: 117802
		private RogueButtonItemCollection BtnNormal;

		// Token: 0x0401CC2B RID: 117803
		private RogueButtonItemCollection BtnMap;
	}
}

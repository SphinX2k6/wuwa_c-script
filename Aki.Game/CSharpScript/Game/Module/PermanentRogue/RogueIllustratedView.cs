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
	// Token: 0x020042EC RID: 17132
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueIllustratedView : UiViewBase
	{
		// Token: 0x0602B591 RID: 177553 RVA: 0x00C2E5C5 File Offset: 0x00C2C7C5
		[NullableContext(1)]
		public RogueIllustratedView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602B592 RID: 177554 RVA: 0x00C2E5D0 File Offset: 0x00C2C7D0
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

		// Token: 0x0602B593 RID: 177555 RVA: 0x00C2E6A8 File Offset: 0x00C2C8A8
		protected override UniTask OnBeforeStartAsync()
		{
			RogueIllustratedView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueIllustratedView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602B594 RID: 177556 RVA: 0x00C2E6EC File Offset: 0x00C2C8EC
		protected override void OnStart()
		{
			base.GetButton(4).RootUIComp.Get().SetUIActive(false);
			base.GetButton(5).RootUIComp.Get().SetUIActive(false);
		}

		// Token: 0x0602B595 RID: 177557 RVA: 0x00C2E72D File Offset: 0x00C2C92D
		protected override void OnBeforeShow()
		{
			this.RefreshBtn();
			this.BindRedDot();
		}

		// Token: 0x0602B596 RID: 177558 RVA: 0x00C2E73B File Offset: 0x00C2C93B
		protected override void OnBeforeHide()
		{
			this.UnbindRedDot();
		}

		// Token: 0x0602B597 RID: 177559 RVA: 0x00C2E743 File Offset: 0x00C2C943
		protected override void OnBeforeDestroy()
		{
			this.CaptionItem = null;
			this.BtnToken = null;
			this.BtnNormal = null;
			this.BtnMap = null;
		}

		// Token: 0x0602B598 RID: 177560 RVA: 0x00C2E761 File Offset: 0x00C2C961
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.PermanentRogueRewardUpdate, new Action(this.OnRefreshAward));
		}

		// Token: 0x0602B599 RID: 177561 RVA: 0x00C2E77F File Offset: 0x00C2C97F
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.PermanentRogueRewardUpdate, new Action(this.OnRefreshAward));
		}

		// Token: 0x0602B59A RID: 177562 RVA: 0x00C2E79D File Offset: 0x00C2C99D
		private void OnClickBack()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602B59B RID: 177563 RVA: 0x00C2E7A6 File Offset: 0x00C2C9A6
		private void OnClickToken()
		{
			UiManager.Instance.OpenView(EUiViewName.RogueTokenIllustratedView, null, null);
		}

		// Token: 0x0602B59C RID: 177564 RVA: 0x00C2E7B9 File Offset: 0x00C2C9B9
		private void OnClickNormal()
		{
			UiManager.Instance.OpenView(EUiViewName.RogueEventIllustratedView, true, null);
		}

		// Token: 0x0602B59D RID: 177565 RVA: 0x00C2E7D1 File Offset: 0x00C2C9D1
		private void OnClickMap()
		{
			UiManager.Instance.OpenView(EUiViewName.RogueEventIllustratedView, false, null);
		}

		// Token: 0x0602B59E RID: 177566 RVA: 0x00C2E7E9 File Offset: 0x00C2C9E9
		private void OnClickPrev()
		{
		}

		// Token: 0x0602B59F RID: 177567 RVA: 0x00C2E7EB File Offset: 0x00C2C9EB
		private void OnClickNext()
		{
		}

		// Token: 0x0602B5A0 RID: 177568 RVA: 0x00C2E7ED File Offset: 0x00C2C9ED
		private void OnRefreshAward()
		{
			this.UnbindRedDot();
			this.BindRedDot();
			this.RefreshBtn();
		}

		// Token: 0x0602B5A1 RID: 177569 RVA: 0x00C2E804 File Offset: 0x00C2CA04
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

		// Token: 0x0602B5A2 RID: 177570 RVA: 0x00C2E9CC File Offset: 0x00C2CBCC
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

		// Token: 0x0602B5A3 RID: 177571 RVA: 0x00C2EA26 File Offset: 0x00C2CC26
		public void UnbindRedDot()
		{
			this.BtnToken.UnBindRedDot();
			this.BtnNormal.UnBindRedDot();
			this.BtnMap.UnBindRedDot();
		}

		// Token: 0x0401765E RID: 95838
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401765F RID: 95839
		private RogueButtonItemCollection BtnToken;

		// Token: 0x04017660 RID: 95840
		private RogueButtonItemCollection BtnNormal;

		// Token: 0x04017661 RID: 95841
		private RogueButtonItemCollection BtnMap;
	}
}

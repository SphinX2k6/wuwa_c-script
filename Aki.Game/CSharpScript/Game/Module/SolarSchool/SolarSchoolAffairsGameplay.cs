using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058FC RID: 22780
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolAffairsGameplay : SolarSchoolGameplayBase, ISolarSchoolAffairsViewHandler
	{
		// Token: 0x06038288 RID: 230024 RVA: 0x00FB29B8 File Offset: 0x00FB0BB8
		protected unsafe override int OnExParse(IReadOnlyDictionary<string, string> parameters)
		{
			using (IEnumerator<KeyValuePair<string, string>> enumerator = parameters.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					KeyValuePair<string, string> keyValuePair = enumerator.Current;
					string[] array = keyValuePair.Value.TrimStart('[').TrimEnd(']').Split(',', StringSplitOptions.RemoveEmptyEntries);
					for (int i = 0; i < array.Length; i++)
					{
						int item;
						if (int.TryParse(array[i], out item))
						{
							this.AffairsIds.Add(item);
						}
						else
						{
							Log instance = Log.Instance;
							ELogModule module = ELogModule.SolarSchool;
							ELogAuthor author = ELogAuthor.YYZ;
							string message = "[SolarSchool][Affairs] 政务Action参数违法";
							<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActionId", base.ActionId);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("key", keyValuePair.Key);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("value", keyValuePair.Value);
							instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
						}
					}
				}
			}
			if (this.AffairsIds.Count <= 0)
			{
				return 0;
			}
			return this.AffairsIds[0];
		}

		// Token: 0x06038289 RID: 230025 RVA: 0x00FB2AF8 File Offset: 0x00FB0CF8
		protected override void OnGameplayStart()
		{
			base.AddState("Popup", new Action(this.EnterPopup));
			base.AddState("OpenView", new Action(this.EnterOpenView));
			base.AddState("WaitChoice", new Action(this.EnterWaitChoice));
			base.AddState("Transition", new Action(this.EnterTransition));
		}

		// Token: 0x0603828A RID: 230026 RVA: 0x00FB2B61 File Offset: 0x00FB0D61
		protected override void OnGameplayEnd()
		{
			this.CloseView();
		}

		// Token: 0x0603828B RID: 230027 RVA: 0x00FB2B6C File Offset: 0x00FB0D6C
		private void EnterPopup()
		{
			SolarSchoolEventPopupParam param = new SolarSchoolEventPopupParam
			{
				PopupId = ESolarSchoolPopupId.AffairsStart,
				OnCloseCallback = delegate()
				{
					base.GotoState("OpenView");
				}
			};
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolEventPopupView, param, null);
		}

		// Token: 0x0603828C RID: 230028 RVA: 0x00FB2BA9 File Offset: 0x00FB0DA9
		private void EnterOpenView()
		{
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolAffairsView, this, null);
		}

		// Token: 0x0603828D RID: 230029 RVA: 0x00FB2BBC File Offset: 0x00FB0DBC
		private unsafe void EnterWaitChoice()
		{
			int num = this.AffairsIds[this.CurrentIndex];
			SolarSchoolAffairs? affairs = SolarSchoolConfig.Instance.GetAffairs(num);
			if (affairs == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[SolarSchool][Affairs] 政务表缺行，跳过该政务";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("affairsId", num);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.AdvanceOrFinish();
				return;
			}
			IReadOnlyList<SolarSchoolAffairsOption> readOnlyList = SolarSchoolConfig.Instance.GetAffairsOptionList(affairs.Value.OptionGroupId) ?? Array.Empty<SolarSchoolAffairsOption>();
			List<int> list = new List<int>(readOnlyList.Count);
			foreach (SolarSchoolAffairsOption solarSchoolAffairsOption in readOnlyList)
			{
				list.Add(solarSchoolAffairsOption.Id);
			}
			if (list.Count == 0)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SolarSchool;
				ELogAuthor author2 = ELogAuthor.YYZ;
				string message2 = "[SolarSchool][Affairs] 政务选项组为空，跳过该政务";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("affairsId", num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("optionGroupId", affairs.Value.OptionGroupId);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.AdvanceOrFinish();
				return;
			}
			SolarSchoolAffairsView view = this.View;
			if (view == null)
			{
				return;
			}
			view.ShowAffairs(affairs.Value, list);
		}

		// Token: 0x0603828E RID: 230030 RVA: 0x00FB2D34 File Offset: 0x00FB0F34
		private void EnterTransition()
		{
			base.GotoState("WaitChoice");
		}

		// Token: 0x0603828F RID: 230031 RVA: 0x00FB2D41 File Offset: 0x00FB0F41
		public void OnViewReady(SolarSchoolAffairsView view)
		{
			this.View = view;
			base.GotoState("WaitChoice");
		}

		// Token: 0x06038290 RID: 230032 RVA: 0x00FB2D58 File Offset: 0x00FB0F58
		public void OnChoiceSelected(int optionId)
		{
			SolarSchoolAffairsOption? affairsOption = SolarSchoolConfig.Instance.GetAffairsOption(optionId);
			SolarSchoolRewardCenter.Instance.TryGiveReward(affairsOption.Value.Reward);
		}

		// Token: 0x06038291 RID: 230033 RVA: 0x00FB2D8B File Offset: 0x00FB0F8B
		public void OnFinished()
		{
			this.AdvanceOrFinish();
		}

		// Token: 0x06038292 RID: 230034 RVA: 0x00FB2D93 File Offset: 0x00FB0F93
		public void OnViewClosed()
		{
			this.View = null;
		}

		// Token: 0x06038293 RID: 230035 RVA: 0x00FB2D9C File Offset: 0x00FB0F9C
		private void AdvanceOrFinish()
		{
			this.CurrentIndex++;
			if (this.CurrentIndex < this.AffairsIds.Count)
			{
				base.GotoState("Transition");
				return;
			}
			this.CloseView();
			base.FinishGameplay();
		}

		// Token: 0x06038294 RID: 230036 RVA: 0x00FB2DD7 File Offset: 0x00FB0FD7
		private void CloseView()
		{
			if (this.View == null)
			{
				base.CloseOpeningView(EUiViewName.SolarSchoolAffairsView);
				return;
			}
			UiViewBase view = this.View;
			this.View = null;
			view.CloseMe(null);
		}

		// Token: 0x0401D91C RID: 121116
		[Nullable(2)]
		private SolarSchoolAffairsView View;

		// Token: 0x0401D91D RID: 121117
		private readonly List<int> AffairsIds = new List<int>();

		// Token: 0x0401D91E RID: 121118
		private int CurrentIndex;

		// Token: 0x0200B4BA RID: 46266
		[Nullable(0)]
		private static class GameplayState
		{
			// Token: 0x04037E1E RID: 228894
			public const string Popup = "Popup";

			// Token: 0x04037E1F RID: 228895
			public const string OpenView = "OpenView";

			// Token: 0x04037E20 RID: 228896
			public const string WaitChoice = "WaitChoice";

			// Token: 0x04037E21 RID: 228897
			public const string Transition = "Transition";
		}
	}
}

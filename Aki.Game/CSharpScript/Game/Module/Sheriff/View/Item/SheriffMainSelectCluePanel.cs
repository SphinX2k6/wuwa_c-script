using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View.Item
{
	// Token: 0x02004C73 RID: 19571
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffMainSelectCluePanel : UiTabViewBase
	{
		// Token: 0x06032956 RID: 207190 RVA: 0x00BCA7AC File Offset: 0x00BC89AC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 22;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(21, new Action(this.OnClickedReplayDialog));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06032957 RID: 207191 RVA: 0x00BCAAF8 File Offset: 0x00BC8CF8
		protected override void OnStart()
		{
			this.Proxy = (this.ExtraParams as SheriffMainProxy);
			this.ConfirmBtn = new ButtonItem(base.GetItem(18));
			this.ConfirmBtn.SetFunction(new Action<int>(this.OnClickBtnSkyEyeConfirm));
			this.QuestionTabLayout = new GenericLayout<SheriffQuestionTabItem, int>(base.GetHorizontalLayout(2), new Func<SheriffQuestionTabItem>(this.CreateQuestionTabItem), null, false, true);
			this.SelectLayout = new GenericLayout<SheriffSelectClueItem, int>(base.GetHorizontalLayout(12), new Func<SheriffSelectClueItem>(this.CreateSelectClueItem), null, false, true);
			this.SelectedLayout = new GenericLayout<SheriffSelectClueItem, int>(base.GetHorizontalLayout(16), new Func<SheriffSelectClueItem>(this.CreateSelectClueItem), null, false, true);
			this.ClueLayout = new GenericLayout<SheriffClueItem, int>(base.GetGridLayout(0), new Func<SheriffClueItem>(this.CreateClueItem), null, false, true);
			this.Proxy.OnClueHintStateChangeCallback = new Action(this.OnClueHintStateChangeCallback);
		}

		// Token: 0x06032958 RID: 207192 RVA: 0x00BCABE0 File Offset: 0x00BC8DE0
		protected override void OnBeforeShow()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.PlayOrReplaySequenceByName("Start", false, null);
			}
			if (this.Proxy.BackFromDetailClue)
			{
				this.Proxy.BackFromDetailClue = false;
				return;
			}
			if (this.Proxy.NeedRemainHoverItem && this.Proxy.ConfirmClueIndex >= 0)
			{
				List<SheriffClueItem> layoutItemList = this.ClueLayout.GetLayoutItemList();
				if (layoutItemList.Count > this.Proxy.ConfirmClueIndex)
				{
					UUIItem rootItem = layoutItemList[this.Proxy.ConfirmClueIndex].GetRootItem();
					UiNavigationNewController.Instance.SetNavigationFocusForViewByRootItem(rootItem, "Group1", true);
				}
			}
			this.Proxy.NeedRemainHoverItem = false;
			this.Proxy.ConfirmClueIndex = -1;
			this.Proxy.GamepadHoverIndex = -1;
			this.CacheClueSet.Clear();
			this.CheckClueEnough();
			this.RefreshQuestionTab();
			this.RefreshQuestionPanel();
			this.RefreshCluePanel(true);
		}

		// Token: 0x06032959 RID: 207193 RVA: 0x00BCACD4 File Offset: 0x00BC8ED4
		protected void CheckClueEnough()
		{
			SheriffAnomalyInfo anomalyInfo = this.Proxy.GetAnomalyInfo();
			int count = anomalyInfo.ClueIds.Count;
			this.IsClueEnough = (SheriffConfig.Instance.GetAnomalyConfigById(anomalyInfo.AnomalyId).Value.ClueLessCount <= count);
			base.GetItem(19).SetUIActive(!this.IsClueEnough);
		}

		// Token: 0x0603295A RID: 207194 RVA: 0x00BCAD3C File Offset: 0x00BC8F3C
		protected void RefreshQuestionTab()
		{
			int questionDataLength = this.Proxy.GetQuestionDataLength();
			List<int> list = new List<int>();
			for (int i = 0; i < questionDataLength; i++)
			{
				list.Add(i);
			}
			this.CurQuestionTabIndex = this.Proxy.GetCurQuestionIndex();
			this.QuestionTabLayout.RefreshByData(list.ToArray(), null, true);
		}

		// Token: 0x0603295B RID: 207195 RVA: 0x00BCAD94 File Offset: 0x00BC8F94
		protected void RefreshQuestionPanel()
		{
			int curQuestionIndex = this.Proxy.GetCurQuestionIndex();
			base.GetItem(4).SetUIActive(curQuestionIndex > this.CurQuestionTabIndex);
			base.GetItem(7).SetUIActive(curQuestionIndex <= this.CurQuestionTabIndex);
			base.GetItem(11).SetUIActive(curQuestionIndex == this.CurQuestionTabIndex);
			base.GetItem(15).SetUIActive(curQuestionIndex > this.CurQuestionTabIndex);
			ButtonItem confirmBtn = this.ConfirmBtn;
			if (confirmBtn != null)
			{
				confirmBtn.SetUiActive(curQuestionIndex >= this.CurQuestionTabIndex);
			}
			if (curQuestionIndex > this.CurQuestionTabIndex)
			{
				UUIButtonComponent button = base.GetButton(21);
				if (button != null)
				{
					button.RootUIComp.Get().SetUIActive(false);
				}
				SheriffMainProxy proxy = this.Proxy;
				if (proxy != null)
				{
					proxy.RefreshHintButtonEnable(false);
				}
				int questionIdByIndex = this.Proxy.GetQuestionIdByIndex(this.CurQuestionTabIndex);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 1);
				defaultInterpolatedStringHandler.AppendLiteral("ReasoningQuestion_");
				defaultInterpolatedStringHandler.AppendFormatted<int>(questionIdByIndex);
				defaultInterpolatedStringHandler.AppendLiteral("_QuestionDesc");
				string key = defaultInterpolatedStringHandler.ToStringAndClear();
				UUIText text = base.GetText(5);
				if (text != null)
				{
					text.ShowTextNew(key);
				}
				string conclusionKey = this.Proxy.GetConclusionKey(questionIdByIndex);
				UUIText text2 = base.GetText(6);
				if (text2 != null)
				{
					text2.ShowTextNew(conclusionKey);
				}
				List<int> clueRecords = this.Proxy.GetClueRecords(this.CurQuestionTabIndex);
				clueRecords.Sort((int a, int b) => a - b);
				this.SelectedLayout.RefreshByData(clueRecords, null, true);
				ButtonItem confirmBtn2 = this.ConfirmBtn;
				if (confirmBtn2 != null)
				{
					confirmBtn2.SetEnableClick(true);
				}
				ButtonItem confirmBtn3 = this.ConfirmBtn;
				if (confirmBtn3 == null)
				{
					return;
				}
				confirmBtn3.SetLocalTextNew("Inference_Desc_11", Array.Empty<object>());
				return;
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (curQuestionIndex < this.CurQuestionTabIndex)
				{
					UUIButtonComponent button2 = base.GetButton(21);
					if (button2 != null)
					{
						button2.RootUIComp.Get().SetUIActive(false);
					}
					SheriffMainProxy proxy2 = this.Proxy;
					if (proxy2 != null)
					{
						proxy2.RefreshHintButtonEnable(false);
					}
					base.GetSprite(8).SetUIActive(true);
					base.GetTexture(9).SetUIActive(false);
					PublicUtil instance = PublicUtil.Instance;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Inference_Desc_");
					defaultInterpolatedStringHandler.AppendFormatted<int>(2 + this.CurQuestionTabIndex - 1);
					string configTextByKey = instance.GetConfigTextByKey(defaultInterpolatedStringHandler.ToStringAndClear());
					LguiUtil.Instance.SetLocalTextNew(base.GetText(10), "Inference_Desc_5", new <>z__ReadOnlySingleElementList<object>(configTextByKey));
					return;
				}
				UUIButtonComponent button3 = base.GetButton(21);
				if (button3 != null)
				{
					button3.RootUIComp.Get().SetUIActive(true);
				}
				SheriffMainProxy proxy3 = this.Proxy;
				if (proxy3 != null)
				{
					proxy3.RefreshHintButtonEnable(true);
				}
				int questionIdByIndex2 = this.Proxy.GetQuestionIdByIndex(this.CurQuestionTabIndex);
				base.GetSprite(8).SetUIActive(false);
				base.GetTexture(9).SetUIActive(true);
				int currentClueLength = this.Proxy.GetCurrentClueLength();
				LguiUtil.Instance.SetLocalTextNew(base.GetText(14), "Inference_Desc_19", new <>z__ReadOnlyArray<object>(new object[]
				{
					this.CacheClueSet.Count,
					currentClueLength
				}));
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 1);
				defaultInterpolatedStringHandler.AppendLiteral("ReasoningQuestion_");
				defaultInterpolatedStringHandler.AppendFormatted<int>(questionIdByIndex2);
				defaultInterpolatedStringHandler.AppendLiteral("_QuestionDesc");
				string key2 = defaultInterpolatedStringHandler.ToStringAndClear();
				UUIText text3 = base.GetText(10);
				if (text3 != null)
				{
					text3.ShowTextNew(key2);
				}
				this.RefreshSelectClueLayout();
				ButtonItem confirmBtn4 = this.ConfirmBtn;
				if (confirmBtn4 == null)
				{
					return;
				}
				confirmBtn4.SetLocalTextNew("Inference_Desc_20", Array.Empty<object>());
				return;
			}
		}

		// Token: 0x0603295C RID: 207196 RVA: 0x00BCB11C File Offset: 0x00BC931C
		protected void RefreshSelectClueLayout()
		{
			List<int> list = this.CacheClueSet.ToList<int>();
			int realClueLength = list.Count;
			int clueLength = this.Proxy.GetCurrentClueLength();
			for (int i = list.Count; i < clueLength; i++)
			{
				list.Add(0);
			}
			this.SelectLayout.RefreshByData(list, delegate
			{
				ButtonItem confirmBtn = this.ConfirmBtn;
				if (confirmBtn == null)
				{
					return;
				}
				confirmBtn.SetEnableClick(this.IsClueEnough && realClueLength >= clueLength);
			}, true);
		}

		// Token: 0x0603295D RID: 207197 RVA: 0x00BCB198 File Offset: 0x00BC9398
		protected void RefreshCluePanel(bool needAnim = true)
		{
			SheriffAnomalyInfo anomalyInfo = this.Proxy.GetAnomalyInfo();
			if (this.AllClueIds.Count == 0)
			{
				List<int> clueListByAnomalyId = SheriffModel.Instance.GetClueListByAnomalyId(anomalyInfo.AnomalyId);
				this.AllClueIds = new List<int>(clueListByAnomalyId);
			}
			List<int> list = new List<int>();
			foreach (int item in this.AllClueIds)
			{
				if (anomalyInfo.ClueIds.Contains(item))
				{
					list.Add(item);
				}
				else
				{
					list.Add(0);
				}
			}
			this.ClueLayout.RefreshByData(list, null, needAnim);
		}

		// Token: 0x0603295E RID: 207198 RVA: 0x00BCB250 File Offset: 0x00BC9450
		private void OnClickBtnSkyEyeConfirm(int data)
		{
			int curQuestionIndex = this.Proxy.GetCurQuestionIndex();
			if (curQuestionIndex > this.CurQuestionTabIndex)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.SheriffRestartConfirm);
				confirmBoxDataNew.FunctionMap[2] = delegate()
				{
					this.Proxy.RestartGameplay();
				};
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			if (curQuestionIndex < this.CurQuestionTabIndex)
			{
				return;
			}
			int currentClueLength = this.Proxy.GetCurrentClueLength();
			if (this.CacheClueSet.Count < currentClueLength)
			{
				return;
			}
			this.Proxy.SetClueRecords(this.CurQuestionTabIndex, this.CacheClueSet.ToList<int>());
		}

		// Token: 0x0603295F RID: 207199 RVA: 0x00BCB2E3 File Offset: 0x00BC94E3
		private SheriffQuestionTabItem CreateQuestionTabItem()
		{
			return new SheriffQuestionTabItem(this.Proxy)
			{
				CheckSelectCallback = new Func<int, bool>(this.OnTabToggleCheck),
				OnToggleStateChangedCallback = new Action<int>(this.OnTabStateChangedCallback)
			};
		}

		// Token: 0x06032960 RID: 207200 RVA: 0x00BCB314 File Offset: 0x00BC9514
		private bool OnTabToggleCheck(int index)
		{
			return this.CurQuestionTabIndex == index;
		}

		// Token: 0x06032961 RID: 207201 RVA: 0x00BCB320 File Offset: 0x00BC9520
		private void OnTabStateChangedCallback(int index)
		{
			this.CurQuestionTabIndex = index;
			List<SheriffQuestionTabItem> layoutItemList = this.QuestionTabLayout.GetLayoutItemList();
			for (int i = 0; i < layoutItemList.Count; i++)
			{
				layoutItemList[i].SetSelected(i == index, false);
			}
			this.RefreshQuestionPanel();
			this.RefreshCluePanel(true);
		}

		// Token: 0x06032962 RID: 207202 RVA: 0x00BCB36F File Offset: 0x00BC956F
		private SheriffSelectClueItem CreateSelectClueItem()
		{
			return new SheriffSelectClueItem();
		}

		// Token: 0x06032963 RID: 207203 RVA: 0x00BCB378 File Offset: 0x00BC9578
		private SheriffClueItem CreateClueItem()
		{
			return new SheriffClueItem(this.Proxy)
			{
				CheckSelectCallback = new Func<int, EToggleState>(this.OnClueToggleCheck),
				OnToggleStateChangedCallback = new Action<int, bool>(this.OnClueStateChangedCallback),
				CheckCanChangeCallback = new Func<int, EToggleState, bool>(this.OnClueCheckCanChange),
				CheckToggleEnable = new Func<bool>(this.OnClueCheckToggleEnable)
			};
		}

		// Token: 0x06032964 RID: 207204 RVA: 0x00BCB3D8 File Offset: 0x00BC95D8
		private EToggleState OnClueToggleCheck(int id)
		{
			int curQuestionIndex = this.Proxy.GetCurQuestionIndex();
			if (this.CurQuestionTabIndex != curQuestionIndex)
			{
				return EToggleState.ETT_UnDetermined;
			}
			int item = this.AllClueIds[id];
			if (!this.CacheClueSet.Contains(item))
			{
				return EToggleState.ETT_UnChecked;
			}
			return EToggleState.ETT_Checked;
		}

		// Token: 0x06032965 RID: 207205 RVA: 0x00BCB41C File Offset: 0x00BC961C
		private unsafe void OnClueStateChangedCallback(int id, bool isSelected)
		{
			int currentClueLength = this.Proxy.GetCurrentClueLength();
			if (currentClueLength == 1)
			{
				if (isSelected)
				{
					this.CacheClueSet.Clear();
					this.CacheClueSet.Add(id);
				}
				else
				{
					this.CacheClueSet.Remove(id);
				}
				GenericLayout<SheriffClueItem, int> clueLayout = this.ClueLayout;
				using (List<SheriffClueItem>.Enumerator enumerator = (((clueLayout != null) ? clueLayout.GetLayoutItemList() : null) ?? new List<SheriffClueItem>()).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						SheriffClueItem sheriffClueItem = enumerator.Current;
						sheriffClueItem.RefreshSelected();
					}
					goto IL_193;
				}
			}
			if (isSelected)
			{
				if (this.CacheClueSet.Contains(id) || this.CacheClueSet.Count >= currentClueLength)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Sheriff;
					ELogAuthor author = ELogAuthor.WHJ;
					string message = "Sheriff Cache Clue Set Add Error";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CacheClueSet", this.CacheClueSet);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				this.CacheClueSet.Add(id);
			}
			else
			{
				if (!this.CacheClueSet.Contains(id))
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Sheriff;
					ELogAuthor author2 = ELogAuthor.WHJ;
					string message2 = "Sheriff Cache Clue Set Delete Error";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("id", id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("CacheClueSet", this.CacheClueSet);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				}
				this.CacheClueSet.Remove(id);
			}
			IL_193:
			LguiUtil.Instance.SetLocalTextNew(base.GetText(14), "Inference_Desc_19", new <>z__ReadOnlyArray<object>(new object[]
			{
				this.CacheClueSet.Count,
				currentClueLength
			}));
			this.RefreshSelectClueLayout();
		}

		// Token: 0x06032966 RID: 207206 RVA: 0x00BCB610 File Offset: 0x00BC9810
		private bool OnClueCheckCanChange(int id, EToggleState curState)
		{
			if (!this.OnClueCheckToggleEnable())
			{
				return true;
			}
			if (curState == EToggleState.ETT_Checked)
			{
				return true;
			}
			if (curState == EToggleState.ETT_UnChecked && id <= 0 && this.OnClueCheckToggleEnable())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Inference_Desc_30", Array.Empty<object>());
				return false;
			}
			if (curState == EToggleState.ETT_UnDetermined && !this.OnClueCheckToggleEnable())
			{
				return false;
			}
			bool flag = this.Proxy.GetCurrentClueLength() == 1;
			bool flag2 = this.CacheClueSet.Count < this.Proxy.GetCurrentClueLength() || this.CacheClueSet.Contains(id);
			if (!flag && !flag2)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Inference_Desc_31", Array.Empty<object>());
			}
			return flag || flag2;
		}

		// Token: 0x06032967 RID: 207207 RVA: 0x00BCB6B2 File Offset: 0x00BC98B2
		private bool OnClueCheckToggleEnable()
		{
			return this.CurQuestionTabIndex == this.Proxy.GetCurQuestionIndex();
		}

		// Token: 0x06032968 RID: 207208 RVA: 0x00BCB6C7 File Offset: 0x00BC98C7
		private void OnClueHintStateChangeCallback()
		{
			this.RefreshCluePanel(false);
		}

		// Token: 0x06032969 RID: 207209 RVA: 0x00BCB6D0 File Offset: 0x00BC98D0
		private void OnClickedReplayDialog()
		{
			SheriffMainProxy proxy = this.Proxy;
			if (proxy == null)
			{
				return;
			}
			proxy.ReplaySelectClueDialog();
		}

		// Token: 0x0603296A RID: 207210 RVA: 0x00BCB6E4 File Offset: 0x00BC98E4
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			if (!(configParams[0] == "SelectClue"))
			{
				return null;
			}
			int index = int.Parse(configParams[1]) - 1;
			GenericLayout<SheriffClueItem, int> clueLayout = this.ClueLayout;
			UUIItem uuiitem;
			if (clueLayout == null)
			{
				uuiitem = null;
			}
			else
			{
				SheriffClueItem layoutItemByIndex = clueLayout.GetLayoutItemByIndex(index);
				uuiitem = ((layoutItemByIndex != null) ? layoutItemByIndex.GetGuideMagnifierItem() : null);
			}
			UUIItem uuiitem2 = uuiitem;
			if (uuiitem2 == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem2,
				uuiitem2
			};
		}

		// Token: 0x0401AEA9 RID: 110249
		protected int CurQuestionTabIndex;

		// Token: 0x0401AEAA RID: 110250
		[Nullable(2)]
		protected SheriffMainProxy Proxy;

		// Token: 0x0401AEAB RID: 110251
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SheriffQuestionTabItem, int> QuestionTabLayout;

		// Token: 0x0401AEAC RID: 110252
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SheriffSelectClueItem, int> SelectLayout;

		// Token: 0x0401AEAD RID: 110253
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SheriffSelectClueItem, int> SelectedLayout;

		// Token: 0x0401AEAE RID: 110254
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SheriffClueItem, int> ClueLayout;

		// Token: 0x0401AEAF RID: 110255
		[Nullable(2)]
		private ButtonItem ConfirmBtn;

		// Token: 0x0401AEB0 RID: 110256
		protected List<int> AllClueIds = new List<int>();

		// Token: 0x0401AEB1 RID: 110257
		private readonly HashSet<int> CacheClueSet = new HashSet<int>();

		// Token: 0x0401AEB2 RID: 110258
		protected bool IsClueEnough = true;

		// Token: 0x0200AE26 RID: 44582
		[NullableContext(0)]
		private static class EDefine
		{
			// Token: 0x04034E3B RID: 216635
			public const int PanelClue = 0;

			// Token: 0x04034E3C RID: 216636
			public const int ToggleSkyEyeClue = 1;

			// Token: 0x04034E3D RID: 216637
			public const int PanelTabQuestion = 2;

			// Token: 0x04034E3E RID: 216638
			public const int ToggleClueTab = 3;

			// Token: 0x04034E3F RID: 216639
			public const int PanelInfo = 4;

			// Token: 0x04034E40 RID: 216640
			public const int TxtTitle = 5;

			// Token: 0x04034E41 RID: 216641
			public const int TxtInfo = 6;

			// Token: 0x04034E42 RID: 216642
			public const int PanelTips = 7;

			// Token: 0x04034E43 RID: 216643
			public const int SpriteLock = 8;

			// Token: 0x04034E44 RID: 216644
			public const int TexUnlock = 9;

			// Token: 0x04034E45 RID: 216645
			public const int TxtTipsTitle = 10;

			// Token: 0x04034E46 RID: 216646
			public const int PanelSelectClue = 11;

			// Token: 0x04034E47 RID: 216647
			public const int SelectClueLayout = 12;

			// Token: 0x04034E48 RID: 216648
			public const int SelectClueItem = 13;

			// Token: 0x04034E49 RID: 216649
			public const int TxtClueNum = 14;

			// Token: 0x04034E4A RID: 216650
			public const int PanelSelectedClue = 15;

			// Token: 0x04034E4B RID: 216651
			public const int SelectedClueLayout = 16;

			// Token: 0x04034E4C RID: 216652
			public const int SelectedClueItem = 17;

			// Token: 0x04034E4D RID: 216653
			public const int BtnSkyEyeConfirm = 18;

			// Token: 0x04034E4E RID: 216654
			public const int PanelNotEnoughTips = 19;

			// Token: 0x04034E4F RID: 216655
			public const int TxtTips = 20;

			// Token: 0x04034E50 RID: 216656
			public const int BtnPageArrow = 21;
		}
	}
}

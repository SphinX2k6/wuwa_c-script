using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DB8 RID: 15800
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomSelectItem : GridProxyAbstract<IPhantomSelectItemContextData>
	{
		// Token: 0x06028620 RID: 165408 RVA: 0x00B50AD3 File Offset: 0x00B4ECD3
		public PhantomSelectItem(bool isRaycastTarget = true)
		{
			this.IsRaycastTarget = isRaycastTarget;
		}

		// Token: 0x06028621 RID: 165409 RVA: 0x00B50AF4 File Offset: 0x00B4ECF4
		public override void Refresh(IPhantomSelectItemContextData data, bool isSelected, int gridIndex)
		{
			this.Update(data);
		}

		// Token: 0x06028622 RID: 165410 RVA: 0x00B50B00 File Offset: 0x00B4ED00
		public void Update(IPhantomSelectItemContextData data)
		{
			RogueGainEntry rogueGainEntry = data.RogueGainEntry;
			if (rogueGainEntry.RoguelikeGainDataType.GetValueOrDefault() != RoguelikeGainDataType.Phantom)
			{
				return;
			}
			this.RogueGainEntry = rogueGainEntry;
			this.RoguelikeInfo = data.RoguelikeInfo;
			this.RefreshPanel();
		}

		// Token: 0x06028623 RID: 165411 RVA: 0x00B50B3C File Offset: 0x00B4ED3C
		public void SetToggleStateChangeCallback(Action<int> callback)
		{
			this.ToggleStateChangeCallback = callback;
		}

		// Token: 0x06028624 RID: 165412 RVA: 0x00B50B45 File Offset: 0x00B4ED45
		public void SetToggleUnDetermined()
		{
			base.GetExtendToggle(5).SetToggleState(EToggleState.ETT_UnDetermined, false, false, false);
		}

		// Token: 0x06028625 RID: 165413 RVA: 0x00B50B58 File Offset: 0x00B4ED58
		public void SetToggleStateForce(bool bSelected)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(5);
			if (bSelected)
			{
				extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
				return;
			}
			extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06028626 RID: 165414 RVA: 0x00B50B88 File Offset: 0x00B4ED88
		public void SetToggleRaycastTarget(bool isRaycastTarget)
		{
			base.GetExtendToggle(5).RootUIComp.Get().SetBubbleUpToParent(isRaycastTarget);
			base.GetExtendToggle(5).SetSelfInteractive(isRaycastTarget);
		}

		// Token: 0x06028627 RID: 165415 RVA: 0x00B50BBC File Offset: 0x00B4EDBC
		public bool IsSelect()
		{
			return base.GetExtendToggle(5).GetToggleState() == EToggleState.ETT_Checked;
		}

		// Token: 0x06028628 RID: 165416 RVA: 0x00B50BCD File Offset: 0x00B4EDCD
		[NullableContext(2)]
		public UUIItem GetSubItem()
		{
			return base.GetGuideUiItem("0");
		}

		// Token: 0x06028629 RID: 165417 RVA: 0x00B50BDC File Offset: 0x00B4EDDC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action<EToggleState>(this.SelfBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602862A RID: 165418 RVA: 0x00B50D8C File Offset: 0x00B4EF8C
		private void SelfBtn(EToggleState state)
		{
			Action<int> toggleStateChangeCallback = this.ToggleStateChangeCallback;
			if (toggleStateChangeCallback == null)
			{
				return;
			}
			toggleStateChangeCallback(this.RogueGainEntry.ConfigId);
		}

		// Token: 0x0602862B RID: 165419 RVA: 0x00B50DAC File Offset: 0x00B4EFAC
		protected override void OnStart()
		{
			this.PhantomAttrLayout = new GenericLayout<PhantomAttrItem, IPhantomAttrItemData>(base.GetVerticalLayout(3), new Func<PhantomAttrItem>(this.CreatePhantomAttrItem), null, false, true);
			this.SetToggleRaycastTarget(this.IsRaycastTarget);
			base.GetExtendToggle(5).CanExecuteChange.Bind(new Func<bool>(this.CanToggleStateChangeInternal));
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0602862C RID: 165420 RVA: 0x00B50E14 File Offset: 0x00B4F014
		private PhantomAttrItem CreatePhantomAttrItem()
		{
			return new PhantomAttrItem();
		}

		// Token: 0x0602862D RID: 165421 RVA: 0x00B50E1C File Offset: 0x00B4F01C
		private bool CanToggleStateChangeInternal()
		{
			if (this.CanToggleStateChange != null)
			{
				EToggleState toggleState = base.GetExtendToggle(5).GetToggleState();
				return this.CanToggleStateChange(toggleState == EToggleState.ETT_Checked);
			}
			return true;
		}

		// Token: 0x0602862E RID: 165422 RVA: 0x00B50E4F File Offset: 0x00B4F04F
		protected override void OnBeforeDestroy()
		{
			this.ToggleStateChangeCallback = null;
			base.GetExtendToggle(5).CanExecuteChange.Unbind();
		}

		// Token: 0x0602862F RID: 165423 RVA: 0x00B50E69 File Offset: 0x00B4F069
		public void RefreshPanel()
		{
			if (this.RogueGainEntry == null)
			{
				return;
			}
			this.RefreshPhantom();
			this.RefreshAffixEntryList();
		}

		// Token: 0x06028630 RID: 165424 RVA: 0x00B50E80 File Offset: 0x00B4F080
		private void RefreshPhantom()
		{
			RoguePokemon? roguePhantomConfig = RoguelikeConfig.Instance.GetRoguePhantomConfig(this.RogueGainEntry.ConfigId);
			if (roguePhantomConfig == null)
			{
				return;
			}
			base.GetText(1).ShowTextNew(roguePhantomConfig.Value.PokemonName);
			base.SetTextureByPath(roguePhantomConfig.Value.PokemonIcon, base.GetTexture(0), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), roguePhantomConfig.Value.PokemonSkillDesc, Array.Empty<object>());
			base.GetText(2).SetUIActive(RoguelikeModel.Instance.GetDescModel() == EDescModel.DETAIL);
			RogueQualityConfig? rogueQualityConfigByQualityId = RoguelikeConfig.Instance.GetRogueQualityConfigByQualityId(roguePhantomConfig.Value.Quality);
			if (rogueQualityConfigByQualityId != null)
			{
				base.SetTextureByPath(rogueQualityConfigByQualityId.Value.PhantomBgA, base.GetTexture(6), null, null);
				base.SetTextureByPath(rogueQualityConfigByQualityId.Value.PhantomBgB, base.GetTexture(7), null, null);
			}
		}

		// Token: 0x06028631 RID: 165425 RVA: 0x00B50FA0 File Offset: 0x00B4F1A0
		private void RefreshAffixEntryList()
		{
			UiAsyncTask task = new UiAsyncTask("PhantomSelectItem.RefreshAffixEntryList", delegate()
			{
				PhantomSelectItem.<<RefreshAffixEntryList>b__26_0>d <<RefreshAffixEntryList>b__26_0>d;
				<<RefreshAffixEntryList>b__26_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<RefreshAffixEntryList>b__26_0>d.<>4__this = this;
				<<RefreshAffixEntryList>b__26_0>d.<>1__state = -1;
				<<RefreshAffixEntryList>b__26_0>d.<>t__builder.Start<PhantomSelectItem.<<RefreshAffixEntryList>b__26_0>d>(ref <<RefreshAffixEntryList>b__26_0>d);
				return <<RefreshAffixEntryList>b__26_0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x06028632 RID: 165426 RVA: 0x00B50FD0 File Offset: 0x00B4F1D0
		private List<IPhantomAttrItemData> GetPhantomAttrItemDataList()
		{
			RoguelikeInfo roguelikeInfo = this.RoguelikeInfo;
			List<IPhantomAttrItemData> list = new List<IPhantomAttrItemData>();
			foreach (AffixEntry affixEntry in (this.RogueGainEntry.AffixEntryList ?? new List<AffixEntry>()))
			{
				PhantomAttrItemData item = new PhantomAttrItemData
				{
					AffixEntry = affixEntry,
					RoguelikeInfo = roguelikeInfo
				};
				list.Add(item);
			}
			return list;
		}

		// Token: 0x06028633 RID: 165427 RVA: 0x00B51058 File Offset: 0x00B4F258
		public void SetUnlockAttrSet(HashSet<long> set)
		{
			this.NewUnlockAttrSet = set;
		}

		// Token: 0x06028634 RID: 165428 RVA: 0x00B51064 File Offset: 0x00B4F264
		public void PlaySequenceByName(string sequenceName)
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayOrReplaySequenceByName(sequenceName, false, null);
		}

		// Token: 0x04015EFE RID: 89854
		public RogueGainEntry RogueGainEntry;

		// Token: 0x04015EFF RID: 89855
		public GenericLayout<PhantomAttrItem, IPhantomAttrItemData> PhantomAttrLayout;

		// Token: 0x04015F00 RID: 89856
		public bool IsRaycastTarget = true;

		// Token: 0x04015F01 RID: 89857
		public HashSet<long> NewUnlockAttrSet = new HashSet<long>();

		// Token: 0x04015F02 RID: 89858
		public Func<bool, bool> CanToggleStateChange;

		// Token: 0x04015F03 RID: 89859
		private RoguelikeInfo RoguelikeInfo;

		// Token: 0x04015F04 RID: 89860
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04015F05 RID: 89861
		private Action<int> ToggleStateChangeCallback;

		// Token: 0x020099A7 RID: 39335
		[NullableContext(0)]
		private class EPhantomSelectItemCom
		{
			// Token: 0x0402FE90 RID: 196240
			public const int HeadTexture = 0;

			// Token: 0x0402FE91 RID: 196241
			public const int NameText = 1;

			// Token: 0x0402FE92 RID: 196242
			public const int DescText = 2;

			// Token: 0x0402FE93 RID: 196243
			public const int AttrListLayout = 3;

			// Token: 0x0402FE94 RID: 196244
			public const int AttrItem = 4;

			// Token: 0x0402FE95 RID: 196245
			public const int SelfToggle = 5;

			// Token: 0x0402FE96 RID: 196246
			public const int QualityBg = 6;

			// Token: 0x0402FE97 RID: 196247
			public const int QualityHeadBg = 7;

			// Token: 0x0402FE98 RID: 196248
			public const int AttrViewport = 8;

			// Token: 0x0402FE99 RID: 196249
			public const int AttrContent = 9;
		}
	}
}

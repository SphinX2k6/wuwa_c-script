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
	// Token: 0x02004DEF RID: 19951
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomSelectItem : GridProxyAbstract<IPhantomSelectItemContextData>
	{
		// Token: 0x060337B5 RID: 210869 RVA: 0x00C075C3 File Offset: 0x00C057C3
		public PhantomSelectItem(bool isRaycastTarget = true)
		{
			this.IsRaycastTarget = isRaycastTarget;
		}

		// Token: 0x060337B6 RID: 210870 RVA: 0x00C075E4 File Offset: 0x00C057E4
		public override void Refresh(IPhantomSelectItemContextData data, bool isSelected, int gridIndex)
		{
			this.Update(data);
		}

		// Token: 0x060337B7 RID: 210871 RVA: 0x00C075F0 File Offset: 0x00C057F0
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

		// Token: 0x060337B8 RID: 210872 RVA: 0x00C0762C File Offset: 0x00C0582C
		public void SetToggleStateChangeCallback(Action<int> callback)
		{
			this.ToggleStateChangeCallback = callback;
		}

		// Token: 0x060337B9 RID: 210873 RVA: 0x00C07635 File Offset: 0x00C05835
		public void SetToggleUnDetermined()
		{
			base.GetExtendToggle(5).SetToggleState(EToggleState.ETT_UnDetermined, false, false, false);
		}

		// Token: 0x060337BA RID: 210874 RVA: 0x00C07648 File Offset: 0x00C05848
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

		// Token: 0x060337BB RID: 210875 RVA: 0x00C07678 File Offset: 0x00C05878
		public void SetToggleRaycastTarget(bool isRaycastTarget)
		{
			base.GetExtendToggle(5).RootUIComp.Get().SetBubbleUpToParent(isRaycastTarget);
			base.GetExtendToggle(5).SetSelfInteractive(isRaycastTarget);
		}

		// Token: 0x060337BC RID: 210876 RVA: 0x00C076AC File Offset: 0x00C058AC
		public bool IsSelect()
		{
			return base.GetExtendToggle(5).GetToggleState() == EToggleState.ETT_Checked;
		}

		// Token: 0x060337BD RID: 210877 RVA: 0x00C076BD File Offset: 0x00C058BD
		[NullableContext(2)]
		public UUIItem GetSubItem()
		{
			return base.GetGuideUiItem("0");
		}

		// Token: 0x060337BE RID: 210878 RVA: 0x00C076CC File Offset: 0x00C058CC
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

		// Token: 0x060337BF RID: 210879 RVA: 0x00C0787C File Offset: 0x00C05A7C
		private void SelfBtn(EToggleState state)
		{
			Action<int> toggleStateChangeCallback = this.ToggleStateChangeCallback;
			if (toggleStateChangeCallback == null)
			{
				return;
			}
			toggleStateChangeCallback(this.RogueGainEntry.ConfigId);
		}

		// Token: 0x060337C0 RID: 210880 RVA: 0x00C0789C File Offset: 0x00C05A9C
		protected override void OnStart()
		{
			this.PhantomAttrLayout = new GenericLayout<PhantomAttrItem, IPhantomAttrItemData>(base.GetVerticalLayout(3), new Func<PhantomAttrItem>(this.CreatePhantomAttrItem), null, false, true);
			this.SetToggleRaycastTarget(this.IsRaycastTarget);
			base.GetExtendToggle(5).CanExecuteChange.Bind(new Func<bool>(this.CanToggleStateChangeInternal));
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x060337C1 RID: 210881 RVA: 0x00C07904 File Offset: 0x00C05B04
		private PhantomAttrItem CreatePhantomAttrItem()
		{
			return new PhantomAttrItem();
		}

		// Token: 0x060337C2 RID: 210882 RVA: 0x00C0790C File Offset: 0x00C05B0C
		private bool CanToggleStateChangeInternal()
		{
			if (this.CanToggleStateChange != null)
			{
				EToggleState toggleState = base.GetExtendToggle(5).GetToggleState();
				return this.CanToggleStateChange(toggleState == EToggleState.ETT_Checked);
			}
			return true;
		}

		// Token: 0x060337C3 RID: 210883 RVA: 0x00C0793F File Offset: 0x00C05B3F
		protected override void OnBeforeDestroy()
		{
			this.ToggleStateChangeCallback = null;
			base.GetExtendToggle(5).CanExecuteChange.Unbind();
		}

		// Token: 0x060337C4 RID: 210884 RVA: 0x00C07959 File Offset: 0x00C05B59
		public void RefreshPanel()
		{
			if (this.RogueGainEntry == null)
			{
				return;
			}
			this.RefreshPhantom();
			this.RefreshAffixEntryList();
		}

		// Token: 0x060337C5 RID: 210885 RVA: 0x00C07970 File Offset: 0x00C05B70
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

		// Token: 0x060337C6 RID: 210886 RVA: 0x00C07A90 File Offset: 0x00C05C90
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

		// Token: 0x060337C7 RID: 210887 RVA: 0x00C07AC0 File Offset: 0x00C05CC0
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

		// Token: 0x060337C8 RID: 210888 RVA: 0x00C07B48 File Offset: 0x00C05D48
		public void SetUnlockAttrSet(HashSet<long> set)
		{
			this.NewUnlockAttrSet = set;
		}

		// Token: 0x060337C9 RID: 210889 RVA: 0x00C07B54 File Offset: 0x00C05D54
		public void PlaySequenceByName(string sequenceName)
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayOrReplaySequenceByName(sequenceName, false, null);
		}

		// Token: 0x0401B52B RID: 111915
		public RogueGainEntry RogueGainEntry;

		// Token: 0x0401B52C RID: 111916
		public GenericLayout<PhantomAttrItem, IPhantomAttrItemData> PhantomAttrLayout;

		// Token: 0x0401B52D RID: 111917
		public bool IsRaycastTarget = true;

		// Token: 0x0401B52E RID: 111918
		public HashSet<long> NewUnlockAttrSet = new HashSet<long>();

		// Token: 0x0401B52F RID: 111919
		public Func<bool, bool> CanToggleStateChange;

		// Token: 0x0401B530 RID: 111920
		private RoguelikeInfo RoguelikeInfo;

		// Token: 0x0401B531 RID: 111921
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401B532 RID: 111922
		private Action<int> ToggleStateChangeCallback;

		// Token: 0x0200AF72 RID: 44914
		[NullableContext(0)]
		private class EPhantomSelectItemCom
		{
			// Token: 0x0403545D RID: 218205
			public const int HeadTexture = 0;

			// Token: 0x0403545E RID: 218206
			public const int NameText = 1;

			// Token: 0x0403545F RID: 218207
			public const int DescText = 2;

			// Token: 0x04035460 RID: 218208
			public const int AttrListLayout = 3;

			// Token: 0x04035461 RID: 218209
			public const int AttrItem = 4;

			// Token: 0x04035462 RID: 218210
			public const int SelfToggle = 5;

			// Token: 0x04035463 RID: 218211
			public const int QualityBg = 6;

			// Token: 0x04035464 RID: 218212
			public const int QualityHeadBg = 7;

			// Token: 0x04035465 RID: 218213
			public const int AttrViewport = 8;

			// Token: 0x04035466 RID: 218214
			public const int AttrContent = 9;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Phantom.Vision.View;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000DB0 RID: 3504
[NullableContext(1)]
[Nullable(0)]
public class VisionDetailDescItem : UiPanelBase
{
	// Token: 0x06008F40 RID: 36672 RVA: 0x002B1950 File Offset: 0x002AFB50
	public VisionDetailDescItem(UUIItem actor)
	{
		this.SourceItem = actor;
	}

	// Token: 0x06008F41 RID: 36673 RVA: 0x002B1960 File Offset: 0x002AFB60
	public UniTask Init()
	{
		global::VisionDetailDescItem.<Init>d__5 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<global::VisionDetailDescItem.<Init>d__5>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06008F42 RID: 36674 RVA: 0x002B19A4 File Offset: 0x002AFBA4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 13;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06008F43 RID: 36675 RVA: 0x002B1B80 File Offset: 0x002AFD80
	protected override UniTask OnBeforeStartAsync()
	{
		global::VisionDetailDescItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<global::VisionDetailDescItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008F44 RID: 36676 RVA: 0x002B1BC3 File Offset: 0x002AFDC3
	public void Update(VisionDetailDesc data)
	{
		this.Data = data;
		this.RefreshTitle(data);
		this.RefreshContent(data);
		this.RefreshEmpty(data);
		this.RefreshTitleItem(data);
		this.RefreshEmptyText(data);
		this.RefreshEmptyContentItem(data);
		this.RefreshElement(data);
	}

	// Token: 0x06008F45 RID: 36677 RVA: 0x002B1BFD File Offset: 0x002AFDFD
	private void RefreshTitle(VisionDetailDesc data)
	{
		base.GetText(0).SetText(data.Title, true);
	}

	// Token: 0x06008F46 RID: 36678 RVA: 0x002B1C14 File Offset: 0x002AFE14
	private void RefreshContent(VisionDetailDesc data)
	{
		bool ifSimpleState = PhantomBattleModel.Instance.GetIfSimpleState(1);
		if (data.FetterId > 0)
		{
			PhantomFetter phantomFetterById = PhantomBattleConfig.Instance.GetPhantomFetterById(data.FetterId);
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(phantomFetterById.Name, null);
			base.GetText(2).SetText(localTextNew ?? "", true);
			if (ifSimpleState)
			{
				if (StringUtils.IsEmpty(phantomFetterById.SimplyEffectDesc))
				{
					base.GetText(3).SetText("", true);
				}
				else
				{
					LguiUtil.Instance.SetLocalTextNew(base.GetText(3), phantomFetterById.SimplyEffectDesc, Array.Empty<object>());
				}
			}
			else
			{
				int effectDescriptionParamLength = phantomFetterById.EffectDescriptionParamLength;
				string[] array = new string[effectDescriptionParamLength];
				for (int i = 0; i < effectDescriptionParamLength; i++)
				{
					array[i] = phantomFetterById.EffectDescriptionParam(i);
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(3), phantomFetterById.EffectDescription, array);
			}
			base.GetItem(12).SetUIActive(true);
			base.GetText(2).SetUIActive(true);
			base.GetText(3).SetUIActive(true);
			return;
		}
		if (data.SkillConfig != null)
		{
			PhantomSkill value = data.SkillConfig.Value;
			if (ifSimpleState)
			{
				if (StringUtils.IsEmpty(value.SimplyDescription))
				{
					base.GetText(3).SetText("", true);
				}
				else
				{
					LguiUtil.Instance.SetLocalTextNew(base.GetText(3), value.SimplyDescription, Array.Empty<object>());
				}
			}
			else
			{
				string[] phantomSkillDescExBySkillIdAndQuality = PhantomBattleConfig.Instance.GetPhantomSkillDescExBySkillIdAndQuality(value.Id, data.Quality);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(3), value.DescriptionEx, phantomSkillDescExBySkillIdAndQuality);
			}
			base.GetItem(12).SetUIActive(false);
			base.GetText(2).SetUIActive(false);
			base.GetText(3).SetUIActive(true);
		}
	}

	// Token: 0x06008F47 RID: 36679 RVA: 0x002B1DE0 File Offset: 0x002AFFE0
	private void RefreshElement(VisionDetailDesc data)
	{
		if (data.FetterId > 0)
		{
			base.GetItem(9).SetUIActive(true);
			PhantomFetterGroup fetterGroupById = PhantomBattleConfig.Instance.GetFetterGroupById(data.FetterGroupId);
			this.VisionFetterSuitItem.Update(new PhantomFetterGroup?(fetterGroupById));
			base.GetText(11).SetText("", true);
			return;
		}
		base.GetItem(9).SetUIActive(false);
	}

	// Token: 0x06008F48 RID: 36680 RVA: 0x002B1E48 File Offset: 0x002B0048
	private void RefreshEmpty(VisionDetailDesc data)
	{
		base.GetItem(4).SetUIActive(data.EmptyState);
	}

	// Token: 0x06008F49 RID: 36681 RVA: 0x002B1E5C File Offset: 0x002B005C
	private void RefreshEmptyText(VisionDetailDesc data)
	{
		base.GetText(6).SetText(data.EmptyText, true);
	}

	// Token: 0x06008F4A RID: 36682 RVA: 0x002B1E74 File Offset: 0x002B0074
	private void RefreshEmptyContentItem(VisionDetailDesc data)
	{
		bool uiactive = !StringUtils.IsEmpty(data.EmptyContentText);
		base.GetItem(7).SetUIActive(uiactive);
		base.GetText(8).SetText(data.EmptyContentText, true);
	}

	// Token: 0x06008F4B RID: 36683 RVA: 0x002B1EB0 File Offset: 0x002B00B0
	private void RefreshTitleItem(VisionDetailDesc data)
	{
		base.GetItem(5).SetUIActive(data.TitleItemShowState);
	}

	// Token: 0x040055B4 RID: 21940
	[Nullable(2)]
	private readonly UUIItem SourceItem;

	// Token: 0x040055B5 RID: 21941
	[Nullable(2)]
	protected VisionDetailDesc Data;

	// Token: 0x040055B6 RID: 21942
	[Nullable(2)]
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x02006FF7 RID: 28663
	[NullableContext(0)]
	private class EVisionDetailDescItem
	{
		// Token: 0x0402491C RID: 149788
		public const int TitleText = 0;

		// Token: 0x0402491D RID: 149789
		public const int ContentItem = 1;

		// Token: 0x0402491E RID: 149790
		public const int ContentTextOne = 2;

		// Token: 0x0402491F RID: 149791
		public const int ContentTextTwo = 3;

		// Token: 0x04024920 RID: 149792
		public const int EmptyItem = 4;

		// Token: 0x04024921 RID: 149793
		public const int TitleParent = 5;

		// Token: 0x04024922 RID: 149794
		public const int EmptyText = 6;

		// Token: 0x04024923 RID: 149795
		public const int EmptyContentItem = 7;

		// Token: 0x04024924 RID: 149796
		public const int EmptyContentText = 8;

		// Token: 0x04024925 RID: 149797
		public const int ElementItem = 9;

		// Token: 0x04024926 RID: 149798
		public const int SuitElementItem = 10;

		// Token: 0x04024927 RID: 149799
		public const int SuitText = 11;

		// Token: 0x04024928 RID: 149800
		public const int TitleContentParent = 12;
	}
}

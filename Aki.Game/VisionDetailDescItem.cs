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

// Token: 0x020018F7 RID: 6391
[NullableContext(1)]
[Nullable(0)]
public class VisionDetailDescItem : UiPanelBase
{
	// Token: 0x0600BB56 RID: 47958 RVA: 0x002A71F0 File Offset: 0x002A53F0
	public VisionDetailDescItem(UUIItem actor)
	{
		this.SourceItem = actor;
	}

	// Token: 0x0600BB57 RID: 47959 RVA: 0x002A7200 File Offset: 0x002A5400
	public UniTask Init()
	{
		global::VisionDetailDescItem.<Init>d__5 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<global::VisionDetailDescItem.<Init>d__5>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600BB58 RID: 47960 RVA: 0x002A7244 File Offset: 0x002A5444
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

	// Token: 0x0600BB59 RID: 47961 RVA: 0x002A7420 File Offset: 0x002A5620
	protected override UniTask OnBeforeStartAsync()
	{
		global::VisionDetailDescItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<global::VisionDetailDescItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600BB5A RID: 47962 RVA: 0x002A7463 File Offset: 0x002A5663
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

	// Token: 0x0600BB5B RID: 47963 RVA: 0x002A749D File Offset: 0x002A569D
	private void RefreshTitle(VisionDetailDesc data)
	{
		base.GetText(0).SetText(data.Title, true);
	}

	// Token: 0x0600BB5C RID: 47964 RVA: 0x002A74B4 File Offset: 0x002A56B4
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

	// Token: 0x0600BB5D RID: 47965 RVA: 0x002A7680 File Offset: 0x002A5880
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

	// Token: 0x0600BB5E RID: 47966 RVA: 0x002A76E8 File Offset: 0x002A58E8
	private void RefreshEmpty(VisionDetailDesc data)
	{
		base.GetItem(4).SetUIActive(data.EmptyState);
	}

	// Token: 0x0600BB5F RID: 47967 RVA: 0x002A76FC File Offset: 0x002A58FC
	private void RefreshEmptyText(VisionDetailDesc data)
	{
		base.GetText(6).SetText(data.EmptyText, true);
	}

	// Token: 0x0600BB60 RID: 47968 RVA: 0x002A7714 File Offset: 0x002A5914
	private void RefreshEmptyContentItem(VisionDetailDesc data)
	{
		bool uiactive = !StringUtils.IsEmpty(data.EmptyContentText);
		base.GetItem(7).SetUIActive(uiactive);
		base.GetText(8).SetText(data.EmptyContentText, true);
	}

	// Token: 0x0600BB61 RID: 47969 RVA: 0x002A7750 File Offset: 0x002A5950
	private void RefreshTitleItem(VisionDetailDesc data)
	{
		base.GetItem(5).SetUIActive(data.TitleItemShowState);
	}

	// Token: 0x04005509 RID: 21769
	[Nullable(2)]
	private readonly UUIItem SourceItem;

	// Token: 0x0400550A RID: 21770
	[Nullable(2)]
	protected VisionDetailDesc Data;

	// Token: 0x0400550B RID: 21771
	[Nullable(2)]
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x02007E70 RID: 32368
	[NullableContext(0)]
	private class EVisionDetailDescItem
	{
		// Token: 0x040295F0 RID: 169456
		public const int TitleText = 0;

		// Token: 0x040295F1 RID: 169457
		public const int ContentItem = 1;

		// Token: 0x040295F2 RID: 169458
		public const int ContentTextOne = 2;

		// Token: 0x040295F3 RID: 169459
		public const int ContentTextTwo = 3;

		// Token: 0x040295F4 RID: 169460
		public const int EmptyItem = 4;

		// Token: 0x040295F5 RID: 169461
		public const int TitleParent = 5;

		// Token: 0x040295F6 RID: 169462
		public const int EmptyText = 6;

		// Token: 0x040295F7 RID: 169463
		public const int EmptyContentItem = 7;

		// Token: 0x040295F8 RID: 169464
		public const int EmptyContentText = 8;

		// Token: 0x040295F9 RID: 169465
		public const int ElementItem = 9;

		// Token: 0x040295FA RID: 169466
		public const int SuitElementItem = 10;

		// Token: 0x040295FB RID: 169467
		public const int SuitText = 11;

		// Token: 0x040295FC RID: 169468
		public const int TitleContentParent = 12;
	}
}

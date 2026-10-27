using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200267E RID: 9854
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class QuestReviewTabItem : GridProxyAbstract<QuestReviewTabData>
{
	// Token: 0x0601431A RID: 82714 RVA: 0x00519610 File Offset: 0x00517810
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(USpineSkeletonAnimationComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnTabClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0601431B RID: 82715 RVA: 0x0051971C File Offset: 0x0051791C
	protected override void OnStart()
	{
		this.SeqPlayer = new LevelSequencePlayer(base.GetRootItem());
		this.SeqPlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSeqEnd), false);
		EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		EventSystem.Instance.Add<int>(EEventName.OnOpenQuestReviewDetail, new Action<int>(this.RefreshRedDot));
	}

	// Token: 0x0601431C RID: 82716 RVA: 0x0051978A File Offset: 0x0051798A
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		EventSystem.Instance.Remove(EEventName.OnOpenQuestReviewDetail, new <>f__AnonymousDelegate2<int>(this.RefreshRedDot));
	}

	// Token: 0x0601431D RID: 82717 RVA: 0x005197C4 File Offset: 0x005179C4
	public override void Refresh(QuestReviewTabData data, bool isSelected, int gridIndex)
	{
		this.Clear();
		this.Data = data;
		this.RefreshRedDot(0);
		if (this.Data.IsFirstTimeShow)
		{
			this.SeqPlayer.PlayLevelSequenceByName("Unlock", false, null, false);
			this.Data.IsFirstTimeShow = false;
			this.HasStartSeqPlayed = true;
		}
		else if (!this.HasStartSeqPlayed)
		{
			this.SeqPlayer.PlayLevelSequenceByName(data.IsSelected ? "Start" : "UnStart", false, null, false);
			this.HasStartSeqPlayed = true;
			base.GetExtendToggle(0).SetToggleState(data.IsSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}
		else
		{
			base.GetExtendToggle(0).SetToggleState(data.IsSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.NameId, Array.Empty<object>());
		base.GetSprite(3).SetUIActive(gridIndex < 2);
	}

	// Token: 0x0601431E RID: 82718 RVA: 0x005198C4 File Offset: 0x00517AC4
	public override void Clear()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		FToggleAnimationPlayInfo ftoggleAnimationPlayInfo = extendToggle.StateSwitchAnimations.Get(EToggleStateSwitch.CheckedToUnChecked);
		if (ftoggleAnimationPlayInfo == null)
		{
			return;
		}
		FSoftObjectPath levelSequence = ftoggleAnimationPlayInfo.Animation.LevelSequence;
		(extendToggle.GetOwner() as AUIBaseActor).SequenceJumpToEnd(levelSequence);
	}

	// Token: 0x0601431F RID: 82719 RVA: 0x00519918 File Offset: 0x00517B18
	private void OnTabClick(EToggleState toggleState)
	{
		QuestReviewController.Instance.TriggerViewRefresh(this.Data.Id);
	}

	// Token: 0x06014320 RID: 82720 RVA: 0x0051992F File Offset: 0x00517B2F
	private void OnSeqEnd(string name)
	{
		if (name == "Unlock")
		{
			QuestReviewTabData data = this.Data;
			if (data != null && data.IsSelected)
			{
				base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_Checked, false, true, false);
			}
		}
	}

	// Token: 0x06014321 RID: 82721 RVA: 0x00519962 File Offset: 0x00517B62
	private void OnActivitySequenceEmitEvent(string param)
	{
		if (param == "idle")
		{
			USpineSkeletonAnimationComponent spine = base.GetSpine(2);
			if (spine == null)
			{
				return;
			}
			spine.SetAnimation(0, param, true);
		}
	}

	// Token: 0x06014322 RID: 82722 RVA: 0x00519988 File Offset: 0x00517B88
	private void RefreshRedDot(int i = 0)
	{
		QuestReviewModel instance = QuestReviewModel.Instance;
		QuestReviewTabData data = this.Data;
		bool uiactive = instance.TabHasRedDot((data != null) ? data.Id : 0);
		base.GetItem(4).SetUIActive(uiactive);
	}

	// Token: 0x04009802 RID: 38914
	[Nullable(2)]
	private QuestReviewTabData Data;

	// Token: 0x04009803 RID: 38915
	[Nullable(2)]
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x04009804 RID: 38916
	private bool HasStartSeqPlayed;

	// Token: 0x02008CCA RID: 36042
	[NullableContext(0)]
	private class ETabComponentDefine
	{
		// Token: 0x0402DB00 RID: 187136
		public const int ToggleSelf = 0;

		// Token: 0x0402DB01 RID: 187137
		public const int TextDesc = 1;

		// Token: 0x0402DB02 RID: 187138
		public const int Spine = 2;

		// Token: 0x0402DB03 RID: 187139
		public const int SpriteLine = 3;

		// Token: 0x0402DB04 RID: 187140
		public const int ItemRedDot = 4;
	}
}

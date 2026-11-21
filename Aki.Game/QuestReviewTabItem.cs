using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001B69 RID: 7017
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class QuestReviewTabItem : GridProxyAbstract<QuestReviewTabData>
{
	// Token: 0x060117FC RID: 71676 RVA: 0x00528348 File Offset: 0x00526548
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

	// Token: 0x060117FD RID: 71677 RVA: 0x00528454 File Offset: 0x00526654
	protected override void OnStart()
	{
		this.SeqPlayer = new LevelSequencePlayer(base.GetRootItem());
		this.SeqPlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSeqEnd), false);
		EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		EventSystem.Instance.Add<int>(EEventName.OnOpenQuestReviewDetail, new Action<int>(this.RefreshRedDot));
	}

	// Token: 0x060117FE RID: 71678 RVA: 0x005284C2 File Offset: 0x005266C2
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		EventSystem.Instance.Remove(EEventName.OnOpenQuestReviewDetail, new <>f__AnonymousDelegate2<int>(this.RefreshRedDot));
	}

	// Token: 0x060117FF RID: 71679 RVA: 0x005284FC File Offset: 0x005266FC
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

	// Token: 0x06011800 RID: 71680 RVA: 0x005285FC File Offset: 0x005267FC
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

	// Token: 0x06011801 RID: 71681 RVA: 0x00528650 File Offset: 0x00526850
	private void OnTabClick(EToggleState toggleState)
	{
		QuestReviewController.Instance.TriggerViewRefresh(this.Data.Id);
	}

	// Token: 0x06011802 RID: 71682 RVA: 0x00528667 File Offset: 0x00526867
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

	// Token: 0x06011803 RID: 71683 RVA: 0x0052869A File Offset: 0x0052689A
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

	// Token: 0x06011804 RID: 71684 RVA: 0x005286C0 File Offset: 0x005268C0
	private void RefreshRedDot(int i = 0)
	{
		QuestReviewModel instance = QuestReviewModel.Instance;
		QuestReviewTabData data = this.Data;
		bool uiactive = instance.TabHasRedDot((data != null) ? data.Id : 0);
		base.GetItem(4).SetUIActive(uiactive);
	}

	// Token: 0x0400995A RID: 39258
	[Nullable(2)]
	private QuestReviewTabData Data;

	// Token: 0x0400995B RID: 39259
	[Nullable(2)]
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x0400995C RID: 39260
	private bool HasStartSeqPlayed;

	// Token: 0x02007E53 RID: 32339
	[NullableContext(0)]
	private class ETabComponentDefine
	{
		// Token: 0x04028E17 RID: 167447
		public const int ToggleSelf = 0;

		// Token: 0x04028E18 RID: 167448
		public const int TextDesc = 1;

		// Token: 0x04028E19 RID: 167449
		public const int Spine = 2;

		// Token: 0x04028E1A RID: 167450
		public const int SpriteLine = 3;

		// Token: 0x04028E1B RID: 167451
		public const int ItemRedDot = 4;
	}
}

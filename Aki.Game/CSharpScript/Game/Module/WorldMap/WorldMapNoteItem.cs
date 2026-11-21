using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020036DA RID: 14042
	public class WorldMapNoteItem : UiPanelBase
	{
		// Token: 0x0602478A RID: 149386 RVA: 0x00A4B7F5 File Offset: 0x00A499F5
		[NullableContext(1)]
		public WorldMapNoteItem(UUIItem item)
		{
			item.SetUIActive(true);
			base.CreateThenShowByActor(item.GetOwner(), null);
		}

		// Token: 0x0602478B RID: 149387 RVA: 0x00A4B814 File Offset: 0x00A49A14
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602478C RID: 149388 RVA: 0x00A4B95F File Offset: 0x00A49B5F
		protected override void OnStart()
		{
		}

		// Token: 0x0602478D RID: 149389 RVA: 0x00A4B961 File Offset: 0x00A49B61
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer sequence = this.Sequence;
			if (sequence != null)
			{
				sequence.Clear();
			}
			this.Sequence = null;
		}

		// Token: 0x0602478E RID: 149390 RVA: 0x00A4B97C File Offset: 0x00A49B7C
		[NullableContext(1)]
		public void UpdateNoteItem(int mapNoteId, Action<int> callback, int? mapMarkId = null, [Nullable(2)] string customDesc = null)
		{
			UUISprite sprite = base.GetSprite(0);
			MapNote? config = ConfigMapNoteById.GetConfig(mapNoteId, true);
			this.SetSpriteByPath(config.Value.Icon, sprite, true, null, null);
			UUIText text = base.GetText(1);
			if (customDesc != null)
			{
				text.SetText(customDesc, true);
			}
			else
			{
				text.ShowTextNew(config.Value.Desc);
			}
			int style = config.Value.Style;
			base.GetItem(3).SetUIActive(style == WorldMapNoteItem.EMapNoteStyle.Normal);
			base.GetItem(6).SetUIActive(style == WorldMapNoteItem.EMapNoteStyle.Normal);
			base.GetItem(4).SetUIActive(style == WorldMapNoteItem.EMapNoteStyle.Available);
			base.GetItem(5).SetUIActive(style == WorldMapNoteItem.EMapNoteStyle.Available);
			this.MarkId = mapMarkId.GetValueOrDefault();
			this.ClickCallback = callback;
		}

		// Token: 0x0602478F RID: 149391 RVA: 0x00A4BA5E File Offset: 0x00A49C5E
		private void OnClick()
		{
			Action<int> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.MarkId);
		}

		// Token: 0x06024790 RID: 149392 RVA: 0x00A4BA78 File Offset: 0x00A49C78
		public void PlayStartToPause()
		{
			if (this.Sequence == null)
			{
				this.Sequence = new LevelSequencePlayer(this.RootItem);
			}
			this.Sequence.PlayLevelSequenceByName("Start", false, null, false);
			this.Sequence.PauseSequence();
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(false);
		}

		// Token: 0x06024791 RID: 149393 RVA: 0x00A4BAD8 File Offset: 0x00A49CD8
		public UniTask ResumeSequence(int index)
		{
			WorldMapNoteItem.<ResumeSequence>d__12 <ResumeSequence>d__;
			<ResumeSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ResumeSequence>d__.<>4__this = this;
			<ResumeSequence>d__.index = index;
			<ResumeSequence>d__.<>1__state = -1;
			<ResumeSequence>d__.<>t__builder.Start<WorldMapNoteItem.<ResumeSequence>d__12>(ref <ResumeSequence>d__);
			return <ResumeSequence>d__.<>t__builder.Task;
		}

		// Token: 0x040144FD RID: 83197
		private int MarkId;

		// Token: 0x040144FE RID: 83198
		[Nullable(2)]
		private Action<int> ClickCallback;

		// Token: 0x040144FF RID: 83199
		[Nullable(2)]
		private LevelSequencePlayer Sequence;

		// Token: 0x020093EA RID: 37866
		public static class EChildComponents
		{
			// Token: 0x0402E42C RID: 189484
			public const int NoteIcon = 0;

			// Token: 0x0402E42D RID: 189485
			public const int NoteDesc = 1;

			// Token: 0x0402E42E RID: 189486
			public const int NoteButton = 2;

			// Token: 0x0402E42F RID: 189487
			public const int TexBg = 3;

			// Token: 0x0402E430 RID: 189488
			public const int TexReceivedBg = 4;

			// Token: 0x0402E431 RID: 189489
			public const int NiaAvailable = 5;

			// Token: 0x0402E432 RID: 189490
			public const int NiaUnAvailable = 6;
		}

		// Token: 0x020093EB RID: 37867
		public static class EMapNoteStyle
		{
			// Token: 0x0402E433 RID: 189491
			public static readonly int Normal = 0;

			// Token: 0x0402E434 RID: 189492
			public static readonly int Available = 1;
		}
	}
}

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
	// Token: 0x020047A9 RID: 18345
	public class WorldMapNoteItem : UiPanelBase
	{
		// Token: 0x0602FFBD RID: 196541 RVA: 0x00B1B859 File Offset: 0x00B19A59
		[NullableContext(1)]
		public WorldMapNoteItem(UUIItem item)
		{
			item.SetUIActive(true);
			base.CreateThenShowByActor(item.GetOwner(), null);
		}

		// Token: 0x0602FFBE RID: 196542 RVA: 0x00B1B878 File Offset: 0x00B19A78
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

		// Token: 0x0602FFBF RID: 196543 RVA: 0x00B1B9C3 File Offset: 0x00B19BC3
		protected override void OnStart()
		{
		}

		// Token: 0x0602FFC0 RID: 196544 RVA: 0x00B1B9C5 File Offset: 0x00B19BC5
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer sequence = this.Sequence;
			if (sequence != null)
			{
				sequence.Clear();
			}
			this.Sequence = null;
		}

		// Token: 0x0602FFC1 RID: 196545 RVA: 0x00B1B9E0 File Offset: 0x00B19BE0
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

		// Token: 0x0602FFC2 RID: 196546 RVA: 0x00B1BAC2 File Offset: 0x00B19CC2
		private void OnClick()
		{
			Action<int> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.MarkId);
		}

		// Token: 0x0602FFC3 RID: 196547 RVA: 0x00B1BADC File Offset: 0x00B19CDC
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

		// Token: 0x0602FFC4 RID: 196548 RVA: 0x00B1BB3C File Offset: 0x00B19D3C
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

		// Token: 0x04019E4D RID: 106061
		private int MarkId;

		// Token: 0x04019E4E RID: 106062
		[Nullable(2)]
		private Action<int> ClickCallback;

		// Token: 0x04019E4F RID: 106063
		[Nullable(2)]
		private LevelSequencePlayer Sequence;

		// Token: 0x0200AA37 RID: 43575
		public static class EChildComponents
		{
			// Token: 0x04033CA0 RID: 212128
			public const int NoteIcon = 0;

			// Token: 0x04033CA1 RID: 212129
			public const int NoteDesc = 1;

			// Token: 0x04033CA2 RID: 212130
			public const int NoteButton = 2;

			// Token: 0x04033CA3 RID: 212131
			public const int TexBg = 3;

			// Token: 0x04033CA4 RID: 212132
			public const int TexReceivedBg = 4;

			// Token: 0x04033CA5 RID: 212133
			public const int NiaAvailable = 5;

			// Token: 0x04033CA6 RID: 212134
			public const int NiaUnAvailable = 6;
		}

		// Token: 0x0200AA38 RID: 43576
		public static class EMapNoteStyle
		{
			// Token: 0x04033CA7 RID: 212135
			public static readonly int Normal = 0;

			// Token: 0x04033CA8 RID: 212136
			public static readonly int Available = 1;
		}
	}
}

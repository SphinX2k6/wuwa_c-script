using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059A8 RID: 22952
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolShopButtonItem : UiPanelBase
	{
		// Token: 0x06038960 RID: 231776 RVA: 0x00FD5294 File Offset: 0x00FD3494
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038961 RID: 231777 RVA: 0x00FD52DC File Offset: 0x00FD34DC
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			UUIButtonComponent rootButton = this.GetRootButton();
			if (rootButton == null)
			{
				return;
			}
			rootButton.OnClickCallBack.Bind(new Action(this.OnClick));
		}

		// Token: 0x06038962 RID: 231778 RVA: 0x00FD5310 File Offset: 0x00FD3510
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
			UUIButtonComponent rootButton = this.GetRootButton();
			if (rootButton != null)
			{
				rootButton.OnClickCallBack.Unbind();
			}
			this.ClickCallback = null;
		}

		// Token: 0x06038963 RID: 231779 RVA: 0x00FD5348 File Offset: 0x00FD3548
		public void PlayShow()
		{
			if (base.GetActive())
			{
				return;
			}
			base.SetUiActive(true);
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
		}

		// Token: 0x06038964 RID: 231780 RVA: 0x00FD5384 File Offset: 0x00FD3584
		[NullableContext(1)]
		public void SetClickCallback(Action callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x06038965 RID: 231781 RVA: 0x00FD538D File Offset: 0x00FD358D
		[NullableContext(1)]
		public void SetTipsText(string textId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, Array.Empty<object>());
		}

		// Token: 0x06038966 RID: 231782 RVA: 0x00FD53A6 File Offset: 0x00FD35A6
		private UUIButtonComponent GetRootButton()
		{
			AActor rootActor = base.GetRootActor();
			return ((rootActor != null) ? rootActor.GetComponentByClass(UUIButtonComponent.StaticClass()) : null) as UUIButtonComponent;
		}

		// Token: 0x06038967 RID: 231783 RVA: 0x00FD53C9 File Offset: 0x00FD35C9
		private void OnClick()
		{
			Action clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback();
		}

		// Token: 0x0401DCE1 RID: 122081
		private Action ClickCallback;

		// Token: 0x0401DCE2 RID: 122082
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0200B553 RID: 46419
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040380FF RID: 229631
			public const int TxtTips = 0;
		}
	}
}

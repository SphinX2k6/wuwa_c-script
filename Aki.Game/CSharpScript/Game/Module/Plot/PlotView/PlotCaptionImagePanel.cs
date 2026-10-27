using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x0200504C RID: 20556
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotCaptionImagePanel : UiPanelBase
	{
		// Token: 0x060349C0 RID: 215488 RVA: 0x00C6D93B File Offset: 0x00C6BB3B
		protected override void OnRegisterComponent()
		{
		}

		// Token: 0x060349C1 RID: 215489 RVA: 0x00C6D940 File Offset: 0x00C6BB40
		protected override void OnStart()
		{
			if (this.RootItem != null)
			{
				this.SequencePlayers.Add(new UiSequencePlayer(this.RootItem));
			}
			UUIItem uuiitem = this.GetLangPrefabRootItem(this.RootActor) ?? this.GetLangPrefabRootItem(base.GetOriginalActor());
			if (uuiitem != null)
			{
				this.SequencePlayers.Add(new UiSequencePlayer(uuiitem));
			}
		}

		// Token: 0x060349C2 RID: 215490 RVA: 0x00C6D99C File Offset: 0x00C6BB9C
		protected override void OnBeforeDestroy()
		{
			foreach (UiSequencePlayer uiSequencePlayer in this.SequencePlayers)
			{
				uiSequencePlayer.Clear();
			}
			this.SequencePlayers.Clear();
		}

		// Token: 0x060349C3 RID: 215491 RVA: 0x00C6D9F8 File Offset: 0x00C6BBF8
		public UniTask PlaySequenceAsync(string sequenceName)
		{
			PlotCaptionImagePanel.<PlaySequenceAsync>d__4 <PlaySequenceAsync>d__;
			<PlaySequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySequenceAsync>d__.<>4__this = this;
			<PlaySequenceAsync>d__.sequenceName = sequenceName;
			<PlaySequenceAsync>d__.<>1__state = -1;
			<PlaySequenceAsync>d__.<>t__builder.Start<PlotCaptionImagePanel.<PlaySequenceAsync>d__4>(ref <PlaySequenceAsync>d__);
			return <PlaySequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060349C4 RID: 215492 RVA: 0x00C6DA43 File Offset: 0x00C6BC43
		private UUIItem GetLangPrefabRootItem(AActor actor)
		{
			UUILangToPrefabComp uuilangToPrefabComp = ((actor != null) ? actor.GetComponentByClass(UUILangToPrefabComp.StaticClass()) : null) as UUILangToPrefabComp;
			if (uuilangToPrefabComp == null)
			{
				return null;
			}
			return uuilangToPrefabComp.GetRootItem();
		}

		// Token: 0x0401C09D RID: 114845
		[Nullable(1)]
		private readonly List<UiSequencePlayer> SequencePlayers = new List<UiSequencePlayer>();
	}
}

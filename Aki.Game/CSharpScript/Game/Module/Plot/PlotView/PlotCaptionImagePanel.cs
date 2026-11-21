using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x0200401B RID: 16411
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotCaptionImagePanel : UiPanelBase
	{
		// Token: 0x060298A2 RID: 170146 RVA: 0x00BBAAAF File Offset: 0x00BB8CAF
		protected override void OnRegisterComponent()
		{
		}

		// Token: 0x060298A3 RID: 170147 RVA: 0x00BBAAB4 File Offset: 0x00BB8CB4
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

		// Token: 0x060298A4 RID: 170148 RVA: 0x00BBAB10 File Offset: 0x00BB8D10
		protected override void OnBeforeDestroy()
		{
			foreach (UiSequencePlayer uiSequencePlayer in this.SequencePlayers)
			{
				uiSequencePlayer.Clear();
			}
			this.SequencePlayers.Clear();
		}

		// Token: 0x060298A5 RID: 170149 RVA: 0x00BBAB6C File Offset: 0x00BB8D6C
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

		// Token: 0x060298A6 RID: 170150 RVA: 0x00BBABB7 File Offset: 0x00BB8DB7
		private UUIItem GetLangPrefabRootItem(AActor actor)
		{
			UUILangToPrefabComp uuilangToPrefabComp = ((actor != null) ? actor.GetComponentByClass(UUILangToPrefabComp.StaticClass()) : null) as UUILangToPrefabComp;
			if (uuilangToPrefabComp == null)
			{
				return null;
			}
			return uuilangToPrefabComp.GetRootItem();
		}

		// Token: 0x04016AC0 RID: 92864
		[Nullable(1)]
		private readonly List<UiSequencePlayer> SequencePlayers = new List<UiSequencePlayer>();
	}
}

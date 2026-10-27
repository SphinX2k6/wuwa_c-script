using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotSceneView
{
	// Token: 0x02005076 RID: 20598
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotSceneArtWordView : SceneUiView
	{
		// Token: 0x06034C45 RID: 216133 RVA: 0x00C7C4C0 File Offset: 0x00C7A6C0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034C46 RID: 216134 RVA: 0x00C7C58C File Offset: 0x00C7A78C
		protected override UniTask OnBeforeShowAsyncImplementImplement()
		{
			PlotSceneArtWordView.<OnBeforeShowAsyncImplementImplement>d__10 <OnBeforeShowAsyncImplementImplement>d__;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<PlotSceneArtWordView.<OnBeforeShowAsyncImplementImplement>d__10>(ref <OnBeforeShowAsyncImplementImplement>d__);
			return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06034C47 RID: 216135 RVA: 0x00C7C5D0 File Offset: 0x00C7A7D0
		protected override void OnBeforeShow()
		{
			AActor rootActor = base.GetRootActor();
			UUILangToPrefabComp uuilangToPrefabComp = ((rootActor != null) ? rootActor.GetComponentByClass(UUILangToPrefabComp.StaticClass()) : null) as UUILangToPrefabComp;
			UUIItem uuiitem = (uuilangToPrefabComp != null) ? uuilangToPrefabComp.GetRootItem() : null;
			if (uuiitem == null)
			{
				return;
			}
			this.TextSequencePlayer = new LevelSequencePlayer(uuiitem);
			if (this.Config != null && !string.IsNullOrEmpty(this.Config.Value.Audio))
			{
				AudioSystem.Instance.PostEvent(this.Config.Value.Audio);
			}
		}

		// Token: 0x06034C48 RID: 216136 RVA: 0x00C7C660 File Offset: 0x00C7A860
		protected override void OnAfterShow()
		{
			UUIItem uuiitem = this.MultiLine ? base.GetItem(2) : base.GetItem(1);
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(true);
			}
			LevelSequencePlayer textSequencePlayer = this.TextSequencePlayer;
			if (textSequencePlayer == null)
			{
				return;
			}
			textSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x06034C49 RID: 216137 RVA: 0x00C7C6B4 File Offset: 0x00C7A8B4
		protected override UniTask OnBeforeHideAsync()
		{
			PlotSceneArtWordView.<OnBeforeHideAsync>d__13 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<PlotSceneArtWordView.<OnBeforeHideAsync>d__13>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034C4A RID: 216138 RVA: 0x00C7C6F8 File Offset: 0x00C7A8F8
		protected override void OnBeforeDestroy()
		{
			this.SpaceMarkWatcher.Stop();
			foreach (PlotSceneArtWordTextPanel plotSceneArtWordTextPanel in this.LinePanels)
			{
				plotSceneArtWordTextPanel.Destroy(null);
			}
			this.LinePanels.Clear();
			LevelSequencePlayer textSequencePlayer = this.TextSequencePlayer;
			if (textSequencePlayer != null)
			{
				textSequencePlayer.Clear();
			}
			this.TextSequencePlayer = null;
		}

		// Token: 0x06034C4B RID: 216139 RVA: 0x00C7C778 File Offset: 0x00C7A978
		private UniTask InitText()
		{
			PlotSceneArtWordView.<InitText>d__15 <InitText>d__;
			<InitText>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitText>d__.<>4__this = this;
			<InitText>d__.<>1__state = -1;
			<InitText>d__.<>t__builder.Start<PlotSceneArtWordView.<InitText>d__15>(ref <InitText>d__);
			return <InitText>d__.<>t__builder.Task;
		}

		// Token: 0x06034C4C RID: 216140 RVA: 0x00C7C7BC File Offset: 0x00C7A9BC
		[NullableContext(2)]
		private void ScaleTemplateWidth(UUIItem template, ref float? baseWidth, float scale)
		{
			if (template == null)
			{
				return;
			}
			float value = baseWidth.GetValueOrDefault();
			if (baseWidth == null)
			{
				value = template.GetWidth();
				baseWidth = new float?(value);
			}
			template.SetWidth(baseWidth.Value * scale);
		}

		// Token: 0x06034C4D RID: 216141 RVA: 0x00C7C800 File Offset: 0x00C7AA00
		private void ApplyLayoutSpacing(UUIItem layout, float scale)
		{
			AActor owner = layout.GetOwner();
			UUIHorizontalLayout uuihorizontalLayout = ((owner != null) ? owner.GetComponentByClass(UUIHorizontalLayout.StaticClass()) : null) as UUIHorizontalLayout;
			if (uuihorizontalLayout == null)
			{
				Log.Instance.Warn(ELogModule.Scene3dUi, ELogAuthor.HYF, "[PlotSceneArtWordView]PnlLayout上找不到UIHorizontalLayout, 间距不缩放", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			float value = this.BaseLayoutSpacing.GetValueOrDefault();
			if (this.BaseLayoutSpacing == null)
			{
				value = uuihorizontalLayout.GetSpacing();
				this.BaseLayoutSpacing = new float?(value);
			}
			uuihorizontalLayout.SetSpacing(this.BaseLayoutSpacing.Value * scale);
		}

		// Token: 0x06034C4E RID: 216142 RVA: 0x00C7C894 File Offset: 0x00C7AA94
		private UniTask ClearLinePanelsAsync()
		{
			PlotSceneArtWordView.<ClearLinePanelsAsync>d__18 <ClearLinePanelsAsync>d__;
			<ClearLinePanelsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ClearLinePanelsAsync>d__.<>4__this = this;
			<ClearLinePanelsAsync>d__.<>1__state = -1;
			<ClearLinePanelsAsync>d__.<>t__builder.Start<PlotSceneArtWordView.<ClearLinePanelsAsync>d__18>(ref <ClearLinePanelsAsync>d__);
			return <ClearLinePanelsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401C1E2 RID: 115170
		[Nullable(2)]
		private LevelSequencePlayer TextSequencePlayer;

		// Token: 0x0401C1E3 RID: 115171
		private readonly List<PlotSceneArtWordTextPanel> LinePanels = new List<PlotSceneArtWordTextPanel>();

		// Token: 0x0401C1E4 RID: 115172
		private bool MultiLine;

		// Token: 0x0401C1E5 RID: 115173
		private FloatingSubtitle3D? Config;

		// Token: 0x0401C1E6 RID: 115174
		private float? BaseLayoutSpacing;

		// Token: 0x0401C1E7 RID: 115175
		private float? BaseTemplateWidthA;

		// Token: 0x0401C1E8 RID: 115176
		private float? BaseTemplateWidthB;

		// Token: 0x0401C1E9 RID: 115177
		private readonly FloatingSubtitleSpaceMarkWatcher SpaceMarkWatcher = new FloatingSubtitleSpaceMarkWatcher();

		// Token: 0x0200B213 RID: 45587
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04035FDB RID: 221147
			TxtName,
			// Token: 0x04035FDC RID: 221148
			PnlName,
			// Token: 0x04035FDD RID: 221149
			PnlLayout,
			// Token: 0x04035FDE RID: 221150
			PnlNameA,
			// Token: 0x04035FDF RID: 221151
			PnlNameB
		}
	}
}

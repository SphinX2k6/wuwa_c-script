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
	// Token: 0x02004046 RID: 16454
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotSceneArtWordView : SceneUiView
	{
		// Token: 0x06029B3A RID: 170810 RVA: 0x00BC9898 File Offset: 0x00BC7A98
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

		// Token: 0x06029B3B RID: 170811 RVA: 0x00BC9964 File Offset: 0x00BC7B64
		protected override UniTask OnBeforeShowAsyncImplementImplement()
		{
			PlotSceneArtWordView.<OnBeforeShowAsyncImplementImplement>d__10 <OnBeforeShowAsyncImplementImplement>d__;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<PlotSceneArtWordView.<OnBeforeShowAsyncImplementImplement>d__10>(ref <OnBeforeShowAsyncImplementImplement>d__);
			return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06029B3C RID: 170812 RVA: 0x00BC99A8 File Offset: 0x00BC7BA8
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

		// Token: 0x06029B3D RID: 170813 RVA: 0x00BC9A38 File Offset: 0x00BC7C38
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

		// Token: 0x06029B3E RID: 170814 RVA: 0x00BC9A8C File Offset: 0x00BC7C8C
		protected override UniTask OnBeforeHideAsync()
		{
			PlotSceneArtWordView.<OnBeforeHideAsync>d__13 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<PlotSceneArtWordView.<OnBeforeHideAsync>d__13>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029B3F RID: 170815 RVA: 0x00BC9AD0 File Offset: 0x00BC7CD0
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

		// Token: 0x06029B40 RID: 170816 RVA: 0x00BC9B50 File Offset: 0x00BC7D50
		private UniTask InitText()
		{
			PlotSceneArtWordView.<InitText>d__15 <InitText>d__;
			<InitText>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitText>d__.<>4__this = this;
			<InitText>d__.<>1__state = -1;
			<InitText>d__.<>t__builder.Start<PlotSceneArtWordView.<InitText>d__15>(ref <InitText>d__);
			return <InitText>d__.<>t__builder.Task;
		}

		// Token: 0x06029B41 RID: 170817 RVA: 0x00BC9B94 File Offset: 0x00BC7D94
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

		// Token: 0x06029B42 RID: 170818 RVA: 0x00BC9BD8 File Offset: 0x00BC7DD8
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

		// Token: 0x06029B43 RID: 170819 RVA: 0x00BC9C6C File Offset: 0x00BC7E6C
		private UniTask ClearLinePanelsAsync()
		{
			PlotSceneArtWordView.<ClearLinePanelsAsync>d__18 <ClearLinePanelsAsync>d__;
			<ClearLinePanelsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ClearLinePanelsAsync>d__.<>4__this = this;
			<ClearLinePanelsAsync>d__.<>1__state = -1;
			<ClearLinePanelsAsync>d__.<>t__builder.Start<PlotSceneArtWordView.<ClearLinePanelsAsync>d__18>(ref <ClearLinePanelsAsync>d__);
			return <ClearLinePanelsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04016C0D RID: 93197
		[Nullable(2)]
		private LevelSequencePlayer TextSequencePlayer;

		// Token: 0x04016C0E RID: 93198
		private readonly List<PlotSceneArtWordTextPanel> LinePanels = new List<PlotSceneArtWordTextPanel>();

		// Token: 0x04016C0F RID: 93199
		private bool MultiLine;

		// Token: 0x04016C10 RID: 93200
		private FloatingSubtitle3D? Config;

		// Token: 0x04016C11 RID: 93201
		private float? BaseLayoutSpacing;

		// Token: 0x04016C12 RID: 93202
		private float? BaseTemplateWidthA;

		// Token: 0x04016C13 RID: 93203
		private float? BaseTemplateWidthB;

		// Token: 0x04016C14 RID: 93204
		private readonly FloatingSubtitleSpaceMarkWatcher SpaceMarkWatcher = new FloatingSubtitleSpaceMarkWatcher();

		// Token: 0x02009C4C RID: 40012
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04030A2F RID: 199215
			TxtName,
			// Token: 0x04030A30 RID: 199216
			PnlName,
			// Token: 0x04030A31 RID: 199217
			PnlLayout,
			// Token: 0x04030A32 RID: 199218
			PnlNameA,
			// Token: 0x04030A33 RID: 199219
			PnlNameB
		}
	}
}

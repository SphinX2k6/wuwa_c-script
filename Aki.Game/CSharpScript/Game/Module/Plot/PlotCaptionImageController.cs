using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot.PlotView;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02004FDD RID: 20445
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class PlotCaptionImageController : ControllerBase
	{
		// Token: 0x0603451B RID: 214299 RVA: 0x00C49D64 File Offset: 0x00C47F64
		public UniTask OpenAsync(string uiPrefabId, float duration, [Nullable(2)] IUiAnimConfig uiAnimConfig)
		{
			PlotCaptionImageController.<OpenAsync>d__2 <OpenAsync>d__;
			<OpenAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenAsync>d__.<>4__this = this;
			<OpenAsync>d__.uiPrefabId = uiPrefabId;
			<OpenAsync>d__.duration = duration;
			<OpenAsync>d__.uiAnimConfig = uiAnimConfig;
			<OpenAsync>d__.<>1__state = -1;
			<OpenAsync>d__.<>t__builder.Start<PlotCaptionImageController.<OpenAsync>d__2>(ref <OpenAsync>d__);
			return <OpenAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603451C RID: 214300 RVA: 0x00C49DC0 File Offset: 0x00C47FC0
		[NullableContext(2)]
		private UniTask WaitCloseAsync(float duration, IUiAnimConfig uiAnimConfig)
		{
			PlotCaptionImageController.<WaitCloseAsync>d__3 <WaitCloseAsync>d__;
			<WaitCloseAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitCloseAsync>d__.<>4__this = this;
			<WaitCloseAsync>d__.duration = duration;
			<WaitCloseAsync>d__.uiAnimConfig = uiAnimConfig;
			<WaitCloseAsync>d__.<>1__state = -1;
			<WaitCloseAsync>d__.<>t__builder.Start<PlotCaptionImageController.<WaitCloseAsync>d__3>(ref <WaitCloseAsync>d__);
			return <WaitCloseAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603451D RID: 214301 RVA: 0x00C49E14 File Offset: 0x00C48014
		private UniTask WaitDurationAsync(float duration)
		{
			PlotCaptionImageController.<WaitDurationAsync>d__4 <WaitDurationAsync>d__;
			<WaitDurationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitDurationAsync>d__.duration = duration;
			<WaitDurationAsync>d__.<>1__state = -1;
			<WaitDurationAsync>d__.<>t__builder.Start<PlotCaptionImageController.<WaitDurationAsync>d__4>(ref <WaitDurationAsync>d__);
			return <WaitDurationAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603451E RID: 214302 RVA: 0x00C49E57 File Offset: 0x00C48057
		private void DestroyPanel()
		{
			if (this.CurrentPanel != null)
			{
				this.CurrentPanel.Destroy(null);
				this.CurrentPanel = null;
				EventSystem.Instance.Emit<EUiViewName>(EEventName.ClosePlotCaptionImageView, EUiViewName.PlotCaptionImageView);
			}
			this.IsInPlotCaption = false;
		}

		// Token: 0x0603451F RID: 214303 RVA: 0x00C49E90 File Offset: 0x00C48090
		protected override bool OnClear()
		{
			this.DestroyPanel();
			return true;
		}

		// Token: 0x17007FC1 RID: 32705
		// (get) Token: 0x06034520 RID: 214304 RVA: 0x00C49E99 File Offset: 0x00C48099
		public static PlotCaptionImageController Instance
		{
			get
			{
				return PlotCaptionImageController._Instance;
			}
		}

		// Token: 0x06034521 RID: 214305 RVA: 0x00C49EA0 File Offset: 0x00C480A0
		public static PlotCaptionImageController GetOrCreateInstance()
		{
			if (PlotCaptionImageController._Instance == null)
			{
				PlotCaptionImageController.CreateInstance();
			}
			return PlotCaptionImageController._Instance;
		}

		// Token: 0x06034522 RID: 214306 RVA: 0x00C49EB4 File Offset: 0x00C480B4
		public static bool CreateInstance()
		{
			if (PlotCaptionImageController._Instance != null)
			{
				return true;
			}
			PlotCaptionImageController._Instance = new PlotCaptionImageController();
			return true;
		}

		// Token: 0x06034523 RID: 214307 RVA: 0x00C49ECA File Offset: 0x00C480CA
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06034524 RID: 214308 RVA: 0x00C49ECC File Offset: 0x00C480CC
		public static void ResetStaticDefaultValue()
		{
			PlotCaptionImageController._Instance = null;
		}

		// Token: 0x06034525 RID: 214309 RVA: 0x00C49ED4 File Offset: 0x00C480D4
		static PlotCaptionImageController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PlotCaptionImageController.CreateStaticDefaultValue), new Action(PlotCaptionImageController.ResetStaticDefaultValue));
		}

		// Token: 0x0401BD2A RID: 113962
		[Nullable(2)]
		private PlotCaptionImagePanel CurrentPanel;

		// Token: 0x0401BD2B RID: 113963
		public bool IsInPlotCaption;

		// Token: 0x0401BD2C RID: 113964
		[Nullable(2)]
		private static PlotCaptionImageController _Instance;
	}
}

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
	// Token: 0x02003FA7 RID: 16295
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class PlotCaptionImageController : ControllerBase
	{
		// Token: 0x060293A4 RID: 168868 RVA: 0x00B93DAC File Offset: 0x00B91FAC
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

		// Token: 0x060293A5 RID: 168869 RVA: 0x00B93E08 File Offset: 0x00B92008
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

		// Token: 0x060293A6 RID: 168870 RVA: 0x00B93E5C File Offset: 0x00B9205C
		private UniTask WaitDurationAsync(float duration)
		{
			PlotCaptionImageController.<WaitDurationAsync>d__4 <WaitDurationAsync>d__;
			<WaitDurationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitDurationAsync>d__.duration = duration;
			<WaitDurationAsync>d__.<>1__state = -1;
			<WaitDurationAsync>d__.<>t__builder.Start<PlotCaptionImageController.<WaitDurationAsync>d__4>(ref <WaitDurationAsync>d__);
			return <WaitDurationAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060293A7 RID: 168871 RVA: 0x00B93E9F File Offset: 0x00B9209F
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

		// Token: 0x060293A8 RID: 168872 RVA: 0x00B93ED8 File Offset: 0x00B920D8
		protected override bool OnClear()
		{
			this.DestroyPanel();
			return true;
		}

		// Token: 0x17005375 RID: 21365
		// (get) Token: 0x060293A9 RID: 168873 RVA: 0x00B93EE1 File Offset: 0x00B920E1
		public static PlotCaptionImageController Instance
		{
			get
			{
				return PlotCaptionImageController._Instance;
			}
		}

		// Token: 0x060293AA RID: 168874 RVA: 0x00B93EE8 File Offset: 0x00B920E8
		public static PlotCaptionImageController GetOrCreateInstance()
		{
			if (PlotCaptionImageController._Instance == null)
			{
				PlotCaptionImageController.CreateInstance();
			}
			return PlotCaptionImageController._Instance;
		}

		// Token: 0x060293AB RID: 168875 RVA: 0x00B93EFC File Offset: 0x00B920FC
		public static bool CreateInstance()
		{
			if (PlotCaptionImageController._Instance != null)
			{
				return true;
			}
			PlotCaptionImageController._Instance = new PlotCaptionImageController();
			return true;
		}

		// Token: 0x060293AC RID: 168876 RVA: 0x00B93F12 File Offset: 0x00B92112
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060293AD RID: 168877 RVA: 0x00B93F14 File Offset: 0x00B92114
		public static void ResetStaticDefaultValue()
		{
			PlotCaptionImageController._Instance = null;
		}

		// Token: 0x060293AE RID: 168878 RVA: 0x00B93F1C File Offset: 0x00B9211C
		static PlotCaptionImageController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PlotCaptionImageController.CreateStaticDefaultValue), new Action(PlotCaptionImageController.ResetStaticDefaultValue));
		}

		// Token: 0x04016705 RID: 91909
		[Nullable(2)]
		private PlotCaptionImagePanel CurrentPanel;

		// Token: 0x04016706 RID: 91910
		public bool IsInPlotCaption;

		// Token: 0x04016707 RID: 91911
		[Nullable(2)]
		private static PlotCaptionImageController _Instance;
	}
}

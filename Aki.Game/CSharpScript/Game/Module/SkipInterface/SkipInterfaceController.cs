using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.SkipInterface
{
	// Token: 0x02004BA1 RID: 19361
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class SkipInterfaceController : ControllerBase
	{
		// Token: 0x060322A0 RID: 205472 RVA: 0x00BA7CBD File Offset: 0x00BA5EBD
		protected override bool OnInit()
		{
			this.AddEvents();
			return true;
		}

		// Token: 0x060322A1 RID: 205473 RVA: 0x00BA7CC6 File Offset: 0x00BA5EC6
		protected override bool OnClear()
		{
			this.RemoveEvents();
			SkipTaskManager.Clear();
			return true;
		}

		// Token: 0x060322A2 RID: 205474 RVA: 0x00BA7CD4 File Offset: 0x00BA5ED4
		private void AddEvents()
		{
			EventSystem.Instance.Add<EUiViewName>(EEventName.OpenViewBegined, this.OnPreOpenView);
			EventSystem.Instance.Add(EEventName.EnterGameSuccess, new Action(this.EnterGameSuccess));
		}

		// Token: 0x060322A3 RID: 205475 RVA: 0x00BA7D02 File Offset: 0x00BA5F02
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove<EUiViewName>(EEventName.OpenViewBegined, this.OnPreOpenView);
			EventSystem.Instance.Remove(EEventName.EnterGameSuccess, new Action(this.EnterGameSuccess));
		}

		// Token: 0x060322A4 RID: 205476 RVA: 0x00BA7D30 File Offset: 0x00BA5F30
		private void EnterGameSuccess()
		{
			this.RequestAccessPathConfig();
		}

		// Token: 0x060322A5 RID: 205477 RVA: 0x00BA7D3C File Offset: 0x00BA5F3C
		private UniTask RequestAccessPathConfig()
		{
			SkipInterfaceController.<RequestAccessPathConfig>d__6 <RequestAccessPathConfig>d__;
			<RequestAccessPathConfig>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestAccessPathConfig>d__.<>1__state = -1;
			<RequestAccessPathConfig>d__.<>t__builder.Start<SkipInterfaceController.<RequestAccessPathConfig>d__6>(ref <RequestAccessPathConfig>d__);
			return <RequestAccessPathConfig>d__.<>t__builder.Task;
		}

		// Token: 0x17007C4C RID: 31820
		// (get) Token: 0x060322A6 RID: 205478 RVA: 0x00BA7D77 File Offset: 0x00BA5F77
		public static SkipInterfaceController Instance
		{
			get
			{
				return SkipInterfaceController._Instance;
			}
		}

		// Token: 0x060322A7 RID: 205479 RVA: 0x00BA7D7E File Offset: 0x00BA5F7E
		public static SkipInterfaceController GetOrCreateInstance()
		{
			if (SkipInterfaceController._Instance == null)
			{
				SkipInterfaceController.CreateInstance();
			}
			return SkipInterfaceController._Instance;
		}

		// Token: 0x060322A8 RID: 205480 RVA: 0x00BA7D92 File Offset: 0x00BA5F92
		public static bool CreateInstance()
		{
			if (SkipInterfaceController._Instance != null)
			{
				return true;
			}
			SkipInterfaceController._Instance = new SkipInterfaceController();
			return true;
		}

		// Token: 0x060322A9 RID: 205481 RVA: 0x00BA7DA8 File Offset: 0x00BA5FA8
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060322AA RID: 205482 RVA: 0x00BA7DAA File Offset: 0x00BA5FAA
		public static void ResetStaticDefaultValue()
		{
			SkipInterfaceController._Instance = null;
		}

		// Token: 0x060322AB RID: 205483 RVA: 0x00BA7DB2 File Offset: 0x00BA5FB2
		static SkipInterfaceController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SkipInterfaceController.CreateStaticDefaultValue), new Action(SkipInterfaceController.ResetStaticDefaultValue));
		}

		// Token: 0x060322AC RID: 205484 RVA: 0x00BA7DD1 File Offset: 0x00BA5FD1
		public SkipInterfaceController()
		{
			Action<EUiViewName> onPreOpenView;
			if ((onPreOpenView = SkipInterfaceController.<>O.<0>__CheckContainRingView) == null)
			{
				onPreOpenView = (SkipInterfaceController.<>O.<0>__CheckContainRingView = new Action<EUiViewName>(SkipTaskManager.CheckContainRingView));
			}
			this.OnPreOpenView = onPreOpenView;
			base..ctor();
		}

		// Token: 0x0401AB7A RID: 109434
		private readonly Action<EUiViewName> OnPreOpenView;

		// Token: 0x0401AB7B RID: 109435
		[Nullable(2)]
		private static SkipInterfaceController _Instance;

		// Token: 0x0200ADCA RID: 44490
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04034C8F RID: 216207
			[Nullable(0)]
			public static Action<EUiViewName> <0>__CheckContainRingView;
		}
	}
}

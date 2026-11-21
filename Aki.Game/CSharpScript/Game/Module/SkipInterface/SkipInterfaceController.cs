using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.SkipInterface
{
	// Token: 0x02003B4B RID: 15179
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class SkipInterfaceController : ControllerBase
	{
		// Token: 0x06027030 RID: 159792 RVA: 0x00AEBE09 File Offset: 0x00AEA009
		protected override bool OnInit()
		{
			this.AddEvents();
			return true;
		}

		// Token: 0x06027031 RID: 159793 RVA: 0x00AEBE12 File Offset: 0x00AEA012
		protected override bool OnClear()
		{
			this.RemoveEvents();
			SkipTaskManager.Clear();
			return true;
		}

		// Token: 0x06027032 RID: 159794 RVA: 0x00AEBE20 File Offset: 0x00AEA020
		private void AddEvents()
		{
			EventSystem.Instance.Add<EUiViewName>(EEventName.OpenViewBegined, this.OnPreOpenView);
			EventSystem.Instance.Add(EEventName.EnterGameSuccess, new Action(this.EnterGameSuccess));
		}

		// Token: 0x06027033 RID: 159795 RVA: 0x00AEBE4E File Offset: 0x00AEA04E
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove<EUiViewName>(EEventName.OpenViewBegined, this.OnPreOpenView);
			EventSystem.Instance.Remove(EEventName.EnterGameSuccess, new Action(this.EnterGameSuccess));
		}

		// Token: 0x06027034 RID: 159796 RVA: 0x00AEBE7C File Offset: 0x00AEA07C
		private void EnterGameSuccess()
		{
			this.RequestAccessPathConfig();
		}

		// Token: 0x06027035 RID: 159797 RVA: 0x00AEBE88 File Offset: 0x00AEA088
		private UniTask RequestAccessPathConfig()
		{
			SkipInterfaceController.<RequestAccessPathConfig>d__6 <RequestAccessPathConfig>d__;
			<RequestAccessPathConfig>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestAccessPathConfig>d__.<>1__state = -1;
			<RequestAccessPathConfig>d__.<>t__builder.Start<SkipInterfaceController.<RequestAccessPathConfig>d__6>(ref <RequestAccessPathConfig>d__);
			return <RequestAccessPathConfig>d__.<>t__builder.Task;
		}

		// Token: 0x17004FF6 RID: 20470
		// (get) Token: 0x06027036 RID: 159798 RVA: 0x00AEBEC3 File Offset: 0x00AEA0C3
		public static SkipInterfaceController Instance
		{
			get
			{
				return SkipInterfaceController._Instance;
			}
		}

		// Token: 0x06027037 RID: 159799 RVA: 0x00AEBECA File Offset: 0x00AEA0CA
		public static SkipInterfaceController GetOrCreateInstance()
		{
			if (SkipInterfaceController._Instance == null)
			{
				SkipInterfaceController.CreateInstance();
			}
			return SkipInterfaceController._Instance;
		}

		// Token: 0x06027038 RID: 159800 RVA: 0x00AEBEDE File Offset: 0x00AEA0DE
		public static bool CreateInstance()
		{
			if (SkipInterfaceController._Instance != null)
			{
				return true;
			}
			SkipInterfaceController._Instance = new SkipInterfaceController();
			return true;
		}

		// Token: 0x06027039 RID: 159801 RVA: 0x00AEBEF4 File Offset: 0x00AEA0F4
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602703A RID: 159802 RVA: 0x00AEBEF6 File Offset: 0x00AEA0F6
		public static void ResetStaticDefaultValue()
		{
			SkipInterfaceController._Instance = null;
		}

		// Token: 0x0602703B RID: 159803 RVA: 0x00AEBEFE File Offset: 0x00AEA0FE
		static SkipInterfaceController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SkipInterfaceController.CreateStaticDefaultValue), new Action(SkipInterfaceController.ResetStaticDefaultValue));
		}

		// Token: 0x0602703C RID: 159804 RVA: 0x00AEBF1D File Offset: 0x00AEA11D
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

		// Token: 0x040154CE RID: 87246
		private readonly Action<EUiViewName> OnPreOpenView;

		// Token: 0x040154CF RID: 87247
		[Nullable(2)]
		private static SkipInterfaceController _Instance;

		// Token: 0x020097E9 RID: 38889
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402F636 RID: 194102
			[Nullable(0)]
			public static Action<EUiViewName> <0>__CheckContainRingView;
		}
	}
}

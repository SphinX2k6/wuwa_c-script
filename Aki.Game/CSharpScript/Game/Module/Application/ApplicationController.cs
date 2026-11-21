using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Application
{
	// Token: 0x02004E92 RID: 20114
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ApplicationController : ControllerBase
	{
		// Token: 0x06032A35 RID: 207413 RVA: 0x00E35BC2 File Offset: 0x00E33DC2
		protected override bool OnInit()
		{
			Application.Instance.AddApplicationHandler(EApplicationLifetimeDelegate.ApplicationWillEnterBackgroundDelegate, new Action(this.ApplicationWillEnterBackground));
			Application.Instance.AddApplicationHandler(EApplicationLifetimeDelegate.ApplicationHasReactivatedDelegate, new Action(this.ApplicationHasReactivated));
			return true;
		}

		// Token: 0x06032A36 RID: 207414 RVA: 0x00E35BF3 File Offset: 0x00E33DF3
		protected override bool OnClear()
		{
			Application.Instance.RemoveApplicationHandler(EApplicationLifetimeDelegate.ApplicationWillEnterBackgroundDelegate, new Action(this.ApplicationWillEnterBackground));
			Application.Instance.RemoveApplicationHandler(EApplicationLifetimeDelegate.ApplicationHasReactivatedDelegate, new Action(this.ApplicationHasReactivated));
			return true;
		}

		// Token: 0x06032A37 RID: 207415 RVA: 0x00E35C24 File Offset: 0x00E33E24
		private void ApplicationWillEnterBackground()
		{
		}

		// Token: 0x06032A38 RID: 207416 RVA: 0x00E35C26 File Offset: 0x00E33E26
		private void ApplicationHasReactivated()
		{
		}

		// Token: 0x17006281 RID: 25217
		// (get) Token: 0x06032A39 RID: 207417 RVA: 0x00E35C28 File Offset: 0x00E33E28
		public static ApplicationController Instance
		{
			get
			{
				return ApplicationController._Instance;
			}
		}

		// Token: 0x06032A3A RID: 207418 RVA: 0x00E35C2F File Offset: 0x00E33E2F
		public static ApplicationController GetOrCreateInstance()
		{
			if (ApplicationController._Instance == null)
			{
				ApplicationController.CreateInstance();
			}
			return ApplicationController._Instance;
		}

		// Token: 0x06032A3B RID: 207419 RVA: 0x00E35C43 File Offset: 0x00E33E43
		public static bool CreateInstance()
		{
			if (ApplicationController._Instance != null)
			{
				return true;
			}
			ApplicationController._Instance = new ApplicationController();
			return true;
		}

		// Token: 0x06032A3C RID: 207420 RVA: 0x00E35C59 File Offset: 0x00E33E59
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06032A3D RID: 207421 RVA: 0x00E35C5B File Offset: 0x00E33E5B
		public static void ResetStaticDefaultValue()
		{
			ApplicationController._Instance = null;
		}

		// Token: 0x06032A3E RID: 207422 RVA: 0x00E35C63 File Offset: 0x00E33E63
		static ApplicationController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ApplicationController.CreateStaticDefaultValue), new Action(ApplicationController.ResetStaticDefaultValue));
		}

		// Token: 0x0401AD75 RID: 109941
		[Nullable(2)]
		private static ApplicationController _Instance;
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Application
{
	// Token: 0x02005EAD RID: 24237
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ApplicationController : ControllerBase
	{
		// Token: 0x0603DAA5 RID: 252581 RVA: 0x00EE4676 File Offset: 0x00EE2876
		protected override bool OnInit()
		{
			Application.Instance.AddApplicationHandler(EApplicationLifetimeDelegate.ApplicationWillEnterBackgroundDelegate, new Action(this.ApplicationWillEnterBackground));
			Application.Instance.AddApplicationHandler(EApplicationLifetimeDelegate.ApplicationHasReactivatedDelegate, new Action(this.ApplicationHasReactivated));
			return true;
		}

		// Token: 0x0603DAA6 RID: 252582 RVA: 0x00EE46A7 File Offset: 0x00EE28A7
		protected override bool OnClear()
		{
			Application.Instance.RemoveApplicationHandler(EApplicationLifetimeDelegate.ApplicationWillEnterBackgroundDelegate, new Action(this.ApplicationWillEnterBackground));
			Application.Instance.RemoveApplicationHandler(EApplicationLifetimeDelegate.ApplicationHasReactivatedDelegate, new Action(this.ApplicationHasReactivated));
			return true;
		}

		// Token: 0x0603DAA7 RID: 252583 RVA: 0x00EE46D8 File Offset: 0x00EE28D8
		private void ApplicationWillEnterBackground()
		{
		}

		// Token: 0x0603DAA8 RID: 252584 RVA: 0x00EE46DA File Offset: 0x00EE28DA
		private void ApplicationHasReactivated()
		{
		}

		// Token: 0x17008EAF RID: 36527
		// (get) Token: 0x0603DAA9 RID: 252585 RVA: 0x00EE46DC File Offset: 0x00EE28DC
		public static ApplicationController Instance
		{
			get
			{
				return ApplicationController._Instance;
			}
		}

		// Token: 0x0603DAAA RID: 252586 RVA: 0x00EE46E3 File Offset: 0x00EE28E3
		public static ApplicationController GetOrCreateInstance()
		{
			if (ApplicationController._Instance == null)
			{
				ApplicationController.CreateInstance();
			}
			return ApplicationController._Instance;
		}

		// Token: 0x0603DAAB RID: 252587 RVA: 0x00EE46F7 File Offset: 0x00EE28F7
		public static bool CreateInstance()
		{
			if (ApplicationController._Instance != null)
			{
				return true;
			}
			ApplicationController._Instance = new ApplicationController();
			return true;
		}

		// Token: 0x0603DAAC RID: 252588 RVA: 0x00EE470D File Offset: 0x00EE290D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603DAAD RID: 252589 RVA: 0x00EE470F File Offset: 0x00EE290F
		public static void ResetStaticDefaultValue()
		{
			ApplicationController._Instance = null;
		}

		// Token: 0x0603DAAE RID: 252590 RVA: 0x00EE4717 File Offset: 0x00EE2917
		static ApplicationController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ApplicationController.CreateStaticDefaultValue), new Action(ApplicationController.ResetStaticDefaultValue));
		}

		// Token: 0x040202AE RID: 131758
		[Nullable(2)]
		private static ApplicationController _Instance;
	}
}

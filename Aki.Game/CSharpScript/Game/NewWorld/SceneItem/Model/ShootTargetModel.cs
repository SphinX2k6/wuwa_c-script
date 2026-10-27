using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.Model
{
	// Token: 0x020071DA RID: 29146
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	internal class ShootTargetModel : ModelBase
	{
		// Token: 0x06047557 RID: 292183 RVA: 0x012237C4 File Offset: 0x012219C4
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x06047558 RID: 292184 RVA: 0x012237C7 File Offset: 0x012219C7
		public void AddTarget(int entityId, int groupId)
		{
		}

		// Token: 0x06047559 RID: 292185 RVA: 0x012237C9 File Offset: 0x012219C9
		public void RemoveTarget(int entityId)
		{
		}

		// Token: 0x0604755A RID: 292186 RVA: 0x012237CB File Offset: 0x012219CB
		protected override bool OnClear()
		{
			return true;
		}

		// Token: 0x17009DF4 RID: 40436
		// (get) Token: 0x0604755B RID: 292187 RVA: 0x012237CE File Offset: 0x012219CE
		public static ShootTargetModel Instance
		{
			get
			{
				return ShootTargetModel._Instance;
			}
		}

		// Token: 0x0604755C RID: 292188 RVA: 0x012237D5 File Offset: 0x012219D5
		public static ShootTargetModel GetOrCreateInstance()
		{
			if (ShootTargetModel._Instance == null)
			{
				ShootTargetModel.CreateInstance();
			}
			return ShootTargetModel._Instance;
		}

		// Token: 0x0604755D RID: 292189 RVA: 0x012237E9 File Offset: 0x012219E9
		public static bool CreateInstance()
		{
			if (ShootTargetModel._Instance != null)
			{
				return true;
			}
			ShootTargetModel._Instance = new ShootTargetModel();
			return true;
		}

		// Token: 0x0604755E RID: 292190 RVA: 0x012237FF File Offset: 0x012219FF
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604755F RID: 292191 RVA: 0x01223801 File Offset: 0x01221A01
		public static void ResetStaticDefaultValue()
		{
			ShootTargetModel._Instance = null;
		}

		// Token: 0x06047560 RID: 292192 RVA: 0x01223809 File Offset: 0x01221A09
		static ShootTargetModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ShootTargetModel.CreateStaticDefaultValue), new Action(ShootTargetModel.ResetStaticDefaultValue));
		}

		// Token: 0x04025814 RID: 153620
		[Nullable(2)]
		private static ShootTargetModel _Instance;
	}
}

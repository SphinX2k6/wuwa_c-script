using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.Model
{
	// Token: 0x0200628F RID: 25231
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	internal class ShootTargetModel : ModelBase
	{
		// Token: 0x0603CE59 RID: 249433 RVA: 0x0117D5F8 File Offset: 0x0117B7F8
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0603CE5A RID: 249434 RVA: 0x0117D5FB File Offset: 0x0117B7FB
		public void AddTarget(int entityId, int groupId)
		{
		}

		// Token: 0x0603CE5B RID: 249435 RVA: 0x0117D5FD File Offset: 0x0117B7FD
		public void RemoveTarget(int entityId)
		{
		}

		// Token: 0x0603CE5C RID: 249436 RVA: 0x0117D5FF File Offset: 0x0117B7FF
		protected override bool OnClear()
		{
			return true;
		}

		// Token: 0x1700734B RID: 29515
		// (get) Token: 0x0603CE5D RID: 249437 RVA: 0x0117D602 File Offset: 0x0117B802
		public static ShootTargetModel Instance
		{
			get
			{
				return ShootTargetModel._Instance;
			}
		}

		// Token: 0x0603CE5E RID: 249438 RVA: 0x0117D609 File Offset: 0x0117B809
		public static ShootTargetModel GetOrCreateInstance()
		{
			if (ShootTargetModel._Instance == null)
			{
				ShootTargetModel.CreateInstance();
			}
			return ShootTargetModel._Instance;
		}

		// Token: 0x0603CE5F RID: 249439 RVA: 0x0117D61D File Offset: 0x0117B81D
		public static bool CreateInstance()
		{
			if (ShootTargetModel._Instance != null)
			{
				return true;
			}
			ShootTargetModel._Instance = new ShootTargetModel();
			return true;
		}

		// Token: 0x0603CE60 RID: 249440 RVA: 0x0117D633 File Offset: 0x0117B833
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603CE61 RID: 249441 RVA: 0x0117D635 File Offset: 0x0117B835
		public static void ResetStaticDefaultValue()
		{
			ShootTargetModel._Instance = null;
		}

		// Token: 0x0603CE62 RID: 249442 RVA: 0x0117D63D File Offset: 0x0117B83D
		static ShootTargetModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ShootTargetModel.CreateStaticDefaultValue), new Action(ShootTargetModel.ResetStaticDefaultValue));
		}

		// Token: 0x04020483 RID: 132227
		[Nullable(2)]
		private static ShootTargetModel _Instance;
	}
}

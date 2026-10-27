using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x020070CA RID: 28874
	[NullableContext(1)]
	[Nullable(0)]
	public class ManipulaterModel : ModelBase
	{
		// Token: 0x06046743 RID: 288579 RVA: 0x011B0512 File Offset: 0x011AE712
		public void SetManipulateMode(ManipulaterModel.EManipulaterMode mode)
		{
			this.ManipulateMode = mode;
		}

		// Token: 0x06046744 RID: 288580 RVA: 0x011B051B File Offset: 0x011AE71B
		public ManipulaterModel.EManipulaterMode GetManipulateMode()
		{
			return this.ManipulateMode;
		}

		// Token: 0x06046745 RID: 288581 RVA: 0x011B0523 File Offset: 0x011AE723
		public void SetTargetPartLocation(Vector offset)
		{
			this.TargetPartLocation = offset;
		}

		// Token: 0x06046746 RID: 288582 RVA: 0x011B052C File Offset: 0x011AE72C
		public Vector GetTargetPartLocation()
		{
			return this.TargetPartLocation;
		}

		// Token: 0x06046747 RID: 288583 RVA: 0x011B0534 File Offset: 0x011AE734
		public bool NeedShowLandTips()
		{
			return this.ShowLandTipsCount > 0;
		}

		// Token: 0x06046748 RID: 288584 RVA: 0x011B0540 File Offset: 0x011AE740
		public void AddShowLandTipsCount(Entity entity)
		{
			if (this.InRangeShowLandTipsEntity.Contains(entity))
			{
				return;
			}
			if (this.ShowLandTipsCount == 0)
			{
				EventSystem.Instance.Emit<bool>(EEventName.OnManipulateShowLandTips, true);
			}
			this.ShowLandTipsCount++;
			this.InRangeShowLandTipsEntity.Add(entity);
		}

		// Token: 0x06046749 RID: 288585 RVA: 0x011B0590 File Offset: 0x011AE790
		public void RemoveShowLandTipsCount(Entity entity)
		{
			if (!this.InRangeShowLandTipsEntity.Contains(entity) || this.ShowLandTipsCount == 0)
			{
				return;
			}
			this.InRangeShowLandTipsEntity.Remove(entity);
			this.ShowLandTipsCount--;
			if (this.ShowLandTipsCount == 0)
			{
				EventSystem.Instance.Emit<bool>(EEventName.OnManipulateShowLandTips, false);
			}
		}

		// Token: 0x0604674A RID: 288586 RVA: 0x011B05E8 File Offset: 0x011AE7E8
		public TArray<FVectorDouble> GetProjectilePath()
		{
			if (this.ProjectilePath == null)
			{
				this.ProjectilePath = new TArray<FVectorDouble>();
			}
			return this.ProjectilePath;
		}

		// Token: 0x0604674B RID: 288587 RVA: 0x011B0603 File Offset: 0x011AE803
		public void SetProjectilePath(TArray<FVectorDouble> path)
		{
			this.ProjectilePath = path;
		}

		// Token: 0x0604674C RID: 288588 RVA: 0x011B060C File Offset: 0x011AE80C
		public TArray<FVectorDouble> GetAfterPortalProjectilePath()
		{
			if (this.AfterPortalProjectilePath == null)
			{
				this.AfterPortalProjectilePath = new TArray<FVectorDouble>();
			}
			return this.AfterPortalProjectilePath;
		}

		// Token: 0x0604674D RID: 288589 RVA: 0x011B0627 File Offset: 0x011AE827
		[NullableContext(2)]
		public void SetAfterPortalProjectilePath(TArray<FVectorDouble> path)
		{
			this.AfterPortalProjectilePath = path;
		}

		// Token: 0x0604674E RID: 288590 RVA: 0x011B0630 File Offset: 0x011AE830
		public FVectorDouble? GetAfterPortalStartPosition()
		{
			return this.AfterPortalStartPosition;
		}

		// Token: 0x0604674F RID: 288591 RVA: 0x011B0638 File Offset: 0x011AE838
		public void SetAfterPortalStartPosition(FVectorDouble? position)
		{
			this.AfterPortalStartPosition = position;
		}

		// Token: 0x17009CAA RID: 40106
		// (get) Token: 0x06046750 RID: 288592 RVA: 0x011B0641 File Offset: 0x011AE841
		public static ManipulaterModel Instance
		{
			get
			{
				return ManipulaterModel._Instance;
			}
		}

		// Token: 0x06046751 RID: 288593 RVA: 0x011B0648 File Offset: 0x011AE848
		public static ManipulaterModel GetOrCreateInstance()
		{
			if (ManipulaterModel._Instance == null)
			{
				ManipulaterModel.CreateInstance();
			}
			return ManipulaterModel._Instance;
		}

		// Token: 0x06046752 RID: 288594 RVA: 0x011B065C File Offset: 0x011AE85C
		public static bool CreateInstance()
		{
			if (ManipulaterModel._Instance != null)
			{
				return true;
			}
			ManipulaterModel._Instance = new ManipulaterModel();
			return true;
		}

		// Token: 0x06046753 RID: 288595 RVA: 0x011B0672 File Offset: 0x011AE872
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06046754 RID: 288596 RVA: 0x011B0674 File Offset: 0x011AE874
		public static void ResetStaticDefaultValue()
		{
			ManipulaterModel._Instance = null;
		}

		// Token: 0x06046755 RID: 288597 RVA: 0x011B067C File Offset: 0x011AE87C
		static ManipulaterModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ManipulaterModel.CreateStaticDefaultValue), new Action(ManipulaterModel.ResetStaticDefaultValue));
		}

		// Token: 0x04024EB5 RID: 151221
		private ManipulaterModel.EManipulaterMode ManipulateMode;

		// Token: 0x04024EB6 RID: 151222
		private Vector TargetPartLocation = Vector.ZeroVectorProxy;

		// Token: 0x04024EB7 RID: 151223
		[Nullable(2)]
		public Vector ExitHoldingStateCameraLocation;

		// Token: 0x04024EB8 RID: 151224
		private int ShowLandTipsCount;

		// Token: 0x04024EB9 RID: 151225
		private readonly HashSet<Entity> InRangeShowLandTipsEntity = new HashSet<Entity>();

		// Token: 0x04024EBA RID: 151226
		[Nullable(2)]
		private TArray<FVectorDouble> ProjectilePath;

		// Token: 0x04024EBB RID: 151227
		[Nullable(2)]
		private TArray<FVectorDouble> AfterPortalProjectilePath;

		// Token: 0x04024EBC RID: 151228
		private FVectorDouble? AfterPortalStartPosition;

		// Token: 0x04024EBD RID: 151229
		[Nullable(2)]
		private static ManipulaterModel _Instance;

		// Token: 0x0200CE6B RID: 52843
		[NullableContext(0)]
		public enum EManipulaterMode
		{
			// Token: 0x0403E244 RID: 254532
			BigWorld,
			// Token: 0x0403E245 RID: 254533
			Boss
		}
	}
}

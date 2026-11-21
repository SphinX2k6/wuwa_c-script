using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x0200632E RID: 25390
	[NullableContext(1)]
	[Nullable(0)]
	public class ManipulaterModel : ModelBase
	{
		// Token: 0x0603D837 RID: 251959 RVA: 0x011CF88E File Offset: 0x011CDA8E
		public void SetManipulateMode(ManipulaterModel.EManipulaterMode mode)
		{
			this.ManipulateMode = mode;
		}

		// Token: 0x0603D838 RID: 251960 RVA: 0x011CF897 File Offset: 0x011CDA97
		public ManipulaterModel.EManipulaterMode GetManipulateMode()
		{
			return this.ManipulateMode;
		}

		// Token: 0x0603D839 RID: 251961 RVA: 0x011CF89F File Offset: 0x011CDA9F
		public void SetTargetPartLocation(Vector offset)
		{
			this.TargetPartLocation = offset;
		}

		// Token: 0x0603D83A RID: 251962 RVA: 0x011CF8A8 File Offset: 0x011CDAA8
		public Vector GetTargetPartLocation()
		{
			return this.TargetPartLocation;
		}

		// Token: 0x0603D83B RID: 251963 RVA: 0x011CF8B0 File Offset: 0x011CDAB0
		public bool NeedShowLandTips()
		{
			return this.ShowLandTipsCount > 0;
		}

		// Token: 0x0603D83C RID: 251964 RVA: 0x011CF8BC File Offset: 0x011CDABC
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

		// Token: 0x0603D83D RID: 251965 RVA: 0x011CF90C File Offset: 0x011CDB0C
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

		// Token: 0x0603D83E RID: 251966 RVA: 0x011CF964 File Offset: 0x011CDB64
		public TArray<FVectorDouble> GetProjectilePath()
		{
			if (this.ProjectilePath == null)
			{
				this.ProjectilePath = new TArray<FVectorDouble>();
			}
			return this.ProjectilePath;
		}

		// Token: 0x0603D83F RID: 251967 RVA: 0x011CF97F File Offset: 0x011CDB7F
		public void SetProjectilePath(TArray<FVectorDouble> path)
		{
			this.ProjectilePath = path;
		}

		// Token: 0x0603D840 RID: 251968 RVA: 0x011CF988 File Offset: 0x011CDB88
		public TArray<FVectorDouble> GetAfterPortalProjectilePath()
		{
			if (this.AfterPortalProjectilePath == null)
			{
				this.AfterPortalProjectilePath = new TArray<FVectorDouble>();
			}
			return this.AfterPortalProjectilePath;
		}

		// Token: 0x0603D841 RID: 251969 RVA: 0x011CF9A3 File Offset: 0x011CDBA3
		[NullableContext(2)]
		public void SetAfterPortalProjectilePath(TArray<FVectorDouble> path)
		{
			this.AfterPortalProjectilePath = path;
		}

		// Token: 0x0603D842 RID: 251970 RVA: 0x011CF9AC File Offset: 0x011CDBAC
		public FVectorDouble? GetAfterPortalStartPosition()
		{
			return this.AfterPortalStartPosition;
		}

		// Token: 0x0603D843 RID: 251971 RVA: 0x011CF9B4 File Offset: 0x011CDBB4
		public void SetAfterPortalStartPosition(FVectorDouble? position)
		{
			this.AfterPortalStartPosition = position;
		}

		// Token: 0x170074BB RID: 29883
		// (get) Token: 0x0603D844 RID: 251972 RVA: 0x011CF9BD File Offset: 0x011CDBBD
		public static ManipulaterModel Instance
		{
			get
			{
				return ManipulaterModel._Instance;
			}
		}

		// Token: 0x0603D845 RID: 251973 RVA: 0x011CF9C4 File Offset: 0x011CDBC4
		public static ManipulaterModel GetOrCreateInstance()
		{
			if (ManipulaterModel._Instance == null)
			{
				ManipulaterModel.CreateInstance();
			}
			return ManipulaterModel._Instance;
		}

		// Token: 0x0603D846 RID: 251974 RVA: 0x011CF9D8 File Offset: 0x011CDBD8
		public static bool CreateInstance()
		{
			if (ManipulaterModel._Instance != null)
			{
				return true;
			}
			ManipulaterModel._Instance = new ManipulaterModel();
			return true;
		}

		// Token: 0x0603D847 RID: 251975 RVA: 0x011CF9EE File Offset: 0x011CDBEE
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603D848 RID: 251976 RVA: 0x011CF9F0 File Offset: 0x011CDBF0
		public static void ResetStaticDefaultValue()
		{
			ManipulaterModel._Instance = null;
		}

		// Token: 0x0603D849 RID: 251977 RVA: 0x011CF9F8 File Offset: 0x011CDBF8
		static ManipulaterModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ManipulaterModel.CreateStaticDefaultValue), new Action(ManipulaterModel.ResetStaticDefaultValue));
		}

		// Token: 0x040209F4 RID: 133620
		private ManipulaterModel.EManipulaterMode ManipulateMode;

		// Token: 0x040209F5 RID: 133621
		private Vector TargetPartLocation = Vector.ZeroVectorProxy;

		// Token: 0x040209F6 RID: 133622
		[Nullable(2)]
		public Vector ExitHoldingStateCameraLocation;

		// Token: 0x040209F7 RID: 133623
		private int ShowLandTipsCount;

		// Token: 0x040209F8 RID: 133624
		private readonly HashSet<Entity> InRangeShowLandTipsEntity = new HashSet<Entity>();

		// Token: 0x040209F9 RID: 133625
		[Nullable(2)]
		private TArray<FVectorDouble> ProjectilePath;

		// Token: 0x040209FA RID: 133626
		[Nullable(2)]
		private TArray<FVectorDouble> AfterPortalProjectilePath;

		// Token: 0x040209FB RID: 133627
		private FVectorDouble? AfterPortalStartPosition;

		// Token: 0x040209FC RID: 133628
		[Nullable(2)]
		private static ManipulaterModel _Instance;

		// Token: 0x0200BB40 RID: 47936
		[NullableContext(0)]
		public enum EManipulaterMode
		{
			// Token: 0x04039978 RID: 235896
			BigWorld,
			// Token: 0x04039979 RID: 235897
			Boss
		}
	}
}

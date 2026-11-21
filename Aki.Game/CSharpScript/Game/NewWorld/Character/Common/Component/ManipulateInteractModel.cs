using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x0200632D RID: 25389
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class ManipulateInteractModel : ModelBase
	{
		// Token: 0x170074B7 RID: 29879
		// (get) Token: 0x0603D829 RID: 251945 RVA: 0x011CF6AB File Offset: 0x011CD8AB
		public double StatueInteractCheckAngle
		{
			get
			{
				return this.StatueInteractCheckAngleInternal;
			}
		}

		// Token: 0x170074B8 RID: 29880
		// (get) Token: 0x0603D82A RID: 251946 RVA: 0x011CF6B3 File Offset: 0x011CD8B3
		public double StatueInteractMoveSpeed
		{
			get
			{
				return this.StatueInteractMoveSpeedInternal;
			}
		}

		// Token: 0x170074B9 RID: 29881
		// (get) Token: 0x0603D82B RID: 251947 RVA: 0x011CF6BB File Offset: 0x011CD8BB
		public double StatueInteractMaxMoveTime
		{
			get
			{
				return this.StatueInteractMaxMoveTimeInternal;
			}
		}

		// Token: 0x0603D82C RID: 251948 RVA: 0x011CF6C3 File Offset: 0x011CD8C3
		protected override bool OnInit()
		{
			this.GetCommonValue();
			EventSystem.Instance.Add<bool, SceneItemExploreInteractComponent>(EEventName.OnOverlapSceneItemExploreInteractRange, new Action<bool, SceneItemExploreInteractComponent>(this.OnOverlapSceneItemExploreInteractRange));
			return true;
		}

		// Token: 0x0603D82D RID: 251949 RVA: 0x011CF6E8 File Offset: 0x011CD8E8
		private void GetCommonValue()
		{
			GlobalConfigFromCsv? config = ConfigGlobalConfigFromCsvByName.GetConfig("StatueInteract.CheckAngle", true);
			if (config != null)
			{
				this.StatueInteractCheckAngleInternal = double.Parse(config.Value.Value);
			}
			config = ConfigGlobalConfigFromCsvByName.GetConfig("StatueInteract.MoveSpeed", true);
			if (config != null)
			{
				this.StatueInteractMoveSpeedInternal = (double)int.Parse(config.Value.Value);
			}
			config = ConfigGlobalConfigFromCsvByName.GetConfig("StatueInteract.MaxMoveTime", true);
			if (config != null)
			{
				this.StatueInteractMaxMoveTimeInternal = double.Parse(config.Value.Value);
			}
		}

		// Token: 0x0603D82E RID: 251950 RVA: 0x011CF783 File Offset: 0x011CD983
		protected override bool OnClear()
		{
			EventSystem.Instance.Remove<bool, SceneItemExploreInteractComponent>(EEventName.OnOverlapSceneItemExploreInteractRange, new Action<bool, SceneItemExploreInteractComponent>(this.OnOverlapSceneItemExploreInteractRange));
			return true;
		}

		// Token: 0x0603D82F RID: 251951 RVA: 0x011CF7A4 File Offset: 0x011CD9A4
		private void OnOverlapSceneItemExploreInteractRange(bool isEnter, SceneItemExploreInteractComponent exploreInteractComp)
		{
			HashSet<SceneItemExploreInteractComponent> hashSet = exploreInteractComp.IsShootSwordInteractPoint ? this.ShootSwordInRangePoints : this.InRangePoints;
			if (isEnter)
			{
				hashSet.Add(exploreInteractComp);
				return;
			}
			hashSet.Remove(exploreInteractComp);
		}

		// Token: 0x170074BA RID: 29882
		// (get) Token: 0x0603D830 RID: 251952 RVA: 0x011CF7DC File Offset: 0x011CD9DC
		public static ManipulateInteractModel Instance
		{
			get
			{
				return ManipulateInteractModel._Instance;
			}
		}

		// Token: 0x0603D831 RID: 251953 RVA: 0x011CF7E3 File Offset: 0x011CD9E3
		public static ManipulateInteractModel GetOrCreateInstance()
		{
			if (ManipulateInteractModel._Instance == null)
			{
				ManipulateInteractModel.CreateInstance();
			}
			return ManipulateInteractModel._Instance;
		}

		// Token: 0x0603D832 RID: 251954 RVA: 0x011CF7F7 File Offset: 0x011CD9F7
		public static bool CreateInstance()
		{
			if (ManipulateInteractModel._Instance != null)
			{
				return true;
			}
			ManipulateInteractModel._Instance = new ManipulateInteractModel();
			return true;
		}

		// Token: 0x0603D833 RID: 251955 RVA: 0x011CF80D File Offset: 0x011CDA0D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603D834 RID: 251956 RVA: 0x011CF80F File Offset: 0x011CDA0F
		public static void ResetStaticDefaultValue()
		{
			ManipulateInteractModel._Instance = null;
		}

		// Token: 0x0603D835 RID: 251957 RVA: 0x011CF817 File Offset: 0x011CDA17
		static ManipulateInteractModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ManipulateInteractModel.CreateStaticDefaultValue), new Action(ManipulateInteractModel.ResetStaticDefaultValue));
		}

		// Token: 0x040209EE RID: 133614
		private double StatueInteractCheckAngleInternal = -1.0;

		// Token: 0x040209EF RID: 133615
		private double StatueInteractMoveSpeedInternal = -1.0;

		// Token: 0x040209F0 RID: 133616
		private double StatueInteractMaxMoveTimeInternal = -1.0;

		// Token: 0x040209F1 RID: 133617
		public readonly HashSet<SceneItemExploreInteractComponent> InRangePoints = new HashSet<SceneItemExploreInteractComponent>();

		// Token: 0x040209F2 RID: 133618
		public readonly HashSet<SceneItemExploreInteractComponent> ShootSwordInRangePoints = new HashSet<SceneItemExploreInteractComponent>();

		// Token: 0x040209F3 RID: 133619
		[Nullable(2)]
		private static ManipulateInteractModel _Instance;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x020070C9 RID: 28873
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class ManipulateInteractModel : ModelBase
	{
		// Token: 0x17009CA6 RID: 40102
		// (get) Token: 0x06046735 RID: 288565 RVA: 0x011B032F File Offset: 0x011AE52F
		public double StatueInteractCheckAngle
		{
			get
			{
				return this.StatueInteractCheckAngleInternal;
			}
		}

		// Token: 0x17009CA7 RID: 40103
		// (get) Token: 0x06046736 RID: 288566 RVA: 0x011B0337 File Offset: 0x011AE537
		public double StatueInteractMoveSpeed
		{
			get
			{
				return this.StatueInteractMoveSpeedInternal;
			}
		}

		// Token: 0x17009CA8 RID: 40104
		// (get) Token: 0x06046737 RID: 288567 RVA: 0x011B033F File Offset: 0x011AE53F
		public double StatueInteractMaxMoveTime
		{
			get
			{
				return this.StatueInteractMaxMoveTimeInternal;
			}
		}

		// Token: 0x06046738 RID: 288568 RVA: 0x011B0347 File Offset: 0x011AE547
		protected override bool OnInit()
		{
			this.GetCommonValue();
			EventSystem.Instance.Add<bool, SceneItemExploreInteractComponent>(EEventName.OnOverlapSceneItemExploreInteractRange, new Action<bool, SceneItemExploreInteractComponent>(this.OnOverlapSceneItemExploreInteractRange));
			return true;
		}

		// Token: 0x06046739 RID: 288569 RVA: 0x011B036C File Offset: 0x011AE56C
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

		// Token: 0x0604673A RID: 288570 RVA: 0x011B0407 File Offset: 0x011AE607
		protected override bool OnClear()
		{
			EventSystem.Instance.Remove<bool, SceneItemExploreInteractComponent>(EEventName.OnOverlapSceneItemExploreInteractRange, new Action<bool, SceneItemExploreInteractComponent>(this.OnOverlapSceneItemExploreInteractRange));
			return true;
		}

		// Token: 0x0604673B RID: 288571 RVA: 0x011B0428 File Offset: 0x011AE628
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

		// Token: 0x17009CA9 RID: 40105
		// (get) Token: 0x0604673C RID: 288572 RVA: 0x011B0460 File Offset: 0x011AE660
		public static ManipulateInteractModel Instance
		{
			get
			{
				return ManipulateInteractModel._Instance;
			}
		}

		// Token: 0x0604673D RID: 288573 RVA: 0x011B0467 File Offset: 0x011AE667
		public static ManipulateInteractModel GetOrCreateInstance()
		{
			if (ManipulateInteractModel._Instance == null)
			{
				ManipulateInteractModel.CreateInstance();
			}
			return ManipulateInteractModel._Instance;
		}

		// Token: 0x0604673E RID: 288574 RVA: 0x011B047B File Offset: 0x011AE67B
		public static bool CreateInstance()
		{
			if (ManipulateInteractModel._Instance != null)
			{
				return true;
			}
			ManipulateInteractModel._Instance = new ManipulateInteractModel();
			return true;
		}

		// Token: 0x0604673F RID: 288575 RVA: 0x011B0491 File Offset: 0x011AE691
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06046740 RID: 288576 RVA: 0x011B0493 File Offset: 0x011AE693
		public static void ResetStaticDefaultValue()
		{
			ManipulateInteractModel._Instance = null;
		}

		// Token: 0x06046741 RID: 288577 RVA: 0x011B049B File Offset: 0x011AE69B
		static ManipulateInteractModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ManipulateInteractModel.CreateStaticDefaultValue), new Action(ManipulateInteractModel.ResetStaticDefaultValue));
		}

		// Token: 0x04024EAF RID: 151215
		private double StatueInteractCheckAngleInternal = -1.0;

		// Token: 0x04024EB0 RID: 151216
		private double StatueInteractMoveSpeedInternal = -1.0;

		// Token: 0x04024EB1 RID: 151217
		private double StatueInteractMaxMoveTimeInternal = -1.0;

		// Token: 0x04024EB2 RID: 151218
		public readonly HashSet<SceneItemExploreInteractComponent> InRangePoints = new HashSet<SceneItemExploreInteractComponent>();

		// Token: 0x04024EB3 RID: 151219
		public readonly HashSet<SceneItemExploreInteractComponent> ShootSwordInRangePoints = new HashSet<SceneItemExploreInteractComponent>();

		// Token: 0x04024EB4 RID: 151220
		[Nullable(2)]
		private static ManipulateInteractModel _Instance;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Portal;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Model
{
	// Token: 0x0200628A RID: 25226
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class PortalModel : ModelBase
	{
		// Token: 0x0603CE1D RID: 249373 RVA: 0x0117CEB3 File Offset: 0x0117B0B3
		protected override bool OnInit()
		{
			this.PortalCache = new Dictionary<long, BP_Portal_C>();
			return true;
		}

		// Token: 0x0603CE1E RID: 249374 RVA: 0x0117CEC1 File Offset: 0x0117B0C1
		public void AddPortalPair(long portalId, BP_Portal_C portal)
		{
			if (this.PortalCache.ContainsKey(portalId))
			{
				return;
			}
			this.PortalCache[portalId] = portal;
		}

		// Token: 0x0603CE1F RID: 249375 RVA: 0x0117CEDF File Offset: 0x0117B0DF
		public void RemovePortalPair(long portalFixId)
		{
			this.PortalCache.Remove(portalFixId);
		}

		// Token: 0x0603CE20 RID: 249376 RVA: 0x0117CEF0 File Offset: 0x0117B0F0
		[NullableContext(2)]
		public BP_Portal_C GetPortal(long portalId)
		{
			BP_Portal_C result;
			if (this.PortalCache.TryGetValue(portalId, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0603CE21 RID: 249377 RVA: 0x0117CF10 File Offset: 0x0117B110
		public IReadOnlyDictionary<long, BP_Portal_C> GetPortals()
		{
			return this.PortalCache;
		}

		// Token: 0x0603CE22 RID: 249378 RVA: 0x0117CF18 File Offset: 0x0117B118
		protected override bool OnClear()
		{
			this.PortalCache = null;
			if (this.PortalInternal != null)
			{
				ActorSystem.Instance.Put("PortalModel.OnClear", this.PortalInternal, null);
				this.PortalInternal = null;
			}
			return true;
		}

		// Token: 0x0603CE23 RID: 249379 RVA: 0x0117CF48 File Offset: 0x0117B148
		protected override bool OnLeaveLevel()
		{
			if (this.PortalInternal != null)
			{
				ActorSystem.Instance.Put("PortalModel.OnLeaveLevel", this.PortalInternal, null);
				this.PortalInternal = null;
			}
			return true;
		}

		// Token: 0x0603CE24 RID: 249380 RVA: 0x0117CF71 File Offset: 0x0117B171
		public BP_Portal_C GetBpPortalActor()
		{
			if (this.PortalInternal == null)
			{
				this.PortalInternal = (ActorSystem.Instance.Spawn(BP_Portal_C.StaticClass(), new FTransformDouble(), null) as BP_Portal_C);
			}
			return this.PortalInternal;
		}

		// Token: 0x17007346 RID: 29510
		// (get) Token: 0x0603CE25 RID: 249381 RVA: 0x0117CFA1 File Offset: 0x0117B1A1
		public static PortalModel Instance
		{
			get
			{
				return PortalModel._Instance;
			}
		}

		// Token: 0x0603CE26 RID: 249382 RVA: 0x0117CFA8 File Offset: 0x0117B1A8
		public static PortalModel GetOrCreateInstance()
		{
			if (PortalModel._Instance == null)
			{
				PortalModel.CreateInstance();
			}
			return PortalModel._Instance;
		}

		// Token: 0x0603CE27 RID: 249383 RVA: 0x0117CFBC File Offset: 0x0117B1BC
		public static bool CreateInstance()
		{
			if (PortalModel._Instance != null)
			{
				return true;
			}
			PortalModel._Instance = new PortalModel();
			return true;
		}

		// Token: 0x0603CE28 RID: 249384 RVA: 0x0117CFD2 File Offset: 0x0117B1D2
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603CE29 RID: 249385 RVA: 0x0117CFD4 File Offset: 0x0117B1D4
		public static void ResetStaticDefaultValue()
		{
			PortalModel._Instance = null;
		}

		// Token: 0x0603CE2A RID: 249386 RVA: 0x0117CFDC File Offset: 0x0117B1DC
		static PortalModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PortalModel.CreateStaticDefaultValue), new Action(PortalModel.ResetStaticDefaultValue));
		}

		// Token: 0x04020477 RID: 132215
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<long, BP_Portal_C> PortalCache;

		// Token: 0x04020478 RID: 132216
		[Nullable(2)]
		private BP_Portal_C PortalInternal;

		// Token: 0x04020479 RID: 132217
		[Nullable(2)]
		private static PortalModel _Instance;
	}
}

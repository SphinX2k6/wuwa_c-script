using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Portal;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Model
{
	// Token: 0x020071D5 RID: 29141
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class PortalModel : ModelBase
	{
		// Token: 0x0604751B RID: 292123 RVA: 0x0122307F File Offset: 0x0122127F
		protected override bool OnInit()
		{
			this.PortalCache = new Dictionary<long, BP_Portal_C>();
			return true;
		}

		// Token: 0x0604751C RID: 292124 RVA: 0x0122308D File Offset: 0x0122128D
		public void AddPortalPair(long portalId, BP_Portal_C portal)
		{
			if (this.PortalCache.ContainsKey(portalId))
			{
				return;
			}
			this.PortalCache[portalId] = portal;
		}

		// Token: 0x0604751D RID: 292125 RVA: 0x012230AB File Offset: 0x012212AB
		public void RemovePortalPair(long portalFixId)
		{
			this.PortalCache.Remove(portalFixId);
		}

		// Token: 0x0604751E RID: 292126 RVA: 0x012230BC File Offset: 0x012212BC
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

		// Token: 0x0604751F RID: 292127 RVA: 0x012230DC File Offset: 0x012212DC
		public IReadOnlyDictionary<long, BP_Portal_C> GetPortals()
		{
			return this.PortalCache;
		}

		// Token: 0x06047520 RID: 292128 RVA: 0x012230E4 File Offset: 0x012212E4
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

		// Token: 0x06047521 RID: 292129 RVA: 0x01223114 File Offset: 0x01221314
		protected override bool OnLeaveLevel()
		{
			if (this.PortalInternal != null)
			{
				ActorSystem.Instance.Put("PortalModel.OnLeaveLevel", this.PortalInternal, null);
				this.PortalInternal = null;
			}
			return true;
		}

		// Token: 0x06047522 RID: 292130 RVA: 0x0122313D File Offset: 0x0122133D
		public BP_Portal_C GetBpPortalActor()
		{
			if (this.PortalInternal == null)
			{
				this.PortalInternal = (ActorSystem.Instance.Spawn(BP_Portal_C.StaticClass(), new FTransformDouble(), null) as BP_Portal_C);
			}
			return this.PortalInternal;
		}

		// Token: 0x17009DEF RID: 40431
		// (get) Token: 0x06047523 RID: 292131 RVA: 0x0122316D File Offset: 0x0122136D
		public static PortalModel Instance
		{
			get
			{
				return PortalModel._Instance;
			}
		}

		// Token: 0x06047524 RID: 292132 RVA: 0x01223174 File Offset: 0x01221374
		public static PortalModel GetOrCreateInstance()
		{
			if (PortalModel._Instance == null)
			{
				PortalModel.CreateInstance();
			}
			return PortalModel._Instance;
		}

		// Token: 0x06047525 RID: 292133 RVA: 0x01223188 File Offset: 0x01221388
		public static bool CreateInstance()
		{
			if (PortalModel._Instance != null)
			{
				return true;
			}
			PortalModel._Instance = new PortalModel();
			return true;
		}

		// Token: 0x06047526 RID: 292134 RVA: 0x0122319E File Offset: 0x0122139E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06047527 RID: 292135 RVA: 0x012231A0 File Offset: 0x012213A0
		public static void ResetStaticDefaultValue()
		{
			PortalModel._Instance = null;
		}

		// Token: 0x06047528 RID: 292136 RVA: 0x012231A8 File Offset: 0x012213A8
		static PortalModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PortalModel.CreateStaticDefaultValue), new Action(PortalModel.ResetStaticDefaultValue));
		}

		// Token: 0x04025808 RID: 153608
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<long, BP_Portal_C> PortalCache;

		// Token: 0x04025809 RID: 153609
		[Nullable(2)]
		private BP_Portal_C PortalInternal;

		// Token: 0x0402580A RID: 153610
		[Nullable(2)]
		private static PortalModel _Instance;
	}
}

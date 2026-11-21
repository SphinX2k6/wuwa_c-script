using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B03 RID: 11011
	public class ILiftMoveTypeTeleport : ILiftMoveType
	{
		// Token: 0x0600F246 RID: 62022 RVA: 0x0023662E File Offset: 0x0023482E
		public static ILiftMoveTypeTeleport Create(ILiftMoveTypeTeleport? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiftMoveTypeTeleport
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048EE RID: 18670
		// (get) Token: 0x0600F247 RID: 62023 RVA: 0x0023664D File Offset: 0x0023484D
		public override ELiftMoveType Type
		{
			get
			{
				return (ELiftMoveType)this.Instance.Type;
			}
		}

		// Token: 0x170048EF RID: 18671
		// (get) Token: 0x0600F248 RID: 62024 RVA: 0x0023665A File Offset: 0x0023485A
		public virtual float StartTeleportOffsetDistance
		{
			get
			{
				return this.Instance.StartTeleportOffsetDistance;
			}
		}

		// Token: 0x170048F0 RID: 18672
		// (get) Token: 0x0600F249 RID: 62025 RVA: 0x00236667 File Offset: 0x00234867
		public virtual float EndTeleportOffsetDistance
		{
			get
			{
				return this.Instance.EndTeleportOffsetDistance;
			}
		}

		// Token: 0x170048F1 RID: 18673
		// (get) Token: 0x0600F24A RID: 62026 RVA: 0x00236674 File Offset: 0x00234874
		public virtual bool SendTeleportEvent
		{
			get
			{
				return this.Instance.SendTeleportEvent;
			}
		}

		// Token: 0x170048F2 RID: 18674
		// (get) Token: 0x0600F24B RID: 62027 RVA: 0x00236681 File Offset: 0x00234881
		public virtual float TeleportStartEventOffsetDistance
		{
			get
			{
				return this.Instance.TeleportStartEventOffsetDistance;
			}
		}

		// Token: 0x040084FB RID: 34043
		private ILiftMoveTypeTeleport Instance;
	}
}

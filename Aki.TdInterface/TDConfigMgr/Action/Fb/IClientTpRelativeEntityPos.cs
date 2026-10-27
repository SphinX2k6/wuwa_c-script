using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026BE RID: 9918
	public class IClientTpRelativeEntityPos : IClientTeleportConfig
	{
		// Token: 0x0600DDD8 RID: 56792 RVA: 0x0020EF92 File Offset: 0x0020D192
		[NullableContext(1)]
		public static IClientTpRelativeEntityPos Create(IClientTpRelativeEntityPos? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientTpRelativeEntityPos
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700421E RID: 16926
		// (get) Token: 0x0600DDD9 RID: 56793 RVA: 0x0020EFB1 File Offset: 0x0020D1B1
		public override EClientTeleportType Type
		{
			get
			{
				return (EClientTeleportType)this.Instance.Type;
			}
		}

		// Token: 0x1700421F RID: 16927
		// (get) Token: 0x0600DDDA RID: 56794 RVA: 0x0020EFBE File Offset: 0x0020D1BE
		public virtual int SourcePosEntityId
		{
			get
			{
				return this.Instance.SourcePosEntityId;
			}
		}

		// Token: 0x17004220 RID: 16928
		// (get) Token: 0x0600DDDB RID: 56795 RVA: 0x0020EFCB File Offset: 0x0020D1CB
		public virtual int TargetPosEntityId
		{
			get
			{
				return this.Instance.TargetPosEntityId;
			}
		}

		// Token: 0x04007B2A RID: 31530
		private IClientTpRelativeEntityPos Instance;
	}
}

using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002982 RID: 10626
	public class IClientTpRelativeEntityPos : IClientTeleportConfig
	{
		// Token: 0x0600EBB4 RID: 60340 RVA: 0x0022B7D2 File Offset: 0x002299D2
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

		// Token: 0x1700455E RID: 17758
		// (get) Token: 0x0600EBB5 RID: 60341 RVA: 0x0022B7F1 File Offset: 0x002299F1
		public override EClientTeleportType Type
		{
			get
			{
				return (EClientTeleportType)this.Instance.Type;
			}
		}

		// Token: 0x1700455F RID: 17759
		// (get) Token: 0x0600EBB6 RID: 60342 RVA: 0x0022B7FE File Offset: 0x002299FE
		public virtual int SourcePosEntityId
		{
			get
			{
				return this.Instance.SourcePosEntityId;
			}
		}

		// Token: 0x17004560 RID: 17760
		// (get) Token: 0x0600EBB7 RID: 60343 RVA: 0x0022B80B File Offset: 0x00229A0B
		public virtual int TargetPosEntityId
		{
			get
			{
				return this.Instance.TargetPosEntityId;
			}
		}

		// Token: 0x040081CA RID: 33226
		private IClientTpRelativeEntityPos Instance;
	}
}

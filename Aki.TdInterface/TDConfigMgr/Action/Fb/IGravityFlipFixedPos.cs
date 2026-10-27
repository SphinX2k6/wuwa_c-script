using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026B8 RID: 9912
	public class IGravityFlipFixedPos : ITeleportConfig
	{
		// Token: 0x0600DDBF RID: 56767 RVA: 0x0020ED14 File Offset: 0x0020CF14
		[NullableContext(1)]
		public static IGravityFlipFixedPos Create(IGravityFlipFixedPos? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGravityFlipFixedPos
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004211 RID: 16913
		// (get) Token: 0x0600DDC0 RID: 56768 RVA: 0x0020ED33 File Offset: 0x0020CF33
		public override ETeleportType Type
		{
			get
			{
				return (ETeleportType)this.Instance.Type;
			}
		}

		// Token: 0x17004212 RID: 16914
		// (get) Token: 0x0600DDC1 RID: 56769 RVA: 0x0020ED40 File Offset: 0x0020CF40
		public virtual int GravityAndPosEntityId
		{
			get
			{
				return this.Instance.GravityAndPosEntityId;
			}
		}

		// Token: 0x04007B1E RID: 31518
		private IGravityFlipFixedPos Instance;
	}
}

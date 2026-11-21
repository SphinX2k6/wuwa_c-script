using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BB5 RID: 11189
	public class IPetalGrabMoveType
	{
		// Token: 0x0600F6A8 RID: 63144 RVA: 0x0023EE1E File Offset: 0x0023D01E
		public static IPetalGrabMoveType Create(IPetalGrabMoveType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPetalGrabMoveType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BEC RID: 19436
		// (get) Token: 0x0600F6A9 RID: 63145 RVA: 0x0023EE3D File Offset: 0x0023D03D
		public virtual EPetalGrabMoveType Type
		{
			get
			{
				return (EPetalGrabMoveType)this.Instance.Type;
			}
		}

		// Token: 0x04008721 RID: 34593
		private IPetalGrabMoveType Instance;
	}
}

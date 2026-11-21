using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BB6 RID: 11190
	public class IPetalGrabMoveLinear : IPetalGrabMoveType
	{
		// Token: 0x0600F6AB RID: 63147 RVA: 0x0023EE52 File Offset: 0x0023D052
		public static IPetalGrabMoveLinear Create(IPetalGrabMoveLinear? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPetalGrabMoveLinear
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BED RID: 19437
		// (get) Token: 0x0600F6AC RID: 63148 RVA: 0x0023EE71 File Offset: 0x0023D071
		public override EPetalGrabMoveType Type
		{
			get
			{
				return (EPetalGrabMoveType)this.Instance.Type;
			}
		}

		// Token: 0x17004BEE RID: 19438
		// (get) Token: 0x0600F6AD RID: 63149 RVA: 0x0023EE7E File Offset: 0x0023D07E
		public virtual int StartHalfWidth
		{
			get
			{
				return this.Instance.StartHalfWidth;
			}
		}

		// Token: 0x17004BEF RID: 19439
		// (get) Token: 0x0600F6AE RID: 63150 RVA: 0x0023EE8B File Offset: 0x0023D08B
		public virtual int EndHalfWidth
		{
			get
			{
				return this.Instance.EndHalfWidth;
			}
		}

		// Token: 0x04008722 RID: 34594
		private IPetalGrabMoveLinear Instance;
	}
}

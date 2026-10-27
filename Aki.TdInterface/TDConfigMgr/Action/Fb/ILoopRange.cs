using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200290A RID: 10506
	[NullableContext(1)]
	[Nullable(0)]
	public class ILoopRange
	{
		// Token: 0x0600E939 RID: 59705 RVA: 0x00223337 File Offset: 0x00221537
		public static ILoopRange Create(ILoopRange? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILoopRange
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048E7 RID: 18663
		// (get) Token: 0x0600E93A RID: 59706 RVA: 0x00223356 File Offset: 0x00221556
		public virtual string LeftMark
		{
			get
			{
				return this.Instance.LeftMark;
			}
		}

		// Token: 0x170048E8 RID: 18664
		// (get) Token: 0x0600E93B RID: 59707 RVA: 0x00223363 File Offset: 0x00221563
		public virtual string RightMark
		{
			get
			{
				return this.Instance.RightMark;
			}
		}

		// Token: 0x040080C0 RID: 32960
		private ILoopRange Instance;
	}
}

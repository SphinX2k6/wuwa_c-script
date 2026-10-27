using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C6A RID: 3178
	[NullableContext(1)]
	[Nullable(0)]
	public class ILiftFloorSeqMark
	{
		// Token: 0x060048DA RID: 18650 RVA: 0x000B6E8D File Offset: 0x000B508D
		public static ILiftFloorSeqMark Create(ILiftFloorSeqMark? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiftFloorSeqMark
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170015C3 RID: 5571
		// (get) Token: 0x060048DB RID: 18651 RVA: 0x000B6EAC File Offset: 0x000B50AC
		public virtual int Floor
		{
			get
			{
				return this.Instance.Floor;
			}
		}

		// Token: 0x170015C4 RID: 5572
		// (get) Token: 0x060048DC RID: 18652 RVA: 0x000B6EB9 File Offset: 0x000B50B9
		public virtual string Mark
		{
			get
			{
				return this.Instance.Mark;
			}
		}

		// Token: 0x04002989 RID: 10633
		private ILiftFloorSeqMark Instance;
	}
}

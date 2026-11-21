using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D49 RID: 3401
	public class ILiftFloorSeqMark
	{
		// Token: 0x06004D79 RID: 19833 RVA: 0x000C1691 File Offset: 0x000BF891
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

		// Token: 0x170016E2 RID: 5858
		// (get) Token: 0x06004D7A RID: 19834 RVA: 0x000C16B0 File Offset: 0x000BF8B0
		public virtual int Floor
		{
			get
			{
				return this.Instance.Floor;
			}
		}

		// Token: 0x170016E3 RID: 5859
		// (get) Token: 0x06004D7B RID: 19835 RVA: 0x000C16BD File Offset: 0x000BF8BD
		public virtual string Mark
		{
			get
			{
				return this.Instance.Mark;
			}
		}

		// Token: 0x04002BF6 RID: 11254
		private ILiftFloorSeqMark Instance;
	}
}

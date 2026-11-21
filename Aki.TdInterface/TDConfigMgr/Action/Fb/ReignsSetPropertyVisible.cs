using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D3B RID: 11579
	public class ReignsSetPropertyVisible : ActionParams
	{
		// Token: 0x0600FCF2 RID: 64754 RVA: 0x00248D98 File Offset: 0x00246F98
		public static ReignsSetPropertyVisible Create(IReignsSetPropertyVisible? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ReignsSetPropertyVisible
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F2A RID: 20266
		// (get) Token: 0x0600FCF3 RID: 64755 RVA: 0x00248DB7 File Offset: 0x00246FB7
		public virtual int PropertyId
		{
			get
			{
				return this.Instance.PropertyId;
			}
		}

		// Token: 0x17004F2B RID: 20267
		// (get) Token: 0x0600FCF4 RID: 64756 RVA: 0x00248DC4 File Offset: 0x00246FC4
		public virtual bool IsVisible
		{
			get
			{
				return this.Instance.IsVisible;
			}
		}

		// Token: 0x04008A1D RID: 35357
		private IReignsSetPropertyVisible Instance;
	}
}

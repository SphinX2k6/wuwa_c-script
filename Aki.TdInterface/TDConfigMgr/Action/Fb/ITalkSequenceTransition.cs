using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200285E RID: 10334
	public class ITalkSequenceTransition
	{
		// Token: 0x0600E67E RID: 59006 RVA: 0x00221E42 File Offset: 0x00220042
		public static ITalkSequenceTransition Create(ITalkSequenceTransition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkSequenceTransition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004270 RID: 17008
		// (get) Token: 0x0600E67F RID: 59007 RVA: 0x00221E61 File Offset: 0x00220061
		public virtual string OptionText
		{
			get
			{
				return this.Instance.OptionText;
			}
		}

		// Token: 0x17004271 RID: 17009
		// (get) Token: 0x0600E680 RID: 59008 RVA: 0x00221E6E File Offset: 0x0022006E
		public virtual string OptionTextKey
		{
			get
			{
				return this.Instance.OptionTextKey;
			}
		}

		// Token: 0x17004272 RID: 17010
		// (get) Token: 0x0600E681 RID: 59009 RVA: 0x00221E7B File Offset: 0x0022007B
		public virtual int NextSequenceIndex
		{
			get
			{
				return this.Instance.NextSequenceIndex;
			}
		}

		// Token: 0x04007EF4 RID: 32500
		private ITalkSequenceTransition Instance;
	}
}

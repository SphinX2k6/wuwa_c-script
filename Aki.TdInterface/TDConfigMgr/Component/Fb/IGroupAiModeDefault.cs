using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E50 RID: 3664
	public class IGroupAiModeDefault : IGroupAiMode
	{
		// Token: 0x060052EC RID: 21228 RVA: 0x000CCDFB File Offset: 0x000CAFFB
		public static IGroupAiModeDefault Create(IGroupAiModeDefault? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupAiModeDefault
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A47 RID: 6727
		// (get) Token: 0x060052ED RID: 21229 RVA: 0x000CCE1A File Offset: 0x000CB01A
		public override EGroupAiMode Type
		{
			get
			{
				return (EGroupAiMode)this.Instance.Type;
			}
		}

		// Token: 0x04002F5B RID: 12123
		private IGroupAiModeDefault Instance;
	}
}

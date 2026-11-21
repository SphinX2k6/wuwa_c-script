using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027C7 RID: 10183
	public class ITalkBackgroundClean : ITalkBackground
	{
		// Token: 0x0600E157 RID: 57687 RVA: 0x002120A2 File Offset: 0x002102A2
		public static ITalkBackgroundClean Create(ITalkBackgroundClean? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkBackgroundClean
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E77 RID: 15991
		// (get) Token: 0x0600E158 RID: 57688 RVA: 0x002120C1 File Offset: 0x002102C1
		public override ETalkBackgroundType Type
		{
			get
			{
				return (ETalkBackgroundType)this.Instance.Type;
			}
		}

		// Token: 0x04007A7B RID: 31355
		private ITalkBackgroundClean Instance;
	}
}

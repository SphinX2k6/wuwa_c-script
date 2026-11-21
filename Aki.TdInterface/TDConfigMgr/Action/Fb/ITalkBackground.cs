using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027C6 RID: 10182
	public class ITalkBackground
	{
		// Token: 0x0600E154 RID: 57684 RVA: 0x0021206E File Offset: 0x0021026E
		public static ITalkBackground Create(ITalkBackground? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkBackground
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E76 RID: 15990
		// (get) Token: 0x0600E155 RID: 57685 RVA: 0x0021208D File Offset: 0x0021028D
		public virtual ETalkBackgroundType Type
		{
			get
			{
				return (ETalkBackgroundType)this.Instance.Type;
			}
		}

		// Token: 0x04007A7A RID: 31354
		private ITalkBackground Instance;
	}
}

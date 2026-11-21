using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014EA RID: 5354
	public class IShowUi
	{
		// Token: 0x06007960 RID: 31072 RVA: 0x00122262 File Offset: 0x00120462
		public static IShowUi Create(IShowUi? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowUi
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700272E RID: 10030
		// (get) Token: 0x06007961 RID: 31073 RVA: 0x00122281 File Offset: 0x00120481
		public virtual EShowUiType Type
		{
			get
			{
				return (EShowUiType)this.Instance.Type;
			}
		}

		// Token: 0x040045D8 RID: 17880
		private IShowUi Instance;
	}
}

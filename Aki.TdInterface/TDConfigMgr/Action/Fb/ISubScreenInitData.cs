using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200279C RID: 10140
	[NullableContext(1)]
	[Nullable(0)]
	public class ISubScreenInitData
	{
		// Token: 0x0600E1AB RID: 57771 RVA: 0x002158C6 File Offset: 0x00213AC6
		public static ISubScreenInitData Create(ISubScreenInitData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubScreenInitData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004435 RID: 17461
		// (get) Token: 0x0600E1AC RID: 57772 RVA: 0x002158E5 File Offset: 0x00213AE5
		public virtual ESubScreenInitDataType Type
		{
			get
			{
				return (ESubScreenInitDataType)this.Instance.Type;
			}
		}

		// Token: 0x17004436 RID: 17462
		// (get) Token: 0x0600E1AD RID: 57773 RVA: 0x002158F2 File Offset: 0x00213AF2
		public virtual string SubScreenKey
		{
			get
			{
				return this.Instance.SubScreenKey;
			}
		}

		// Token: 0x04007D24 RID: 32036
		private ISubScreenInitData Instance;
	}
}

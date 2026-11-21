using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B54 RID: 2900
	public class IInitStateBirth : IInitState
	{
		// Token: 0x06004249 RID: 16969 RVA: 0x000A8872 File Offset: 0x000A6A72
		public static IInitStateBirth Create(IInitStateBirth? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInitStateBirth
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x0600424A RID: 16970 RVA: 0x000A8891 File Offset: 0x000A6A91
		public override EInitStateType Type
		{
			get
			{
				return (EInitStateType)this.Instance.Type;
			}
		}

		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x0600424B RID: 16971 RVA: 0x000A889E File Offset: 0x000A6A9E
		public virtual string BirthTag
		{
			get
			{
				return this.Instance.BirthTag;
			}
		}

		// Token: 0x040024B9 RID: 9401
		private IInitStateBirth Instance;
	}
}

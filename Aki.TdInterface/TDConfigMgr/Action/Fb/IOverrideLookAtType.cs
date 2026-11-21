using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D64 RID: 11620
	public class IOverrideLookAtType
	{
		// Token: 0x0600FD9B RID: 64923 RVA: 0x00249E0D File Offset: 0x0024800D
		public static IOverrideLookAtType Create(IOverrideLookAtType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOverrideLookAtType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F81 RID: 20353
		// (get) Token: 0x0600FD9C RID: 64924 RVA: 0x00249E2C File Offset: 0x0024802C
		public virtual EOverrideLookAtType Type
		{
			get
			{
				return (EOverrideLookAtType)this.Instance.Type;
			}
		}

		// Token: 0x04008A70 RID: 35440
		private IOverrideLookAtType Instance;
	}
}

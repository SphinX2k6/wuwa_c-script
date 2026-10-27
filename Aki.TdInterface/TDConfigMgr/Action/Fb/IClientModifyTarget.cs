using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002959 RID: 10585
	public class IClientModifyTarget
	{
		// Token: 0x0600EAB7 RID: 60087 RVA: 0x00225E0C File Offset: 0x0022400C
		[NullableContext(1)]
		public static IClientModifyTarget Create(IClientModifyTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientModifyTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049C7 RID: 18887
		// (get) Token: 0x0600EAB8 RID: 60088 RVA: 0x00225E2B File Offset: 0x0022402B
		public virtual EClientModifyTargetType Type
		{
			get
			{
				return (EClientModifyTargetType)this.Instance.Type;
			}
		}

		// Token: 0x04008157 RID: 33111
		private IClientModifyTarget Instance;
	}
}

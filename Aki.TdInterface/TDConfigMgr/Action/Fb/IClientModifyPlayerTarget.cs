using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200295B RID: 10587
	public class IClientModifyPlayerTarget : IClientModifyTarget
	{
		// Token: 0x0600EABD RID: 60093 RVA: 0x00225E74 File Offset: 0x00224074
		[NullableContext(1)]
		public static IClientModifyPlayerTarget Create(IClientModifyPlayerTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientModifyPlayerTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049C9 RID: 18889
		// (get) Token: 0x0600EABE RID: 60094 RVA: 0x00225E93 File Offset: 0x00224093
		public override EClientModifyTargetType Type
		{
			get
			{
				return (EClientModifyTargetType)this.Instance.Type;
			}
		}

		// Token: 0x04008159 RID: 33113
		private IClientModifyPlayerTarget Instance;
	}
}

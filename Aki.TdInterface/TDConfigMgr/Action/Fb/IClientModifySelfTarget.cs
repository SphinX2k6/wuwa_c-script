using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200295A RID: 10586
	public class IClientModifySelfTarget : IClientModifyTarget
	{
		// Token: 0x0600EABA RID: 60090 RVA: 0x00225E40 File Offset: 0x00224040
		[NullableContext(1)]
		public static IClientModifySelfTarget Create(IClientModifySelfTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientModifySelfTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049C8 RID: 18888
		// (get) Token: 0x0600EABB RID: 60091 RVA: 0x00225E5F File Offset: 0x0022405F
		public override EClientModifyTargetType Type
		{
			get
			{
				return (EClientModifyTargetType)this.Instance.Type;
			}
		}

		// Token: 0x04008158 RID: 33112
		private IClientModifySelfTarget Instance;
	}
}

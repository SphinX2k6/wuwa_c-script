using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029BB RID: 10683
	public class IGroupAiCommunicateMode
	{
		// Token: 0x0600EC97 RID: 60567 RVA: 0x0022D12C File Offset: 0x0022B32C
		public static IGroupAiCommunicateMode Create(IGroupAiCommunicateMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupAiCommunicateMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045CF RID: 17871
		// (get) Token: 0x0600EC98 RID: 60568 RVA: 0x0022D14B File Offset: 0x0022B34B
		public virtual EGroupAiCommunicateType Type
		{
			get
			{
				return (EGroupAiCommunicateType)this.Instance.Type;
			}
		}

		// Token: 0x0400823D RID: 33341
		private IGroupAiCommunicateMode Instance;
	}
}

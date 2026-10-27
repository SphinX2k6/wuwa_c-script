using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026F5 RID: 9973
	public class IGroupAiCommunicateMode
	{
		// Token: 0x0600DEAF RID: 57007 RVA: 0x002107C4 File Offset: 0x0020E9C4
		[NullableContext(1)]
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

		// Token: 0x17004287 RID: 17031
		// (get) Token: 0x0600DEB0 RID: 57008 RVA: 0x002107E3 File Offset: 0x0020E9E3
		public virtual EGroupAiCommunicateType Type
		{
			get
			{
				return (EGroupAiCommunicateType)this.Instance.Type;
			}
		}

		// Token: 0x04007B99 RID: 31641
		private IGroupAiCommunicateMode Instance;
	}
}

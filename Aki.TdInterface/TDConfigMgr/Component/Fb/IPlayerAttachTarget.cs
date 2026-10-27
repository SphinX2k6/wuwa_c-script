using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C7F RID: 3199
	public class IPlayerAttachTarget : IAttachTarget
	{
		// Token: 0x06004943 RID: 18755 RVA: 0x000B7CDB File Offset: 0x000B5EDB
		[NullableContext(1)]
		public static IPlayerAttachTarget Create(IPlayerAttachTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerAttachTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001602 RID: 5634
		// (get) Token: 0x06004944 RID: 18756 RVA: 0x000B7CFA File Offset: 0x000B5EFA
		public override EAttachType Type
		{
			get
			{
				return (EAttachType)this.Instance.Type;
			}
		}

		// Token: 0x040029CC RID: 10700
		private IPlayerAttachTarget Instance;
	}
}

using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D5D RID: 3421
	public class IDynamicAttachTarget : IAttachTarget
	{
		// Token: 0x06004DDF RID: 19935 RVA: 0x000C24AB File Offset: 0x000C06AB
		public static IDynamicAttachTarget Create(IDynamicAttachTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDynamicAttachTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001720 RID: 5920
		// (get) Token: 0x06004DE0 RID: 19936 RVA: 0x000C24CA File Offset: 0x000C06CA
		public override EAttachType Type
		{
			get
			{
				return (EAttachType)this.Instance.Type;
			}
		}

		// Token: 0x04002C38 RID: 11320
		private IDynamicAttachTarget Instance;
	}
}

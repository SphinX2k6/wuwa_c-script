using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E13 RID: 3603
	public class IConnectorPathAdvanceVisual
	{
		// Token: 0x060051A1 RID: 20897 RVA: 0x000CA0F0 File Offset: 0x000C82F0
		public static IConnectorPathAdvanceVisual Create(IConnectorPathAdvanceVisual? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConnectorPathAdvanceVisual
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001976 RID: 6518
		// (get) Token: 0x060051A2 RID: 20898 RVA: 0x000CA10F File Offset: 0x000C830F
		public virtual EConnectorPathAdvanceVisualType Type
		{
			get
			{
				return (EConnectorPathAdvanceVisualType)this.Instance.Type;
			}
		}

		// Token: 0x04002E8E RID: 11918
		private IConnectorPathAdvanceVisual Instance;
	}
}

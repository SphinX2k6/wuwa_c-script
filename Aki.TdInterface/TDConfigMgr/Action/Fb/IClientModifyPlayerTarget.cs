using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C40 RID: 11328
	public class IClientModifyPlayerTarget : IClientModifyTarget
	{
		// Token: 0x0600F933 RID: 63795 RVA: 0x0024352C File Offset: 0x0024172C
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

		// Token: 0x17004D61 RID: 19809
		// (get) Token: 0x0600F934 RID: 63796 RVA: 0x0024354B File Offset: 0x0024174B
		public override EClientModifyTargetType Type
		{
			get
			{
				return (EClientModifyTargetType)this.Instance.Type;
			}
		}

		// Token: 0x0400883A RID: 34874
		private IClientModifyPlayerTarget Instance;
	}
}

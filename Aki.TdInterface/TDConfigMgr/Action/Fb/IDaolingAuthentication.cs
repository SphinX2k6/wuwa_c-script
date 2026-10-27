using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002868 RID: 10344
	public class IDaolingAuthentication : IUiGame
	{
		// Token: 0x0600E53F RID: 58687 RVA: 0x0021B722 File Offset: 0x00219922
		[NullableContext(1)]
		public static IDaolingAuthentication Create(IDaolingAuthentication? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDaolingAuthentication
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004631 RID: 17969
		// (get) Token: 0x0600E540 RID: 58688 RVA: 0x0021B741 File Offset: 0x00219941
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x04007ECA RID: 32458
		private IDaolingAuthentication Instance;
	}
}

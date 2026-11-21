using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028E9 RID: 10473
	public class ICharacterLookAtEmptyData : ICharacterLookAtData
	{
		// Token: 0x0600E913 RID: 59667 RVA: 0x00226DFE File Offset: 0x00224FFE
		public static ICharacterLookAtEmptyData Create(ICharacterLookAtEmptyData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICharacterLookAtEmptyData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043EF RID: 17391
		// (get) Token: 0x0600E914 RID: 59668 RVA: 0x00226E1D File Offset: 0x0022501D
		public override ECharacterLookAt Type
		{
			get
			{
				return (ECharacterLookAt)this.Instance.Type;
			}
		}

		// Token: 0x0400806B RID: 32875
		private ICharacterLookAtEmptyData Instance;
	}
}

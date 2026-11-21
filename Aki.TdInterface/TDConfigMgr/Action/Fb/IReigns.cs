using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B0F RID: 11023
	public class IReigns : IUiGame
	{
		// Token: 0x0600F281 RID: 62081 RVA: 0x00236BC6 File Offset: 0x00234DC6
		public static IReigns Create(IReigns? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IReigns
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004911 RID: 18705
		// (get) Token: 0x0600F282 RID: 62082 RVA: 0x00236BE5 File Offset: 0x00234DE5
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x17004912 RID: 18706
		// (get) Token: 0x0600F283 RID: 62083 RVA: 0x00236BF2 File Offset: 0x00234DF2
		public virtual int ReignsId
		{
			get
			{
				return this.Instance.ReignsId;
			}
		}

		// Token: 0x04008515 RID: 34069
		private IReigns Instance;
	}
}

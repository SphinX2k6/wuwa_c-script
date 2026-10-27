using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002749 RID: 10057
	public class ICommonTipId : ICommonTipType
	{
		// Token: 0x0600E01C RID: 57372 RVA: 0x00212B73 File Offset: 0x00210D73
		[NullableContext(1)]
		public static ICommonTipId Create(ICommonTipId? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipId
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700434C RID: 17228
		// (get) Token: 0x0600E01D RID: 57373 RVA: 0x00212B92 File Offset: 0x00210D92
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x1700434D RID: 17229
		// (get) Token: 0x0600E01E RID: 57374 RVA: 0x00212B9F File Offset: 0x00210D9F
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04007C47 RID: 31815
		private ICommonTipId Instance;
	}
}

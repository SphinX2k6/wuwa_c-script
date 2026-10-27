using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B06 RID: 11014
	[NullableContext(2)]
	[Nullable(0)]
	public class IControlElementalBoxReturn : IControlElementalBoxTypeBase
	{
		// Token: 0x0600F131 RID: 61745 RVA: 0x0022FBDE File Offset: 0x0022DDDE
		[NullableContext(1)]
		public static IControlElementalBoxReturn Create(IControlElementalBoxReturn? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IControlElementalBoxReturn
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CE7 RID: 19687
		// (get) Token: 0x0600F132 RID: 61746 RVA: 0x0022FBFD File Offset: 0x0022DDFD
		public override EControlElementalBoxType Type
		{
			get
			{
				return (EControlElementalBoxType)this.Instance.Type;
			}
		}

		// Token: 0x17004CE8 RID: 19688
		// (get) Token: 0x0600F133 RID: 61747 RVA: 0x0022FC0A File Offset: 0x0022DE0A
		public virtual string ReturnBeforeMoveSeq
		{
			get
			{
				return this.Instance.ReturnBeforeMoveSeq;
			}
		}

		// Token: 0x040084A6 RID: 33958
		private IControlElementalBoxReturn Instance;
	}
}

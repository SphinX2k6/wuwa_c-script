using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DFA RID: 11770
	public class IControlElementalBoxReturn : IControlElementalBoxTypeBase
	{
		// Token: 0x0600FFE7 RID: 65511 RVA: 0x0024D8EA File Offset: 0x0024BAEA
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

		// Token: 0x170050A1 RID: 20641
		// (get) Token: 0x0600FFE8 RID: 65512 RVA: 0x0024D909 File Offset: 0x0024BB09
		public override EControlElementalBoxType Type
		{
			get
			{
				return (EControlElementalBoxType)this.Instance.Type;
			}
		}

		// Token: 0x170050A2 RID: 20642
		// (get) Token: 0x0600FFE9 RID: 65513 RVA: 0x0024D916 File Offset: 0x0024BB16
		[Nullable(2)]
		public virtual string ReturnBeforeMoveSeq
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.ReturnBeforeMoveSeq;
			}
		}

		// Token: 0x04008BAA RID: 35754
		private IControlElementalBoxReturn Instance;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002757 RID: 10071
	[NullableContext(1)]
	[Nullable(0)]
	public class IGreatSwordChallenge : ICommonTipType
	{
		// Token: 0x0600E062 RID: 57442 RVA: 0x00212FBC File Offset: 0x002111BC
		public static IGreatSwordChallenge Create(IGreatSwordChallenge? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGreatSwordChallenge
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004376 RID: 17270
		// (get) Token: 0x0600E063 RID: 57443 RVA: 0x00212FDB File Offset: 0x002111DB
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x17004377 RID: 17271
		// (get) Token: 0x0600E064 RID: 57444 RVA: 0x00212FE8 File Offset: 0x002111E8
		public virtual string MainText
		{
			get
			{
				return this.Instance.MainText;
			}
		}

		// Token: 0x17004378 RID: 17272
		// (get) Token: 0x0600E065 RID: 57445 RVA: 0x00212FF5 File Offset: 0x002111F5
		public virtual string SubText
		{
			get
			{
				return this.Instance.SubText;
			}
		}

		// Token: 0x04007C55 RID: 31829
		private IGreatSwordChallenge Instance;
	}
}

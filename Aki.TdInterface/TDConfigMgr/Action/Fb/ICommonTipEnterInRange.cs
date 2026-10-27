using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200274B RID: 10059
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonTipEnterInRange : ICommonTipType
	{
		// Token: 0x0600E023 RID: 57379 RVA: 0x00212BE8 File Offset: 0x00210DE8
		public static ICommonTipEnterInRange Create(ICommonTipEnterInRange? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipEnterInRange
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700434F RID: 17231
		// (get) Token: 0x0600E024 RID: 57380 RVA: 0x00212C07 File Offset: 0x00210E07
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x17004350 RID: 17232
		// (get) Token: 0x0600E025 RID: 57381 RVA: 0x00212C14 File Offset: 0x00210E14
		public virtual string TidText
		{
			get
			{
				return this.Instance.TidText;
			}
		}

		// Token: 0x17004351 RID: 17233
		// (get) Token: 0x0600E026 RID: 57382 RVA: 0x00212C21 File Offset: 0x00210E21
		[Nullable(2)]
		public virtual string EdTidText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04007C49 RID: 31817
		private ICommonTipEnterInRange Instance;
	}
}

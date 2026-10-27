using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002808 RID: 10248
	[NullableContext(1)]
	[Nullable(0)]
	public class IFoxReversePush : ILeisureInteractType
	{
		// Token: 0x0600E36A RID: 58218 RVA: 0x00218582 File Offset: 0x00216782
		public static IFoxReversePush Create(IFoxReversePush? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFoxReversePush
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700451C RID: 17692
		// (get) Token: 0x0600E36B RID: 58219 RVA: 0x002185A1 File Offset: 0x002167A1
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x1700451D RID: 17693
		// (get) Token: 0x0600E36C RID: 58220 RVA: 0x002185AE File Offset: 0x002167AE
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x1700451E RID: 17694
		// (get) Token: 0x0600E36D RID: 58221 RVA: 0x002185BB File Offset: 0x002167BB
		public virtual int SeqEntityId
		{
			get
			{
				return this.Instance.SeqEntityId;
			}
		}

		// Token: 0x1700451F RID: 17695
		// (get) Token: 0x0600E36E RID: 58222 RVA: 0x002185C8 File Offset: 0x002167C8
		public virtual string SliderTag
		{
			get
			{
				return this.Instance.SliderTag;
			}
		}

		// Token: 0x17004520 RID: 17696
		// (get) Token: 0x0600E36F RID: 58223 RVA: 0x002185D5 File Offset: 0x002167D5
		public virtual float Radius
		{
			get
			{
				return this.Instance.Radius;
			}
		}

		// Token: 0x04007DEC RID: 32236
		private IFoxReversePush Instance;
	}
}

using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ADB RID: 10971
	public class IFoxReversePush : ILeisureInteractType
	{
		// Token: 0x0600F18F RID: 61839 RVA: 0x002353E6 File Offset: 0x002335E6
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

		// Token: 0x17004887 RID: 18567
		// (get) Token: 0x0600F190 RID: 61840 RVA: 0x00235405 File Offset: 0x00233605
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x17004888 RID: 18568
		// (get) Token: 0x0600F191 RID: 61841 RVA: 0x00235412 File Offset: 0x00233612
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x17004889 RID: 18569
		// (get) Token: 0x0600F192 RID: 61842 RVA: 0x0023541F File Offset: 0x0023361F
		public virtual int SeqEntityId
		{
			get
			{
				return this.Instance.SeqEntityId;
			}
		}

		// Token: 0x1700488A RID: 18570
		// (get) Token: 0x0600F193 RID: 61843 RVA: 0x0023542C File Offset: 0x0023362C
		public virtual string SliderTag
		{
			get
			{
				return this.Instance.SliderTag;
			}
		}

		// Token: 0x1700488B RID: 18571
		// (get) Token: 0x0600F194 RID: 61844 RVA: 0x00235439 File Offset: 0x00233639
		public virtual float Radius
		{
			get
			{
				return this.Instance.Radius;
			}
		}

		// Token: 0x040084A9 RID: 33961
		private IFoxReversePush Instance;
	}
}

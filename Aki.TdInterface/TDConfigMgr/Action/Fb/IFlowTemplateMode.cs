using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A41 RID: 10817
	public class IFlowTemplateMode
	{
		// Token: 0x0600EEED RID: 61165 RVA: 0x00230655 File Offset: 0x0022E855
		public static IFlowTemplateMode Create(IFlowTemplateMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowTemplateMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004719 RID: 18201
		// (get) Token: 0x0600EEEE RID: 61166 RVA: 0x00230674 File Offset: 0x0022E874
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x1700471A RID: 18202
		// (get) Token: 0x0600EEEF RID: 61167 RVA: 0x00230681 File Offset: 0x0022E881
		public virtual int CameraId
		{
			get
			{
				return this.Instance.CameraId;
			}
		}

		// Token: 0x04008333 RID: 33587
		private IFlowTemplateMode Instance;
	}
}

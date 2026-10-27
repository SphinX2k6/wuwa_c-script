using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200276F RID: 10095
	public class IFlowTemplateMode
	{
		// Token: 0x0600E0CF RID: 57551 RVA: 0x002138C1 File Offset: 0x00211AC1
		[NullableContext(1)]
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

		// Token: 0x170043B3 RID: 17331
		// (get) Token: 0x0600E0D0 RID: 57552 RVA: 0x002138E0 File Offset: 0x00211AE0
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x170043B4 RID: 17332
		// (get) Token: 0x0600E0D1 RID: 57553 RVA: 0x002138ED File Offset: 0x00211AED
		public virtual int CameraId
		{
			get
			{
				return this.Instance.CameraId;
			}
		}

		// Token: 0x04007C7D RID: 31869
		private IFlowTemplateMode Instance;
	}
}

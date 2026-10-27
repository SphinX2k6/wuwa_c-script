using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B05 RID: 11013
	[NullableContext(2)]
	[Nullable(0)]
	public class IControlElementalBoxCapture : IControlElementalBoxTypeBase
	{
		// Token: 0x0600F12D RID: 61741 RVA: 0x0022FB9D File Offset: 0x0022DD9D
		[NullableContext(1)]
		public static IControlElementalBoxCapture Create(IControlElementalBoxCapture? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IControlElementalBoxCapture
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CE5 RID: 19685
		// (get) Token: 0x0600F12E RID: 61742 RVA: 0x0022FBBC File Offset: 0x0022DDBC
		public override EControlElementalBoxType Type
		{
			get
			{
				return (EControlElementalBoxType)this.Instance.Type;
			}
		}

		// Token: 0x17004CE6 RID: 19686
		// (get) Token: 0x0600F12F RID: 61743 RVA: 0x0022FBC9 File Offset: 0x0022DDC9
		public virtual string CaptureCompleteSeq
		{
			get
			{
				return this.Instance.CaptureCompleteSeq;
			}
		}

		// Token: 0x040084A5 RID: 33957
		private IControlElementalBoxCapture Instance;
	}
}

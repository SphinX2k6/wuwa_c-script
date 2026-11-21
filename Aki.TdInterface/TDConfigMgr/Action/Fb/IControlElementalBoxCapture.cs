using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DF9 RID: 11769
	public class IControlElementalBoxCapture : IControlElementalBoxTypeBase
	{
		// Token: 0x0600FFE3 RID: 65507 RVA: 0x0024D8A9 File Offset: 0x0024BAA9
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

		// Token: 0x1700509F RID: 20639
		// (get) Token: 0x0600FFE4 RID: 65508 RVA: 0x0024D8C8 File Offset: 0x0024BAC8
		public override EControlElementalBoxType Type
		{
			get
			{
				return (EControlElementalBoxType)this.Instance.Type;
			}
		}

		// Token: 0x170050A0 RID: 20640
		// (get) Token: 0x0600FFE5 RID: 65509 RVA: 0x0024D8D5 File Offset: 0x0024BAD5
		[Nullable(2)]
		public virtual string CaptureCompleteSeq
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.CaptureCompleteSeq;
			}
		}

		// Token: 0x04008BA9 RID: 35753
		private IControlElementalBoxCapture Instance;
	}
}

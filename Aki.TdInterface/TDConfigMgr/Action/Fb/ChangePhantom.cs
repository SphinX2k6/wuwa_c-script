using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200288B RID: 10379
	public class ChangePhantom : ActionParams
	{
		// Token: 0x0600E5EB RID: 58859 RVA: 0x0021CBAC File Offset: 0x0021ADAC
		[NullableContext(1)]
		public static ChangePhantom Create(IChangePhantom? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangePhantom
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004697 RID: 18071
		// (get) Token: 0x0600E5EC RID: 58860 RVA: 0x0021CBCB File Offset: 0x0021ADCB
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04007F1D RID: 32541
		private IChangePhantom Instance;
	}
}

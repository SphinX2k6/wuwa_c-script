using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002770 RID: 10096
	public class IEaseData
	{
		// Token: 0x0600E0D3 RID: 57555 RVA: 0x00213902 File Offset: 0x00211B02
		[NullableContext(1)]
		public static IEaseData Create(IEaseData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEaseData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043B5 RID: 17333
		// (get) Token: 0x0600E0D4 RID: 57556 RVA: 0x00213921 File Offset: 0x00211B21
		public virtual EEaseType Type
		{
			get
			{
				return (EEaseType)this.Instance.Type;
			}
		}

		// Token: 0x170043B6 RID: 17334
		// (get) Token: 0x0600E0D5 RID: 57557 RVA: 0x0021392E File Offset: 0x00211B2E
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x04007C7E RID: 31870
		private IEaseData Instance;
	}
}

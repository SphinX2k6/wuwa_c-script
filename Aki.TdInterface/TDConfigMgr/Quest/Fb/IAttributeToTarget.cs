using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200138D RID: 5005
	public class IAttributeToTarget
	{
		// Token: 0x0600727C RID: 29308 RVA: 0x001134D1 File Offset: 0x001116D1
		[NullableContext(1)]
		public static IAttributeToTarget Create(IAttributeToTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAttributeToTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002535 RID: 9525
		// (get) Token: 0x0600727D RID: 29309 RVA: 0x001134F0 File Offset: 0x001116F0
		public virtual EAttributeToTarget Type
		{
			get
			{
				return (EAttributeToTarget)this.Instance.Type;
			}
		}

		// Token: 0x0400422B RID: 16939
		private IAttributeToTarget Instance;
	}
}

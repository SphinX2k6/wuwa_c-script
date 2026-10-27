using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A70 RID: 10864
	public class IOverrideLookAtType
	{
		// Token: 0x0600EEE5 RID: 61157 RVA: 0x0022C101 File Offset: 0x0022A301
		[NullableContext(1)]
		public static IOverrideLookAtType Create(IOverrideLookAtType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOverrideLookAtType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BC7 RID: 19399
		// (get) Token: 0x0600EEE6 RID: 61158 RVA: 0x0022C120 File Offset: 0x0022A320
		public virtual EOverrideLookAtType Type
		{
			get
			{
				return (EOverrideLookAtType)this.Instance.Type;
			}
		}

		// Token: 0x0400836C RID: 33644
		private IOverrideLookAtType Instance;
	}
}

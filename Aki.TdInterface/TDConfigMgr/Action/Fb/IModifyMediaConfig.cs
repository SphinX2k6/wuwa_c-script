using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002904 RID: 10500
	public class IModifyMediaConfig
	{
		// Token: 0x0600E91F RID: 59679 RVA: 0x00223044 File Offset: 0x00221244
		[NullableContext(1)]
		public static IModifyMediaConfig Create(IModifyMediaConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModifyMediaConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048D9 RID: 18649
		// (get) Token: 0x0600E920 RID: 59680 RVA: 0x00223063 File Offset: 0x00221263
		public virtual EModifyActorMediaType Type
		{
			get
			{
				return (EModifyActorMediaType)this.Instance.Type;
			}
		}

		// Token: 0x040080B2 RID: 32946
		private IModifyMediaConfig Instance;
	}
}

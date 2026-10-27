using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200280D RID: 10253
	public class IMechStuntLevelFly : IMechStuntConfigType
	{
		// Token: 0x0600E37E RID: 58238 RVA: 0x002186EE File Offset: 0x002168EE
		[NullableContext(1)]
		public static IMechStuntLevelFly Create(IMechStuntLevelFly? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechStuntLevelFly
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004526 RID: 17702
		// (get) Token: 0x0600E37F RID: 58239 RVA: 0x0021870D File Offset: 0x0021690D
		public override EMechStuntType Type
		{
			get
			{
				return (EMechStuntType)this.Instance.Type;
			}
		}

		// Token: 0x04007DF3 RID: 32243
		private IMechStuntLevelFly Instance;
	}
}

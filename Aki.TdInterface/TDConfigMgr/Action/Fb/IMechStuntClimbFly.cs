using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200280C RID: 10252
	public class IMechStuntClimbFly : IMechStuntConfigType
	{
		// Token: 0x0600E37B RID: 58235 RVA: 0x002186BA File Offset: 0x002168BA
		[NullableContext(1)]
		public static IMechStuntClimbFly Create(IMechStuntClimbFly? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechStuntClimbFly
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004525 RID: 17701
		// (get) Token: 0x0600E37C RID: 58236 RVA: 0x002186D9 File Offset: 0x002168D9
		public override EMechStuntType Type
		{
			get
			{
				return (EMechStuntType)this.Instance.Type;
			}
		}

		// Token: 0x04007DF2 RID: 32242
		private IMechStuntClimbFly Instance;
	}
}

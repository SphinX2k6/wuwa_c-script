using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024DF RID: 9439
	public class FixFoundationRelation : ActionParams
	{
		// Token: 0x0600D2B9 RID: 53945 RVA: 0x001F419E File Offset: 0x001F239E
		[NullableContext(1)]
		public static FixFoundationRelation Create(IFixFoundationRelation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FixFoundationRelation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04007395 RID: 29589
		private IFixFoundationRelation Instance;
	}
}

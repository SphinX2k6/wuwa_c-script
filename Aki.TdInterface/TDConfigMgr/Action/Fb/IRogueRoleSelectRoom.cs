using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026C7 RID: 9927
	public class IRogueRoleSelectRoom : IRogueSelectRoomType
	{
		// Token: 0x0600DE00 RID: 56832 RVA: 0x0020F41D File Offset: 0x0020D61D
		[NullableContext(1)]
		public static IRogueRoleSelectRoom Create(IRogueRoleSelectRoom? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRogueRoleSelectRoom
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004234 RID: 16948
		// (get) Token: 0x0600DE01 RID: 56833 RVA: 0x0020F43C File Offset: 0x0020D63C
		public override ERogueSelectRoomType Type
		{
			get
			{
				return (ERogueSelectRoomType)this.Instance.Type;
			}
		}

		// Token: 0x04007B43 RID: 31555
		private IRogueRoleSelectRoom Instance;
	}
}

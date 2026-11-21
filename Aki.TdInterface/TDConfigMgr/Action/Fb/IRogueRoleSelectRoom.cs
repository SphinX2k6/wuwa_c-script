using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200298B RID: 10635
	public class IRogueRoleSelectRoom : IRogueSelectRoomType
	{
		// Token: 0x0600EBDC RID: 60380 RVA: 0x0022BC5D File Offset: 0x00229E5D
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

		// Token: 0x17004574 RID: 17780
		// (get) Token: 0x0600EBDD RID: 60381 RVA: 0x0022BC7C File Offset: 0x00229E7C
		public override ERogueSelectRoomType Type
		{
			get
			{
				return (ERogueSelectRoomType)this.Instance.Type;
			}
		}

		// Token: 0x040081E3 RID: 33251
		private IRogueRoleSelectRoom Instance;
	}
}

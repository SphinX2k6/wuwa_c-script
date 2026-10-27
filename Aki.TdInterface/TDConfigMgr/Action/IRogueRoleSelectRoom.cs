using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DC8 RID: 7624
	[NullableContext(1)]
	[Nullable(0)]
	public class IRogueRoleSelectRoom : IRogueSelectRoomType
	{
		// Token: 0x0600A34B RID: 41803 RVA: 0x00172E40 File Offset: 0x00171040
		private IRogueRoleSelectRoom_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRogueRoleSelectRoom 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRogueRoleSelectRoom_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRogueRoleSelectRoom_SetValue());
			}
			return result;
		}

		// Token: 0x0600A34C RID: 41804 RVA: 0x00172E78 File Offset: 0x00171078
		public static IRogueRoleSelectRoom Create([Nullable(2)] IRogueRoleSelectRoom instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRogueRoleSelectRoom
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A34D RID: 41805 RVA: 0x00172E8B File Offset: 0x0017108B
		public static IRogueRoleSelectRoom CreateFromSetValue([Nullable(2)] IRogueRoleSelectRoom_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRogueRoleSelectRoom
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A34E RID: 41806 RVA: 0x00172E9E File Offset: 0x0017109E
		public new IRogueRoleSelectRoom_SetValue ToSetValue()
		{
			return new IRogueRoleSelectRoom_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003250 RID: 12880
		// (get) Token: 0x0600A34F RID: 41807 RVA: 0x00172EB1 File Offset: 0x001710B1
		// (set) Token: 0x0600A350 RID: 41808 RVA: 0x00172EDC File Offset: 0x001710DC
		public override ERogueSelectRoomType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERogueSelectRoomType.Role;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040061EF RID: 25071
		[Nullable(2)]
		protected new IRogueRoleSelectRoom FbInstance;

		// Token: 0x040061F0 RID: 25072
		[Nullable(2)]
		protected new IRogueRoleSelectRoom_SetValue PocoInterface;
	}
}

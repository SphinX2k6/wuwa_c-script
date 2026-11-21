using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FE1 RID: 8161
	public class IRogueSelectRoomType
	{
		// Token: 0x0600AD5D RID: 44381 RVA: 0x00187624 File Offset: 0x00185824
		private IRogueSelectRoomType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRogueSelectRoomType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRogueSelectRoomType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRogueSelectRoomType_SetValue());
			}
			return result;
		}

		// Token: 0x0600AD5E RID: 44382 RVA: 0x0018765C File Offset: 0x0018585C
		public static IRogueSelectRoomType Create([Nullable(2)] IRogueSelectRoomType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRogueSelectRoomType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AD5F RID: 44383 RVA: 0x0018766F File Offset: 0x0018586F
		public static IRogueSelectRoomType CreateFromSetValue([Nullable(2)] IRogueSelectRoomType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRogueSelectRoomType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AD60 RID: 44384 RVA: 0x00187682 File Offset: 0x00185882
		public IRogueSelectRoomType_SetValue ToSetValue()
		{
			return new IRogueSelectRoomType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170034EB RID: 13547
		// (get) Token: 0x0600AD61 RID: 44385 RVA: 0x00187695 File Offset: 0x00185895
		// (set) Token: 0x0600AD62 RID: 44386 RVA: 0x001876C0 File Offset: 0x001858C0
		public virtual ERogueSelectRoomType Type
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

		// Token: 0x0400677A RID: 26490
		[Nullable(2)]
		protected IRogueSelectRoomType FbInstance;

		// Token: 0x0400677B RID: 26491
		[Nullable(2)]
		protected IRogueSelectRoomType_SetValue PocoInterface;
	}
}

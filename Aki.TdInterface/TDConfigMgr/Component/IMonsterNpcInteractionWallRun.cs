using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000579 RID: 1401
	public class IMonsterNpcInteractionWallRun : IMonsterNpcInteractionConfig
	{
		// Token: 0x06001C4E RID: 7246 RVA: 0x00051AC4 File Offset: 0x0004FCC4
		private IMonsterNpcInteractionWallRun_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMonsterNpcInteractionWallRun 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMonsterNpcInteractionWallRun_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMonsterNpcInteractionWallRun_SetValue());
			}
			return result;
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x00051AFC File Offset: 0x0004FCFC
		public static IMonsterNpcInteractionWallRun Create([Nullable(2)] IMonsterNpcInteractionWallRun instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterNpcInteractionWallRun
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x00051B0F File Offset: 0x0004FD0F
		public static IMonsterNpcInteractionWallRun CreateFromSetValue([Nullable(2)] IMonsterNpcInteractionWallRun_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMonsterNpcInteractionWallRun
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x00051B22 File Offset: 0x0004FD22
		public new IMonsterNpcInteractionWallRun_SetValue ToSetValue()
		{
			return new IMonsterNpcInteractionWallRun_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06001C52 RID: 7250 RVA: 0x00051B35 File Offset: 0x0004FD35
		// (set) Token: 0x06001C53 RID: 7251 RVA: 0x00051B60 File Offset: 0x0004FD60
		public override EMonsterNpcInteractionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMonsterNpcInteractionType.WallRun;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001481 RID: 5249
		[Nullable(2)]
		protected new IMonsterNpcInteractionWallRun FbInstance;

		// Token: 0x04001482 RID: 5250
		[Nullable(2)]
		protected new IMonsterNpcInteractionWallRun_SetValue PocoInterface;
	}
}

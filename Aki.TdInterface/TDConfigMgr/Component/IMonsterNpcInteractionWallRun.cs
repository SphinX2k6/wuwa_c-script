using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000512 RID: 1298
	[NullableContext(1)]
	[Nullable(0)]
	public class IMonsterNpcInteractionWallRun : IMonsterNpcInteractionConfig
	{
		// Token: 0x06001A52 RID: 6738 RVA: 0x0004CD08 File Offset: 0x0004AF08
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

		// Token: 0x06001A53 RID: 6739 RVA: 0x0004CD40 File Offset: 0x0004AF40
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

		// Token: 0x06001A54 RID: 6740 RVA: 0x0004CD53 File Offset: 0x0004AF53
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

		// Token: 0x06001A55 RID: 6741 RVA: 0x0004CD66 File Offset: 0x0004AF66
		public new IMonsterNpcInteractionWallRun_SetValue ToSetValue()
		{
			return new IMonsterNpcInteractionWallRun_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06001A56 RID: 6742 RVA: 0x0004CD79 File Offset: 0x0004AF79
		// (set) Token: 0x06001A57 RID: 6743 RVA: 0x0004CDA4 File Offset: 0x0004AFA4
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

		// Token: 0x04001317 RID: 4887
		[Nullable(2)]
		protected new IMonsterNpcInteractionWallRun FbInstance;

		// Token: 0x04001318 RID: 4888
		[Nullable(2)]
		protected new IMonsterNpcInteractionWallRun_SetValue PocoInterface;
	}
}

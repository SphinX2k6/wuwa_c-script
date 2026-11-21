using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001179 RID: 4473
	public class IPhotographTargetRolesOnScene : IPhotographTarget
	{
		// Token: 0x06006364 RID: 25444 RVA: 0x000EF3BC File Offset: 0x000ED5BC
		private IPhotographTargetRolesOnScene_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPhotographTargetRolesOnScene 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPhotographTargetRolesOnScene_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPhotographTargetRolesOnScene_SetValue());
			}
			return result;
		}

		// Token: 0x06006365 RID: 25445 RVA: 0x000EF3F4 File Offset: 0x000ED5F4
		public static IPhotographTargetRolesOnScene Create([Nullable(2)] IPhotographTargetRolesOnScene instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhotographTargetRolesOnScene
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006366 RID: 25446 RVA: 0x000EF407 File Offset: 0x000ED607
		public static IPhotographTargetRolesOnScene CreateFromSetValue([Nullable(2)] IPhotographTargetRolesOnScene_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPhotographTargetRolesOnScene
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006367 RID: 25447 RVA: 0x000EF41A File Offset: 0x000ED61A
		public new IPhotographTargetRolesOnScene_SetValue ToSetValue()
		{
			return new IPhotographTargetRolesOnScene_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002079 RID: 8313
		// (get) Token: 0x06006368 RID: 25448 RVA: 0x000EF42D File Offset: 0x000ED62D
		// (set) Token: 0x06006369 RID: 25449 RVA: 0x000EF458 File Offset: 0x000ED658
		public override EPhotographTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPhotographTargetType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003B8D RID: 15245
		[Nullable(2)]
		protected new IPhotographTargetRolesOnScene FbInstance;

		// Token: 0x04003B8E RID: 15246
		[Nullable(2)]
		protected new IPhotographTargetRolesOnScene_SetValue PocoInterface;
	}
}

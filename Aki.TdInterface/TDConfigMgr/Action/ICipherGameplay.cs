using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200189A RID: 6298
	[NullableContext(1)]
	[Nullable(0)]
	public class ICipherGameplay : IUiGame
	{
		// Token: 0x0600873B RID: 34619 RVA: 0x00140BCC File Offset: 0x0013EDCC
		private ICipherGameplay_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICipherGameplay 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICipherGameplay_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICipherGameplay_SetValue());
			}
			return result;
		}

		// Token: 0x0600873C RID: 34620 RVA: 0x00140C04 File Offset: 0x0013EE04
		public static ICipherGameplay Create([Nullable(2)] ICipherGameplay instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICipherGameplay
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600873D RID: 34621 RVA: 0x00140C17 File Offset: 0x0013EE17
		public static ICipherGameplay CreateFromSetValue([Nullable(2)] ICipherGameplay_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICipherGameplay
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600873E RID: 34622 RVA: 0x00140C2A File Offset: 0x0013EE2A
		public new ICipherGameplay_SetValue ToSetValue()
		{
			return new ICipherGameplay_SetValue
			{
				Type = this.Type,
				CipherId = this.CipherId
			};
		}

		// Token: 0x17002C0B RID: 11275
		// (get) Token: 0x0600873F RID: 34623 RVA: 0x00140C49 File Offset: 0x0013EE49
		// (set) Token: 0x06008740 RID: 34624 RVA: 0x00140C74 File Offset: 0x0013EE74
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002C0C RID: 11276
		// (get) Token: 0x06008741 RID: 34625 RVA: 0x00140C82 File Offset: 0x0013EE82
		// (set) Token: 0x06008742 RID: 34626 RVA: 0x00140CAD File Offset: 0x0013EEAD
		public virtual string CipherId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CipherId;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.CipherId;
			}
			set
			{
				this.GetOrCreatePoco().CipherId = value;
			}
		}

		// Token: 0x04005528 RID: 21800
		[Nullable(2)]
		protected new ICipherGameplay FbInstance;

		// Token: 0x04005529 RID: 21801
		[Nullable(2)]
		protected new ICipherGameplay_SetValue PocoInterface;
	}
}

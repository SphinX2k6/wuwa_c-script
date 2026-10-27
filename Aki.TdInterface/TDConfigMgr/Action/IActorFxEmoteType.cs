using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001774 RID: 6004
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorFxEmoteType
	{
		// Token: 0x06007F1F RID: 32543 RVA: 0x00130108 File Offset: 0x0012E308
		private IActorFxEmoteType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorFxEmoteType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorFxEmoteType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorFxEmoteType_SetValue());
			}
			return result;
		}

		// Token: 0x06007F20 RID: 32544 RVA: 0x00130140 File Offset: 0x0012E340
		public static IActorFxEmoteType Create([Nullable(2)] IActorFxEmoteType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorFxEmoteType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007F21 RID: 32545 RVA: 0x00130153 File Offset: 0x0012E353
		public static IActorFxEmoteType CreateFromSetValue([Nullable(2)] IActorFxEmoteType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorFxEmoteType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007F22 RID: 32546 RVA: 0x00130166 File Offset: 0x0012E366
		public IActorFxEmoteType_SetValue ToSetValue()
		{
			return new IActorFxEmoteType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170029B6 RID: 10678
		// (get) Token: 0x06007F23 RID: 32547 RVA: 0x00130179 File Offset: 0x0012E379
		// (set) Token: 0x06007F24 RID: 32548 RVA: 0x001301A4 File Offset: 0x0012E3A4
		public virtual EActorFxEmoteType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EActorFxEmoteType.Play;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040050DB RID: 20699
		[Nullable(2)]
		protected IActorFxEmoteType FbInstance;

		// Token: 0x040050DC RID: 20700
		[Nullable(2)]
		protected IActorFxEmoteType_SetValue PocoInterface;
	}
}

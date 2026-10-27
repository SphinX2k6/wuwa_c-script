using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200050E RID: 1294
	[NullableContext(1)]
	[Nullable(0)]
	public class IMonsterNpcInteractionHook : IMonsterNpcInteractionConfig
	{
		// Token: 0x06001A42 RID: 6722 RVA: 0x0004CB90 File Offset: 0x0004AD90
		private IMonsterNpcInteractionHook_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMonsterNpcInteractionHook 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMonsterNpcInteractionHook_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMonsterNpcInteractionHook_SetValue());
			}
			return result;
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x0004CBC8 File Offset: 0x0004ADC8
		public static IMonsterNpcInteractionHook Create([Nullable(2)] IMonsterNpcInteractionHook instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterNpcInteractionHook
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x0004CBDB File Offset: 0x0004ADDB
		public static IMonsterNpcInteractionHook CreateFromSetValue([Nullable(2)] IMonsterNpcInteractionHook_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMonsterNpcInteractionHook
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x0004CBEE File Offset: 0x0004ADEE
		public new IMonsterNpcInteractionHook_SetValue ToSetValue()
		{
			return new IMonsterNpcInteractionHook_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06001A46 RID: 6726 RVA: 0x0004CC01 File Offset: 0x0004AE01
		// (set) Token: 0x06001A47 RID: 6727 RVA: 0x0004CC2C File Offset: 0x0004AE2C
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

		// Token: 0x04001311 RID: 4881
		[Nullable(2)]
		protected new IMonsterNpcInteractionHook FbInstance;

		// Token: 0x04001312 RID: 4882
		[Nullable(2)]
		protected new IMonsterNpcInteractionHook_SetValue PocoInterface;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011DE RID: 4574
	[NullableContext(1)]
	[Nullable(0)]
	public class IUseCount : IProgressBarLeftType
	{
		// Token: 0x060067E4 RID: 26596 RVA: 0x000F8734 File Offset: 0x000F6934
		private IUseCount_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUseCount 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUseCount_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUseCount_SetValue());
			}
			return result;
		}

		// Token: 0x060067E5 RID: 26597 RVA: 0x000F876C File Offset: 0x000F696C
		public static IUseCount Create([Nullable(2)] IUseCount instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUseCount
			{
				FbInstance = instance
			};
		}

		// Token: 0x060067E6 RID: 26598 RVA: 0x000F877F File Offset: 0x000F697F
		public static IUseCount CreateFromSetValue([Nullable(2)] IUseCount_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUseCount
			{
				PocoInterface = value
			};
		}

		// Token: 0x060067E7 RID: 26599 RVA: 0x000F8792 File Offset: 0x000F6992
		public new IUseCount_SetValue ToSetValue()
		{
			return new IUseCount_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170021AA RID: 8618
		// (get) Token: 0x060067E8 RID: 26600 RVA: 0x000F87A5 File Offset: 0x000F69A5
		// (set) Token: 0x060067E9 RID: 26601 RVA: 0x000F87D0 File Offset: 0x000F69D0
		public override EProgressBarLeftType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EProgressBarLeftType.UseCount;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003E4B RID: 15947
		[Nullable(2)]
		protected new IUseCount FbInstance;

		// Token: 0x04003E4C RID: 15948
		[Nullable(2)]
		protected new IUseCount_SetValue PocoInterface;
	}
}

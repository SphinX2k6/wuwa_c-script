using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200054C RID: 1356
	[NullableContext(1)]
	[Nullable(0)]
	public class INoiseRemovalBoarderBase
	{
		// Token: 0x06001BC2 RID: 7106 RVA: 0x00050044 File Offset: 0x0004E244
		private INoiseRemovalBoarderBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INoiseRemovalBoarderBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INoiseRemovalBoarderBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INoiseRemovalBoarderBase_SetValue());
			}
			return result;
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x0005007C File Offset: 0x0004E27C
		public static INoiseRemovalBoarderBase Create([Nullable(2)] INoiseRemovalBoarderBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INoiseRemovalBoarderBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x0005008F File Offset: 0x0004E28F
		public static INoiseRemovalBoarderBase CreateFromSetValue([Nullable(2)] INoiseRemovalBoarderBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INoiseRemovalBoarderBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x000500A2 File Offset: 0x0004E2A2
		public INoiseRemovalBoarderBase_SetValue ToSetValue()
		{
			return new INoiseRemovalBoarderBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06001BC6 RID: 7110 RVA: 0x000500B5 File Offset: 0x0004E2B5
		// (set) Token: 0x06001BC7 RID: 7111 RVA: 0x000500E0 File Offset: 0x0004E2E0
		public virtual ENoiseRemovalBoarderShape Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENoiseRemovalBoarderShape.Box;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040013EE RID: 5102
		[Nullable(2)]
		protected INoiseRemovalBoarderBase FbInstance;

		// Token: 0x040013EF RID: 5103
		[Nullable(2)]
		protected INoiseRemovalBoarderBase_SetValue PocoInterface;
	}
}

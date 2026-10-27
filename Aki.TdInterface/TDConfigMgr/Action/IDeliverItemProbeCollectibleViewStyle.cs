using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001986 RID: 6534
	[NullableContext(1)]
	[Nullable(0)]
	public class IDeliverItemProbeCollectibleViewStyle
	{
		// Token: 0x06008BE9 RID: 35817 RVA: 0x00148A6C File Offset: 0x00146C6C
		private IDeliverItemProbeCollectibleViewStyle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDeliverItemProbeCollectibleViewStyle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDeliverItemProbeCollectibleViewStyle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDeliverItemProbeCollectibleViewStyle_SetValue());
			}
			return result;
		}

		// Token: 0x06008BEA RID: 35818 RVA: 0x00148AA4 File Offset: 0x00146CA4
		public static IDeliverItemProbeCollectibleViewStyle Create([Nullable(2)] IDeliverItemProbeCollectibleViewStyle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDeliverItemProbeCollectibleViewStyle
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008BEB RID: 35819 RVA: 0x00148AB7 File Offset: 0x00146CB7
		public static IDeliverItemProbeCollectibleViewStyle CreateFromSetValue([Nullable(2)] IDeliverItemProbeCollectibleViewStyle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDeliverItemProbeCollectibleViewStyle
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008BEC RID: 35820 RVA: 0x00148ACA File Offset: 0x00146CCA
		public IDeliverItemProbeCollectibleViewStyle_SetValue ToSetValue()
		{
			return new IDeliverItemProbeCollectibleViewStyle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D00 RID: 11520
		// (get) Token: 0x06008BED RID: 35821 RVA: 0x00148ADD File Offset: 0x00146CDD
		// (set) Token: 0x06008BEE RID: 35822 RVA: 0x00148B08 File Offset: 0x00146D08
		public virtual EDeliverItemProbeCollectibleViewStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDeliverItemProbeCollectibleViewStyle.HandInItemStyle;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005733 RID: 22323
		[Nullable(2)]
		protected IDeliverItemProbeCollectibleViewStyle FbInstance;

		// Token: 0x04005734 RID: 22324
		[Nullable(2)]
		protected IDeliverItemProbeCollectibleViewStyle_SetValue PocoInterface;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AEB RID: 6891
	[NullableContext(1)]
	[Nullable(0)]
	public class IHandInItemViewStyle : IDeliverItemProbeCollectibleViewStyle
	{
		// Token: 0x060093A4 RID: 37796 RVA: 0x00156798 File Offset: 0x00154998
		private IHandInItemViewStyle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHandInItemViewStyle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHandInItemViewStyle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHandInItemViewStyle_SetValue());
			}
			return result;
		}

		// Token: 0x060093A5 RID: 37797 RVA: 0x001567D0 File Offset: 0x001549D0
		public static IHandInItemViewStyle Create([Nullable(2)] IHandInItemViewStyle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHandInItemViewStyle
			{
				FbInstance = instance
			};
		}

		// Token: 0x060093A6 RID: 37798 RVA: 0x001567E3 File Offset: 0x001549E3
		public static IHandInItemViewStyle CreateFromSetValue([Nullable(2)] IHandInItemViewStyle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHandInItemViewStyle
			{
				PocoInterface = value
			};
		}

		// Token: 0x060093A7 RID: 37799 RVA: 0x001567F6 File Offset: 0x001549F6
		public new IHandInItemViewStyle_SetValue ToSetValue()
		{
			return new IHandInItemViewStyle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EC7 RID: 11975
		// (get) Token: 0x060093A8 RID: 37800 RVA: 0x00156809 File Offset: 0x00154A09
		// (set) Token: 0x060093A9 RID: 37801 RVA: 0x00156834 File Offset: 0x00154A34
		public override EDeliverItemProbeCollectibleViewStyle Type
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

		// Token: 0x04005AB0 RID: 23216
		[Nullable(2)]
		protected new IHandInItemViewStyle FbInstance;

		// Token: 0x04005AB1 RID: 23217
		[Nullable(2)]
		protected new IHandInItemViewStyle_SetValue PocoInterface;
	}
}

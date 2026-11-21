using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C98 RID: 7320
	public class IHandInItemViewStyle : IDeliverItemProbeCollectibleViewStyle
	{
		// Token: 0x06009B7E RID: 39806 RVA: 0x0016726C File Offset: 0x0016546C
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

		// Token: 0x06009B7F RID: 39807 RVA: 0x001672A4 File Offset: 0x001654A4
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

		// Token: 0x06009B80 RID: 39808 RVA: 0x001672B7 File Offset: 0x001654B7
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

		// Token: 0x06009B81 RID: 39809 RVA: 0x001672CA File Offset: 0x001654CA
		public new IHandInItemViewStyle_SetValue ToSetValue()
		{
			return new IHandInItemViewStyle_SetValue
			{
				Type = this.Type,
				TidDescText = this.TidDescText,
				EdTidDescText = this.EdTidDescText
			};
		}

		// Token: 0x170030E8 RID: 12520
		// (get) Token: 0x06009B82 RID: 39810 RVA: 0x001672F5 File Offset: 0x001654F5
		// (set) Token: 0x06009B83 RID: 39811 RVA: 0x00167320 File Offset: 0x00165520
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

		// Token: 0x170030E9 RID: 12521
		// (get) Token: 0x06009B84 RID: 39812 RVA: 0x0016732E File Offset: 0x0016552E
		// (set) Token: 0x06009B85 RID: 39813 RVA: 0x00167359 File Offset: 0x00165559
		public virtual string TidDescText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidDescText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidDescText;
			}
			set
			{
				this.GetOrCreatePoco().TidDescText = value;
			}
		}

		// Token: 0x170030EA RID: 12522
		// (get) Token: 0x06009B86 RID: 39814 RVA: 0x00167367 File Offset: 0x00165567
		// (set) Token: 0x06009B87 RID: 39815 RVA: 0x0016737E File Offset: 0x0016557E
		[Nullable(2)]
		public virtual string EdTidDescText
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidDescText;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidDescText = value;
			}
		}

		// Token: 0x04005F45 RID: 24389
		[Nullable(2)]
		protected new IHandInItemViewStyle FbInstance;

		// Token: 0x04005F46 RID: 24390
		[Nullable(2)]
		protected new IHandInItemViewStyle_SetValue PocoInterface;
	}
}

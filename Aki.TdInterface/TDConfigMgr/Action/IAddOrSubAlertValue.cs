using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017A8 RID: 6056
	[NullableContext(1)]
	[Nullable(0)]
	public class IAddOrSubAlertValue : ISetAlertValueType
	{
		// Token: 0x06008029 RID: 32809 RVA: 0x00131F10 File Offset: 0x00130110
		private IAddOrSubAlertValue_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAddOrSubAlertValue 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAddOrSubAlertValue_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAddOrSubAlertValue_SetValue());
			}
			return result;
		}

		// Token: 0x0600802A RID: 32810 RVA: 0x00131F48 File Offset: 0x00130148
		public static IAddOrSubAlertValue Create([Nullable(2)] IAddOrSubAlertValue instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAddOrSubAlertValue
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600802B RID: 32811 RVA: 0x00131F5B File Offset: 0x0013015B
		public static IAddOrSubAlertValue CreateFromSetValue([Nullable(2)] IAddOrSubAlertValue_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAddOrSubAlertValue
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600802C RID: 32812 RVA: 0x00131F6E File Offset: 0x0013016E
		public new IAddOrSubAlertValue_SetValue ToSetValue()
		{
			return new IAddOrSubAlertValue_SetValue
			{
				Type = this.Type,
				DeltaValue = this.DeltaValue
			};
		}

		// Token: 0x170029ED RID: 10733
		// (get) Token: 0x0600802D RID: 32813 RVA: 0x00131F8D File Offset: 0x0013018D
		// (set) Token: 0x0600802E RID: 32814 RVA: 0x00131FB8 File Offset: 0x001301B8
		public override EValueChangeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EValueChangeType.AddOrSub;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170029EE RID: 10734
		// (get) Token: 0x0600802F RID: 32815 RVA: 0x00131FC6 File Offset: 0x001301C6
		// (set) Token: 0x06008030 RID: 32816 RVA: 0x00131FF5 File Offset: 0x001301F5
		public virtual float DeltaValue
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DeltaValue;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.DeltaValue;
			}
			set
			{
				this.GetOrCreatePoco().DeltaValue = value;
			}
		}

		// Token: 0x04005158 RID: 20824
		[Nullable(2)]
		protected new IAddOrSubAlertValue FbInstance;

		// Token: 0x04005159 RID: 20825
		[Nullable(2)]
		protected new IAddOrSubAlertValue_SetValue PocoInterface;
	}
}

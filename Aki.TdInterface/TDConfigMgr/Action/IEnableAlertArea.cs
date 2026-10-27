using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019DA RID: 6618
	[NullableContext(2)]
	[Nullable(0)]
	public class IEnableAlertArea : IAlertSystemOption
	{
		// Token: 0x06008DBB RID: 36283 RVA: 0x0014BE60 File Offset: 0x0014A060
		[NullableContext(1)]
		private IEnableAlertArea_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnableAlertArea 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnableAlertArea_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnableAlertArea_SetValue());
			}
			return result;
		}

		// Token: 0x06008DBC RID: 36284 RVA: 0x0014BE98 File Offset: 0x0014A098
		[NullableContext(1)]
		public static IEnableAlertArea Create([Nullable(2)] IEnableAlertArea instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableAlertArea
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008DBD RID: 36285 RVA: 0x0014BEAB File Offset: 0x0014A0AB
		[NullableContext(1)]
		public static IEnableAlertArea CreateFromSetValue([Nullable(2)] IEnableAlertArea_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnableAlertArea
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008DBE RID: 36286 RVA: 0x0014BEBE File Offset: 0x0014A0BE
		[NullableContext(1)]
		public new IEnableAlertArea_SetValue ToSetValue()
		{
			return new IEnableAlertArea_SetValue
			{
				Type = this.Type,
				AreaId = this.AreaId,
				IsEnable = this.IsEnable,
				AutoDisableCondition = this.AutoDisableCondition
			};
		}

		// Token: 0x17002D6B RID: 11627
		// (get) Token: 0x06008DBF RID: 36287 RVA: 0x0014BEF5 File Offset: 0x0014A0F5
		// (set) Token: 0x06008DC0 RID: 36288 RVA: 0x0014BF20 File Offset: 0x0014A120
		public override EAlertSystemOption Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAlertSystemOption.EnableAlertArea;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002D6C RID: 11628
		// (get) Token: 0x06008DC1 RID: 36289 RVA: 0x0014BF2E File Offset: 0x0014A12E
		// (set) Token: 0x06008DC2 RID: 36290 RVA: 0x0014BF59 File Offset: 0x0014A159
		public override int AreaId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AreaId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.AreaId;
			}
			set
			{
				this.GetOrCreatePoco().AreaId = value;
			}
		}

		// Token: 0x17002D6D RID: 11629
		// (get) Token: 0x06008DC3 RID: 36291 RVA: 0x0014BF67 File Offset: 0x0014A167
		// (set) Token: 0x06008DC4 RID: 36292 RVA: 0x0014BF92 File Offset: 0x0014A192
		public virtual bool IsEnable
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsEnable;
				}
				return this.PocoInterface != null && this.PocoInterface.IsEnable;
			}
			set
			{
				this.GetOrCreatePoco().IsEnable = value;
			}
		}

		// Token: 0x17002D6E RID: 11630
		// (get) Token: 0x06008DC5 RID: 36293 RVA: 0x0014BFA0 File Offset: 0x0014A1A0
		// (set) Token: 0x06008DC6 RID: 36294 RVA: 0x0014BFC7 File Offset: 0x0014A1C7
		public virtual IDisableAlertAreaCondition AutoDisableCondition
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AutoDisableCondition;
				}
				IEnableAlertArea_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AutoDisableCondition;
			}
			set
			{
				this.GetOrCreatePoco().AutoDisableCondition = value;
			}
		}

		// Token: 0x04005800 RID: 22528
		protected new IEnableAlertArea FbInstance;

		// Token: 0x04005801 RID: 22529
		protected new IEnableAlertArea_SetValue PocoInterface;
	}
}

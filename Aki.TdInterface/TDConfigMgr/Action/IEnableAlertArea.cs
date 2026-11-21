using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B67 RID: 7015
	public class IEnableAlertArea : IAlertSystemOption
	{
		// Token: 0x060094FD RID: 38141 RVA: 0x0015B96C File Offset: 0x00159B6C
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

		// Token: 0x060094FE RID: 38142 RVA: 0x0015B9A4 File Offset: 0x00159BA4
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

		// Token: 0x060094FF RID: 38143 RVA: 0x0015B9B7 File Offset: 0x00159BB7
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

		// Token: 0x06009500 RID: 38144 RVA: 0x0015B9CA File Offset: 0x00159BCA
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

		// Token: 0x17002F70 RID: 12144
		// (get) Token: 0x06009501 RID: 38145 RVA: 0x0015BA01 File Offset: 0x00159C01
		// (set) Token: 0x06009502 RID: 38146 RVA: 0x0015BA2C File Offset: 0x00159C2C
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

		// Token: 0x17002F71 RID: 12145
		// (get) Token: 0x06009503 RID: 38147 RVA: 0x0015BA3A File Offset: 0x00159C3A
		// (set) Token: 0x06009504 RID: 38148 RVA: 0x0015BA65 File Offset: 0x00159C65
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

		// Token: 0x17002F72 RID: 12146
		// (get) Token: 0x06009505 RID: 38149 RVA: 0x0015BA73 File Offset: 0x00159C73
		// (set) Token: 0x06009506 RID: 38150 RVA: 0x0015BA9E File Offset: 0x00159C9E
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

		// Token: 0x17002F73 RID: 12147
		// (get) Token: 0x06009507 RID: 38151 RVA: 0x0015BAAC File Offset: 0x00159CAC
		// (set) Token: 0x06009508 RID: 38152 RVA: 0x0015BAD3 File Offset: 0x00159CD3
		[Nullable(2)]
		public virtual IDisableAlertAreaCondition AutoDisableCondition
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().AutoDisableCondition = value;
			}
		}

		// Token: 0x04005C55 RID: 23637
		[Nullable(2)]
		protected new IEnableAlertArea FbInstance;

		// Token: 0x04005C56 RID: 23638
		[Nullable(2)]
		protected new IEnableAlertArea_SetValue PocoInterface;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BE6 RID: 7142
	[NullableContext(2)]
	[Nullable(0)]
	public class IModifyAlertValue : IAlertSystemOption
	{
		// Token: 0x060098F3 RID: 39155 RVA: 0x00160400 File Offset: 0x0015E600
		[NullableContext(1)]
		private IModifyAlertValue_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IModifyAlertValue 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IModifyAlertValue_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IModifyAlertValue_SetValue());
			}
			return result;
		}

		// Token: 0x060098F4 RID: 39156 RVA: 0x00160438 File Offset: 0x0015E638
		[NullableContext(1)]
		public static IModifyAlertValue Create([Nullable(2)] IModifyAlertValue instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModifyAlertValue
			{
				FbInstance = instance
			};
		}

		// Token: 0x060098F5 RID: 39157 RVA: 0x0016044B File Offset: 0x0015E64B
		[NullableContext(1)]
		public static IModifyAlertValue CreateFromSetValue([Nullable(2)] IModifyAlertValue_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IModifyAlertValue
			{
				PocoInterface = value
			};
		}

		// Token: 0x060098F6 RID: 39158 RVA: 0x0016045E File Offset: 0x0015E65E
		[NullableContext(1)]
		public new IModifyAlertValue_SetValue ToSetValue()
		{
			return new IModifyAlertValue_SetValue
			{
				Type = this.Type,
				AreaId = this.AreaId,
				SetType = this.SetType,
				ChangeSpeed = this.ChangeSpeed
			};
		}

		// Token: 0x17002FF7 RID: 12279
		// (get) Token: 0x060098F7 RID: 39159 RVA: 0x00160495 File Offset: 0x0015E695
		// (set) Token: 0x060098F8 RID: 39160 RVA: 0x001604C0 File Offset: 0x0015E6C0
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

		// Token: 0x17002FF8 RID: 12280
		// (get) Token: 0x060098F9 RID: 39161 RVA: 0x001604CE File Offset: 0x0015E6CE
		// (set) Token: 0x060098FA RID: 39162 RVA: 0x001604F9 File Offset: 0x0015E6F9
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

		// Token: 0x17002FF9 RID: 12281
		// (get) Token: 0x060098FB RID: 39163 RVA: 0x00160507 File Offset: 0x0015E707
		// (set) Token: 0x060098FC RID: 39164 RVA: 0x0016052E File Offset: 0x0015E72E
		public virtual ISetAlertValueType SetType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SetType;
				}
				IModifyAlertValue_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SetType;
			}
			set
			{
				this.GetOrCreatePoco().SetType = value;
			}
		}

		// Token: 0x17002FFA RID: 12282
		// (get) Token: 0x060098FD RID: 39165 RVA: 0x0016053C File Offset: 0x0015E73C
		// (set) Token: 0x060098FE RID: 39166 RVA: 0x00160563 File Offset: 0x0015E763
		public virtual IAlertValueSpeedChangeType ChangeSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ChangeSpeed;
				}
				IModifyAlertValue_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ChangeSpeed;
			}
			set
			{
				this.GetOrCreatePoco().ChangeSpeed = value;
			}
		}

		// Token: 0x04005D34 RID: 23860
		protected new IModifyAlertValue FbInstance;

		// Token: 0x04005D35 RID: 23861
		protected new IModifyAlertValue_SetValue PocoInterface;
	}
}

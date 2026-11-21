using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DD5 RID: 7637
	[NullableContext(2)]
	[Nullable(0)]
	public class IModifyAlertValue : IAlertSystemOption
	{
		// Token: 0x0600A221 RID: 41505 RVA: 0x001732F8 File Offset: 0x001714F8
		[NullableContext(0)]
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

		// Token: 0x0600A222 RID: 41506 RVA: 0x00173330 File Offset: 0x00171530
		[NullableContext(0)]
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

		// Token: 0x0600A223 RID: 41507 RVA: 0x00173343 File Offset: 0x00171543
		[NullableContext(0)]
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

		// Token: 0x0600A224 RID: 41508 RVA: 0x00173356 File Offset: 0x00171556
		[NullableContext(0)]
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

		// Token: 0x1700325F RID: 12895
		// (get) Token: 0x0600A225 RID: 41509 RVA: 0x0017338D File Offset: 0x0017158D
		// (set) Token: 0x0600A226 RID: 41510 RVA: 0x001733B8 File Offset: 0x001715B8
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

		// Token: 0x17003260 RID: 12896
		// (get) Token: 0x0600A227 RID: 41511 RVA: 0x001733C6 File Offset: 0x001715C6
		// (set) Token: 0x0600A228 RID: 41512 RVA: 0x001733F1 File Offset: 0x001715F1
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

		// Token: 0x17003261 RID: 12897
		// (get) Token: 0x0600A229 RID: 41513 RVA: 0x001733FF File Offset: 0x001715FF
		// (set) Token: 0x0600A22A RID: 41514 RVA: 0x00173426 File Offset: 0x00171626
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

		// Token: 0x17003262 RID: 12898
		// (get) Token: 0x0600A22B RID: 41515 RVA: 0x00173434 File Offset: 0x00171634
		// (set) Token: 0x0600A22C RID: 41516 RVA: 0x0017345B File Offset: 0x0017165B
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

		// Token: 0x0400625A RID: 25178
		protected new IModifyAlertValue FbInstance;

		// Token: 0x0400625B RID: 25179
		protected new IModifyAlertValue_SetValue PocoInterface;
	}
}

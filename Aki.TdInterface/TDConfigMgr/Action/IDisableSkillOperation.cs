using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019B8 RID: 6584
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IDisableSkillOperationConverter))]
	public class IDisableSkillOperation : ISkillOperationType
	{
		// Token: 0x06008D11 RID: 36113 RVA: 0x0014AC70 File Offset: 0x00148E70
		private IDisableSkillOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDisableSkillOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDisableSkillOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDisableSkillOperation_SetValue());
			}
			return result;
		}

		// Token: 0x06008D12 RID: 36114 RVA: 0x0014ACA8 File Offset: 0x00148EA8
		public static IDisableSkillOperation Create([Nullable(2)] IDisableSkillOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableSkillOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008D13 RID: 36115 RVA: 0x0014ACBB File Offset: 0x00148EBB
		public static IDisableSkillOperation CreateFromSetValue([Nullable(2)] IDisableSkillOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDisableSkillOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008D14 RID: 36116 RVA: 0x0014ACCE File Offset: 0x00148ECE
		public new IDisableSkillOperation_SetValue ToSetValue()
		{
			return new IDisableSkillOperation_SetValue
			{
				Type = this.Type,
				DisplayMode = this.DisplayMode,
				DisableSkillWheel = this.DisableSkillWheel
			};
		}

		// Token: 0x17002D49 RID: 11593
		// (get) Token: 0x06008D15 RID: 36117 RVA: 0x0014ACF9 File Offset: 0x00148EF9
		// (set) Token: 0x06008D16 RID: 36118 RVA: 0x0014AD24 File Offset: 0x00148F24
		public override ESkillOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESkillOperationType.Enable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002D4A RID: 11594
		// (get) Token: 0x06008D17 RID: 36119 RVA: 0x0014AD34 File Offset: 0x00148F34
		// (set) Token: 0x06008D18 RID: 36120 RVA: 0x0014AD6E File Offset: 0x00148F6E
		public virtual EDisplayModeInSkillOp? DisplayMode
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisplayMode;
				}
				IDisableSkillOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisplayMode;
			}
			set
			{
				this.GetOrCreatePoco().DisplayMode = value;
			}
		}

		// Token: 0x17002D4B RID: 11595
		// (get) Token: 0x06008D19 RID: 36121 RVA: 0x0014AD7C File Offset: 0x00148F7C
		// (set) Token: 0x06008D1A RID: 36122 RVA: 0x0014ADB6 File Offset: 0x00148FB6
		public virtual bool? DisableSkillWheel
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableSkillWheel;
				}
				IDisableSkillOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableSkillWheel;
			}
			set
			{
				this.GetOrCreatePoco().DisableSkillWheel = value;
			}
		}

		// Token: 0x040057B6 RID: 22454
		[Nullable(2)]
		protected new IDisableSkillOperation FbInstance;

		// Token: 0x040057B7 RID: 22455
		[Nullable(2)]
		protected new IDisableSkillOperation_SetValue PocoInterface;
	}
}

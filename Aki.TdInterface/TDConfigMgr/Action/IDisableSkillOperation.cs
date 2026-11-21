using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B45 RID: 6981
	[JsonConverter(typeof(IDisableSkillOperationConverter))]
	public class IDisableSkillOperation : ISkillOperationType
	{
		// Token: 0x06009453 RID: 37971 RVA: 0x0015A77C File Offset: 0x0015897C
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

		// Token: 0x06009454 RID: 37972 RVA: 0x0015A7B4 File Offset: 0x001589B4
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

		// Token: 0x06009455 RID: 37973 RVA: 0x0015A7C7 File Offset: 0x001589C7
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

		// Token: 0x06009456 RID: 37974 RVA: 0x0015A7DA File Offset: 0x001589DA
		public new IDisableSkillOperation_SetValue ToSetValue()
		{
			return new IDisableSkillOperation_SetValue
			{
				Type = this.Type,
				DisplayMode = this.DisplayMode,
				DisableSkillWheel = this.DisableSkillWheel
			};
		}

		// Token: 0x17002F4E RID: 12110
		// (get) Token: 0x06009457 RID: 37975 RVA: 0x0015A805 File Offset: 0x00158A05
		// (set) Token: 0x06009458 RID: 37976 RVA: 0x0015A830 File Offset: 0x00158A30
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

		// Token: 0x17002F4F RID: 12111
		// (get) Token: 0x06009459 RID: 37977 RVA: 0x0015A840 File Offset: 0x00158A40
		// (set) Token: 0x0600945A RID: 37978 RVA: 0x0015A87A File Offset: 0x00158A7A
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

		// Token: 0x17002F50 RID: 12112
		// (get) Token: 0x0600945B RID: 37979 RVA: 0x0015A888 File Offset: 0x00158A88
		// (set) Token: 0x0600945C RID: 37980 RVA: 0x0015A8C2 File Offset: 0x00158AC2
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

		// Token: 0x04005C0B RID: 23563
		[Nullable(2)]
		protected new IDisableSkillOperation FbInstance;

		// Token: 0x04005C0C RID: 23564
		[Nullable(2)]
		protected new IDisableSkillOperation_SetValue PocoInterface;
	}
}

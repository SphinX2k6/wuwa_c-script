using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E14 RID: 7700
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetBattleTagConfig
	{
		// Token: 0x0600A4B9 RID: 42169 RVA: 0x00175794 File Offset: 0x00173994
		private ISetBattleTagConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetBattleTagConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetBattleTagConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetBattleTagConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A4BA RID: 42170 RVA: 0x001757CC File Offset: 0x001739CC
		public static ISetBattleTagConfig Create([Nullable(2)] ISetBattleTagConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetBattleTagConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A4BB RID: 42171 RVA: 0x001757DF File Offset: 0x001739DF
		public static ISetBattleTagConfig CreateFromSetValue([Nullable(2)] ISetBattleTagConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetBattleTagConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A4BC RID: 42172 RVA: 0x001757F2 File Offset: 0x001739F2
		public ISetBattleTagConfig_SetValue ToSetValue()
		{
			return new ISetBattleTagConfig_SetValue
			{
				EntityId = this.EntityId,
				TagConfigId = this.TagConfigId,
				DelayTime = this.DelayTime
			};
		}

		// Token: 0x17003295 RID: 12949
		// (get) Token: 0x0600A4BD RID: 42173 RVA: 0x0017581D File Offset: 0x00173A1D
		// (set) Token: 0x0600A4BE RID: 42174 RVA: 0x00175848 File Offset: 0x00173A48
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17003296 RID: 12950
		// (get) Token: 0x0600A4BF RID: 42175 RVA: 0x00175856 File Offset: 0x00173A56
		// (set) Token: 0x0600A4C0 RID: 42176 RVA: 0x00175881 File Offset: 0x00173A81
		public virtual int TagConfigId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TagConfigId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TagConfigId;
			}
			set
			{
				this.GetOrCreatePoco().TagConfigId = value;
			}
		}

		// Token: 0x17003297 RID: 12951
		// (get) Token: 0x0600A4C1 RID: 42177 RVA: 0x00175890 File Offset: 0x00173A90
		// (set) Token: 0x0600A4C2 RID: 42178 RVA: 0x001758CA File Offset: 0x00173ACA
		public virtual int? DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				ISetBattleTagConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DelayTime;
			}
			set
			{
				this.GetOrCreatePoco().DelayTime = value;
			}
		}

		// Token: 0x0400629A RID: 25242
		[Nullable(2)]
		protected ISetBattleTagConfig FbInstance;

		// Token: 0x0400629B RID: 25243
		[Nullable(2)]
		protected ISetBattleTagConfig_SetValue PocoInterface;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200200C RID: 8204
	[NullableContext(2)]
	[Nullable(0)]
	public class IUiAnimConfig
	{
		// Token: 0x0600B470 RID: 46192 RVA: 0x001A397C File Offset: 0x001A1B7C
		[NullableContext(1)]
		private IUiAnimConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUiAnimConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUiAnimConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUiAnimConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600B471 RID: 46193 RVA: 0x001A39B4 File Offset: 0x001A1BB4
		[NullableContext(1)]
		public static IUiAnimConfig Create([Nullable(2)] IUiAnimConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUiAnimConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B472 RID: 46194 RVA: 0x001A39C7 File Offset: 0x001A1BC7
		[NullableContext(1)]
		public static IUiAnimConfig CreateFromSetValue([Nullable(2)] IUiAnimConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUiAnimConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B473 RID: 46195 RVA: 0x001A39DA File Offset: 0x001A1BDA
		[NullableContext(1)]
		public IUiAnimConfig_SetValue ToSetValue()
		{
			return new IUiAnimConfig_SetValue
			{
				UiStartAnimName = this.UiStartAnimName,
				UiEndAnimName = this.UiEndAnimName
			};
		}

		// Token: 0x1700377E RID: 14206
		// (get) Token: 0x0600B474 RID: 46196 RVA: 0x001A39F9 File Offset: 0x001A1BF9
		// (set) Token: 0x0600B475 RID: 46197 RVA: 0x001A3A20 File Offset: 0x001A1C20
		public virtual string UiStartAnimName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UiStartAnimName;
				}
				IUiAnimConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UiStartAnimName;
			}
			set
			{
				this.GetOrCreatePoco().UiStartAnimName = value;
			}
		}

		// Token: 0x1700377F RID: 14207
		// (get) Token: 0x0600B476 RID: 46198 RVA: 0x001A3A2E File Offset: 0x001A1C2E
		// (set) Token: 0x0600B477 RID: 46199 RVA: 0x001A3A55 File Offset: 0x001A1C55
		public virtual string UiEndAnimName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UiEndAnimName;
				}
				IUiAnimConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UiEndAnimName;
			}
			set
			{
				this.GetOrCreatePoco().UiEndAnimName = value;
			}
		}

		// Token: 0x04006CBF RID: 27839
		protected IUiAnimConfig FbInstance;

		// Token: 0x04006CC0 RID: 27840
		protected IUiAnimConfig_SetValue PocoInterface;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007B2 RID: 1970
	public class IStateRepPerfBase
	{
		// Token: 0x06002A0B RID: 10763 RVA: 0x0006ED7C File Offset: 0x0006CF7C
		private IStateRepPerfBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStateRepPerfBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStateRepPerfBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStateRepPerfBase_SetValue());
			}
			return result;
		}

		// Token: 0x06002A0C RID: 10764 RVA: 0x0006EDB4 File Offset: 0x0006CFB4
		public static IStateRepPerfBase Create([Nullable(2)] IStateRepPerfBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateRepPerfBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002A0D RID: 10765 RVA: 0x0006EDC7 File Offset: 0x0006CFC7
		public static IStateRepPerfBase CreateFromSetValue([Nullable(2)] IStateRepPerfBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStateRepPerfBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002A0E RID: 10766 RVA: 0x0006EDDA File Offset: 0x0006CFDA
		public IStateRepPerfBase_SetValue ToSetValue()
		{
			return new IStateRepPerfBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06002A0F RID: 10767 RVA: 0x0006EDED File Offset: 0x0006CFED
		// (set) Token: 0x06002A10 RID: 10768 RVA: 0x0006EE18 File Offset: 0x0006D018
		public virtual EStateRepPerfType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EStateRepPerfType.SkillId;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001C4F RID: 7247
		[Nullable(2)]
		protected IStateRepPerfBase FbInstance;

		// Token: 0x04001C50 RID: 7248
		[Nullable(2)]
		protected IStateRepPerfBase_SetValue PocoInterface;
	}
}

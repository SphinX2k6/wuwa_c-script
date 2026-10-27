using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000678 RID: 1656
	[NullableContext(1)]
	[Nullable(0)]
	public class IRenderFlag
	{
		// Token: 0x0600236A RID: 9066 RVA: 0x00060B30 File Offset: 0x0005ED30
		private IRenderFlag_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRenderFlag 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRenderFlag_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRenderFlag_SetValue());
			}
			return result;
		}

		// Token: 0x0600236B RID: 9067 RVA: 0x00060B68 File Offset: 0x0005ED68
		public static IRenderFlag Create([Nullable(2)] IRenderFlag instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRenderFlag
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600236C RID: 9068 RVA: 0x00060B7B File Offset: 0x0005ED7B
		public static IRenderFlag CreateFromSetValue([Nullable(2)] IRenderFlag_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRenderFlag
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600236D RID: 9069 RVA: 0x00060B8E File Offset: 0x0005ED8E
		public IRenderFlag_SetValue ToSetValue()
		{
			return new IRenderFlag_SetValue
			{
				Type = this.Type,
				Enable = this.Enable
			};
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x0600236E RID: 9070 RVA: 0x00060BAD File Offset: 0x0005EDAD
		// (set) Token: 0x0600236F RID: 9071 RVA: 0x00060BD8 File Offset: 0x0005EDD8
		public virtual ERenderFlagType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERenderFlagType.Fog;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06002370 RID: 9072 RVA: 0x00060BE6 File Offset: 0x0005EDE6
		// (set) Token: 0x06002371 RID: 9073 RVA: 0x00060C11 File Offset: 0x0005EE11
		public virtual bool Enable
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Enable;
				}
				return this.PocoInterface != null && this.PocoInterface.Enable;
			}
			set
			{
				this.GetOrCreatePoco().Enable = value;
			}
		}

		// Token: 0x04001876 RID: 6262
		[Nullable(2)]
		protected IRenderFlag FbInstance;

		// Token: 0x04001877 RID: 6263
		[Nullable(2)]
		protected IRenderFlag_SetValue PocoInterface;
	}
}

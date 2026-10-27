using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EE5 RID: 7909
	[NullableContext(1)]
	[Nullable(0)]
	public class ISubtitleStyleBase
	{
		// Token: 0x0600A936 RID: 43318 RVA: 0x0017DB0C File Offset: 0x0017BD0C
		private ISubtitleStyleBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISubtitleStyleBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISubtitleStyleBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISubtitleStyleBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600A937 RID: 43319 RVA: 0x0017DB44 File Offset: 0x0017BD44
		public static ISubtitleStyleBase Create([Nullable(2)] ISubtitleStyleBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubtitleStyleBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A938 RID: 43320 RVA: 0x0017DB57 File Offset: 0x0017BD57
		public static ISubtitleStyleBase CreateFromSetValue([Nullable(2)] ISubtitleStyleBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISubtitleStyleBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A939 RID: 43321 RVA: 0x0017DB6A File Offset: 0x0017BD6A
		public ISubtitleStyleBase_SetValue ToSetValue()
		{
			return new ISubtitleStyleBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700339B RID: 13211
		// (get) Token: 0x0600A93A RID: 43322 RVA: 0x0017DB7D File Offset: 0x0017BD7D
		// (set) Token: 0x0600A93B RID: 43323 RVA: 0x0017DBA8 File Offset: 0x0017BDA8
		public virtual ESubtitleStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESubtitleStyle.LevelA;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040064B6 RID: 25782
		[Nullable(2)]
		protected ISubtitleStyleBase FbInstance;

		// Token: 0x040064B7 RID: 25783
		[Nullable(2)]
		protected ISubtitleStyleBase_SetValue PocoInterface;
	}
}

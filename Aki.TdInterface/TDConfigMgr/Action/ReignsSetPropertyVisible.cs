using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002140 RID: 8512
	[NullableContext(1)]
	[Nullable(0)]
	public class ReignsSetPropertyVisible : ActionParams
	{
		// Token: 0x0600BB68 RID: 47976 RVA: 0x001B0BCC File Offset: 0x001AEDCC
		private ReignsSetPropertyVisible_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ReignsSetPropertyVisible 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ReignsSetPropertyVisible_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ReignsSetPropertyVisible_SetValue());
			}
			return result;
		}

		// Token: 0x0600BB69 RID: 47977 RVA: 0x001B0C04 File Offset: 0x001AEE04
		public static ReignsSetPropertyVisible Create([Nullable(2)] ReignsSetPropertyVisible instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ReignsSetPropertyVisible
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BB6A RID: 47978 RVA: 0x001B0C17 File Offset: 0x001AEE17
		public static ReignsSetPropertyVisible CreateFromSetValue([Nullable(2)] ReignsSetPropertyVisible_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ReignsSetPropertyVisible
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BB6B RID: 47979 RVA: 0x001B0C2A File Offset: 0x001AEE2A
		public ReignsSetPropertyVisible_SetValue ToSetValue()
		{
			return new ReignsSetPropertyVisible_SetValue
			{
				PropertyId = this.PropertyId,
				IsVisible = this.IsVisible
			};
		}

		// Token: 0x17003931 RID: 14641
		// (get) Token: 0x0600BB6C RID: 47980 RVA: 0x001B0C49 File Offset: 0x001AEE49
		// (set) Token: 0x0600BB6D RID: 47981 RVA: 0x001B0C74 File Offset: 0x001AEE74
		public virtual int PropertyId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PropertyId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PropertyId;
			}
			set
			{
				this.GetOrCreatePoco().PropertyId = value;
			}
		}

		// Token: 0x17003932 RID: 14642
		// (get) Token: 0x0600BB6E RID: 47982 RVA: 0x001B0C82 File Offset: 0x001AEE82
		// (set) Token: 0x0600BB6F RID: 47983 RVA: 0x001B0CAD File Offset: 0x001AEEAD
		public virtual bool IsVisible
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsVisible;
				}
				return this.PocoInterface != null && this.PocoInterface.IsVisible;
			}
			set
			{
				this.GetOrCreatePoco().IsVisible = value;
			}
		}

		// Token: 0x04007013 RID: 28691
		[Nullable(2)]
		protected new ReignsSetPropertyVisible FbInstance;

		// Token: 0x04007014 RID: 28692
		[Nullable(2)]
		protected ReignsSetPropertyVisible_SetValue PocoInterface;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200005E RID: 94
	public class DynamicLevelPlayComponent : IComponentBase
	{
		// Token: 0x0600031A RID: 794 RVA: 0x0001BAB8 File Offset: 0x00019CB8
		private DynamicLevelPlayComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("DynamicLevelPlayComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			DynamicLevelPlayComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new DynamicLevelPlayComponent_SetValue());
			}
			return result;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0001BAF0 File Offset: 0x00019CF0
		public static DynamicLevelPlayComponent Create([Nullable(2)] DynamicLevelPlayComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DynamicLevelPlayComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0001BB03 File Offset: 0x00019D03
		public static DynamicLevelPlayComponent CreateFromSetValue([Nullable(2)] DynamicLevelPlayComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new DynamicLevelPlayComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0001BB16 File Offset: 0x00019D16
		public new DynamicLevelPlayComponent_SetValue ToSetValue()
		{
			return new DynamicLevelPlayComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				DynamicLevelPlayId = this.DynamicLevelPlayId
			};
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600031E RID: 798 RVA: 0x0001BB44 File Offset: 0x00019D44
		// (set) Token: 0x0600031F RID: 799 RVA: 0x0001BB7E File Offset: 0x00019D7E
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				DynamicLevelPlayComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000320 RID: 800 RVA: 0x0001BB8C File Offset: 0x00019D8C
		// (set) Token: 0x06000321 RID: 801 RVA: 0x0001BBB6 File Offset: 0x00019DB6
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000322 RID: 802 RVA: 0x0001BBC4 File Offset: 0x00019DC4
		// (set) Token: 0x06000323 RID: 803 RVA: 0x0001BBEF File Offset: 0x00019DEF
		public virtual int DynamicLevelPlayId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DynamicLevelPlayId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.DynamicLevelPlayId;
			}
			set
			{
				this.GetOrCreatePoco().DynamicLevelPlayId = value;
			}
		}

		// Token: 0x040001FC RID: 508
		[Nullable(2)]
		protected new DynamicLevelPlayComponent FbInstance;

		// Token: 0x040001FD RID: 509
		[Nullable(2)]
		protected new DynamicLevelPlayComponent_SetValue PocoInterface;
	}
}

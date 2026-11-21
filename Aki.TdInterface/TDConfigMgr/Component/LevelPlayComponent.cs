using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008C6 RID: 2246
	public class LevelPlayComponent : IComponentBase
	{
		// Token: 0x06003081 RID: 12417 RVA: 0x0007CA1C File Offset: 0x0007AC1C
		private LevelPlayComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("LevelPlayComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			LevelPlayComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new LevelPlayComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003082 RID: 12418 RVA: 0x0007CA54 File Offset: 0x0007AC54
		public static LevelPlayComponent Create([Nullable(2)] LevelPlayComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LevelPlayComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003083 RID: 12419 RVA: 0x0007CA67 File Offset: 0x0007AC67
		public static LevelPlayComponent CreateFromSetValue([Nullable(2)] LevelPlayComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new LevelPlayComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003084 RID: 12420 RVA: 0x0007CA7A File Offset: 0x0007AC7A
		public new LevelPlayComponent_SetValue ToSetValue()
		{
			return new LevelPlayComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				LevelPlayId = this.LevelPlayId
			};
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x06003085 RID: 12421 RVA: 0x0007CAA8 File Offset: 0x0007ACA8
		// (set) Token: 0x06003086 RID: 12422 RVA: 0x0007CAE2 File Offset: 0x0007ACE2
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				LevelPlayComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x06003087 RID: 12423 RVA: 0x0007CAF0 File Offset: 0x0007ACF0
		// (set) Token: 0x06003088 RID: 12424 RVA: 0x0007CB1A File Offset: 0x0007AD1A
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

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x06003089 RID: 12425 RVA: 0x0007CB28 File Offset: 0x0007AD28
		// (set) Token: 0x0600308A RID: 12426 RVA: 0x0007CB53 File Offset: 0x0007AD53
		public virtual int LevelPlayId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LevelPlayId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.LevelPlayId;
			}
			set
			{
				this.GetOrCreatePoco().LevelPlayId = value;
			}
		}

		// Token: 0x0400200B RID: 8203
		[Nullable(2)]
		protected new LevelPlayComponent FbInstance;

		// Token: 0x0400200C RID: 8204
		[Nullable(2)]
		protected new LevelPlayComponent_SetValue PocoInterface;
	}
}

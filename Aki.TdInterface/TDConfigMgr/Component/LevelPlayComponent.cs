using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000823 RID: 2083
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelPlayComponent : IComponentBase
	{
		// Token: 0x06002D51 RID: 11601 RVA: 0x000756B8 File Offset: 0x000738B8
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

		// Token: 0x06002D52 RID: 11602 RVA: 0x000756F0 File Offset: 0x000738F0
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

		// Token: 0x06002D53 RID: 11603 RVA: 0x00075703 File Offset: 0x00073903
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

		// Token: 0x06002D54 RID: 11604 RVA: 0x00075716 File Offset: 0x00073916
		public new LevelPlayComponent_SetValue ToSetValue()
		{
			return new LevelPlayComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				LevelPlayId = this.LevelPlayId
			};
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x06002D55 RID: 11605 RVA: 0x00075744 File Offset: 0x00073944
		// (set) Token: 0x06002D56 RID: 11606 RVA: 0x0007577E File Offset: 0x0007397E
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

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x06002D57 RID: 11607 RVA: 0x0007578C File Offset: 0x0007398C
		// (set) Token: 0x06002D58 RID: 11608 RVA: 0x000757B6 File Offset: 0x000739B6
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

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x06002D59 RID: 11609 RVA: 0x000757C4 File Offset: 0x000739C4
		// (set) Token: 0x06002D5A RID: 11610 RVA: 0x000757EF File Offset: 0x000739EF
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

		// Token: 0x04001DFF RID: 7679
		[Nullable(2)]
		protected new LevelPlayComponent FbInstance;

		// Token: 0x04001E00 RID: 7680
		[Nullable(2)]
		protected new LevelPlayComponent_SetValue PocoInterface;
	}
}

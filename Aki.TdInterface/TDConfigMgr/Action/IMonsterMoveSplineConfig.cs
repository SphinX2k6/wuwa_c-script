using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BF4 RID: 7156
	[NullableContext(1)]
	[Nullable(0)]
	public class IMonsterMoveSplineConfig
	{
		// Token: 0x0600993F RID: 39231 RVA: 0x00160BD4 File Offset: 0x0015EDD4
		private IMonsterMoveSplineConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMonsterMoveSplineConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMonsterMoveSplineConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMonsterMoveSplineConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009940 RID: 39232 RVA: 0x00160C0C File Offset: 0x0015EE0C
		public static IMonsterMoveSplineConfig Create([Nullable(2)] IMonsterMoveSplineConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterMoveSplineConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009941 RID: 39233 RVA: 0x00160C1F File Offset: 0x0015EE1F
		public static IMonsterMoveSplineConfig CreateFromSetValue([Nullable(2)] IMonsterMoveSplineConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMonsterMoveSplineConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009942 RID: 39234 RVA: 0x00160C32 File Offset: 0x0015EE32
		public IMonsterMoveSplineConfig_SetValue ToSetValue()
		{
			return new IMonsterMoveSplineConfig_SetValue
			{
				TargetEntityId = this.TargetEntityId,
				SplineEntityId = this.SplineEntityId
			};
		}

		// Token: 0x17003008 RID: 12296
		// (get) Token: 0x06009943 RID: 39235 RVA: 0x00160C51 File Offset: 0x0015EE51
		// (set) Token: 0x06009944 RID: 39236 RVA: 0x00160C7C File Offset: 0x0015EE7C
		public virtual int TargetEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TargetEntityId;
			}
			set
			{
				this.GetOrCreatePoco().TargetEntityId = value;
			}
		}

		// Token: 0x17003009 RID: 12297
		// (get) Token: 0x06009945 RID: 39237 RVA: 0x00160C8A File Offset: 0x0015EE8A
		// (set) Token: 0x06009946 RID: 39238 RVA: 0x00160CB5 File Offset: 0x0015EEB5
		public virtual int SplineEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SplineEntityId;
			}
			set
			{
				this.GetOrCreatePoco().SplineEntityId = value;
			}
		}

		// Token: 0x04005D53 RID: 23891
		[Nullable(2)]
		protected IMonsterMoveSplineConfig FbInstance;

		// Token: 0x04005D54 RID: 23892
		[Nullable(2)]
		protected IMonsterMoveSplineConfig_SetValue PocoInterface;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DE3 RID: 7651
	public class IMonsterMoveSplineConfig
	{
		// Token: 0x0600A26D RID: 41581 RVA: 0x00173ACC File Offset: 0x00171CCC
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

		// Token: 0x0600A26E RID: 41582 RVA: 0x00173B04 File Offset: 0x00171D04
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

		// Token: 0x0600A26F RID: 41583 RVA: 0x00173B17 File Offset: 0x00171D17
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

		// Token: 0x0600A270 RID: 41584 RVA: 0x00173B2A File Offset: 0x00171D2A
		public IMonsterMoveSplineConfig_SetValue ToSetValue()
		{
			return new IMonsterMoveSplineConfig_SetValue
			{
				TargetEntityId = this.TargetEntityId,
				SplineEntityId = this.SplineEntityId,
				IsStrict = this.IsStrict
			};
		}

		// Token: 0x17003270 RID: 12912
		// (get) Token: 0x0600A271 RID: 41585 RVA: 0x00173B55 File Offset: 0x00171D55
		// (set) Token: 0x0600A272 RID: 41586 RVA: 0x00173B80 File Offset: 0x00171D80
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

		// Token: 0x17003271 RID: 12913
		// (get) Token: 0x0600A273 RID: 41587 RVA: 0x00173B8E File Offset: 0x00171D8E
		// (set) Token: 0x0600A274 RID: 41588 RVA: 0x00173BB9 File Offset: 0x00171DB9
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

		// Token: 0x17003272 RID: 12914
		// (get) Token: 0x0600A275 RID: 41589 RVA: 0x00173BC8 File Offset: 0x00171DC8
		// (set) Token: 0x0600A276 RID: 41590 RVA: 0x00173C02 File Offset: 0x00171E02
		public virtual bool? IsStrict
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsStrict;
				}
				IMonsterMoveSplineConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsStrict;
			}
			set
			{
				this.GetOrCreatePoco().IsStrict = value;
			}
		}

		// Token: 0x04006279 RID: 25209
		[Nullable(2)]
		protected IMonsterMoveSplineConfig FbInstance;

		// Token: 0x0400627A RID: 25210
		[Nullable(2)]
		protected IMonsterMoveSplineConfig_SetValue PocoInterface;
	}
}

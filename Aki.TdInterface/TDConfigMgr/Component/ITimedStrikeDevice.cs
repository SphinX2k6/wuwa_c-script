using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000813 RID: 2067
	public class ITimedStrikeDevice : IProgressBarControl
	{
		// Token: 0x06002C63 RID: 11363 RVA: 0x00074074 File Offset: 0x00072274
		private ITimedStrikeDevice_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITimedStrikeDevice 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITimedStrikeDevice_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITimedStrikeDevice_SetValue());
			}
			return result;
		}

		// Token: 0x06002C64 RID: 11364 RVA: 0x000740AC File Offset: 0x000722AC
		public static ITimedStrikeDevice Create([Nullable(2)] ITimedStrikeDevice instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimedStrikeDevice
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002C65 RID: 11365 RVA: 0x000740BF File Offset: 0x000722BF
		public static ITimedStrikeDevice CreateFromSetValue([Nullable(2)] ITimedStrikeDevice_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITimedStrikeDevice
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002C66 RID: 11366 RVA: 0x000740D4 File Offset: 0x000722D4
		public new ITimedStrikeDevice_SetValue ToSetValue()
		{
			return new ITimedStrikeDevice_SetValue
			{
				Type = this.Type,
				MaxValue = this.MaxValue,
				InitValue = this.InitValue,
				ProgressPerformanceAttribute = this.ProgressPerformanceAttribute,
				AddValue = this.AddValue,
				Timeout = this.Timeout,
				FallbackValue = this.FallbackValue,
				FallbackInterval = this.FallbackInterval,
				ZeroValuePerformanceAttribute = this.ZeroValuePerformanceAttribute,
				AscendPerformanceAttribute = this.AscendPerformanceAttribute,
				DescendPerformanceAttribute = this.DescendPerformanceAttribute
			};
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x06002C67 RID: 11367 RVA: 0x0007416A File Offset: 0x0007236A
		// (set) Token: 0x06002C68 RID: 11368 RVA: 0x00074195 File Offset: 0x00072395
		public override EProgressBarControlType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EProgressBarControlType.CaptureStrategicPoint;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x06002C69 RID: 11369 RVA: 0x000741A3 File Offset: 0x000723A3
		// (set) Token: 0x06002C6A RID: 11370 RVA: 0x000741CE File Offset: 0x000723CE
		public override int MaxValue
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxValue;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MaxValue;
			}
			set
			{
				this.GetOrCreatePoco().MaxValue = value;
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x06002C6B RID: 11371 RVA: 0x000741DC File Offset: 0x000723DC
		// (set) Token: 0x06002C6C RID: 11372 RVA: 0x00074207 File Offset: 0x00072407
		public override int InitValue
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InitValue;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.InitValue;
			}
			set
			{
				this.GetOrCreatePoco().InitValue = value;
			}
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x06002C6D RID: 11373 RVA: 0x00074218 File Offset: 0x00072418
		// (set) Token: 0x06002C6E RID: 11374 RVA: 0x00074252 File Offset: 0x00072452
		public override int? ProgressPerformanceAttribute
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ProgressPerformanceAttribute;
				}
				ITimedStrikeDevice_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ProgressPerformanceAttribute;
			}
			set
			{
				this.GetOrCreatePoco().ProgressPerformanceAttribute = value;
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x06002C6F RID: 11375 RVA: 0x00074260 File Offset: 0x00072460
		// (set) Token: 0x06002C70 RID: 11376 RVA: 0x0007428B File Offset: 0x0007248B
		public virtual int AddValue
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AddValue;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.AddValue;
			}
			set
			{
				this.GetOrCreatePoco().AddValue = value;
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x06002C71 RID: 11377 RVA: 0x00074299 File Offset: 0x00072499
		// (set) Token: 0x06002C72 RID: 11378 RVA: 0x000742C4 File Offset: 0x000724C4
		public virtual int Timeout
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Timeout;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Timeout;
			}
			set
			{
				this.GetOrCreatePoco().Timeout = value;
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x06002C73 RID: 11379 RVA: 0x000742D2 File Offset: 0x000724D2
		// (set) Token: 0x06002C74 RID: 11380 RVA: 0x000742FD File Offset: 0x000724FD
		public virtual int FallbackValue
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FallbackValue;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.FallbackValue;
			}
			set
			{
				this.GetOrCreatePoco().FallbackValue = value;
			}
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x06002C75 RID: 11381 RVA: 0x0007430B File Offset: 0x0007250B
		// (set) Token: 0x06002C76 RID: 11382 RVA: 0x00074336 File Offset: 0x00072536
		public virtual int FallbackInterval
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FallbackInterval;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.FallbackInterval;
			}
			set
			{
				this.GetOrCreatePoco().FallbackInterval = value;
			}
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x06002C77 RID: 11383 RVA: 0x00074344 File Offset: 0x00072544
		// (set) Token: 0x06002C78 RID: 11384 RVA: 0x0007437E File Offset: 0x0007257E
		public virtual int? ZeroValuePerformanceAttribute
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ZeroValuePerformanceAttribute;
				}
				ITimedStrikeDevice_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ZeroValuePerformanceAttribute;
			}
			set
			{
				this.GetOrCreatePoco().ZeroValuePerformanceAttribute = value;
			}
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x06002C79 RID: 11385 RVA: 0x0007438C File Offset: 0x0007258C
		// (set) Token: 0x06002C7A RID: 11386 RVA: 0x000743C6 File Offset: 0x000725C6
		public virtual int? AscendPerformanceAttribute
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AscendPerformanceAttribute;
				}
				ITimedStrikeDevice_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AscendPerformanceAttribute;
			}
			set
			{
				this.GetOrCreatePoco().AscendPerformanceAttribute = value;
			}
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x06002C7B RID: 11387 RVA: 0x000743D4 File Offset: 0x000725D4
		// (set) Token: 0x06002C7C RID: 11388 RVA: 0x0007440E File Offset: 0x0007260E
		public virtual int? DescendPerformanceAttribute
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DescendPerformanceAttribute;
				}
				ITimedStrikeDevice_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DescendPerformanceAttribute;
			}
			set
			{
				this.GetOrCreatePoco().DescendPerformanceAttribute = value;
			}
		}

		// Token: 0x04001DB7 RID: 7607
		[Nullable(2)]
		protected new ITimedStrikeDevice FbInstance;

		// Token: 0x04001DB8 RID: 7608
		[Nullable(2)]
		protected new ITimedStrikeDevice_SetValue PocoInterface;
	}
}

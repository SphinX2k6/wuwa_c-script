using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DB1 RID: 7601
	public class IMechEscortPoint
	{
		// Token: 0x0600A16F RID: 41327 RVA: 0x00172034 File Offset: 0x00170234
		private IMechEscortPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechEscortPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechEscortPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechEscortPoint_SetValue());
			}
			return result;
		}

		// Token: 0x0600A170 RID: 41328 RVA: 0x0017206C File Offset: 0x0017026C
		public static IMechEscortPoint Create([Nullable(2)] IMechEscortPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechEscortPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A171 RID: 41329 RVA: 0x0017207F File Offset: 0x0017027F
		public static IMechEscortPoint CreateFromSetValue([Nullable(2)] IMechEscortPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechEscortPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A172 RID: 41330 RVA: 0x00172094 File Offset: 0x00170294
		public IMechEscortPoint_SetValue ToSetValue()
		{
			return new IMechEscortPoint_SetValue
			{
				SplinePointIndex = this.SplinePointIndex,
				ForwardOffset = this.ForwardOffset,
				Radius = this.Radius,
				Angle = this.Angle,
				MovieCamera = this.MovieCamera
			};
		}

		// Token: 0x1700323C RID: 12860
		// (get) Token: 0x0600A173 RID: 41331 RVA: 0x001720E2 File Offset: 0x001702E2
		// (set) Token: 0x0600A174 RID: 41332 RVA: 0x0017210D File Offset: 0x0017030D
		public virtual int SplinePointIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplinePointIndex;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SplinePointIndex;
			}
			set
			{
				this.GetOrCreatePoco().SplinePointIndex = value;
			}
		}

		// Token: 0x1700323D RID: 12861
		// (get) Token: 0x0600A175 RID: 41333 RVA: 0x0017211B File Offset: 0x0017031B
		// (set) Token: 0x0600A176 RID: 41334 RVA: 0x0017214A File Offset: 0x0017034A
		public virtual float ForwardOffset
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ForwardOffset;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.ForwardOffset;
			}
			set
			{
				this.GetOrCreatePoco().ForwardOffset = value;
			}
		}

		// Token: 0x1700323E RID: 12862
		// (get) Token: 0x0600A177 RID: 41335 RVA: 0x00172158 File Offset: 0x00170358
		// (set) Token: 0x0600A178 RID: 41336 RVA: 0x00172187 File Offset: 0x00170387
		public virtual float Radius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Radius;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Radius;
			}
			set
			{
				this.GetOrCreatePoco().Radius = value;
			}
		}

		// Token: 0x1700323F RID: 12863
		// (get) Token: 0x0600A179 RID: 41337 RVA: 0x00172195 File Offset: 0x00170395
		// (set) Token: 0x0600A17A RID: 41338 RVA: 0x001721C4 File Offset: 0x001703C4
		public virtual float Angle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Angle;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Angle;
			}
			set
			{
				this.GetOrCreatePoco().Angle = value;
			}
		}

		// Token: 0x17003240 RID: 12864
		// (get) Token: 0x0600A17B RID: 41339 RVA: 0x001721D2 File Offset: 0x001703D2
		// (set) Token: 0x0600A17C RID: 41340 RVA: 0x001721F9 File Offset: 0x001703F9
		[Nullable(2)]
		public virtual IEnterMovieCameraType MovieCamera
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MovieCamera;
				}
				IMechEscortPoint_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MovieCamera;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().MovieCamera = value;
			}
		}

		// Token: 0x0400620D RID: 25101
		[Nullable(2)]
		protected IMechEscortPoint FbInstance;

		// Token: 0x0400620E RID: 25102
		[Nullable(2)]
		protected IMechEscortPoint_SetValue PocoInterface;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E3B RID: 7739
	public class IMovingCameraTimeParams
	{
		// Token: 0x0600A491 RID: 42129 RVA: 0x00177D18 File Offset: 0x00175F18
		private IMovingCameraTimeParams_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMovingCameraTimeParams 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMovingCameraTimeParams_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMovingCameraTimeParams_SetValue());
			}
			return result;
		}

		// Token: 0x0600A492 RID: 42130 RVA: 0x00177D50 File Offset: 0x00175F50
		public static IMovingCameraTimeParams Create([Nullable(2)] IMovingCameraTimeParams instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMovingCameraTimeParams
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A493 RID: 42131 RVA: 0x00177D63 File Offset: 0x00175F63
		public static IMovingCameraTimeParams CreateFromSetValue([Nullable(2)] IMovingCameraTimeParams_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMovingCameraTimeParams
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A494 RID: 42132 RVA: 0x00177D76 File Offset: 0x00175F76
		public IMovingCameraTimeParams_SetValue ToSetValue()
		{
			return new IMovingCameraTimeParams_SetValue
			{
				FadeInTime = this.FadeInTime,
				AfterFadeInStayTime = this.AfterFadeInStayTime,
				FadeOutTime = this.FadeOutTime,
				BeforeFadeOutStayTime = this.BeforeFadeOutStayTime
			};
		}

		// Token: 0x170032FE RID: 13054
		// (get) Token: 0x0600A495 RID: 42133 RVA: 0x00177DAD File Offset: 0x00175FAD
		// (set) Token: 0x0600A496 RID: 42134 RVA: 0x00177DDC File Offset: 0x00175FDC
		public virtual float FadeInTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeInTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.FadeInTime;
			}
			set
			{
				this.GetOrCreatePoco().FadeInTime = value;
			}
		}

		// Token: 0x170032FF RID: 13055
		// (get) Token: 0x0600A497 RID: 42135 RVA: 0x00177DEA File Offset: 0x00175FEA
		// (set) Token: 0x0600A498 RID: 42136 RVA: 0x00177E19 File Offset: 0x00176019
		public virtual float AfterFadeInStayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AfterFadeInStayTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.AfterFadeInStayTime;
			}
			set
			{
				this.GetOrCreatePoco().AfterFadeInStayTime = value;
			}
		}

		// Token: 0x17003300 RID: 13056
		// (get) Token: 0x0600A499 RID: 42137 RVA: 0x00177E27 File Offset: 0x00176027
		// (set) Token: 0x0600A49A RID: 42138 RVA: 0x00177E56 File Offset: 0x00176056
		public virtual float FadeOutTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeOutTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.FadeOutTime;
			}
			set
			{
				this.GetOrCreatePoco().FadeOutTime = value;
			}
		}

		// Token: 0x17003301 RID: 13057
		// (get) Token: 0x0600A49B RID: 42139 RVA: 0x00177E64 File Offset: 0x00176064
		// (set) Token: 0x0600A49C RID: 42140 RVA: 0x00177E93 File Offset: 0x00176093
		public virtual float BeforeFadeOutStayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BeforeFadeOutStayTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.BeforeFadeOutStayTime;
			}
			set
			{
				this.GetOrCreatePoco().BeforeFadeOutStayTime = value;
			}
		}

		// Token: 0x04006385 RID: 25477
		[Nullable(2)]
		protected IMovingCameraTimeParams FbInstance;

		// Token: 0x04006386 RID: 25478
		[Nullable(2)]
		protected IMovingCameraTimeParams_SetValue PocoInterface;
	}
}

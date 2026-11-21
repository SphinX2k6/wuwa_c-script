using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E35 RID: 7733
	public class IMovieBackgroundFadeData
	{
		// Token: 0x0600A475 RID: 42101 RVA: 0x00177A40 File Offset: 0x00175C40
		private IMovieBackgroundFadeData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMovieBackgroundFadeData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMovieBackgroundFadeData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMovieBackgroundFadeData_SetValue());
			}
			return result;
		}

		// Token: 0x0600A476 RID: 42102 RVA: 0x00177A78 File Offset: 0x00175C78
		public static IMovieBackgroundFadeData Create([Nullable(2)] IMovieBackgroundFadeData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMovieBackgroundFadeData
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A477 RID: 42103 RVA: 0x00177A8B File Offset: 0x00175C8B
		public static IMovieBackgroundFadeData CreateFromSetValue([Nullable(2)] IMovieBackgroundFadeData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMovieBackgroundFadeData
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A478 RID: 42104 RVA: 0x00177A9E File Offset: 0x00175C9E
		public IMovieBackgroundFadeData_SetValue ToSetValue()
		{
			return new IMovieBackgroundFadeData_SetValue
			{
				FadeInBackgroundType = this.FadeInBackgroundType,
				FadeOutBackgroundType = this.FadeOutBackgroundType
			};
		}

		// Token: 0x170032F9 RID: 13049
		// (get) Token: 0x0600A479 RID: 42105 RVA: 0x00177ABD File Offset: 0x00175CBD
		// (set) Token: 0x0600A47A RID: 42106 RVA: 0x00177AE8 File Offset: 0x00175CE8
		public virtual EMovieBackgroundType FadeInBackgroundType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeInBackgroundType;
				}
				if (this.PocoInterface == null)
				{
					return EMovieBackgroundType.White;
				}
				return this.PocoInterface.FadeInBackgroundType;
			}
			set
			{
				this.GetOrCreatePoco().FadeInBackgroundType = value;
			}
		}

		// Token: 0x170032FA RID: 13050
		// (get) Token: 0x0600A47B RID: 42107 RVA: 0x00177AF6 File Offset: 0x00175CF6
		// (set) Token: 0x0600A47C RID: 42108 RVA: 0x00177B21 File Offset: 0x00175D21
		public virtual EMovieBackgroundType FadeOutBackgroundType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeOutBackgroundType;
				}
				if (this.PocoInterface == null)
				{
					return EMovieBackgroundType.White;
				}
				return this.PocoInterface.FadeOutBackgroundType;
			}
			set
			{
				this.GetOrCreatePoco().FadeOutBackgroundType = value;
			}
		}

		// Token: 0x0400637A RID: 25466
		[Nullable(2)]
		protected IMovieBackgroundFadeData FbInstance;

		// Token: 0x0400637B RID: 25467
		[Nullable(2)]
		protected IMovieBackgroundFadeData_SetValue PocoInterface;
	}
}

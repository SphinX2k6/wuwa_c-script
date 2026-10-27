using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C3E RID: 7230
	[NullableContext(1)]
	[Nullable(0)]
	public class IMovieBackgroundFadeData
	{
		// Token: 0x06009B1D RID: 39709 RVA: 0x00164700 File Offset: 0x00162900
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

		// Token: 0x06009B1E RID: 39710 RVA: 0x00164738 File Offset: 0x00162938
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

		// Token: 0x06009B1F RID: 39711 RVA: 0x0016474B File Offset: 0x0016294B
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

		// Token: 0x06009B20 RID: 39712 RVA: 0x0016475E File Offset: 0x0016295E
		public IMovieBackgroundFadeData_SetValue ToSetValue()
		{
			return new IMovieBackgroundFadeData_SetValue
			{
				FadeInBackgroundType = this.FadeInBackgroundType,
				FadeOutBackgroundType = this.FadeOutBackgroundType
			};
		}

		// Token: 0x17003088 RID: 12424
		// (get) Token: 0x06009B21 RID: 39713 RVA: 0x0016477D File Offset: 0x0016297D
		// (set) Token: 0x06009B22 RID: 39714 RVA: 0x001647A8 File Offset: 0x001629A8
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

		// Token: 0x17003089 RID: 12425
		// (get) Token: 0x06009B23 RID: 39715 RVA: 0x001647B6 File Offset: 0x001629B6
		// (set) Token: 0x06009B24 RID: 39716 RVA: 0x001647E1 File Offset: 0x001629E1
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

		// Token: 0x04005E43 RID: 24131
		[Nullable(2)]
		protected IMovieBackgroundFadeData FbInstance;

		// Token: 0x04005E44 RID: 24132
		[Nullable(2)]
		protected IMovieBackgroundFadeData_SetValue PocoInterface;
	}
}

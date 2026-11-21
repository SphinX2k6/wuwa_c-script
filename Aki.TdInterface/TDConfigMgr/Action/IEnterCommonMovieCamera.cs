using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B8D RID: 7053
	public class IEnterCommonMovieCamera : IEnterMovieCameraType
	{
		// Token: 0x060095DB RID: 38363 RVA: 0x0015D238 File Offset: 0x0015B438
		private IEnterCommonMovieCamera_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnterCommonMovieCamera 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnterCommonMovieCamera_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnterCommonMovieCamera_SetValue());
			}
			return result;
		}

		// Token: 0x060095DC RID: 38364 RVA: 0x0015D270 File Offset: 0x0015B470
		public static IEnterCommonMovieCamera Create([Nullable(2)] IEnterCommonMovieCamera instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnterCommonMovieCamera
			{
				FbInstance = instance
			};
		}

		// Token: 0x060095DD RID: 38365 RVA: 0x0015D283 File Offset: 0x0015B483
		public static IEnterCommonMovieCamera CreateFromSetValue([Nullable(2)] IEnterCommonMovieCamera_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnterCommonMovieCamera
			{
				PocoInterface = value
			};
		}

		// Token: 0x060095DE RID: 38366 RVA: 0x0015D296 File Offset: 0x0015B496
		public new IEnterCommonMovieCamera_SetValue ToSetValue()
		{
			return new IEnterCommonMovieCamera_SetValue
			{
				Type = this.Type,
				RowName = this.RowName,
				SpecElementIndex = this.SpecElementIndex
			};
		}

		// Token: 0x17002FA6 RID: 12198
		// (get) Token: 0x060095DF RID: 38367 RVA: 0x0015D2C1 File Offset: 0x0015B4C1
		// (set) Token: 0x060095E0 RID: 38368 RVA: 0x0015D2EC File Offset: 0x0015B4EC
		public override EMovieCameraType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMovieCameraType.Common;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002FA7 RID: 12199
		// (get) Token: 0x060095E1 RID: 38369 RVA: 0x0015D2FA File Offset: 0x0015B4FA
		// (set) Token: 0x060095E2 RID: 38370 RVA: 0x0015D325 File Offset: 0x0015B525
		public virtual string RowName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RowName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.RowName;
			}
			set
			{
				this.GetOrCreatePoco().RowName = value;
			}
		}

		// Token: 0x17002FA8 RID: 12200
		// (get) Token: 0x060095E3 RID: 38371 RVA: 0x0015D334 File Offset: 0x0015B534
		// (set) Token: 0x060095E4 RID: 38372 RVA: 0x0015D36E File Offset: 0x0015B56E
		public virtual int? SpecElementIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SpecElementIndex;
				}
				IEnterCommonMovieCamera_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SpecElementIndex;
			}
			set
			{
				this.GetOrCreatePoco().SpecElementIndex = value;
			}
		}

		// Token: 0x04005CB1 RID: 23729
		[Nullable(2)]
		protected new IEnterCommonMovieCamera FbInstance;

		// Token: 0x04005CB2 RID: 23730
		[Nullable(2)]
		protected new IEnterCommonMovieCamera_SetValue PocoInterface;
	}
}

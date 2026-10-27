using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019FA RID: 6650
	[NullableContext(1)]
	[Nullable(0)]
	public class IEnterCommonMovieCamera : IEnterMovieCameraType
	{
		// Token: 0x06008E79 RID: 36473 RVA: 0x0014D3C8 File Offset: 0x0014B5C8
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

		// Token: 0x06008E7A RID: 36474 RVA: 0x0014D400 File Offset: 0x0014B600
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

		// Token: 0x06008E7B RID: 36475 RVA: 0x0014D413 File Offset: 0x0014B613
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

		// Token: 0x06008E7C RID: 36476 RVA: 0x0014D426 File Offset: 0x0014B626
		public new IEnterCommonMovieCamera_SetValue ToSetValue()
		{
			return new IEnterCommonMovieCamera_SetValue
			{
				Type = this.Type,
				RowName = this.RowName,
				SpecElementIndex = this.SpecElementIndex
			};
		}

		// Token: 0x17002D9A RID: 11674
		// (get) Token: 0x06008E7D RID: 36477 RVA: 0x0014D451 File Offset: 0x0014B651
		// (set) Token: 0x06008E7E RID: 36478 RVA: 0x0014D47C File Offset: 0x0014B67C
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

		// Token: 0x17002D9B RID: 11675
		// (get) Token: 0x06008E7F RID: 36479 RVA: 0x0014D48A File Offset: 0x0014B68A
		// (set) Token: 0x06008E80 RID: 36480 RVA: 0x0014D4B5 File Offset: 0x0014B6B5
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

		// Token: 0x17002D9C RID: 11676
		// (get) Token: 0x06008E81 RID: 36481 RVA: 0x0014D4C4 File Offset: 0x0014B6C4
		// (set) Token: 0x06008E82 RID: 36482 RVA: 0x0014D4FE File Offset: 0x0014B6FE
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

		// Token: 0x0400584F RID: 22607
		[Nullable(2)]
		protected new IEnterCommonMovieCamera FbInstance;

		// Token: 0x04005850 RID: 22608
		[Nullable(2)]
		protected new IEnterCommonMovieCamera_SetValue PocoInterface;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200194C RID: 6476
	[NullableContext(1)]
	[Nullable(0)]
	public class ICustomScreenLoading : ICustomScreenTypeBase
	{
		// Token: 0x06008AC5 RID: 35525 RVA: 0x00146A50 File Offset: 0x00144C50
		private ICustomScreenLoading_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICustomScreenLoading 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICustomScreenLoading_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICustomScreenLoading_SetValue());
			}
			return result;
		}

		// Token: 0x06008AC6 RID: 35526 RVA: 0x00146A88 File Offset: 0x00144C88
		public static ICustomScreenLoading Create([Nullable(2)] ICustomScreenLoading instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomScreenLoading
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008AC7 RID: 35527 RVA: 0x00146A9B File Offset: 0x00144C9B
		public static ICustomScreenLoading CreateFromSetValue([Nullable(2)] ICustomScreenLoading_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICustomScreenLoading
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008AC8 RID: 35528 RVA: 0x00146AAE File Offset: 0x00144CAE
		public new ICustomScreenLoading_SetValue ToSetValue()
		{
			return new ICustomScreenLoading_SetValue
			{
				Type = this.Type,
				LoadingType = this.LoadingType
			};
		}

		// Token: 0x17002CC5 RID: 11461
		// (get) Token: 0x06008AC9 RID: 35529 RVA: 0x00146ACD File Offset: 0x00144CCD
		// (set) Token: 0x06008ACA RID: 35530 RVA: 0x00146AF8 File Offset: 0x00144CF8
		public override ECustomScreenType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECustomScreenType.Spine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002CC6 RID: 11462
		// (get) Token: 0x06008ACB RID: 35531 RVA: 0x00146B08 File Offset: 0x00144D08
		// (set) Token: 0x06008ACC RID: 35532 RVA: 0x00146B69 File Offset: 0x00144D69
		public virtual ICustomScreenLoadingCyberpunk LoadingType
		{
			get
			{
				if (this._LoadingTypeInited)
				{
					return this._LoadingTypeCache;
				}
				this._LoadingTypeInited = true;
				if (this.FbInstance != null)
				{
					this._LoadingTypeCache = ICustomScreenLoadingCyberpunk.Create(this.FbInstance.LoadingType);
				}
				else
				{
					ICustomScreenLoading_SetValue pocoInterface = this.PocoInterface;
					this._LoadingTypeCache = ((pocoInterface != null) ? pocoInterface.LoadingType : null);
				}
				return this._LoadingTypeCache;
			}
			set
			{
				this.GetOrCreatePoco().LoadingType = value;
				this._LoadingTypeInited = false;
			}
		}

		// Token: 0x040056AC RID: 22188
		[Nullable(2)]
		protected new ICustomScreenLoading FbInstance;

		// Token: 0x040056AD RID: 22189
		[Nullable(2)]
		protected new ICustomScreenLoading_SetValue PocoInterface;

		// Token: 0x040056AE RID: 22190
		private ICustomScreenLoadingCyberpunk _LoadingTypeCache;

		// Token: 0x040056AF RID: 22191
		private bool _LoadingTypeInited;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AD7 RID: 6871
	public class ICustomScreenLoading : ICustomScreenTypeBase
	{
		// Token: 0x060091F9 RID: 37369 RVA: 0x0015644C File Offset: 0x0015464C
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

		// Token: 0x060091FA RID: 37370 RVA: 0x00156484 File Offset: 0x00154684
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

		// Token: 0x060091FB RID: 37371 RVA: 0x00156497 File Offset: 0x00154697
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

		// Token: 0x060091FC RID: 37372 RVA: 0x001564AA File Offset: 0x001546AA
		public new ICustomScreenLoading_SetValue ToSetValue()
		{
			return new ICustomScreenLoading_SetValue
			{
				Type = this.Type,
				LoadingType = this.LoadingType
			};
		}

		// Token: 0x17002EC6 RID: 11974
		// (get) Token: 0x060091FD RID: 37373 RVA: 0x001564C9 File Offset: 0x001546C9
		// (set) Token: 0x060091FE RID: 37374 RVA: 0x001564F4 File Offset: 0x001546F4
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

		// Token: 0x17002EC7 RID: 11975
		// (get) Token: 0x060091FF RID: 37375 RVA: 0x00156504 File Offset: 0x00154704
		// (set) Token: 0x06009200 RID: 37376 RVA: 0x00156565 File Offset: 0x00154765
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

		// Token: 0x04005AFF RID: 23295
		[Nullable(2)]
		protected new ICustomScreenLoading FbInstance;

		// Token: 0x04005B00 RID: 23296
		[Nullable(2)]
		protected new ICustomScreenLoading_SetValue PocoInterface;

		// Token: 0x04005B01 RID: 23297
		private ICustomScreenLoadingCyberpunk _LoadingTypeCache;

		// Token: 0x04005B02 RID: 23298
		private bool _LoadingTypeInited;
	}
}

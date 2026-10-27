using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200104D RID: 4173
	[NullableContext(1)]
	[Nullable(0)]
	public class IPhotoTarget
	{
		// Token: 0x06005D7A RID: 23930 RVA: 0x000E24A4 File Offset: 0x000E06A4
		private IPhotoTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPhotoTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPhotoTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPhotoTarget_SetValue());
			}
			return result;
		}

		// Token: 0x06005D7B RID: 23931 RVA: 0x000E24DC File Offset: 0x000E06DC
		public static IPhotoTarget Create([Nullable(2)] IPhotoTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhotoTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005D7C RID: 23932 RVA: 0x000E24EF File Offset: 0x000E06EF
		public static IPhotoTarget CreateFromSetValue([Nullable(2)] IPhotoTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPhotoTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005D7D RID: 23933 RVA: 0x000E2504 File Offset: 0x000E0704
		public IPhotoTarget_SetValue ToSetValue()
		{
			return new IPhotoTarget_SetValue
			{
				EntityId = this.EntityId,
				TidDescription = this.TidDescription,
				IsOptionalTarget = this.IsOptionalTarget,
				SetVar = this.SetVar,
				EdTidDescription = this.EdTidDescription
			};
		}

		// Token: 0x17001ECB RID: 7883
		// (get) Token: 0x06005D7E RID: 23934 RVA: 0x000E2552 File Offset: 0x000E0752
		// (set) Token: 0x06005D7F RID: 23935 RVA: 0x000E257D File Offset: 0x000E077D
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17001ECC RID: 7884
		// (get) Token: 0x06005D80 RID: 23936 RVA: 0x000E258B File Offset: 0x000E078B
		// (set) Token: 0x06005D81 RID: 23937 RVA: 0x000E25B6 File Offset: 0x000E07B6
		public virtual string TidDescription
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidDescription;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidDescription;
			}
			set
			{
				this.GetOrCreatePoco().TidDescription = value;
			}
		}

		// Token: 0x17001ECD RID: 7885
		// (get) Token: 0x06005D82 RID: 23938 RVA: 0x000E25C4 File Offset: 0x000E07C4
		// (set) Token: 0x06005D83 RID: 23939 RVA: 0x000E25FE File Offset: 0x000E07FE
		public virtual bool? IsOptionalTarget
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsOptionalTarget;
				}
				IPhotoTarget_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsOptionalTarget;
			}
			set
			{
				this.GetOrCreatePoco().IsOptionalTarget = value;
			}
		}

		// Token: 0x17001ECE RID: 7886
		// (get) Token: 0x06005D84 RID: 23940 RVA: 0x000E260C File Offset: 0x000E080C
		// (set) Token: 0x06005D85 RID: 23941 RVA: 0x000E266D File Offset: 0x000E086D
		[Nullable(2)]
		public virtual SetVar SetVar
		{
			[NullableContext(2)]
			get
			{
				if (this._SetVarInited)
				{
					return this._SetVarCache;
				}
				this._SetVarInited = true;
				if (this.FbInstance != null)
				{
					this._SetVarCache = SetVar.Create(this.FbInstance.SetVar);
				}
				else
				{
					IPhotoTarget_SetValue pocoInterface = this.PocoInterface;
					this._SetVarCache = ((pocoInterface != null) ? pocoInterface.SetVar : null);
				}
				return this._SetVarCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().SetVar = value;
				this._SetVarInited = false;
			}
		}

		// Token: 0x17001ECF RID: 7887
		// (get) Token: 0x06005D86 RID: 23942 RVA: 0x000E2682 File Offset: 0x000E0882
		// (set) Token: 0x06005D87 RID: 23943 RVA: 0x000E2699 File Offset: 0x000E0899
		[Nullable(2)]
		public virtual string EdTidDescription
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidDescription;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidDescription = value;
			}
		}

		// Token: 0x04003848 RID: 14408
		[Nullable(2)]
		protected IPhotoTarget FbInstance;

		// Token: 0x04003849 RID: 14409
		[Nullable(2)]
		protected IPhotoTarget_SetValue PocoInterface;

		// Token: 0x0400384A RID: 14410
		private SetVar _SetVarCache;

		// Token: 0x0400384B RID: 14411
		private bool _SetVarInited;
	}
}

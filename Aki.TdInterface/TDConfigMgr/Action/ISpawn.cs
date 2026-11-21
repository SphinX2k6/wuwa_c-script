using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020CE RID: 8398
	public class ISpawn
	{
		// Token: 0x0600B24C RID: 45644 RVA: 0x001907D8 File Offset: 0x0018E9D8
		private ISpawn_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISpawn 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISpawn_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISpawn_SetValue());
			}
			return result;
		}

		// Token: 0x0600B24D RID: 45645 RVA: 0x00190810 File Offset: 0x0018EA10
		public static ISpawn Create([Nullable(2)] ISpawn instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpawn
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B24E RID: 45646 RVA: 0x00190823 File Offset: 0x0018EA23
		public static ISpawn CreateFromSetValue([Nullable(2)] ISpawn_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISpawn
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B24F RID: 45647 RVA: 0x00190836 File Offset: 0x0018EA36
		public ISpawn_SetValue ToSetValue()
		{
			return new ISpawn_SetValue
			{
				TemplateGuid = this.TemplateGuid,
				Transform = this.Transform
			};
		}

		// Token: 0x17003600 RID: 13824
		// (get) Token: 0x0600B250 RID: 45648 RVA: 0x00190855 File Offset: 0x0018EA55
		// (set) Token: 0x0600B251 RID: 45649 RVA: 0x00190880 File Offset: 0x0018EA80
		public virtual int TemplateGuid
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TemplateGuid;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TemplateGuid;
			}
			set
			{
				this.GetOrCreatePoco().TemplateGuid = value;
			}
		}

		// Token: 0x17003601 RID: 13825
		// (get) Token: 0x0600B252 RID: 45650 RVA: 0x00190890 File Offset: 0x0018EA90
		// (set) Token: 0x0600B253 RID: 45651 RVA: 0x001908F1 File Offset: 0x0018EAF1
		public virtual ITransform Transform
		{
			get
			{
				if (this._TransformInited)
				{
					return this._TransformCache;
				}
				this._TransformInited = true;
				if (this.FbInstance != null)
				{
					this._TransformCache = ITransform.Create(this.FbInstance.Transform);
				}
				else
				{
					ISpawn_SetValue pocoInterface = this.PocoInterface;
					this._TransformCache = ((pocoInterface != null) ? pocoInterface.Transform : null);
				}
				return this._TransformCache;
			}
			set
			{
				this.GetOrCreatePoco().Transform = value;
				this._TransformInited = false;
			}
		}

		// Token: 0x040069D3 RID: 27091
		[Nullable(2)]
		protected ISpawn FbInstance;

		// Token: 0x040069D4 RID: 27092
		[Nullable(2)]
		protected ISpawn_SetValue PocoInterface;

		// Token: 0x040069D5 RID: 27093
		private ITransform _TransformCache;

		// Token: 0x040069D6 RID: 27094
		private bool _TransformInited;
	}
}

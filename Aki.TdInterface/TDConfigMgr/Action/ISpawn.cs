using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E99 RID: 7833
	[NullableContext(1)]
	[Nullable(0)]
	public class ISpawn
	{
		// Token: 0x0600A794 RID: 42900 RVA: 0x0017AAD8 File Offset: 0x00178CD8
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

		// Token: 0x0600A795 RID: 42901 RVA: 0x0017AB10 File Offset: 0x00178D10
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

		// Token: 0x0600A796 RID: 42902 RVA: 0x0017AB23 File Offset: 0x00178D23
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

		// Token: 0x0600A797 RID: 42903 RVA: 0x0017AB36 File Offset: 0x00178D36
		public ISpawn_SetValue ToSetValue()
		{
			return new ISpawn_SetValue
			{
				TemplateGuid = this.TemplateGuid,
				Transform = this.Transform
			};
		}

		// Token: 0x1700333C RID: 13116
		// (get) Token: 0x0600A798 RID: 42904 RVA: 0x0017AB55 File Offset: 0x00178D55
		// (set) Token: 0x0600A799 RID: 42905 RVA: 0x0017AB80 File Offset: 0x00178D80
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

		// Token: 0x1700333D RID: 13117
		// (get) Token: 0x0600A79A RID: 42906 RVA: 0x0017AB90 File Offset: 0x00178D90
		// (set) Token: 0x0600A79B RID: 42907 RVA: 0x0017ABF1 File Offset: 0x00178DF1
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

		// Token: 0x040063EF RID: 25583
		[Nullable(2)]
		protected ISpawn FbInstance;

		// Token: 0x040063F0 RID: 25584
		[Nullable(2)]
		protected ISpawn_SetValue PocoInterface;

		// Token: 0x040063F1 RID: 25585
		private ITransform _TransformCache;

		// Token: 0x040063F2 RID: 25586
		private bool _TransformInited;
	}
}

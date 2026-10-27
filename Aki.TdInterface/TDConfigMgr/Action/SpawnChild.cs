using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002214 RID: 8724
	[NullableContext(1)]
	[Nullable(0)]
	public class SpawnChild : ActionParams
	{
		// Token: 0x0600BF86 RID: 49030 RVA: 0x001B84A4 File Offset: 0x001B66A4
		private SpawnChild_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SpawnChild 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SpawnChild_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SpawnChild_SetValue());
			}
			return result;
		}

		// Token: 0x0600BF87 RID: 49031 RVA: 0x001B84DC File Offset: 0x001B66DC
		public static SpawnChild Create([Nullable(2)] SpawnChild instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SpawnChild
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BF88 RID: 49032 RVA: 0x001B84EF File Offset: 0x001B66EF
		public static SpawnChild CreateFromSetValue([Nullable(2)] SpawnChild_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SpawnChild
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BF89 RID: 49033 RVA: 0x001B8502 File Offset: 0x001B6702
		public SpawnChild_SetValue ToSetValue()
		{
			return new SpawnChild_SetValue
			{
				TemplateGuid = this.TemplateGuid,
				Transform = this.Transform
			};
		}

		// Token: 0x17003A09 RID: 14857
		// (get) Token: 0x0600BF8A RID: 49034 RVA: 0x001B8521 File Offset: 0x001B6721
		// (set) Token: 0x0600BF8B RID: 49035 RVA: 0x001B854C File Offset: 0x001B674C
		public virtual string TemplateGuid
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TemplateGuid;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TemplateGuid;
			}
			set
			{
				this.GetOrCreatePoco().TemplateGuid = value;
			}
		}

		// Token: 0x17003A0A RID: 14858
		// (get) Token: 0x0600BF8C RID: 49036 RVA: 0x001B855C File Offset: 0x001B675C
		// (set) Token: 0x0600BF8D RID: 49037 RVA: 0x001B85BD File Offset: 0x001B67BD
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
					SpawnChild_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04007231 RID: 29233
		[Nullable(2)]
		protected new SpawnChild FbInstance;

		// Token: 0x04007232 RID: 29234
		[Nullable(2)]
		protected SpawnChild_SetValue PocoInterface;

		// Token: 0x04007233 RID: 29235
		private ITransform _TransformCache;

		// Token: 0x04007234 RID: 29236
		private bool _TransformInited;
	}
}

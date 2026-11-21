using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200247F RID: 9343
	public class SpawnChild : ActionParams
	{
		// Token: 0x0600CB44 RID: 52036 RVA: 0x001CFB70 File Offset: 0x001CDD70
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

		// Token: 0x0600CB45 RID: 52037 RVA: 0x001CFBA8 File Offset: 0x001CDDA8
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

		// Token: 0x0600CB46 RID: 52038 RVA: 0x001CFBBB File Offset: 0x001CDDBB
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

		// Token: 0x0600CB47 RID: 52039 RVA: 0x001CFBCE File Offset: 0x001CDDCE
		public SpawnChild_SetValue ToSetValue()
		{
			return new SpawnChild_SetValue
			{
				TemplateGuid = this.TemplateGuid,
				Transform = this.Transform
			};
		}

		// Token: 0x17003CFF RID: 15615
		// (get) Token: 0x0600CB48 RID: 52040 RVA: 0x001CFBED File Offset: 0x001CDDED
		// (set) Token: 0x0600CB49 RID: 52041 RVA: 0x001CFC18 File Offset: 0x001CDE18
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

		// Token: 0x17003D00 RID: 15616
		// (get) Token: 0x0600CB4A RID: 52042 RVA: 0x001CFC28 File Offset: 0x001CDE28
		// (set) Token: 0x0600CB4B RID: 52043 RVA: 0x001CFC89 File Offset: 0x001CDE89
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

		// Token: 0x0400787B RID: 30843
		[Nullable(2)]
		protected new SpawnChild FbInstance;

		// Token: 0x0400787C RID: 30844
		[Nullable(2)]
		protected SpawnChild_SetValue PocoInterface;

		// Token: 0x0400787D RID: 30845
		private ITransform _TransformCache;

		// Token: 0x0400787E RID: 30846
		private bool _TransformInited;
	}
}

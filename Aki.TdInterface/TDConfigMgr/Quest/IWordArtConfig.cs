using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200134E RID: 4942
	public class IWordArtConfig
	{
		// Token: 0x06006F33 RID: 28467 RVA: 0x00107D58 File Offset: 0x00105F58
		private IWordArtConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWordArtConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWordArtConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWordArtConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06006F34 RID: 28468 RVA: 0x00107D90 File Offset: 0x00105F90
		public static IWordArtConfig Create([Nullable(2)] IWordArtConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWordArtConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006F35 RID: 28469 RVA: 0x00107DA3 File Offset: 0x00105FA3
		public static IWordArtConfig CreateFromSetValue([Nullable(2)] IWordArtConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWordArtConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006F36 RID: 28470 RVA: 0x00107DB6 File Offset: 0x00105FB6
		public IWordArtConfig_SetValue ToSetValue()
		{
			return new IWordArtConfig_SetValue
			{
				EffectiveTarget = this.EffectiveTarget,
				Resource = this.Resource
			};
		}

		// Token: 0x170023A4 RID: 9124
		// (get) Token: 0x06006F37 RID: 28471 RVA: 0x00107DD8 File Offset: 0x00105FD8
		// (set) Token: 0x06006F38 RID: 28472 RVA: 0x00107E39 File Offset: 0x00106039
		public virtual INumberWordArtEffectiveTargetType EffectiveTarget
		{
			get
			{
				if (this._EffectiveTargetInited)
				{
					return this._EffectiveTargetCache;
				}
				this._EffectiveTargetInited = true;
				if (this.FbInstance != null)
				{
					this._EffectiveTargetCache = INumberWordArtEffectiveTargetType.Create(this.FbInstance.EffectiveTarget);
				}
				else
				{
					IWordArtConfig_SetValue pocoInterface = this.PocoInterface;
					this._EffectiveTargetCache = ((pocoInterface != null) ? pocoInterface.EffectiveTarget : null);
				}
				return this._EffectiveTargetCache;
			}
			set
			{
				this.GetOrCreatePoco().EffectiveTarget = value;
				this._EffectiveTargetInited = false;
			}
		}

		// Token: 0x170023A5 RID: 9125
		// (get) Token: 0x06006F39 RID: 28473 RVA: 0x00107E50 File Offset: 0x00106050
		// (set) Token: 0x06006F3A RID: 28474 RVA: 0x00107EB1 File Offset: 0x001060B1
		public virtual IWordArtDefaultResourceType Resource
		{
			get
			{
				if (this._ResourceInited)
				{
					return this._ResourceCache;
				}
				this._ResourceInited = true;
				if (this.FbInstance != null)
				{
					this._ResourceCache = IWordArtDefaultResourceType.Create(this.FbInstance.Resource);
				}
				else
				{
					IWordArtConfig_SetValue pocoInterface = this.PocoInterface;
					this._ResourceCache = ((pocoInterface != null) ? pocoInterface.Resource : null);
				}
				return this._ResourceCache;
			}
			set
			{
				this.GetOrCreatePoco().Resource = value;
				this._ResourceInited = false;
			}
		}

		// Token: 0x04004232 RID: 16946
		[Nullable(2)]
		protected IWordArtConfig FbInstance;

		// Token: 0x04004233 RID: 16947
		[Nullable(2)]
		protected IWordArtConfig_SetValue PocoInterface;

		// Token: 0x04004234 RID: 16948
		private INumberWordArtEffectiveTargetType _EffectiveTargetCache;

		// Token: 0x04004235 RID: 16949
		private bool _EffectiveTargetInited;

		// Token: 0x04004236 RID: 16950
		private IWordArtDefaultResourceType _ResourceCache;

		// Token: 0x04004237 RID: 16951
		private bool _ResourceInited;
	}
}

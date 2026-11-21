using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F29 RID: 7977
	public class IPlayMpcEffect : PlayEffect2
	{
		// Token: 0x0600A9AF RID: 43439 RVA: 0x0018101C File Offset: 0x0017F21C
		private IPlayMpcEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlayMpcEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlayMpcEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlayMpcEffect_SetValue());
			}
			return result;
		}

		// Token: 0x0600A9B0 RID: 43440 RVA: 0x00181054 File Offset: 0x0017F254
		public static IPlayMpcEffect Create([Nullable(2)] IPlayMpcEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayMpcEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A9B1 RID: 43441 RVA: 0x00181067 File Offset: 0x0017F267
		public static IPlayMpcEffect CreateFromSetValue([Nullable(2)] IPlayMpcEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlayMpcEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A9B2 RID: 43442 RVA: 0x0018107A File Offset: 0x0017F27A
		public new IPlayMpcEffect_SetValue ToSetValue()
		{
			return new IPlayMpcEffect_SetValue
			{
				Type = this.Type,
				Path = this.Path,
				Pos2 = this.Pos2,
				Params = this.Params
			};
		}

		// Token: 0x17003428 RID: 13352
		// (get) Token: 0x0600A9B3 RID: 43443 RVA: 0x001810B1 File Offset: 0x0017F2B1
		// (set) Token: 0x0600A9B4 RID: 43444 RVA: 0x001810DC File Offset: 0x0017F2DC
		public override EEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEffectType.Effect;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003429 RID: 13353
		// (get) Token: 0x0600A9B5 RID: 43445 RVA: 0x001810EA File Offset: 0x0017F2EA
		// (set) Token: 0x0600A9B6 RID: 43446 RVA: 0x00181115 File Offset: 0x0017F315
		public override string Path
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Path;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Path;
			}
			set
			{
				this.GetOrCreatePoco().Path = value;
			}
		}

		// Token: 0x1700342A RID: 13354
		// (get) Token: 0x0600A9B7 RID: 43447 RVA: 0x00181123 File Offset: 0x0017F323
		// (set) Token: 0x0600A9B8 RID: 43448 RVA: 0x0018114A File Offset: 0x0017F34A
		public virtual IBasePos2 Pos2
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Pos2;
				}
				IPlayMpcEffect_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Pos2;
			}
			set
			{
				this.GetOrCreatePoco().Pos2 = value;
			}
		}

		// Token: 0x1700342B RID: 13355
		// (get) Token: 0x0600A9B9 RID: 43449 RVA: 0x00181158 File Offset: 0x0017F358
		// (set) Token: 0x0600A9BA RID: 43450 RVA: 0x001811EB File Offset: 0x0017F3EB
		public virtual List<IPostProcessVolumeCenterPosition> Params
		{
			get
			{
				if (this._ParamsInited)
				{
					return this._ParamsCache;
				}
				this._ParamsInited = true;
				if (this.FbInstance != null)
				{
					List<IPostProcessVolumeCenterPosition> @params = this.FbInstance.Params;
					if (@params != null)
					{
						this._ParamsCache = new List<IPostProcessVolumeCenterPosition>(@params.Count);
						for (int i = 0; i < @params.Count; i++)
						{
							this._ParamsCache.Add(IPostProcessVolumeCenterPosition.Create(@params[i]));
						}
					}
				}
				else
				{
					IPlayMpcEffect_SetValue pocoInterface = this.PocoInterface;
					this._ParamsCache = ((pocoInterface != null) ? pocoInterface.Params : null);
				}
				return this._ParamsCache;
			}
			set
			{
				this.GetOrCreatePoco().Params = value;
				this._ParamsInited = false;
			}
		}

		// Token: 0x040065DB RID: 26075
		[Nullable(2)]
		protected new IPlayMpcEffect FbInstance;

		// Token: 0x040065DC RID: 26076
		[Nullable(2)]
		protected new IPlayMpcEffect_SetValue PocoInterface;

		// Token: 0x040065DD RID: 26077
		private List<IPostProcessVolumeCenterPosition> _ParamsCache;

		// Token: 0x040065DE RID: 26078
		private bool _ParamsInited;
	}
}

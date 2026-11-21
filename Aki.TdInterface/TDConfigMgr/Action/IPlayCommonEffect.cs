using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F07 RID: 7943
	public class IPlayCommonEffect : PlayEffect2
	{
		// Token: 0x0600A907 RID: 43271 RVA: 0x0017FD88 File Offset: 0x0017DF88
		private IPlayCommonEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlayCommonEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlayCommonEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlayCommonEffect_SetValue());
			}
			return result;
		}

		// Token: 0x0600A908 RID: 43272 RVA: 0x0017FDC0 File Offset: 0x0017DFC0
		public static IPlayCommonEffect Create([Nullable(2)] IPlayCommonEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayCommonEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A909 RID: 43273 RVA: 0x0017FDD3 File Offset: 0x0017DFD3
		public static IPlayCommonEffect CreateFromSetValue([Nullable(2)] IPlayCommonEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlayCommonEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A90A RID: 43274 RVA: 0x0017FDE8 File Offset: 0x0017DFE8
		public new IPlayCommonEffect_SetValue ToSetValue()
		{
			return new IPlayCommonEffect_SetValue
			{
				Type = this.Type,
				Path = this.Path,
				Pos2 = this.Pos2,
				DestroyTime = this.DestroyTime,
				PlayEffectEnd = this.PlayEffectEnd
			};
		}

		// Token: 0x17003407 RID: 13319
		// (get) Token: 0x0600A90B RID: 43275 RVA: 0x0017FE36 File Offset: 0x0017E036
		// (set) Token: 0x0600A90C RID: 43276 RVA: 0x0017FE61 File Offset: 0x0017E061
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

		// Token: 0x17003408 RID: 13320
		// (get) Token: 0x0600A90D RID: 43277 RVA: 0x0017FE6F File Offset: 0x0017E06F
		// (set) Token: 0x0600A90E RID: 43278 RVA: 0x0017FE9A File Offset: 0x0017E09A
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

		// Token: 0x17003409 RID: 13321
		// (get) Token: 0x0600A90F RID: 43279 RVA: 0x0017FEA8 File Offset: 0x0017E0A8
		// (set) Token: 0x0600A910 RID: 43280 RVA: 0x0017FECF File Offset: 0x0017E0CF
		public virtual IBasePos2 Pos2
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Pos2;
				}
				IPlayCommonEffect_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700340A RID: 13322
		// (get) Token: 0x0600A911 RID: 43281 RVA: 0x0017FEE0 File Offset: 0x0017E0E0
		// (set) Token: 0x0600A912 RID: 43282 RVA: 0x0017FF1A File Offset: 0x0017E11A
		public virtual float? DestroyTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DestroyTime;
				}
				IPlayCommonEffect_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DestroyTime;
			}
			set
			{
				this.GetOrCreatePoco().DestroyTime = value;
			}
		}

		// Token: 0x1700340B RID: 13323
		// (get) Token: 0x0600A913 RID: 43283 RVA: 0x0017FF28 File Offset: 0x0017E128
		// (set) Token: 0x0600A914 RID: 43284 RVA: 0x0017FF62 File Offset: 0x0017E162
		public virtual bool? PlayEffectEnd
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlayEffectEnd;
				}
				IPlayCommonEffect_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PlayEffectEnd;
			}
			set
			{
				this.GetOrCreatePoco().PlayEffectEnd = value;
			}
		}

		// Token: 0x0400658E RID: 25998
		[Nullable(2)]
		protected new IPlayCommonEffect FbInstance;

		// Token: 0x0400658F RID: 25999
		[Nullable(2)]
		protected new IPlayCommonEffect_SetValue PocoInterface;
	}
}

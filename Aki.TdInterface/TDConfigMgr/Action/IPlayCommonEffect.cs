using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CFA RID: 7418
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlayCommonEffect : PlayEffect2
	{
		// Token: 0x06009F2F RID: 40751 RVA: 0x0016BBE4 File Offset: 0x00169DE4
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

		// Token: 0x06009F30 RID: 40752 RVA: 0x0016BC1C File Offset: 0x00169E1C
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

		// Token: 0x06009F31 RID: 40753 RVA: 0x0016BC2F File Offset: 0x00169E2F
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

		// Token: 0x06009F32 RID: 40754 RVA: 0x0016BC44 File Offset: 0x00169E44
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

		// Token: 0x17003177 RID: 12663
		// (get) Token: 0x06009F33 RID: 40755 RVA: 0x0016BC92 File Offset: 0x00169E92
		// (set) Token: 0x06009F34 RID: 40756 RVA: 0x0016BCBD File Offset: 0x00169EBD
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

		// Token: 0x17003178 RID: 12664
		// (get) Token: 0x06009F35 RID: 40757 RVA: 0x0016BCCB File Offset: 0x00169ECB
		// (set) Token: 0x06009F36 RID: 40758 RVA: 0x0016BCF6 File Offset: 0x00169EF6
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

		// Token: 0x17003179 RID: 12665
		// (get) Token: 0x06009F37 RID: 40759 RVA: 0x0016BD04 File Offset: 0x00169F04
		// (set) Token: 0x06009F38 RID: 40760 RVA: 0x0016BD2B File Offset: 0x00169F2B
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

		// Token: 0x1700317A RID: 12666
		// (get) Token: 0x06009F39 RID: 40761 RVA: 0x0016BD3C File Offset: 0x00169F3C
		// (set) Token: 0x06009F3A RID: 40762 RVA: 0x0016BD76 File Offset: 0x00169F76
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

		// Token: 0x1700317B RID: 12667
		// (get) Token: 0x06009F3B RID: 40763 RVA: 0x0016BD84 File Offset: 0x00169F84
		// (set) Token: 0x06009F3C RID: 40764 RVA: 0x0016BDBE File Offset: 0x00169FBE
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

		// Token: 0x0400601E RID: 24606
		[Nullable(2)]
		protected new IPlayCommonEffect FbInstance;

		// Token: 0x0400601F RID: 24607
		[Nullable(2)]
		protected new IPlayCommonEffect_SetValue PocoInterface;
	}
}

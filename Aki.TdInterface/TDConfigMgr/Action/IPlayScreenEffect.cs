using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F2F RID: 7983
	public class IPlayScreenEffect : PlayEffect2
	{
		// Token: 0x0600A9DF RID: 43487 RVA: 0x00181698 File Offset: 0x0017F898
		private IPlayScreenEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlayScreenEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlayScreenEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlayScreenEffect_SetValue());
			}
			return result;
		}

		// Token: 0x0600A9E0 RID: 43488 RVA: 0x001816D0 File Offset: 0x0017F8D0
		public static IPlayScreenEffect Create([Nullable(2)] IPlayScreenEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayScreenEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A9E1 RID: 43489 RVA: 0x001816E3 File Offset: 0x0017F8E3
		public static IPlayScreenEffect CreateFromSetValue([Nullable(2)] IPlayScreenEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlayScreenEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A9E2 RID: 43490 RVA: 0x001816F6 File Offset: 0x0017F8F6
		public new IPlayScreenEffect_SetValue ToSetValue()
		{
			return new IPlayScreenEffect_SetValue
			{
				Type = this.Type,
				Path = this.Path,
				DestroyTime = this.DestroyTime,
				BindSubScreenKey = this.BindSubScreenKey
			};
		}

		// Token: 0x17003437 RID: 13367
		// (get) Token: 0x0600A9E3 RID: 43491 RVA: 0x0018172D File Offset: 0x0017F92D
		// (set) Token: 0x0600A9E4 RID: 43492 RVA: 0x00181758 File Offset: 0x0017F958
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

		// Token: 0x17003438 RID: 13368
		// (get) Token: 0x0600A9E5 RID: 43493 RVA: 0x00181766 File Offset: 0x0017F966
		// (set) Token: 0x0600A9E6 RID: 43494 RVA: 0x00181791 File Offset: 0x0017F991
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

		// Token: 0x17003439 RID: 13369
		// (get) Token: 0x0600A9E7 RID: 43495 RVA: 0x001817A0 File Offset: 0x0017F9A0
		// (set) Token: 0x0600A9E8 RID: 43496 RVA: 0x001817DA File Offset: 0x0017F9DA
		public virtual float? DestroyTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DestroyTime;
				}
				IPlayScreenEffect_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700343A RID: 13370
		// (get) Token: 0x0600A9E9 RID: 43497 RVA: 0x001817E8 File Offset: 0x0017F9E8
		// (set) Token: 0x0600A9EA RID: 43498 RVA: 0x0018180F File Offset: 0x0017FA0F
		[Nullable(2)]
		public virtual string BindSubScreenKey
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BindSubScreenKey;
				}
				IPlayScreenEffect_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BindSubScreenKey;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().BindSubScreenKey = value;
			}
		}

		// Token: 0x040065F4 RID: 26100
		[Nullable(2)]
		protected new IPlayScreenEffect FbInstance;

		// Token: 0x040065F5 RID: 26101
		[Nullable(2)]
		protected new IPlayScreenEffect_SetValue PocoInterface;
	}
}

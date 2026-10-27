using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D1E RID: 7454
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlayScreenEffect : PlayEffect2
	{
		// Token: 0x06009FF3 RID: 40947 RVA: 0x0016D274 File Offset: 0x0016B474
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

		// Token: 0x06009FF4 RID: 40948 RVA: 0x0016D2AC File Offset: 0x0016B4AC
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

		// Token: 0x06009FF5 RID: 40949 RVA: 0x0016D2BF File Offset: 0x0016B4BF
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

		// Token: 0x06009FF6 RID: 40950 RVA: 0x0016D2D2 File Offset: 0x0016B4D2
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

		// Token: 0x170031A3 RID: 12707
		// (get) Token: 0x06009FF7 RID: 40951 RVA: 0x0016D309 File Offset: 0x0016B509
		// (set) Token: 0x06009FF8 RID: 40952 RVA: 0x0016D334 File Offset: 0x0016B534
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

		// Token: 0x170031A4 RID: 12708
		// (get) Token: 0x06009FF9 RID: 40953 RVA: 0x0016D342 File Offset: 0x0016B542
		// (set) Token: 0x06009FFA RID: 40954 RVA: 0x0016D36D File Offset: 0x0016B56D
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

		// Token: 0x170031A5 RID: 12709
		// (get) Token: 0x06009FFB RID: 40955 RVA: 0x0016D37C File Offset: 0x0016B57C
		// (set) Token: 0x06009FFC RID: 40956 RVA: 0x0016D3B6 File Offset: 0x0016B5B6
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

		// Token: 0x170031A6 RID: 12710
		// (get) Token: 0x06009FFD RID: 40957 RVA: 0x0016D3C4 File Offset: 0x0016B5C4
		// (set) Token: 0x06009FFE RID: 40958 RVA: 0x0016D3EB File Offset: 0x0016B5EB
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

		// Token: 0x04006078 RID: 24696
		[Nullable(2)]
		protected new IPlayScreenEffect FbInstance;

		// Token: 0x04006079 RID: 24697
		[Nullable(2)]
		protected new IPlayScreenEffect_SetValue PocoInterface;
	}
}

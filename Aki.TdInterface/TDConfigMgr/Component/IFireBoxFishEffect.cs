using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000386 RID: 902
	[NullableContext(1)]
	[Nullable(0)]
	public class IFireBoxFishEffect : IGraph3dEffectBase
	{
		// Token: 0x060011E3 RID: 4579 RVA: 0x0003BB94 File Offset: 0x00039D94
		private IFireBoxFishEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFireBoxFishEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFireBoxFishEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFireBoxFishEffect_SetValue());
			}
			return result;
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x0003BBCC File Offset: 0x00039DCC
		public static IFireBoxFishEffect Create([Nullable(2)] IFireBoxFishEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFireBoxFishEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x0003BBDF File Offset: 0x00039DDF
		public static IFireBoxFishEffect CreateFromSetValue([Nullable(2)] IFireBoxFishEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFireBoxFishEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x0003BBF2 File Offset: 0x00039DF2
		public new IFireBoxFishEffect_SetValue ToSetValue()
		{
			return new IFireBoxFishEffect_SetValue
			{
				Type = this.Type,
				Effect = this.Effect
			};
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x060011E7 RID: 4583 RVA: 0x0003BC11 File Offset: 0x00039E11
		// (set) Token: 0x060011E8 RID: 4584 RVA: 0x0003BC3C File Offset: 0x00039E3C
		public override EGraph3dEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EGraph3dEffectType.FireBoxFish;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x060011E9 RID: 4585 RVA: 0x0003BC4A File Offset: 0x00039E4A
		// (set) Token: 0x060011EA RID: 4586 RVA: 0x0003BC75 File Offset: 0x00039E75
		public virtual string Effect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Effect;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Effect;
			}
			set
			{
				this.GetOrCreatePoco().Effect = value;
			}
		}

		// Token: 0x04000E8B RID: 3723
		[Nullable(2)]
		protected new IFireBoxFishEffect FbInstance;

		// Token: 0x04000E8C RID: 3724
		[Nullable(2)]
		protected new IFireBoxFishEffect_SetValue PocoInterface;
	}
}

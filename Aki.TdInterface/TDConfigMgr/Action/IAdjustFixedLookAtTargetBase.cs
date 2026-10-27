using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017BE RID: 6078
	[NullableContext(1)]
	[Nullable(0)]
	public class IAdjustFixedLookAtTargetBase
	{
		// Token: 0x060081C5 RID: 33221 RVA: 0x00136130 File Offset: 0x00134330
		private IAdjustFixedLookAtTargetBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAdjustFixedLookAtTargetBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAdjustFixedLookAtTargetBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAdjustFixedLookAtTargetBase_SetValue());
			}
			return result;
		}

		// Token: 0x060081C6 RID: 33222 RVA: 0x00136168 File Offset: 0x00134368
		public static IAdjustFixedLookAtTargetBase Create([Nullable(2)] IAdjustFixedLookAtTargetBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAdjustFixedLookAtTargetBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x060081C7 RID: 33223 RVA: 0x0013617B File Offset: 0x0013437B
		public static IAdjustFixedLookAtTargetBase CreateFromSetValue([Nullable(2)] IAdjustFixedLookAtTargetBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAdjustFixedLookAtTargetBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x060081C8 RID: 33224 RVA: 0x0013618E File Offset: 0x0013438E
		public IAdjustFixedLookAtTargetBase_SetValue ToSetValue()
		{
			return new IAdjustFixedLookAtTargetBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002A9A RID: 10906
		// (get) Token: 0x060081C9 RID: 33225 RVA: 0x001361A1 File Offset: 0x001343A1
		// (set) Token: 0x060081CA RID: 33226 RVA: 0x001361CC File Offset: 0x001343CC
		public virtual EFixedLookAtTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFixedLookAtTargetType.RangeEntity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400526D RID: 21101
		[Nullable(2)]
		protected IAdjustFixedLookAtTargetBase FbInstance;

		// Token: 0x0400526E RID: 21102
		[Nullable(2)]
		protected IAdjustFixedLookAtTargetBase_SetValue PocoInterface;
	}
}

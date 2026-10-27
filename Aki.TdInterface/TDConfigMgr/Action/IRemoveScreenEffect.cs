using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DA0 RID: 7584
	[NullableContext(1)]
	[Nullable(0)]
	public class IRemoveScreenEffect : IRemoveEffectBase
	{
		// Token: 0x0600A289 RID: 41609 RVA: 0x001719EC File Offset: 0x0016FBEC
		private IRemoveScreenEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRemoveScreenEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRemoveScreenEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRemoveScreenEffect_SetValue());
			}
			return result;
		}

		// Token: 0x0600A28A RID: 41610 RVA: 0x00171A24 File Offset: 0x0016FC24
		public static IRemoveScreenEffect Create([Nullable(2)] IRemoveScreenEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRemoveScreenEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A28B RID: 41611 RVA: 0x00171A37 File Offset: 0x0016FC37
		public static IRemoveScreenEffect CreateFromSetValue([Nullable(2)] IRemoveScreenEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRemoveScreenEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A28C RID: 41612 RVA: 0x00171A4A File Offset: 0x0016FC4A
		public new IRemoveScreenEffect_SetValue ToSetValue()
		{
			return new IRemoveScreenEffect_SetValue
			{
				Type = this.Type,
				Path = this.Path
			};
		}

		// Token: 0x1700322B RID: 12843
		// (get) Token: 0x0600A28D RID: 41613 RVA: 0x00171A69 File Offset: 0x0016FC69
		// (set) Token: 0x0600A28E RID: 41614 RVA: 0x00171A94 File Offset: 0x0016FC94
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

		// Token: 0x1700322C RID: 12844
		// (get) Token: 0x0600A28F RID: 41615 RVA: 0x00171AA2 File Offset: 0x0016FCA2
		// (set) Token: 0x0600A290 RID: 41616 RVA: 0x00171ACD File Offset: 0x0016FCCD
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

		// Token: 0x0400619C RID: 24988
		[Nullable(2)]
		protected new IRemoveScreenEffect FbInstance;

		// Token: 0x0400619D RID: 24989
		[Nullable(2)]
		protected new IRemoveScreenEffect_SetValue PocoInterface;
	}
}

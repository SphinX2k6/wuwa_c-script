using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A25 RID: 6693
	public class ICipherGameplay : IUiGame
	{
		// Token: 0x06008E63 RID: 36451 RVA: 0x00150400 File Offset: 0x0014E600
		private ICipherGameplay_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICipherGameplay 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICipherGameplay_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICipherGameplay_SetValue());
			}
			return result;
		}

		// Token: 0x06008E64 RID: 36452 RVA: 0x00150438 File Offset: 0x0014E638
		public static ICipherGameplay Create([Nullable(2)] ICipherGameplay instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICipherGameplay
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008E65 RID: 36453 RVA: 0x0015044B File Offset: 0x0014E64B
		public static ICipherGameplay CreateFromSetValue([Nullable(2)] ICipherGameplay_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICipherGameplay
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008E66 RID: 36454 RVA: 0x0015045E File Offset: 0x0014E65E
		public new ICipherGameplay_SetValue ToSetValue()
		{
			return new ICipherGameplay_SetValue
			{
				Type = this.Type,
				CipherId = this.CipherId
			};
		}

		// Token: 0x17002E06 RID: 11782
		// (get) Token: 0x06008E67 RID: 36455 RVA: 0x0015047D File Offset: 0x0014E67D
		// (set) Token: 0x06008E68 RID: 36456 RVA: 0x001504A8 File Offset: 0x0014E6A8
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002E07 RID: 11783
		// (get) Token: 0x06008E69 RID: 36457 RVA: 0x001504B6 File Offset: 0x0014E6B6
		// (set) Token: 0x06008E6A RID: 36458 RVA: 0x001504E1 File Offset: 0x0014E6E1
		public virtual string CipherId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CipherId;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.CipherId;
			}
			set
			{
				this.GetOrCreatePoco().CipherId = value;
			}
		}

		// Token: 0x04005975 RID: 22901
		[Nullable(2)]
		protected new ICipherGameplay FbInstance;

		// Token: 0x04005976 RID: 22902
		[Nullable(2)]
		protected new ICipherGameplay_SetValue PocoInterface;
	}
}

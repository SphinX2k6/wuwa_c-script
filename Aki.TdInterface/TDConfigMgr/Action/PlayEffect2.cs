using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200210B RID: 8459
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayEffect2 : ActionParams
	{
		// Token: 0x0600BA16 RID: 47638 RVA: 0x001AE0F0 File Offset: 0x001AC2F0
		private PlayEffect2_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("PlayEffect2 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			PlayEffect2_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new PlayEffect2_SetValue());
			}
			return result;
		}

		// Token: 0x0600BA17 RID: 47639 RVA: 0x001AE128 File Offset: 0x001AC328
		public static PlayEffect2 Create([Nullable(2)] PlayEffect2 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayEffect2
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BA18 RID: 47640 RVA: 0x001AE13B File Offset: 0x001AC33B
		public static PlayEffect2 CreateFromSetValue([Nullable(2)] PlayEffect2_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new PlayEffect2
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BA19 RID: 47641 RVA: 0x001AE14E File Offset: 0x001AC34E
		public PlayEffect2_SetValue ToSetValue()
		{
			return new PlayEffect2_SetValue
			{
				Type = this.Type,
				Path = this.Path
			};
		}

		// Token: 0x170038D4 RID: 14548
		// (get) Token: 0x0600BA1A RID: 47642 RVA: 0x001AE16D File Offset: 0x001AC36D
		// (set) Token: 0x0600BA1B RID: 47643 RVA: 0x001AE198 File Offset: 0x001AC398
		public virtual EEffectType Type
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

		// Token: 0x170038D5 RID: 14549
		// (get) Token: 0x0600BA1C RID: 47644 RVA: 0x001AE1A6 File Offset: 0x001AC3A6
		// (set) Token: 0x0600BA1D RID: 47645 RVA: 0x001AE1D1 File Offset: 0x001AC3D1
		public virtual string Path
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

		// Token: 0x04006F67 RID: 28519
		[Nullable(2)]
		protected new PlayEffect2 FbInstance;

		// Token: 0x04006F68 RID: 28520
		[Nullable(2)]
		protected PlayEffect2_SetValue PocoInterface;
	}
}

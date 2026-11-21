using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E69 RID: 7785
	public class INpcGroupSequenceBlendAnimTypeBase
	{
		// Token: 0x0600A57D RID: 42365 RVA: 0x00179740 File Offset: 0x00177940
		private INpcGroupSequenceBlendAnimTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcGroupSequenceBlendAnimTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcGroupSequenceBlendAnimTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcGroupSequenceBlendAnimTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600A57E RID: 42366 RVA: 0x00179778 File Offset: 0x00177978
		public static INpcGroupSequenceBlendAnimTypeBase Create([Nullable(2)] INpcGroupSequenceBlendAnimTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcGroupSequenceBlendAnimTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A57F RID: 42367 RVA: 0x0017978B File Offset: 0x0017798B
		public static INpcGroupSequenceBlendAnimTypeBase CreateFromSetValue([Nullable(2)] INpcGroupSequenceBlendAnimTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcGroupSequenceBlendAnimTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A580 RID: 42368 RVA: 0x0017979E File Offset: 0x0017799E
		public INpcGroupSequenceBlendAnimTypeBase_SetValue ToSetValue()
		{
			return new INpcGroupSequenceBlendAnimTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700332F RID: 13103
		// (get) Token: 0x0600A581 RID: 42369 RVA: 0x001797B1 File Offset: 0x001779B1
		// (set) Token: 0x0600A582 RID: 42370 RVA: 0x001797DC File Offset: 0x001779DC
		public virtual ENpcGroupSequenceBlendAnimType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcGroupSequenceBlendAnimType.AnimSequence;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040063F2 RID: 25586
		[Nullable(2)]
		protected INpcGroupSequenceBlendAnimTypeBase FbInstance;

		// Token: 0x040063F3 RID: 25587
		[Nullable(2)]
		protected INpcGroupSequenceBlendAnimTypeBase_SetValue PocoInterface;
	}
}

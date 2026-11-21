using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E6D RID: 7789
	public class INpcGroupSequencePlaySetting
	{
		// Token: 0x0600A58F RID: 42383 RVA: 0x001798FC File Offset: 0x00177AFC
		private INpcGroupSequencePlaySetting_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcGroupSequencePlaySetting 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcGroupSequencePlaySetting_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcGroupSequencePlaySetting_SetValue());
			}
			return result;
		}

		// Token: 0x0600A590 RID: 42384 RVA: 0x00179934 File Offset: 0x00177B34
		public static INpcGroupSequencePlaySetting Create([Nullable(2)] INpcGroupSequencePlaySetting instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcGroupSequencePlaySetting
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A591 RID: 42385 RVA: 0x00179947 File Offset: 0x00177B47
		public static INpcGroupSequencePlaySetting CreateFromSetValue([Nullable(2)] INpcGroupSequencePlaySetting_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcGroupSequencePlaySetting
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A592 RID: 42386 RVA: 0x0017995A File Offset: 0x00177B5A
		public INpcGroupSequencePlaySetting_SetValue ToSetValue()
		{
			return new INpcGroupSequencePlaySetting_SetValue
			{
				Mark = this.Mark,
				IsLoop = this.IsLoop,
				IsWaitCurrentSequenceFinish = this.IsWaitCurrentSequenceFinish
			};
		}

		// Token: 0x17003332 RID: 13106
		// (get) Token: 0x0600A593 RID: 42387 RVA: 0x00179985 File Offset: 0x00177B85
		// (set) Token: 0x0600A594 RID: 42388 RVA: 0x001799B0 File Offset: 0x00177BB0
		public virtual string Mark
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Mark;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Mark;
			}
			set
			{
				this.GetOrCreatePoco().Mark = value;
			}
		}

		// Token: 0x17003333 RID: 13107
		// (get) Token: 0x0600A595 RID: 42389 RVA: 0x001799BE File Offset: 0x00177BBE
		// (set) Token: 0x0600A596 RID: 42390 RVA: 0x001799E9 File Offset: 0x00177BE9
		public virtual bool IsLoop
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsLoop;
				}
				return this.PocoInterface != null && this.PocoInterface.IsLoop;
			}
			set
			{
				this.GetOrCreatePoco().IsLoop = value;
			}
		}

		// Token: 0x17003334 RID: 13108
		// (get) Token: 0x0600A597 RID: 42391 RVA: 0x001799F7 File Offset: 0x00177BF7
		// (set) Token: 0x0600A598 RID: 42392 RVA: 0x00179A22 File Offset: 0x00177C22
		public virtual bool IsWaitCurrentSequenceFinish
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsWaitCurrentSequenceFinish;
				}
				return this.PocoInterface != null && this.PocoInterface.IsWaitCurrentSequenceFinish;
			}
			set
			{
				this.GetOrCreatePoco().IsWaitCurrentSequenceFinish = value;
			}
		}

		// Token: 0x040063F9 RID: 25593
		[Nullable(2)]
		protected INpcGroupSequencePlaySetting FbInstance;

		// Token: 0x040063FA RID: 25594
		[Nullable(2)]
		protected INpcGroupSequencePlaySetting_SetValue PocoInterface;
	}
}

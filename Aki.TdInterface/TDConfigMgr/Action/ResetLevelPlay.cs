using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002160 RID: 8544
	[NullableContext(1)]
	[Nullable(0)]
	public class ResetLevelPlay : ActionParams
	{
		// Token: 0x0600BBFA RID: 48122 RVA: 0x001B1ADC File Offset: 0x001AFCDC
		private ResetLevelPlay_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ResetLevelPlay 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ResetLevelPlay_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ResetLevelPlay_SetValue());
			}
			return result;
		}

		// Token: 0x0600BBFB RID: 48123 RVA: 0x001B1B14 File Offset: 0x001AFD14
		public static ResetLevelPlay Create([Nullable(2)] ResetLevelPlay instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ResetLevelPlay
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BBFC RID: 48124 RVA: 0x001B1B27 File Offset: 0x001AFD27
		public static ResetLevelPlay CreateFromSetValue([Nullable(2)] ResetLevelPlay_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ResetLevelPlay
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BBFD RID: 48125 RVA: 0x001B1B3A File Offset: 0x001AFD3A
		public ResetLevelPlay_SetValue ToSetValue()
		{
			return new ResetLevelPlay_SetValue
			{
				ResetLevelPlayList = this.ResetLevelPlayList
			};
		}

		// Token: 0x1700394A RID: 14666
		// (get) Token: 0x0600BBFE RID: 48126 RVA: 0x001B1B4D File Offset: 0x001AFD4D
		// (set) Token: 0x0600BBFF RID: 48127 RVA: 0x001B1B74 File Offset: 0x001AFD74
		public virtual List<int> ResetLevelPlayList
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ResetLevelPlayList;
				}
				ResetLevelPlay_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ResetLevelPlayList;
			}
			set
			{
				this.GetOrCreatePoco().ResetLevelPlayList = value;
			}
		}

		// Token: 0x04007052 RID: 28754
		[Nullable(2)]
		protected new ResetLevelPlay FbInstance;

		// Token: 0x04007053 RID: 28755
		[Nullable(2)]
		protected ResetLevelPlay_SetValue PocoInterface;
	}
}

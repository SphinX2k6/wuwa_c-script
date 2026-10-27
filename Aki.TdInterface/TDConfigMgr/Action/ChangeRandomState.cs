using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014E4 RID: 5348
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeRandomState : ActionParams
	{
		// Token: 0x060079BA RID: 31162 RVA: 0x00123294 File Offset: 0x00121494
		private ChangeRandomState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ChangeRandomState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ChangeRandomState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ChangeRandomState_SetValue());
			}
			return result;
		}

		// Token: 0x060079BB RID: 31163 RVA: 0x001232CC File Offset: 0x001214CC
		public static ChangeRandomState Create([Nullable(2)] ChangeRandomState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeRandomState
			{
				FbInstance = instance
			};
		}

		// Token: 0x060079BC RID: 31164 RVA: 0x001232DF File Offset: 0x001214DF
		public static ChangeRandomState CreateFromSetValue([Nullable(2)] ChangeRandomState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ChangeRandomState
			{
				PocoInterface = value
			};
		}

		// Token: 0x060079BD RID: 31165 RVA: 0x001232F2 File Offset: 0x001214F2
		public ChangeRandomState_SetValue ToSetValue()
		{
			return new ChangeRandomState_SetValue
			{
				StateIds = this.StateIds
			};
		}

		// Token: 0x170028BD RID: 10429
		// (get) Token: 0x060079BE RID: 31166 RVA: 0x00123305 File Offset: 0x00121505
		// (set) Token: 0x060079BF RID: 31167 RVA: 0x0012332C File Offset: 0x0012152C
		public virtual List<int> StateIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StateIds;
				}
				ChangeRandomState_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StateIds;
			}
			set
			{
				this.GetOrCreatePoco().StateIds = value;
			}
		}

		// Token: 0x0400469A RID: 18074
		[Nullable(2)]
		protected new ChangeRandomState FbInstance;

		// Token: 0x0400469B RID: 18075
		[Nullable(2)]
		protected ChangeRandomState_SetValue PocoInterface;
	}
}

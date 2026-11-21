using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200163D RID: 5693
	public class ChangeRandomState : ActionParams
	{
		// Token: 0x06008087 RID: 32903 RVA: 0x00131EE0 File Offset: 0x001300E0
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

		// Token: 0x06008088 RID: 32904 RVA: 0x00131F18 File Offset: 0x00130118
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

		// Token: 0x06008089 RID: 32905 RVA: 0x00131F2B File Offset: 0x0013012B
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

		// Token: 0x0600808A RID: 32906 RVA: 0x00131F3E File Offset: 0x0013013E
		public ChangeRandomState_SetValue ToSetValue()
		{
			return new ChangeRandomState_SetValue
			{
				StateIds = this.StateIds
			};
		}

		// Token: 0x17002AA7 RID: 10919
		// (get) Token: 0x0600808B RID: 32907 RVA: 0x00131F51 File Offset: 0x00130151
		// (set) Token: 0x0600808C RID: 32908 RVA: 0x00131F78 File Offset: 0x00130178
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

		// Token: 0x04004A35 RID: 18997
		[Nullable(2)]
		protected new ChangeRandomState FbInstance;

		// Token: 0x04004A36 RID: 18998
		[Nullable(2)]
		protected ChangeRandomState_SetValue PocoInterface;
	}
}

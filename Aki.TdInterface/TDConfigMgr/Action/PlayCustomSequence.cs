using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002366 RID: 9062
	public class PlayCustomSequence : ActionParams
	{
		// Token: 0x0600C584 RID: 50564 RVA: 0x001C4F4C File Offset: 0x001C314C
		private PlayCustomSequence_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("PlayCustomSequence 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			PlayCustomSequence_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new PlayCustomSequence_SetValue());
			}
			return result;
		}

		// Token: 0x0600C585 RID: 50565 RVA: 0x001C4F84 File Offset: 0x001C3184
		public static PlayCustomSequence Create([Nullable(2)] PlayCustomSequence instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayCustomSequence
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C586 RID: 50566 RVA: 0x001C4F97 File Offset: 0x001C3197
		public static PlayCustomSequence CreateFromSetValue([Nullable(2)] PlayCustomSequence_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new PlayCustomSequence
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C587 RID: 50567 RVA: 0x001C4FAA File Offset: 0x001C31AA
		public PlayCustomSequence_SetValue ToSetValue()
		{
			return new PlayCustomSequence_SetValue
			{
				CustomSeqId = this.CustomSeqId,
				WhoIds = this.WhoIds,
				ResetCamera = this.ResetCamera
			};
		}

		// Token: 0x17003BBA RID: 15290
		// (get) Token: 0x0600C588 RID: 50568 RVA: 0x001C4FD5 File Offset: 0x001C31D5
		// (set) Token: 0x0600C589 RID: 50569 RVA: 0x001C5000 File Offset: 0x001C3200
		public virtual int CustomSeqId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CustomSeqId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.CustomSeqId;
			}
			set
			{
				this.GetOrCreatePoco().CustomSeqId = value;
			}
		}

		// Token: 0x17003BBB RID: 15291
		// (get) Token: 0x0600C58A RID: 50570 RVA: 0x001C500E File Offset: 0x001C320E
		// (set) Token: 0x0600C58B RID: 50571 RVA: 0x001C5035 File Offset: 0x001C3235
		public virtual List<int> WhoIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WhoIds;
				}
				PlayCustomSequence_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.WhoIds;
			}
			set
			{
				this.GetOrCreatePoco().WhoIds = value;
			}
		}

		// Token: 0x17003BBC RID: 15292
		// (get) Token: 0x0600C58C RID: 50572 RVA: 0x001C5044 File Offset: 0x001C3244
		// (set) Token: 0x0600C58D RID: 50573 RVA: 0x001C507E File Offset: 0x001C327E
		public virtual bool? ResetCamera
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ResetCamera;
				}
				PlayCustomSequence_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ResetCamera;
			}
			set
			{
				this.GetOrCreatePoco().ResetCamera = value;
			}
		}

		// Token: 0x0400758F RID: 30095
		[Nullable(2)]
		protected new PlayCustomSequence FbInstance;

		// Token: 0x04007590 RID: 30096
		[Nullable(2)]
		protected PlayCustomSequence_SetValue PocoInterface;
	}
}

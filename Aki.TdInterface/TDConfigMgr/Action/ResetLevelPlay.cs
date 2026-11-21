using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023C1 RID: 9153
	public class ResetLevelPlay : ActionParams
	{
		// Token: 0x0600C788 RID: 51080 RVA: 0x001C8C90 File Offset: 0x001C6E90
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

		// Token: 0x0600C789 RID: 51081 RVA: 0x001C8CC8 File Offset: 0x001C6EC8
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

		// Token: 0x0600C78A RID: 51082 RVA: 0x001C8CDB File Offset: 0x001C6EDB
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

		// Token: 0x0600C78B RID: 51083 RVA: 0x001C8CEE File Offset: 0x001C6EEE
		public ResetLevelPlay_SetValue ToSetValue()
		{
			return new ResetLevelPlay_SetValue
			{
				ResetLevelPlayList = this.ResetLevelPlayList
			};
		}

		// Token: 0x17003C37 RID: 15415
		// (get) Token: 0x0600C78C RID: 51084 RVA: 0x001C8D01 File Offset: 0x001C6F01
		// (set) Token: 0x0600C78D RID: 51085 RVA: 0x001C8D28 File Offset: 0x001C6F28
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

		// Token: 0x04007687 RID: 30343
		[Nullable(2)]
		protected new ResetLevelPlay FbInstance;

		// Token: 0x04007688 RID: 30344
		[Nullable(2)]
		protected ResetLevelPlay_SetValue PocoInterface;
	}
}

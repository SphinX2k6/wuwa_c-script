using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001971 RID: 6513
	public class IAudioStateGroup
	{
		// Token: 0x06008A8F RID: 35471 RVA: 0x001494E0 File Offset: 0x001476E0
		private IAudioStateGroup_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAudioStateGroup 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAudioStateGroup_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAudioStateGroup_SetValue());
			}
			return result;
		}

		// Token: 0x06008A90 RID: 35472 RVA: 0x00149518 File Offset: 0x00147718
		public static IAudioStateGroup Create([Nullable(2)] IAudioStateGroup instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAudioStateGroup
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008A91 RID: 35473 RVA: 0x0014952B File Offset: 0x0014772B
		public static IAudioStateGroup CreateFromSetValue([Nullable(2)] IAudioStateGroup_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAudioStateGroup
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008A92 RID: 35474 RVA: 0x0014953E File Offset: 0x0014773E
		public IAudioStateGroup_SetValue ToSetValue()
		{
			return new IAudioStateGroup_SetValue
			{
				Group = this.Group,
				States = this.States
			};
		}

		// Token: 0x17002D2A RID: 11562
		// (get) Token: 0x06008A93 RID: 35475 RVA: 0x0014955D File Offset: 0x0014775D
		// (set) Token: 0x06008A94 RID: 35476 RVA: 0x00149588 File Offset: 0x00147788
		public virtual string Group
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Group;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Group;
			}
			set
			{
				this.GetOrCreatePoco().Group = value;
			}
		}

		// Token: 0x17002D2B RID: 11563
		// (get) Token: 0x06008A95 RID: 35477 RVA: 0x00149596 File Offset: 0x00147796
		// (set) Token: 0x06008A96 RID: 35478 RVA: 0x001495BD File Offset: 0x001477BD
		public virtual List<string> States
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.States;
				}
				IAudioStateGroup_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.States;
			}
			set
			{
				this.GetOrCreatePoco().States = value;
			}
		}

		// Token: 0x040057B1 RID: 22449
		[Nullable(2)]
		protected IAudioStateGroup FbInstance;

		// Token: 0x040057B2 RID: 22450
		[Nullable(2)]
		protected IAudioStateGroup_SetValue PocoInterface;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017E8 RID: 6120
	[NullableContext(1)]
	[Nullable(0)]
	public class IAudioStateGroup
	{
		// Token: 0x06008373 RID: 33651 RVA: 0x00139DF8 File Offset: 0x00137FF8
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

		// Token: 0x06008374 RID: 33652 RVA: 0x00139E30 File Offset: 0x00138030
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

		// Token: 0x06008375 RID: 33653 RVA: 0x00139E43 File Offset: 0x00138043
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

		// Token: 0x06008376 RID: 33654 RVA: 0x00139E56 File Offset: 0x00138056
		public IAudioStateGroup_SetValue ToSetValue()
		{
			return new IAudioStateGroup_SetValue
			{
				Group = this.Group,
				States = this.States
			};
		}

		// Token: 0x17002B32 RID: 11058
		// (get) Token: 0x06008377 RID: 33655 RVA: 0x00139E75 File Offset: 0x00138075
		// (set) Token: 0x06008378 RID: 33656 RVA: 0x00139EA0 File Offset: 0x001380A0
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

		// Token: 0x17002B33 RID: 11059
		// (get) Token: 0x06008379 RID: 33657 RVA: 0x00139EAE File Offset: 0x001380AE
		// (set) Token: 0x0600837A RID: 33658 RVA: 0x00139ED5 File Offset: 0x001380D5
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

		// Token: 0x04005369 RID: 21353
		[Nullable(2)]
		protected IAudioStateGroup FbInstance;

		// Token: 0x0400536A RID: 21354
		[Nullable(2)]
		protected IAudioStateGroup_SetValue PocoInterface;
	}
}

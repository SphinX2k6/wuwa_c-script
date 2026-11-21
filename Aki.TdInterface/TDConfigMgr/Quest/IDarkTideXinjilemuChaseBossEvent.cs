using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001060 RID: 4192
	public class IDarkTideXinjilemuChaseBossEvent : IDarkTideBossEvent
	{
		// Token: 0x06005C56 RID: 23638 RVA: 0x000E09F0 File Offset: 0x000DEBF0
		private IDarkTideXinjilemuChaseBossEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDarkTideXinjilemuChaseBossEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDarkTideXinjilemuChaseBossEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDarkTideXinjilemuChaseBossEvent_SetValue());
			}
			return result;
		}

		// Token: 0x06005C57 RID: 23639 RVA: 0x000E0A28 File Offset: 0x000DEC28
		public static IDarkTideXinjilemuChaseBossEvent Create([Nullable(2)] IDarkTideXinjilemuChaseBossEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDarkTideXinjilemuChaseBossEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005C58 RID: 23640 RVA: 0x000E0A3B File Offset: 0x000DEC3B
		public static IDarkTideXinjilemuChaseBossEvent CreateFromSetValue([Nullable(2)] IDarkTideXinjilemuChaseBossEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDarkTideXinjilemuChaseBossEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005C59 RID: 23641 RVA: 0x000E0A4E File Offset: 0x000DEC4E
		public new IDarkTideXinjilemuChaseBossEvent_SetValue ToSetValue()
		{
			return new IDarkTideXinjilemuChaseBossEvent_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001E97 RID: 7831
		// (get) Token: 0x06005C5A RID: 23642 RVA: 0x000E0A61 File Offset: 0x000DEC61
		// (set) Token: 0x06005C5B RID: 23643 RVA: 0x000E0A8C File Offset: 0x000DEC8C
		public override EDarkTideBossEventType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDarkTideBossEventType.XinjilemuChase;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040037A1 RID: 14241
		[Nullable(2)]
		protected new IDarkTideXinjilemuChaseBossEvent FbInstance;

		// Token: 0x040037A2 RID: 14242
		[Nullable(2)]
		protected new IDarkTideXinjilemuChaseBossEvent_SetValue PocoInterface;
	}
}

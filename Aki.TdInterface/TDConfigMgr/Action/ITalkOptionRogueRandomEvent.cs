using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F82 RID: 8066
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkOptionRogueRandomEvent : ITalkOptionParamType
	{
		// Token: 0x0600B16A RID: 45418 RVA: 0x0019E01C File Offset: 0x0019C21C
		private ITalkOptionRogueRandomEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkOptionRogueRandomEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkOptionRogueRandomEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkOptionRogueRandomEvent_SetValue());
			}
			return result;
		}

		// Token: 0x0600B16B RID: 45419 RVA: 0x0019E054 File Offset: 0x0019C254
		public static ITalkOptionRogueRandomEvent Create([Nullable(2)] ITalkOptionRogueRandomEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionRogueRandomEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B16C RID: 45420 RVA: 0x0019E067 File Offset: 0x0019C267
		public static ITalkOptionRogueRandomEvent CreateFromSetValue([Nullable(2)] ITalkOptionRogueRandomEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkOptionRogueRandomEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B16D RID: 45421 RVA: 0x0019E07A File Offset: 0x0019C27A
		public new ITalkOptionRogueRandomEvent_SetValue ToSetValue()
		{
			return new ITalkOptionRogueRandomEvent_SetValue
			{
				Type = this.Type,
				OptionId = this.OptionId
			};
		}

		// Token: 0x170036CA RID: 14026
		// (get) Token: 0x0600B16E RID: 45422 RVA: 0x0019E099 File Offset: 0x0019C299
		// (set) Token: 0x0600B16F RID: 45423 RVA: 0x0019E0C4 File Offset: 0x0019C2C4
		public override ETalkOptionParamType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkOptionParamType.QteSucceed;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170036CB RID: 14027
		// (get) Token: 0x0600B170 RID: 45424 RVA: 0x0019E0D4 File Offset: 0x0019C2D4
		// (set) Token: 0x0600B171 RID: 45425 RVA: 0x0019E10E File Offset: 0x0019C30E
		public virtual int? OptionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OptionId;
				}
				ITalkOptionRogueRandomEvent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.OptionId;
			}
			set
			{
				this.GetOrCreatePoco().OptionId = value;
			}
		}

		// Token: 0x04006B49 RID: 27465
		[Nullable(2)]
		protected new ITalkOptionRogueRandomEvent FbInstance;

		// Token: 0x04006B4A RID: 27466
		[Nullable(2)]
		protected new ITalkOptionRogueRandomEvent_SetValue PocoInterface;
	}
}

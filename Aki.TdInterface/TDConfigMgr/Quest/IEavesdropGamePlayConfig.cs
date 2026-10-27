using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F4E RID: 3918
	[NullableContext(1)]
	[Nullable(0)]
	public class IEavesdropGamePlayConfig : ISpecialGamePlayConfig
	{
		// Token: 0x06005712 RID: 22290 RVA: 0x000D5164 File Offset: 0x000D3364
		private IEavesdropGamePlayConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEavesdropGamePlayConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEavesdropGamePlayConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEavesdropGamePlayConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06005713 RID: 22291 RVA: 0x000D519C File Offset: 0x000D339C
		public static IEavesdropGamePlayConfig Create([Nullable(2)] IEavesdropGamePlayConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEavesdropGamePlayConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005714 RID: 22292 RVA: 0x000D51AF File Offset: 0x000D33AF
		public static IEavesdropGamePlayConfig CreateFromSetValue([Nullable(2)] IEavesdropGamePlayConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEavesdropGamePlayConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005715 RID: 22293 RVA: 0x000D51C4 File Offset: 0x000D33C4
		public new IEavesdropGamePlayConfig_SetValue ToSetValue()
		{
			return new IEavesdropGamePlayConfig_SetValue
			{
				Type = this.Type,
				EavesdropEntityId = this.EavesdropEntityId,
				HintRangeEntityId = this.HintRangeEntityId,
				ListenableRangeEntityId = this.ListenableRangeEntityId,
				TooCloseRangeEntityId = this.TooCloseRangeEntityId,
				HintTag = this.HintTag,
				ListenableTag = this.ListenableTag,
				TooCloseTag = this.TooCloseTag,
				ListenedTag = this.ListenedTag
			};
		}

		// Token: 0x17001D15 RID: 7445
		// (get) Token: 0x06005716 RID: 22294 RVA: 0x000D5242 File Offset: 0x000D3442
		// (set) Token: 0x06005717 RID: 22295 RVA: 0x000D526D File Offset: 0x000D346D
		public override ESpecialGamePlayConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpecialGamePlayConfigType.Stalking;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17001D16 RID: 7446
		// (get) Token: 0x06005718 RID: 22296 RVA: 0x000D527B File Offset: 0x000D347B
		// (set) Token: 0x06005719 RID: 22297 RVA: 0x000D52A6 File Offset: 0x000D34A6
		public virtual int EavesdropEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EavesdropEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EavesdropEntityId;
			}
			set
			{
				this.GetOrCreatePoco().EavesdropEntityId = value;
			}
		}

		// Token: 0x17001D17 RID: 7447
		// (get) Token: 0x0600571A RID: 22298 RVA: 0x000D52B4 File Offset: 0x000D34B4
		// (set) Token: 0x0600571B RID: 22299 RVA: 0x000D52DF File Offset: 0x000D34DF
		public virtual int HintRangeEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HintRangeEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.HintRangeEntityId;
			}
			set
			{
				this.GetOrCreatePoco().HintRangeEntityId = value;
			}
		}

		// Token: 0x17001D18 RID: 7448
		// (get) Token: 0x0600571C RID: 22300 RVA: 0x000D52ED File Offset: 0x000D34ED
		// (set) Token: 0x0600571D RID: 22301 RVA: 0x000D5318 File Offset: 0x000D3518
		public virtual int ListenableRangeEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ListenableRangeEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ListenableRangeEntityId;
			}
			set
			{
				this.GetOrCreatePoco().ListenableRangeEntityId = value;
			}
		}

		// Token: 0x17001D19 RID: 7449
		// (get) Token: 0x0600571E RID: 22302 RVA: 0x000D5326 File Offset: 0x000D3526
		// (set) Token: 0x0600571F RID: 22303 RVA: 0x000D5351 File Offset: 0x000D3551
		public virtual int TooCloseRangeEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TooCloseRangeEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TooCloseRangeEntityId;
			}
			set
			{
				this.GetOrCreatePoco().TooCloseRangeEntityId = value;
			}
		}

		// Token: 0x17001D1A RID: 7450
		// (get) Token: 0x06005720 RID: 22304 RVA: 0x000D535F File Offset: 0x000D355F
		// (set) Token: 0x06005721 RID: 22305 RVA: 0x000D538A File Offset: 0x000D358A
		public virtual int HintTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HintTag;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.HintTag;
			}
			set
			{
				this.GetOrCreatePoco().HintTag = value;
			}
		}

		// Token: 0x17001D1B RID: 7451
		// (get) Token: 0x06005722 RID: 22306 RVA: 0x000D5398 File Offset: 0x000D3598
		// (set) Token: 0x06005723 RID: 22307 RVA: 0x000D53C3 File Offset: 0x000D35C3
		public virtual int ListenableTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ListenableTag;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ListenableTag;
			}
			set
			{
				this.GetOrCreatePoco().ListenableTag = value;
			}
		}

		// Token: 0x17001D1C RID: 7452
		// (get) Token: 0x06005724 RID: 22308 RVA: 0x000D53D1 File Offset: 0x000D35D1
		// (set) Token: 0x06005725 RID: 22309 RVA: 0x000D53FC File Offset: 0x000D35FC
		public virtual int TooCloseTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TooCloseTag;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TooCloseTag;
			}
			set
			{
				this.GetOrCreatePoco().TooCloseTag = value;
			}
		}

		// Token: 0x17001D1D RID: 7453
		// (get) Token: 0x06005726 RID: 22310 RVA: 0x000D540A File Offset: 0x000D360A
		// (set) Token: 0x06005727 RID: 22311 RVA: 0x000D5435 File Offset: 0x000D3635
		public virtual int ListenedTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ListenedTag;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ListenedTag;
			}
			set
			{
				this.GetOrCreatePoco().ListenedTag = value;
			}
		}

		// Token: 0x040034BA RID: 13498
		[Nullable(2)]
		protected new IEavesdropGamePlayConfig FbInstance;

		// Token: 0x040034BB RID: 13499
		[Nullable(2)]
		protected new IEavesdropGamePlayConfig_SetValue PocoInterface;
	}
}

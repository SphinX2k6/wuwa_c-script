using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C62 RID: 7266
	[NullableContext(1)]
	[Nullable(0)]
	public class INotifyMonsterPerception : ISendBattleStateType
	{
		// Token: 0x06009BD9 RID: 39897 RVA: 0x00165B50 File Offset: 0x00163D50
		private INotifyMonsterPerception_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INotifyMonsterPerception 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INotifyMonsterPerception_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INotifyMonsterPerception_SetValue());
			}
			return result;
		}

		// Token: 0x06009BDA RID: 39898 RVA: 0x00165B88 File Offset: 0x00163D88
		public static INotifyMonsterPerception Create([Nullable(2)] INotifyMonsterPerception instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INotifyMonsterPerception
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009BDB RID: 39899 RVA: 0x00165B9B File Offset: 0x00163D9B
		public static INotifyMonsterPerception CreateFromSetValue([Nullable(2)] INotifyMonsterPerception_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INotifyMonsterPerception
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009BDC RID: 39900 RVA: 0x00165BAE File Offset: 0x00163DAE
		public new INotifyMonsterPerception_SetValue ToSetValue()
		{
			return new INotifyMonsterPerception_SetValue
			{
				Type = this.Type,
				EntityIds = this.EntityIds,
				PerceptionBehaviorOption = this.PerceptionBehaviorOption
			};
		}

		// Token: 0x170030B0 RID: 12464
		// (get) Token: 0x06009BDD RID: 39901 RVA: 0x00165BD9 File Offset: 0x00163DD9
		// (set) Token: 0x06009BDE RID: 39902 RVA: 0x00165C04 File Offset: 0x00163E04
		public override ESetBattleStateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetBattleStateType.SetBattleTag;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170030B1 RID: 12465
		// (get) Token: 0x06009BDF RID: 39903 RVA: 0x00165C12 File Offset: 0x00163E12
		// (set) Token: 0x06009BE0 RID: 39904 RVA: 0x00165C39 File Offset: 0x00163E39
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				INotifyMonsterPerception_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIds;
			}
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x170030B2 RID: 12466
		// (get) Token: 0x06009BE1 RID: 39905 RVA: 0x00165C47 File Offset: 0x00163E47
		// (set) Token: 0x06009BE2 RID: 39906 RVA: 0x00165C6E File Offset: 0x00163E6E
		public virtual IBattleStatePerceptionBehaviorType PerceptionBehaviorOption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PerceptionBehaviorOption;
				}
				INotifyMonsterPerception_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PerceptionBehaviorOption;
			}
			set
			{
				this.GetOrCreatePoco().PerceptionBehaviorOption = value;
			}
		}

		// Token: 0x04005E95 RID: 24213
		[Nullable(2)]
		protected new INotifyMonsterPerception FbInstance;

		// Token: 0x04005E96 RID: 24214
		[Nullable(2)]
		protected new INotifyMonsterPerception_SetValue PocoInterface;
	}
}

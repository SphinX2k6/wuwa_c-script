using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001864 RID: 6244
	[NullableContext(1)]
	[Nullable(0)]
	public class IChangeAnimalEmotionBubble : IExecClientBattleActionType
	{
		// Token: 0x06008627 RID: 34343 RVA: 0x0013ED98 File Offset: 0x0013CF98
		private IChangeAnimalEmotionBubble_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IChangeAnimalEmotionBubble 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IChangeAnimalEmotionBubble_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IChangeAnimalEmotionBubble_SetValue());
			}
			return result;
		}

		// Token: 0x06008628 RID: 34344 RVA: 0x0013EDD0 File Offset: 0x0013CFD0
		public static IChangeAnimalEmotionBubble Create([Nullable(2)] IChangeAnimalEmotionBubble instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeAnimalEmotionBubble
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008629 RID: 34345 RVA: 0x0013EDE3 File Offset: 0x0013CFE3
		public static IChangeAnimalEmotionBubble CreateFromSetValue([Nullable(2)] IChangeAnimalEmotionBubble_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IChangeAnimalEmotionBubble
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600862A RID: 34346 RVA: 0x0013EDF6 File Offset: 0x0013CFF6
		public new IChangeAnimalEmotionBubble_SetValue ToSetValue()
		{
			return new IChangeAnimalEmotionBubble_SetValue
			{
				Type = this.Type,
				AnimalEntityIds = this.AnimalEntityIds,
				MontagePath = this.MontagePath,
				EmotionName = this.EmotionName
			};
		}

		// Token: 0x17002BD2 RID: 11218
		// (get) Token: 0x0600862B RID: 34347 RVA: 0x0013EE2D File Offset: 0x0013D02D
		// (set) Token: 0x0600862C RID: 34348 RVA: 0x0013EE58 File Offset: 0x0013D058
		public override EExecClientBattleActionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExecClientBattleActionType.SendTagEventToControlCharacter;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002BD3 RID: 11219
		// (get) Token: 0x0600862D RID: 34349 RVA: 0x0013EE66 File Offset: 0x0013D066
		// (set) Token: 0x0600862E RID: 34350 RVA: 0x0013EE8D File Offset: 0x0013D08D
		public virtual List<int> AnimalEntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AnimalEntityIds;
				}
				IChangeAnimalEmotionBubble_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AnimalEntityIds;
			}
			set
			{
				this.GetOrCreatePoco().AnimalEntityIds = value;
			}
		}

		// Token: 0x17002BD4 RID: 11220
		// (get) Token: 0x0600862F RID: 34351 RVA: 0x0013EE9B File Offset: 0x0013D09B
		// (set) Token: 0x06008630 RID: 34352 RVA: 0x0013EEC6 File Offset: 0x0013D0C6
		public virtual string MontagePath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MontagePath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.MontagePath;
			}
			set
			{
				this.GetOrCreatePoco().MontagePath = value;
			}
		}

		// Token: 0x17002BD5 RID: 11221
		// (get) Token: 0x06008631 RID: 34353 RVA: 0x0013EED4 File Offset: 0x0013D0D4
		// (set) Token: 0x06008632 RID: 34354 RVA: 0x0013EEFF File Offset: 0x0013D0FF
		public virtual string EmotionName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EmotionName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.EmotionName;
			}
			set
			{
				this.GetOrCreatePoco().EmotionName = value;
			}
		}

		// Token: 0x040054AB RID: 21675
		[Nullable(2)]
		protected new IChangeAnimalEmotionBubble FbInstance;

		// Token: 0x040054AC RID: 21676
		[Nullable(2)]
		protected new IChangeAnimalEmotionBubble_SetValue PocoInterface;
	}
}

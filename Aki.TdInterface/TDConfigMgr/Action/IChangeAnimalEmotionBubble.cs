using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019EF RID: 6639
	public class IChangeAnimalEmotionBubble : IExecClientBattleActionType
	{
		// Token: 0x06008D4F RID: 36175 RVA: 0x0014E5CC File Offset: 0x0014C7CC
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

		// Token: 0x06008D50 RID: 36176 RVA: 0x0014E604 File Offset: 0x0014C804
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

		// Token: 0x06008D51 RID: 36177 RVA: 0x0014E617 File Offset: 0x0014C817
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

		// Token: 0x06008D52 RID: 36178 RVA: 0x0014E62A File Offset: 0x0014C82A
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

		// Token: 0x17002DCD RID: 11725
		// (get) Token: 0x06008D53 RID: 36179 RVA: 0x0014E661 File Offset: 0x0014C861
		// (set) Token: 0x06008D54 RID: 36180 RVA: 0x0014E68C File Offset: 0x0014C88C
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

		// Token: 0x17002DCE RID: 11726
		// (get) Token: 0x06008D55 RID: 36181 RVA: 0x0014E69A File Offset: 0x0014C89A
		// (set) Token: 0x06008D56 RID: 36182 RVA: 0x0014E6C1 File Offset: 0x0014C8C1
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

		// Token: 0x17002DCF RID: 11727
		// (get) Token: 0x06008D57 RID: 36183 RVA: 0x0014E6CF File Offset: 0x0014C8CF
		// (set) Token: 0x06008D58 RID: 36184 RVA: 0x0014E6FA File Offset: 0x0014C8FA
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

		// Token: 0x17002DD0 RID: 11728
		// (get) Token: 0x06008D59 RID: 36185 RVA: 0x0014E708 File Offset: 0x0014C908
		// (set) Token: 0x06008D5A RID: 36186 RVA: 0x0014E733 File Offset: 0x0014C933
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

		// Token: 0x040058F8 RID: 22776
		[Nullable(2)]
		protected new IChangeAnimalEmotionBubble FbInstance;

		// Token: 0x040058F9 RID: 22777
		[Nullable(2)]
		protected new IChangeAnimalEmotionBubble_SetValue PocoInterface;
	}
}

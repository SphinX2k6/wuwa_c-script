using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Protocol.CombatMessage;

namespace CSharpScript.Game.Module.CombatMessage
{
	// Token: 0x02005BAF RID: 23471
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class CombatMessageModel : ModelBase
	{
		// Token: 0x0603B5AC RID: 243116 RVA: 0x00E2820C File Offset: 0x00E2640C
		protected override bool OnLeaveLevel()
		{
			this.AnyEntityInFight = false;
			return true;
		}

		// Token: 0x0603B5AD RID: 243117 RVA: 0x00E28216 File Offset: 0x00E26416
		protected override bool OnChangeMode()
		{
			this.AnyEntityInFight = false;
			return true;
		}

		// Token: 0x0603B5AE RID: 243118 RVA: 0x00E28220 File Offset: 0x00E26420
		public bool AddMoveSync(IMoveSync moveSync)
		{
			return this.MoveSyncSet.Add(moveSync);
		}

		// Token: 0x0603B5AF RID: 243119 RVA: 0x00E28233 File Offset: 0x00E26433
		public bool DeleteMoveSync(IMoveSync moveSync)
		{
			return this.MoveSyncSet.Remove(moveSync);
		}

		// Token: 0x0603B5B0 RID: 243120 RVA: 0x00E28246 File Offset: 0x00E26446
		public void SetCombatMessageSwitch(bool isOpen)
		{
			this.CombatMessageSwitch = isOpen;
		}

		// Token: 0x0603B5B1 RID: 243121 RVA: 0x00E28250 File Offset: 0x00E26450
		public long GenMessageId()
		{
			long num = this.LastMessageId + 1L;
			this.LastMessageId = num;
			long num2 = num | this.Prefix << 60;
			if (this.CombatMessageSwitch)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.CombatInfo;
				ELogAuthor author = ELogAuthor.ZFJ;
				string message = "[GenMessageId]Debug";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("messageId", num2);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return num2;
		}

		// Token: 0x0603B5B2 RID: 243122 RVA: 0x00E282B2 File Offset: 0x00E264B2
		public void SetLastPrefix(int prefix)
		{
			this.Prefix = (long)prefix;
		}

		// Token: 0x0603B5B3 RID: 243123 RVA: 0x00E282BC File Offset: 0x00E264BC
		public void SetLastMessageId(long value)
		{
			this.LastMessageId = value;
		}

		// Token: 0x0603B5B4 RID: 243124 RVA: 0x00E282C8 File Offset: 0x00E264C8
		[NullableContext(2)]
		public CombatMessageBuffer GetMessageBuffer(long creatureDataId)
		{
			if (creatureDataId == 0L)
			{
				return null;
			}
			CombatMessageBuffer combatMessageBuffer;
			if (!this.CombatMessageBufferMap.TryGetValue(creatureDataId, out combatMessageBuffer))
			{
				combatMessageBuffer = new CombatMessageBuffer(creatureDataId);
				this.CombatMessageBufferMap[creatureDataId] = combatMessageBuffer;
			}
			return combatMessageBuffer;
		}

		// Token: 0x0603B5B5 RID: 243125 RVA: 0x00E28300 File Offset: 0x00E26500
		[NullableContext(2)]
		public CombatMessageBuffer GetMessageBufferByEntityId(int entityId)
		{
			CombatMessageBuffer result;
			this.CombatMessageBufferMapByEntity.TryGetValue((long)entityId, out result);
			return result;
		}

		// Token: 0x0603B5B6 RID: 243126 RVA: 0x00E28320 File Offset: 0x00E26520
		public void SetEntityMap(int entityId, long creatureDataId)
		{
			CombatMessageBuffer value;
			if (this.CombatMessageBufferMap.TryGetValue(creatureDataId, out value))
			{
				this.CombatMessageBufferMapByEntity[(long)entityId] = value;
			}
		}

		// Token: 0x0603B5B7 RID: 243127 RVA: 0x00E2834C File Offset: 0x00E2654C
		public void TryClearSkillCount(long skillContextId)
		{
			int num;
			this.SkillContextMap.TryGetValue(skillContextId, out num);
			if (num == 0)
			{
				this.SkillContextMap.Remove(skillContextId);
				this.SkillHitCountMap.Remove(skillContextId);
				this.SkillHitCountByVictimMap.Remove(skillContextId);
				this.SkillDamageCountMap.Remove(skillContextId);
				this.SkillDamageCountByVictimMap.Remove(skillContextId);
			}
		}

		// Token: 0x0603B5B8 RID: 243128 RVA: 0x00E283AC File Offset: 0x00E265AC
		public void AddSkillRefCount(long? skillContextId)
		{
			if (skillContextId != null && skillContextId.Value > 0L)
			{
				int num;
				this.SkillContextMap.TryGetValue(skillContextId.Value, out num);
				this.SkillContextMap[skillContextId.Value] = num + 1;
				if (num == 0)
				{
					this.SkillHitCountMap[skillContextId.Value] = 0;
					this.SkillHitCountByVictimMap[skillContextId.Value] = new Dictionary<int, int>();
					this.SkillDamageCountMap[skillContextId.Value] = 0;
					this.SkillDamageCountByVictimMap[skillContextId.Value] = new Dictionary<int, int>();
				}
			}
		}

		// Token: 0x0603B5B9 RID: 243129 RVA: 0x00E28454 File Offset: 0x00E26654
		public void RemoveSkillRefCount(long? skillContextId)
		{
			if (skillContextId != null && skillContextId.Value > 0L)
			{
				int num;
				if (!this.SkillContextMap.TryGetValue(skillContextId.Value, out num))
				{
					return;
				}
				num--;
				this.SkillContextMap[skillContextId.Value] = num;
				if (num <= 0)
				{
					this.SkillDirtySet.Add(skillContextId.Value);
				}
			}
		}

		// Token: 0x0603B5BA RID: 243130 RVA: 0x00E284BA File Offset: 0x00E266BA
		public void OnBulletAdded(long? skillContextId, long? bulletContextId, string bulletRowName)
		{
			this.AddSkillRefCount(skillContextId);
			if (bulletContextId != null && bulletContextId.Value > 0L)
			{
				this.BulletDamageCountMap[bulletContextId.Value] = 0;
			}
		}

		// Token: 0x0603B5BB RID: 243131 RVA: 0x00E284EC File Offset: 0x00E266EC
		public void OnBulletRemoved(long? skillContextId, long? bulletContextId)
		{
			this.RemoveSkillRefCount(skillContextId);
			if (bulletContextId != null && bulletContextId.Value > 0L)
			{
				TimerSystem.Instance.Delay(delegate(float _)
				{
					this.BulletDamageCountMap.Remove(bulletContextId.Value);
				}, 500f, null, null, true, 1f);
			}
		}

		// Token: 0x0603B5BC RID: 243132 RVA: 0x00E28554 File Offset: 0x00E26754
		[Conditional("DEBUG")]
		public void RecordDebugSkillContextInfo(long? skillContextId, int skillId)
		{
		}

		// Token: 0x0603B5BD RID: 243133 RVA: 0x00E28556 File Offset: 0x00E26756
		[Conditional("DEBUG")]
		public void ClearDebugSkillContextInfo(long? skillContextId)
		{
		}

		// Token: 0x0603B5BE RID: 243134 RVA: 0x00E28558 File Offset: 0x00E26758
		[Conditional("DEBUG")]
		public void RecordDebugBulletContextInfo(long? bulletContextId, string bulletRowName)
		{
		}

		// Token: 0x0603B5BF RID: 243135 RVA: 0x00E2855A File Offset: 0x00E2675A
		[Conditional("DEBUG")]
		public void ClearDebugBulletContextInfo(long bulletContextId)
		{
		}

		// Token: 0x0603B5C0 RID: 243136 RVA: 0x00E2855C File Offset: 0x00E2675C
		public int? AddSkillHitCount(long? skillContextId)
		{
			if (skillContextId == null || skillContextId.Value <= 0L)
			{
				return null;
			}
			int num;
			if (!this.SkillHitCountMap.TryGetValue(skillContextId.Value, out num))
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Message;
				Entity entity = null;
				string message = "技能命中计数器不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("skillContextId", skillContextId);
				instance.Warn(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			this.SkillHitCountMap[skillContextId.Value] = num + 1;
			return new int?(num + 1);
		}

		// Token: 0x0603B5C1 RID: 243137 RVA: 0x00E285F0 File Offset: 0x00E267F0
		public int? AddSkillHitCountByVictim(long? skillContextId, int victimEntityId)
		{
			if (skillContextId == null || skillContextId.Value <= 0L)
			{
				return null;
			}
			Dictionary<int, int> dictionary;
			if (!this.SkillHitCountByVictimMap.TryGetValue(skillContextId.Value, out dictionary))
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Message;
				Entity entity = null;
				string message = "技能对受害者命中计数器不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("skillContextId", skillContextId);
				instance.Warn(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			int valueOrDefault = dictionary.GetValueOrDefault(victimEntityId, 0);
			dictionary[victimEntityId] = valueOrDefault + 1;
			return new int?(valueOrDefault + 1);
		}

		// Token: 0x0603B5C2 RID: 243138 RVA: 0x00E28684 File Offset: 0x00E26884
		public int? AddSkillDamageCount(long? skillContextId)
		{
			if (skillContextId == null || skillContextId.Value <= 0L)
			{
				return null;
			}
			int num;
			if (!this.SkillDamageCountMap.TryGetValue(skillContextId.Value, out num))
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Message;
				Entity entity = null;
				string message = "技能伤害计数器不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("skillContextId", skillContextId);
				instance.Warn(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			this.SkillDamageCountMap[skillContextId.Value] = num + 1;
			return new int?(num + 1);
		}

		// Token: 0x0603B5C3 RID: 243139 RVA: 0x00E28718 File Offset: 0x00E26918
		public int? AddSkillDamageCountByVictim(long? skillContextId, int victimEntityId)
		{
			if (skillContextId == null || skillContextId.Value <= 0L)
			{
				return null;
			}
			Dictionary<int, int> dictionary;
			if (!this.SkillDamageCountByVictimMap.TryGetValue(skillContextId.Value, out dictionary))
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Message;
				Entity entity = null;
				string message = "技能对受害者伤害计数器不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("skillContextId", skillContextId);
				instance.Warn(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			int valueOrDefault = dictionary.GetValueOrDefault(victimEntityId, 0);
			dictionary[victimEntityId] = valueOrDefault + 1;
			return new int?(valueOrDefault + 1);
		}

		// Token: 0x0603B5C4 RID: 243140 RVA: 0x00E287AC File Offset: 0x00E269AC
		public int? AddBulletDamageCount(long? bulletContextId)
		{
			if (bulletContextId == null || bulletContextId.Value <= 0L)
			{
				return null;
			}
			int num;
			if (!this.BulletDamageCountMap.TryGetValue(bulletContextId.Value, out num))
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Message;
				Entity entity = null;
				string message = "子弹命中计数器不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("bulletContextId", bulletContextId);
				instance.Warn(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			this.BulletDamageCountMap[bulletContextId.Value] = num + 1;
			return new int?(num + 1);
		}

		// Token: 0x17008CF9 RID: 36089
		// (get) Token: 0x0603B5C5 RID: 243141 RVA: 0x00E2883F File Offset: 0x00E26A3F
		public static CombatMessageModel Instance
		{
			get
			{
				return CombatMessageModel._Instance;
			}
		}

		// Token: 0x0603B5C6 RID: 243142 RVA: 0x00E28846 File Offset: 0x00E26A46
		public static CombatMessageModel GetOrCreateInstance()
		{
			if (CombatMessageModel._Instance == null)
			{
				CombatMessageModel.CreateInstance();
			}
			return CombatMessageModel._Instance;
		}

		// Token: 0x0603B5C7 RID: 243143 RVA: 0x00E2885A File Offset: 0x00E26A5A
		public static bool CreateInstance()
		{
			if (CombatMessageModel._Instance != null)
			{
				return true;
			}
			CombatMessageModel._Instance = new CombatMessageModel();
			return true;
		}

		// Token: 0x0603B5C8 RID: 243144 RVA: 0x00E28870 File Offset: 0x00E26A70
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B5C9 RID: 243145 RVA: 0x00E28872 File Offset: 0x00E26A72
		public static void ResetStaticDefaultValue()
		{
			CombatMessageModel._Instance = null;
		}

		// Token: 0x0603B5CA RID: 243146 RVA: 0x00E2887A File Offset: 0x00E26A7A
		static CombatMessageModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CombatMessageModel.CreateStaticDefaultValue), new Action(CombatMessageModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401EED9 RID: 126681
		public const int COUNT_CONTEXT_REMOVE_DELAY = 500;

		// Token: 0x0401EEDA RID: 126682
		public const float BUFFER_TIME_RATE = 1.05f;

		// Token: 0x0401EEDB RID: 126683
		public const int TIME_BUFFER_SIZE = 20;

		// Token: 0x0401EEDC RID: 126684
		public const float TIME_OFFSET_LERP_RATE = 0.1f;

		// Token: 0x0401EEDD RID: 126685
		public const float FIX_BUFFER_TIME = 0.08f;

		// Token: 0x0401EEDE RID: 126686
		public const int TIME_BUFFER_CHECK_COUNT_MIN = 5;

		// Token: 0x0401EEDF RID: 126687
		public const float TIME_BUFFER_CHECK_TIME_MAX = 3f;

		// Token: 0x0401EEE0 RID: 126688
		public const float MAX_FLUCTUATE = 0.5f;

		// Token: 0x0401EEE1 RID: 126689
		public const float RECORD_UDP_MESSAGE_INTERNAL = 0.2f;

		// Token: 0x0401EEE2 RID: 126690
		public const int MESSAGE_ID_MASK = 60;

		// Token: 0x0401EEE3 RID: 126691
		public bool MoveSyncUdpMode = true;

		// Token: 0x0401EEE4 RID: 126692
		public float MoveSyncUdpSendInterval = 0.03f;

		// Token: 0x0401EEE5 RID: 126693
		public bool MoveSyncUdpFullSampling;

		// Token: 0x0401EEE6 RID: 126694
		public bool CombatMessageSendPackMode = true;

		// Token: 0x0401EEE7 RID: 126695
		public float CombatMessageSendInterval = 0.04f;

		// Token: 0x0401EEE8 RID: 126696
		public float CombatMessageSendIntervalMulti = 0.03f;

		// Token: 0x0401EEE9 RID: 126697
		public double CombatMessageSendLastTime;

		// Token: 0x0401EEEA RID: 126698
		private long Prefix = 1L;

		// Token: 0x0401EEEB RID: 126699
		private long LastMessageId;

		// Token: 0x0401EEEC RID: 126700
		public readonly Dictionary<long, CombatMessageBuffer> CombatMessageBufferMap = new Dictionary<long, CombatMessageBuffer>();

		// Token: 0x0401EEED RID: 126701
		public readonly Dictionary<long, CombatMessageBuffer> CombatMessageBufferMapByEntity = new Dictionary<long, CombatMessageBuffer>();

		// Token: 0x0401EEEE RID: 126702
		public bool NeedPushMove;

		// Token: 0x0401EEEF RID: 126703
		public readonly HashSet<IMoveSync> MoveSyncSet = new HashSet<IMoveSync>();

		// Token: 0x0401EEF0 RID: 126704
		public bool AnyEntityInFight;

		// Token: 0x0401EEF1 RID: 126705
		public bool AnyHateChange;

		// Token: 0x0401EEF2 RID: 126706
		public CombatSendPackRequest MessagePack = CombatSendPackRequest.Create();

		// Token: 0x0401EEF3 RID: 126707
		private bool CombatMessageSwitch;

		// Token: 0x0401EEF4 RID: 126708
		private readonly Dictionary<long, int> SkillContextMap = new Dictionary<long, int>();

		// Token: 0x0401EEF5 RID: 126709
		private readonly Dictionary<long, int> SkillHitCountMap = new Dictionary<long, int>();

		// Token: 0x0401EEF6 RID: 126710
		private readonly Dictionary<long, Dictionary<int, int>> SkillHitCountByVictimMap = new Dictionary<long, Dictionary<int, int>>();

		// Token: 0x0401EEF7 RID: 126711
		private readonly Dictionary<long, int> SkillDamageCountMap = new Dictionary<long, int>();

		// Token: 0x0401EEF8 RID: 126712
		private readonly Dictionary<long, Dictionary<int, int>> SkillDamageCountByVictimMap = new Dictionary<long, Dictionary<int, int>>();

		// Token: 0x0401EEF9 RID: 126713
		private readonly Dictionary<long, int> BulletDamageCountMap = new Dictionary<long, int>();

		// Token: 0x0401EEFA RID: 126714
		public readonly HashSet<long> SkillDirtySet = new HashSet<long>();

		// Token: 0x0401EEFB RID: 126715
		private readonly Dictionary<long, long> DebugSkillContextMap = new Dictionary<long, long>();

		// Token: 0x0401EEFC RID: 126716
		private readonly Dictionary<long, string> DebugBulletContextMap = new Dictionary<long, string>();

		// Token: 0x0401EEFD RID: 126717
		[Nullable(2)]
		private static CombatMessageModel _Instance;
	}
}

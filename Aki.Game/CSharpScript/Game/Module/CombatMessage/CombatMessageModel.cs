using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Protocol.CombatMessage;

namespace CSharpScript.Game.Module.CombatMessage
{
	// Token: 0x02004B8F RID: 19343
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class CombatMessageModel : ModelBase
	{
		// Token: 0x060304F9 RID: 197881 RVA: 0x00D78570 File Offset: 0x00D76770
		protected override bool OnLeaveLevel()
		{
			this.AnyEntityInFight = false;
			return true;
		}

		// Token: 0x060304FA RID: 197882 RVA: 0x00D7857A File Offset: 0x00D7677A
		protected override bool OnChangeMode()
		{
			this.AnyEntityInFight = false;
			return true;
		}

		// Token: 0x060304FB RID: 197883 RVA: 0x00D78584 File Offset: 0x00D76784
		public bool AddMoveSync(IMoveSync moveSync)
		{
			return this.MoveSyncSet.Add(moveSync);
		}

		// Token: 0x060304FC RID: 197884 RVA: 0x00D78597 File Offset: 0x00D76797
		public bool DeleteMoveSync(IMoveSync moveSync)
		{
			return this.MoveSyncSet.Remove(moveSync);
		}

		// Token: 0x060304FD RID: 197885 RVA: 0x00D785AA File Offset: 0x00D767AA
		public void SetCombatMessageSwitch(bool isOpen)
		{
			this.CombatMessageSwitch = isOpen;
		}

		// Token: 0x060304FE RID: 197886 RVA: 0x00D785B4 File Offset: 0x00D767B4
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

		// Token: 0x060304FF RID: 197887 RVA: 0x00D78616 File Offset: 0x00D76816
		public void SetLastPrefix(int prefix)
		{
			this.Prefix = (long)prefix;
		}

		// Token: 0x06030500 RID: 197888 RVA: 0x00D78620 File Offset: 0x00D76820
		public void SetLastMessageId(long value)
		{
			this.LastMessageId = value;
		}

		// Token: 0x06030501 RID: 197889 RVA: 0x00D7862C File Offset: 0x00D7682C
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

		// Token: 0x06030502 RID: 197890 RVA: 0x00D78664 File Offset: 0x00D76864
		[NullableContext(2)]
		public CombatMessageBuffer GetMessageBufferByEntityId(int entityId)
		{
			CombatMessageBuffer result;
			this.CombatMessageBufferMapByEntity.TryGetValue((long)entityId, out result);
			return result;
		}

		// Token: 0x06030503 RID: 197891 RVA: 0x00D78684 File Offset: 0x00D76884
		public void SetEntityMap(int entityId, long creatureDataId)
		{
			CombatMessageBuffer value;
			if (this.CombatMessageBufferMap.TryGetValue(creatureDataId, out value))
			{
				this.CombatMessageBufferMapByEntity[(long)entityId] = value;
			}
		}

		// Token: 0x06030504 RID: 197892 RVA: 0x00D786B0 File Offset: 0x00D768B0
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

		// Token: 0x06030505 RID: 197893 RVA: 0x00D78710 File Offset: 0x00D76910
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

		// Token: 0x06030506 RID: 197894 RVA: 0x00D787B8 File Offset: 0x00D769B8
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

		// Token: 0x06030507 RID: 197895 RVA: 0x00D7881E File Offset: 0x00D76A1E
		public void OnBulletAdded(long? skillContextId, long? bulletContextId, string bulletRowName)
		{
			this.AddSkillRefCount(skillContextId);
			if (bulletContextId != null && bulletContextId.Value > 0L)
			{
				this.BulletDamageCountMap[bulletContextId.Value] = 0;
			}
		}

		// Token: 0x06030508 RID: 197896 RVA: 0x00D78850 File Offset: 0x00D76A50
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

		// Token: 0x06030509 RID: 197897 RVA: 0x00D788B8 File Offset: 0x00D76AB8
		[Conditional("DEBUG")]
		public void RecordDebugSkillContextInfo(long? skillContextId, int skillId)
		{
		}

		// Token: 0x0603050A RID: 197898 RVA: 0x00D788BA File Offset: 0x00D76ABA
		[Conditional("DEBUG")]
		public void ClearDebugSkillContextInfo(long? skillContextId)
		{
		}

		// Token: 0x0603050B RID: 197899 RVA: 0x00D788BC File Offset: 0x00D76ABC
		[Conditional("DEBUG")]
		public void RecordDebugBulletContextInfo(long? bulletContextId, string bulletRowName)
		{
		}

		// Token: 0x0603050C RID: 197900 RVA: 0x00D788BE File Offset: 0x00D76ABE
		[Conditional("DEBUG")]
		public void ClearDebugBulletContextInfo(long bulletContextId)
		{
		}

		// Token: 0x0603050D RID: 197901 RVA: 0x00D788C0 File Offset: 0x00D76AC0
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

		// Token: 0x0603050E RID: 197902 RVA: 0x00D78954 File Offset: 0x00D76B54
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

		// Token: 0x0603050F RID: 197903 RVA: 0x00D789E8 File Offset: 0x00D76BE8
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

		// Token: 0x06030510 RID: 197904 RVA: 0x00D78A7C File Offset: 0x00D76C7C
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

		// Token: 0x06030511 RID: 197905 RVA: 0x00D78B10 File Offset: 0x00D76D10
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

		// Token: 0x170060CB RID: 24779
		// (get) Token: 0x06030512 RID: 197906 RVA: 0x00D78BA3 File Offset: 0x00D76DA3
		public static CombatMessageModel Instance
		{
			get
			{
				return CombatMessageModel._Instance;
			}
		}

		// Token: 0x06030513 RID: 197907 RVA: 0x00D78BAA File Offset: 0x00D76DAA
		public static CombatMessageModel GetOrCreateInstance()
		{
			if (CombatMessageModel._Instance == null)
			{
				CombatMessageModel.CreateInstance();
			}
			return CombatMessageModel._Instance;
		}

		// Token: 0x06030514 RID: 197908 RVA: 0x00D78BBE File Offset: 0x00D76DBE
		public static bool CreateInstance()
		{
			if (CombatMessageModel._Instance != null)
			{
				return true;
			}
			CombatMessageModel._Instance = new CombatMessageModel();
			return true;
		}

		// Token: 0x06030515 RID: 197909 RVA: 0x00D78BD4 File Offset: 0x00D76DD4
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06030516 RID: 197910 RVA: 0x00D78BD6 File Offset: 0x00D76DD6
		public static void ResetStaticDefaultValue()
		{
			CombatMessageModel._Instance = null;
		}

		// Token: 0x06030517 RID: 197911 RVA: 0x00D78BDE File Offset: 0x00D76DDE
		static CombatMessageModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CombatMessageModel.CreateStaticDefaultValue), new Action(CombatMessageModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401998A RID: 104842
		public const int COUNT_CONTEXT_REMOVE_DELAY = 500;

		// Token: 0x0401998B RID: 104843
		public const float BUFFER_TIME_RATE = 1.05f;

		// Token: 0x0401998C RID: 104844
		public const int TIME_BUFFER_SIZE = 20;

		// Token: 0x0401998D RID: 104845
		public const float TIME_OFFSET_LERP_RATE = 0.1f;

		// Token: 0x0401998E RID: 104846
		public const float FIX_BUFFER_TIME = 0.08f;

		// Token: 0x0401998F RID: 104847
		public const int TIME_BUFFER_CHECK_COUNT_MIN = 5;

		// Token: 0x04019990 RID: 104848
		public const float TIME_BUFFER_CHECK_TIME_MAX = 3f;

		// Token: 0x04019991 RID: 104849
		public const float MAX_FLUCTUATE = 0.5f;

		// Token: 0x04019992 RID: 104850
		public const float RECORD_UDP_MESSAGE_INTERNAL = 0.2f;

		// Token: 0x04019993 RID: 104851
		public const int MESSAGE_ID_MASK = 60;

		// Token: 0x04019994 RID: 104852
		public bool MoveSyncUdpMode = true;

		// Token: 0x04019995 RID: 104853
		public float MoveSyncUdpSendInterval = 0.03f;

		// Token: 0x04019996 RID: 104854
		public bool MoveSyncUdpFullSampling;

		// Token: 0x04019997 RID: 104855
		public bool CombatMessageSendPackMode = true;

		// Token: 0x04019998 RID: 104856
		public float CombatMessageSendInterval = 0.04f;

		// Token: 0x04019999 RID: 104857
		public float CombatMessageSendIntervalMulti = 0.03f;

		// Token: 0x0401999A RID: 104858
		public double CombatMessageSendLastTime;

		// Token: 0x0401999B RID: 104859
		private long Prefix = 1L;

		// Token: 0x0401999C RID: 104860
		private long LastMessageId;

		// Token: 0x0401999D RID: 104861
		public readonly Dictionary<long, CombatMessageBuffer> CombatMessageBufferMap = new Dictionary<long, CombatMessageBuffer>();

		// Token: 0x0401999E RID: 104862
		public readonly Dictionary<long, CombatMessageBuffer> CombatMessageBufferMapByEntity = new Dictionary<long, CombatMessageBuffer>();

		// Token: 0x0401999F RID: 104863
		public bool NeedPushMove;

		// Token: 0x040199A0 RID: 104864
		public readonly HashSet<IMoveSync> MoveSyncSet = new HashSet<IMoveSync>();

		// Token: 0x040199A1 RID: 104865
		public bool AnyEntityInFight;

		// Token: 0x040199A2 RID: 104866
		public bool AnyHateChange;

		// Token: 0x040199A3 RID: 104867
		public CombatSendPackRequest MessagePack = CombatSendPackRequest.Create();

		// Token: 0x040199A4 RID: 104868
		private bool CombatMessageSwitch;

		// Token: 0x040199A5 RID: 104869
		private readonly Dictionary<long, int> SkillContextMap = new Dictionary<long, int>();

		// Token: 0x040199A6 RID: 104870
		private readonly Dictionary<long, int> SkillHitCountMap = new Dictionary<long, int>();

		// Token: 0x040199A7 RID: 104871
		private readonly Dictionary<long, Dictionary<int, int>> SkillHitCountByVictimMap = new Dictionary<long, Dictionary<int, int>>();

		// Token: 0x040199A8 RID: 104872
		private readonly Dictionary<long, int> SkillDamageCountMap = new Dictionary<long, int>();

		// Token: 0x040199A9 RID: 104873
		private readonly Dictionary<long, Dictionary<int, int>> SkillDamageCountByVictimMap = new Dictionary<long, Dictionary<int, int>>();

		// Token: 0x040199AA RID: 104874
		private readonly Dictionary<long, int> BulletDamageCountMap = new Dictionary<long, int>();

		// Token: 0x040199AB RID: 104875
		public readonly HashSet<long> SkillDirtySet = new HashSet<long>();

		// Token: 0x040199AC RID: 104876
		private readonly Dictionary<long, long> DebugSkillContextMap = new Dictionary<long, long>();

		// Token: 0x040199AD RID: 104877
		private readonly Dictionary<long, string> DebugBulletContextMap = new Dictionary<long, string>();

		// Token: 0x040199AE RID: 104878
		[Nullable(2)]
		private static CombatMessageModel _Instance;
	}
}

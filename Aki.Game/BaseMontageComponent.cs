using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

// Token: 0x02002E7C RID: 11900
[NullableContext(1)]
[Nullable(0)]
public class BaseMontageComponent : EntityComponent, IStaticVariableResetter
{
	// Token: 0x060196F1 RID: 104177 RVA: 0x006916C4 File Offset: 0x0068F8C4
	static BaseMontageComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BaseMontageComponent.CreateStaticDefaultValue), new Action(BaseMontageComponent.ResetStaticDefaultValue));
	}

	// Token: 0x060196F2 RID: 104178 RVA: 0x006916E4 File Offset: 0x0068F8E4
	protected override bool OnStart()
	{
		if (BaseMontageComponent.AnimNotifyClass2Server == null)
		{
			BaseMontageComponent.AnimNotifyClass2Server = new TSet<string>
			{
				"TsAnimNotifyAddBuff_C",
				"TsAnimNotifyAddTag_C",
				"TsAnimNotifySkillBehavior_C",
				"TsAnimNotifyReSkillEvent_C",
				"TsAnimNotifyChangeRoleQte_C",
				"TsAnimNotifyPanelQte_C",
				"TsAnimNotifyJoinTeamQte_C",
				"TsAnimNotifyDetach_C",
				"TsAnimNotifyStateAddBuff_C",
				"TsAnimNotifyStateAddTag_C",
				"TsAnimNotifyStateCounterAttack_C",
				"TsAnimNotifyStateVisionCounterAttack_C",
				"TsAnimNotifyStateBulletDuration_C",
				"TsAnimNotifyStateCaughtBinding_C",
				"TsAnimNotifyStateCaughtTrigger_C",
				"TsAnimNotifyStateMontageSpeedChange_C",
				"TsAnimNotifyStateAttach_C"
			};
		}
		return true;
	}

	// Token: 0x060196F3 RID: 104179 RVA: 0x006917D4 File Offset: 0x0068F9D4
	protected override bool OnEnd()
	{
		this.MontageMapByName.Clear();
		this.MontagePathMapByName.Clear();
		this.MontageNeedPush2ServerMapByName.Clear();
		this.TaskForcePushMontageSet.Clear();
		foreach (UAsyncTaskPlayMontageAndWait uasyncTaskPlayMontageAndWait in this.CachedTask)
		{
			uasyncTaskPlayMontageAndWait.EndTask();
		}
		this.CachedTask.Clear();
		foreach (MontageTask montageTask in this.MontageTaskMap.Values)
		{
			montageTask.EndTask();
		}
		this.MontageTaskMap.Clear();
		return true;
	}

	// Token: 0x060196F4 RID: 104180 RVA: 0x006918AC File Offset: 0x0068FAAC
	[NullableContext(2)]
	public virtual UAnimInstance GetMainAnimInstance()
	{
		return null;
	}

	// Token: 0x060196F5 RID: 104181 RVA: 0x006918B0 File Offset: 0x0068FAB0
	[NullableContext(2)]
	public int? CreateTaskWithName([Nullable(1)] string montageName, Action playCallback = null, Action<bool> endCallback = null, float blendInTime = -1f)
	{
		int num = this.IncHandleId + 1;
		this.IncHandleId = num;
		int num2 = num;
		MontageTask montageTask = new MontageTask(this, num2, playCallback, endCallback);
		montageTask.InitWithPath(montageName, blendInTime);
		if (montageTask.Invalid)
		{
			return null;
		}
		this.MontageTaskMap.Add(num2, montageTask);
		return new int?(num2);
	}

	// Token: 0x060196F6 RID: 104182 RVA: 0x00691908 File Offset: 0x0068FB08
	[NullableContext(2)]
	public int? CreateTaskWithMontage([Nullable(1)] UAnimMontage montage, Action playCallback = null, Action<bool> endCallback = null, float blendInTime = -1f)
	{
		int num = this.IncHandleId + 1;
		this.IncHandleId = num;
		int num2 = num;
		MontageTask montageTask = new MontageTask(this, num2, playCallback, endCallback);
		montageTask.InitWithMontage(montage, blendInTime);
		if (montageTask.Invalid)
		{
			return null;
		}
		this.MontageTaskMap.Add(num2, montageTask);
		return new int?(num2);
	}

	// Token: 0x060196F7 RID: 104183 RVA: 0x00691960 File Offset: 0x0068FB60
	public void PlayMontageTaskWhenReady(int taskHandle, float startPos, long? contextId = null, float remainedTrigger = -1f)
	{
		MontageTask valueOrDefault = this.MontageTaskMap.GetValueOrDefault(taskHandle);
		if (valueOrDefault == null)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Animation;
			Entity entity = base.Entity;
			string message = "请求播Montage失败，找不到对应task";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("handle", taskHandle);
			instance.Error(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (valueOrDefault.MontageNeedPush2Server)
		{
			if (contextId == null)
			{
				CombatLog instance2 = CombatLog.Instance;
				CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Animation;
				Entity entity2 = base.Entity;
				string message2 = "请求播Montage时找不到对应contextId";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("handle", taskHandle);
				instance2.Error(flag2, entity2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			else
			{
				PlayEntityMontagePush playEntityMontagePush = PlayEntityMontagePush.Create();
				playEntityMontagePush.MontageName = valueOrDefault.MontageName;
				playEntityMontagePush.MontageHashCode = valueOrDefault.MontagePathHash;
				playEntityMontagePush.SpeedRatio = 1f;
				playEntityMontagePush.StartSection = "";
				playEntityMontagePush.StartTimeSeconds = startPos;
				this.MontageTaskMessageId = new long?(CombatNet.Instance.Send(EPushMessageId.PlayEntityMontagePush, base.Entity, playEntityMontagePush, new long?(contextId.Value), null, null));
			}
		}
		valueOrDefault.Play(startPos, remainedTrigger);
	}

	// Token: 0x060196F8 RID: 104184 RVA: 0x00691A78 File Offset: 0x0068FC78
	public void EndMontageTask(int handle)
	{
		MontageTask valueOrDefault = this.MontageTaskMap.GetValueOrDefault(handle);
		if (valueOrDefault != null)
		{
			valueOrDefault.EndTask();
			this.MontageTaskMap.Remove(handle);
		}
	}

	// Token: 0x060196F9 RID: 104185 RVA: 0x00691AA8 File Offset: 0x0068FCA8
	public float GetMontageTimeRemaining(int handle)
	{
		MontageTask valueOrDefault = this.MontageTaskMap.GetValueOrDefault(handle);
		if (((valueOrDefault != null) ? valueOrDefault.Montage : null) != null)
		{
			float sequenceLength = valueOrDefault.Montage.SequenceLength;
			float num = valueOrDefault.MontageComponent.GetMainAnimInstance().Montage_GetPosition(valueOrDefault.Montage);
			return sequenceLength - num;
		}
		return -1f;
	}

	// Token: 0x060196FA RID: 104186 RVA: 0x00691AFC File Offset: 0x0068FCFC
	public float GetMontageTimeElapsing(int handle)
	{
		MontageTask valueOrDefault = this.MontageTaskMap.GetValueOrDefault(handle);
		if (((valueOrDefault != null) ? valueOrDefault.Montage : null) != null)
		{
			return valueOrDefault.MontageComponent.GetMainAnimInstance().Montage_GetPosition(valueOrDefault.Montage);
		}
		return -1f;
	}

	// Token: 0x060196FB RID: 104187 RVA: 0x00691B40 File Offset: 0x0068FD40
	public float GetMontageTimeLength(int handle)
	{
		MontageTask valueOrDefault = this.MontageTaskMap.GetValueOrDefault(handle);
		if (((valueOrDefault != null) ? valueOrDefault.Montage : null) != null)
		{
			return valueOrDefault.Montage.SequenceLength;
		}
		return -1f;
	}

	// Token: 0x060196FC RID: 104188 RVA: 0x00691B7C File Offset: 0x0068FD7C
	[NullableContext(2)]
	public string GetMontageTaskNameByHandle(int handle)
	{
		MontageTask valueOrDefault = this.MontageTaskMap.GetValueOrDefault(handle);
		if (!string.IsNullOrEmpty((valueOrDefault != null) ? valueOrDefault.MontageName : null))
		{
			return valueOrDefault.MontageName;
		}
		return null;
	}

	// Token: 0x060196FD RID: 104189 RVA: 0x00691BB4 File Offset: 0x0068FDB4
	[NullableContext(2)]
	public void SetMontageTaskRemainCb(int handle, Action<float> cb = null)
	{
		MontageTask valueOrDefault = this.MontageTaskMap.GetValueOrDefault(handle);
		if (valueOrDefault != null && cb != null)
		{
			valueOrDefault.RemainCallback = cb;
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Battle;
		ELogAuthor author = ELogAuthor.PZ;
		string message = "MontageRemain回调绑定失败";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("task", (valueOrDefault != null) ? valueOrDefault.MontageName : null);
		instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x060196FE RID: 104190 RVA: 0x00691C10 File Offset: 0x0068FE10
	public void PushMontageInfo(MontageInfo montageInfo, UAnimMontage montage)
	{
		if (this.MontageInfoQueue.Size == 4)
		{
			this.MontageInfoQueue.Pop();
		}
		montageInfo.MontageNames.Add(montage.GetName());
		TArray<FSlotAnimationTrack> slotAnimTracks = montage.SlotAnimTracks;
		for (int i = 0; i < slotAnimTracks.Num(); i++)
		{
			TArray<FAnimSegment> animSegments = slotAnimTracks.Get(i).AnimTrack.AnimSegments;
			for (int j = 0; j < animSegments.Num(); j++)
			{
				FAnimSegment fanimSegment = animSegments.Get(j);
				List<string> montageNames = montageInfo.MontageNames;
				UAnimSequenceBase animReference = fanimSegment.AnimReference;
				montageNames.Add(((animReference != null) ? animReference.GetName() : null) ?? "");
			}
		}
		this.MontageInfoQueue.Push(montageInfo);
	}

	// Token: 0x060196FF RID: 104191 RVA: 0x00691CC0 File Offset: 0x0068FEC0
	[return: Nullable(2)]
	public MontageInfo GetMontageInfo(string montageName)
	{
		for (int i = this.MontageInfoQueue.Size - 1; i >= 0; i--)
		{
			MontageInfo montageInfo = this.MontageInfoQueue.Get(i);
			if (montageInfo.MontageNames.Contains(montageName))
			{
				return montageInfo;
			}
		}
		return null;
	}

	// Token: 0x06019700 RID: 104192 RVA: 0x00691D04 File Offset: 0x0068FF04
	public virtual void AddMontage(string name, UAnimMontage montage, string path)
	{
		if (montage == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.YZ;
			string message = "添加的动画不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", name);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		UKuroStaticLibrary.SetMontageANIndex(montage);
		this.MontageMapByName[name] = montage;
		this.MontagePathMapByName[name] = path;
	}

	// Token: 0x06019701 RID: 104193 RVA: 0x00691D5C File Offset: 0x0068FF5C
	[return: Nullable(2)]
	public virtual UAnimMontage GetMontageByName(string name, bool includeMorphMontage = true, bool replaceMorphMontage = false)
	{
		if (string.IsNullOrEmpty(name))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.YZ;
			string message = "传入的Name为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", name);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return this.MontageMapByName.GetValueOrDefault(name);
	}

	// Token: 0x06019702 RID: 104194 RVA: 0x00691DA8 File Offset: 0x0068FFA8
	[return: Nullable(2)]
	public virtual string GetMontagePathByName(string name, bool includeMorphMontage = true, bool replaceMorphMontage = false)
	{
		if (string.IsNullOrEmpty(name))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.YZ;
			string message = "传入的Name为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", name);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return this.MontagePathMapByName.GetValueOrDefault(name);
	}

	// Token: 0x06019703 RID: 104195 RVA: 0x00691DF4 File Offset: 0x0068FFF4
	public virtual bool IsMontageNeedPush2Server(string name)
	{
		UAnimMontage montageByName = this.GetMontageByName(name, true, false);
		if (montageByName == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.ZFJ;
			string message = "montage找不到";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", name);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		bool result;
		if (this.MontageNeedPush2ServerMapByName.TryGetValue(name, out result))
		{
			return result;
		}
		if (this.TaskForcePushMontageSet.Contains(name))
		{
			this.MontageNeedPush2ServerMapByName.TryAdd(name, true);
			return true;
		}
		bool flag = UKuroStaticLibrary.IsMontageContainGivenAnimNotify(montageByName, BaseMontageComponent.AnimNotifyClass2Server);
		this.MontageNeedPush2ServerMapByName.TryAdd(name, flag);
		return flag;
	}

	// Token: 0x06019704 RID: 104196 RVA: 0x00691E84 File Offset: 0x00690084
	public void AddForcePushMontage(string montageName)
	{
		if (this.GetMontageByName(montageName, true, false) == null)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Animation;
			Entity entity = base.Entity;
			string message = "添加强制同步蒙太奇失败，该实体缺少对应蒙太奇资源";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MontageName", montageName);
			instance.Warn(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.TaskForcePushMontageSet.Add(montageName);
	}

	// Token: 0x06019705 RID: 104197 RVA: 0x00691ED4 File Offset: 0x006900D4
	public bool RemoveForcePushMontage(string montageName)
	{
		if (this.GetMontageByName(montageName, true, false) == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.GHY;
			string message = "移除强制同步蒙太奇失败，montage找不到";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", montageName);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		bool flag = this.TaskForcePushMontageSet.Remove(montageName);
		if (!flag)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Battle;
			ELogAuthor author2 = ELogAuthor.GHY;
			string message2 = "移除强制同步蒙太奇失败，不在强制同步列表中";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Name", montageName);
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}
		return flag;
	}

	// Token: 0x06019706 RID: 104198 RVA: 0x00691F4B File Offset: 0x0069014B
	public static void CreateStaticDefaultValue()
	{
		BaseMontageComponent.AnimNotifyClass2Server = null;
		BaseMontageComponent.RemainedTriggerOn = true;
	}

	// Token: 0x06019707 RID: 104199 RVA: 0x00691F59 File Offset: 0x00690159
	public static void ResetStaticDefaultValue()
	{
		BaseMontageComponent.AnimNotifyClass2Server = null;
		BaseMontageComponent.RemainedTriggerOn = true;
	}

	// Token: 0x06019708 RID: 104200 RVA: 0x00691F68 File Offset: 0x00690168
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BaseMontageComponent baseMontageComponent = (BaseMontageComponent)componentTemplate;
		if (base.CanResetComponentProperty("MontageMapByName") && baseMontageComponent.MontageMapByName != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<string, UAnimMontage>>(this.MontageMapByName), "MontageMapByName"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("MontagePathMapByName") && baseMontageComponent.MontagePathMapByName != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<string, string>>(this.MontagePathMapByName), "MontagePathMapByName"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("MontageNeedPush2ServerMapByName") && baseMontageComponent.MontageNeedPush2ServerMapByName != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<string, bool>>(this.MontageNeedPush2ServerMapByName), "MontageNeedPush2ServerMapByName"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("TaskForcePushMontageSet") && baseMontageComponent.TaskForcePushMontageSet != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<string>(this.TaskForcePushMontageSet), "TaskForcePushMontageSet"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("CachedTask") && baseMontageComponent.CachedTask != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<UAsyncTaskPlayMontageAndWait>>(this.CachedTask), "CachedTask"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("IncHandleId"))
		{
			this.IncHandleId = baseMontageComponent.IncHandleId;
		}
		if (base.CanResetComponentProperty("MontageTaskMessageId"))
		{
			this.MontageTaskMessageId = baseMontageComponent.MontageTaskMessageId;
		}
		return (!base.CanResetComponentProperty("MontageTaskMap") || baseMontageComponent.MontageTaskMap == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, MontageTask>>(this.MontageTaskMap), "MontageTaskMap")) && (!base.CanResetComponentProperty("MontageInfoQueue") || baseMontageComponent.MontageInfoQueue == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Queue<MontageInfo>>(this.MontageInfoQueue), "MontageInfoQueue"));
	}

	// Token: 0x0400BD3B RID: 48443
	protected readonly Dictionary<string, UAnimMontage> MontageMapByName = new Dictionary<string, UAnimMontage>();

	// Token: 0x0400BD3C RID: 48444
	protected readonly Dictionary<string, string> MontagePathMapByName = new Dictionary<string, string>();

	// Token: 0x0400BD3D RID: 48445
	private readonly Dictionary<string, bool> MontageNeedPush2ServerMapByName = new Dictionary<string, bool>();

	// Token: 0x0400BD3E RID: 48446
	private readonly HashSet<string> TaskForcePushMontageSet = new HashSet<string>();

	// Token: 0x0400BD3F RID: 48447
	private readonly List<UAsyncTaskPlayMontageAndWait> CachedTask = new List<UAsyncTaskPlayMontageAndWait>();

	// Token: 0x0400BD40 RID: 48448
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static TSet<string> AnimNotifyClass2Server;

	// Token: 0x0400BD41 RID: 48449
	public static bool RemainedTriggerOn;

	// Token: 0x0400BD42 RID: 48450
	private int IncHandleId;

	// Token: 0x0400BD43 RID: 48451
	public long? MontageTaskMessageId;

	// Token: 0x0400BD44 RID: 48452
	private readonly Dictionary<int, MontageTask> MontageTaskMap = new Dictionary<int, MontageTask>();

	// Token: 0x0400BD45 RID: 48453
	private readonly Queue<MontageInfo> MontageInfoQueue = new Queue<MontageInfo>(4);
}

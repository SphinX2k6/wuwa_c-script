using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

// Token: 0x020023CE RID: 9166
[NullableContext(1)]
[Nullable(0)]
public class BaseMontageComponent : EntityComponent, IStaticVariableResetter
{
	// Token: 0x06016FC5 RID: 94149 RVA: 0x006B7AF0 File Offset: 0x006B5CF0
	static BaseMontageComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BaseMontageComponent.CreateStaticDefaultValue), new Action(BaseMontageComponent.ResetStaticDefaultValue));
	}

	// Token: 0x06016FC6 RID: 94150 RVA: 0x006B7B10 File Offset: 0x006B5D10
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

	// Token: 0x06016FC7 RID: 94151 RVA: 0x006B7C00 File Offset: 0x006B5E00
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

	// Token: 0x06016FC8 RID: 94152 RVA: 0x006B7CD8 File Offset: 0x006B5ED8
	[NullableContext(2)]
	public virtual UAnimInstance GetMainAnimInstance()
	{
		return null;
	}

	// Token: 0x06016FC9 RID: 94153 RVA: 0x006B7CDC File Offset: 0x006B5EDC
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

	// Token: 0x06016FCA RID: 94154 RVA: 0x006B7D34 File Offset: 0x006B5F34
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

	// Token: 0x06016FCB RID: 94155 RVA: 0x006B7D8C File Offset: 0x006B5F8C
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

	// Token: 0x06016FCC RID: 94156 RVA: 0x006B7EA4 File Offset: 0x006B60A4
	public void EndMontageTask(int handle)
	{
		MontageTask valueOrDefault = this.MontageTaskMap.GetValueOrDefault(handle);
		if (valueOrDefault != null)
		{
			valueOrDefault.EndTask();
			this.MontageTaskMap.Remove(handle);
		}
	}

	// Token: 0x06016FCD RID: 94157 RVA: 0x006B7ED4 File Offset: 0x006B60D4
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

	// Token: 0x06016FCE RID: 94158 RVA: 0x006B7F28 File Offset: 0x006B6128
	public float GetMontageTimeElapsing(int handle)
	{
		MontageTask valueOrDefault = this.MontageTaskMap.GetValueOrDefault(handle);
		if (((valueOrDefault != null) ? valueOrDefault.Montage : null) != null)
		{
			return valueOrDefault.MontageComponent.GetMainAnimInstance().Montage_GetPosition(valueOrDefault.Montage);
		}
		return -1f;
	}

	// Token: 0x06016FCF RID: 94159 RVA: 0x006B7F6C File Offset: 0x006B616C
	public float GetMontageTimeLength(int handle)
	{
		MontageTask valueOrDefault = this.MontageTaskMap.GetValueOrDefault(handle);
		if (((valueOrDefault != null) ? valueOrDefault.Montage : null) != null)
		{
			return valueOrDefault.Montage.SequenceLength;
		}
		return -1f;
	}

	// Token: 0x06016FD0 RID: 94160 RVA: 0x006B7FA8 File Offset: 0x006B61A8
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

	// Token: 0x06016FD1 RID: 94161 RVA: 0x006B7FE0 File Offset: 0x006B61E0
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

	// Token: 0x06016FD2 RID: 94162 RVA: 0x006B803C File Offset: 0x006B623C
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

	// Token: 0x06016FD3 RID: 94163 RVA: 0x006B80EC File Offset: 0x006B62EC
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

	// Token: 0x06016FD4 RID: 94164 RVA: 0x006B8130 File Offset: 0x006B6330
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

	// Token: 0x06016FD5 RID: 94165 RVA: 0x006B8188 File Offset: 0x006B6388
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

	// Token: 0x06016FD6 RID: 94166 RVA: 0x006B81D4 File Offset: 0x006B63D4
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

	// Token: 0x06016FD7 RID: 94167 RVA: 0x006B8220 File Offset: 0x006B6420
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

	// Token: 0x06016FD8 RID: 94168 RVA: 0x006B82B0 File Offset: 0x006B64B0
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

	// Token: 0x06016FD9 RID: 94169 RVA: 0x006B8300 File Offset: 0x006B6500
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

	// Token: 0x06016FDA RID: 94170 RVA: 0x006B8377 File Offset: 0x006B6577
	public static void CreateStaticDefaultValue()
	{
		BaseMontageComponent.AnimNotifyClass2Server = null;
		BaseMontageComponent.RemainedTriggerOn = true;
	}

	// Token: 0x06016FDB RID: 94171 RVA: 0x006B8385 File Offset: 0x006B6585
	public static void ResetStaticDefaultValue()
	{
		BaseMontageComponent.AnimNotifyClass2Server = null;
		BaseMontageComponent.RemainedTriggerOn = true;
	}

	// Token: 0x06016FDC RID: 94172 RVA: 0x006B8394 File Offset: 0x006B6594
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BaseMontageComponent baseMontageComponent = (BaseMontageComponent)componentTemplate;
		if (baseMontageComponent.MontageMapByName != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.MontageMapByName), "MontageMapByName"))
		{
			return false;
		}
		if (baseMontageComponent.MontagePathMapByName != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.MontagePathMapByName), "MontagePathMapByName"))
		{
			return false;
		}
		if (baseMontageComponent.MontageNeedPush2ServerMapByName != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.MontageNeedPush2ServerMapByName), "MontageNeedPush2ServerMapByName"))
		{
			return false;
		}
		if (baseMontageComponent.TaskForcePushMontageSet != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<string>(this.TaskForcePushMontageSet), "TaskForcePushMontageSet"))
		{
			return false;
		}
		if (baseMontageComponent.CachedTask != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CachedTask), "CachedTask"))
		{
			return false;
		}
		this.IncHandleId = baseMontageComponent.IncHandleId;
		this.MontageTaskMessageId = baseMontageComponent.MontageTaskMessageId;
		return (baseMontageComponent.MontageTaskMap == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.MontageTaskMap), "MontageTaskMap")) && (baseMontageComponent.MontageInfoQueue == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.MontageInfoQueue), "MontageInfoQueue"));
	}

	// Token: 0x1700237E RID: 9086
	// (get) Token: 0x06016FDD RID: 94173 RVA: 0x006B84BA File Offset: 0x006B66BA
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700237F RID: 9087
	// (get) Token: 0x06016FDE RID: 94174 RVA: 0x006B84BD File Offset: 0x006B66BD
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400C0D2 RID: 49362
	protected readonly Dictionary<string, UAnimMontage> MontageMapByName = new Dictionary<string, UAnimMontage>();

	// Token: 0x0400C0D3 RID: 49363
	protected readonly Dictionary<string, string> MontagePathMapByName = new Dictionary<string, string>();

	// Token: 0x0400C0D4 RID: 49364
	private readonly Dictionary<string, bool> MontageNeedPush2ServerMapByName = new Dictionary<string, bool>();

	// Token: 0x0400C0D5 RID: 49365
	private readonly HashSet<string> TaskForcePushMontageSet = new HashSet<string>();

	// Token: 0x0400C0D6 RID: 49366
	private readonly List<UAsyncTaskPlayMontageAndWait> CachedTask = new List<UAsyncTaskPlayMontageAndWait>();

	// Token: 0x0400C0D7 RID: 49367
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static TSet<string> AnimNotifyClass2Server;

	// Token: 0x0400C0D8 RID: 49368
	public static bool RemainedTriggerOn;

	// Token: 0x0400C0D9 RID: 49369
	private int IncHandleId;

	// Token: 0x0400C0DA RID: 49370
	public long? MontageTaskMessageId;

	// Token: 0x0400C0DB RID: 49371
	private readonly Dictionary<int, MontageTask> MontageTaskMap = new Dictionary<int, MontageTask>();

	// Token: 0x0400C0DC RID: 49372
	private readonly Queue<MontageInfo> MontageInfoQueue = new Queue<MontageInfo>(4);
}

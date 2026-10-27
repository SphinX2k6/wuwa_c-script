using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x020034DA RID: 13530
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class CreatureGroupController : ControllerBase
{
	// Token: 0x0601D9C2 RID: 121282 RVA: 0x00847EAD File Offset: 0x008460AD
	protected override bool OnClear()
	{
		this.BindEntityGroups.Clear();
		this.BindGroupEntityWhiteFilter.Cleanup();
		return base.OnClear();
	}

	// Token: 0x0601D9C3 RID: 121283 RVA: 0x00847ECC File Offset: 0x008460CC
	public unsafe void AddBindEntity(long creatureDataIdA, long creatureDataIdB)
	{
		this.BindEntityGroups.Union(creatureDataIdA, creatureDataIdB);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Entity;
		ELogAuthor author = ELogAuthor.ZQR;
		string message = "[实体生命周期:实体绑组] 建立实体绑定";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataIdA", creatureDataIdA);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CreatureDataIdB", creatureDataIdB);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x0601D9C4 RID: 121284 RVA: 0x00847F43 File Offset: 0x00846143
	public bool HasBindGroup(long creatureDataId)
	{
		return this.BindEntityGroups.Has(creatureDataId);
	}

	// Token: 0x0601D9C5 RID: 121285 RVA: 0x00847F51 File Offset: 0x00846151
	[NullableContext(2)]
	public IReadOnlyList<long> GetBindGroup(long creatureDataId)
	{
		return this.BindEntityGroups.GetSet(creatureDataId);
	}

	// Token: 0x0601D9C6 RID: 121286 RVA: 0x00847F60 File Offset: 0x00846160
	private EExecutedFlag? GetHighestExecutedFlag(long creatureDataId)
	{
		EntityHandle entity = CreatureModel.Instance.GetEntity(creatureDataId);
		if (entity == null || !entity.Valid || entity.Entity == null)
		{
			return null;
		}
		EExecutedFlag flag = entity.Entity.Flag;
		if ((flag & EExecutedFlag.Clear) != EExecutedFlag.None)
		{
			return new EExecutedFlag?(EExecutedFlag.Clear);
		}
		if ((flag & EExecutedFlag.End) != EExecutedFlag.None)
		{
			return new EExecutedFlag?(EExecutedFlag.End);
		}
		if ((flag & EExecutedFlag.PostActivate) != EExecutedFlag.None)
		{
			return new EExecutedFlag?(EExecutedFlag.PostActivate);
		}
		if ((flag & EExecutedFlag.Activate) != EExecutedFlag.None)
		{
			return new EExecutedFlag?(EExecutedFlag.Activate);
		}
		if ((flag & EExecutedFlag.Start) != EExecutedFlag.None)
		{
			return new EExecutedFlag?(EExecutedFlag.Start);
		}
		if ((flag & EExecutedFlag.Init) != EExecutedFlag.None)
		{
			return new EExecutedFlag?(EExecutedFlag.Init);
		}
		if ((flag & EExecutedFlag.Create) != EExecutedFlag.None)
		{
			return new EExecutedFlag?(EExecutedFlag.Create);
		}
		return new EExecutedFlag?(EExecutedFlag.None);
	}

	// Token: 0x0601D9C7 RID: 121287 RVA: 0x00848010 File Offset: 0x00846210
	private EExecutedFlag GetHighestExecutedFlagInBindGroup(IReadOnlyList<long> bindGroup)
	{
		EExecutedFlag eexecutedFlag = EExecutedFlag.Start;
		foreach (long creatureDataId in bindGroup)
		{
			EExecutedFlag? highestExecutedFlag = this.GetHighestExecutedFlag(creatureDataId);
			if (highestExecutedFlag != null)
			{
				eexecutedFlag = (EExecutedFlag)Math.Max((int)eexecutedFlag, (int)highestExecutedFlag.Value);
			}
		}
		return eexecutedFlag;
	}

	// Token: 0x0601D9C8 RID: 121288 RVA: 0x00848074 File Offset: 0x00846274
	private EExecutedFlag GetLowestExecutedFlagInBindGroup(IReadOnlyList<long> bindGroup)
	{
		EExecutedFlag eexecutedFlag = EExecutedFlag.PostActivate;
		foreach (long creatureDataId in bindGroup)
		{
			EExecutedFlag? highestExecutedFlag = this.GetHighestExecutedFlag(creatureDataId);
			if (highestExecutedFlag != null)
			{
				eexecutedFlag = (EExecutedFlag)Math.Min((int)eexecutedFlag, (int)highestExecutedFlag.Value);
			}
		}
		return eexecutedFlag;
	}

	// Token: 0x0601D9C9 RID: 121289 RVA: 0x008480D8 File Offset: 0x008462D8
	private void ReleaseRefreshBindGroupLock()
	{
		this.RefreshBindGroupLock = false;
		if (this.RefreshBindGroupCache.Count > 0)
		{
			long num = this.RefreshBindGroupCache.Keys.First<long>();
			string reason = this.RefreshBindGroupCache[num];
			this.RefreshBindGroupCache.Remove(num);
			this.RefreshBindGroup(num, reason);
		}
	}

	// Token: 0x0601D9CA RID: 121290 RVA: 0x00848130 File Offset: 0x00846330
	public unsafe void RefreshBindGroup(long creatureDataId, string reason)
	{
		IReadOnlyList<long> bindGroup = this.GetBindGroup(creatureDataId);
		EntityHandle entity = CreatureModel.Instance.GetEntity(creatureDataId);
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", creatureDataId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("bindGroup", bindGroup);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("EntityId", (entity != null) ? new int?(entity.Id) : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("reason", reason);
		ReadOnlySpan<ValueTuple<string, object>> readOnlySpan = <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4);
		if (bindGroup == null)
		{
			Log.Instance.Error(ELogModule.Entity, ELogAuthor.ZQR, "[实体生命周期:实体绑组] 实体不在实体组中", readOnlySpan);
			this.ReleaseRefreshBindGroupLock();
			return;
		}
		EExecutedFlag highestExecutedFlagInBindGroup = this.GetHighestExecutedFlagInBindGroup(bindGroup);
		EExecutedFlag lowestExecutedFlagInBindGroup = this.GetLowestExecutedFlagInBindGroup(bindGroup);
		ReadOnlySpan<ValueTuple<string, object>> readOnlySpan2 = readOnlySpan;
		int num = 0;
		ValueTuple<string, object>[] array = new ValueTuple<string, object>[2 + readOnlySpan2.Length];
		readOnlySpan2.CopyTo(new Span<ValueTuple<string, object>>(array).Slice(num, readOnlySpan2.Length));
		num += readOnlySpan2.Length;
		array[num] = new ValueTuple<string, object>("highestFlag", highestExecutedFlagInBindGroup);
		num++;
		array[num] = new ValueTuple<string, object>("lowestFlag", lowestExecutedFlagInBindGroup);
		readOnlySpan = new ReadOnlySpan<ValueTuple<string, object>>(array);
		if (lowestExecutedFlagInBindGroup >= EExecutedFlag.PostActivate)
		{
			Log.Instance.Info(ELogModule.Entity, ELogAuthor.ZQR, "[实体生命周期:实体绑组] 实体组激活完毕，删除实体组及相应缓存", readOnlySpan);
			foreach (long key in bindGroup)
			{
				this.RefreshBindGroupCache.Remove(key);
			}
			this.BindEntityGroups.DeleteSet(creatureDataId);
			EventSystem.Instance.Emit<IReadOnlyList<long>>(EEventName.RemoveEntityFromBindGroup, bindGroup);
			this.ReleaseRefreshBindGroupLock();
			return;
		}
		if (this.RefreshBindGroupLock)
		{
			this.RefreshBindGroupCache[creatureDataId] = reason;
			return;
		}
		this.RefreshBindGroupLock = true;
		if (lowestExecutedFlagInBindGroup >= highestExecutedFlagInBindGroup)
		{
			Log.Instance.Info(ELogModule.Entity, ELogAuthor.ZQR, "[实体生命周期:实体绑组] 整组推进生命周期", readOnlySpan);
			using (IEnumerator<long> enumerator = bindGroup.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					long creatureDataId2 = enumerator.Current;
					this.ForwardEntityLifeCycle(creatureDataId2);
				}
				goto IL_2B7;
			}
		}
		if (highestExecutedFlagInBindGroup > EExecutedFlag.Start)
		{
			Log.Instance.Info(ELogModule.Entity, ELogAuthor.ZQR, "[实体生命周期:实体绑组] 部分推进生命周期", readOnlySpan);
			using (IEnumerator<long> enumerator = bindGroup.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					long creatureDataId3 = enumerator.Current;
					EExecutedFlag? highestExecutedFlag = this.GetHighestExecutedFlag(creatureDataId3);
					if (highestExecutedFlag != null && highestExecutedFlag.Value < highestExecutedFlagInBindGroup)
					{
						this.ForwardEntityLifeCycle(creatureDataId3);
					}
				}
				goto IL_2B7;
			}
		}
		Log.Instance.Info(ELogModule.Entity, ELogAuthor.ZQR, "[实体生命周期:实体绑组] 同组尚未start，暂时阻塞", readOnlySpan);
		IL_2B7:
		this.ReleaseRefreshBindGroupLock();
	}

	// Token: 0x0601D9CB RID: 121291 RVA: 0x00848424 File Offset: 0x00846624
	private unsafe void ForwardEntityLifeCycle(long creatureDataId)
	{
		EntityHandle entity = CreatureModel.Instance.GetEntity(creatureDataId);
		EExecutedFlag? highestExecutedFlag = this.GetHighestExecutedFlag(creatureDataId);
		if (entity == null || !entity.Valid || entity.Entity == null)
		{
			return;
		}
		if (highestExecutedFlag == null || highestExecutedFlag.Value == EExecutedFlag.None)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.ZQR;
			string message = "[实体生命周期:实体绑组]实体Flag为空";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", creatureDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityId", entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ExecutedFlag", highestExecutedFlag);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		if (highestExecutedFlag.Value >= EExecutedFlag.Start && highestExecutedFlag.Value < EExecutedFlag.PostActivate)
		{
			if (highestExecutedFlag.Value == EExecutedFlag.Start)
			{
				CreatureController.Instance.ActivateEntityRequest(entity);
				return;
			}
			if (highestExecutedFlag.Value == EExecutedFlag.Activate)
			{
				EntitySystem.Instance.PostActive(entity.Entity);
				this.RefreshBindGroup(creatureDataId, "postActive");
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Entity;
			ELogAuthor author2 = ELogAuthor.ZQR;
			string message2 = "[实体生命周期:实体绑组]预期外的flag类型";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("CreatureDataId", creatureDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("EntityId", entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("ExecutedFlag", highestExecutedFlag);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
		}
	}

	// Token: 0x0601D9CC RID: 121292 RVA: 0x008485CC File Offset: 0x008467CC
	public void RemoveFromBindGroup(long creatureDataId, string reason)
	{
		IReadOnlyList<long> bindGroup = this.GetBindGroup(creatureDataId);
		if (bindGroup == null)
		{
			return;
		}
		long? num = null;
		foreach (long num2 in bindGroup)
		{
			if (num2 != creatureDataId)
			{
				num = new long?(num2);
				break;
			}
		}
		this.BindEntityGroups.Delete(creatureDataId);
		EventSystem.Instance.Emit<IReadOnlyList<long>>(EEventName.RemoveEntityFromBindGroup, new <>z__ReadOnlySingleElementList<long>(creatureDataId));
		if (num != null)
		{
			if (this.HasBindGroup(num.Value))
			{
				this.RefreshBindGroup(num.Value, reason);
				return;
			}
			this.ForwardEntityLifeCycle(num.Value);
		}
	}

	// Token: 0x170028E3 RID: 10467
	// (get) Token: 0x0601D9CD RID: 121293 RVA: 0x00848684 File Offset: 0x00846884
	public static CreatureGroupController Instance
	{
		get
		{
			return CreatureGroupController._Instance;
		}
	}

	// Token: 0x0601D9CE RID: 121294 RVA: 0x0084868B File Offset: 0x0084688B
	public static CreatureGroupController GetOrCreateInstance()
	{
		if (CreatureGroupController._Instance == null)
		{
			CreatureGroupController.CreateInstance();
		}
		return CreatureGroupController._Instance;
	}

	// Token: 0x0601D9CF RID: 121295 RVA: 0x0084869F File Offset: 0x0084689F
	public static bool CreateInstance()
	{
		if (CreatureGroupController._Instance != null)
		{
			return true;
		}
		CreatureGroupController._Instance = new CreatureGroupController();
		return true;
	}

	// Token: 0x0601D9D0 RID: 121296 RVA: 0x008486B5 File Offset: 0x008468B5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601D9D1 RID: 121297 RVA: 0x008486B7 File Offset: 0x008468B7
	public static void ResetStaticDefaultValue()
	{
		CreatureGroupController._Instance = null;
	}

	// Token: 0x0601D9D2 RID: 121298 RVA: 0x008486BF File Offset: 0x008468BF
	static CreatureGroupController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CreatureGroupController.CreateStaticDefaultValue), new Action(CreatureGroupController.ResetStaticDefaultValue));
	}

	// Token: 0x0400E86F RID: 59503
	private readonly DisjointSet<long> BindEntityGroups = new DisjointSet<long>();

	// Token: 0x0400E870 RID: 59504
	private readonly BindGroupEntityWhiteFilter BindGroupEntityWhiteFilter = new BindGroupEntityWhiteFilter();

	// Token: 0x0400E871 RID: 59505
	private bool RefreshBindGroupLock;

	// Token: 0x0400E872 RID: 59506
	private readonly Dictionary<long, string> RefreshBindGroupCache = new Dictionary<long, string>();

	// Token: 0x0400E873 RID: 59507
	[Nullable(2)]
	private static CreatureGroupController _Instance;
}

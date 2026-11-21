using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002A4E RID: 10830
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class CreatureGroupController : ControllerBase
{
	// Token: 0x0601B6CC RID: 112332 RVA: 0x008701C2 File Offset: 0x0086E3C2
	protected override bool OnClear()
	{
		this.BindEntityGroups.Clear();
		this.BindGroupEntityWhiteFilter.Cleanup();
		return base.OnClear();
	}

	// Token: 0x0601B6CD RID: 112333 RVA: 0x008701E0 File Offset: 0x0086E3E0
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

	// Token: 0x0601B6CE RID: 112334 RVA: 0x00870257 File Offset: 0x0086E457
	public bool HasBindGroup(long creatureDataId)
	{
		return this.BindEntityGroups.Has(creatureDataId);
	}

	// Token: 0x0601B6CF RID: 112335 RVA: 0x00870265 File Offset: 0x0086E465
	[NullableContext(2)]
	public IReadOnlyList<long> GetBindGroup(long creatureDataId)
	{
		return this.BindEntityGroups.GetSet(creatureDataId);
	}

	// Token: 0x0601B6D0 RID: 112336 RVA: 0x00870274 File Offset: 0x0086E474
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

	// Token: 0x0601B6D1 RID: 112337 RVA: 0x00870324 File Offset: 0x0086E524
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

	// Token: 0x0601B6D2 RID: 112338 RVA: 0x00870388 File Offset: 0x0086E588
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

	// Token: 0x0601B6D3 RID: 112339 RVA: 0x008703EC File Offset: 0x0086E5EC
	private void ReleaseRefreshBindGroupLock()
	{
		this.RefreshBindGroupLock = false;
		if (this.RefreshBindGroupCache.Count > 0)
		{
			long num = 0L;
			using (Dictionary<long, string>.KeyCollection.Enumerator enumerator = this.RefreshBindGroupCache.Keys.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					num = enumerator.Current;
				}
			}
			string reason = this.RefreshBindGroupCache[num];
			this.RefreshBindGroupCache.Remove(num);
			this.RefreshBindGroup(num, reason);
		}
	}

	// Token: 0x0601B6D4 RID: 112340 RVA: 0x0087047C File Offset: 0x0086E67C
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

	// Token: 0x0601B6D5 RID: 112341 RVA: 0x00870770 File Offset: 0x0086E970
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

	// Token: 0x0601B6D6 RID: 112342 RVA: 0x00870918 File Offset: 0x0086EB18
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

	// Token: 0x17002C7B RID: 11387
	// (get) Token: 0x0601B6D7 RID: 112343 RVA: 0x008709D0 File Offset: 0x0086EBD0
	public static CreatureGroupController Instance
	{
		get
		{
			return CreatureGroupController._Instance;
		}
	}

	// Token: 0x0601B6D8 RID: 112344 RVA: 0x008709D7 File Offset: 0x0086EBD7
	public static CreatureGroupController GetOrCreateInstance()
	{
		if (CreatureGroupController._Instance == null)
		{
			CreatureGroupController.CreateInstance();
		}
		return CreatureGroupController._Instance;
	}

	// Token: 0x0601B6D9 RID: 112345 RVA: 0x008709EB File Offset: 0x0086EBEB
	public static bool CreateInstance()
	{
		if (CreatureGroupController._Instance != null)
		{
			return true;
		}
		CreatureGroupController._Instance = new CreatureGroupController();
		return true;
	}

	// Token: 0x0601B6DA RID: 112346 RVA: 0x00870A01 File Offset: 0x0086EC01
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B6DB RID: 112347 RVA: 0x00870A03 File Offset: 0x0086EC03
	public static void ResetStaticDefaultValue()
	{
		CreatureGroupController._Instance = null;
	}

	// Token: 0x0601B6DC RID: 112348 RVA: 0x00870A0B File Offset: 0x0086EC0B
	static CreatureGroupController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CreatureGroupController.CreateStaticDefaultValue), new Action(CreatureGroupController.ResetStaticDefaultValue));
	}

	// Token: 0x0400ED26 RID: 60710
	private readonly DisjointSet<long> BindEntityGroups = new DisjointSet<long>();

	// Token: 0x0400ED27 RID: 60711
	private readonly BindGroupEntityWhiteFilter BindGroupEntityWhiteFilter = new BindGroupEntityWhiteFilter();

	// Token: 0x0400ED28 RID: 60712
	private bool RefreshBindGroupLock;

	// Token: 0x0400ED29 RID: 60713
	private readonly Dictionary<long, string> RefreshBindGroupCache = new Dictionary<long, string>();

	// Token: 0x0400ED2A RID: 60714
	[Nullable(2)]
	private static CreatureGroupController _Instance;
}

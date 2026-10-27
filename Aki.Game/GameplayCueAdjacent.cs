using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x02002FAF RID: 12207
[NullableContext(1)]
[Nullable(0)]
public class GameplayCueAdjacent : GameplayCueBase
{
	// Token: 0x06019E17 RID: 106007 RVA: 0x006C3F3C File Offset: 0x006C213C
	protected unsafe override void OnInit()
	{
		this.CueIds.Clear();
		this.TargetEntityTypes.Clear();
		int parametersLength = this.CueConfig.ParametersLength;
		string text = (parametersLength > 0) ? this.CueConfig.Parameters(0) : "";
		string[] array;
		if (!string.IsNullOrEmpty(text))
		{
			array = text.Split('#', StringSplitOptions.None);
			for (int i = 0; i < array.Length; i++)
			{
				int num;
				if (int.TryParse(array[i], out num) && num > 0)
				{
					this.CueIds.Add(num);
				}
			}
		}
		if (this.CueIds.Count == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.HXY;
			string message = "GameplayCueAdjacent配置错误: CueId列表为空";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CueId", this.CueConfig.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Parameters[0]", (parametersLength > 0) ? this.CueConfig.Parameters(0) : "");
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		float num2;
		this.Distance = ((parametersLength > 1 && float.TryParse(this.CueConfig.Parameters(1), out num2)) ? num2 : 20000f);
		float num3;
		this.SpreadDuration = ((parametersLength > 2 && float.TryParse(this.CueConfig.Parameters(2), out num3)) ? num3 : 0f);
		int num4;
		this.TargetRelation = ((parametersLength > 3 && int.TryParse(this.CueConfig.Parameters(3), out num4)) ? ((ERelation)num4) : ERelation.None);
		array = ((parametersLength > 4) ? this.CueConfig.Parameters(4) : "0#2").Split('#', StringSplitOptions.None);
		for (int i = 0; i < array.Length; i++)
		{
			int item;
			if (int.TryParse(array[i], out item))
			{
				this.TargetEntityTypes.Add(item);
			}
		}
		if (this.TargetEntityTypes.Count == 0)
		{
			this.TargetEntityTypes.Add(0);
			this.TargetEntityTypes.Add(2);
		}
	}

	// Token: 0x06019E18 RID: 106008 RVA: 0x006C4138 File Offset: 0x006C2338
	protected override void OnCreate()
	{
		if (this.CueIds.Count == 0)
		{
			return;
		}
		List<EntityHandle> entitiesToAdd = this.GetEntitiesToAdd();
		if (this.SpreadDuration <= 0f)
		{
			using (List<EntityHandle>.Enumerator enumerator = entitiesToAdd.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					EntityHandle entityHandle = enumerator.Current;
					this.ApplyCueToEntity(entityHandle);
				}
				return;
			}
		}
		this.SetupSpreadApplication(entitiesToAdd);
	}

	// Token: 0x06019E19 RID: 106009 RVA: 0x006C41B0 File Offset: 0x006C23B0
	protected override void OnTick(float delta)
	{
		if (this.PendingEntities.Count == 0)
		{
			return;
		}
		this.ElapsedTime += delta;
		while (this.PendingEntities.Count > 0 && this.ElapsedTime >= this.PendingEntities[0].Item2)
		{
			ValueTuple<EntityHandle, float> valueTuple = this.PendingEntities[0];
			this.PendingEntities.RemoveAt(0);
			this.ApplyCueToEntity(valueTuple.Item1);
		}
	}

	// Token: 0x06019E1A RID: 106010 RVA: 0x006C4228 File Offset: 0x006C2428
	protected override void OnDestroy()
	{
		this.PendingEntities.Clear();
		foreach (KeyValuePair<EntityHandle, List<int>> keyValuePair in this.AdjacentCandidates)
		{
			EntityHandle entityHandle;
			List<int> list;
			keyValuePair.Deconstruct(out entityHandle, out list);
			EntityHandle entityHandle2 = entityHandle;
			List<int> list2 = list;
			if (entityHandle2.Valid)
			{
				WorldEntity entity = entityHandle2.Entity;
				BaseGameplayCueComponent baseGameplayCueComponent = (entity != null) ? entity.GetComponent<BaseGameplayCueComponent>() : null;
				if (baseGameplayCueComponent != null)
				{
					foreach (int num in list2)
					{
						baseGameplayCueComponent.RemoveCueByHandle((long)num);
					}
				}
			}
		}
		this.AdjacentCandidates.Clear();
	}

	// Token: 0x06019E1B RID: 106011 RVA: 0x006C4300 File Offset: 0x006C2500
	private void ApplyCueToEntity(EntityHandle entityHandle)
	{
		if (!entityHandle.Valid)
		{
			return;
		}
		WorldEntity entity = entityHandle.Entity;
		BaseGameplayCueComponent baseGameplayCueComponent = (entity != null) ? entity.GetComponent<BaseGameplayCueComponent>() : null;
		if (baseGameplayCueComponent == null)
		{
			return;
		}
		List<int> list = new List<int>();
		foreach (int num in this.CueIds)
		{
			int num2 = baseGameplayCueComponent.AddCue((long)num, null);
			if (num2 != 0)
			{
				list.Add(num2);
			}
		}
		if (list.Count > 0)
		{
			this.AdjacentCandidates[entityHandle] = list;
		}
	}

	// Token: 0x06019E1C RID: 106012 RVA: 0x006C43A8 File Offset: 0x006C25A8
	private void SetupSpreadApplication(List<EntityHandle> candidates)
	{
		WorldEntity entity = this.EntityHandle.Entity;
		BaseActorComponent baseActorComponent = (entity != null) ? entity.GetComponent<BaseActorComponent>() : null;
		if (baseActorComponent == null)
		{
			return;
		}
		global::Vector actorLocationProxy = baseActorComponent.ActorLocationProxy;
		List<ValueTuple<EntityHandle, double>> list = new List<ValueTuple<EntityHandle, double>>(candidates.Count);
		foreach (EntityHandle entityHandle in candidates)
		{
			WorldEntity entity2 = entityHandle.Entity;
			BaseActorComponent baseActorComponent2 = (entity2 != null) ? entity2.GetComponent<BaseActorComponent>() : null;
			if (baseActorComponent2 != null)
			{
				global::Vector actorLocationProxy2 = baseActorComponent2.ActorLocationProxy;
				list.Add(new ValueTuple<EntityHandle, double>(entityHandle, global::Vector.Distance(actorLocationProxy, actorLocationProxy2)));
			}
		}
		list.Sort(([TupleElementNames(new string[]
		{
			"Handle",
			"Distance"
		})] [Nullable(new byte[]
		{
			0,
			1
		})] ValueTuple<EntityHandle, double> a, [TupleElementNames(new string[]
		{
			"Handle",
			"Distance"
		})] [Nullable(new byte[]
		{
			0,
			1
		})] ValueTuple<EntityHandle, double> b) => a.Item2.CompareTo(b.Item2));
		this.PendingEntities.Clear();
		foreach (ValueTuple<EntityHandle, double> valueTuple in list)
		{
			this.PendingEntities.Add(new ValueTuple<EntityHandle, float>(valueTuple.Item1, (this.Distance > 0f) ? ((float)(valueTuple.Item2 / (double)this.Distance) * this.SpreadDuration) : 0f));
		}
		this.ElapsedTime = 0f;
	}

	// Token: 0x06019E1D RID: 106013 RVA: 0x006C450C File Offset: 0x006C270C
	private List<EntityHandle> GetEntitiesToAdd()
	{
		List<EntityHandle> list = new List<EntityHandle>();
		List<EntityHandle> list2 = new List<EntityHandle>();
		CreatureModel.Instance.GetEntitiesInRange((float)((int)this.Distance), EEntityTypeQuery.Character, list, true, false);
		TsBaseCharacter tsBaseCharacter = this.ActorInternal as TsBaseCharacter;
		ECamp targetCamp = (tsBaseCharacter != null) ? tsBaseCharacter.Camp : ECamp.Player;
		foreach (EntityHandle entityHandle in list)
		{
			if (LockOnUtils.IsValidLockOnTarget(entityHandle, null, null, false))
			{
				WorldEntity entity = entityHandle.Entity;
				if (((entity != null) ? entity.GetComponent<BaseGameplayCueComponent>() : null) != null)
				{
					WorldEntity entity2 = entityHandle.Entity;
					BaseCharacterComponent baseCharacterComponent = (entity2 != null) ? entity2.GetComponent<BaseCharacterComponent>() : null;
					if (baseCharacterComponent != null)
					{
						ERelation campRelationship = CampUtils.GetCampRelationship(baseCharacterComponent.Actor.Camp, targetCamp);
						if (this.TargetRelation == ERelation.None || campRelationship == this.TargetRelation)
						{
							WorldEntity entity3 = entityHandle.Entity;
							CreatureDataComponent creatureDataComponent = (entity3 != null) ? entity3.GetComponent<CreatureDataComponent>() : null;
							int item = (int)((creatureDataComponent != null) ? creatureDataComponent.GetEntityType() : ((EEntityType)(-1)));
							if (this.TargetEntityTypes.Contains(item))
							{
								list2.Add(entityHandle);
							}
						}
					}
				}
			}
		}
		return list2;
	}

	// Token: 0x0400C3BC RID: 50108
	private readonly Dictionary<EntityHandle, List<int>> AdjacentCandidates = new Dictionary<EntityHandle, List<int>>();

	// Token: 0x0400C3BD RID: 50109
	private readonly List<int> CueIds = new List<int>();

	// Token: 0x0400C3BE RID: 50110
	private readonly List<int> TargetEntityTypes = new List<int>();

	// Token: 0x0400C3BF RID: 50111
	[TupleElementNames(new string[]
	{
		"Handle",
		"ApplyTime"
	})]
	[Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	private readonly List<ValueTuple<EntityHandle, float>> PendingEntities = new List<ValueTuple<EntityHandle, float>>();

	// Token: 0x0400C3C0 RID: 50112
	private float Distance;

	// Token: 0x0400C3C1 RID: 50113
	private ERelation TargetRelation;

	// Token: 0x0400C3C2 RID: 50114
	private float SpreadDuration;

	// Token: 0x0400C3C3 RID: 50115
	private float ElapsedTime;
}

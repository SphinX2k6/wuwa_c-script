using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003529 RID: 13609
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class SceneOpacityModel : ModelBase
{
	// Token: 0x0601DE88 RID: 122504 RVA: 0x00862C0E File Offset: 0x00860E0E
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0601DE89 RID: 122505 RVA: 0x00862C11 File Offset: 0x00860E11
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x0601DE8A RID: 122506 RVA: 0x00862C14 File Offset: 0x00860E14
	protected override bool OnLeaveLevel()
	{
		this.OpacityComponentMap.Clear();
		this.CurrentOpacityMap.Clear();
		return true;
	}

	// Token: 0x0601DE8B RID: 122507 RVA: 0x00862C30 File Offset: 0x00860E30
	public void AddOpacityEntity(UStaticMeshComponent component, int entityId)
	{
		HashSet<int> hashSet;
		if (!this.OpacityComponentMap.TryGetValue(component, out hashSet))
		{
			hashSet = new HashSet<int>();
			this.OpacityComponentMap[component] = hashSet;
		}
		hashSet.Add(entityId);
		if (!this.CurrentOpacityMap.ContainsKey(component))
		{
			this.CurrentOpacityMap[component] = 1f;
		}
	}

	// Token: 0x0601DE8C RID: 122508 RVA: 0x00862C88 File Offset: 0x00860E88
	public void RemoveOpacityEntity(UStaticMeshComponent component, int entityId)
	{
		HashSet<int> hashSet;
		if (!this.OpacityComponentMap.TryGetValue(component, out hashSet))
		{
			return;
		}
		hashSet.Remove(entityId);
		if (hashSet.Count == 0)
		{
			this.OpacityComponentMap.Remove(component);
		}
	}

	// Token: 0x0601DE8D RID: 122509 RVA: 0x00862CC4 File Offset: 0x00860EC4
	public bool IsAffected(UStaticMeshComponent component)
	{
		HashSet<int> hashSet;
		return this.OpacityComponentMap.TryGetValue(component, out hashSet) && hashSet.Count > 0;
	}

	// Token: 0x1700295D RID: 10589
	// (get) Token: 0x0601DE8E RID: 122510 RVA: 0x00862CEC File Offset: 0x00860EEC
	public static SceneOpacityModel Instance
	{
		get
		{
			return SceneOpacityModel._Instance;
		}
	}

	// Token: 0x0601DE8F RID: 122511 RVA: 0x00862CF3 File Offset: 0x00860EF3
	public static SceneOpacityModel GetOrCreateInstance()
	{
		if (SceneOpacityModel._Instance == null)
		{
			SceneOpacityModel.CreateInstance();
		}
		return SceneOpacityModel._Instance;
	}

	// Token: 0x0601DE90 RID: 122512 RVA: 0x00862D07 File Offset: 0x00860F07
	public static bool CreateInstance()
	{
		if (SceneOpacityModel._Instance != null)
		{
			return true;
		}
		SceneOpacityModel._Instance = new SceneOpacityModel();
		return true;
	}

	// Token: 0x0601DE91 RID: 122513 RVA: 0x00862D1D File Offset: 0x00860F1D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601DE92 RID: 122514 RVA: 0x00862D1F File Offset: 0x00860F1F
	public static void ResetStaticDefaultValue()
	{
		SceneOpacityModel._Instance = null;
	}

	// Token: 0x0601DE93 RID: 122515 RVA: 0x00862D27 File Offset: 0x00860F27
	static SceneOpacityModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SceneOpacityModel.CreateStaticDefaultValue), new Action(SceneOpacityModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400EADB RID: 60123
	public const float MIN_OPACITY = 0.2f;

	// Token: 0x0400EADC RID: 60124
	public const float OPACITY_SPEED = 0.001f;

	// Token: 0x0400EADD RID: 60125
	public const float MAX_OPACITY = 1f;

	// Token: 0x0400EADE RID: 60126
	public readonly Dictionary<UStaticMeshComponent, HashSet<int>> OpacityComponentMap = new Dictionary<UStaticMeshComponent, HashSet<int>>();

	// Token: 0x0400EADF RID: 60127
	public readonly Dictionary<UStaticMeshComponent, float> CurrentOpacityMap = new Dictionary<UStaticMeshComponent, float>();

	// Token: 0x0400EAE0 RID: 60128
	[Nullable(2)]
	private static SceneOpacityModel _Instance;
}

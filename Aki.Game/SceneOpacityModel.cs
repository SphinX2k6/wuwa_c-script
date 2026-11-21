using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002A9E RID: 10910
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class SceneOpacityModel : ModelBase
{
	// Token: 0x0601BBB0 RID: 113584 RVA: 0x0088A846 File Offset: 0x00888A46
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0601BBB1 RID: 113585 RVA: 0x0088A849 File Offset: 0x00888A49
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x0601BBB2 RID: 113586 RVA: 0x0088A84C File Offset: 0x00888A4C
	protected override bool OnLeaveLevel()
	{
		this.OpacityComponentMap.Clear();
		this.CurrentOpacityMap.Clear();
		return true;
	}

	// Token: 0x0601BBB3 RID: 113587 RVA: 0x0088A868 File Offset: 0x00888A68
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

	// Token: 0x0601BBB4 RID: 113588 RVA: 0x0088A8C0 File Offset: 0x00888AC0
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

	// Token: 0x0601BBB5 RID: 113589 RVA: 0x0088A8FC File Offset: 0x00888AFC
	public bool IsAffected(UStaticMeshComponent component)
	{
		HashSet<int> hashSet;
		return this.OpacityComponentMap.TryGetValue(component, out hashSet) && hashSet.Count > 0;
	}

	// Token: 0x17002CF6 RID: 11510
	// (get) Token: 0x0601BBB6 RID: 113590 RVA: 0x0088A924 File Offset: 0x00888B24
	public static SceneOpacityModel Instance
	{
		get
		{
			return SceneOpacityModel._Instance;
		}
	}

	// Token: 0x0601BBB7 RID: 113591 RVA: 0x0088A92B File Offset: 0x00888B2B
	public static SceneOpacityModel GetOrCreateInstance()
	{
		if (SceneOpacityModel._Instance == null)
		{
			SceneOpacityModel.CreateInstance();
		}
		return SceneOpacityModel._Instance;
	}

	// Token: 0x0601BBB8 RID: 113592 RVA: 0x0088A93F File Offset: 0x00888B3F
	public static bool CreateInstance()
	{
		if (SceneOpacityModel._Instance != null)
		{
			return true;
		}
		SceneOpacityModel._Instance = new SceneOpacityModel();
		return true;
	}

	// Token: 0x0601BBB9 RID: 113593 RVA: 0x0088A955 File Offset: 0x00888B55
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601BBBA RID: 113594 RVA: 0x0088A957 File Offset: 0x00888B57
	public static void ResetStaticDefaultValue()
	{
		SceneOpacityModel._Instance = null;
	}

	// Token: 0x0601BBBB RID: 113595 RVA: 0x0088A95F File Offset: 0x00888B5F
	static SceneOpacityModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SceneOpacityModel.CreateStaticDefaultValue), new Action(SceneOpacityModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400EF98 RID: 61336
	public const float MIN_OPACITY = 0.2f;

	// Token: 0x0400EF99 RID: 61337
	public const float OPACITY_SPEED = 0.001f;

	// Token: 0x0400EF9A RID: 61338
	public const float MAX_OPACITY = 1f;

	// Token: 0x0400EF9B RID: 61339
	public readonly Dictionary<UStaticMeshComponent, HashSet<int>> OpacityComponentMap = new Dictionary<UStaticMeshComponent, HashSet<int>>();

	// Token: 0x0400EF9C RID: 61340
	public readonly Dictionary<UStaticMeshComponent, float> CurrentOpacityMap = new Dictionary<UStaticMeshComponent, float>();

	// Token: 0x0400EF9D RID: 61341
	[Nullable(2)]
	private static SceneOpacityModel _Instance;
}

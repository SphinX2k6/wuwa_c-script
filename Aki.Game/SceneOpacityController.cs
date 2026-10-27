using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;
using UnrealEngine;

// Token: 0x020034E6 RID: 13542
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
[TickController(0)]
public class SceneOpacityController : ControllerBase
{
	// Token: 0x0601DAC6 RID: 121542 RVA: 0x0084FE2A File Offset: 0x0084E02A
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0601DAC7 RID: 121543 RVA: 0x0084FE2D File Offset: 0x0084E02D
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x0601DAC8 RID: 121544 RVA: 0x0084FE30 File Offset: 0x0084E030
	protected override bool OnLeaveLevel()
	{
		return true;
	}

	// Token: 0x0601DAC9 RID: 121545 RVA: 0x0084FE34 File Offset: 0x0084E034
	protected override void OnTick(float delta)
	{
		SceneOpacityModel instance = SceneOpacityModel.Instance;
		if (instance == null)
		{
			return;
		}
		Dictionary<UStaticMeshComponent, float> currentOpacityMap = instance.CurrentOpacityMap;
		this.PendingRemoveComponents.Clear();
		foreach (KeyValuePair<UStaticMeshComponent, float> keyValuePair in currentOpacityMap)
		{
			UStaticMeshComponent ustaticMeshComponent;
			float num;
			keyValuePair.Deconstruct(out ustaticMeshComponent, out num);
			UStaticMeshComponent ustaticMeshComponent2 = ustaticMeshComponent;
			float num2 = num;
			if (ustaticMeshComponent2 == null || !ustaticMeshComponent2.IsValid())
			{
				this.PendingRemoveComponents.Add(ustaticMeshComponent2);
			}
			else
			{
				float num3;
				if (instance.IsAffected(ustaticMeshComponent2))
				{
					num3 = Math.Max(0.2f, num2 - 0.001f * delta);
				}
				else
				{
					num3 = Math.Min(1f, num2 + 0.001f * delta);
				}
				if (num3 >= 1f)
				{
					ustaticMeshComponent2.SetKuroOpacity(1f);
					ustaticMeshComponent2.SetUseKuroOpacity(false);
					this.PendingRemoveComponents.Add(ustaticMeshComponent2);
				}
				else
				{
					ustaticMeshComponent2.SetUseKuroOpacity(true);
					ustaticMeshComponent2.SetKuroOpacity(num3);
					currentOpacityMap[ustaticMeshComponent2] = num3;
				}
			}
		}
		foreach (UStaticMeshComponent key in this.PendingRemoveComponents)
		{
			currentOpacityMap.Remove(key);
			instance.OpacityComponentMap.Remove(key);
		}
		this.PendingRemoveComponents.Clear();
		if (currentOpacityMap.Count == 0)
		{
			base.PauseTick();
		}
	}

	// Token: 0x0601DACA RID: 121546 RVA: 0x0084FFB4 File Offset: 0x0084E1B4
	public void SetOpacity(UStaticMeshComponent component, int entityId, bool enable)
	{
		if (enable)
		{
			if (SceneOpacityModel.Instance.OpacityComponentMap.Count == 0)
			{
				base.ResumeTick();
			}
			SceneOpacityModel.Instance.AddOpacityEntity(component, entityId);
			return;
		}
		SceneOpacityModel.Instance.RemoveOpacityEntity(component, entityId);
	}

	// Token: 0x170028EA RID: 10474
	// (get) Token: 0x0601DACB RID: 121547 RVA: 0x0084FFE9 File Offset: 0x0084E1E9
	public static SceneOpacityController Instance
	{
		get
		{
			return SceneOpacityController._Instance;
		}
	}

	// Token: 0x0601DACC RID: 121548 RVA: 0x0084FFF0 File Offset: 0x0084E1F0
	public static SceneOpacityController GetOrCreateInstance()
	{
		if (SceneOpacityController._Instance == null)
		{
			SceneOpacityController.CreateInstance();
		}
		return SceneOpacityController._Instance;
	}

	// Token: 0x0601DACD RID: 121549 RVA: 0x00850004 File Offset: 0x0084E204
	public static bool CreateInstance()
	{
		if (SceneOpacityController._Instance != null)
		{
			return true;
		}
		SceneOpacityController._Instance = new SceneOpacityController();
		return true;
	}

	// Token: 0x0601DACE RID: 121550 RVA: 0x0085001A File Offset: 0x0084E21A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601DACF RID: 121551 RVA: 0x0085001C File Offset: 0x0084E21C
	public static void ResetStaticDefaultValue()
	{
		SceneOpacityController._Instance = null;
	}

	// Token: 0x0601DAD0 RID: 121552 RVA: 0x00850024 File Offset: 0x0084E224
	static SceneOpacityController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SceneOpacityController.CreateStaticDefaultValue), new Action(SceneOpacityController.ResetStaticDefaultValue));
	}

	// Token: 0x0400E8CE RID: 59598
	private readonly List<UStaticMeshComponent> PendingRemoveComponents = new List<UStaticMeshComponent>();

	// Token: 0x0400E8CF RID: 59599
	[Nullable(2)]
	private static SceneOpacityController _Instance;
}

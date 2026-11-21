using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;
using UnrealEngine;

// Token: 0x02002A5A RID: 10842
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
[TickController(0)]
public class SceneOpacityController : ControllerBase
{
	// Token: 0x0601B7D4 RID: 112596 RVA: 0x008781A2 File Offset: 0x008763A2
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0601B7D5 RID: 112597 RVA: 0x008781A5 File Offset: 0x008763A5
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x0601B7D6 RID: 112598 RVA: 0x008781A8 File Offset: 0x008763A8
	protected override bool OnLeaveLevel()
	{
		return true;
	}

	// Token: 0x0601B7D7 RID: 112599 RVA: 0x008781AC File Offset: 0x008763AC
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

	// Token: 0x0601B7D8 RID: 112600 RVA: 0x0087832C File Offset: 0x0087652C
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

	// Token: 0x17002C82 RID: 11394
	// (get) Token: 0x0601B7D9 RID: 112601 RVA: 0x00878361 File Offset: 0x00876561
	public static SceneOpacityController Instance
	{
		get
		{
			return SceneOpacityController._Instance;
		}
	}

	// Token: 0x0601B7DA RID: 112602 RVA: 0x00878368 File Offset: 0x00876568
	public static SceneOpacityController GetOrCreateInstance()
	{
		if (SceneOpacityController._Instance == null)
		{
			SceneOpacityController.CreateInstance();
		}
		return SceneOpacityController._Instance;
	}

	// Token: 0x0601B7DB RID: 112603 RVA: 0x0087837C File Offset: 0x0087657C
	public static bool CreateInstance()
	{
		if (SceneOpacityController._Instance != null)
		{
			return true;
		}
		SceneOpacityController._Instance = new SceneOpacityController();
		return true;
	}

	// Token: 0x0601B7DC RID: 112604 RVA: 0x00878392 File Offset: 0x00876592
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B7DD RID: 112605 RVA: 0x00878394 File Offset: 0x00876594
	public static void ResetStaticDefaultValue()
	{
		SceneOpacityController._Instance = null;
	}

	// Token: 0x0601B7DE RID: 112606 RVA: 0x0087839C File Offset: 0x0087659C
	static SceneOpacityController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SceneOpacityController.CreateStaticDefaultValue), new Action(SceneOpacityController.ResetStaticDefaultValue));
	}

	// Token: 0x0400ED85 RID: 60805
	private readonly List<UStaticMeshComponent> PendingRemoveComponents = new List<UStaticMeshComponent>();

	// Token: 0x0400ED86 RID: 60806
	[Nullable(2)]
	private static SceneOpacityController _Instance;
}

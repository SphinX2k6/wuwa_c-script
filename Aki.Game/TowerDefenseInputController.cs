using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Input;
using CSharpScript.Game.KuroSimpleCombat;

// Token: 0x02000384 RID: 900
public class TowerDefenseInputController
{
	// Token: 0x060031DF RID: 12767 RVA: 0x0011E758 File Offset: 0x0011C958
	public static bool OnStart()
	{
		return true;
	}

	// Token: 0x060031E0 RID: 12768 RVA: 0x0011E75B File Offset: 0x0011C95B
	public static bool OnStop()
	{
		TowerDefenseInputController.RemoveInputLayer();
		return true;
	}

	// Token: 0x060031E1 RID: 12769 RVA: 0x0011E764 File Offset: 0x0011C964
	[NullableContext(2)]
	private static TowerDefenseInputLayer GetInputLayer()
	{
		EntityHandle possessedPlayerEntity = TowerDefensePlayerController.GetPossessedPlayerEntity();
		if (possessedPlayerEntity != null)
		{
			return InputController.Instance.GetInputLayer(possessedPlayerEntity.Id, EInputLayer.TowerDefense) as TowerDefenseInputLayer;
		}
		return null;
	}

	// Token: 0x060031E2 RID: 12770 RVA: 0x0011E794 File Offset: 0x0011C994
	public static bool AddInputLayer()
	{
		TowerDefenseInputLayer towerDefenseInputLayer = TowerDefenseInputController.GetInputLayer();
		if (towerDefenseInputLayer != null)
		{
			TowerDefenseInputController.RemoveInputLayer();
		}
		towerDefenseInputLayer = (InputController.Instance.CreateInputLayer(EInputLayer.TowerDefense) as TowerDefenseInputLayer);
		if (towerDefenseInputLayer != null)
		{
			EntityHandle possessedPlayerEntity = TowerDefensePlayerController.GetPossessedPlayerEntity();
			if (possessedPlayerEntity != null)
			{
				InputController.Instance.AddInputLayer(possessedPlayerEntity.Id, towerDefenseInputLayer);
			}
			else
			{
				KscLog.Warn(KscLog.EModule.Input, ELogAuthor.PZ, KscEnv.Instance.KscWorld, "塔防输入层加入异常,无法绑定实体", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return true;
		}
		KscLog.Warn(KscLog.EModule.Input, ELogAuthor.PZ, KscEnv.Instance.KscWorld, "塔防输入层加入异常", default(ReadOnlySpan<ValueTuple<string, object>>));
		return false;
	}

	// Token: 0x060031E3 RID: 12771 RVA: 0x0011E824 File Offset: 0x0011CA24
	public static bool RemoveInputLayer()
	{
		TowerDefenseInputLayer inputLayer = TowerDefenseInputController.GetInputLayer();
		if (inputLayer != null)
		{
			InputController.Instance.RemoveInputLayer(inputLayer);
			inputLayer.Clear();
			return true;
		}
		KscLog.Warn(KscLog.EModule.Input, ELogAuthor.PZ, KscEnv.Instance.KscWorld, "塔防输入层移除异常", default(ReadOnlySpan<ValueTuple<string, object>>));
		return false;
	}
}

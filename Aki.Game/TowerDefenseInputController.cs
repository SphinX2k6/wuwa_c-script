using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Input;
using CSharpScript.Game.KuroSimpleCombat;

// Token: 0x02000ECF RID: 3791
public class TowerDefenseInputController
{
	// Token: 0x06005E48 RID: 24136 RVA: 0x00116AA0 File Offset: 0x00114CA0
	public static bool OnStart()
	{
		return true;
	}

	// Token: 0x06005E49 RID: 24137 RVA: 0x00116AA3 File Offset: 0x00114CA3
	public static bool OnStop()
	{
		TowerDefenseInputController.RemoveInputLayer();
		return true;
	}

	// Token: 0x06005E4A RID: 24138 RVA: 0x00116AAC File Offset: 0x00114CAC
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

	// Token: 0x06005E4B RID: 24139 RVA: 0x00116ADC File Offset: 0x00114CDC
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

	// Token: 0x06005E4C RID: 24140 RVA: 0x00116B6C File Offset: 0x00114D6C
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

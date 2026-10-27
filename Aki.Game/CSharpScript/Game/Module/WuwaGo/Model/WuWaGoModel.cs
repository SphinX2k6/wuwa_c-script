using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Model
{
	// Token: 0x02004739 RID: 18233
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class WuWaGoModel : ModelBase
	{
		// Token: 0x17007711 RID: 30481
		// (get) Token: 0x0602FA79 RID: 195193 RVA: 0x00B0BF2F File Offset: 0x00B0A12F
		public WuWaGoGameData GameData
		{
			get
			{
				if (this.GameDataInner == null)
				{
					this.GameDataInner = new WuWaGoGameData();
				}
				return this.GameDataInner;
			}
		}

		// Token: 0x0602FA7A RID: 195194 RVA: 0x00B0BF4A File Offset: 0x00B0A14A
		public bool InitGameData(Transform originTransform, WuWaGoConfigData levelData)
		{
			return this.GameData.Init(originTransform, levelData);
		}

		// Token: 0x0602FA7B RID: 195195 RVA: 0x00B0BF59 File Offset: 0x00B0A159
		public void ResetGameData()
		{
			WuWaGoGameData gameDataInner = this.GameDataInner;
			if (gameDataInner == null)
			{
				return;
			}
			gameDataInner.Reset();
		}

		// Token: 0x0602FA7C RID: 195196 RVA: 0x00B0BF6B File Offset: 0x00B0A16B
		[return: Nullable(2)]
		public WuWaGoGrid GetGrid(Vector coordinate)
		{
			return this.GameData.GetGrid(coordinate);
		}

		// Token: 0x0602FA7D RID: 195197 RVA: 0x00B0BF79 File Offset: 0x00B0A179
		[NullableContext(2)]
		public WuWaGoGrid GetGridById(int gridId)
		{
			return this.GameData.GetGridById(gridId);
		}

		// Token: 0x0602FA7E RID: 195198 RVA: 0x00B0BF88 File Offset: 0x00B0A188
		[NullableContext(2)]
		public WuWaGoBaseUnit GetUnitById(int unitId)
		{
			if (unitId == 0)
			{
				return null;
			}
			WuWaGoBaseUnit result;
			this.GameData.AllUnits.TryGetValue(unitId, out result);
			return result;
		}

		// Token: 0x17007712 RID: 30482
		// (get) Token: 0x0602FA7F RID: 195199 RVA: 0x00B0BFAF File Offset: 0x00B0A1AF
		public static WuWaGoModel Instance
		{
			get
			{
				return WuWaGoModel._Instance;
			}
		}

		// Token: 0x0602FA80 RID: 195200 RVA: 0x00B0BFB6 File Offset: 0x00B0A1B6
		public static WuWaGoModel GetOrCreateInstance()
		{
			if (WuWaGoModel._Instance == null)
			{
				WuWaGoModel.CreateInstance();
			}
			return WuWaGoModel._Instance;
		}

		// Token: 0x0602FA81 RID: 195201 RVA: 0x00B0BFCA File Offset: 0x00B0A1CA
		public static bool CreateInstance()
		{
			if (WuWaGoModel._Instance != null)
			{
				return true;
			}
			WuWaGoModel._Instance = new WuWaGoModel();
			return true;
		}

		// Token: 0x0602FA82 RID: 195202 RVA: 0x00B0BFE0 File Offset: 0x00B0A1E0
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602FA83 RID: 195203 RVA: 0x00B0BFE2 File Offset: 0x00B0A1E2
		public static void ResetStaticDefaultValue()
		{
			WuWaGoModel._Instance = null;
		}

		// Token: 0x0602FA84 RID: 195204 RVA: 0x00B0BFEA File Offset: 0x00B0A1EA
		static WuWaGoModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WuWaGoModel.CreateStaticDefaultValue), new Action(WuWaGoModel.ResetStaticDefaultValue));
		}

		// Token: 0x04019BBD RID: 105405
		public readonly bool EnableDebug;

		// Token: 0x04019BBE RID: 105406
		[Nullable(2)]
		private WuWaGoGameData GameDataInner;

		// Token: 0x04019BBF RID: 105407
		[Nullable(2)]
		private static WuWaGoModel _Instance;
	}
}

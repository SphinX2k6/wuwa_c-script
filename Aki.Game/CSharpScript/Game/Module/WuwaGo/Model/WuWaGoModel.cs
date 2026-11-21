using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Model
{
	// Token: 0x0200366A RID: 13930
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class WuWaGoModel : ModelBase
	{
		// Token: 0x170049CD RID: 18893
		// (get) Token: 0x06024243 RID: 148035 RVA: 0x00A3BEFB File Offset: 0x00A3A0FB
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

		// Token: 0x06024244 RID: 148036 RVA: 0x00A3BF16 File Offset: 0x00A3A116
		public bool InitGameData(Transform originTransform, WuWaGoConfigData levelData)
		{
			return this.GameData.Init(originTransform, levelData);
		}

		// Token: 0x06024245 RID: 148037 RVA: 0x00A3BF25 File Offset: 0x00A3A125
		public void ResetGameData()
		{
			WuWaGoGameData gameDataInner = this.GameDataInner;
			if (gameDataInner == null)
			{
				return;
			}
			gameDataInner.Reset();
		}

		// Token: 0x06024246 RID: 148038 RVA: 0x00A3BF37 File Offset: 0x00A3A137
		[return: Nullable(2)]
		public WuWaGoGrid GetGrid(Vector coordinate)
		{
			return this.GameData.GetGrid(coordinate);
		}

		// Token: 0x06024247 RID: 148039 RVA: 0x00A3BF45 File Offset: 0x00A3A145
		[NullableContext(2)]
		public WuWaGoGrid GetGridById(int gridId)
		{
			return this.GameData.GetGridById(gridId);
		}

		// Token: 0x06024248 RID: 148040 RVA: 0x00A3BF54 File Offset: 0x00A3A154
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

		// Token: 0x170049CE RID: 18894
		// (get) Token: 0x06024249 RID: 148041 RVA: 0x00A3BF7B File Offset: 0x00A3A17B
		public static WuWaGoModel Instance
		{
			get
			{
				return WuWaGoModel._Instance;
			}
		}

		// Token: 0x0602424A RID: 148042 RVA: 0x00A3BF82 File Offset: 0x00A3A182
		public static WuWaGoModel GetOrCreateInstance()
		{
			if (WuWaGoModel._Instance == null)
			{
				WuWaGoModel.CreateInstance();
			}
			return WuWaGoModel._Instance;
		}

		// Token: 0x0602424B RID: 148043 RVA: 0x00A3BF96 File Offset: 0x00A3A196
		public static bool CreateInstance()
		{
			if (WuWaGoModel._Instance != null)
			{
				return true;
			}
			WuWaGoModel._Instance = new WuWaGoModel();
			return true;
		}

		// Token: 0x0602424C RID: 148044 RVA: 0x00A3BFAC File Offset: 0x00A3A1AC
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602424D RID: 148045 RVA: 0x00A3BFAE File Offset: 0x00A3A1AE
		public static void ResetStaticDefaultValue()
		{
			WuWaGoModel._Instance = null;
		}

		// Token: 0x0602424E RID: 148046 RVA: 0x00A3BFB6 File Offset: 0x00A3A1B6
		static WuWaGoModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WuWaGoModel.CreateStaticDefaultValue), new Action(WuWaGoModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401426D RID: 82541
		public readonly bool EnableDebug;

		// Token: 0x0401426E RID: 82542
		[Nullable(2)]
		private WuWaGoGameData GameDataInner;

		// Token: 0x0401426F RID: 82543
		[Nullable(2)]
		private static WuWaGoModel _Instance;
	}
}

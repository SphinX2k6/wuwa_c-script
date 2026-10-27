using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02005877 RID: 22647
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceDungeonGuideModel : ModelBase
	{
		// Token: 0x060399F9 RID: 236025 RVA: 0x00DB19BC File Offset: 0x00DAFBBC
		public int GetCurrentInstanceDungeonGuideType()
		{
			return this.CurrentInstanceDungeonGuideType;
		}

		// Token: 0x060399FA RID: 236026 RVA: 0x00DB19C4 File Offset: 0x00DAFBC4
		public int GetCurrentInstanceDungeonGuideValue()
		{
			return this.CurrentInstanceDungeonGuideValue;
		}

		// Token: 0x060399FB RID: 236027 RVA: 0x00DB19CC File Offset: 0x00DAFBCC
		public void RefreshCurrentDungeonGuide()
		{
			ValueTuple<int, int> guide = InstanceDungeonConfig.Instance.GetGuide(CreatureModel.Instance.GetInstanceId());
			this.CurrentInstanceDungeonGuideType = guide.Item1;
			this.CurrentInstanceDungeonGuideValue = guide.Item2;
			EventSystem.Instance.Emit(EEventName.DungeonGuideChange);
		}

		// Token: 0x060399FC RID: 236028 RVA: 0x00DB1A16 File Offset: 0x00DAFC16
		public bool GetHaveGuide()
		{
			return this.CurrentInstanceDungeonGuideType != 0;
		}

		// Token: 0x17008A69 RID: 35433
		// (get) Token: 0x060399FD RID: 236029 RVA: 0x00DB1A21 File Offset: 0x00DAFC21
		public static InstanceDungeonGuideModel Instance
		{
			get
			{
				return InstanceDungeonGuideModel._Instance;
			}
		}

		// Token: 0x060399FE RID: 236030 RVA: 0x00DB1A28 File Offset: 0x00DAFC28
		public static InstanceDungeonGuideModel GetOrCreateInstance()
		{
			if (InstanceDungeonGuideModel._Instance == null)
			{
				InstanceDungeonGuideModel.CreateInstance();
			}
			return InstanceDungeonGuideModel._Instance;
		}

		// Token: 0x060399FF RID: 236031 RVA: 0x00DB1A3C File Offset: 0x00DAFC3C
		public static bool CreateInstance()
		{
			if (InstanceDungeonGuideModel._Instance != null)
			{
				return true;
			}
			InstanceDungeonGuideModel._Instance = new InstanceDungeonGuideModel();
			return true;
		}

		// Token: 0x06039A00 RID: 236032 RVA: 0x00DB1A52 File Offset: 0x00DAFC52
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039A01 RID: 236033 RVA: 0x00DB1A54 File Offset: 0x00DAFC54
		public static void ResetStaticDefaultValue()
		{
			InstanceDungeonGuideModel._Instance = null;
		}

		// Token: 0x06039A02 RID: 236034 RVA: 0x00DB1A5C File Offset: 0x00DAFC5C
		static InstanceDungeonGuideModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InstanceDungeonGuideModel.CreateStaticDefaultValue), new Action(InstanceDungeonGuideModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401E1E4 RID: 123364
		private int CurrentInstanceDungeonGuideType;

		// Token: 0x0401E1E5 RID: 123365
		private int CurrentInstanceDungeonGuideValue;

		// Token: 0x0401E1E6 RID: 123366
		[Nullable(2)]
		private static InstanceDungeonGuideModel _Instance;
	}
}

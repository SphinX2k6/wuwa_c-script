using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x0200484F RID: 18511
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceDungeonGuideModel : ModelBase
	{
		// Token: 0x0602E91A RID: 190746 RVA: 0x00D0088C File Offset: 0x00CFEA8C
		public int GetCurrentInstanceDungeonGuideType()
		{
			return this.CurrentInstanceDungeonGuideType;
		}

		// Token: 0x0602E91B RID: 190747 RVA: 0x00D00894 File Offset: 0x00CFEA94
		public int GetCurrentInstanceDungeonGuideValue()
		{
			return this.CurrentInstanceDungeonGuideValue;
		}

		// Token: 0x0602E91C RID: 190748 RVA: 0x00D0089C File Offset: 0x00CFEA9C
		public void RefreshCurrentDungeonGuide()
		{
			ValueTuple<int, int> guide = InstanceDungeonConfig.Instance.GetGuide(CreatureModel.Instance.GetInstanceId());
			this.CurrentInstanceDungeonGuideType = guide.Item1;
			this.CurrentInstanceDungeonGuideValue = guide.Item2;
			EventSystem.Instance.Emit(EEventName.DungeonGuideChange);
		}

		// Token: 0x0602E91D RID: 190749 RVA: 0x00D008E6 File Offset: 0x00CFEAE6
		public bool GetHaveGuide()
		{
			return this.CurrentInstanceDungeonGuideType != 0;
		}

		// Token: 0x17005E35 RID: 24117
		// (get) Token: 0x0602E91E RID: 190750 RVA: 0x00D008F1 File Offset: 0x00CFEAF1
		public static InstanceDungeonGuideModel Instance
		{
			get
			{
				return InstanceDungeonGuideModel._Instance;
			}
		}

		// Token: 0x0602E91F RID: 190751 RVA: 0x00D008F8 File Offset: 0x00CFEAF8
		public static InstanceDungeonGuideModel GetOrCreateInstance()
		{
			if (InstanceDungeonGuideModel._Instance == null)
			{
				InstanceDungeonGuideModel.CreateInstance();
			}
			return InstanceDungeonGuideModel._Instance;
		}

		// Token: 0x0602E920 RID: 190752 RVA: 0x00D0090C File Offset: 0x00CFEB0C
		public static bool CreateInstance()
		{
			if (InstanceDungeonGuideModel._Instance != null)
			{
				return true;
			}
			InstanceDungeonGuideModel._Instance = new InstanceDungeonGuideModel();
			return true;
		}

		// Token: 0x0602E921 RID: 190753 RVA: 0x00D00922 File Offset: 0x00CFEB22
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E922 RID: 190754 RVA: 0x00D00924 File Offset: 0x00CFEB24
		public static void ResetStaticDefaultValue()
		{
			InstanceDungeonGuideModel._Instance = null;
		}

		// Token: 0x0602E923 RID: 190755 RVA: 0x00D0092C File Offset: 0x00CFEB2C
		static InstanceDungeonGuideModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InstanceDungeonGuideModel.CreateStaticDefaultValue), new Action(InstanceDungeonGuideModel.ResetStaticDefaultValue));
		}

		// Token: 0x04018C81 RID: 101505
		private int CurrentInstanceDungeonGuideType;

		// Token: 0x04018C82 RID: 101506
		private int CurrentInstanceDungeonGuideValue;

		// Token: 0x04018C83 RID: 101507
		[Nullable(2)]
		private static InstanceDungeonGuideModel _Instance;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CAD RID: 23725
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class AlertMarkModel : ModelBase
	{
		// Token: 0x0603BEF5 RID: 245493 RVA: 0x00E5279B File Offset: 0x00E5099B
		public void AddPendingMarkInfo(int id, AActor trackActor, EAlertnessType type, float showDist)
		{
			this.PendingMarkInfos[id] = new ValueTuple<AActor, EAlertnessType, float>(trackActor, type, showDist);
		}

		// Token: 0x17008DF0 RID: 36336
		// (get) Token: 0x0603BEF6 RID: 245494 RVA: 0x00E527B2 File Offset: 0x00E509B2
		public static AlertMarkModel Instance
		{
			get
			{
				return AlertMarkModel._Instance;
			}
		}

		// Token: 0x0603BEF7 RID: 245495 RVA: 0x00E527B9 File Offset: 0x00E509B9
		public static AlertMarkModel GetOrCreateInstance()
		{
			if (AlertMarkModel._Instance == null)
			{
				AlertMarkModel.CreateInstance();
			}
			return AlertMarkModel._Instance;
		}

		// Token: 0x0603BEF8 RID: 245496 RVA: 0x00E527CD File Offset: 0x00E509CD
		public static bool CreateInstance()
		{
			if (AlertMarkModel._Instance != null)
			{
				return true;
			}
			AlertMarkModel._Instance = new AlertMarkModel();
			return true;
		}

		// Token: 0x0603BEF9 RID: 245497 RVA: 0x00E527E3 File Offset: 0x00E509E3
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603BEFA RID: 245498 RVA: 0x00E527E5 File Offset: 0x00E509E5
		public static void ResetStaticDefaultValue()
		{
			AlertMarkModel._Instance = null;
		}

		// Token: 0x0603BEFB RID: 245499 RVA: 0x00E527ED File Offset: 0x00E509ED
		static AlertMarkModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AlertMarkModel.CreateStaticDefaultValue), new Action(AlertMarkModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401F46C RID: 128108
		public bool AlertMarkInit;

		// Token: 0x0401F46D RID: 128109
		[TupleElementNames(new string[]
		{
			"trackActor",
			"type",
			"showDist"
		})]
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public readonly Dictionary<int, ValueTuple<AActor, EAlertnessType, float>> PendingMarkInfos = new Dictionary<int, ValueTuple<AActor, EAlertnessType, float>>();

		// Token: 0x0401F46E RID: 128110
		[Nullable(2)]
		private static AlertMarkModel _Instance;
	}
}

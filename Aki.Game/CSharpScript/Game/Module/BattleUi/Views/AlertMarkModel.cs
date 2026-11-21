using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004C8F RID: 19599
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class AlertMarkModel : ModelBase
	{
		// Token: 0x06030E48 RID: 200264 RVA: 0x00DA2E43 File Offset: 0x00DA1043
		public void AddPendingMarkInfo(int id, AActor trackActor, EAlertnessType type, float showDist)
		{
			this.PendingMarkInfos[id] = new ValueTuple<AActor, EAlertnessType, float>(trackActor, type, showDist);
		}

		// Token: 0x170061C2 RID: 25026
		// (get) Token: 0x06030E49 RID: 200265 RVA: 0x00DA2E5A File Offset: 0x00DA105A
		public static AlertMarkModel Instance
		{
			get
			{
				return AlertMarkModel._Instance;
			}
		}

		// Token: 0x06030E4A RID: 200266 RVA: 0x00DA2E61 File Offset: 0x00DA1061
		public static AlertMarkModel GetOrCreateInstance()
		{
			if (AlertMarkModel._Instance == null)
			{
				AlertMarkModel.CreateInstance();
			}
			return AlertMarkModel._Instance;
		}

		// Token: 0x06030E4B RID: 200267 RVA: 0x00DA2E75 File Offset: 0x00DA1075
		public static bool CreateInstance()
		{
			if (AlertMarkModel._Instance != null)
			{
				return true;
			}
			AlertMarkModel._Instance = new AlertMarkModel();
			return true;
		}

		// Token: 0x06030E4C RID: 200268 RVA: 0x00DA2E8B File Offset: 0x00DA108B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06030E4D RID: 200269 RVA: 0x00DA2E8D File Offset: 0x00DA108D
		public static void ResetStaticDefaultValue()
		{
			AlertMarkModel._Instance = null;
		}

		// Token: 0x06030E4E RID: 200270 RVA: 0x00DA2E95 File Offset: 0x00DA1095
		static AlertMarkModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AlertMarkModel.CreateStaticDefaultValue), new Action(AlertMarkModel.ResetStaticDefaultValue));
		}

		// Token: 0x04019F25 RID: 106277
		public bool AlertMarkInit;

		// Token: 0x04019F26 RID: 106278
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

		// Token: 0x04019F27 RID: 106279
		[Nullable(2)]
		private static AlertMarkModel _Instance;
	}
}

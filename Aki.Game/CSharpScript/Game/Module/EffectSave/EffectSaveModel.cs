using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.EffectSave
{
	// Token: 0x02005A8F RID: 23183
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class EffectSaveModel : ModelBase
	{
		// Token: 0x0603AB82 RID: 240514 RVA: 0x00DFCB62 File Offset: 0x00DFAD62
		protected override bool OnInit()
		{
			this.EffectSaveMap.Clear();
			return true;
		}

		// Token: 0x17008BFF RID: 35839
		// (get) Token: 0x0603AB83 RID: 240515 RVA: 0x00DFCB70 File Offset: 0x00DFAD70
		public static EffectSaveModel Instance
		{
			get
			{
				return EffectSaveModel._Instance;
			}
		}

		// Token: 0x0603AB84 RID: 240516 RVA: 0x00DFCB77 File Offset: 0x00DFAD77
		public static EffectSaveModel GetOrCreateInstance()
		{
			if (EffectSaveModel._Instance == null)
			{
				EffectSaveModel.CreateInstance();
			}
			return EffectSaveModel._Instance;
		}

		// Token: 0x0603AB85 RID: 240517 RVA: 0x00DFCB8B File Offset: 0x00DFAD8B
		public static bool CreateInstance()
		{
			if (EffectSaveModel._Instance != null)
			{
				return true;
			}
			EffectSaveModel._Instance = new EffectSaveModel();
			return true;
		}

		// Token: 0x0603AB86 RID: 240518 RVA: 0x00DFCBA1 File Offset: 0x00DFADA1
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603AB87 RID: 240519 RVA: 0x00DFCBA3 File Offset: 0x00DFADA3
		public static void ResetStaticDefaultValue()
		{
			EffectSaveModel._Instance = null;
		}

		// Token: 0x0603AB88 RID: 240520 RVA: 0x00DFCBAB File Offset: 0x00DFADAB
		static EffectSaveModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(EffectSaveModel.CreateStaticDefaultValue), new Action(EffectSaveModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401EA62 RID: 125538
		public FTransformDouble TempTransform = new FTransformDouble();

		// Token: 0x0401EA63 RID: 125539
		public FVectorDouble TempPosition = new FVectorDouble();

		// Token: 0x0401EA64 RID: 125540
		public FRotator TempRotation = new FRotator();

		// Token: 0x0401EA65 RID: 125541
		public Dictionary<long, int> EffectSaveMap = new Dictionary<long, int>();

		// Token: 0x0401EA66 RID: 125542
		[Nullable(2)]
		private static EffectSaveModel _Instance;
	}
}

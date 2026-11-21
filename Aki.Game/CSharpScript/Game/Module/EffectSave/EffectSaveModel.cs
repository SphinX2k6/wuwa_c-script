using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.EffectSave
{
	// Token: 0x02004A6B RID: 19051
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class EffectSaveModel : ModelBase
	{
		// Token: 0x0602FACB RID: 195275 RVA: 0x00D4D0F6 File Offset: 0x00D4B2F6
		protected override bool OnInit()
		{
			this.EffectSaveMap.Clear();
			return true;
		}

		// Token: 0x17005FCD RID: 24525
		// (get) Token: 0x0602FACC RID: 195276 RVA: 0x00D4D104 File Offset: 0x00D4B304
		public static EffectSaveModel Instance
		{
			get
			{
				return EffectSaveModel._Instance;
			}
		}

		// Token: 0x0602FACD RID: 195277 RVA: 0x00D4D10B File Offset: 0x00D4B30B
		public static EffectSaveModel GetOrCreateInstance()
		{
			if (EffectSaveModel._Instance == null)
			{
				EffectSaveModel.CreateInstance();
			}
			return EffectSaveModel._Instance;
		}

		// Token: 0x0602FACE RID: 195278 RVA: 0x00D4D11F File Offset: 0x00D4B31F
		public static bool CreateInstance()
		{
			if (EffectSaveModel._Instance != null)
			{
				return true;
			}
			EffectSaveModel._Instance = new EffectSaveModel();
			return true;
		}

		// Token: 0x0602FACF RID: 195279 RVA: 0x00D4D135 File Offset: 0x00D4B335
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602FAD0 RID: 195280 RVA: 0x00D4D137 File Offset: 0x00D4B337
		public static void ResetStaticDefaultValue()
		{
			EffectSaveModel._Instance = null;
		}

		// Token: 0x0602FAD1 RID: 195281 RVA: 0x00D4D13F File Offset: 0x00D4B33F
		static EffectSaveModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(EffectSaveModel.CreateStaticDefaultValue), new Action(EffectSaveModel.ResetStaticDefaultValue));
		}

		// Token: 0x04019509 RID: 103689
		public FTransformDouble TempTransform = new FTransformDouble();

		// Token: 0x0401950A RID: 103690
		public FVectorDouble TempPosition = new FVectorDouble();

		// Token: 0x0401950B RID: 103691
		public FRotator TempRotation = new FRotator();

		// Token: 0x0401950C RID: 103692
		public Dictionary<long, int> EffectSaveMap = new Dictionary<long, int>();

		// Token: 0x0401950D RID: 103693
		[Nullable(2)]
		private static EffectSaveModel _Instance;
	}
}

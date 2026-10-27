using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Blueprints;
using AkiClient.Game.Aki.Character.Input.Enum;
using AkiClient.Game.Aki.Character.Input.Structures;
using UnrealEngine;

namespace CSharpScript.Game.Input
{
	// Token: 0x02006FCE RID: 28622
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class InputLayer : IStaticVariableResetter
	{
		// Token: 0x060459BE RID: 285118 RVA: 0x01149DD9 File Offset: 0x01147FD9
		static InputLayer()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InputLayer.CreateStaticDefaultValue), new Action(InputLayer.ResetStaticDefaultValue));
		}

		// Token: 0x060459BF RID: 285119 RVA: 0x01149DF8 File Offset: 0x01147FF8
		public virtual void Clear()
		{
		}

		// Token: 0x060459C0 RID: 285120 RVA: 0x01149DFA File Offset: 0x01147FFA
		public virtual EInputLayer GetLayerType()
		{
			return EInputLayer.None;
		}

		// Token: 0x060459C1 RID: 285121 RVA: 0x01149DFD File Offset: 0x01147FFD
		public virtual BP_InputBase_C GetBpInputComp()
		{
			return null;
		}

		// Token: 0x060459C2 RID: 285122 RVA: 0x01149E00 File Offset: 0x01148000
		[NullableContext(1)]
		public static SInputCommand GetSwallowCommand()
		{
			if (InputLayer.SwallowCommand == null)
			{
				InputLayer.SwallowCommand = new SInputCommand(ECommandType.Swallow, 0, default(FGameplayTag));
			}
			return InputLayer.SwallowCommand;
		}

		// Token: 0x060459C3 RID: 285123 RVA: 0x01149E3A File Offset: 0x0114803A
		public virtual SInputCommand HandlePress(EInputAction action, float time)
		{
			return null;
		}

		// Token: 0x060459C4 RID: 285124 RVA: 0x01149E3D File Offset: 0x0114803D
		public virtual SInputCommand HandleRelease(EInputAction action, float time)
		{
			return null;
		}

		// Token: 0x060459C5 RID: 285125 RVA: 0x01149E40 File Offset: 0x01148040
		public virtual SInputCommand HandleHold(EInputAction action, float time)
		{
			return null;
		}

		// Token: 0x060459C6 RID: 285126 RVA: 0x01149E43 File Offset: 0x01148043
		public virtual void DispatchPressEvent(EInputAction action, float time)
		{
		}

		// Token: 0x060459C7 RID: 285127 RVA: 0x01149E45 File Offset: 0x01148045
		public virtual void DispatchReleaseEvent(EInputAction action, float time)
		{
		}

		// Token: 0x060459C8 RID: 285128 RVA: 0x01149E47 File Offset: 0x01148047
		public virtual bool CheckBlockDispatchEvent(EInputAction action)
		{
			return false;
		}

		// Token: 0x060459C9 RID: 285129 RVA: 0x01149E4A File Offset: 0x0114804A
		public virtual SInputCommand HandlePressEx(EInputAction action, float time, float param = 0f)
		{
			return this.HandlePress(action, time);
		}

		// Token: 0x060459CA RID: 285130 RVA: 0x01149E54 File Offset: 0x01148054
		public virtual SInputCommand HandleReleaseEx(EInputAction action, float time, float param = 0f)
		{
			return this.HandleRelease(action, time);
		}

		// Token: 0x060459CB RID: 285131 RVA: 0x01149E5E File Offset: 0x0114805E
		public virtual SInputCommand HandleHoldEx(EInputAction action, float time, float param = 0f)
		{
			return this.HandleHold(action, time);
		}

		// Token: 0x060459CC RID: 285132 RVA: 0x01149E68 File Offset: 0x01148068
		public virtual void DispatchPressEventEx(EInputAction action, float time, float param = 0f)
		{
			this.DispatchPressEvent(action, time);
		}

		// Token: 0x060459CD RID: 285133 RVA: 0x01149E72 File Offset: 0x01148072
		public virtual void DispatchReleaseEventEx(EInputAction action, float time, float param = 0f)
		{
			this.DispatchReleaseEvent(action, time);
		}

		// Token: 0x060459CE RID: 285134 RVA: 0x01149E7C File Offset: 0x0114807C
		public static void CreateStaticDefaultValue()
		{
			InputLayer.IsTestMode = false;
		}

		// Token: 0x060459CF RID: 285135 RVA: 0x01149E84 File Offset: 0x01148084
		public static void ResetStaticDefaultValue()
		{
			InputLayer.IsTestMode = false;
			InputLayer.SwallowCommand = null;
		}

		// Token: 0x04024566 RID: 148838
		public int UnitId;

		// Token: 0x04024567 RID: 148839
		public static bool IsTestMode;

		// Token: 0x04024568 RID: 148840
		protected static SInputCommand SwallowCommand;
	}
}

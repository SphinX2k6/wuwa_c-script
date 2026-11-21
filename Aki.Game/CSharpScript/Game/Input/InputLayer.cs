using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Blueprints;
using AkiClient.Game.Aki.Character.Input.Enum;
using AkiClient.Game.Aki.Character.Input.Structures;

namespace CSharpScript.Game.Input
{
	// Token: 0x0200614F RID: 24911
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class InputLayer : IStaticVariableResetter
	{
		// Token: 0x0603BB6E RID: 244590 RVA: 0x010F3BD1 File Offset: 0x010F1DD1
		static InputLayer()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InputLayer.CreateStaticDefaultValue), new Action(InputLayer.ResetStaticDefaultValue));
		}

		// Token: 0x0603BB6F RID: 244591 RVA: 0x010F3BF0 File Offset: 0x010F1DF0
		public virtual void Clear()
		{
		}

		// Token: 0x0603BB70 RID: 244592 RVA: 0x010F3BF2 File Offset: 0x010F1DF2
		public virtual EInputLayer GetLayerType()
		{
			return EInputLayer.None;
		}

		// Token: 0x0603BB71 RID: 244593 RVA: 0x010F3BF5 File Offset: 0x010F1DF5
		public virtual BP_InputBase_C GetBpInputComp()
		{
			return null;
		}

		// Token: 0x0603BB72 RID: 244594 RVA: 0x010F3BF8 File Offset: 0x010F1DF8
		public virtual BP_InputBase_C GetBpInputComp(EInputAction action, EInputState state)
		{
			return this.GetBpInputComp();
		}

		// Token: 0x0603BB73 RID: 244595 RVA: 0x010F3C00 File Offset: 0x010F1E00
		[NullableContext(1)]
		public static SInputCommand GetSwallowCommand()
		{
			if (InputLayer.SwallowCommand == null)
			{
				InputLayer.SwallowCommand = new SInputCommand
				{
					CommandType = ECommandType.Swallow
				};
			}
			return InputLayer.SwallowCommand;
		}

		// Token: 0x0603BB74 RID: 244596 RVA: 0x010F3C2B File Offset: 0x010F1E2B
		public virtual SInputCommand HandlePress(EInputAction action, float time)
		{
			return null;
		}

		// Token: 0x0603BB75 RID: 244597 RVA: 0x010F3C2E File Offset: 0x010F1E2E
		public virtual SInputCommand HandleRelease(EInputAction action, float time)
		{
			return null;
		}

		// Token: 0x0603BB76 RID: 244598 RVA: 0x010F3C31 File Offset: 0x010F1E31
		public virtual SInputCommand HandleHold(EInputAction action, float time)
		{
			return null;
		}

		// Token: 0x0603BB77 RID: 244599 RVA: 0x010F3C34 File Offset: 0x010F1E34
		public virtual bool DispatchPressEvent(EInputAction action, float time)
		{
			return false;
		}

		// Token: 0x0603BB78 RID: 244600 RVA: 0x010F3C37 File Offset: 0x010F1E37
		public virtual bool DispatchReleaseEvent(EInputAction action, float time)
		{
			return false;
		}

		// Token: 0x0603BB79 RID: 244601 RVA: 0x010F3C3A File Offset: 0x010F1E3A
		public virtual SInputCommand HandlePressEx(EInputAction action, float time, float param = 0f)
		{
			return this.HandlePress(action, time);
		}

		// Token: 0x0603BB7A RID: 244602 RVA: 0x010F3C44 File Offset: 0x010F1E44
		public virtual SInputCommand HandleReleaseEx(EInputAction action, float time, float param = 0f)
		{
			return this.HandleRelease(action, time);
		}

		// Token: 0x0603BB7B RID: 244603 RVA: 0x010F3C4E File Offset: 0x010F1E4E
		public virtual SInputCommand HandleHoldEx(EInputAction action, float time, float param = 0f)
		{
			return this.HandleHold(action, time);
		}

		// Token: 0x0603BB7C RID: 244604 RVA: 0x010F3C58 File Offset: 0x010F1E58
		public virtual bool DispatchPressEventEx(EInputAction action, float time, float param = 0f)
		{
			return this.DispatchPressEvent(action, time);
		}

		// Token: 0x0603BB7D RID: 244605 RVA: 0x010F3C62 File Offset: 0x010F1E62
		public virtual bool DispatchReleaseEventEx(EInputAction action, float time, float param = 0f)
		{
			return this.DispatchReleaseEvent(action, time);
		}

		// Token: 0x0603BB7E RID: 244606 RVA: 0x010F3C6C File Offset: 0x010F1E6C
		public virtual bool IsCheckHoldConfigTime(EInputAction action)
		{
			return true;
		}

		// Token: 0x0603BB7F RID: 244607 RVA: 0x010F3C6F File Offset: 0x010F1E6F
		public static void CreateStaticDefaultValue()
		{
			InputLayer.IsTestMode = false;
		}

		// Token: 0x0603BB80 RID: 244608 RVA: 0x010F3C77 File Offset: 0x010F1E77
		public static void ResetStaticDefaultValue()
		{
			InputLayer.IsTestMode = false;
			InputLayer.SwallowCommand = null;
		}

		// Token: 0x0401F81B RID: 129051
		public int UnitId;

		// Token: 0x0401F81C RID: 129052
		public static bool IsTestMode;

		// Token: 0x0401F81D RID: 129053
		protected static SInputCommand SwallowCommand;
	}
}

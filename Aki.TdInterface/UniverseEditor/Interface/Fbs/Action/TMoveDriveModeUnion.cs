using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F52 RID: 32594
	public class TMoveDriveModeUnion
	{
		// Token: 0x1700F2AF RID: 62127
		// (get) Token: 0x0603AC47 RID: 240711 RVA: 0x007E69E2 File Offset: 0x007E4BE2
		// (set) Token: 0x0603AC48 RID: 240712 RVA: 0x007E69EA File Offset: 0x007E4BEA
		public TMoveDriveMode Type { get; set; }

		// Token: 0x1700F2B0 RID: 62128
		// (get) Token: 0x0603AC49 RID: 240713 RVA: 0x007E69F3 File Offset: 0x007E4BF3
		// (set) Token: 0x0603AC4A RID: 240714 RVA: 0x007E69FB File Offset: 0x007E4BFB
		public object Value { get; set; }

		// Token: 0x0603AC4B RID: 240715 RVA: 0x007E6A04 File Offset: 0x007E4C04
		public TMoveDriveModeUnion()
		{
			this.Type = TMoveDriveMode.NONE;
			this.Value = null;
		}

		// Token: 0x0603AC4C RID: 240716 RVA: 0x007E6A1A File Offset: 0x007E4C1A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AC4D RID: 240717 RVA: 0x007E6A2C File Offset: 0x007E4C2C
		public IInputDrivenMoveDriveModeT AsIInputDrivenMoveDriveMode()
		{
			return this.As<IInputDrivenMoveDriveModeT>();
		}

		// Token: 0x0603AC4E RID: 240718 RVA: 0x007E6A34 File Offset: 0x007E4C34
		public static TMoveDriveModeUnion FromIInputDrivenMoveDriveMode(IInputDrivenMoveDriveModeT _iinputdrivenmovedrivemode)
		{
			return new TMoveDriveModeUnion
			{
				Type = TMoveDriveMode.IInputDrivenMoveDriveMode,
				Value = _iinputdrivenmovedrivemode
			};
		}

		// Token: 0x0603AC4F RID: 240719 RVA: 0x007E6A49 File Offset: 0x007E4C49
		public IPositionDrivenMoveDriveModeT AsIPositionDrivenMoveDriveMode()
		{
			return this.As<IPositionDrivenMoveDriveModeT>();
		}

		// Token: 0x0603AC50 RID: 240720 RVA: 0x007E6A51 File Offset: 0x007E4C51
		public static TMoveDriveModeUnion FromIPositionDrivenMoveDriveMode(IPositionDrivenMoveDriveModeT _ipositiondrivenmovedrivemode)
		{
			return new TMoveDriveModeUnion
			{
				Type = TMoveDriveMode.IPositionDrivenMoveDriveMode,
				Value = _ipositiondrivenmovedrivemode
			};
		}

		// Token: 0x0603AC51 RID: 240721 RVA: 0x007E6A68 File Offset: 0x007E4C68
		public static int Pack(FlatBufferBuilder builder, TMoveDriveModeUnion _o)
		{
			TMoveDriveMode type = _o.Type;
			if (type == TMoveDriveMode.IInputDrivenMoveDriveMode)
			{
				return IInputDrivenMoveDriveMode.Pack(builder, _o.AsIInputDrivenMoveDriveMode()).Value;
			}
			if (type != TMoveDriveMode.IPositionDrivenMoveDriveMode)
			{
				return 0;
			}
			return IPositionDrivenMoveDriveMode.Pack(builder, _o.AsIPositionDrivenMoveDriveMode()).Value;
		}
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007729 RID: 30505
	public class TMoveDriveModeUnion
	{
		// Token: 0x1700E65F RID: 58975
		// (get) Token: 0x0603770C RID: 227084 RVA: 0x00781A52 File Offset: 0x0077FC52
		// (set) Token: 0x0603770D RID: 227085 RVA: 0x00781A5A File Offset: 0x0077FC5A
		public TMoveDriveMode Type { get; set; }

		// Token: 0x1700E660 RID: 58976
		// (get) Token: 0x0603770E RID: 227086 RVA: 0x00781A63 File Offset: 0x0077FC63
		// (set) Token: 0x0603770F RID: 227087 RVA: 0x00781A6B File Offset: 0x0077FC6B
		public object Value { get; set; }

		// Token: 0x06037710 RID: 227088 RVA: 0x00781A74 File Offset: 0x0077FC74
		public TMoveDriveModeUnion()
		{
			this.Type = TMoveDriveMode.NONE;
			this.Value = null;
		}

		// Token: 0x06037711 RID: 227089 RVA: 0x00781A8A File Offset: 0x0077FC8A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037712 RID: 227090 RVA: 0x00781A9C File Offset: 0x0077FC9C
		public IInputDrivenMoveDriveModeT AsIInputDrivenMoveDriveMode()
		{
			return this.As<IInputDrivenMoveDriveModeT>();
		}

		// Token: 0x06037713 RID: 227091 RVA: 0x00781AA4 File Offset: 0x0077FCA4
		public static TMoveDriveModeUnion FromIInputDrivenMoveDriveMode(IInputDrivenMoveDriveModeT _iinputdrivenmovedrivemode)
		{
			return new TMoveDriveModeUnion
			{
				Type = TMoveDriveMode.IInputDrivenMoveDriveMode,
				Value = _iinputdrivenmovedrivemode
			};
		}

		// Token: 0x06037714 RID: 227092 RVA: 0x00781AB9 File Offset: 0x0077FCB9
		public IPositionDrivenMoveDriveModeT AsIPositionDrivenMoveDriveMode()
		{
			return this.As<IPositionDrivenMoveDriveModeT>();
		}

		// Token: 0x06037715 RID: 227093 RVA: 0x00781AC1 File Offset: 0x0077FCC1
		public static TMoveDriveModeUnion FromIPositionDrivenMoveDriveMode(IPositionDrivenMoveDriveModeT _ipositiondrivenmovedrivemode)
		{
			return new TMoveDriveModeUnion
			{
				Type = TMoveDriveMode.IPositionDrivenMoveDriveMode,
				Value = _ipositiondrivenmovedrivemode
			};
		}

		// Token: 0x06037716 RID: 227094 RVA: 0x00781AD8 File Offset: 0x0077FCD8
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

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007016 RID: 28694
	public struct IInputDrivenMoveDriveMode : IFlatbufferObject
	{
		// Token: 0x1700D218 RID: 53784
		// (get) Token: 0x06031B72 RID: 203634 RVA: 0x006BB548 File Offset: 0x006B9748
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031B73 RID: 203635 RVA: 0x006BB555 File Offset: 0x006B9755
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031B74 RID: 203636 RVA: 0x006BB55C File Offset: 0x006B975C
		public static IInputDrivenMoveDriveMode GetRootAsIInputDrivenMoveDriveMode(ByteBuffer _bb)
		{
			return IInputDrivenMoveDriveMode.GetRootAsIInputDrivenMoveDriveMode(_bb, default(IInputDrivenMoveDriveMode));
		}

		// Token: 0x06031B75 RID: 203637 RVA: 0x006BB578 File Offset: 0x006B9778
		public static IInputDrivenMoveDriveMode GetRootAsIInputDrivenMoveDriveMode(ByteBuffer _bb, IInputDrivenMoveDriveMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031B76 RID: 203638 RVA: 0x006BB595 File Offset: 0x006B9795
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031B77 RID: 203639 RVA: 0x006BB5A4 File Offset: 0x006B97A4
		public IInputDrivenMoveDriveMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D219 RID: 53785
		// (get) Token: 0x06031B78 RID: 203640 RVA: 0x006BB5B4 File Offset: 0x006B97B4
		public ESplineMoveDriveMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESplineMoveDriveMode.InputDriven;
				}
				return (ESplineMoveDriveMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031B79 RID: 203641 RVA: 0x006BB5F0 File Offset: 0x006B97F0
		public static Offset<IInputDrivenMoveDriveMode> CreateIInputDrivenMoveDriveMode(FlatBufferBuilder builder, ESplineMoveDriveMode Type = ESplineMoveDriveMode.InputDriven)
		{
			builder.StartTable(1);
			IInputDrivenMoveDriveMode.AddType(builder, Type);
			return IInputDrivenMoveDriveMode.EndIInputDrivenMoveDriveMode(builder);
		}

		// Token: 0x06031B7A RID: 203642 RVA: 0x006BB606 File Offset: 0x006B9806
		public static void StartIInputDrivenMoveDriveMode(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031B7B RID: 203643 RVA: 0x006BB60F File Offset: 0x006B980F
		public static void AddType(FlatBufferBuilder builder, ESplineMoveDriveMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031B7C RID: 203644 RVA: 0x006BB61A File Offset: 0x006B981A
		public static Offset<IInputDrivenMoveDriveMode> EndIInputDrivenMoveDriveMode(FlatBufferBuilder builder)
		{
			return new Offset<IInputDrivenMoveDriveMode>(builder.EndTable());
		}

		// Token: 0x06031B7D RID: 203645 RVA: 0x006BB628 File Offset: 0x006B9828
		public IInputDrivenMoveDriveModeT UnPack()
		{
			IInputDrivenMoveDriveModeT inputDrivenMoveDriveModeT = new IInputDrivenMoveDriveModeT();
			this.UnPackTo(inputDrivenMoveDriveModeT);
			return inputDrivenMoveDriveModeT;
		}

		// Token: 0x06031B7E RID: 203646 RVA: 0x006BB643 File Offset: 0x006B9843
		public void UnPackTo(IInputDrivenMoveDriveModeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031B7F RID: 203647 RVA: 0x006BB654 File Offset: 0x006B9854
		public static Offset<IInputDrivenMoveDriveMode> Pack(FlatBufferBuilder builder, IInputDrivenMoveDriveModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInputDrivenMoveDriveMode>);
			}
			return IInputDrivenMoveDriveMode.CreateIInputDrivenMoveDriveMode(builder, _o.Type);
		}

		// Token: 0x04011F52 RID: 73554
		private Table __p;
	}
}

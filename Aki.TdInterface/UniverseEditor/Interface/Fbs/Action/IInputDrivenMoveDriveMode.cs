using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006963 RID: 26979
	public struct IInputDrivenMoveDriveMode : IFlatbufferObject
	{
		// Token: 0x1700C815 RID: 51221
		// (get) Token: 0x0602F1A2 RID: 192930 RVA: 0x0066B060 File Offset: 0x00669260
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F1A3 RID: 192931 RVA: 0x0066B06D File Offset: 0x0066926D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F1A4 RID: 192932 RVA: 0x0066B074 File Offset: 0x00669274
		public static IInputDrivenMoveDriveMode GetRootAsIInputDrivenMoveDriveMode(ByteBuffer _bb)
		{
			return IInputDrivenMoveDriveMode.GetRootAsIInputDrivenMoveDriveMode(_bb, default(IInputDrivenMoveDriveMode));
		}

		// Token: 0x0602F1A5 RID: 192933 RVA: 0x0066B090 File Offset: 0x00669290
		public static IInputDrivenMoveDriveMode GetRootAsIInputDrivenMoveDriveMode(ByteBuffer _bb, IInputDrivenMoveDriveMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F1A6 RID: 192934 RVA: 0x0066B0AD File Offset: 0x006692AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F1A7 RID: 192935 RVA: 0x0066B0BC File Offset: 0x006692BC
		public IInputDrivenMoveDriveMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C816 RID: 51222
		// (get) Token: 0x0602F1A8 RID: 192936 RVA: 0x0066B0CC File Offset: 0x006692CC
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

		// Token: 0x0602F1A9 RID: 192937 RVA: 0x0066B108 File Offset: 0x00669308
		public static Offset<IInputDrivenMoveDriveMode> CreateIInputDrivenMoveDriveMode(FlatBufferBuilder builder, ESplineMoveDriveMode Type = ESplineMoveDriveMode.InputDriven)
		{
			builder.StartTable(1);
			IInputDrivenMoveDriveMode.AddType(builder, Type);
			return IInputDrivenMoveDriveMode.EndIInputDrivenMoveDriveMode(builder);
		}

		// Token: 0x0602F1AA RID: 192938 RVA: 0x0066B11E File Offset: 0x0066931E
		public static void StartIInputDrivenMoveDriveMode(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F1AB RID: 192939 RVA: 0x0066B127 File Offset: 0x00669327
		public static void AddType(FlatBufferBuilder builder, ESplineMoveDriveMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F1AC RID: 192940 RVA: 0x0066B132 File Offset: 0x00669332
		public static Offset<IInputDrivenMoveDriveMode> EndIInputDrivenMoveDriveMode(FlatBufferBuilder builder)
		{
			return new Offset<IInputDrivenMoveDriveMode>(builder.EndTable());
		}

		// Token: 0x0602F1AD RID: 192941 RVA: 0x0066B140 File Offset: 0x00669340
		public IInputDrivenMoveDriveModeT UnPack()
		{
			IInputDrivenMoveDriveModeT inputDrivenMoveDriveModeT = new IInputDrivenMoveDriveModeT();
			this.UnPackTo(inputDrivenMoveDriveModeT);
			return inputDrivenMoveDriveModeT;
		}

		// Token: 0x0602F1AE RID: 192942 RVA: 0x0066B15B File Offset: 0x0066935B
		public void UnPackTo(IInputDrivenMoveDriveModeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F1AF RID: 192943 RVA: 0x0066B16C File Offset: 0x0066936C
		public static Offset<IInputDrivenMoveDriveMode> Pack(FlatBufferBuilder builder, IInputDrivenMoveDriveModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInputDrivenMoveDriveMode>);
			}
			return IInputDrivenMoveDriveMode.CreateIInputDrivenMoveDriveMode(builder, _o.Type);
		}

		// Token: 0x040110E6 RID: 69862
		private Table __p;
	}
}

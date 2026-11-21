using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074E3 RID: 29923
	public struct IPositionDrivenMoveDriveMode : IFlatbufferObject
	{
		// Token: 0x1700DC32 RID: 56370
		// (get) Token: 0x06034758 RID: 214872 RVA: 0x007101C8 File Offset: 0x0070E3C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034759 RID: 214873 RVA: 0x007101D5 File Offset: 0x0070E3D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603475A RID: 214874 RVA: 0x007101DC File Offset: 0x0070E3DC
		public static IPositionDrivenMoveDriveMode GetRootAsIPositionDrivenMoveDriveMode(ByteBuffer _bb)
		{
			return IPositionDrivenMoveDriveMode.GetRootAsIPositionDrivenMoveDriveMode(_bb, default(IPositionDrivenMoveDriveMode));
		}

		// Token: 0x0603475B RID: 214875 RVA: 0x007101F8 File Offset: 0x0070E3F8
		public static IPositionDrivenMoveDriveMode GetRootAsIPositionDrivenMoveDriveMode(ByteBuffer _bb, IPositionDrivenMoveDriveMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603475C RID: 214876 RVA: 0x00710215 File Offset: 0x0070E415
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603475D RID: 214877 RVA: 0x00710224 File Offset: 0x0070E424
		public IPositionDrivenMoveDriveMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DC33 RID: 56371
		// (get) Token: 0x0603475E RID: 214878 RVA: 0x00710234 File Offset: 0x0070E434
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

		// Token: 0x1700DC34 RID: 56372
		// (get) Token: 0x0603475F RID: 214879 RVA: 0x00710270 File Offset: 0x0070E470
		public bool IsFixedPitch
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DC35 RID: 56373
		// (get) Token: 0x06034760 RID: 214880 RVA: 0x007102B0 File Offset: 0x0070E4B0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034761 RID: 214881 RVA: 0x007102EC File Offset: 0x0070E4EC
		public static Offset<IPositionDrivenMoveDriveMode> CreateIPositionDrivenMoveDriveMode(FlatBufferBuilder builder, ESplineMoveDriveMode Type = ESplineMoveDriveMode.InputDriven, bool IsFixedPitch = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IPositionDrivenMoveDriveMode.AddNullMask(builder, NullMask);
			IPositionDrivenMoveDriveMode.AddIsFixedPitch(builder, IsFixedPitch);
			IPositionDrivenMoveDriveMode.AddType(builder, Type);
			return IPositionDrivenMoveDriveMode.EndIPositionDrivenMoveDriveMode(builder);
		}

		// Token: 0x06034762 RID: 214882 RVA: 0x00710310 File Offset: 0x0070E510
		public static void StartIPositionDrivenMoveDriveMode(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06034763 RID: 214883 RVA: 0x00710319 File Offset: 0x0070E519
		public static void AddType(FlatBufferBuilder builder, ESplineMoveDriveMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034764 RID: 214884 RVA: 0x00710324 File Offset: 0x0070E524
		public static void AddIsFixedPitch(FlatBufferBuilder builder, bool isFixedPitch)
		{
			builder.AddBool(1, isFixedPitch, false);
		}

		// Token: 0x06034765 RID: 214885 RVA: 0x0071032F File Offset: 0x0070E52F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06034766 RID: 214886 RVA: 0x0071033A File Offset: 0x0070E53A
		public static Offset<IPositionDrivenMoveDriveMode> EndIPositionDrivenMoveDriveMode(FlatBufferBuilder builder)
		{
			return new Offset<IPositionDrivenMoveDriveMode>(builder.EndTable());
		}

		// Token: 0x06034767 RID: 214887 RVA: 0x00710348 File Offset: 0x0070E548
		public IPositionDrivenMoveDriveModeT UnPack()
		{
			IPositionDrivenMoveDriveModeT positionDrivenMoveDriveModeT = new IPositionDrivenMoveDriveModeT();
			this.UnPackTo(positionDrivenMoveDriveModeT);
			return positionDrivenMoveDriveModeT;
		}

		// Token: 0x06034768 RID: 214888 RVA: 0x00710363 File Offset: 0x0070E563
		public void UnPackTo(IPositionDrivenMoveDriveModeT _o)
		{
			_o.Type = this.Type;
			_o.IsFixedPitch = this.IsFixedPitch;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06034769 RID: 214889 RVA: 0x0071038C File Offset: 0x0070E58C
		public static Offset<IPositionDrivenMoveDriveMode> Pack(FlatBufferBuilder builder, IPositionDrivenMoveDriveModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPositionDrivenMoveDriveMode>);
			}
			return IPositionDrivenMoveDriveMode.CreateIPositionDrivenMoveDriveMode(builder, _o.Type, _o.IsFixedPitch, _o.NullMask);
		}

		// Token: 0x040126A1 RID: 75425
		private Table __p;
	}
}

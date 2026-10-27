using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006439 RID: 25657
	public struct ICloseSplineMovePattern : IFlatbufferObject
	{
		// Token: 0x1700BF0C RID: 48908
		// (get) Token: 0x0602C67C RID: 181884 RVA: 0x00617B7C File Offset: 0x00615D7C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C67D RID: 181885 RVA: 0x00617B89 File Offset: 0x00615D89
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C67E RID: 181886 RVA: 0x00617B90 File Offset: 0x00615D90
		public static ICloseSplineMovePattern GetRootAsICloseSplineMovePattern(ByteBuffer _bb)
		{
			return ICloseSplineMovePattern.GetRootAsICloseSplineMovePattern(_bb, default(ICloseSplineMovePattern));
		}

		// Token: 0x0602C67F RID: 181887 RVA: 0x00617BAC File Offset: 0x00615DAC
		public static ICloseSplineMovePattern GetRootAsICloseSplineMovePattern(ByteBuffer _bb, ICloseSplineMovePattern obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C680 RID: 181888 RVA: 0x00617BC9 File Offset: 0x00615DC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C681 RID: 181889 RVA: 0x00617BD8 File Offset: 0x00615DD8
		public ICloseSplineMovePattern __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF0D RID: 48909
		// (get) Token: 0x0602C682 RID: 181890 RVA: 0x00617BE8 File Offset: 0x00615DE8
		public ESplineMovePattern Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESplineMovePattern.PathLine;
				}
				return (ESplineMovePattern)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BF0E RID: 48910
		// (get) Token: 0x0602C683 RID: 181891 RVA: 0x00617C24 File Offset: 0x00615E24
		public float GravitySwitchAngularVelocity
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BF0F RID: 48911
		// (get) Token: 0x0602C684 RID: 181892 RVA: 0x00617C64 File Offset: 0x00615E64
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

		// Token: 0x0602C685 RID: 181893 RVA: 0x00617CA0 File Offset: 0x00615EA0
		public static Offset<ICloseSplineMovePattern> CreateICloseSplineMovePattern(FlatBufferBuilder builder, ESplineMovePattern Type = ESplineMovePattern.PathLine, float GravitySwitchAngularVelocity = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			ICloseSplineMovePattern.AddGravitySwitchAngularVelocity(builder, GravitySwitchAngularVelocity);
			ICloseSplineMovePattern.AddNullMask(builder, NullMask);
			ICloseSplineMovePattern.AddType(builder, Type);
			return ICloseSplineMovePattern.EndICloseSplineMovePattern(builder);
		}

		// Token: 0x0602C686 RID: 181894 RVA: 0x00617CC4 File Offset: 0x00615EC4
		public static void StartICloseSplineMovePattern(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602C687 RID: 181895 RVA: 0x00617CCD File Offset: 0x00615ECD
		public static void AddType(FlatBufferBuilder builder, ESplineMovePattern type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C688 RID: 181896 RVA: 0x00617CD8 File Offset: 0x00615ED8
		public static void AddGravitySwitchAngularVelocity(FlatBufferBuilder builder, float gravitySwitchAngularVelocity)
		{
			builder.AddFloat(1, gravitySwitchAngularVelocity, 0.0);
		}

		// Token: 0x0602C689 RID: 181897 RVA: 0x00617CEB File Offset: 0x00615EEB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602C68A RID: 181898 RVA: 0x00617CF6 File Offset: 0x00615EF6
		public static Offset<ICloseSplineMovePattern> EndICloseSplineMovePattern(FlatBufferBuilder builder)
		{
			return new Offset<ICloseSplineMovePattern>(builder.EndTable());
		}

		// Token: 0x0602C68B RID: 181899 RVA: 0x00617D04 File Offset: 0x00615F04
		public ICloseSplineMovePatternT UnPack()
		{
			ICloseSplineMovePatternT closeSplineMovePatternT = new ICloseSplineMovePatternT();
			this.UnPackTo(closeSplineMovePatternT);
			return closeSplineMovePatternT;
		}

		// Token: 0x0602C68C RID: 181900 RVA: 0x00617D1F File Offset: 0x00615F1F
		public void UnPackTo(ICloseSplineMovePatternT _o)
		{
			_o.Type = this.Type;
			_o.GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602C68D RID: 181901 RVA: 0x00617D48 File Offset: 0x00615F48
		public static Offset<ICloseSplineMovePattern> Pack(FlatBufferBuilder builder, ICloseSplineMovePatternT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICloseSplineMovePattern>);
			}
			return ICloseSplineMovePattern.CreateICloseSplineMovePattern(builder, _o.Type, _o.GravitySwitchAngularVelocity, _o.NullMask);
		}

		// Token: 0x04010A2C RID: 68140
		private Table __p;
	}
}

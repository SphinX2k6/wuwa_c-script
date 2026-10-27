using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200718A RID: 29066
	public struct ISplineMovePattern : IFlatbufferObject
	{
		// Token: 0x1700D7DF RID: 55263
		// (get) Token: 0x06033874 RID: 211060 RVA: 0x006F0D5C File Offset: 0x006EEF5C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033875 RID: 211061 RVA: 0x006F0D69 File Offset: 0x006EEF69
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033876 RID: 211062 RVA: 0x006F0D70 File Offset: 0x006EEF70
		public static ISplineMovePattern GetRootAsISplineMovePattern(ByteBuffer _bb)
		{
			return ISplineMovePattern.GetRootAsISplineMovePattern(_bb, default(ISplineMovePattern));
		}

		// Token: 0x06033877 RID: 211063 RVA: 0x006F0D8C File Offset: 0x006EEF8C
		public static ISplineMovePattern GetRootAsISplineMovePattern(ByteBuffer _bb, ISplineMovePattern obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033878 RID: 211064 RVA: 0x006F0DA9 File Offset: 0x006EEFA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033879 RID: 211065 RVA: 0x006F0DB8 File Offset: 0x006EEFB8
		public ISplineMovePattern __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D7E0 RID: 55264
		// (get) Token: 0x0603387A RID: 211066 RVA: 0x006F0DC8 File Offset: 0x006EEFC8
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

		// Token: 0x1700D7E1 RID: 55265
		// (get) Token: 0x0603387B RID: 211067 RVA: 0x006F0E04 File Offset: 0x006EF004
		public float MaxOffsetDistance
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

		// Token: 0x1700D7E2 RID: 55266
		// (get) Token: 0x0603387C RID: 211068 RVA: 0x006F0E44 File Offset: 0x006EF044
		public bool IsOneWay
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D7E3 RID: 55267
		// (get) Token: 0x0603387D RID: 211069 RVA: 0x006F0E84 File Offset: 0x006EF084
		public float LayerVerticalLimit
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D7E4 RID: 55268
		// (get) Token: 0x0603387E RID: 211070 RVA: 0x006F0EC8 File Offset: 0x006EF0C8
		public bool DynamicGravity
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D7E5 RID: 55269
		// (get) Token: 0x0603387F RID: 211071 RVA: 0x006F0F08 File Offset: 0x006EF108
		public float GravitySwitchAngularVelocity
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D7E6 RID: 55270
		// (get) Token: 0x06033880 RID: 211072 RVA: 0x006F0F4C File Offset: 0x006EF14C
		public int AutoExitDistance
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D7E7 RID: 55271
		// (get) Token: 0x06033881 RID: 211073 RVA: 0x006F0F8C File Offset: 0x006EF18C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033882 RID: 211074 RVA: 0x006F0FCC File Offset: 0x006EF1CC
		public static Offset<ISplineMovePattern> CreateISplineMovePattern(FlatBufferBuilder builder, ESplineMovePattern Type = ESplineMovePattern.PathLine, float MaxOffsetDistance = 0f, bool IsOneWay = false, float LayerVerticalLimit = 0f, bool DynamicGravity = false, float GravitySwitchAngularVelocity = 0f, int AutoExitDistance = 0, byte NullMask = 0)
		{
			builder.StartTable(8);
			ISplineMovePattern.AddAutoExitDistance(builder, AutoExitDistance);
			ISplineMovePattern.AddGravitySwitchAngularVelocity(builder, GravitySwitchAngularVelocity);
			ISplineMovePattern.AddLayerVerticalLimit(builder, LayerVerticalLimit);
			ISplineMovePattern.AddMaxOffsetDistance(builder, MaxOffsetDistance);
			ISplineMovePattern.AddNullMask(builder, NullMask);
			ISplineMovePattern.AddDynamicGravity(builder, DynamicGravity);
			ISplineMovePattern.AddIsOneWay(builder, IsOneWay);
			ISplineMovePattern.AddType(builder, Type);
			return ISplineMovePattern.EndISplineMovePattern(builder);
		}

		// Token: 0x06033883 RID: 211075 RVA: 0x006F1023 File Offset: 0x006EF223
		public static void StartISplineMovePattern(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06033884 RID: 211076 RVA: 0x006F102C File Offset: 0x006EF22C
		public static void AddType(FlatBufferBuilder builder, ESplineMovePattern type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033885 RID: 211077 RVA: 0x006F1037 File Offset: 0x006EF237
		public static void AddMaxOffsetDistance(FlatBufferBuilder builder, float maxOffsetDistance)
		{
			builder.AddFloat(1, maxOffsetDistance, 0.0);
		}

		// Token: 0x06033886 RID: 211078 RVA: 0x006F104A File Offset: 0x006EF24A
		public static void AddIsOneWay(FlatBufferBuilder builder, bool isOneWay)
		{
			builder.AddBool(2, isOneWay, false);
		}

		// Token: 0x06033887 RID: 211079 RVA: 0x006F1055 File Offset: 0x006EF255
		public static void AddLayerVerticalLimit(FlatBufferBuilder builder, float layerVerticalLimit)
		{
			builder.AddFloat(3, layerVerticalLimit, 0.0);
		}

		// Token: 0x06033888 RID: 211080 RVA: 0x006F1068 File Offset: 0x006EF268
		public static void AddDynamicGravity(FlatBufferBuilder builder, bool dynamicGravity)
		{
			builder.AddBool(4, dynamicGravity, false);
		}

		// Token: 0x06033889 RID: 211081 RVA: 0x006F1073 File Offset: 0x006EF273
		public static void AddGravitySwitchAngularVelocity(FlatBufferBuilder builder, float gravitySwitchAngularVelocity)
		{
			builder.AddFloat(5, gravitySwitchAngularVelocity, 0.0);
		}

		// Token: 0x0603388A RID: 211082 RVA: 0x006F1086 File Offset: 0x006EF286
		public static void AddAutoExitDistance(FlatBufferBuilder builder, int autoExitDistance)
		{
			builder.AddInt(6, autoExitDistance, 0);
		}

		// Token: 0x0603388B RID: 211083 RVA: 0x006F1091 File Offset: 0x006EF291
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0603388C RID: 211084 RVA: 0x006F109C File Offset: 0x006EF29C
		public static Offset<ISplineMovePattern> EndISplineMovePattern(FlatBufferBuilder builder)
		{
			return new Offset<ISplineMovePattern>(builder.EndTable());
		}

		// Token: 0x0603388D RID: 211085 RVA: 0x006F10AC File Offset: 0x006EF2AC
		public ISplineMovePatternT UnPack()
		{
			ISplineMovePatternT splineMovePatternT = new ISplineMovePatternT();
			this.UnPackTo(splineMovePatternT);
			return splineMovePatternT;
		}

		// Token: 0x0603388E RID: 211086 RVA: 0x006F10C8 File Offset: 0x006EF2C8
		public void UnPackTo(ISplineMovePatternT _o)
		{
			_o.Type = this.Type;
			_o.MaxOffsetDistance = this.MaxOffsetDistance;
			_o.IsOneWay = this.IsOneWay;
			_o.LayerVerticalLimit = this.LayerVerticalLimit;
			_o.DynamicGravity = this.DynamicGravity;
			_o.GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity;
			_o.AutoExitDistance = this.AutoExitDistance;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603388F RID: 211087 RVA: 0x006F1138 File Offset: 0x006EF338
		public static Offset<ISplineMovePattern> Pack(FlatBufferBuilder builder, ISplineMovePatternT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISplineMovePattern>);
			}
			return ISplineMovePattern.CreateISplineMovePattern(builder, _o.Type, _o.MaxOffsetDistance, _o.IsOneWay, _o.LayerVerticalLimit, _o.DynamicGravity, _o.GravitySwitchAngularVelocity, _o.AutoExitDistance, _o.NullMask);
		}

		// Token: 0x04011C3B RID: 72763
		private Table __p;
	}
}

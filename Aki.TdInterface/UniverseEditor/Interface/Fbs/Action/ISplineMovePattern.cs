using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200795F RID: 31071
	public struct ISplineMovePattern : IFlatbufferObject
	{
		// Token: 0x1700E3D6 RID: 58326
		// (get) Token: 0x06036B6C RID: 224108 RVA: 0x00751F5E File Offset: 0x0075015E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036B6D RID: 224109 RVA: 0x00751F6B File Offset: 0x0075016B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036B6E RID: 224110 RVA: 0x00751F74 File Offset: 0x00750174
		public static ISplineMovePattern GetRootAsISplineMovePattern(ByteBuffer _bb)
		{
			return ISplineMovePattern.GetRootAsISplineMovePattern(_bb, default(ISplineMovePattern));
		}

		// Token: 0x06036B6F RID: 224111 RVA: 0x00751F90 File Offset: 0x00750190
		public static ISplineMovePattern GetRootAsISplineMovePattern(ByteBuffer _bb, ISplineMovePattern obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036B70 RID: 224112 RVA: 0x00751FAD File Offset: 0x007501AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036B71 RID: 224113 RVA: 0x00751FBC File Offset: 0x007501BC
		public ISplineMovePattern __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3D7 RID: 58327
		// (get) Token: 0x06036B72 RID: 224114 RVA: 0x00751FCC File Offset: 0x007501CC
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

		// Token: 0x1700E3D8 RID: 58328
		// (get) Token: 0x06036B73 RID: 224115 RVA: 0x00752008 File Offset: 0x00750208
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

		// Token: 0x1700E3D9 RID: 58329
		// (get) Token: 0x06036B74 RID: 224116 RVA: 0x00752048 File Offset: 0x00750248
		public bool IsOneWay
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E3DA RID: 58330
		// (get) Token: 0x06036B75 RID: 224117 RVA: 0x00752088 File Offset: 0x00750288
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

		// Token: 0x1700E3DB RID: 58331
		// (get) Token: 0x06036B76 RID: 224118 RVA: 0x007520CC File Offset: 0x007502CC
		public bool DynamicGravity
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E3DC RID: 58332
		// (get) Token: 0x06036B77 RID: 224119 RVA: 0x0075210C File Offset: 0x0075030C
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

		// Token: 0x1700E3DD RID: 58333
		// (get) Token: 0x06036B78 RID: 224120 RVA: 0x00752150 File Offset: 0x00750350
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

		// Token: 0x1700E3DE RID: 58334
		// (get) Token: 0x06036B79 RID: 224121 RVA: 0x00752190 File Offset: 0x00750390
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

		// Token: 0x06036B7A RID: 224122 RVA: 0x007521D0 File Offset: 0x007503D0
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

		// Token: 0x06036B7B RID: 224123 RVA: 0x00752227 File Offset: 0x00750427
		public static void StartISplineMovePattern(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06036B7C RID: 224124 RVA: 0x00752230 File Offset: 0x00750430
		public static void AddType(FlatBufferBuilder builder, ESplineMovePattern type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036B7D RID: 224125 RVA: 0x0075223B File Offset: 0x0075043B
		public static void AddMaxOffsetDistance(FlatBufferBuilder builder, float maxOffsetDistance)
		{
			builder.AddFloat(1, maxOffsetDistance, 0.0);
		}

		// Token: 0x06036B7E RID: 224126 RVA: 0x0075224E File Offset: 0x0075044E
		public static void AddIsOneWay(FlatBufferBuilder builder, bool isOneWay)
		{
			builder.AddBool(2, isOneWay, false);
		}

		// Token: 0x06036B7F RID: 224127 RVA: 0x00752259 File Offset: 0x00750459
		public static void AddLayerVerticalLimit(FlatBufferBuilder builder, float layerVerticalLimit)
		{
			builder.AddFloat(3, layerVerticalLimit, 0.0);
		}

		// Token: 0x06036B80 RID: 224128 RVA: 0x0075226C File Offset: 0x0075046C
		public static void AddDynamicGravity(FlatBufferBuilder builder, bool dynamicGravity)
		{
			builder.AddBool(4, dynamicGravity, false);
		}

		// Token: 0x06036B81 RID: 224129 RVA: 0x00752277 File Offset: 0x00750477
		public static void AddGravitySwitchAngularVelocity(FlatBufferBuilder builder, float gravitySwitchAngularVelocity)
		{
			builder.AddFloat(5, gravitySwitchAngularVelocity, 0.0);
		}

		// Token: 0x06036B82 RID: 224130 RVA: 0x0075228A File Offset: 0x0075048A
		public static void AddAutoExitDistance(FlatBufferBuilder builder, int autoExitDistance)
		{
			builder.AddInt(6, autoExitDistance, 0);
		}

		// Token: 0x06036B83 RID: 224131 RVA: 0x00752295 File Offset: 0x00750495
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06036B84 RID: 224132 RVA: 0x007522A0 File Offset: 0x007504A0
		public static Offset<ISplineMovePattern> EndISplineMovePattern(FlatBufferBuilder builder)
		{
			return new Offset<ISplineMovePattern>(builder.EndTable());
		}

		// Token: 0x06036B85 RID: 224133 RVA: 0x007522B0 File Offset: 0x007504B0
		public ISplineMovePatternT UnPack()
		{
			ISplineMovePatternT splineMovePatternT = new ISplineMovePatternT();
			this.UnPackTo(splineMovePatternT);
			return splineMovePatternT;
		}

		// Token: 0x06036B86 RID: 224134 RVA: 0x007522CC File Offset: 0x007504CC
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

		// Token: 0x06036B87 RID: 224135 RVA: 0x0075233C File Offset: 0x0075053C
		public static Offset<ISplineMovePattern> Pack(FlatBufferBuilder builder, ISplineMovePatternT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISplineMovePattern>);
			}
			return ISplineMovePattern.CreateISplineMovePattern(builder, _o.Type, _o.MaxOffsetDistance, _o.IsOneWay, _o.LayerVerticalLimit, _o.DynamicGravity, _o.GravitySwitchAngularVelocity, _o.AutoExitDistance, _o.NullMask);
		}

		// Token: 0x04012C39 RID: 76857
		private Table __p;
	}
}

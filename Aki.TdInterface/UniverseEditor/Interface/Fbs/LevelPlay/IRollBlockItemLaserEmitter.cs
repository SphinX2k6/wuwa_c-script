using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004599 RID: 17817
	public struct IRollBlockItemLaserEmitter : IFlatbufferObject
	{
		// Token: 0x17007E91 RID: 32401
		// (get) Token: 0x0601AEA5 RID: 110245 RVA: 0x003D7017 File Offset: 0x003D5217
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AEA6 RID: 110246 RVA: 0x003D7024 File Offset: 0x003D5224
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AEA7 RID: 110247 RVA: 0x003D702C File Offset: 0x003D522C
		public static IRollBlockItemLaserEmitter GetRootAsIRollBlockItemLaserEmitter(ByteBuffer _bb)
		{
			return IRollBlockItemLaserEmitter.GetRootAsIRollBlockItemLaserEmitter(_bb, default(IRollBlockItemLaserEmitter));
		}

		// Token: 0x0601AEA8 RID: 110248 RVA: 0x003D7048 File Offset: 0x003D5248
		public static IRollBlockItemLaserEmitter GetRootAsIRollBlockItemLaserEmitter(ByteBuffer _bb, IRollBlockItemLaserEmitter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AEA9 RID: 110249 RVA: 0x003D7065 File Offset: 0x003D5265
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AEAA RID: 110250 RVA: 0x003D7074 File Offset: 0x003D5274
		public IRollBlockItemLaserEmitter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E92 RID: 32402
		// (get) Token: 0x0601AEAB RID: 110251 RVA: 0x003D7084 File Offset: 0x003D5284
		public ERollBlockItemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERollBlockItemType.BreakableObstacle;
				}
				return (ERollBlockItemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007E93 RID: 32403
		// (get) Token: 0x0601AEAC RID: 110252 RVA: 0x003D70C0 File Offset: 0x003D52C0
		public ERollBlockLayType Direction
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ERollBlockLayType.Left;
				}
				return (ERollBlockLayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007E94 RID: 32404
		// (get) Token: 0x0601AEAD RID: 110253 RVA: 0x003D70FC File Offset: 0x003D52FC
		public int Length
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007E95 RID: 32405
		// (get) Token: 0x0601AEAE RID: 110254 RVA: 0x003D7138 File Offset: 0x003D5338
		public int Height
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007E96 RID: 32406
		// (get) Token: 0x0601AEAF RID: 110255 RVA: 0x003D7178 File Offset: 0x003D5378
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601AEB0 RID: 110256 RVA: 0x003D71B5 File Offset: 0x003D53B5
		public static Offset<IRollBlockItemLaserEmitter> CreateIRollBlockItemLaserEmitter(FlatBufferBuilder builder, ERollBlockItemType Type = ERollBlockItemType.BreakableObstacle, ERollBlockLayType Direction = ERollBlockLayType.Left, int Length = 0, int Height = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			IRollBlockItemLaserEmitter.AddHeight(builder, Height);
			IRollBlockItemLaserEmitter.AddLength(builder, Length);
			IRollBlockItemLaserEmitter.AddNullMask(builder, NullMask);
			IRollBlockItemLaserEmitter.AddDirection(builder, Direction);
			IRollBlockItemLaserEmitter.AddType(builder, Type);
			return IRollBlockItemLaserEmitter.EndIRollBlockItemLaserEmitter(builder);
		}

		// Token: 0x0601AEB1 RID: 110257 RVA: 0x003D71E9 File Offset: 0x003D53E9
		public static void StartIRollBlockItemLaserEmitter(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601AEB2 RID: 110258 RVA: 0x003D71F2 File Offset: 0x003D53F2
		public static void AddType(FlatBufferBuilder builder, ERollBlockItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AEB3 RID: 110259 RVA: 0x003D71FD File Offset: 0x003D53FD
		public static void AddDirection(FlatBufferBuilder builder, ERollBlockLayType direction)
		{
			builder.AddByte(1, (byte)direction, 0);
		}

		// Token: 0x0601AEB4 RID: 110260 RVA: 0x003D7208 File Offset: 0x003D5408
		public static void AddLength(FlatBufferBuilder builder, int length)
		{
			builder.AddInt(2, length, 0);
		}

		// Token: 0x0601AEB5 RID: 110261 RVA: 0x003D7213 File Offset: 0x003D5413
		public static void AddHeight(FlatBufferBuilder builder, int height)
		{
			builder.AddInt(3, height, 0);
		}

		// Token: 0x0601AEB6 RID: 110262 RVA: 0x003D721E File Offset: 0x003D541E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601AEB7 RID: 110263 RVA: 0x003D7229 File Offset: 0x003D5429
		public static Offset<IRollBlockItemLaserEmitter> EndIRollBlockItemLaserEmitter(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockItemLaserEmitter>(builder.EndTable());
		}

		// Token: 0x0601AEB8 RID: 110264 RVA: 0x003D7238 File Offset: 0x003D5438
		public IRollBlockItemLaserEmitterT UnPack()
		{
			IRollBlockItemLaserEmitterT rollBlockItemLaserEmitterT = new IRollBlockItemLaserEmitterT();
			this.UnPackTo(rollBlockItemLaserEmitterT);
			return rollBlockItemLaserEmitterT;
		}

		// Token: 0x0601AEB9 RID: 110265 RVA: 0x003D7253 File Offset: 0x003D5453
		public void UnPackTo(IRollBlockItemLaserEmitterT _o)
		{
			_o.Type = this.Type;
			_o.Direction = this.Direction;
			_o.Length = this.Length;
			_o.Height = this.Height;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601AEBA RID: 110266 RVA: 0x003D7294 File Offset: 0x003D5494
		public static Offset<IRollBlockItemLaserEmitter> Pack(FlatBufferBuilder builder, IRollBlockItemLaserEmitterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockItemLaserEmitter>);
			}
			return IRollBlockItemLaserEmitter.CreateIRollBlockItemLaserEmitter(builder, _o.Type, _o.Direction, _o.Length, _o.Height, _o.NullMask);
		}

		// Token: 0x0400C658 RID: 50776
		private Table __p;
	}
}

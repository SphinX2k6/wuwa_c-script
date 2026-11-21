using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A01 RID: 18945
	public struct IRollBlockItemLaserEmitter : IFlatbufferObject
	{
		// Token: 0x170084D2 RID: 34002
		// (get) Token: 0x0601C67A RID: 116346 RVA: 0x004032B3 File Offset: 0x004014B3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C67B RID: 116347 RVA: 0x004032C0 File Offset: 0x004014C0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C67C RID: 116348 RVA: 0x004032C8 File Offset: 0x004014C8
		public static IRollBlockItemLaserEmitter GetRootAsIRollBlockItemLaserEmitter(ByteBuffer _bb)
		{
			return IRollBlockItemLaserEmitter.GetRootAsIRollBlockItemLaserEmitter(_bb, default(IRollBlockItemLaserEmitter));
		}

		// Token: 0x0601C67D RID: 116349 RVA: 0x004032E4 File Offset: 0x004014E4
		public static IRollBlockItemLaserEmitter GetRootAsIRollBlockItemLaserEmitter(ByteBuffer _bb, IRollBlockItemLaserEmitter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C67E RID: 116350 RVA: 0x00403301 File Offset: 0x00401501
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C67F RID: 116351 RVA: 0x00403310 File Offset: 0x00401510
		public IRollBlockItemLaserEmitter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170084D3 RID: 34003
		// (get) Token: 0x0601C680 RID: 116352 RVA: 0x00403320 File Offset: 0x00401520
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

		// Token: 0x170084D4 RID: 34004
		// (get) Token: 0x0601C681 RID: 116353 RVA: 0x0040335C File Offset: 0x0040155C
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

		// Token: 0x170084D5 RID: 34005
		// (get) Token: 0x0601C682 RID: 116354 RVA: 0x00403398 File Offset: 0x00401598
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

		// Token: 0x170084D6 RID: 34006
		// (get) Token: 0x0601C683 RID: 116355 RVA: 0x004033D4 File Offset: 0x004015D4
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

		// Token: 0x170084D7 RID: 34007
		// (get) Token: 0x0601C684 RID: 116356 RVA: 0x00403414 File Offset: 0x00401614
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

		// Token: 0x0601C685 RID: 116357 RVA: 0x00403451 File Offset: 0x00401651
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

		// Token: 0x0601C686 RID: 116358 RVA: 0x00403485 File Offset: 0x00401685
		public static void StartIRollBlockItemLaserEmitter(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601C687 RID: 116359 RVA: 0x0040348E File Offset: 0x0040168E
		public static void AddType(FlatBufferBuilder builder, ERollBlockItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C688 RID: 116360 RVA: 0x00403499 File Offset: 0x00401699
		public static void AddDirection(FlatBufferBuilder builder, ERollBlockLayType direction)
		{
			builder.AddByte(1, (byte)direction, 0);
		}

		// Token: 0x0601C689 RID: 116361 RVA: 0x004034A4 File Offset: 0x004016A4
		public static void AddLength(FlatBufferBuilder builder, int length)
		{
			builder.AddInt(2, length, 0);
		}

		// Token: 0x0601C68A RID: 116362 RVA: 0x004034AF File Offset: 0x004016AF
		public static void AddHeight(FlatBufferBuilder builder, int height)
		{
			builder.AddInt(3, height, 0);
		}

		// Token: 0x0601C68B RID: 116363 RVA: 0x004034BA File Offset: 0x004016BA
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601C68C RID: 116364 RVA: 0x004034C5 File Offset: 0x004016C5
		public static Offset<IRollBlockItemLaserEmitter> EndIRollBlockItemLaserEmitter(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockItemLaserEmitter>(builder.EndTable());
		}

		// Token: 0x0601C68D RID: 116365 RVA: 0x004034D4 File Offset: 0x004016D4
		public IRollBlockItemLaserEmitterT UnPack()
		{
			IRollBlockItemLaserEmitterT rollBlockItemLaserEmitterT = new IRollBlockItemLaserEmitterT();
			this.UnPackTo(rollBlockItemLaserEmitterT);
			return rollBlockItemLaserEmitterT;
		}

		// Token: 0x0601C68E RID: 116366 RVA: 0x004034EF File Offset: 0x004016EF
		public void UnPackTo(IRollBlockItemLaserEmitterT _o)
		{
			_o.Type = this.Type;
			_o.Direction = this.Direction;
			_o.Length = this.Length;
			_o.Height = this.Height;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601C68F RID: 116367 RVA: 0x00403530 File Offset: 0x00401730
		public static Offset<IRollBlockItemLaserEmitter> Pack(FlatBufferBuilder builder, IRollBlockItemLaserEmitterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockItemLaserEmitter>);
			}
			return IRollBlockItemLaserEmitter.CreateIRollBlockItemLaserEmitter(builder, _o.Type, _o.Direction, _o.Length, _o.Height, _o.NullMask);
		}

		// Token: 0x0400D087 RID: 53383
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049FE RID: 18942
	public struct IRollBlockItemBreakableObstacle : IFlatbufferObject
	{
		// Token: 0x170084CB RID: 33995
		// (get) Token: 0x0601C660 RID: 116320 RVA: 0x00402F9A File Offset: 0x0040119A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C661 RID: 116321 RVA: 0x00402FA7 File Offset: 0x004011A7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C662 RID: 116322 RVA: 0x00402FB0 File Offset: 0x004011B0
		public static IRollBlockItemBreakableObstacle GetRootAsIRollBlockItemBreakableObstacle(ByteBuffer _bb)
		{
			return IRollBlockItemBreakableObstacle.GetRootAsIRollBlockItemBreakableObstacle(_bb, default(IRollBlockItemBreakableObstacle));
		}

		// Token: 0x0601C663 RID: 116323 RVA: 0x00402FCC File Offset: 0x004011CC
		public static IRollBlockItemBreakableObstacle GetRootAsIRollBlockItemBreakableObstacle(ByteBuffer _bb, IRollBlockItemBreakableObstacle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C664 RID: 116324 RVA: 0x00402FE9 File Offset: 0x004011E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C665 RID: 116325 RVA: 0x00402FF8 File Offset: 0x004011F8
		public IRollBlockItemBreakableObstacle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170084CC RID: 33996
		// (get) Token: 0x0601C666 RID: 116326 RVA: 0x00403008 File Offset: 0x00401208
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

		// Token: 0x170084CD RID: 33997
		// (get) Token: 0x0601C667 RID: 116327 RVA: 0x00403044 File Offset: 0x00401244
		public int Key
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170084CE RID: 33998
		// (get) Token: 0x0601C668 RID: 116328 RVA: 0x00403080 File Offset: 0x00401280
		public IRollBlockPath? Path
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IRollBlockPath?(default(IRollBlockPath).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601C669 RID: 116329 RVA: 0x004030DD File Offset: 0x004012DD
		public static Offset<IRollBlockItemBreakableObstacle> CreateIRollBlockItemBreakableObstacle(FlatBufferBuilder builder, ERollBlockItemType Type = ERollBlockItemType.BreakableObstacle, int Key = 0, Offset<IRollBlockPath> PathOffset = default(Offset<IRollBlockPath>))
		{
			builder.StartTable(3);
			IRollBlockItemBreakableObstacle.AddPath(builder, PathOffset);
			IRollBlockItemBreakableObstacle.AddKey(builder, Key);
			IRollBlockItemBreakableObstacle.AddType(builder, Type);
			return IRollBlockItemBreakableObstacle.EndIRollBlockItemBreakableObstacle(builder);
		}

		// Token: 0x0601C66A RID: 116330 RVA: 0x00403101 File Offset: 0x00401301
		public static void StartIRollBlockItemBreakableObstacle(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601C66B RID: 116331 RVA: 0x0040310A File Offset: 0x0040130A
		public static void AddType(FlatBufferBuilder builder, ERollBlockItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C66C RID: 116332 RVA: 0x00403115 File Offset: 0x00401315
		public static void AddKey(FlatBufferBuilder builder, int key)
		{
			builder.AddInt(1, key, 0);
		}

		// Token: 0x0601C66D RID: 116333 RVA: 0x00403120 File Offset: 0x00401320
		public static void AddPath(FlatBufferBuilder builder, Offset<IRollBlockPath> pathOffset)
		{
			builder.AddOffset(2, pathOffset.Value, 0);
		}

		// Token: 0x0601C66E RID: 116334 RVA: 0x00403130 File Offset: 0x00401330
		public static Offset<IRollBlockItemBreakableObstacle> EndIRollBlockItemBreakableObstacle(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockItemBreakableObstacle>(builder.EndTable());
		}

		// Token: 0x0601C66F RID: 116335 RVA: 0x00403140 File Offset: 0x00401340
		public IRollBlockItemBreakableObstacleT UnPack()
		{
			IRollBlockItemBreakableObstacleT rollBlockItemBreakableObstacleT = new IRollBlockItemBreakableObstacleT();
			this.UnPackTo(rollBlockItemBreakableObstacleT);
			return rollBlockItemBreakableObstacleT;
		}

		// Token: 0x0601C670 RID: 116336 RVA: 0x0040315C File Offset: 0x0040135C
		public void UnPackTo(IRollBlockItemBreakableObstacleT _o)
		{
			_o.Type = this.Type;
			_o.Key = this.Key;
			_o.Path = ((this.Path != null) ? this.Path.Value.UnPack() : null);
		}

		// Token: 0x0601C671 RID: 116337 RVA: 0x004031B0 File Offset: 0x004013B0
		public static Offset<IRollBlockItemBreakableObstacle> Pack(FlatBufferBuilder builder, IRollBlockItemBreakableObstacleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockItemBreakableObstacle>);
			}
			Offset<IRollBlockPath> pathOffset = (_o.Path == null) ? default(Offset<IRollBlockPath>) : IRollBlockPath.Pack(builder, _o.Path);
			return IRollBlockItemBreakableObstacle.CreateIRollBlockItemBreakableObstacle(builder, _o.Type, _o.Key, pathOffset);
		}

		// Token: 0x0400D083 RID: 53379
		private Table __p;
	}
}

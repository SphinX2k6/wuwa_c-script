using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DF7 RID: 24055
	public struct IRandomPoolChoose : IFlatbufferObject
	{
		// Token: 0x1700B149 RID: 45385
		// (get) Token: 0x06028270 RID: 164464 RVA: 0x0057DD0E File Offset: 0x0057BF0E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028271 RID: 164465 RVA: 0x0057DD1B File Offset: 0x0057BF1B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028272 RID: 164466 RVA: 0x0057DD24 File Offset: 0x0057BF24
		public static IRandomPoolChoose GetRootAsIRandomPoolChoose(ByteBuffer _bb)
		{
			return IRandomPoolChoose.GetRootAsIRandomPoolChoose(_bb, default(IRandomPoolChoose));
		}

		// Token: 0x06028273 RID: 164467 RVA: 0x0057DD40 File Offset: 0x0057BF40
		public static IRandomPoolChoose GetRootAsIRandomPoolChoose(ByteBuffer _bb, IRandomPoolChoose obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028274 RID: 164468 RVA: 0x0057DD5D File Offset: 0x0057BF5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028275 RID: 164469 RVA: 0x0057DD6C File Offset: 0x0057BF6C
		public IRandomPoolChoose __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B14A RID: 45386
		// (get) Token: 0x06028276 RID: 164470 RVA: 0x0057DD7C File Offset: 0x0057BF7C
		public EMonsterChooseType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMonsterChooseType.RandomPoolChoose;
				}
				return (EMonsterChooseType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028277 RID: 164471 RVA: 0x0057DDB8 File Offset: 0x0057BFB8
		public IRandomPoolConfig? RandomPoolConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IRandomPoolConfig?(default(IRandomPoolConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B14B RID: 45387
		// (get) Token: 0x06028278 RID: 164472 RVA: 0x0057DE18 File Offset: 0x0057C018
		public int RandomPoolConfigsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06028279 RID: 164473 RVA: 0x0057DE43 File Offset: 0x0057C043
		public static Offset<IRandomPoolChoose> CreateIRandomPoolChoose(FlatBufferBuilder builder, EMonsterChooseType Type = EMonsterChooseType.RandomPoolChoose, VectorOffset RandomPoolConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IRandomPoolChoose.AddRandomPoolConfigs(builder, RandomPoolConfigsOffset);
			IRandomPoolChoose.AddType(builder, Type);
			return IRandomPoolChoose.EndIRandomPoolChoose(builder);
		}

		// Token: 0x0602827A RID: 164474 RVA: 0x0057DE60 File Offset: 0x0057C060
		public static void StartIRandomPoolChoose(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602827B RID: 164475 RVA: 0x0057DE69 File Offset: 0x0057C069
		public static void AddType(FlatBufferBuilder builder, EMonsterChooseType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602827C RID: 164476 RVA: 0x0057DE74 File Offset: 0x0057C074
		public static void AddRandomPoolConfigs(FlatBufferBuilder builder, VectorOffset randomPoolConfigsOffset)
		{
			builder.AddOffset(1, randomPoolConfigsOffset.Value, 0);
		}

		// Token: 0x0602827D RID: 164477 RVA: 0x0057DE84 File Offset: 0x0057C084
		public static VectorOffset CreateRandomPoolConfigsVector(FlatBufferBuilder builder, Offset<IRandomPoolConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602827E RID: 164478 RVA: 0x0057DEC4 File Offset: 0x0057C0C4
		public static VectorOffset CreateRandomPoolConfigsVectorBlock(FlatBufferBuilder builder, Offset<IRandomPoolConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRandomPoolConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602827F RID: 164479 RVA: 0x0057DEDE File Offset: 0x0057C0DE
		public static VectorOffset CreateRandomPoolConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRandomPoolConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRandomPoolConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028280 RID: 164480 RVA: 0x0057DEFC File Offset: 0x0057C0FC
		public static VectorOffset CreateRandomPoolConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRandomPoolConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028281 RID: 164481 RVA: 0x0057DF15 File Offset: 0x0057C115
		public static void StartRandomPoolConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028282 RID: 164482 RVA: 0x0057DF20 File Offset: 0x0057C120
		public static Offset<IRandomPoolChoose> EndIRandomPoolChoose(FlatBufferBuilder builder)
		{
			return new Offset<IRandomPoolChoose>(builder.EndTable());
		}

		// Token: 0x06028283 RID: 164483 RVA: 0x0057DF30 File Offset: 0x0057C130
		public IRandomPoolChooseT UnPack()
		{
			IRandomPoolChooseT randomPoolChooseT = new IRandomPoolChooseT();
			this.UnPackTo(randomPoolChooseT);
			return randomPoolChooseT;
		}

		// Token: 0x06028284 RID: 164484 RVA: 0x0057DF4C File Offset: 0x0057C14C
		public void UnPackTo(IRandomPoolChooseT _o)
		{
			_o.Type = this.Type;
			_o.RandomPoolConfigs = new List<IRandomPoolConfigT>();
			for (int i = 0; i < this.RandomPoolConfigsLength; i++)
			{
				_o.RandomPoolConfigs.Add((this.RandomPoolConfigs(i) != null) ? this.RandomPoolConfigs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06028285 RID: 164485 RVA: 0x0057DFB8 File Offset: 0x0057C1B8
		public static Offset<IRandomPoolChoose> Pack(FlatBufferBuilder builder, IRandomPoolChooseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRandomPoolChoose>);
			}
			VectorOffset randomPoolConfigsOffset = default(VectorOffset);
			if (_o.RandomPoolConfigs != null)
			{
				Offset<IRandomPoolConfig>[] array = new Offset<IRandomPoolConfig>[_o.RandomPoolConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IRandomPoolConfig.Pack(builder, _o.RandomPoolConfigs[i]);
				}
				randomPoolConfigsOffset = IRandomPoolChoose.CreateRandomPoolConfigsVector(builder, array);
			}
			return IRandomPoolChoose.CreateIRandomPoolChoose(builder, _o.Type, randomPoolConfigsOffset);
		}

		// Token: 0x0400F9CE RID: 63950
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005992 RID: 22930
	public struct ISpwanMonsterMode : IFlatbufferObject
	{
		// Token: 0x1700AC19 RID: 44057
		// (get) Token: 0x06026D60 RID: 159072 RVA: 0x0055865B File Offset: 0x0055685B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026D61 RID: 159073 RVA: 0x00558668 File Offset: 0x00556868
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026D62 RID: 159074 RVA: 0x00558670 File Offset: 0x00556870
		public static ISpwanMonsterMode GetRootAsISpwanMonsterMode(ByteBuffer _bb)
		{
			return ISpwanMonsterMode.GetRootAsISpwanMonsterMode(_bb, default(ISpwanMonsterMode));
		}

		// Token: 0x06026D63 RID: 159075 RVA: 0x0055868C File Offset: 0x0055688C
		public static ISpwanMonsterMode GetRootAsISpwanMonsterMode(ByteBuffer _bb, ISpwanMonsterMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026D64 RID: 159076 RVA: 0x005586A9 File Offset: 0x005568A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026D65 RID: 159077 RVA: 0x005586B8 File Offset: 0x005568B8
		public ISpwanMonsterMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC1A RID: 44058
		// (get) Token: 0x06026D66 RID: 159078 RVA: 0x005586C8 File Offset: 0x005568C8
		public ESpawnMonsterConstraint Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpawnMonsterConstraint.CharacterForwardAnnularSector;
				}
				return (ESpawnMonsterConstraint)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026D67 RID: 159079 RVA: 0x00558704 File Offset: 0x00556904
		public static Offset<ISpwanMonsterMode> CreateISpwanMonsterMode(FlatBufferBuilder builder, ESpawnMonsterConstraint Type = ESpawnMonsterConstraint.CharacterForwardAnnularSector)
		{
			builder.StartTable(1);
			ISpwanMonsterMode.AddType(builder, Type);
			return ISpwanMonsterMode.EndISpwanMonsterMode(builder);
		}

		// Token: 0x06026D68 RID: 159080 RVA: 0x0055871A File Offset: 0x0055691A
		public static void StartISpwanMonsterMode(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026D69 RID: 159081 RVA: 0x00558723 File Offset: 0x00556923
		public static void AddType(FlatBufferBuilder builder, ESpawnMonsterConstraint type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026D6A RID: 159082 RVA: 0x0055872E File Offset: 0x0055692E
		public static Offset<ISpwanMonsterMode> EndISpwanMonsterMode(FlatBufferBuilder builder)
		{
			return new Offset<ISpwanMonsterMode>(builder.EndTable());
		}

		// Token: 0x06026D6B RID: 159083 RVA: 0x0055873C File Offset: 0x0055693C
		public ISpwanMonsterModeT UnPack()
		{
			ISpwanMonsterModeT spwanMonsterModeT = new ISpwanMonsterModeT();
			this.UnPackTo(spwanMonsterModeT);
			return spwanMonsterModeT;
		}

		// Token: 0x06026D6C RID: 159084 RVA: 0x00558757 File Offset: 0x00556957
		public void UnPackTo(ISpwanMonsterModeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026D6D RID: 159085 RVA: 0x00558768 File Offset: 0x00556968
		public static Offset<ISpwanMonsterMode> Pack(FlatBufferBuilder builder, ISpwanMonsterModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpwanMonsterMode>);
			}
			return ISpwanMonsterMode.CreateISpwanMonsterMode(builder, _o.Type);
		}

		// Token: 0x0400EF9A RID: 61338
		private Table __p;
	}
}

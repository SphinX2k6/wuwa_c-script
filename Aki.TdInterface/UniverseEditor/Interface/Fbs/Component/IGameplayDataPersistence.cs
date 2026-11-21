using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005865 RID: 22629
	public struct IGameplayDataPersistence : IFlatbufferObject
	{
		// Token: 0x1700A3EF RID: 41967
		// (get) Token: 0x06024ACD RID: 150221 RVA: 0x00509D6E File Offset: 0x00507F6E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024ACE RID: 150222 RVA: 0x00509D7B File Offset: 0x00507F7B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024ACF RID: 150223 RVA: 0x00509D84 File Offset: 0x00507F84
		public static IGameplayDataPersistence GetRootAsIGameplayDataPersistence(ByteBuffer _bb)
		{
			return IGameplayDataPersistence.GetRootAsIGameplayDataPersistence(_bb, default(IGameplayDataPersistence));
		}

		// Token: 0x06024AD0 RID: 150224 RVA: 0x00509DA0 File Offset: 0x00507FA0
		public static IGameplayDataPersistence GetRootAsIGameplayDataPersistence(ByteBuffer _bb, IGameplayDataPersistence obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024AD1 RID: 150225 RVA: 0x00509DBD File Offset: 0x00507FBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024AD2 RID: 150226 RVA: 0x00509DCC File Offset: 0x00507FCC
		public IGameplayDataPersistence __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A3F0 RID: 41968
		// (get) Token: 0x06024AD3 RID: 150227 RVA: 0x00509DDC File Offset: 0x00507FDC
		public EDataPersistenceGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDataPersistenceGameplayType.TetrisBoardGame;
				}
				return (EDataPersistenceGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024AD4 RID: 150228 RVA: 0x00509E18 File Offset: 0x00508018
		public static Offset<IGameplayDataPersistence> CreateIGameplayDataPersistence(FlatBufferBuilder builder, EDataPersistenceGameplayType Type = EDataPersistenceGameplayType.TetrisBoardGame)
		{
			builder.StartTable(1);
			IGameplayDataPersistence.AddType(builder, Type);
			return IGameplayDataPersistence.EndIGameplayDataPersistence(builder);
		}

		// Token: 0x06024AD5 RID: 150229 RVA: 0x00509E2E File Offset: 0x0050802E
		public static void StartIGameplayDataPersistence(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024AD6 RID: 150230 RVA: 0x00509E37 File Offset: 0x00508037
		public static void AddType(FlatBufferBuilder builder, EDataPersistenceGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024AD7 RID: 150231 RVA: 0x00509E42 File Offset: 0x00508042
		public static Offset<IGameplayDataPersistence> EndIGameplayDataPersistence(FlatBufferBuilder builder)
		{
			return new Offset<IGameplayDataPersistence>(builder.EndTable());
		}

		// Token: 0x06024AD8 RID: 150232 RVA: 0x00509E50 File Offset: 0x00508050
		public IGameplayDataPersistenceT UnPack()
		{
			IGameplayDataPersistenceT gameplayDataPersistenceT = new IGameplayDataPersistenceT();
			this.UnPackTo(gameplayDataPersistenceT);
			return gameplayDataPersistenceT;
		}

		// Token: 0x06024AD9 RID: 150233 RVA: 0x00509E6B File Offset: 0x0050806B
		public void UnPackTo(IGameplayDataPersistenceT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06024ADA RID: 150234 RVA: 0x00509E7C File Offset: 0x0050807C
		public static Offset<IGameplayDataPersistence> Pack(FlatBufferBuilder builder, IGameplayDataPersistenceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGameplayDataPersistence>);
			}
			return IGameplayDataPersistence.CreateIGameplayDataPersistence(builder, _o.Type);
		}

		// Token: 0x0400F0AD RID: 61613
		private Table __p;
	}
}

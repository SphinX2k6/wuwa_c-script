using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052E2 RID: 21218
	public struct IGameplayDataPersistence : IFlatbufferObject
	{
		// Token: 0x17009BBE RID: 39870
		// (get) Token: 0x06022A33 RID: 141875 RVA: 0x004CD242 File Offset: 0x004CB442
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022A34 RID: 141876 RVA: 0x004CD24F File Offset: 0x004CB44F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022A35 RID: 141877 RVA: 0x004CD258 File Offset: 0x004CB458
		public static IGameplayDataPersistence GetRootAsIGameplayDataPersistence(ByteBuffer _bb)
		{
			return IGameplayDataPersistence.GetRootAsIGameplayDataPersistence(_bb, default(IGameplayDataPersistence));
		}

		// Token: 0x06022A36 RID: 141878 RVA: 0x004CD274 File Offset: 0x004CB474
		public static IGameplayDataPersistence GetRootAsIGameplayDataPersistence(ByteBuffer _bb, IGameplayDataPersistence obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022A37 RID: 141879 RVA: 0x004CD291 File Offset: 0x004CB491
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022A38 RID: 141880 RVA: 0x004CD2A0 File Offset: 0x004CB4A0
		public IGameplayDataPersistence __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009BBF RID: 39871
		// (get) Token: 0x06022A39 RID: 141881 RVA: 0x004CD2B0 File Offset: 0x004CB4B0
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

		// Token: 0x06022A3A RID: 141882 RVA: 0x004CD2EC File Offset: 0x004CB4EC
		public static Offset<IGameplayDataPersistence> CreateIGameplayDataPersistence(FlatBufferBuilder builder, EDataPersistenceGameplayType Type = EDataPersistenceGameplayType.TetrisBoardGame)
		{
			builder.StartTable(1);
			IGameplayDataPersistence.AddType(builder, Type);
			return IGameplayDataPersistence.EndIGameplayDataPersistence(builder);
		}

		// Token: 0x06022A3B RID: 141883 RVA: 0x004CD302 File Offset: 0x004CB502
		public static void StartIGameplayDataPersistence(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06022A3C RID: 141884 RVA: 0x004CD30B File Offset: 0x004CB50B
		public static void AddType(FlatBufferBuilder builder, EDataPersistenceGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022A3D RID: 141885 RVA: 0x004CD316 File Offset: 0x004CB516
		public static Offset<IGameplayDataPersistence> EndIGameplayDataPersistence(FlatBufferBuilder builder)
		{
			return new Offset<IGameplayDataPersistence>(builder.EndTable());
		}

		// Token: 0x06022A3E RID: 141886 RVA: 0x004CD324 File Offset: 0x004CB524
		public IGameplayDataPersistenceT UnPack()
		{
			IGameplayDataPersistenceT gameplayDataPersistenceT = new IGameplayDataPersistenceT();
			this.UnPackTo(gameplayDataPersistenceT);
			return gameplayDataPersistenceT;
		}

		// Token: 0x06022A3F RID: 141887 RVA: 0x004CD33F File Offset: 0x004CB53F
		public void UnPackTo(IGameplayDataPersistenceT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06022A40 RID: 141888 RVA: 0x004CD350 File Offset: 0x004CB550
		public static Offset<IGameplayDataPersistence> Pack(FlatBufferBuilder builder, IGameplayDataPersistenceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGameplayDataPersistence>);
			}
			return IGameplayDataPersistence.CreateIGameplayDataPersistence(builder, _o.Type);
		}

		// Token: 0x0400E481 RID: 58497
		private Table __p;
	}
}

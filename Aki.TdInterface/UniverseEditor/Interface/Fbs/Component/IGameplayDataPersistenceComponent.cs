using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005868 RID: 22632
	public struct IGameplayDataPersistenceComponent : IFlatbufferObject
	{
		// Token: 0x1700A3F2 RID: 41970
		// (get) Token: 0x06024ADF RID: 150239 RVA: 0x00509EE5 File Offset: 0x005080E5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024AE0 RID: 150240 RVA: 0x00509EF2 File Offset: 0x005080F2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024AE1 RID: 150241 RVA: 0x00509EFC File Offset: 0x005080FC
		public static IGameplayDataPersistenceComponent GetRootAsIGameplayDataPersistenceComponent(ByteBuffer _bb)
		{
			return IGameplayDataPersistenceComponent.GetRootAsIGameplayDataPersistenceComponent(_bb, default(IGameplayDataPersistenceComponent));
		}

		// Token: 0x06024AE2 RID: 150242 RVA: 0x00509F18 File Offset: 0x00508118
		public static IGameplayDataPersistenceComponent GetRootAsIGameplayDataPersistenceComponent(ByteBuffer _bb, IGameplayDataPersistenceComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024AE3 RID: 150243 RVA: 0x00509F35 File Offset: 0x00508135
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024AE4 RID: 150244 RVA: 0x00509F44 File Offset: 0x00508144
		public IGameplayDataPersistenceComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A3F3 RID: 41971
		// (get) Token: 0x06024AE5 RID: 150245 RVA: 0x00509F54 File Offset: 0x00508154
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A3F4 RID: 41972
		// (get) Token: 0x06024AE6 RID: 150246 RVA: 0x00509F94 File Offset: 0x00508194
		public IGameplayDataPersistenceTetrisBoardGame? DataPersistenceGameplay
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IGameplayDataPersistenceTetrisBoardGame?(default(IGameplayDataPersistenceTetrisBoardGame).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A3F5 RID: 41973
		// (get) Token: 0x06024AE7 RID: 150247 RVA: 0x00509FF4 File Offset: 0x005081F4
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

		// Token: 0x06024AE8 RID: 150248 RVA: 0x0050A030 File Offset: 0x00508230
		public static Offset<IGameplayDataPersistenceComponent> CreateIGameplayDataPersistenceComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IGameplayDataPersistenceTetrisBoardGame> DataPersistenceGameplayOffset = default(Offset<IGameplayDataPersistenceTetrisBoardGame>), byte NullMask = 0)
		{
			builder.StartTable(3);
			IGameplayDataPersistenceComponent.AddDataPersistenceGameplay(builder, DataPersistenceGameplayOffset);
			IGameplayDataPersistenceComponent.AddNullMask(builder, NullMask);
			IGameplayDataPersistenceComponent.AddDisabled(builder, Disabled);
			return IGameplayDataPersistenceComponent.EndIGameplayDataPersistenceComponent(builder);
		}

		// Token: 0x06024AE9 RID: 150249 RVA: 0x0050A054 File Offset: 0x00508254
		public static void StartIGameplayDataPersistenceComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06024AEA RID: 150250 RVA: 0x0050A05D File Offset: 0x0050825D
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06024AEB RID: 150251 RVA: 0x0050A068 File Offset: 0x00508268
		public static void AddDataPersistenceGameplay(FlatBufferBuilder builder, Offset<IGameplayDataPersistenceTetrisBoardGame> dataPersistenceGameplayOffset)
		{
			builder.AddOffset(1, dataPersistenceGameplayOffset.Value, 0);
		}

		// Token: 0x06024AEC RID: 150252 RVA: 0x0050A078 File Offset: 0x00508278
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06024AED RID: 150253 RVA: 0x0050A083 File Offset: 0x00508283
		public static Offset<IGameplayDataPersistenceComponent> EndIGameplayDataPersistenceComponent(FlatBufferBuilder builder)
		{
			return new Offset<IGameplayDataPersistenceComponent>(builder.EndTable());
		}

		// Token: 0x06024AEE RID: 150254 RVA: 0x0050A090 File Offset: 0x00508290
		public IGameplayDataPersistenceComponentT UnPack()
		{
			IGameplayDataPersistenceComponentT gameplayDataPersistenceComponentT = new IGameplayDataPersistenceComponentT();
			this.UnPackTo(gameplayDataPersistenceComponentT);
			return gameplayDataPersistenceComponentT;
		}

		// Token: 0x06024AEF RID: 150255 RVA: 0x0050A0AC File Offset: 0x005082AC
		public void UnPackTo(IGameplayDataPersistenceComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.DataPersistenceGameplay = ((this.DataPersistenceGameplay != null) ? this.DataPersistenceGameplay.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024AF0 RID: 150256 RVA: 0x0050A100 File Offset: 0x00508300
		public static Offset<IGameplayDataPersistenceComponent> Pack(FlatBufferBuilder builder, IGameplayDataPersistenceComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGameplayDataPersistenceComponent>);
			}
			Offset<IGameplayDataPersistenceTetrisBoardGame> dataPersistenceGameplayOffset = (_o.DataPersistenceGameplay == null) ? default(Offset<IGameplayDataPersistenceTetrisBoardGame>) : IGameplayDataPersistenceTetrisBoardGame.Pack(builder, _o.DataPersistenceGameplay);
			return IGameplayDataPersistenceComponent.CreateIGameplayDataPersistenceComponent(builder, _o.Disabled, dataPersistenceGameplayOffset, _o.NullMask);
		}

		// Token: 0x0400F0AF RID: 61615
		private Table __p;
	}
}

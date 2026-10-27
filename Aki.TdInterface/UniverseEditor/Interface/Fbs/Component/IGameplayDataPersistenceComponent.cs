using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052E5 RID: 21221
	public struct IGameplayDataPersistenceComponent : IFlatbufferObject
	{
		// Token: 0x17009BC1 RID: 39873
		// (get) Token: 0x06022A45 RID: 141893 RVA: 0x004CD3B9 File Offset: 0x004CB5B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022A46 RID: 141894 RVA: 0x004CD3C6 File Offset: 0x004CB5C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022A47 RID: 141895 RVA: 0x004CD3D0 File Offset: 0x004CB5D0
		public static IGameplayDataPersistenceComponent GetRootAsIGameplayDataPersistenceComponent(ByteBuffer _bb)
		{
			return IGameplayDataPersistenceComponent.GetRootAsIGameplayDataPersistenceComponent(_bb, default(IGameplayDataPersistenceComponent));
		}

		// Token: 0x06022A48 RID: 141896 RVA: 0x004CD3EC File Offset: 0x004CB5EC
		public static IGameplayDataPersistenceComponent GetRootAsIGameplayDataPersistenceComponent(ByteBuffer _bb, IGameplayDataPersistenceComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022A49 RID: 141897 RVA: 0x004CD409 File Offset: 0x004CB609
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022A4A RID: 141898 RVA: 0x004CD418 File Offset: 0x004CB618
		public IGameplayDataPersistenceComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009BC2 RID: 39874
		// (get) Token: 0x06022A4B RID: 141899 RVA: 0x004CD428 File Offset: 0x004CB628
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009BC3 RID: 39875
		// (get) Token: 0x06022A4C RID: 141900 RVA: 0x004CD468 File Offset: 0x004CB668
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

		// Token: 0x17009BC4 RID: 39876
		// (get) Token: 0x06022A4D RID: 141901 RVA: 0x004CD4C8 File Offset: 0x004CB6C8
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

		// Token: 0x06022A4E RID: 141902 RVA: 0x004CD504 File Offset: 0x004CB704
		public static Offset<IGameplayDataPersistenceComponent> CreateIGameplayDataPersistenceComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IGameplayDataPersistenceTetrisBoardGame> DataPersistenceGameplayOffset = default(Offset<IGameplayDataPersistenceTetrisBoardGame>), byte NullMask = 0)
		{
			builder.StartTable(3);
			IGameplayDataPersistenceComponent.AddDataPersistenceGameplay(builder, DataPersistenceGameplayOffset);
			IGameplayDataPersistenceComponent.AddNullMask(builder, NullMask);
			IGameplayDataPersistenceComponent.AddDisabled(builder, Disabled);
			return IGameplayDataPersistenceComponent.EndIGameplayDataPersistenceComponent(builder);
		}

		// Token: 0x06022A4F RID: 141903 RVA: 0x004CD528 File Offset: 0x004CB728
		public static void StartIGameplayDataPersistenceComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022A50 RID: 141904 RVA: 0x004CD531 File Offset: 0x004CB731
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06022A51 RID: 141905 RVA: 0x004CD53C File Offset: 0x004CB73C
		public static void AddDataPersistenceGameplay(FlatBufferBuilder builder, Offset<IGameplayDataPersistenceTetrisBoardGame> dataPersistenceGameplayOffset)
		{
			builder.AddOffset(1, dataPersistenceGameplayOffset.Value, 0);
		}

		// Token: 0x06022A52 RID: 141906 RVA: 0x004CD54C File Offset: 0x004CB74C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06022A53 RID: 141907 RVA: 0x004CD557 File Offset: 0x004CB757
		public static Offset<IGameplayDataPersistenceComponent> EndIGameplayDataPersistenceComponent(FlatBufferBuilder builder)
		{
			return new Offset<IGameplayDataPersistenceComponent>(builder.EndTable());
		}

		// Token: 0x06022A54 RID: 141908 RVA: 0x004CD564 File Offset: 0x004CB764
		public IGameplayDataPersistenceComponentT UnPack()
		{
			IGameplayDataPersistenceComponentT gameplayDataPersistenceComponentT = new IGameplayDataPersistenceComponentT();
			this.UnPackTo(gameplayDataPersistenceComponentT);
			return gameplayDataPersistenceComponentT;
		}

		// Token: 0x06022A55 RID: 141909 RVA: 0x004CD580 File Offset: 0x004CB780
		public void UnPackTo(IGameplayDataPersistenceComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.DataPersistenceGameplay = ((this.DataPersistenceGameplay != null) ? this.DataPersistenceGameplay.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022A56 RID: 141910 RVA: 0x004CD5D4 File Offset: 0x004CB7D4
		public static Offset<IGameplayDataPersistenceComponent> Pack(FlatBufferBuilder builder, IGameplayDataPersistenceComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGameplayDataPersistenceComponent>);
			}
			Offset<IGameplayDataPersistenceTetrisBoardGame> dataPersistenceGameplayOffset = (_o.DataPersistenceGameplay == null) ? default(Offset<IGameplayDataPersistenceTetrisBoardGame>) : IGameplayDataPersistenceTetrisBoardGame.Pack(builder, _o.DataPersistenceGameplay);
			return IGameplayDataPersistenceComponent.CreateIGameplayDataPersistenceComponent(builder, _o.Disabled, dataPersistenceGameplayOffset, _o.NullMask);
		}

		// Token: 0x0400E483 RID: 58499
		private Table __p;
	}
}

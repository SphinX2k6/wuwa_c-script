using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006790 RID: 26512
	public struct IAddGuestCharacter : IFlatbufferObject
	{
		// Token: 0x1700C0C7 RID: 49351
		// (get) Token: 0x0602CF52 RID: 184146 RVA: 0x006251FF File Offset: 0x006233FF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CF53 RID: 184147 RVA: 0x0062520C File Offset: 0x0062340C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CF54 RID: 184148 RVA: 0x00625214 File Offset: 0x00623414
		public static IAddGuestCharacter GetRootAsIAddGuestCharacter(ByteBuffer _bb)
		{
			return IAddGuestCharacter.GetRootAsIAddGuestCharacter(_bb, default(IAddGuestCharacter));
		}

		// Token: 0x0602CF55 RID: 184149 RVA: 0x00625230 File Offset: 0x00623430
		public static IAddGuestCharacter GetRootAsIAddGuestCharacter(ByteBuffer _bb, IAddGuestCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CF56 RID: 184150 RVA: 0x0062524D File Offset: 0x0062344D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CF57 RID: 184151 RVA: 0x0062525C File Offset: 0x0062345C
		public IAddGuestCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C0C8 RID: 49352
		// (get) Token: 0x0602CF58 RID: 184152 RVA: 0x0062526C File Offset: 0x0062346C
		public int GuestCharacterId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C0C9 RID: 49353
		// (get) Token: 0x0602CF59 RID: 184153 RVA: 0x006252A8 File Offset: 0x006234A8
		public IActiveRange? ActiveRange
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IActiveRange?(default(IActiveRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602CF5A RID: 184154 RVA: 0x00625305 File Offset: 0x00623505
		public static Offset<IAddGuestCharacter> CreateIAddGuestCharacter(FlatBufferBuilder builder, int GuestCharacterId = 0, Offset<IActiveRange> ActiveRangeOffset = default(Offset<IActiveRange>))
		{
			builder.StartTable(2);
			IAddGuestCharacter.AddActiveRange(builder, ActiveRangeOffset);
			IAddGuestCharacter.AddGuestCharacterId(builder, GuestCharacterId);
			return IAddGuestCharacter.EndIAddGuestCharacter(builder);
		}

		// Token: 0x0602CF5B RID: 184155 RVA: 0x00625322 File Offset: 0x00623522
		public static void StartIAddGuestCharacter(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602CF5C RID: 184156 RVA: 0x0062532B File Offset: 0x0062352B
		public static void AddGuestCharacterId(FlatBufferBuilder builder, int guestCharacterId)
		{
			builder.AddInt(0, guestCharacterId, 0);
		}

		// Token: 0x0602CF5D RID: 184157 RVA: 0x00625336 File Offset: 0x00623536
		public static void AddActiveRange(FlatBufferBuilder builder, Offset<IActiveRange> activeRangeOffset)
		{
			builder.AddOffset(1, activeRangeOffset.Value, 0);
		}

		// Token: 0x0602CF5E RID: 184158 RVA: 0x00625346 File Offset: 0x00623546
		public static Offset<IAddGuestCharacter> EndIAddGuestCharacter(FlatBufferBuilder builder)
		{
			return new Offset<IAddGuestCharacter>(builder.EndTable());
		}

		// Token: 0x0602CF5F RID: 184159 RVA: 0x00625354 File Offset: 0x00623554
		public IAddGuestCharacterT UnPack()
		{
			IAddGuestCharacterT addGuestCharacterT = new IAddGuestCharacterT();
			this.UnPackTo(addGuestCharacterT);
			return addGuestCharacterT;
		}

		// Token: 0x0602CF60 RID: 184160 RVA: 0x00625370 File Offset: 0x00623570
		public void UnPackTo(IAddGuestCharacterT _o)
		{
			_o.GuestCharacterId = this.GuestCharacterId;
			_o.ActiveRange = ((this.ActiveRange != null) ? this.ActiveRange.Value.UnPack() : null);
		}

		// Token: 0x0602CF61 RID: 184161 RVA: 0x006253B8 File Offset: 0x006235B8
		public static Offset<IAddGuestCharacter> Pack(FlatBufferBuilder builder, IAddGuestCharacterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddGuestCharacter>);
			}
			Offset<IActiveRange> activeRangeOffset = (_o.ActiveRange == null) ? default(Offset<IActiveRange>) : IActiveRange.Pack(builder, _o.ActiveRange);
			return IAddGuestCharacter.CreateIAddGuestCharacter(builder, _o.GuestCharacterId, activeRangeOffset);
		}

		// Token: 0x04011307 RID: 70407
		private Table __p;
	}
}

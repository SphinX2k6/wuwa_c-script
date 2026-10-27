using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200612B RID: 24875
	public struct IAddGuestCharacter : IFlatbufferObject
	{
		// Token: 0x1700B757 RID: 46935
		// (get) Token: 0x0602A859 RID: 174169 RVA: 0x005DB023 File Offset: 0x005D9223
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A85A RID: 174170 RVA: 0x005DB030 File Offset: 0x005D9230
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A85B RID: 174171 RVA: 0x005DB038 File Offset: 0x005D9238
		public static IAddGuestCharacter GetRootAsIAddGuestCharacter(ByteBuffer _bb)
		{
			return IAddGuestCharacter.GetRootAsIAddGuestCharacter(_bb, default(IAddGuestCharacter));
		}

		// Token: 0x0602A85C RID: 174172 RVA: 0x005DB054 File Offset: 0x005D9254
		public static IAddGuestCharacter GetRootAsIAddGuestCharacter(ByteBuffer _bb, IAddGuestCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A85D RID: 174173 RVA: 0x005DB071 File Offset: 0x005D9271
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A85E RID: 174174 RVA: 0x005DB080 File Offset: 0x005D9280
		public IAddGuestCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B758 RID: 46936
		// (get) Token: 0x0602A85F RID: 174175 RVA: 0x005DB090 File Offset: 0x005D9290
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

		// Token: 0x1700B759 RID: 46937
		// (get) Token: 0x0602A860 RID: 174176 RVA: 0x005DB0CC File Offset: 0x005D92CC
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

		// Token: 0x0602A861 RID: 174177 RVA: 0x005DB129 File Offset: 0x005D9329
		public static Offset<IAddGuestCharacter> CreateIAddGuestCharacter(FlatBufferBuilder builder, int GuestCharacterId = 0, Offset<IActiveRange> ActiveRangeOffset = default(Offset<IActiveRange>))
		{
			builder.StartTable(2);
			IAddGuestCharacter.AddActiveRange(builder, ActiveRangeOffset);
			IAddGuestCharacter.AddGuestCharacterId(builder, GuestCharacterId);
			return IAddGuestCharacter.EndIAddGuestCharacter(builder);
		}

		// Token: 0x0602A862 RID: 174178 RVA: 0x005DB146 File Offset: 0x005D9346
		public static void StartIAddGuestCharacter(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602A863 RID: 174179 RVA: 0x005DB14F File Offset: 0x005D934F
		public static void AddGuestCharacterId(FlatBufferBuilder builder, int guestCharacterId)
		{
			builder.AddInt(0, guestCharacterId, 0);
		}

		// Token: 0x0602A864 RID: 174180 RVA: 0x005DB15A File Offset: 0x005D935A
		public static void AddActiveRange(FlatBufferBuilder builder, Offset<IActiveRange> activeRangeOffset)
		{
			builder.AddOffset(1, activeRangeOffset.Value, 0);
		}

		// Token: 0x0602A865 RID: 174181 RVA: 0x005DB16A File Offset: 0x005D936A
		public static Offset<IAddGuestCharacter> EndIAddGuestCharacter(FlatBufferBuilder builder)
		{
			return new Offset<IAddGuestCharacter>(builder.EndTable());
		}

		// Token: 0x0602A866 RID: 174182 RVA: 0x005DB178 File Offset: 0x005D9378
		public IAddGuestCharacterT UnPack()
		{
			IAddGuestCharacterT addGuestCharacterT = new IAddGuestCharacterT();
			this.UnPackTo(addGuestCharacterT);
			return addGuestCharacterT;
		}

		// Token: 0x0602A867 RID: 174183 RVA: 0x005DB194 File Offset: 0x005D9394
		public void UnPackTo(IAddGuestCharacterT _o)
		{
			_o.GuestCharacterId = this.GuestCharacterId;
			_o.ActiveRange = ((this.ActiveRange != null) ? this.ActiveRange.Value.UnPack() : null);
		}

		// Token: 0x0602A868 RID: 174184 RVA: 0x005DB1DC File Offset: 0x005D93DC
		public static Offset<IAddGuestCharacter> Pack(FlatBufferBuilder builder, IAddGuestCharacterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddGuestCharacter>);
			}
			Offset<IActiveRange> activeRangeOffset = (_o.ActiveRange == null) ? default(Offset<IActiveRange>) : IActiveRange.Pack(builder, _o.ActiveRange);
			return IAddGuestCharacter.CreateIAddGuestCharacter(builder, _o.GuestCharacterId, activeRangeOffset);
		}

		// Token: 0x04010500 RID: 66816
		private Table __p;
	}
}

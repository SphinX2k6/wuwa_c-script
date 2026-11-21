using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D6D RID: 23917
	public struct IPointLightOperations : IFlatbufferObject
	{
		// Token: 0x1700B004 RID: 45060
		// (get) Token: 0x06027D03 RID: 163075 RVA: 0x00572406 File Offset: 0x00570606
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027D04 RID: 163076 RVA: 0x00572413 File Offset: 0x00570613
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027D05 RID: 163077 RVA: 0x0057241C File Offset: 0x0057061C
		public static IPointLightOperations GetRootAsIPointLightOperations(ByteBuffer _bb)
		{
			return IPointLightOperations.GetRootAsIPointLightOperations(_bb, default(IPointLightOperations));
		}

		// Token: 0x06027D06 RID: 163078 RVA: 0x00572438 File Offset: 0x00570638
		public static IPointLightOperations GetRootAsIPointLightOperations(ByteBuffer _bb, IPointLightOperations obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027D07 RID: 163079 RVA: 0x00572455 File Offset: 0x00570655
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027D08 RID: 163080 RVA: 0x00572464 File Offset: 0x00570664
		public IPointLightOperations __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B005 RID: 45061
		// (get) Token: 0x06027D09 RID: 163081 RVA: 0x00572474 File Offset: 0x00570674
		public IEntityMatch? Match
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IEntityMatch?(default(IEntityMatch).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B006 RID: 45062
		// (get) Token: 0x06027D0A RID: 163082 RVA: 0x005724D4 File Offset: 0x005706D4
		public string SwitchToTargetState
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027D0B RID: 163083 RVA: 0x0057250B File Offset: 0x0057070B
		public Span<byte> GetSwitchToTargetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06027D0C RID: 163084 RVA: 0x0057251A File Offset: 0x0057071A
		public byte[] GetSwitchToTargetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06027D0D RID: 163085 RVA: 0x00572528 File Offset: 0x00570728
		public static Offset<IPointLightOperations> CreateIPointLightOperations(FlatBufferBuilder builder, Offset<IEntityMatch> MatchOffset = default(Offset<IEntityMatch>), StringOffset SwitchToTargetStateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IPointLightOperations.AddSwitchToTargetState(builder, SwitchToTargetStateOffset);
			IPointLightOperations.AddMatch(builder, MatchOffset);
			return IPointLightOperations.EndIPointLightOperations(builder);
		}

		// Token: 0x06027D0E RID: 163086 RVA: 0x00572545 File Offset: 0x00570745
		public static void StartIPointLightOperations(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027D0F RID: 163087 RVA: 0x0057254E File Offset: 0x0057074E
		public static void AddMatch(FlatBufferBuilder builder, Offset<IEntityMatch> matchOffset)
		{
			builder.AddOffset(0, matchOffset.Value, 0);
		}

		// Token: 0x06027D10 RID: 163088 RVA: 0x0057255E File Offset: 0x0057075E
		public static void AddSwitchToTargetState(FlatBufferBuilder builder, StringOffset switchToTargetStateOffset)
		{
			builder.AddOffset(1, switchToTargetStateOffset.Value, 0);
		}

		// Token: 0x06027D11 RID: 163089 RVA: 0x0057256E File Offset: 0x0057076E
		public static Offset<IPointLightOperations> EndIPointLightOperations(FlatBufferBuilder builder)
		{
			return new Offset<IPointLightOperations>(builder.EndTable());
		}

		// Token: 0x06027D12 RID: 163090 RVA: 0x0057257C File Offset: 0x0057077C
		public IPointLightOperationsT UnPack()
		{
			IPointLightOperationsT pointLightOperationsT = new IPointLightOperationsT();
			this.UnPackTo(pointLightOperationsT);
			return pointLightOperationsT;
		}

		// Token: 0x06027D13 RID: 163091 RVA: 0x00572598 File Offset: 0x00570798
		public void UnPackTo(IPointLightOperationsT _o)
		{
			_o.Match = ((this.Match != null) ? this.Match.Value.UnPack() : null);
			_o.SwitchToTargetState = this.SwitchToTargetState;
		}

		// Token: 0x06027D14 RID: 163092 RVA: 0x005725E0 File Offset: 0x005707E0
		public static Offset<IPointLightOperations> Pack(FlatBufferBuilder builder, IPointLightOperationsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPointLightOperations>);
			}
			Offset<IEntityMatch> matchOffset = (_o.Match == null) ? default(Offset<IEntityMatch>) : IEntityMatch.Pack(builder, _o.Match);
			StringOffset switchToTargetStateOffset = (_o.SwitchToTargetState == null) ? default(StringOffset) : builder.CreateString(_o.SwitchToTargetState);
			return IPointLightOperations.CreateIPointLightOperations(builder, matchOffset, switchToTargetStateOffset);
		}

		// Token: 0x0400F8F4 RID: 63732
		private Table __p;
	}
}

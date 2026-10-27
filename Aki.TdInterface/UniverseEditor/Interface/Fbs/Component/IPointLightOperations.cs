using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005766 RID: 22374
	public struct IPointLightOperations : IFlatbufferObject
	{
		// Token: 0x1700A6E0 RID: 42720
		// (get) Token: 0x060257E3 RID: 153571 RVA: 0x0052C27A File Offset: 0x0052A47A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060257E4 RID: 153572 RVA: 0x0052C287 File Offset: 0x0052A487
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060257E5 RID: 153573 RVA: 0x0052C290 File Offset: 0x0052A490
		public static IPointLightOperations GetRootAsIPointLightOperations(ByteBuffer _bb)
		{
			return IPointLightOperations.GetRootAsIPointLightOperations(_bb, default(IPointLightOperations));
		}

		// Token: 0x060257E6 RID: 153574 RVA: 0x0052C2AC File Offset: 0x0052A4AC
		public static IPointLightOperations GetRootAsIPointLightOperations(ByteBuffer _bb, IPointLightOperations obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060257E7 RID: 153575 RVA: 0x0052C2C9 File Offset: 0x0052A4C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060257E8 RID: 153576 RVA: 0x0052C2D8 File Offset: 0x0052A4D8
		public IPointLightOperations __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A6E1 RID: 42721
		// (get) Token: 0x060257E9 RID: 153577 RVA: 0x0052C2E8 File Offset: 0x0052A4E8
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

		// Token: 0x1700A6E2 RID: 42722
		// (get) Token: 0x060257EA RID: 153578 RVA: 0x0052C348 File Offset: 0x0052A548
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

		// Token: 0x060257EB RID: 153579 RVA: 0x0052C37F File Offset: 0x0052A57F
		public Span<byte> GetSwitchToTargetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060257EC RID: 153580 RVA: 0x0052C38E File Offset: 0x0052A58E
		public byte[] GetSwitchToTargetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060257ED RID: 153581 RVA: 0x0052C39C File Offset: 0x0052A59C
		public static Offset<IPointLightOperations> CreateIPointLightOperations(FlatBufferBuilder builder, Offset<IEntityMatch> MatchOffset = default(Offset<IEntityMatch>), StringOffset SwitchToTargetStateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IPointLightOperations.AddSwitchToTargetState(builder, SwitchToTargetStateOffset);
			IPointLightOperations.AddMatch(builder, MatchOffset);
			return IPointLightOperations.EndIPointLightOperations(builder);
		}

		// Token: 0x060257EE RID: 153582 RVA: 0x0052C3B9 File Offset: 0x0052A5B9
		public static void StartIPointLightOperations(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060257EF RID: 153583 RVA: 0x0052C3C2 File Offset: 0x0052A5C2
		public static void AddMatch(FlatBufferBuilder builder, Offset<IEntityMatch> matchOffset)
		{
			builder.AddOffset(0, matchOffset.Value, 0);
		}

		// Token: 0x060257F0 RID: 153584 RVA: 0x0052C3D2 File Offset: 0x0052A5D2
		public static void AddSwitchToTargetState(FlatBufferBuilder builder, StringOffset switchToTargetStateOffset)
		{
			builder.AddOffset(1, switchToTargetStateOffset.Value, 0);
		}

		// Token: 0x060257F1 RID: 153585 RVA: 0x0052C3E2 File Offset: 0x0052A5E2
		public static Offset<IPointLightOperations> EndIPointLightOperations(FlatBufferBuilder builder)
		{
			return new Offset<IPointLightOperations>(builder.EndTable());
		}

		// Token: 0x060257F2 RID: 153586 RVA: 0x0052C3F0 File Offset: 0x0052A5F0
		public IPointLightOperationsT UnPack()
		{
			IPointLightOperationsT pointLightOperationsT = new IPointLightOperationsT();
			this.UnPackTo(pointLightOperationsT);
			return pointLightOperationsT;
		}

		// Token: 0x060257F3 RID: 153587 RVA: 0x0052C40C File Offset: 0x0052A60C
		public void UnPackTo(IPointLightOperationsT _o)
		{
			_o.Match = ((this.Match != null) ? this.Match.Value.UnPack() : null);
			_o.SwitchToTargetState = this.SwitchToTargetState;
		}

		// Token: 0x060257F4 RID: 153588 RVA: 0x0052C454 File Offset: 0x0052A654
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

		// Token: 0x0400EC09 RID: 60425
		private Table __p;
	}
}

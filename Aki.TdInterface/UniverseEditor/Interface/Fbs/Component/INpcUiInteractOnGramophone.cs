using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C15 RID: 23573
	public struct INpcUiInteractOnGramophone : IFlatbufferObject
	{
		// Token: 0x1700ACB9 RID: 44217
		// (get) Token: 0x06026FB8 RID: 159672 RVA: 0x005564E6 File Offset: 0x005546E6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026FB9 RID: 159673 RVA: 0x005564F3 File Offset: 0x005546F3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026FBA RID: 159674 RVA: 0x005564FC File Offset: 0x005546FC
		public static INpcUiInteractOnGramophone GetRootAsINpcUiInteractOnGramophone(ByteBuffer _bb)
		{
			return INpcUiInteractOnGramophone.GetRootAsINpcUiInteractOnGramophone(_bb, default(INpcUiInteractOnGramophone));
		}

		// Token: 0x06026FBB RID: 159675 RVA: 0x00556518 File Offset: 0x00554718
		public static INpcUiInteractOnGramophone GetRootAsINpcUiInteractOnGramophone(ByteBuffer _bb, INpcUiInteractOnGramophone obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026FBC RID: 159676 RVA: 0x00556535 File Offset: 0x00554735
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026FBD RID: 159677 RVA: 0x00556544 File Offset: 0x00554744
		public INpcUiInteractOnGramophone __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ACBA RID: 44218
		// (get) Token: 0x06026FBE RID: 159678 RVA: 0x00556554 File Offset: 0x00554754
		public ENpcUiInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcUiInteractType.HandInItem;
				}
				return (ENpcUiInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700ACBB RID: 44219
		// (get) Token: 0x06026FBF RID: 159679 RVA: 0x00556590 File Offset: 0x00554790
		public string EnterMontage
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

		// Token: 0x06026FC0 RID: 159680 RVA: 0x005565C7 File Offset: 0x005547C7
		public Span<byte> GetEnterMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06026FC1 RID: 159681 RVA: 0x005565D6 File Offset: 0x005547D6
		public byte[] GetEnterMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700ACBC RID: 44220
		// (get) Token: 0x06026FC2 RID: 159682 RVA: 0x005565E4 File Offset: 0x005547E4
		public string StandByMontage
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026FC3 RID: 159683 RVA: 0x0055661B File Offset: 0x0055481B
		public Span<byte> GetStandByMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06026FC4 RID: 159684 RVA: 0x0055662A File Offset: 0x0055482A
		public byte[] GetStandByMontageArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700ACBD RID: 44221
		// (get) Token: 0x06026FC5 RID: 159685 RVA: 0x00556638 File Offset: 0x00554838
		public string SwitchMusicMontage
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026FC6 RID: 159686 RVA: 0x00556670 File Offset: 0x00554870
		public Span<byte> GetSwitchMusicMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06026FC7 RID: 159687 RVA: 0x00556680 File Offset: 0x00554880
		public byte[] GetSwitchMusicMontageArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700ACBE RID: 44222
		// (get) Token: 0x06026FC8 RID: 159688 RVA: 0x00556690 File Offset: 0x00554890
		public string ExitMontage
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026FC9 RID: 159689 RVA: 0x005566C8 File Offset: 0x005548C8
		public Span<byte> GetExitMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06026FCA RID: 159690 RVA: 0x005566D8 File Offset: 0x005548D8
		public byte[] GetExitMontageArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700ACBF RID: 44223
		// (get) Token: 0x06026FCB RID: 159691 RVA: 0x005566E8 File Offset: 0x005548E8
		public IPlayFlow? EnterFlow
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700ACC0 RID: 44224
		// (get) Token: 0x06026FCC RID: 159692 RVA: 0x00556748 File Offset: 0x00554948
		public IPlayFlow? FailedFlow
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700ACC1 RID: 44225
		// (get) Token: 0x06026FCD RID: 159693 RVA: 0x005567A8 File Offset: 0x005549A8
		public IPlayFlow? SuccessFlow
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06026FCE RID: 159694 RVA: 0x00556808 File Offset: 0x00554A08
		public static Offset<INpcUiInteractOnGramophone> CreateINpcUiInteractOnGramophone(FlatBufferBuilder builder, ENpcUiInteractType Type = ENpcUiInteractType.HandInItem, StringOffset EnterMontageOffset = default(StringOffset), StringOffset StandByMontageOffset = default(StringOffset), StringOffset SwitchMusicMontageOffset = default(StringOffset), StringOffset ExitMontageOffset = default(StringOffset), Offset<IPlayFlow> EnterFlowOffset = default(Offset<IPlayFlow>), Offset<IPlayFlow> FailedFlowOffset = default(Offset<IPlayFlow>), Offset<IPlayFlow> SuccessFlowOffset = default(Offset<IPlayFlow>))
		{
			builder.StartTable(8);
			INpcUiInteractOnGramophone.AddSuccessFlow(builder, SuccessFlowOffset);
			INpcUiInteractOnGramophone.AddFailedFlow(builder, FailedFlowOffset);
			INpcUiInteractOnGramophone.AddEnterFlow(builder, EnterFlowOffset);
			INpcUiInteractOnGramophone.AddExitMontage(builder, ExitMontageOffset);
			INpcUiInteractOnGramophone.AddSwitchMusicMontage(builder, SwitchMusicMontageOffset);
			INpcUiInteractOnGramophone.AddStandByMontage(builder, StandByMontageOffset);
			INpcUiInteractOnGramophone.AddEnterMontage(builder, EnterMontageOffset);
			INpcUiInteractOnGramophone.AddType(builder, Type);
			return INpcUiInteractOnGramophone.EndINpcUiInteractOnGramophone(builder);
		}

		// Token: 0x06026FCF RID: 159695 RVA: 0x0055685F File Offset: 0x00554A5F
		public static void StartINpcUiInteractOnGramophone(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06026FD0 RID: 159696 RVA: 0x00556868 File Offset: 0x00554A68
		public static void AddType(FlatBufferBuilder builder, ENpcUiInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026FD1 RID: 159697 RVA: 0x00556873 File Offset: 0x00554A73
		public static void AddEnterMontage(FlatBufferBuilder builder, StringOffset enterMontageOffset)
		{
			builder.AddOffset(1, enterMontageOffset.Value, 0);
		}

		// Token: 0x06026FD2 RID: 159698 RVA: 0x00556883 File Offset: 0x00554A83
		public static void AddStandByMontage(FlatBufferBuilder builder, StringOffset standByMontageOffset)
		{
			builder.AddOffset(2, standByMontageOffset.Value, 0);
		}

		// Token: 0x06026FD3 RID: 159699 RVA: 0x00556893 File Offset: 0x00554A93
		public static void AddSwitchMusicMontage(FlatBufferBuilder builder, StringOffset switchMusicMontageOffset)
		{
			builder.AddOffset(3, switchMusicMontageOffset.Value, 0);
		}

		// Token: 0x06026FD4 RID: 159700 RVA: 0x005568A3 File Offset: 0x00554AA3
		public static void AddExitMontage(FlatBufferBuilder builder, StringOffset exitMontageOffset)
		{
			builder.AddOffset(4, exitMontageOffset.Value, 0);
		}

		// Token: 0x06026FD5 RID: 159701 RVA: 0x005568B3 File Offset: 0x00554AB3
		public static void AddEnterFlow(FlatBufferBuilder builder, Offset<IPlayFlow> enterFlowOffset)
		{
			builder.AddOffset(5, enterFlowOffset.Value, 0);
		}

		// Token: 0x06026FD6 RID: 159702 RVA: 0x005568C3 File Offset: 0x00554AC3
		public static void AddFailedFlow(FlatBufferBuilder builder, Offset<IPlayFlow> failedFlowOffset)
		{
			builder.AddOffset(6, failedFlowOffset.Value, 0);
		}

		// Token: 0x06026FD7 RID: 159703 RVA: 0x005568D3 File Offset: 0x00554AD3
		public static void AddSuccessFlow(FlatBufferBuilder builder, Offset<IPlayFlow> successFlowOffset)
		{
			builder.AddOffset(7, successFlowOffset.Value, 0);
		}

		// Token: 0x06026FD8 RID: 159704 RVA: 0x005568E3 File Offset: 0x00554AE3
		public static Offset<INpcUiInteractOnGramophone> EndINpcUiInteractOnGramophone(FlatBufferBuilder builder)
		{
			return new Offset<INpcUiInteractOnGramophone>(builder.EndTable());
		}

		// Token: 0x06026FD9 RID: 159705 RVA: 0x005568F0 File Offset: 0x00554AF0
		public INpcUiInteractOnGramophoneT UnPack()
		{
			INpcUiInteractOnGramophoneT npcUiInteractOnGramophoneT = new INpcUiInteractOnGramophoneT();
			this.UnPackTo(npcUiInteractOnGramophoneT);
			return npcUiInteractOnGramophoneT;
		}

		// Token: 0x06026FDA RID: 159706 RVA: 0x0055690C File Offset: 0x00554B0C
		public void UnPackTo(INpcUiInteractOnGramophoneT _o)
		{
			_o.Type = this.Type;
			_o.EnterMontage = this.EnterMontage;
			_o.StandByMontage = this.StandByMontage;
			_o.SwitchMusicMontage = this.SwitchMusicMontage;
			_o.ExitMontage = this.ExitMontage;
			_o.EnterFlow = ((this.EnterFlow != null) ? this.EnterFlow.Value.UnPack() : null);
			_o.FailedFlow = ((this.FailedFlow != null) ? this.FailedFlow.Value.UnPack() : null);
			_o.SuccessFlow = ((this.SuccessFlow != null) ? this.SuccessFlow.Value.UnPack() : null);
		}

		// Token: 0x06026FDB RID: 159707 RVA: 0x005569E4 File Offset: 0x00554BE4
		public static Offset<INpcUiInteractOnGramophone> Pack(FlatBufferBuilder builder, INpcUiInteractOnGramophoneT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcUiInteractOnGramophone>);
			}
			StringOffset enterMontageOffset = (_o.EnterMontage == null) ? default(StringOffset) : builder.CreateString(_o.EnterMontage);
			StringOffset standByMontageOffset = (_o.StandByMontage == null) ? default(StringOffset) : builder.CreateString(_o.StandByMontage);
			StringOffset switchMusicMontageOffset = (_o.SwitchMusicMontage == null) ? default(StringOffset) : builder.CreateString(_o.SwitchMusicMontage);
			StringOffset exitMontageOffset = (_o.ExitMontage == null) ? default(StringOffset) : builder.CreateString(_o.ExitMontage);
			Offset<IPlayFlow> enterFlowOffset = (_o.EnterFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.EnterFlow);
			Offset<IPlayFlow> failedFlowOffset = (_o.FailedFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.FailedFlow);
			Offset<IPlayFlow> successFlowOffset = (_o.SuccessFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.SuccessFlow);
			return INpcUiInteractOnGramophone.CreateINpcUiInteractOnGramophone(builder, _o.Type, enterMontageOffset, standByMontageOffset, switchMusicMontageOffset, exitMontageOffset, enterFlowOffset, failedFlowOffset, successFlowOffset);
		}

		// Token: 0x0400F6B7 RID: 63159
		private Table __p;
	}
}

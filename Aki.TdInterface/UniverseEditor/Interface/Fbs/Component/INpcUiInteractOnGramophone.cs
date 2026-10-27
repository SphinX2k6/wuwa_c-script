using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005674 RID: 22132
	public struct INpcUiInteractOnGramophone : IFlatbufferObject
	{
		// Token: 0x1700A42A RID: 42026
		// (get) Token: 0x06024D7F RID: 150911 RVA: 0x0051594A File Offset: 0x00513B4A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024D80 RID: 150912 RVA: 0x00515957 File Offset: 0x00513B57
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024D81 RID: 150913 RVA: 0x00515960 File Offset: 0x00513B60
		public static INpcUiInteractOnGramophone GetRootAsINpcUiInteractOnGramophone(ByteBuffer _bb)
		{
			return INpcUiInteractOnGramophone.GetRootAsINpcUiInteractOnGramophone(_bb, default(INpcUiInteractOnGramophone));
		}

		// Token: 0x06024D82 RID: 150914 RVA: 0x0051597C File Offset: 0x00513B7C
		public static INpcUiInteractOnGramophone GetRootAsINpcUiInteractOnGramophone(ByteBuffer _bb, INpcUiInteractOnGramophone obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024D83 RID: 150915 RVA: 0x00515999 File Offset: 0x00513B99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024D84 RID: 150916 RVA: 0x005159A8 File Offset: 0x00513BA8
		public INpcUiInteractOnGramophone __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A42B RID: 42027
		// (get) Token: 0x06024D85 RID: 150917 RVA: 0x005159B8 File Offset: 0x00513BB8
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

		// Token: 0x1700A42C RID: 42028
		// (get) Token: 0x06024D86 RID: 150918 RVA: 0x005159F4 File Offset: 0x00513BF4
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

		// Token: 0x06024D87 RID: 150919 RVA: 0x00515A2B File Offset: 0x00513C2B
		public Span<byte> GetEnterMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06024D88 RID: 150920 RVA: 0x00515A3A File Offset: 0x00513C3A
		public byte[] GetEnterMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700A42D RID: 42029
		// (get) Token: 0x06024D89 RID: 150921 RVA: 0x00515A48 File Offset: 0x00513C48
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

		// Token: 0x06024D8A RID: 150922 RVA: 0x00515A7F File Offset: 0x00513C7F
		public Span<byte> GetStandByMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06024D8B RID: 150923 RVA: 0x00515A8E File Offset: 0x00513C8E
		public byte[] GetStandByMontageArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700A42E RID: 42030
		// (get) Token: 0x06024D8C RID: 150924 RVA: 0x00515A9C File Offset: 0x00513C9C
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

		// Token: 0x06024D8D RID: 150925 RVA: 0x00515AD4 File Offset: 0x00513CD4
		public Span<byte> GetSwitchMusicMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06024D8E RID: 150926 RVA: 0x00515AE4 File Offset: 0x00513CE4
		public byte[] GetSwitchMusicMontageArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700A42F RID: 42031
		// (get) Token: 0x06024D8F RID: 150927 RVA: 0x00515AF4 File Offset: 0x00513CF4
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

		// Token: 0x06024D90 RID: 150928 RVA: 0x00515B2C File Offset: 0x00513D2C
		public Span<byte> GetExitMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06024D91 RID: 150929 RVA: 0x00515B3C File Offset: 0x00513D3C
		public byte[] GetExitMontageArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700A430 RID: 42032
		// (get) Token: 0x06024D92 RID: 150930 RVA: 0x00515B4C File Offset: 0x00513D4C
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

		// Token: 0x1700A431 RID: 42033
		// (get) Token: 0x06024D93 RID: 150931 RVA: 0x00515BAC File Offset: 0x00513DAC
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

		// Token: 0x1700A432 RID: 42034
		// (get) Token: 0x06024D94 RID: 150932 RVA: 0x00515C0C File Offset: 0x00513E0C
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

		// Token: 0x06024D95 RID: 150933 RVA: 0x00515C6C File Offset: 0x00513E6C
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

		// Token: 0x06024D96 RID: 150934 RVA: 0x00515CC3 File Offset: 0x00513EC3
		public static void StartINpcUiInteractOnGramophone(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06024D97 RID: 150935 RVA: 0x00515CCC File Offset: 0x00513ECC
		public static void AddType(FlatBufferBuilder builder, ENpcUiInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024D98 RID: 150936 RVA: 0x00515CD7 File Offset: 0x00513ED7
		public static void AddEnterMontage(FlatBufferBuilder builder, StringOffset enterMontageOffset)
		{
			builder.AddOffset(1, enterMontageOffset.Value, 0);
		}

		// Token: 0x06024D99 RID: 150937 RVA: 0x00515CE7 File Offset: 0x00513EE7
		public static void AddStandByMontage(FlatBufferBuilder builder, StringOffset standByMontageOffset)
		{
			builder.AddOffset(2, standByMontageOffset.Value, 0);
		}

		// Token: 0x06024D9A RID: 150938 RVA: 0x00515CF7 File Offset: 0x00513EF7
		public static void AddSwitchMusicMontage(FlatBufferBuilder builder, StringOffset switchMusicMontageOffset)
		{
			builder.AddOffset(3, switchMusicMontageOffset.Value, 0);
		}

		// Token: 0x06024D9B RID: 150939 RVA: 0x00515D07 File Offset: 0x00513F07
		public static void AddExitMontage(FlatBufferBuilder builder, StringOffset exitMontageOffset)
		{
			builder.AddOffset(4, exitMontageOffset.Value, 0);
		}

		// Token: 0x06024D9C RID: 150940 RVA: 0x00515D17 File Offset: 0x00513F17
		public static void AddEnterFlow(FlatBufferBuilder builder, Offset<IPlayFlow> enterFlowOffset)
		{
			builder.AddOffset(5, enterFlowOffset.Value, 0);
		}

		// Token: 0x06024D9D RID: 150941 RVA: 0x00515D27 File Offset: 0x00513F27
		public static void AddFailedFlow(FlatBufferBuilder builder, Offset<IPlayFlow> failedFlowOffset)
		{
			builder.AddOffset(6, failedFlowOffset.Value, 0);
		}

		// Token: 0x06024D9E RID: 150942 RVA: 0x00515D37 File Offset: 0x00513F37
		public static void AddSuccessFlow(FlatBufferBuilder builder, Offset<IPlayFlow> successFlowOffset)
		{
			builder.AddOffset(7, successFlowOffset.Value, 0);
		}

		// Token: 0x06024D9F RID: 150943 RVA: 0x00515D47 File Offset: 0x00513F47
		public static Offset<INpcUiInteractOnGramophone> EndINpcUiInteractOnGramophone(FlatBufferBuilder builder)
		{
			return new Offset<INpcUiInteractOnGramophone>(builder.EndTable());
		}

		// Token: 0x06024DA0 RID: 150944 RVA: 0x00515D54 File Offset: 0x00513F54
		public INpcUiInteractOnGramophoneT UnPack()
		{
			INpcUiInteractOnGramophoneT npcUiInteractOnGramophoneT = new INpcUiInteractOnGramophoneT();
			this.UnPackTo(npcUiInteractOnGramophoneT);
			return npcUiInteractOnGramophoneT;
		}

		// Token: 0x06024DA1 RID: 150945 RVA: 0x00515D70 File Offset: 0x00513F70
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

		// Token: 0x06024DA2 RID: 150946 RVA: 0x00515E48 File Offset: 0x00514048
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

		// Token: 0x0400EA4E RID: 59982
		private Table __p;
	}
}

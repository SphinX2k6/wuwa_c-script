using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D92 RID: 28050
	public struct IPreloadFlows : IFlatbufferObject
	{
		// Token: 0x1700D13C RID: 53564
		// (get) Token: 0x060318C5 RID: 202949 RVA: 0x006B7402 File Offset: 0x006B5602
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060318C6 RID: 202950 RVA: 0x006B740F File Offset: 0x006B560F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060318C7 RID: 202951 RVA: 0x006B7418 File Offset: 0x006B5618
		public static IPreloadFlows GetRootAsIPreloadFlows(ByteBuffer _bb)
		{
			return IPreloadFlows.GetRootAsIPreloadFlows(_bb, default(IPreloadFlows));
		}

		// Token: 0x060318C8 RID: 202952 RVA: 0x006B7434 File Offset: 0x006B5634
		public static IPreloadFlows GetRootAsIPreloadFlows(ByteBuffer _bb, IPreloadFlows obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060318C9 RID: 202953 RVA: 0x006B7451 File Offset: 0x006B5651
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060318CA RID: 202954 RVA: 0x006B7460 File Offset: 0x006B5660
		public IPreloadFlows __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D13D RID: 53565
		// (get) Token: 0x060318CB RID: 202955 RVA: 0x006B7470 File Offset: 0x006B5670
		public EPreloadObjectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPreloadObjectType.PreloadTrialCharacterForSkill;
				}
				return (EPreloadObjectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D13E RID: 53566
		// (get) Token: 0x060318CC RID: 202956 RVA: 0x006B74AC File Offset: 0x006B56AC
		public IPlayFlow? FlowData
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060318CD RID: 202957 RVA: 0x006B7509 File Offset: 0x006B5709
		public static Offset<IPreloadFlows> CreateIPreloadFlows(FlatBufferBuilder builder, EPreloadObjectType Type = EPreloadObjectType.PreloadTrialCharacterForSkill, Offset<IPlayFlow> FlowDataOffset = default(Offset<IPlayFlow>))
		{
			builder.StartTable(2);
			IPreloadFlows.AddFlowData(builder, FlowDataOffset);
			IPreloadFlows.AddType(builder, Type);
			return IPreloadFlows.EndIPreloadFlows(builder);
		}

		// Token: 0x060318CE RID: 202958 RVA: 0x006B7526 File Offset: 0x006B5726
		public static void StartIPreloadFlows(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060318CF RID: 202959 RVA: 0x006B752F File Offset: 0x006B572F
		public static void AddType(FlatBufferBuilder builder, EPreloadObjectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060318D0 RID: 202960 RVA: 0x006B753A File Offset: 0x006B573A
		public static void AddFlowData(FlatBufferBuilder builder, Offset<IPlayFlow> flowDataOffset)
		{
			builder.AddOffset(1, flowDataOffset.Value, 0);
		}

		// Token: 0x060318D1 RID: 202961 RVA: 0x006B754A File Offset: 0x006B574A
		public static Offset<IPreloadFlows> EndIPreloadFlows(FlatBufferBuilder builder)
		{
			return new Offset<IPreloadFlows>(builder.EndTable());
		}

		// Token: 0x060318D2 RID: 202962 RVA: 0x006B7558 File Offset: 0x006B5758
		public IPreloadFlowsT UnPack()
		{
			IPreloadFlowsT preloadFlowsT = new IPreloadFlowsT();
			this.UnPackTo(preloadFlowsT);
			return preloadFlowsT;
		}

		// Token: 0x060318D3 RID: 202963 RVA: 0x006B7574 File Offset: 0x006B5774
		public void UnPackTo(IPreloadFlowsT _o)
		{
			_o.Type = this.Type;
			_o.FlowData = ((this.FlowData != null) ? this.FlowData.Value.UnPack() : null);
		}

		// Token: 0x060318D4 RID: 202964 RVA: 0x006B75BC File Offset: 0x006B57BC
		public static Offset<IPreloadFlows> Pack(FlatBufferBuilder builder, IPreloadFlowsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPreloadFlows>);
			}
			Offset<IPlayFlow> flowDataOffset = (_o.FlowData == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.FlowData);
			return IPreloadFlows.CreateIPreloadFlows(builder, _o.Type, flowDataOffset);
		}

		// Token: 0x04011765 RID: 71525
		private Table __p;
	}
}

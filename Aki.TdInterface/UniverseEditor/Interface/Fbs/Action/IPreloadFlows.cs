using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200750D RID: 29965
	public struct IPreloadFlows : IFlatbufferObject
	{
		// Token: 0x1700DC84 RID: 56452
		// (get) Token: 0x060348C1 RID: 215233 RVA: 0x00712AEA File Offset: 0x00710CEA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060348C2 RID: 215234 RVA: 0x00712AF7 File Offset: 0x00710CF7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060348C3 RID: 215235 RVA: 0x00712B00 File Offset: 0x00710D00
		public static IPreloadFlows GetRootAsIPreloadFlows(ByteBuffer _bb)
		{
			return IPreloadFlows.GetRootAsIPreloadFlows(_bb, default(IPreloadFlows));
		}

		// Token: 0x060348C4 RID: 215236 RVA: 0x00712B1C File Offset: 0x00710D1C
		public static IPreloadFlows GetRootAsIPreloadFlows(ByteBuffer _bb, IPreloadFlows obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060348C5 RID: 215237 RVA: 0x00712B39 File Offset: 0x00710D39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060348C6 RID: 215238 RVA: 0x00712B48 File Offset: 0x00710D48
		public IPreloadFlows __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DC85 RID: 56453
		// (get) Token: 0x060348C7 RID: 215239 RVA: 0x00712B58 File Offset: 0x00710D58
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

		// Token: 0x1700DC86 RID: 56454
		// (get) Token: 0x060348C8 RID: 215240 RVA: 0x00712B94 File Offset: 0x00710D94
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

		// Token: 0x060348C9 RID: 215241 RVA: 0x00712BF1 File Offset: 0x00710DF1
		public static Offset<IPreloadFlows> CreateIPreloadFlows(FlatBufferBuilder builder, EPreloadObjectType Type = EPreloadObjectType.PreloadTrialCharacterForSkill, Offset<IPlayFlow> FlowDataOffset = default(Offset<IPlayFlow>))
		{
			builder.StartTable(2);
			IPreloadFlows.AddFlowData(builder, FlowDataOffset);
			IPreloadFlows.AddType(builder, Type);
			return IPreloadFlows.EndIPreloadFlows(builder);
		}

		// Token: 0x060348CA RID: 215242 RVA: 0x00712C0E File Offset: 0x00710E0E
		public static void StartIPreloadFlows(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060348CB RID: 215243 RVA: 0x00712C17 File Offset: 0x00710E17
		public static void AddType(FlatBufferBuilder builder, EPreloadObjectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060348CC RID: 215244 RVA: 0x00712C22 File Offset: 0x00710E22
		public static void AddFlowData(FlatBufferBuilder builder, Offset<IPlayFlow> flowDataOffset)
		{
			builder.AddOffset(1, flowDataOffset.Value, 0);
		}

		// Token: 0x060348CD RID: 215245 RVA: 0x00712C32 File Offset: 0x00710E32
		public static Offset<IPreloadFlows> EndIPreloadFlows(FlatBufferBuilder builder)
		{
			return new Offset<IPreloadFlows>(builder.EndTable());
		}

		// Token: 0x060348CE RID: 215246 RVA: 0x00712C40 File Offset: 0x00710E40
		public IPreloadFlowsT UnPack()
		{
			IPreloadFlowsT preloadFlowsT = new IPreloadFlowsT();
			this.UnPackTo(preloadFlowsT);
			return preloadFlowsT;
		}

		// Token: 0x060348CF RID: 215247 RVA: 0x00712C5C File Offset: 0x00710E5C
		public void UnPackTo(IPreloadFlowsT _o)
		{
			_o.Type = this.Type;
			_o.FlowData = ((this.FlowData != null) ? this.FlowData.Value.UnPack() : null);
		}

		// Token: 0x060348D0 RID: 215248 RVA: 0x00712CA4 File Offset: 0x00710EA4
		public static Offset<IPreloadFlows> Pack(FlatBufferBuilder builder, IPreloadFlowsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPreloadFlows>);
			}
			Offset<IPlayFlow> flowDataOffset = (_o.FlowData == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.FlowData);
			return IPreloadFlows.CreateIPreloadFlows(builder, _o.Type, flowDataOffset);
		}

		// Token: 0x040126E1 RID: 75489
		private Table __p;
	}
}

using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x0200474B RID: 18251
	public struct IPlotPosPlayFlow : IFlatbufferObject
	{
		// Token: 0x170082F3 RID: 33523
		// (get) Token: 0x0601C171 RID: 115057 RVA: 0x003FAE7F File Offset: 0x003F907F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C172 RID: 115058 RVA: 0x003FAE8C File Offset: 0x003F908C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C173 RID: 115059 RVA: 0x003FAE94 File Offset: 0x003F9094
		public static IPlotPosPlayFlow GetRootAsIPlotPosPlayFlow(ByteBuffer _bb)
		{
			return IPlotPosPlayFlow.GetRootAsIPlotPosPlayFlow(_bb, default(IPlotPosPlayFlow));
		}

		// Token: 0x0601C174 RID: 115060 RVA: 0x003FAEB0 File Offset: 0x003F90B0
		public static IPlotPosPlayFlow GetRootAsIPlotPosPlayFlow(ByteBuffer _bb, IPlotPosPlayFlow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C175 RID: 115061 RVA: 0x003FAECD File Offset: 0x003F90CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C176 RID: 115062 RVA: 0x003FAEDC File Offset: 0x003F90DC
		public IPlotPosPlayFlow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170082F4 RID: 33524
		// (get) Token: 0x0601C177 RID: 115063 RVA: 0x003FAEEC File Offset: 0x003F90EC
		public string Guid
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C178 RID: 115064 RVA: 0x003FAF23 File Offset: 0x003F9123
		public Span<byte> GetGuidBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601C179 RID: 115065 RVA: 0x003FAF32 File Offset: 0x003F9132
		public byte[] GetGuidArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170082F5 RID: 33525
		// (get) Token: 0x0601C17A RID: 115066 RVA: 0x003FAF40 File Offset: 0x003F9140
		public IVectorInfo? Pos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601C17B RID: 115067 RVA: 0x003FAF9D File Offset: 0x003F919D
		public static Offset<IPlotPosPlayFlow> CreateIPlotPosPlayFlow(FlatBufferBuilder builder, StringOffset GuidOffset = default(StringOffset), Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IPlotPosPlayFlow.AddPos(builder, PosOffset);
			IPlotPosPlayFlow.AddGuid(builder, GuidOffset);
			return IPlotPosPlayFlow.EndIPlotPosPlayFlow(builder);
		}

		// Token: 0x0601C17C RID: 115068 RVA: 0x003FAFBA File Offset: 0x003F91BA
		public static void StartIPlotPosPlayFlow(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C17D RID: 115069 RVA: 0x003FAFC3 File Offset: 0x003F91C3
		public static void AddGuid(FlatBufferBuilder builder, StringOffset guidOffset)
		{
			builder.AddOffset(0, guidOffset.Value, 0);
		}

		// Token: 0x0601C17E RID: 115070 RVA: 0x003FAFD3 File Offset: 0x003F91D3
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x0601C17F RID: 115071 RVA: 0x003FAFE3 File Offset: 0x003F91E3
		public static Offset<IPlotPosPlayFlow> EndIPlotPosPlayFlow(FlatBufferBuilder builder)
		{
			return new Offset<IPlotPosPlayFlow>(builder.EndTable());
		}

		// Token: 0x0601C180 RID: 115072 RVA: 0x003FAFF0 File Offset: 0x003F91F0
		public IPlotPosPlayFlowT UnPack()
		{
			IPlotPosPlayFlowT plotPosPlayFlowT = new IPlotPosPlayFlowT();
			this.UnPackTo(plotPosPlayFlowT);
			return plotPosPlayFlowT;
		}

		// Token: 0x0601C181 RID: 115073 RVA: 0x003FB00C File Offset: 0x003F920C
		public void UnPackTo(IPlotPosPlayFlowT _o)
		{
			_o.Guid = this.Guid;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
		}

		// Token: 0x0601C182 RID: 115074 RVA: 0x003FB054 File Offset: 0x003F9254
		public static Offset<IPlotPosPlayFlow> Pack(FlatBufferBuilder builder, IPlotPosPlayFlowT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlotPosPlayFlow>);
			}
			StringOffset guidOffset = (_o.Guid == null) ? default(StringOffset) : builder.CreateString(_o.Guid);
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			return IPlotPosPlayFlow.CreateIPlotPosPlayFlow(builder, guidOffset, posOffset);
		}

		// Token: 0x0400CA39 RID: 51769
		private Table __p;
	}
}

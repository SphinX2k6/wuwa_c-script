using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004BB3 RID: 19379
	public struct IPlotPosPlayFlow : IFlatbufferObject
	{
		// Token: 0x17008934 RID: 35124
		// (get) Token: 0x0601D946 RID: 121158 RVA: 0x0042711B File Offset: 0x0042531B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D947 RID: 121159 RVA: 0x00427128 File Offset: 0x00425328
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D948 RID: 121160 RVA: 0x00427130 File Offset: 0x00425330
		public static IPlotPosPlayFlow GetRootAsIPlotPosPlayFlow(ByteBuffer _bb)
		{
			return IPlotPosPlayFlow.GetRootAsIPlotPosPlayFlow(_bb, default(IPlotPosPlayFlow));
		}

		// Token: 0x0601D949 RID: 121161 RVA: 0x0042714C File Offset: 0x0042534C
		public static IPlotPosPlayFlow GetRootAsIPlotPosPlayFlow(ByteBuffer _bb, IPlotPosPlayFlow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D94A RID: 121162 RVA: 0x00427169 File Offset: 0x00425369
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D94B RID: 121163 RVA: 0x00427178 File Offset: 0x00425378
		public IPlotPosPlayFlow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008935 RID: 35125
		// (get) Token: 0x0601D94C RID: 121164 RVA: 0x00427188 File Offset: 0x00425388
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

		// Token: 0x0601D94D RID: 121165 RVA: 0x004271BF File Offset: 0x004253BF
		public Span<byte> GetGuidBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601D94E RID: 121166 RVA: 0x004271CE File Offset: 0x004253CE
		public byte[] GetGuidArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008936 RID: 35126
		// (get) Token: 0x0601D94F RID: 121167 RVA: 0x004271DC File Offset: 0x004253DC
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

		// Token: 0x0601D950 RID: 121168 RVA: 0x00427239 File Offset: 0x00425439
		public static Offset<IPlotPosPlayFlow> CreateIPlotPosPlayFlow(FlatBufferBuilder builder, StringOffset GuidOffset = default(StringOffset), Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IPlotPosPlayFlow.AddPos(builder, PosOffset);
			IPlotPosPlayFlow.AddGuid(builder, GuidOffset);
			return IPlotPosPlayFlow.EndIPlotPosPlayFlow(builder);
		}

		// Token: 0x0601D951 RID: 121169 RVA: 0x00427256 File Offset: 0x00425456
		public static void StartIPlotPosPlayFlow(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D952 RID: 121170 RVA: 0x0042725F File Offset: 0x0042545F
		public static void AddGuid(FlatBufferBuilder builder, StringOffset guidOffset)
		{
			builder.AddOffset(0, guidOffset.Value, 0);
		}

		// Token: 0x0601D953 RID: 121171 RVA: 0x0042726F File Offset: 0x0042546F
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x0601D954 RID: 121172 RVA: 0x0042727F File Offset: 0x0042547F
		public static Offset<IPlotPosPlayFlow> EndIPlotPosPlayFlow(FlatBufferBuilder builder)
		{
			return new Offset<IPlotPosPlayFlow>(builder.EndTable());
		}

		// Token: 0x0601D955 RID: 121173 RVA: 0x0042728C File Offset: 0x0042548C
		public IPlotPosPlayFlowT UnPack()
		{
			IPlotPosPlayFlowT plotPosPlayFlowT = new IPlotPosPlayFlowT();
			this.UnPackTo(plotPosPlayFlowT);
			return plotPosPlayFlowT;
		}

		// Token: 0x0601D956 RID: 121174 RVA: 0x004272A8 File Offset: 0x004254A8
		public void UnPackTo(IPlotPosPlayFlowT _o)
		{
			_o.Guid = this.Guid;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
		}

		// Token: 0x0601D957 RID: 121175 RVA: 0x004272F0 File Offset: 0x004254F0
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

		// Token: 0x0400D468 RID: 54376
		private Table __p;
	}
}

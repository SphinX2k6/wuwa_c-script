using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CA2 RID: 23714
	public struct IPasserbyNpcPerformance : IFlatbufferObject
	{
		// Token: 0x1700AE31 RID: 44593
		// (get) Token: 0x0602756B RID: 161131 RVA: 0x00562A97 File Offset: 0x00560C97
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602756C RID: 161132 RVA: 0x00562AA4 File Offset: 0x00560CA4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602756D RID: 161133 RVA: 0x00562AAC File Offset: 0x00560CAC
		public static IPasserbyNpcPerformance GetRootAsIPasserbyNpcPerformance(ByteBuffer _bb)
		{
			return IPasserbyNpcPerformance.GetRootAsIPasserbyNpcPerformance(_bb, default(IPasserbyNpcPerformance));
		}

		// Token: 0x0602756E RID: 161134 RVA: 0x00562AC8 File Offset: 0x00560CC8
		public static IPasserbyNpcPerformance GetRootAsIPasserbyNpcPerformance(ByteBuffer _bb, IPasserbyNpcPerformance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602756F RID: 161135 RVA: 0x00562AE5 File Offset: 0x00560CE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027570 RID: 161136 RVA: 0x00562AF4 File Offset: 0x00560CF4
		public IPasserbyNpcPerformance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE32 RID: 44594
		// (get) Token: 0x06027571 RID: 161137 RVA: 0x00562B04 File Offset: 0x00560D04
		public string EffectGroupDa
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

		// Token: 0x06027572 RID: 161138 RVA: 0x00562B3B File Offset: 0x00560D3B
		public Span<byte> GetEffectGroupDaBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06027573 RID: 161139 RVA: 0x00562B4A File Offset: 0x00560D4A
		public byte[] GetEffectGroupDaArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06027574 RID: 161140 RVA: 0x00562B58 File Offset: 0x00560D58
		public static Offset<IPasserbyNpcPerformance> CreateIPasserbyNpcPerformance(FlatBufferBuilder builder, StringOffset EffectGroupDaOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IPasserbyNpcPerformance.AddEffectGroupDa(builder, EffectGroupDaOffset);
			return IPasserbyNpcPerformance.EndIPasserbyNpcPerformance(builder);
		}

		// Token: 0x06027575 RID: 161141 RVA: 0x00562B6E File Offset: 0x00560D6E
		public static void StartIPasserbyNpcPerformance(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06027576 RID: 161142 RVA: 0x00562B77 File Offset: 0x00560D77
		public static void AddEffectGroupDa(FlatBufferBuilder builder, StringOffset effectGroupDaOffset)
		{
			builder.AddOffset(0, effectGroupDaOffset.Value, 0);
		}

		// Token: 0x06027577 RID: 161143 RVA: 0x00562B87 File Offset: 0x00560D87
		public static Offset<IPasserbyNpcPerformance> EndIPasserbyNpcPerformance(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcPerformance>(builder.EndTable());
		}

		// Token: 0x06027578 RID: 161144 RVA: 0x00562B94 File Offset: 0x00560D94
		public IPasserbyNpcPerformanceT UnPack()
		{
			IPasserbyNpcPerformanceT passerbyNpcPerformanceT = new IPasserbyNpcPerformanceT();
			this.UnPackTo(passerbyNpcPerformanceT);
			return passerbyNpcPerformanceT;
		}

		// Token: 0x06027579 RID: 161145 RVA: 0x00562BAF File Offset: 0x00560DAF
		public void UnPackTo(IPasserbyNpcPerformanceT _o)
		{
			_o.EffectGroupDa = this.EffectGroupDa;
		}

		// Token: 0x0602757A RID: 161146 RVA: 0x00562BC0 File Offset: 0x00560DC0
		public static Offset<IPasserbyNpcPerformance> Pack(FlatBufferBuilder builder, IPasserbyNpcPerformanceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcPerformance>);
			}
			StringOffset effectGroupDaOffset = (_o.EffectGroupDa == null) ? default(StringOffset) : builder.CreateString(_o.EffectGroupDa);
			return IPasserbyNpcPerformance.CreateIPasserbyNpcPerformance(builder, effectGroupDaOffset);
		}

		// Token: 0x0400F7B5 RID: 63413
		private Table __p;
	}
}

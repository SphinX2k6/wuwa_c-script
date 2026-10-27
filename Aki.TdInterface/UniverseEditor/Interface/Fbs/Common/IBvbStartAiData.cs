using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D64 RID: 23908
	public struct IBvbStartAiData : IFlatbufferObject
	{
		// Token: 0x1700B319 RID: 45849
		// (get) Token: 0x06028E64 RID: 167524 RVA: 0x0059E785 File Offset: 0x0059C985
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028E65 RID: 167525 RVA: 0x0059E792 File Offset: 0x0059C992
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028E66 RID: 167526 RVA: 0x0059E79C File Offset: 0x0059C99C
		public static IBvbStartAiData GetRootAsIBvbStartAiData(ByteBuffer _bb)
		{
			return IBvbStartAiData.GetRootAsIBvbStartAiData(_bb, default(IBvbStartAiData));
		}

		// Token: 0x06028E67 RID: 167527 RVA: 0x0059E7B8 File Offset: 0x0059C9B8
		public static IBvbStartAiData GetRootAsIBvbStartAiData(ByteBuffer _bb, IBvbStartAiData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028E68 RID: 167528 RVA: 0x0059E7D5 File Offset: 0x0059C9D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028E69 RID: 167529 RVA: 0x0059E7E4 File Offset: 0x0059C9E4
		public IBvbStartAiData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B31A RID: 45850
		// (get) Token: 0x06028E6A RID: 167530 RVA: 0x0059E7F4 File Offset: 0x0059C9F4
		public EBvbEventName Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBvbEventName.AIEvolution;
				}
				return (EBvbEventName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028E6B RID: 167531 RVA: 0x0059E830 File Offset: 0x0059CA30
		public static Offset<IBvbStartAiData> CreateIBvbStartAiData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution)
		{
			builder.StartTable(1);
			IBvbStartAiData.AddType(builder, Type);
			return IBvbStartAiData.EndIBvbStartAiData(builder);
		}

		// Token: 0x06028E6C RID: 167532 RVA: 0x0059E846 File Offset: 0x0059CA46
		public static void StartIBvbStartAiData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06028E6D RID: 167533 RVA: 0x0059E84F File Offset: 0x0059CA4F
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028E6E RID: 167534 RVA: 0x0059E85A File Offset: 0x0059CA5A
		public static Offset<IBvbStartAiData> EndIBvbStartAiData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbStartAiData>(builder.EndTable());
		}

		// Token: 0x06028E6F RID: 167535 RVA: 0x0059E868 File Offset: 0x0059CA68
		public IBvbStartAiDataT UnPack()
		{
			IBvbStartAiDataT bvbStartAiDataT = new IBvbStartAiDataT();
			this.UnPackTo(bvbStartAiDataT);
			return bvbStartAiDataT;
		}

		// Token: 0x06028E70 RID: 167536 RVA: 0x0059E883 File Offset: 0x0059CA83
		public void UnPackTo(IBvbStartAiDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06028E71 RID: 167537 RVA: 0x0059E894 File Offset: 0x0059CA94
		public static Offset<IBvbStartAiData> Pack(FlatBufferBuilder builder, IBvbStartAiDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbStartAiData>);
			}
			return IBvbStartAiData.CreateIBvbStartAiData(builder, _o.Type);
		}

		// Token: 0x0400F730 RID: 63280
		private Table __p;
	}
}

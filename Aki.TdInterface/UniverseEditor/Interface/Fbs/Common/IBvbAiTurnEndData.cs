using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D43 RID: 23875
	public struct IBvbAiTurnEndData : IFlatbufferObject
	{
		// Token: 0x1700B2FA RID: 45818
		// (get) Token: 0x06028D7A RID: 167290 RVA: 0x0059D1F0 File Offset: 0x0059B3F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028D7B RID: 167291 RVA: 0x0059D1FD File Offset: 0x0059B3FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028D7C RID: 167292 RVA: 0x0059D204 File Offset: 0x0059B404
		public static IBvbAiTurnEndData GetRootAsIBvbAiTurnEndData(ByteBuffer _bb)
		{
			return IBvbAiTurnEndData.GetRootAsIBvbAiTurnEndData(_bb, default(IBvbAiTurnEndData));
		}

		// Token: 0x06028D7D RID: 167293 RVA: 0x0059D220 File Offset: 0x0059B420
		public static IBvbAiTurnEndData GetRootAsIBvbAiTurnEndData(ByteBuffer _bb, IBvbAiTurnEndData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028D7E RID: 167294 RVA: 0x0059D23D File Offset: 0x0059B43D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028D7F RID: 167295 RVA: 0x0059D24C File Offset: 0x0059B44C
		public IBvbAiTurnEndData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B2FB RID: 45819
		// (get) Token: 0x06028D80 RID: 167296 RVA: 0x0059D25C File Offset: 0x0059B45C
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

		// Token: 0x06028D81 RID: 167297 RVA: 0x0059D298 File Offset: 0x0059B498
		public static Offset<IBvbAiTurnEndData> CreateIBvbAiTurnEndData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution)
		{
			builder.StartTable(1);
			IBvbAiTurnEndData.AddType(builder, Type);
			return IBvbAiTurnEndData.EndIBvbAiTurnEndData(builder);
		}

		// Token: 0x06028D82 RID: 167298 RVA: 0x0059D2AE File Offset: 0x0059B4AE
		public static void StartIBvbAiTurnEndData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06028D83 RID: 167299 RVA: 0x0059D2B7 File Offset: 0x0059B4B7
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028D84 RID: 167300 RVA: 0x0059D2C2 File Offset: 0x0059B4C2
		public static Offset<IBvbAiTurnEndData> EndIBvbAiTurnEndData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbAiTurnEndData>(builder.EndTable());
		}

		// Token: 0x06028D85 RID: 167301 RVA: 0x0059D2D0 File Offset: 0x0059B4D0
		public IBvbAiTurnEndDataT UnPack()
		{
			IBvbAiTurnEndDataT bvbAiTurnEndDataT = new IBvbAiTurnEndDataT();
			this.UnPackTo(bvbAiTurnEndDataT);
			return bvbAiTurnEndDataT;
		}

		// Token: 0x06028D86 RID: 167302 RVA: 0x0059D2EB File Offset: 0x0059B4EB
		public void UnPackTo(IBvbAiTurnEndDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06028D87 RID: 167303 RVA: 0x0059D2FC File Offset: 0x0059B4FC
		public static Offset<IBvbAiTurnEndData> Pack(FlatBufferBuilder builder, IBvbAiTurnEndDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbAiTurnEndData>);
			}
			return IBvbAiTurnEndData.CreateIBvbAiTurnEndData(builder, _o.Type);
		}

		// Token: 0x0400F6FA RID: 63226
		private Table __p;
	}
}

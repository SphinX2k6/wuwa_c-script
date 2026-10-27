using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D6D RID: 23917
	public struct IBvbWaitForGameBeginData : IFlatbufferObject
	{
		// Token: 0x1700B322 RID: 45858
		// (get) Token: 0x06028E9A RID: 167578 RVA: 0x0059EBED File Offset: 0x0059CDED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028E9B RID: 167579 RVA: 0x0059EBFA File Offset: 0x0059CDFA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028E9C RID: 167580 RVA: 0x0059EC04 File Offset: 0x0059CE04
		public static IBvbWaitForGameBeginData GetRootAsIBvbWaitForGameBeginData(ByteBuffer _bb)
		{
			return IBvbWaitForGameBeginData.GetRootAsIBvbWaitForGameBeginData(_bb, default(IBvbWaitForGameBeginData));
		}

		// Token: 0x06028E9D RID: 167581 RVA: 0x0059EC20 File Offset: 0x0059CE20
		public static IBvbWaitForGameBeginData GetRootAsIBvbWaitForGameBeginData(ByteBuffer _bb, IBvbWaitForGameBeginData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028E9E RID: 167582 RVA: 0x0059EC3D File Offset: 0x0059CE3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028E9F RID: 167583 RVA: 0x0059EC4C File Offset: 0x0059CE4C
		public IBvbWaitForGameBeginData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B323 RID: 45859
		// (get) Token: 0x06028EA0 RID: 167584 RVA: 0x0059EC5C File Offset: 0x0059CE5C
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

		// Token: 0x06028EA1 RID: 167585 RVA: 0x0059EC98 File Offset: 0x0059CE98
		public static Offset<IBvbWaitForGameBeginData> CreateIBvbWaitForGameBeginData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution)
		{
			builder.StartTable(1);
			IBvbWaitForGameBeginData.AddType(builder, Type);
			return IBvbWaitForGameBeginData.EndIBvbWaitForGameBeginData(builder);
		}

		// Token: 0x06028EA2 RID: 167586 RVA: 0x0059ECAE File Offset: 0x0059CEAE
		public static void StartIBvbWaitForGameBeginData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06028EA3 RID: 167587 RVA: 0x0059ECB7 File Offset: 0x0059CEB7
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028EA4 RID: 167588 RVA: 0x0059ECC2 File Offset: 0x0059CEC2
		public static Offset<IBvbWaitForGameBeginData> EndIBvbWaitForGameBeginData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbWaitForGameBeginData>(builder.EndTable());
		}

		// Token: 0x06028EA5 RID: 167589 RVA: 0x0059ECD0 File Offset: 0x0059CED0
		public IBvbWaitForGameBeginDataT UnPack()
		{
			IBvbWaitForGameBeginDataT bvbWaitForGameBeginDataT = new IBvbWaitForGameBeginDataT();
			this.UnPackTo(bvbWaitForGameBeginDataT);
			return bvbWaitForGameBeginDataT;
		}

		// Token: 0x06028EA6 RID: 167590 RVA: 0x0059ECEB File Offset: 0x0059CEEB
		public void UnPackTo(IBvbWaitForGameBeginDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06028EA7 RID: 167591 RVA: 0x0059ECFC File Offset: 0x0059CEFC
		public static Offset<IBvbWaitForGameBeginData> Pack(FlatBufferBuilder builder, IBvbWaitForGameBeginDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbWaitForGameBeginData>);
			}
			return IBvbWaitForGameBeginData.CreateIBvbWaitForGameBeginData(builder, _o.Type);
		}

		// Token: 0x0400F736 RID: 63286
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D46 RID: 23878
	public struct IBvbBurnBuffTimeUpData : IFlatbufferObject
	{
		// Token: 0x1700B2FD RID: 45821
		// (get) Token: 0x06028D8C RID: 167308 RVA: 0x0059D365 File Offset: 0x0059B565
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028D8D RID: 167309 RVA: 0x0059D372 File Offset: 0x0059B572
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028D8E RID: 167310 RVA: 0x0059D37C File Offset: 0x0059B57C
		public static IBvbBurnBuffTimeUpData GetRootAsIBvbBurnBuffTimeUpData(ByteBuffer _bb)
		{
			return IBvbBurnBuffTimeUpData.GetRootAsIBvbBurnBuffTimeUpData(_bb, default(IBvbBurnBuffTimeUpData));
		}

		// Token: 0x06028D8F RID: 167311 RVA: 0x0059D398 File Offset: 0x0059B598
		public static IBvbBurnBuffTimeUpData GetRootAsIBvbBurnBuffTimeUpData(ByteBuffer _bb, IBvbBurnBuffTimeUpData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028D90 RID: 167312 RVA: 0x0059D3B5 File Offset: 0x0059B5B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028D91 RID: 167313 RVA: 0x0059D3C4 File Offset: 0x0059B5C4
		public IBvbBurnBuffTimeUpData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B2FE RID: 45822
		// (get) Token: 0x06028D92 RID: 167314 RVA: 0x0059D3D4 File Offset: 0x0059B5D4
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

		// Token: 0x06028D93 RID: 167315 RVA: 0x0059D410 File Offset: 0x0059B610
		public static Offset<IBvbBurnBuffTimeUpData> CreateIBvbBurnBuffTimeUpData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution)
		{
			builder.StartTable(1);
			IBvbBurnBuffTimeUpData.AddType(builder, Type);
			return IBvbBurnBuffTimeUpData.EndIBvbBurnBuffTimeUpData(builder);
		}

		// Token: 0x06028D94 RID: 167316 RVA: 0x0059D426 File Offset: 0x0059B626
		public static void StartIBvbBurnBuffTimeUpData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06028D95 RID: 167317 RVA: 0x0059D42F File Offset: 0x0059B62F
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028D96 RID: 167318 RVA: 0x0059D43A File Offset: 0x0059B63A
		public static Offset<IBvbBurnBuffTimeUpData> EndIBvbBurnBuffTimeUpData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbBurnBuffTimeUpData>(builder.EndTable());
		}

		// Token: 0x06028D97 RID: 167319 RVA: 0x0059D448 File Offset: 0x0059B648
		public IBvbBurnBuffTimeUpDataT UnPack()
		{
			IBvbBurnBuffTimeUpDataT bvbBurnBuffTimeUpDataT = new IBvbBurnBuffTimeUpDataT();
			this.UnPackTo(bvbBurnBuffTimeUpDataT);
			return bvbBurnBuffTimeUpDataT;
		}

		// Token: 0x06028D98 RID: 167320 RVA: 0x0059D463 File Offset: 0x0059B663
		public void UnPackTo(IBvbBurnBuffTimeUpDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06028D99 RID: 167321 RVA: 0x0059D474 File Offset: 0x0059B674
		public static Offset<IBvbBurnBuffTimeUpData> Pack(FlatBufferBuilder builder, IBvbBurnBuffTimeUpDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbBurnBuffTimeUpData>);
			}
			return IBvbBurnBuffTimeUpData.CreateIBvbBurnBuffTimeUpData(builder, _o.Type);
		}

		// Token: 0x0400F6FC RID: 63228
		private Table __p;
	}
}

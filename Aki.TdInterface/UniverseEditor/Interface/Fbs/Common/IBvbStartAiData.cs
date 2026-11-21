using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200639B RID: 25499
	public struct IBvbStartAiData : IFlatbufferObject
	{
		// Token: 0x1700BC7A RID: 48250
		// (get) Token: 0x0602B4CE RID: 177358 RVA: 0x005E71F5 File Offset: 0x005E53F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B4CF RID: 177359 RVA: 0x005E7202 File Offset: 0x005E5402
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B4D0 RID: 177360 RVA: 0x005E720C File Offset: 0x005E540C
		public static IBvbStartAiData GetRootAsIBvbStartAiData(ByteBuffer _bb)
		{
			return IBvbStartAiData.GetRootAsIBvbStartAiData(_bb, default(IBvbStartAiData));
		}

		// Token: 0x0602B4D1 RID: 177361 RVA: 0x005E7228 File Offset: 0x005E5428
		public static IBvbStartAiData GetRootAsIBvbStartAiData(ByteBuffer _bb, IBvbStartAiData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B4D2 RID: 177362 RVA: 0x005E7245 File Offset: 0x005E5445
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B4D3 RID: 177363 RVA: 0x005E7254 File Offset: 0x005E5454
		public IBvbStartAiData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC7B RID: 48251
		// (get) Token: 0x0602B4D4 RID: 177364 RVA: 0x005E7264 File Offset: 0x005E5464
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

		// Token: 0x0602B4D5 RID: 177365 RVA: 0x005E72A0 File Offset: 0x005E54A0
		public static Offset<IBvbStartAiData> CreateIBvbStartAiData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution)
		{
			builder.StartTable(1);
			IBvbStartAiData.AddType(builder, Type);
			return IBvbStartAiData.EndIBvbStartAiData(builder);
		}

		// Token: 0x0602B4D6 RID: 177366 RVA: 0x005E72B6 File Offset: 0x005E54B6
		public static void StartIBvbStartAiData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B4D7 RID: 177367 RVA: 0x005E72BF File Offset: 0x005E54BF
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B4D8 RID: 177368 RVA: 0x005E72CA File Offset: 0x005E54CA
		public static Offset<IBvbStartAiData> EndIBvbStartAiData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbStartAiData>(builder.EndTable());
		}

		// Token: 0x0602B4D9 RID: 177369 RVA: 0x005E72D8 File Offset: 0x005E54D8
		public IBvbStartAiDataT UnPack()
		{
			IBvbStartAiDataT bvbStartAiDataT = new IBvbStartAiDataT();
			this.UnPackTo(bvbStartAiDataT);
			return bvbStartAiDataT;
		}

		// Token: 0x0602B4DA RID: 177370 RVA: 0x005E72F3 File Offset: 0x005E54F3
		public void UnPackTo(IBvbStartAiDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B4DB RID: 177371 RVA: 0x005E7304 File Offset: 0x005E5504
		public static Offset<IBvbStartAiData> Pack(FlatBufferBuilder builder, IBvbStartAiDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbStartAiData>);
			}
			return IBvbStartAiData.CreateIBvbStartAiData(builder, _o.Type);
		}

		// Token: 0x04010482 RID: 66690
		private Table __p;
	}
}

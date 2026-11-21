using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006383 RID: 25475
	public struct IBvbEventData : IFlatbufferObject
	{
		// Token: 0x1700BC64 RID: 48228
		// (get) Token: 0x0602B41A RID: 177178 RVA: 0x005E60C5 File Offset: 0x005E42C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B41B RID: 177179 RVA: 0x005E60D2 File Offset: 0x005E42D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B41C RID: 177180 RVA: 0x005E60DC File Offset: 0x005E42DC
		public static IBvbEventData GetRootAsIBvbEventData(ByteBuffer _bb)
		{
			return IBvbEventData.GetRootAsIBvbEventData(_bb, default(IBvbEventData));
		}

		// Token: 0x0602B41D RID: 177181 RVA: 0x005E60F8 File Offset: 0x005E42F8
		public static IBvbEventData GetRootAsIBvbEventData(ByteBuffer _bb, IBvbEventData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B41E RID: 177182 RVA: 0x005E6115 File Offset: 0x005E4315
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B41F RID: 177183 RVA: 0x005E6124 File Offset: 0x005E4324
		public IBvbEventData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC65 RID: 48229
		// (get) Token: 0x0602B420 RID: 177184 RVA: 0x005E6134 File Offset: 0x005E4334
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

		// Token: 0x0602B421 RID: 177185 RVA: 0x005E6170 File Offset: 0x005E4370
		public static Offset<IBvbEventData> CreateIBvbEventData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution)
		{
			builder.StartTable(1);
			IBvbEventData.AddType(builder, Type);
			return IBvbEventData.EndIBvbEventData(builder);
		}

		// Token: 0x0602B422 RID: 177186 RVA: 0x005E6186 File Offset: 0x005E4386
		public static void StartIBvbEventData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B423 RID: 177187 RVA: 0x005E618F File Offset: 0x005E438F
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B424 RID: 177188 RVA: 0x005E619A File Offset: 0x005E439A
		public static Offset<IBvbEventData> EndIBvbEventData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbEventData>(builder.EndTable());
		}

		// Token: 0x0602B425 RID: 177189 RVA: 0x005E61A8 File Offset: 0x005E43A8
		public IBvbEventDataT UnPack()
		{
			IBvbEventDataT bvbEventDataT = new IBvbEventDataT();
			this.UnPackTo(bvbEventDataT);
			return bvbEventDataT;
		}

		// Token: 0x0602B426 RID: 177190 RVA: 0x005E61C3 File Offset: 0x005E43C3
		public void UnPackTo(IBvbEventDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B427 RID: 177191 RVA: 0x005E61D4 File Offset: 0x005E43D4
		public static Offset<IBvbEventData> Pack(FlatBufferBuilder builder, IBvbEventDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbEventData>);
			}
			return IBvbEventData.CreateIBvbEventData(builder, _o.Type);
		}

		// Token: 0x04010452 RID: 66642
		private Table __p;
	}
}

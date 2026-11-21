using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200638F RID: 25487
	public struct IBvbPlayerTurnStartData : IFlatbufferObject
	{
		// Token: 0x1700BC6F RID: 48239
		// (get) Token: 0x0602B48A RID: 177290 RVA: 0x005E6C45 File Offset: 0x005E4E45
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B48B RID: 177291 RVA: 0x005E6C52 File Offset: 0x005E4E52
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B48C RID: 177292 RVA: 0x005E6C5C File Offset: 0x005E4E5C
		public static IBvbPlayerTurnStartData GetRootAsIBvbPlayerTurnStartData(ByteBuffer _bb)
		{
			return IBvbPlayerTurnStartData.GetRootAsIBvbPlayerTurnStartData(_bb, default(IBvbPlayerTurnStartData));
		}

		// Token: 0x0602B48D RID: 177293 RVA: 0x005E6C78 File Offset: 0x005E4E78
		public static IBvbPlayerTurnStartData GetRootAsIBvbPlayerTurnStartData(ByteBuffer _bb, IBvbPlayerTurnStartData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B48E RID: 177294 RVA: 0x005E6C95 File Offset: 0x005E4E95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B48F RID: 177295 RVA: 0x005E6CA4 File Offset: 0x005E4EA4
		public IBvbPlayerTurnStartData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC70 RID: 48240
		// (get) Token: 0x0602B490 RID: 177296 RVA: 0x005E6CB4 File Offset: 0x005E4EB4
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

		// Token: 0x0602B491 RID: 177297 RVA: 0x005E6CF0 File Offset: 0x005E4EF0
		public static Offset<IBvbPlayerTurnStartData> CreateIBvbPlayerTurnStartData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution)
		{
			builder.StartTable(1);
			IBvbPlayerTurnStartData.AddType(builder, Type);
			return IBvbPlayerTurnStartData.EndIBvbPlayerTurnStartData(builder);
		}

		// Token: 0x0602B492 RID: 177298 RVA: 0x005E6D06 File Offset: 0x005E4F06
		public static void StartIBvbPlayerTurnStartData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B493 RID: 177299 RVA: 0x005E6D0F File Offset: 0x005E4F0F
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B494 RID: 177300 RVA: 0x005E6D1A File Offset: 0x005E4F1A
		public static Offset<IBvbPlayerTurnStartData> EndIBvbPlayerTurnStartData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbPlayerTurnStartData>(builder.EndTable());
		}

		// Token: 0x0602B495 RID: 177301 RVA: 0x005E6D28 File Offset: 0x005E4F28
		public IBvbPlayerTurnStartDataT UnPack()
		{
			IBvbPlayerTurnStartDataT bvbPlayerTurnStartDataT = new IBvbPlayerTurnStartDataT();
			this.UnPackTo(bvbPlayerTurnStartDataT);
			return bvbPlayerTurnStartDataT;
		}

		// Token: 0x0602B496 RID: 177302 RVA: 0x005E6D43 File Offset: 0x005E4F43
		public void UnPackTo(IBvbPlayerTurnStartDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B497 RID: 177303 RVA: 0x005E6D54 File Offset: 0x005E4F54
		public static Offset<IBvbPlayerTurnStartData> Pack(FlatBufferBuilder builder, IBvbPlayerTurnStartDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbPlayerTurnStartData>);
			}
			return IBvbPlayerTurnStartData.CreateIBvbPlayerTurnStartData(builder, _o.Type);
		}

		// Token: 0x04010475 RID: 66677
		private Table __p;
	}
}

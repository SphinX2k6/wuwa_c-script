using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200639E RID: 25502
	public struct IBvbStartBattleData : IFlatbufferObject
	{
		// Token: 0x1700BC7D RID: 48253
		// (get) Token: 0x0602B4E0 RID: 177376 RVA: 0x005E736D File Offset: 0x005E556D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B4E1 RID: 177377 RVA: 0x005E737A File Offset: 0x005E557A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B4E2 RID: 177378 RVA: 0x005E7384 File Offset: 0x005E5584
		public static IBvbStartBattleData GetRootAsIBvbStartBattleData(ByteBuffer _bb)
		{
			return IBvbStartBattleData.GetRootAsIBvbStartBattleData(_bb, default(IBvbStartBattleData));
		}

		// Token: 0x0602B4E3 RID: 177379 RVA: 0x005E73A0 File Offset: 0x005E55A0
		public static IBvbStartBattleData GetRootAsIBvbStartBattleData(ByteBuffer _bb, IBvbStartBattleData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B4E4 RID: 177380 RVA: 0x005E73BD File Offset: 0x005E55BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B4E5 RID: 177381 RVA: 0x005E73CC File Offset: 0x005E55CC
		public IBvbStartBattleData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC7E RID: 48254
		// (get) Token: 0x0602B4E6 RID: 177382 RVA: 0x005E73DC File Offset: 0x005E55DC
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

		// Token: 0x0602B4E7 RID: 177383 RVA: 0x005E7418 File Offset: 0x005E5618
		public static Offset<IBvbStartBattleData> CreateIBvbStartBattleData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution)
		{
			builder.StartTable(1);
			IBvbStartBattleData.AddType(builder, Type);
			return IBvbStartBattleData.EndIBvbStartBattleData(builder);
		}

		// Token: 0x0602B4E8 RID: 177384 RVA: 0x005E742E File Offset: 0x005E562E
		public static void StartIBvbStartBattleData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B4E9 RID: 177385 RVA: 0x005E7437 File Offset: 0x005E5637
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B4EA RID: 177386 RVA: 0x005E7442 File Offset: 0x005E5642
		public static Offset<IBvbStartBattleData> EndIBvbStartBattleData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbStartBattleData>(builder.EndTable());
		}

		// Token: 0x0602B4EB RID: 177387 RVA: 0x005E7450 File Offset: 0x005E5650
		public IBvbStartBattleDataT UnPack()
		{
			IBvbStartBattleDataT bvbStartBattleDataT = new IBvbStartBattleDataT();
			this.UnPackTo(bvbStartBattleDataT);
			return bvbStartBattleDataT;
		}

		// Token: 0x0602B4EC RID: 177388 RVA: 0x005E746B File Offset: 0x005E566B
		public void UnPackTo(IBvbStartBattleDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B4ED RID: 177389 RVA: 0x005E747C File Offset: 0x005E567C
		public static Offset<IBvbStartBattleData> Pack(FlatBufferBuilder builder, IBvbStartBattleDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbStartBattleData>);
			}
			return IBvbStartBattleData.CreateIBvbStartBattleData(builder, _o.Type);
		}

		// Token: 0x04010484 RID: 66692
		private Table __p;
	}
}

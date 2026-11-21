using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044D8 RID: 17624
	public struct IRecallFishingBoat : IFlatbufferObject
	{
		// Token: 0x17007AB3 RID: 31411
		// (get) Token: 0x060197BC RID: 104380 RVA: 0x003A280F File Offset: 0x003A0A0F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060197BD RID: 104381 RVA: 0x003A281C File Offset: 0x003A0A1C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060197BE RID: 104382 RVA: 0x003A2824 File Offset: 0x003A0A24
		public static IRecallFishingBoat GetRootAsIRecallFishingBoat(ByteBuffer _bb)
		{
			return IRecallFishingBoat.GetRootAsIRecallFishingBoat(_bb, default(IRecallFishingBoat));
		}

		// Token: 0x060197BF RID: 104383 RVA: 0x003A2840 File Offset: 0x003A0A40
		public static IRecallFishingBoat GetRootAsIRecallFishingBoat(ByteBuffer _bb, IRecallFishingBoat obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060197C0 RID: 104384 RVA: 0x003A285D File Offset: 0x003A0A5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060197C1 RID: 104385 RVA: 0x003A286C File Offset: 0x003A0A6C
		public IRecallFishingBoat __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007AB4 RID: 31412
		// (get) Token: 0x060197C2 RID: 104386 RVA: 0x003A287C File Offset: 0x003A0A7C
		public EVehicleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVehicleType.Gongduola;
				}
				return (EVehicleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060197C3 RID: 104387 RVA: 0x003A28B8 File Offset: 0x003A0AB8
		public static Offset<IRecallFishingBoat> CreateIRecallFishingBoat(FlatBufferBuilder builder, EVehicleType Type = EVehicleType.Gongduola)
		{
			builder.StartTable(1);
			IRecallFishingBoat.AddType(builder, Type);
			return IRecallFishingBoat.EndIRecallFishingBoat(builder);
		}

		// Token: 0x060197C4 RID: 104388 RVA: 0x003A28CE File Offset: 0x003A0ACE
		public static void StartIRecallFishingBoat(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060197C5 RID: 104389 RVA: 0x003A28D7 File Offset: 0x003A0AD7
		public static void AddType(FlatBufferBuilder builder, EVehicleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060197C6 RID: 104390 RVA: 0x003A28E2 File Offset: 0x003A0AE2
		public static Offset<IRecallFishingBoat> EndIRecallFishingBoat(FlatBufferBuilder builder)
		{
			return new Offset<IRecallFishingBoat>(builder.EndTable());
		}

		// Token: 0x060197C7 RID: 104391 RVA: 0x003A28F0 File Offset: 0x003A0AF0
		public IRecallFishingBoatT UnPack()
		{
			IRecallFishingBoatT recallFishingBoatT = new IRecallFishingBoatT();
			this.UnPackTo(recallFishingBoatT);
			return recallFishingBoatT;
		}

		// Token: 0x060197C8 RID: 104392 RVA: 0x003A290B File Offset: 0x003A0B0B
		public void UnPackTo(IRecallFishingBoatT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060197C9 RID: 104393 RVA: 0x003A291C File Offset: 0x003A0B1C
		public static Offset<IRecallFishingBoat> Pack(FlatBufferBuilder builder, IRecallFishingBoatT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRecallFishingBoat>);
			}
			return IRecallFishingBoat.CreateIRecallFishingBoat(builder, _o.Type);
		}

		// Token: 0x0400C60A RID: 50698
		private Table __p;
	}
}

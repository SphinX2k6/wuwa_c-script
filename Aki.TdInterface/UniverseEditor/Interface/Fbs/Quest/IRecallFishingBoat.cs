using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004097 RID: 16535
	public struct IRecallFishingBoat : IFlatbufferObject
	{
		// Token: 0x170074B1 RID: 29873
		// (get) Token: 0x06018123 RID: 98595 RVA: 0x003789D7 File Offset: 0x00376BD7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018124 RID: 98596 RVA: 0x003789E4 File Offset: 0x00376BE4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018125 RID: 98597 RVA: 0x003789EC File Offset: 0x00376BEC
		public static IRecallFishingBoat GetRootAsIRecallFishingBoat(ByteBuffer _bb)
		{
			return IRecallFishingBoat.GetRootAsIRecallFishingBoat(_bb, default(IRecallFishingBoat));
		}

		// Token: 0x06018126 RID: 98598 RVA: 0x00378A08 File Offset: 0x00376C08
		public static IRecallFishingBoat GetRootAsIRecallFishingBoat(ByteBuffer _bb, IRecallFishingBoat obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018127 RID: 98599 RVA: 0x00378A25 File Offset: 0x00376C25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018128 RID: 98600 RVA: 0x00378A34 File Offset: 0x00376C34
		public IRecallFishingBoat __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170074B2 RID: 29874
		// (get) Token: 0x06018129 RID: 98601 RVA: 0x00378A44 File Offset: 0x00376C44
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

		// Token: 0x0601812A RID: 98602 RVA: 0x00378A80 File Offset: 0x00376C80
		public static Offset<IRecallFishingBoat> CreateIRecallFishingBoat(FlatBufferBuilder builder, EVehicleType Type = EVehicleType.Gongduola)
		{
			builder.StartTable(1);
			IRecallFishingBoat.AddType(builder, Type);
			return IRecallFishingBoat.EndIRecallFishingBoat(builder);
		}

		// Token: 0x0601812B RID: 98603 RVA: 0x00378A96 File Offset: 0x00376C96
		public static void StartIRecallFishingBoat(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601812C RID: 98604 RVA: 0x00378A9F File Offset: 0x00376C9F
		public static void AddType(FlatBufferBuilder builder, EVehicleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601812D RID: 98605 RVA: 0x00378AAA File Offset: 0x00376CAA
		public static Offset<IRecallFishingBoat> EndIRecallFishingBoat(FlatBufferBuilder builder)
		{
			return new Offset<IRecallFishingBoat>(builder.EndTable());
		}

		// Token: 0x0601812E RID: 98606 RVA: 0x00378AB8 File Offset: 0x00376CB8
		public IRecallFishingBoatT UnPack()
		{
			IRecallFishingBoatT recallFishingBoatT = new IRecallFishingBoatT();
			this.UnPackTo(recallFishingBoatT);
			return recallFishingBoatT;
		}

		// Token: 0x0601812F RID: 98607 RVA: 0x00378AD3 File Offset: 0x00376CD3
		public void UnPackTo(IRecallFishingBoatT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06018130 RID: 98608 RVA: 0x00378AE4 File Offset: 0x00376CE4
		public static Offset<IRecallFishingBoat> Pack(FlatBufferBuilder builder, IRecallFishingBoatT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRecallFishingBoat>);
			}
			return IRecallFishingBoat.CreateIRecallFishingBoat(builder, _o.Type);
		}

		// Token: 0x0400BC23 RID: 48163
		private Table __p;
	}
}

using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200409A RID: 16538
	public struct IRecallVehicle : IFlatbufferObject
	{
		// Token: 0x170074B4 RID: 29876
		// (get) Token: 0x06018135 RID: 98613 RVA: 0x00378B4D File Offset: 0x00376D4D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018136 RID: 98614 RVA: 0x00378B5A File Offset: 0x00376D5A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018137 RID: 98615 RVA: 0x00378B64 File Offset: 0x00376D64
		public static IRecallVehicle GetRootAsIRecallVehicle(ByteBuffer _bb)
		{
			return IRecallVehicle.GetRootAsIRecallVehicle(_bb, default(IRecallVehicle));
		}

		// Token: 0x06018138 RID: 98616 RVA: 0x00378B80 File Offset: 0x00376D80
		public static IRecallVehicle GetRootAsIRecallVehicle(ByteBuffer _bb, IRecallVehicle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018139 RID: 98617 RVA: 0x00378B9D File Offset: 0x00376D9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601813A RID: 98618 RVA: 0x00378BAC File Offset: 0x00376DAC
		public IRecallVehicle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170074B5 RID: 29877
		// (get) Token: 0x0601813B RID: 98619 RVA: 0x00378BBC File Offset: 0x00376DBC
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

		// Token: 0x0601813C RID: 98620 RVA: 0x00378BF8 File Offset: 0x00376DF8
		public static Offset<IRecallVehicle> CreateIRecallVehicle(FlatBufferBuilder builder, EVehicleType Type = EVehicleType.Gongduola)
		{
			builder.StartTable(1);
			IRecallVehicle.AddType(builder, Type);
			return IRecallVehicle.EndIRecallVehicle(builder);
		}

		// Token: 0x0601813D RID: 98621 RVA: 0x00378C0E File Offset: 0x00376E0E
		public static void StartIRecallVehicle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601813E RID: 98622 RVA: 0x00378C17 File Offset: 0x00376E17
		public static void AddType(FlatBufferBuilder builder, EVehicleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601813F RID: 98623 RVA: 0x00378C22 File Offset: 0x00376E22
		public static Offset<IRecallVehicle> EndIRecallVehicle(FlatBufferBuilder builder)
		{
			return new Offset<IRecallVehicle>(builder.EndTable());
		}

		// Token: 0x06018140 RID: 98624 RVA: 0x00378C30 File Offset: 0x00376E30
		public IRecallVehicleT UnPack()
		{
			IRecallVehicleT recallVehicleT = new IRecallVehicleT();
			this.UnPackTo(recallVehicleT);
			return recallVehicleT;
		}

		// Token: 0x06018141 RID: 98625 RVA: 0x00378C4B File Offset: 0x00376E4B
		public void UnPackTo(IRecallVehicleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06018142 RID: 98626 RVA: 0x00378C5C File Offset: 0x00376E5C
		public static Offset<IRecallVehicle> Pack(FlatBufferBuilder builder, IRecallVehicleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRecallVehicle>);
			}
			return IRecallVehicle.CreateIRecallVehicle(builder, _o.Type);
		}

		// Token: 0x0400BC25 RID: 48165
		private Table __p;
	}
}

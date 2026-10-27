using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005644 RID: 22084
	public struct INpcRideInGongduolaPerform : IFlatbufferObject
	{
		// Token: 0x1700A39B RID: 41883
		// (get) Token: 0x06024B63 RID: 150371 RVA: 0x00511169 File Offset: 0x0050F369
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024B64 RID: 150372 RVA: 0x00511176 File Offset: 0x0050F376
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024B65 RID: 150373 RVA: 0x00511180 File Offset: 0x0050F380
		public static INpcRideInGongduolaPerform GetRootAsINpcRideInGongduolaPerform(ByteBuffer _bb)
		{
			return INpcRideInGongduolaPerform.GetRootAsINpcRideInGongduolaPerform(_bb, default(INpcRideInGongduolaPerform));
		}

		// Token: 0x06024B66 RID: 150374 RVA: 0x0051119C File Offset: 0x0050F39C
		public static INpcRideInGongduolaPerform GetRootAsINpcRideInGongduolaPerform(ByteBuffer _bb, INpcRideInGongduolaPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024B67 RID: 150375 RVA: 0x005111B9 File Offset: 0x0050F3B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024B68 RID: 150376 RVA: 0x005111C8 File Offset: 0x0050F3C8
		public INpcRideInGongduolaPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A39C RID: 41884
		// (get) Token: 0x06024B69 RID: 150377 RVA: 0x005111D8 File Offset: 0x0050F3D8
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

		// Token: 0x1700A39D RID: 41885
		// (get) Token: 0x06024B6A RID: 150378 RVA: 0x00511214 File Offset: 0x0050F414
		public string Montage
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024B6B RID: 150379 RVA: 0x0051124B File Offset: 0x0050F44B
		public Span<byte> GetMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06024B6C RID: 150380 RVA: 0x0051125A File Offset: 0x0050F45A
		public byte[] GetMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06024B6D RID: 150381 RVA: 0x00511268 File Offset: 0x0050F468
		public static Offset<INpcRideInGongduolaPerform> CreateINpcRideInGongduolaPerform(FlatBufferBuilder builder, EVehicleType Type = EVehicleType.Gongduola, StringOffset MontageOffset = default(StringOffset))
		{
			builder.StartTable(2);
			INpcRideInGongduolaPerform.AddMontage(builder, MontageOffset);
			INpcRideInGongduolaPerform.AddType(builder, Type);
			return INpcRideInGongduolaPerform.EndINpcRideInGongduolaPerform(builder);
		}

		// Token: 0x06024B6E RID: 150382 RVA: 0x00511285 File Offset: 0x0050F485
		public static void StartINpcRideInGongduolaPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06024B6F RID: 150383 RVA: 0x0051128E File Offset: 0x0050F48E
		public static void AddType(FlatBufferBuilder builder, EVehicleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024B70 RID: 150384 RVA: 0x00511299 File Offset: 0x0050F499
		public static void AddMontage(FlatBufferBuilder builder, StringOffset montageOffset)
		{
			builder.AddOffset(1, montageOffset.Value, 0);
		}

		// Token: 0x06024B71 RID: 150385 RVA: 0x005112A9 File Offset: 0x0050F4A9
		public static Offset<INpcRideInGongduolaPerform> EndINpcRideInGongduolaPerform(FlatBufferBuilder builder)
		{
			return new Offset<INpcRideInGongduolaPerform>(builder.EndTable());
		}

		// Token: 0x06024B72 RID: 150386 RVA: 0x005112B8 File Offset: 0x0050F4B8
		public INpcRideInGongduolaPerformT UnPack()
		{
			INpcRideInGongduolaPerformT npcRideInGongduolaPerformT = new INpcRideInGongduolaPerformT();
			this.UnPackTo(npcRideInGongduolaPerformT);
			return npcRideInGongduolaPerformT;
		}

		// Token: 0x06024B73 RID: 150387 RVA: 0x005112D3 File Offset: 0x0050F4D3
		public void UnPackTo(INpcRideInGongduolaPerformT _o)
		{
			_o.Type = this.Type;
			_o.Montage = this.Montage;
		}

		// Token: 0x06024B74 RID: 150388 RVA: 0x005112F0 File Offset: 0x0050F4F0
		public static Offset<INpcRideInGongduolaPerform> Pack(FlatBufferBuilder builder, INpcRideInGongduolaPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcRideInGongduolaPerform>);
			}
			StringOffset montageOffset = (_o.Montage == null) ? default(StringOffset) : builder.CreateString(_o.Montage);
			return INpcRideInGongduolaPerform.CreateINpcRideInGongduolaPerform(builder, _o.Type, montageOffset);
		}

		// Token: 0x0400E9EB RID: 59883
		private Table __p;
	}
}

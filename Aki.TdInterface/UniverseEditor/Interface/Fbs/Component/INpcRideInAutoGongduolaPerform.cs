using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005641 RID: 22081
	public struct INpcRideInAutoGongduolaPerform : IFlatbufferObject
	{
		// Token: 0x1700A396 RID: 41878
		// (get) Token: 0x06024B4B RID: 150347 RVA: 0x00510F36 File Offset: 0x0050F136
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024B4C RID: 150348 RVA: 0x00510F43 File Offset: 0x0050F143
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024B4D RID: 150349 RVA: 0x00510F4C File Offset: 0x0050F14C
		public static INpcRideInAutoGongduolaPerform GetRootAsINpcRideInAutoGongduolaPerform(ByteBuffer _bb)
		{
			return INpcRideInAutoGongduolaPerform.GetRootAsINpcRideInAutoGongduolaPerform(_bb, default(INpcRideInAutoGongduolaPerform));
		}

		// Token: 0x06024B4E RID: 150350 RVA: 0x00510F68 File Offset: 0x0050F168
		public static INpcRideInAutoGongduolaPerform GetRootAsINpcRideInAutoGongduolaPerform(ByteBuffer _bb, INpcRideInAutoGongduolaPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024B4F RID: 150351 RVA: 0x00510F85 File Offset: 0x0050F185
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024B50 RID: 150352 RVA: 0x00510F94 File Offset: 0x0050F194
		public INpcRideInAutoGongduolaPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A397 RID: 41879
		// (get) Token: 0x06024B51 RID: 150353 RVA: 0x00510FA4 File Offset: 0x0050F1A4
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

		// Token: 0x1700A398 RID: 41880
		// (get) Token: 0x06024B52 RID: 150354 RVA: 0x00510FE0 File Offset: 0x0050F1E0
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

		// Token: 0x06024B53 RID: 150355 RVA: 0x00511017 File Offset: 0x0050F217
		public Span<byte> GetMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06024B54 RID: 150356 RVA: 0x00511026 File Offset: 0x0050F226
		public byte[] GetMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06024B55 RID: 150357 RVA: 0x00511034 File Offset: 0x0050F234
		public static Offset<INpcRideInAutoGongduolaPerform> CreateINpcRideInAutoGongduolaPerform(FlatBufferBuilder builder, EVehicleType Type = EVehicleType.Gongduola, StringOffset MontageOffset = default(StringOffset))
		{
			builder.StartTable(2);
			INpcRideInAutoGongduolaPerform.AddMontage(builder, MontageOffset);
			INpcRideInAutoGongduolaPerform.AddType(builder, Type);
			return INpcRideInAutoGongduolaPerform.EndINpcRideInAutoGongduolaPerform(builder);
		}

		// Token: 0x06024B56 RID: 150358 RVA: 0x00511051 File Offset: 0x0050F251
		public static void StartINpcRideInAutoGongduolaPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06024B57 RID: 150359 RVA: 0x0051105A File Offset: 0x0050F25A
		public static void AddType(FlatBufferBuilder builder, EVehicleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024B58 RID: 150360 RVA: 0x00511065 File Offset: 0x0050F265
		public static void AddMontage(FlatBufferBuilder builder, StringOffset montageOffset)
		{
			builder.AddOffset(1, montageOffset.Value, 0);
		}

		// Token: 0x06024B59 RID: 150361 RVA: 0x00511075 File Offset: 0x0050F275
		public static Offset<INpcRideInAutoGongduolaPerform> EndINpcRideInAutoGongduolaPerform(FlatBufferBuilder builder)
		{
			return new Offset<INpcRideInAutoGongduolaPerform>(builder.EndTable());
		}

		// Token: 0x06024B5A RID: 150362 RVA: 0x00511084 File Offset: 0x0050F284
		public INpcRideInAutoGongduolaPerformT UnPack()
		{
			INpcRideInAutoGongduolaPerformT npcRideInAutoGongduolaPerformT = new INpcRideInAutoGongduolaPerformT();
			this.UnPackTo(npcRideInAutoGongduolaPerformT);
			return npcRideInAutoGongduolaPerformT;
		}

		// Token: 0x06024B5B RID: 150363 RVA: 0x0051109F File Offset: 0x0050F29F
		public void UnPackTo(INpcRideInAutoGongduolaPerformT _o)
		{
			_o.Type = this.Type;
			_o.Montage = this.Montage;
		}

		// Token: 0x06024B5C RID: 150364 RVA: 0x005110BC File Offset: 0x0050F2BC
		public static Offset<INpcRideInAutoGongduolaPerform> Pack(FlatBufferBuilder builder, INpcRideInAutoGongduolaPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcRideInAutoGongduolaPerform>);
			}
			StringOffset montageOffset = (_o.Montage == null) ? default(StringOffset) : builder.CreateString(_o.Montage);
			return INpcRideInAutoGongduolaPerform.CreateINpcRideInAutoGongduolaPerform(builder, _o.Type, montageOffset);
		}

		// Token: 0x0400E9E8 RID: 59880
		private Table __p;
	}
}

using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006308 RID: 25352
	public struct IChangeMediaPlayDa : IFlatbufferObject
	{
		// Token: 0x1700BD41 RID: 48449
		// (get) Token: 0x0602BD73 RID: 179571 RVA: 0x0060781C File Offset: 0x00605A1C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BD74 RID: 179572 RVA: 0x00607829 File Offset: 0x00605A29
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BD75 RID: 179573 RVA: 0x00607830 File Offset: 0x00605A30
		public static IChangeMediaPlayDa GetRootAsIChangeMediaPlayDa(ByteBuffer _bb)
		{
			return IChangeMediaPlayDa.GetRootAsIChangeMediaPlayDa(_bb, default(IChangeMediaPlayDa));
		}

		// Token: 0x0602BD76 RID: 179574 RVA: 0x0060784C File Offset: 0x00605A4C
		public static IChangeMediaPlayDa GetRootAsIChangeMediaPlayDa(ByteBuffer _bb, IChangeMediaPlayDa obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BD77 RID: 179575 RVA: 0x00607869 File Offset: 0x00605A69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BD78 RID: 179576 RVA: 0x00607878 File Offset: 0x00605A78
		public IChangeMediaPlayDa __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD42 RID: 48450
		// (get) Token: 0x0602BD79 RID: 179577 RVA: 0x00607888 File Offset: 0x00605A88
		public EModifyActorMediaType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EModifyActorMediaType.ChangeMediaPlayDA;
				}
				return (EModifyActorMediaType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BD43 RID: 48451
		// (get) Token: 0x0602BD7A RID: 179578 RVA: 0x006078C4 File Offset: 0x00605AC4
		public string MediaPlayDa
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

		// Token: 0x0602BD7B RID: 179579 RVA: 0x006078FB File Offset: 0x00605AFB
		public Span<byte> GetMediaPlayDaBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602BD7C RID: 179580 RVA: 0x0060790A File Offset: 0x00605B0A
		public byte[] GetMediaPlayDaArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602BD7D RID: 179581 RVA: 0x00607918 File Offset: 0x00605B18
		public IActorRef? ActorRefs(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BD44 RID: 48452
		// (get) Token: 0x0602BD7E RID: 179582 RVA: 0x00607978 File Offset: 0x00605B78
		public int ActorRefsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602BD7F RID: 179583 RVA: 0x006079A3 File Offset: 0x00605BA3
		public static Offset<IChangeMediaPlayDa> CreateIChangeMediaPlayDa(FlatBufferBuilder builder, EModifyActorMediaType Type = EModifyActorMediaType.ChangeMediaPlayDA, StringOffset MediaPlayDaOffset = default(StringOffset), VectorOffset ActorRefsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IChangeMediaPlayDa.AddActorRefs(builder, ActorRefsOffset);
			IChangeMediaPlayDa.AddMediaPlayDa(builder, MediaPlayDaOffset);
			IChangeMediaPlayDa.AddType(builder, Type);
			return IChangeMediaPlayDa.EndIChangeMediaPlayDa(builder);
		}

		// Token: 0x0602BD80 RID: 179584 RVA: 0x006079C7 File Offset: 0x00605BC7
		public static void StartIChangeMediaPlayDa(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602BD81 RID: 179585 RVA: 0x006079D0 File Offset: 0x00605BD0
		public static void AddType(FlatBufferBuilder builder, EModifyActorMediaType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BD82 RID: 179586 RVA: 0x006079DB File Offset: 0x00605BDB
		public static void AddMediaPlayDa(FlatBufferBuilder builder, StringOffset mediaPlayDaOffset)
		{
			builder.AddOffset(1, mediaPlayDaOffset.Value, 0);
		}

		// Token: 0x0602BD83 RID: 179587 RVA: 0x006079EB File Offset: 0x00605BEB
		public static void AddActorRefs(FlatBufferBuilder builder, VectorOffset actorRefsOffset)
		{
			builder.AddOffset(2, actorRefsOffset.Value, 0);
		}

		// Token: 0x0602BD84 RID: 179588 RVA: 0x006079FC File Offset: 0x00605BFC
		public static VectorOffset CreateActorRefsVector(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602BD85 RID: 179589 RVA: 0x00607A3C File Offset: 0x00605C3C
		public static VectorOffset CreateActorRefsVectorBlock(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BD86 RID: 179590 RVA: 0x00607A56 File Offset: 0x00605C56
		public static VectorOffset CreateActorRefsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorRef>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BD87 RID: 179591 RVA: 0x00607A74 File Offset: 0x00605C74
		public static VectorOffset CreateActorRefsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorRef>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602BD88 RID: 179592 RVA: 0x00607A8D File Offset: 0x00605C8D
		public static void StartActorRefsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602BD89 RID: 179593 RVA: 0x00607A98 File Offset: 0x00605C98
		public static Offset<IChangeMediaPlayDa> EndIChangeMediaPlayDa(FlatBufferBuilder builder)
		{
			return new Offset<IChangeMediaPlayDa>(builder.EndTable());
		}

		// Token: 0x0602BD8A RID: 179594 RVA: 0x00607AA8 File Offset: 0x00605CA8
		public IChangeMediaPlayDaT UnPack()
		{
			IChangeMediaPlayDaT changeMediaPlayDaT = new IChangeMediaPlayDaT();
			this.UnPackTo(changeMediaPlayDaT);
			return changeMediaPlayDaT;
		}

		// Token: 0x0602BD8B RID: 179595 RVA: 0x00607AC4 File Offset: 0x00605CC4
		public void UnPackTo(IChangeMediaPlayDaT _o)
		{
			_o.Type = this.Type;
			_o.MediaPlayDa = this.MediaPlayDa;
			_o.ActorRefs = new List<IActorRefT>();
			for (int i = 0; i < this.ActorRefsLength; i++)
			{
				_o.ActorRefs.Add((this.ActorRefs(i) != null) ? this.ActorRefs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602BD8C RID: 179596 RVA: 0x00607B3C File Offset: 0x00605D3C
		public static Offset<IChangeMediaPlayDa> Pack(FlatBufferBuilder builder, IChangeMediaPlayDaT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeMediaPlayDa>);
			}
			StringOffset mediaPlayDaOffset = (_o.MediaPlayDa == null) ? default(StringOffset) : builder.CreateString(_o.MediaPlayDa);
			VectorOffset actorRefsOffset = default(VectorOffset);
			if (_o.ActorRefs != null)
			{
				Offset<IActorRef>[] array = new Offset<IActorRef>[_o.ActorRefs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActorRef.Pack(builder, _o.ActorRefs[i]);
				}
				actorRefsOffset = IChangeMediaPlayDa.CreateActorRefsVector(builder, array);
			}
			return IChangeMediaPlayDa.CreateIChangeMediaPlayDa(builder, _o.Type, mediaPlayDaOffset, actorRefsOffset);
		}

		// Token: 0x040108C9 RID: 67785
		private Table __p;
	}
}

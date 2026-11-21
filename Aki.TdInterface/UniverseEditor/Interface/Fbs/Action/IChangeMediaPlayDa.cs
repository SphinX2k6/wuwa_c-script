using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006979 RID: 27001
	public struct IChangeMediaPlayDa : IFlatbufferObject
	{
		// Token: 0x1700C6CB RID: 50891
		// (get) Token: 0x0602E4DC RID: 189660 RVA: 0x00652828 File Offset: 0x00650A28
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E4DD RID: 189661 RVA: 0x00652835 File Offset: 0x00650A35
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E4DE RID: 189662 RVA: 0x0065283C File Offset: 0x00650A3C
		public static IChangeMediaPlayDa GetRootAsIChangeMediaPlayDa(ByteBuffer _bb)
		{
			return IChangeMediaPlayDa.GetRootAsIChangeMediaPlayDa(_bb, default(IChangeMediaPlayDa));
		}

		// Token: 0x0602E4DF RID: 189663 RVA: 0x00652858 File Offset: 0x00650A58
		public static IChangeMediaPlayDa GetRootAsIChangeMediaPlayDa(ByteBuffer _bb, IChangeMediaPlayDa obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E4E0 RID: 189664 RVA: 0x00652875 File Offset: 0x00650A75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E4E1 RID: 189665 RVA: 0x00652884 File Offset: 0x00650A84
		public IChangeMediaPlayDa __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C6CC RID: 50892
		// (get) Token: 0x0602E4E2 RID: 189666 RVA: 0x00652894 File Offset: 0x00650A94
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

		// Token: 0x1700C6CD RID: 50893
		// (get) Token: 0x0602E4E3 RID: 189667 RVA: 0x006528D0 File Offset: 0x00650AD0
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

		// Token: 0x0602E4E4 RID: 189668 RVA: 0x00652907 File Offset: 0x00650B07
		public Span<byte> GetMediaPlayDaBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602E4E5 RID: 189669 RVA: 0x00652916 File Offset: 0x00650B16
		public byte[] GetMediaPlayDaArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602E4E6 RID: 189670 RVA: 0x00652924 File Offset: 0x00650B24
		public IActorRef? ActorRefs(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C6CE RID: 50894
		// (get) Token: 0x0602E4E7 RID: 189671 RVA: 0x00652984 File Offset: 0x00650B84
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

		// Token: 0x0602E4E8 RID: 189672 RVA: 0x006529AF File Offset: 0x00650BAF
		public static Offset<IChangeMediaPlayDa> CreateIChangeMediaPlayDa(FlatBufferBuilder builder, EModifyActorMediaType Type = EModifyActorMediaType.ChangeMediaPlayDA, StringOffset MediaPlayDaOffset = default(StringOffset), VectorOffset ActorRefsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IChangeMediaPlayDa.AddActorRefs(builder, ActorRefsOffset);
			IChangeMediaPlayDa.AddMediaPlayDa(builder, MediaPlayDaOffset);
			IChangeMediaPlayDa.AddType(builder, Type);
			return IChangeMediaPlayDa.EndIChangeMediaPlayDa(builder);
		}

		// Token: 0x0602E4E9 RID: 189673 RVA: 0x006529D3 File Offset: 0x00650BD3
		public static void StartIChangeMediaPlayDa(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602E4EA RID: 189674 RVA: 0x006529DC File Offset: 0x00650BDC
		public static void AddType(FlatBufferBuilder builder, EModifyActorMediaType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E4EB RID: 189675 RVA: 0x006529E7 File Offset: 0x00650BE7
		public static void AddMediaPlayDa(FlatBufferBuilder builder, StringOffset mediaPlayDaOffset)
		{
			builder.AddOffset(1, mediaPlayDaOffset.Value, 0);
		}

		// Token: 0x0602E4EC RID: 189676 RVA: 0x006529F7 File Offset: 0x00650BF7
		public static void AddActorRefs(FlatBufferBuilder builder, VectorOffset actorRefsOffset)
		{
			builder.AddOffset(2, actorRefsOffset.Value, 0);
		}

		// Token: 0x0602E4ED RID: 189677 RVA: 0x00652A08 File Offset: 0x00650C08
		public static VectorOffset CreateActorRefsVector(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602E4EE RID: 189678 RVA: 0x00652A48 File Offset: 0x00650C48
		public static VectorOffset CreateActorRefsVectorBlock(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E4EF RID: 189679 RVA: 0x00652A62 File Offset: 0x00650C62
		public static VectorOffset CreateActorRefsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorRef>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E4F0 RID: 189680 RVA: 0x00652A80 File Offset: 0x00650C80
		public static VectorOffset CreateActorRefsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorRef>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602E4F1 RID: 189681 RVA: 0x00652A99 File Offset: 0x00650C99
		public static void StartActorRefsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602E4F2 RID: 189682 RVA: 0x00652AA4 File Offset: 0x00650CA4
		public static Offset<IChangeMediaPlayDa> EndIChangeMediaPlayDa(FlatBufferBuilder builder)
		{
			return new Offset<IChangeMediaPlayDa>(builder.EndTable());
		}

		// Token: 0x0602E4F3 RID: 189683 RVA: 0x00652AB4 File Offset: 0x00650CB4
		public IChangeMediaPlayDaT UnPack()
		{
			IChangeMediaPlayDaT changeMediaPlayDaT = new IChangeMediaPlayDaT();
			this.UnPackTo(changeMediaPlayDaT);
			return changeMediaPlayDaT;
		}

		// Token: 0x0602E4F4 RID: 189684 RVA: 0x00652AD0 File Offset: 0x00650CD0
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

		// Token: 0x0602E4F5 RID: 189685 RVA: 0x00652B48 File Offset: 0x00650D48
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

		// Token: 0x040116DF RID: 71391
		private Table __p;
	}
}

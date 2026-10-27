using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064D7 RID: 25815
	public struct IControlTrackingOther : IFlatbufferObject
	{
		// Token: 0x1700C017 RID: 49175
		// (get) Token: 0x0602CC76 RID: 183414 RVA: 0x006275F4 File Offset: 0x006257F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CC77 RID: 183415 RVA: 0x00627601 File Offset: 0x00625801
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CC78 RID: 183416 RVA: 0x00627608 File Offset: 0x00625808
		public static IControlTrackingOther GetRootAsIControlTrackingOther(ByteBuffer _bb)
		{
			return IControlTrackingOther.GetRootAsIControlTrackingOther(_bb, default(IControlTrackingOther));
		}

		// Token: 0x0602CC79 RID: 183417 RVA: 0x00627624 File Offset: 0x00625824
		public static IControlTrackingOther GetRootAsIControlTrackingOther(ByteBuffer _bb, IControlTrackingOther obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CC7A RID: 183418 RVA: 0x00627641 File Offset: 0x00625841
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CC7B RID: 183419 RVA: 0x00627650 File Offset: 0x00625850
		public IControlTrackingOther __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C018 RID: 49176
		// (get) Token: 0x0602CC7C RID: 183420 RVA: 0x00627660 File Offset: 0x00625860
		public EControlTrackingType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EControlTrackingType.Self;
				}
				return (EControlTrackingType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CC7D RID: 183421 RVA: 0x0062769C File Offset: 0x0062589C
		public int Entities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C019 RID: 49177
		// (get) Token: 0x0602CC7E RID: 183422 RVA: 0x006276DC File Offset: 0x006258DC
		public int EntitiesLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602CC7F RID: 183423 RVA: 0x00627707 File Offset: 0x00625907
		public Span<int> GetEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602CC80 RID: 183424 RVA: 0x00627716 File Offset: 0x00625916
		public int[] GetEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0602CC81 RID: 183425 RVA: 0x00627724 File Offset: 0x00625924
		public static Offset<IControlTrackingOther> CreateIControlTrackingOther(FlatBufferBuilder builder, EControlTrackingType Type = EControlTrackingType.Self, VectorOffset EntitiesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IControlTrackingOther.AddEntities(builder, EntitiesOffset);
			IControlTrackingOther.AddType(builder, Type);
			return IControlTrackingOther.EndIControlTrackingOther(builder);
		}

		// Token: 0x0602CC82 RID: 183426 RVA: 0x00627741 File Offset: 0x00625941
		public static void StartIControlTrackingOther(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602CC83 RID: 183427 RVA: 0x0062774A File Offset: 0x0062594A
		public static void AddType(FlatBufferBuilder builder, EControlTrackingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CC84 RID: 183428 RVA: 0x00627755 File Offset: 0x00625955
		public static void AddEntities(FlatBufferBuilder builder, VectorOffset entitiesOffset)
		{
			builder.AddOffset(1, entitiesOffset.Value, 0);
		}

		// Token: 0x0602CC85 RID: 183429 RVA: 0x00627768 File Offset: 0x00625968
		public static VectorOffset CreateEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602CC86 RID: 183430 RVA: 0x0062779F File Offset: 0x0062599F
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CC87 RID: 183431 RVA: 0x006277B9 File Offset: 0x006259B9
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CC88 RID: 183432 RVA: 0x006277D7 File Offset: 0x006259D7
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602CC89 RID: 183433 RVA: 0x006277F0 File Offset: 0x006259F0
		public static void StartEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602CC8A RID: 183434 RVA: 0x006277FB File Offset: 0x006259FB
		public static Offset<IControlTrackingOther> EndIControlTrackingOther(FlatBufferBuilder builder)
		{
			return new Offset<IControlTrackingOther>(builder.EndTable());
		}

		// Token: 0x0602CC8B RID: 183435 RVA: 0x00627808 File Offset: 0x00625A08
		public IControlTrackingOtherT UnPack()
		{
			IControlTrackingOtherT controlTrackingOtherT = new IControlTrackingOtherT();
			this.UnPackTo(controlTrackingOtherT);
			return controlTrackingOtherT;
		}

		// Token: 0x0602CC8C RID: 183436 RVA: 0x00627824 File Offset: 0x00625A24
		public void UnPackTo(IControlTrackingOtherT _o)
		{
			_o.Type = this.Type;
			_o.Entities = new List<int>();
			for (int i = 0; i < this.EntitiesLength; i++)
			{
				_o.Entities.Add(this.Entities(i));
			}
		}

		// Token: 0x0602CC8D RID: 183437 RVA: 0x0062786C File Offset: 0x00625A6C
		public static Offset<IControlTrackingOther> Pack(FlatBufferBuilder builder, IControlTrackingOtherT _o)
		{
			if (_o == null)
			{
				return default(Offset<IControlTrackingOther>);
			}
			VectorOffset entitiesOffset = default(VectorOffset);
			if (_o.Entities != null)
			{
				int[] data = _o.Entities.ToArray();
				entitiesOffset = IControlTrackingOther.CreateEntitiesVector(builder, data);
			}
			return IControlTrackingOther.CreateIControlTrackingOther(builder, _o.Type, entitiesOffset);
		}

		// Token: 0x04010B12 RID: 68370
		private Table __p;
	}
}

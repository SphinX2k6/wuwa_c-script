using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200731F RID: 29471
	public struct INpcGroupSequenceStaticEntityBinding : IFlatbufferObject
	{
		// Token: 0x1700D803 RID: 55299
		// (get) Token: 0x06033635 RID: 210485 RVA: 0x006EDB72 File Offset: 0x006EBD72
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033636 RID: 210486 RVA: 0x006EDB7F File Offset: 0x006EBD7F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033637 RID: 210487 RVA: 0x006EDB88 File Offset: 0x006EBD88
		public static INpcGroupSequenceStaticEntityBinding GetRootAsINpcGroupSequenceStaticEntityBinding(ByteBuffer _bb)
		{
			return INpcGroupSequenceStaticEntityBinding.GetRootAsINpcGroupSequenceStaticEntityBinding(_bb, default(INpcGroupSequenceStaticEntityBinding));
		}

		// Token: 0x06033638 RID: 210488 RVA: 0x006EDBA4 File Offset: 0x006EBDA4
		public static INpcGroupSequenceStaticEntityBinding GetRootAsINpcGroupSequenceStaticEntityBinding(ByteBuffer _bb, INpcGroupSequenceStaticEntityBinding obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033639 RID: 210489 RVA: 0x006EDBC1 File Offset: 0x006EBDC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603363A RID: 210490 RVA: 0x006EDBD0 File Offset: 0x006EBDD0
		public INpcGroupSequenceStaticEntityBinding __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D804 RID: 55300
		// (get) Token: 0x0603363B RID: 210491 RVA: 0x006EDBE0 File Offset: 0x006EBDE0
		public ENpcGroupSequenceBindingType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcGroupSequenceBindingType.StaticEntity;
				}
				return (ENpcGroupSequenceBindingType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603363C RID: 210492 RVA: 0x006EDC1C File Offset: 0x006EBE1C
		public int Actors(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D805 RID: 55301
		// (get) Token: 0x0603363D RID: 210493 RVA: 0x006EDC5C File Offset: 0x006EBE5C
		public int ActorsLength
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

		// Token: 0x0603363E RID: 210494 RVA: 0x006EDC87 File Offset: 0x006EBE87
		public Span<int> GetActorsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0603363F RID: 210495 RVA: 0x006EDC96 File Offset: 0x006EBE96
		public int[] GetActorsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06033640 RID: 210496 RVA: 0x006EDCA4 File Offset: 0x006EBEA4
		public static Offset<INpcGroupSequenceStaticEntityBinding> CreateINpcGroupSequenceStaticEntityBinding(FlatBufferBuilder builder, ENpcGroupSequenceBindingType Type = ENpcGroupSequenceBindingType.StaticEntity, VectorOffset ActorsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			INpcGroupSequenceStaticEntityBinding.AddActors(builder, ActorsOffset);
			INpcGroupSequenceStaticEntityBinding.AddType(builder, Type);
			return INpcGroupSequenceStaticEntityBinding.EndINpcGroupSequenceStaticEntityBinding(builder);
		}

		// Token: 0x06033641 RID: 210497 RVA: 0x006EDCC1 File Offset: 0x006EBEC1
		public static void StartINpcGroupSequenceStaticEntityBinding(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033642 RID: 210498 RVA: 0x006EDCCA File Offset: 0x006EBECA
		public static void AddType(FlatBufferBuilder builder, ENpcGroupSequenceBindingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033643 RID: 210499 RVA: 0x006EDCD5 File Offset: 0x006EBED5
		public static void AddActors(FlatBufferBuilder builder, VectorOffset actorsOffset)
		{
			builder.AddOffset(1, actorsOffset.Value, 0);
		}

		// Token: 0x06033644 RID: 210500 RVA: 0x006EDCE8 File Offset: 0x006EBEE8
		public static VectorOffset CreateActorsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06033645 RID: 210501 RVA: 0x006EDD1F File Offset: 0x006EBF1F
		public static VectorOffset CreateActorsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06033646 RID: 210502 RVA: 0x006EDD39 File Offset: 0x006EBF39
		public static VectorOffset CreateActorsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06033647 RID: 210503 RVA: 0x006EDD57 File Offset: 0x006EBF57
		public static VectorOffset CreateActorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033648 RID: 210504 RVA: 0x006EDD70 File Offset: 0x006EBF70
		public static void StartActorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06033649 RID: 210505 RVA: 0x006EDD7B File Offset: 0x006EBF7B
		public static Offset<INpcGroupSequenceStaticEntityBinding> EndINpcGroupSequenceStaticEntityBinding(FlatBufferBuilder builder)
		{
			return new Offset<INpcGroupSequenceStaticEntityBinding>(builder.EndTable());
		}

		// Token: 0x0603364A RID: 210506 RVA: 0x006EDD88 File Offset: 0x006EBF88
		public INpcGroupSequenceStaticEntityBindingT UnPack()
		{
			INpcGroupSequenceStaticEntityBindingT npcGroupSequenceStaticEntityBindingT = new INpcGroupSequenceStaticEntityBindingT();
			this.UnPackTo(npcGroupSequenceStaticEntityBindingT);
			return npcGroupSequenceStaticEntityBindingT;
		}

		// Token: 0x0603364B RID: 210507 RVA: 0x006EDDA4 File Offset: 0x006EBFA4
		public void UnPackTo(INpcGroupSequenceStaticEntityBindingT _o)
		{
			_o.Type = this.Type;
			_o.Actors = new List<int>();
			for (int i = 0; i < this.ActorsLength; i++)
			{
				_o.Actors.Add(this.Actors(i));
			}
		}

		// Token: 0x0603364C RID: 210508 RVA: 0x006EDDEC File Offset: 0x006EBFEC
		public static Offset<INpcGroupSequenceStaticEntityBinding> Pack(FlatBufferBuilder builder, INpcGroupSequenceStaticEntityBindingT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcGroupSequenceStaticEntityBinding>);
			}
			VectorOffset actorsOffset = default(VectorOffset);
			if (_o.Actors != null)
			{
				int[] data = _o.Actors.ToArray();
				actorsOffset = INpcGroupSequenceStaticEntityBinding.CreateActorsVector(builder, data);
			}
			return INpcGroupSequenceStaticEntityBinding.CreateINpcGroupSequenceStaticEntityBinding(builder, _o.Type, actorsOffset);
		}

		// Token: 0x040123E1 RID: 74721
		private Table __p;
	}
}

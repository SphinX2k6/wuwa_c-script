using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006717 RID: 26391
	public struct IExecuteTag : IFlatbufferObject
	{
		// Token: 0x1700C406 RID: 50182
		// (get) Token: 0x0602DE67 RID: 188007 RVA: 0x00646AB5 File Offset: 0x00644CB5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DE68 RID: 188008 RVA: 0x00646AC2 File Offset: 0x00644CC2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DE69 RID: 188009 RVA: 0x00646ACC File Offset: 0x00644CCC
		public static IExecuteTag GetRootAsIExecuteTag(ByteBuffer _bb)
		{
			return IExecuteTag.GetRootAsIExecuteTag(_bb, default(IExecuteTag));
		}

		// Token: 0x0602DE6A RID: 188010 RVA: 0x00646AE8 File Offset: 0x00644CE8
		public static IExecuteTag GetRootAsIExecuteTag(ByteBuffer _bb, IExecuteTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DE6B RID: 188011 RVA: 0x00646B05 File Offset: 0x00644D05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DE6C RID: 188012 RVA: 0x00646B14 File Offset: 0x00644D14
		public IExecuteTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C407 RID: 50183
		// (get) Token: 0x0602DE6D RID: 188013 RVA: 0x00646B24 File Offset: 0x00644D24
		public EInteractEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractEffectType.ModifyTipText;
				}
				return (EInteractEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C408 RID: 50184
		// (get) Token: 0x0602DE6E RID: 188014 RVA: 0x00646B60 File Offset: 0x00644D60
		public float DelayTime
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DE6F RID: 188015 RVA: 0x00646BA0 File Offset: 0x00644DA0
		public int Tags(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C409 RID: 50185
		// (get) Token: 0x0602DE70 RID: 188016 RVA: 0x00646BE0 File Offset: 0x00644DE0
		public int TagsLength
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

		// Token: 0x0602DE71 RID: 188017 RVA: 0x00646C0B File Offset: 0x00644E0B
		public Span<int> GetTagsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0602DE72 RID: 188018 RVA: 0x00646C1A File Offset: 0x00644E1A
		public int[] GetTagsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x1700C40A RID: 50186
		// (get) Token: 0x0602DE73 RID: 188019 RVA: 0x00646C28 File Offset: 0x00644E28
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DE74 RID: 188020 RVA: 0x00646C65 File Offset: 0x00644E65
		public static Offset<IExecuteTag> CreateIExecuteTag(FlatBufferBuilder builder, EInteractEffectType Type = EInteractEffectType.ModifyTipText, float DelayTime = 0f, VectorOffset TagsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IExecuteTag.AddTags(builder, TagsOffset);
			IExecuteTag.AddDelayTime(builder, DelayTime);
			IExecuteTag.AddNullMask(builder, NullMask);
			IExecuteTag.AddType(builder, Type);
			return IExecuteTag.EndIExecuteTag(builder);
		}

		// Token: 0x0602DE75 RID: 188021 RVA: 0x00646C91 File Offset: 0x00644E91
		public static void StartIExecuteTag(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602DE76 RID: 188022 RVA: 0x00646C9A File Offset: 0x00644E9A
		public static void AddType(FlatBufferBuilder builder, EInteractEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DE77 RID: 188023 RVA: 0x00646CA5 File Offset: 0x00644EA5
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(1, delayTime, 0.0);
		}

		// Token: 0x0602DE78 RID: 188024 RVA: 0x00646CB8 File Offset: 0x00644EB8
		public static void AddTags(FlatBufferBuilder builder, VectorOffset tagsOffset)
		{
			builder.AddOffset(2, tagsOffset.Value, 0);
		}

		// Token: 0x0602DE79 RID: 188025 RVA: 0x00646CC8 File Offset: 0x00644EC8
		public static VectorOffset CreateTagsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602DE7A RID: 188026 RVA: 0x00646CFF File Offset: 0x00644EFF
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602DE7B RID: 188027 RVA: 0x00646D19 File Offset: 0x00644F19
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602DE7C RID: 188028 RVA: 0x00646D37 File Offset: 0x00644F37
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602DE7D RID: 188029 RVA: 0x00646D50 File Offset: 0x00644F50
		public static void StartTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602DE7E RID: 188030 RVA: 0x00646D5B File Offset: 0x00644F5B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602DE7F RID: 188031 RVA: 0x00646D66 File Offset: 0x00644F66
		public static Offset<IExecuteTag> EndIExecuteTag(FlatBufferBuilder builder)
		{
			return new Offset<IExecuteTag>(builder.EndTable());
		}

		// Token: 0x0602DE80 RID: 188032 RVA: 0x00646D74 File Offset: 0x00644F74
		public IExecuteTagT UnPack()
		{
			IExecuteTagT executeTagT = new IExecuteTagT();
			this.UnPackTo(executeTagT);
			return executeTagT;
		}

		// Token: 0x0602DE81 RID: 188033 RVA: 0x00646D90 File Offset: 0x00644F90
		public void UnPackTo(IExecuteTagT _o)
		{
			_o.Type = this.Type;
			_o.DelayTime = this.DelayTime;
			_o.Tags = new List<int>();
			for (int i = 0; i < this.TagsLength; i++)
			{
				_o.Tags.Add(this.Tags(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602DE82 RID: 188034 RVA: 0x00646DF0 File Offset: 0x00644FF0
		public static Offset<IExecuteTag> Pack(FlatBufferBuilder builder, IExecuteTagT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExecuteTag>);
			}
			VectorOffset tagsOffset = default(VectorOffset);
			if (_o.Tags != null)
			{
				int[] data = _o.Tags.ToArray();
				tagsOffset = IExecuteTag.CreateTagsVector(builder, data);
			}
			return IExecuteTag.CreateIExecuteTag(builder, _o.Type, _o.DelayTime, tagsOffset, _o.NullMask);
		}

		// Token: 0x04010DFC RID: 69116
		private Table __p;
	}
}

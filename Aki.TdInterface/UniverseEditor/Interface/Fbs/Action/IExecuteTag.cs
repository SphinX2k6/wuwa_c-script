using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D97 RID: 28055
	public struct IExecuteTag : IFlatbufferObject
	{
		// Token: 0x1700CDBC RID: 52668
		// (get) Token: 0x060306AD RID: 198317 RVA: 0x006941F9 File Offset: 0x006923F9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060306AE RID: 198318 RVA: 0x00694206 File Offset: 0x00692406
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060306AF RID: 198319 RVA: 0x00694210 File Offset: 0x00692410
		public static IExecuteTag GetRootAsIExecuteTag(ByteBuffer _bb)
		{
			return IExecuteTag.GetRootAsIExecuteTag(_bb, default(IExecuteTag));
		}

		// Token: 0x060306B0 RID: 198320 RVA: 0x0069422C File Offset: 0x0069242C
		public static IExecuteTag GetRootAsIExecuteTag(ByteBuffer _bb, IExecuteTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060306B1 RID: 198321 RVA: 0x00694249 File Offset: 0x00692449
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060306B2 RID: 198322 RVA: 0x00694258 File Offset: 0x00692458
		public IExecuteTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDBD RID: 52669
		// (get) Token: 0x060306B3 RID: 198323 RVA: 0x00694268 File Offset: 0x00692468
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

		// Token: 0x1700CDBE RID: 52670
		// (get) Token: 0x060306B4 RID: 198324 RVA: 0x006942A4 File Offset: 0x006924A4
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

		// Token: 0x060306B5 RID: 198325 RVA: 0x006942E4 File Offset: 0x006924E4
		public int Tags(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CDBF RID: 52671
		// (get) Token: 0x060306B6 RID: 198326 RVA: 0x00694324 File Offset: 0x00692524
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

		// Token: 0x060306B7 RID: 198327 RVA: 0x0069434F File Offset: 0x0069254F
		public Span<int> GetTagsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060306B8 RID: 198328 RVA: 0x0069435E File Offset: 0x0069255E
		public int[] GetTagsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x1700CDC0 RID: 52672
		// (get) Token: 0x060306B9 RID: 198329 RVA: 0x0069436C File Offset: 0x0069256C
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

		// Token: 0x060306BA RID: 198330 RVA: 0x006943A9 File Offset: 0x006925A9
		public static Offset<IExecuteTag> CreateIExecuteTag(FlatBufferBuilder builder, EInteractEffectType Type = EInteractEffectType.ModifyTipText, float DelayTime = 0f, VectorOffset TagsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IExecuteTag.AddTags(builder, TagsOffset);
			IExecuteTag.AddDelayTime(builder, DelayTime);
			IExecuteTag.AddNullMask(builder, NullMask);
			IExecuteTag.AddType(builder, Type);
			return IExecuteTag.EndIExecuteTag(builder);
		}

		// Token: 0x060306BB RID: 198331 RVA: 0x006943D5 File Offset: 0x006925D5
		public static void StartIExecuteTag(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060306BC RID: 198332 RVA: 0x006943DE File Offset: 0x006925DE
		public static void AddType(FlatBufferBuilder builder, EInteractEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060306BD RID: 198333 RVA: 0x006943E9 File Offset: 0x006925E9
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(1, delayTime, 0.0);
		}

		// Token: 0x060306BE RID: 198334 RVA: 0x006943FC File Offset: 0x006925FC
		public static void AddTags(FlatBufferBuilder builder, VectorOffset tagsOffset)
		{
			builder.AddOffset(2, tagsOffset.Value, 0);
		}

		// Token: 0x060306BF RID: 198335 RVA: 0x0069440C File Offset: 0x0069260C
		public static VectorOffset CreateTagsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060306C0 RID: 198336 RVA: 0x00694443 File Offset: 0x00692643
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060306C1 RID: 198337 RVA: 0x0069445D File Offset: 0x0069265D
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060306C2 RID: 198338 RVA: 0x0069447B File Offset: 0x0069267B
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060306C3 RID: 198339 RVA: 0x00694494 File Offset: 0x00692694
		public static void StartTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060306C4 RID: 198340 RVA: 0x0069449F File Offset: 0x0069269F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060306C5 RID: 198341 RVA: 0x006944AA File Offset: 0x006926AA
		public static Offset<IExecuteTag> EndIExecuteTag(FlatBufferBuilder builder)
		{
			return new Offset<IExecuteTag>(builder.EndTable());
		}

		// Token: 0x060306C6 RID: 198342 RVA: 0x006944B8 File Offset: 0x006926B8
		public IExecuteTagT UnPack()
		{
			IExecuteTagT executeTagT = new IExecuteTagT();
			this.UnPackTo(executeTagT);
			return executeTagT;
		}

		// Token: 0x060306C7 RID: 198343 RVA: 0x006944D4 File Offset: 0x006926D4
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

		// Token: 0x060306C8 RID: 198344 RVA: 0x00694534 File Offset: 0x00692734
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

		// Token: 0x04011C2E RID: 72750
		private Table __p;
	}
}

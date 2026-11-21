using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EC8 RID: 24264
	public struct ISceneItemAttributeComponent : IFlatbufferObject
	{
		// Token: 0x1700B33F RID: 45887
		// (get) Token: 0x06028A88 RID: 166536 RVA: 0x0058ED9E File Offset: 0x0058CF9E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028A89 RID: 166537 RVA: 0x0058EDAB File Offset: 0x0058CFAB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028A8A RID: 166538 RVA: 0x0058EDB4 File Offset: 0x0058CFB4
		public static ISceneItemAttributeComponent GetRootAsISceneItemAttributeComponent(ByteBuffer _bb)
		{
			return ISceneItemAttributeComponent.GetRootAsISceneItemAttributeComponent(_bb, default(ISceneItemAttributeComponent));
		}

		// Token: 0x06028A8B RID: 166539 RVA: 0x0058EDD0 File Offset: 0x0058CFD0
		public static ISceneItemAttributeComponent GetRootAsISceneItemAttributeComponent(ByteBuffer _bb, ISceneItemAttributeComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028A8C RID: 166540 RVA: 0x0058EDED File Offset: 0x0058CFED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028A8D RID: 166541 RVA: 0x0058EDFC File Offset: 0x0058CFFC
		public ISceneItemAttributeComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B340 RID: 45888
		// (get) Token: 0x06028A8E RID: 166542 RVA: 0x0058EE0C File Offset: 0x0058D00C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B341 RID: 45889
		// (get) Token: 0x06028A8F RID: 166543 RVA: 0x0058EE4C File Offset: 0x0058D04C
		public string AttributeType
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

		// Token: 0x06028A90 RID: 166544 RVA: 0x0058EE83 File Offset: 0x0058D083
		public Span<byte> GetAttributeTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06028A91 RID: 166545 RVA: 0x0058EE92 File Offset: 0x0058D092
		public byte[] GetAttributeTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06028A92 RID: 166546 RVA: 0x0058EEA0 File Offset: 0x0058D0A0
		public int DefaultTags(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B342 RID: 45890
		// (get) Token: 0x06028A93 RID: 166547 RVA: 0x0058EEE0 File Offset: 0x0058D0E0
		public int DefaultTagsLength
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

		// Token: 0x06028A94 RID: 166548 RVA: 0x0058EF0B File Offset: 0x0058D10B
		public Span<int> GetDefaultTagsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06028A95 RID: 166549 RVA: 0x0058EF1A File Offset: 0x0058D11A
		public int[] GetDefaultTagsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x1700B343 RID: 45891
		// (get) Token: 0x06028A96 RID: 166550 RVA: 0x0058EF28 File Offset: 0x0058D128
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

		// Token: 0x06028A97 RID: 166551 RVA: 0x0058EF65 File Offset: 0x0058D165
		public static Offset<ISceneItemAttributeComponent> CreateISceneItemAttributeComponent(FlatBufferBuilder builder, bool Disabled = false, StringOffset AttributeTypeOffset = default(StringOffset), VectorOffset DefaultTagsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			ISceneItemAttributeComponent.AddDefaultTags(builder, DefaultTagsOffset);
			ISceneItemAttributeComponent.AddAttributeType(builder, AttributeTypeOffset);
			ISceneItemAttributeComponent.AddNullMask(builder, NullMask);
			ISceneItemAttributeComponent.AddDisabled(builder, Disabled);
			return ISceneItemAttributeComponent.EndISceneItemAttributeComponent(builder);
		}

		// Token: 0x06028A98 RID: 166552 RVA: 0x0058EF91 File Offset: 0x0058D191
		public static void StartISceneItemAttributeComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06028A99 RID: 166553 RVA: 0x0058EF9A File Offset: 0x0058D19A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06028A9A RID: 166554 RVA: 0x0058EFA5 File Offset: 0x0058D1A5
		public static void AddAttributeType(FlatBufferBuilder builder, StringOffset attributeTypeOffset)
		{
			builder.AddOffset(1, attributeTypeOffset.Value, 0);
		}

		// Token: 0x06028A9B RID: 166555 RVA: 0x0058EFB5 File Offset: 0x0058D1B5
		public static void AddDefaultTags(FlatBufferBuilder builder, VectorOffset defaultTagsOffset)
		{
			builder.AddOffset(2, defaultTagsOffset.Value, 0);
		}

		// Token: 0x06028A9C RID: 166556 RVA: 0x0058EFC8 File Offset: 0x0058D1C8
		public static VectorOffset CreateDefaultTagsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06028A9D RID: 166557 RVA: 0x0058EFFF File Offset: 0x0058D1FF
		public static VectorOffset CreateDefaultTagsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06028A9E RID: 166558 RVA: 0x0058F019 File Offset: 0x0058D219
		public static VectorOffset CreateDefaultTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06028A9F RID: 166559 RVA: 0x0058F037 File Offset: 0x0058D237
		public static VectorOffset CreateDefaultTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028AA0 RID: 166560 RVA: 0x0058F050 File Offset: 0x0058D250
		public static void StartDefaultTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028AA1 RID: 166561 RVA: 0x0058F05B File Offset: 0x0058D25B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06028AA2 RID: 166562 RVA: 0x0058F066 File Offset: 0x0058D266
		public static Offset<ISceneItemAttributeComponent> EndISceneItemAttributeComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISceneItemAttributeComponent>(builder.EndTable());
		}

		// Token: 0x06028AA3 RID: 166563 RVA: 0x0058F074 File Offset: 0x0058D274
		public ISceneItemAttributeComponentT UnPack()
		{
			ISceneItemAttributeComponentT sceneItemAttributeComponentT = new ISceneItemAttributeComponentT();
			this.UnPackTo(sceneItemAttributeComponentT);
			return sceneItemAttributeComponentT;
		}

		// Token: 0x06028AA4 RID: 166564 RVA: 0x0058F090 File Offset: 0x0058D290
		public void UnPackTo(ISceneItemAttributeComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.AttributeType = this.AttributeType;
			_o.DefaultTags = new List<int>();
			for (int i = 0; i < this.DefaultTagsLength; i++)
			{
				_o.DefaultTags.Add(this.DefaultTags(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06028AA5 RID: 166565 RVA: 0x0058F0F0 File Offset: 0x0058D2F0
		public static Offset<ISceneItemAttributeComponent> Pack(FlatBufferBuilder builder, ISceneItemAttributeComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneItemAttributeComponent>);
			}
			StringOffset attributeTypeOffset = (_o.AttributeType == null) ? default(StringOffset) : builder.CreateString(_o.AttributeType);
			VectorOffset defaultTagsOffset = default(VectorOffset);
			if (_o.DefaultTags != null)
			{
				int[] data = _o.DefaultTags.ToArray();
				defaultTagsOffset = ISceneItemAttributeComponent.CreateDefaultTagsVector(builder, data);
			}
			return ISceneItemAttributeComponent.CreateISceneItemAttributeComponent(builder, _o.Disabled, attributeTypeOffset, defaultTagsOffset, _o.NullMask);
		}

		// Token: 0x0400FB21 RID: 64289
		private Table __p;
	}
}

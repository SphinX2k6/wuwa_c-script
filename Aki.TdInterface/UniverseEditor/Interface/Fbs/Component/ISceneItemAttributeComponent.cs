using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058BB RID: 22715
	public struct ISceneItemAttributeComponent : IFlatbufferObject
	{
		// Token: 0x1700AA0F RID: 43535
		// (get) Token: 0x06026526 RID: 156966 RVA: 0x00548252 File Offset: 0x00546452
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026527 RID: 156967 RVA: 0x0054825F File Offset: 0x0054645F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026528 RID: 156968 RVA: 0x00548268 File Offset: 0x00546468
		public static ISceneItemAttributeComponent GetRootAsISceneItemAttributeComponent(ByteBuffer _bb)
		{
			return ISceneItemAttributeComponent.GetRootAsISceneItemAttributeComponent(_bb, default(ISceneItemAttributeComponent));
		}

		// Token: 0x06026529 RID: 156969 RVA: 0x00548284 File Offset: 0x00546484
		public static ISceneItemAttributeComponent GetRootAsISceneItemAttributeComponent(ByteBuffer _bb, ISceneItemAttributeComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602652A RID: 156970 RVA: 0x005482A1 File Offset: 0x005464A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602652B RID: 156971 RVA: 0x005482B0 File Offset: 0x005464B0
		public ISceneItemAttributeComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA10 RID: 43536
		// (get) Token: 0x0602652C RID: 156972 RVA: 0x005482C0 File Offset: 0x005464C0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AA11 RID: 43537
		// (get) Token: 0x0602652D RID: 156973 RVA: 0x00548300 File Offset: 0x00546500
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

		// Token: 0x0602652E RID: 156974 RVA: 0x00548337 File Offset: 0x00546537
		public Span<byte> GetAttributeTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602652F RID: 156975 RVA: 0x00548346 File Offset: 0x00546546
		public byte[] GetAttributeTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06026530 RID: 156976 RVA: 0x00548354 File Offset: 0x00546554
		public int DefaultTags(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700AA12 RID: 43538
		// (get) Token: 0x06026531 RID: 156977 RVA: 0x00548394 File Offset: 0x00546594
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

		// Token: 0x06026532 RID: 156978 RVA: 0x005483BF File Offset: 0x005465BF
		public Span<int> GetDefaultTagsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06026533 RID: 156979 RVA: 0x005483CE File Offset: 0x005465CE
		public int[] GetDefaultTagsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x1700AA13 RID: 43539
		// (get) Token: 0x06026534 RID: 156980 RVA: 0x005483DC File Offset: 0x005465DC
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

		// Token: 0x06026535 RID: 156981 RVA: 0x00548419 File Offset: 0x00546619
		public static Offset<ISceneItemAttributeComponent> CreateISceneItemAttributeComponent(FlatBufferBuilder builder, bool Disabled = false, StringOffset AttributeTypeOffset = default(StringOffset), VectorOffset DefaultTagsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			ISceneItemAttributeComponent.AddDefaultTags(builder, DefaultTagsOffset);
			ISceneItemAttributeComponent.AddAttributeType(builder, AttributeTypeOffset);
			ISceneItemAttributeComponent.AddNullMask(builder, NullMask);
			ISceneItemAttributeComponent.AddDisabled(builder, Disabled);
			return ISceneItemAttributeComponent.EndISceneItemAttributeComponent(builder);
		}

		// Token: 0x06026536 RID: 156982 RVA: 0x00548445 File Offset: 0x00546645
		public static void StartISceneItemAttributeComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06026537 RID: 156983 RVA: 0x0054844E File Offset: 0x0054664E
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06026538 RID: 156984 RVA: 0x00548459 File Offset: 0x00546659
		public static void AddAttributeType(FlatBufferBuilder builder, StringOffset attributeTypeOffset)
		{
			builder.AddOffset(1, attributeTypeOffset.Value, 0);
		}

		// Token: 0x06026539 RID: 156985 RVA: 0x00548469 File Offset: 0x00546669
		public static void AddDefaultTags(FlatBufferBuilder builder, VectorOffset defaultTagsOffset)
		{
			builder.AddOffset(2, defaultTagsOffset.Value, 0);
		}

		// Token: 0x0602653A RID: 156986 RVA: 0x0054847C File Offset: 0x0054667C
		public static VectorOffset CreateDefaultTagsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602653B RID: 156987 RVA: 0x005484B3 File Offset: 0x005466B3
		public static VectorOffset CreateDefaultTagsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602653C RID: 156988 RVA: 0x005484CD File Offset: 0x005466CD
		public static VectorOffset CreateDefaultTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602653D RID: 156989 RVA: 0x005484EB File Offset: 0x005466EB
		public static VectorOffset CreateDefaultTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602653E RID: 156990 RVA: 0x00548504 File Offset: 0x00546704
		public static void StartDefaultTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602653F RID: 156991 RVA: 0x0054850F File Offset: 0x0054670F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06026540 RID: 156992 RVA: 0x0054851A File Offset: 0x0054671A
		public static Offset<ISceneItemAttributeComponent> EndISceneItemAttributeComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISceneItemAttributeComponent>(builder.EndTable());
		}

		// Token: 0x06026541 RID: 156993 RVA: 0x00548528 File Offset: 0x00546728
		public ISceneItemAttributeComponentT UnPack()
		{
			ISceneItemAttributeComponentT sceneItemAttributeComponentT = new ISceneItemAttributeComponentT();
			this.UnPackTo(sceneItemAttributeComponentT);
			return sceneItemAttributeComponentT;
		}

		// Token: 0x06026542 RID: 156994 RVA: 0x00548544 File Offset: 0x00546744
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

		// Token: 0x06026543 RID: 156995 RVA: 0x005485A4 File Offset: 0x005467A4
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

		// Token: 0x0400EE2E RID: 60974
		private Table __p;
	}
}

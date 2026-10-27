using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x02004375 RID: 17269
	public struct IPerformerAiSelector : IFlatbufferObject
	{
		// Token: 0x170079ED RID: 31213
		// (get) Token: 0x06019A38 RID: 105016 RVA: 0x003AB7CA File Offset: 0x003A99CA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019A39 RID: 105017 RVA: 0x003AB7D7 File Offset: 0x003A99D7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019A3A RID: 105018 RVA: 0x003AB7E0 File Offset: 0x003A99E0
		public static IPerformerAiSelector GetRootAsIPerformerAiSelector(ByteBuffer _bb)
		{
			return IPerformerAiSelector.GetRootAsIPerformerAiSelector(_bb, default(IPerformerAiSelector));
		}

		// Token: 0x06019A3B RID: 105019 RVA: 0x003AB7FC File Offset: 0x003A99FC
		public static IPerformerAiSelector GetRootAsIPerformerAiSelector(ByteBuffer _bb, IPerformerAiSelector obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019A3C RID: 105020 RVA: 0x003AB819 File Offset: 0x003A9A19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019A3D RID: 105021 RVA: 0x003AB828 File Offset: 0x003A9A28
		public IPerformerAiSelector __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170079EE RID: 31214
		// (get) Token: 0x06019A3E RID: 105022 RVA: 0x003AB838 File Offset: 0x003A9A38
		public EPerformerAiNodeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPerformerAiNodeType.Start;
				}
				return (EPerformerAiNodeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170079EF RID: 31215
		// (get) Token: 0x06019A3F RID: 105023 RVA: 0x003AB874 File Offset: 0x003A9A74
		public int Id
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170079F0 RID: 31216
		// (get) Token: 0x06019A40 RID: 105024 RVA: 0x003AB8B0 File Offset: 0x003A9AB0
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019A41 RID: 105025 RVA: 0x003AB8E7 File Offset: 0x003A9AE7
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06019A42 RID: 105026 RVA: 0x003AB8F6 File Offset: 0x003A9AF6
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06019A43 RID: 105027 RVA: 0x003AB904 File Offset: 0x003A9B04
		public TPerformerAiDecorator DecoratorsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TPerformerAiDecorator.NONE;
			}
			return (TPerformerAiDecorator)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170079F1 RID: 31217
		// (get) Token: 0x06019A44 RID: 105028 RVA: 0x003AB944 File Offset: 0x003A9B44
		public int DecoratorsTypeLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06019A45 RID: 105029 RVA: 0x003AB970 File Offset: 0x003A9B70
		public Span<TPerformerAiDecorator> GetDecoratorsTypeBytes()
		{
			return this.__p.__vector_as_span<TPerformerAiDecorator>(10, 1);
		}

		// Token: 0x06019A46 RID: 105030 RVA: 0x003AB980 File Offset: 0x003A9B80
		public TPerformerAiDecorator[] GetDecoratorsTypeArray()
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TPerformerAiDecorator[] array = new TPerformerAiDecorator[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TPerformerAiDecorator)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06019A47 RID: 105031 RVA: 0x003AB9EC File Offset: 0x003A9BEC
		public TTable? Decorators<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x170079F2 RID: 31218
		// (get) Token: 0x06019A48 RID: 105032 RVA: 0x003ABA34 File Offset: 0x003A9C34
		public int DecoratorsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170079F3 RID: 31219
		// (get) Token: 0x06019A49 RID: 105033 RVA: 0x003ABA60 File Offset: 0x003A9C60
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06019A4A RID: 105034 RVA: 0x003ABAA0 File Offset: 0x003A9CA0
		public TPerformerAiNode ChildrenType(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return TPerformerAiNode.NONE;
			}
			return (TPerformerAiNode)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170079F4 RID: 31220
		// (get) Token: 0x06019A4B RID: 105035 RVA: 0x003ABAE0 File Offset: 0x003A9CE0
		public int ChildrenTypeLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06019A4C RID: 105036 RVA: 0x003ABB0C File Offset: 0x003A9D0C
		public Span<TPerformerAiNode> GetChildrenTypeBytes()
		{
			return this.__p.__vector_as_span<TPerformerAiNode>(16, 1);
		}

		// Token: 0x06019A4D RID: 105037 RVA: 0x003ABB1C File Offset: 0x003A9D1C
		public TPerformerAiNode[] GetChildrenTypeArray()
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TPerformerAiNode[] array = new TPerformerAiNode[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TPerformerAiNode)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06019A4E RID: 105038 RVA: 0x003ABB88 File Offset: 0x003A9D88
		public TTable? Children<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x170079F5 RID: 31221
		// (get) Token: 0x06019A4F RID: 105039 RVA: 0x003ABBD0 File Offset: 0x003A9DD0
		public int ChildrenLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170079F6 RID: 31222
		// (get) Token: 0x06019A50 RID: 105040 RVA: 0x003ABBFC File Offset: 0x003A9DFC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019A51 RID: 105041 RVA: 0x003ABC3C File Offset: 0x003A9E3C
		public static Offset<IPerformerAiSelector> CreateIPerformerAiSelector(FlatBufferBuilder builder, EPerformerAiNodeType Type = EPerformerAiNodeType.Start, int Id = 0, StringOffset DescOffset = default(StringOffset), VectorOffset Decorators_typeOffset = default(VectorOffset), VectorOffset DecoratorsOffset = default(VectorOffset), bool _foldedForTree = false, VectorOffset Children_typeOffset = default(VectorOffset), VectorOffset ChildrenOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(9);
			IPerformerAiSelector.AddChildren(builder, ChildrenOffset);
			IPerformerAiSelector.AddChildrenType(builder, Children_typeOffset);
			IPerformerAiSelector.AddDecorators(builder, DecoratorsOffset);
			IPerformerAiSelector.AddDecoratorsType(builder, Decorators_typeOffset);
			IPerformerAiSelector.AddDesc(builder, DescOffset);
			IPerformerAiSelector.AddId(builder, Id);
			IPerformerAiSelector.AddNullMask(builder, NullMask);
			IPerformerAiSelector.Add_FoldedForTree(builder, _foldedForTree);
			IPerformerAiSelector.AddType(builder, Type);
			return IPerformerAiSelector.EndIPerformerAiSelector(builder);
		}

		// Token: 0x06019A52 RID: 105042 RVA: 0x003ABC9C File Offset: 0x003A9E9C
		public static void StartIPerformerAiSelector(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06019A53 RID: 105043 RVA: 0x003ABCA6 File Offset: 0x003A9EA6
		public static void AddType(FlatBufferBuilder builder, EPerformerAiNodeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019A54 RID: 105044 RVA: 0x003ABCB1 File Offset: 0x003A9EB1
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06019A55 RID: 105045 RVA: 0x003ABCBC File Offset: 0x003A9EBC
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x06019A56 RID: 105046 RVA: 0x003ABCCC File Offset: 0x003A9ECC
		public static void AddDecoratorsType(FlatBufferBuilder builder, VectorOffset decoratorsTypeOffset)
		{
			builder.AddOffset(3, decoratorsTypeOffset.Value, 0);
		}

		// Token: 0x06019A57 RID: 105047 RVA: 0x003ABCDC File Offset: 0x003A9EDC
		public static VectorOffset CreateDecoratorsTypeVector(FlatBufferBuilder builder, TPerformerAiDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019A58 RID: 105048 RVA: 0x003ABD13 File Offset: 0x003A9F13
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, TPerformerAiDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TPerformerAiDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x06019A59 RID: 105049 RVA: 0x003ABD2D File Offset: 0x003A9F2D
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TPerformerAiDecorator> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TPerformerAiDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x06019A5A RID: 105050 RVA: 0x003ABD4B File Offset: 0x003A9F4B
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TPerformerAiDecorator>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019A5B RID: 105051 RVA: 0x003ABD64 File Offset: 0x003A9F64
		public static void StartDecoratorsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06019A5C RID: 105052 RVA: 0x003ABD6F File Offset: 0x003A9F6F
		public static void AddDecorators(FlatBufferBuilder builder, VectorOffset decoratorsOffset)
		{
			builder.AddOffset(4, decoratorsOffset.Value, 0);
		}

		// Token: 0x06019A5D RID: 105053 RVA: 0x003ABD80 File Offset: 0x003A9F80
		public static VectorOffset CreateDecoratorsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019A5E RID: 105054 RVA: 0x003ABDB7 File Offset: 0x003A9FB7
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019A5F RID: 105055 RVA: 0x003ABDD1 File Offset: 0x003A9FD1
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019A60 RID: 105056 RVA: 0x003ABDEF File Offset: 0x003A9FEF
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019A61 RID: 105057 RVA: 0x003ABE08 File Offset: 0x003AA008
		public static void StartDecoratorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019A62 RID: 105058 RVA: 0x003ABE13 File Offset: 0x003AA013
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(5, _FoldedForTree, false);
		}

		// Token: 0x06019A63 RID: 105059 RVA: 0x003ABE1E File Offset: 0x003AA01E
		public static void AddChildrenType(FlatBufferBuilder builder, VectorOffset childrenTypeOffset)
		{
			builder.AddOffset(6, childrenTypeOffset.Value, 0);
		}

		// Token: 0x06019A64 RID: 105060 RVA: 0x003ABE30 File Offset: 0x003AA030
		public static VectorOffset CreateChildrenTypeVector(FlatBufferBuilder builder, TPerformerAiNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019A65 RID: 105061 RVA: 0x003ABE67 File Offset: 0x003AA067
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, TPerformerAiNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TPerformerAiNode>(data);
			return builder.EndVector();
		}

		// Token: 0x06019A66 RID: 105062 RVA: 0x003ABE81 File Offset: 0x003AA081
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TPerformerAiNode> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TPerformerAiNode>(data);
			return builder.EndVector();
		}

		// Token: 0x06019A67 RID: 105063 RVA: 0x003ABE9F File Offset: 0x003AA09F
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TPerformerAiNode>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019A68 RID: 105064 RVA: 0x003ABEB8 File Offset: 0x003AA0B8
		public static void StartChildrenTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06019A69 RID: 105065 RVA: 0x003ABEC3 File Offset: 0x003AA0C3
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(7, childrenOffset.Value, 0);
		}

		// Token: 0x06019A6A RID: 105066 RVA: 0x003ABED4 File Offset: 0x003AA0D4
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019A6B RID: 105067 RVA: 0x003ABF0B File Offset: 0x003AA10B
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019A6C RID: 105068 RVA: 0x003ABF25 File Offset: 0x003AA125
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019A6D RID: 105069 RVA: 0x003ABF43 File Offset: 0x003AA143
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019A6E RID: 105070 RVA: 0x003ABF5C File Offset: 0x003AA15C
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019A6F RID: 105071 RVA: 0x003ABF67 File Offset: 0x003AA167
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06019A70 RID: 105072 RVA: 0x003ABF72 File Offset: 0x003AA172
		public static Offset<IPerformerAiSelector> EndIPerformerAiSelector(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiSelector>(builder.EndTable());
		}

		// Token: 0x06019A71 RID: 105073 RVA: 0x003ABF80 File Offset: 0x003AA180
		public IPerformerAiSelectorT UnPack()
		{
			IPerformerAiSelectorT performerAiSelectorT = new IPerformerAiSelectorT();
			this.UnPackTo(performerAiSelectorT);
			return performerAiSelectorT;
		}

		// Token: 0x06019A72 RID: 105074 RVA: 0x003ABF9C File Offset: 0x003AA19C
		public void UnPackTo(IPerformerAiSelectorT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Desc = this.Desc;
			_o.Decorators = new List<TPerformerAiDecoratorUnion>();
			for (int i = 0; i < this.DecoratorsLength; i++)
			{
				TPerformerAiDecoratorUnion tperformerAiDecoratorUnion = new TPerformerAiDecoratorUnion();
				tperformerAiDecoratorUnion.Type = this.DecoratorsType(i);
				switch (this.DecoratorsType(i))
				{
				case TPerformerAiDecorator.IPerformerAiAlwaysFalseDecorator:
					tperformerAiDecoratorUnion.Value = ((this.Decorators<IPerformerAiAlwaysFalseDecorator>(i) != null) ? this.Decorators<IPerformerAiAlwaysFalseDecorator>(i).Value.UnPack() : null);
					break;
				case TPerformerAiDecorator.IPerformerAiAlwaysTrueDecorator:
					tperformerAiDecoratorUnion.Value = ((this.Decorators<IPerformerAiAlwaysTrueDecorator>(i) != null) ? this.Decorators<IPerformerAiAlwaysTrueDecorator>(i).Value.UnPack() : null);
					break;
				case TPerformerAiDecorator.IPerformerAiConditionDecorator:
					tperformerAiDecoratorUnion.Value = ((this.Decorators<IPerformerAiConditionDecorator>(i) != null) ? this.Decorators<IPerformerAiConditionDecorator>(i).Value.UnPack() : null);
					break;
				case TPerformerAiDecorator.IPerformerAiCoolDownDecorator:
					tperformerAiDecoratorUnion.Value = ((this.Decorators<IPerformerAiCoolDownDecorator>(i) != null) ? this.Decorators<IPerformerAiCoolDownDecorator>(i).Value.UnPack() : null);
					break;
				case TPerformerAiDecorator.IPerformerAiDoOnceDecorator:
					tperformerAiDecoratorUnion.Value = ((this.Decorators<IPerformerAiDoOnceDecorator>(i) != null) ? this.Decorators<IPerformerAiDoOnceDecorator>(i).Value.UnPack() : null);
					break;
				}
				_o.Decorators.Add(tperformerAiDecoratorUnion);
			}
			_o._FoldedForTree = this._FoldedForTree;
			_o.Children = new List<TPerformerAiNodeUnion>();
			for (int j = 0; j < this.ChildrenLength; j++)
			{
				TPerformerAiNodeUnion tperformerAiNodeUnion = new TPerformerAiNodeUnion();
				tperformerAiNodeUnion.Type = this.ChildrenType(j);
				switch (this.ChildrenType(j))
				{
				case TPerformerAiNode.IPerformerAiProbability:
					tperformerAiNodeUnion.Value = ((this.Children<IPerformerAiProbability>(j) != null) ? this.Children<IPerformerAiProbability>(j).Value.UnPack() : null);
					break;
				case TPerformerAiNode.IPerformerAiSelector:
					tperformerAiNodeUnion.Value = ((this.Children<IPerformerAiSelector>(j) != null) ? this.Children<IPerformerAiSelector>(j).Value.UnPack() : null);
					break;
				case TPerformerAiNode.IPerformerAiSequence:
					tperformerAiNodeUnion.Value = ((this.Children<IPerformerAiSequence>(j) != null) ? this.Children<IPerformerAiSequence>(j).Value.UnPack() : null);
					break;
				case TPerformerAiNode.IPerformerAiStart:
					tperformerAiNodeUnion.Value = ((this.Children<IPerformerAiStart>(j) != null) ? this.Children<IPerformerAiStart>(j).Value.UnPack() : null);
					break;
				case TPerformerAiNode.IPerformerAiTask:
					tperformerAiNodeUnion.Value = ((this.Children<IPerformerAiTask>(j) != null) ? this.Children<IPerformerAiTask>(j).Value.UnPack() : null);
					break;
				}
				_o.Children.Add(tperformerAiNodeUnion);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06019A73 RID: 105075 RVA: 0x003AC2F8 File Offset: 0x003AA4F8
		public static Offset<IPerformerAiSelector> Pack(FlatBufferBuilder builder, IPerformerAiSelectorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformerAiSelector>);
			}
			StringOffset descOffset = (_o.Desc == null) ? default(StringOffset) : builder.CreateString(_o.Desc);
			VectorOffset decorators_typeOffset = default(VectorOffset);
			if (_o.Decorators != null)
			{
				TPerformerAiDecorator[] array = new TPerformerAiDecorator[_o.Decorators.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Decorators[i].Type;
				}
				decorators_typeOffset = IPerformerAiSelector.CreateDecoratorsTypeVector(builder, array);
			}
			VectorOffset decoratorsOffset = default(VectorOffset);
			if (_o.Decorators != null)
			{
				int[] array2 = new int[_o.Decorators.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TPerformerAiDecoratorUnion.Pack(builder, _o.Decorators[j]);
				}
				decoratorsOffset = IPerformerAiSelector.CreateDecoratorsVector(builder, array2);
			}
			VectorOffset children_typeOffset = default(VectorOffset);
			if (_o.Children != null)
			{
				TPerformerAiNode[] array3 = new TPerformerAiNode[_o.Children.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = _o.Children[k].Type;
				}
				children_typeOffset = IPerformerAiSelector.CreateChildrenTypeVector(builder, array3);
			}
			VectorOffset childrenOffset = default(VectorOffset);
			if (_o.Children != null)
			{
				int[] array4 = new int[_o.Children.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = TPerformerAiNodeUnion.Pack(builder, _o.Children[l]);
				}
				childrenOffset = IPerformerAiSelector.CreateChildrenVector(builder, array4);
			}
			return IPerformerAiSelector.CreateIPerformerAiSelector(builder, _o.Type, _o.Id, descOffset, decorators_typeOffset, decoratorsOffset, _o._FoldedForTree, children_typeOffset, childrenOffset, _o.NullMask);
		}

		// Token: 0x0400C17E RID: 49534
		private Table __p;
	}
}

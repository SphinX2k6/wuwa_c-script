using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047DD RID: 18397
	public struct IPerformerAiStart : IFlatbufferObject
	{
		// Token: 0x17008044 RID: 32836
		// (get) Token: 0x0601B25E RID: 111198 RVA: 0x003D8E24 File Offset: 0x003D7024
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B25F RID: 111199 RVA: 0x003D8E31 File Offset: 0x003D7031
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B260 RID: 111200 RVA: 0x003D8E38 File Offset: 0x003D7038
		public static IPerformerAiStart GetRootAsIPerformerAiStart(ByteBuffer _bb)
		{
			return IPerformerAiStart.GetRootAsIPerformerAiStart(_bb, default(IPerformerAiStart));
		}

		// Token: 0x0601B261 RID: 111201 RVA: 0x003D8E54 File Offset: 0x003D7054
		public static IPerformerAiStart GetRootAsIPerformerAiStart(ByteBuffer _bb, IPerformerAiStart obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B262 RID: 111202 RVA: 0x003D8E71 File Offset: 0x003D7071
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B263 RID: 111203 RVA: 0x003D8E80 File Offset: 0x003D7080
		public IPerformerAiStart __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008045 RID: 32837
		// (get) Token: 0x0601B264 RID: 111204 RVA: 0x003D8E90 File Offset: 0x003D7090
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

		// Token: 0x17008046 RID: 32838
		// (get) Token: 0x0601B265 RID: 111205 RVA: 0x003D8ECC File Offset: 0x003D70CC
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

		// Token: 0x17008047 RID: 32839
		// (get) Token: 0x0601B266 RID: 111206 RVA: 0x003D8F08 File Offset: 0x003D7108
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

		// Token: 0x0601B267 RID: 111207 RVA: 0x003D8F3F File Offset: 0x003D713F
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601B268 RID: 111208 RVA: 0x003D8F4E File Offset: 0x003D714E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0601B269 RID: 111209 RVA: 0x003D8F5C File Offset: 0x003D715C
		public TPerformerAiDecorator DecoratorsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TPerformerAiDecorator.NONE;
			}
			return (TPerformerAiDecorator)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008048 RID: 32840
		// (get) Token: 0x0601B26A RID: 111210 RVA: 0x003D8F9C File Offset: 0x003D719C
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

		// Token: 0x0601B26B RID: 111211 RVA: 0x003D8FC8 File Offset: 0x003D71C8
		public Span<TPerformerAiDecorator> GetDecoratorsTypeBytes()
		{
			return this.__p.__vector_as_span<TPerformerAiDecorator>(10, 1);
		}

		// Token: 0x0601B26C RID: 111212 RVA: 0x003D8FD8 File Offset: 0x003D71D8
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

		// Token: 0x0601B26D RID: 111213 RVA: 0x003D9044 File Offset: 0x003D7244
		public TTable? Decorators<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17008049 RID: 32841
		// (get) Token: 0x0601B26E RID: 111214 RVA: 0x003D908C File Offset: 0x003D728C
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

		// Token: 0x1700804A RID: 32842
		// (get) Token: 0x0601B26F RID: 111215 RVA: 0x003D90B8 File Offset: 0x003D72B8
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700804B RID: 32843
		// (get) Token: 0x0601B270 RID: 111216 RVA: 0x003D90F8 File Offset: 0x003D72F8
		public TPerformerAiNode ChildType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return TPerformerAiNode.NONE;
				}
				return (TPerformerAiNode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B271 RID: 111217 RVA: 0x003D9138 File Offset: 0x003D7338
		public TTable? Child<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601B272 RID: 111218 RVA: 0x003D9180 File Offset: 0x003D7380
		public IPerformerAiProbability ChildAsIPerformerAiProbability()
		{
			return this.Child<IPerformerAiProbability>().Value;
		}

		// Token: 0x0601B273 RID: 111219 RVA: 0x003D919C File Offset: 0x003D739C
		public IPerformerAiSelector ChildAsIPerformerAiSelector()
		{
			return this.Child<IPerformerAiSelector>().Value;
		}

		// Token: 0x0601B274 RID: 111220 RVA: 0x003D91B8 File Offset: 0x003D73B8
		public IPerformerAiSequence ChildAsIPerformerAiSequence()
		{
			return this.Child<IPerformerAiSequence>().Value;
		}

		// Token: 0x0601B275 RID: 111221 RVA: 0x003D91D4 File Offset: 0x003D73D4
		public IPerformerAiStart ChildAsIPerformerAiStart()
		{
			return this.Child<IPerformerAiStart>().Value;
		}

		// Token: 0x0601B276 RID: 111222 RVA: 0x003D91F0 File Offset: 0x003D73F0
		public IPerformerAiTask ChildAsIPerformerAiTask()
		{
			return this.Child<IPerformerAiTask>().Value;
		}

		// Token: 0x1700804C RID: 32844
		// (get) Token: 0x0601B277 RID: 111223 RVA: 0x003D920C File Offset: 0x003D740C
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

		// Token: 0x0601B278 RID: 111224 RVA: 0x003D924C File Offset: 0x003D744C
		public static Offset<IPerformerAiStart> CreateIPerformerAiStart(FlatBufferBuilder builder, EPerformerAiNodeType Type = EPerformerAiNodeType.Start, int Id = 0, StringOffset DescOffset = default(StringOffset), VectorOffset Decorators_typeOffset = default(VectorOffset), VectorOffset DecoratorsOffset = default(VectorOffset), bool _foldedForTree = false, TPerformerAiNode Child_type = TPerformerAiNode.NONE, int ChildOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(9);
			IPerformerAiStart.AddChild(builder, ChildOffset);
			IPerformerAiStart.AddDecorators(builder, DecoratorsOffset);
			IPerformerAiStart.AddDecoratorsType(builder, Decorators_typeOffset);
			IPerformerAiStart.AddDesc(builder, DescOffset);
			IPerformerAiStart.AddId(builder, Id);
			IPerformerAiStart.AddNullMask(builder, NullMask);
			IPerformerAiStart.AddChildType(builder, Child_type);
			IPerformerAiStart.Add_FoldedForTree(builder, _foldedForTree);
			IPerformerAiStart.AddType(builder, Type);
			return IPerformerAiStart.EndIPerformerAiStart(builder);
		}

		// Token: 0x0601B279 RID: 111225 RVA: 0x003D92AC File Offset: 0x003D74AC
		public static void StartIPerformerAiStart(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0601B27A RID: 111226 RVA: 0x003D92B6 File Offset: 0x003D74B6
		public static void AddType(FlatBufferBuilder builder, EPerformerAiNodeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B27B RID: 111227 RVA: 0x003D92C1 File Offset: 0x003D74C1
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0601B27C RID: 111228 RVA: 0x003D92CC File Offset: 0x003D74CC
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x0601B27D RID: 111229 RVA: 0x003D92DC File Offset: 0x003D74DC
		public static void AddDecoratorsType(FlatBufferBuilder builder, VectorOffset decoratorsTypeOffset)
		{
			builder.AddOffset(3, decoratorsTypeOffset.Value, 0);
		}

		// Token: 0x0601B27E RID: 111230 RVA: 0x003D92EC File Offset: 0x003D74EC
		public static VectorOffset CreateDecoratorsTypeVector(FlatBufferBuilder builder, TPerformerAiDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B27F RID: 111231 RVA: 0x003D9323 File Offset: 0x003D7523
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, TPerformerAiDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TPerformerAiDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B280 RID: 111232 RVA: 0x003D933D File Offset: 0x003D753D
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TPerformerAiDecorator> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TPerformerAiDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B281 RID: 111233 RVA: 0x003D935B File Offset: 0x003D755B
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TPerformerAiDecorator>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B282 RID: 111234 RVA: 0x003D9374 File Offset: 0x003D7574
		public static void StartDecoratorsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601B283 RID: 111235 RVA: 0x003D937F File Offset: 0x003D757F
		public static void AddDecorators(FlatBufferBuilder builder, VectorOffset decoratorsOffset)
		{
			builder.AddOffset(4, decoratorsOffset.Value, 0);
		}

		// Token: 0x0601B284 RID: 111236 RVA: 0x003D9390 File Offset: 0x003D7590
		public static VectorOffset CreateDecoratorsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B285 RID: 111237 RVA: 0x003D93C7 File Offset: 0x003D75C7
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B286 RID: 111238 RVA: 0x003D93E1 File Offset: 0x003D75E1
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B287 RID: 111239 RVA: 0x003D93FF File Offset: 0x003D75FF
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B288 RID: 111240 RVA: 0x003D9418 File Offset: 0x003D7618
		public static void StartDecoratorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B289 RID: 111241 RVA: 0x003D9423 File Offset: 0x003D7623
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(5, _FoldedForTree, false);
		}

		// Token: 0x0601B28A RID: 111242 RVA: 0x003D942E File Offset: 0x003D762E
		public static void AddChildType(FlatBufferBuilder builder, TPerformerAiNode childType)
		{
			builder.AddByte(6, (byte)childType, 0);
		}

		// Token: 0x0601B28B RID: 111243 RVA: 0x003D9439 File Offset: 0x003D7639
		public static void AddChild(FlatBufferBuilder builder, int childOffset)
		{
			builder.AddOffset(7, childOffset, 0);
		}

		// Token: 0x0601B28C RID: 111244 RVA: 0x003D9444 File Offset: 0x003D7644
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0601B28D RID: 111245 RVA: 0x003D944F File Offset: 0x003D764F
		public static Offset<IPerformerAiStart> EndIPerformerAiStart(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiStart>(builder.EndTable());
		}

		// Token: 0x0601B28E RID: 111246 RVA: 0x003D945C File Offset: 0x003D765C
		public IPerformerAiStartT UnPack()
		{
			IPerformerAiStartT performerAiStartT = new IPerformerAiStartT();
			this.UnPackTo(performerAiStartT);
			return performerAiStartT;
		}

		// Token: 0x0601B28F RID: 111247 RVA: 0x003D9478 File Offset: 0x003D7678
		public void UnPackTo(IPerformerAiStartT _o)
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
			_o.Child = new TPerformerAiNodeUnion();
			_o.Child.Type = this.ChildType;
			switch (this.ChildType)
			{
			case TPerformerAiNode.IPerformerAiProbability:
				_o.Child.Value = ((this.Child<IPerformerAiProbability>() != null) ? this.Child<IPerformerAiProbability>().Value.UnPack() : null);
				break;
			case TPerformerAiNode.IPerformerAiSelector:
				_o.Child.Value = ((this.Child<IPerformerAiSelector>() != null) ? this.Child<IPerformerAiSelector>().Value.UnPack() : null);
				break;
			case TPerformerAiNode.IPerformerAiSequence:
				_o.Child.Value = ((this.Child<IPerformerAiSequence>() != null) ? this.Child<IPerformerAiSequence>().Value.UnPack() : null);
				break;
			case TPerformerAiNode.IPerformerAiStart:
				_o.Child.Value = ((this.Child<IPerformerAiStart>() != null) ? this.Child<IPerformerAiStart>().Value.UnPack() : null);
				break;
			case TPerformerAiNode.IPerformerAiTask:
				_o.Child.Value = ((this.Child<IPerformerAiTask>() != null) ? this.Child<IPerformerAiTask>().Value.UnPack() : null);
				break;
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601B290 RID: 111248 RVA: 0x003D97A4 File Offset: 0x003D79A4
		public static Offset<IPerformerAiStart> Pack(FlatBufferBuilder builder, IPerformerAiStartT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformerAiStart>);
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
				decorators_typeOffset = IPerformerAiStart.CreateDecoratorsTypeVector(builder, array);
			}
			VectorOffset decoratorsOffset = default(VectorOffset);
			if (_o.Decorators != null)
			{
				int[] array2 = new int[_o.Decorators.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TPerformerAiDecoratorUnion.Pack(builder, _o.Decorators[j]);
				}
				decoratorsOffset = IPerformerAiStart.CreateDecoratorsVector(builder, array2);
			}
			TPerformerAiNode child_type = (_o.Child == null) ? TPerformerAiNode.NONE : _o.Child.Type;
			int childOffset = (_o.Child == null) ? 0 : TPerformerAiNodeUnion.Pack(builder, _o.Child);
			return IPerformerAiStart.CreateIPerformerAiStart(builder, _o.Type, _o.Id, descOffset, decorators_typeOffset, decoratorsOffset, _o._FoldedForTree, child_type, childOffset, _o.NullMask);
		}

		// Token: 0x0400CBAC RID: 52140
		private Table __p;
	}
}

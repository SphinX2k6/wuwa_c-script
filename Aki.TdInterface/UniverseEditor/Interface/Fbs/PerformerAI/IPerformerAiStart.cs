using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x0200437B RID: 17275
	public struct IPerformerAiStart : IFlatbufferObject
	{
		// Token: 0x17007A0F RID: 31247
		// (get) Token: 0x06019AD0 RID: 105168 RVA: 0x003AD3FC File Offset: 0x003AB5FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019AD1 RID: 105169 RVA: 0x003AD409 File Offset: 0x003AB609
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019AD2 RID: 105170 RVA: 0x003AD410 File Offset: 0x003AB610
		public static IPerformerAiStart GetRootAsIPerformerAiStart(ByteBuffer _bb)
		{
			return IPerformerAiStart.GetRootAsIPerformerAiStart(_bb, default(IPerformerAiStart));
		}

		// Token: 0x06019AD3 RID: 105171 RVA: 0x003AD42C File Offset: 0x003AB62C
		public static IPerformerAiStart GetRootAsIPerformerAiStart(ByteBuffer _bb, IPerformerAiStart obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019AD4 RID: 105172 RVA: 0x003AD449 File Offset: 0x003AB649
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019AD5 RID: 105173 RVA: 0x003AD458 File Offset: 0x003AB658
		public IPerformerAiStart __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007A10 RID: 31248
		// (get) Token: 0x06019AD6 RID: 105174 RVA: 0x003AD468 File Offset: 0x003AB668
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

		// Token: 0x17007A11 RID: 31249
		// (get) Token: 0x06019AD7 RID: 105175 RVA: 0x003AD4A4 File Offset: 0x003AB6A4
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

		// Token: 0x17007A12 RID: 31250
		// (get) Token: 0x06019AD8 RID: 105176 RVA: 0x003AD4E0 File Offset: 0x003AB6E0
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

		// Token: 0x06019AD9 RID: 105177 RVA: 0x003AD517 File Offset: 0x003AB717
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06019ADA RID: 105178 RVA: 0x003AD526 File Offset: 0x003AB726
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06019ADB RID: 105179 RVA: 0x003AD534 File Offset: 0x003AB734
		public TPerformerAiDecorator DecoratorsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TPerformerAiDecorator.NONE;
			}
			return (TPerformerAiDecorator)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007A13 RID: 31251
		// (get) Token: 0x06019ADC RID: 105180 RVA: 0x003AD574 File Offset: 0x003AB774
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

		// Token: 0x06019ADD RID: 105181 RVA: 0x003AD5A0 File Offset: 0x003AB7A0
		public Span<TPerformerAiDecorator> GetDecoratorsTypeBytes()
		{
			return this.__p.__vector_as_span<TPerformerAiDecorator>(10, 1);
		}

		// Token: 0x06019ADE RID: 105182 RVA: 0x003AD5B0 File Offset: 0x003AB7B0
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

		// Token: 0x06019ADF RID: 105183 RVA: 0x003AD61C File Offset: 0x003AB81C
		public TTable? Decorators<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007A14 RID: 31252
		// (get) Token: 0x06019AE0 RID: 105184 RVA: 0x003AD664 File Offset: 0x003AB864
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

		// Token: 0x17007A15 RID: 31253
		// (get) Token: 0x06019AE1 RID: 105185 RVA: 0x003AD690 File Offset: 0x003AB890
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007A16 RID: 31254
		// (get) Token: 0x06019AE2 RID: 105186 RVA: 0x003AD6D0 File Offset: 0x003AB8D0
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

		// Token: 0x06019AE3 RID: 105187 RVA: 0x003AD710 File Offset: 0x003AB910
		public TTable? Child<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06019AE4 RID: 105188 RVA: 0x003AD758 File Offset: 0x003AB958
		public IPerformerAiProbability ChildAsIPerformerAiProbability()
		{
			return this.Child<IPerformerAiProbability>().Value;
		}

		// Token: 0x06019AE5 RID: 105189 RVA: 0x003AD774 File Offset: 0x003AB974
		public IPerformerAiSelector ChildAsIPerformerAiSelector()
		{
			return this.Child<IPerformerAiSelector>().Value;
		}

		// Token: 0x06019AE6 RID: 105190 RVA: 0x003AD790 File Offset: 0x003AB990
		public IPerformerAiSequence ChildAsIPerformerAiSequence()
		{
			return this.Child<IPerformerAiSequence>().Value;
		}

		// Token: 0x06019AE7 RID: 105191 RVA: 0x003AD7AC File Offset: 0x003AB9AC
		public IPerformerAiStart ChildAsIPerformerAiStart()
		{
			return this.Child<IPerformerAiStart>().Value;
		}

		// Token: 0x06019AE8 RID: 105192 RVA: 0x003AD7C8 File Offset: 0x003AB9C8
		public IPerformerAiTask ChildAsIPerformerAiTask()
		{
			return this.Child<IPerformerAiTask>().Value;
		}

		// Token: 0x17007A17 RID: 31255
		// (get) Token: 0x06019AE9 RID: 105193 RVA: 0x003AD7E4 File Offset: 0x003AB9E4
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

		// Token: 0x06019AEA RID: 105194 RVA: 0x003AD824 File Offset: 0x003ABA24
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

		// Token: 0x06019AEB RID: 105195 RVA: 0x003AD884 File Offset: 0x003ABA84
		public static void StartIPerformerAiStart(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06019AEC RID: 105196 RVA: 0x003AD88E File Offset: 0x003ABA8E
		public static void AddType(FlatBufferBuilder builder, EPerformerAiNodeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019AED RID: 105197 RVA: 0x003AD899 File Offset: 0x003ABA99
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06019AEE RID: 105198 RVA: 0x003AD8A4 File Offset: 0x003ABAA4
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x06019AEF RID: 105199 RVA: 0x003AD8B4 File Offset: 0x003ABAB4
		public static void AddDecoratorsType(FlatBufferBuilder builder, VectorOffset decoratorsTypeOffset)
		{
			builder.AddOffset(3, decoratorsTypeOffset.Value, 0);
		}

		// Token: 0x06019AF0 RID: 105200 RVA: 0x003AD8C4 File Offset: 0x003ABAC4
		public static VectorOffset CreateDecoratorsTypeVector(FlatBufferBuilder builder, TPerformerAiDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019AF1 RID: 105201 RVA: 0x003AD8FB File Offset: 0x003ABAFB
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, TPerformerAiDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TPerformerAiDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x06019AF2 RID: 105202 RVA: 0x003AD915 File Offset: 0x003ABB15
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TPerformerAiDecorator> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TPerformerAiDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x06019AF3 RID: 105203 RVA: 0x003AD933 File Offset: 0x003ABB33
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TPerformerAiDecorator>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019AF4 RID: 105204 RVA: 0x003AD94C File Offset: 0x003ABB4C
		public static void StartDecoratorsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06019AF5 RID: 105205 RVA: 0x003AD957 File Offset: 0x003ABB57
		public static void AddDecorators(FlatBufferBuilder builder, VectorOffset decoratorsOffset)
		{
			builder.AddOffset(4, decoratorsOffset.Value, 0);
		}

		// Token: 0x06019AF6 RID: 105206 RVA: 0x003AD968 File Offset: 0x003ABB68
		public static VectorOffset CreateDecoratorsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019AF7 RID: 105207 RVA: 0x003AD99F File Offset: 0x003ABB9F
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019AF8 RID: 105208 RVA: 0x003AD9B9 File Offset: 0x003ABBB9
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019AF9 RID: 105209 RVA: 0x003AD9D7 File Offset: 0x003ABBD7
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019AFA RID: 105210 RVA: 0x003AD9F0 File Offset: 0x003ABBF0
		public static void StartDecoratorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019AFB RID: 105211 RVA: 0x003AD9FB File Offset: 0x003ABBFB
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(5, _FoldedForTree, false);
		}

		// Token: 0x06019AFC RID: 105212 RVA: 0x003ADA06 File Offset: 0x003ABC06
		public static void AddChildType(FlatBufferBuilder builder, TPerformerAiNode childType)
		{
			builder.AddByte(6, (byte)childType, 0);
		}

		// Token: 0x06019AFD RID: 105213 RVA: 0x003ADA11 File Offset: 0x003ABC11
		public static void AddChild(FlatBufferBuilder builder, int childOffset)
		{
			builder.AddOffset(7, childOffset, 0);
		}

		// Token: 0x06019AFE RID: 105214 RVA: 0x003ADA1C File Offset: 0x003ABC1C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06019AFF RID: 105215 RVA: 0x003ADA27 File Offset: 0x003ABC27
		public static Offset<IPerformerAiStart> EndIPerformerAiStart(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiStart>(builder.EndTable());
		}

		// Token: 0x06019B00 RID: 105216 RVA: 0x003ADA34 File Offset: 0x003ABC34
		public IPerformerAiStartT UnPack()
		{
			IPerformerAiStartT performerAiStartT = new IPerformerAiStartT();
			this.UnPackTo(performerAiStartT);
			return performerAiStartT;
		}

		// Token: 0x06019B01 RID: 105217 RVA: 0x003ADA50 File Offset: 0x003ABC50
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

		// Token: 0x06019B02 RID: 105218 RVA: 0x003ADD7C File Offset: 0x003ABF7C
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

		// Token: 0x0400C18E RID: 49550
		private Table __p;
	}
}

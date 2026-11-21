using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047E0 RID: 18400
	public struct IPerformerAiTask : IFlatbufferObject
	{
		// Token: 0x17008054 RID: 32852
		// (get) Token: 0x0601B2A1 RID: 111265 RVA: 0x003D9A45 File Offset: 0x003D7C45
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B2A2 RID: 111266 RVA: 0x003D9A52 File Offset: 0x003D7C52
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B2A3 RID: 111267 RVA: 0x003D9A5C File Offset: 0x003D7C5C
		public static IPerformerAiTask GetRootAsIPerformerAiTask(ByteBuffer _bb)
		{
			return IPerformerAiTask.GetRootAsIPerformerAiTask(_bb, default(IPerformerAiTask));
		}

		// Token: 0x0601B2A4 RID: 111268 RVA: 0x003D9A78 File Offset: 0x003D7C78
		public static IPerformerAiTask GetRootAsIPerformerAiTask(ByteBuffer _bb, IPerformerAiTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B2A5 RID: 111269 RVA: 0x003D9A95 File Offset: 0x003D7C95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B2A6 RID: 111270 RVA: 0x003D9AA4 File Offset: 0x003D7CA4
		public IPerformerAiTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008055 RID: 32853
		// (get) Token: 0x0601B2A7 RID: 111271 RVA: 0x003D9AB4 File Offset: 0x003D7CB4
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

		// Token: 0x17008056 RID: 32854
		// (get) Token: 0x0601B2A8 RID: 111272 RVA: 0x003D9AF0 File Offset: 0x003D7CF0
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

		// Token: 0x17008057 RID: 32855
		// (get) Token: 0x0601B2A9 RID: 111273 RVA: 0x003D9B2C File Offset: 0x003D7D2C
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

		// Token: 0x0601B2AA RID: 111274 RVA: 0x003D9B63 File Offset: 0x003D7D63
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601B2AB RID: 111275 RVA: 0x003D9B72 File Offset: 0x003D7D72
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0601B2AC RID: 111276 RVA: 0x003D9B80 File Offset: 0x003D7D80
		public TPerformerAiDecorator DecoratorsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TPerformerAiDecorator.NONE;
			}
			return (TPerformerAiDecorator)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008058 RID: 32856
		// (get) Token: 0x0601B2AD RID: 111277 RVA: 0x003D9BC0 File Offset: 0x003D7DC0
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

		// Token: 0x0601B2AE RID: 111278 RVA: 0x003D9BEC File Offset: 0x003D7DEC
		public Span<TPerformerAiDecorator> GetDecoratorsTypeBytes()
		{
			return this.__p.__vector_as_span<TPerformerAiDecorator>(10, 1);
		}

		// Token: 0x0601B2AF RID: 111279 RVA: 0x003D9BFC File Offset: 0x003D7DFC
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

		// Token: 0x0601B2B0 RID: 111280 RVA: 0x003D9C68 File Offset: 0x003D7E68
		public TTable? Decorators<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17008059 RID: 32857
		// (get) Token: 0x0601B2B1 RID: 111281 RVA: 0x003D9CB0 File Offset: 0x003D7EB0
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

		// Token: 0x1700805A RID: 32858
		// (get) Token: 0x0601B2B2 RID: 111282 RVA: 0x003D9CDC File Offset: 0x003D7EDC
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700805B RID: 32859
		// (get) Token: 0x0601B2B3 RID: 111283 RVA: 0x003D9D1C File Offset: 0x003D7F1C
		public IActionInfo? Action
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700805C RID: 32860
		// (get) Token: 0x0601B2B4 RID: 111284 RVA: 0x003D9D7C File Offset: 0x003D7F7C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B2B5 RID: 111285 RVA: 0x003D9DBC File Offset: 0x003D7FBC
		public static Offset<IPerformerAiTask> CreateIPerformerAiTask(FlatBufferBuilder builder, EPerformerAiNodeType Type = EPerformerAiNodeType.Start, int Id = 0, StringOffset DescOffset = default(StringOffset), VectorOffset Decorators_typeOffset = default(VectorOffset), VectorOffset DecoratorsOffset = default(VectorOffset), bool _foldedForTree = false, Offset<IActionInfo> ActionOffset = default(Offset<IActionInfo>), byte NullMask = 0)
		{
			builder.StartTable(8);
			IPerformerAiTask.AddAction(builder, ActionOffset);
			IPerformerAiTask.AddDecorators(builder, DecoratorsOffset);
			IPerformerAiTask.AddDecoratorsType(builder, Decorators_typeOffset);
			IPerformerAiTask.AddDesc(builder, DescOffset);
			IPerformerAiTask.AddId(builder, Id);
			IPerformerAiTask.AddNullMask(builder, NullMask);
			IPerformerAiTask.Add_FoldedForTree(builder, _foldedForTree);
			IPerformerAiTask.AddType(builder, Type);
			return IPerformerAiTask.EndIPerformerAiTask(builder);
		}

		// Token: 0x0601B2B6 RID: 111286 RVA: 0x003D9E13 File Offset: 0x003D8013
		public static void StartIPerformerAiTask(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0601B2B7 RID: 111287 RVA: 0x003D9E1C File Offset: 0x003D801C
		public static void AddType(FlatBufferBuilder builder, EPerformerAiNodeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B2B8 RID: 111288 RVA: 0x003D9E27 File Offset: 0x003D8027
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0601B2B9 RID: 111289 RVA: 0x003D9E32 File Offset: 0x003D8032
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x0601B2BA RID: 111290 RVA: 0x003D9E42 File Offset: 0x003D8042
		public static void AddDecoratorsType(FlatBufferBuilder builder, VectorOffset decoratorsTypeOffset)
		{
			builder.AddOffset(3, decoratorsTypeOffset.Value, 0);
		}

		// Token: 0x0601B2BB RID: 111291 RVA: 0x003D9E54 File Offset: 0x003D8054
		public static VectorOffset CreateDecoratorsTypeVector(FlatBufferBuilder builder, TPerformerAiDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B2BC RID: 111292 RVA: 0x003D9E8B File Offset: 0x003D808B
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, TPerformerAiDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TPerformerAiDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B2BD RID: 111293 RVA: 0x003D9EA5 File Offset: 0x003D80A5
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TPerformerAiDecorator> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TPerformerAiDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B2BE RID: 111294 RVA: 0x003D9EC3 File Offset: 0x003D80C3
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TPerformerAiDecorator>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B2BF RID: 111295 RVA: 0x003D9EDC File Offset: 0x003D80DC
		public static void StartDecoratorsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601B2C0 RID: 111296 RVA: 0x003D9EE7 File Offset: 0x003D80E7
		public static void AddDecorators(FlatBufferBuilder builder, VectorOffset decoratorsOffset)
		{
			builder.AddOffset(4, decoratorsOffset.Value, 0);
		}

		// Token: 0x0601B2C1 RID: 111297 RVA: 0x003D9EF8 File Offset: 0x003D80F8
		public static VectorOffset CreateDecoratorsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B2C2 RID: 111298 RVA: 0x003D9F2F File Offset: 0x003D812F
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B2C3 RID: 111299 RVA: 0x003D9F49 File Offset: 0x003D8149
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B2C4 RID: 111300 RVA: 0x003D9F67 File Offset: 0x003D8167
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B2C5 RID: 111301 RVA: 0x003D9F80 File Offset: 0x003D8180
		public static void StartDecoratorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B2C6 RID: 111302 RVA: 0x003D9F8B File Offset: 0x003D818B
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(5, _FoldedForTree, false);
		}

		// Token: 0x0601B2C7 RID: 111303 RVA: 0x003D9F96 File Offset: 0x003D8196
		public static void AddAction(FlatBufferBuilder builder, Offset<IActionInfo> actionOffset)
		{
			builder.AddOffset(6, actionOffset.Value, 0);
		}

		// Token: 0x0601B2C8 RID: 111304 RVA: 0x003D9FA6 File Offset: 0x003D81A6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0601B2C9 RID: 111305 RVA: 0x003D9FB1 File Offset: 0x003D81B1
		public static Offset<IPerformerAiTask> EndIPerformerAiTask(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiTask>(builder.EndTable());
		}

		// Token: 0x0601B2CA RID: 111306 RVA: 0x003D9FC0 File Offset: 0x003D81C0
		public IPerformerAiTaskT UnPack()
		{
			IPerformerAiTaskT performerAiTaskT = new IPerformerAiTaskT();
			this.UnPackTo(performerAiTaskT);
			return performerAiTaskT;
		}

		// Token: 0x0601B2CB RID: 111307 RVA: 0x003D9FDC File Offset: 0x003D81DC
		public void UnPackTo(IPerformerAiTaskT _o)
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
			_o.Action = ((this.Action != null) ? this.Action.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601B2CC RID: 111308 RVA: 0x003DA1D4 File Offset: 0x003D83D4
		public static Offset<IPerformerAiTask> Pack(FlatBufferBuilder builder, IPerformerAiTaskT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformerAiTask>);
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
				decorators_typeOffset = IPerformerAiTask.CreateDecoratorsTypeVector(builder, array);
			}
			VectorOffset decoratorsOffset = default(VectorOffset);
			if (_o.Decorators != null)
			{
				int[] array2 = new int[_o.Decorators.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TPerformerAiDecoratorUnion.Pack(builder, _o.Decorators[j]);
				}
				decoratorsOffset = IPerformerAiTask.CreateDecoratorsVector(builder, array2);
			}
			Offset<IActionInfo> actionOffset = (_o.Action == null) ? default(Offset<IActionInfo>) : IActionInfo.Pack(builder, _o.Action);
			return IPerformerAiTask.CreateIPerformerAiTask(builder, _o.Type, _o.Id, descOffset, decorators_typeOffset, decoratorsOffset, _o._FoldedForTree, actionOffset, _o.NullMask);
		}

		// Token: 0x0400CBB4 RID: 52148
		private Table __p;
	}
}

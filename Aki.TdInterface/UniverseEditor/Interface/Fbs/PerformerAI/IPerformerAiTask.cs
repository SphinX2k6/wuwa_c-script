using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x0200437E RID: 17278
	public struct IPerformerAiTask : IFlatbufferObject
	{
		// Token: 0x17007A1F RID: 31263
		// (get) Token: 0x06019B13 RID: 105235 RVA: 0x003AE01D File Offset: 0x003AC21D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019B14 RID: 105236 RVA: 0x003AE02A File Offset: 0x003AC22A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019B15 RID: 105237 RVA: 0x003AE034 File Offset: 0x003AC234
		public static IPerformerAiTask GetRootAsIPerformerAiTask(ByteBuffer _bb)
		{
			return IPerformerAiTask.GetRootAsIPerformerAiTask(_bb, default(IPerformerAiTask));
		}

		// Token: 0x06019B16 RID: 105238 RVA: 0x003AE050 File Offset: 0x003AC250
		public static IPerformerAiTask GetRootAsIPerformerAiTask(ByteBuffer _bb, IPerformerAiTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019B17 RID: 105239 RVA: 0x003AE06D File Offset: 0x003AC26D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019B18 RID: 105240 RVA: 0x003AE07C File Offset: 0x003AC27C
		public IPerformerAiTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007A20 RID: 31264
		// (get) Token: 0x06019B19 RID: 105241 RVA: 0x003AE08C File Offset: 0x003AC28C
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

		// Token: 0x17007A21 RID: 31265
		// (get) Token: 0x06019B1A RID: 105242 RVA: 0x003AE0C8 File Offset: 0x003AC2C8
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

		// Token: 0x17007A22 RID: 31266
		// (get) Token: 0x06019B1B RID: 105243 RVA: 0x003AE104 File Offset: 0x003AC304
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

		// Token: 0x06019B1C RID: 105244 RVA: 0x003AE13B File Offset: 0x003AC33B
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06019B1D RID: 105245 RVA: 0x003AE14A File Offset: 0x003AC34A
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06019B1E RID: 105246 RVA: 0x003AE158 File Offset: 0x003AC358
		public TPerformerAiDecorator DecoratorsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TPerformerAiDecorator.NONE;
			}
			return (TPerformerAiDecorator)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007A23 RID: 31267
		// (get) Token: 0x06019B1F RID: 105247 RVA: 0x003AE198 File Offset: 0x003AC398
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

		// Token: 0x06019B20 RID: 105248 RVA: 0x003AE1C4 File Offset: 0x003AC3C4
		public Span<TPerformerAiDecorator> GetDecoratorsTypeBytes()
		{
			return this.__p.__vector_as_span<TPerformerAiDecorator>(10, 1);
		}

		// Token: 0x06019B21 RID: 105249 RVA: 0x003AE1D4 File Offset: 0x003AC3D4
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

		// Token: 0x06019B22 RID: 105250 RVA: 0x003AE240 File Offset: 0x003AC440
		public TTable? Decorators<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007A24 RID: 31268
		// (get) Token: 0x06019B23 RID: 105251 RVA: 0x003AE288 File Offset: 0x003AC488
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

		// Token: 0x17007A25 RID: 31269
		// (get) Token: 0x06019B24 RID: 105252 RVA: 0x003AE2B4 File Offset: 0x003AC4B4
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007A26 RID: 31270
		// (get) Token: 0x06019B25 RID: 105253 RVA: 0x003AE2F4 File Offset: 0x003AC4F4
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

		// Token: 0x17007A27 RID: 31271
		// (get) Token: 0x06019B26 RID: 105254 RVA: 0x003AE354 File Offset: 0x003AC554
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

		// Token: 0x06019B27 RID: 105255 RVA: 0x003AE394 File Offset: 0x003AC594
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

		// Token: 0x06019B28 RID: 105256 RVA: 0x003AE3EB File Offset: 0x003AC5EB
		public static void StartIPerformerAiTask(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06019B29 RID: 105257 RVA: 0x003AE3F4 File Offset: 0x003AC5F4
		public static void AddType(FlatBufferBuilder builder, EPerformerAiNodeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019B2A RID: 105258 RVA: 0x003AE3FF File Offset: 0x003AC5FF
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06019B2B RID: 105259 RVA: 0x003AE40A File Offset: 0x003AC60A
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x06019B2C RID: 105260 RVA: 0x003AE41A File Offset: 0x003AC61A
		public static void AddDecoratorsType(FlatBufferBuilder builder, VectorOffset decoratorsTypeOffset)
		{
			builder.AddOffset(3, decoratorsTypeOffset.Value, 0);
		}

		// Token: 0x06019B2D RID: 105261 RVA: 0x003AE42C File Offset: 0x003AC62C
		public static VectorOffset CreateDecoratorsTypeVector(FlatBufferBuilder builder, TPerformerAiDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019B2E RID: 105262 RVA: 0x003AE463 File Offset: 0x003AC663
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, TPerformerAiDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TPerformerAiDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x06019B2F RID: 105263 RVA: 0x003AE47D File Offset: 0x003AC67D
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TPerformerAiDecorator> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TPerformerAiDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x06019B30 RID: 105264 RVA: 0x003AE49B File Offset: 0x003AC69B
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TPerformerAiDecorator>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019B31 RID: 105265 RVA: 0x003AE4B4 File Offset: 0x003AC6B4
		public static void StartDecoratorsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06019B32 RID: 105266 RVA: 0x003AE4BF File Offset: 0x003AC6BF
		public static void AddDecorators(FlatBufferBuilder builder, VectorOffset decoratorsOffset)
		{
			builder.AddOffset(4, decoratorsOffset.Value, 0);
		}

		// Token: 0x06019B33 RID: 105267 RVA: 0x003AE4D0 File Offset: 0x003AC6D0
		public static VectorOffset CreateDecoratorsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019B34 RID: 105268 RVA: 0x003AE507 File Offset: 0x003AC707
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019B35 RID: 105269 RVA: 0x003AE521 File Offset: 0x003AC721
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019B36 RID: 105270 RVA: 0x003AE53F File Offset: 0x003AC73F
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019B37 RID: 105271 RVA: 0x003AE558 File Offset: 0x003AC758
		public static void StartDecoratorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019B38 RID: 105272 RVA: 0x003AE563 File Offset: 0x003AC763
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(5, _FoldedForTree, false);
		}

		// Token: 0x06019B39 RID: 105273 RVA: 0x003AE56E File Offset: 0x003AC76E
		public static void AddAction(FlatBufferBuilder builder, Offset<IActionInfo> actionOffset)
		{
			builder.AddOffset(6, actionOffset.Value, 0);
		}

		// Token: 0x06019B3A RID: 105274 RVA: 0x003AE57E File Offset: 0x003AC77E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06019B3B RID: 105275 RVA: 0x003AE589 File Offset: 0x003AC789
		public static Offset<IPerformerAiTask> EndIPerformerAiTask(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiTask>(builder.EndTable());
		}

		// Token: 0x06019B3C RID: 105276 RVA: 0x003AE598 File Offset: 0x003AC798
		public IPerformerAiTaskT UnPack()
		{
			IPerformerAiTaskT performerAiTaskT = new IPerformerAiTaskT();
			this.UnPackTo(performerAiTaskT);
			return performerAiTaskT;
		}

		// Token: 0x06019B3D RID: 105277 RVA: 0x003AE5B4 File Offset: 0x003AC7B4
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

		// Token: 0x06019B3E RID: 105278 RVA: 0x003AE7AC File Offset: 0x003AC9AC
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

		// Token: 0x0400C196 RID: 49558
		private Table __p;
	}
}

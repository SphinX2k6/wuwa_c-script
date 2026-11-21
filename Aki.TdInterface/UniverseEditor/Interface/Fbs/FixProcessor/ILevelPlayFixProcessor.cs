using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004BCB RID: 19403
	public struct ILevelPlayFixProcessor : IFlatbufferObject
	{
		// Token: 0x1700895C RID: 35164
		// (get) Token: 0x0601D9F4 RID: 121332 RVA: 0x00428771 File Offset: 0x00426971
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D9F5 RID: 121333 RVA: 0x0042877E File Offset: 0x0042697E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D9F6 RID: 121334 RVA: 0x00428788 File Offset: 0x00426988
		public static ILevelPlayFixProcessor GetRootAsILevelPlayFixProcessor(ByteBuffer _bb)
		{
			return ILevelPlayFixProcessor.GetRootAsILevelPlayFixProcessor(_bb, default(ILevelPlayFixProcessor));
		}

		// Token: 0x0601D9F7 RID: 121335 RVA: 0x004287A4 File Offset: 0x004269A4
		public static ILevelPlayFixProcessor GetRootAsILevelPlayFixProcessor(ByteBuffer _bb, ILevelPlayFixProcessor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D9F8 RID: 121336 RVA: 0x004287C1 File Offset: 0x004269C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D9F9 RID: 121337 RVA: 0x004287D0 File Offset: 0x004269D0
		public ILevelPlayFixProcessor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601D9FA RID: 121338 RVA: 0x004287E0 File Offset: 0x004269E0
		public IFixAction? FixActions(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IFixAction?(default(IFixAction).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700895D RID: 35165
		// (get) Token: 0x0601D9FB RID: 121339 RVA: 0x00428840 File Offset: 0x00426A40
		public int FixActionsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601D9FC RID: 121340 RVA: 0x0042886B File Offset: 0x00426A6B
		public static Offset<ILevelPlayFixProcessor> CreateILevelPlayFixProcessor(FlatBufferBuilder builder, VectorOffset FixActionsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			ILevelPlayFixProcessor.AddFixActions(builder, FixActionsOffset);
			return ILevelPlayFixProcessor.EndILevelPlayFixProcessor(builder);
		}

		// Token: 0x0601D9FD RID: 121341 RVA: 0x00428881 File Offset: 0x00426A81
		public static void StartILevelPlayFixProcessor(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601D9FE RID: 121342 RVA: 0x0042888A File Offset: 0x00426A8A
		public static void AddFixActions(FlatBufferBuilder builder, VectorOffset fixActionsOffset)
		{
			builder.AddOffset(0, fixActionsOffset.Value, 0);
		}

		// Token: 0x0601D9FF RID: 121343 RVA: 0x0042889C File Offset: 0x00426A9C
		public static VectorOffset CreateFixActionsVector(FlatBufferBuilder builder, Offset<IFixAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DA00 RID: 121344 RVA: 0x004288DC File Offset: 0x00426ADC
		public static VectorOffset CreateFixActionsVectorBlock(FlatBufferBuilder builder, Offset<IFixAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFixAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DA01 RID: 121345 RVA: 0x004288F6 File Offset: 0x00426AF6
		public static VectorOffset CreateFixActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFixAction>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFixAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DA02 RID: 121346 RVA: 0x00428914 File Offset: 0x00426B14
		public static VectorOffset CreateFixActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFixAction>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DA03 RID: 121347 RVA: 0x0042892D File Offset: 0x00426B2D
		public static void StartFixActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DA04 RID: 121348 RVA: 0x00428938 File Offset: 0x00426B38
		public static Offset<ILevelPlayFixProcessor> EndILevelPlayFixProcessor(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayFixProcessor>(builder.EndTable());
		}

		// Token: 0x0601DA05 RID: 121349 RVA: 0x00428948 File Offset: 0x00426B48
		public ILevelPlayFixProcessorT UnPack()
		{
			ILevelPlayFixProcessorT levelPlayFixProcessorT = new ILevelPlayFixProcessorT();
			this.UnPackTo(levelPlayFixProcessorT);
			return levelPlayFixProcessorT;
		}

		// Token: 0x0601DA06 RID: 121350 RVA: 0x00428964 File Offset: 0x00426B64
		public void UnPackTo(ILevelPlayFixProcessorT _o)
		{
			_o.FixActions = new List<IFixActionT>();
			for (int i = 0; i < this.FixActionsLength; i++)
			{
				_o.FixActions.Add((this.FixActions(i) != null) ? this.FixActions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601DA07 RID: 121351 RVA: 0x004289C4 File Offset: 0x00426BC4
		public static Offset<ILevelPlayFixProcessor> Pack(FlatBufferBuilder builder, ILevelPlayFixProcessorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayFixProcessor>);
			}
			VectorOffset fixActionsOffset = default(VectorOffset);
			if (_o.FixActions != null)
			{
				Offset<IFixAction>[] array = new Offset<IFixAction>[_o.FixActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IFixAction.Pack(builder, _o.FixActions[i]);
				}
				fixActionsOffset = ILevelPlayFixProcessor.CreateFixActionsVector(builder, array);
			}
			return ILevelPlayFixProcessor.CreateILevelPlayFixProcessor(builder, fixActionsOffset);
		}

		// Token: 0x0400D491 RID: 54417
		private Table __p;
	}
}

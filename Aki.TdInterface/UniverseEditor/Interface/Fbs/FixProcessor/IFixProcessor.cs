using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004BBF RID: 19391
	public struct IFixProcessor : IFlatbufferObject
	{
		// Token: 0x17008946 RID: 35142
		// (get) Token: 0x0601D98C RID: 121228 RVA: 0x00427A8C File Offset: 0x00425C8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D98D RID: 121229 RVA: 0x00427A99 File Offset: 0x00425C99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D98E RID: 121230 RVA: 0x00427AA0 File Offset: 0x00425CA0
		public static IFixProcessor GetRootAsIFixProcessor(ByteBuffer _bb)
		{
			return IFixProcessor.GetRootAsIFixProcessor(_bb, default(IFixProcessor));
		}

		// Token: 0x0601D98F RID: 121231 RVA: 0x00427ABC File Offset: 0x00425CBC
		public static IFixProcessor GetRootAsIFixProcessor(ByteBuffer _bb, IFixProcessor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D990 RID: 121232 RVA: 0x00427AD9 File Offset: 0x00425CD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D991 RID: 121233 RVA: 0x00427AE8 File Offset: 0x00425CE8
		public IFixProcessor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601D992 RID: 121234 RVA: 0x00427AF8 File Offset: 0x00425CF8
		public IFixAction? FixActions(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IFixAction?(default(IFixAction).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008947 RID: 35143
		// (get) Token: 0x0601D993 RID: 121235 RVA: 0x00427B58 File Offset: 0x00425D58
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

		// Token: 0x0601D994 RID: 121236 RVA: 0x00427B83 File Offset: 0x00425D83
		public static Offset<IFixProcessor> CreateIFixProcessor(FlatBufferBuilder builder, VectorOffset FixActionsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IFixProcessor.AddFixActions(builder, FixActionsOffset);
			return IFixProcessor.EndIFixProcessor(builder);
		}

		// Token: 0x0601D995 RID: 121237 RVA: 0x00427B99 File Offset: 0x00425D99
		public static void StartIFixProcessor(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601D996 RID: 121238 RVA: 0x00427BA2 File Offset: 0x00425DA2
		public static void AddFixActions(FlatBufferBuilder builder, VectorOffset fixActionsOffset)
		{
			builder.AddOffset(0, fixActionsOffset.Value, 0);
		}

		// Token: 0x0601D997 RID: 121239 RVA: 0x00427BB4 File Offset: 0x00425DB4
		public static VectorOffset CreateFixActionsVector(FlatBufferBuilder builder, Offset<IFixAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D998 RID: 121240 RVA: 0x00427BF4 File Offset: 0x00425DF4
		public static VectorOffset CreateFixActionsVectorBlock(FlatBufferBuilder builder, Offset<IFixAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFixAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D999 RID: 121241 RVA: 0x00427C0E File Offset: 0x00425E0E
		public static VectorOffset CreateFixActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFixAction>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFixAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D99A RID: 121242 RVA: 0x00427C2C File Offset: 0x00425E2C
		public static VectorOffset CreateFixActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFixAction>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D99B RID: 121243 RVA: 0x00427C45 File Offset: 0x00425E45
		public static void StartFixActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D99C RID: 121244 RVA: 0x00427C50 File Offset: 0x00425E50
		public static Offset<IFixProcessor> EndIFixProcessor(FlatBufferBuilder builder)
		{
			return new Offset<IFixProcessor>(builder.EndTable());
		}

		// Token: 0x0601D99D RID: 121245 RVA: 0x00427C60 File Offset: 0x00425E60
		public IFixProcessorT UnPack()
		{
			IFixProcessorT fixProcessorT = new IFixProcessorT();
			this.UnPackTo(fixProcessorT);
			return fixProcessorT;
		}

		// Token: 0x0601D99E RID: 121246 RVA: 0x00427C7C File Offset: 0x00425E7C
		public void UnPackTo(IFixProcessorT _o)
		{
			_o.FixActions = new List<IFixActionT>();
			for (int i = 0; i < this.FixActionsLength; i++)
			{
				_o.FixActions.Add((this.FixActions(i) != null) ? this.FixActions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601D99F RID: 121247 RVA: 0x00427CDC File Offset: 0x00425EDC
		public static Offset<IFixProcessor> Pack(FlatBufferBuilder builder, IFixProcessorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixProcessor>);
			}
			VectorOffset fixActionsOffset = default(VectorOffset);
			if (_o.FixActions != null)
			{
				Offset<IFixAction>[] array = new Offset<IFixAction>[_o.FixActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IFixAction.Pack(builder, _o.FixActions[i]);
				}
				fixActionsOffset = IFixProcessor.CreateFixActionsVector(builder, array);
			}
			return IFixProcessor.CreateIFixProcessor(builder, fixActionsOffset);
		}

		// Token: 0x0400D484 RID: 54404
		private Table __p;
	}
}

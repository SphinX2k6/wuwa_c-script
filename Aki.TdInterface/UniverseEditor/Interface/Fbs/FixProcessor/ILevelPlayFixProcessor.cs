using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004763 RID: 18275
	public struct ILevelPlayFixProcessor : IFlatbufferObject
	{
		// Token: 0x1700831B RID: 33563
		// (get) Token: 0x0601C21F RID: 115231 RVA: 0x003FC4D5 File Offset: 0x003FA6D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C220 RID: 115232 RVA: 0x003FC4E2 File Offset: 0x003FA6E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C221 RID: 115233 RVA: 0x003FC4EC File Offset: 0x003FA6EC
		public static ILevelPlayFixProcessor GetRootAsILevelPlayFixProcessor(ByteBuffer _bb)
		{
			return ILevelPlayFixProcessor.GetRootAsILevelPlayFixProcessor(_bb, default(ILevelPlayFixProcessor));
		}

		// Token: 0x0601C222 RID: 115234 RVA: 0x003FC508 File Offset: 0x003FA708
		public static ILevelPlayFixProcessor GetRootAsILevelPlayFixProcessor(ByteBuffer _bb, ILevelPlayFixProcessor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C223 RID: 115235 RVA: 0x003FC525 File Offset: 0x003FA725
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C224 RID: 115236 RVA: 0x003FC534 File Offset: 0x003FA734
		public ILevelPlayFixProcessor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601C225 RID: 115237 RVA: 0x003FC544 File Offset: 0x003FA744
		public IFixAction? FixActions(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IFixAction?(default(IFixAction).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700831C RID: 33564
		// (get) Token: 0x0601C226 RID: 115238 RVA: 0x003FC5A4 File Offset: 0x003FA7A4
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

		// Token: 0x0601C227 RID: 115239 RVA: 0x003FC5CF File Offset: 0x003FA7CF
		public static Offset<ILevelPlayFixProcessor> CreateILevelPlayFixProcessor(FlatBufferBuilder builder, VectorOffset FixActionsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			ILevelPlayFixProcessor.AddFixActions(builder, FixActionsOffset);
			return ILevelPlayFixProcessor.EndILevelPlayFixProcessor(builder);
		}

		// Token: 0x0601C228 RID: 115240 RVA: 0x003FC5E5 File Offset: 0x003FA7E5
		public static void StartILevelPlayFixProcessor(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C229 RID: 115241 RVA: 0x003FC5EE File Offset: 0x003FA7EE
		public static void AddFixActions(FlatBufferBuilder builder, VectorOffset fixActionsOffset)
		{
			builder.AddOffset(0, fixActionsOffset.Value, 0);
		}

		// Token: 0x0601C22A RID: 115242 RVA: 0x003FC600 File Offset: 0x003FA800
		public static VectorOffset CreateFixActionsVector(FlatBufferBuilder builder, Offset<IFixAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C22B RID: 115243 RVA: 0x003FC640 File Offset: 0x003FA840
		public static VectorOffset CreateFixActionsVectorBlock(FlatBufferBuilder builder, Offset<IFixAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFixAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C22C RID: 115244 RVA: 0x003FC65A File Offset: 0x003FA85A
		public static VectorOffset CreateFixActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFixAction>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFixAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C22D RID: 115245 RVA: 0x003FC678 File Offset: 0x003FA878
		public static VectorOffset CreateFixActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFixAction>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C22E RID: 115246 RVA: 0x003FC691 File Offset: 0x003FA891
		public static void StartFixActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C22F RID: 115247 RVA: 0x003FC69C File Offset: 0x003FA89C
		public static Offset<ILevelPlayFixProcessor> EndILevelPlayFixProcessor(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayFixProcessor>(builder.EndTable());
		}

		// Token: 0x0601C230 RID: 115248 RVA: 0x003FC6AC File Offset: 0x003FA8AC
		public ILevelPlayFixProcessorT UnPack()
		{
			ILevelPlayFixProcessorT levelPlayFixProcessorT = new ILevelPlayFixProcessorT();
			this.UnPackTo(levelPlayFixProcessorT);
			return levelPlayFixProcessorT;
		}

		// Token: 0x0601C231 RID: 115249 RVA: 0x003FC6C8 File Offset: 0x003FA8C8
		public void UnPackTo(ILevelPlayFixProcessorT _o)
		{
			_o.FixActions = new List<IFixActionT>();
			for (int i = 0; i < this.FixActionsLength; i++)
			{
				_o.FixActions.Add((this.FixActions(i) != null) ? this.FixActions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601C232 RID: 115250 RVA: 0x003FC728 File Offset: 0x003FA928
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

		// Token: 0x0400CA62 RID: 51810
		private Table __p;
	}
}

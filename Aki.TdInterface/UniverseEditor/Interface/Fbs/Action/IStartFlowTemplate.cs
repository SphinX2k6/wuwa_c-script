using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007983 RID: 31107
	public struct IStartFlowTemplate : IFlatbufferObject
	{
		// Token: 0x1700E413 RID: 58387
		// (get) Token: 0x06036C88 RID: 224392 RVA: 0x00753DF9 File Offset: 0x00751FF9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036C89 RID: 224393 RVA: 0x00753E06 File Offset: 0x00752006
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036C8A RID: 224394 RVA: 0x00753E10 File Offset: 0x00752010
		public static IStartFlowTemplate GetRootAsIStartFlowTemplate(ByteBuffer _bb)
		{
			return IStartFlowTemplate.GetRootAsIStartFlowTemplate(_bb, default(IStartFlowTemplate));
		}

		// Token: 0x06036C8B RID: 224395 RVA: 0x00753E2C File Offset: 0x0075202C
		public static IStartFlowTemplate GetRootAsIStartFlowTemplate(ByteBuffer _bb, IStartFlowTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036C8C RID: 224396 RVA: 0x00753E49 File Offset: 0x00752049
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036C8D RID: 224397 RVA: 0x00753E58 File Offset: 0x00752058
		public IStartFlowTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E414 RID: 58388
		// (get) Token: 0x06036C8E RID: 224398 RVA: 0x00753E68 File Offset: 0x00752068
		public IFlowTemplateMode? TemplateMode
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IFlowTemplateMode?(default(IFlowTemplateMode).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E415 RID: 58389
		// (get) Token: 0x06036C8F RID: 224399 RVA: 0x00753EC8 File Offset: 0x007520C8
		public IPosA? TargetPos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPosA?(default(IPosA).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06036C90 RID: 224400 RVA: 0x00753F28 File Offset: 0x00752128
		public int ActorIdArray(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E416 RID: 58390
		// (get) Token: 0x06036C91 RID: 224401 RVA: 0x00753F68 File Offset: 0x00752168
		public int ActorIdArrayLength
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

		// Token: 0x06036C92 RID: 224402 RVA: 0x00753F93 File Offset: 0x00752193
		public Span<int> GetActorIdArrayBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06036C93 RID: 224403 RVA: 0x00753FA2 File Offset: 0x007521A2
		public int[] GetActorIdArrayArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x06036C94 RID: 224404 RVA: 0x00753FB0 File Offset: 0x007521B0
		public int TalkerIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E417 RID: 58391
		// (get) Token: 0x06036C95 RID: 224405 RVA: 0x00753FF0 File Offset: 0x007521F0
		public int TalkerIdsLength
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

		// Token: 0x06036C96 RID: 224406 RVA: 0x0075401C File Offset: 0x0075221C
		public Span<int> GetTalkerIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06036C97 RID: 224407 RVA: 0x0075402C File Offset: 0x0075222C
		public int[] GetTalkerIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x1700E418 RID: 58392
		// (get) Token: 0x06036C98 RID: 224408 RVA: 0x0075403C File Offset: 0x0075223C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036C99 RID: 224409 RVA: 0x00754079 File Offset: 0x00752279
		public static Offset<IStartFlowTemplate> CreateIStartFlowTemplate(FlatBufferBuilder builder, Offset<IFlowTemplateMode> TemplateModeOffset = default(Offset<IFlowTemplateMode>), Offset<IPosA> TargetPosOffset = default(Offset<IPosA>), VectorOffset ActorIdArrayOffset = default(VectorOffset), VectorOffset TalkerIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IStartFlowTemplate.AddTalkerIds(builder, TalkerIdsOffset);
			IStartFlowTemplate.AddActorIdArray(builder, ActorIdArrayOffset);
			IStartFlowTemplate.AddTargetPos(builder, TargetPosOffset);
			IStartFlowTemplate.AddTemplateMode(builder, TemplateModeOffset);
			IStartFlowTemplate.AddNullMask(builder, NullMask);
			return IStartFlowTemplate.EndIStartFlowTemplate(builder);
		}

		// Token: 0x06036C9A RID: 224410 RVA: 0x007540AD File Offset: 0x007522AD
		public static void StartIStartFlowTemplate(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06036C9B RID: 224411 RVA: 0x007540B6 File Offset: 0x007522B6
		public static void AddTemplateMode(FlatBufferBuilder builder, Offset<IFlowTemplateMode> templateModeOffset)
		{
			builder.AddOffset(0, templateModeOffset.Value, 0);
		}

		// Token: 0x06036C9C RID: 224412 RVA: 0x007540C6 File Offset: 0x007522C6
		public static void AddTargetPos(FlatBufferBuilder builder, Offset<IPosA> targetPosOffset)
		{
			builder.AddOffset(1, targetPosOffset.Value, 0);
		}

		// Token: 0x06036C9D RID: 224413 RVA: 0x007540D6 File Offset: 0x007522D6
		public static void AddActorIdArray(FlatBufferBuilder builder, VectorOffset actorIdArrayOffset)
		{
			builder.AddOffset(2, actorIdArrayOffset.Value, 0);
		}

		// Token: 0x06036C9E RID: 224414 RVA: 0x007540E8 File Offset: 0x007522E8
		public static VectorOffset CreateActorIdArrayVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06036C9F RID: 224415 RVA: 0x0075411F File Offset: 0x0075231F
		public static VectorOffset CreateActorIdArrayVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06036CA0 RID: 224416 RVA: 0x00754139 File Offset: 0x00752339
		public static VectorOffset CreateActorIdArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06036CA1 RID: 224417 RVA: 0x00754157 File Offset: 0x00752357
		public static VectorOffset CreateActorIdArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06036CA2 RID: 224418 RVA: 0x00754170 File Offset: 0x00752370
		public static void StartActorIdArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06036CA3 RID: 224419 RVA: 0x0075417B File Offset: 0x0075237B
		public static void AddTalkerIds(FlatBufferBuilder builder, VectorOffset talkerIdsOffset)
		{
			builder.AddOffset(3, talkerIdsOffset.Value, 0);
		}

		// Token: 0x06036CA4 RID: 224420 RVA: 0x0075418C File Offset: 0x0075238C
		public static VectorOffset CreateTalkerIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06036CA5 RID: 224421 RVA: 0x007541C3 File Offset: 0x007523C3
		public static VectorOffset CreateTalkerIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06036CA6 RID: 224422 RVA: 0x007541DD File Offset: 0x007523DD
		public static VectorOffset CreateTalkerIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06036CA7 RID: 224423 RVA: 0x007541FB File Offset: 0x007523FB
		public static VectorOffset CreateTalkerIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06036CA8 RID: 224424 RVA: 0x00754214 File Offset: 0x00752414
		public static void StartTalkerIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06036CA9 RID: 224425 RVA: 0x0075421F File Offset: 0x0075241F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06036CAA RID: 224426 RVA: 0x0075422A File Offset: 0x0075242A
		public static Offset<IStartFlowTemplate> EndIStartFlowTemplate(FlatBufferBuilder builder)
		{
			return new Offset<IStartFlowTemplate>(builder.EndTable());
		}

		// Token: 0x06036CAB RID: 224427 RVA: 0x00754238 File Offset: 0x00752438
		public IStartFlowTemplateT UnPack()
		{
			IStartFlowTemplateT startFlowTemplateT = new IStartFlowTemplateT();
			this.UnPackTo(startFlowTemplateT);
			return startFlowTemplateT;
		}

		// Token: 0x06036CAC RID: 224428 RVA: 0x00754254 File Offset: 0x00752454
		public void UnPackTo(IStartFlowTemplateT _o)
		{
			_o.TemplateMode = ((this.TemplateMode != null) ? this.TemplateMode.Value.UnPack() : null);
			_o.TargetPos = ((this.TargetPos != null) ? this.TargetPos.Value.UnPack() : null);
			_o.ActorIdArray = new List<int>();
			for (int i = 0; i < this.ActorIdArrayLength; i++)
			{
				_o.ActorIdArray.Add(this.ActorIdArray(i));
			}
			_o.TalkerIds = new List<int>();
			for (int j = 0; j < this.TalkerIdsLength; j++)
			{
				_o.TalkerIds.Add(this.TalkerIds(j));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06036CAD RID: 224429 RVA: 0x00754334 File Offset: 0x00752534
		public static Offset<IStartFlowTemplate> Pack(FlatBufferBuilder builder, IStartFlowTemplateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStartFlowTemplate>);
			}
			Offset<IFlowTemplateMode> templateModeOffset = (_o.TemplateMode == null) ? default(Offset<IFlowTemplateMode>) : IFlowTemplateMode.Pack(builder, _o.TemplateMode);
			Offset<IPosA> targetPosOffset = (_o.TargetPos == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.TargetPos);
			VectorOffset actorIdArrayOffset = default(VectorOffset);
			if (_o.ActorIdArray != null)
			{
				int[] data = _o.ActorIdArray.ToArray();
				actorIdArrayOffset = IStartFlowTemplate.CreateActorIdArrayVector(builder, data);
			}
			VectorOffset talkerIdsOffset = default(VectorOffset);
			if (_o.TalkerIds != null)
			{
				int[] data2 = _o.TalkerIds.ToArray();
				talkerIdsOffset = IStartFlowTemplate.CreateTalkerIdsVector(builder, data2);
			}
			return IStartFlowTemplate.CreateIStartFlowTemplate(builder, templateModeOffset, targetPosOffset, actorIdArrayOffset, talkerIdsOffset, _o.NullMask);
		}

		// Token: 0x04012C76 RID: 76918
		private Table __p;
	}
}

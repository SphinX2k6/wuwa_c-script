using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062FC RID: 25340
	public struct IChangeFlowTemplate : IFlatbufferObject
	{
		// Token: 0x1700BD1F RID: 48415
		// (get) Token: 0x0602BCE7 RID: 179431 RVA: 0x006065D6 File Offset: 0x006047D6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BCE8 RID: 179432 RVA: 0x006065E3 File Offset: 0x006047E3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BCE9 RID: 179433 RVA: 0x006065EC File Offset: 0x006047EC
		public static IChangeFlowTemplate GetRootAsIChangeFlowTemplate(ByteBuffer _bb)
		{
			return IChangeFlowTemplate.GetRootAsIChangeFlowTemplate(_bb, default(IChangeFlowTemplate));
		}

		// Token: 0x0602BCEA RID: 179434 RVA: 0x00606608 File Offset: 0x00604808
		public static IChangeFlowTemplate GetRootAsIChangeFlowTemplate(ByteBuffer _bb, IChangeFlowTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BCEB RID: 179435 RVA: 0x00606625 File Offset: 0x00604825
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BCEC RID: 179436 RVA: 0x00606634 File Offset: 0x00604834
		public IChangeFlowTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD20 RID: 48416
		// (get) Token: 0x0602BCED RID: 179437 RVA: 0x00606644 File Offset: 0x00604844
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

		// Token: 0x1700BD21 RID: 48417
		// (get) Token: 0x0602BCEE RID: 179438 RVA: 0x006066A4 File Offset: 0x006048A4
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

		// Token: 0x0602BCEF RID: 179439 RVA: 0x00606704 File Offset: 0x00604904
		public int ActorIdArray(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BD22 RID: 48418
		// (get) Token: 0x0602BCF0 RID: 179440 RVA: 0x00606744 File Offset: 0x00604944
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

		// Token: 0x0602BCF1 RID: 179441 RVA: 0x0060676F File Offset: 0x0060496F
		public Span<int> GetActorIdArrayBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0602BCF2 RID: 179442 RVA: 0x0060677E File Offset: 0x0060497E
		public int[] GetActorIdArrayArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x0602BCF3 RID: 179443 RVA: 0x0060678C File Offset: 0x0060498C
		public int TalkerIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BD23 RID: 48419
		// (get) Token: 0x0602BCF4 RID: 179444 RVA: 0x006067CC File Offset: 0x006049CC
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

		// Token: 0x0602BCF5 RID: 179445 RVA: 0x006067F8 File Offset: 0x006049F8
		public Span<int> GetTalkerIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0602BCF6 RID: 179446 RVA: 0x00606808 File Offset: 0x00604A08
		public int[] GetTalkerIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x1700BD24 RID: 48420
		// (get) Token: 0x0602BCF7 RID: 179447 RVA: 0x00606818 File Offset: 0x00604A18
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

		// Token: 0x0602BCF8 RID: 179448 RVA: 0x00606855 File Offset: 0x00604A55
		public static Offset<IChangeFlowTemplate> CreateIChangeFlowTemplate(FlatBufferBuilder builder, Offset<IFlowTemplateMode> TemplateModeOffset = default(Offset<IFlowTemplateMode>), Offset<IPosA> TargetPosOffset = default(Offset<IPosA>), VectorOffset ActorIdArrayOffset = default(VectorOffset), VectorOffset TalkerIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IChangeFlowTemplate.AddTalkerIds(builder, TalkerIdsOffset);
			IChangeFlowTemplate.AddActorIdArray(builder, ActorIdArrayOffset);
			IChangeFlowTemplate.AddTargetPos(builder, TargetPosOffset);
			IChangeFlowTemplate.AddTemplateMode(builder, TemplateModeOffset);
			IChangeFlowTemplate.AddNullMask(builder, NullMask);
			return IChangeFlowTemplate.EndIChangeFlowTemplate(builder);
		}

		// Token: 0x0602BCF9 RID: 179449 RVA: 0x00606889 File Offset: 0x00604A89
		public static void StartIChangeFlowTemplate(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602BCFA RID: 179450 RVA: 0x00606892 File Offset: 0x00604A92
		public static void AddTemplateMode(FlatBufferBuilder builder, Offset<IFlowTemplateMode> templateModeOffset)
		{
			builder.AddOffset(0, templateModeOffset.Value, 0);
		}

		// Token: 0x0602BCFB RID: 179451 RVA: 0x006068A2 File Offset: 0x00604AA2
		public static void AddTargetPos(FlatBufferBuilder builder, Offset<IPosA> targetPosOffset)
		{
			builder.AddOffset(1, targetPosOffset.Value, 0);
		}

		// Token: 0x0602BCFC RID: 179452 RVA: 0x006068B2 File Offset: 0x00604AB2
		public static void AddActorIdArray(FlatBufferBuilder builder, VectorOffset actorIdArrayOffset)
		{
			builder.AddOffset(2, actorIdArrayOffset.Value, 0);
		}

		// Token: 0x0602BCFD RID: 179453 RVA: 0x006068C4 File Offset: 0x00604AC4
		public static VectorOffset CreateActorIdArrayVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602BCFE RID: 179454 RVA: 0x006068FB File Offset: 0x00604AFB
		public static VectorOffset CreateActorIdArrayVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BCFF RID: 179455 RVA: 0x00606915 File Offset: 0x00604B15
		public static VectorOffset CreateActorIdArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BD00 RID: 179456 RVA: 0x00606933 File Offset: 0x00604B33
		public static VectorOffset CreateActorIdArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602BD01 RID: 179457 RVA: 0x0060694C File Offset: 0x00604B4C
		public static void StartActorIdArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602BD02 RID: 179458 RVA: 0x00606957 File Offset: 0x00604B57
		public static void AddTalkerIds(FlatBufferBuilder builder, VectorOffset talkerIdsOffset)
		{
			builder.AddOffset(3, talkerIdsOffset.Value, 0);
		}

		// Token: 0x0602BD03 RID: 179459 RVA: 0x00606968 File Offset: 0x00604B68
		public static VectorOffset CreateTalkerIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602BD04 RID: 179460 RVA: 0x0060699F File Offset: 0x00604B9F
		public static VectorOffset CreateTalkerIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BD05 RID: 179461 RVA: 0x006069B9 File Offset: 0x00604BB9
		public static VectorOffset CreateTalkerIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BD06 RID: 179462 RVA: 0x006069D7 File Offset: 0x00604BD7
		public static VectorOffset CreateTalkerIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602BD07 RID: 179463 RVA: 0x006069F0 File Offset: 0x00604BF0
		public static void StartTalkerIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602BD08 RID: 179464 RVA: 0x006069FB File Offset: 0x00604BFB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602BD09 RID: 179465 RVA: 0x00606A06 File Offset: 0x00604C06
		public static Offset<IChangeFlowTemplate> EndIChangeFlowTemplate(FlatBufferBuilder builder)
		{
			return new Offset<IChangeFlowTemplate>(builder.EndTable());
		}

		// Token: 0x0602BD0A RID: 179466 RVA: 0x00606A14 File Offset: 0x00604C14
		public IChangeFlowTemplateT UnPack()
		{
			IChangeFlowTemplateT changeFlowTemplateT = new IChangeFlowTemplateT();
			this.UnPackTo(changeFlowTemplateT);
			return changeFlowTemplateT;
		}

		// Token: 0x0602BD0B RID: 179467 RVA: 0x00606A30 File Offset: 0x00604C30
		public void UnPackTo(IChangeFlowTemplateT _o)
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

		// Token: 0x0602BD0C RID: 179468 RVA: 0x00606B10 File Offset: 0x00604D10
		public static Offset<IChangeFlowTemplate> Pack(FlatBufferBuilder builder, IChangeFlowTemplateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeFlowTemplate>);
			}
			Offset<IFlowTemplateMode> templateModeOffset = (_o.TemplateMode == null) ? default(Offset<IFlowTemplateMode>) : IFlowTemplateMode.Pack(builder, _o.TemplateMode);
			Offset<IPosA> targetPosOffset = (_o.TargetPos == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.TargetPos);
			VectorOffset actorIdArrayOffset = default(VectorOffset);
			if (_o.ActorIdArray != null)
			{
				int[] data = _o.ActorIdArray.ToArray();
				actorIdArrayOffset = IChangeFlowTemplate.CreateActorIdArrayVector(builder, data);
			}
			VectorOffset talkerIdsOffset = default(VectorOffset);
			if (_o.TalkerIds != null)
			{
				int[] data2 = _o.TalkerIds.ToArray();
				talkerIdsOffset = IChangeFlowTemplate.CreateTalkerIdsVector(builder, data2);
			}
			return IChangeFlowTemplate.CreateIChangeFlowTemplate(builder, templateModeOffset, targetPosOffset, actorIdArrayOffset, talkerIdsOffset, _o.NullMask);
		}

		// Token: 0x040108B6 RID: 67766
		private Table __p;
	}
}

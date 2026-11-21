using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200696D RID: 26989
	public struct IChangeFlowTemplate : IFlatbufferObject
	{
		// Token: 0x1700C6A9 RID: 50857
		// (get) Token: 0x0602E450 RID: 189520 RVA: 0x006515E2 File Offset: 0x0064F7E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E451 RID: 189521 RVA: 0x006515EF File Offset: 0x0064F7EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E452 RID: 189522 RVA: 0x006515F8 File Offset: 0x0064F7F8
		public static IChangeFlowTemplate GetRootAsIChangeFlowTemplate(ByteBuffer _bb)
		{
			return IChangeFlowTemplate.GetRootAsIChangeFlowTemplate(_bb, default(IChangeFlowTemplate));
		}

		// Token: 0x0602E453 RID: 189523 RVA: 0x00651614 File Offset: 0x0064F814
		public static IChangeFlowTemplate GetRootAsIChangeFlowTemplate(ByteBuffer _bb, IChangeFlowTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E454 RID: 189524 RVA: 0x00651631 File Offset: 0x0064F831
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E455 RID: 189525 RVA: 0x00651640 File Offset: 0x0064F840
		public IChangeFlowTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C6AA RID: 50858
		// (get) Token: 0x0602E456 RID: 189526 RVA: 0x00651650 File Offset: 0x0064F850
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

		// Token: 0x1700C6AB RID: 50859
		// (get) Token: 0x0602E457 RID: 189527 RVA: 0x006516B0 File Offset: 0x0064F8B0
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

		// Token: 0x0602E458 RID: 189528 RVA: 0x00651710 File Offset: 0x0064F910
		public int ActorIdArray(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C6AC RID: 50860
		// (get) Token: 0x0602E459 RID: 189529 RVA: 0x00651750 File Offset: 0x0064F950
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

		// Token: 0x0602E45A RID: 189530 RVA: 0x0065177B File Offset: 0x0064F97B
		public Span<int> GetActorIdArrayBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0602E45B RID: 189531 RVA: 0x0065178A File Offset: 0x0064F98A
		public int[] GetActorIdArrayArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x0602E45C RID: 189532 RVA: 0x00651798 File Offset: 0x0064F998
		public int TalkerIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C6AD RID: 50861
		// (get) Token: 0x0602E45D RID: 189533 RVA: 0x006517D8 File Offset: 0x0064F9D8
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

		// Token: 0x0602E45E RID: 189534 RVA: 0x00651804 File Offset: 0x0064FA04
		public Span<int> GetTalkerIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0602E45F RID: 189535 RVA: 0x00651814 File Offset: 0x0064FA14
		public int[] GetTalkerIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x1700C6AE RID: 50862
		// (get) Token: 0x0602E460 RID: 189536 RVA: 0x00651824 File Offset: 0x0064FA24
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

		// Token: 0x0602E461 RID: 189537 RVA: 0x00651861 File Offset: 0x0064FA61
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

		// Token: 0x0602E462 RID: 189538 RVA: 0x00651895 File Offset: 0x0064FA95
		public static void StartIChangeFlowTemplate(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602E463 RID: 189539 RVA: 0x0065189E File Offset: 0x0064FA9E
		public static void AddTemplateMode(FlatBufferBuilder builder, Offset<IFlowTemplateMode> templateModeOffset)
		{
			builder.AddOffset(0, templateModeOffset.Value, 0);
		}

		// Token: 0x0602E464 RID: 189540 RVA: 0x006518AE File Offset: 0x0064FAAE
		public static void AddTargetPos(FlatBufferBuilder builder, Offset<IPosA> targetPosOffset)
		{
			builder.AddOffset(1, targetPosOffset.Value, 0);
		}

		// Token: 0x0602E465 RID: 189541 RVA: 0x006518BE File Offset: 0x0064FABE
		public static void AddActorIdArray(FlatBufferBuilder builder, VectorOffset actorIdArrayOffset)
		{
			builder.AddOffset(2, actorIdArrayOffset.Value, 0);
		}

		// Token: 0x0602E466 RID: 189542 RVA: 0x006518D0 File Offset: 0x0064FAD0
		public static VectorOffset CreateActorIdArrayVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602E467 RID: 189543 RVA: 0x00651907 File Offset: 0x0064FB07
		public static VectorOffset CreateActorIdArrayVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E468 RID: 189544 RVA: 0x00651921 File Offset: 0x0064FB21
		public static VectorOffset CreateActorIdArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E469 RID: 189545 RVA: 0x0065193F File Offset: 0x0064FB3F
		public static VectorOffset CreateActorIdArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602E46A RID: 189546 RVA: 0x00651958 File Offset: 0x0064FB58
		public static void StartActorIdArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602E46B RID: 189547 RVA: 0x00651963 File Offset: 0x0064FB63
		public static void AddTalkerIds(FlatBufferBuilder builder, VectorOffset talkerIdsOffset)
		{
			builder.AddOffset(3, talkerIdsOffset.Value, 0);
		}

		// Token: 0x0602E46C RID: 189548 RVA: 0x00651974 File Offset: 0x0064FB74
		public static VectorOffset CreateTalkerIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602E46D RID: 189549 RVA: 0x006519AB File Offset: 0x0064FBAB
		public static VectorOffset CreateTalkerIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E46E RID: 189550 RVA: 0x006519C5 File Offset: 0x0064FBC5
		public static VectorOffset CreateTalkerIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E46F RID: 189551 RVA: 0x006519E3 File Offset: 0x0064FBE3
		public static VectorOffset CreateTalkerIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602E470 RID: 189552 RVA: 0x006519FC File Offset: 0x0064FBFC
		public static void StartTalkerIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602E471 RID: 189553 RVA: 0x00651A07 File Offset: 0x0064FC07
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602E472 RID: 189554 RVA: 0x00651A12 File Offset: 0x0064FC12
		public static Offset<IChangeFlowTemplate> EndIChangeFlowTemplate(FlatBufferBuilder builder)
		{
			return new Offset<IChangeFlowTemplate>(builder.EndTable());
		}

		// Token: 0x0602E473 RID: 189555 RVA: 0x00651A20 File Offset: 0x0064FC20
		public IChangeFlowTemplateT UnPack()
		{
			IChangeFlowTemplateT changeFlowTemplateT = new IChangeFlowTemplateT();
			this.UnPackTo(changeFlowTemplateT);
			return changeFlowTemplateT;
		}

		// Token: 0x0602E474 RID: 189556 RVA: 0x00651A3C File Offset: 0x0064FC3C
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

		// Token: 0x0602E475 RID: 189557 RVA: 0x00651B1C File Offset: 0x0064FD1C
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

		// Token: 0x040116CC RID: 71372
		private Table __p;
	}
}

using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071AE RID: 29102
	public struct IStartFlowTemplate : IFlatbufferObject
	{
		// Token: 0x1700D81C RID: 55324
		// (get) Token: 0x0603398A RID: 211338 RVA: 0x006F2B2D File Offset: 0x006F0D2D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603398B RID: 211339 RVA: 0x006F2B3A File Offset: 0x006F0D3A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603398C RID: 211340 RVA: 0x006F2B44 File Offset: 0x006F0D44
		public static IStartFlowTemplate GetRootAsIStartFlowTemplate(ByteBuffer _bb)
		{
			return IStartFlowTemplate.GetRootAsIStartFlowTemplate(_bb, default(IStartFlowTemplate));
		}

		// Token: 0x0603398D RID: 211341 RVA: 0x006F2B60 File Offset: 0x006F0D60
		public static IStartFlowTemplate GetRootAsIStartFlowTemplate(ByteBuffer _bb, IStartFlowTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603398E RID: 211342 RVA: 0x006F2B7D File Offset: 0x006F0D7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603398F RID: 211343 RVA: 0x006F2B8C File Offset: 0x006F0D8C
		public IStartFlowTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D81D RID: 55325
		// (get) Token: 0x06033990 RID: 211344 RVA: 0x006F2B9C File Offset: 0x006F0D9C
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

		// Token: 0x1700D81E RID: 55326
		// (get) Token: 0x06033991 RID: 211345 RVA: 0x006F2BFC File Offset: 0x006F0DFC
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

		// Token: 0x06033992 RID: 211346 RVA: 0x006F2C5C File Offset: 0x006F0E5C
		public int ActorIdArray(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D81F RID: 55327
		// (get) Token: 0x06033993 RID: 211347 RVA: 0x006F2C9C File Offset: 0x006F0E9C
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

		// Token: 0x06033994 RID: 211348 RVA: 0x006F2CC7 File Offset: 0x006F0EC7
		public Span<int> GetActorIdArrayBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06033995 RID: 211349 RVA: 0x006F2CD6 File Offset: 0x006F0ED6
		public int[] GetActorIdArrayArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x06033996 RID: 211350 RVA: 0x006F2CE4 File Offset: 0x006F0EE4
		public int TalkerIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D820 RID: 55328
		// (get) Token: 0x06033997 RID: 211351 RVA: 0x006F2D24 File Offset: 0x006F0F24
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

		// Token: 0x06033998 RID: 211352 RVA: 0x006F2D50 File Offset: 0x006F0F50
		public Span<int> GetTalkerIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06033999 RID: 211353 RVA: 0x006F2D60 File Offset: 0x006F0F60
		public int[] GetTalkerIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x1700D821 RID: 55329
		// (get) Token: 0x0603399A RID: 211354 RVA: 0x006F2D70 File Offset: 0x006F0F70
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

		// Token: 0x0603399B RID: 211355 RVA: 0x006F2DAD File Offset: 0x006F0FAD
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

		// Token: 0x0603399C RID: 211356 RVA: 0x006F2DE1 File Offset: 0x006F0FE1
		public static void StartIStartFlowTemplate(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0603399D RID: 211357 RVA: 0x006F2DEA File Offset: 0x006F0FEA
		public static void AddTemplateMode(FlatBufferBuilder builder, Offset<IFlowTemplateMode> templateModeOffset)
		{
			builder.AddOffset(0, templateModeOffset.Value, 0);
		}

		// Token: 0x0603399E RID: 211358 RVA: 0x006F2DFA File Offset: 0x006F0FFA
		public static void AddTargetPos(FlatBufferBuilder builder, Offset<IPosA> targetPosOffset)
		{
			builder.AddOffset(1, targetPosOffset.Value, 0);
		}

		// Token: 0x0603399F RID: 211359 RVA: 0x006F2E0A File Offset: 0x006F100A
		public static void AddActorIdArray(FlatBufferBuilder builder, VectorOffset actorIdArrayOffset)
		{
			builder.AddOffset(2, actorIdArrayOffset.Value, 0);
		}

		// Token: 0x060339A0 RID: 211360 RVA: 0x006F2E1C File Offset: 0x006F101C
		public static VectorOffset CreateActorIdArrayVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060339A1 RID: 211361 RVA: 0x006F2E53 File Offset: 0x006F1053
		public static VectorOffset CreateActorIdArrayVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060339A2 RID: 211362 RVA: 0x006F2E6D File Offset: 0x006F106D
		public static VectorOffset CreateActorIdArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060339A3 RID: 211363 RVA: 0x006F2E8B File Offset: 0x006F108B
		public static VectorOffset CreateActorIdArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060339A4 RID: 211364 RVA: 0x006F2EA4 File Offset: 0x006F10A4
		public static void StartActorIdArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060339A5 RID: 211365 RVA: 0x006F2EAF File Offset: 0x006F10AF
		public static void AddTalkerIds(FlatBufferBuilder builder, VectorOffset talkerIdsOffset)
		{
			builder.AddOffset(3, talkerIdsOffset.Value, 0);
		}

		// Token: 0x060339A6 RID: 211366 RVA: 0x006F2EC0 File Offset: 0x006F10C0
		public static VectorOffset CreateTalkerIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060339A7 RID: 211367 RVA: 0x006F2EF7 File Offset: 0x006F10F7
		public static VectorOffset CreateTalkerIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060339A8 RID: 211368 RVA: 0x006F2F11 File Offset: 0x006F1111
		public static VectorOffset CreateTalkerIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060339A9 RID: 211369 RVA: 0x006F2F2F File Offset: 0x006F112F
		public static VectorOffset CreateTalkerIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060339AA RID: 211370 RVA: 0x006F2F48 File Offset: 0x006F1148
		public static void StartTalkerIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060339AB RID: 211371 RVA: 0x006F2F53 File Offset: 0x006F1153
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060339AC RID: 211372 RVA: 0x006F2F5E File Offset: 0x006F115E
		public static Offset<IStartFlowTemplate> EndIStartFlowTemplate(FlatBufferBuilder builder)
		{
			return new Offset<IStartFlowTemplate>(builder.EndTable());
		}

		// Token: 0x060339AD RID: 211373 RVA: 0x006F2F6C File Offset: 0x006F116C
		public IStartFlowTemplateT UnPack()
		{
			IStartFlowTemplateT startFlowTemplateT = new IStartFlowTemplateT();
			this.UnPackTo(startFlowTemplateT);
			return startFlowTemplateT;
		}

		// Token: 0x060339AE RID: 211374 RVA: 0x006F2F88 File Offset: 0x006F1188
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

		// Token: 0x060339AF RID: 211375 RVA: 0x006F3068 File Offset: 0x006F1268
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

		// Token: 0x04011C75 RID: 72821
		private Table __p;
	}
}

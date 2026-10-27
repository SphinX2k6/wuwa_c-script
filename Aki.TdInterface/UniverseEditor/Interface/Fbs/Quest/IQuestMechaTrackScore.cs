using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FEF RID: 16367
	public struct IQuestMechaTrackScore : IFlatbufferObject
	{
		// Token: 0x170072DE RID: 29406
		// (get) Token: 0x0601790D RID: 96525 RVA: 0x00365F2D File Offset: 0x0036412D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601790E RID: 96526 RVA: 0x00365F3A File Offset: 0x0036413A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601790F RID: 96527 RVA: 0x00365F44 File Offset: 0x00364144
		public static IQuestMechaTrackScore GetRootAsIQuestMechaTrackScore(ByteBuffer _bb)
		{
			return IQuestMechaTrackScore.GetRootAsIQuestMechaTrackScore(_bb, default(IQuestMechaTrackScore));
		}

		// Token: 0x06017910 RID: 96528 RVA: 0x00365F60 File Offset: 0x00364160
		public static IQuestMechaTrackScore GetRootAsIQuestMechaTrackScore(ByteBuffer _bb, IQuestMechaTrackScore obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017911 RID: 96529 RVA: 0x00365F7D File Offset: 0x0036417D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017912 RID: 96530 RVA: 0x00365F8C File Offset: 0x0036418C
		public IQuestMechaTrackScore __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170072DF RID: 29407
		// (get) Token: 0x06017913 RID: 96531 RVA: 0x00365F9C File Offset: 0x0036419C
		public EStatisticsEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EStatisticsEventType.Collect;
				}
				return (EStatisticsEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170072E0 RID: 29408
		// (get) Token: 0x06017914 RID: 96532 RVA: 0x00365FD8 File Offset: 0x003641D8
		public TVarRef VarType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017915 RID: 96533 RVA: 0x00366014 File Offset: 0x00364214
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017916 RID: 96534 RVA: 0x00366058 File Offset: 0x00364258
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x06017917 RID: 96535 RVA: 0x00366074 File Offset: 0x00364274
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x06017918 RID: 96536 RVA: 0x00366090 File Offset: 0x00364290
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x06017919 RID: 96537 RVA: 0x003660AC File Offset: 0x003642AC
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x0601791A RID: 96538 RVA: 0x003660C8 File Offset: 0x003642C8
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x170072E1 RID: 29409
		// (get) Token: 0x0601791B RID: 96539 RVA: 0x003660E4 File Offset: 0x003642E4
		public int ScoreGroupId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601791C RID: 96540 RVA: 0x00366124 File Offset: 0x00364324
		public TMechaTrackScoreDetectionType DetectionTypesType(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return TMechaTrackScoreDetectionType.NONE;
			}
			return (TMechaTrackScoreDetectionType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170072E2 RID: 29410
		// (get) Token: 0x0601791D RID: 96541 RVA: 0x00366164 File Offset: 0x00364364
		public int DetectionTypesTypeLength
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

		// Token: 0x0601791E RID: 96542 RVA: 0x00366190 File Offset: 0x00364390
		public Span<TMechaTrackScoreDetectionType> GetDetectionTypesTypeBytes()
		{
			return this.__p.__vector_as_span<TMechaTrackScoreDetectionType>(12, 1);
		}

		// Token: 0x0601791F RID: 96543 RVA: 0x003661A0 File Offset: 0x003643A0
		public TMechaTrackScoreDetectionType[] GetDetectionTypesTypeArray()
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TMechaTrackScoreDetectionType[] array = new TMechaTrackScoreDetectionType[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TMechaTrackScoreDetectionType)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06017920 RID: 96544 RVA: 0x0036620C File Offset: 0x0036440C
		public TTable? DetectionTypes<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x170072E3 RID: 29411
		// (get) Token: 0x06017921 RID: 96545 RVA: 0x00366254 File Offset: 0x00364454
		public int DetectionTypesLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06017922 RID: 96546 RVA: 0x00366280 File Offset: 0x00364480
		public static Offset<IQuestMechaTrackScore> CreateIQuestMechaTrackScore(FlatBufferBuilder builder, EStatisticsEventType Type = EStatisticsEventType.Collect, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0, int ScoreGroupId = 0, VectorOffset DetectionTypes_typeOffset = default(VectorOffset), VectorOffset DetectionTypesOffset = default(VectorOffset))
		{
			builder.StartTable(6);
			IQuestMechaTrackScore.AddDetectionTypes(builder, DetectionTypesOffset);
			IQuestMechaTrackScore.AddDetectionTypesType(builder, DetectionTypes_typeOffset);
			IQuestMechaTrackScore.AddScoreGroupId(builder, ScoreGroupId);
			IQuestMechaTrackScore.AddVar(builder, VarOffset);
			IQuestMechaTrackScore.AddVarType(builder, Var_type);
			IQuestMechaTrackScore.AddType(builder, Type);
			return IQuestMechaTrackScore.EndIQuestMechaTrackScore(builder);
		}

		// Token: 0x06017923 RID: 96547 RVA: 0x003662BC File Offset: 0x003644BC
		public static void StartIQuestMechaTrackScore(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06017924 RID: 96548 RVA: 0x003662C5 File Offset: 0x003644C5
		public static void AddType(FlatBufferBuilder builder, EStatisticsEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017925 RID: 96549 RVA: 0x003662D0 File Offset: 0x003644D0
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x06017926 RID: 96550 RVA: 0x003662DB File Offset: 0x003644DB
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x06017927 RID: 96551 RVA: 0x003662E6 File Offset: 0x003644E6
		public static void AddScoreGroupId(FlatBufferBuilder builder, int scoreGroupId)
		{
			builder.AddInt(3, scoreGroupId, 0);
		}

		// Token: 0x06017928 RID: 96552 RVA: 0x003662F1 File Offset: 0x003644F1
		public static void AddDetectionTypesType(FlatBufferBuilder builder, VectorOffset detectionTypesTypeOffset)
		{
			builder.AddOffset(4, detectionTypesTypeOffset.Value, 0);
		}

		// Token: 0x06017929 RID: 96553 RVA: 0x00366304 File Offset: 0x00364504
		public static VectorOffset CreateDetectionTypesTypeVector(FlatBufferBuilder builder, TMechaTrackScoreDetectionType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601792A RID: 96554 RVA: 0x0036633B File Offset: 0x0036453B
		public static VectorOffset CreateDetectionTypesTypeVectorBlock(FlatBufferBuilder builder, TMechaTrackScoreDetectionType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TMechaTrackScoreDetectionType>(data);
			return builder.EndVector();
		}

		// Token: 0x0601792B RID: 96555 RVA: 0x00366355 File Offset: 0x00364555
		public static VectorOffset CreateDetectionTypesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TMechaTrackScoreDetectionType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TMechaTrackScoreDetectionType>(data);
			return builder.EndVector();
		}

		// Token: 0x0601792C RID: 96556 RVA: 0x00366373 File Offset: 0x00364573
		public static VectorOffset CreateDetectionTypesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TMechaTrackScoreDetectionType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601792D RID: 96557 RVA: 0x0036638C File Offset: 0x0036458C
		public static void StartDetectionTypesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601792E RID: 96558 RVA: 0x00366397 File Offset: 0x00364597
		public static void AddDetectionTypes(FlatBufferBuilder builder, VectorOffset detectionTypesOffset)
		{
			builder.AddOffset(5, detectionTypesOffset.Value, 0);
		}

		// Token: 0x0601792F RID: 96559 RVA: 0x003663A8 File Offset: 0x003645A8
		public static VectorOffset CreateDetectionTypesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017930 RID: 96560 RVA: 0x003663DF File Offset: 0x003645DF
		public static VectorOffset CreateDetectionTypesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017931 RID: 96561 RVA: 0x003663F9 File Offset: 0x003645F9
		public static VectorOffset CreateDetectionTypesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017932 RID: 96562 RVA: 0x00366417 File Offset: 0x00364617
		public static VectorOffset CreateDetectionTypesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017933 RID: 96563 RVA: 0x00366430 File Offset: 0x00364630
		public static void StartDetectionTypesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017934 RID: 96564 RVA: 0x0036643B File Offset: 0x0036463B
		public static Offset<IQuestMechaTrackScore> EndIQuestMechaTrackScore(FlatBufferBuilder builder)
		{
			return new Offset<IQuestMechaTrackScore>(builder.EndTable());
		}

		// Token: 0x06017935 RID: 96565 RVA: 0x00366448 File Offset: 0x00364648
		public IQuestMechaTrackScoreT UnPack()
		{
			IQuestMechaTrackScoreT questMechaTrackScoreT = new IQuestMechaTrackScoreT();
			this.UnPackTo(questMechaTrackScoreT);
			return questMechaTrackScoreT;
		}

		// Token: 0x06017936 RID: 96566 RVA: 0x00366464 File Offset: 0x00364664
		public void UnPackTo(IQuestMechaTrackScoreT _o)
		{
			_o.Type = this.Type;
			_o.Var = new TVarRefUnion();
			_o.Var.Type = this.VarType;
			switch (this.VarType)
			{
			case TVarRef.IConstVarRef:
				_o.Var.Value = ((this.Var<IConstVarRef>() != null) ? this.Var<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.Var.Value = ((this.Var<IGlobalVarRef>() != null) ? this.Var<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.Var.Value = ((this.Var<IOtherVarRef>() != null) ? this.Var<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.Var.Value = ((this.Var<ISelfVarRef>() != null) ? this.Var<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.Var.Value = ((this.Var<ISystemVarRef>() != null) ? this.Var<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.ScoreGroupId = this.ScoreGroupId;
			_o.DetectionTypes = new List<TMechaTrackScoreDetectionTypeUnion>();
			for (int i = 0; i < this.DetectionTypesLength; i++)
			{
				TMechaTrackScoreDetectionTypeUnion tmechaTrackScoreDetectionTypeUnion = new TMechaTrackScoreDetectionTypeUnion();
				tmechaTrackScoreDetectionTypeUnion.Type = this.DetectionTypesType(i);
				switch (this.DetectionTypesType(i))
				{
				case TMechaTrackScoreDetectionType.IMechaTrackScoreMechanismState:
					tmechaTrackScoreDetectionTypeUnion.Value = ((this.DetectionTypes<IMechaTrackScoreMechanismState>(i) != null) ? this.DetectionTypes<IMechaTrackScoreMechanismState>(i).Value.UnPack() : null);
					break;
				case TMechaTrackScoreDetectionType.IMechaTrackScoreStuntAction:
					tmechaTrackScoreDetectionTypeUnion.Value = ((this.DetectionTypes<IMechaTrackScoreStuntAction>(i) != null) ? this.DetectionTypes<IMechaTrackScoreStuntAction>(i).Value.UnPack() : null);
					break;
				case TMechaTrackScoreDetectionType.IMechaTrackScoreTagDetection:
					tmechaTrackScoreDetectionTypeUnion.Value = ((this.DetectionTypes<IMechaTrackScoreTagDetection>(i) != null) ? this.DetectionTypes<IMechaTrackScoreTagDetection>(i).Value.UnPack() : null);
					break;
				}
				_o.DetectionTypes.Add(tmechaTrackScoreDetectionTypeUnion);
			}
		}

		// Token: 0x06017937 RID: 96567 RVA: 0x00366700 File Offset: 0x00364900
		public static Offset<IQuestMechaTrackScore> Pack(FlatBufferBuilder builder, IQuestMechaTrackScoreT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestMechaTrackScore>);
			}
			TVarRef var_type = (_o.Var == null) ? TVarRef.NONE : _o.Var.Type;
			int varOffset = (_o.Var == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var);
			VectorOffset detectionTypes_typeOffset = default(VectorOffset);
			if (_o.DetectionTypes != null)
			{
				TMechaTrackScoreDetectionType[] array = new TMechaTrackScoreDetectionType[_o.DetectionTypes.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.DetectionTypes[i].Type;
				}
				detectionTypes_typeOffset = IQuestMechaTrackScore.CreateDetectionTypesTypeVector(builder, array);
			}
			VectorOffset detectionTypesOffset = default(VectorOffset);
			if (_o.DetectionTypes != null)
			{
				int[] array2 = new int[_o.DetectionTypes.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TMechaTrackScoreDetectionTypeUnion.Pack(builder, _o.DetectionTypes[j]);
				}
				detectionTypesOffset = IQuestMechaTrackScore.CreateDetectionTypesVector(builder, array2);
			}
			return IQuestMechaTrackScore.CreateIQuestMechaTrackScore(builder, _o.Type, var_type, varOffset, _o.ScoreGroupId, detectionTypes_typeOffset, detectionTypesOffset);
		}

		// Token: 0x0400BAF1 RID: 47857
		private Table __p;
	}
}

using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004430 RID: 17456
	public struct IQuestMechaTrackScore : IFlatbufferObject
	{
		// Token: 0x170078E0 RID: 30944
		// (get) Token: 0x06018FA6 RID: 102310 RVA: 0x0038FD21 File Offset: 0x0038DF21
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018FA7 RID: 102311 RVA: 0x0038FD2E File Offset: 0x0038DF2E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018FA8 RID: 102312 RVA: 0x0038FD38 File Offset: 0x0038DF38
		public static IQuestMechaTrackScore GetRootAsIQuestMechaTrackScore(ByteBuffer _bb)
		{
			return IQuestMechaTrackScore.GetRootAsIQuestMechaTrackScore(_bb, default(IQuestMechaTrackScore));
		}

		// Token: 0x06018FA9 RID: 102313 RVA: 0x0038FD54 File Offset: 0x0038DF54
		public static IQuestMechaTrackScore GetRootAsIQuestMechaTrackScore(ByteBuffer _bb, IQuestMechaTrackScore obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018FAA RID: 102314 RVA: 0x0038FD71 File Offset: 0x0038DF71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018FAB RID: 102315 RVA: 0x0038FD80 File Offset: 0x0038DF80
		public IQuestMechaTrackScore __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170078E1 RID: 30945
		// (get) Token: 0x06018FAC RID: 102316 RVA: 0x0038FD90 File Offset: 0x0038DF90
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

		// Token: 0x170078E2 RID: 30946
		// (get) Token: 0x06018FAD RID: 102317 RVA: 0x0038FDCC File Offset: 0x0038DFCC
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

		// Token: 0x06018FAE RID: 102318 RVA: 0x0038FE08 File Offset: 0x0038E008
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06018FAF RID: 102319 RVA: 0x0038FE4C File Offset: 0x0038E04C
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x06018FB0 RID: 102320 RVA: 0x0038FE68 File Offset: 0x0038E068
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x06018FB1 RID: 102321 RVA: 0x0038FE84 File Offset: 0x0038E084
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x06018FB2 RID: 102322 RVA: 0x0038FEA0 File Offset: 0x0038E0A0
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x06018FB3 RID: 102323 RVA: 0x0038FEBC File Offset: 0x0038E0BC
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x170078E3 RID: 30947
		// (get) Token: 0x06018FB4 RID: 102324 RVA: 0x0038FED8 File Offset: 0x0038E0D8
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

		// Token: 0x06018FB5 RID: 102325 RVA: 0x0038FF18 File Offset: 0x0038E118
		public TMechaTrackScoreDetectionType DetectionTypesType(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return TMechaTrackScoreDetectionType.NONE;
			}
			return (TMechaTrackScoreDetectionType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170078E4 RID: 30948
		// (get) Token: 0x06018FB6 RID: 102326 RVA: 0x0038FF58 File Offset: 0x0038E158
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

		// Token: 0x06018FB7 RID: 102327 RVA: 0x0038FF84 File Offset: 0x0038E184
		public Span<TMechaTrackScoreDetectionType> GetDetectionTypesTypeBytes()
		{
			return this.__p.__vector_as_span<TMechaTrackScoreDetectionType>(12, 1);
		}

		// Token: 0x06018FB8 RID: 102328 RVA: 0x0038FF94 File Offset: 0x0038E194
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

		// Token: 0x06018FB9 RID: 102329 RVA: 0x00390000 File Offset: 0x0038E200
		public TTable? DetectionTypes<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x170078E5 RID: 30949
		// (get) Token: 0x06018FBA RID: 102330 RVA: 0x00390048 File Offset: 0x0038E248
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

		// Token: 0x06018FBB RID: 102331 RVA: 0x00390074 File Offset: 0x0038E274
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

		// Token: 0x06018FBC RID: 102332 RVA: 0x003900B0 File Offset: 0x0038E2B0
		public static void StartIQuestMechaTrackScore(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06018FBD RID: 102333 RVA: 0x003900B9 File Offset: 0x0038E2B9
		public static void AddType(FlatBufferBuilder builder, EStatisticsEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018FBE RID: 102334 RVA: 0x003900C4 File Offset: 0x0038E2C4
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x06018FBF RID: 102335 RVA: 0x003900CF File Offset: 0x0038E2CF
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x06018FC0 RID: 102336 RVA: 0x003900DA File Offset: 0x0038E2DA
		public static void AddScoreGroupId(FlatBufferBuilder builder, int scoreGroupId)
		{
			builder.AddInt(3, scoreGroupId, 0);
		}

		// Token: 0x06018FC1 RID: 102337 RVA: 0x003900E5 File Offset: 0x0038E2E5
		public static void AddDetectionTypesType(FlatBufferBuilder builder, VectorOffset detectionTypesTypeOffset)
		{
			builder.AddOffset(4, detectionTypesTypeOffset.Value, 0);
		}

		// Token: 0x06018FC2 RID: 102338 RVA: 0x003900F8 File Offset: 0x0038E2F8
		public static VectorOffset CreateDetectionTypesTypeVector(FlatBufferBuilder builder, TMechaTrackScoreDetectionType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06018FC3 RID: 102339 RVA: 0x0039012F File Offset: 0x0038E32F
		public static VectorOffset CreateDetectionTypesTypeVectorBlock(FlatBufferBuilder builder, TMechaTrackScoreDetectionType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TMechaTrackScoreDetectionType>(data);
			return builder.EndVector();
		}

		// Token: 0x06018FC4 RID: 102340 RVA: 0x00390149 File Offset: 0x0038E349
		public static VectorOffset CreateDetectionTypesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TMechaTrackScoreDetectionType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TMechaTrackScoreDetectionType>(data);
			return builder.EndVector();
		}

		// Token: 0x06018FC5 RID: 102341 RVA: 0x00390167 File Offset: 0x0038E367
		public static VectorOffset CreateDetectionTypesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TMechaTrackScoreDetectionType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018FC6 RID: 102342 RVA: 0x00390180 File Offset: 0x0038E380
		public static void StartDetectionTypesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06018FC7 RID: 102343 RVA: 0x0039018B File Offset: 0x0038E38B
		public static void AddDetectionTypes(FlatBufferBuilder builder, VectorOffset detectionTypesOffset)
		{
			builder.AddOffset(5, detectionTypesOffset.Value, 0);
		}

		// Token: 0x06018FC8 RID: 102344 RVA: 0x0039019C File Offset: 0x0038E39C
		public static VectorOffset CreateDetectionTypesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06018FC9 RID: 102345 RVA: 0x003901D3 File Offset: 0x0038E3D3
		public static VectorOffset CreateDetectionTypesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018FCA RID: 102346 RVA: 0x003901ED File Offset: 0x0038E3ED
		public static VectorOffset CreateDetectionTypesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018FCB RID: 102347 RVA: 0x0039020B File Offset: 0x0038E40B
		public static VectorOffset CreateDetectionTypesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018FCC RID: 102348 RVA: 0x00390224 File Offset: 0x0038E424
		public static void StartDetectionTypesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018FCD RID: 102349 RVA: 0x0039022F File Offset: 0x0038E42F
		public static Offset<IQuestMechaTrackScore> EndIQuestMechaTrackScore(FlatBufferBuilder builder)
		{
			return new Offset<IQuestMechaTrackScore>(builder.EndTable());
		}

		// Token: 0x06018FCE RID: 102350 RVA: 0x0039023C File Offset: 0x0038E43C
		public IQuestMechaTrackScoreT UnPack()
		{
			IQuestMechaTrackScoreT questMechaTrackScoreT = new IQuestMechaTrackScoreT();
			this.UnPackTo(questMechaTrackScoreT);
			return questMechaTrackScoreT;
		}

		// Token: 0x06018FCF RID: 102351 RVA: 0x00390258 File Offset: 0x0038E458
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

		// Token: 0x06018FD0 RID: 102352 RVA: 0x003904F4 File Offset: 0x0038E6F4
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

		// Token: 0x0400C4D8 RID: 50392
		private Table __p;
	}
}

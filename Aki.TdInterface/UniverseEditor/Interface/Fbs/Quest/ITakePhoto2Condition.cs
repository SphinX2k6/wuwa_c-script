using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200417B RID: 16763
	public struct ITakePhoto2Condition : IFlatbufferObject
	{
		// Token: 0x170076B2 RID: 30386
		// (get) Token: 0x060189FB RID: 100859 RVA: 0x0038BD02 File Offset: 0x00389F02
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060189FC RID: 100860 RVA: 0x0038BD0F File Offset: 0x00389F0F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060189FD RID: 100861 RVA: 0x0038BD18 File Offset: 0x00389F18
		public static ITakePhoto2Condition GetRootAsITakePhoto2Condition(ByteBuffer _bb)
		{
			return ITakePhoto2Condition.GetRootAsITakePhoto2Condition(_bb, default(ITakePhoto2Condition));
		}

		// Token: 0x060189FE RID: 100862 RVA: 0x0038BD34 File Offset: 0x00389F34
		public static ITakePhoto2Condition GetRootAsITakePhoto2Condition(ByteBuffer _bb, ITakePhoto2Condition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060189FF RID: 100863 RVA: 0x0038BD51 File Offset: 0x00389F51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018A00 RID: 100864 RVA: 0x0038BD60 File Offset: 0x00389F60
		public ITakePhoto2Condition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170076B3 RID: 30387
		// (get) Token: 0x06018A01 RID: 100865 RVA: 0x0038BD70 File Offset: 0x00389F70
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170076B4 RID: 30388
		// (get) Token: 0x06018A02 RID: 100866 RVA: 0x0038BDAC File Offset: 0x00389FAC
		public IConditionGroup? PreConditions
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170076B5 RID: 30389
		// (get) Token: 0x06018A03 RID: 100867 RVA: 0x0038BE0C File Offset: 0x0038A00C
		public string TidConditionDescription
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

		// Token: 0x06018A04 RID: 100868 RVA: 0x0038BE43 File Offset: 0x0038A043
		public Span<byte> GetTidConditionDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06018A05 RID: 100869 RVA: 0x0038BE52 File Offset: 0x0038A052
		public byte[] GetTidConditionDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x170076B6 RID: 30390
		// (get) Token: 0x06018A06 RID: 100870 RVA: 0x0038BE60 File Offset: 0x0038A060
		public string TargetPreviewImagePath
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018A07 RID: 100871 RVA: 0x0038BE98 File Offset: 0x0038A098
		public Span<byte> GetTargetPreviewImagePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06018A08 RID: 100872 RVA: 0x0038BEA8 File Offset: 0x0038A0A8
		public byte[] GetTargetPreviewImagePathArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x170076B7 RID: 30391
		// (get) Token: 0x06018A09 RID: 100873 RVA: 0x0038BEB8 File Offset: 0x0038A0B8
		public ITakePhoto2TimeCondition? TimeCondition
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new ITakePhoto2TimeCondition?(default(ITakePhoto2TimeCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170076B8 RID: 30392
		// (get) Token: 0x06018A0A RID: 100874 RVA: 0x0038BF18 File Offset: 0x0038A118
		public ITakePhoto2PosCondition? PosCondition
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new ITakePhoto2PosCondition?(default(ITakePhoto2PosCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170076B9 RID: 30393
		// (get) Token: 0x06018A0B RID: 100875 RVA: 0x0038BF78 File Offset: 0x0038A178
		public ITakePhoto2CameraFovCondition? FovCondition
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new ITakePhoto2CameraFovCondition?(default(ITakePhoto2CameraFovCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170076BA RID: 30394
		// (get) Token: 0x06018A0C RID: 100876 RVA: 0x0038BFD8 File Offset: 0x0038A1D8
		public ITakePhoto2SequenceCondition? SequenceCondition
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new ITakePhoto2SequenceCondition?(default(ITakePhoto2SequenceCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170076BB RID: 30395
		// (get) Token: 0x06018A0D RID: 100877 RVA: 0x0038C038 File Offset: 0x0038A238
		public string BoundCameraSeqPath
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018A0E RID: 100878 RVA: 0x0038C070 File Offset: 0x0038A270
		public Span<byte> GetBoundCameraSeqPathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06018A0F RID: 100879 RVA: 0x0038C080 File Offset: 0x0038A280
		public byte[] GetBoundCameraSeqPathArray()
		{
			return this.__p.__vector_as_array<byte>(20);
		}

		// Token: 0x06018A10 RID: 100880 RVA: 0x0038C090 File Offset: 0x0038A290
		public TTakePhoto2TargetConfig PhotoTargetsType(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return TTakePhoto2TargetConfig.NONE;
			}
			return (TTakePhoto2TargetConfig)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170076BC RID: 30396
		// (get) Token: 0x06018A11 RID: 100881 RVA: 0x0038C0D0 File Offset: 0x0038A2D0
		public int PhotoTargetsTypeLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06018A12 RID: 100882 RVA: 0x0038C0FC File Offset: 0x0038A2FC
		public Span<TTakePhoto2TargetConfig> GetPhotoTargetsTypeBytes()
		{
			return this.__p.__vector_as_span<TTakePhoto2TargetConfig>(22, 1);
		}

		// Token: 0x06018A13 RID: 100883 RVA: 0x0038C10C File Offset: 0x0038A30C
		public TTakePhoto2TargetConfig[] GetPhotoTargetsTypeArray()
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TTakePhoto2TargetConfig[] array = new TTakePhoto2TargetConfig[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TTakePhoto2TargetConfig)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06018A14 RID: 100884 RVA: 0x0038C178 File Offset: 0x0038A378
		public TTable? PhotoTargets<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x170076BD RID: 30397
		// (get) Token: 0x06018A15 RID: 100885 RVA: 0x0038C1C0 File Offset: 0x0038A3C0
		public int PhotoTargetsLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06018A16 RID: 100886 RVA: 0x0038C1EC File Offset: 0x0038A3EC
		public static Offset<ITakePhoto2Condition> CreateITakePhoto2Condition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), StringOffset TidConditionDescriptionOffset = default(StringOffset), StringOffset TargetPreviewImagePathOffset = default(StringOffset), Offset<ITakePhoto2TimeCondition> TimeConditionOffset = default(Offset<ITakePhoto2TimeCondition>), Offset<ITakePhoto2PosCondition> PosConditionOffset = default(Offset<ITakePhoto2PosCondition>), Offset<ITakePhoto2CameraFovCondition> FovConditionOffset = default(Offset<ITakePhoto2CameraFovCondition>), Offset<ITakePhoto2SequenceCondition> SequenceConditionOffset = default(Offset<ITakePhoto2SequenceCondition>), StringOffset BoundCameraSeqPathOffset = default(StringOffset), VectorOffset PhotoTargets_typeOffset = default(VectorOffset), VectorOffset PhotoTargetsOffset = default(VectorOffset))
		{
			builder.StartTable(11);
			ITakePhoto2Condition.AddPhotoTargets(builder, PhotoTargetsOffset);
			ITakePhoto2Condition.AddPhotoTargetsType(builder, PhotoTargets_typeOffset);
			ITakePhoto2Condition.AddBoundCameraSeqPath(builder, BoundCameraSeqPathOffset);
			ITakePhoto2Condition.AddSequenceCondition(builder, SequenceConditionOffset);
			ITakePhoto2Condition.AddFovCondition(builder, FovConditionOffset);
			ITakePhoto2Condition.AddPosCondition(builder, PosConditionOffset);
			ITakePhoto2Condition.AddTimeCondition(builder, TimeConditionOffset);
			ITakePhoto2Condition.AddTargetPreviewImagePath(builder, TargetPreviewImagePathOffset);
			ITakePhoto2Condition.AddTidConditionDescription(builder, TidConditionDescriptionOffset);
			ITakePhoto2Condition.AddPreConditions(builder, PreConditionsOffset);
			ITakePhoto2Condition.AddType(builder, Type);
			return ITakePhoto2Condition.EndITakePhoto2Condition(builder);
		}

		// Token: 0x06018A17 RID: 100887 RVA: 0x0038C25C File Offset: 0x0038A45C
		public static void StartITakePhoto2Condition(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x06018A18 RID: 100888 RVA: 0x0038C266 File Offset: 0x0038A466
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018A19 RID: 100889 RVA: 0x0038C271 File Offset: 0x0038A471
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06018A1A RID: 100890 RVA: 0x0038C281 File Offset: 0x0038A481
		public static void AddTidConditionDescription(FlatBufferBuilder builder, StringOffset tidConditionDescriptionOffset)
		{
			builder.AddOffset(2, tidConditionDescriptionOffset.Value, 0);
		}

		// Token: 0x06018A1B RID: 100891 RVA: 0x0038C291 File Offset: 0x0038A491
		public static void AddTargetPreviewImagePath(FlatBufferBuilder builder, StringOffset targetPreviewImagePathOffset)
		{
			builder.AddOffset(3, targetPreviewImagePathOffset.Value, 0);
		}

		// Token: 0x06018A1C RID: 100892 RVA: 0x0038C2A1 File Offset: 0x0038A4A1
		public static void AddTimeCondition(FlatBufferBuilder builder, Offset<ITakePhoto2TimeCondition> timeConditionOffset)
		{
			builder.AddOffset(4, timeConditionOffset.Value, 0);
		}

		// Token: 0x06018A1D RID: 100893 RVA: 0x0038C2B1 File Offset: 0x0038A4B1
		public static void AddPosCondition(FlatBufferBuilder builder, Offset<ITakePhoto2PosCondition> posConditionOffset)
		{
			builder.AddOffset(5, posConditionOffset.Value, 0);
		}

		// Token: 0x06018A1E RID: 100894 RVA: 0x0038C2C1 File Offset: 0x0038A4C1
		public static void AddFovCondition(FlatBufferBuilder builder, Offset<ITakePhoto2CameraFovCondition> fovConditionOffset)
		{
			builder.AddOffset(6, fovConditionOffset.Value, 0);
		}

		// Token: 0x06018A1F RID: 100895 RVA: 0x0038C2D1 File Offset: 0x0038A4D1
		public static void AddSequenceCondition(FlatBufferBuilder builder, Offset<ITakePhoto2SequenceCondition> sequenceConditionOffset)
		{
			builder.AddOffset(7, sequenceConditionOffset.Value, 0);
		}

		// Token: 0x06018A20 RID: 100896 RVA: 0x0038C2E1 File Offset: 0x0038A4E1
		public static void AddBoundCameraSeqPath(FlatBufferBuilder builder, StringOffset boundCameraSeqPathOffset)
		{
			builder.AddOffset(8, boundCameraSeqPathOffset.Value, 0);
		}

		// Token: 0x06018A21 RID: 100897 RVA: 0x0038C2F1 File Offset: 0x0038A4F1
		public static void AddPhotoTargetsType(FlatBufferBuilder builder, VectorOffset photoTargetsTypeOffset)
		{
			builder.AddOffset(9, photoTargetsTypeOffset.Value, 0);
		}

		// Token: 0x06018A22 RID: 100898 RVA: 0x0038C304 File Offset: 0x0038A504
		public static VectorOffset CreatePhotoTargetsTypeVector(FlatBufferBuilder builder, TTakePhoto2TargetConfig[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06018A23 RID: 100899 RVA: 0x0038C33B File Offset: 0x0038A53B
		public static VectorOffset CreatePhotoTargetsTypeVectorBlock(FlatBufferBuilder builder, TTakePhoto2TargetConfig[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TTakePhoto2TargetConfig>(data);
			return builder.EndVector();
		}

		// Token: 0x06018A24 RID: 100900 RVA: 0x0038C355 File Offset: 0x0038A555
		public static VectorOffset CreatePhotoTargetsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TTakePhoto2TargetConfig> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TTakePhoto2TargetConfig>(data);
			return builder.EndVector();
		}

		// Token: 0x06018A25 RID: 100901 RVA: 0x0038C373 File Offset: 0x0038A573
		public static VectorOffset CreatePhotoTargetsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TTakePhoto2TargetConfig>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018A26 RID: 100902 RVA: 0x0038C38C File Offset: 0x0038A58C
		public static void StartPhotoTargetsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06018A27 RID: 100903 RVA: 0x0038C397 File Offset: 0x0038A597
		public static void AddPhotoTargets(FlatBufferBuilder builder, VectorOffset photoTargetsOffset)
		{
			builder.AddOffset(10, photoTargetsOffset.Value, 0);
		}

		// Token: 0x06018A28 RID: 100904 RVA: 0x0038C3A8 File Offset: 0x0038A5A8
		public static VectorOffset CreatePhotoTargetsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06018A29 RID: 100905 RVA: 0x0038C3DF File Offset: 0x0038A5DF
		public static VectorOffset CreatePhotoTargetsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018A2A RID: 100906 RVA: 0x0038C3F9 File Offset: 0x0038A5F9
		public static VectorOffset CreatePhotoTargetsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018A2B RID: 100907 RVA: 0x0038C417 File Offset: 0x0038A617
		public static VectorOffset CreatePhotoTargetsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018A2C RID: 100908 RVA: 0x0038C430 File Offset: 0x0038A630
		public static void StartPhotoTargetsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018A2D RID: 100909 RVA: 0x0038C43B File Offset: 0x0038A63B
		public static Offset<ITakePhoto2Condition> EndITakePhoto2Condition(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2Condition>(builder.EndTable());
		}

		// Token: 0x06018A2E RID: 100910 RVA: 0x0038C448 File Offset: 0x0038A648
		public ITakePhoto2ConditionT UnPack()
		{
			ITakePhoto2ConditionT takePhoto2ConditionT = new ITakePhoto2ConditionT();
			this.UnPackTo(takePhoto2ConditionT);
			return takePhoto2ConditionT;
		}

		// Token: 0x06018A2F RID: 100911 RVA: 0x0038C464 File Offset: 0x0038A664
		public void UnPackTo(ITakePhoto2ConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.TidConditionDescription = this.TidConditionDescription;
			_o.TargetPreviewImagePath = this.TargetPreviewImagePath;
			_o.TimeCondition = ((this.TimeCondition != null) ? this.TimeCondition.Value.UnPack() : null);
			_o.PosCondition = ((this.PosCondition != null) ? this.PosCondition.Value.UnPack() : null);
			_o.FovCondition = ((this.FovCondition != null) ? this.FovCondition.Value.UnPack() : null);
			_o.SequenceCondition = ((this.SequenceCondition != null) ? this.SequenceCondition.Value.UnPack() : null);
			_o.BoundCameraSeqPath = this.BoundCameraSeqPath;
			_o.PhotoTargets = new List<TTakePhoto2TargetConfigUnion>();
			for (int i = 0; i < this.PhotoTargetsLength; i++)
			{
				TTakePhoto2TargetConfigUnion ttakePhoto2TargetConfigUnion = new TTakePhoto2TargetConfigUnion();
				ttakePhoto2TargetConfigUnion.Type = this.PhotoTargetsType(i);
				switch (this.PhotoTargetsType(i))
				{
				case TTakePhoto2TargetConfig.ITakePhoto2EntityTarget:
					ttakePhoto2TargetConfigUnion.Value = ((this.PhotoTargets<ITakePhoto2EntityTarget>(i) != null) ? this.PhotoTargets<ITakePhoto2EntityTarget>(i).Value.UnPack() : null);
					break;
				case TTakePhoto2TargetConfig.ITakePhoto2PhotoTargetEntityTarget:
					ttakePhoto2TargetConfigUnion.Value = ((this.PhotoTargets<ITakePhoto2PhotoTargetEntityTarget>(i) != null) ? this.PhotoTargets<ITakePhoto2PhotoTargetEntityTarget>(i).Value.UnPack() : null);
					break;
				case TTakePhoto2TargetConfig.ITakePhoto2TaggedActorTarget:
					ttakePhoto2TargetConfigUnion.Value = ((this.PhotoTargets<ITakePhoto2TaggedActorTarget>(i) != null) ? this.PhotoTargets<ITakePhoto2TaggedActorTarget>(i).Value.UnPack() : null);
					break;
				case TTakePhoto2TargetConfig.ITakePhoto2TargetEntityType:
					ttakePhoto2TargetConfigUnion.Value = ((this.PhotoTargets<ITakePhoto2TargetEntityType>(i) != null) ? this.PhotoTargets<ITakePhoto2TargetEntityType>(i).Value.UnPack() : null);
					break;
				}
				_o.PhotoTargets.Add(ttakePhoto2TargetConfigUnion);
			}
		}

		// Token: 0x06018A30 RID: 100912 RVA: 0x0038C6EC File Offset: 0x0038A8EC
		public static Offset<ITakePhoto2Condition> Pack(FlatBufferBuilder builder, ITakePhoto2ConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhoto2Condition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			StringOffset tidConditionDescriptionOffset = (_o.TidConditionDescription == null) ? default(StringOffset) : builder.CreateString(_o.TidConditionDescription);
			StringOffset targetPreviewImagePathOffset = (_o.TargetPreviewImagePath == null) ? default(StringOffset) : builder.CreateString(_o.TargetPreviewImagePath);
			Offset<ITakePhoto2TimeCondition> timeConditionOffset = (_o.TimeCondition == null) ? default(Offset<ITakePhoto2TimeCondition>) : ITakePhoto2TimeCondition.Pack(builder, _o.TimeCondition);
			Offset<ITakePhoto2PosCondition> posConditionOffset = (_o.PosCondition == null) ? default(Offset<ITakePhoto2PosCondition>) : ITakePhoto2PosCondition.Pack(builder, _o.PosCondition);
			Offset<ITakePhoto2CameraFovCondition> fovConditionOffset = (_o.FovCondition == null) ? default(Offset<ITakePhoto2CameraFovCondition>) : ITakePhoto2CameraFovCondition.Pack(builder, _o.FovCondition);
			Offset<ITakePhoto2SequenceCondition> sequenceConditionOffset = (_o.SequenceCondition == null) ? default(Offset<ITakePhoto2SequenceCondition>) : ITakePhoto2SequenceCondition.Pack(builder, _o.SequenceCondition);
			StringOffset boundCameraSeqPathOffset = (_o.BoundCameraSeqPath == null) ? default(StringOffset) : builder.CreateString(_o.BoundCameraSeqPath);
			VectorOffset photoTargets_typeOffset = default(VectorOffset);
			if (_o.PhotoTargets != null)
			{
				TTakePhoto2TargetConfig[] array = new TTakePhoto2TargetConfig[_o.PhotoTargets.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.PhotoTargets[i].Type;
				}
				photoTargets_typeOffset = ITakePhoto2Condition.CreatePhotoTargetsTypeVector(builder, array);
			}
			VectorOffset photoTargetsOffset = default(VectorOffset);
			if (_o.PhotoTargets != null)
			{
				int[] array2 = new int[_o.PhotoTargets.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TTakePhoto2TargetConfigUnion.Pack(builder, _o.PhotoTargets[j]);
				}
				photoTargetsOffset = ITakePhoto2Condition.CreatePhotoTargetsVector(builder, array2);
			}
			return ITakePhoto2Condition.CreateITakePhoto2Condition(builder, _o.Type, preConditionsOffset, tidConditionDescriptionOffset, targetPreviewImagePathOffset, timeConditionOffset, posConditionOffset, fovConditionOffset, sequenceConditionOffset, boundCameraSeqPathOffset, photoTargets_typeOffset, photoTargetsOffset);
		}

		// Token: 0x0400BD98 RID: 48536
		private Table __p;
	}
}

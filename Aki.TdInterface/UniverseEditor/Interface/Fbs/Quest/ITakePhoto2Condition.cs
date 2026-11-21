using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045C5 RID: 17861
	public struct ITakePhoto2Condition : IFlatbufferObject
	{
		// Token: 0x17007CC9 RID: 31945
		// (get) Token: 0x0601A0EF RID: 106735 RVA: 0x003B67B1 File Offset: 0x003B49B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A0F0 RID: 106736 RVA: 0x003B67BE File Offset: 0x003B49BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A0F1 RID: 106737 RVA: 0x003B67C8 File Offset: 0x003B49C8
		public static ITakePhoto2Condition GetRootAsITakePhoto2Condition(ByteBuffer _bb)
		{
			return ITakePhoto2Condition.GetRootAsITakePhoto2Condition(_bb, default(ITakePhoto2Condition));
		}

		// Token: 0x0601A0F2 RID: 106738 RVA: 0x003B67E4 File Offset: 0x003B49E4
		public static ITakePhoto2Condition GetRootAsITakePhoto2Condition(ByteBuffer _bb, ITakePhoto2Condition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A0F3 RID: 106739 RVA: 0x003B6801 File Offset: 0x003B4A01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A0F4 RID: 106740 RVA: 0x003B6810 File Offset: 0x003B4A10
		public ITakePhoto2Condition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007CCA RID: 31946
		// (get) Token: 0x0601A0F5 RID: 106741 RVA: 0x003B6820 File Offset: 0x003B4A20
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

		// Token: 0x17007CCB RID: 31947
		// (get) Token: 0x0601A0F6 RID: 106742 RVA: 0x003B685C File Offset: 0x003B4A5C
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

		// Token: 0x17007CCC RID: 31948
		// (get) Token: 0x0601A0F7 RID: 106743 RVA: 0x003B68BC File Offset: 0x003B4ABC
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

		// Token: 0x0601A0F8 RID: 106744 RVA: 0x003B68F3 File Offset: 0x003B4AF3
		public Span<byte> GetTidConditionDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601A0F9 RID: 106745 RVA: 0x003B6902 File Offset: 0x003B4B02
		public byte[] GetTidConditionDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17007CCD RID: 31949
		// (get) Token: 0x0601A0FA RID: 106746 RVA: 0x003B6910 File Offset: 0x003B4B10
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

		// Token: 0x0601A0FB RID: 106747 RVA: 0x003B6948 File Offset: 0x003B4B48
		public Span<byte> GetTargetPreviewImagePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601A0FC RID: 106748 RVA: 0x003B6958 File Offset: 0x003B4B58
		public byte[] GetTargetPreviewImagePathArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17007CCE RID: 31950
		// (get) Token: 0x0601A0FD RID: 106749 RVA: 0x003B6968 File Offset: 0x003B4B68
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

		// Token: 0x17007CCF RID: 31951
		// (get) Token: 0x0601A0FE RID: 106750 RVA: 0x003B69C8 File Offset: 0x003B4BC8
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

		// Token: 0x17007CD0 RID: 31952
		// (get) Token: 0x0601A0FF RID: 106751 RVA: 0x003B6A28 File Offset: 0x003B4C28
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

		// Token: 0x17007CD1 RID: 31953
		// (get) Token: 0x0601A100 RID: 106752 RVA: 0x003B6A88 File Offset: 0x003B4C88
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

		// Token: 0x17007CD2 RID: 31954
		// (get) Token: 0x0601A101 RID: 106753 RVA: 0x003B6AE8 File Offset: 0x003B4CE8
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

		// Token: 0x0601A102 RID: 106754 RVA: 0x003B6B20 File Offset: 0x003B4D20
		public Span<byte> GetBoundCameraSeqPathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0601A103 RID: 106755 RVA: 0x003B6B30 File Offset: 0x003B4D30
		public byte[] GetBoundCameraSeqPathArray()
		{
			return this.__p.__vector_as_array<byte>(20);
		}

		// Token: 0x17007CD3 RID: 31955
		// (get) Token: 0x0601A104 RID: 106756 RVA: 0x003B6B40 File Offset: 0x003B4D40
		public string BackgroundImagePath
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A105 RID: 106757 RVA: 0x003B6B78 File Offset: 0x003B4D78
		public Span<byte> GetBackgroundImagePathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0601A106 RID: 106758 RVA: 0x003B6B88 File Offset: 0x003B4D88
		public byte[] GetBackgroundImagePathArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x0601A107 RID: 106759 RVA: 0x003B6B98 File Offset: 0x003B4D98
		public TTakePhoto2TargetConfig PhotoTargetsType(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return TTakePhoto2TargetConfig.NONE;
			}
			return (TTakePhoto2TargetConfig)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007CD4 RID: 31956
		// (get) Token: 0x0601A108 RID: 106760 RVA: 0x003B6BD8 File Offset: 0x003B4DD8
		public int PhotoTargetsTypeLength
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

		// Token: 0x0601A109 RID: 106761 RVA: 0x003B6C04 File Offset: 0x003B4E04
		public Span<TTakePhoto2TargetConfig> GetPhotoTargetsTypeBytes()
		{
			return this.__p.__vector_as_span<TTakePhoto2TargetConfig>(24, 1);
		}

		// Token: 0x0601A10A RID: 106762 RVA: 0x003B6C14 File Offset: 0x003B4E14
		public TTakePhoto2TargetConfig[] GetPhotoTargetsTypeArray()
		{
			int num = this.__p.__offset(24);
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

		// Token: 0x0601A10B RID: 106763 RVA: 0x003B6C80 File Offset: 0x003B4E80
		public TTable? PhotoTargets<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007CD5 RID: 31957
		// (get) Token: 0x0601A10C RID: 106764 RVA: 0x003B6CC8 File Offset: 0x003B4EC8
		public int PhotoTargetsLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17007CD6 RID: 31958
		// (get) Token: 0x0601A10D RID: 106765 RVA: 0x003B6CF4 File Offset: 0x003B4EF4
		public ITakePhoto2BeforeYourEyesMode? PhotoMode
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return new ITakePhoto2BeforeYourEyesMode?(default(ITakePhoto2BeforeYourEyesMode).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007CD7 RID: 31959
		// (get) Token: 0x0601A10E RID: 106766 RVA: 0x003B6D54 File Offset: 0x003B4F54
		public bool CanDetectWhenNotTracking
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007CD8 RID: 31960
		// (get) Token: 0x0601A10F RID: 106767 RVA: 0x003B6D94 File Offset: 0x003B4F94
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A110 RID: 106768 RVA: 0x003B6DD4 File Offset: 0x003B4FD4
		public static Offset<ITakePhoto2Condition> CreateITakePhoto2Condition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), StringOffset TidConditionDescriptionOffset = default(StringOffset), StringOffset TargetPreviewImagePathOffset = default(StringOffset), Offset<ITakePhoto2TimeCondition> TimeConditionOffset = default(Offset<ITakePhoto2TimeCondition>), Offset<ITakePhoto2PosCondition> PosConditionOffset = default(Offset<ITakePhoto2PosCondition>), Offset<ITakePhoto2CameraFovCondition> FovConditionOffset = default(Offset<ITakePhoto2CameraFovCondition>), Offset<ITakePhoto2SequenceCondition> SequenceConditionOffset = default(Offset<ITakePhoto2SequenceCondition>), StringOffset BoundCameraSeqPathOffset = default(StringOffset), StringOffset BackgroundImagePathOffset = default(StringOffset), VectorOffset PhotoTargets_typeOffset = default(VectorOffset), VectorOffset PhotoTargetsOffset = default(VectorOffset), Offset<ITakePhoto2BeforeYourEyesMode> PhotoModeOffset = default(Offset<ITakePhoto2BeforeYourEyesMode>), bool CanDetectWhenNotTracking = false, byte NullMask = 0)
		{
			builder.StartTable(15);
			ITakePhoto2Condition.AddPhotoMode(builder, PhotoModeOffset);
			ITakePhoto2Condition.AddPhotoTargets(builder, PhotoTargetsOffset);
			ITakePhoto2Condition.AddPhotoTargetsType(builder, PhotoTargets_typeOffset);
			ITakePhoto2Condition.AddBackgroundImagePath(builder, BackgroundImagePathOffset);
			ITakePhoto2Condition.AddBoundCameraSeqPath(builder, BoundCameraSeqPathOffset);
			ITakePhoto2Condition.AddSequenceCondition(builder, SequenceConditionOffset);
			ITakePhoto2Condition.AddFovCondition(builder, FovConditionOffset);
			ITakePhoto2Condition.AddPosCondition(builder, PosConditionOffset);
			ITakePhoto2Condition.AddTimeCondition(builder, TimeConditionOffset);
			ITakePhoto2Condition.AddTargetPreviewImagePath(builder, TargetPreviewImagePathOffset);
			ITakePhoto2Condition.AddTidConditionDescription(builder, TidConditionDescriptionOffset);
			ITakePhoto2Condition.AddPreConditions(builder, PreConditionsOffset);
			ITakePhoto2Condition.AddNullMask(builder, NullMask);
			ITakePhoto2Condition.AddCanDetectWhenNotTracking(builder, CanDetectWhenNotTracking);
			ITakePhoto2Condition.AddType(builder, Type);
			return ITakePhoto2Condition.EndITakePhoto2Condition(builder);
		}

		// Token: 0x0601A111 RID: 106769 RVA: 0x003B6E64 File Offset: 0x003B5064
		public static void StartITakePhoto2Condition(FlatBufferBuilder builder)
		{
			builder.StartTable(15);
		}

		// Token: 0x0601A112 RID: 106770 RVA: 0x003B6E6E File Offset: 0x003B506E
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A113 RID: 106771 RVA: 0x003B6E79 File Offset: 0x003B5079
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x0601A114 RID: 106772 RVA: 0x003B6E89 File Offset: 0x003B5089
		public static void AddTidConditionDescription(FlatBufferBuilder builder, StringOffset tidConditionDescriptionOffset)
		{
			builder.AddOffset(2, tidConditionDescriptionOffset.Value, 0);
		}

		// Token: 0x0601A115 RID: 106773 RVA: 0x003B6E99 File Offset: 0x003B5099
		public static void AddTargetPreviewImagePath(FlatBufferBuilder builder, StringOffset targetPreviewImagePathOffset)
		{
			builder.AddOffset(3, targetPreviewImagePathOffset.Value, 0);
		}

		// Token: 0x0601A116 RID: 106774 RVA: 0x003B6EA9 File Offset: 0x003B50A9
		public static void AddTimeCondition(FlatBufferBuilder builder, Offset<ITakePhoto2TimeCondition> timeConditionOffset)
		{
			builder.AddOffset(4, timeConditionOffset.Value, 0);
		}

		// Token: 0x0601A117 RID: 106775 RVA: 0x003B6EB9 File Offset: 0x003B50B9
		public static void AddPosCondition(FlatBufferBuilder builder, Offset<ITakePhoto2PosCondition> posConditionOffset)
		{
			builder.AddOffset(5, posConditionOffset.Value, 0);
		}

		// Token: 0x0601A118 RID: 106776 RVA: 0x003B6EC9 File Offset: 0x003B50C9
		public static void AddFovCondition(FlatBufferBuilder builder, Offset<ITakePhoto2CameraFovCondition> fovConditionOffset)
		{
			builder.AddOffset(6, fovConditionOffset.Value, 0);
		}

		// Token: 0x0601A119 RID: 106777 RVA: 0x003B6ED9 File Offset: 0x003B50D9
		public static void AddSequenceCondition(FlatBufferBuilder builder, Offset<ITakePhoto2SequenceCondition> sequenceConditionOffset)
		{
			builder.AddOffset(7, sequenceConditionOffset.Value, 0);
		}

		// Token: 0x0601A11A RID: 106778 RVA: 0x003B6EE9 File Offset: 0x003B50E9
		public static void AddBoundCameraSeqPath(FlatBufferBuilder builder, StringOffset boundCameraSeqPathOffset)
		{
			builder.AddOffset(8, boundCameraSeqPathOffset.Value, 0);
		}

		// Token: 0x0601A11B RID: 106779 RVA: 0x003B6EF9 File Offset: 0x003B50F9
		public static void AddBackgroundImagePath(FlatBufferBuilder builder, StringOffset backgroundImagePathOffset)
		{
			builder.AddOffset(9, backgroundImagePathOffset.Value, 0);
		}

		// Token: 0x0601A11C RID: 106780 RVA: 0x003B6F0A File Offset: 0x003B510A
		public static void AddPhotoTargetsType(FlatBufferBuilder builder, VectorOffset photoTargetsTypeOffset)
		{
			builder.AddOffset(10, photoTargetsTypeOffset.Value, 0);
		}

		// Token: 0x0601A11D RID: 106781 RVA: 0x003B6F1C File Offset: 0x003B511C
		public static VectorOffset CreatePhotoTargetsTypeVector(FlatBufferBuilder builder, TTakePhoto2TargetConfig[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A11E RID: 106782 RVA: 0x003B6F53 File Offset: 0x003B5153
		public static VectorOffset CreatePhotoTargetsTypeVectorBlock(FlatBufferBuilder builder, TTakePhoto2TargetConfig[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TTakePhoto2TargetConfig>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A11F RID: 106783 RVA: 0x003B6F6D File Offset: 0x003B516D
		public static VectorOffset CreatePhotoTargetsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TTakePhoto2TargetConfig> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TTakePhoto2TargetConfig>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A120 RID: 106784 RVA: 0x003B6F8B File Offset: 0x003B518B
		public static VectorOffset CreatePhotoTargetsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TTakePhoto2TargetConfig>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A121 RID: 106785 RVA: 0x003B6FA4 File Offset: 0x003B51A4
		public static void StartPhotoTargetsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601A122 RID: 106786 RVA: 0x003B6FAF File Offset: 0x003B51AF
		public static void AddPhotoTargets(FlatBufferBuilder builder, VectorOffset photoTargetsOffset)
		{
			builder.AddOffset(11, photoTargetsOffset.Value, 0);
		}

		// Token: 0x0601A123 RID: 106787 RVA: 0x003B6FC0 File Offset: 0x003B51C0
		public static VectorOffset CreatePhotoTargetsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A124 RID: 106788 RVA: 0x003B6FF7 File Offset: 0x003B51F7
		public static VectorOffset CreatePhotoTargetsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A125 RID: 106789 RVA: 0x003B7011 File Offset: 0x003B5211
		public static VectorOffset CreatePhotoTargetsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A126 RID: 106790 RVA: 0x003B702F File Offset: 0x003B522F
		public static VectorOffset CreatePhotoTargetsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A127 RID: 106791 RVA: 0x003B7048 File Offset: 0x003B5248
		public static void StartPhotoTargetsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A128 RID: 106792 RVA: 0x003B7053 File Offset: 0x003B5253
		public static void AddPhotoMode(FlatBufferBuilder builder, Offset<ITakePhoto2BeforeYourEyesMode> photoModeOffset)
		{
			builder.AddOffset(12, photoModeOffset.Value, 0);
		}

		// Token: 0x0601A129 RID: 106793 RVA: 0x003B7064 File Offset: 0x003B5264
		public static void AddCanDetectWhenNotTracking(FlatBufferBuilder builder, bool canDetectWhenNotTracking)
		{
			builder.AddBool(13, canDetectWhenNotTracking, false);
		}

		// Token: 0x0601A12A RID: 106794 RVA: 0x003B7070 File Offset: 0x003B5270
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(14, nullMask, 0);
		}

		// Token: 0x0601A12B RID: 106795 RVA: 0x003B707C File Offset: 0x003B527C
		public static Offset<ITakePhoto2Condition> EndITakePhoto2Condition(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2Condition>(builder.EndTable());
		}

		// Token: 0x0601A12C RID: 106796 RVA: 0x003B708C File Offset: 0x003B528C
		public ITakePhoto2ConditionT UnPack()
		{
			ITakePhoto2ConditionT takePhoto2ConditionT = new ITakePhoto2ConditionT();
			this.UnPackTo(takePhoto2ConditionT);
			return takePhoto2ConditionT;
		}

		// Token: 0x0601A12D RID: 106797 RVA: 0x003B70A8 File Offset: 0x003B52A8
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
			_o.BackgroundImagePath = this.BackgroundImagePath;
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
			_o.PhotoMode = ((this.PhotoMode != null) ? this.PhotoMode.Value.UnPack() : null);
			_o.CanDetectWhenNotTracking = this.CanDetectWhenNotTracking;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601A12E RID: 106798 RVA: 0x003B7388 File Offset: 0x003B5588
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
			StringOffset backgroundImagePathOffset = (_o.BackgroundImagePath == null) ? default(StringOffset) : builder.CreateString(_o.BackgroundImagePath);
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
			Offset<ITakePhoto2BeforeYourEyesMode> photoModeOffset = (_o.PhotoMode == null) ? default(Offset<ITakePhoto2BeforeYourEyesMode>) : ITakePhoto2BeforeYourEyesMode.Pack(builder, _o.PhotoMode);
			return ITakePhoto2Condition.CreateITakePhoto2Condition(builder, _o.Type, preConditionsOffset, tidConditionDescriptionOffset, targetPreviewImagePathOffset, timeConditionOffset, posConditionOffset, fovConditionOffset, sequenceConditionOffset, boundCameraSeqPathOffset, backgroundImagePathOffset, photoTargets_typeOffset, photoTargetsOffset, photoModeOffset, _o.CanDetectWhenNotTracking, _o.NullMask);
		}

		// Token: 0x0400C78B RID: 51083
		private Table __p;
	}
}

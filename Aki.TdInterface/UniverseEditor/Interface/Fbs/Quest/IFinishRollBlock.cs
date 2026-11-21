using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004283 RID: 17027
	public struct IFinishRollBlock : IFlatbufferObject
	{
		// Token: 0x1700743F RID: 29759
		// (get) Token: 0x06017C3F RID: 97343 RVA: 0x0036416E File Offset: 0x0036236E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017C40 RID: 97344 RVA: 0x0036417B File Offset: 0x0036237B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017C41 RID: 97345 RVA: 0x00364184 File Offset: 0x00362384
		public static IFinishRollBlock GetRootAsIFinishRollBlock(ByteBuffer _bb)
		{
			return IFinishRollBlock.GetRootAsIFinishRollBlock(_bb, default(IFinishRollBlock));
		}

		// Token: 0x06017C42 RID: 97346 RVA: 0x003641A0 File Offset: 0x003623A0
		public static IFinishRollBlock GetRootAsIFinishRollBlock(ByteBuffer _bb, IFinishRollBlock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017C43 RID: 97347 RVA: 0x003641BD File Offset: 0x003623BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017C44 RID: 97348 RVA: 0x003641CC File Offset: 0x003623CC
		public IFinishRollBlock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007440 RID: 29760
		// (get) Token: 0x06017C45 RID: 97349 RVA: 0x003641DC File Offset: 0x003623DC
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

		// Token: 0x17007441 RID: 29761
		// (get) Token: 0x06017C46 RID: 97350 RVA: 0x00364218 File Offset: 0x00362418
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

		// Token: 0x17007442 RID: 29762
		// (get) Token: 0x06017C47 RID: 97351 RVA: 0x00364278 File Offset: 0x00362478
		public int CenterEntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007443 RID: 29763
		// (get) Token: 0x06017C48 RID: 97352 RVA: 0x003642B4 File Offset: 0x003624B4
		public int InteractEntityId
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

		// Token: 0x06017C49 RID: 97353 RVA: 0x003642F4 File Offset: 0x003624F4
		public ERollBlockInteractType InteractTypes(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return ERollBlockInteractType.Normal;
			}
			return (ERollBlockInteractType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007444 RID: 29764
		// (get) Token: 0x06017C4A RID: 97354 RVA: 0x00364334 File Offset: 0x00362534
		public int InteractTypesLength
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

		// Token: 0x06017C4B RID: 97355 RVA: 0x00364360 File Offset: 0x00362560
		public Span<ERollBlockInteractType> GetInteractTypesBytes()
		{
			return this.__p.__vector_as_span<ERollBlockInteractType>(12, 1);
		}

		// Token: 0x06017C4C RID: 97356 RVA: 0x00364370 File Offset: 0x00362570
		public ERollBlockInteractType[] GetInteractTypesArray()
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			ERollBlockInteractType[] array = new ERollBlockInteractType[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (ERollBlockInteractType)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06017C4D RID: 97357 RVA: 0x003643DC File Offset: 0x003625DC
		public TRollBlockLaunchMethod LaunchMethodType(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return TRollBlockLaunchMethod.NONE;
			}
			return (TRollBlockLaunchMethod)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007445 RID: 29765
		// (get) Token: 0x06017C4E RID: 97358 RVA: 0x0036441C File Offset: 0x0036261C
		public int LaunchMethodTypeLength
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

		// Token: 0x06017C4F RID: 97359 RVA: 0x00364448 File Offset: 0x00362648
		public Span<TRollBlockLaunchMethod> GetLaunchMethodTypeBytes()
		{
			return this.__p.__vector_as_span<TRollBlockLaunchMethod>(14, 1);
		}

		// Token: 0x06017C50 RID: 97360 RVA: 0x00364458 File Offset: 0x00362658
		public TRollBlockLaunchMethod[] GetLaunchMethodTypeArray()
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TRollBlockLaunchMethod[] array = new TRollBlockLaunchMethod[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TRollBlockLaunchMethod)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06017C51 RID: 97361 RVA: 0x003644C4 File Offset: 0x003626C4
		public TTable? LaunchMethod<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007446 RID: 29766
		// (get) Token: 0x06017C52 RID: 97362 RVA: 0x0036450C File Offset: 0x0036270C
		public int LaunchMethodLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17007447 RID: 29767
		// (get) Token: 0x06017C53 RID: 97363 RVA: 0x00364538 File Offset: 0x00362738
		public int RollBlockGroupId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007448 RID: 29768
		// (get) Token: 0x06017C54 RID: 97364 RVA: 0x00364578 File Offset: 0x00362778
		public int RollBlockTemplateId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007449 RID: 29769
		// (get) Token: 0x06017C55 RID: 97365 RVA: 0x003645B8 File Offset: 0x003627B8
		public TVarRef CurrentDifficultyVarRefType
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017C56 RID: 97366 RVA: 0x003645F8 File Offset: 0x003627F8
		public TTable? CurrentDifficultyVarRef<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017C57 RID: 97367 RVA: 0x00364640 File Offset: 0x00362840
		public IConstVarRef CurrentDifficultyVarRefAsIConstVarRef()
		{
			return this.CurrentDifficultyVarRef<IConstVarRef>().Value;
		}

		// Token: 0x06017C58 RID: 97368 RVA: 0x0036465C File Offset: 0x0036285C
		public IGlobalVarRef CurrentDifficultyVarRefAsIGlobalVarRef()
		{
			return this.CurrentDifficultyVarRef<IGlobalVarRef>().Value;
		}

		// Token: 0x06017C59 RID: 97369 RVA: 0x00364678 File Offset: 0x00362878
		public IOtherVarRef CurrentDifficultyVarRefAsIOtherVarRef()
		{
			return this.CurrentDifficultyVarRef<IOtherVarRef>().Value;
		}

		// Token: 0x06017C5A RID: 97370 RVA: 0x00364694 File Offset: 0x00362894
		public ISelfVarRef CurrentDifficultyVarRefAsISelfVarRef()
		{
			return this.CurrentDifficultyVarRef<ISelfVarRef>().Value;
		}

		// Token: 0x06017C5B RID: 97371 RVA: 0x003646B0 File Offset: 0x003628B0
		public ISystemVarRef CurrentDifficultyVarRefAsISystemVarRef()
		{
			return this.CurrentDifficultyVarRef<ISystemVarRef>().Value;
		}

		// Token: 0x1700744A RID: 29770
		// (get) Token: 0x06017C5C RID: 97372 RVA: 0x003646CC File Offset: 0x003628CC
		public TVarRef AllDifficultyCountVarRefType
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017C5D RID: 97373 RVA: 0x0036470C File Offset: 0x0036290C
		public TTable? AllDifficultyCountVarRef<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017C5E RID: 97374 RVA: 0x00364754 File Offset: 0x00362954
		public IConstVarRef AllDifficultyCountVarRefAsIConstVarRef()
		{
			return this.AllDifficultyCountVarRef<IConstVarRef>().Value;
		}

		// Token: 0x06017C5F RID: 97375 RVA: 0x00364770 File Offset: 0x00362970
		public IGlobalVarRef AllDifficultyCountVarRefAsIGlobalVarRef()
		{
			return this.AllDifficultyCountVarRef<IGlobalVarRef>().Value;
		}

		// Token: 0x06017C60 RID: 97376 RVA: 0x0036478C File Offset: 0x0036298C
		public IOtherVarRef AllDifficultyCountVarRefAsIOtherVarRef()
		{
			return this.AllDifficultyCountVarRef<IOtherVarRef>().Value;
		}

		// Token: 0x06017C61 RID: 97377 RVA: 0x003647A8 File Offset: 0x003629A8
		public ISelfVarRef AllDifficultyCountVarRefAsISelfVarRef()
		{
			return this.AllDifficultyCountVarRef<ISelfVarRef>().Value;
		}

		// Token: 0x06017C62 RID: 97378 RVA: 0x003647C4 File Offset: 0x003629C4
		public ISystemVarRef AllDifficultyCountVarRefAsISystemVarRef()
		{
			return this.AllDifficultyCountVarRef<ISystemVarRef>().Value;
		}

		// Token: 0x06017C63 RID: 97379 RVA: 0x003647E0 File Offset: 0x003629E0
		public IActionInfo? EnterActions(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700744B RID: 29771
		// (get) Token: 0x06017C64 RID: 97380 RVA: 0x00364844 File Offset: 0x00362A44
		public int EnterActionsLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06017C65 RID: 97381 RVA: 0x00364870 File Offset: 0x00362A70
		public IActionInfo? ExitActions(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700744C RID: 29772
		// (get) Token: 0x06017C66 RID: 97382 RVA: 0x003648D4 File Offset: 0x00362AD4
		public int ExitActionsLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06017C67 RID: 97383 RVA: 0x00364900 File Offset: 0x00362B00
		public IActionInfo? CompleteActions(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700744D RID: 29773
		// (get) Token: 0x06017C68 RID: 97384 RVA: 0x00364964 File Offset: 0x00362B64
		public int CompleteActionsLength
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700744E RID: 29774
		// (get) Token: 0x06017C69 RID: 97385 RVA: 0x00364990 File Offset: 0x00362B90
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017C6A RID: 97386 RVA: 0x003649D0 File Offset: 0x00362BD0
		public static Offset<IFinishRollBlock> CreateIFinishRollBlock(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), int CenterEntityId = 0, int InteractEntityId = 0, VectorOffset InteractTypesOffset = default(VectorOffset), VectorOffset LaunchMethod_typeOffset = default(VectorOffset), VectorOffset LaunchMethodOffset = default(VectorOffset), int RollBlockGroupId = 0, int RollBlockTemplateId = 0, TVarRef CurrentDifficultyVarRef_type = TVarRef.NONE, int CurrentDifficultyVarRefOffset = 0, TVarRef AllDifficultyCountVarRef_type = TVarRef.NONE, int AllDifficultyCountVarRefOffset = 0, VectorOffset EnterActionsOffset = default(VectorOffset), VectorOffset ExitActionsOffset = default(VectorOffset), VectorOffset CompleteActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(17);
			IFinishRollBlock.AddCompleteActions(builder, CompleteActionsOffset);
			IFinishRollBlock.AddExitActions(builder, ExitActionsOffset);
			IFinishRollBlock.AddEnterActions(builder, EnterActionsOffset);
			IFinishRollBlock.AddAllDifficultyCountVarRef(builder, AllDifficultyCountVarRefOffset);
			IFinishRollBlock.AddCurrentDifficultyVarRef(builder, CurrentDifficultyVarRefOffset);
			IFinishRollBlock.AddRollBlockTemplateId(builder, RollBlockTemplateId);
			IFinishRollBlock.AddRollBlockGroupId(builder, RollBlockGroupId);
			IFinishRollBlock.AddLaunchMethod(builder, LaunchMethodOffset);
			IFinishRollBlock.AddLaunchMethodType(builder, LaunchMethod_typeOffset);
			IFinishRollBlock.AddInteractTypes(builder, InteractTypesOffset);
			IFinishRollBlock.AddInteractEntityId(builder, InteractEntityId);
			IFinishRollBlock.AddCenterEntityId(builder, CenterEntityId);
			IFinishRollBlock.AddPreConditions(builder, PreConditionsOffset);
			IFinishRollBlock.AddNullMask(builder, NullMask);
			IFinishRollBlock.AddAllDifficultyCountVarRefType(builder, AllDifficultyCountVarRef_type);
			IFinishRollBlock.AddCurrentDifficultyVarRefType(builder, CurrentDifficultyVarRef_type);
			IFinishRollBlock.AddType(builder, Type);
			return IFinishRollBlock.EndIFinishRollBlock(builder);
		}

		// Token: 0x06017C6B RID: 97387 RVA: 0x00364A70 File Offset: 0x00362C70
		public static void StartIFinishRollBlock(FlatBufferBuilder builder)
		{
			builder.StartTable(17);
		}

		// Token: 0x06017C6C RID: 97388 RVA: 0x00364A7A File Offset: 0x00362C7A
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017C6D RID: 97389 RVA: 0x00364A85 File Offset: 0x00362C85
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06017C6E RID: 97390 RVA: 0x00364A95 File Offset: 0x00362C95
		public static void AddCenterEntityId(FlatBufferBuilder builder, int centerEntityId)
		{
			builder.AddInt(2, centerEntityId, 0);
		}

		// Token: 0x06017C6F RID: 97391 RVA: 0x00364AA0 File Offset: 0x00362CA0
		public static void AddInteractEntityId(FlatBufferBuilder builder, int interactEntityId)
		{
			builder.AddInt(3, interactEntityId, 0);
		}

		// Token: 0x06017C70 RID: 97392 RVA: 0x00364AAB File Offset: 0x00362CAB
		public static void AddInteractTypes(FlatBufferBuilder builder, VectorOffset interactTypesOffset)
		{
			builder.AddOffset(4, interactTypesOffset.Value, 0);
		}

		// Token: 0x06017C71 RID: 97393 RVA: 0x00364ABC File Offset: 0x00362CBC
		public static VectorOffset CreateInteractTypesVector(FlatBufferBuilder builder, ERollBlockInteractType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017C72 RID: 97394 RVA: 0x00364AF3 File Offset: 0x00362CF3
		public static VectorOffset CreateInteractTypesVectorBlock(FlatBufferBuilder builder, ERollBlockInteractType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<ERollBlockInteractType>(data);
			return builder.EndVector();
		}

		// Token: 0x06017C73 RID: 97395 RVA: 0x00364B0D File Offset: 0x00362D0D
		public static VectorOffset CreateInteractTypesVectorBlock(FlatBufferBuilder builder, ArraySegment<ERollBlockInteractType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<ERollBlockInteractType>(data);
			return builder.EndVector();
		}

		// Token: 0x06017C74 RID: 97396 RVA: 0x00364B2B File Offset: 0x00362D2B
		public static VectorOffset CreateInteractTypesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<ERollBlockInteractType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017C75 RID: 97397 RVA: 0x00364B44 File Offset: 0x00362D44
		public static void StartInteractTypesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06017C76 RID: 97398 RVA: 0x00364B4F File Offset: 0x00362D4F
		public static void AddLaunchMethodType(FlatBufferBuilder builder, VectorOffset launchMethodTypeOffset)
		{
			builder.AddOffset(5, launchMethodTypeOffset.Value, 0);
		}

		// Token: 0x06017C77 RID: 97399 RVA: 0x00364B60 File Offset: 0x00362D60
		public static VectorOffset CreateLaunchMethodTypeVector(FlatBufferBuilder builder, TRollBlockLaunchMethod[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017C78 RID: 97400 RVA: 0x00364B97 File Offset: 0x00362D97
		public static VectorOffset CreateLaunchMethodTypeVectorBlock(FlatBufferBuilder builder, TRollBlockLaunchMethod[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TRollBlockLaunchMethod>(data);
			return builder.EndVector();
		}

		// Token: 0x06017C79 RID: 97401 RVA: 0x00364BB1 File Offset: 0x00362DB1
		public static VectorOffset CreateLaunchMethodTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TRollBlockLaunchMethod> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TRollBlockLaunchMethod>(data);
			return builder.EndVector();
		}

		// Token: 0x06017C7A RID: 97402 RVA: 0x00364BCF File Offset: 0x00362DCF
		public static VectorOffset CreateLaunchMethodTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TRollBlockLaunchMethod>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017C7B RID: 97403 RVA: 0x00364BE8 File Offset: 0x00362DE8
		public static void StartLaunchMethodTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06017C7C RID: 97404 RVA: 0x00364BF3 File Offset: 0x00362DF3
		public static void AddLaunchMethod(FlatBufferBuilder builder, VectorOffset launchMethodOffset)
		{
			builder.AddOffset(6, launchMethodOffset.Value, 0);
		}

		// Token: 0x06017C7D RID: 97405 RVA: 0x00364C04 File Offset: 0x00362E04
		public static VectorOffset CreateLaunchMethodVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017C7E RID: 97406 RVA: 0x00364C3B File Offset: 0x00362E3B
		public static VectorOffset CreateLaunchMethodVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017C7F RID: 97407 RVA: 0x00364C55 File Offset: 0x00362E55
		public static VectorOffset CreateLaunchMethodVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017C80 RID: 97408 RVA: 0x00364C73 File Offset: 0x00362E73
		public static VectorOffset CreateLaunchMethodVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017C81 RID: 97409 RVA: 0x00364C8C File Offset: 0x00362E8C
		public static void StartLaunchMethodVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017C82 RID: 97410 RVA: 0x00364C97 File Offset: 0x00362E97
		public static void AddRollBlockGroupId(FlatBufferBuilder builder, int rollBlockGroupId)
		{
			builder.AddInt(7, rollBlockGroupId, 0);
		}

		// Token: 0x06017C83 RID: 97411 RVA: 0x00364CA2 File Offset: 0x00362EA2
		public static void AddRollBlockTemplateId(FlatBufferBuilder builder, int rollBlockTemplateId)
		{
			builder.AddInt(8, rollBlockTemplateId, 0);
		}

		// Token: 0x06017C84 RID: 97412 RVA: 0x00364CAD File Offset: 0x00362EAD
		public static void AddCurrentDifficultyVarRefType(FlatBufferBuilder builder, TVarRef currentDifficultyVarRefType)
		{
			builder.AddByte(9, (byte)currentDifficultyVarRefType, 0);
		}

		// Token: 0x06017C85 RID: 97413 RVA: 0x00364CB9 File Offset: 0x00362EB9
		public static void AddCurrentDifficultyVarRef(FlatBufferBuilder builder, int currentDifficultyVarRefOffset)
		{
			builder.AddOffset(10, currentDifficultyVarRefOffset, 0);
		}

		// Token: 0x06017C86 RID: 97414 RVA: 0x00364CC5 File Offset: 0x00362EC5
		public static void AddAllDifficultyCountVarRefType(FlatBufferBuilder builder, TVarRef allDifficultyCountVarRefType)
		{
			builder.AddByte(11, (byte)allDifficultyCountVarRefType, 0);
		}

		// Token: 0x06017C87 RID: 97415 RVA: 0x00364CD1 File Offset: 0x00362ED1
		public static void AddAllDifficultyCountVarRef(FlatBufferBuilder builder, int allDifficultyCountVarRefOffset)
		{
			builder.AddOffset(12, allDifficultyCountVarRefOffset, 0);
		}

		// Token: 0x06017C88 RID: 97416 RVA: 0x00364CDD File Offset: 0x00362EDD
		public static void AddEnterActions(FlatBufferBuilder builder, VectorOffset enterActionsOffset)
		{
			builder.AddOffset(13, enterActionsOffset.Value, 0);
		}

		// Token: 0x06017C89 RID: 97417 RVA: 0x00364CF0 File Offset: 0x00362EF0
		public static VectorOffset CreateEnterActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06017C8A RID: 97418 RVA: 0x00364D30 File Offset: 0x00362F30
		public static VectorOffset CreateEnterActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017C8B RID: 97419 RVA: 0x00364D4A File Offset: 0x00362F4A
		public static VectorOffset CreateEnterActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017C8C RID: 97420 RVA: 0x00364D68 File Offset: 0x00362F68
		public static VectorOffset CreateEnterActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017C8D RID: 97421 RVA: 0x00364D81 File Offset: 0x00362F81
		public static void StartEnterActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017C8E RID: 97422 RVA: 0x00364D8C File Offset: 0x00362F8C
		public static void AddExitActions(FlatBufferBuilder builder, VectorOffset exitActionsOffset)
		{
			builder.AddOffset(14, exitActionsOffset.Value, 0);
		}

		// Token: 0x06017C8F RID: 97423 RVA: 0x00364DA0 File Offset: 0x00362FA0
		public static VectorOffset CreateExitActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06017C90 RID: 97424 RVA: 0x00364DE0 File Offset: 0x00362FE0
		public static VectorOffset CreateExitActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017C91 RID: 97425 RVA: 0x00364DFA File Offset: 0x00362FFA
		public static VectorOffset CreateExitActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017C92 RID: 97426 RVA: 0x00364E18 File Offset: 0x00363018
		public static VectorOffset CreateExitActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017C93 RID: 97427 RVA: 0x00364E31 File Offset: 0x00363031
		public static void StartExitActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017C94 RID: 97428 RVA: 0x00364E3C File Offset: 0x0036303C
		public static void AddCompleteActions(FlatBufferBuilder builder, VectorOffset completeActionsOffset)
		{
			builder.AddOffset(15, completeActionsOffset.Value, 0);
		}

		// Token: 0x06017C95 RID: 97429 RVA: 0x00364E50 File Offset: 0x00363050
		public static VectorOffset CreateCompleteActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06017C96 RID: 97430 RVA: 0x00364E90 File Offset: 0x00363090
		public static VectorOffset CreateCompleteActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017C97 RID: 97431 RVA: 0x00364EAA File Offset: 0x003630AA
		public static VectorOffset CreateCompleteActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017C98 RID: 97432 RVA: 0x00364EC8 File Offset: 0x003630C8
		public static VectorOffset CreateCompleteActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017C99 RID: 97433 RVA: 0x00364EE1 File Offset: 0x003630E1
		public static void StartCompleteActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017C9A RID: 97434 RVA: 0x00364EEC File Offset: 0x003630EC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(16, nullMask, 0);
		}

		// Token: 0x06017C9B RID: 97435 RVA: 0x00364EF8 File Offset: 0x003630F8
		public static Offset<IFinishRollBlock> EndIFinishRollBlock(FlatBufferBuilder builder)
		{
			return new Offset<IFinishRollBlock>(builder.EndTable());
		}

		// Token: 0x06017C9C RID: 97436 RVA: 0x00364F08 File Offset: 0x00363108
		public IFinishRollBlockT UnPack()
		{
			IFinishRollBlockT finishRollBlockT = new IFinishRollBlockT();
			this.UnPackTo(finishRollBlockT);
			return finishRollBlockT;
		}

		// Token: 0x06017C9D RID: 97437 RVA: 0x00364F24 File Offset: 0x00363124
		public void UnPackTo(IFinishRollBlockT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.CenterEntityId = this.CenterEntityId;
			_o.InteractEntityId = this.InteractEntityId;
			_o.InteractTypes = new List<ERollBlockInteractType>();
			for (int i = 0; i < this.InteractTypesLength; i++)
			{
				_o.InteractTypes.Add(this.InteractTypes(i));
			}
			_o.LaunchMethod = new List<TRollBlockLaunchMethodUnion>();
			for (int j = 0; j < this.LaunchMethodLength; j++)
			{
				TRollBlockLaunchMethodUnion trollBlockLaunchMethodUnion = new TRollBlockLaunchMethodUnion();
				trollBlockLaunchMethodUnion.Type = this.LaunchMethodType(j);
				TRollBlockLaunchMethod trollBlockLaunchMethod = this.LaunchMethodType(j);
				if (trollBlockLaunchMethod != TRollBlockLaunchMethod.IRollBlockLaunchMethodInteract)
				{
					if (trollBlockLaunchMethod == TRollBlockLaunchMethod.IRollBlockLaunchMethodRange)
					{
						trollBlockLaunchMethodUnion.Value = ((this.LaunchMethod<IRollBlockLaunchMethodRange>(j) != null) ? this.LaunchMethod<IRollBlockLaunchMethodRange>(j).Value.UnPack() : null);
					}
				}
				else
				{
					trollBlockLaunchMethodUnion.Value = ((this.LaunchMethod<IRollBlockLaunchMethodInteract>(j) != null) ? this.LaunchMethod<IRollBlockLaunchMethodInteract>(j).Value.UnPack() : null);
				}
				_o.LaunchMethod.Add(trollBlockLaunchMethodUnion);
			}
			_o.RollBlockGroupId = this.RollBlockGroupId;
			_o.RollBlockTemplateId = this.RollBlockTemplateId;
			_o.CurrentDifficultyVarRef = new TVarRefUnion();
			_o.CurrentDifficultyVarRef.Type = this.CurrentDifficultyVarRefType;
			switch (this.CurrentDifficultyVarRefType)
			{
			case TVarRef.IConstVarRef:
				_o.CurrentDifficultyVarRef.Value = ((this.CurrentDifficultyVarRef<IConstVarRef>() != null) ? this.CurrentDifficultyVarRef<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.CurrentDifficultyVarRef.Value = ((this.CurrentDifficultyVarRef<IGlobalVarRef>() != null) ? this.CurrentDifficultyVarRef<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.CurrentDifficultyVarRef.Value = ((this.CurrentDifficultyVarRef<IOtherVarRef>() != null) ? this.CurrentDifficultyVarRef<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.CurrentDifficultyVarRef.Value = ((this.CurrentDifficultyVarRef<ISelfVarRef>() != null) ? this.CurrentDifficultyVarRef<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.CurrentDifficultyVarRef.Value = ((this.CurrentDifficultyVarRef<ISystemVarRef>() != null) ? this.CurrentDifficultyVarRef<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.AllDifficultyCountVarRef = new TVarRefUnion();
			_o.AllDifficultyCountVarRef.Type = this.AllDifficultyCountVarRefType;
			switch (this.AllDifficultyCountVarRefType)
			{
			case TVarRef.IConstVarRef:
				_o.AllDifficultyCountVarRef.Value = ((this.AllDifficultyCountVarRef<IConstVarRef>() != null) ? this.AllDifficultyCountVarRef<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.AllDifficultyCountVarRef.Value = ((this.AllDifficultyCountVarRef<IGlobalVarRef>() != null) ? this.AllDifficultyCountVarRef<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.AllDifficultyCountVarRef.Value = ((this.AllDifficultyCountVarRef<IOtherVarRef>() != null) ? this.AllDifficultyCountVarRef<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.AllDifficultyCountVarRef.Value = ((this.AllDifficultyCountVarRef<ISelfVarRef>() != null) ? this.AllDifficultyCountVarRef<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.AllDifficultyCountVarRef.Value = ((this.AllDifficultyCountVarRef<ISystemVarRef>() != null) ? this.AllDifficultyCountVarRef<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.EnterActions = new List<IActionInfoT>();
			for (int k = 0; k < this.EnterActionsLength; k++)
			{
				_o.EnterActions.Add((this.EnterActions(k) != null) ? this.EnterActions(k).Value.UnPack() : null);
			}
			_o.ExitActions = new List<IActionInfoT>();
			for (int l = 0; l < this.ExitActionsLength; l++)
			{
				_o.ExitActions.Add((this.ExitActions(l) != null) ? this.ExitActions(l).Value.UnPack() : null);
			}
			_o.CompleteActions = new List<IActionInfoT>();
			for (int m = 0; m < this.CompleteActionsLength; m++)
			{
				_o.CompleteActions.Add((this.CompleteActions(m) != null) ? this.CompleteActions(m).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06017C9E RID: 97438 RVA: 0x0036547C File Offset: 0x0036367C
		public static Offset<IFinishRollBlock> Pack(FlatBufferBuilder builder, IFinishRollBlockT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishRollBlock>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			VectorOffset interactTypesOffset = default(VectorOffset);
			if (_o.InteractTypes != null)
			{
				ERollBlockInteractType[] data = _o.InteractTypes.ToArray();
				interactTypesOffset = IFinishRollBlock.CreateInteractTypesVector(builder, data);
			}
			VectorOffset launchMethod_typeOffset = default(VectorOffset);
			if (_o.LaunchMethod != null)
			{
				TRollBlockLaunchMethod[] array = new TRollBlockLaunchMethod[_o.LaunchMethod.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.LaunchMethod[i].Type;
				}
				launchMethod_typeOffset = IFinishRollBlock.CreateLaunchMethodTypeVector(builder, array);
			}
			VectorOffset launchMethodOffset = default(VectorOffset);
			if (_o.LaunchMethod != null)
			{
				int[] array2 = new int[_o.LaunchMethod.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TRollBlockLaunchMethodUnion.Pack(builder, _o.LaunchMethod[j]);
				}
				launchMethodOffset = IFinishRollBlock.CreateLaunchMethodVector(builder, array2);
			}
			TVarRef currentDifficultyVarRef_type = (_o.CurrentDifficultyVarRef == null) ? TVarRef.NONE : _o.CurrentDifficultyVarRef.Type;
			int currentDifficultyVarRefOffset = (_o.CurrentDifficultyVarRef == null) ? 0 : TVarRefUnion.Pack(builder, _o.CurrentDifficultyVarRef);
			TVarRef allDifficultyCountVarRef_type = (_o.AllDifficultyCountVarRef == null) ? TVarRef.NONE : _o.AllDifficultyCountVarRef.Type;
			int allDifficultyCountVarRefOffset = (_o.AllDifficultyCountVarRef == null) ? 0 : TVarRefUnion.Pack(builder, _o.AllDifficultyCountVarRef);
			VectorOffset enterActionsOffset = default(VectorOffset);
			if (_o.EnterActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.EnterActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.EnterActions[k]);
				}
				enterActionsOffset = IFinishRollBlock.CreateEnterActionsVector(builder, array3);
			}
			VectorOffset exitActionsOffset = default(VectorOffset);
			if (_o.ExitActions != null)
			{
				Offset<IActionInfo>[] array4 = new Offset<IActionInfo>[_o.ExitActions.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = IActionInfo.Pack(builder, _o.ExitActions[l]);
				}
				exitActionsOffset = IFinishRollBlock.CreateExitActionsVector(builder, array4);
			}
			VectorOffset completeActionsOffset = default(VectorOffset);
			if (_o.CompleteActions != null)
			{
				Offset<IActionInfo>[] array5 = new Offset<IActionInfo>[_o.CompleteActions.Count];
				for (int m = 0; m < array5.Length; m++)
				{
					array5[m] = IActionInfo.Pack(builder, _o.CompleteActions[m]);
				}
				completeActionsOffset = IFinishRollBlock.CreateCompleteActionsVector(builder, array5);
			}
			return IFinishRollBlock.CreateIFinishRollBlock(builder, _o.Type, preConditionsOffset, _o.CenterEntityId, _o.InteractEntityId, interactTypesOffset, launchMethod_typeOffset, launchMethodOffset, _o.RollBlockGroupId, _o.RollBlockTemplateId, currentDifficultyVarRef_type, currentDifficultyVarRefOffset, allDifficultyCountVarRef_type, allDifficultyCountVarRefOffset, enterActionsOffset, exitActionsOffset, completeActionsOffset, _o.NullMask);
		}

		// Token: 0x0400C1B4 RID: 49588
		private Table __p;
	}
}

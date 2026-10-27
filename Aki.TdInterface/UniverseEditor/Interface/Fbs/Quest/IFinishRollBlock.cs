using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E48 RID: 15944
	public struct IFinishRollBlock : IFlatbufferObject
	{
		// Token: 0x17006E5B RID: 28251
		// (get) Token: 0x06016618 RID: 91672 RVA: 0x0033B63E File Offset: 0x0033983E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016619 RID: 91673 RVA: 0x0033B64B File Offset: 0x0033984B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601661A RID: 91674 RVA: 0x0033B654 File Offset: 0x00339854
		public static IFinishRollBlock GetRootAsIFinishRollBlock(ByteBuffer _bb)
		{
			return IFinishRollBlock.GetRootAsIFinishRollBlock(_bb, default(IFinishRollBlock));
		}

		// Token: 0x0601661B RID: 91675 RVA: 0x0033B670 File Offset: 0x00339870
		public static IFinishRollBlock GetRootAsIFinishRollBlock(ByteBuffer _bb, IFinishRollBlock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601661C RID: 91676 RVA: 0x0033B68D File Offset: 0x0033988D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601661D RID: 91677 RVA: 0x0033B69C File Offset: 0x0033989C
		public IFinishRollBlock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E5C RID: 28252
		// (get) Token: 0x0601661E RID: 91678 RVA: 0x0033B6AC File Offset: 0x003398AC
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

		// Token: 0x17006E5D RID: 28253
		// (get) Token: 0x0601661F RID: 91679 RVA: 0x0033B6E8 File Offset: 0x003398E8
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

		// Token: 0x17006E5E RID: 28254
		// (get) Token: 0x06016620 RID: 91680 RVA: 0x0033B748 File Offset: 0x00339948
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

		// Token: 0x17006E5F RID: 28255
		// (get) Token: 0x06016621 RID: 91681 RVA: 0x0033B784 File Offset: 0x00339984
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

		// Token: 0x06016622 RID: 91682 RVA: 0x0033B7C4 File Offset: 0x003399C4
		public ERollBlockInteractType InteractTypes(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return ERollBlockInteractType.Normal;
			}
			return (ERollBlockInteractType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17006E60 RID: 28256
		// (get) Token: 0x06016623 RID: 91683 RVA: 0x0033B804 File Offset: 0x00339A04
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

		// Token: 0x06016624 RID: 91684 RVA: 0x0033B830 File Offset: 0x00339A30
		public Span<ERollBlockInteractType> GetInteractTypesBytes()
		{
			return this.__p.__vector_as_span<ERollBlockInteractType>(12, 1);
		}

		// Token: 0x06016625 RID: 91685 RVA: 0x0033B840 File Offset: 0x00339A40
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

		// Token: 0x06016626 RID: 91686 RVA: 0x0033B8AC File Offset: 0x00339AAC
		public TRollBlockLaunchMethod LaunchMethodType(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return TRollBlockLaunchMethod.NONE;
			}
			return (TRollBlockLaunchMethod)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17006E61 RID: 28257
		// (get) Token: 0x06016627 RID: 91687 RVA: 0x0033B8EC File Offset: 0x00339AEC
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

		// Token: 0x06016628 RID: 91688 RVA: 0x0033B918 File Offset: 0x00339B18
		public Span<TRollBlockLaunchMethod> GetLaunchMethodTypeBytes()
		{
			return this.__p.__vector_as_span<TRollBlockLaunchMethod>(14, 1);
		}

		// Token: 0x06016629 RID: 91689 RVA: 0x0033B928 File Offset: 0x00339B28
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

		// Token: 0x0601662A RID: 91690 RVA: 0x0033B994 File Offset: 0x00339B94
		public TTable? LaunchMethod<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17006E62 RID: 28258
		// (get) Token: 0x0601662B RID: 91691 RVA: 0x0033B9DC File Offset: 0x00339BDC
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

		// Token: 0x17006E63 RID: 28259
		// (get) Token: 0x0601662C RID: 91692 RVA: 0x0033BA08 File Offset: 0x00339C08
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

		// Token: 0x17006E64 RID: 28260
		// (get) Token: 0x0601662D RID: 91693 RVA: 0x0033BA48 File Offset: 0x00339C48
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

		// Token: 0x17006E65 RID: 28261
		// (get) Token: 0x0601662E RID: 91694 RVA: 0x0033BA88 File Offset: 0x00339C88
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

		// Token: 0x0601662F RID: 91695 RVA: 0x0033BAC8 File Offset: 0x00339CC8
		public TTable? CurrentDifficultyVarRef<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06016630 RID: 91696 RVA: 0x0033BB10 File Offset: 0x00339D10
		public IConstVarRef CurrentDifficultyVarRefAsIConstVarRef()
		{
			return this.CurrentDifficultyVarRef<IConstVarRef>().Value;
		}

		// Token: 0x06016631 RID: 91697 RVA: 0x0033BB2C File Offset: 0x00339D2C
		public IGlobalVarRef CurrentDifficultyVarRefAsIGlobalVarRef()
		{
			return this.CurrentDifficultyVarRef<IGlobalVarRef>().Value;
		}

		// Token: 0x06016632 RID: 91698 RVA: 0x0033BB48 File Offset: 0x00339D48
		public IOtherVarRef CurrentDifficultyVarRefAsIOtherVarRef()
		{
			return this.CurrentDifficultyVarRef<IOtherVarRef>().Value;
		}

		// Token: 0x06016633 RID: 91699 RVA: 0x0033BB64 File Offset: 0x00339D64
		public ISelfVarRef CurrentDifficultyVarRefAsISelfVarRef()
		{
			return this.CurrentDifficultyVarRef<ISelfVarRef>().Value;
		}

		// Token: 0x06016634 RID: 91700 RVA: 0x0033BB80 File Offset: 0x00339D80
		public ISystemVarRef CurrentDifficultyVarRefAsISystemVarRef()
		{
			return this.CurrentDifficultyVarRef<ISystemVarRef>().Value;
		}

		// Token: 0x17006E66 RID: 28262
		// (get) Token: 0x06016635 RID: 91701 RVA: 0x0033BB9C File Offset: 0x00339D9C
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

		// Token: 0x06016636 RID: 91702 RVA: 0x0033BBDC File Offset: 0x00339DDC
		public TTable? AllDifficultyCountVarRef<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06016637 RID: 91703 RVA: 0x0033BC24 File Offset: 0x00339E24
		public IConstVarRef AllDifficultyCountVarRefAsIConstVarRef()
		{
			return this.AllDifficultyCountVarRef<IConstVarRef>().Value;
		}

		// Token: 0x06016638 RID: 91704 RVA: 0x0033BC40 File Offset: 0x00339E40
		public IGlobalVarRef AllDifficultyCountVarRefAsIGlobalVarRef()
		{
			return this.AllDifficultyCountVarRef<IGlobalVarRef>().Value;
		}

		// Token: 0x06016639 RID: 91705 RVA: 0x0033BC5C File Offset: 0x00339E5C
		public IOtherVarRef AllDifficultyCountVarRefAsIOtherVarRef()
		{
			return this.AllDifficultyCountVarRef<IOtherVarRef>().Value;
		}

		// Token: 0x0601663A RID: 91706 RVA: 0x0033BC78 File Offset: 0x00339E78
		public ISelfVarRef AllDifficultyCountVarRefAsISelfVarRef()
		{
			return this.AllDifficultyCountVarRef<ISelfVarRef>().Value;
		}

		// Token: 0x0601663B RID: 91707 RVA: 0x0033BC94 File Offset: 0x00339E94
		public ISystemVarRef AllDifficultyCountVarRefAsISystemVarRef()
		{
			return this.AllDifficultyCountVarRef<ISystemVarRef>().Value;
		}

		// Token: 0x0601663C RID: 91708 RVA: 0x0033BCB0 File Offset: 0x00339EB0
		public IActionInfo? EnterActions(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006E67 RID: 28263
		// (get) Token: 0x0601663D RID: 91709 RVA: 0x0033BD14 File Offset: 0x00339F14
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

		// Token: 0x0601663E RID: 91710 RVA: 0x0033BD40 File Offset: 0x00339F40
		public IActionInfo? ExitActions(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006E68 RID: 28264
		// (get) Token: 0x0601663F RID: 91711 RVA: 0x0033BDA4 File Offset: 0x00339FA4
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

		// Token: 0x06016640 RID: 91712 RVA: 0x0033BDD0 File Offset: 0x00339FD0
		public IActionInfo? CompleteActions(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006E69 RID: 28265
		// (get) Token: 0x06016641 RID: 91713 RVA: 0x0033BE34 File Offset: 0x0033A034
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

		// Token: 0x17006E6A RID: 28266
		// (get) Token: 0x06016642 RID: 91714 RVA: 0x0033BE60 File Offset: 0x0033A060
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

		// Token: 0x06016643 RID: 91715 RVA: 0x0033BEA0 File Offset: 0x0033A0A0
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

		// Token: 0x06016644 RID: 91716 RVA: 0x0033BF40 File Offset: 0x0033A140
		public static void StartIFinishRollBlock(FlatBufferBuilder builder)
		{
			builder.StartTable(17);
		}

		// Token: 0x06016645 RID: 91717 RVA: 0x0033BF4A File Offset: 0x0033A14A
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016646 RID: 91718 RVA: 0x0033BF55 File Offset: 0x0033A155
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06016647 RID: 91719 RVA: 0x0033BF65 File Offset: 0x0033A165
		public static void AddCenterEntityId(FlatBufferBuilder builder, int centerEntityId)
		{
			builder.AddInt(2, centerEntityId, 0);
		}

		// Token: 0x06016648 RID: 91720 RVA: 0x0033BF70 File Offset: 0x0033A170
		public static void AddInteractEntityId(FlatBufferBuilder builder, int interactEntityId)
		{
			builder.AddInt(3, interactEntityId, 0);
		}

		// Token: 0x06016649 RID: 91721 RVA: 0x0033BF7B File Offset: 0x0033A17B
		public static void AddInteractTypes(FlatBufferBuilder builder, VectorOffset interactTypesOffset)
		{
			builder.AddOffset(4, interactTypesOffset.Value, 0);
		}

		// Token: 0x0601664A RID: 91722 RVA: 0x0033BF8C File Offset: 0x0033A18C
		public static VectorOffset CreateInteractTypesVector(FlatBufferBuilder builder, ERollBlockInteractType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601664B RID: 91723 RVA: 0x0033BFC3 File Offset: 0x0033A1C3
		public static VectorOffset CreateInteractTypesVectorBlock(FlatBufferBuilder builder, ERollBlockInteractType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<ERollBlockInteractType>(data);
			return builder.EndVector();
		}

		// Token: 0x0601664C RID: 91724 RVA: 0x0033BFDD File Offset: 0x0033A1DD
		public static VectorOffset CreateInteractTypesVectorBlock(FlatBufferBuilder builder, ArraySegment<ERollBlockInteractType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<ERollBlockInteractType>(data);
			return builder.EndVector();
		}

		// Token: 0x0601664D RID: 91725 RVA: 0x0033BFFB File Offset: 0x0033A1FB
		public static VectorOffset CreateInteractTypesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<ERollBlockInteractType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601664E RID: 91726 RVA: 0x0033C014 File Offset: 0x0033A214
		public static void StartInteractTypesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601664F RID: 91727 RVA: 0x0033C01F File Offset: 0x0033A21F
		public static void AddLaunchMethodType(FlatBufferBuilder builder, VectorOffset launchMethodTypeOffset)
		{
			builder.AddOffset(5, launchMethodTypeOffset.Value, 0);
		}

		// Token: 0x06016650 RID: 91728 RVA: 0x0033C030 File Offset: 0x0033A230
		public static VectorOffset CreateLaunchMethodTypeVector(FlatBufferBuilder builder, TRollBlockLaunchMethod[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06016651 RID: 91729 RVA: 0x0033C067 File Offset: 0x0033A267
		public static VectorOffset CreateLaunchMethodTypeVectorBlock(FlatBufferBuilder builder, TRollBlockLaunchMethod[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TRollBlockLaunchMethod>(data);
			return builder.EndVector();
		}

		// Token: 0x06016652 RID: 91730 RVA: 0x0033C081 File Offset: 0x0033A281
		public static VectorOffset CreateLaunchMethodTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TRollBlockLaunchMethod> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TRollBlockLaunchMethod>(data);
			return builder.EndVector();
		}

		// Token: 0x06016653 RID: 91731 RVA: 0x0033C09F File Offset: 0x0033A29F
		public static VectorOffset CreateLaunchMethodTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TRollBlockLaunchMethod>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016654 RID: 91732 RVA: 0x0033C0B8 File Offset: 0x0033A2B8
		public static void StartLaunchMethodTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06016655 RID: 91733 RVA: 0x0033C0C3 File Offset: 0x0033A2C3
		public static void AddLaunchMethod(FlatBufferBuilder builder, VectorOffset launchMethodOffset)
		{
			builder.AddOffset(6, launchMethodOffset.Value, 0);
		}

		// Token: 0x06016656 RID: 91734 RVA: 0x0033C0D4 File Offset: 0x0033A2D4
		public static VectorOffset CreateLaunchMethodVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06016657 RID: 91735 RVA: 0x0033C10B File Offset: 0x0033A30B
		public static VectorOffset CreateLaunchMethodVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016658 RID: 91736 RVA: 0x0033C125 File Offset: 0x0033A325
		public static VectorOffset CreateLaunchMethodVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016659 RID: 91737 RVA: 0x0033C143 File Offset: 0x0033A343
		public static VectorOffset CreateLaunchMethodVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601665A RID: 91738 RVA: 0x0033C15C File Offset: 0x0033A35C
		public static void StartLaunchMethodVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601665B RID: 91739 RVA: 0x0033C167 File Offset: 0x0033A367
		public static void AddRollBlockGroupId(FlatBufferBuilder builder, int rollBlockGroupId)
		{
			builder.AddInt(7, rollBlockGroupId, 0);
		}

		// Token: 0x0601665C RID: 91740 RVA: 0x0033C172 File Offset: 0x0033A372
		public static void AddRollBlockTemplateId(FlatBufferBuilder builder, int rollBlockTemplateId)
		{
			builder.AddInt(8, rollBlockTemplateId, 0);
		}

		// Token: 0x0601665D RID: 91741 RVA: 0x0033C17D File Offset: 0x0033A37D
		public static void AddCurrentDifficultyVarRefType(FlatBufferBuilder builder, TVarRef currentDifficultyVarRefType)
		{
			builder.AddByte(9, (byte)currentDifficultyVarRefType, 0);
		}

		// Token: 0x0601665E RID: 91742 RVA: 0x0033C189 File Offset: 0x0033A389
		public static void AddCurrentDifficultyVarRef(FlatBufferBuilder builder, int currentDifficultyVarRefOffset)
		{
			builder.AddOffset(10, currentDifficultyVarRefOffset, 0);
		}

		// Token: 0x0601665F RID: 91743 RVA: 0x0033C195 File Offset: 0x0033A395
		public static void AddAllDifficultyCountVarRefType(FlatBufferBuilder builder, TVarRef allDifficultyCountVarRefType)
		{
			builder.AddByte(11, (byte)allDifficultyCountVarRefType, 0);
		}

		// Token: 0x06016660 RID: 91744 RVA: 0x0033C1A1 File Offset: 0x0033A3A1
		public static void AddAllDifficultyCountVarRef(FlatBufferBuilder builder, int allDifficultyCountVarRefOffset)
		{
			builder.AddOffset(12, allDifficultyCountVarRefOffset, 0);
		}

		// Token: 0x06016661 RID: 91745 RVA: 0x0033C1AD File Offset: 0x0033A3AD
		public static void AddEnterActions(FlatBufferBuilder builder, VectorOffset enterActionsOffset)
		{
			builder.AddOffset(13, enterActionsOffset.Value, 0);
		}

		// Token: 0x06016662 RID: 91746 RVA: 0x0033C1C0 File Offset: 0x0033A3C0
		public static VectorOffset CreateEnterActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06016663 RID: 91747 RVA: 0x0033C200 File Offset: 0x0033A400
		public static VectorOffset CreateEnterActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016664 RID: 91748 RVA: 0x0033C21A File Offset: 0x0033A41A
		public static VectorOffset CreateEnterActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016665 RID: 91749 RVA: 0x0033C238 File Offset: 0x0033A438
		public static VectorOffset CreateEnterActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016666 RID: 91750 RVA: 0x0033C251 File Offset: 0x0033A451
		public static void StartEnterActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016667 RID: 91751 RVA: 0x0033C25C File Offset: 0x0033A45C
		public static void AddExitActions(FlatBufferBuilder builder, VectorOffset exitActionsOffset)
		{
			builder.AddOffset(14, exitActionsOffset.Value, 0);
		}

		// Token: 0x06016668 RID: 91752 RVA: 0x0033C270 File Offset: 0x0033A470
		public static VectorOffset CreateExitActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06016669 RID: 91753 RVA: 0x0033C2B0 File Offset: 0x0033A4B0
		public static VectorOffset CreateExitActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601666A RID: 91754 RVA: 0x0033C2CA File Offset: 0x0033A4CA
		public static VectorOffset CreateExitActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601666B RID: 91755 RVA: 0x0033C2E8 File Offset: 0x0033A4E8
		public static VectorOffset CreateExitActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601666C RID: 91756 RVA: 0x0033C301 File Offset: 0x0033A501
		public static void StartExitActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601666D RID: 91757 RVA: 0x0033C30C File Offset: 0x0033A50C
		public static void AddCompleteActions(FlatBufferBuilder builder, VectorOffset completeActionsOffset)
		{
			builder.AddOffset(15, completeActionsOffset.Value, 0);
		}

		// Token: 0x0601666E RID: 91758 RVA: 0x0033C320 File Offset: 0x0033A520
		public static VectorOffset CreateCompleteActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601666F RID: 91759 RVA: 0x0033C360 File Offset: 0x0033A560
		public static VectorOffset CreateCompleteActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016670 RID: 91760 RVA: 0x0033C37A File Offset: 0x0033A57A
		public static VectorOffset CreateCompleteActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016671 RID: 91761 RVA: 0x0033C398 File Offset: 0x0033A598
		public static VectorOffset CreateCompleteActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016672 RID: 91762 RVA: 0x0033C3B1 File Offset: 0x0033A5B1
		public static void StartCompleteActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016673 RID: 91763 RVA: 0x0033C3BC File Offset: 0x0033A5BC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(16, nullMask, 0);
		}

		// Token: 0x06016674 RID: 91764 RVA: 0x0033C3C8 File Offset: 0x0033A5C8
		public static Offset<IFinishRollBlock> EndIFinishRollBlock(FlatBufferBuilder builder)
		{
			return new Offset<IFinishRollBlock>(builder.EndTable());
		}

		// Token: 0x06016675 RID: 91765 RVA: 0x0033C3D8 File Offset: 0x0033A5D8
		public IFinishRollBlockT UnPack()
		{
			IFinishRollBlockT finishRollBlockT = new IFinishRollBlockT();
			this.UnPackTo(finishRollBlockT);
			return finishRollBlockT;
		}

		// Token: 0x06016676 RID: 91766 RVA: 0x0033C3F4 File Offset: 0x0033A5F4
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

		// Token: 0x06016677 RID: 91767 RVA: 0x0033C94C File Offset: 0x0033AB4C
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

		// Token: 0x0400B7DD RID: 47069
		private Table __p;
	}
}

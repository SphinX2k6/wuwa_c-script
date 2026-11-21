using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200575D RID: 22365
	public struct IExploreSkillMechascoutDrag : IFlatbufferObject
	{
		// Token: 0x1700A1A5 RID: 41381
		// (get) Token: 0x060240C6 RID: 147654 RVA: 0x004F54C9 File Offset: 0x004F36C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060240C7 RID: 147655 RVA: 0x004F54D6 File Offset: 0x004F36D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060240C8 RID: 147656 RVA: 0x004F54E0 File Offset: 0x004F36E0
		public static IExploreSkillMechascoutDrag GetRootAsIExploreSkillMechascoutDrag(ByteBuffer _bb)
		{
			return IExploreSkillMechascoutDrag.GetRootAsIExploreSkillMechascoutDrag(_bb, default(IExploreSkillMechascoutDrag));
		}

		// Token: 0x060240C9 RID: 147657 RVA: 0x004F54FC File Offset: 0x004F36FC
		public static IExploreSkillMechascoutDrag GetRootAsIExploreSkillMechascoutDrag(ByteBuffer _bb, IExploreSkillMechascoutDrag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060240CA RID: 147658 RVA: 0x004F5519 File Offset: 0x004F3719
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060240CB RID: 147659 RVA: 0x004F5528 File Offset: 0x004F3728
		public IExploreSkillMechascoutDrag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A1A6 RID: 41382
		// (get) Token: 0x060240CC RID: 147660 RVA: 0x004F5538 File Offset: 0x004F3738
		public EExploreSkillInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExploreSkillInteractType.PullGiant;
				}
				return (EExploreSkillInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A1A7 RID: 41383
		// (get) Token: 0x060240CD RID: 147661 RVA: 0x004F5574 File Offset: 0x004F3774
		public TMechascoutDragType DragTypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TMechascoutDragType.NONE;
				}
				return (TMechascoutDragType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060240CE RID: 147662 RVA: 0x004F55B0 File Offset: 0x004F37B0
		public TTable? DragType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060240CF RID: 147663 RVA: 0x004F55F4 File Offset: 0x004F37F4
		public IMechascoutDragInstant DragTypeAsIMechascoutDragInstant()
		{
			return this.DragType<IMechascoutDragInstant>().Value;
		}

		// Token: 0x060240D0 RID: 147664 RVA: 0x004F5610 File Offset: 0x004F3810
		public IMechascoutDragLongPress DragTypeAsIMechascoutDragLongPress()
		{
			return this.DragType<IMechascoutDragLongPress>().Value;
		}

		// Token: 0x060240D1 RID: 147665 RVA: 0x004F562C File Offset: 0x004F382C
		public int TriggerPointList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A1A8 RID: 41384
		// (get) Token: 0x060240D2 RID: 147666 RVA: 0x004F566C File Offset: 0x004F386C
		public int TriggerPointListLength
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

		// Token: 0x060240D3 RID: 147667 RVA: 0x004F5698 File Offset: 0x004F3898
		public Span<int> GetTriggerPointListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060240D4 RID: 147668 RVA: 0x004F56A8 File Offset: 0x004F38A8
		public int[] GetTriggerPointListArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x060240D5 RID: 147669 RVA: 0x004F56B8 File Offset: 0x004F38B8
		public IActionInfo? FinishedActions(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A1A9 RID: 41385
		// (get) Token: 0x060240D6 RID: 147670 RVA: 0x004F571C File Offset: 0x004F391C
		public int FinishedActionsLength
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

		// Token: 0x1700A1AA RID: 41386
		// (get) Token: 0x060240D7 RID: 147671 RVA: 0x004F5748 File Offset: 0x004F3948
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060240D8 RID: 147672 RVA: 0x004F5785 File Offset: 0x004F3985
		public static Offset<IExploreSkillMechascoutDrag> CreateIExploreSkillMechascoutDrag(FlatBufferBuilder builder, EExploreSkillInteractType Type = EExploreSkillInteractType.PullGiant, TMechascoutDragType DragType_type = TMechascoutDragType.NONE, int DragTypeOffset = 0, VectorOffset TriggerPointListOffset = default(VectorOffset), VectorOffset FinishedActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IExploreSkillMechascoutDrag.AddFinishedActions(builder, FinishedActionsOffset);
			IExploreSkillMechascoutDrag.AddTriggerPointList(builder, TriggerPointListOffset);
			IExploreSkillMechascoutDrag.AddDragType(builder, DragTypeOffset);
			IExploreSkillMechascoutDrag.AddNullMask(builder, NullMask);
			IExploreSkillMechascoutDrag.AddDragTypeType(builder, DragType_type);
			IExploreSkillMechascoutDrag.AddType(builder, Type);
			return IExploreSkillMechascoutDrag.EndIExploreSkillMechascoutDrag(builder);
		}

		// Token: 0x060240D9 RID: 147673 RVA: 0x004F57C1 File Offset: 0x004F39C1
		public static void StartIExploreSkillMechascoutDrag(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060240DA RID: 147674 RVA: 0x004F57CA File Offset: 0x004F39CA
		public static void AddType(FlatBufferBuilder builder, EExploreSkillInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060240DB RID: 147675 RVA: 0x004F57D5 File Offset: 0x004F39D5
		public static void AddDragTypeType(FlatBufferBuilder builder, TMechascoutDragType dragTypeType)
		{
			builder.AddByte(1, (byte)dragTypeType, 0);
		}

		// Token: 0x060240DC RID: 147676 RVA: 0x004F57E0 File Offset: 0x004F39E0
		public static void AddDragType(FlatBufferBuilder builder, int dragTypeOffset)
		{
			builder.AddOffset(2, dragTypeOffset, 0);
		}

		// Token: 0x060240DD RID: 147677 RVA: 0x004F57EB File Offset: 0x004F39EB
		public static void AddTriggerPointList(FlatBufferBuilder builder, VectorOffset triggerPointListOffset)
		{
			builder.AddOffset(3, triggerPointListOffset.Value, 0);
		}

		// Token: 0x060240DE RID: 147678 RVA: 0x004F57FC File Offset: 0x004F39FC
		public static VectorOffset CreateTriggerPointListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060240DF RID: 147679 RVA: 0x004F5833 File Offset: 0x004F3A33
		public static VectorOffset CreateTriggerPointListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060240E0 RID: 147680 RVA: 0x004F584D File Offset: 0x004F3A4D
		public static VectorOffset CreateTriggerPointListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060240E1 RID: 147681 RVA: 0x004F586B File Offset: 0x004F3A6B
		public static VectorOffset CreateTriggerPointListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060240E2 RID: 147682 RVA: 0x004F5884 File Offset: 0x004F3A84
		public static void StartTriggerPointListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060240E3 RID: 147683 RVA: 0x004F588F File Offset: 0x004F3A8F
		public static void AddFinishedActions(FlatBufferBuilder builder, VectorOffset finishedActionsOffset)
		{
			builder.AddOffset(4, finishedActionsOffset.Value, 0);
		}

		// Token: 0x060240E4 RID: 147684 RVA: 0x004F58A0 File Offset: 0x004F3AA0
		public static VectorOffset CreateFinishedActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060240E5 RID: 147685 RVA: 0x004F58E0 File Offset: 0x004F3AE0
		public static VectorOffset CreateFinishedActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060240E6 RID: 147686 RVA: 0x004F58FA File Offset: 0x004F3AFA
		public static VectorOffset CreateFinishedActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060240E7 RID: 147687 RVA: 0x004F5918 File Offset: 0x004F3B18
		public static VectorOffset CreateFinishedActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060240E8 RID: 147688 RVA: 0x004F5931 File Offset: 0x004F3B31
		public static void StartFinishedActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060240E9 RID: 147689 RVA: 0x004F593C File Offset: 0x004F3B3C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060240EA RID: 147690 RVA: 0x004F5947 File Offset: 0x004F3B47
		public static Offset<IExploreSkillMechascoutDrag> EndIExploreSkillMechascoutDrag(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillMechascoutDrag>(builder.EndTable());
		}

		// Token: 0x060240EB RID: 147691 RVA: 0x004F5954 File Offset: 0x004F3B54
		public IExploreSkillMechascoutDragT UnPack()
		{
			IExploreSkillMechascoutDragT exploreSkillMechascoutDragT = new IExploreSkillMechascoutDragT();
			this.UnPackTo(exploreSkillMechascoutDragT);
			return exploreSkillMechascoutDragT;
		}

		// Token: 0x060240EC RID: 147692 RVA: 0x004F5970 File Offset: 0x004F3B70
		public void UnPackTo(IExploreSkillMechascoutDragT _o)
		{
			_o.Type = this.Type;
			_o.DragType = new TMechascoutDragTypeUnion();
			_o.DragType.Type = this.DragTypeType;
			TMechascoutDragType dragTypeType = this.DragTypeType;
			if (dragTypeType != TMechascoutDragType.IMechascoutDragInstant)
			{
				if (dragTypeType == TMechascoutDragType.IMechascoutDragLongPress)
				{
					_o.DragType.Value = ((this.DragType<IMechascoutDragLongPress>() != null) ? this.DragType<IMechascoutDragLongPress>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.DragType.Value = ((this.DragType<IMechascoutDragInstant>() != null) ? this.DragType<IMechascoutDragInstant>().Value.UnPack() : null);
			}
			_o.TriggerPointList = new List<int>();
			for (int i = 0; i < this.TriggerPointListLength; i++)
			{
				_o.TriggerPointList.Add(this.TriggerPointList(i));
			}
			_o.FinishedActions = new List<IActionInfoT>();
			for (int j = 0; j < this.FinishedActionsLength; j++)
			{
				_o.FinishedActions.Add((this.FinishedActions(j) != null) ? this.FinishedActions(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060240ED RID: 147693 RVA: 0x004F5ABC File Offset: 0x004F3CBC
		public static Offset<IExploreSkillMechascoutDrag> Pack(FlatBufferBuilder builder, IExploreSkillMechascoutDragT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExploreSkillMechascoutDrag>);
			}
			TMechascoutDragType dragType_type = (_o.DragType == null) ? TMechascoutDragType.NONE : _o.DragType.Type;
			int dragTypeOffset = (_o.DragType == null) ? 0 : TMechascoutDragTypeUnion.Pack(builder, _o.DragType);
			VectorOffset triggerPointListOffset = default(VectorOffset);
			if (_o.TriggerPointList != null)
			{
				int[] data = _o.TriggerPointList.ToArray();
				triggerPointListOffset = IExploreSkillMechascoutDrag.CreateTriggerPointListVector(builder, data);
			}
			VectorOffset finishedActionsOffset = default(VectorOffset);
			if (_o.FinishedActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.FinishedActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.FinishedActions[i]);
				}
				finishedActionsOffset = IExploreSkillMechascoutDrag.CreateFinishedActionsVector(builder, array);
			}
			return IExploreSkillMechascoutDrag.CreateIExploreSkillMechascoutDrag(builder, _o.Type, dragType_type, dragTypeOffset, triggerPointListOffset, finishedActionsOffset, _o.NullMask);
		}

		// Token: 0x0400EF27 RID: 61223
		private Table __p;
	}
}

using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051F5 RID: 20981
	public struct IExploreSkillMechascoutDrag : IFlatbufferObject
	{
		// Token: 0x170099A9 RID: 39337
		// (get) Token: 0x06022130 RID: 139568 RVA: 0x004BAA05 File Offset: 0x004B8C05
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022131 RID: 139569 RVA: 0x004BAA12 File Offset: 0x004B8C12
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022132 RID: 139570 RVA: 0x004BAA1C File Offset: 0x004B8C1C
		public static IExploreSkillMechascoutDrag GetRootAsIExploreSkillMechascoutDrag(ByteBuffer _bb)
		{
			return IExploreSkillMechascoutDrag.GetRootAsIExploreSkillMechascoutDrag(_bb, default(IExploreSkillMechascoutDrag));
		}

		// Token: 0x06022133 RID: 139571 RVA: 0x004BAA38 File Offset: 0x004B8C38
		public static IExploreSkillMechascoutDrag GetRootAsIExploreSkillMechascoutDrag(ByteBuffer _bb, IExploreSkillMechascoutDrag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022134 RID: 139572 RVA: 0x004BAA55 File Offset: 0x004B8C55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022135 RID: 139573 RVA: 0x004BAA64 File Offset: 0x004B8C64
		public IExploreSkillMechascoutDrag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170099AA RID: 39338
		// (get) Token: 0x06022136 RID: 139574 RVA: 0x004BAA74 File Offset: 0x004B8C74
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

		// Token: 0x170099AB RID: 39339
		// (get) Token: 0x06022137 RID: 139575 RVA: 0x004BAAB0 File Offset: 0x004B8CB0
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

		// Token: 0x06022138 RID: 139576 RVA: 0x004BAAEC File Offset: 0x004B8CEC
		public TTable? DragType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06022139 RID: 139577 RVA: 0x004BAB30 File Offset: 0x004B8D30
		public IMechascoutDragInstant DragTypeAsIMechascoutDragInstant()
		{
			return this.DragType<IMechascoutDragInstant>().Value;
		}

		// Token: 0x0602213A RID: 139578 RVA: 0x004BAB4C File Offset: 0x004B8D4C
		public IMechascoutDragLongPress DragTypeAsIMechascoutDragLongPress()
		{
			return this.DragType<IMechascoutDragLongPress>().Value;
		}

		// Token: 0x0602213B RID: 139579 RVA: 0x004BAB68 File Offset: 0x004B8D68
		public int TriggerPointList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170099AC RID: 39340
		// (get) Token: 0x0602213C RID: 139580 RVA: 0x004BABA8 File Offset: 0x004B8DA8
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

		// Token: 0x0602213D RID: 139581 RVA: 0x004BABD4 File Offset: 0x004B8DD4
		public Span<int> GetTriggerPointListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0602213E RID: 139582 RVA: 0x004BABE4 File Offset: 0x004B8DE4
		public int[] GetTriggerPointListArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x0602213F RID: 139583 RVA: 0x004BABF4 File Offset: 0x004B8DF4
		public IActionInfo? FinishedActions(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170099AD RID: 39341
		// (get) Token: 0x06022140 RID: 139584 RVA: 0x004BAC58 File Offset: 0x004B8E58
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

		// Token: 0x170099AE RID: 39342
		// (get) Token: 0x06022141 RID: 139585 RVA: 0x004BAC84 File Offset: 0x004B8E84
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

		// Token: 0x06022142 RID: 139586 RVA: 0x004BACC1 File Offset: 0x004B8EC1
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

		// Token: 0x06022143 RID: 139587 RVA: 0x004BACFD File Offset: 0x004B8EFD
		public static void StartIExploreSkillMechascoutDrag(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06022144 RID: 139588 RVA: 0x004BAD06 File Offset: 0x004B8F06
		public static void AddType(FlatBufferBuilder builder, EExploreSkillInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022145 RID: 139589 RVA: 0x004BAD11 File Offset: 0x004B8F11
		public static void AddDragTypeType(FlatBufferBuilder builder, TMechascoutDragType dragTypeType)
		{
			builder.AddByte(1, (byte)dragTypeType, 0);
		}

		// Token: 0x06022146 RID: 139590 RVA: 0x004BAD1C File Offset: 0x004B8F1C
		public static void AddDragType(FlatBufferBuilder builder, int dragTypeOffset)
		{
			builder.AddOffset(2, dragTypeOffset, 0);
		}

		// Token: 0x06022147 RID: 139591 RVA: 0x004BAD27 File Offset: 0x004B8F27
		public static void AddTriggerPointList(FlatBufferBuilder builder, VectorOffset triggerPointListOffset)
		{
			builder.AddOffset(3, triggerPointListOffset.Value, 0);
		}

		// Token: 0x06022148 RID: 139592 RVA: 0x004BAD38 File Offset: 0x004B8F38
		public static VectorOffset CreateTriggerPointListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06022149 RID: 139593 RVA: 0x004BAD6F File Offset: 0x004B8F6F
		public static VectorOffset CreateTriggerPointListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602214A RID: 139594 RVA: 0x004BAD89 File Offset: 0x004B8F89
		public static VectorOffset CreateTriggerPointListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602214B RID: 139595 RVA: 0x004BADA7 File Offset: 0x004B8FA7
		public static VectorOffset CreateTriggerPointListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602214C RID: 139596 RVA: 0x004BADC0 File Offset: 0x004B8FC0
		public static void StartTriggerPointListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602214D RID: 139597 RVA: 0x004BADCB File Offset: 0x004B8FCB
		public static void AddFinishedActions(FlatBufferBuilder builder, VectorOffset finishedActionsOffset)
		{
			builder.AddOffset(4, finishedActionsOffset.Value, 0);
		}

		// Token: 0x0602214E RID: 139598 RVA: 0x004BADDC File Offset: 0x004B8FDC
		public static VectorOffset CreateFinishedActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602214F RID: 139599 RVA: 0x004BAE1C File Offset: 0x004B901C
		public static VectorOffset CreateFinishedActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022150 RID: 139600 RVA: 0x004BAE36 File Offset: 0x004B9036
		public static VectorOffset CreateFinishedActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022151 RID: 139601 RVA: 0x004BAE54 File Offset: 0x004B9054
		public static VectorOffset CreateFinishedActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022152 RID: 139602 RVA: 0x004BAE6D File Offset: 0x004B906D
		public static void StartFinishedActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022153 RID: 139603 RVA: 0x004BAE78 File Offset: 0x004B9078
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06022154 RID: 139604 RVA: 0x004BAE83 File Offset: 0x004B9083
		public static Offset<IExploreSkillMechascoutDrag> EndIExploreSkillMechascoutDrag(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillMechascoutDrag>(builder.EndTable());
		}

		// Token: 0x06022155 RID: 139605 RVA: 0x004BAE90 File Offset: 0x004B9090
		public IExploreSkillMechascoutDragT UnPack()
		{
			IExploreSkillMechascoutDragT exploreSkillMechascoutDragT = new IExploreSkillMechascoutDragT();
			this.UnPackTo(exploreSkillMechascoutDragT);
			return exploreSkillMechascoutDragT;
		}

		// Token: 0x06022156 RID: 139606 RVA: 0x004BAEAC File Offset: 0x004B90AC
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

		// Token: 0x06022157 RID: 139607 RVA: 0x004BAFF8 File Offset: 0x004B91F8
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

		// Token: 0x0400E321 RID: 58145
		private Table __p;
	}
}

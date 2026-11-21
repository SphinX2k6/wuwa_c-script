using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E65 RID: 24165
	public struct IRenjuConfig : IFlatbufferObject
	{
		// Token: 0x1700B230 RID: 45616
		// (get) Token: 0x0602866B RID: 165483 RVA: 0x00586261 File Offset: 0x00584461
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602866C RID: 165484 RVA: 0x0058626E File Offset: 0x0058446E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602866D RID: 165485 RVA: 0x00586278 File Offset: 0x00584478
		public static IRenjuConfig GetRootAsIRenjuConfig(ByteBuffer _bb)
		{
			return IRenjuConfig.GetRootAsIRenjuConfig(_bb, default(IRenjuConfig));
		}

		// Token: 0x0602866E RID: 165486 RVA: 0x00586294 File Offset: 0x00584494
		public static IRenjuConfig GetRootAsIRenjuConfig(ByteBuffer _bb, IRenjuConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602866F RID: 165487 RVA: 0x005862B1 File Offset: 0x005844B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028670 RID: 165488 RVA: 0x005862C0 File Offset: 0x005844C0
		public IRenjuConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B231 RID: 45617
		// (get) Token: 0x06028671 RID: 165489 RVA: 0x005862D0 File Offset: 0x005844D0
		public ERenjuController Controller
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERenjuController.Computer;
				}
				return (ERenjuController)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B232 RID: 45618
		// (get) Token: 0x06028672 RID: 165490 RVA: 0x0058630C File Offset: 0x0058450C
		public ERenjuOrder Order
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ERenjuOrder.Order0;
				}
				return (ERenjuOrder)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B233 RID: 45619
		// (get) Token: 0x06028673 RID: 165491 RVA: 0x00586348 File Offset: 0x00584548
		public int RenjuCount
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

		// Token: 0x06028674 RID: 165492 RVA: 0x00586384 File Offset: 0x00584584
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B234 RID: 45620
		// (get) Token: 0x06028675 RID: 165493 RVA: 0x005863C4 File Offset: 0x005845C4
		public int EntityIdsLength
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

		// Token: 0x06028676 RID: 165494 RVA: 0x005863F0 File Offset: 0x005845F0
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06028677 RID: 165495 RVA: 0x00586400 File Offset: 0x00584600
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x06028678 RID: 165496 RVA: 0x00586410 File Offset: 0x00584610
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B235 RID: 45621
		// (get) Token: 0x06028679 RID: 165497 RVA: 0x00586474 File Offset: 0x00584674
		public int ActionsLength
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

		// Token: 0x1700B236 RID: 45622
		// (get) Token: 0x0602867A RID: 165498 RVA: 0x005864A0 File Offset: 0x005846A0
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

		// Token: 0x0602867B RID: 165499 RVA: 0x005864DD File Offset: 0x005846DD
		public static Offset<IRenjuConfig> CreateIRenjuConfig(FlatBufferBuilder builder, ERenjuController Controller = ERenjuController.Computer, ERenjuOrder Order = ERenjuOrder.Order0, int RenjuCount = 0, VectorOffset EntityIdsOffset = default(VectorOffset), VectorOffset ActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IRenjuConfig.AddActions(builder, ActionsOffset);
			IRenjuConfig.AddEntityIds(builder, EntityIdsOffset);
			IRenjuConfig.AddRenjuCount(builder, RenjuCount);
			IRenjuConfig.AddNullMask(builder, NullMask);
			IRenjuConfig.AddOrder(builder, Order);
			IRenjuConfig.AddController(builder, Controller);
			return IRenjuConfig.EndIRenjuConfig(builder);
		}

		// Token: 0x0602867C RID: 165500 RVA: 0x00586519 File Offset: 0x00584719
		public static void StartIRenjuConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602867D RID: 165501 RVA: 0x00586522 File Offset: 0x00584722
		public static void AddController(FlatBufferBuilder builder, ERenjuController controller)
		{
			builder.AddByte(0, (byte)controller, 0);
		}

		// Token: 0x0602867E RID: 165502 RVA: 0x0058652D File Offset: 0x0058472D
		public static void AddOrder(FlatBufferBuilder builder, ERenjuOrder order)
		{
			builder.AddByte(1, (byte)order, 0);
		}

		// Token: 0x0602867F RID: 165503 RVA: 0x00586538 File Offset: 0x00584738
		public static void AddRenjuCount(FlatBufferBuilder builder, int renjuCount)
		{
			builder.AddInt(2, renjuCount, 0);
		}

		// Token: 0x06028680 RID: 165504 RVA: 0x00586543 File Offset: 0x00584743
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(3, entityIdsOffset.Value, 0);
		}

		// Token: 0x06028681 RID: 165505 RVA: 0x00586554 File Offset: 0x00584754
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06028682 RID: 165506 RVA: 0x0058658B File Offset: 0x0058478B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06028683 RID: 165507 RVA: 0x005865A5 File Offset: 0x005847A5
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06028684 RID: 165508 RVA: 0x005865C3 File Offset: 0x005847C3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028685 RID: 165509 RVA: 0x005865DC File Offset: 0x005847DC
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028686 RID: 165510 RVA: 0x005865E7 File Offset: 0x005847E7
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(4, actionsOffset.Value, 0);
		}

		// Token: 0x06028687 RID: 165511 RVA: 0x005865F8 File Offset: 0x005847F8
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06028688 RID: 165512 RVA: 0x00586638 File Offset: 0x00584838
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028689 RID: 165513 RVA: 0x00586652 File Offset: 0x00584852
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602868A RID: 165514 RVA: 0x00586670 File Offset: 0x00584870
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602868B RID: 165515 RVA: 0x00586689 File Offset: 0x00584889
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602868C RID: 165516 RVA: 0x00586694 File Offset: 0x00584894
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602868D RID: 165517 RVA: 0x0058669F File Offset: 0x0058489F
		public static Offset<IRenjuConfig> EndIRenjuConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRenjuConfig>(builder.EndTable());
		}

		// Token: 0x0602868E RID: 165518 RVA: 0x005866AC File Offset: 0x005848AC
		public IRenjuConfigT UnPack()
		{
			IRenjuConfigT renjuConfigT = new IRenjuConfigT();
			this.UnPackTo(renjuConfigT);
			return renjuConfigT;
		}

		// Token: 0x0602868F RID: 165519 RVA: 0x005866C8 File Offset: 0x005848C8
		public void UnPackTo(IRenjuConfigT _o)
		{
			_o.Controller = this.Controller;
			_o.Order = this.Order;
			_o.RenjuCount = this.RenjuCount;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.Actions = new List<IActionInfoT>();
			for (int j = 0; j < this.ActionsLength; j++)
			{
				_o.Actions.Add((this.Actions(j) != null) ? this.Actions(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06028690 RID: 165520 RVA: 0x00586788 File Offset: 0x00584988
		public static Offset<IRenjuConfig> Pack(FlatBufferBuilder builder, IRenjuConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRenjuConfig>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IRenjuConfig.CreateEntityIdsVector(builder, data);
			}
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = IRenjuConfig.CreateActionsVector(builder, array);
			}
			return IRenjuConfig.CreateIRenjuConfig(builder, _o.Controller, _o.Order, _o.RenjuCount, entityIdsOffset, actionsOffset, _o.NullMask);
		}

		// Token: 0x0400FA77 RID: 64119
		private Table __p;
	}
}

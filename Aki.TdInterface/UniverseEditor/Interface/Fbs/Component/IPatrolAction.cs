using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CF3 RID: 23795
	public struct IPatrolAction : IFlatbufferObject
	{
		// Token: 0x1700AEDF RID: 44767
		// (get) Token: 0x06027846 RID: 161862 RVA: 0x00568491 File Offset: 0x00566691
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027847 RID: 161863 RVA: 0x0056849E File Offset: 0x0056669E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027848 RID: 161864 RVA: 0x005684A8 File Offset: 0x005666A8
		public static IPatrolAction GetRootAsIPatrolAction(ByteBuffer _bb)
		{
			return IPatrolAction.GetRootAsIPatrolAction(_bb, default(IPatrolAction));
		}

		// Token: 0x06027849 RID: 161865 RVA: 0x005684C4 File Offset: 0x005666C4
		public static IPatrolAction GetRootAsIPatrolAction(ByteBuffer _bb, IPatrolAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602784A RID: 161866 RVA: 0x005684E1 File Offset: 0x005666E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602784B RID: 161867 RVA: 0x005684F0 File Offset: 0x005666F0
		public IPatrolAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AEE0 RID: 44768
		// (get) Token: 0x0602784C RID: 161868 RVA: 0x00568500 File Offset: 0x00566700
		public int Point
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602784D RID: 161869 RVA: 0x0056853C File Offset: 0x0056673C
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AEE1 RID: 44769
		// (get) Token: 0x0602784E RID: 161870 RVA: 0x0056859C File Offset: 0x0056679C
		public int ActionsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602784F RID: 161871 RVA: 0x005685C7 File Offset: 0x005667C7
		public static Offset<IPatrolAction> CreateIPatrolAction(FlatBufferBuilder builder, int Point = 0, VectorOffset ActionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IPatrolAction.AddActions(builder, ActionsOffset);
			IPatrolAction.AddPoint(builder, Point);
			return IPatrolAction.EndIPatrolAction(builder);
		}

		// Token: 0x06027850 RID: 161872 RVA: 0x005685E4 File Offset: 0x005667E4
		public static void StartIPatrolAction(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027851 RID: 161873 RVA: 0x005685ED File Offset: 0x005667ED
		public static void AddPoint(FlatBufferBuilder builder, int point)
		{
			builder.AddInt(0, point, 0);
		}

		// Token: 0x06027852 RID: 161874 RVA: 0x005685F8 File Offset: 0x005667F8
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(1, actionsOffset.Value, 0);
		}

		// Token: 0x06027853 RID: 161875 RVA: 0x00568608 File Offset: 0x00566808
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027854 RID: 161876 RVA: 0x00568648 File Offset: 0x00566848
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027855 RID: 161877 RVA: 0x00568662 File Offset: 0x00566862
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027856 RID: 161878 RVA: 0x00568680 File Offset: 0x00566880
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027857 RID: 161879 RVA: 0x00568699 File Offset: 0x00566899
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027858 RID: 161880 RVA: 0x005686A4 File Offset: 0x005668A4
		public static Offset<IPatrolAction> EndIPatrolAction(FlatBufferBuilder builder)
		{
			return new Offset<IPatrolAction>(builder.EndTable());
		}

		// Token: 0x06027859 RID: 161881 RVA: 0x005686B4 File Offset: 0x005668B4
		public IPatrolActionT UnPack()
		{
			IPatrolActionT patrolActionT = new IPatrolActionT();
			this.UnPackTo(patrolActionT);
			return patrolActionT;
		}

		// Token: 0x0602785A RID: 161882 RVA: 0x005686D0 File Offset: 0x005668D0
		public void UnPackTo(IPatrolActionT _o)
		{
			_o.Point = this.Point;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602785B RID: 161883 RVA: 0x0056873C File Offset: 0x0056693C
		public static Offset<IPatrolAction> Pack(FlatBufferBuilder builder, IPatrolActionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPatrolAction>);
			}
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = IPatrolAction.CreateActionsVector(builder, array);
			}
			return IPatrolAction.CreateIPatrolAction(builder, _o.Point, actionsOffset);
		}

		// Token: 0x0400F831 RID: 63537
		private Table __p;
	}
}

using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CF0 RID: 23792
	public struct IPatrol : IFlatbufferObject
	{
		// Token: 0x1700AED2 RID: 44754
		// (get) Token: 0x06027812 RID: 161810 RVA: 0x00567D86 File Offset: 0x00565F86
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027813 RID: 161811 RVA: 0x00567D93 File Offset: 0x00565F93
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027814 RID: 161812 RVA: 0x00567D9C File Offset: 0x00565F9C
		public static IPatrol GetRootAsIPatrol(ByteBuffer _bb)
		{
			return IPatrol.GetRootAsIPatrol(_bb, default(IPatrol));
		}

		// Token: 0x06027815 RID: 161813 RVA: 0x00567DB8 File Offset: 0x00565FB8
		public static IPatrol GetRootAsIPatrol(ByteBuffer _bb, IPatrol obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027816 RID: 161814 RVA: 0x00567DD5 File Offset: 0x00565FD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027817 RID: 161815 RVA: 0x00567DE4 File Offset: 0x00565FE4
		public IPatrol __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AED3 RID: 44755
		// (get) Token: 0x06027818 RID: 161816 RVA: 0x00567DF4 File Offset: 0x00565FF4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AED4 RID: 44756
		// (get) Token: 0x06027819 RID: 161817 RVA: 0x00567E34 File Offset: 0x00566034
		public int SplineEntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602781A RID: 161818 RVA: 0x00567E70 File Offset: 0x00566070
		public int SplineEntityIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700AED5 RID: 44757
		// (get) Token: 0x0602781B RID: 161819 RVA: 0x00567EB0 File Offset: 0x005660B0
		public int SplineEntityIdsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602781C RID: 161820 RVA: 0x00567EDB File Offset: 0x005660DB
		public Span<int> GetSplineEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0602781D RID: 161821 RVA: 0x00567EEA File Offset: 0x005660EA
		public int[] GetSplineEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x1700AED6 RID: 44758
		// (get) Token: 0x0602781E RID: 161822 RVA: 0x00567EF8 File Offset: 0x005660F8
		public bool IsCircle
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602781F RID: 161823 RVA: 0x00567F38 File Offset: 0x00566138
		public IPatrolAction? Actions(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IPatrolAction?(default(IPatrolAction).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AED7 RID: 44759
		// (get) Token: 0x06027820 RID: 161824 RVA: 0x00567F9C File Offset: 0x0056619C
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

		// Token: 0x1700AED8 RID: 44760
		// (get) Token: 0x06027821 RID: 161825 RVA: 0x00567FC8 File Offset: 0x005661C8
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

		// Token: 0x06027822 RID: 161826 RVA: 0x00568005 File Offset: 0x00566205
		public static Offset<IPatrol> CreateIPatrol(FlatBufferBuilder builder, bool Disabled = false, int SplineEntityId = 0, VectorOffset SplineEntityIdsOffset = default(VectorOffset), bool IsCircle = false, VectorOffset ActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IPatrol.AddActions(builder, ActionsOffset);
			IPatrol.AddSplineEntityIds(builder, SplineEntityIdsOffset);
			IPatrol.AddSplineEntityId(builder, SplineEntityId);
			IPatrol.AddNullMask(builder, NullMask);
			IPatrol.AddIsCircle(builder, IsCircle);
			IPatrol.AddDisabled(builder, Disabled);
			return IPatrol.EndIPatrol(builder);
		}

		// Token: 0x06027823 RID: 161827 RVA: 0x00568041 File Offset: 0x00566241
		public static void StartIPatrol(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06027824 RID: 161828 RVA: 0x0056804A File Offset: 0x0056624A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027825 RID: 161829 RVA: 0x00568055 File Offset: 0x00566255
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(1, splineEntityId, 0);
		}

		// Token: 0x06027826 RID: 161830 RVA: 0x00568060 File Offset: 0x00566260
		public static void AddSplineEntityIds(FlatBufferBuilder builder, VectorOffset splineEntityIdsOffset)
		{
			builder.AddOffset(2, splineEntityIdsOffset.Value, 0);
		}

		// Token: 0x06027827 RID: 161831 RVA: 0x00568070 File Offset: 0x00566270
		public static VectorOffset CreateSplineEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06027828 RID: 161832 RVA: 0x005680A7 File Offset: 0x005662A7
		public static VectorOffset CreateSplineEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06027829 RID: 161833 RVA: 0x005680C1 File Offset: 0x005662C1
		public static VectorOffset CreateSplineEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602782A RID: 161834 RVA: 0x005680DF File Offset: 0x005662DF
		public static VectorOffset CreateSplineEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602782B RID: 161835 RVA: 0x005680F8 File Offset: 0x005662F8
		public static void StartSplineEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602782C RID: 161836 RVA: 0x00568103 File Offset: 0x00566303
		public static void AddIsCircle(FlatBufferBuilder builder, bool isCircle)
		{
			builder.AddBool(3, isCircle, false);
		}

		// Token: 0x0602782D RID: 161837 RVA: 0x0056810E File Offset: 0x0056630E
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(4, actionsOffset.Value, 0);
		}

		// Token: 0x0602782E RID: 161838 RVA: 0x00568120 File Offset: 0x00566320
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IPatrolAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602782F RID: 161839 RVA: 0x00568160 File Offset: 0x00566360
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IPatrolAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPatrolAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027830 RID: 161840 RVA: 0x0056817A File Offset: 0x0056637A
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPatrolAction>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPatrolAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027831 RID: 161841 RVA: 0x00568198 File Offset: 0x00566398
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPatrolAction>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027832 RID: 161842 RVA: 0x005681B1 File Offset: 0x005663B1
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027833 RID: 161843 RVA: 0x005681BC File Offset: 0x005663BC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06027834 RID: 161844 RVA: 0x005681C7 File Offset: 0x005663C7
		public static Offset<IPatrol> EndIPatrol(FlatBufferBuilder builder)
		{
			return new Offset<IPatrol>(builder.EndTable());
		}

		// Token: 0x06027835 RID: 161845 RVA: 0x005681D4 File Offset: 0x005663D4
		public IPatrolT UnPack()
		{
			IPatrolT patrolT = new IPatrolT();
			this.UnPackTo(patrolT);
			return patrolT;
		}

		// Token: 0x06027836 RID: 161846 RVA: 0x005681F0 File Offset: 0x005663F0
		public void UnPackTo(IPatrolT _o)
		{
			_o.Disabled = this.Disabled;
			_o.SplineEntityId = this.SplineEntityId;
			_o.SplineEntityIds = new List<int>();
			for (int i = 0; i < this.SplineEntityIdsLength; i++)
			{
				_o.SplineEntityIds.Add(this.SplineEntityIds(i));
			}
			_o.IsCircle = this.IsCircle;
			_o.Actions = new List<IPatrolActionT>();
			for (int j = 0; j < this.ActionsLength; j++)
			{
				_o.Actions.Add((this.Actions(j) != null) ? this.Actions(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027837 RID: 161847 RVA: 0x005682B0 File Offset: 0x005664B0
		public static Offset<IPatrol> Pack(FlatBufferBuilder builder, IPatrolT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPatrol>);
			}
			VectorOffset splineEntityIdsOffset = default(VectorOffset);
			if (_o.SplineEntityIds != null)
			{
				int[] data = _o.SplineEntityIds.ToArray();
				splineEntityIdsOffset = IPatrol.CreateSplineEntityIdsVector(builder, data);
			}
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IPatrolAction>[] array = new Offset<IPatrolAction>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IPatrolAction.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = IPatrol.CreateActionsVector(builder, array);
			}
			return IPatrol.CreateIPatrol(builder, _o.Disabled, _o.SplineEntityId, splineEntityIdsOffset, _o.IsCircle, actionsOffset, _o.NullMask);
		}

		// Token: 0x0400F82A RID: 63530
		private Table __p;
	}
}

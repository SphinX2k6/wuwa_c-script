using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005701 RID: 22273
	public struct IPatrol : IFlatbufferObject
	{
		// Token: 0x1700A5CF RID: 42447
		// (get) Token: 0x060253AB RID: 152491 RVA: 0x0052333A File Offset: 0x0052153A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060253AC RID: 152492 RVA: 0x00523347 File Offset: 0x00521547
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060253AD RID: 152493 RVA: 0x00523350 File Offset: 0x00521550
		public static IPatrol GetRootAsIPatrol(ByteBuffer _bb)
		{
			return IPatrol.GetRootAsIPatrol(_bb, default(IPatrol));
		}

		// Token: 0x060253AE RID: 152494 RVA: 0x0052336C File Offset: 0x0052156C
		public static IPatrol GetRootAsIPatrol(ByteBuffer _bb, IPatrol obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060253AF RID: 152495 RVA: 0x00523389 File Offset: 0x00521589
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060253B0 RID: 152496 RVA: 0x00523398 File Offset: 0x00521598
		public IPatrol __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A5D0 RID: 42448
		// (get) Token: 0x060253B1 RID: 152497 RVA: 0x005233A8 File Offset: 0x005215A8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A5D1 RID: 42449
		// (get) Token: 0x060253B2 RID: 152498 RVA: 0x005233E8 File Offset: 0x005215E8
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

		// Token: 0x060253B3 RID: 152499 RVA: 0x00523424 File Offset: 0x00521624
		public int SplineEntityIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A5D2 RID: 42450
		// (get) Token: 0x060253B4 RID: 152500 RVA: 0x00523464 File Offset: 0x00521664
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

		// Token: 0x060253B5 RID: 152501 RVA: 0x0052348F File Offset: 0x0052168F
		public Span<int> GetSplineEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060253B6 RID: 152502 RVA: 0x0052349E File Offset: 0x0052169E
		public int[] GetSplineEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x1700A5D3 RID: 42451
		// (get) Token: 0x060253B7 RID: 152503 RVA: 0x005234AC File Offset: 0x005216AC
		public bool IsCircle
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060253B8 RID: 152504 RVA: 0x005234EC File Offset: 0x005216EC
		public IPatrolAction? Actions(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IPatrolAction?(default(IPatrolAction).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A5D4 RID: 42452
		// (get) Token: 0x060253B9 RID: 152505 RVA: 0x00523550 File Offset: 0x00521750
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

		// Token: 0x1700A5D5 RID: 42453
		// (get) Token: 0x060253BA RID: 152506 RVA: 0x0052357C File Offset: 0x0052177C
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

		// Token: 0x060253BB RID: 152507 RVA: 0x005235B9 File Offset: 0x005217B9
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

		// Token: 0x060253BC RID: 152508 RVA: 0x005235F5 File Offset: 0x005217F5
		public static void StartIPatrol(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060253BD RID: 152509 RVA: 0x005235FE File Offset: 0x005217FE
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060253BE RID: 152510 RVA: 0x00523609 File Offset: 0x00521809
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(1, splineEntityId, 0);
		}

		// Token: 0x060253BF RID: 152511 RVA: 0x00523614 File Offset: 0x00521814
		public static void AddSplineEntityIds(FlatBufferBuilder builder, VectorOffset splineEntityIdsOffset)
		{
			builder.AddOffset(2, splineEntityIdsOffset.Value, 0);
		}

		// Token: 0x060253C0 RID: 152512 RVA: 0x00523624 File Offset: 0x00521824
		public static VectorOffset CreateSplineEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060253C1 RID: 152513 RVA: 0x0052365B File Offset: 0x0052185B
		public static VectorOffset CreateSplineEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060253C2 RID: 152514 RVA: 0x00523675 File Offset: 0x00521875
		public static VectorOffset CreateSplineEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060253C3 RID: 152515 RVA: 0x00523693 File Offset: 0x00521893
		public static VectorOffset CreateSplineEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060253C4 RID: 152516 RVA: 0x005236AC File Offset: 0x005218AC
		public static void StartSplineEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060253C5 RID: 152517 RVA: 0x005236B7 File Offset: 0x005218B7
		public static void AddIsCircle(FlatBufferBuilder builder, bool isCircle)
		{
			builder.AddBool(3, isCircle, false);
		}

		// Token: 0x060253C6 RID: 152518 RVA: 0x005236C2 File Offset: 0x005218C2
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(4, actionsOffset.Value, 0);
		}

		// Token: 0x060253C7 RID: 152519 RVA: 0x005236D4 File Offset: 0x005218D4
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IPatrolAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060253C8 RID: 152520 RVA: 0x00523714 File Offset: 0x00521914
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IPatrolAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPatrolAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x060253C9 RID: 152521 RVA: 0x0052372E File Offset: 0x0052192E
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPatrolAction>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPatrolAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x060253CA RID: 152522 RVA: 0x0052374C File Offset: 0x0052194C
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPatrolAction>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060253CB RID: 152523 RVA: 0x00523765 File Offset: 0x00521965
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060253CC RID: 152524 RVA: 0x00523770 File Offset: 0x00521970
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060253CD RID: 152525 RVA: 0x0052377B File Offset: 0x0052197B
		public static Offset<IPatrol> EndIPatrol(FlatBufferBuilder builder)
		{
			return new Offset<IPatrol>(builder.EndTable());
		}

		// Token: 0x060253CE RID: 152526 RVA: 0x00523788 File Offset: 0x00521988
		public IPatrolT UnPack()
		{
			IPatrolT patrolT = new IPatrolT();
			this.UnPackTo(patrolT);
			return patrolT;
		}

		// Token: 0x060253CF RID: 152527 RVA: 0x005237A4 File Offset: 0x005219A4
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

		// Token: 0x060253D0 RID: 152528 RVA: 0x00523864 File Offset: 0x00521A64
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

		// Token: 0x0400EB5D RID: 60253
		private Table __p;
	}
}

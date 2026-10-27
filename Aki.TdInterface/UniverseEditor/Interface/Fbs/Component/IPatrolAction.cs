using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005704 RID: 22276
	public struct IPatrolAction : IFlatbufferObject
	{
		// Token: 0x1700A5DC RID: 42460
		// (get) Token: 0x060253DF RID: 152543 RVA: 0x00523A45 File Offset: 0x00521C45
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060253E0 RID: 152544 RVA: 0x00523A52 File Offset: 0x00521C52
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060253E1 RID: 152545 RVA: 0x00523A5C File Offset: 0x00521C5C
		public static IPatrolAction GetRootAsIPatrolAction(ByteBuffer _bb)
		{
			return IPatrolAction.GetRootAsIPatrolAction(_bb, default(IPatrolAction));
		}

		// Token: 0x060253E2 RID: 152546 RVA: 0x00523A78 File Offset: 0x00521C78
		public static IPatrolAction GetRootAsIPatrolAction(ByteBuffer _bb, IPatrolAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060253E3 RID: 152547 RVA: 0x00523A95 File Offset: 0x00521C95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060253E4 RID: 152548 RVA: 0x00523AA4 File Offset: 0x00521CA4
		public IPatrolAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A5DD RID: 42461
		// (get) Token: 0x060253E5 RID: 152549 RVA: 0x00523AB4 File Offset: 0x00521CB4
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

		// Token: 0x060253E6 RID: 152550 RVA: 0x00523AF0 File Offset: 0x00521CF0
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A5DE RID: 42462
		// (get) Token: 0x060253E7 RID: 152551 RVA: 0x00523B50 File Offset: 0x00521D50
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

		// Token: 0x060253E8 RID: 152552 RVA: 0x00523B7B File Offset: 0x00521D7B
		public static Offset<IPatrolAction> CreateIPatrolAction(FlatBufferBuilder builder, int Point = 0, VectorOffset ActionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IPatrolAction.AddActions(builder, ActionsOffset);
			IPatrolAction.AddPoint(builder, Point);
			return IPatrolAction.EndIPatrolAction(builder);
		}

		// Token: 0x060253E9 RID: 152553 RVA: 0x00523B98 File Offset: 0x00521D98
		public static void StartIPatrolAction(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060253EA RID: 152554 RVA: 0x00523BA1 File Offset: 0x00521DA1
		public static void AddPoint(FlatBufferBuilder builder, int point)
		{
			builder.AddInt(0, point, 0);
		}

		// Token: 0x060253EB RID: 152555 RVA: 0x00523BAC File Offset: 0x00521DAC
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(1, actionsOffset.Value, 0);
		}

		// Token: 0x060253EC RID: 152556 RVA: 0x00523BBC File Offset: 0x00521DBC
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060253ED RID: 152557 RVA: 0x00523BFC File Offset: 0x00521DFC
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060253EE RID: 152558 RVA: 0x00523C16 File Offset: 0x00521E16
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060253EF RID: 152559 RVA: 0x00523C34 File Offset: 0x00521E34
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060253F0 RID: 152560 RVA: 0x00523C4D File Offset: 0x00521E4D
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060253F1 RID: 152561 RVA: 0x00523C58 File Offset: 0x00521E58
		public static Offset<IPatrolAction> EndIPatrolAction(FlatBufferBuilder builder)
		{
			return new Offset<IPatrolAction>(builder.EndTable());
		}

		// Token: 0x060253F2 RID: 152562 RVA: 0x00523C68 File Offset: 0x00521E68
		public IPatrolActionT UnPack()
		{
			IPatrolActionT patrolActionT = new IPatrolActionT();
			this.UnPackTo(patrolActionT);
			return patrolActionT;
		}

		// Token: 0x060253F3 RID: 152563 RVA: 0x00523C84 File Offset: 0x00521E84
		public void UnPackTo(IPatrolActionT _o)
		{
			_o.Point = this.Point;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060253F4 RID: 152564 RVA: 0x00523CF0 File Offset: 0x00521EF0
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

		// Token: 0x0400EB64 RID: 60260
		private Table __p;
	}
}

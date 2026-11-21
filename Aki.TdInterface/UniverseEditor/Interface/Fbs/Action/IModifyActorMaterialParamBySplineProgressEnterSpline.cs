using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071DD RID: 29149
	public struct IModifyActorMaterialParamBySplineProgressEnterSpline : IFlatbufferObject
	{
		// Token: 0x1700D566 RID: 54630
		// (get) Token: 0x06032B3C RID: 207676 RVA: 0x006D95C4 File Offset: 0x006D77C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032B3D RID: 207677 RVA: 0x006D95D1 File Offset: 0x006D77D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032B3E RID: 207678 RVA: 0x006D95D8 File Offset: 0x006D77D8
		public static IModifyActorMaterialParamBySplineProgressEnterSpline GetRootAsIModifyActorMaterialParamBySplineProgressEnterSpline(ByteBuffer _bb)
		{
			return IModifyActorMaterialParamBySplineProgressEnterSpline.GetRootAsIModifyActorMaterialParamBySplineProgressEnterSpline(_bb, default(IModifyActorMaterialParamBySplineProgressEnterSpline));
		}

		// Token: 0x06032B3F RID: 207679 RVA: 0x006D95F4 File Offset: 0x006D77F4
		public static IModifyActorMaterialParamBySplineProgressEnterSpline GetRootAsIModifyActorMaterialParamBySplineProgressEnterSpline(ByteBuffer _bb, IModifyActorMaterialParamBySplineProgressEnterSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032B40 RID: 207680 RVA: 0x006D9611 File Offset: 0x006D7811
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032B41 RID: 207681 RVA: 0x006D9620 File Offset: 0x006D7820
		public IModifyActorMaterialParamBySplineProgressEnterSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D567 RID: 54631
		// (get) Token: 0x06032B42 RID: 207682 RVA: 0x006D9630 File Offset: 0x006D7830
		public EModifyActorMaterialParamBySplineProgressType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EModifyActorMaterialParamBySplineProgressType.EnterSpline;
				}
				return (EModifyActorMaterialParamBySplineProgressType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D568 RID: 54632
		// (get) Token: 0x06032B43 RID: 207683 RVA: 0x006D966C File Offset: 0x006D786C
		public TModifyActorMaterialParamBySplineProgressTarget MoveTargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TModifyActorMaterialParamBySplineProgressTarget.NONE;
				}
				return (TModifyActorMaterialParamBySplineProgressTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032B44 RID: 207684 RVA: 0x006D96A8 File Offset: 0x006D78A8
		public TTable? MoveTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06032B45 RID: 207685 RVA: 0x006D96EC File Offset: 0x006D78EC
		public IModifyActorMaterialParamByEntitySplineProgress MoveTargetAsIModifyActorMaterialParamByEntitySplineProgress()
		{
			return this.MoveTarget<IModifyActorMaterialParamByEntitySplineProgress>().Value;
		}

		// Token: 0x06032B46 RID: 207686 RVA: 0x006D9708 File Offset: 0x006D7908
		public IModifyActorMaterialParamByPlayerSplineProgress MoveTargetAsIModifyActorMaterialParamByPlayerSplineProgress()
		{
			return this.MoveTarget<IModifyActorMaterialParamByPlayerSplineProgress>().Value;
		}

		// Token: 0x1700D569 RID: 54633
		// (get) Token: 0x06032B47 RID: 207687 RVA: 0x006D9724 File Offset: 0x006D7924
		public int SplineEntityId
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

		// Token: 0x06032B48 RID: 207688 RVA: 0x006D9764 File Offset: 0x006D7964
		public IActorRefWithMaterialParam? ActorRefs(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IActorRefWithMaterialParam?(default(IActorRefWithMaterialParam).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D56A RID: 54634
		// (get) Token: 0x06032B49 RID: 207689 RVA: 0x006D97C8 File Offset: 0x006D79C8
		public int ActorRefsLength
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

		// Token: 0x06032B4A RID: 207690 RVA: 0x006D97F4 File Offset: 0x006D79F4
		public static Offset<IModifyActorMaterialParamBySplineProgressEnterSpline> CreateIModifyActorMaterialParamBySplineProgressEnterSpline(FlatBufferBuilder builder, EModifyActorMaterialParamBySplineProgressType Type = EModifyActorMaterialParamBySplineProgressType.EnterSpline, TModifyActorMaterialParamBySplineProgressTarget MoveTarget_type = TModifyActorMaterialParamBySplineProgressTarget.NONE, int MoveTargetOffset = 0, int SplineEntityId = 0, VectorOffset ActorRefsOffset = default(VectorOffset))
		{
			builder.StartTable(5);
			IModifyActorMaterialParamBySplineProgressEnterSpline.AddActorRefs(builder, ActorRefsOffset);
			IModifyActorMaterialParamBySplineProgressEnterSpline.AddSplineEntityId(builder, SplineEntityId);
			IModifyActorMaterialParamBySplineProgressEnterSpline.AddMoveTarget(builder, MoveTargetOffset);
			IModifyActorMaterialParamBySplineProgressEnterSpline.AddMoveTargetType(builder, MoveTarget_type);
			IModifyActorMaterialParamBySplineProgressEnterSpline.AddType(builder, Type);
			return IModifyActorMaterialParamBySplineProgressEnterSpline.EndIModifyActorMaterialParamBySplineProgressEnterSpline(builder);
		}

		// Token: 0x06032B4B RID: 207691 RVA: 0x006D9828 File Offset: 0x006D7A28
		public static void StartIModifyActorMaterialParamBySplineProgressEnterSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06032B4C RID: 207692 RVA: 0x006D9831 File Offset: 0x006D7A31
		public static void AddType(FlatBufferBuilder builder, EModifyActorMaterialParamBySplineProgressType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032B4D RID: 207693 RVA: 0x006D983C File Offset: 0x006D7A3C
		public static void AddMoveTargetType(FlatBufferBuilder builder, TModifyActorMaterialParamBySplineProgressTarget moveTargetType)
		{
			builder.AddByte(1, (byte)moveTargetType, 0);
		}

		// Token: 0x06032B4E RID: 207694 RVA: 0x006D9847 File Offset: 0x006D7A47
		public static void AddMoveTarget(FlatBufferBuilder builder, int moveTargetOffset)
		{
			builder.AddOffset(2, moveTargetOffset, 0);
		}

		// Token: 0x06032B4F RID: 207695 RVA: 0x006D9852 File Offset: 0x006D7A52
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(3, splineEntityId, 0);
		}

		// Token: 0x06032B50 RID: 207696 RVA: 0x006D985D File Offset: 0x006D7A5D
		public static void AddActorRefs(FlatBufferBuilder builder, VectorOffset actorRefsOffset)
		{
			builder.AddOffset(4, actorRefsOffset.Value, 0);
		}

		// Token: 0x06032B51 RID: 207697 RVA: 0x006D9870 File Offset: 0x006D7A70
		public static VectorOffset CreateActorRefsVector(FlatBufferBuilder builder, Offset<IActorRefWithMaterialParam>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06032B52 RID: 207698 RVA: 0x006D98B0 File Offset: 0x006D7AB0
		public static VectorOffset CreateActorRefsVectorBlock(FlatBufferBuilder builder, Offset<IActorRefWithMaterialParam>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorRefWithMaterialParam>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032B53 RID: 207699 RVA: 0x006D98CA File Offset: 0x006D7ACA
		public static VectorOffset CreateActorRefsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorRefWithMaterialParam>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorRefWithMaterialParam>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032B54 RID: 207700 RVA: 0x006D98E8 File Offset: 0x006D7AE8
		public static VectorOffset CreateActorRefsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorRefWithMaterialParam>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032B55 RID: 207701 RVA: 0x006D9901 File Offset: 0x006D7B01
		public static void StartActorRefsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032B56 RID: 207702 RVA: 0x006D990C File Offset: 0x006D7B0C
		public static Offset<IModifyActorMaterialParamBySplineProgressEnterSpline> EndIModifyActorMaterialParamBySplineProgressEnterSpline(FlatBufferBuilder builder)
		{
			return new Offset<IModifyActorMaterialParamBySplineProgressEnterSpline>(builder.EndTable());
		}

		// Token: 0x06032B57 RID: 207703 RVA: 0x006D991C File Offset: 0x006D7B1C
		public IModifyActorMaterialParamBySplineProgressEnterSplineT UnPack()
		{
			IModifyActorMaterialParamBySplineProgressEnterSplineT modifyActorMaterialParamBySplineProgressEnterSplineT = new IModifyActorMaterialParamBySplineProgressEnterSplineT();
			this.UnPackTo(modifyActorMaterialParamBySplineProgressEnterSplineT);
			return modifyActorMaterialParamBySplineProgressEnterSplineT;
		}

		// Token: 0x06032B58 RID: 207704 RVA: 0x006D9938 File Offset: 0x006D7B38
		public void UnPackTo(IModifyActorMaterialParamBySplineProgressEnterSplineT _o)
		{
			_o.Type = this.Type;
			_o.MoveTarget = new TModifyActorMaterialParamBySplineProgressTargetUnion();
			_o.MoveTarget.Type = this.MoveTargetType;
			TModifyActorMaterialParamBySplineProgressTarget moveTargetType = this.MoveTargetType;
			if (moveTargetType != TModifyActorMaterialParamBySplineProgressTarget.IModifyActorMaterialParamByEntitySplineProgress)
			{
				if (moveTargetType == TModifyActorMaterialParamBySplineProgressTarget.IModifyActorMaterialParamByPlayerSplineProgress)
				{
					_o.MoveTarget.Value = ((this.MoveTarget<IModifyActorMaterialParamByPlayerSplineProgress>() != null) ? this.MoveTarget<IModifyActorMaterialParamByPlayerSplineProgress>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.MoveTarget.Value = ((this.MoveTarget<IModifyActorMaterialParamByEntitySplineProgress>() != null) ? this.MoveTarget<IModifyActorMaterialParamByEntitySplineProgress>().Value.UnPack() : null);
			}
			_o.SplineEntityId = this.SplineEntityId;
			_o.ActorRefs = new List<IActorRefWithMaterialParamT>();
			for (int i = 0; i < this.ActorRefsLength; i++)
			{
				_o.ActorRefs.Add((this.ActorRefs(i) != null) ? this.ActorRefs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06032B59 RID: 207705 RVA: 0x006D9A50 File Offset: 0x006D7C50
		public static Offset<IModifyActorMaterialParamBySplineProgressEnterSpline> Pack(FlatBufferBuilder builder, IModifyActorMaterialParamBySplineProgressEnterSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IModifyActorMaterialParamBySplineProgressEnterSpline>);
			}
			TModifyActorMaterialParamBySplineProgressTarget moveTarget_type = (_o.MoveTarget == null) ? TModifyActorMaterialParamBySplineProgressTarget.NONE : _o.MoveTarget.Type;
			int moveTargetOffset = (_o.MoveTarget == null) ? 0 : TModifyActorMaterialParamBySplineProgressTargetUnion.Pack(builder, _o.MoveTarget);
			VectorOffset actorRefsOffset = default(VectorOffset);
			if (_o.ActorRefs != null)
			{
				Offset<IActorRefWithMaterialParam>[] array = new Offset<IActorRefWithMaterialParam>[_o.ActorRefs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActorRefWithMaterialParam.Pack(builder, _o.ActorRefs[i]);
				}
				actorRefsOffset = IModifyActorMaterialParamBySplineProgressEnterSpline.CreateActorRefsVector(builder, array);
			}
			return IModifyActorMaterialParamBySplineProgressEnterSpline.CreateIModifyActorMaterialParamBySplineProgressEnterSpline(builder, _o.Type, moveTarget_type, moveTargetOffset, _o.SplineEntityId, actorRefsOffset);
		}

		// Token: 0x040121F2 RID: 74226
		private Table __p;
	}
}

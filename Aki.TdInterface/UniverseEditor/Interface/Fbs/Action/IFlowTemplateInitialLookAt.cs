using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EAB RID: 28331
	public struct IFlowTemplateInitialLookAt : IFlatbufferObject
	{
		// Token: 0x1700CFD1 RID: 53201
		// (get) Token: 0x06031028 RID: 200744 RVA: 0x006A5B5C File Offset: 0x006A3D5C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031029 RID: 200745 RVA: 0x006A5B69 File Offset: 0x006A3D69
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603102A RID: 200746 RVA: 0x006A5B70 File Offset: 0x006A3D70
		public static IFlowTemplateInitialLookAt GetRootAsIFlowTemplateInitialLookAt(ByteBuffer _bb)
		{
			return IFlowTemplateInitialLookAt.GetRootAsIFlowTemplateInitialLookAt(_bb, default(IFlowTemplateInitialLookAt));
		}

		// Token: 0x0603102B RID: 200747 RVA: 0x006A5B8C File Offset: 0x006A3D8C
		public static IFlowTemplateInitialLookAt GetRootAsIFlowTemplateInitialLookAt(ByteBuffer _bb, IFlowTemplateInitialLookAt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603102C RID: 200748 RVA: 0x006A5BA9 File Offset: 0x006A3DA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603102D RID: 200749 RVA: 0x006A5BB8 File Offset: 0x006A3DB8
		public IFlowTemplateInitialLookAt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CFD2 RID: 53202
		// (get) Token: 0x0603102E RID: 200750 RVA: 0x006A5BC8 File Offset: 0x006A3DC8
		public int ActorIndex
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

		// Token: 0x1700CFD3 RID: 53203
		// (get) Token: 0x0603102F RID: 200751 RVA: 0x006A5C04 File Offset: 0x006A3E04
		public TActorLookAtData TargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TActorLookAtData.NONE;
				}
				return (TActorLookAtData)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031030 RID: 200752 RVA: 0x006A5C40 File Offset: 0x006A3E40
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06031031 RID: 200753 RVA: 0x006A5C84 File Offset: 0x006A3E84
		public IActorLookAtEmptyData TargetAsIActorLookAtEmptyData()
		{
			return this.Target<IActorLookAtEmptyData>().Value;
		}

		// Token: 0x06031032 RID: 200754 RVA: 0x006A5CA0 File Offset: 0x006A3EA0
		public IActorLookAtEntityData TargetAsIActorLookAtEntityData()
		{
			return this.Target<IActorLookAtEntityData>().Value;
		}

		// Token: 0x06031033 RID: 200755 RVA: 0x006A5CBC File Offset: 0x006A3EBC
		public IActorLookAtOtherActor TargetAsIActorLookAtOtherActor()
		{
			return this.Target<IActorLookAtOtherActor>().Value;
		}

		// Token: 0x06031034 RID: 200756 RVA: 0x006A5CD8 File Offset: 0x006A3ED8
		public IActorLookAtPlayerData TargetAsIActorLookAtPlayerData()
		{
			return this.Target<IActorLookAtPlayerData>().Value;
		}

		// Token: 0x06031035 RID: 200757 RVA: 0x006A5CF4 File Offset: 0x006A3EF4
		public IActorLookAtPositionData TargetAsIActorLookAtPositionData()
		{
			return this.Target<IActorLookAtPositionData>().Value;
		}

		// Token: 0x06031036 RID: 200758 RVA: 0x006A5D10 File Offset: 0x006A3F10
		public IActorLookAtTalkerData TargetAsIActorLookAtTalkerData()
		{
			return this.Target<IActorLookAtTalkerData>().Value;
		}

		// Token: 0x06031037 RID: 200759 RVA: 0x006A5D2C File Offset: 0x006A3F2C
		public IActorLookAtUnLock TargetAsIActorLookAtUnLock()
		{
			return this.Target<IActorLookAtUnLock>().Value;
		}

		// Token: 0x06031038 RID: 200760 RVA: 0x006A5D47 File Offset: 0x006A3F47
		public static Offset<IFlowTemplateInitialLookAt> CreateIFlowTemplateInitialLookAt(FlatBufferBuilder builder, int ActorIndex = 0, TActorLookAtData Target_type = TActorLookAtData.NONE, int TargetOffset = 0)
		{
			builder.StartTable(3);
			IFlowTemplateInitialLookAt.AddTarget(builder, TargetOffset);
			IFlowTemplateInitialLookAt.AddActorIndex(builder, ActorIndex);
			IFlowTemplateInitialLookAt.AddTargetType(builder, Target_type);
			return IFlowTemplateInitialLookAt.EndIFlowTemplateInitialLookAt(builder);
		}

		// Token: 0x06031039 RID: 200761 RVA: 0x006A5D6B File Offset: 0x006A3F6B
		public static void StartIFlowTemplateInitialLookAt(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603103A RID: 200762 RVA: 0x006A5D74 File Offset: 0x006A3F74
		public static void AddActorIndex(FlatBufferBuilder builder, int actorIndex)
		{
			builder.AddInt(0, actorIndex, 0);
		}

		// Token: 0x0603103B RID: 200763 RVA: 0x006A5D7F File Offset: 0x006A3F7F
		public static void AddTargetType(FlatBufferBuilder builder, TActorLookAtData targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0603103C RID: 200764 RVA: 0x006A5D8A File Offset: 0x006A3F8A
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0603103D RID: 200765 RVA: 0x006A5D95 File Offset: 0x006A3F95
		public static Offset<IFlowTemplateInitialLookAt> EndIFlowTemplateInitialLookAt(FlatBufferBuilder builder)
		{
			return new Offset<IFlowTemplateInitialLookAt>(builder.EndTable());
		}

		// Token: 0x0603103E RID: 200766 RVA: 0x006A5DA4 File Offset: 0x006A3FA4
		public IFlowTemplateInitialLookAtT UnPack()
		{
			IFlowTemplateInitialLookAtT flowTemplateInitialLookAtT = new IFlowTemplateInitialLookAtT();
			this.UnPackTo(flowTemplateInitialLookAtT);
			return flowTemplateInitialLookAtT;
		}

		// Token: 0x0603103F RID: 200767 RVA: 0x006A5DC0 File Offset: 0x006A3FC0
		public void UnPackTo(IFlowTemplateInitialLookAtT _o)
		{
			_o.ActorIndex = this.ActorIndex;
			_o.Target = new TActorLookAtDataUnion();
			_o.Target.Type = this.TargetType;
			switch (this.TargetType)
			{
			case TActorLookAtData.IActorLookAtEmptyData:
				_o.Target.Value = ((this.Target<IActorLookAtEmptyData>() != null) ? this.Target<IActorLookAtEmptyData>().Value.UnPack() : null);
				return;
			case TActorLookAtData.IActorLookAtEntityData:
				_o.Target.Value = ((this.Target<IActorLookAtEntityData>() != null) ? this.Target<IActorLookAtEntityData>().Value.UnPack() : null);
				return;
			case TActorLookAtData.IActorLookAtOtherActor:
				_o.Target.Value = ((this.Target<IActorLookAtOtherActor>() != null) ? this.Target<IActorLookAtOtherActor>().Value.UnPack() : null);
				return;
			case TActorLookAtData.IActorLookAtPlayerData:
				_o.Target.Value = ((this.Target<IActorLookAtPlayerData>() != null) ? this.Target<IActorLookAtPlayerData>().Value.UnPack() : null);
				return;
			case TActorLookAtData.IActorLookAtPositionData:
				_o.Target.Value = ((this.Target<IActorLookAtPositionData>() != null) ? this.Target<IActorLookAtPositionData>().Value.UnPack() : null);
				return;
			case TActorLookAtData.IActorLookAtTalkerData:
				_o.Target.Value = ((this.Target<IActorLookAtTalkerData>() != null) ? this.Target<IActorLookAtTalkerData>().Value.UnPack() : null);
				return;
			case TActorLookAtData.IActorLookAtUnLock:
				_o.Target.Value = ((this.Target<IActorLookAtUnLock>() != null) ? this.Target<IActorLookAtUnLock>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06031040 RID: 200768 RVA: 0x006A5FA4 File Offset: 0x006A41A4
		public static Offset<IFlowTemplateInitialLookAt> Pack(FlatBufferBuilder builder, IFlowTemplateInitialLookAtT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowTemplateInitialLookAt>);
			}
			TActorLookAtData target_type = (_o.Target == null) ? TActorLookAtData.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TActorLookAtDataUnion.Pack(builder, _o.Target);
			return IFlowTemplateInitialLookAt.CreateIFlowTemplateInitialLookAt(builder, _o.ActorIndex, target_type, targetOffset);
		}

		// Token: 0x04011D9F RID: 73119
		private Table __p;
	}
}

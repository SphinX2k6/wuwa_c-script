using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006825 RID: 26661
	public struct IFlowTemplateInitialLookAt : IFlatbufferObject
	{
		// Token: 0x1700C60D RID: 50701
		// (get) Token: 0x0602E7A0 RID: 190368 RVA: 0x00657C1C File Offset: 0x00655E1C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E7A1 RID: 190369 RVA: 0x00657C29 File Offset: 0x00655E29
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E7A2 RID: 190370 RVA: 0x00657C30 File Offset: 0x00655E30
		public static IFlowTemplateInitialLookAt GetRootAsIFlowTemplateInitialLookAt(ByteBuffer _bb)
		{
			return IFlowTemplateInitialLookAt.GetRootAsIFlowTemplateInitialLookAt(_bb, default(IFlowTemplateInitialLookAt));
		}

		// Token: 0x0602E7A3 RID: 190371 RVA: 0x00657C4C File Offset: 0x00655E4C
		public static IFlowTemplateInitialLookAt GetRootAsIFlowTemplateInitialLookAt(ByteBuffer _bb, IFlowTemplateInitialLookAt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E7A4 RID: 190372 RVA: 0x00657C69 File Offset: 0x00655E69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E7A5 RID: 190373 RVA: 0x00657C78 File Offset: 0x00655E78
		public IFlowTemplateInitialLookAt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C60E RID: 50702
		// (get) Token: 0x0602E7A6 RID: 190374 RVA: 0x00657C88 File Offset: 0x00655E88
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

		// Token: 0x1700C60F RID: 50703
		// (get) Token: 0x0602E7A7 RID: 190375 RVA: 0x00657CC4 File Offset: 0x00655EC4
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

		// Token: 0x0602E7A8 RID: 190376 RVA: 0x00657D00 File Offset: 0x00655F00
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602E7A9 RID: 190377 RVA: 0x00657D44 File Offset: 0x00655F44
		public IActorLookAtEmptyData TargetAsIActorLookAtEmptyData()
		{
			return this.Target<IActorLookAtEmptyData>().Value;
		}

		// Token: 0x0602E7AA RID: 190378 RVA: 0x00657D60 File Offset: 0x00655F60
		public IActorLookAtEntityData TargetAsIActorLookAtEntityData()
		{
			return this.Target<IActorLookAtEntityData>().Value;
		}

		// Token: 0x0602E7AB RID: 190379 RVA: 0x00657D7C File Offset: 0x00655F7C
		public IActorLookAtOtherActor TargetAsIActorLookAtOtherActor()
		{
			return this.Target<IActorLookAtOtherActor>().Value;
		}

		// Token: 0x0602E7AC RID: 190380 RVA: 0x00657D98 File Offset: 0x00655F98
		public IActorLookAtPlayerData TargetAsIActorLookAtPlayerData()
		{
			return this.Target<IActorLookAtPlayerData>().Value;
		}

		// Token: 0x0602E7AD RID: 190381 RVA: 0x00657DB4 File Offset: 0x00655FB4
		public IActorLookAtPositionData TargetAsIActorLookAtPositionData()
		{
			return this.Target<IActorLookAtPositionData>().Value;
		}

		// Token: 0x0602E7AE RID: 190382 RVA: 0x00657DD0 File Offset: 0x00655FD0
		public IActorLookAtTalkerData TargetAsIActorLookAtTalkerData()
		{
			return this.Target<IActorLookAtTalkerData>().Value;
		}

		// Token: 0x0602E7AF RID: 190383 RVA: 0x00657DEC File Offset: 0x00655FEC
		public IActorLookAtUnLock TargetAsIActorLookAtUnLock()
		{
			return this.Target<IActorLookAtUnLock>().Value;
		}

		// Token: 0x0602E7B0 RID: 190384 RVA: 0x00657E07 File Offset: 0x00656007
		public static Offset<IFlowTemplateInitialLookAt> CreateIFlowTemplateInitialLookAt(FlatBufferBuilder builder, int ActorIndex = 0, TActorLookAtData Target_type = TActorLookAtData.NONE, int TargetOffset = 0)
		{
			builder.StartTable(3);
			IFlowTemplateInitialLookAt.AddTarget(builder, TargetOffset);
			IFlowTemplateInitialLookAt.AddActorIndex(builder, ActorIndex);
			IFlowTemplateInitialLookAt.AddTargetType(builder, Target_type);
			return IFlowTemplateInitialLookAt.EndIFlowTemplateInitialLookAt(builder);
		}

		// Token: 0x0602E7B1 RID: 190385 RVA: 0x00657E2B File Offset: 0x0065602B
		public static void StartIFlowTemplateInitialLookAt(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602E7B2 RID: 190386 RVA: 0x00657E34 File Offset: 0x00656034
		public static void AddActorIndex(FlatBufferBuilder builder, int actorIndex)
		{
			builder.AddInt(0, actorIndex, 0);
		}

		// Token: 0x0602E7B3 RID: 190387 RVA: 0x00657E3F File Offset: 0x0065603F
		public static void AddTargetType(FlatBufferBuilder builder, TActorLookAtData targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0602E7B4 RID: 190388 RVA: 0x00657E4A File Offset: 0x0065604A
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0602E7B5 RID: 190389 RVA: 0x00657E55 File Offset: 0x00656055
		public static Offset<IFlowTemplateInitialLookAt> EndIFlowTemplateInitialLookAt(FlatBufferBuilder builder)
		{
			return new Offset<IFlowTemplateInitialLookAt>(builder.EndTable());
		}

		// Token: 0x0602E7B6 RID: 190390 RVA: 0x00657E64 File Offset: 0x00656064
		public IFlowTemplateInitialLookAtT UnPack()
		{
			IFlowTemplateInitialLookAtT flowTemplateInitialLookAtT = new IFlowTemplateInitialLookAtT();
			this.UnPackTo(flowTemplateInitialLookAtT);
			return flowTemplateInitialLookAtT;
		}

		// Token: 0x0602E7B7 RID: 190391 RVA: 0x00657E80 File Offset: 0x00656080
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

		// Token: 0x0602E7B8 RID: 190392 RVA: 0x00658064 File Offset: 0x00656264
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

		// Token: 0x04010F65 RID: 69477
		private Table __p;
	}
}

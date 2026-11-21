using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069D8 RID: 27096
	public struct ICheckFlowLookAtTarget : IFlatbufferObject
	{
		// Token: 0x1700C761 RID: 51041
		// (get) Token: 0x0602E7C9 RID: 190409 RVA: 0x00657AB1 File Offset: 0x00655CB1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E7CA RID: 190410 RVA: 0x00657ABE File Offset: 0x00655CBE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E7CB RID: 190411 RVA: 0x00657AC8 File Offset: 0x00655CC8
		public static ICheckFlowLookAtTarget GetRootAsICheckFlowLookAtTarget(ByteBuffer _bb)
		{
			return ICheckFlowLookAtTarget.GetRootAsICheckFlowLookAtTarget(_bb, default(ICheckFlowLookAtTarget));
		}

		// Token: 0x0602E7CC RID: 190412 RVA: 0x00657AE4 File Offset: 0x00655CE4
		public static ICheckFlowLookAtTarget GetRootAsICheckFlowLookAtTarget(ByteBuffer _bb, ICheckFlowLookAtTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E7CD RID: 190413 RVA: 0x00657B01 File Offset: 0x00655D01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E7CE RID: 190414 RVA: 0x00657B10 File Offset: 0x00655D10
		public ICheckFlowLookAtTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C762 RID: 51042
		// (get) Token: 0x0602E7CF RID: 190415 RVA: 0x00657B20 File Offset: 0x00655D20
		public ECheckFlowLookAtTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckFlowLookAtTargetType.Entity;
				}
				return (ECheckFlowLookAtTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E7D0 RID: 190416 RVA: 0x00657B5C File Offset: 0x00655D5C
		public static Offset<ICheckFlowLookAtTarget> CreateICheckFlowLookAtTarget(FlatBufferBuilder builder, ECheckFlowLookAtTargetType Type = ECheckFlowLookAtTargetType.Entity)
		{
			builder.StartTable(1);
			ICheckFlowLookAtTarget.AddType(builder, Type);
			return ICheckFlowLookAtTarget.EndICheckFlowLookAtTarget(builder);
		}

		// Token: 0x0602E7D1 RID: 190417 RVA: 0x00657B72 File Offset: 0x00655D72
		public static void StartICheckFlowLookAtTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E7D2 RID: 190418 RVA: 0x00657B7B File Offset: 0x00655D7B
		public static void AddType(FlatBufferBuilder builder, ECheckFlowLookAtTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E7D3 RID: 190419 RVA: 0x00657B86 File Offset: 0x00655D86
		public static Offset<ICheckFlowLookAtTarget> EndICheckFlowLookAtTarget(FlatBufferBuilder builder)
		{
			return new Offset<ICheckFlowLookAtTarget>(builder.EndTable());
		}

		// Token: 0x0602E7D4 RID: 190420 RVA: 0x00657B94 File Offset: 0x00655D94
		public ICheckFlowLookAtTargetT UnPack()
		{
			ICheckFlowLookAtTargetT checkFlowLookAtTargetT = new ICheckFlowLookAtTargetT();
			this.UnPackTo(checkFlowLookAtTargetT);
			return checkFlowLookAtTargetT;
		}

		// Token: 0x0602E7D5 RID: 190421 RVA: 0x00657BAF File Offset: 0x00655DAF
		public void UnPackTo(ICheckFlowLookAtTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E7D6 RID: 190422 RVA: 0x00657BC0 File Offset: 0x00655DC0
		public static Offset<ICheckFlowLookAtTarget> Pack(FlatBufferBuilder builder, ICheckFlowLookAtTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckFlowLookAtTarget>);
			}
			return ICheckFlowLookAtTarget.CreateICheckFlowLookAtTarget(builder, _o.Type);
		}

		// Token: 0x04011749 RID: 71497
		private Table __p;
	}
}

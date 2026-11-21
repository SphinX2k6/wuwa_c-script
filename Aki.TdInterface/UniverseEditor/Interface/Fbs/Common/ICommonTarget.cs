using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063AA RID: 25514
	public struct ICommonTarget : IFlatbufferObject
	{
		// Token: 0x1700BC8D RID: 48269
		// (get) Token: 0x0602B530 RID: 177456 RVA: 0x005E7B72 File Offset: 0x005E5D72
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B531 RID: 177457 RVA: 0x005E7B7F File Offset: 0x005E5D7F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B532 RID: 177458 RVA: 0x005E7B88 File Offset: 0x005E5D88
		public static ICommonTarget GetRootAsICommonTarget(ByteBuffer _bb)
		{
			return ICommonTarget.GetRootAsICommonTarget(_bb, default(ICommonTarget));
		}

		// Token: 0x0602B533 RID: 177459 RVA: 0x005E7BA4 File Offset: 0x005E5DA4
		public static ICommonTarget GetRootAsICommonTarget(ByteBuffer _bb, ICommonTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B534 RID: 177460 RVA: 0x005E7BC1 File Offset: 0x005E5DC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B535 RID: 177461 RVA: 0x005E7BD0 File Offset: 0x005E5DD0
		public ICommonTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC8E RID: 48270
		// (get) Token: 0x0602B536 RID: 177462 RVA: 0x005E7BE0 File Offset: 0x005E5DE0
		public ECommonTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTargetType.Player;
				}
				return (ECommonTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B537 RID: 177463 RVA: 0x005E7C1C File Offset: 0x005E5E1C
		public static Offset<ICommonTarget> CreateICommonTarget(FlatBufferBuilder builder, ECommonTargetType Type = ECommonTargetType.Player)
		{
			builder.StartTable(1);
			ICommonTarget.AddType(builder, Type);
			return ICommonTarget.EndICommonTarget(builder);
		}

		// Token: 0x0602B538 RID: 177464 RVA: 0x005E7C32 File Offset: 0x005E5E32
		public static void StartICommonTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B539 RID: 177465 RVA: 0x005E7C3B File Offset: 0x005E5E3B
		public static void AddType(FlatBufferBuilder builder, ECommonTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B53A RID: 177466 RVA: 0x005E7C46 File Offset: 0x005E5E46
		public static Offset<ICommonTarget> EndICommonTarget(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTarget>(builder.EndTable());
		}

		// Token: 0x0602B53B RID: 177467 RVA: 0x005E7C54 File Offset: 0x005E5E54
		public ICommonTargetT UnPack()
		{
			ICommonTargetT commonTargetT = new ICommonTargetT();
			this.UnPackTo(commonTargetT);
			return commonTargetT;
		}

		// Token: 0x0602B53C RID: 177468 RVA: 0x005E7C6F File Offset: 0x005E5E6F
		public void UnPackTo(ICommonTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B53D RID: 177469 RVA: 0x005E7C80 File Offset: 0x005E5E80
		public static Offset<ICommonTarget> Pack(FlatBufferBuilder builder, ICommonTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTarget>);
			}
			return ICommonTarget.CreateICommonTarget(builder, _o.Type);
		}

		// Token: 0x0401048E RID: 66702
		private Table __p;
	}
}

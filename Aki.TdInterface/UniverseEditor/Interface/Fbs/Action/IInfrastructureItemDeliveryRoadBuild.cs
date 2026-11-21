using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200700D RID: 28685
	public struct IInfrastructureItemDeliveryRoadBuild : IFlatbufferObject
	{
		// Token: 0x1700D20E RID: 53774
		// (get) Token: 0x06031B3C RID: 203580 RVA: 0x006BB086 File Offset: 0x006B9286
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031B3D RID: 203581 RVA: 0x006BB093 File Offset: 0x006B9293
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031B3E RID: 203582 RVA: 0x006BB09C File Offset: 0x006B929C
		public static IInfrastructureItemDeliveryRoadBuild GetRootAsIInfrastructureItemDeliveryRoadBuild(ByteBuffer _bb)
		{
			return IInfrastructureItemDeliveryRoadBuild.GetRootAsIInfrastructureItemDeliveryRoadBuild(_bb, default(IInfrastructureItemDeliveryRoadBuild));
		}

		// Token: 0x06031B3F RID: 203583 RVA: 0x006BB0B8 File Offset: 0x006B92B8
		public static IInfrastructureItemDeliveryRoadBuild GetRootAsIInfrastructureItemDeliveryRoadBuild(ByteBuffer _bb, IInfrastructureItemDeliveryRoadBuild obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031B40 RID: 203584 RVA: 0x006BB0D5 File Offset: 0x006B92D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031B41 RID: 203585 RVA: 0x006BB0E4 File Offset: 0x006B92E4
		public IInfrastructureItemDeliveryRoadBuild __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D20F RID: 53775
		// (get) Token: 0x06031B42 RID: 203586 RVA: 0x006BB0F4 File Offset: 0x006B92F4
		public EInfrastructureItemDeliveryType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInfrastructureItemDeliveryType.Observatory;
				}
				return (EInfrastructureItemDeliveryType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D210 RID: 53776
		// (get) Token: 0x06031B43 RID: 203587 RVA: 0x006BB130 File Offset: 0x006B9330
		public int Id
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

		// Token: 0x06031B44 RID: 203588 RVA: 0x006BB16C File Offset: 0x006B936C
		public static Offset<IInfrastructureItemDeliveryRoadBuild> CreateIInfrastructureItemDeliveryRoadBuild(FlatBufferBuilder builder, EInfrastructureItemDeliveryType Type = EInfrastructureItemDeliveryType.Observatory, int Id = 0)
		{
			builder.StartTable(2);
			IInfrastructureItemDeliveryRoadBuild.AddId(builder, Id);
			IInfrastructureItemDeliveryRoadBuild.AddType(builder, Type);
			return IInfrastructureItemDeliveryRoadBuild.EndIInfrastructureItemDeliveryRoadBuild(builder);
		}

		// Token: 0x06031B45 RID: 203589 RVA: 0x006BB189 File Offset: 0x006B9389
		public static void StartIInfrastructureItemDeliveryRoadBuild(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031B46 RID: 203590 RVA: 0x006BB192 File Offset: 0x006B9392
		public static void AddType(FlatBufferBuilder builder, EInfrastructureItemDeliveryType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031B47 RID: 203591 RVA: 0x006BB19D File Offset: 0x006B939D
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06031B48 RID: 203592 RVA: 0x006BB1A8 File Offset: 0x006B93A8
		public static Offset<IInfrastructureItemDeliveryRoadBuild> EndIInfrastructureItemDeliveryRoadBuild(FlatBufferBuilder builder)
		{
			return new Offset<IInfrastructureItemDeliveryRoadBuild>(builder.EndTable());
		}

		// Token: 0x06031B49 RID: 203593 RVA: 0x006BB1B8 File Offset: 0x006B93B8
		public IInfrastructureItemDeliveryRoadBuildT UnPack()
		{
			IInfrastructureItemDeliveryRoadBuildT infrastructureItemDeliveryRoadBuildT = new IInfrastructureItemDeliveryRoadBuildT();
			this.UnPackTo(infrastructureItemDeliveryRoadBuildT);
			return infrastructureItemDeliveryRoadBuildT;
		}

		// Token: 0x06031B4A RID: 203594 RVA: 0x006BB1D3 File Offset: 0x006B93D3
		public void UnPackTo(IInfrastructureItemDeliveryRoadBuildT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x06031B4B RID: 203595 RVA: 0x006BB1F0 File Offset: 0x006B93F0
		public static Offset<IInfrastructureItemDeliveryRoadBuild> Pack(FlatBufferBuilder builder, IInfrastructureItemDeliveryRoadBuildT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInfrastructureItemDeliveryRoadBuild>);
			}
			return IInfrastructureItemDeliveryRoadBuild.CreateIInfrastructureItemDeliveryRoadBuild(builder, _o.Type, _o.Id);
		}

		// Token: 0x04011F46 RID: 73542
		private Table __p;
	}
}

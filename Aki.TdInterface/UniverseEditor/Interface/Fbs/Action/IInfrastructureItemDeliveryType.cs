using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007010 RID: 28688
	public struct IInfrastructureItemDeliveryType : IFlatbufferObject
	{
		// Token: 0x1700D213 RID: 53779
		// (get) Token: 0x06031B52 RID: 203602 RVA: 0x006BB286 File Offset: 0x006B9486
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031B53 RID: 203603 RVA: 0x006BB293 File Offset: 0x006B9493
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031B54 RID: 203604 RVA: 0x006BB29C File Offset: 0x006B949C
		public static IInfrastructureItemDeliveryType GetRootAsIInfrastructureItemDeliveryType(ByteBuffer _bb)
		{
			return IInfrastructureItemDeliveryType.GetRootAsIInfrastructureItemDeliveryType(_bb, default(IInfrastructureItemDeliveryType));
		}

		// Token: 0x06031B55 RID: 203605 RVA: 0x006BB2B8 File Offset: 0x006B94B8
		public static IInfrastructureItemDeliveryType GetRootAsIInfrastructureItemDeliveryType(ByteBuffer _bb, IInfrastructureItemDeliveryType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031B56 RID: 203606 RVA: 0x006BB2D5 File Offset: 0x006B94D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031B57 RID: 203607 RVA: 0x006BB2E4 File Offset: 0x006B94E4
		public IInfrastructureItemDeliveryType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D214 RID: 53780
		// (get) Token: 0x06031B58 RID: 203608 RVA: 0x006BB2F4 File Offset: 0x006B94F4
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

		// Token: 0x06031B59 RID: 203609 RVA: 0x006BB330 File Offset: 0x006B9530
		public static Offset<IInfrastructureItemDeliveryType> CreateIInfrastructureItemDeliveryType(FlatBufferBuilder builder, EInfrastructureItemDeliveryType Type = EInfrastructureItemDeliveryType.Observatory)
		{
			builder.StartTable(1);
			IInfrastructureItemDeliveryType.AddType(builder, Type);
			return IInfrastructureItemDeliveryType.EndIInfrastructureItemDeliveryType(builder);
		}

		// Token: 0x06031B5A RID: 203610 RVA: 0x006BB346 File Offset: 0x006B9546
		public static void StartIInfrastructureItemDeliveryType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031B5B RID: 203611 RVA: 0x006BB34F File Offset: 0x006B954F
		public static void AddType(FlatBufferBuilder builder, EInfrastructureItemDeliveryType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031B5C RID: 203612 RVA: 0x006BB35A File Offset: 0x006B955A
		public static Offset<IInfrastructureItemDeliveryType> EndIInfrastructureItemDeliveryType(FlatBufferBuilder builder)
		{
			return new Offset<IInfrastructureItemDeliveryType>(builder.EndTable());
		}

		// Token: 0x06031B5D RID: 203613 RVA: 0x006BB368 File Offset: 0x006B9568
		public IInfrastructureItemDeliveryTypeT UnPack()
		{
			IInfrastructureItemDeliveryTypeT infrastructureItemDeliveryTypeT = new IInfrastructureItemDeliveryTypeT();
			this.UnPackTo(infrastructureItemDeliveryTypeT);
			return infrastructureItemDeliveryTypeT;
		}

		// Token: 0x06031B5E RID: 203614 RVA: 0x006BB383 File Offset: 0x006B9583
		public void UnPackTo(IInfrastructureItemDeliveryTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031B5F RID: 203615 RVA: 0x006BB394 File Offset: 0x006B9594
		public static Offset<IInfrastructureItemDeliveryType> Pack(FlatBufferBuilder builder, IInfrastructureItemDeliveryTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInfrastructureItemDeliveryType>);
			}
			return IInfrastructureItemDeliveryType.CreateIInfrastructureItemDeliveryType(builder, _o.Type);
		}

		// Token: 0x04011F49 RID: 73545
		private Table __p;
	}
}

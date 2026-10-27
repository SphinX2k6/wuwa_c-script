using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005602 RID: 22018
	public struct INoiseRemovalBoxBoarder : IFlatbufferObject
	{
		// Token: 0x1700A2E7 RID: 41703
		// (get) Token: 0x0602487F RID: 149631 RVA: 0x0050A8E8 File Offset: 0x00508AE8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024880 RID: 149632 RVA: 0x0050A8F5 File Offset: 0x00508AF5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024881 RID: 149633 RVA: 0x0050A8FC File Offset: 0x00508AFC
		public static INoiseRemovalBoxBoarder GetRootAsINoiseRemovalBoxBoarder(ByteBuffer _bb)
		{
			return INoiseRemovalBoxBoarder.GetRootAsINoiseRemovalBoxBoarder(_bb, default(INoiseRemovalBoxBoarder));
		}

		// Token: 0x06024882 RID: 149634 RVA: 0x0050A918 File Offset: 0x00508B18
		public static INoiseRemovalBoxBoarder GetRootAsINoiseRemovalBoxBoarder(ByteBuffer _bb, INoiseRemovalBoxBoarder obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024883 RID: 149635 RVA: 0x0050A935 File Offset: 0x00508B35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024884 RID: 149636 RVA: 0x0050A944 File Offset: 0x00508B44
		public INoiseRemovalBoxBoarder __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A2E8 RID: 41704
		// (get) Token: 0x06024885 RID: 149637 RVA: 0x0050A954 File Offset: 0x00508B54
		public ENoiseRemovalBoarderShape Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENoiseRemovalBoarderShape.Box;
				}
				return (ENoiseRemovalBoarderShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A2E9 RID: 41705
		// (get) Token: 0x06024886 RID: 149638 RVA: 0x0050A990 File Offset: 0x00508B90
		public IVectorInfo? BoxExtendPositive
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A2EA RID: 41706
		// (get) Token: 0x06024887 RID: 149639 RVA: 0x0050A9F0 File Offset: 0x00508BF0
		public IVectorInfo? BoxExtendNegative
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06024888 RID: 149640 RVA: 0x0050AA4D File Offset: 0x00508C4D
		public static Offset<INoiseRemovalBoxBoarder> CreateINoiseRemovalBoxBoarder(FlatBufferBuilder builder, ENoiseRemovalBoarderShape Type = ENoiseRemovalBoarderShape.Box, Offset<IVectorInfo> BoxExtendPositiveOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> BoxExtendNegativeOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			INoiseRemovalBoxBoarder.AddBoxExtendNegative(builder, BoxExtendNegativeOffset);
			INoiseRemovalBoxBoarder.AddBoxExtendPositive(builder, BoxExtendPositiveOffset);
			INoiseRemovalBoxBoarder.AddType(builder, Type);
			return INoiseRemovalBoxBoarder.EndINoiseRemovalBoxBoarder(builder);
		}

		// Token: 0x06024889 RID: 149641 RVA: 0x0050AA71 File Offset: 0x00508C71
		public static void StartINoiseRemovalBoxBoarder(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602488A RID: 149642 RVA: 0x0050AA7A File Offset: 0x00508C7A
		public static void AddType(FlatBufferBuilder builder, ENoiseRemovalBoarderShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602488B RID: 149643 RVA: 0x0050AA85 File Offset: 0x00508C85
		public static void AddBoxExtendPositive(FlatBufferBuilder builder, Offset<IVectorInfo> boxExtendPositiveOffset)
		{
			builder.AddOffset(1, boxExtendPositiveOffset.Value, 0);
		}

		// Token: 0x0602488C RID: 149644 RVA: 0x0050AA95 File Offset: 0x00508C95
		public static void AddBoxExtendNegative(FlatBufferBuilder builder, Offset<IVectorInfo> boxExtendNegativeOffset)
		{
			builder.AddOffset(2, boxExtendNegativeOffset.Value, 0);
		}

		// Token: 0x0602488D RID: 149645 RVA: 0x0050AAA5 File Offset: 0x00508CA5
		public static Offset<INoiseRemovalBoxBoarder> EndINoiseRemovalBoxBoarder(FlatBufferBuilder builder)
		{
			return new Offset<INoiseRemovalBoxBoarder>(builder.EndTable());
		}

		// Token: 0x0602488E RID: 149646 RVA: 0x0050AAB4 File Offset: 0x00508CB4
		public INoiseRemovalBoxBoarderT UnPack()
		{
			INoiseRemovalBoxBoarderT noiseRemovalBoxBoarderT = new INoiseRemovalBoxBoarderT();
			this.UnPackTo(noiseRemovalBoxBoarderT);
			return noiseRemovalBoxBoarderT;
		}

		// Token: 0x0602488F RID: 149647 RVA: 0x0050AAD0 File Offset: 0x00508CD0
		public void UnPackTo(INoiseRemovalBoxBoarderT _o)
		{
			_o.Type = this.Type;
			_o.BoxExtendPositive = ((this.BoxExtendPositive != null) ? this.BoxExtendPositive.Value.UnPack() : null);
			_o.BoxExtendNegative = ((this.BoxExtendNegative != null) ? this.BoxExtendNegative.Value.UnPack() : null);
		}

		// Token: 0x06024890 RID: 149648 RVA: 0x0050AB48 File Offset: 0x00508D48
		public static Offset<INoiseRemovalBoxBoarder> Pack(FlatBufferBuilder builder, INoiseRemovalBoxBoarderT _o)
		{
			if (_o == null)
			{
				return default(Offset<INoiseRemovalBoxBoarder>);
			}
			Offset<IVectorInfo> boxExtendPositiveOffset = (_o.BoxExtendPositive == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.BoxExtendPositive);
			Offset<IVectorInfo> boxExtendNegativeOffset = (_o.BoxExtendNegative == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.BoxExtendNegative);
			return INoiseRemovalBoxBoarder.CreateINoiseRemovalBoxBoarder(builder, _o.Type, boxExtendPositiveOffset, boxExtendNegativeOffset);
		}

		// Token: 0x0400E97D RID: 59773
		private Table __p;
	}
}

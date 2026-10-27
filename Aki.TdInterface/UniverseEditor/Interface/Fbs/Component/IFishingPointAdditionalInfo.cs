using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005261 RID: 21089
	public struct IFishingPointAdditionalInfo : IFlatbufferObject
	{
		// Token: 0x17009A75 RID: 39541
		// (get) Token: 0x060224E3 RID: 140515 RVA: 0x004C1985 File Offset: 0x004BFB85
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060224E4 RID: 140516 RVA: 0x004C1992 File Offset: 0x004BFB92
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060224E5 RID: 140517 RVA: 0x004C199C File Offset: 0x004BFB9C
		public static IFishingPointAdditionalInfo GetRootAsIFishingPointAdditionalInfo(ByteBuffer _bb)
		{
			return IFishingPointAdditionalInfo.GetRootAsIFishingPointAdditionalInfo(_bb, default(IFishingPointAdditionalInfo));
		}

		// Token: 0x060224E6 RID: 140518 RVA: 0x004C19B8 File Offset: 0x004BFBB8
		public static IFishingPointAdditionalInfo GetRootAsIFishingPointAdditionalInfo(ByteBuffer _bb, IFishingPointAdditionalInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060224E7 RID: 140519 RVA: 0x004C19D5 File Offset: 0x004BFBD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060224E8 RID: 140520 RVA: 0x004C19E4 File Offset: 0x004BFBE4
		public IFishingPointAdditionalInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A76 RID: 39542
		// (get) Token: 0x060224E9 RID: 140521 RVA: 0x004C19F4 File Offset: 0x004BFBF4
		public EInteractAdditionalInfoType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractAdditionalInfoType.FishingPoint;
				}
				return (EInteractAdditionalInfoType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060224EA RID: 140522 RVA: 0x004C1A30 File Offset: 0x004BFC30
		public static Offset<IFishingPointAdditionalInfo> CreateIFishingPointAdditionalInfo(FlatBufferBuilder builder, EInteractAdditionalInfoType Type = EInteractAdditionalInfoType.FishingPoint)
		{
			builder.StartTable(1);
			IFishingPointAdditionalInfo.AddType(builder, Type);
			return IFishingPointAdditionalInfo.EndIFishingPointAdditionalInfo(builder);
		}

		// Token: 0x060224EB RID: 140523 RVA: 0x004C1A46 File Offset: 0x004BFC46
		public static void StartIFishingPointAdditionalInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060224EC RID: 140524 RVA: 0x004C1A4F File Offset: 0x004BFC4F
		public static void AddType(FlatBufferBuilder builder, EInteractAdditionalInfoType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060224ED RID: 140525 RVA: 0x004C1A5A File Offset: 0x004BFC5A
		public static Offset<IFishingPointAdditionalInfo> EndIFishingPointAdditionalInfo(FlatBufferBuilder builder)
		{
			return new Offset<IFishingPointAdditionalInfo>(builder.EndTable());
		}

		// Token: 0x060224EE RID: 140526 RVA: 0x004C1A68 File Offset: 0x004BFC68
		public IFishingPointAdditionalInfoT UnPack()
		{
			IFishingPointAdditionalInfoT fishingPointAdditionalInfoT = new IFishingPointAdditionalInfoT();
			this.UnPackTo(fishingPointAdditionalInfoT);
			return fishingPointAdditionalInfoT;
		}

		// Token: 0x060224EF RID: 140527 RVA: 0x004C1A83 File Offset: 0x004BFC83
		public void UnPackTo(IFishingPointAdditionalInfoT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060224F0 RID: 140528 RVA: 0x004C1A94 File Offset: 0x004BFC94
		public static Offset<IFishingPointAdditionalInfo> Pack(FlatBufferBuilder builder, IFishingPointAdditionalInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFishingPointAdditionalInfo>);
			}
			return IFishingPointAdditionalInfo.CreateIFishingPointAdditionalInfo(builder, _o.Type);
		}

		// Token: 0x0400E3B2 RID: 58290
		private Table __p;
	}
}

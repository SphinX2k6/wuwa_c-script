using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057C9 RID: 22473
	public struct IFishingPointAdditionalInfo : IFlatbufferObject
	{
		// Token: 0x1700A271 RID: 41585
		// (get) Token: 0x06024479 RID: 148601 RVA: 0x004FC449 File Offset: 0x004FA649
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602447A RID: 148602 RVA: 0x004FC456 File Offset: 0x004FA656
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602447B RID: 148603 RVA: 0x004FC460 File Offset: 0x004FA660
		public static IFishingPointAdditionalInfo GetRootAsIFishingPointAdditionalInfo(ByteBuffer _bb)
		{
			return IFishingPointAdditionalInfo.GetRootAsIFishingPointAdditionalInfo(_bb, default(IFishingPointAdditionalInfo));
		}

		// Token: 0x0602447C RID: 148604 RVA: 0x004FC47C File Offset: 0x004FA67C
		public static IFishingPointAdditionalInfo GetRootAsIFishingPointAdditionalInfo(ByteBuffer _bb, IFishingPointAdditionalInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602447D RID: 148605 RVA: 0x004FC499 File Offset: 0x004FA699
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602447E RID: 148606 RVA: 0x004FC4A8 File Offset: 0x004FA6A8
		public IFishingPointAdditionalInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A272 RID: 41586
		// (get) Token: 0x0602447F RID: 148607 RVA: 0x004FC4B8 File Offset: 0x004FA6B8
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

		// Token: 0x06024480 RID: 148608 RVA: 0x004FC4F4 File Offset: 0x004FA6F4
		public static Offset<IFishingPointAdditionalInfo> CreateIFishingPointAdditionalInfo(FlatBufferBuilder builder, EInteractAdditionalInfoType Type = EInteractAdditionalInfoType.FishingPoint)
		{
			builder.StartTable(1);
			IFishingPointAdditionalInfo.AddType(builder, Type);
			return IFishingPointAdditionalInfo.EndIFishingPointAdditionalInfo(builder);
		}

		// Token: 0x06024481 RID: 148609 RVA: 0x004FC50A File Offset: 0x004FA70A
		public static void StartIFishingPointAdditionalInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024482 RID: 148610 RVA: 0x004FC513 File Offset: 0x004FA713
		public static void AddType(FlatBufferBuilder builder, EInteractAdditionalInfoType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024483 RID: 148611 RVA: 0x004FC51E File Offset: 0x004FA71E
		public static Offset<IFishingPointAdditionalInfo> EndIFishingPointAdditionalInfo(FlatBufferBuilder builder)
		{
			return new Offset<IFishingPointAdditionalInfo>(builder.EndTable());
		}

		// Token: 0x06024484 RID: 148612 RVA: 0x004FC52C File Offset: 0x004FA72C
		public IFishingPointAdditionalInfoT UnPack()
		{
			IFishingPointAdditionalInfoT fishingPointAdditionalInfoT = new IFishingPointAdditionalInfoT();
			this.UnPackTo(fishingPointAdditionalInfoT);
			return fishingPointAdditionalInfoT;
		}

		// Token: 0x06024485 RID: 148613 RVA: 0x004FC547 File Offset: 0x004FA747
		public void UnPackTo(IFishingPointAdditionalInfoT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06024486 RID: 148614 RVA: 0x004FC558 File Offset: 0x004FA758
		public static Offset<IFishingPointAdditionalInfo> Pack(FlatBufferBuilder builder, IFishingPointAdditionalInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFishingPointAdditionalInfo>);
			}
			return IFishingPointAdditionalInfo.CreateIFishingPointAdditionalInfo(builder, _o.Type);
		}

		// Token: 0x0400EFB8 RID: 61368
		private Table __p;
	}
}

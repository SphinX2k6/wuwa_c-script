using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007531 RID: 30001
	public struct IProjectionMachine : IFlatbufferObject
	{
		// Token: 0x1700DCB1 RID: 56497
		// (get) Token: 0x060349B1 RID: 215473 RVA: 0x007142FE File Offset: 0x007124FE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060349B2 RID: 215474 RVA: 0x0071430B File Offset: 0x0071250B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060349B3 RID: 215475 RVA: 0x00714314 File Offset: 0x00712514
		public static IProjectionMachine GetRootAsIProjectionMachine(ByteBuffer _bb)
		{
			return IProjectionMachine.GetRootAsIProjectionMachine(_bb, default(IProjectionMachine));
		}

		// Token: 0x060349B4 RID: 215476 RVA: 0x00714330 File Offset: 0x00712530
		public static IProjectionMachine GetRootAsIProjectionMachine(ByteBuffer _bb, IProjectionMachine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060349B5 RID: 215477 RVA: 0x0071434D File Offset: 0x0071254D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060349B6 RID: 215478 RVA: 0x0071435C File Offset: 0x0071255C
		public IProjectionMachine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DCB2 RID: 56498
		// (get) Token: 0x060349B7 RID: 215479 RVA: 0x0071436C File Offset: 0x0071256C
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DCB3 RID: 56499
		// (get) Token: 0x060349B8 RID: 215480 RVA: 0x007143A8 File Offset: 0x007125A8
		public int ItemId
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

		// Token: 0x1700DCB4 RID: 56500
		// (get) Token: 0x060349B9 RID: 215481 RVA: 0x007143E4 File Offset: 0x007125E4
		public string PhotoAsset
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060349BA RID: 215482 RVA: 0x0071441B File Offset: 0x0071261B
		public Span<byte> GetPhotoAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060349BB RID: 215483 RVA: 0x0071442A File Offset: 0x0071262A
		public byte[] GetPhotoAssetArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700DCB5 RID: 56501
		// (get) Token: 0x060349BC RID: 215484 RVA: 0x00714438 File Offset: 0x00712638
		public bool HideFixedPhoto
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DCB6 RID: 56502
		// (get) Token: 0x060349BD RID: 215485 RVA: 0x00714478 File Offset: 0x00712678
		public IProjectionMachinePhotoFilter? PhotoFilter
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IProjectionMachinePhotoFilter?(default(IProjectionMachinePhotoFilter).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700DCB7 RID: 56503
		// (get) Token: 0x060349BE RID: 215486 RVA: 0x007144D8 File Offset: 0x007126D8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060349BF RID: 215487 RVA: 0x00714515 File Offset: 0x00712715
		public static Offset<IProjectionMachine> CreateIProjectionMachine(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, int ItemId = 0, StringOffset PhotoAssetOffset = default(StringOffset), bool HideFixedPhoto = false, Offset<IProjectionMachinePhotoFilter> PhotoFilterOffset = default(Offset<IProjectionMachinePhotoFilter>), byte NullMask = 0)
		{
			builder.StartTable(6);
			IProjectionMachine.AddPhotoFilter(builder, PhotoFilterOffset);
			IProjectionMachine.AddPhotoAsset(builder, PhotoAssetOffset);
			IProjectionMachine.AddItemId(builder, ItemId);
			IProjectionMachine.AddNullMask(builder, NullMask);
			IProjectionMachine.AddHideFixedPhoto(builder, HideFixedPhoto);
			IProjectionMachine.AddType(builder, Type);
			return IProjectionMachine.EndIProjectionMachine(builder);
		}

		// Token: 0x060349C0 RID: 215488 RVA: 0x00714551 File Offset: 0x00712751
		public static void StartIProjectionMachine(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060349C1 RID: 215489 RVA: 0x0071455A File Offset: 0x0071275A
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060349C2 RID: 215490 RVA: 0x00714565 File Offset: 0x00712765
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(1, itemId, 0);
		}

		// Token: 0x060349C3 RID: 215491 RVA: 0x00714570 File Offset: 0x00712770
		public static void AddPhotoAsset(FlatBufferBuilder builder, StringOffset photoAssetOffset)
		{
			builder.AddOffset(2, photoAssetOffset.Value, 0);
		}

		// Token: 0x060349C4 RID: 215492 RVA: 0x00714580 File Offset: 0x00712780
		public static void AddHideFixedPhoto(FlatBufferBuilder builder, bool hideFixedPhoto)
		{
			builder.AddBool(3, hideFixedPhoto, false);
		}

		// Token: 0x060349C5 RID: 215493 RVA: 0x0071458B File Offset: 0x0071278B
		public static void AddPhotoFilter(FlatBufferBuilder builder, Offset<IProjectionMachinePhotoFilter> photoFilterOffset)
		{
			builder.AddOffset(4, photoFilterOffset.Value, 0);
		}

		// Token: 0x060349C6 RID: 215494 RVA: 0x0071459B File Offset: 0x0071279B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060349C7 RID: 215495 RVA: 0x007145A6 File Offset: 0x007127A6
		public static Offset<IProjectionMachine> EndIProjectionMachine(FlatBufferBuilder builder)
		{
			return new Offset<IProjectionMachine>(builder.EndTable());
		}

		// Token: 0x060349C8 RID: 215496 RVA: 0x007145B4 File Offset: 0x007127B4
		public IProjectionMachineT UnPack()
		{
			IProjectionMachineT projectionMachineT = new IProjectionMachineT();
			this.UnPackTo(projectionMachineT);
			return projectionMachineT;
		}

		// Token: 0x060349C9 RID: 215497 RVA: 0x007145D0 File Offset: 0x007127D0
		public void UnPackTo(IProjectionMachineT _o)
		{
			_o.Type = this.Type;
			_o.ItemId = this.ItemId;
			_o.PhotoAsset = this.PhotoAsset;
			_o.HideFixedPhoto = this.HideFixedPhoto;
			_o.PhotoFilter = ((this.PhotoFilter != null) ? this.PhotoFilter.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060349CA RID: 215498 RVA: 0x00714648 File Offset: 0x00712848
		public static Offset<IProjectionMachine> Pack(FlatBufferBuilder builder, IProjectionMachineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProjectionMachine>);
			}
			StringOffset photoAssetOffset = (_o.PhotoAsset == null) ? default(StringOffset) : builder.CreateString(_o.PhotoAsset);
			Offset<IProjectionMachinePhotoFilter> photoFilterOffset = (_o.PhotoFilter == null) ? default(Offset<IProjectionMachinePhotoFilter>) : IProjectionMachinePhotoFilter.Pack(builder, _o.PhotoFilter);
			return IProjectionMachine.CreateIProjectionMachine(builder, _o.Type, _o.ItemId, photoAssetOffset, _o.HideFixedPhoto, photoFilterOffset, _o.NullMask);
		}

		// Token: 0x0401270B RID: 75531
		private Table __p;
	}
}

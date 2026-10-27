using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DB6 RID: 28086
	public struct IProjectionMachine : IFlatbufferObject
	{
		// Token: 0x1700D169 RID: 53609
		// (get) Token: 0x060319B5 RID: 203189 RVA: 0x006B8C16 File Offset: 0x006B6E16
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060319B6 RID: 203190 RVA: 0x006B8C23 File Offset: 0x006B6E23
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060319B7 RID: 203191 RVA: 0x006B8C2C File Offset: 0x006B6E2C
		public static IProjectionMachine GetRootAsIProjectionMachine(ByteBuffer _bb)
		{
			return IProjectionMachine.GetRootAsIProjectionMachine(_bb, default(IProjectionMachine));
		}

		// Token: 0x060319B8 RID: 203192 RVA: 0x006B8C48 File Offset: 0x006B6E48
		public static IProjectionMachine GetRootAsIProjectionMachine(ByteBuffer _bb, IProjectionMachine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060319B9 RID: 203193 RVA: 0x006B8C65 File Offset: 0x006B6E65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060319BA RID: 203194 RVA: 0x006B8C74 File Offset: 0x006B6E74
		public IProjectionMachine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D16A RID: 53610
		// (get) Token: 0x060319BB RID: 203195 RVA: 0x006B8C84 File Offset: 0x006B6E84
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

		// Token: 0x1700D16B RID: 53611
		// (get) Token: 0x060319BC RID: 203196 RVA: 0x006B8CC0 File Offset: 0x006B6EC0
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

		// Token: 0x1700D16C RID: 53612
		// (get) Token: 0x060319BD RID: 203197 RVA: 0x006B8CFC File Offset: 0x006B6EFC
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

		// Token: 0x060319BE RID: 203198 RVA: 0x006B8D33 File Offset: 0x006B6F33
		public Span<byte> GetPhotoAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060319BF RID: 203199 RVA: 0x006B8D42 File Offset: 0x006B6F42
		public byte[] GetPhotoAssetArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700D16D RID: 53613
		// (get) Token: 0x060319C0 RID: 203200 RVA: 0x006B8D50 File Offset: 0x006B6F50
		public bool HideFixedPhoto
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D16E RID: 53614
		// (get) Token: 0x060319C1 RID: 203201 RVA: 0x006B8D90 File Offset: 0x006B6F90
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

		// Token: 0x1700D16F RID: 53615
		// (get) Token: 0x060319C2 RID: 203202 RVA: 0x006B8DF0 File Offset: 0x006B6FF0
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

		// Token: 0x060319C3 RID: 203203 RVA: 0x006B8E2D File Offset: 0x006B702D
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

		// Token: 0x060319C4 RID: 203204 RVA: 0x006B8E69 File Offset: 0x006B7069
		public static void StartIProjectionMachine(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060319C5 RID: 203205 RVA: 0x006B8E72 File Offset: 0x006B7072
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060319C6 RID: 203206 RVA: 0x006B8E7D File Offset: 0x006B707D
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(1, itemId, 0);
		}

		// Token: 0x060319C7 RID: 203207 RVA: 0x006B8E88 File Offset: 0x006B7088
		public static void AddPhotoAsset(FlatBufferBuilder builder, StringOffset photoAssetOffset)
		{
			builder.AddOffset(2, photoAssetOffset.Value, 0);
		}

		// Token: 0x060319C8 RID: 203208 RVA: 0x006B8E98 File Offset: 0x006B7098
		public static void AddHideFixedPhoto(FlatBufferBuilder builder, bool hideFixedPhoto)
		{
			builder.AddBool(3, hideFixedPhoto, false);
		}

		// Token: 0x060319C9 RID: 203209 RVA: 0x006B8EA3 File Offset: 0x006B70A3
		public static void AddPhotoFilter(FlatBufferBuilder builder, Offset<IProjectionMachinePhotoFilter> photoFilterOffset)
		{
			builder.AddOffset(4, photoFilterOffset.Value, 0);
		}

		// Token: 0x060319CA RID: 203210 RVA: 0x006B8EB3 File Offset: 0x006B70B3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060319CB RID: 203211 RVA: 0x006B8EBE File Offset: 0x006B70BE
		public static Offset<IProjectionMachine> EndIProjectionMachine(FlatBufferBuilder builder)
		{
			return new Offset<IProjectionMachine>(builder.EndTable());
		}

		// Token: 0x060319CC RID: 203212 RVA: 0x006B8ECC File Offset: 0x006B70CC
		public IProjectionMachineT UnPack()
		{
			IProjectionMachineT projectionMachineT = new IProjectionMachineT();
			this.UnPackTo(projectionMachineT);
			return projectionMachineT;
		}

		// Token: 0x060319CD RID: 203213 RVA: 0x006B8EE8 File Offset: 0x006B70E8
		public void UnPackTo(IProjectionMachineT _o)
		{
			_o.Type = this.Type;
			_o.ItemId = this.ItemId;
			_o.PhotoAsset = this.PhotoAsset;
			_o.HideFixedPhoto = this.HideFixedPhoto;
			_o.PhotoFilter = ((this.PhotoFilter != null) ? this.PhotoFilter.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060319CE RID: 203214 RVA: 0x006B8F60 File Offset: 0x006B7160
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

		// Token: 0x0401178F RID: 71567
		private Table __p;
	}
}

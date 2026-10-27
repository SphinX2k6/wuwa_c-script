using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BFA RID: 27642
	public struct IOpenFishingItemDeliveryWithReturn : IFlatbufferObject
	{
		// Token: 0x1700CD8A RID: 52618
		// (get) Token: 0x0603096A RID: 199018 RVA: 0x00698724 File Offset: 0x00696924
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603096B RID: 199019 RVA: 0x00698731 File Offset: 0x00696931
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603096C RID: 199020 RVA: 0x00698738 File Offset: 0x00696938
		public static IOpenFishingItemDeliveryWithReturn GetRootAsIOpenFishingItemDeliveryWithReturn(ByteBuffer _bb)
		{
			return IOpenFishingItemDeliveryWithReturn.GetRootAsIOpenFishingItemDeliveryWithReturn(_bb, default(IOpenFishingItemDeliveryWithReturn));
		}

		// Token: 0x0603096D RID: 199021 RVA: 0x00698754 File Offset: 0x00696954
		public static IOpenFishingItemDeliveryWithReturn GetRootAsIOpenFishingItemDeliveryWithReturn(ByteBuffer _bb, IOpenFishingItemDeliveryWithReturn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603096E RID: 199022 RVA: 0x00698771 File Offset: 0x00696971
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603096F RID: 199023 RVA: 0x00698780 File Offset: 0x00696980
		public IOpenFishingItemDeliveryWithReturn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD8B RID: 52619
		// (get) Token: 0x06030970 RID: 199024 RVA: 0x00698790 File Offset: 0x00696990
		public ESystemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystemType.Shop;
				}
				return (ESystemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CD8C RID: 52620
		// (get) Token: 0x06030971 RID: 199025 RVA: 0x006987CC File Offset: 0x006969CC
		public int PresetId
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

		// Token: 0x1700CD8D RID: 52621
		// (get) Token: 0x06030972 RID: 199026 RVA: 0x00698808 File Offset: 0x00696A08
		public TVarRef ReturnVarType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030973 RID: 199027 RVA: 0x00698844 File Offset: 0x00696A44
		public TTable? ReturnVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030974 RID: 199028 RVA: 0x0069888C File Offset: 0x00696A8C
		public IConstVarRef ReturnVarAsIConstVarRef()
		{
			return this.ReturnVar<IConstVarRef>().Value;
		}

		// Token: 0x06030975 RID: 199029 RVA: 0x006988A8 File Offset: 0x00696AA8
		public IGlobalVarRef ReturnVarAsIGlobalVarRef()
		{
			return this.ReturnVar<IGlobalVarRef>().Value;
		}

		// Token: 0x06030976 RID: 199030 RVA: 0x006988C4 File Offset: 0x00696AC4
		public IOtherVarRef ReturnVarAsIOtherVarRef()
		{
			return this.ReturnVar<IOtherVarRef>().Value;
		}

		// Token: 0x06030977 RID: 199031 RVA: 0x006988E0 File Offset: 0x00696AE0
		public ISelfVarRef ReturnVarAsISelfVarRef()
		{
			return this.ReturnVar<ISelfVarRef>().Value;
		}

		// Token: 0x06030978 RID: 199032 RVA: 0x006988FC File Offset: 0x00696AFC
		public ISystemVarRef ReturnVarAsISystemVarRef()
		{
			return this.ReturnVar<ISystemVarRef>().Value;
		}

		// Token: 0x06030979 RID: 199033 RVA: 0x00698917 File Offset: 0x00696B17
		public static Offset<IOpenFishingItemDeliveryWithReturn> CreateIOpenFishingItemDeliveryWithReturn(FlatBufferBuilder builder, ESystemType Type = ESystemType.Shop, int PresetId = 0, TVarRef ReturnVar_type = TVarRef.NONE, int ReturnVarOffset = 0)
		{
			builder.StartTable(4);
			IOpenFishingItemDeliveryWithReturn.AddReturnVar(builder, ReturnVarOffset);
			IOpenFishingItemDeliveryWithReturn.AddPresetId(builder, PresetId);
			IOpenFishingItemDeliveryWithReturn.AddReturnVarType(builder, ReturnVar_type);
			IOpenFishingItemDeliveryWithReturn.AddType(builder, Type);
			return IOpenFishingItemDeliveryWithReturn.EndIOpenFishingItemDeliveryWithReturn(builder);
		}

		// Token: 0x0603097A RID: 199034 RVA: 0x00698943 File Offset: 0x00696B43
		public static void StartIOpenFishingItemDeliveryWithReturn(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0603097B RID: 199035 RVA: 0x0069894C File Offset: 0x00696B4C
		public static void AddType(FlatBufferBuilder builder, ESystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603097C RID: 199036 RVA: 0x00698957 File Offset: 0x00696B57
		public static void AddPresetId(FlatBufferBuilder builder, int presetId)
		{
			builder.AddInt(1, presetId, 0);
		}

		// Token: 0x0603097D RID: 199037 RVA: 0x00698962 File Offset: 0x00696B62
		public static void AddReturnVarType(FlatBufferBuilder builder, TVarRef returnVarType)
		{
			builder.AddByte(2, (byte)returnVarType, 0);
		}

		// Token: 0x0603097E RID: 199038 RVA: 0x0069896D File Offset: 0x00696B6D
		public static void AddReturnVar(FlatBufferBuilder builder, int returnVarOffset)
		{
			builder.AddOffset(3, returnVarOffset, 0);
		}

		// Token: 0x0603097F RID: 199039 RVA: 0x00698978 File Offset: 0x00696B78
		public static Offset<IOpenFishingItemDeliveryWithReturn> EndIOpenFishingItemDeliveryWithReturn(FlatBufferBuilder builder)
		{
			return new Offset<IOpenFishingItemDeliveryWithReturn>(builder.EndTable());
		}

		// Token: 0x06030980 RID: 199040 RVA: 0x00698988 File Offset: 0x00696B88
		public IOpenFishingItemDeliveryWithReturnT UnPack()
		{
			IOpenFishingItemDeliveryWithReturnT openFishingItemDeliveryWithReturnT = new IOpenFishingItemDeliveryWithReturnT();
			this.UnPackTo(openFishingItemDeliveryWithReturnT);
			return openFishingItemDeliveryWithReturnT;
		}

		// Token: 0x06030981 RID: 199041 RVA: 0x006989A4 File Offset: 0x00696BA4
		public void UnPackTo(IOpenFishingItemDeliveryWithReturnT _o)
		{
			_o.Type = this.Type;
			_o.PresetId = this.PresetId;
			_o.ReturnVar = new TVarRefUnion();
			_o.ReturnVar.Type = this.ReturnVarType;
			switch (this.ReturnVarType)
			{
			case TVarRef.IConstVarRef:
				_o.ReturnVar.Value = ((this.ReturnVar<IConstVarRef>() != null) ? this.ReturnVar<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.ReturnVar.Value = ((this.ReturnVar<IGlobalVarRef>() != null) ? this.ReturnVar<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.ReturnVar.Value = ((this.ReturnVar<IOtherVarRef>() != null) ? this.ReturnVar<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.ReturnVar.Value = ((this.ReturnVar<ISelfVarRef>() != null) ? this.ReturnVar<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.ReturnVar.Value = ((this.ReturnVar<ISystemVarRef>() != null) ? this.ReturnVar<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06030982 RID: 199042 RVA: 0x00698B1C File Offset: 0x00696D1C
		public static Offset<IOpenFishingItemDeliveryWithReturn> Pack(FlatBufferBuilder builder, IOpenFishingItemDeliveryWithReturnT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenFishingItemDeliveryWithReturn>);
			}
			TVarRef returnVar_type = (_o.ReturnVar == null) ? TVarRef.NONE : _o.ReturnVar.Type;
			int returnVarOffset = (_o.ReturnVar == null) ? 0 : TVarRefUnion.Pack(builder, _o.ReturnVar);
			return IOpenFishingItemDeliveryWithReturn.CreateIOpenFishingItemDeliveryWithReturn(builder, _o.Type, _o.PresetId, returnVar_type, returnVarOffset);
		}

		// Token: 0x040114F4 RID: 70900
		private Table __p;
	}
}

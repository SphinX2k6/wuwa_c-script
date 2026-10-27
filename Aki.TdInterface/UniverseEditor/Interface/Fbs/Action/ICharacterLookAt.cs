using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200633A RID: 25402
	public struct ICharacterLookAt : IFlatbufferObject
	{
		// Token: 0x1700BD93 RID: 48531
		// (get) Token: 0x0602BF03 RID: 179971 RVA: 0x0060A0D6 File Offset: 0x006082D6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BF04 RID: 179972 RVA: 0x0060A0E3 File Offset: 0x006082E3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BF05 RID: 179973 RVA: 0x0060A0EC File Offset: 0x006082EC
		public static ICharacterLookAt GetRootAsICharacterLookAt(ByteBuffer _bb)
		{
			return ICharacterLookAt.GetRootAsICharacterLookAt(_bb, default(ICharacterLookAt));
		}

		// Token: 0x0602BF06 RID: 179974 RVA: 0x0060A108 File Offset: 0x00608308
		public static ICharacterLookAt GetRootAsICharacterLookAt(ByteBuffer _bb, ICharacterLookAt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BF07 RID: 179975 RVA: 0x0060A125 File Offset: 0x00608325
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BF08 RID: 179976 RVA: 0x0060A134 File Offset: 0x00608334
		public ICharacterLookAt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD94 RID: 48532
		// (get) Token: 0x0602BF09 RID: 179977 RVA: 0x0060A144 File Offset: 0x00608344
		public int CharEntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BD95 RID: 48533
		// (get) Token: 0x0602BF0A RID: 179978 RVA: 0x0060A180 File Offset: 0x00608380
		public TCharacterLookAtData TargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TCharacterLookAtData.NONE;
				}
				return (TCharacterLookAtData)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BF0B RID: 179979 RVA: 0x0060A1BC File Offset: 0x006083BC
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602BF0C RID: 179980 RVA: 0x0060A200 File Offset: 0x00608400
		public ICharacterLookAtEmptyData TargetAsICharacterLookAtEmptyData()
		{
			return this.Target<ICharacterLookAtEmptyData>().Value;
		}

		// Token: 0x0602BF0D RID: 179981 RVA: 0x0060A21C File Offset: 0x0060841C
		public ICharacterLookAtEntityData TargetAsICharacterLookAtEntityData()
		{
			return this.Target<ICharacterLookAtEntityData>().Value;
		}

		// Token: 0x0602BF0E RID: 179982 RVA: 0x0060A238 File Offset: 0x00608438
		public ICharacterLookAtPlayerData TargetAsICharacterLookAtPlayerData()
		{
			return this.Target<ICharacterLookAtPlayerData>().Value;
		}

		// Token: 0x0602BF0F RID: 179983 RVA: 0x0060A254 File Offset: 0x00608454
		public ICharacterLookAtPositionData TargetAsICharacterLookAtPositionData()
		{
			return this.Target<ICharacterLookAtPositionData>().Value;
		}

		// Token: 0x0602BF10 RID: 179984 RVA: 0x0060A270 File Offset: 0x00608470
		public ICharacterLookAtUnlockData TargetAsICharacterLookAtUnlockData()
		{
			return this.Target<ICharacterLookAtUnlockData>().Value;
		}

		// Token: 0x0602BF11 RID: 179985 RVA: 0x0060A28B File Offset: 0x0060848B
		public static Offset<ICharacterLookAt> CreateICharacterLookAt(FlatBufferBuilder builder, int CharEntityId = 0, TCharacterLookAtData Target_type = TCharacterLookAtData.NONE, int TargetOffset = 0)
		{
			builder.StartTable(3);
			ICharacterLookAt.AddTarget(builder, TargetOffset);
			ICharacterLookAt.AddCharEntityId(builder, CharEntityId);
			ICharacterLookAt.AddTargetType(builder, Target_type);
			return ICharacterLookAt.EndICharacterLookAt(builder);
		}

		// Token: 0x0602BF12 RID: 179986 RVA: 0x0060A2AF File Offset: 0x006084AF
		public static void StartICharacterLookAt(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602BF13 RID: 179987 RVA: 0x0060A2B8 File Offset: 0x006084B8
		public static void AddCharEntityId(FlatBufferBuilder builder, int charEntityId)
		{
			builder.AddInt(0, charEntityId, 0);
		}

		// Token: 0x0602BF14 RID: 179988 RVA: 0x0060A2C3 File Offset: 0x006084C3
		public static void AddTargetType(FlatBufferBuilder builder, TCharacterLookAtData targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0602BF15 RID: 179989 RVA: 0x0060A2CE File Offset: 0x006084CE
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0602BF16 RID: 179990 RVA: 0x0060A2D9 File Offset: 0x006084D9
		public static Offset<ICharacterLookAt> EndICharacterLookAt(FlatBufferBuilder builder)
		{
			return new Offset<ICharacterLookAt>(builder.EndTable());
		}

		// Token: 0x0602BF17 RID: 179991 RVA: 0x0060A2E8 File Offset: 0x006084E8
		public ICharacterLookAtT UnPack()
		{
			ICharacterLookAtT characterLookAtT = new ICharacterLookAtT();
			this.UnPackTo(characterLookAtT);
			return characterLookAtT;
		}

		// Token: 0x0602BF18 RID: 179992 RVA: 0x0060A304 File Offset: 0x00608504
		public void UnPackTo(ICharacterLookAtT _o)
		{
			_o.CharEntityId = this.CharEntityId;
			_o.Target = new TCharacterLookAtDataUnion();
			_o.Target.Type = this.TargetType;
			switch (this.TargetType)
			{
			case TCharacterLookAtData.ICharacterLookAtEmptyData:
				_o.Target.Value = ((this.Target<ICharacterLookAtEmptyData>() != null) ? this.Target<ICharacterLookAtEmptyData>().Value.UnPack() : null);
				return;
			case TCharacterLookAtData.ICharacterLookAtEntityData:
				_o.Target.Value = ((this.Target<ICharacterLookAtEntityData>() != null) ? this.Target<ICharacterLookAtEntityData>().Value.UnPack() : null);
				return;
			case TCharacterLookAtData.ICharacterLookAtPlayerData:
				_o.Target.Value = ((this.Target<ICharacterLookAtPlayerData>() != null) ? this.Target<ICharacterLookAtPlayerData>().Value.UnPack() : null);
				return;
			case TCharacterLookAtData.ICharacterLookAtPositionData:
				_o.Target.Value = ((this.Target<ICharacterLookAtPositionData>() != null) ? this.Target<ICharacterLookAtPositionData>().Value.UnPack() : null);
				return;
			case TCharacterLookAtData.ICharacterLookAtUnlockData:
				_o.Target.Value = ((this.Target<ICharacterLookAtUnlockData>() != null) ? this.Target<ICharacterLookAtUnlockData>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602BF19 RID: 179993 RVA: 0x0060A470 File Offset: 0x00608670
		public static Offset<ICharacterLookAt> Pack(FlatBufferBuilder builder, ICharacterLookAtT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICharacterLookAt>);
			}
			TCharacterLookAtData target_type = (_o.Target == null) ? TCharacterLookAtData.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TCharacterLookAtDataUnion.Pack(builder, _o.Target);
			return ICharacterLookAt.CreateICharacterLookAt(builder, _o.CharEntityId, target_type, targetOffset);
		}

		// Token: 0x04010901 RID: 67841
		private Table __p;
	}
}

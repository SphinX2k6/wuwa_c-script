using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F5F RID: 16223
	public struct INumberWordArtEffectiveTargetType : IFlatbufferObject
	{
		// Token: 0x170070CF RID: 28879
		// (get) Token: 0x0601712E RID: 94510 RVA: 0x003537B8 File Offset: 0x003519B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601712F RID: 94511 RVA: 0x003537C5 File Offset: 0x003519C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017130 RID: 94512 RVA: 0x003537CC File Offset: 0x003519CC
		public static INumberWordArtEffectiveTargetType GetRootAsINumberWordArtEffectiveTargetType(ByteBuffer _bb)
		{
			return INumberWordArtEffectiveTargetType.GetRootAsINumberWordArtEffectiveTargetType(_bb, default(INumberWordArtEffectiveTargetType));
		}

		// Token: 0x06017131 RID: 94513 RVA: 0x003537E8 File Offset: 0x003519E8
		public static INumberWordArtEffectiveTargetType GetRootAsINumberWordArtEffectiveTargetType(ByteBuffer _bb, INumberWordArtEffectiveTargetType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017132 RID: 94514 RVA: 0x00353805 File Offset: 0x00351A05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017133 RID: 94515 RVA: 0x00353814 File Offset: 0x00351A14
		public INumberWordArtEffectiveTargetType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170070D0 RID: 28880
		// (get) Token: 0x06017134 RID: 94516 RVA: 0x00353824 File Offset: 0x00351A24
		public EWordArtEffectiveTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWordArtEffectiveTargetType.Number;
				}
				return (EWordArtEffectiveTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170070D1 RID: 28881
		// (get) Token: 0x06017135 RID: 94517 RVA: 0x00353860 File Offset: 0x00351A60
		public bool ShowUiMotion
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170070D2 RID: 28882
		// (get) Token: 0x06017136 RID: 94518 RVA: 0x003538A0 File Offset: 0x00351AA0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017137 RID: 94519 RVA: 0x003538DC File Offset: 0x00351ADC
		public static Offset<INumberWordArtEffectiveTargetType> CreateINumberWordArtEffectiveTargetType(FlatBufferBuilder builder, EWordArtEffectiveTargetType Type = EWordArtEffectiveTargetType.Number, bool ShowUiMotion = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			INumberWordArtEffectiveTargetType.AddNullMask(builder, NullMask);
			INumberWordArtEffectiveTargetType.AddShowUiMotion(builder, ShowUiMotion);
			INumberWordArtEffectiveTargetType.AddType(builder, Type);
			return INumberWordArtEffectiveTargetType.EndINumberWordArtEffectiveTargetType(builder);
		}

		// Token: 0x06017138 RID: 94520 RVA: 0x00353900 File Offset: 0x00351B00
		public static void StartINumberWordArtEffectiveTargetType(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06017139 RID: 94521 RVA: 0x00353909 File Offset: 0x00351B09
		public static void AddType(FlatBufferBuilder builder, EWordArtEffectiveTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601713A RID: 94522 RVA: 0x00353914 File Offset: 0x00351B14
		public static void AddShowUiMotion(FlatBufferBuilder builder, bool showUiMotion)
		{
			builder.AddBool(1, showUiMotion, false);
		}

		// Token: 0x0601713B RID: 94523 RVA: 0x0035391F File Offset: 0x00351B1F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601713C RID: 94524 RVA: 0x0035392A File Offset: 0x00351B2A
		public static Offset<INumberWordArtEffectiveTargetType> EndINumberWordArtEffectiveTargetType(FlatBufferBuilder builder)
		{
			return new Offset<INumberWordArtEffectiveTargetType>(builder.EndTable());
		}

		// Token: 0x0601713D RID: 94525 RVA: 0x00353938 File Offset: 0x00351B38
		public INumberWordArtEffectiveTargetTypeT UnPack()
		{
			INumberWordArtEffectiveTargetTypeT numberWordArtEffectiveTargetTypeT = new INumberWordArtEffectiveTargetTypeT();
			this.UnPackTo(numberWordArtEffectiveTargetTypeT);
			return numberWordArtEffectiveTargetTypeT;
		}

		// Token: 0x0601713E RID: 94526 RVA: 0x00353953 File Offset: 0x00351B53
		public void UnPackTo(INumberWordArtEffectiveTargetTypeT _o)
		{
			_o.Type = this.Type;
			_o.ShowUiMotion = this.ShowUiMotion;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601713F RID: 94527 RVA: 0x0035397C File Offset: 0x00351B7C
		public static Offset<INumberWordArtEffectiveTargetType> Pack(FlatBufferBuilder builder, INumberWordArtEffectiveTargetTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<INumberWordArtEffectiveTargetType>);
			}
			return INumberWordArtEffectiveTargetType.CreateINumberWordArtEffectiveTargetType(builder, _o.Type, _o.ShowUiMotion, _o.NullMask);
		}

		// Token: 0x0400B974 RID: 47476
		private Table __p;
	}
}

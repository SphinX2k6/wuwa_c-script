using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200439D RID: 17309
	public struct INumberWordArtEffectiveTargetType : IFlatbufferObject
	{
		// Token: 0x170076C0 RID: 30400
		// (get) Token: 0x06018790 RID: 100240 RVA: 0x0037CC2C File Offset: 0x0037AE2C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018791 RID: 100241 RVA: 0x0037CC39 File Offset: 0x0037AE39
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018792 RID: 100242 RVA: 0x0037CC40 File Offset: 0x0037AE40
		public static INumberWordArtEffectiveTargetType GetRootAsINumberWordArtEffectiveTargetType(ByteBuffer _bb)
		{
			return INumberWordArtEffectiveTargetType.GetRootAsINumberWordArtEffectiveTargetType(_bb, default(INumberWordArtEffectiveTargetType));
		}

		// Token: 0x06018793 RID: 100243 RVA: 0x0037CC5C File Offset: 0x0037AE5C
		public static INumberWordArtEffectiveTargetType GetRootAsINumberWordArtEffectiveTargetType(ByteBuffer _bb, INumberWordArtEffectiveTargetType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018794 RID: 100244 RVA: 0x0037CC79 File Offset: 0x0037AE79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018795 RID: 100245 RVA: 0x0037CC88 File Offset: 0x0037AE88
		public INumberWordArtEffectiveTargetType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170076C1 RID: 30401
		// (get) Token: 0x06018796 RID: 100246 RVA: 0x0037CC98 File Offset: 0x0037AE98
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

		// Token: 0x170076C2 RID: 30402
		// (get) Token: 0x06018797 RID: 100247 RVA: 0x0037CCD4 File Offset: 0x0037AED4
		public bool ShowUiMotion
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170076C3 RID: 30403
		// (get) Token: 0x06018798 RID: 100248 RVA: 0x0037CD14 File Offset: 0x0037AF14
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

		// Token: 0x06018799 RID: 100249 RVA: 0x0037CD50 File Offset: 0x0037AF50
		public static Offset<INumberWordArtEffectiveTargetType> CreateINumberWordArtEffectiveTargetType(FlatBufferBuilder builder, EWordArtEffectiveTargetType Type = EWordArtEffectiveTargetType.Number, bool ShowUiMotion = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			INumberWordArtEffectiveTargetType.AddNullMask(builder, NullMask);
			INumberWordArtEffectiveTargetType.AddShowUiMotion(builder, ShowUiMotion);
			INumberWordArtEffectiveTargetType.AddType(builder, Type);
			return INumberWordArtEffectiveTargetType.EndINumberWordArtEffectiveTargetType(builder);
		}

		// Token: 0x0601879A RID: 100250 RVA: 0x0037CD74 File Offset: 0x0037AF74
		public static void StartINumberWordArtEffectiveTargetType(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601879B RID: 100251 RVA: 0x0037CD7D File Offset: 0x0037AF7D
		public static void AddType(FlatBufferBuilder builder, EWordArtEffectiveTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601879C RID: 100252 RVA: 0x0037CD88 File Offset: 0x0037AF88
		public static void AddShowUiMotion(FlatBufferBuilder builder, bool showUiMotion)
		{
			builder.AddBool(1, showUiMotion, false);
		}

		// Token: 0x0601879D RID: 100253 RVA: 0x0037CD93 File Offset: 0x0037AF93
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601879E RID: 100254 RVA: 0x0037CD9E File Offset: 0x0037AF9E
		public static Offset<INumberWordArtEffectiveTargetType> EndINumberWordArtEffectiveTargetType(FlatBufferBuilder builder)
		{
			return new Offset<INumberWordArtEffectiveTargetType>(builder.EndTable());
		}

		// Token: 0x0601879F RID: 100255 RVA: 0x0037CDAC File Offset: 0x0037AFAC
		public INumberWordArtEffectiveTargetTypeT UnPack()
		{
			INumberWordArtEffectiveTargetTypeT numberWordArtEffectiveTargetTypeT = new INumberWordArtEffectiveTargetTypeT();
			this.UnPackTo(numberWordArtEffectiveTargetTypeT);
			return numberWordArtEffectiveTargetTypeT;
		}

		// Token: 0x060187A0 RID: 100256 RVA: 0x0037CDC7 File Offset: 0x0037AFC7
		public void UnPackTo(INumberWordArtEffectiveTargetTypeT _o)
		{
			_o.Type = this.Type;
			_o.ShowUiMotion = this.ShowUiMotion;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060187A1 RID: 100257 RVA: 0x0037CDF0 File Offset: 0x0037AFF0
		public static Offset<INumberWordArtEffectiveTargetType> Pack(FlatBufferBuilder builder, INumberWordArtEffectiveTargetTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<INumberWordArtEffectiveTargetType>);
			}
			return INumberWordArtEffectiveTargetType.CreateINumberWordArtEffectiveTargetType(builder, _o.Type, _o.ShowUiMotion, _o.NullMask);
		}

		// Token: 0x0400C352 RID: 50002
		private Table __p;
	}
}

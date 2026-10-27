using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075D4 RID: 30164
	public struct IVisualNovelRoleConfig : IFlatbufferObject
	{
		// Token: 0x1700E528 RID: 58664
		// (get) Token: 0x06036F20 RID: 225056 RVA: 0x007750D8 File Offset: 0x007732D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036F21 RID: 225057 RVA: 0x007750E5 File Offset: 0x007732E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036F22 RID: 225058 RVA: 0x007750EC File Offset: 0x007732EC
		public static IVisualNovelRoleConfig GetRootAsIVisualNovelRoleConfig(ByteBuffer _bb)
		{
			return IVisualNovelRoleConfig.GetRootAsIVisualNovelRoleConfig(_bb, default(IVisualNovelRoleConfig));
		}

		// Token: 0x06036F23 RID: 225059 RVA: 0x00775108 File Offset: 0x00773308
		public static IVisualNovelRoleConfig GetRootAsIVisualNovelRoleConfig(ByteBuffer _bb, IVisualNovelRoleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036F24 RID: 225060 RVA: 0x00775125 File Offset: 0x00773325
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036F25 RID: 225061 RVA: 0x00775134 File Offset: 0x00773334
		public IVisualNovelRoleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E529 RID: 58665
		// (get) Token: 0x06036F26 RID: 225062 RVA: 0x00775144 File Offset: 0x00773344
		public int Expression
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

		// Token: 0x1700E52A RID: 58666
		// (get) Token: 0x06036F27 RID: 225063 RVA: 0x00775180 File Offset: 0x00773380
		public EAvgVisualEffect VisualEffect
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EAvgVisualEffect.Default;
				}
				return (EAvgVisualEffect)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E52B RID: 58667
		// (get) Token: 0x06036F28 RID: 225064 RVA: 0x007751BC File Offset: 0x007733BC
		public bool HideAvatar
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E52C RID: 58668
		// (get) Token: 0x06036F29 RID: 225065 RVA: 0x007751FC File Offset: 0x007733FC
		public bool HidePortrait
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E52D RID: 58669
		// (get) Token: 0x06036F2A RID: 225066 RVA: 0x0077523C File Offset: 0x0077343C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036F2B RID: 225067 RVA: 0x00775279 File Offset: 0x00773479
		public static Offset<IVisualNovelRoleConfig> CreateIVisualNovelRoleConfig(FlatBufferBuilder builder, int Expression = 0, EAvgVisualEffect VisualEffect = EAvgVisualEffect.Default, bool HideAvatar = false, bool HidePortrait = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IVisualNovelRoleConfig.AddExpression(builder, Expression);
			IVisualNovelRoleConfig.AddNullMask(builder, NullMask);
			IVisualNovelRoleConfig.AddHidePortrait(builder, HidePortrait);
			IVisualNovelRoleConfig.AddHideAvatar(builder, HideAvatar);
			IVisualNovelRoleConfig.AddVisualEffect(builder, VisualEffect);
			return IVisualNovelRoleConfig.EndIVisualNovelRoleConfig(builder);
		}

		// Token: 0x06036F2C RID: 225068 RVA: 0x007752AD File Offset: 0x007734AD
		public static void StartIVisualNovelRoleConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06036F2D RID: 225069 RVA: 0x007752B6 File Offset: 0x007734B6
		public static void AddExpression(FlatBufferBuilder builder, int expression)
		{
			builder.AddInt(0, expression, 0);
		}

		// Token: 0x06036F2E RID: 225070 RVA: 0x007752C1 File Offset: 0x007734C1
		public static void AddVisualEffect(FlatBufferBuilder builder, EAvgVisualEffect visualEffect)
		{
			builder.AddByte(1, (byte)visualEffect, 0);
		}

		// Token: 0x06036F2F RID: 225071 RVA: 0x007752CC File Offset: 0x007734CC
		public static void AddHideAvatar(FlatBufferBuilder builder, bool hideAvatar)
		{
			builder.AddBool(2, hideAvatar, false);
		}

		// Token: 0x06036F30 RID: 225072 RVA: 0x007752D7 File Offset: 0x007734D7
		public static void AddHidePortrait(FlatBufferBuilder builder, bool hidePortrait)
		{
			builder.AddBool(3, hidePortrait, false);
		}

		// Token: 0x06036F31 RID: 225073 RVA: 0x007752E2 File Offset: 0x007734E2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06036F32 RID: 225074 RVA: 0x007752ED File Offset: 0x007734ED
		public static Offset<IVisualNovelRoleConfig> EndIVisualNovelRoleConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelRoleConfig>(builder.EndTable());
		}

		// Token: 0x06036F33 RID: 225075 RVA: 0x007752FC File Offset: 0x007734FC
		public IVisualNovelRoleConfigT UnPack()
		{
			IVisualNovelRoleConfigT visualNovelRoleConfigT = new IVisualNovelRoleConfigT();
			this.UnPackTo(visualNovelRoleConfigT);
			return visualNovelRoleConfigT;
		}

		// Token: 0x06036F34 RID: 225076 RVA: 0x00775317 File Offset: 0x00773517
		public void UnPackTo(IVisualNovelRoleConfigT _o)
		{
			_o.Expression = this.Expression;
			_o.VisualEffect = this.VisualEffect;
			_o.HideAvatar = this.HideAvatar;
			_o.HidePortrait = this.HidePortrait;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06036F35 RID: 225077 RVA: 0x00775358 File Offset: 0x00773558
		public static Offset<IVisualNovelRoleConfig> Pack(FlatBufferBuilder builder, IVisualNovelRoleConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelRoleConfig>);
			}
			return IVisualNovelRoleConfig.CreateIVisualNovelRoleConfig(builder, _o.Expression, _o.VisualEffect, _o.HideAvatar, _o.HidePortrait, _o.NullMask);
		}

		// Token: 0x04012534 RID: 75060
		private Table __p;
	}
}

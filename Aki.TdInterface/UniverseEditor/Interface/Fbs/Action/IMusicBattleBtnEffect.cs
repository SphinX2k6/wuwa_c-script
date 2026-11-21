using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072D7 RID: 29399
	public struct IMusicBattleBtnEffect : IFlatbufferObject
	{
		// Token: 0x1700D793 RID: 55187
		// (get) Token: 0x06033417 RID: 209943 RVA: 0x006EA226 File Offset: 0x006E8426
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033418 RID: 209944 RVA: 0x006EA233 File Offset: 0x006E8433
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033419 RID: 209945 RVA: 0x006EA23C File Offset: 0x006E843C
		public static IMusicBattleBtnEffect GetRootAsIMusicBattleBtnEffect(ByteBuffer _bb)
		{
			return IMusicBattleBtnEffect.GetRootAsIMusicBattleBtnEffect(_bb, default(IMusicBattleBtnEffect));
		}

		// Token: 0x0603341A RID: 209946 RVA: 0x006EA258 File Offset: 0x006E8458
		public static IMusicBattleBtnEffect GetRootAsIMusicBattleBtnEffect(ByteBuffer _bb, IMusicBattleBtnEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603341B RID: 209947 RVA: 0x006EA275 File Offset: 0x006E8475
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603341C RID: 209948 RVA: 0x006EA284 File Offset: 0x006E8484
		public IMusicBattleBtnEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D794 RID: 55188
		// (get) Token: 0x0603341D RID: 209949 RVA: 0x006EA294 File Offset: 0x006E8494
		public ESkillBtnEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESkillBtnEffectType.MusicBattleBtnEffect;
				}
				return (ESkillBtnEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603341E RID: 209950 RVA: 0x006EA2D0 File Offset: 0x006E84D0
		public static Offset<IMusicBattleBtnEffect> CreateIMusicBattleBtnEffect(FlatBufferBuilder builder, ESkillBtnEffectType Type = ESkillBtnEffectType.MusicBattleBtnEffect)
		{
			builder.StartTable(1);
			IMusicBattleBtnEffect.AddType(builder, Type);
			return IMusicBattleBtnEffect.EndIMusicBattleBtnEffect(builder);
		}

		// Token: 0x0603341F RID: 209951 RVA: 0x006EA2E6 File Offset: 0x006E84E6
		public static void StartIMusicBattleBtnEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033420 RID: 209952 RVA: 0x006EA2EF File Offset: 0x006E84EF
		public static void AddType(FlatBufferBuilder builder, ESkillBtnEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033421 RID: 209953 RVA: 0x006EA2FA File Offset: 0x006E84FA
		public static Offset<IMusicBattleBtnEffect> EndIMusicBattleBtnEffect(FlatBufferBuilder builder)
		{
			return new Offset<IMusicBattleBtnEffect>(builder.EndTable());
		}

		// Token: 0x06033422 RID: 209954 RVA: 0x006EA308 File Offset: 0x006E8508
		public IMusicBattleBtnEffectT UnPack()
		{
			IMusicBattleBtnEffectT musicBattleBtnEffectT = new IMusicBattleBtnEffectT();
			this.UnPackTo(musicBattleBtnEffectT);
			return musicBattleBtnEffectT;
		}

		// Token: 0x06033423 RID: 209955 RVA: 0x006EA323 File Offset: 0x006E8523
		public void UnPackTo(IMusicBattleBtnEffectT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033424 RID: 209956 RVA: 0x006EA334 File Offset: 0x006E8534
		public static Offset<IMusicBattleBtnEffect> Pack(FlatBufferBuilder builder, IMusicBattleBtnEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMusicBattleBtnEffect>);
			}
			return IMusicBattleBtnEffect.CreateIMusicBattleBtnEffect(builder, _o.Type);
		}

		// Token: 0x0401237C RID: 74620
		private Table __p;
	}
}

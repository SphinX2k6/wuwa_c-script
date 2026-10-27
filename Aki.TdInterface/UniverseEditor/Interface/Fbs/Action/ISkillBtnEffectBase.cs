using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200712A RID: 28970
	public struct ISkillBtnEffectBase : IFlatbufferObject
	{
		// Token: 0x1700D756 RID: 55126
		// (get) Token: 0x060335D5 RID: 210389 RVA: 0x006EC6E0 File Offset: 0x006EA8E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060335D6 RID: 210390 RVA: 0x006EC6ED File Offset: 0x006EA8ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060335D7 RID: 210391 RVA: 0x006EC6F4 File Offset: 0x006EA8F4
		public static ISkillBtnEffectBase GetRootAsISkillBtnEffectBase(ByteBuffer _bb)
		{
			return ISkillBtnEffectBase.GetRootAsISkillBtnEffectBase(_bb, default(ISkillBtnEffectBase));
		}

		// Token: 0x060335D8 RID: 210392 RVA: 0x006EC710 File Offset: 0x006EA910
		public static ISkillBtnEffectBase GetRootAsISkillBtnEffectBase(ByteBuffer _bb, ISkillBtnEffectBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060335D9 RID: 210393 RVA: 0x006EC72D File Offset: 0x006EA92D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060335DA RID: 210394 RVA: 0x006EC73C File Offset: 0x006EA93C
		public ISkillBtnEffectBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D757 RID: 55127
		// (get) Token: 0x060335DB RID: 210395 RVA: 0x006EC74C File Offset: 0x006EA94C
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

		// Token: 0x060335DC RID: 210396 RVA: 0x006EC788 File Offset: 0x006EA988
		public static Offset<ISkillBtnEffectBase> CreateISkillBtnEffectBase(FlatBufferBuilder builder, ESkillBtnEffectType Type = ESkillBtnEffectType.MusicBattleBtnEffect)
		{
			builder.StartTable(1);
			ISkillBtnEffectBase.AddType(builder, Type);
			return ISkillBtnEffectBase.EndISkillBtnEffectBase(builder);
		}

		// Token: 0x060335DD RID: 210397 RVA: 0x006EC79E File Offset: 0x006EA99E
		public static void StartISkillBtnEffectBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060335DE RID: 210398 RVA: 0x006EC7A7 File Offset: 0x006EA9A7
		public static void AddType(FlatBufferBuilder builder, ESkillBtnEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060335DF RID: 210399 RVA: 0x006EC7B2 File Offset: 0x006EA9B2
		public static Offset<ISkillBtnEffectBase> EndISkillBtnEffectBase(FlatBufferBuilder builder)
		{
			return new Offset<ISkillBtnEffectBase>(builder.EndTable());
		}

		// Token: 0x060335E0 RID: 210400 RVA: 0x006EC7C0 File Offset: 0x006EA9C0
		public ISkillBtnEffectBaseT UnPack()
		{
			ISkillBtnEffectBaseT skillBtnEffectBaseT = new ISkillBtnEffectBaseT();
			this.UnPackTo(skillBtnEffectBaseT);
			return skillBtnEffectBaseT;
		}

		// Token: 0x060335E1 RID: 210401 RVA: 0x006EC7DB File Offset: 0x006EA9DB
		public void UnPackTo(ISkillBtnEffectBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060335E2 RID: 210402 RVA: 0x006EC7EC File Offset: 0x006EA9EC
		public static Offset<ISkillBtnEffectBase> Pack(FlatBufferBuilder builder, ISkillBtnEffectBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISkillBtnEffectBase>);
			}
			return ISkillBtnEffectBase.CreateISkillBtnEffectBase(builder, _o.Type);
		}

		// Token: 0x04011BC1 RID: 72641
		private Table __p;
	}
}

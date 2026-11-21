using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078F6 RID: 30966
	public struct ISkillBtnEffectBase : IFlatbufferObject
	{
		// Token: 0x1700E339 RID: 58169
		// (get) Token: 0x06036877 RID: 223351 RVA: 0x0074CCEC File Offset: 0x0074AEEC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036878 RID: 223352 RVA: 0x0074CCF9 File Offset: 0x0074AEF9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036879 RID: 223353 RVA: 0x0074CD00 File Offset: 0x0074AF00
		public static ISkillBtnEffectBase GetRootAsISkillBtnEffectBase(ByteBuffer _bb)
		{
			return ISkillBtnEffectBase.GetRootAsISkillBtnEffectBase(_bb, default(ISkillBtnEffectBase));
		}

		// Token: 0x0603687A RID: 223354 RVA: 0x0074CD1C File Offset: 0x0074AF1C
		public static ISkillBtnEffectBase GetRootAsISkillBtnEffectBase(ByteBuffer _bb, ISkillBtnEffectBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603687B RID: 223355 RVA: 0x0074CD39 File Offset: 0x0074AF39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603687C RID: 223356 RVA: 0x0074CD48 File Offset: 0x0074AF48
		public ISkillBtnEffectBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E33A RID: 58170
		// (get) Token: 0x0603687D RID: 223357 RVA: 0x0074CD58 File Offset: 0x0074AF58
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

		// Token: 0x0603687E RID: 223358 RVA: 0x0074CD94 File Offset: 0x0074AF94
		public static Offset<ISkillBtnEffectBase> CreateISkillBtnEffectBase(FlatBufferBuilder builder, ESkillBtnEffectType Type = ESkillBtnEffectType.MusicBattleBtnEffect)
		{
			builder.StartTable(1);
			ISkillBtnEffectBase.AddType(builder, Type);
			return ISkillBtnEffectBase.EndISkillBtnEffectBase(builder);
		}

		// Token: 0x0603687F RID: 223359 RVA: 0x0074CDAA File Offset: 0x0074AFAA
		public static void StartISkillBtnEffectBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036880 RID: 223360 RVA: 0x0074CDB3 File Offset: 0x0074AFB3
		public static void AddType(FlatBufferBuilder builder, ESkillBtnEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036881 RID: 223361 RVA: 0x0074CDBE File Offset: 0x0074AFBE
		public static Offset<ISkillBtnEffectBase> EndISkillBtnEffectBase(FlatBufferBuilder builder)
		{
			return new Offset<ISkillBtnEffectBase>(builder.EndTable());
		}

		// Token: 0x06036882 RID: 223362 RVA: 0x0074CDCC File Offset: 0x0074AFCC
		public ISkillBtnEffectBaseT UnPack()
		{
			ISkillBtnEffectBaseT skillBtnEffectBaseT = new ISkillBtnEffectBaseT();
			this.UnPackTo(skillBtnEffectBaseT);
			return skillBtnEffectBaseT;
		}

		// Token: 0x06036883 RID: 223363 RVA: 0x0074CDE7 File Offset: 0x0074AFE7
		public void UnPackTo(ISkillBtnEffectBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036884 RID: 223364 RVA: 0x0074CDF8 File Offset: 0x0074AFF8
		public static Offset<ISkillBtnEffectBase> Pack(FlatBufferBuilder builder, ISkillBtnEffectBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISkillBtnEffectBase>);
			}
			return ISkillBtnEffectBase.CreateISkillBtnEffectBase(builder, _o.Type);
		}

		// Token: 0x04012BAF RID: 76719
		private Table __p;
	}
}

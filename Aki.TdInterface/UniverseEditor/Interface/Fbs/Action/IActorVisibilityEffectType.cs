using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006778 RID: 26488
	public struct IActorVisibilityEffectType : IFlatbufferObject
	{
		// Token: 0x1700C096 RID: 49302
		// (get) Token: 0x0602CE58 RID: 183896 RVA: 0x0062368D File Offset: 0x0062188D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CE59 RID: 183897 RVA: 0x0062369A File Offset: 0x0062189A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CE5A RID: 183898 RVA: 0x006236A4 File Offset: 0x006218A4
		public static IActorVisibilityEffectType GetRootAsIActorVisibilityEffectType(ByteBuffer _bb)
		{
			return IActorVisibilityEffectType.GetRootAsIActorVisibilityEffectType(_bb, default(IActorVisibilityEffectType));
		}

		// Token: 0x0602CE5B RID: 183899 RVA: 0x006236C0 File Offset: 0x006218C0
		public static IActorVisibilityEffectType GetRootAsIActorVisibilityEffectType(ByteBuffer _bb, IActorVisibilityEffectType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CE5C RID: 183900 RVA: 0x006236DD File Offset: 0x006218DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CE5D RID: 183901 RVA: 0x006236EC File Offset: 0x006218EC
		public IActorVisibilityEffectType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C097 RID: 49303
		// (get) Token: 0x0602CE5E RID: 183902 RVA: 0x006236FC File Offset: 0x006218FC
		public EActorVisibilityEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EActorVisibilityEffectType.Default;
				}
				return (EActorVisibilityEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CE5F RID: 183903 RVA: 0x00623738 File Offset: 0x00621938
		public static Offset<IActorVisibilityEffectType> CreateIActorVisibilityEffectType(FlatBufferBuilder builder, EActorVisibilityEffectType Type = EActorVisibilityEffectType.Default)
		{
			builder.StartTable(1);
			IActorVisibilityEffectType.AddType(builder, Type);
			return IActorVisibilityEffectType.EndIActorVisibilityEffectType(builder);
		}

		// Token: 0x0602CE60 RID: 183904 RVA: 0x0062374E File Offset: 0x0062194E
		public static void StartIActorVisibilityEffectType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602CE61 RID: 183905 RVA: 0x00623757 File Offset: 0x00621957
		public static void AddType(FlatBufferBuilder builder, EActorVisibilityEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CE62 RID: 183906 RVA: 0x00623762 File Offset: 0x00621962
		public static Offset<IActorVisibilityEffectType> EndIActorVisibilityEffectType(FlatBufferBuilder builder)
		{
			return new Offset<IActorVisibilityEffectType>(builder.EndTable());
		}

		// Token: 0x0602CE63 RID: 183907 RVA: 0x00623770 File Offset: 0x00621970
		public IActorVisibilityEffectTypeT UnPack()
		{
			IActorVisibilityEffectTypeT actorVisibilityEffectTypeT = new IActorVisibilityEffectTypeT();
			this.UnPackTo(actorVisibilityEffectTypeT);
			return actorVisibilityEffectTypeT;
		}

		// Token: 0x0602CE64 RID: 183908 RVA: 0x0062378B File Offset: 0x0062198B
		public void UnPackTo(IActorVisibilityEffectTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602CE65 RID: 183909 RVA: 0x0062379C File Offset: 0x0062199C
		public static Offset<IActorVisibilityEffectType> Pack(FlatBufferBuilder builder, IActorVisibilityEffectTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorVisibilityEffectType>);
			}
			return IActorVisibilityEffectType.CreateIActorVisibilityEffectType(builder, _o.Type);
		}

		// Token: 0x040112E6 RID: 70374
		private Table __p;
	}
}

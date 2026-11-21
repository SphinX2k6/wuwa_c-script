using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006775 RID: 26485
	public struct IActorVisibilityEffectDefault : IFlatbufferObject
	{
		// Token: 0x1700C093 RID: 49299
		// (get) Token: 0x0602CE46 RID: 183878 RVA: 0x00623517 File Offset: 0x00621717
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CE47 RID: 183879 RVA: 0x00623524 File Offset: 0x00621724
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CE48 RID: 183880 RVA: 0x0062352C File Offset: 0x0062172C
		public static IActorVisibilityEffectDefault GetRootAsIActorVisibilityEffectDefault(ByteBuffer _bb)
		{
			return IActorVisibilityEffectDefault.GetRootAsIActorVisibilityEffectDefault(_bb, default(IActorVisibilityEffectDefault));
		}

		// Token: 0x0602CE49 RID: 183881 RVA: 0x00623548 File Offset: 0x00621748
		public static IActorVisibilityEffectDefault GetRootAsIActorVisibilityEffectDefault(ByteBuffer _bb, IActorVisibilityEffectDefault obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CE4A RID: 183882 RVA: 0x00623565 File Offset: 0x00621765
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CE4B RID: 183883 RVA: 0x00623574 File Offset: 0x00621774
		public IActorVisibilityEffectDefault __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C094 RID: 49300
		// (get) Token: 0x0602CE4C RID: 183884 RVA: 0x00623584 File Offset: 0x00621784
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

		// Token: 0x0602CE4D RID: 183885 RVA: 0x006235C0 File Offset: 0x006217C0
		public static Offset<IActorVisibilityEffectDefault> CreateIActorVisibilityEffectDefault(FlatBufferBuilder builder, EActorVisibilityEffectType Type = EActorVisibilityEffectType.Default)
		{
			builder.StartTable(1);
			IActorVisibilityEffectDefault.AddType(builder, Type);
			return IActorVisibilityEffectDefault.EndIActorVisibilityEffectDefault(builder);
		}

		// Token: 0x0602CE4E RID: 183886 RVA: 0x006235D6 File Offset: 0x006217D6
		public static void StartIActorVisibilityEffectDefault(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602CE4F RID: 183887 RVA: 0x006235DF File Offset: 0x006217DF
		public static void AddType(FlatBufferBuilder builder, EActorVisibilityEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CE50 RID: 183888 RVA: 0x006235EA File Offset: 0x006217EA
		public static Offset<IActorVisibilityEffectDefault> EndIActorVisibilityEffectDefault(FlatBufferBuilder builder)
		{
			return new Offset<IActorVisibilityEffectDefault>(builder.EndTable());
		}

		// Token: 0x0602CE51 RID: 183889 RVA: 0x006235F8 File Offset: 0x006217F8
		public IActorVisibilityEffectDefaultT UnPack()
		{
			IActorVisibilityEffectDefaultT actorVisibilityEffectDefaultT = new IActorVisibilityEffectDefaultT();
			this.UnPackTo(actorVisibilityEffectDefaultT);
			return actorVisibilityEffectDefaultT;
		}

		// Token: 0x0602CE52 RID: 183890 RVA: 0x00623613 File Offset: 0x00621813
		public void UnPackTo(IActorVisibilityEffectDefaultT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602CE53 RID: 183891 RVA: 0x00623624 File Offset: 0x00621824
		public static Offset<IActorVisibilityEffectDefault> Pack(FlatBufferBuilder builder, IActorVisibilityEffectDefaultT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorVisibilityEffectDefault>);
			}
			return IActorVisibilityEffectDefault.CreateIActorVisibilityEffectDefault(builder, _o.Type);
		}

		// Token: 0x040112E4 RID: 70372
		private Table __p;
	}
}

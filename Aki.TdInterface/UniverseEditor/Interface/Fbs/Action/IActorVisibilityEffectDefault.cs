using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006113 RID: 24851
	public struct IActorVisibilityEffectDefault : IFlatbufferObject
	{
		// Token: 0x1700B728 RID: 46888
		// (get) Token: 0x0602A765 RID: 173925 RVA: 0x005D956F File Offset: 0x005D776F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A766 RID: 173926 RVA: 0x005D957C File Offset: 0x005D777C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A767 RID: 173927 RVA: 0x005D9584 File Offset: 0x005D7784
		public static IActorVisibilityEffectDefault GetRootAsIActorVisibilityEffectDefault(ByteBuffer _bb)
		{
			return IActorVisibilityEffectDefault.GetRootAsIActorVisibilityEffectDefault(_bb, default(IActorVisibilityEffectDefault));
		}

		// Token: 0x0602A768 RID: 173928 RVA: 0x005D95A0 File Offset: 0x005D77A0
		public static IActorVisibilityEffectDefault GetRootAsIActorVisibilityEffectDefault(ByteBuffer _bb, IActorVisibilityEffectDefault obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A769 RID: 173929 RVA: 0x005D95BD File Offset: 0x005D77BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A76A RID: 173930 RVA: 0x005D95CC File Offset: 0x005D77CC
		public IActorVisibilityEffectDefault __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B729 RID: 46889
		// (get) Token: 0x0602A76B RID: 173931 RVA: 0x005D95DC File Offset: 0x005D77DC
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

		// Token: 0x0602A76C RID: 173932 RVA: 0x005D9618 File Offset: 0x005D7818
		public static Offset<IActorVisibilityEffectDefault> CreateIActorVisibilityEffectDefault(FlatBufferBuilder builder, EActorVisibilityEffectType Type = EActorVisibilityEffectType.Default)
		{
			builder.StartTable(1);
			IActorVisibilityEffectDefault.AddType(builder, Type);
			return IActorVisibilityEffectDefault.EndIActorVisibilityEffectDefault(builder);
		}

		// Token: 0x0602A76D RID: 173933 RVA: 0x005D962E File Offset: 0x005D782E
		public static void StartIActorVisibilityEffectDefault(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602A76E RID: 173934 RVA: 0x005D9637 File Offset: 0x005D7837
		public static void AddType(FlatBufferBuilder builder, EActorVisibilityEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A76F RID: 173935 RVA: 0x005D9642 File Offset: 0x005D7842
		public static Offset<IActorVisibilityEffectDefault> EndIActorVisibilityEffectDefault(FlatBufferBuilder builder)
		{
			return new Offset<IActorVisibilityEffectDefault>(builder.EndTable());
		}

		// Token: 0x0602A770 RID: 173936 RVA: 0x005D9650 File Offset: 0x005D7850
		public IActorVisibilityEffectDefaultT UnPack()
		{
			IActorVisibilityEffectDefaultT actorVisibilityEffectDefaultT = new IActorVisibilityEffectDefaultT();
			this.UnPackTo(actorVisibilityEffectDefaultT);
			return actorVisibilityEffectDefaultT;
		}

		// Token: 0x0602A771 RID: 173937 RVA: 0x005D966B File Offset: 0x005D786B
		public void UnPackTo(IActorVisibilityEffectDefaultT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602A772 RID: 173938 RVA: 0x005D967C File Offset: 0x005D787C
		public static Offset<IActorVisibilityEffectDefault> Pack(FlatBufferBuilder builder, IActorVisibilityEffectDefaultT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorVisibilityEffectDefault>);
			}
			return IActorVisibilityEffectDefault.CreateIActorVisibilityEffectDefault(builder, _o.Type);
		}

		// Token: 0x040104E0 RID: 66784
		private Table __p;
	}
}

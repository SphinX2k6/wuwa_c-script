using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006116 RID: 24854
	public struct IActorVisibilityEffectType : IFlatbufferObject
	{
		// Token: 0x1700B72B RID: 46891
		// (get) Token: 0x0602A777 RID: 173943 RVA: 0x005D96E5 File Offset: 0x005D78E5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A778 RID: 173944 RVA: 0x005D96F2 File Offset: 0x005D78F2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A779 RID: 173945 RVA: 0x005D96FC File Offset: 0x005D78FC
		public static IActorVisibilityEffectType GetRootAsIActorVisibilityEffectType(ByteBuffer _bb)
		{
			return IActorVisibilityEffectType.GetRootAsIActorVisibilityEffectType(_bb, default(IActorVisibilityEffectType));
		}

		// Token: 0x0602A77A RID: 173946 RVA: 0x005D9718 File Offset: 0x005D7918
		public static IActorVisibilityEffectType GetRootAsIActorVisibilityEffectType(ByteBuffer _bb, IActorVisibilityEffectType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A77B RID: 173947 RVA: 0x005D9735 File Offset: 0x005D7935
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A77C RID: 173948 RVA: 0x005D9744 File Offset: 0x005D7944
		public IActorVisibilityEffectType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B72C RID: 46892
		// (get) Token: 0x0602A77D RID: 173949 RVA: 0x005D9754 File Offset: 0x005D7954
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

		// Token: 0x0602A77E RID: 173950 RVA: 0x005D9790 File Offset: 0x005D7990
		public static Offset<IActorVisibilityEffectType> CreateIActorVisibilityEffectType(FlatBufferBuilder builder, EActorVisibilityEffectType Type = EActorVisibilityEffectType.Default)
		{
			builder.StartTable(1);
			IActorVisibilityEffectType.AddType(builder, Type);
			return IActorVisibilityEffectType.EndIActorVisibilityEffectType(builder);
		}

		// Token: 0x0602A77F RID: 173951 RVA: 0x005D97A6 File Offset: 0x005D79A6
		public static void StartIActorVisibilityEffectType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602A780 RID: 173952 RVA: 0x005D97AF File Offset: 0x005D79AF
		public static void AddType(FlatBufferBuilder builder, EActorVisibilityEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A781 RID: 173953 RVA: 0x005D97BA File Offset: 0x005D79BA
		public static Offset<IActorVisibilityEffectType> EndIActorVisibilityEffectType(FlatBufferBuilder builder)
		{
			return new Offset<IActorVisibilityEffectType>(builder.EndTable());
		}

		// Token: 0x0602A782 RID: 173954 RVA: 0x005D97C8 File Offset: 0x005D79C8
		public IActorVisibilityEffectTypeT UnPack()
		{
			IActorVisibilityEffectTypeT actorVisibilityEffectTypeT = new IActorVisibilityEffectTypeT();
			this.UnPackTo(actorVisibilityEffectTypeT);
			return actorVisibilityEffectTypeT;
		}

		// Token: 0x0602A783 RID: 173955 RVA: 0x005D97E3 File Offset: 0x005D79E3
		public void UnPackTo(IActorVisibilityEffectTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602A784 RID: 173956 RVA: 0x005D97F4 File Offset: 0x005D79F4
		public static Offset<IActorVisibilityEffectType> Pack(FlatBufferBuilder builder, IActorVisibilityEffectTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorVisibilityEffectType>);
			}
			return IActorVisibilityEffectType.CreateIActorVisibilityEffectType(builder, _o.Type);
		}

		// Token: 0x040104E2 RID: 66786
		private Table __p;
	}
}

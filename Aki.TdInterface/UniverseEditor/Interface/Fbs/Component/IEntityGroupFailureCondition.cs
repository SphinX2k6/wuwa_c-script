using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005180 RID: 20864
	public struct IEntityGroupFailureCondition : IFlatbufferObject
	{
		// Token: 0x17009871 RID: 39025
		// (get) Token: 0x06021BC5 RID: 138181 RVA: 0x004AE6B5 File Offset: 0x004AC8B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021BC6 RID: 138182 RVA: 0x004AE6C2 File Offset: 0x004AC8C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021BC7 RID: 138183 RVA: 0x004AE6CC File Offset: 0x004AC8CC
		public static IEntityGroupFailureCondition GetRootAsIEntityGroupFailureCondition(ByteBuffer _bb)
		{
			return IEntityGroupFailureCondition.GetRootAsIEntityGroupFailureCondition(_bb, default(IEntityGroupFailureCondition));
		}

		// Token: 0x06021BC8 RID: 138184 RVA: 0x004AE6E8 File Offset: 0x004AC8E8
		public static IEntityGroupFailureCondition GetRootAsIEntityGroupFailureCondition(ByteBuffer _bb, IEntityGroupFailureCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021BC9 RID: 138185 RVA: 0x004AE705 File Offset: 0x004AC905
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021BCA RID: 138186 RVA: 0x004AE714 File Offset: 0x004AC914
		public IEntityGroupFailureCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009872 RID: 39026
		// (get) Token: 0x06021BCB RID: 138187 RVA: 0x004AE724 File Offset: 0x004AC924
		public EEntityGroupFailureCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEntityGroupFailureCondition.SequentialState;
				}
				return (EEntityGroupFailureCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021BCC RID: 138188 RVA: 0x004AE760 File Offset: 0x004AC960
		public static Offset<IEntityGroupFailureCondition> CreateIEntityGroupFailureCondition(FlatBufferBuilder builder, EEntityGroupFailureCondition Type = EEntityGroupFailureCondition.SequentialState)
		{
			builder.StartTable(1);
			IEntityGroupFailureCondition.AddType(builder, Type);
			return IEntityGroupFailureCondition.EndIEntityGroupFailureCondition(builder);
		}

		// Token: 0x06021BCD RID: 138189 RVA: 0x004AE776 File Offset: 0x004AC976
		public static void StartIEntityGroupFailureCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06021BCE RID: 138190 RVA: 0x004AE77F File Offset: 0x004AC97F
		public static void AddType(FlatBufferBuilder builder, EEntityGroupFailureCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021BCF RID: 138191 RVA: 0x004AE78A File Offset: 0x004AC98A
		public static Offset<IEntityGroupFailureCondition> EndIEntityGroupFailureCondition(FlatBufferBuilder builder)
		{
			return new Offset<IEntityGroupFailureCondition>(builder.EndTable());
		}

		// Token: 0x06021BD0 RID: 138192 RVA: 0x004AE798 File Offset: 0x004AC998
		public IEntityGroupFailureConditionT UnPack()
		{
			IEntityGroupFailureConditionT entityGroupFailureConditionT = new IEntityGroupFailureConditionT();
			this.UnPackTo(entityGroupFailureConditionT);
			return entityGroupFailureConditionT;
		}

		// Token: 0x06021BD1 RID: 138193 RVA: 0x004AE7B3 File Offset: 0x004AC9B3
		public void UnPackTo(IEntityGroupFailureConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06021BD2 RID: 138194 RVA: 0x004AE7C4 File Offset: 0x004AC9C4
		public static Offset<IEntityGroupFailureCondition> Pack(FlatBufferBuilder builder, IEntityGroupFailureConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityGroupFailureCondition>);
			}
			return IEntityGroupFailureCondition.CreateIEntityGroupFailureCondition(builder, _o.Type);
		}

		// Token: 0x0400E24F RID: 57935
		private Table __p;
	}
}

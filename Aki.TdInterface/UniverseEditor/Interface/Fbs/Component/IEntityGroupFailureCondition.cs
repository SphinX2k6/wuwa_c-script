using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056E5 RID: 22245
	public struct IEntityGroupFailureCondition : IFlatbufferObject
	{
		// Token: 0x1700A060 RID: 41056
		// (get) Token: 0x06023B1D RID: 146205 RVA: 0x004E86D5 File Offset: 0x004E68D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023B1E RID: 146206 RVA: 0x004E86E2 File Offset: 0x004E68E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023B1F RID: 146207 RVA: 0x004E86EC File Offset: 0x004E68EC
		public static IEntityGroupFailureCondition GetRootAsIEntityGroupFailureCondition(ByteBuffer _bb)
		{
			return IEntityGroupFailureCondition.GetRootAsIEntityGroupFailureCondition(_bb, default(IEntityGroupFailureCondition));
		}

		// Token: 0x06023B20 RID: 146208 RVA: 0x004E8708 File Offset: 0x004E6908
		public static IEntityGroupFailureCondition GetRootAsIEntityGroupFailureCondition(ByteBuffer _bb, IEntityGroupFailureCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023B21 RID: 146209 RVA: 0x004E8725 File Offset: 0x004E6925
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023B22 RID: 146210 RVA: 0x004E8734 File Offset: 0x004E6934
		public IEntityGroupFailureCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A061 RID: 41057
		// (get) Token: 0x06023B23 RID: 146211 RVA: 0x004E8744 File Offset: 0x004E6944
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

		// Token: 0x06023B24 RID: 146212 RVA: 0x004E8780 File Offset: 0x004E6980
		public static Offset<IEntityGroupFailureCondition> CreateIEntityGroupFailureCondition(FlatBufferBuilder builder, EEntityGroupFailureCondition Type = EEntityGroupFailureCondition.SequentialState)
		{
			builder.StartTable(1);
			IEntityGroupFailureCondition.AddType(builder, Type);
			return IEntityGroupFailureCondition.EndIEntityGroupFailureCondition(builder);
		}

		// Token: 0x06023B25 RID: 146213 RVA: 0x004E8796 File Offset: 0x004E6996
		public static void StartIEntityGroupFailureCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06023B26 RID: 146214 RVA: 0x004E879F File Offset: 0x004E699F
		public static void AddType(FlatBufferBuilder builder, EEntityGroupFailureCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023B27 RID: 146215 RVA: 0x004E87AA File Offset: 0x004E69AA
		public static Offset<IEntityGroupFailureCondition> EndIEntityGroupFailureCondition(FlatBufferBuilder builder)
		{
			return new Offset<IEntityGroupFailureCondition>(builder.EndTable());
		}

		// Token: 0x06023B28 RID: 146216 RVA: 0x004E87B8 File Offset: 0x004E69B8
		public IEntityGroupFailureConditionT UnPack()
		{
			IEntityGroupFailureConditionT entityGroupFailureConditionT = new IEntityGroupFailureConditionT();
			this.UnPackTo(entityGroupFailureConditionT);
			return entityGroupFailureConditionT;
		}

		// Token: 0x06023B29 RID: 146217 RVA: 0x004E87D3 File Offset: 0x004E69D3
		public void UnPackTo(IEntityGroupFailureConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06023B2A RID: 146218 RVA: 0x004E87E4 File Offset: 0x004E69E4
		public static Offset<IEntityGroupFailureCondition> Pack(FlatBufferBuilder builder, IEntityGroupFailureConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityGroupFailureCondition>);
			}
			return IEntityGroupFailureCondition.CreateIEntityGroupFailureCondition(builder, _o.Type);
		}

		// Token: 0x0400EE4D RID: 61005
		private Table __p;
	}
}

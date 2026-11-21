using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005148 RID: 20808
	public struct IMechCondition : IFlatbufferObject
	{
		// Token: 0x17009524 RID: 38180
		// (get) Token: 0x06020BC3 RID: 134083 RVA: 0x00488FBE File Offset: 0x004871BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020BC4 RID: 134084 RVA: 0x00488FCB File Offset: 0x004871CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020BC5 RID: 134085 RVA: 0x00488FD4 File Offset: 0x004871D4
		public static IMechCondition GetRootAsIMechCondition(ByteBuffer _bb)
		{
			return IMechCondition.GetRootAsIMechCondition(_bb, default(IMechCondition));
		}

		// Token: 0x06020BC6 RID: 134086 RVA: 0x00488FF0 File Offset: 0x004871F0
		public static IMechCondition GetRootAsIMechCondition(ByteBuffer _bb, IMechCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020BC7 RID: 134087 RVA: 0x0048900D File Offset: 0x0048720D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020BC8 RID: 134088 RVA: 0x0048901C File Offset: 0x0048721C
		public IMechCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009525 RID: 38181
		// (get) Token: 0x06020BC9 RID: 134089 RVA: 0x0048902C File Offset: 0x0048722C
		public EMechConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMechConditionType.PlayerInMech;
				}
				return (EMechConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020BCA RID: 134090 RVA: 0x00489068 File Offset: 0x00487268
		public static Offset<IMechCondition> CreateIMechCondition(FlatBufferBuilder builder, EMechConditionType Type = EMechConditionType.PlayerInMech)
		{
			builder.StartTable(1);
			IMechCondition.AddType(builder, Type);
			return IMechCondition.EndIMechCondition(builder);
		}

		// Token: 0x06020BCB RID: 134091 RVA: 0x0048907E File Offset: 0x0048727E
		public static void StartIMechCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06020BCC RID: 134092 RVA: 0x00489087 File Offset: 0x00487287
		public static void AddType(FlatBufferBuilder builder, EMechConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020BCD RID: 134093 RVA: 0x00489092 File Offset: 0x00487292
		public static Offset<IMechCondition> EndIMechCondition(FlatBufferBuilder builder)
		{
			return new Offset<IMechCondition>(builder.EndTable());
		}

		// Token: 0x06020BCE RID: 134094 RVA: 0x004890A0 File Offset: 0x004872A0
		public IMechConditionT UnPack()
		{
			IMechConditionT mechConditionT = new IMechConditionT();
			this.UnPackTo(mechConditionT);
			return mechConditionT;
		}

		// Token: 0x06020BCF RID: 134095 RVA: 0x004890BB File Offset: 0x004872BB
		public void UnPackTo(IMechConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06020BD0 RID: 134096 RVA: 0x004890CC File Offset: 0x004872CC
		public static Offset<IMechCondition> Pack(FlatBufferBuilder builder, IMechConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechCondition>);
			}
			return IMechCondition.CreateIMechCondition(builder, _o.Type);
		}

		// Token: 0x0400E11E RID: 57630
		private Table __p;
	}
}

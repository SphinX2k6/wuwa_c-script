using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D00 RID: 19712
	public struct ITrafficMatchTargetType : IFlatbufferObject
	{
		// Token: 0x17008F06 RID: 36614
		// (get) Token: 0x0601F4A2 RID: 128162 RVA: 0x0045D78B File Offset: 0x0045B98B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F4A3 RID: 128163 RVA: 0x0045D798 File Offset: 0x0045B998
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F4A4 RID: 128164 RVA: 0x0045D7A0 File Offset: 0x0045B9A0
		public static ITrafficMatchTargetType GetRootAsITrafficMatchTargetType(ByteBuffer _bb)
		{
			return ITrafficMatchTargetType.GetRootAsITrafficMatchTargetType(_bb, default(ITrafficMatchTargetType));
		}

		// Token: 0x0601F4A5 RID: 128165 RVA: 0x0045D7BC File Offset: 0x0045B9BC
		public static ITrafficMatchTargetType GetRootAsITrafficMatchTargetType(ByteBuffer _bb, ITrafficMatchTargetType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F4A6 RID: 128166 RVA: 0x0045D7D9 File Offset: 0x0045B9D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F4A7 RID: 128167 RVA: 0x0045D7E8 File Offset: 0x0045B9E8
		public ITrafficMatchTargetType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F07 RID: 36615
		// (get) Token: 0x0601F4A8 RID: 128168 RVA: 0x0045D7F8 File Offset: 0x0045B9F8
		public ETrafficMatchTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrafficMatchTargetType.MatchByEntityLogic;
				}
				return (ETrafficMatchTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F4A9 RID: 128169 RVA: 0x0045D834 File Offset: 0x0045BA34
		public static Offset<ITrafficMatchTargetType> CreateITrafficMatchTargetType(FlatBufferBuilder builder, ETrafficMatchTargetType Type = ETrafficMatchTargetType.MatchByEntityLogic)
		{
			builder.StartTable(1);
			ITrafficMatchTargetType.AddType(builder, Type);
			return ITrafficMatchTargetType.EndITrafficMatchTargetType(builder);
		}

		// Token: 0x0601F4AA RID: 128170 RVA: 0x0045D84A File Offset: 0x0045BA4A
		public static void StartITrafficMatchTargetType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601F4AB RID: 128171 RVA: 0x0045D853 File Offset: 0x0045BA53
		public static void AddType(FlatBufferBuilder builder, ETrafficMatchTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F4AC RID: 128172 RVA: 0x0045D85E File Offset: 0x0045BA5E
		public static Offset<ITrafficMatchTargetType> EndITrafficMatchTargetType(FlatBufferBuilder builder)
		{
			return new Offset<ITrafficMatchTargetType>(builder.EndTable());
		}

		// Token: 0x0601F4AD RID: 128173 RVA: 0x0045D86C File Offset: 0x0045BA6C
		public ITrafficMatchTargetTypeT UnPack()
		{
			ITrafficMatchTargetTypeT trafficMatchTargetTypeT = new ITrafficMatchTargetTypeT();
			this.UnPackTo(trafficMatchTargetTypeT);
			return trafficMatchTargetTypeT;
		}

		// Token: 0x0601F4AE RID: 128174 RVA: 0x0045D887 File Offset: 0x0045BA87
		public void UnPackTo(ITrafficMatchTargetTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601F4AF RID: 128175 RVA: 0x0045D898 File Offset: 0x0045BA98
		public static Offset<ITrafficMatchTargetType> Pack(FlatBufferBuilder builder, ITrafficMatchTargetTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrafficMatchTargetType>);
			}
			return ITrafficMatchTargetType.CreateITrafficMatchTargetType(builder, _o.Type);
		}

		// Token: 0x0400D6DC RID: 55004
		private Table __p;
	}
}

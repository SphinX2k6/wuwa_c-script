using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007304 RID: 29444
	public struct INpcGroupPerformInitiatorType : IFlatbufferObject
	{
		// Token: 0x1700D7E3 RID: 55267
		// (get) Token: 0x06033593 RID: 210323 RVA: 0x006ECCCB File Offset: 0x006EAECB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033594 RID: 210324 RVA: 0x006ECCD8 File Offset: 0x006EAED8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033595 RID: 210325 RVA: 0x006ECCE0 File Offset: 0x006EAEE0
		public static INpcGroupPerformInitiatorType GetRootAsINpcGroupPerformInitiatorType(ByteBuffer _bb)
		{
			return INpcGroupPerformInitiatorType.GetRootAsINpcGroupPerformInitiatorType(_bb, default(INpcGroupPerformInitiatorType));
		}

		// Token: 0x06033596 RID: 210326 RVA: 0x006ECCFC File Offset: 0x006EAEFC
		public static INpcGroupPerformInitiatorType GetRootAsINpcGroupPerformInitiatorType(ByteBuffer _bb, INpcGroupPerformInitiatorType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033597 RID: 210327 RVA: 0x006ECD19 File Offset: 0x006EAF19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033598 RID: 210328 RVA: 0x006ECD28 File Offset: 0x006EAF28
		public INpcGroupPerformInitiatorType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D7E4 RID: 55268
		// (get) Token: 0x06033599 RID: 210329 RVA: 0x006ECD38 File Offset: 0x006EAF38
		public ENpcGroupPerformInitiatorType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcGroupPerformInitiatorType.Player;
				}
				return (ENpcGroupPerformInitiatorType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603359A RID: 210330 RVA: 0x006ECD74 File Offset: 0x006EAF74
		public static Offset<INpcGroupPerformInitiatorType> CreateINpcGroupPerformInitiatorType(FlatBufferBuilder builder, ENpcGroupPerformInitiatorType Type = ENpcGroupPerformInitiatorType.Player)
		{
			builder.StartTable(1);
			INpcGroupPerformInitiatorType.AddType(builder, Type);
			return INpcGroupPerformInitiatorType.EndINpcGroupPerformInitiatorType(builder);
		}

		// Token: 0x0603359B RID: 210331 RVA: 0x006ECD8A File Offset: 0x006EAF8A
		public static void StartINpcGroupPerformInitiatorType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603359C RID: 210332 RVA: 0x006ECD93 File Offset: 0x006EAF93
		public static void AddType(FlatBufferBuilder builder, ENpcGroupPerformInitiatorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603359D RID: 210333 RVA: 0x006ECD9E File Offset: 0x006EAF9E
		public static Offset<INpcGroupPerformInitiatorType> EndINpcGroupPerformInitiatorType(FlatBufferBuilder builder)
		{
			return new Offset<INpcGroupPerformInitiatorType>(builder.EndTable());
		}

		// Token: 0x0603359E RID: 210334 RVA: 0x006ECDAC File Offset: 0x006EAFAC
		public INpcGroupPerformInitiatorTypeT UnPack()
		{
			INpcGroupPerformInitiatorTypeT npcGroupPerformInitiatorTypeT = new INpcGroupPerformInitiatorTypeT();
			this.UnPackTo(npcGroupPerformInitiatorTypeT);
			return npcGroupPerformInitiatorTypeT;
		}

		// Token: 0x0603359F RID: 210335 RVA: 0x006ECDC7 File Offset: 0x006EAFC7
		public void UnPackTo(INpcGroupPerformInitiatorTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060335A0 RID: 210336 RVA: 0x006ECDD8 File Offset: 0x006EAFD8
		public static Offset<INpcGroupPerformInitiatorType> Pack(FlatBufferBuilder builder, INpcGroupPerformInitiatorTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcGroupPerformInitiatorType>);
			}
			return INpcGroupPerformInitiatorType.CreateINpcGroupPerformInitiatorType(builder, _o.Type);
		}

		// Token: 0x040123BF RID: 74687
		private Table __p;
	}
}

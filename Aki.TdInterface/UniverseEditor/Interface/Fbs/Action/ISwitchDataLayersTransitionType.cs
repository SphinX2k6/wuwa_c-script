using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007250 RID: 29264
	public struct ISwitchDataLayersTransitionType : IFlatbufferObject
	{
		// Token: 0x1700D926 RID: 55590
		// (get) Token: 0x06033E94 RID: 212628 RVA: 0x006FB98F File Offset: 0x006F9B8F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033E95 RID: 212629 RVA: 0x006FB99C File Offset: 0x006F9B9C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033E96 RID: 212630 RVA: 0x006FB9A4 File Offset: 0x006F9BA4
		public static ISwitchDataLayersTransitionType GetRootAsISwitchDataLayersTransitionType(ByteBuffer _bb)
		{
			return ISwitchDataLayersTransitionType.GetRootAsISwitchDataLayersTransitionType(_bb, default(ISwitchDataLayersTransitionType));
		}

		// Token: 0x06033E97 RID: 212631 RVA: 0x006FB9C0 File Offset: 0x006F9BC0
		public static ISwitchDataLayersTransitionType GetRootAsISwitchDataLayersTransitionType(ByteBuffer _bb, ISwitchDataLayersTransitionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033E98 RID: 212632 RVA: 0x006FB9DD File Offset: 0x006F9BDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033E99 RID: 212633 RVA: 0x006FB9EC File Offset: 0x006F9BEC
		public ISwitchDataLayersTransitionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D927 RID: 55591
		// (get) Token: 0x06033E9A RID: 212634 RVA: 0x006FB9FC File Offset: 0x006F9BFC
		public ESwitchDataLayersTransitionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESwitchDataLayersTransitionType.Sequence;
				}
				return (ESwitchDataLayersTransitionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033E9B RID: 212635 RVA: 0x006FBA38 File Offset: 0x006F9C38
		public static Offset<ISwitchDataLayersTransitionType> CreateISwitchDataLayersTransitionType(FlatBufferBuilder builder, ESwitchDataLayersTransitionType Type = ESwitchDataLayersTransitionType.Sequence)
		{
			builder.StartTable(1);
			ISwitchDataLayersTransitionType.AddType(builder, Type);
			return ISwitchDataLayersTransitionType.EndISwitchDataLayersTransitionType(builder);
		}

		// Token: 0x06033E9C RID: 212636 RVA: 0x006FBA4E File Offset: 0x006F9C4E
		public static void StartISwitchDataLayersTransitionType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033E9D RID: 212637 RVA: 0x006FBA57 File Offset: 0x006F9C57
		public static void AddType(FlatBufferBuilder builder, ESwitchDataLayersTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033E9E RID: 212638 RVA: 0x006FBA62 File Offset: 0x006F9C62
		public static Offset<ISwitchDataLayersTransitionType> EndISwitchDataLayersTransitionType(FlatBufferBuilder builder)
		{
			return new Offset<ISwitchDataLayersTransitionType>(builder.EndTable());
		}

		// Token: 0x06033E9F RID: 212639 RVA: 0x006FBA70 File Offset: 0x006F9C70
		public ISwitchDataLayersTransitionTypeT UnPack()
		{
			ISwitchDataLayersTransitionTypeT switchDataLayersTransitionTypeT = new ISwitchDataLayersTransitionTypeT();
			this.UnPackTo(switchDataLayersTransitionTypeT);
			return switchDataLayersTransitionTypeT;
		}

		// Token: 0x06033EA0 RID: 212640 RVA: 0x006FBA8B File Offset: 0x006F9C8B
		public void UnPackTo(ISwitchDataLayersTransitionTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033EA1 RID: 212641 RVA: 0x006FBA9C File Offset: 0x006F9C9C
		public static Offset<ISwitchDataLayersTransitionType> Pack(FlatBufferBuilder builder, ISwitchDataLayersTransitionTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISwitchDataLayersTransitionType>);
			}
			return ISwitchDataLayersTransitionType.CreateISwitchDataLayersTransitionType(builder, _o.Type);
		}

		// Token: 0x04011D44 RID: 73028
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072F5 RID: 29429
	public struct ITalkItemPhoneMessageSystemTip : IFlatbufferObject
	{
		// Token: 0x1700DD6A RID: 56682
		// (get) Token: 0x06034EAB RID: 216747 RVA: 0x0072AC12 File Offset: 0x00728E12
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034EAC RID: 216748 RVA: 0x0072AC1F File Offset: 0x00728E1F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034EAD RID: 216749 RVA: 0x0072AC28 File Offset: 0x00728E28
		public static ITalkItemPhoneMessageSystemTip GetRootAsITalkItemPhoneMessageSystemTip(ByteBuffer _bb)
		{
			return ITalkItemPhoneMessageSystemTip.GetRootAsITalkItemPhoneMessageSystemTip(_bb, default(ITalkItemPhoneMessageSystemTip));
		}

		// Token: 0x06034EAE RID: 216750 RVA: 0x0072AC44 File Offset: 0x00728E44
		public static ITalkItemPhoneMessageSystemTip GetRootAsITalkItemPhoneMessageSystemTip(ByteBuffer _bb, ITalkItemPhoneMessageSystemTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034EAF RID: 216751 RVA: 0x0072AC61 File Offset: 0x00728E61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034EB0 RID: 216752 RVA: 0x0072AC70 File Offset: 0x00728E70
		public ITalkItemPhoneMessageSystemTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD6B RID: 56683
		// (get) Token: 0x06034EB1 RID: 216753 RVA: 0x0072AC80 File Offset: 0x00728E80
		public EPhoneMessageType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhoneMessageType.Voice;
				}
				return (EPhoneMessageType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034EB2 RID: 216754 RVA: 0x0072ACBC File Offset: 0x00728EBC
		public static Offset<ITalkItemPhoneMessageSystemTip> CreateITalkItemPhoneMessageSystemTip(FlatBufferBuilder builder, EPhoneMessageType Type = EPhoneMessageType.Voice)
		{
			builder.StartTable(1);
			ITalkItemPhoneMessageSystemTip.AddType(builder, Type);
			return ITalkItemPhoneMessageSystemTip.EndITalkItemPhoneMessageSystemTip(builder);
		}

		// Token: 0x06034EB3 RID: 216755 RVA: 0x0072ACD2 File Offset: 0x00728ED2
		public static void StartITalkItemPhoneMessageSystemTip(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034EB4 RID: 216756 RVA: 0x0072ACDB File Offset: 0x00728EDB
		public static void AddType(FlatBufferBuilder builder, EPhoneMessageType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034EB5 RID: 216757 RVA: 0x0072ACE6 File Offset: 0x00728EE6
		public static Offset<ITalkItemPhoneMessageSystemTip> EndITalkItemPhoneMessageSystemTip(FlatBufferBuilder builder)
		{
			return new Offset<ITalkItemPhoneMessageSystemTip>(builder.EndTable());
		}

		// Token: 0x06034EB6 RID: 216758 RVA: 0x0072ACF4 File Offset: 0x00728EF4
		public ITalkItemPhoneMessageSystemTipT UnPack()
		{
			ITalkItemPhoneMessageSystemTipT talkItemPhoneMessageSystemTipT = new ITalkItemPhoneMessageSystemTipT();
			this.UnPackTo(talkItemPhoneMessageSystemTipT);
			return talkItemPhoneMessageSystemTipT;
		}

		// Token: 0x06034EB7 RID: 216759 RVA: 0x0072AD0F File Offset: 0x00728F0F
		public void UnPackTo(ITalkItemPhoneMessageSystemTipT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06034EB8 RID: 216760 RVA: 0x0072AD20 File Offset: 0x00728F20
		public static Offset<ITalkItemPhoneMessageSystemTip> Pack(FlatBufferBuilder builder, ITalkItemPhoneMessageSystemTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkItemPhoneMessageSystemTip>);
			}
			return ITalkItemPhoneMessageSystemTip.CreateITalkItemPhoneMessageSystemTip(builder, _o.Type);
		}

		// Token: 0x04011FB1 RID: 73649
		private Table __p;
	}
}

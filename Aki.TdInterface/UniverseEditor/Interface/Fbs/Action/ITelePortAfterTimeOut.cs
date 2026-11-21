using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B5A RID: 31578
	public struct ITelePortAfterTimeOut : IFlatbufferObject
	{
		// Token: 0x1700EC6E RID: 60526
		// (get) Token: 0x06038DCF RID: 232911 RVA: 0x007B00BE File Offset: 0x007AE2BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038DD0 RID: 232912 RVA: 0x007B00CB File Offset: 0x007AE2CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038DD1 RID: 232913 RVA: 0x007B00D4 File Offset: 0x007AE2D4
		public static ITelePortAfterTimeOut GetRootAsITelePortAfterTimeOut(ByteBuffer _bb)
		{
			return ITelePortAfterTimeOut.GetRootAsITelePortAfterTimeOut(_bb, default(ITelePortAfterTimeOut));
		}

		// Token: 0x06038DD2 RID: 232914 RVA: 0x007B00F0 File Offset: 0x007AE2F0
		public static ITelePortAfterTimeOut GetRootAsITelePortAfterTimeOut(ByteBuffer _bb, ITelePortAfterTimeOut obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038DD3 RID: 232915 RVA: 0x007B010D File Offset: 0x007AE30D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038DD4 RID: 232916 RVA: 0x007B011C File Offset: 0x007AE31C
		public ITelePortAfterTimeOut __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EC6F RID: 60527
		// (get) Token: 0x06038DD5 RID: 232917 RVA: 0x007B012C File Offset: 0x007AE32C
		public ETeammateTeleportType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeammateTeleportType.TelePortAfterTimeOut;
				}
				return (ETeammateTeleportType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EC70 RID: 60528
		// (get) Token: 0x06038DD6 RID: 232918 RVA: 0x007B0168 File Offset: 0x007AE368
		public int TimeOut
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06038DD7 RID: 232919 RVA: 0x007B01A4 File Offset: 0x007AE3A4
		public static Offset<ITelePortAfterTimeOut> CreateITelePortAfterTimeOut(FlatBufferBuilder builder, ETeammateTeleportType Type = ETeammateTeleportType.TelePortAfterTimeOut, int TimeOut = 0)
		{
			builder.StartTable(2);
			ITelePortAfterTimeOut.AddTimeOut(builder, TimeOut);
			ITelePortAfterTimeOut.AddType(builder, Type);
			return ITelePortAfterTimeOut.EndITelePortAfterTimeOut(builder);
		}

		// Token: 0x06038DD8 RID: 232920 RVA: 0x007B01C1 File Offset: 0x007AE3C1
		public static void StartITelePortAfterTimeOut(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06038DD9 RID: 232921 RVA: 0x007B01CA File Offset: 0x007AE3CA
		public static void AddType(FlatBufferBuilder builder, ETeammateTeleportType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038DDA RID: 232922 RVA: 0x007B01D5 File Offset: 0x007AE3D5
		public static void AddTimeOut(FlatBufferBuilder builder, int timeOut)
		{
			builder.AddInt(1, timeOut, 0);
		}

		// Token: 0x06038DDB RID: 232923 RVA: 0x007B01E0 File Offset: 0x007AE3E0
		public static Offset<ITelePortAfterTimeOut> EndITelePortAfterTimeOut(FlatBufferBuilder builder)
		{
			return new Offset<ITelePortAfterTimeOut>(builder.EndTable());
		}

		// Token: 0x06038DDC RID: 232924 RVA: 0x007B01F0 File Offset: 0x007AE3F0
		public ITelePortAfterTimeOutT UnPack()
		{
			ITelePortAfterTimeOutT telePortAfterTimeOutT = new ITelePortAfterTimeOutT();
			this.UnPackTo(telePortAfterTimeOutT);
			return telePortAfterTimeOutT;
		}

		// Token: 0x06038DDD RID: 232925 RVA: 0x007B020B File Offset: 0x007AE40B
		public void UnPackTo(ITelePortAfterTimeOutT _o)
		{
			_o.Type = this.Type;
			_o.TimeOut = this.TimeOut;
		}

		// Token: 0x06038DDE RID: 232926 RVA: 0x007B0228 File Offset: 0x007AE428
		public static Offset<ITelePortAfterTimeOut> Pack(FlatBufferBuilder builder, ITelePortAfterTimeOutT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITelePortAfterTimeOut>);
			}
			return ITelePortAfterTimeOut.CreateITelePortAfterTimeOut(builder, _o.Type, _o.TimeOut);
		}

		// Token: 0x0401319B RID: 78235
		private Table __p;
	}
}

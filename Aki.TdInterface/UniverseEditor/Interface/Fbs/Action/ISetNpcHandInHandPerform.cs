using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007800 RID: 30720
	public struct ISetNpcHandInHandPerform : IFlatbufferObject
	{
		// Token: 0x1700E121 RID: 57633
		// (get) Token: 0x06035F7F RID: 221055 RVA: 0x0073AA80 File Offset: 0x00738C80
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035F80 RID: 221056 RVA: 0x0073AA8D File Offset: 0x00738C8D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035F81 RID: 221057 RVA: 0x0073AA94 File Offset: 0x00738C94
		public static ISetNpcHandInHandPerform GetRootAsISetNpcHandInHandPerform(ByteBuffer _bb)
		{
			return ISetNpcHandInHandPerform.GetRootAsISetNpcHandInHandPerform(_bb, default(ISetNpcHandInHandPerform));
		}

		// Token: 0x06035F82 RID: 221058 RVA: 0x0073AAB0 File Offset: 0x00738CB0
		public static ISetNpcHandInHandPerform GetRootAsISetNpcHandInHandPerform(ByteBuffer _bb, ISetNpcHandInHandPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035F83 RID: 221059 RVA: 0x0073AACD File Offset: 0x00738CCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035F84 RID: 221060 RVA: 0x0073AADC File Offset: 0x00738CDC
		public ISetNpcHandInHandPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E122 RID: 57634
		// (get) Token: 0x06035F85 RID: 221061 RVA: 0x0073AAEC File Offset: 0x00738CEC
		public ENpcGroupPerformType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcGroupPerformType.HandInHand;
				}
				return (ENpcGroupPerformType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E123 RID: 57635
		// (get) Token: 0x06035F86 RID: 221062 RVA: 0x0073AB28 File Offset: 0x00738D28
		public IHandInHandInitiator? Initiator
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IHandInHandInitiator?(default(IHandInHandInitiator).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E124 RID: 57636
		// (get) Token: 0x06035F87 RID: 221063 RVA: 0x0073AB88 File Offset: 0x00738D88
		public int Follower
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035F88 RID: 221064 RVA: 0x0073ABC4 File Offset: 0x00738DC4
		public static Offset<ISetNpcHandInHandPerform> CreateISetNpcHandInHandPerform(FlatBufferBuilder builder, ENpcGroupPerformType Type = ENpcGroupPerformType.HandInHand, Offset<IHandInHandInitiator> InitiatorOffset = default(Offset<IHandInHandInitiator>), int Follower = 0)
		{
			builder.StartTable(3);
			ISetNpcHandInHandPerform.AddFollower(builder, Follower);
			ISetNpcHandInHandPerform.AddInitiator(builder, InitiatorOffset);
			ISetNpcHandInHandPerform.AddType(builder, Type);
			return ISetNpcHandInHandPerform.EndISetNpcHandInHandPerform(builder);
		}

		// Token: 0x06035F89 RID: 221065 RVA: 0x0073ABE8 File Offset: 0x00738DE8
		public static void StartISetNpcHandInHandPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06035F8A RID: 221066 RVA: 0x0073ABF1 File Offset: 0x00738DF1
		public static void AddType(FlatBufferBuilder builder, ENpcGroupPerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035F8B RID: 221067 RVA: 0x0073ABFC File Offset: 0x00738DFC
		public static void AddInitiator(FlatBufferBuilder builder, Offset<IHandInHandInitiator> initiatorOffset)
		{
			builder.AddOffset(1, initiatorOffset.Value, 0);
		}

		// Token: 0x06035F8C RID: 221068 RVA: 0x0073AC0C File Offset: 0x00738E0C
		public static void AddFollower(FlatBufferBuilder builder, int follower)
		{
			builder.AddInt(2, follower, 0);
		}

		// Token: 0x06035F8D RID: 221069 RVA: 0x0073AC17 File Offset: 0x00738E17
		public static Offset<ISetNpcHandInHandPerform> EndISetNpcHandInHandPerform(FlatBufferBuilder builder)
		{
			return new Offset<ISetNpcHandInHandPerform>(builder.EndTable());
		}

		// Token: 0x06035F8E RID: 221070 RVA: 0x0073AC24 File Offset: 0x00738E24
		public ISetNpcHandInHandPerformT UnPack()
		{
			ISetNpcHandInHandPerformT setNpcHandInHandPerformT = new ISetNpcHandInHandPerformT();
			this.UnPackTo(setNpcHandInHandPerformT);
			return setNpcHandInHandPerformT;
		}

		// Token: 0x06035F8F RID: 221071 RVA: 0x0073AC40 File Offset: 0x00738E40
		public void UnPackTo(ISetNpcHandInHandPerformT _o)
		{
			_o.Type = this.Type;
			_o.Initiator = ((this.Initiator != null) ? this.Initiator.Value.UnPack() : null);
			_o.Follower = this.Follower;
		}

		// Token: 0x06035F90 RID: 221072 RVA: 0x0073AC94 File Offset: 0x00738E94
		public static Offset<ISetNpcHandInHandPerform> Pack(FlatBufferBuilder builder, ISetNpcHandInHandPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetNpcHandInHandPerform>);
			}
			Offset<IHandInHandInitiator> initiatorOffset = (_o.Initiator == null) ? default(Offset<IHandInHandInitiator>) : IHandInHandInitiator.Pack(builder, _o.Initiator);
			return ISetNpcHandInHandPerform.CreateISetNpcHandInHandPerform(builder, _o.Type, initiatorOffset, _o.Follower);
		}

		// Token: 0x04012A54 RID: 76372
		private Table __p;
	}
}

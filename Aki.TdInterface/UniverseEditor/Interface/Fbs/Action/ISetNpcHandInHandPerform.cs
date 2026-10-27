using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007037 RID: 28727
	public struct ISetNpcHandInHandPerform : IFlatbufferObject
	{
		// Token: 0x1700D54D RID: 54605
		// (get) Token: 0x06032D16 RID: 208150 RVA: 0x006DADA2 File Offset: 0x006D8FA2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032D17 RID: 208151 RVA: 0x006DADAF File Offset: 0x006D8FAF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032D18 RID: 208152 RVA: 0x006DADB8 File Offset: 0x006D8FB8
		public static ISetNpcHandInHandPerform GetRootAsISetNpcHandInHandPerform(ByteBuffer _bb)
		{
			return ISetNpcHandInHandPerform.GetRootAsISetNpcHandInHandPerform(_bb, default(ISetNpcHandInHandPerform));
		}

		// Token: 0x06032D19 RID: 208153 RVA: 0x006DADD4 File Offset: 0x006D8FD4
		public static ISetNpcHandInHandPerform GetRootAsISetNpcHandInHandPerform(ByteBuffer _bb, ISetNpcHandInHandPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032D1A RID: 208154 RVA: 0x006DADF1 File Offset: 0x006D8FF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032D1B RID: 208155 RVA: 0x006DAE00 File Offset: 0x006D9000
		public ISetNpcHandInHandPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D54E RID: 54606
		// (get) Token: 0x06032D1C RID: 208156 RVA: 0x006DAE10 File Offset: 0x006D9010
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

		// Token: 0x1700D54F RID: 54607
		// (get) Token: 0x06032D1D RID: 208157 RVA: 0x006DAE4C File Offset: 0x006D904C
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

		// Token: 0x1700D550 RID: 54608
		// (get) Token: 0x06032D1E RID: 208158 RVA: 0x006DAEAC File Offset: 0x006D90AC
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

		// Token: 0x06032D1F RID: 208159 RVA: 0x006DAEE8 File Offset: 0x006D90E8
		public static Offset<ISetNpcHandInHandPerform> CreateISetNpcHandInHandPerform(FlatBufferBuilder builder, ENpcGroupPerformType Type = ENpcGroupPerformType.HandInHand, Offset<IHandInHandInitiator> InitiatorOffset = default(Offset<IHandInHandInitiator>), int Follower = 0)
		{
			builder.StartTable(3);
			ISetNpcHandInHandPerform.AddFollower(builder, Follower);
			ISetNpcHandInHandPerform.AddInitiator(builder, InitiatorOffset);
			ISetNpcHandInHandPerform.AddType(builder, Type);
			return ISetNpcHandInHandPerform.EndISetNpcHandInHandPerform(builder);
		}

		// Token: 0x06032D20 RID: 208160 RVA: 0x006DAF0C File Offset: 0x006D910C
		public static void StartISetNpcHandInHandPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06032D21 RID: 208161 RVA: 0x006DAF15 File Offset: 0x006D9115
		public static void AddType(FlatBufferBuilder builder, ENpcGroupPerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032D22 RID: 208162 RVA: 0x006DAF20 File Offset: 0x006D9120
		public static void AddInitiator(FlatBufferBuilder builder, Offset<IHandInHandInitiator> initiatorOffset)
		{
			builder.AddOffset(1, initiatorOffset.Value, 0);
		}

		// Token: 0x06032D23 RID: 208163 RVA: 0x006DAF30 File Offset: 0x006D9130
		public static void AddFollower(FlatBufferBuilder builder, int follower)
		{
			builder.AddInt(2, follower, 0);
		}

		// Token: 0x06032D24 RID: 208164 RVA: 0x006DAF3B File Offset: 0x006D913B
		public static Offset<ISetNpcHandInHandPerform> EndISetNpcHandInHandPerform(FlatBufferBuilder builder)
		{
			return new Offset<ISetNpcHandInHandPerform>(builder.EndTable());
		}

		// Token: 0x06032D25 RID: 208165 RVA: 0x006DAF48 File Offset: 0x006D9148
		public ISetNpcHandInHandPerformT UnPack()
		{
			ISetNpcHandInHandPerformT setNpcHandInHandPerformT = new ISetNpcHandInHandPerformT();
			this.UnPackTo(setNpcHandInHandPerformT);
			return setNpcHandInHandPerformT;
		}

		// Token: 0x06032D26 RID: 208166 RVA: 0x006DAF64 File Offset: 0x006D9164
		public void UnPackTo(ISetNpcHandInHandPerformT _o)
		{
			_o.Type = this.Type;
			_o.Initiator = ((this.Initiator != null) ? this.Initiator.Value.UnPack() : null);
			_o.Follower = this.Follower;
		}

		// Token: 0x06032D27 RID: 208167 RVA: 0x006DAFB8 File Offset: 0x006D91B8
		public static Offset<ISetNpcHandInHandPerform> Pack(FlatBufferBuilder builder, ISetNpcHandInHandPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetNpcHandInHandPerform>);
			}
			Offset<IHandInHandInitiator> initiatorOffset = (_o.Initiator == null) ? default(Offset<IHandInHandInitiator>) : IHandInHandInitiator.Pack(builder, _o.Initiator);
			return ISetNpcHandInHandPerform.CreateISetNpcHandInHandPerform(builder, _o.Type, initiatorOffset, _o.Follower);
		}

		// Token: 0x04011A6E RID: 72302
		private Table __p;
	}
}

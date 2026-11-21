using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200515D RID: 20829
	public struct IOnlinePlayerConditionTargetParticipator : IFlatbufferObject
	{
		// Token: 0x17009539 RID: 38201
		// (get) Token: 0x06020C3B RID: 134203 RVA: 0x004899E1 File Offset: 0x00487BE1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020C3C RID: 134204 RVA: 0x004899EE File Offset: 0x00487BEE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020C3D RID: 134205 RVA: 0x004899F8 File Offset: 0x00487BF8
		public static IOnlinePlayerConditionTargetParticipator GetRootAsIOnlinePlayerConditionTargetParticipator(ByteBuffer _bb)
		{
			return IOnlinePlayerConditionTargetParticipator.GetRootAsIOnlinePlayerConditionTargetParticipator(_bb, default(IOnlinePlayerConditionTargetParticipator));
		}

		// Token: 0x06020C3E RID: 134206 RVA: 0x00489A14 File Offset: 0x00487C14
		public static IOnlinePlayerConditionTargetParticipator GetRootAsIOnlinePlayerConditionTargetParticipator(ByteBuffer _bb, IOnlinePlayerConditionTargetParticipator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020C3F RID: 134207 RVA: 0x00489A31 File Offset: 0x00487C31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020C40 RID: 134208 RVA: 0x00489A40 File Offset: 0x00487C40
		public IOnlinePlayerConditionTargetParticipator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700953A RID: 38202
		// (get) Token: 0x06020C41 RID: 134209 RVA: 0x00489A50 File Offset: 0x00487C50
		public EOnlinePlayerConditionTarget Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EOnlinePlayerConditionTarget.Host;
				}
				return (EOnlinePlayerConditionTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700953B RID: 38203
		// (get) Token: 0x06020C42 RID: 134210 RVA: 0x00489A8C File Offset: 0x00487C8C
		public bool AnyPlayer
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06020C43 RID: 134211 RVA: 0x00489ACB File Offset: 0x00487CCB
		public static Offset<IOnlinePlayerConditionTargetParticipator> CreateIOnlinePlayerConditionTargetParticipator(FlatBufferBuilder builder, EOnlinePlayerConditionTarget Type = EOnlinePlayerConditionTarget.Host, bool AnyPlayer = false)
		{
			builder.StartTable(2);
			IOnlinePlayerConditionTargetParticipator.AddAnyPlayer(builder, AnyPlayer);
			IOnlinePlayerConditionTargetParticipator.AddType(builder, Type);
			return IOnlinePlayerConditionTargetParticipator.EndIOnlinePlayerConditionTargetParticipator(builder);
		}

		// Token: 0x06020C44 RID: 134212 RVA: 0x00489AE8 File Offset: 0x00487CE8
		public static void StartIOnlinePlayerConditionTargetParticipator(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020C45 RID: 134213 RVA: 0x00489AF1 File Offset: 0x00487CF1
		public static void AddType(FlatBufferBuilder builder, EOnlinePlayerConditionTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020C46 RID: 134214 RVA: 0x00489AFC File Offset: 0x00487CFC
		public static void AddAnyPlayer(FlatBufferBuilder builder, bool anyPlayer)
		{
			builder.AddBool(1, anyPlayer, false);
		}

		// Token: 0x06020C47 RID: 134215 RVA: 0x00489B07 File Offset: 0x00487D07
		public static Offset<IOnlinePlayerConditionTargetParticipator> EndIOnlinePlayerConditionTargetParticipator(FlatBufferBuilder builder)
		{
			return new Offset<IOnlinePlayerConditionTargetParticipator>(builder.EndTable());
		}

		// Token: 0x06020C48 RID: 134216 RVA: 0x00489B14 File Offset: 0x00487D14
		public IOnlinePlayerConditionTargetParticipatorT UnPack()
		{
			IOnlinePlayerConditionTargetParticipatorT onlinePlayerConditionTargetParticipatorT = new IOnlinePlayerConditionTargetParticipatorT();
			this.UnPackTo(onlinePlayerConditionTargetParticipatorT);
			return onlinePlayerConditionTargetParticipatorT;
		}

		// Token: 0x06020C49 RID: 134217 RVA: 0x00489B2F File Offset: 0x00487D2F
		public void UnPackTo(IOnlinePlayerConditionTargetParticipatorT _o)
		{
			_o.Type = this.Type;
			_o.AnyPlayer = this.AnyPlayer;
		}

		// Token: 0x06020C4A RID: 134218 RVA: 0x00489B4C File Offset: 0x00487D4C
		public static Offset<IOnlinePlayerConditionTargetParticipator> Pack(FlatBufferBuilder builder, IOnlinePlayerConditionTargetParticipatorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOnlinePlayerConditionTargetParticipator>);
			}
			return IOnlinePlayerConditionTargetParticipator.CreateIOnlinePlayerConditionTargetParticipator(builder, _o.Type, _o.AnyPlayer);
		}

		// Token: 0x0400E136 RID: 57654
		private Table __p;
	}
}

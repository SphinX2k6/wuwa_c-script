using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C64 RID: 19556
	public struct IOnlinePlayerConditionTargetParticipator : IFlatbufferObject
	{
		// Token: 0x17008E0B RID: 36363
		// (get) Token: 0x0601F019 RID: 127001 RVA: 0x00455E91 File Offset: 0x00454091
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F01A RID: 127002 RVA: 0x00455E9E File Offset: 0x0045409E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F01B RID: 127003 RVA: 0x00455EA8 File Offset: 0x004540A8
		public static IOnlinePlayerConditionTargetParticipator GetRootAsIOnlinePlayerConditionTargetParticipator(ByteBuffer _bb)
		{
			return IOnlinePlayerConditionTargetParticipator.GetRootAsIOnlinePlayerConditionTargetParticipator(_bb, default(IOnlinePlayerConditionTargetParticipator));
		}

		// Token: 0x0601F01C RID: 127004 RVA: 0x00455EC4 File Offset: 0x004540C4
		public static IOnlinePlayerConditionTargetParticipator GetRootAsIOnlinePlayerConditionTargetParticipator(ByteBuffer _bb, IOnlinePlayerConditionTargetParticipator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F01D RID: 127005 RVA: 0x00455EE1 File Offset: 0x004540E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F01E RID: 127006 RVA: 0x00455EF0 File Offset: 0x004540F0
		public IOnlinePlayerConditionTargetParticipator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E0C RID: 36364
		// (get) Token: 0x0601F01F RID: 127007 RVA: 0x00455F00 File Offset: 0x00454100
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

		// Token: 0x17008E0D RID: 36365
		// (get) Token: 0x0601F020 RID: 127008 RVA: 0x00455F3C File Offset: 0x0045413C
		public bool AnyPlayer
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601F021 RID: 127009 RVA: 0x00455F7B File Offset: 0x0045417B
		public static Offset<IOnlinePlayerConditionTargetParticipator> CreateIOnlinePlayerConditionTargetParticipator(FlatBufferBuilder builder, EOnlinePlayerConditionTarget Type = EOnlinePlayerConditionTarget.Host, bool AnyPlayer = false)
		{
			builder.StartTable(2);
			IOnlinePlayerConditionTargetParticipator.AddAnyPlayer(builder, AnyPlayer);
			IOnlinePlayerConditionTargetParticipator.AddType(builder, Type);
			return IOnlinePlayerConditionTargetParticipator.EndIOnlinePlayerConditionTargetParticipator(builder);
		}

		// Token: 0x0601F022 RID: 127010 RVA: 0x00455F98 File Offset: 0x00454198
		public static void StartIOnlinePlayerConditionTargetParticipator(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F023 RID: 127011 RVA: 0x00455FA1 File Offset: 0x004541A1
		public static void AddType(FlatBufferBuilder builder, EOnlinePlayerConditionTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F024 RID: 127012 RVA: 0x00455FAC File Offset: 0x004541AC
		public static void AddAnyPlayer(FlatBufferBuilder builder, bool anyPlayer)
		{
			builder.AddBool(1, anyPlayer, false);
		}

		// Token: 0x0601F025 RID: 127013 RVA: 0x00455FB7 File Offset: 0x004541B7
		public static Offset<IOnlinePlayerConditionTargetParticipator> EndIOnlinePlayerConditionTargetParticipator(FlatBufferBuilder builder)
		{
			return new Offset<IOnlinePlayerConditionTargetParticipator>(builder.EndTable());
		}

		// Token: 0x0601F026 RID: 127014 RVA: 0x00455FC4 File Offset: 0x004541C4
		public IOnlinePlayerConditionTargetParticipatorT UnPack()
		{
			IOnlinePlayerConditionTargetParticipatorT onlinePlayerConditionTargetParticipatorT = new IOnlinePlayerConditionTargetParticipatorT();
			this.UnPackTo(onlinePlayerConditionTargetParticipatorT);
			return onlinePlayerConditionTargetParticipatorT;
		}

		// Token: 0x0601F027 RID: 127015 RVA: 0x00455FDF File Offset: 0x004541DF
		public void UnPackTo(IOnlinePlayerConditionTargetParticipatorT _o)
		{
			_o.Type = this.Type;
			_o.AnyPlayer = this.AnyPlayer;
		}

		// Token: 0x0601F028 RID: 127016 RVA: 0x00455FFC File Offset: 0x004541FC
		public static Offset<IOnlinePlayerConditionTargetParticipator> Pack(FlatBufferBuilder builder, IOnlinePlayerConditionTargetParticipatorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOnlinePlayerConditionTargetParticipator>);
			}
			return IOnlinePlayerConditionTargetParticipator.CreateIOnlinePlayerConditionTargetParticipator(builder, _o.Type, _o.AnyPlayer);
		}

		// Token: 0x0400D60F RID: 54799
		private Table __p;
	}
}

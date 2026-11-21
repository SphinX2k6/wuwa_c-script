using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A3B RID: 27195
	public struct IClientFollowShooterLeisureInteractType : IFlatbufferObject
	{
		// Token: 0x1700C7D7 RID: 51159
		// (get) Token: 0x0602EA5C RID: 191068 RVA: 0x0065C148 File Offset: 0x0065A348
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EA5D RID: 191069 RVA: 0x0065C155 File Offset: 0x0065A355
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EA5E RID: 191070 RVA: 0x0065C15C File Offset: 0x0065A35C
		public static IClientFollowShooterLeisureInteractType GetRootAsIClientFollowShooterLeisureInteractType(ByteBuffer _bb)
		{
			return IClientFollowShooterLeisureInteractType.GetRootAsIClientFollowShooterLeisureInteractType(_bb, default(IClientFollowShooterLeisureInteractType));
		}

		// Token: 0x0602EA5F RID: 191071 RVA: 0x0065C178 File Offset: 0x0065A378
		public static IClientFollowShooterLeisureInteractType GetRootAsIClientFollowShooterLeisureInteractType(ByteBuffer _bb, IClientFollowShooterLeisureInteractType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EA60 RID: 191072 RVA: 0x0065C195 File Offset: 0x0065A395
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EA61 RID: 191073 RVA: 0x0065C1A4 File Offset: 0x0065A3A4
		public IClientFollowShooterLeisureInteractType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7D8 RID: 51160
		// (get) Token: 0x0602EA62 RID: 191074 RVA: 0x0065C1B4 File Offset: 0x0065A3B4
		public EClientFollowShooterLeisureInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientFollowShooterLeisureInteractType.PlayAnimation;
				}
				return (EClientFollowShooterLeisureInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EA63 RID: 191075 RVA: 0x0065C1F0 File Offset: 0x0065A3F0
		public static Offset<IClientFollowShooterLeisureInteractType> CreateIClientFollowShooterLeisureInteractType(FlatBufferBuilder builder, EClientFollowShooterLeisureInteractType Type = EClientFollowShooterLeisureInteractType.PlayAnimation)
		{
			builder.StartTable(1);
			IClientFollowShooterLeisureInteractType.AddType(builder, Type);
			return IClientFollowShooterLeisureInteractType.EndIClientFollowShooterLeisureInteractType(builder);
		}

		// Token: 0x0602EA64 RID: 191076 RVA: 0x0065C206 File Offset: 0x0065A406
		public static void StartIClientFollowShooterLeisureInteractType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602EA65 RID: 191077 RVA: 0x0065C20F File Offset: 0x0065A40F
		public static void AddType(FlatBufferBuilder builder, EClientFollowShooterLeisureInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EA66 RID: 191078 RVA: 0x0065C21A File Offset: 0x0065A41A
		public static Offset<IClientFollowShooterLeisureInteractType> EndIClientFollowShooterLeisureInteractType(FlatBufferBuilder builder)
		{
			return new Offset<IClientFollowShooterLeisureInteractType>(builder.EndTable());
		}

		// Token: 0x0602EA67 RID: 191079 RVA: 0x0065C228 File Offset: 0x0065A428
		public IClientFollowShooterLeisureInteractTypeT UnPack()
		{
			IClientFollowShooterLeisureInteractTypeT clientFollowShooterLeisureInteractTypeT = new IClientFollowShooterLeisureInteractTypeT();
			this.UnPackTo(clientFollowShooterLeisureInteractTypeT);
			return clientFollowShooterLeisureInteractTypeT;
		}

		// Token: 0x0602EA68 RID: 191080 RVA: 0x0065C243 File Offset: 0x0065A443
		public void UnPackTo(IClientFollowShooterLeisureInteractTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602EA69 RID: 191081 RVA: 0x0065C254 File Offset: 0x0065A454
		public static Offset<IClientFollowShooterLeisureInteractType> Pack(FlatBufferBuilder builder, IClientFollowShooterLeisureInteractTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientFollowShooterLeisureInteractType>);
			}
			return IClientFollowShooterLeisureInteractType.CreateIClientFollowShooterLeisureInteractType(builder, _o.Type);
		}

		// Token: 0x040117B8 RID: 71608
		private Table __p;
	}
}

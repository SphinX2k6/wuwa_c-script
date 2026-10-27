using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063C1 RID: 25537
	public struct IClientFollowShooterLeisureInteractType : IFlatbufferObject
	{
		// Token: 0x1700BE4B RID: 48715
		// (get) Token: 0x0602C2C9 RID: 180937 RVA: 0x00610C40 File Offset: 0x0060EE40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C2CA RID: 180938 RVA: 0x00610C4D File Offset: 0x0060EE4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C2CB RID: 180939 RVA: 0x00610C54 File Offset: 0x0060EE54
		public static IClientFollowShooterLeisureInteractType GetRootAsIClientFollowShooterLeisureInteractType(ByteBuffer _bb)
		{
			return IClientFollowShooterLeisureInteractType.GetRootAsIClientFollowShooterLeisureInteractType(_bb, default(IClientFollowShooterLeisureInteractType));
		}

		// Token: 0x0602C2CC RID: 180940 RVA: 0x00610C70 File Offset: 0x0060EE70
		public static IClientFollowShooterLeisureInteractType GetRootAsIClientFollowShooterLeisureInteractType(ByteBuffer _bb, IClientFollowShooterLeisureInteractType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C2CD RID: 180941 RVA: 0x00610C8D File Offset: 0x0060EE8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C2CE RID: 180942 RVA: 0x00610C9C File Offset: 0x0060EE9C
		public IClientFollowShooterLeisureInteractType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE4C RID: 48716
		// (get) Token: 0x0602C2CF RID: 180943 RVA: 0x00610CAC File Offset: 0x0060EEAC
		public EClientFollowShooterLeisureInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientFollowShooterLeisureInteractType.ResetToPlayer;
				}
				return (EClientFollowShooterLeisureInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C2D0 RID: 180944 RVA: 0x00610CE8 File Offset: 0x0060EEE8
		public static Offset<IClientFollowShooterLeisureInteractType> CreateIClientFollowShooterLeisureInteractType(FlatBufferBuilder builder, EClientFollowShooterLeisureInteractType Type = EClientFollowShooterLeisureInteractType.ResetToPlayer)
		{
			builder.StartTable(1);
			IClientFollowShooterLeisureInteractType.AddType(builder, Type);
			return IClientFollowShooterLeisureInteractType.EndIClientFollowShooterLeisureInteractType(builder);
		}

		// Token: 0x0602C2D1 RID: 180945 RVA: 0x00610CFE File Offset: 0x0060EEFE
		public static void StartIClientFollowShooterLeisureInteractType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C2D2 RID: 180946 RVA: 0x00610D07 File Offset: 0x0060EF07
		public static void AddType(FlatBufferBuilder builder, EClientFollowShooterLeisureInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C2D3 RID: 180947 RVA: 0x00610D12 File Offset: 0x0060EF12
		public static Offset<IClientFollowShooterLeisureInteractType> EndIClientFollowShooterLeisureInteractType(FlatBufferBuilder builder)
		{
			return new Offset<IClientFollowShooterLeisureInteractType>(builder.EndTable());
		}

		// Token: 0x0602C2D4 RID: 180948 RVA: 0x00610D20 File Offset: 0x0060EF20
		public IClientFollowShooterLeisureInteractTypeT UnPack()
		{
			IClientFollowShooterLeisureInteractTypeT clientFollowShooterLeisureInteractTypeT = new IClientFollowShooterLeisureInteractTypeT();
			this.UnPackTo(clientFollowShooterLeisureInteractTypeT);
			return clientFollowShooterLeisureInteractTypeT;
		}

		// Token: 0x0602C2D5 RID: 180949 RVA: 0x00610D3B File Offset: 0x0060EF3B
		public void UnPackTo(IClientFollowShooterLeisureInteractTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602C2D6 RID: 180950 RVA: 0x00610D4C File Offset: 0x0060EF4C
		public static Offset<IClientFollowShooterLeisureInteractType> Pack(FlatBufferBuilder builder, IClientFollowShooterLeisureInteractTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientFollowShooterLeisureInteractType>);
			}
			return IClientFollowShooterLeisureInteractType.CreateIClientFollowShooterLeisureInteractType(builder, _o.Type);
		}

		// Token: 0x0401099B RID: 67995
		private Table __p;
	}
}

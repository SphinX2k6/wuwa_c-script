using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200610C RID: 24844
	public struct ITurntableControlType : IFlatbufferObject
	{
		// Token: 0x1700B8F4 RID: 47348
		// (get) Token: 0x0602A1CE RID: 172494 RVA: 0x005BF7F0 File Offset: 0x005BD9F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A1CF RID: 172495 RVA: 0x005BF7FD File Offset: 0x005BD9FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A1D0 RID: 172496 RVA: 0x005BF804 File Offset: 0x005BDA04
		public static ITurntableControlType GetRootAsITurntableControlType(ByteBuffer _bb)
		{
			return ITurntableControlType.GetRootAsITurntableControlType(_bb, default(ITurntableControlType));
		}

		// Token: 0x0602A1D1 RID: 172497 RVA: 0x005BF820 File Offset: 0x005BDA20
		public static ITurntableControlType GetRootAsITurntableControlType(ByteBuffer _bb, ITurntableControlType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A1D2 RID: 172498 RVA: 0x005BF83D File Offset: 0x005BDA3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A1D3 RID: 172499 RVA: 0x005BF84C File Offset: 0x005BDA4C
		public ITurntableControlType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B8F5 RID: 47349
		// (get) Token: 0x0602A1D4 RID: 172500 RVA: 0x005BF85C File Offset: 0x005BDA5C
		public EControllerType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EControllerType.FreeAngle;
				}
				return (EControllerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B8F6 RID: 47350
		// (get) Token: 0x0602A1D5 RID: 172501 RVA: 0x005BF898 File Offset: 0x005BDA98
		public int RotationSpeed
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

		// Token: 0x0602A1D6 RID: 172502 RVA: 0x005BF8D4 File Offset: 0x005BDAD4
		public static Offset<ITurntableControlType> CreateITurntableControlType(FlatBufferBuilder builder, EControllerType Type = EControllerType.FreeAngle, int RotationSpeed = 0)
		{
			builder.StartTable(2);
			ITurntableControlType.AddRotationSpeed(builder, RotationSpeed);
			ITurntableControlType.AddType(builder, Type);
			return ITurntableControlType.EndITurntableControlType(builder);
		}

		// Token: 0x0602A1D7 RID: 172503 RVA: 0x005BF8F1 File Offset: 0x005BDAF1
		public static void StartITurntableControlType(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602A1D8 RID: 172504 RVA: 0x005BF8FA File Offset: 0x005BDAFA
		public static void AddType(FlatBufferBuilder builder, EControllerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A1D9 RID: 172505 RVA: 0x005BF905 File Offset: 0x005BDB05
		public static void AddRotationSpeed(FlatBufferBuilder builder, int rotationSpeed)
		{
			builder.AddInt(1, rotationSpeed, 0);
		}

		// Token: 0x0602A1DA RID: 172506 RVA: 0x005BF910 File Offset: 0x005BDB10
		public static Offset<ITurntableControlType> EndITurntableControlType(FlatBufferBuilder builder)
		{
			return new Offset<ITurntableControlType>(builder.EndTable());
		}

		// Token: 0x0602A1DB RID: 172507 RVA: 0x005BF920 File Offset: 0x005BDB20
		public ITurntableControlTypeT UnPack()
		{
			ITurntableControlTypeT turntableControlTypeT = new ITurntableControlTypeT();
			this.UnPackTo(turntableControlTypeT);
			return turntableControlTypeT;
		}

		// Token: 0x0602A1DC RID: 172508 RVA: 0x005BF93B File Offset: 0x005BDB3B
		public void UnPackTo(ITurntableControlTypeT _o)
		{
			_o.Type = this.Type;
			_o.RotationSpeed = this.RotationSpeed;
		}

		// Token: 0x0602A1DD RID: 172509 RVA: 0x005BF958 File Offset: 0x005BDB58
		public static Offset<ITurntableControlType> Pack(FlatBufferBuilder builder, ITurntableControlTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITurntableControlType>);
			}
			return ITurntableControlType.CreateITurntableControlType(builder, _o.Type, _o.RotationSpeed);
		}

		// Token: 0x0400FEF7 RID: 65271
		private Table __p;
	}
}

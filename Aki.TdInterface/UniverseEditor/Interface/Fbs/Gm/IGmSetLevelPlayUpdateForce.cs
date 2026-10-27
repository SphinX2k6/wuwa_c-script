using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200466C RID: 18028
	public struct IGmSetLevelPlayUpdateForce : IFlatbufferObject
	{
		// Token: 0x17007FFF RID: 32767
		// (get) Token: 0x0601B5C1 RID: 112065 RVA: 0x003E3D2C File Offset: 0x003E1F2C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B5C2 RID: 112066 RVA: 0x003E3D39 File Offset: 0x003E1F39
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B5C3 RID: 112067 RVA: 0x003E3D40 File Offset: 0x003E1F40
		public static IGmSetLevelPlayUpdateForce GetRootAsIGmSetLevelPlayUpdateForce(ByteBuffer _bb)
		{
			return IGmSetLevelPlayUpdateForce.GetRootAsIGmSetLevelPlayUpdateForce(_bb, default(IGmSetLevelPlayUpdateForce));
		}

		// Token: 0x0601B5C4 RID: 112068 RVA: 0x003E3D5C File Offset: 0x003E1F5C
		public static IGmSetLevelPlayUpdateForce GetRootAsIGmSetLevelPlayUpdateForce(ByteBuffer _bb, IGmSetLevelPlayUpdateForce obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B5C5 RID: 112069 RVA: 0x003E3D79 File Offset: 0x003E1F79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B5C6 RID: 112070 RVA: 0x003E3D88 File Offset: 0x003E1F88
		public IGmSetLevelPlayUpdateForce __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008000 RID: 32768
		// (get) Token: 0x0601B5C7 RID: 112071 RVA: 0x003E3D98 File Offset: 0x003E1F98
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008001 RID: 32769
		// (get) Token: 0x0601B5C8 RID: 112072 RVA: 0x003E3DD4 File Offset: 0x003E1FD4
		public int LevelPlayId
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

		// Token: 0x17008002 RID: 32770
		// (get) Token: 0x0601B5C9 RID: 112073 RVA: 0x003E3E10 File Offset: 0x003E2010
		public bool IsTeleport
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601B5CA RID: 112074 RVA: 0x003E3E4F File Offset: 0x003E204F
		public static Offset<IGmSetLevelPlayUpdateForce> CreateIGmSetLevelPlayUpdateForce(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int LevelPlayId = 0, bool IsTeleport = false)
		{
			builder.StartTable(3);
			IGmSetLevelPlayUpdateForce.AddLevelPlayId(builder, LevelPlayId);
			IGmSetLevelPlayUpdateForce.AddIsTeleport(builder, IsTeleport);
			IGmSetLevelPlayUpdateForce.AddType(builder, Type);
			return IGmSetLevelPlayUpdateForce.EndIGmSetLevelPlayUpdateForce(builder);
		}

		// Token: 0x0601B5CB RID: 112075 RVA: 0x003E3E73 File Offset: 0x003E2073
		public static void StartIGmSetLevelPlayUpdateForce(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601B5CC RID: 112076 RVA: 0x003E3E7C File Offset: 0x003E207C
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B5CD RID: 112077 RVA: 0x003E3E87 File Offset: 0x003E2087
		public static void AddLevelPlayId(FlatBufferBuilder builder, int levelPlayId)
		{
			builder.AddInt(1, levelPlayId, 0);
		}

		// Token: 0x0601B5CE RID: 112078 RVA: 0x003E3E92 File Offset: 0x003E2092
		public static void AddIsTeleport(FlatBufferBuilder builder, bool isTeleport)
		{
			builder.AddBool(2, isTeleport, false);
		}

		// Token: 0x0601B5CF RID: 112079 RVA: 0x003E3E9D File Offset: 0x003E209D
		public static Offset<IGmSetLevelPlayUpdateForce> EndIGmSetLevelPlayUpdateForce(FlatBufferBuilder builder)
		{
			return new Offset<IGmSetLevelPlayUpdateForce>(builder.EndTable());
		}

		// Token: 0x0601B5D0 RID: 112080 RVA: 0x003E3EAC File Offset: 0x003E20AC
		public IGmSetLevelPlayUpdateForceT UnPack()
		{
			IGmSetLevelPlayUpdateForceT gmSetLevelPlayUpdateForceT = new IGmSetLevelPlayUpdateForceT();
			this.UnPackTo(gmSetLevelPlayUpdateForceT);
			return gmSetLevelPlayUpdateForceT;
		}

		// Token: 0x0601B5D1 RID: 112081 RVA: 0x003E3EC7 File Offset: 0x003E20C7
		public void UnPackTo(IGmSetLevelPlayUpdateForceT _o)
		{
			_o.Type = this.Type;
			_o.LevelPlayId = this.LevelPlayId;
			_o.IsTeleport = this.IsTeleport;
		}

		// Token: 0x0601B5D2 RID: 112082 RVA: 0x003E3EF0 File Offset: 0x003E20F0
		public static Offset<IGmSetLevelPlayUpdateForce> Pack(FlatBufferBuilder builder, IGmSetLevelPlayUpdateForceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGmSetLevelPlayUpdateForce>);
			}
			return IGmSetLevelPlayUpdateForce.CreateIGmSetLevelPlayUpdateForce(builder, _o.Type, _o.LevelPlayId, _o.IsTeleport);
		}

		// Token: 0x0400C82B RID: 51243
		private Table __p;
	}
}

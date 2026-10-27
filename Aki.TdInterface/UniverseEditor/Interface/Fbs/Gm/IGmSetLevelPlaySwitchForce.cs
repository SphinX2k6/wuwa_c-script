using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004669 RID: 18025
	public struct IGmSetLevelPlaySwitchForce : IFlatbufferObject
	{
		// Token: 0x17007FF8 RID: 32760
		// (get) Token: 0x0601B5A7 RID: 112039 RVA: 0x003E3A98 File Offset: 0x003E1C98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B5A8 RID: 112040 RVA: 0x003E3AA5 File Offset: 0x003E1CA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B5A9 RID: 112041 RVA: 0x003E3AAC File Offset: 0x003E1CAC
		public static IGmSetLevelPlaySwitchForce GetRootAsIGmSetLevelPlaySwitchForce(ByteBuffer _bb)
		{
			return IGmSetLevelPlaySwitchForce.GetRootAsIGmSetLevelPlaySwitchForce(_bb, default(IGmSetLevelPlaySwitchForce));
		}

		// Token: 0x0601B5AA RID: 112042 RVA: 0x003E3AC8 File Offset: 0x003E1CC8
		public static IGmSetLevelPlaySwitchForce GetRootAsIGmSetLevelPlaySwitchForce(ByteBuffer _bb, IGmSetLevelPlaySwitchForce obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B5AB RID: 112043 RVA: 0x003E3AE5 File Offset: 0x003E1CE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B5AC RID: 112044 RVA: 0x003E3AF4 File Offset: 0x003E1CF4
		public IGmSetLevelPlaySwitchForce __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007FF9 RID: 32761
		// (get) Token: 0x0601B5AD RID: 112045 RVA: 0x003E3B04 File Offset: 0x003E1D04
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

		// Token: 0x17007FFA RID: 32762
		// (get) Token: 0x0601B5AE RID: 112046 RVA: 0x003E3B40 File Offset: 0x003E1D40
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

		// Token: 0x17007FFB RID: 32763
		// (get) Token: 0x0601B5AF RID: 112047 RVA: 0x003E3B7C File Offset: 0x003E1D7C
		public bool IsOpen
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601B5B0 RID: 112048 RVA: 0x003E3BBB File Offset: 0x003E1DBB
		public static Offset<IGmSetLevelPlaySwitchForce> CreateIGmSetLevelPlaySwitchForce(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int LevelPlayId = 0, bool IsOpen = false)
		{
			builder.StartTable(3);
			IGmSetLevelPlaySwitchForce.AddLevelPlayId(builder, LevelPlayId);
			IGmSetLevelPlaySwitchForce.AddIsOpen(builder, IsOpen);
			IGmSetLevelPlaySwitchForce.AddType(builder, Type);
			return IGmSetLevelPlaySwitchForce.EndIGmSetLevelPlaySwitchForce(builder);
		}

		// Token: 0x0601B5B1 RID: 112049 RVA: 0x003E3BDF File Offset: 0x003E1DDF
		public static void StartIGmSetLevelPlaySwitchForce(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601B5B2 RID: 112050 RVA: 0x003E3BE8 File Offset: 0x003E1DE8
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B5B3 RID: 112051 RVA: 0x003E3BF3 File Offset: 0x003E1DF3
		public static void AddLevelPlayId(FlatBufferBuilder builder, int levelPlayId)
		{
			builder.AddInt(1, levelPlayId, 0);
		}

		// Token: 0x0601B5B4 RID: 112052 RVA: 0x003E3BFE File Offset: 0x003E1DFE
		public static void AddIsOpen(FlatBufferBuilder builder, bool isOpen)
		{
			builder.AddBool(2, isOpen, false);
		}

		// Token: 0x0601B5B5 RID: 112053 RVA: 0x003E3C09 File Offset: 0x003E1E09
		public static Offset<IGmSetLevelPlaySwitchForce> EndIGmSetLevelPlaySwitchForce(FlatBufferBuilder builder)
		{
			return new Offset<IGmSetLevelPlaySwitchForce>(builder.EndTable());
		}

		// Token: 0x0601B5B6 RID: 112054 RVA: 0x003E3C18 File Offset: 0x003E1E18
		public IGmSetLevelPlaySwitchForceT UnPack()
		{
			IGmSetLevelPlaySwitchForceT gmSetLevelPlaySwitchForceT = new IGmSetLevelPlaySwitchForceT();
			this.UnPackTo(gmSetLevelPlaySwitchForceT);
			return gmSetLevelPlaySwitchForceT;
		}

		// Token: 0x0601B5B7 RID: 112055 RVA: 0x003E3C33 File Offset: 0x003E1E33
		public void UnPackTo(IGmSetLevelPlaySwitchForceT _o)
		{
			_o.Type = this.Type;
			_o.LevelPlayId = this.LevelPlayId;
			_o.IsOpen = this.IsOpen;
		}

		// Token: 0x0601B5B8 RID: 112056 RVA: 0x003E3C5C File Offset: 0x003E1E5C
		public static Offset<IGmSetLevelPlaySwitchForce> Pack(FlatBufferBuilder builder, IGmSetLevelPlaySwitchForceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGmSetLevelPlaySwitchForce>);
			}
			return IGmSetLevelPlaySwitchForce.CreateIGmSetLevelPlaySwitchForce(builder, _o.Type, _o.LevelPlayId, _o.IsOpen);
		}

		// Token: 0x0400C827 RID: 51239
		private Table __p;
	}
}

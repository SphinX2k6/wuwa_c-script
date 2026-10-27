using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200686D RID: 26733
	public struct IGamepadShakeConfig : IFlatbufferObject
	{
		// Token: 0x1700C695 RID: 50837
		// (get) Token: 0x0602E9F5 RID: 190965 RVA: 0x0065BCF0 File Offset: 0x00659EF0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E9F6 RID: 190966 RVA: 0x0065BCFD File Offset: 0x00659EFD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E9F7 RID: 190967 RVA: 0x0065BD04 File Offset: 0x00659F04
		public static IGamepadShakeConfig GetRootAsIGamepadShakeConfig(ByteBuffer _bb)
		{
			return IGamepadShakeConfig.GetRootAsIGamepadShakeConfig(_bb, default(IGamepadShakeConfig));
		}

		// Token: 0x0602E9F8 RID: 190968 RVA: 0x0065BD20 File Offset: 0x00659F20
		public static IGamepadShakeConfig GetRootAsIGamepadShakeConfig(ByteBuffer _bb, IGamepadShakeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E9F9 RID: 190969 RVA: 0x0065BD3D File Offset: 0x00659F3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E9FA RID: 190970 RVA: 0x0065BD4C File Offset: 0x00659F4C
		public IGamepadShakeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C696 RID: 50838
		// (get) Token: 0x0602E9FB RID: 190971 RVA: 0x0065BD5C File Offset: 0x00659F5C
		public EGamepadShakeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGamepadShakeType.Onetime;
				}
				return (EGamepadShakeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E9FC RID: 190972 RVA: 0x0065BD98 File Offset: 0x00659F98
		public static Offset<IGamepadShakeConfig> CreateIGamepadShakeConfig(FlatBufferBuilder builder, EGamepadShakeType Type = EGamepadShakeType.Onetime)
		{
			builder.StartTable(1);
			IGamepadShakeConfig.AddType(builder, Type);
			return IGamepadShakeConfig.EndIGamepadShakeConfig(builder);
		}

		// Token: 0x0602E9FD RID: 190973 RVA: 0x0065BDAE File Offset: 0x00659FAE
		public static void StartIGamepadShakeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E9FE RID: 190974 RVA: 0x0065BDB7 File Offset: 0x00659FB7
		public static void AddType(FlatBufferBuilder builder, EGamepadShakeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E9FF RID: 190975 RVA: 0x0065BDC2 File Offset: 0x00659FC2
		public static Offset<IGamepadShakeConfig> EndIGamepadShakeConfig(FlatBufferBuilder builder)
		{
			return new Offset<IGamepadShakeConfig>(builder.EndTable());
		}

		// Token: 0x0602EA00 RID: 190976 RVA: 0x0065BDD0 File Offset: 0x00659FD0
		public IGamepadShakeConfigT UnPack()
		{
			IGamepadShakeConfigT gamepadShakeConfigT = new IGamepadShakeConfigT();
			this.UnPackTo(gamepadShakeConfigT);
			return gamepadShakeConfigT;
		}

		// Token: 0x0602EA01 RID: 190977 RVA: 0x0065BDEB File Offset: 0x00659FEB
		public void UnPackTo(IGamepadShakeConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602EA02 RID: 190978 RVA: 0x0065BDFC File Offset: 0x00659FFC
		public static Offset<IGamepadShakeConfig> Pack(FlatBufferBuilder builder, IGamepadShakeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGamepadShakeConfig>);
			}
			return IGamepadShakeConfig.CreateIGamepadShakeConfig(builder, _o.Type);
		}

		// Token: 0x04010FBF RID: 69567
		private Table __p;
	}
}

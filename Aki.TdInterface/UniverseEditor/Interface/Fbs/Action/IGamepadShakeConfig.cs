using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F0E RID: 28430
	public struct IGamepadShakeConfig : IFlatbufferObject
	{
		// Token: 0x1700D07B RID: 53371
		// (get) Token: 0x0603132F RID: 201519 RVA: 0x006AAD70 File Offset: 0x006A8F70
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031330 RID: 201520 RVA: 0x006AAD7D File Offset: 0x006A8F7D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031331 RID: 201521 RVA: 0x006AAD84 File Offset: 0x006A8F84
		public static IGamepadShakeConfig GetRootAsIGamepadShakeConfig(ByteBuffer _bb)
		{
			return IGamepadShakeConfig.GetRootAsIGamepadShakeConfig(_bb, default(IGamepadShakeConfig));
		}

		// Token: 0x06031332 RID: 201522 RVA: 0x006AADA0 File Offset: 0x006A8FA0
		public static IGamepadShakeConfig GetRootAsIGamepadShakeConfig(ByteBuffer _bb, IGamepadShakeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031333 RID: 201523 RVA: 0x006AADBD File Offset: 0x006A8FBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031334 RID: 201524 RVA: 0x006AADCC File Offset: 0x006A8FCC
		public IGamepadShakeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D07C RID: 53372
		// (get) Token: 0x06031335 RID: 201525 RVA: 0x006AADDC File Offset: 0x006A8FDC
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

		// Token: 0x06031336 RID: 201526 RVA: 0x006AAE18 File Offset: 0x006A9018
		public static Offset<IGamepadShakeConfig> CreateIGamepadShakeConfig(FlatBufferBuilder builder, EGamepadShakeType Type = EGamepadShakeType.Onetime)
		{
			builder.StartTable(1);
			IGamepadShakeConfig.AddType(builder, Type);
			return IGamepadShakeConfig.EndIGamepadShakeConfig(builder);
		}

		// Token: 0x06031337 RID: 201527 RVA: 0x006AAE2E File Offset: 0x006A902E
		public static void StartIGamepadShakeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031338 RID: 201528 RVA: 0x006AAE37 File Offset: 0x006A9037
		public static void AddType(FlatBufferBuilder builder, EGamepadShakeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031339 RID: 201529 RVA: 0x006AAE42 File Offset: 0x006A9042
		public static Offset<IGamepadShakeConfig> EndIGamepadShakeConfig(FlatBufferBuilder builder)
		{
			return new Offset<IGamepadShakeConfig>(builder.EndTable());
		}

		// Token: 0x0603133A RID: 201530 RVA: 0x006AAE50 File Offset: 0x006A9050
		public IGamepadShakeConfigT UnPack()
		{
			IGamepadShakeConfigT gamepadShakeConfigT = new IGamepadShakeConfigT();
			this.UnPackTo(gamepadShakeConfigT);
			return gamepadShakeConfigT;
		}

		// Token: 0x0603133B RID: 201531 RVA: 0x006AAE6B File Offset: 0x006A906B
		public void UnPackTo(IGamepadShakeConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603133C RID: 201532 RVA: 0x006AAE7C File Offset: 0x006A907C
		public static Offset<IGamepadShakeConfig> Pack(FlatBufferBuilder builder, IGamepadShakeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGamepadShakeConfig>);
			}
			return IGamepadShakeConfig.CreateIGamepadShakeConfig(builder, _o.Type);
		}

		// Token: 0x04011E14 RID: 73236
		private Table __p;
	}
}

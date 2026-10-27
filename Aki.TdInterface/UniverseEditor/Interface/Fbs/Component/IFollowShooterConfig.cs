using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200529D RID: 21149
	public struct IFollowShooterConfig : IFlatbufferObject
	{
		// Token: 0x17009B1A RID: 39706
		// (get) Token: 0x060227A0 RID: 141216 RVA: 0x004C7B4E File Offset: 0x004C5D4E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060227A1 RID: 141217 RVA: 0x004C7B5B File Offset: 0x004C5D5B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060227A2 RID: 141218 RVA: 0x004C7B64 File Offset: 0x004C5D64
		public static IFollowShooterConfig GetRootAsIFollowShooterConfig(ByteBuffer _bb)
		{
			return IFollowShooterConfig.GetRootAsIFollowShooterConfig(_bb, default(IFollowShooterConfig));
		}

		// Token: 0x060227A3 RID: 141219 RVA: 0x004C7B80 File Offset: 0x004C5D80
		public static IFollowShooterConfig GetRootAsIFollowShooterConfig(ByteBuffer _bb, IFollowShooterConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060227A4 RID: 141220 RVA: 0x004C7B9D File Offset: 0x004C5D9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060227A5 RID: 141221 RVA: 0x004C7BAC File Offset: 0x004C5DAC
		public IFollowShooterConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B1B RID: 39707
		// (get) Token: 0x060227A6 RID: 141222 RVA: 0x004C7BBC File Offset: 0x004C5DBC
		public EFollowShooterType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFollowShooterType.JellyFish;
				}
				return (EFollowShooterType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060227A7 RID: 141223 RVA: 0x004C7BF8 File Offset: 0x004C5DF8
		public static Offset<IFollowShooterConfig> CreateIFollowShooterConfig(FlatBufferBuilder builder, EFollowShooterType Type = EFollowShooterType.JellyFish)
		{
			builder.StartTable(1);
			IFollowShooterConfig.AddType(builder, Type);
			return IFollowShooterConfig.EndIFollowShooterConfig(builder);
		}

		// Token: 0x060227A8 RID: 141224 RVA: 0x004C7C0E File Offset: 0x004C5E0E
		public static void StartIFollowShooterConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060227A9 RID: 141225 RVA: 0x004C7C17 File Offset: 0x004C5E17
		public static void AddType(FlatBufferBuilder builder, EFollowShooterType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060227AA RID: 141226 RVA: 0x004C7C22 File Offset: 0x004C5E22
		public static Offset<IFollowShooterConfig> EndIFollowShooterConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFollowShooterConfig>(builder.EndTable());
		}

		// Token: 0x060227AB RID: 141227 RVA: 0x004C7C30 File Offset: 0x004C5E30
		public IFollowShooterConfigT UnPack()
		{
			IFollowShooterConfigT followShooterConfigT = new IFollowShooterConfigT();
			this.UnPackTo(followShooterConfigT);
			return followShooterConfigT;
		}

		// Token: 0x060227AC RID: 141228 RVA: 0x004C7C4B File Offset: 0x004C5E4B
		public void UnPackTo(IFollowShooterConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060227AD RID: 141229 RVA: 0x004C7C5C File Offset: 0x004C5E5C
		public static Offset<IFollowShooterConfig> Pack(FlatBufferBuilder builder, IFollowShooterConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowShooterConfig>);
			}
			return IFollowShooterConfig.CreateIFollowShooterConfig(builder, _o.Type);
		}

		// Token: 0x0400E413 RID: 58387
		private Table __p;
	}
}

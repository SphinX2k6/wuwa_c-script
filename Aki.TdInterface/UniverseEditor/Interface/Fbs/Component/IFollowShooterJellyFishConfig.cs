using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052A6 RID: 21158
	public struct IFollowShooterJellyFishConfig : IFlatbufferObject
	{
		// Token: 0x17009B24 RID: 39716
		// (get) Token: 0x060227D4 RID: 141268 RVA: 0x004C8050 File Offset: 0x004C6250
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060227D5 RID: 141269 RVA: 0x004C805D File Offset: 0x004C625D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060227D6 RID: 141270 RVA: 0x004C8064 File Offset: 0x004C6264
		public static IFollowShooterJellyFishConfig GetRootAsIFollowShooterJellyFishConfig(ByteBuffer _bb)
		{
			return IFollowShooterJellyFishConfig.GetRootAsIFollowShooterJellyFishConfig(_bb, default(IFollowShooterJellyFishConfig));
		}

		// Token: 0x060227D7 RID: 141271 RVA: 0x004C8080 File Offset: 0x004C6280
		public static IFollowShooterJellyFishConfig GetRootAsIFollowShooterJellyFishConfig(ByteBuffer _bb, IFollowShooterJellyFishConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060227D8 RID: 141272 RVA: 0x004C809D File Offset: 0x004C629D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060227D9 RID: 141273 RVA: 0x004C80AC File Offset: 0x004C62AC
		public IFollowShooterJellyFishConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B25 RID: 39717
		// (get) Token: 0x060227DA RID: 141274 RVA: 0x004C80BC File Offset: 0x004C62BC
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

		// Token: 0x17009B26 RID: 39718
		// (get) Token: 0x060227DB RID: 141275 RVA: 0x004C80F8 File Offset: 0x004C62F8
		public float ResetRange
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009B27 RID: 39719
		// (get) Token: 0x060227DC RID: 141276 RVA: 0x004C8138 File Offset: 0x004C6338
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060227DD RID: 141277 RVA: 0x004C8174 File Offset: 0x004C6374
		public static Offset<IFollowShooterJellyFishConfig> CreateIFollowShooterJellyFishConfig(FlatBufferBuilder builder, EFollowShooterType Type = EFollowShooterType.JellyFish, float ResetRange = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			IFollowShooterJellyFishConfig.AddResetRange(builder, ResetRange);
			IFollowShooterJellyFishConfig.AddNullMask(builder, NullMask);
			IFollowShooterJellyFishConfig.AddType(builder, Type);
			return IFollowShooterJellyFishConfig.EndIFollowShooterJellyFishConfig(builder);
		}

		// Token: 0x060227DE RID: 141278 RVA: 0x004C8198 File Offset: 0x004C6398
		public static void StartIFollowShooterJellyFishConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060227DF RID: 141279 RVA: 0x004C81A1 File Offset: 0x004C63A1
		public static void AddType(FlatBufferBuilder builder, EFollowShooterType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060227E0 RID: 141280 RVA: 0x004C81AC File Offset: 0x004C63AC
		public static void AddResetRange(FlatBufferBuilder builder, float resetRange)
		{
			builder.AddFloat(1, resetRange, 0.0);
		}

		// Token: 0x060227E1 RID: 141281 RVA: 0x004C81BF File Offset: 0x004C63BF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060227E2 RID: 141282 RVA: 0x004C81CA File Offset: 0x004C63CA
		public static Offset<IFollowShooterJellyFishConfig> EndIFollowShooterJellyFishConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFollowShooterJellyFishConfig>(builder.EndTable());
		}

		// Token: 0x060227E3 RID: 141283 RVA: 0x004C81D8 File Offset: 0x004C63D8
		public IFollowShooterJellyFishConfigT UnPack()
		{
			IFollowShooterJellyFishConfigT followShooterJellyFishConfigT = new IFollowShooterJellyFishConfigT();
			this.UnPackTo(followShooterJellyFishConfigT);
			return followShooterJellyFishConfigT;
		}

		// Token: 0x060227E4 RID: 141284 RVA: 0x004C81F3 File Offset: 0x004C63F3
		public void UnPackTo(IFollowShooterJellyFishConfigT _o)
		{
			_o.Type = this.Type;
			_o.ResetRange = this.ResetRange;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060227E5 RID: 141285 RVA: 0x004C821C File Offset: 0x004C641C
		public static Offset<IFollowShooterJellyFishConfig> Pack(FlatBufferBuilder builder, IFollowShooterJellyFishConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowShooterJellyFishConfig>);
			}
			return IFollowShooterJellyFishConfig.CreateIFollowShooterJellyFishConfig(builder, _o.Type, _o.ResetRange, _o.NullMask);
		}

		// Token: 0x0400E41E RID: 58398
		private Table __p;
	}
}

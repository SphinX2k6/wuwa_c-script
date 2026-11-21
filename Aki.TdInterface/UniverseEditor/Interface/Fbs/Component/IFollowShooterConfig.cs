using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005805 RID: 22533
	public struct IFollowShooterConfig : IFlatbufferObject
	{
		// Token: 0x1700A318 RID: 41752
		// (get) Token: 0x0602473A RID: 149306 RVA: 0x005026BE File Offset: 0x005008BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602473B RID: 149307 RVA: 0x005026CB File Offset: 0x005008CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602473C RID: 149308 RVA: 0x005026D4 File Offset: 0x005008D4
		public static IFollowShooterConfig GetRootAsIFollowShooterConfig(ByteBuffer _bb)
		{
			return IFollowShooterConfig.GetRootAsIFollowShooterConfig(_bb, default(IFollowShooterConfig));
		}

		// Token: 0x0602473D RID: 149309 RVA: 0x005026F0 File Offset: 0x005008F0
		public static IFollowShooterConfig GetRootAsIFollowShooterConfig(ByteBuffer _bb, IFollowShooterConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602473E RID: 149310 RVA: 0x0050270D File Offset: 0x0050090D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602473F RID: 149311 RVA: 0x0050271C File Offset: 0x0050091C
		public IFollowShooterConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A319 RID: 41753
		// (get) Token: 0x06024740 RID: 149312 RVA: 0x0050272C File Offset: 0x0050092C
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

		// Token: 0x06024741 RID: 149313 RVA: 0x00502768 File Offset: 0x00500968
		public static Offset<IFollowShooterConfig> CreateIFollowShooterConfig(FlatBufferBuilder builder, EFollowShooterType Type = EFollowShooterType.JellyFish)
		{
			builder.StartTable(1);
			IFollowShooterConfig.AddType(builder, Type);
			return IFollowShooterConfig.EndIFollowShooterConfig(builder);
		}

		// Token: 0x06024742 RID: 149314 RVA: 0x0050277E File Offset: 0x0050097E
		public static void StartIFollowShooterConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024743 RID: 149315 RVA: 0x00502787 File Offset: 0x00500987
		public static void AddType(FlatBufferBuilder builder, EFollowShooterType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024744 RID: 149316 RVA: 0x00502792 File Offset: 0x00500992
		public static Offset<IFollowShooterConfig> EndIFollowShooterConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFollowShooterConfig>(builder.EndTable());
		}

		// Token: 0x06024745 RID: 149317 RVA: 0x005027A0 File Offset: 0x005009A0
		public IFollowShooterConfigT UnPack()
		{
			IFollowShooterConfigT followShooterConfigT = new IFollowShooterConfigT();
			this.UnPackTo(followShooterConfigT);
			return followShooterConfigT;
		}

		// Token: 0x06024746 RID: 149318 RVA: 0x005027BB File Offset: 0x005009BB
		public void UnPackTo(IFollowShooterConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06024747 RID: 149319 RVA: 0x005027CC File Offset: 0x005009CC
		public static Offset<IFollowShooterConfig> Pack(FlatBufferBuilder builder, IFollowShooterConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowShooterConfig>);
			}
			return IFollowShooterConfig.CreateIFollowShooterConfig(builder, _o.Type);
		}

		// Token: 0x0400F01A RID: 61466
		private Table __p;
	}
}

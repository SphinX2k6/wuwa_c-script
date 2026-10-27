using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004136 RID: 16694
	public struct ISpecialGamePlayConfig : IFlatbufferObject
	{
		// Token: 0x17007641 RID: 30273
		// (get) Token: 0x060187BE RID: 100286 RVA: 0x00387A55 File Offset: 0x00385C55
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060187BF RID: 100287 RVA: 0x00387A62 File Offset: 0x00385C62
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060187C0 RID: 100288 RVA: 0x00387A6C File Offset: 0x00385C6C
		public static ISpecialGamePlayConfig GetRootAsISpecialGamePlayConfig(ByteBuffer _bb)
		{
			return ISpecialGamePlayConfig.GetRootAsISpecialGamePlayConfig(_bb, default(ISpecialGamePlayConfig));
		}

		// Token: 0x060187C1 RID: 100289 RVA: 0x00387A88 File Offset: 0x00385C88
		public static ISpecialGamePlayConfig GetRootAsISpecialGamePlayConfig(ByteBuffer _bb, ISpecialGamePlayConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060187C2 RID: 100290 RVA: 0x00387AA5 File Offset: 0x00385CA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060187C3 RID: 100291 RVA: 0x00387AB4 File Offset: 0x00385CB4
		public ISpecialGamePlayConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007642 RID: 30274
		// (get) Token: 0x060187C4 RID: 100292 RVA: 0x00387AC4 File Offset: 0x00385CC4
		public ESpecialGamePlayConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpecialGamePlayConfigType.Stalking;
				}
				return (ESpecialGamePlayConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060187C5 RID: 100293 RVA: 0x00387B00 File Offset: 0x00385D00
		public static Offset<ISpecialGamePlayConfig> CreateISpecialGamePlayConfig(FlatBufferBuilder builder, ESpecialGamePlayConfigType Type = ESpecialGamePlayConfigType.Stalking)
		{
			builder.StartTable(1);
			ISpecialGamePlayConfig.AddType(builder, Type);
			return ISpecialGamePlayConfig.EndISpecialGamePlayConfig(builder);
		}

		// Token: 0x060187C6 RID: 100294 RVA: 0x00387B16 File Offset: 0x00385D16
		public static void StartISpecialGamePlayConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060187C7 RID: 100295 RVA: 0x00387B1F File Offset: 0x00385D1F
		public static void AddType(FlatBufferBuilder builder, ESpecialGamePlayConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060187C8 RID: 100296 RVA: 0x00387B2A File Offset: 0x00385D2A
		public static Offset<ISpecialGamePlayConfig> EndISpecialGamePlayConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISpecialGamePlayConfig>(builder.EndTable());
		}

		// Token: 0x060187C9 RID: 100297 RVA: 0x00387B38 File Offset: 0x00385D38
		public ISpecialGamePlayConfigT UnPack()
		{
			ISpecialGamePlayConfigT specialGamePlayConfigT = new ISpecialGamePlayConfigT();
			this.UnPackTo(specialGamePlayConfigT);
			return specialGamePlayConfigT;
		}

		// Token: 0x060187CA RID: 100298 RVA: 0x00387B53 File Offset: 0x00385D53
		public void UnPackTo(ISpecialGamePlayConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060187CB RID: 100299 RVA: 0x00387B64 File Offset: 0x00385D64
		public static Offset<ISpecialGamePlayConfig> Pack(FlatBufferBuilder builder, ISpecialGamePlayConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpecialGamePlayConfig>);
			}
			return ISpecialGamePlayConfig.CreateISpecialGamePlayConfig(builder, _o.Type);
		}

		// Token: 0x0400BD39 RID: 48441
		private Table __p;
	}
}

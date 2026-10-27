using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E54 RID: 15956
	public struct IFirstPersonTurretGamePlayConfig : IFlatbufferObject
	{
		// Token: 0x17006EA8 RID: 28328
		// (get) Token: 0x0601674F RID: 91983 RVA: 0x0033F408 File Offset: 0x0033D608
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016750 RID: 91984 RVA: 0x0033F415 File Offset: 0x0033D615
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016751 RID: 91985 RVA: 0x0033F41C File Offset: 0x0033D61C
		public static IFirstPersonTurretGamePlayConfig GetRootAsIFirstPersonTurretGamePlayConfig(ByteBuffer _bb)
		{
			return IFirstPersonTurretGamePlayConfig.GetRootAsIFirstPersonTurretGamePlayConfig(_bb, default(IFirstPersonTurretGamePlayConfig));
		}

		// Token: 0x06016752 RID: 91986 RVA: 0x0033F438 File Offset: 0x0033D638
		public static IFirstPersonTurretGamePlayConfig GetRootAsIFirstPersonTurretGamePlayConfig(ByteBuffer _bb, IFirstPersonTurretGamePlayConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016753 RID: 91987 RVA: 0x0033F455 File Offset: 0x0033D655
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016754 RID: 91988 RVA: 0x0033F464 File Offset: 0x0033D664
		public IFirstPersonTurretGamePlayConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006EA9 RID: 28329
		// (get) Token: 0x06016755 RID: 91989 RVA: 0x0033F474 File Offset: 0x0033D674
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

		// Token: 0x06016756 RID: 91990 RVA: 0x0033F4B0 File Offset: 0x0033D6B0
		public static Offset<IFirstPersonTurretGamePlayConfig> CreateIFirstPersonTurretGamePlayConfig(FlatBufferBuilder builder, ESpecialGamePlayConfigType Type = ESpecialGamePlayConfigType.Stalking)
		{
			builder.StartTable(1);
			IFirstPersonTurretGamePlayConfig.AddType(builder, Type);
			return IFirstPersonTurretGamePlayConfig.EndIFirstPersonTurretGamePlayConfig(builder);
		}

		// Token: 0x06016757 RID: 91991 RVA: 0x0033F4C6 File Offset: 0x0033D6C6
		public static void StartIFirstPersonTurretGamePlayConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016758 RID: 91992 RVA: 0x0033F4CF File Offset: 0x0033D6CF
		public static void AddType(FlatBufferBuilder builder, ESpecialGamePlayConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016759 RID: 91993 RVA: 0x0033F4DA File Offset: 0x0033D6DA
		public static Offset<IFirstPersonTurretGamePlayConfig> EndIFirstPersonTurretGamePlayConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFirstPersonTurretGamePlayConfig>(builder.EndTable());
		}

		// Token: 0x0601675A RID: 91994 RVA: 0x0033F4E8 File Offset: 0x0033D6E8
		public IFirstPersonTurretGamePlayConfigT UnPack()
		{
			IFirstPersonTurretGamePlayConfigT firstPersonTurretGamePlayConfigT = new IFirstPersonTurretGamePlayConfigT();
			this.UnPackTo(firstPersonTurretGamePlayConfigT);
			return firstPersonTurretGamePlayConfigT;
		}

		// Token: 0x0601675B RID: 91995 RVA: 0x0033F503 File Offset: 0x0033D703
		public void UnPackTo(IFirstPersonTurretGamePlayConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601675C RID: 91996 RVA: 0x0033F514 File Offset: 0x0033D714
		public static Offset<IFirstPersonTurretGamePlayConfig> Pack(FlatBufferBuilder builder, IFirstPersonTurretGamePlayConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFirstPersonTurretGamePlayConfig>);
			}
			return IFirstPersonTurretGamePlayConfig.CreateIFirstPersonTurretGamePlayConfig(builder, _o.Type);
		}

		// Token: 0x0400B805 RID: 47109
		private Table __p;
	}
}

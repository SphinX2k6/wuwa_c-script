using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057F9 RID: 22521
	public struct IFollowDecorationConfig : IFlatbufferObject
	{
		// Token: 0x1700A2FB RID: 41723
		// (get) Token: 0x060246BA RID: 149178 RVA: 0x00501483 File Offset: 0x004FF683
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060246BB RID: 149179 RVA: 0x00501490 File Offset: 0x004FF690
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060246BC RID: 149180 RVA: 0x00501498 File Offset: 0x004FF698
		public static IFollowDecorationConfig GetRootAsIFollowDecorationConfig(ByteBuffer _bb)
		{
			return IFollowDecorationConfig.GetRootAsIFollowDecorationConfig(_bb, default(IFollowDecorationConfig));
		}

		// Token: 0x060246BD RID: 149181 RVA: 0x005014B4 File Offset: 0x004FF6B4
		public static IFollowDecorationConfig GetRootAsIFollowDecorationConfig(ByteBuffer _bb, IFollowDecorationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060246BE RID: 149182 RVA: 0x005014D1 File Offset: 0x004FF6D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060246BF RID: 149183 RVA: 0x005014E0 File Offset: 0x004FF6E0
		public IFollowDecorationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A2FC RID: 41724
		// (get) Token: 0x060246C0 RID: 149184 RVA: 0x005014F0 File Offset: 0x004FF6F0
		public EFollowDecorationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFollowDecorationType.Chair;
				}
				return (EFollowDecorationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060246C1 RID: 149185 RVA: 0x0050152C File Offset: 0x004FF72C
		public static Offset<IFollowDecorationConfig> CreateIFollowDecorationConfig(FlatBufferBuilder builder, EFollowDecorationType Type = EFollowDecorationType.Chair)
		{
			builder.StartTable(1);
			IFollowDecorationConfig.AddType(builder, Type);
			return IFollowDecorationConfig.EndIFollowDecorationConfig(builder);
		}

		// Token: 0x060246C2 RID: 149186 RVA: 0x00501542 File Offset: 0x004FF742
		public static void StartIFollowDecorationConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060246C3 RID: 149187 RVA: 0x0050154B File Offset: 0x004FF74B
		public static void AddType(FlatBufferBuilder builder, EFollowDecorationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060246C4 RID: 149188 RVA: 0x00501556 File Offset: 0x004FF756
		public static Offset<IFollowDecorationConfig> EndIFollowDecorationConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFollowDecorationConfig>(builder.EndTable());
		}

		// Token: 0x060246C5 RID: 149189 RVA: 0x00501564 File Offset: 0x004FF764
		public IFollowDecorationConfigT UnPack()
		{
			IFollowDecorationConfigT followDecorationConfigT = new IFollowDecorationConfigT();
			this.UnPackTo(followDecorationConfigT);
			return followDecorationConfigT;
		}

		// Token: 0x060246C6 RID: 149190 RVA: 0x0050157F File Offset: 0x004FF77F
		public void UnPackTo(IFollowDecorationConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060246C7 RID: 149191 RVA: 0x00501590 File Offset: 0x004FF790
		public static Offset<IFollowDecorationConfig> Pack(FlatBufferBuilder builder, IFollowDecorationConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowDecorationConfig>);
			}
			return IFollowDecorationConfig.CreateIFollowDecorationConfig(builder, _o.Type);
		}

		// Token: 0x0400F005 RID: 61445
		private Table __p;
	}
}

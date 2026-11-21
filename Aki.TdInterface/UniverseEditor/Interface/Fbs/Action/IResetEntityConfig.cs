using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007603 RID: 30211
	public struct IResetEntityConfig : IFlatbufferObject
	{
		// Token: 0x1700DE03 RID: 56835
		// (get) Token: 0x06035029 RID: 217129 RVA: 0x0071F275 File Offset: 0x0071D475
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603502A RID: 217130 RVA: 0x0071F282 File Offset: 0x0071D482
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603502B RID: 217131 RVA: 0x0071F28C File Offset: 0x0071D48C
		public static IResetEntityConfig GetRootAsIResetEntityConfig(ByteBuffer _bb)
		{
			return IResetEntityConfig.GetRootAsIResetEntityConfig(_bb, default(IResetEntityConfig));
		}

		// Token: 0x0603502C RID: 217132 RVA: 0x0071F2A8 File Offset: 0x0071D4A8
		public static IResetEntityConfig GetRootAsIResetEntityConfig(ByteBuffer _bb, IResetEntityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603502D RID: 217133 RVA: 0x0071F2C5 File Offset: 0x0071D4C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603502E RID: 217134 RVA: 0x0071F2D4 File Offset: 0x0071D4D4
		public IResetEntityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DE04 RID: 56836
		// (get) Token: 0x0603502F RID: 217135 RVA: 0x0071F2E4 File Offset: 0x0071D4E4
		public EResetEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EResetEntityType.TeleControl;
				}
				return (EResetEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035030 RID: 217136 RVA: 0x0071F320 File Offset: 0x0071D520
		public static Offset<IResetEntityConfig> CreateIResetEntityConfig(FlatBufferBuilder builder, EResetEntityType Type = EResetEntityType.TeleControl)
		{
			builder.StartTable(1);
			IResetEntityConfig.AddType(builder, Type);
			return IResetEntityConfig.EndIResetEntityConfig(builder);
		}

		// Token: 0x06035031 RID: 217137 RVA: 0x0071F336 File Offset: 0x0071D536
		public static void StartIResetEntityConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035032 RID: 217138 RVA: 0x0071F33F File Offset: 0x0071D53F
		public static void AddType(FlatBufferBuilder builder, EResetEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035033 RID: 217139 RVA: 0x0071F34A File Offset: 0x0071D54A
		public static Offset<IResetEntityConfig> EndIResetEntityConfig(FlatBufferBuilder builder)
		{
			return new Offset<IResetEntityConfig>(builder.EndTable());
		}

		// Token: 0x06035034 RID: 217140 RVA: 0x0071F358 File Offset: 0x0071D558
		public IResetEntityConfigT UnPack()
		{
			IResetEntityConfigT resetEntityConfigT = new IResetEntityConfigT();
			this.UnPackTo(resetEntityConfigT);
			return resetEntityConfigT;
		}

		// Token: 0x06035035 RID: 217141 RVA: 0x0071F373 File Offset: 0x0071D573
		public void UnPackTo(IResetEntityConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035036 RID: 217142 RVA: 0x0071F384 File Offset: 0x0071D584
		public static Offset<IResetEntityConfig> Pack(FlatBufferBuilder builder, IResetEntityConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResetEntityConfig>);
			}
			return IResetEntityConfig.CreateIResetEntityConfig(builder, _o.Type);
		}

		// Token: 0x040127EF RID: 75759
		private Table __p;
	}
}

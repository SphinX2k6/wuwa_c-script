using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063DD RID: 25565
	public struct IElementalBoxConfig : IFlatbufferObject
	{
		// Token: 0x1700BCE1 RID: 48353
		// (get) Token: 0x0602B6CC RID: 177868 RVA: 0x005EAD1C File Offset: 0x005E8F1C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B6CD RID: 177869 RVA: 0x005EAD29 File Offset: 0x005E8F29
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B6CE RID: 177870 RVA: 0x005EAD30 File Offset: 0x005E8F30
		public static IElementalBoxConfig GetRootAsIElementalBoxConfig(ByteBuffer _bb)
		{
			return IElementalBoxConfig.GetRootAsIElementalBoxConfig(_bb, default(IElementalBoxConfig));
		}

		// Token: 0x0602B6CF RID: 177871 RVA: 0x005EAD4C File Offset: 0x005E8F4C
		public static IElementalBoxConfig GetRootAsIElementalBoxConfig(ByteBuffer _bb, IElementalBoxConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B6D0 RID: 177872 RVA: 0x005EAD69 File Offset: 0x005E8F69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B6D1 RID: 177873 RVA: 0x005EAD78 File Offset: 0x005E8F78
		public IElementalBoxConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BCE2 RID: 48354
		// (get) Token: 0x0602B6D2 RID: 177874 RVA: 0x005EAD88 File Offset: 0x005E8F88
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BCE3 RID: 48355
		// (get) Token: 0x0602B6D3 RID: 177875 RVA: 0x005EADC4 File Offset: 0x005E8FC4
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B6D4 RID: 177876 RVA: 0x005EADFB File Offset: 0x005E8FFB
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602B6D5 RID: 177877 RVA: 0x005EAE0A File Offset: 0x005E900A
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700BCE4 RID: 48356
		// (get) Token: 0x0602B6D6 RID: 177878 RVA: 0x005EAE18 File Offset: 0x005E9018
		public EElementalType ElementalType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EElementalType.Fire;
				}
				return (EElementalType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BCE5 RID: 48357
		// (get) Token: 0x0602B6D7 RID: 177879 RVA: 0x005EAE54 File Offset: 0x005E9054
		public int Priority
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BCE6 RID: 48358
		// (get) Token: 0x0602B6D8 RID: 177880 RVA: 0x005EAE94 File Offset: 0x005E9094
		public string InitState
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B6D9 RID: 177881 RVA: 0x005EAECC File Offset: 0x005E90CC
		public Span<byte> GetInitStateBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0602B6DA RID: 177882 RVA: 0x005EAEDC File Offset: 0x005E90DC
		public byte[] GetInitStateArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700BCE7 RID: 48359
		// (get) Token: 0x0602B6DB RID: 177883 RVA: 0x005EAEEC File Offset: 0x005E90EC
		public string CustomBoxPrefab
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B6DC RID: 177884 RVA: 0x005EAF24 File Offset: 0x005E9124
		public Span<byte> GetCustomBoxPrefabBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0602B6DD RID: 177885 RVA: 0x005EAF34 File Offset: 0x005E9134
		public byte[] GetCustomBoxPrefabArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x0602B6DE RID: 177886 RVA: 0x005EAF43 File Offset: 0x005E9143
		public static Offset<IElementalBoxConfig> CreateIElementalBoxConfig(FlatBufferBuilder builder, int Id = 0, StringOffset DescOffset = default(StringOffset), EElementalType ElementalType = EElementalType.Fire, int Priority = 0, StringOffset InitStateOffset = default(StringOffset), StringOffset CustomBoxPrefabOffset = default(StringOffset))
		{
			builder.StartTable(6);
			IElementalBoxConfig.AddCustomBoxPrefab(builder, CustomBoxPrefabOffset);
			IElementalBoxConfig.AddInitState(builder, InitStateOffset);
			IElementalBoxConfig.AddPriority(builder, Priority);
			IElementalBoxConfig.AddDesc(builder, DescOffset);
			IElementalBoxConfig.AddId(builder, Id);
			IElementalBoxConfig.AddElementalType(builder, ElementalType);
			return IElementalBoxConfig.EndIElementalBoxConfig(builder);
		}

		// Token: 0x0602B6DF RID: 177887 RVA: 0x005EAF7F File Offset: 0x005E917F
		public static void StartIElementalBoxConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602B6E0 RID: 177888 RVA: 0x005EAF88 File Offset: 0x005E9188
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0602B6E1 RID: 177889 RVA: 0x005EAF93 File Offset: 0x005E9193
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(1, descOffset.Value, 0);
		}

		// Token: 0x0602B6E2 RID: 177890 RVA: 0x005EAFA3 File Offset: 0x005E91A3
		public static void AddElementalType(FlatBufferBuilder builder, EElementalType elementalType)
		{
			builder.AddByte(2, (byte)elementalType, 0);
		}

		// Token: 0x0602B6E3 RID: 177891 RVA: 0x005EAFAE File Offset: 0x005E91AE
		public static void AddPriority(FlatBufferBuilder builder, int priority)
		{
			builder.AddInt(3, priority, 0);
		}

		// Token: 0x0602B6E4 RID: 177892 RVA: 0x005EAFB9 File Offset: 0x005E91B9
		public static void AddInitState(FlatBufferBuilder builder, StringOffset initStateOffset)
		{
			builder.AddOffset(4, initStateOffset.Value, 0);
		}

		// Token: 0x0602B6E5 RID: 177893 RVA: 0x005EAFC9 File Offset: 0x005E91C9
		public static void AddCustomBoxPrefab(FlatBufferBuilder builder, StringOffset customBoxPrefabOffset)
		{
			builder.AddOffset(5, customBoxPrefabOffset.Value, 0);
		}

		// Token: 0x0602B6E6 RID: 177894 RVA: 0x005EAFD9 File Offset: 0x005E91D9
		public static Offset<IElementalBoxConfig> EndIElementalBoxConfig(FlatBufferBuilder builder)
		{
			return new Offset<IElementalBoxConfig>(builder.EndTable());
		}

		// Token: 0x0602B6E7 RID: 177895 RVA: 0x005EAFE8 File Offset: 0x005E91E8
		public IElementalBoxConfigT UnPack()
		{
			IElementalBoxConfigT elementalBoxConfigT = new IElementalBoxConfigT();
			this.UnPackTo(elementalBoxConfigT);
			return elementalBoxConfigT;
		}

		// Token: 0x0602B6E8 RID: 177896 RVA: 0x005EB004 File Offset: 0x005E9204
		public void UnPackTo(IElementalBoxConfigT _o)
		{
			_o.Id = this.Id;
			_o.Desc = this.Desc;
			_o.ElementalType = this.ElementalType;
			_o.Priority = this.Priority;
			_o.InitState = this.InitState;
			_o.CustomBoxPrefab = this.CustomBoxPrefab;
		}

		// Token: 0x0602B6E9 RID: 177897 RVA: 0x005EB05C File Offset: 0x005E925C
		public static Offset<IElementalBoxConfig> Pack(FlatBufferBuilder builder, IElementalBoxConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IElementalBoxConfig>);
			}
			StringOffset descOffset = (_o.Desc == null) ? default(StringOffset) : builder.CreateString(_o.Desc);
			StringOffset initStateOffset = (_o.InitState == null) ? default(StringOffset) : builder.CreateString(_o.InitState);
			StringOffset customBoxPrefabOffset = (_o.CustomBoxPrefab == null) ? default(StringOffset) : builder.CreateString(_o.CustomBoxPrefab);
			return IElementalBoxConfig.CreateIElementalBoxConfig(builder, _o.Id, descOffset, _o.ElementalType, _o.Priority, initStateOffset, customBoxPrefabOffset);
		}

		// Token: 0x040104D2 RID: 66770
		private Table __p;
	}
}

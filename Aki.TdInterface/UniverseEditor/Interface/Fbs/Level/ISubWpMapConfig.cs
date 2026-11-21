using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x02004880 RID: 18560
	public struct ISubWpMapConfig : IFlatbufferObject
	{
		// Token: 0x17008138 RID: 33080
		// (get) Token: 0x0601B731 RID: 112433 RVA: 0x003E2930 File Offset: 0x003E0B30
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B732 RID: 112434 RVA: 0x003E293D File Offset: 0x003E0B3D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B733 RID: 112435 RVA: 0x003E2944 File Offset: 0x003E0B44
		public static ISubWpMapConfig GetRootAsISubWpMapConfig(ByteBuffer _bb)
		{
			return ISubWpMapConfig.GetRootAsISubWpMapConfig(_bb, default(ISubWpMapConfig));
		}

		// Token: 0x0601B734 RID: 112436 RVA: 0x003E2960 File Offset: 0x003E0B60
		public static ISubWpMapConfig GetRootAsISubWpMapConfig(ByteBuffer _bb, ISubWpMapConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B735 RID: 112437 RVA: 0x003E297D File Offset: 0x003E0B7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B736 RID: 112438 RVA: 0x003E298C File Offset: 0x003E0B8C
		public ISubWpMapConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008139 RID: 33081
		// (get) Token: 0x0601B737 RID: 112439 RVA: 0x003E299C File Offset: 0x003E0B9C
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

		// Token: 0x1700813A RID: 33082
		// (get) Token: 0x0601B738 RID: 112440 RVA: 0x003E29D8 File Offset: 0x003E0BD8
		public string Name
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

		// Token: 0x0601B739 RID: 112441 RVA: 0x003E2A0F File Offset: 0x003E0C0F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601B73A RID: 112442 RVA: 0x003E2A1E File Offset: 0x003E0C1E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700813B RID: 33083
		// (get) Token: 0x0601B73B RID: 112443 RVA: 0x003E2A2C File Offset: 0x003E0C2C
		public string ContentPath
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B73C RID: 112444 RVA: 0x003E2A63 File Offset: 0x003E0C63
		public Span<byte> GetContentPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601B73D RID: 112445 RVA: 0x003E2A72 File Offset: 0x003E0C72
		public byte[] GetContentPathArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700813C RID: 33084
		// (get) Token: 0x0601B73E RID: 112446 RVA: 0x003E2A80 File Offset: 0x003E0C80
		public bool IsTest
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601B73F RID: 112447 RVA: 0x003E2AC0 File Offset: 0x003E0CC0
		public static Offset<ISubWpMapConfig> CreateISubWpMapConfig(FlatBufferBuilder builder, int Id = 0, StringOffset NameOffset = default(StringOffset), StringOffset ContentPathOffset = default(StringOffset), bool IsTest = false)
		{
			builder.StartTable(4);
			ISubWpMapConfig.AddContentPath(builder, ContentPathOffset);
			ISubWpMapConfig.AddName(builder, NameOffset);
			ISubWpMapConfig.AddId(builder, Id);
			ISubWpMapConfig.AddIsTest(builder, IsTest);
			return ISubWpMapConfig.EndISubWpMapConfig(builder);
		}

		// Token: 0x0601B740 RID: 112448 RVA: 0x003E2AEC File Offset: 0x003E0CEC
		public static void StartISubWpMapConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601B741 RID: 112449 RVA: 0x003E2AF5 File Offset: 0x003E0CF5
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601B742 RID: 112450 RVA: 0x003E2B00 File Offset: 0x003E0D00
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x0601B743 RID: 112451 RVA: 0x003E2B10 File Offset: 0x003E0D10
		public static void AddContentPath(FlatBufferBuilder builder, StringOffset contentPathOffset)
		{
			builder.AddOffset(2, contentPathOffset.Value, 0);
		}

		// Token: 0x0601B744 RID: 112452 RVA: 0x003E2B20 File Offset: 0x003E0D20
		public static void AddIsTest(FlatBufferBuilder builder, bool isTest)
		{
			builder.AddBool(3, isTest, false);
		}

		// Token: 0x0601B745 RID: 112453 RVA: 0x003E2B2B File Offset: 0x003E0D2B
		public static Offset<ISubWpMapConfig> EndISubWpMapConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISubWpMapConfig>(builder.EndTable());
		}

		// Token: 0x0601B746 RID: 112454 RVA: 0x003E2B38 File Offset: 0x003E0D38
		public ISubWpMapConfigT UnPack()
		{
			ISubWpMapConfigT subWpMapConfigT = new ISubWpMapConfigT();
			this.UnPackTo(subWpMapConfigT);
			return subWpMapConfigT;
		}

		// Token: 0x0601B747 RID: 112455 RVA: 0x003E2B53 File Offset: 0x003E0D53
		public void UnPackTo(ISubWpMapConfigT _o)
		{
			_o.Id = this.Id;
			_o.Name = this.Name;
			_o.ContentPath = this.ContentPath;
			_o.IsTest = this.IsTest;
		}

		// Token: 0x0601B748 RID: 112456 RVA: 0x003E2B88 File Offset: 0x003E0D88
		public static Offset<ISubWpMapConfig> Pack(FlatBufferBuilder builder, ISubWpMapConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISubWpMapConfig>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			StringOffset contentPathOffset = (_o.ContentPath == null) ? default(StringOffset) : builder.CreateString(_o.ContentPath);
			return ISubWpMapConfig.CreateISubWpMapConfig(builder, _o.Id, nameOffset, contentPathOffset, _o.IsTest);
		}

		// Token: 0x0400CDA1 RID: 52641
		private Table __p;
	}
}

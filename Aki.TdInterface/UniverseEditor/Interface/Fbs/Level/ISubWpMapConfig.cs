using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x02004418 RID: 17432
	public struct ISubWpMapConfig : IFlatbufferObject
	{
		// Token: 0x17007AF9 RID: 31481
		// (get) Token: 0x06019F60 RID: 106336 RVA: 0x003B6724 File Offset: 0x003B4924
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019F61 RID: 106337 RVA: 0x003B6731 File Offset: 0x003B4931
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019F62 RID: 106338 RVA: 0x003B6738 File Offset: 0x003B4938
		public static ISubWpMapConfig GetRootAsISubWpMapConfig(ByteBuffer _bb)
		{
			return ISubWpMapConfig.GetRootAsISubWpMapConfig(_bb, default(ISubWpMapConfig));
		}

		// Token: 0x06019F63 RID: 106339 RVA: 0x003B6754 File Offset: 0x003B4954
		public static ISubWpMapConfig GetRootAsISubWpMapConfig(ByteBuffer _bb, ISubWpMapConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019F64 RID: 106340 RVA: 0x003B6771 File Offset: 0x003B4971
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019F65 RID: 106341 RVA: 0x003B6780 File Offset: 0x003B4980
		public ISubWpMapConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007AFA RID: 31482
		// (get) Token: 0x06019F66 RID: 106342 RVA: 0x003B6790 File Offset: 0x003B4990
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

		// Token: 0x17007AFB RID: 31483
		// (get) Token: 0x06019F67 RID: 106343 RVA: 0x003B67CC File Offset: 0x003B49CC
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

		// Token: 0x06019F68 RID: 106344 RVA: 0x003B6803 File Offset: 0x003B4A03
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06019F69 RID: 106345 RVA: 0x003B6812 File Offset: 0x003B4A12
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17007AFC RID: 31484
		// (get) Token: 0x06019F6A RID: 106346 RVA: 0x003B6820 File Offset: 0x003B4A20
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

		// Token: 0x06019F6B RID: 106347 RVA: 0x003B6857 File Offset: 0x003B4A57
		public Span<byte> GetContentPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06019F6C RID: 106348 RVA: 0x003B6866 File Offset: 0x003B4A66
		public byte[] GetContentPathArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17007AFD RID: 31485
		// (get) Token: 0x06019F6D RID: 106349 RVA: 0x003B6874 File Offset: 0x003B4A74
		public bool IsTest
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06019F6E RID: 106350 RVA: 0x003B68B4 File Offset: 0x003B4AB4
		public static Offset<ISubWpMapConfig> CreateISubWpMapConfig(FlatBufferBuilder builder, int Id = 0, StringOffset NameOffset = default(StringOffset), StringOffset ContentPathOffset = default(StringOffset), bool IsTest = false)
		{
			builder.StartTable(4);
			ISubWpMapConfig.AddContentPath(builder, ContentPathOffset);
			ISubWpMapConfig.AddName(builder, NameOffset);
			ISubWpMapConfig.AddId(builder, Id);
			ISubWpMapConfig.AddIsTest(builder, IsTest);
			return ISubWpMapConfig.EndISubWpMapConfig(builder);
		}

		// Token: 0x06019F6F RID: 106351 RVA: 0x003B68E0 File Offset: 0x003B4AE0
		public static void StartISubWpMapConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06019F70 RID: 106352 RVA: 0x003B68E9 File Offset: 0x003B4AE9
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06019F71 RID: 106353 RVA: 0x003B68F4 File Offset: 0x003B4AF4
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x06019F72 RID: 106354 RVA: 0x003B6904 File Offset: 0x003B4B04
		public static void AddContentPath(FlatBufferBuilder builder, StringOffset contentPathOffset)
		{
			builder.AddOffset(2, contentPathOffset.Value, 0);
		}

		// Token: 0x06019F73 RID: 106355 RVA: 0x003B6914 File Offset: 0x003B4B14
		public static void AddIsTest(FlatBufferBuilder builder, bool isTest)
		{
			builder.AddBool(3, isTest, false);
		}

		// Token: 0x06019F74 RID: 106356 RVA: 0x003B691F File Offset: 0x003B4B1F
		public static Offset<ISubWpMapConfig> EndISubWpMapConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISubWpMapConfig>(builder.EndTable());
		}

		// Token: 0x06019F75 RID: 106357 RVA: 0x003B692C File Offset: 0x003B4B2C
		public ISubWpMapConfigT UnPack()
		{
			ISubWpMapConfigT subWpMapConfigT = new ISubWpMapConfigT();
			this.UnPackTo(subWpMapConfigT);
			return subWpMapConfigT;
		}

		// Token: 0x06019F76 RID: 106358 RVA: 0x003B6947 File Offset: 0x003B4B47
		public void UnPackTo(ISubWpMapConfigT _o)
		{
			_o.Id = this.Id;
			_o.Name = this.Name;
			_o.ContentPath = this.ContentPath;
			_o.IsTest = this.IsTest;
		}

		// Token: 0x06019F77 RID: 106359 RVA: 0x003B697C File Offset: 0x003B4B7C
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

		// Token: 0x0400C374 RID: 50036
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B66 RID: 27494
	public struct ICustomJson : IFlatbufferObject
	{
		// Token: 0x1700C9D0 RID: 51664
		// (get) Token: 0x0602F4FF RID: 193791 RVA: 0x0067530A File Offset: 0x0067350A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F500 RID: 193792 RVA: 0x00675317 File Offset: 0x00673517
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F501 RID: 193793 RVA: 0x00675320 File Offset: 0x00673520
		public static ICustomJson GetRootAsICustomJson(ByteBuffer _bb)
		{
			return ICustomJson.GetRootAsICustomJson(_bb, default(ICustomJson));
		}

		// Token: 0x0602F502 RID: 193794 RVA: 0x0067533C File Offset: 0x0067353C
		public static ICustomJson GetRootAsICustomJson(ByteBuffer _bb, ICustomJson obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F503 RID: 193795 RVA: 0x00675359 File Offset: 0x00673559
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F504 RID: 193796 RVA: 0x00675368 File Offset: 0x00673568
		public ICustomJson __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9D1 RID: 51665
		// (get) Token: 0x0602F505 RID: 193797 RVA: 0x00675378 File Offset: 0x00673578
		public string Name
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F506 RID: 193798 RVA: 0x006753AF File Offset: 0x006735AF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602F507 RID: 193799 RVA: 0x006753BE File Offset: 0x006735BE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700C9D2 RID: 51666
		// (get) Token: 0x0602F508 RID: 193800 RVA: 0x006753CC File Offset: 0x006735CC
		public string JsonString
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

		// Token: 0x0602F509 RID: 193801 RVA: 0x00675403 File Offset: 0x00673603
		public Span<byte> GetJsonStringBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602F50A RID: 193802 RVA: 0x00675412 File Offset: 0x00673612
		public byte[] GetJsonStringArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602F50B RID: 193803 RVA: 0x00675420 File Offset: 0x00673620
		public static Offset<ICustomJson> CreateICustomJson(FlatBufferBuilder builder, StringOffset NameOffset = default(StringOffset), StringOffset JsonStringOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICustomJson.AddJsonString(builder, JsonStringOffset);
			ICustomJson.AddName(builder, NameOffset);
			return ICustomJson.EndICustomJson(builder);
		}

		// Token: 0x0602F50C RID: 193804 RVA: 0x0067543D File Offset: 0x0067363D
		public static void StartICustomJson(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F50D RID: 193805 RVA: 0x00675446 File Offset: 0x00673646
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(0, nameOffset.Value, 0);
		}

		// Token: 0x0602F50E RID: 193806 RVA: 0x00675456 File Offset: 0x00673656
		public static void AddJsonString(FlatBufferBuilder builder, StringOffset jsonStringOffset)
		{
			builder.AddOffset(1, jsonStringOffset.Value, 0);
		}

		// Token: 0x0602F50F RID: 193807 RVA: 0x00675466 File Offset: 0x00673666
		public static Offset<ICustomJson> EndICustomJson(FlatBufferBuilder builder)
		{
			return new Offset<ICustomJson>(builder.EndTable());
		}

		// Token: 0x0602F510 RID: 193808 RVA: 0x00675474 File Offset: 0x00673674
		public ICustomJsonT UnPack()
		{
			ICustomJsonT customJsonT = new ICustomJsonT();
			this.UnPackTo(customJsonT);
			return customJsonT;
		}

		// Token: 0x0602F511 RID: 193809 RVA: 0x0067548F File Offset: 0x0067368F
		public void UnPackTo(ICustomJsonT _o)
		{
			_o.Name = this.Name;
			_o.JsonString = this.JsonString;
		}

		// Token: 0x0602F512 RID: 193810 RVA: 0x006754AC File Offset: 0x006736AC
		public static Offset<ICustomJson> Pack(FlatBufferBuilder builder, ICustomJsonT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomJson>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			StringOffset jsonStringOffset = (_o.JsonString == null) ? default(StringOffset) : builder.CreateString(_o.JsonString);
			return ICustomJson.CreateICustomJson(builder, nameOffset, jsonStringOffset);
		}

		// Token: 0x04011953 RID: 72019
		private Table __p;
	}
}

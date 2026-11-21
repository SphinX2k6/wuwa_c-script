using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007198 RID: 29080
	public struct IMaxAlertValue : IFlatbufferObject
	{
		// Token: 0x1700D4E3 RID: 54499
		// (get) Token: 0x060328ED RID: 207085 RVA: 0x006D4F78 File Offset: 0x006D3178
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060328EE RID: 207086 RVA: 0x006D4F85 File Offset: 0x006D3185
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060328EF RID: 207087 RVA: 0x006D4F8C File Offset: 0x006D318C
		public static IMaxAlertValue GetRootAsIMaxAlertValue(ByteBuffer _bb)
		{
			return IMaxAlertValue.GetRootAsIMaxAlertValue(_bb, default(IMaxAlertValue));
		}

		// Token: 0x060328F0 RID: 207088 RVA: 0x006D4FA8 File Offset: 0x006D31A8
		public static IMaxAlertValue GetRootAsIMaxAlertValue(ByteBuffer _bb, IMaxAlertValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060328F1 RID: 207089 RVA: 0x006D4FC5 File Offset: 0x006D31C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060328F2 RID: 207090 RVA: 0x006D4FD4 File Offset: 0x006D31D4
		public IMaxAlertValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D4E4 RID: 54500
		// (get) Token: 0x060328F3 RID: 207091 RVA: 0x006D4FE4 File Offset: 0x006D31E4
		public EValueChangeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EValueChangeType.AddOrSub;
				}
				return (EValueChangeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060328F4 RID: 207092 RVA: 0x006D5020 File Offset: 0x006D3220
		public static Offset<IMaxAlertValue> CreateIMaxAlertValue(FlatBufferBuilder builder, EValueChangeType Type = EValueChangeType.AddOrSub)
		{
			builder.StartTable(1);
			IMaxAlertValue.AddType(builder, Type);
			return IMaxAlertValue.EndIMaxAlertValue(builder);
		}

		// Token: 0x060328F5 RID: 207093 RVA: 0x006D5036 File Offset: 0x006D3236
		public static void StartIMaxAlertValue(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060328F6 RID: 207094 RVA: 0x006D503F File Offset: 0x006D323F
		public static void AddType(FlatBufferBuilder builder, EValueChangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060328F7 RID: 207095 RVA: 0x006D504A File Offset: 0x006D324A
		public static Offset<IMaxAlertValue> EndIMaxAlertValue(FlatBufferBuilder builder)
		{
			return new Offset<IMaxAlertValue>(builder.EndTable());
		}

		// Token: 0x060328F8 RID: 207096 RVA: 0x006D5058 File Offset: 0x006D3258
		public IMaxAlertValueT UnPack()
		{
			IMaxAlertValueT maxAlertValueT = new IMaxAlertValueT();
			this.UnPackTo(maxAlertValueT);
			return maxAlertValueT;
		}

		// Token: 0x060328F9 RID: 207097 RVA: 0x006D5073 File Offset: 0x006D3273
		public void UnPackTo(IMaxAlertValueT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060328FA RID: 207098 RVA: 0x006D5084 File Offset: 0x006D3284
		public static Offset<IMaxAlertValue> Pack(FlatBufferBuilder builder, IMaxAlertValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMaxAlertValue>);
			}
			return IMaxAlertValue.CreateIMaxAlertValue(builder, _o.Type);
		}

		// Token: 0x04012196 RID: 74134
		private Table __p;
	}
}

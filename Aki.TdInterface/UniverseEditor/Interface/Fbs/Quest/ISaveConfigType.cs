using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200453B RID: 17723
	public struct ISaveConfigType : IFlatbufferObject
	{
		// Token: 0x17007B47 RID: 31559
		// (get) Token: 0x06019AA2 RID: 105122 RVA: 0x003A7AF1 File Offset: 0x003A5CF1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019AA3 RID: 105123 RVA: 0x003A7AFE File Offset: 0x003A5CFE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019AA4 RID: 105124 RVA: 0x003A7B08 File Offset: 0x003A5D08
		public static ISaveConfigType GetRootAsISaveConfigType(ByteBuffer _bb)
		{
			return ISaveConfigType.GetRootAsISaveConfigType(_bb, default(ISaveConfigType));
		}

		// Token: 0x06019AA5 RID: 105125 RVA: 0x003A7B24 File Offset: 0x003A5D24
		public static ISaveConfigType GetRootAsISaveConfigType(ByteBuffer _bb, ISaveConfigType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019AA6 RID: 105126 RVA: 0x003A7B41 File Offset: 0x003A5D41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019AA7 RID: 105127 RVA: 0x003A7B50 File Offset: 0x003A5D50
		public ISaveConfigType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B48 RID: 31560
		// (get) Token: 0x06019AA8 RID: 105128 RVA: 0x003A7B60 File Offset: 0x003A5D60
		public ESaveConfig Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESaveConfig.SaveNew;
				}
				return (ESaveConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019AA9 RID: 105129 RVA: 0x003A7B9C File Offset: 0x003A5D9C
		public static Offset<ISaveConfigType> CreateISaveConfigType(FlatBufferBuilder builder, ESaveConfig Type = ESaveConfig.SaveNew)
		{
			builder.StartTable(1);
			ISaveConfigType.AddType(builder, Type);
			return ISaveConfigType.EndISaveConfigType(builder);
		}

		// Token: 0x06019AAA RID: 105130 RVA: 0x003A7BB2 File Offset: 0x003A5DB2
		public static void StartISaveConfigType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019AAB RID: 105131 RVA: 0x003A7BBB File Offset: 0x003A5DBB
		public static void AddType(FlatBufferBuilder builder, ESaveConfig type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019AAC RID: 105132 RVA: 0x003A7BC6 File Offset: 0x003A5DC6
		public static Offset<ISaveConfigType> EndISaveConfigType(FlatBufferBuilder builder)
		{
			return new Offset<ISaveConfigType>(builder.EndTable());
		}

		// Token: 0x06019AAD RID: 105133 RVA: 0x003A7BD4 File Offset: 0x003A5DD4
		public ISaveConfigTypeT UnPack()
		{
			ISaveConfigTypeT saveConfigTypeT = new ISaveConfigTypeT();
			this.UnPackTo(saveConfigTypeT);
			return saveConfigTypeT;
		}

		// Token: 0x06019AAE RID: 105134 RVA: 0x003A7BEF File Offset: 0x003A5DEF
		public void UnPackTo(ISaveConfigTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019AAF RID: 105135 RVA: 0x003A7C00 File Offset: 0x003A5E00
		public static Offset<ISaveConfigType> Pack(FlatBufferBuilder builder, ISaveConfigTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISaveConfigType>);
			}
			return ISaveConfigType.CreateISaveConfigType(builder, _o.Type);
		}

		// Token: 0x0400C682 RID: 50818
		private Table __p;
	}
}

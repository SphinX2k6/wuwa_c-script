using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004541 RID: 17729
	public struct ISaveNew : IFlatbufferObject
	{
		// Token: 0x17007B4C RID: 31564
		// (get) Token: 0x06019AC2 RID: 105154 RVA: 0x003A7DB4 File Offset: 0x003A5FB4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019AC3 RID: 105155 RVA: 0x003A7DC1 File Offset: 0x003A5FC1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019AC4 RID: 105156 RVA: 0x003A7DC8 File Offset: 0x003A5FC8
		public static ISaveNew GetRootAsISaveNew(ByteBuffer _bb)
		{
			return ISaveNew.GetRootAsISaveNew(_bb, default(ISaveNew));
		}

		// Token: 0x06019AC5 RID: 105157 RVA: 0x003A7DE4 File Offset: 0x003A5FE4
		public static ISaveNew GetRootAsISaveNew(ByteBuffer _bb, ISaveNew obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019AC6 RID: 105158 RVA: 0x003A7E01 File Offset: 0x003A6001
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019AC7 RID: 105159 RVA: 0x003A7E10 File Offset: 0x003A6010
		public ISaveNew __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B4D RID: 31565
		// (get) Token: 0x06019AC8 RID: 105160 RVA: 0x003A7E20 File Offset: 0x003A6020
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

		// Token: 0x06019AC9 RID: 105161 RVA: 0x003A7E5C File Offset: 0x003A605C
		public static Offset<ISaveNew> CreateISaveNew(FlatBufferBuilder builder, ESaveConfig Type = ESaveConfig.SaveNew)
		{
			builder.StartTable(1);
			ISaveNew.AddType(builder, Type);
			return ISaveNew.EndISaveNew(builder);
		}

		// Token: 0x06019ACA RID: 105162 RVA: 0x003A7E72 File Offset: 0x003A6072
		public static void StartISaveNew(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019ACB RID: 105163 RVA: 0x003A7E7B File Offset: 0x003A607B
		public static void AddType(FlatBufferBuilder builder, ESaveConfig type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019ACC RID: 105164 RVA: 0x003A7E86 File Offset: 0x003A6086
		public static Offset<ISaveNew> EndISaveNew(FlatBufferBuilder builder)
		{
			return new Offset<ISaveNew>(builder.EndTable());
		}

		// Token: 0x06019ACD RID: 105165 RVA: 0x003A7E94 File Offset: 0x003A6094
		public ISaveNewT UnPack()
		{
			ISaveNewT saveNewT = new ISaveNewT();
			this.UnPackTo(saveNewT);
			return saveNewT;
		}

		// Token: 0x06019ACE RID: 105166 RVA: 0x003A7EAF File Offset: 0x003A60AF
		public void UnPackTo(ISaveNewT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019ACF RID: 105167 RVA: 0x003A7EC0 File Offset: 0x003A60C0
		public static Offset<ISaveNew> Pack(FlatBufferBuilder builder, ISaveNewT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISaveNew>);
			}
			return ISaveNew.CreateISaveNew(builder, _o.Type);
		}

		// Token: 0x0400C68B RID: 50827
		private Table __p;
	}
}

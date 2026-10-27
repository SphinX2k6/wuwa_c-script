using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AC4 RID: 27332
	public struct IModifyMediaConfig : IFlatbufferObject
	{
		// Token: 0x1700CAC9 RID: 51913
		// (get) Token: 0x0602FE60 RID: 196192 RVA: 0x00683F48 File Offset: 0x00682148
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FE61 RID: 196193 RVA: 0x00683F55 File Offset: 0x00682155
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FE62 RID: 196194 RVA: 0x00683F5C File Offset: 0x0068215C
		public static IModifyMediaConfig GetRootAsIModifyMediaConfig(ByteBuffer _bb)
		{
			return IModifyMediaConfig.GetRootAsIModifyMediaConfig(_bb, default(IModifyMediaConfig));
		}

		// Token: 0x0602FE63 RID: 196195 RVA: 0x00683F78 File Offset: 0x00682178
		public static IModifyMediaConfig GetRootAsIModifyMediaConfig(ByteBuffer _bb, IModifyMediaConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FE64 RID: 196196 RVA: 0x00683F95 File Offset: 0x00682195
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FE65 RID: 196197 RVA: 0x00683FA4 File Offset: 0x006821A4
		public IModifyMediaConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CACA RID: 51914
		// (get) Token: 0x0602FE66 RID: 196198 RVA: 0x00683FB4 File Offset: 0x006821B4
		public EModifyActorMediaType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EModifyActorMediaType.ChangeMediaPlayDA;
				}
				return (EModifyActorMediaType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FE67 RID: 196199 RVA: 0x00683FF0 File Offset: 0x006821F0
		public static Offset<IModifyMediaConfig> CreateIModifyMediaConfig(FlatBufferBuilder builder, EModifyActorMediaType Type = EModifyActorMediaType.ChangeMediaPlayDA)
		{
			builder.StartTable(1);
			IModifyMediaConfig.AddType(builder, Type);
			return IModifyMediaConfig.EndIModifyMediaConfig(builder);
		}

		// Token: 0x0602FE68 RID: 196200 RVA: 0x00684006 File Offset: 0x00682206
		public static void StartIModifyMediaConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FE69 RID: 196201 RVA: 0x0068400F File Offset: 0x0068220F
		public static void AddType(FlatBufferBuilder builder, EModifyActorMediaType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FE6A RID: 196202 RVA: 0x0068401A File Offset: 0x0068221A
		public static Offset<IModifyMediaConfig> EndIModifyMediaConfig(FlatBufferBuilder builder)
		{
			return new Offset<IModifyMediaConfig>(builder.EndTable());
		}

		// Token: 0x0602FE6B RID: 196203 RVA: 0x00684028 File Offset: 0x00682228
		public IModifyMediaConfigT UnPack()
		{
			IModifyMediaConfigT modifyMediaConfigT = new IModifyMediaConfigT();
			this.UnPackTo(modifyMediaConfigT);
			return modifyMediaConfigT;
		}

		// Token: 0x0602FE6C RID: 196204 RVA: 0x00684043 File Offset: 0x00682243
		public void UnPackTo(IModifyMediaConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FE6D RID: 196205 RVA: 0x00684054 File Offset: 0x00682254
		public static Offset<IModifyMediaConfig> Pack(FlatBufferBuilder builder, IModifyMediaConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IModifyMediaConfig>);
			}
			return IModifyMediaConfig.CreateIModifyMediaConfig(builder, _o.Type);
		}

		// Token: 0x04011308 RID: 70408
		private Table __p;
	}
}

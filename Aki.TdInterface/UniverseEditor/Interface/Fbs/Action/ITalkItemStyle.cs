using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072FE RID: 29438
	public struct ITalkItemStyle : IFlatbufferObject
	{
		// Token: 0x1700DDBE RID: 56766
		// (get) Token: 0x06034FDA RID: 217050 RVA: 0x0072E562 File Offset: 0x0072C762
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034FDB RID: 217051 RVA: 0x0072E56F File Offset: 0x0072C76F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034FDC RID: 217052 RVA: 0x0072E578 File Offset: 0x0072C778
		public static ITalkItemStyle GetRootAsITalkItemStyle(ByteBuffer _bb)
		{
			return ITalkItemStyle.GetRootAsITalkItemStyle(_bb, default(ITalkItemStyle));
		}

		// Token: 0x06034FDD RID: 217053 RVA: 0x0072E594 File Offset: 0x0072C794
		public static ITalkItemStyle GetRootAsITalkItemStyle(ByteBuffer _bb, ITalkItemStyle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034FDE RID: 217054 RVA: 0x0072E5B1 File Offset: 0x0072C7B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034FDF RID: 217055 RVA: 0x0072E5C0 File Offset: 0x0072C7C0
		public ITalkItemStyle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DDBF RID: 56767
		// (get) Token: 0x06034FE0 RID: 217056 RVA: 0x0072E5D0 File Offset: 0x0072C7D0
		public ETalkItemStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkItemStyle.InnerVoice;
				}
				return (ETalkItemStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034FE1 RID: 217057 RVA: 0x0072E60C File Offset: 0x0072C80C
		public static Offset<ITalkItemStyle> CreateITalkItemStyle(FlatBufferBuilder builder, ETalkItemStyle Type = ETalkItemStyle.InnerVoice)
		{
			builder.StartTable(1);
			ITalkItemStyle.AddType(builder, Type);
			return ITalkItemStyle.EndITalkItemStyle(builder);
		}

		// Token: 0x06034FE2 RID: 217058 RVA: 0x0072E622 File Offset: 0x0072C822
		public static void StartITalkItemStyle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034FE3 RID: 217059 RVA: 0x0072E62B File Offset: 0x0072C82B
		public static void AddType(FlatBufferBuilder builder, ETalkItemStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034FE4 RID: 217060 RVA: 0x0072E636 File Offset: 0x0072C836
		public static Offset<ITalkItemStyle> EndITalkItemStyle(FlatBufferBuilder builder)
		{
			return new Offset<ITalkItemStyle>(builder.EndTable());
		}

		// Token: 0x06034FE5 RID: 217061 RVA: 0x0072E644 File Offset: 0x0072C844
		public ITalkItemStyleT UnPack()
		{
			ITalkItemStyleT talkItemStyleT = new ITalkItemStyleT();
			this.UnPackTo(talkItemStyleT);
			return talkItemStyleT;
		}

		// Token: 0x06034FE6 RID: 217062 RVA: 0x0072E65F File Offset: 0x0072C85F
		public void UnPackTo(ITalkItemStyleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06034FE7 RID: 217063 RVA: 0x0072E670 File Offset: 0x0072C870
		public static Offset<ITalkItemStyle> Pack(FlatBufferBuilder builder, ITalkItemStyleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkItemStyle>);
			}
			return ITalkItemStyle.CreateITalkItemStyle(builder, _o.Type);
		}

		// Token: 0x04011FDC RID: 73692
		private Table __p;
	}
}

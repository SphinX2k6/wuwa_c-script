using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001253 RID: 4691
	public struct TemplateConfig : IFlatbufferObject
	{
		// Token: 0x17003D4A RID: 15690
		// (get) Token: 0x0600EAB7 RID: 60087 RVA: 0x00355D51 File Offset: 0x00353F51
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EAB8 RID: 60088 RVA: 0x00355D5E File Offset: 0x00353F5E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EAB9 RID: 60089 RVA: 0x00355D68 File Offset: 0x00353F68
		public static TemplateConfig GetRootAsTemplateConfig(ByteBuffer _bb)
		{
			return TemplateConfig.GetRootAsTemplateConfig(_bb, default(TemplateConfig));
		}

		// Token: 0x0600EABA RID: 60090 RVA: 0x00355D84 File Offset: 0x00353F84
		public static TemplateConfig GetRootAsTemplateConfig(ByteBuffer _bb, TemplateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EABB RID: 60091 RVA: 0x00355DA1 File Offset: 0x00353FA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EABC RID: 60092 RVA: 0x00355DB0 File Offset: 0x00353FB0
		public TemplateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D4B RID: 15691
		// (get) Token: 0x0600EABD RID: 60093 RVA: 0x00355DC0 File Offset: 0x00353FC0
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

		// Token: 0x17003D4C RID: 15692
		// (get) Token: 0x0600EABE RID: 60094 RVA: 0x00355DFC File Offset: 0x00353FFC
		public string BlueprintType
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

		// Token: 0x0600EABF RID: 60095 RVA: 0x00355E33 File Offset: 0x00354033
		public Span<byte> GetBlueprintTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600EAC0 RID: 60096 RVA: 0x00355E42 File Offset: 0x00354042
		public byte[] GetBlueprintTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D4D RID: 15693
		// (get) Token: 0x0600EAC1 RID: 60097 RVA: 0x00355E5C File Offset: 0x0035405C
		public string Name
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

		// Token: 0x0600EAC2 RID: 60098 RVA: 0x00355E93 File Offset: 0x00354093
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600EAC3 RID: 60099 RVA: 0x00355EA2 File Offset: 0x003540A2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D4E RID: 15694
		// (get) Token: 0x0600EAC4 RID: 60100 RVA: 0x00355EBC File Offset: 0x003540BC
		public string ComponentsData
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EAC5 RID: 60101 RVA: 0x00355EF4 File Offset: 0x003540F4
		public Span<byte> GetComponentsDataBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600EAC6 RID: 60102 RVA: 0x00355F04 File Offset: 0x00354104
		public byte[] GetComponentsDataArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0400589D RID: 22685
		private Table __p;
	}
}

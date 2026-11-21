using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A56 RID: 27222
	public struct IClientModifyTarget : IFlatbufferObject
	{
		// Token: 0x1700C7FF RID: 51199
		// (get) Token: 0x0602EB2B RID: 191275 RVA: 0x0065D831 File Offset: 0x0065BA31
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EB2C RID: 191276 RVA: 0x0065D83E File Offset: 0x0065BA3E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EB2D RID: 191277 RVA: 0x0065D848 File Offset: 0x0065BA48
		public static IClientModifyTarget GetRootAsIClientModifyTarget(ByteBuffer _bb)
		{
			return IClientModifyTarget.GetRootAsIClientModifyTarget(_bb, default(IClientModifyTarget));
		}

		// Token: 0x0602EB2E RID: 191278 RVA: 0x0065D864 File Offset: 0x0065BA64
		public static IClientModifyTarget GetRootAsIClientModifyTarget(ByteBuffer _bb, IClientModifyTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EB2F RID: 191279 RVA: 0x0065D881 File Offset: 0x0065BA81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EB30 RID: 191280 RVA: 0x0065D890 File Offset: 0x0065BA90
		public IClientModifyTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C800 RID: 51200
		// (get) Token: 0x0602EB31 RID: 191281 RVA: 0x0065D8A0 File Offset: 0x0065BAA0
		public EClientModifyTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientModifyTargetType.Self;
				}
				return (EClientModifyTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EB32 RID: 191282 RVA: 0x0065D8DC File Offset: 0x0065BADC
		public static Offset<IClientModifyTarget> CreateIClientModifyTarget(FlatBufferBuilder builder, EClientModifyTargetType Type = EClientModifyTargetType.Self)
		{
			builder.StartTable(1);
			IClientModifyTarget.AddType(builder, Type);
			return IClientModifyTarget.EndIClientModifyTarget(builder);
		}

		// Token: 0x0602EB33 RID: 191283 RVA: 0x0065D8F2 File Offset: 0x0065BAF2
		public static void StartIClientModifyTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602EB34 RID: 191284 RVA: 0x0065D8FB File Offset: 0x0065BAFB
		public static void AddType(FlatBufferBuilder builder, EClientModifyTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EB35 RID: 191285 RVA: 0x0065D906 File Offset: 0x0065BB06
		public static Offset<IClientModifyTarget> EndIClientModifyTarget(FlatBufferBuilder builder)
		{
			return new Offset<IClientModifyTarget>(builder.EndTable());
		}

		// Token: 0x0602EB36 RID: 191286 RVA: 0x0065D914 File Offset: 0x0065BB14
		public IClientModifyTargetT UnPack()
		{
			IClientModifyTargetT clientModifyTargetT = new IClientModifyTargetT();
			this.UnPackTo(clientModifyTargetT);
			return clientModifyTargetT;
		}

		// Token: 0x0602EB37 RID: 191287 RVA: 0x0065D92F File Offset: 0x0065BB2F
		public void UnPackTo(IClientModifyTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602EB38 RID: 191288 RVA: 0x0065D940 File Offset: 0x0065BB40
		public static Offset<IClientModifyTarget> Pack(FlatBufferBuilder builder, IClientModifyTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientModifyTarget>);
			}
			return IClientModifyTarget.CreateIClientModifyTarget(builder, _o.Type);
		}

		// Token: 0x040117D7 RID: 71639
		private Table __p;
	}
}

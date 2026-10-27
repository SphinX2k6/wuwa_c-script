using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EC2 RID: 20162
	public struct IAttachTiming : IFlatbufferObject
	{
		// Token: 0x170090A6 RID: 37030
		// (get) Token: 0x0601FC1F RID: 130079 RVA: 0x0046BC06 File Offset: 0x00469E06
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FC20 RID: 130080 RVA: 0x0046BC13 File Offset: 0x00469E13
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FC21 RID: 130081 RVA: 0x0046BC1C File Offset: 0x00469E1C
		public static IAttachTiming GetRootAsIAttachTiming(ByteBuffer _bb)
		{
			return IAttachTiming.GetRootAsIAttachTiming(_bb, default(IAttachTiming));
		}

		// Token: 0x0601FC22 RID: 130082 RVA: 0x0046BC38 File Offset: 0x00469E38
		public static IAttachTiming GetRootAsIAttachTiming(ByteBuffer _bb, IAttachTiming obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FC23 RID: 130083 RVA: 0x0046BC55 File Offset: 0x00469E55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FC24 RID: 130084 RVA: 0x0046BC64 File Offset: 0x00469E64
		public IAttachTiming __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170090A7 RID: 37031
		// (get) Token: 0x0601FC25 RID: 130085 RVA: 0x0046BC74 File Offset: 0x00469E74
		public EAttachTimingType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAttachTimingType.Default;
				}
				return (EAttachTimingType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FC26 RID: 130086 RVA: 0x0046BCB0 File Offset: 0x00469EB0
		public static Offset<IAttachTiming> CreateIAttachTiming(FlatBufferBuilder builder, EAttachTimingType Type = EAttachTimingType.Default)
		{
			builder.StartTable(1);
			IAttachTiming.AddType(builder, Type);
			return IAttachTiming.EndIAttachTiming(builder);
		}

		// Token: 0x0601FC27 RID: 130087 RVA: 0x0046BCC6 File Offset: 0x00469EC6
		public static void StartIAttachTiming(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601FC28 RID: 130088 RVA: 0x0046BCCF File Offset: 0x00469ECF
		public static void AddType(FlatBufferBuilder builder, EAttachTimingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FC29 RID: 130089 RVA: 0x0046BCDA File Offset: 0x00469EDA
		public static Offset<IAttachTiming> EndIAttachTiming(FlatBufferBuilder builder)
		{
			return new Offset<IAttachTiming>(builder.EndTable());
		}

		// Token: 0x0601FC2A RID: 130090 RVA: 0x0046BCE8 File Offset: 0x00469EE8
		public IAttachTimingT UnPack()
		{
			IAttachTimingT attachTimingT = new IAttachTimingT();
			this.UnPackTo(attachTimingT);
			return attachTimingT;
		}

		// Token: 0x0601FC2B RID: 130091 RVA: 0x0046BD03 File Offset: 0x00469F03
		public void UnPackTo(IAttachTimingT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601FC2C RID: 130092 RVA: 0x0046BD14 File Offset: 0x00469F14
		public static Offset<IAttachTiming> Pack(FlatBufferBuilder builder, IAttachTimingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAttachTiming>);
			}
			return IAttachTiming.CreateIAttachTiming(builder, _o.Type);
		}

		// Token: 0x0400DCB4 RID: 56500
		private Table __p;
	}
}

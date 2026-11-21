using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007947 RID: 31047
	public struct ISpecificScanEffect : IFlatbufferObject
	{
		// Token: 0x1700E3BE RID: 58302
		// (get) Token: 0x06036ADF RID: 223967 RVA: 0x007510F6 File Offset: 0x0074F2F6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036AE0 RID: 223968 RVA: 0x00751103 File Offset: 0x0074F303
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036AE1 RID: 223969 RVA: 0x0075110C File Offset: 0x0074F30C
		public static ISpecificScanEffect GetRootAsISpecificScanEffect(ByteBuffer _bb)
		{
			return ISpecificScanEffect.GetRootAsISpecificScanEffect(_bb, default(ISpecificScanEffect));
		}

		// Token: 0x06036AE2 RID: 223970 RVA: 0x00751128 File Offset: 0x0074F328
		public static ISpecificScanEffect GetRootAsISpecificScanEffect(ByteBuffer _bb, ISpecificScanEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036AE3 RID: 223971 RVA: 0x00751145 File Offset: 0x0074F345
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036AE4 RID: 223972 RVA: 0x00751154 File Offset: 0x0074F354
		public ISpecificScanEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3BF RID: 58303
		// (get) Token: 0x06036AE5 RID: 223973 RVA: 0x00751164 File Offset: 0x0074F364
		public ESpecificScanType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpecificScanType.None;
				}
				return (ESpecificScanType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036AE6 RID: 223974 RVA: 0x007511A0 File Offset: 0x0074F3A0
		public static Offset<ISpecificScanEffect> CreateISpecificScanEffect(FlatBufferBuilder builder, ESpecificScanType Type = ESpecificScanType.None)
		{
			builder.StartTable(1);
			ISpecificScanEffect.AddType(builder, Type);
			return ISpecificScanEffect.EndISpecificScanEffect(builder);
		}

		// Token: 0x06036AE7 RID: 223975 RVA: 0x007511B6 File Offset: 0x0074F3B6
		public static void StartISpecificScanEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036AE8 RID: 223976 RVA: 0x007511BF File Offset: 0x0074F3BF
		public static void AddType(FlatBufferBuilder builder, ESpecificScanType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036AE9 RID: 223977 RVA: 0x007511CA File Offset: 0x0074F3CA
		public static Offset<ISpecificScanEffect> EndISpecificScanEffect(FlatBufferBuilder builder)
		{
			return new Offset<ISpecificScanEffect>(builder.EndTable());
		}

		// Token: 0x06036AEA RID: 223978 RVA: 0x007511D8 File Offset: 0x0074F3D8
		public ISpecificScanEffectT UnPack()
		{
			ISpecificScanEffectT specificScanEffectT = new ISpecificScanEffectT();
			this.UnPackTo(specificScanEffectT);
			return specificScanEffectT;
		}

		// Token: 0x06036AEB RID: 223979 RVA: 0x007511F3 File Offset: 0x0074F3F3
		public void UnPackTo(ISpecificScanEffectT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036AEC RID: 223980 RVA: 0x00751204 File Offset: 0x0074F404
		public static Offset<ISpecificScanEffect> Pack(FlatBufferBuilder builder, ISpecificScanEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpecificScanEffect>);
			}
			return ISpecificScanEffect.CreateISpecificScanEffect(builder, _o.Type);
		}

		// Token: 0x04012C14 RID: 76820
		private Table __p;
	}
}

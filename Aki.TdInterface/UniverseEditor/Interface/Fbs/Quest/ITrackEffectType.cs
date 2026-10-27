using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041F6 RID: 16886
	public struct ITrackEffectType : IFlatbufferObject
	{
		// Token: 0x170077DB RID: 30683
		// (get) Token: 0x06018E9C RID: 102044 RVA: 0x00395B80 File Offset: 0x00393D80
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018E9D RID: 102045 RVA: 0x00395B8D File Offset: 0x00393D8D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018E9E RID: 102046 RVA: 0x00395B94 File Offset: 0x00393D94
		public static ITrackEffectType GetRootAsITrackEffectType(ByteBuffer _bb)
		{
			return ITrackEffectType.GetRootAsITrackEffectType(_bb, default(ITrackEffectType));
		}

		// Token: 0x06018E9F RID: 102047 RVA: 0x00395BB0 File Offset: 0x00393DB0
		public static ITrackEffectType GetRootAsITrackEffectType(ByteBuffer _bb, ITrackEffectType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018EA0 RID: 102048 RVA: 0x00395BCD File Offset: 0x00393DCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018EA1 RID: 102049 RVA: 0x00395BDC File Offset: 0x00393DDC
		public ITrackEffectType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170077DC RID: 30684
		// (get) Token: 0x06018EA2 RID: 102050 RVA: 0x00395BEC File Offset: 0x00393DEC
		public ETrackEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrackEffectType.AutoChange;
				}
				return (ETrackEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018EA3 RID: 102051 RVA: 0x00395C28 File Offset: 0x00393E28
		public static Offset<ITrackEffectType> CreateITrackEffectType(FlatBufferBuilder builder, ETrackEffectType Type = ETrackEffectType.AutoChange)
		{
			builder.StartTable(1);
			ITrackEffectType.AddType(builder, Type);
			return ITrackEffectType.EndITrackEffectType(builder);
		}

		// Token: 0x06018EA4 RID: 102052 RVA: 0x00395C3E File Offset: 0x00393E3E
		public static void StartITrackEffectType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018EA5 RID: 102053 RVA: 0x00395C47 File Offset: 0x00393E47
		public static void AddType(FlatBufferBuilder builder, ETrackEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018EA6 RID: 102054 RVA: 0x00395C52 File Offset: 0x00393E52
		public static Offset<ITrackEffectType> EndITrackEffectType(FlatBufferBuilder builder)
		{
			return new Offset<ITrackEffectType>(builder.EndTable());
		}

		// Token: 0x06018EA7 RID: 102055 RVA: 0x00395C60 File Offset: 0x00393E60
		public ITrackEffectTypeT UnPack()
		{
			ITrackEffectTypeT trackEffectTypeT = new ITrackEffectTypeT();
			this.UnPackTo(trackEffectTypeT);
			return trackEffectTypeT;
		}

		// Token: 0x06018EA8 RID: 102056 RVA: 0x00395C7B File Offset: 0x00393E7B
		public void UnPackTo(ITrackEffectTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06018EA9 RID: 102057 RVA: 0x00395C8C File Offset: 0x00393E8C
		public static Offset<ITrackEffectType> Pack(FlatBufferBuilder builder, ITrackEffectTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrackEffectType>);
			}
			return ITrackEffectType.CreateITrackEffectType(builder, _o.Type);
		}

		// Token: 0x0400BE54 RID: 48724
		private Table __p;
	}
}

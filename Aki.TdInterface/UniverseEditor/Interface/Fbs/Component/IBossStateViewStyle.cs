using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200544E RID: 21582
	public struct IBossStateViewStyle : IFlatbufferObject
	{
		// Token: 0x17009965 RID: 39269
		// (get) Token: 0x06021DEC RID: 138732 RVA: 0x004AB4ED File Offset: 0x004A96ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021DED RID: 138733 RVA: 0x004AB4FA File Offset: 0x004A96FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021DEE RID: 138734 RVA: 0x004AB504 File Offset: 0x004A9704
		public static IBossStateViewStyle GetRootAsIBossStateViewStyle(ByteBuffer _bb)
		{
			return IBossStateViewStyle.GetRootAsIBossStateViewStyle(_bb, default(IBossStateViewStyle));
		}

		// Token: 0x06021DEF RID: 138735 RVA: 0x004AB520 File Offset: 0x004A9720
		public static IBossStateViewStyle GetRootAsIBossStateViewStyle(ByteBuffer _bb, IBossStateViewStyle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021DF0 RID: 138736 RVA: 0x004AB53D File Offset: 0x004A973D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021DF1 RID: 138737 RVA: 0x004AB54C File Offset: 0x004A974C
		public IBossStateViewStyle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009966 RID: 39270
		// (get) Token: 0x06021DF2 RID: 138738 RVA: 0x004AB55C File Offset: 0x004A975C
		public EBossStateViewStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBossStateViewStyle.DoubleView;
				}
				return (EBossStateViewStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021DF3 RID: 138739 RVA: 0x004AB598 File Offset: 0x004A9798
		public static Offset<IBossStateViewStyle> CreateIBossStateViewStyle(FlatBufferBuilder builder, EBossStateViewStyle Type = EBossStateViewStyle.DoubleView)
		{
			builder.StartTable(1);
			IBossStateViewStyle.AddType(builder, Type);
			return IBossStateViewStyle.EndIBossStateViewStyle(builder);
		}

		// Token: 0x06021DF4 RID: 138740 RVA: 0x004AB5AE File Offset: 0x004A97AE
		public static void StartIBossStateViewStyle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06021DF5 RID: 138741 RVA: 0x004AB5B7 File Offset: 0x004A97B7
		public static void AddType(FlatBufferBuilder builder, EBossStateViewStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021DF6 RID: 138742 RVA: 0x004AB5C2 File Offset: 0x004A97C2
		public static Offset<IBossStateViewStyle> EndIBossStateViewStyle(FlatBufferBuilder builder)
		{
			return new Offset<IBossStateViewStyle>(builder.EndTable());
		}

		// Token: 0x06021DF7 RID: 138743 RVA: 0x004AB5D0 File Offset: 0x004A97D0
		public IBossStateViewStyleT UnPack()
		{
			IBossStateViewStyleT bossStateViewStyleT = new IBossStateViewStyleT();
			this.UnPackTo(bossStateViewStyleT);
			return bossStateViewStyleT;
		}

		// Token: 0x06021DF8 RID: 138744 RVA: 0x004AB5EB File Offset: 0x004A97EB
		public void UnPackTo(IBossStateViewStyleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06021DF9 RID: 138745 RVA: 0x004AB5FC File Offset: 0x004A97FC
		public static Offset<IBossStateViewStyle> Pack(FlatBufferBuilder builder, IBossStateViewStyleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBossStateViewStyle>);
			}
			return IBossStateViewStyle.CreateIBossStateViewStyle(builder, _o.Type);
		}

		// Token: 0x0400E920 RID: 59680
		private Table __p;
	}
}

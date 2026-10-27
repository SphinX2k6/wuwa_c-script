using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200428C RID: 17036
	public struct IWarningPreform : IFlatbufferObject
	{
		// Token: 0x170078FD RID: 30973
		// (get) Token: 0x060193CF RID: 103375 RVA: 0x003A03BE File Offset: 0x0039E5BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060193D0 RID: 103376 RVA: 0x003A03CB File Offset: 0x0039E5CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060193D1 RID: 103377 RVA: 0x003A03D4 File Offset: 0x0039E5D4
		public static IWarningPreform GetRootAsIWarningPreform(ByteBuffer _bb)
		{
			return IWarningPreform.GetRootAsIWarningPreform(_bb, default(IWarningPreform));
		}

		// Token: 0x060193D2 RID: 103378 RVA: 0x003A03F0 File Offset: 0x0039E5F0
		public static IWarningPreform GetRootAsIWarningPreform(ByteBuffer _bb, IWarningPreform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060193D3 RID: 103379 RVA: 0x003A040D File Offset: 0x0039E60D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060193D4 RID: 103380 RVA: 0x003A041C File Offset: 0x0039E61C
		public IWarningPreform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170078FE RID: 30974
		// (get) Token: 0x060193D5 RID: 103381 RVA: 0x003A042C File Offset: 0x0039E62C
		public TWarningPreformConfig TypeType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TWarningPreformConfig.NONE;
				}
				return (TWarningPreformConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060193D6 RID: 103382 RVA: 0x003A0468 File Offset: 0x0039E668
		public TTable? Type<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060193D7 RID: 103383 RVA: 0x003A04AC File Offset: 0x0039E6AC
		public IWarningPreformActivateStateRecordEntity TypeAsIWarningPreformActivateStateRecordEntity()
		{
			return this.Type<IWarningPreformActivateStateRecordEntity>().Value;
		}

		// Token: 0x060193D8 RID: 103384 RVA: 0x003A04C8 File Offset: 0x0039E6C8
		public IWarningPreformFadeInScreen TypeAsIWarningPreformFadeInScreen()
		{
			return this.Type<IWarningPreformFadeInScreen>().Value;
		}

		// Token: 0x060193D9 RID: 103385 RVA: 0x003A04E3 File Offset: 0x0039E6E3
		public static Offset<IWarningPreform> CreateIWarningPreform(FlatBufferBuilder builder, TWarningPreformConfig Type_type = TWarningPreformConfig.NONE, int TypeOffset = 0)
		{
			builder.StartTable(2);
			IWarningPreform.AddType(builder, TypeOffset);
			IWarningPreform.AddTypeType(builder, Type_type);
			return IWarningPreform.EndIWarningPreform(builder);
		}

		// Token: 0x060193DA RID: 103386 RVA: 0x003A0500 File Offset: 0x0039E700
		public static void StartIWarningPreform(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060193DB RID: 103387 RVA: 0x003A0509 File Offset: 0x0039E709
		public static void AddTypeType(FlatBufferBuilder builder, TWarningPreformConfig typeType)
		{
			builder.AddByte(0, (byte)typeType, 0);
		}

		// Token: 0x060193DC RID: 103388 RVA: 0x003A0514 File Offset: 0x0039E714
		public static void AddType(FlatBufferBuilder builder, int typeOffset)
		{
			builder.AddOffset(1, typeOffset, 0);
		}

		// Token: 0x060193DD RID: 103389 RVA: 0x003A051F File Offset: 0x0039E71F
		public static Offset<IWarningPreform> EndIWarningPreform(FlatBufferBuilder builder)
		{
			return new Offset<IWarningPreform>(builder.EndTable());
		}

		// Token: 0x060193DE RID: 103390 RVA: 0x003A052C File Offset: 0x0039E72C
		public IWarningPreformT UnPack()
		{
			IWarningPreformT warningPreformT = new IWarningPreformT();
			this.UnPackTo(warningPreformT);
			return warningPreformT;
		}

		// Token: 0x060193DF RID: 103391 RVA: 0x003A0548 File Offset: 0x0039E748
		public void UnPackTo(IWarningPreformT _o)
		{
			_o.Type = new TWarningPreformConfigUnion();
			_o.Type.Type = this.TypeType;
			TWarningPreformConfig typeType = this.TypeType;
			if (typeType == TWarningPreformConfig.IWarningPreformActivateStateRecordEntity)
			{
				_o.Type.Value = ((this.Type<IWarningPreformActivateStateRecordEntity>() != null) ? this.Type<IWarningPreformActivateStateRecordEntity>().Value.UnPack() : null);
				return;
			}
			if (typeType != TWarningPreformConfig.IWarningPreformFadeInScreen)
			{
				return;
			}
			_o.Type.Value = ((this.Type<IWarningPreformFadeInScreen>() != null) ? this.Type<IWarningPreformFadeInScreen>().Value.UnPack() : null);
		}

		// Token: 0x060193E0 RID: 103392 RVA: 0x003A05EC File Offset: 0x0039E7EC
		public static Offset<IWarningPreform> Pack(FlatBufferBuilder builder, IWarningPreformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWarningPreform>);
			}
			TWarningPreformConfig type_type = (_o.Type == null) ? TWarningPreformConfig.NONE : _o.Type.Type;
			int typeOffset = (_o.Type == null) ? 0 : TWarningPreformConfigUnion.Pack(builder, _o.Type);
			return IWarningPreform.CreateIWarningPreform(builder, type_type, typeOffset);
		}

		// Token: 0x0400BF2D RID: 48941
		private Table __p;
	}
}

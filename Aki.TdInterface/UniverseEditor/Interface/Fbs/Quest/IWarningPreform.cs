using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046E8 RID: 18152
	public struct IWarningPreform : IFlatbufferObject
	{
		// Token: 0x17007F2E RID: 32558
		// (get) Token: 0x0601AB3B RID: 109371 RVA: 0x003CBA96 File Offset: 0x003C9C96
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AB3C RID: 109372 RVA: 0x003CBAA3 File Offset: 0x003C9CA3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AB3D RID: 109373 RVA: 0x003CBAAC File Offset: 0x003C9CAC
		public static IWarningPreform GetRootAsIWarningPreform(ByteBuffer _bb)
		{
			return IWarningPreform.GetRootAsIWarningPreform(_bb, default(IWarningPreform));
		}

		// Token: 0x0601AB3E RID: 109374 RVA: 0x003CBAC8 File Offset: 0x003C9CC8
		public static IWarningPreform GetRootAsIWarningPreform(ByteBuffer _bb, IWarningPreform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AB3F RID: 109375 RVA: 0x003CBAE5 File Offset: 0x003C9CE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AB40 RID: 109376 RVA: 0x003CBAF4 File Offset: 0x003C9CF4
		public IWarningPreform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F2F RID: 32559
		// (get) Token: 0x0601AB41 RID: 109377 RVA: 0x003CBB04 File Offset: 0x003C9D04
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

		// Token: 0x0601AB42 RID: 109378 RVA: 0x003CBB40 File Offset: 0x003C9D40
		public TTable? Type<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601AB43 RID: 109379 RVA: 0x003CBB84 File Offset: 0x003C9D84
		public IWarningPreformActivateStateRecordEntity TypeAsIWarningPreformActivateStateRecordEntity()
		{
			return this.Type<IWarningPreformActivateStateRecordEntity>().Value;
		}

		// Token: 0x0601AB44 RID: 109380 RVA: 0x003CBBA0 File Offset: 0x003C9DA0
		public IWarningPreformFadeInScreen TypeAsIWarningPreformFadeInScreen()
		{
			return this.Type<IWarningPreformFadeInScreen>().Value;
		}

		// Token: 0x0601AB45 RID: 109381 RVA: 0x003CBBBB File Offset: 0x003C9DBB
		public static Offset<IWarningPreform> CreateIWarningPreform(FlatBufferBuilder builder, TWarningPreformConfig Type_type = TWarningPreformConfig.NONE, int TypeOffset = 0)
		{
			builder.StartTable(2);
			IWarningPreform.AddType(builder, TypeOffset);
			IWarningPreform.AddTypeType(builder, Type_type);
			return IWarningPreform.EndIWarningPreform(builder);
		}

		// Token: 0x0601AB46 RID: 109382 RVA: 0x003CBBD8 File Offset: 0x003C9DD8
		public static void StartIWarningPreform(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601AB47 RID: 109383 RVA: 0x003CBBE1 File Offset: 0x003C9DE1
		public static void AddTypeType(FlatBufferBuilder builder, TWarningPreformConfig typeType)
		{
			builder.AddByte(0, (byte)typeType, 0);
		}

		// Token: 0x0601AB48 RID: 109384 RVA: 0x003CBBEC File Offset: 0x003C9DEC
		public static void AddType(FlatBufferBuilder builder, int typeOffset)
		{
			builder.AddOffset(1, typeOffset, 0);
		}

		// Token: 0x0601AB49 RID: 109385 RVA: 0x003CBBF7 File Offset: 0x003C9DF7
		public static Offset<IWarningPreform> EndIWarningPreform(FlatBufferBuilder builder)
		{
			return new Offset<IWarningPreform>(builder.EndTable());
		}

		// Token: 0x0601AB4A RID: 109386 RVA: 0x003CBC04 File Offset: 0x003C9E04
		public IWarningPreformT UnPack()
		{
			IWarningPreformT warningPreformT = new IWarningPreformT();
			this.UnPackTo(warningPreformT);
			return warningPreformT;
		}

		// Token: 0x0601AB4B RID: 109387 RVA: 0x003CBC20 File Offset: 0x003C9E20
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

		// Token: 0x0601AB4C RID: 109388 RVA: 0x003CBCC4 File Offset: 0x003C9EC4
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

		// Token: 0x0400C93A RID: 51514
		private Table __p;
	}
}

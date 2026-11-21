using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200710F RID: 28943
	public struct ILiveLikeParam : IFlatbufferObject
	{
		// Token: 0x1700D3F7 RID: 54263
		// (get) Token: 0x06032461 RID: 205921 RVA: 0x006CC6A5 File Offset: 0x006CA8A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032462 RID: 205922 RVA: 0x006CC6B2 File Offset: 0x006CA8B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032463 RID: 205923 RVA: 0x006CC6BC File Offset: 0x006CA8BC
		public static ILiveLikeParam GetRootAsILiveLikeParam(ByteBuffer _bb)
		{
			return ILiveLikeParam.GetRootAsILiveLikeParam(_bb, default(ILiveLikeParam));
		}

		// Token: 0x06032464 RID: 205924 RVA: 0x006CC6D8 File Offset: 0x006CA8D8
		public static ILiveLikeParam GetRootAsILiveLikeParam(ByteBuffer _bb, ILiveLikeParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032465 RID: 205925 RVA: 0x006CC6F5 File Offset: 0x006CA8F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032466 RID: 205926 RVA: 0x006CC704 File Offset: 0x006CA904
		public ILiveLikeParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3F8 RID: 54264
		// (get) Token: 0x06032467 RID: 205927 RVA: 0x006CC714 File Offset: 0x006CA914
		public ELiveParamType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELiveParamType.Heat;
				}
				return (ELiveParamType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D3F9 RID: 54265
		// (get) Token: 0x06032468 RID: 205928 RVA: 0x006CC750 File Offset: 0x006CA950
		public ELiveLikeState State
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ELiveLikeState.Enable;
				}
				return (ELiveLikeState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032469 RID: 205929 RVA: 0x006CC78C File Offset: 0x006CA98C
		public static Offset<ILiveLikeParam> CreateILiveLikeParam(FlatBufferBuilder builder, ELiveParamType Type = ELiveParamType.Heat, ELiveLikeState State = ELiveLikeState.Enable)
		{
			builder.StartTable(2);
			ILiveLikeParam.AddState(builder, State);
			ILiveLikeParam.AddType(builder, Type);
			return ILiveLikeParam.EndILiveLikeParam(builder);
		}

		// Token: 0x0603246A RID: 205930 RVA: 0x006CC7A9 File Offset: 0x006CA9A9
		public static void StartILiveLikeParam(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603246B RID: 205931 RVA: 0x006CC7B2 File Offset: 0x006CA9B2
		public static void AddType(FlatBufferBuilder builder, ELiveParamType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603246C RID: 205932 RVA: 0x006CC7BD File Offset: 0x006CA9BD
		public static void AddState(FlatBufferBuilder builder, ELiveLikeState state)
		{
			builder.AddByte(1, (byte)state, 0);
		}

		// Token: 0x0603246D RID: 205933 RVA: 0x006CC7C8 File Offset: 0x006CA9C8
		public static Offset<ILiveLikeParam> EndILiveLikeParam(FlatBufferBuilder builder)
		{
			return new Offset<ILiveLikeParam>(builder.EndTable());
		}

		// Token: 0x0603246E RID: 205934 RVA: 0x006CC7D8 File Offset: 0x006CA9D8
		public ILiveLikeParamT UnPack()
		{
			ILiveLikeParamT liveLikeParamT = new ILiveLikeParamT();
			this.UnPackTo(liveLikeParamT);
			return liveLikeParamT;
		}

		// Token: 0x0603246F RID: 205935 RVA: 0x006CC7F3 File Offset: 0x006CA9F3
		public void UnPackTo(ILiveLikeParamT _o)
		{
			_o.Type = this.Type;
			_o.State = this.State;
		}

		// Token: 0x06032470 RID: 205936 RVA: 0x006CC810 File Offset: 0x006CAA10
		public static Offset<ILiveLikeParam> Pack(FlatBufferBuilder builder, ILiveLikeParamT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveLikeParam>);
			}
			return ILiveLikeParam.CreateILiveLikeParam(builder, _o.Type, _o.State);
		}

		// Token: 0x040120EA RID: 73962
		private Table __p;
	}
}

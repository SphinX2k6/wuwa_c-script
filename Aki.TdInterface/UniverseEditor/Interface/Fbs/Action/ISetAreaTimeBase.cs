using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FA2 RID: 28578
	public struct ISetAreaTimeBase : IFlatbufferObject
	{
		// Token: 0x1700D43E RID: 54334
		// (get) Token: 0x06032819 RID: 206873 RVA: 0x006D1112 File Offset: 0x006CF312
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603281A RID: 206874 RVA: 0x006D111F File Offset: 0x006CF31F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603281B RID: 206875 RVA: 0x006D1128 File Offset: 0x006CF328
		public static ISetAreaTimeBase GetRootAsISetAreaTimeBase(ByteBuffer _bb)
		{
			return ISetAreaTimeBase.GetRootAsISetAreaTimeBase(_bb, default(ISetAreaTimeBase));
		}

		// Token: 0x0603281C RID: 206876 RVA: 0x006D1144 File Offset: 0x006CF344
		public static ISetAreaTimeBase GetRootAsISetAreaTimeBase(ByteBuffer _bb, ISetAreaTimeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603281D RID: 206877 RVA: 0x006D1161 File Offset: 0x006CF361
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603281E RID: 206878 RVA: 0x006D1170 File Offset: 0x006CF370
		public ISetAreaTimeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D43F RID: 54335
		// (get) Token: 0x0603281F RID: 206879 RVA: 0x006D1180 File Offset: 0x006CF380
		public ESetAreaTime Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESetAreaTime.Lock;
				}
				return (ESetAreaTime)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032820 RID: 206880 RVA: 0x006D11BC File Offset: 0x006CF3BC
		public static Offset<ISetAreaTimeBase> CreateISetAreaTimeBase(FlatBufferBuilder builder, ESetAreaTime Type = ESetAreaTime.Lock)
		{
			builder.StartTable(1);
			ISetAreaTimeBase.AddType(builder, Type);
			return ISetAreaTimeBase.EndISetAreaTimeBase(builder);
		}

		// Token: 0x06032821 RID: 206881 RVA: 0x006D11D2 File Offset: 0x006CF3D2
		public static void StartISetAreaTimeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032822 RID: 206882 RVA: 0x006D11DB File Offset: 0x006CF3DB
		public static void AddType(FlatBufferBuilder builder, ESetAreaTime type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032823 RID: 206883 RVA: 0x006D11E6 File Offset: 0x006CF3E6
		public static Offset<ISetAreaTimeBase> EndISetAreaTimeBase(FlatBufferBuilder builder)
		{
			return new Offset<ISetAreaTimeBase>(builder.EndTable());
		}

		// Token: 0x06032824 RID: 206884 RVA: 0x006D11F4 File Offset: 0x006CF3F4
		public ISetAreaTimeBaseT UnPack()
		{
			ISetAreaTimeBaseT setAreaTimeBaseT = new ISetAreaTimeBaseT();
			this.UnPackTo(setAreaTimeBaseT);
			return setAreaTimeBaseT;
		}

		// Token: 0x06032825 RID: 206885 RVA: 0x006D120F File Offset: 0x006CF40F
		public void UnPackTo(ISetAreaTimeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032826 RID: 206886 RVA: 0x006D1220 File Offset: 0x006CF420
		public static Offset<ISetAreaTimeBase> Pack(FlatBufferBuilder builder, ISetAreaTimeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetAreaTimeBase>);
			}
			return ISetAreaTimeBase.CreateISetAreaTimeBase(builder, _o.Type);
		}

		// Token: 0x040119A6 RID: 72102
		private Table __p;
	}
}

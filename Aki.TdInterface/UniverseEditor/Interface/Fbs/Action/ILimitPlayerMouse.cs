using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070CA RID: 28874
	public struct ILimitPlayerMouse : IFlatbufferObject
	{
		// Token: 0x1700D37D RID: 54141
		// (get) Token: 0x06032233 RID: 205363 RVA: 0x006C8BF5 File Offset: 0x006C6DF5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032234 RID: 205364 RVA: 0x006C8C02 File Offset: 0x006C6E02
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032235 RID: 205365 RVA: 0x006C8C0C File Offset: 0x006C6E0C
		public static ILimitPlayerMouse GetRootAsILimitPlayerMouse(ByteBuffer _bb)
		{
			return ILimitPlayerMouse.GetRootAsILimitPlayerMouse(_bb, default(ILimitPlayerMouse));
		}

		// Token: 0x06032236 RID: 205366 RVA: 0x006C8C28 File Offset: 0x006C6E28
		public static ILimitPlayerMouse GetRootAsILimitPlayerMouse(ByteBuffer _bb, ILimitPlayerMouse obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032237 RID: 205367 RVA: 0x006C8C45 File Offset: 0x006C6E45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032238 RID: 205368 RVA: 0x006C8C54 File Offset: 0x006C6E54
		public ILimitPlayerMouse __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D37E RID: 54142
		// (get) Token: 0x06032239 RID: 205369 RVA: 0x006C8C64 File Offset: 0x006C6E64
		public ELimitPlayOperation Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELimitPlayOperation.AllowCamera;
				}
				return (ELimitPlayOperation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603223A RID: 205370 RVA: 0x006C8CA0 File Offset: 0x006C6EA0
		public static Offset<ILimitPlayerMouse> CreateILimitPlayerMouse(FlatBufferBuilder builder, ELimitPlayOperation Type = ELimitPlayOperation.AllowCamera)
		{
			builder.StartTable(1);
			ILimitPlayerMouse.AddType(builder, Type);
			return ILimitPlayerMouse.EndILimitPlayerMouse(builder);
		}

		// Token: 0x0603223B RID: 205371 RVA: 0x006C8CB6 File Offset: 0x006C6EB6
		public static void StartILimitPlayerMouse(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603223C RID: 205372 RVA: 0x006C8CBF File Offset: 0x006C6EBF
		public static void AddType(FlatBufferBuilder builder, ELimitPlayOperation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603223D RID: 205373 RVA: 0x006C8CCA File Offset: 0x006C6ECA
		public static Offset<ILimitPlayerMouse> EndILimitPlayerMouse(FlatBufferBuilder builder)
		{
			return new Offset<ILimitPlayerMouse>(builder.EndTable());
		}

		// Token: 0x0603223E RID: 205374 RVA: 0x006C8CD8 File Offset: 0x006C6ED8
		public ILimitPlayerMouseT UnPack()
		{
			ILimitPlayerMouseT limitPlayerMouseT = new ILimitPlayerMouseT();
			this.UnPackTo(limitPlayerMouseT);
			return limitPlayerMouseT;
		}

		// Token: 0x0603223F RID: 205375 RVA: 0x006C8CF3 File Offset: 0x006C6EF3
		public void UnPackTo(ILimitPlayerMouseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032240 RID: 205376 RVA: 0x006C8D04 File Offset: 0x006C6F04
		public static Offset<ILimitPlayerMouse> Pack(FlatBufferBuilder builder, ILimitPlayerMouseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILimitPlayerMouse>);
			}
			return ILimitPlayerMouse.CreateILimitPlayerMouse(builder, _o.Type);
		}

		// Token: 0x04012089 RID: 73865
		private Table __p;
	}
}

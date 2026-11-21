using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070C1 RID: 28865
	public struct ILimitPlayerAction : IFlatbufferObject
	{
		// Token: 0x1700D374 RID: 54132
		// (get) Token: 0x060321FD RID: 205309 RVA: 0x006C8790 File Offset: 0x006C6990
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060321FE RID: 205310 RVA: 0x006C879D File Offset: 0x006C699D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060321FF RID: 205311 RVA: 0x006C87A4 File Offset: 0x006C69A4
		public static ILimitPlayerAction GetRootAsILimitPlayerAction(ByteBuffer _bb)
		{
			return ILimitPlayerAction.GetRootAsILimitPlayerAction(_bb, default(ILimitPlayerAction));
		}

		// Token: 0x06032200 RID: 205312 RVA: 0x006C87C0 File Offset: 0x006C69C0
		public static ILimitPlayerAction GetRootAsILimitPlayerAction(ByteBuffer _bb, ILimitPlayerAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032201 RID: 205313 RVA: 0x006C87DD File Offset: 0x006C69DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032202 RID: 205314 RVA: 0x006C87EC File Offset: 0x006C69EC
		public ILimitPlayerAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D375 RID: 54133
		// (get) Token: 0x06032203 RID: 205315 RVA: 0x006C87FC File Offset: 0x006C69FC
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

		// Token: 0x06032204 RID: 205316 RVA: 0x006C8838 File Offset: 0x006C6A38
		public static Offset<ILimitPlayerAction> CreateILimitPlayerAction(FlatBufferBuilder builder, ELimitPlayOperation Type = ELimitPlayOperation.AllowCamera)
		{
			builder.StartTable(1);
			ILimitPlayerAction.AddType(builder, Type);
			return ILimitPlayerAction.EndILimitPlayerAction(builder);
		}

		// Token: 0x06032205 RID: 205317 RVA: 0x006C884E File Offset: 0x006C6A4E
		public static void StartILimitPlayerAction(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032206 RID: 205318 RVA: 0x006C8857 File Offset: 0x006C6A57
		public static void AddType(FlatBufferBuilder builder, ELimitPlayOperation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032207 RID: 205319 RVA: 0x006C8862 File Offset: 0x006C6A62
		public static Offset<ILimitPlayerAction> EndILimitPlayerAction(FlatBufferBuilder builder)
		{
			return new Offset<ILimitPlayerAction>(builder.EndTable());
		}

		// Token: 0x06032208 RID: 205320 RVA: 0x006C8870 File Offset: 0x006C6A70
		public ILimitPlayerActionT UnPack()
		{
			ILimitPlayerActionT limitPlayerActionT = new ILimitPlayerActionT();
			this.UnPackTo(limitPlayerActionT);
			return limitPlayerActionT;
		}

		// Token: 0x06032209 RID: 205321 RVA: 0x006C888B File Offset: 0x006C6A8B
		public void UnPackTo(ILimitPlayerActionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603220A RID: 205322 RVA: 0x006C889C File Offset: 0x006C6A9C
		public static Offset<ILimitPlayerAction> Pack(FlatBufferBuilder builder, ILimitPlayerActionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILimitPlayerAction>);
			}
			return ILimitPlayerAction.CreateILimitPlayerAction(builder, _o.Type);
		}

		// Token: 0x04012083 RID: 73859
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200705B RID: 28763
	public struct IInteractType : IFlatbufferObject
	{
		// Token: 0x1700D2AA RID: 53930
		// (get) Token: 0x06031DF5 RID: 204277 RVA: 0x006C048E File Offset: 0x006BE68E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031DF6 RID: 204278 RVA: 0x006C049B File Offset: 0x006BE69B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031DF7 RID: 204279 RVA: 0x006C04A4 File Offset: 0x006BE6A4
		public static IInteractType GetRootAsIInteractType(ByteBuffer _bb)
		{
			return IInteractType.GetRootAsIInteractType(_bb, default(IInteractType));
		}

		// Token: 0x06031DF8 RID: 204280 RVA: 0x006C04C0 File Offset: 0x006BE6C0
		public static IInteractType GetRootAsIInteractType(ByteBuffer _bb, IInteractType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031DF9 RID: 204281 RVA: 0x006C04DD File Offset: 0x006BE6DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031DFA RID: 204282 RVA: 0x006C04EC File Offset: 0x006BE6EC
		public IInteractType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D2AB RID: 53931
		// (get) Token: 0x06031DFB RID: 204283 RVA: 0x006C04FC File Offset: 0x006BE6FC
		public EInteractOption Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractOption.Flow;
				}
				return (EInteractOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031DFC RID: 204284 RVA: 0x006C0538 File Offset: 0x006BE738
		public static Offset<IInteractType> CreateIInteractType(FlatBufferBuilder builder, EInteractOption Type = EInteractOption.Flow)
		{
			builder.StartTable(1);
			IInteractType.AddType(builder, Type);
			return IInteractType.EndIInteractType(builder);
		}

		// Token: 0x06031DFD RID: 204285 RVA: 0x006C054E File Offset: 0x006BE74E
		public static void StartIInteractType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031DFE RID: 204286 RVA: 0x006C0557 File Offset: 0x006BE757
		public static void AddType(FlatBufferBuilder builder, EInteractOption type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031DFF RID: 204287 RVA: 0x006C0562 File Offset: 0x006BE762
		public static Offset<IInteractType> EndIInteractType(FlatBufferBuilder builder)
		{
			return new Offset<IInteractType>(builder.EndTable());
		}

		// Token: 0x06031E00 RID: 204288 RVA: 0x006C0570 File Offset: 0x006BE770
		public IInteractTypeT UnPack()
		{
			IInteractTypeT interactTypeT = new IInteractTypeT();
			this.UnPackTo(interactTypeT);
			return interactTypeT;
		}

		// Token: 0x06031E01 RID: 204289 RVA: 0x006C058B File Offset: 0x006BE78B
		public void UnPackTo(IInteractTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031E02 RID: 204290 RVA: 0x006C059C File Offset: 0x006BE79C
		public static Offset<IInteractType> Pack(FlatBufferBuilder builder, IInteractTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractType>);
			}
			return IInteractType.CreateIInteractType(builder, _o.Type);
		}

		// Token: 0x04011FBD RID: 73661
		private Table __p;
	}
}

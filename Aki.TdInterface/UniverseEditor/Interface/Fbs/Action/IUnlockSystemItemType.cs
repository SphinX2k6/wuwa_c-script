using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CD7 RID: 31959
	public struct IUnlockSystemItemType : IFlatbufferObject
	{
		// Token: 0x1700EF30 RID: 61232
		// (get) Token: 0x06039A65 RID: 236133 RVA: 0x007C7119 File Offset: 0x007C5319
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039A66 RID: 236134 RVA: 0x007C7126 File Offset: 0x007C5326
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039A67 RID: 236135 RVA: 0x007C7130 File Offset: 0x007C5330
		public static IUnlockSystemItemType GetRootAsIUnlockSystemItemType(ByteBuffer _bb)
		{
			return IUnlockSystemItemType.GetRootAsIUnlockSystemItemType(_bb, default(IUnlockSystemItemType));
		}

		// Token: 0x06039A68 RID: 236136 RVA: 0x007C714C File Offset: 0x007C534C
		public static IUnlockSystemItemType GetRootAsIUnlockSystemItemType(ByteBuffer _bb, IUnlockSystemItemType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039A69 RID: 236137 RVA: 0x007C7169 File Offset: 0x007C5369
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039A6A RID: 236138 RVA: 0x007C7178 File Offset: 0x007C5378
		public IUnlockSystemItemType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EF31 RID: 61233
		// (get) Token: 0x06039A6B RID: 236139 RVA: 0x007C7188 File Offset: 0x007C5388
		public EUnlockSystemItemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EUnlockSystemItemType.CookSystem;
				}
				return (EUnlockSystemItemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039A6C RID: 236140 RVA: 0x007C71C4 File Offset: 0x007C53C4
		public static Offset<IUnlockSystemItemType> CreateIUnlockSystemItemType(FlatBufferBuilder builder, EUnlockSystemItemType Type = EUnlockSystemItemType.CookSystem)
		{
			builder.StartTable(1);
			IUnlockSystemItemType.AddType(builder, Type);
			return IUnlockSystemItemType.EndIUnlockSystemItemType(builder);
		}

		// Token: 0x06039A6D RID: 236141 RVA: 0x007C71DA File Offset: 0x007C53DA
		public static void StartIUnlockSystemItemType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06039A6E RID: 236142 RVA: 0x007C71E3 File Offset: 0x007C53E3
		public static void AddType(FlatBufferBuilder builder, EUnlockSystemItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039A6F RID: 236143 RVA: 0x007C71EE File Offset: 0x007C53EE
		public static Offset<IUnlockSystemItemType> EndIUnlockSystemItemType(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockSystemItemType>(builder.EndTable());
		}

		// Token: 0x06039A70 RID: 236144 RVA: 0x007C71FC File Offset: 0x007C53FC
		public IUnlockSystemItemTypeT UnPack()
		{
			IUnlockSystemItemTypeT unlockSystemItemTypeT = new IUnlockSystemItemTypeT();
			this.UnPackTo(unlockSystemItemTypeT);
			return unlockSystemItemTypeT;
		}

		// Token: 0x06039A71 RID: 236145 RVA: 0x007C7217 File Offset: 0x007C5417
		public void UnPackTo(IUnlockSystemItemTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06039A72 RID: 236146 RVA: 0x007C7228 File Offset: 0x007C5428
		public static Offset<IUnlockSystemItemType> Pack(FlatBufferBuilder builder, IUnlockSystemItemTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockSystemItemType>);
			}
			return IUnlockSystemItemType.CreateIUnlockSystemItemType(builder, _o.Type);
		}

		// Token: 0x040133D9 RID: 78809
		private Table __p;
	}
}

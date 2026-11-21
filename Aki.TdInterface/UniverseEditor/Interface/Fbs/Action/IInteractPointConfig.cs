using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200704F RID: 28751
	public struct IInteractPointConfig : IFlatbufferObject
	{
		// Token: 0x1700D2A0 RID: 53920
		// (get) Token: 0x06031DB9 RID: 204217 RVA: 0x006BFFA5 File Offset: 0x006BE1A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031DBA RID: 204218 RVA: 0x006BFFB2 File Offset: 0x006BE1B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031DBB RID: 204219 RVA: 0x006BFFBC File Offset: 0x006BE1BC
		public static IInteractPointConfig GetRootAsIInteractPointConfig(ByteBuffer _bb)
		{
			return IInteractPointConfig.GetRootAsIInteractPointConfig(_bb, default(IInteractPointConfig));
		}

		// Token: 0x06031DBC RID: 204220 RVA: 0x006BFFD8 File Offset: 0x006BE1D8
		public static IInteractPointConfig GetRootAsIInteractPointConfig(ByteBuffer _bb, IInteractPointConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031DBD RID: 204221 RVA: 0x006BFFF5 File Offset: 0x006BE1F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031DBE RID: 204222 RVA: 0x006C0004 File Offset: 0x006BE204
		public IInteractPointConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D2A1 RID: 53921
		// (get) Token: 0x06031DBF RID: 204223 RVA: 0x006C0014 File Offset: 0x006BE214
		public EInteractUnlockType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractUnlockType.Sequence;
				}
				return (EInteractUnlockType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031DC0 RID: 204224 RVA: 0x006C0050 File Offset: 0x006BE250
		public static Offset<IInteractPointConfig> CreateIInteractPointConfig(FlatBufferBuilder builder, EInteractUnlockType Type = EInteractUnlockType.Sequence)
		{
			builder.StartTable(1);
			IInteractPointConfig.AddType(builder, Type);
			return IInteractPointConfig.EndIInteractPointConfig(builder);
		}

		// Token: 0x06031DC1 RID: 204225 RVA: 0x006C0066 File Offset: 0x006BE266
		public static void StartIInteractPointConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031DC2 RID: 204226 RVA: 0x006C006F File Offset: 0x006BE26F
		public static void AddType(FlatBufferBuilder builder, EInteractUnlockType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031DC3 RID: 204227 RVA: 0x006C007A File Offset: 0x006BE27A
		public static Offset<IInteractPointConfig> EndIInteractPointConfig(FlatBufferBuilder builder)
		{
			return new Offset<IInteractPointConfig>(builder.EndTable());
		}

		// Token: 0x06031DC4 RID: 204228 RVA: 0x006C0088 File Offset: 0x006BE288
		public IInteractPointConfigT UnPack()
		{
			IInteractPointConfigT interactPointConfigT = new IInteractPointConfigT();
			this.UnPackTo(interactPointConfigT);
			return interactPointConfigT;
		}

		// Token: 0x06031DC5 RID: 204229 RVA: 0x006C00A3 File Offset: 0x006BE2A3
		public void UnPackTo(IInteractPointConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031DC6 RID: 204230 RVA: 0x006C00B4 File Offset: 0x006BE2B4
		public static Offset<IInteractPointConfig> Pack(FlatBufferBuilder builder, IInteractPointConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractPointConfig>);
			}
			return IInteractPointConfig.CreateIInteractPointConfig(builder, _o.Type);
		}

		// Token: 0x04011FAD RID: 73645
		private Table __p;
	}
}

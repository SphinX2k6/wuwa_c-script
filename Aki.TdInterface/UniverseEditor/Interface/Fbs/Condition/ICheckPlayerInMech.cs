using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FC2 RID: 20418
	public struct ICheckPlayerInMech : IFlatbufferObject
	{
		// Token: 0x1700920C RID: 37388
		// (get) Token: 0x0601FD53 RID: 130387 RVA: 0x0046C05A File Offset: 0x0046A25A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FD54 RID: 130388 RVA: 0x0046C067 File Offset: 0x0046A267
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FD55 RID: 130389 RVA: 0x0046C070 File Offset: 0x0046A270
		public static ICheckPlayerInMech GetRootAsICheckPlayerInMech(ByteBuffer _bb)
		{
			return ICheckPlayerInMech.GetRootAsICheckPlayerInMech(_bb, default(ICheckPlayerInMech));
		}

		// Token: 0x0601FD56 RID: 130390 RVA: 0x0046C08C File Offset: 0x0046A28C
		public static ICheckPlayerInMech GetRootAsICheckPlayerInMech(ByteBuffer _bb, ICheckPlayerInMech obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FD57 RID: 130391 RVA: 0x0046C0A9 File Offset: 0x0046A2A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FD58 RID: 130392 RVA: 0x0046C0B8 File Offset: 0x0046A2B8
		public ICheckPlayerInMech __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700920D RID: 37389
		// (get) Token: 0x0601FD59 RID: 130393 RVA: 0x0046C0C8 File Offset: 0x0046A2C8
		public EMechConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMechConditionType.PlayerInMech;
				}
				return (EMechConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700920E RID: 37390
		// (get) Token: 0x0601FD5A RID: 130394 RVA: 0x0046C104 File Offset: 0x0046A304
		public bool IsInMech
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601FD5B RID: 130395 RVA: 0x0046C143 File Offset: 0x0046A343
		public static Offset<ICheckPlayerInMech> CreateICheckPlayerInMech(FlatBufferBuilder builder, EMechConditionType Type = EMechConditionType.PlayerInMech, bool IsInMech = false)
		{
			builder.StartTable(2);
			ICheckPlayerInMech.AddIsInMech(builder, IsInMech);
			ICheckPlayerInMech.AddType(builder, Type);
			return ICheckPlayerInMech.EndICheckPlayerInMech(builder);
		}

		// Token: 0x0601FD5C RID: 130396 RVA: 0x0046C160 File Offset: 0x0046A360
		public static void StartICheckPlayerInMech(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601FD5D RID: 130397 RVA: 0x0046C169 File Offset: 0x0046A369
		public static void AddType(FlatBufferBuilder builder, EMechConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FD5E RID: 130398 RVA: 0x0046C174 File Offset: 0x0046A374
		public static void AddIsInMech(FlatBufferBuilder builder, bool isInMech)
		{
			builder.AddBool(1, isInMech, false);
		}

		// Token: 0x0601FD5F RID: 130399 RVA: 0x0046C17F File Offset: 0x0046A37F
		public static Offset<ICheckPlayerInMech> EndICheckPlayerInMech(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerInMech>(builder.EndTable());
		}

		// Token: 0x0601FD60 RID: 130400 RVA: 0x0046C18C File Offset: 0x0046A38C
		public ICheckPlayerInMechT UnPack()
		{
			ICheckPlayerInMechT checkPlayerInMechT = new ICheckPlayerInMechT();
			this.UnPackTo(checkPlayerInMechT);
			return checkPlayerInMechT;
		}

		// Token: 0x0601FD61 RID: 130401 RVA: 0x0046C1A7 File Offset: 0x0046A3A7
		public void UnPackTo(ICheckPlayerInMechT _o)
		{
			_o.Type = this.Type;
			_o.IsInMech = this.IsInMech;
		}

		// Token: 0x0601FD62 RID: 130402 RVA: 0x0046C1C4 File Offset: 0x0046A3C4
		public static Offset<ICheckPlayerInMech> Pack(FlatBufferBuilder builder, ICheckPlayerInMechT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerInMech>);
			}
			return ICheckPlayerInMech.CreateICheckPlayerInMech(builder, _o.Type, _o.IsInMech);
		}

		// Token: 0x0400DE69 RID: 56937
		private Table __p;
	}
}

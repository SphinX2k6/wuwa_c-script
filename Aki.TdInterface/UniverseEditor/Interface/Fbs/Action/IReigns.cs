using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E1C RID: 28188
	public struct IReigns : IFlatbufferObject
	{
		// Token: 0x1700D21D RID: 53789
		// (get) Token: 0x06031CE9 RID: 204009 RVA: 0x006BE41C File Offset: 0x006BC61C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031CEA RID: 204010 RVA: 0x006BE429 File Offset: 0x006BC629
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031CEB RID: 204011 RVA: 0x006BE430 File Offset: 0x006BC630
		public static IReigns GetRootAsIReigns(ByteBuffer _bb)
		{
			return IReigns.GetRootAsIReigns(_bb, default(IReigns));
		}

		// Token: 0x06031CEC RID: 204012 RVA: 0x006BE44C File Offset: 0x006BC64C
		public static IReigns GetRootAsIReigns(ByteBuffer _bb, IReigns obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031CED RID: 204013 RVA: 0x006BE469 File Offset: 0x006BC669
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031CEE RID: 204014 RVA: 0x006BE478 File Offset: 0x006BC678
		public IReigns __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D21E RID: 53790
		// (get) Token: 0x06031CEF RID: 204015 RVA: 0x006BE488 File Offset: 0x006BC688
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D21F RID: 53791
		// (get) Token: 0x06031CF0 RID: 204016 RVA: 0x006BE4C4 File Offset: 0x006BC6C4
		public int ReignsId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031CF1 RID: 204017 RVA: 0x006BE500 File Offset: 0x006BC700
		public static Offset<IReigns> CreateIReigns(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, int ReignsId = 0)
		{
			builder.StartTable(2);
			IReigns.AddReignsId(builder, ReignsId);
			IReigns.AddType(builder, Type);
			return IReigns.EndIReigns(builder);
		}

		// Token: 0x06031CF2 RID: 204018 RVA: 0x006BE51D File Offset: 0x006BC71D
		public static void StartIReigns(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031CF3 RID: 204019 RVA: 0x006BE526 File Offset: 0x006BC726
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031CF4 RID: 204020 RVA: 0x006BE531 File Offset: 0x006BC731
		public static void AddReignsId(FlatBufferBuilder builder, int reignsId)
		{
			builder.AddInt(1, reignsId, 0);
		}

		// Token: 0x06031CF5 RID: 204021 RVA: 0x006BE53C File Offset: 0x006BC73C
		public static Offset<IReigns> EndIReigns(FlatBufferBuilder builder)
		{
			return new Offset<IReigns>(builder.EndTable());
		}

		// Token: 0x06031CF6 RID: 204022 RVA: 0x006BE54C File Offset: 0x006BC74C
		public IReignsT UnPack()
		{
			IReignsT reignsT = new IReignsT();
			this.UnPackTo(reignsT);
			return reignsT;
		}

		// Token: 0x06031CF7 RID: 204023 RVA: 0x006BE567 File Offset: 0x006BC767
		public void UnPackTo(IReignsT _o)
		{
			_o.Type = this.Type;
			_o.ReignsId = this.ReignsId;
		}

		// Token: 0x06031CF8 RID: 204024 RVA: 0x006BE584 File Offset: 0x006BC784
		public static Offset<IReigns> Pack(FlatBufferBuilder builder, IReignsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReigns>);
			}
			return IReigns.CreateIReigns(builder, _o.Type, _o.ReignsId);
		}

		// Token: 0x04011806 RID: 71686
		private Table __p;
	}
}

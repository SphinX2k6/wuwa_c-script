using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200633D RID: 25405
	public struct ICharacterLookAtData : IFlatbufferObject
	{
		// Token: 0x1700BD98 RID: 48536
		// (get) Token: 0x0602BF20 RID: 180000 RVA: 0x0060A564 File Offset: 0x00608764
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BF21 RID: 180001 RVA: 0x0060A571 File Offset: 0x00608771
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BF22 RID: 180002 RVA: 0x0060A578 File Offset: 0x00608778
		public static ICharacterLookAtData GetRootAsICharacterLookAtData(ByteBuffer _bb)
		{
			return ICharacterLookAtData.GetRootAsICharacterLookAtData(_bb, default(ICharacterLookAtData));
		}

		// Token: 0x0602BF23 RID: 180003 RVA: 0x0060A594 File Offset: 0x00608794
		public static ICharacterLookAtData GetRootAsICharacterLookAtData(ByteBuffer _bb, ICharacterLookAtData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BF24 RID: 180004 RVA: 0x0060A5B1 File Offset: 0x006087B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BF25 RID: 180005 RVA: 0x0060A5C0 File Offset: 0x006087C0
		public ICharacterLookAtData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD99 RID: 48537
		// (get) Token: 0x0602BF26 RID: 180006 RVA: 0x0060A5D0 File Offset: 0x006087D0
		public ECharacterLookAt Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECharacterLookAt.Empty;
				}
				return (ECharacterLookAt)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BF27 RID: 180007 RVA: 0x0060A60C File Offset: 0x0060880C
		public static Offset<ICharacterLookAtData> CreateICharacterLookAtData(FlatBufferBuilder builder, ECharacterLookAt Type = ECharacterLookAt.Empty)
		{
			builder.StartTable(1);
			ICharacterLookAtData.AddType(builder, Type);
			return ICharacterLookAtData.EndICharacterLookAtData(builder);
		}

		// Token: 0x0602BF28 RID: 180008 RVA: 0x0060A622 File Offset: 0x00608822
		public static void StartICharacterLookAtData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602BF29 RID: 180009 RVA: 0x0060A62B File Offset: 0x0060882B
		public static void AddType(FlatBufferBuilder builder, ECharacterLookAt type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BF2A RID: 180010 RVA: 0x0060A636 File Offset: 0x00608836
		public static Offset<ICharacterLookAtData> EndICharacterLookAtData(FlatBufferBuilder builder)
		{
			return new Offset<ICharacterLookAtData>(builder.EndTable());
		}

		// Token: 0x0602BF2B RID: 180011 RVA: 0x0060A644 File Offset: 0x00608844
		public ICharacterLookAtDataT UnPack()
		{
			ICharacterLookAtDataT characterLookAtDataT = new ICharacterLookAtDataT();
			this.UnPackTo(characterLookAtDataT);
			return characterLookAtDataT;
		}

		// Token: 0x0602BF2C RID: 180012 RVA: 0x0060A65F File Offset: 0x0060885F
		public void UnPackTo(ICharacterLookAtDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602BF2D RID: 180013 RVA: 0x0060A670 File Offset: 0x00608870
		public static Offset<ICharacterLookAtData> Pack(FlatBufferBuilder builder, ICharacterLookAtDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICharacterLookAtData>);
			}
			return ICharacterLookAtData.CreateICharacterLookAtData(builder, _o.Type);
		}

		// Token: 0x04010904 RID: 67844
		private Table __p;
	}
}

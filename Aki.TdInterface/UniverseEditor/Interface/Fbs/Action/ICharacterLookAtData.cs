using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069AE RID: 27054
	public struct ICharacterLookAtData : IFlatbufferObject
	{
		// Token: 0x1700C720 RID: 50976
		// (get) Token: 0x0602E68A RID: 190090 RVA: 0x006556B8 File Offset: 0x006538B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E68B RID: 190091 RVA: 0x006556C5 File Offset: 0x006538C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E68C RID: 190092 RVA: 0x006556CC File Offset: 0x006538CC
		public static ICharacterLookAtData GetRootAsICharacterLookAtData(ByteBuffer _bb)
		{
			return ICharacterLookAtData.GetRootAsICharacterLookAtData(_bb, default(ICharacterLookAtData));
		}

		// Token: 0x0602E68D RID: 190093 RVA: 0x006556E8 File Offset: 0x006538E8
		public static ICharacterLookAtData GetRootAsICharacterLookAtData(ByteBuffer _bb, ICharacterLookAtData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E68E RID: 190094 RVA: 0x00655705 File Offset: 0x00653905
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E68F RID: 190095 RVA: 0x00655714 File Offset: 0x00653914
		public ICharacterLookAtData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C721 RID: 50977
		// (get) Token: 0x0602E690 RID: 190096 RVA: 0x00655724 File Offset: 0x00653924
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

		// Token: 0x0602E691 RID: 190097 RVA: 0x00655760 File Offset: 0x00653960
		public static Offset<ICharacterLookAtData> CreateICharacterLookAtData(FlatBufferBuilder builder, ECharacterLookAt Type = ECharacterLookAt.Empty)
		{
			builder.StartTable(1);
			ICharacterLookAtData.AddType(builder, Type);
			return ICharacterLookAtData.EndICharacterLookAtData(builder);
		}

		// Token: 0x0602E692 RID: 190098 RVA: 0x00655776 File Offset: 0x00653976
		public static void StartICharacterLookAtData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E693 RID: 190099 RVA: 0x0065577F File Offset: 0x0065397F
		public static void AddType(FlatBufferBuilder builder, ECharacterLookAt type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E694 RID: 190100 RVA: 0x0065578A File Offset: 0x0065398A
		public static Offset<ICharacterLookAtData> EndICharacterLookAtData(FlatBufferBuilder builder)
		{
			return new Offset<ICharacterLookAtData>(builder.EndTable());
		}

		// Token: 0x0602E695 RID: 190101 RVA: 0x00655798 File Offset: 0x00653998
		public ICharacterLookAtDataT UnPack()
		{
			ICharacterLookAtDataT characterLookAtDataT = new ICharacterLookAtDataT();
			this.UnPackTo(characterLookAtDataT);
			return characterLookAtDataT;
		}

		// Token: 0x0602E696 RID: 190102 RVA: 0x006557B3 File Offset: 0x006539B3
		public void UnPackTo(ICharacterLookAtDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E697 RID: 190103 RVA: 0x006557C4 File Offset: 0x006539C4
		public static Offset<ICharacterLookAtData> Pack(FlatBufferBuilder builder, ICharacterLookAtDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICharacterLookAtData>);
			}
			return ICharacterLookAtData.CreateICharacterLookAtData(builder, _o.Type);
		}

		// Token: 0x04011719 RID: 71449
		private Table __p;
	}
}

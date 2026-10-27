using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200685B RID: 26715
	public struct IFoxPickUp : IFlatbufferObject
	{
		// Token: 0x1700C669 RID: 50793
		// (get) Token: 0x0602E945 RID: 190789 RVA: 0x0065AA40 File Offset: 0x00658C40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E946 RID: 190790 RVA: 0x0065AA4D File Offset: 0x00658C4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E947 RID: 190791 RVA: 0x0065AA54 File Offset: 0x00658C54
		public static IFoxPickUp GetRootAsIFoxPickUp(ByteBuffer _bb)
		{
			return IFoxPickUp.GetRootAsIFoxPickUp(_bb, default(IFoxPickUp));
		}

		// Token: 0x0602E948 RID: 190792 RVA: 0x0065AA70 File Offset: 0x00658C70
		public static IFoxPickUp GetRootAsIFoxPickUp(ByteBuffer _bb, IFoxPickUp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E949 RID: 190793 RVA: 0x0065AA8D File Offset: 0x00658C8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E94A RID: 190794 RVA: 0x0065AA9C File Offset: 0x00658C9C
		public IFoxPickUp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C66A RID: 50794
		// (get) Token: 0x0602E94B RID: 190795 RVA: 0x0065AAAC File Offset: 0x00658CAC
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C66B RID: 50795
		// (get) Token: 0x0602E94C RID: 190796 RVA: 0x0065AAE8 File Offset: 0x00658CE8
		public int DataTableIndex
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

		// Token: 0x1700C66C RID: 50796
		// (get) Token: 0x0602E94D RID: 190797 RVA: 0x0065AB24 File Offset: 0x00658D24
		public bool MouthOpen
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C66D RID: 50797
		// (get) Token: 0x0602E94E RID: 190798 RVA: 0x0065AB64 File Offset: 0x00658D64
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E94F RID: 190799 RVA: 0x0065ABA1 File Offset: 0x00658DA1
		public static Offset<IFoxPickUp> CreateIFoxPickUp(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, int DataTableIndex = 0, bool MouthOpen = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IFoxPickUp.AddDataTableIndex(builder, DataTableIndex);
			IFoxPickUp.AddNullMask(builder, NullMask);
			IFoxPickUp.AddMouthOpen(builder, MouthOpen);
			IFoxPickUp.AddType(builder, Type);
			return IFoxPickUp.EndIFoxPickUp(builder);
		}

		// Token: 0x0602E950 RID: 190800 RVA: 0x0065ABCD File Offset: 0x00658DCD
		public static void StartIFoxPickUp(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602E951 RID: 190801 RVA: 0x0065ABD6 File Offset: 0x00658DD6
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E952 RID: 190802 RVA: 0x0065ABE1 File Offset: 0x00658DE1
		public static void AddDataTableIndex(FlatBufferBuilder builder, int dataTableIndex)
		{
			builder.AddInt(1, dataTableIndex, 0);
		}

		// Token: 0x0602E953 RID: 190803 RVA: 0x0065ABEC File Offset: 0x00658DEC
		public static void AddMouthOpen(FlatBufferBuilder builder, bool mouthOpen)
		{
			builder.AddBool(2, mouthOpen, false);
		}

		// Token: 0x0602E954 RID: 190804 RVA: 0x0065ABF7 File Offset: 0x00658DF7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602E955 RID: 190805 RVA: 0x0065AC02 File Offset: 0x00658E02
		public static Offset<IFoxPickUp> EndIFoxPickUp(FlatBufferBuilder builder)
		{
			return new Offset<IFoxPickUp>(builder.EndTable());
		}

		// Token: 0x0602E956 RID: 190806 RVA: 0x0065AC10 File Offset: 0x00658E10
		public IFoxPickUpT UnPack()
		{
			IFoxPickUpT foxPickUpT = new IFoxPickUpT();
			this.UnPackTo(foxPickUpT);
			return foxPickUpT;
		}

		// Token: 0x0602E957 RID: 190807 RVA: 0x0065AC2B File Offset: 0x00658E2B
		public void UnPackTo(IFoxPickUpT _o)
		{
			_o.Type = this.Type;
			_o.DataTableIndex = this.DataTableIndex;
			_o.MouthOpen = this.MouthOpen;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602E958 RID: 190808 RVA: 0x0065AC60 File Offset: 0x00658E60
		public static Offset<IFoxPickUp> Pack(FlatBufferBuilder builder, IFoxPickUpT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFoxPickUp>);
			}
			return IFoxPickUp.CreateIFoxPickUp(builder, _o.Type, _o.DataTableIndex, _o.MouthOpen, _o.NullMask);
		}

		// Token: 0x04010FA6 RID: 69542
		private Table __p;
	}
}

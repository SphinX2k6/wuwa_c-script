using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EF0 RID: 28400
	public struct IFoxPickUp : IFlatbufferObject
	{
		// Token: 0x1700D03D RID: 53309
		// (get) Token: 0x0603122B RID: 201259 RVA: 0x006A92AC File Offset: 0x006A74AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603122C RID: 201260 RVA: 0x006A92B9 File Offset: 0x006A74B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603122D RID: 201261 RVA: 0x006A92C0 File Offset: 0x006A74C0
		public static IFoxPickUp GetRootAsIFoxPickUp(ByteBuffer _bb)
		{
			return IFoxPickUp.GetRootAsIFoxPickUp(_bb, default(IFoxPickUp));
		}

		// Token: 0x0603122E RID: 201262 RVA: 0x006A92DC File Offset: 0x006A74DC
		public static IFoxPickUp GetRootAsIFoxPickUp(ByteBuffer _bb, IFoxPickUp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603122F RID: 201263 RVA: 0x006A92F9 File Offset: 0x006A74F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031230 RID: 201264 RVA: 0x006A9308 File Offset: 0x006A7508
		public IFoxPickUp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D03E RID: 53310
		// (get) Token: 0x06031231 RID: 201265 RVA: 0x006A9318 File Offset: 0x006A7518
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

		// Token: 0x1700D03F RID: 53311
		// (get) Token: 0x06031232 RID: 201266 RVA: 0x006A9354 File Offset: 0x006A7554
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

		// Token: 0x1700D040 RID: 53312
		// (get) Token: 0x06031233 RID: 201267 RVA: 0x006A9390 File Offset: 0x006A7590
		public bool MouthOpen
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D041 RID: 53313
		// (get) Token: 0x06031234 RID: 201268 RVA: 0x006A93D0 File Offset: 0x006A75D0
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

		// Token: 0x06031235 RID: 201269 RVA: 0x006A940D File Offset: 0x006A760D
		public static Offset<IFoxPickUp> CreateIFoxPickUp(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, int DataTableIndex = 0, bool MouthOpen = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IFoxPickUp.AddDataTableIndex(builder, DataTableIndex);
			IFoxPickUp.AddNullMask(builder, NullMask);
			IFoxPickUp.AddMouthOpen(builder, MouthOpen);
			IFoxPickUp.AddType(builder, Type);
			return IFoxPickUp.EndIFoxPickUp(builder);
		}

		// Token: 0x06031236 RID: 201270 RVA: 0x006A9439 File Offset: 0x006A7639
		public static void StartIFoxPickUp(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06031237 RID: 201271 RVA: 0x006A9442 File Offset: 0x006A7642
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031238 RID: 201272 RVA: 0x006A944D File Offset: 0x006A764D
		public static void AddDataTableIndex(FlatBufferBuilder builder, int dataTableIndex)
		{
			builder.AddInt(1, dataTableIndex, 0);
		}

		// Token: 0x06031239 RID: 201273 RVA: 0x006A9458 File Offset: 0x006A7658
		public static void AddMouthOpen(FlatBufferBuilder builder, bool mouthOpen)
		{
			builder.AddBool(2, mouthOpen, false);
		}

		// Token: 0x0603123A RID: 201274 RVA: 0x006A9463 File Offset: 0x006A7663
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0603123B RID: 201275 RVA: 0x006A946E File Offset: 0x006A766E
		public static Offset<IFoxPickUp> EndIFoxPickUp(FlatBufferBuilder builder)
		{
			return new Offset<IFoxPickUp>(builder.EndTable());
		}

		// Token: 0x0603123C RID: 201276 RVA: 0x006A947C File Offset: 0x006A767C
		public IFoxPickUpT UnPack()
		{
			IFoxPickUpT foxPickUpT = new IFoxPickUpT();
			this.UnPackTo(foxPickUpT);
			return foxPickUpT;
		}

		// Token: 0x0603123D RID: 201277 RVA: 0x006A9497 File Offset: 0x006A7697
		public void UnPackTo(IFoxPickUpT _o)
		{
			_o.Type = this.Type;
			_o.DataTableIndex = this.DataTableIndex;
			_o.MouthOpen = this.MouthOpen;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603123E RID: 201278 RVA: 0x006A94CC File Offset: 0x006A76CC
		public static Offset<IFoxPickUp> Pack(FlatBufferBuilder builder, IFoxPickUpT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFoxPickUp>);
			}
			return IFoxPickUp.CreateIFoxPickUp(builder, _o.Type, _o.DataTableIndex, _o.MouthOpen, _o.NullMask);
		}

		// Token: 0x04011DF0 RID: 73200
		private Table __p;
	}
}

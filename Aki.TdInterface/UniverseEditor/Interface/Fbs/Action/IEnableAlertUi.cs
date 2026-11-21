using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CB6 RID: 27830
	public struct IEnableAlertUi : IFlatbufferObject
	{
		// Token: 0x1700CC26 RID: 52262
		// (get) Token: 0x0602FF6E RID: 196462 RVA: 0x006874E1 File Offset: 0x006856E1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FF6F RID: 196463 RVA: 0x006874EE File Offset: 0x006856EE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FF70 RID: 196464 RVA: 0x006874F8 File Offset: 0x006856F8
		public static IEnableAlertUi GetRootAsIEnableAlertUi(ByteBuffer _bb)
		{
			return IEnableAlertUi.GetRootAsIEnableAlertUi(_bb, default(IEnableAlertUi));
		}

		// Token: 0x0602FF71 RID: 196465 RVA: 0x00687514 File Offset: 0x00685714
		public static IEnableAlertUi GetRootAsIEnableAlertUi(ByteBuffer _bb, IEnableAlertUi obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FF72 RID: 196466 RVA: 0x00687531 File Offset: 0x00685731
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FF73 RID: 196467 RVA: 0x00687540 File Offset: 0x00685740
		public IEnableAlertUi __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC27 RID: 52263
		// (get) Token: 0x0602FF74 RID: 196468 RVA: 0x00687550 File Offset: 0x00685750
		public EAlertSystemOption Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAlertSystemOption.EnableAlertArea;
				}
				return (EAlertSystemOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CC28 RID: 52264
		// (get) Token: 0x0602FF75 RID: 196469 RVA: 0x0068758C File Offset: 0x0068578C
		public int AreaId
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

		// Token: 0x1700CC29 RID: 52265
		// (get) Token: 0x0602FF76 RID: 196470 RVA: 0x006875C8 File Offset: 0x006857C8
		public bool IsEnable
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602FF77 RID: 196471 RVA: 0x00687607 File Offset: 0x00685807
		public static Offset<IEnableAlertUi> CreateIEnableAlertUi(FlatBufferBuilder builder, EAlertSystemOption Type = EAlertSystemOption.EnableAlertArea, int AreaId = 0, bool IsEnable = false)
		{
			builder.StartTable(3);
			IEnableAlertUi.AddAreaId(builder, AreaId);
			IEnableAlertUi.AddIsEnable(builder, IsEnable);
			IEnableAlertUi.AddType(builder, Type);
			return IEnableAlertUi.EndIEnableAlertUi(builder);
		}

		// Token: 0x0602FF78 RID: 196472 RVA: 0x0068762B File Offset: 0x0068582B
		public static void StartIEnableAlertUi(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602FF79 RID: 196473 RVA: 0x00687634 File Offset: 0x00685834
		public static void AddType(FlatBufferBuilder builder, EAlertSystemOption type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FF7A RID: 196474 RVA: 0x0068763F File Offset: 0x0068583F
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(1, areaId, 0);
		}

		// Token: 0x0602FF7B RID: 196475 RVA: 0x0068764A File Offset: 0x0068584A
		public static void AddIsEnable(FlatBufferBuilder builder, bool isEnable)
		{
			builder.AddBool(2, isEnable, false);
		}

		// Token: 0x0602FF7C RID: 196476 RVA: 0x00687655 File Offset: 0x00685855
		public static Offset<IEnableAlertUi> EndIEnableAlertUi(FlatBufferBuilder builder)
		{
			return new Offset<IEnableAlertUi>(builder.EndTable());
		}

		// Token: 0x0602FF7D RID: 196477 RVA: 0x00687664 File Offset: 0x00685864
		public IEnableAlertUiT UnPack()
		{
			IEnableAlertUiT enableAlertUiT = new IEnableAlertUiT();
			this.UnPackTo(enableAlertUiT);
			return enableAlertUiT;
		}

		// Token: 0x0602FF7E RID: 196478 RVA: 0x0068767F File Offset: 0x0068587F
		public void UnPackTo(IEnableAlertUiT _o)
		{
			_o.Type = this.Type;
			_o.AreaId = this.AreaId;
			_o.IsEnable = this.IsEnable;
		}

		// Token: 0x0602FF7F RID: 196479 RVA: 0x006876A8 File Offset: 0x006858A8
		public static Offset<IEnableAlertUi> Pack(FlatBufferBuilder builder, IEnableAlertUiT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableAlertUi>);
			}
			return IEnableAlertUi.CreateIEnableAlertUi(builder, _o.Type, _o.AreaId, _o.IsEnable);
		}

		// Token: 0x04011AFD RID: 72445
		private Table __p;
	}
}

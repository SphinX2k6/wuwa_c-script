using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006645 RID: 26181
	public struct IEnableAlertUi : IFlatbufferObject
	{
		// Token: 0x1700C288 RID: 49800
		// (get) Token: 0x0602D79D RID: 186269 RVA: 0x0063A979 File Offset: 0x00638B79
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D79E RID: 186270 RVA: 0x0063A986 File Offset: 0x00638B86
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D79F RID: 186271 RVA: 0x0063A990 File Offset: 0x00638B90
		public static IEnableAlertUi GetRootAsIEnableAlertUi(ByteBuffer _bb)
		{
			return IEnableAlertUi.GetRootAsIEnableAlertUi(_bb, default(IEnableAlertUi));
		}

		// Token: 0x0602D7A0 RID: 186272 RVA: 0x0063A9AC File Offset: 0x00638BAC
		public static IEnableAlertUi GetRootAsIEnableAlertUi(ByteBuffer _bb, IEnableAlertUi obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D7A1 RID: 186273 RVA: 0x0063A9C9 File Offset: 0x00638BC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D7A2 RID: 186274 RVA: 0x0063A9D8 File Offset: 0x00638BD8
		public IEnableAlertUi __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C289 RID: 49801
		// (get) Token: 0x0602D7A3 RID: 186275 RVA: 0x0063A9E8 File Offset: 0x00638BE8
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

		// Token: 0x1700C28A RID: 49802
		// (get) Token: 0x0602D7A4 RID: 186276 RVA: 0x0063AA24 File Offset: 0x00638C24
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

		// Token: 0x1700C28B RID: 49803
		// (get) Token: 0x0602D7A5 RID: 186277 RVA: 0x0063AA60 File Offset: 0x00638C60
		public bool IsEnable
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602D7A6 RID: 186278 RVA: 0x0063AA9F File Offset: 0x00638C9F
		public static Offset<IEnableAlertUi> CreateIEnableAlertUi(FlatBufferBuilder builder, EAlertSystemOption Type = EAlertSystemOption.EnableAlertArea, int AreaId = 0, bool IsEnable = false)
		{
			builder.StartTable(3);
			IEnableAlertUi.AddAreaId(builder, AreaId);
			IEnableAlertUi.AddIsEnable(builder, IsEnable);
			IEnableAlertUi.AddType(builder, Type);
			return IEnableAlertUi.EndIEnableAlertUi(builder);
		}

		// Token: 0x0602D7A7 RID: 186279 RVA: 0x0063AAC3 File Offset: 0x00638CC3
		public static void StartIEnableAlertUi(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602D7A8 RID: 186280 RVA: 0x0063AACC File Offset: 0x00638CCC
		public static void AddType(FlatBufferBuilder builder, EAlertSystemOption type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D7A9 RID: 186281 RVA: 0x0063AAD7 File Offset: 0x00638CD7
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(1, areaId, 0);
		}

		// Token: 0x0602D7AA RID: 186282 RVA: 0x0063AAE2 File Offset: 0x00638CE2
		public static void AddIsEnable(FlatBufferBuilder builder, bool isEnable)
		{
			builder.AddBool(2, isEnable, false);
		}

		// Token: 0x0602D7AB RID: 186283 RVA: 0x0063AAED File Offset: 0x00638CED
		public static Offset<IEnableAlertUi> EndIEnableAlertUi(FlatBufferBuilder builder)
		{
			return new Offset<IEnableAlertUi>(builder.EndTable());
		}

		// Token: 0x0602D7AC RID: 186284 RVA: 0x0063AAFC File Offset: 0x00638CFC
		public IEnableAlertUiT UnPack()
		{
			IEnableAlertUiT enableAlertUiT = new IEnableAlertUiT();
			this.UnPackTo(enableAlertUiT);
			return enableAlertUiT;
		}

		// Token: 0x0602D7AD RID: 186285 RVA: 0x0063AB17 File Offset: 0x00638D17
		public void UnPackTo(IEnableAlertUiT _o)
		{
			_o.Type = this.Type;
			_o.AreaId = this.AreaId;
			_o.IsEnable = this.IsEnable;
		}

		// Token: 0x0602D7AE RID: 186286 RVA: 0x0063AB40 File Offset: 0x00638D40
		public static Offset<IEnableAlertUi> Pack(FlatBufferBuilder builder, IEnableAlertUiT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableAlertUi>);
			}
			return IEnableAlertUi.CreateIEnableAlertUi(builder, _o.Type, _o.AreaId, _o.IsEnable);
		}

		// Token: 0x04010CE2 RID: 68834
		private Table __p;
	}
}

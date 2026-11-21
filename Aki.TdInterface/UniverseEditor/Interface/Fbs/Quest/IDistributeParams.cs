using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004217 RID: 16919
	public struct IDistributeParams : IFlatbufferObject
	{
		// Token: 0x1700733A RID: 29498
		// (get) Token: 0x060177FC RID: 96252 RVA: 0x0035AE77 File Offset: 0x00359077
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060177FD RID: 96253 RVA: 0x0035AE84 File Offset: 0x00359084
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060177FE RID: 96254 RVA: 0x0035AE8C File Offset: 0x0035908C
		public static IDistributeParams GetRootAsIDistributeParams(ByteBuffer _bb)
		{
			return IDistributeParams.GetRootAsIDistributeParams(_bb, default(IDistributeParams));
		}

		// Token: 0x060177FF RID: 96255 RVA: 0x0035AEA8 File Offset: 0x003590A8
		public static IDistributeParams GetRootAsIDistributeParams(ByteBuffer _bb, IDistributeParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017800 RID: 96256 RVA: 0x0035AEC5 File Offset: 0x003590C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017801 RID: 96257 RVA: 0x0035AED4 File Offset: 0x003590D4
		public IDistributeParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700733B RID: 29499
		// (get) Token: 0x06017802 RID: 96258 RVA: 0x0035AEE4 File Offset: 0x003590E4
		public int InformationViewCheck
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700733C RID: 29500
		// (get) Token: 0x06017803 RID: 96259 RVA: 0x0035AF20 File Offset: 0x00359120
		public IItemConfig? UseItem
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IItemConfig?(default(IItemConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700733D RID: 29501
		// (get) Token: 0x06017804 RID: 96260 RVA: 0x0035AF80 File Offset: 0x00359180
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017805 RID: 96261 RVA: 0x0035AFBC File Offset: 0x003591BC
		public static Offset<IDistributeParams> CreateIDistributeParams(FlatBufferBuilder builder, int InformationViewCheck = 0, Offset<IItemConfig> UseItemOffset = default(Offset<IItemConfig>), byte NullMask = 0)
		{
			builder.StartTable(3);
			IDistributeParams.AddUseItem(builder, UseItemOffset);
			IDistributeParams.AddInformationViewCheck(builder, InformationViewCheck);
			IDistributeParams.AddNullMask(builder, NullMask);
			return IDistributeParams.EndIDistributeParams(builder);
		}

		// Token: 0x06017806 RID: 96262 RVA: 0x0035AFE0 File Offset: 0x003591E0
		public static void StartIDistributeParams(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06017807 RID: 96263 RVA: 0x0035AFE9 File Offset: 0x003591E9
		public static void AddInformationViewCheck(FlatBufferBuilder builder, int informationViewCheck)
		{
			builder.AddInt(0, informationViewCheck, 0);
		}

		// Token: 0x06017808 RID: 96264 RVA: 0x0035AFF4 File Offset: 0x003591F4
		public static void AddUseItem(FlatBufferBuilder builder, Offset<IItemConfig> useItemOffset)
		{
			builder.AddOffset(1, useItemOffset.Value, 0);
		}

		// Token: 0x06017809 RID: 96265 RVA: 0x0035B004 File Offset: 0x00359204
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601780A RID: 96266 RVA: 0x0035B00F File Offset: 0x0035920F
		public static Offset<IDistributeParams> EndIDistributeParams(FlatBufferBuilder builder)
		{
			return new Offset<IDistributeParams>(builder.EndTable());
		}

		// Token: 0x0601780B RID: 96267 RVA: 0x0035B01C File Offset: 0x0035921C
		public IDistributeParamsT UnPack()
		{
			IDistributeParamsT distributeParamsT = new IDistributeParamsT();
			this.UnPackTo(distributeParamsT);
			return distributeParamsT;
		}

		// Token: 0x0601780C RID: 96268 RVA: 0x0035B038 File Offset: 0x00359238
		public void UnPackTo(IDistributeParamsT _o)
		{
			_o.InformationViewCheck = this.InformationViewCheck;
			_o.UseItem = ((this.UseItem != null) ? this.UseItem.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601780D RID: 96269 RVA: 0x0035B08C File Offset: 0x0035928C
		public static Offset<IDistributeParams> Pack(FlatBufferBuilder builder, IDistributeParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDistributeParams>);
			}
			Offset<IItemConfig> useItemOffset = (_o.UseItem == null) ? default(Offset<IItemConfig>) : IItemConfig.Pack(builder, _o.UseItem);
			return IDistributeParams.CreateIDistributeParams(builder, _o.InformationViewCheck, useItemOffset, _o.NullMask);
		}

		// Token: 0x0400C0F7 RID: 49399
		private Table __p;
	}
}

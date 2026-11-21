using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E39 RID: 20025
	public struct ICheckAlertAreaEnabled : IFlatbufferObject
	{
		// Token: 0x17008EA3 RID: 36515
		// (get) Token: 0x0601EF7D RID: 126845 RVA: 0x0045338C File Offset: 0x0045158C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EF7E RID: 126846 RVA: 0x00453399 File Offset: 0x00451599
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EF7F RID: 126847 RVA: 0x004533A0 File Offset: 0x004515A0
		public static ICheckAlertAreaEnabled GetRootAsICheckAlertAreaEnabled(ByteBuffer _bb)
		{
			return ICheckAlertAreaEnabled.GetRootAsICheckAlertAreaEnabled(_bb, default(ICheckAlertAreaEnabled));
		}

		// Token: 0x0601EF80 RID: 126848 RVA: 0x004533BC File Offset: 0x004515BC
		public static ICheckAlertAreaEnabled GetRootAsICheckAlertAreaEnabled(ByteBuffer _bb, ICheckAlertAreaEnabled obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EF81 RID: 126849 RVA: 0x004533D9 File Offset: 0x004515D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EF82 RID: 126850 RVA: 0x004533E8 File Offset: 0x004515E8
		public ICheckAlertAreaEnabled __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008EA4 RID: 36516
		// (get) Token: 0x0601EF83 RID: 126851 RVA: 0x004533F8 File Offset: 0x004515F8
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008EA5 RID: 36517
		// (get) Token: 0x0601EF84 RID: 126852 RVA: 0x00453434 File Offset: 0x00451634
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

		// Token: 0x0601EF85 RID: 126853 RVA: 0x00453470 File Offset: 0x00451670
		public static Offset<ICheckAlertAreaEnabled> CreateICheckAlertAreaEnabled(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int AreaId = 0)
		{
			builder.StartTable(2);
			ICheckAlertAreaEnabled.AddAreaId(builder, AreaId);
			ICheckAlertAreaEnabled.AddType(builder, Type);
			return ICheckAlertAreaEnabled.EndICheckAlertAreaEnabled(builder);
		}

		// Token: 0x0601EF86 RID: 126854 RVA: 0x0045348D File Offset: 0x0045168D
		public static void StartICheckAlertAreaEnabled(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601EF87 RID: 126855 RVA: 0x00453496 File Offset: 0x00451696
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EF88 RID: 126856 RVA: 0x004534A1 File Offset: 0x004516A1
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(1, areaId, 0);
		}

		// Token: 0x0601EF89 RID: 126857 RVA: 0x004534AC File Offset: 0x004516AC
		public static Offset<ICheckAlertAreaEnabled> EndICheckAlertAreaEnabled(FlatBufferBuilder builder)
		{
			return new Offset<ICheckAlertAreaEnabled>(builder.EndTable());
		}

		// Token: 0x0601EF8A RID: 126858 RVA: 0x004534BC File Offset: 0x004516BC
		public ICheckAlertAreaEnabledT UnPack()
		{
			ICheckAlertAreaEnabledT checkAlertAreaEnabledT = new ICheckAlertAreaEnabledT();
			this.UnPackTo(checkAlertAreaEnabledT);
			return checkAlertAreaEnabledT;
		}

		// Token: 0x0601EF8B RID: 126859 RVA: 0x004534D7 File Offset: 0x004516D7
		public void UnPackTo(ICheckAlertAreaEnabledT _o)
		{
			_o.Type = this.Type;
			_o.AreaId = this.AreaId;
		}

		// Token: 0x0601EF8C RID: 126860 RVA: 0x004534F4 File Offset: 0x004516F4
		public static Offset<ICheckAlertAreaEnabled> Pack(FlatBufferBuilder builder, ICheckAlertAreaEnabledT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckAlertAreaEnabled>);
			}
			return ICheckAlertAreaEnabled.CreateICheckAlertAreaEnabled(builder, _o.Type, _o.AreaId);
		}

		// Token: 0x0400DC55 RID: 56405
		private Table __p;
	}
}

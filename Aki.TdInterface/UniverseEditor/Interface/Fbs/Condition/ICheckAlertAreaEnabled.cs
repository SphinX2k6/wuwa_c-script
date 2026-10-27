using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004982 RID: 18818
	public struct ICheckAlertAreaEnabled : IFlatbufferObject
	{
		// Token: 0x170087E8 RID: 34792
		// (get) Token: 0x0601D558 RID: 120152 RVA: 0x00422ED8 File Offset: 0x004210D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D559 RID: 120153 RVA: 0x00422EE5 File Offset: 0x004210E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D55A RID: 120154 RVA: 0x00422EEC File Offset: 0x004210EC
		public static ICheckAlertAreaEnabled GetRootAsICheckAlertAreaEnabled(ByteBuffer _bb)
		{
			return ICheckAlertAreaEnabled.GetRootAsICheckAlertAreaEnabled(_bb, default(ICheckAlertAreaEnabled));
		}

		// Token: 0x0601D55B RID: 120155 RVA: 0x00422F08 File Offset: 0x00421108
		public static ICheckAlertAreaEnabled GetRootAsICheckAlertAreaEnabled(ByteBuffer _bb, ICheckAlertAreaEnabled obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D55C RID: 120156 RVA: 0x00422F25 File Offset: 0x00421125
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D55D RID: 120157 RVA: 0x00422F34 File Offset: 0x00421134
		public ICheckAlertAreaEnabled __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170087E9 RID: 34793
		// (get) Token: 0x0601D55E RID: 120158 RVA: 0x00422F44 File Offset: 0x00421144
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

		// Token: 0x170087EA RID: 34794
		// (get) Token: 0x0601D55F RID: 120159 RVA: 0x00422F80 File Offset: 0x00421180
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

		// Token: 0x0601D560 RID: 120160 RVA: 0x00422FBC File Offset: 0x004211BC
		public static Offset<ICheckAlertAreaEnabled> CreateICheckAlertAreaEnabled(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int AreaId = 0)
		{
			builder.StartTable(2);
			ICheckAlertAreaEnabled.AddAreaId(builder, AreaId);
			ICheckAlertAreaEnabled.AddType(builder, Type);
			return ICheckAlertAreaEnabled.EndICheckAlertAreaEnabled(builder);
		}

		// Token: 0x0601D561 RID: 120161 RVA: 0x00422FD9 File Offset: 0x004211D9
		public static void StartICheckAlertAreaEnabled(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D562 RID: 120162 RVA: 0x00422FE2 File Offset: 0x004211E2
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D563 RID: 120163 RVA: 0x00422FED File Offset: 0x004211ED
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(1, areaId, 0);
		}

		// Token: 0x0601D564 RID: 120164 RVA: 0x00422FF8 File Offset: 0x004211F8
		public static Offset<ICheckAlertAreaEnabled> EndICheckAlertAreaEnabled(FlatBufferBuilder builder)
		{
			return new Offset<ICheckAlertAreaEnabled>(builder.EndTable());
		}

		// Token: 0x0601D565 RID: 120165 RVA: 0x00423008 File Offset: 0x00421208
		public ICheckAlertAreaEnabledT UnPack()
		{
			ICheckAlertAreaEnabledT checkAlertAreaEnabledT = new ICheckAlertAreaEnabledT();
			this.UnPackTo(checkAlertAreaEnabledT);
			return checkAlertAreaEnabledT;
		}

		// Token: 0x0601D566 RID: 120166 RVA: 0x00423023 File Offset: 0x00421223
		public void UnPackTo(ICheckAlertAreaEnabledT _o)
		{
			_o.Type = this.Type;
			_o.AreaId = this.AreaId;
		}

		// Token: 0x0601D567 RID: 120167 RVA: 0x00423040 File Offset: 0x00421240
		public static Offset<ICheckAlertAreaEnabled> Pack(FlatBufferBuilder builder, ICheckAlertAreaEnabledT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckAlertAreaEnabled>);
			}
			return ICheckAlertAreaEnabled.CreateICheckAlertAreaEnabled(builder, _o.Type, _o.AreaId);
		}

		// Token: 0x0400D18D RID: 53645
		private Table __p;
	}
}

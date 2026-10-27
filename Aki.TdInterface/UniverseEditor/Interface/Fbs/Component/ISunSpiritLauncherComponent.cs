using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A0A RID: 23050
	public struct ISunSpiritLauncherComponent : IFlatbufferObject
	{
		// Token: 0x1700AD31 RID: 44337
		// (get) Token: 0x06027208 RID: 160264 RVA: 0x00561F59 File Offset: 0x00560159
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027209 RID: 160265 RVA: 0x00561F66 File Offset: 0x00560166
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602720A RID: 160266 RVA: 0x00561F70 File Offset: 0x00560170
		public static ISunSpiritLauncherComponent GetRootAsISunSpiritLauncherComponent(ByteBuffer _bb)
		{
			return ISunSpiritLauncherComponent.GetRootAsISunSpiritLauncherComponent(_bb, default(ISunSpiritLauncherComponent));
		}

		// Token: 0x0602720B RID: 160267 RVA: 0x00561F8C File Offset: 0x0056018C
		public static ISunSpiritLauncherComponent GetRootAsISunSpiritLauncherComponent(ByteBuffer _bb, ISunSpiritLauncherComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602720C RID: 160268 RVA: 0x00561FA9 File Offset: 0x005601A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602720D RID: 160269 RVA: 0x00561FB8 File Offset: 0x005601B8
		public ISunSpiritLauncherComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AD32 RID: 44338
		// (get) Token: 0x0602720E RID: 160270 RVA: 0x00561FC8 File Offset: 0x005601C8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AD33 RID: 44339
		// (get) Token: 0x0602720F RID: 160271 RVA: 0x00562008 File Offset: 0x00560208
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

		// Token: 0x1700AD34 RID: 44340
		// (get) Token: 0x06027210 RID: 160272 RVA: 0x00562044 File Offset: 0x00560244
		public int NeedsCount
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AD35 RID: 44341
		// (get) Token: 0x06027211 RID: 160273 RVA: 0x00562080 File Offset: 0x00560280
		public int SunSpiritGearId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AD36 RID: 44342
		// (get) Token: 0x06027212 RID: 160274 RVA: 0x005620C0 File Offset: 0x005602C0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027213 RID: 160275 RVA: 0x005620FD File Offset: 0x005602FD
		public static Offset<ISunSpiritLauncherComponent> CreateISunSpiritLauncherComponent(FlatBufferBuilder builder, bool Disabled = false, int AreaId = 0, int NeedsCount = 0, int SunSpiritGearId = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			ISunSpiritLauncherComponent.AddSunSpiritGearId(builder, SunSpiritGearId);
			ISunSpiritLauncherComponent.AddNeedsCount(builder, NeedsCount);
			ISunSpiritLauncherComponent.AddAreaId(builder, AreaId);
			ISunSpiritLauncherComponent.AddNullMask(builder, NullMask);
			ISunSpiritLauncherComponent.AddDisabled(builder, Disabled);
			return ISunSpiritLauncherComponent.EndISunSpiritLauncherComponent(builder);
		}

		// Token: 0x06027214 RID: 160276 RVA: 0x00562131 File Offset: 0x00560331
		public static void StartISunSpiritLauncherComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06027215 RID: 160277 RVA: 0x0056213A File Offset: 0x0056033A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027216 RID: 160278 RVA: 0x00562145 File Offset: 0x00560345
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(1, areaId, 0);
		}

		// Token: 0x06027217 RID: 160279 RVA: 0x00562150 File Offset: 0x00560350
		public static void AddNeedsCount(FlatBufferBuilder builder, int needsCount)
		{
			builder.AddInt(2, needsCount, 0);
		}

		// Token: 0x06027218 RID: 160280 RVA: 0x0056215B File Offset: 0x0056035B
		public static void AddSunSpiritGearId(FlatBufferBuilder builder, int sunSpiritGearId)
		{
			builder.AddInt(3, sunSpiritGearId, 0);
		}

		// Token: 0x06027219 RID: 160281 RVA: 0x00562166 File Offset: 0x00560366
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602721A RID: 160282 RVA: 0x00562171 File Offset: 0x00560371
		public static Offset<ISunSpiritLauncherComponent> EndISunSpiritLauncherComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISunSpiritLauncherComponent>(builder.EndTable());
		}

		// Token: 0x0602721B RID: 160283 RVA: 0x00562180 File Offset: 0x00560380
		public ISunSpiritLauncherComponentT UnPack()
		{
			ISunSpiritLauncherComponentT sunSpiritLauncherComponentT = new ISunSpiritLauncherComponentT();
			this.UnPackTo(sunSpiritLauncherComponentT);
			return sunSpiritLauncherComponentT;
		}

		// Token: 0x0602721C RID: 160284 RVA: 0x0056219B File Offset: 0x0056039B
		public void UnPackTo(ISunSpiritLauncherComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.AreaId = this.AreaId;
			_o.NeedsCount = this.NeedsCount;
			_o.SunSpiritGearId = this.SunSpiritGearId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602721D RID: 160285 RVA: 0x005621DC File Offset: 0x005603DC
		public static Offset<ISunSpiritLauncherComponent> Pack(FlatBufferBuilder builder, ISunSpiritLauncherComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISunSpiritLauncherComponent>);
			}
			return ISunSpiritLauncherComponent.CreateISunSpiritLauncherComponent(builder, _o.Disabled, _o.AreaId, _o.NeedsCount, _o.SunSpiritGearId, _o.NullMask);
		}

		// Token: 0x0400F050 RID: 61520
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B86 RID: 23430
	public struct IWindSourceComponent : IFlatbufferObject
	{
		// Token: 0x1700B10E RID: 45326
		// (get) Token: 0x060281B5 RID: 164277 RVA: 0x00583462 File Offset: 0x00581662
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060281B6 RID: 164278 RVA: 0x0058346F File Offset: 0x0058166F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060281B7 RID: 164279 RVA: 0x00583478 File Offset: 0x00581678
		public static IWindSourceComponent GetRootAsIWindSourceComponent(ByteBuffer _bb)
		{
			return IWindSourceComponent.GetRootAsIWindSourceComponent(_bb, default(IWindSourceComponent));
		}

		// Token: 0x060281B8 RID: 164280 RVA: 0x00583494 File Offset: 0x00581694
		public static IWindSourceComponent GetRootAsIWindSourceComponent(ByteBuffer _bb, IWindSourceComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060281B9 RID: 164281 RVA: 0x005834B1 File Offset: 0x005816B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060281BA RID: 164282 RVA: 0x005834C0 File Offset: 0x005816C0
		public IWindSourceComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B10F RID: 45327
		// (get) Token: 0x060281BB RID: 164283 RVA: 0x005834D0 File Offset: 0x005816D0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B110 RID: 45328
		// (get) Token: 0x060281BC RID: 164284 RVA: 0x00583510 File Offset: 0x00581710
		public IWindDirectional? WindSource
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IWindDirectional?(default(IWindDirectional).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B111 RID: 45329
		// (get) Token: 0x060281BD RID: 164285 RVA: 0x00583570 File Offset: 0x00581770
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

		// Token: 0x060281BE RID: 164286 RVA: 0x005835AC File Offset: 0x005817AC
		public static Offset<IWindSourceComponent> CreateIWindSourceComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IWindDirectional> WindSourceOffset = default(Offset<IWindDirectional>), byte NullMask = 0)
		{
			builder.StartTable(3);
			IWindSourceComponent.AddWindSource(builder, WindSourceOffset);
			IWindSourceComponent.AddNullMask(builder, NullMask);
			IWindSourceComponent.AddDisabled(builder, Disabled);
			return IWindSourceComponent.EndIWindSourceComponent(builder);
		}

		// Token: 0x060281BF RID: 164287 RVA: 0x005835D0 File Offset: 0x005817D0
		public static void StartIWindSourceComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060281C0 RID: 164288 RVA: 0x005835D9 File Offset: 0x005817D9
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060281C1 RID: 164289 RVA: 0x005835E4 File Offset: 0x005817E4
		public static void AddWindSource(FlatBufferBuilder builder, Offset<IWindDirectional> windSourceOffset)
		{
			builder.AddOffset(1, windSourceOffset.Value, 0);
		}

		// Token: 0x060281C2 RID: 164290 RVA: 0x005835F4 File Offset: 0x005817F4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060281C3 RID: 164291 RVA: 0x005835FF File Offset: 0x005817FF
		public static Offset<IWindSourceComponent> EndIWindSourceComponent(FlatBufferBuilder builder)
		{
			return new Offset<IWindSourceComponent>(builder.EndTable());
		}

		// Token: 0x060281C4 RID: 164292 RVA: 0x0058360C File Offset: 0x0058180C
		public IWindSourceComponentT UnPack()
		{
			IWindSourceComponentT windSourceComponentT = new IWindSourceComponentT();
			this.UnPackTo(windSourceComponentT);
			return windSourceComponentT;
		}

		// Token: 0x060281C5 RID: 164293 RVA: 0x00583628 File Offset: 0x00581828
		public void UnPackTo(IWindSourceComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.WindSource = ((this.WindSource != null) ? this.WindSource.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060281C6 RID: 164294 RVA: 0x0058367C File Offset: 0x0058187C
		public static Offset<IWindSourceComponent> Pack(FlatBufferBuilder builder, IWindSourceComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWindSourceComponent>);
			}
			Offset<IWindDirectional> windSourceOffset = (_o.WindSource == null) ? default(Offset<IWindDirectional>) : IWindDirectional.Pack(builder, _o.WindSource);
			return IWindSourceComponent.CreateIWindSourceComponent(builder, _o.Disabled, windSourceOffset, _o.NullMask);
		}

		// Token: 0x0400F2E3 RID: 62179
		private Table __p;
	}
}

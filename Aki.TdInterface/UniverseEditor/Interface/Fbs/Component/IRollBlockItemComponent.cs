using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005888 RID: 22664
	public struct IRollBlockItemComponent : IFlatbufferObject
	{
		// Token: 0x1700A97C RID: 43388
		// (get) Token: 0x060262FC RID: 156412 RVA: 0x0054393A File Offset: 0x00541B3A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060262FD RID: 156413 RVA: 0x00543947 File Offset: 0x00541B47
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060262FE RID: 156414 RVA: 0x00543950 File Offset: 0x00541B50
		public static IRollBlockItemComponent GetRootAsIRollBlockItemComponent(ByteBuffer _bb)
		{
			return IRollBlockItemComponent.GetRootAsIRollBlockItemComponent(_bb, default(IRollBlockItemComponent));
		}

		// Token: 0x060262FF RID: 156415 RVA: 0x0054396C File Offset: 0x00541B6C
		public static IRollBlockItemComponent GetRootAsIRollBlockItemComponent(ByteBuffer _bb, IRollBlockItemComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026300 RID: 156416 RVA: 0x00543989 File Offset: 0x00541B89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026301 RID: 156417 RVA: 0x00543998 File Offset: 0x00541B98
		public IRollBlockItemComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A97D RID: 43389
		// (get) Token: 0x06026302 RID: 156418 RVA: 0x005439A8 File Offset: 0x00541BA8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A97E RID: 43390
		// (get) Token: 0x06026303 RID: 156419 RVA: 0x005439E8 File Offset: 0x00541BE8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026304 RID: 156420 RVA: 0x00543A24 File Offset: 0x00541C24
		public static Offset<IRollBlockItemComponent> CreateIRollBlockItemComponent(FlatBufferBuilder builder, bool Disabled = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IRollBlockItemComponent.AddNullMask(builder, NullMask);
			IRollBlockItemComponent.AddDisabled(builder, Disabled);
			return IRollBlockItemComponent.EndIRollBlockItemComponent(builder);
		}

		// Token: 0x06026305 RID: 156421 RVA: 0x00543A41 File Offset: 0x00541C41
		public static void StartIRollBlockItemComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026306 RID: 156422 RVA: 0x00543A4A File Offset: 0x00541C4A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06026307 RID: 156423 RVA: 0x00543A55 File Offset: 0x00541C55
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x06026308 RID: 156424 RVA: 0x00543A60 File Offset: 0x00541C60
		public static Offset<IRollBlockItemComponent> EndIRollBlockItemComponent(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockItemComponent>(builder.EndTable());
		}

		// Token: 0x06026309 RID: 156425 RVA: 0x00543A70 File Offset: 0x00541C70
		public IRollBlockItemComponentT UnPack()
		{
			IRollBlockItemComponentT rollBlockItemComponentT = new IRollBlockItemComponentT();
			this.UnPackTo(rollBlockItemComponentT);
			return rollBlockItemComponentT;
		}

		// Token: 0x0602630A RID: 156426 RVA: 0x00543A8B File Offset: 0x00541C8B
		public void UnPackTo(IRollBlockItemComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602630B RID: 156427 RVA: 0x00543AA8 File Offset: 0x00541CA8
		public static Offset<IRollBlockItemComponent> Pack(FlatBufferBuilder builder, IRollBlockItemComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockItemComponent>);
			}
			return IRollBlockItemComponent.CreateIRollBlockItemComponent(builder, _o.Disabled, _o.NullMask);
		}

		// Token: 0x0400EDD3 RID: 60883
		private Table __p;
	}
}

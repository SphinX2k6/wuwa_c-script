using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005885 RID: 22661
	public struct IRollBlockFloorComponent : IFlatbufferObject
	{
		// Token: 0x1700A977 RID: 43383
		// (get) Token: 0x060262E6 RID: 156390 RVA: 0x00543736 File Offset: 0x00541936
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060262E7 RID: 156391 RVA: 0x00543743 File Offset: 0x00541943
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060262E8 RID: 156392 RVA: 0x0054374C File Offset: 0x0054194C
		public static IRollBlockFloorComponent GetRootAsIRollBlockFloorComponent(ByteBuffer _bb)
		{
			return IRollBlockFloorComponent.GetRootAsIRollBlockFloorComponent(_bb, default(IRollBlockFloorComponent));
		}

		// Token: 0x060262E9 RID: 156393 RVA: 0x00543768 File Offset: 0x00541968
		public static IRollBlockFloorComponent GetRootAsIRollBlockFloorComponent(ByteBuffer _bb, IRollBlockFloorComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060262EA RID: 156394 RVA: 0x00543785 File Offset: 0x00541985
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060262EB RID: 156395 RVA: 0x00543794 File Offset: 0x00541994
		public IRollBlockFloorComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A978 RID: 43384
		// (get) Token: 0x060262EC RID: 156396 RVA: 0x005437A4 File Offset: 0x005419A4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A979 RID: 43385
		// (get) Token: 0x060262ED RID: 156397 RVA: 0x005437E4 File Offset: 0x005419E4
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

		// Token: 0x060262EE RID: 156398 RVA: 0x00543820 File Offset: 0x00541A20
		public static Offset<IRollBlockFloorComponent> CreateIRollBlockFloorComponent(FlatBufferBuilder builder, bool Disabled = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IRollBlockFloorComponent.AddNullMask(builder, NullMask);
			IRollBlockFloorComponent.AddDisabled(builder, Disabled);
			return IRollBlockFloorComponent.EndIRollBlockFloorComponent(builder);
		}

		// Token: 0x060262EF RID: 156399 RVA: 0x0054383D File Offset: 0x00541A3D
		public static void StartIRollBlockFloorComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060262F0 RID: 156400 RVA: 0x00543846 File Offset: 0x00541A46
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060262F1 RID: 156401 RVA: 0x00543851 File Offset: 0x00541A51
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x060262F2 RID: 156402 RVA: 0x0054385C File Offset: 0x00541A5C
		public static Offset<IRollBlockFloorComponent> EndIRollBlockFloorComponent(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockFloorComponent>(builder.EndTable());
		}

		// Token: 0x060262F3 RID: 156403 RVA: 0x0054386C File Offset: 0x00541A6C
		public IRollBlockFloorComponentT UnPack()
		{
			IRollBlockFloorComponentT rollBlockFloorComponentT = new IRollBlockFloorComponentT();
			this.UnPackTo(rollBlockFloorComponentT);
			return rollBlockFloorComponentT;
		}

		// Token: 0x060262F4 RID: 156404 RVA: 0x00543887 File Offset: 0x00541A87
		public void UnPackTo(IRollBlockFloorComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060262F5 RID: 156405 RVA: 0x005438A4 File Offset: 0x00541AA4
		public static Offset<IRollBlockFloorComponent> Pack(FlatBufferBuilder builder, IRollBlockFloorComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockFloorComponent>);
			}
			return IRollBlockFloorComponent.CreateIRollBlockFloorComponent(builder, _o.Disabled, _o.NullMask);
		}

		// Token: 0x0400EDD0 RID: 60880
		private Table __p;
	}
}

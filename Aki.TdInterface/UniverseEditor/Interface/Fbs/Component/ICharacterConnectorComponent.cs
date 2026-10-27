using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F7C RID: 20348
	public struct ICharacterConnectorComponent : IFlatbufferObject
	{
		// Token: 0x1700930E RID: 37646
		// (get) Token: 0x060204CF RID: 132303 RVA: 0x0047E745 File Offset: 0x0047C945
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060204D0 RID: 132304 RVA: 0x0047E752 File Offset: 0x0047C952
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060204D1 RID: 132305 RVA: 0x0047E75C File Offset: 0x0047C95C
		public static ICharacterConnectorComponent GetRootAsICharacterConnectorComponent(ByteBuffer _bb)
		{
			return ICharacterConnectorComponent.GetRootAsICharacterConnectorComponent(_bb, default(ICharacterConnectorComponent));
		}

		// Token: 0x060204D2 RID: 132306 RVA: 0x0047E778 File Offset: 0x0047C978
		public static ICharacterConnectorComponent GetRootAsICharacterConnectorComponent(ByteBuffer _bb, ICharacterConnectorComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060204D3 RID: 132307 RVA: 0x0047E795 File Offset: 0x0047C995
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060204D4 RID: 132308 RVA: 0x0047E7A4 File Offset: 0x0047C9A4
		public ICharacterConnectorComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700930F RID: 37647
		// (get) Token: 0x060204D5 RID: 132309 RVA: 0x0047E7B4 File Offset: 0x0047C9B4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009310 RID: 37648
		// (get) Token: 0x060204D6 RID: 132310 RVA: 0x0047E7F4 File Offset: 0x0047C9F4
		public ICharacterConnectorRange? LogicType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ICharacterConnectorRange?(default(ICharacterConnectorRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009311 RID: 37649
		// (get) Token: 0x060204D7 RID: 132311 RVA: 0x0047E854 File Offset: 0x0047CA54
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

		// Token: 0x060204D8 RID: 132312 RVA: 0x0047E890 File Offset: 0x0047CA90
		public static Offset<ICharacterConnectorComponent> CreateICharacterConnectorComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<ICharacterConnectorRange> LogicTypeOffset = default(Offset<ICharacterConnectorRange>), byte NullMask = 0)
		{
			builder.StartTable(3);
			ICharacterConnectorComponent.AddLogicType(builder, LogicTypeOffset);
			ICharacterConnectorComponent.AddNullMask(builder, NullMask);
			ICharacterConnectorComponent.AddDisabled(builder, Disabled);
			return ICharacterConnectorComponent.EndICharacterConnectorComponent(builder);
		}

		// Token: 0x060204D9 RID: 132313 RVA: 0x0047E8B4 File Offset: 0x0047CAB4
		public static void StartICharacterConnectorComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060204DA RID: 132314 RVA: 0x0047E8BD File Offset: 0x0047CABD
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060204DB RID: 132315 RVA: 0x0047E8C8 File Offset: 0x0047CAC8
		public static void AddLogicType(FlatBufferBuilder builder, Offset<ICharacterConnectorRange> logicTypeOffset)
		{
			builder.AddOffset(1, logicTypeOffset.Value, 0);
		}

		// Token: 0x060204DC RID: 132316 RVA: 0x0047E8D8 File Offset: 0x0047CAD8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060204DD RID: 132317 RVA: 0x0047E8E3 File Offset: 0x0047CAE3
		public static Offset<ICharacterConnectorComponent> EndICharacterConnectorComponent(FlatBufferBuilder builder)
		{
			return new Offset<ICharacterConnectorComponent>(builder.EndTable());
		}

		// Token: 0x060204DE RID: 132318 RVA: 0x0047E8F0 File Offset: 0x0047CAF0
		public ICharacterConnectorComponentT UnPack()
		{
			ICharacterConnectorComponentT characterConnectorComponentT = new ICharacterConnectorComponentT();
			this.UnPackTo(characterConnectorComponentT);
			return characterConnectorComponentT;
		}

		// Token: 0x060204DF RID: 132319 RVA: 0x0047E90C File Offset: 0x0047CB0C
		public void UnPackTo(ICharacterConnectorComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.LogicType = ((this.LogicType != null) ? this.LogicType.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060204E0 RID: 132320 RVA: 0x0047E960 File Offset: 0x0047CB60
		public static Offset<ICharacterConnectorComponent> Pack(FlatBufferBuilder builder, ICharacterConnectorComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICharacterConnectorComponent>);
			}
			Offset<ICharacterConnectorRange> logicTypeOffset = (_o.LogicType == null) ? default(Offset<ICharacterConnectorRange>) : ICharacterConnectorRange.Pack(builder, _o.LogicType);
			return ICharacterConnectorComponent.CreateICharacterConnectorComponent(builder, _o.Disabled, logicTypeOffset, _o.NullMask);
		}

		// Token: 0x0400DE23 RID: 56867
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ACE RID: 23246
	public struct IMechHookInteractConfig : IFlatbufferObject
	{
		// Token: 0x1700A978 RID: 43384
		// (get) Token: 0x06026233 RID: 156211 RVA: 0x00539A31 File Offset: 0x00537C31
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026234 RID: 156212 RVA: 0x00539A3E File Offset: 0x00537C3E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026235 RID: 156213 RVA: 0x00539A48 File Offset: 0x00537C48
		public static IMechHookInteractConfig GetRootAsIMechHookInteractConfig(ByteBuffer _bb)
		{
			return IMechHookInteractConfig.GetRootAsIMechHookInteractConfig(_bb, default(IMechHookInteractConfig));
		}

		// Token: 0x06026236 RID: 156214 RVA: 0x00539A64 File Offset: 0x00537C64
		public static IMechHookInteractConfig GetRootAsIMechHookInteractConfig(ByteBuffer _bb, IMechHookInteractConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026237 RID: 156215 RVA: 0x00539A81 File Offset: 0x00537C81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026238 RID: 156216 RVA: 0x00539A90 File Offset: 0x00537C90
		public IMechHookInteractConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A979 RID: 43385
		// (get) Token: 0x06026239 RID: 156217 RVA: 0x00539AA0 File Offset: 0x00537CA0
		public TMechHookInteractType InteractTypeType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TMechHookInteractType.NONE;
				}
				return (TMechHookInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602623A RID: 156218 RVA: 0x00539ADC File Offset: 0x00537CDC
		public TTable? InteractType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602623B RID: 156219 RVA: 0x00539B20 File Offset: 0x00537D20
		public IMechBurrowHookInteract InteractTypeAsIMechBurrowHookInteract()
		{
			return this.InteractType<IMechBurrowHookInteract>().Value;
		}

		// Token: 0x0602623C RID: 156220 RVA: 0x00539B3C File Offset: 0x00537D3C
		public IMechFixedPointHookInteract InteractTypeAsIMechFixedPointHookInteract()
		{
			return this.InteractType<IMechFixedPointHookInteract>().Value;
		}

		// Token: 0x0602623D RID: 156221 RVA: 0x00539B58 File Offset: 0x00537D58
		public IMechPullHookInteract InteractTypeAsIMechPullHookInteract()
		{
			return this.InteractType<IMechPullHookInteract>().Value;
		}

		// Token: 0x1700A97A RID: 43386
		// (get) Token: 0x0602623E RID: 156222 RVA: 0x00539B74 File Offset: 0x00537D74
		public IMechHookAcceleration? MechHookAcceleration
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IMechHookAcceleration?(default(IMechHookAcceleration).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A97B RID: 43387
		// (get) Token: 0x0602623F RID: 156223 RVA: 0x00539BD4 File Offset: 0x00537DD4
		public IInteractSectorRange? SectorRange
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IInteractSectorRange?(default(IInteractSectorRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A97C RID: 43388
		// (get) Token: 0x06026240 RID: 156224 RVA: 0x00539C34 File Offset: 0x00537E34
		public float Radius
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A97D RID: 43389
		// (get) Token: 0x06026241 RID: 156225 RVA: 0x00539C78 File Offset: 0x00537E78
		public float NonInteractiveInnerRadius
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A97E RID: 43390
		// (get) Token: 0x06026242 RID: 156226 RVA: 0x00539CBC File Offset: 0x00537EBC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026243 RID: 156227 RVA: 0x00539CFC File Offset: 0x00537EFC
		public static Offset<IMechHookInteractConfig> CreateIMechHookInteractConfig(FlatBufferBuilder builder, TMechHookInteractType InteractType_type = TMechHookInteractType.NONE, int InteractTypeOffset = 0, Offset<IMechHookAcceleration> MechHookAccelerationOffset = default(Offset<IMechHookAcceleration>), Offset<IInteractSectorRange> SectorRangeOffset = default(Offset<IInteractSectorRange>), float Radius = 0f, float NonInteractiveInnerRadius = 0f, byte NullMask = 0)
		{
			builder.StartTable(7);
			IMechHookInteractConfig.AddNonInteractiveInnerRadius(builder, NonInteractiveInnerRadius);
			IMechHookInteractConfig.AddRadius(builder, Radius);
			IMechHookInteractConfig.AddSectorRange(builder, SectorRangeOffset);
			IMechHookInteractConfig.AddMechHookAcceleration(builder, MechHookAccelerationOffset);
			IMechHookInteractConfig.AddInteractType(builder, InteractTypeOffset);
			IMechHookInteractConfig.AddNullMask(builder, NullMask);
			IMechHookInteractConfig.AddInteractTypeType(builder, InteractType_type);
			return IMechHookInteractConfig.EndIMechHookInteractConfig(builder);
		}

		// Token: 0x06026244 RID: 156228 RVA: 0x00539D4B File Offset: 0x00537F4B
		public static void StartIMechHookInteractConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06026245 RID: 156229 RVA: 0x00539D54 File Offset: 0x00537F54
		public static void AddInteractTypeType(FlatBufferBuilder builder, TMechHookInteractType interactTypeType)
		{
			builder.AddByte(0, (byte)interactTypeType, 0);
		}

		// Token: 0x06026246 RID: 156230 RVA: 0x00539D5F File Offset: 0x00537F5F
		public static void AddInteractType(FlatBufferBuilder builder, int interactTypeOffset)
		{
			builder.AddOffset(1, interactTypeOffset, 0);
		}

		// Token: 0x06026247 RID: 156231 RVA: 0x00539D6A File Offset: 0x00537F6A
		public static void AddMechHookAcceleration(FlatBufferBuilder builder, Offset<IMechHookAcceleration> mechHookAccelerationOffset)
		{
			builder.AddOffset(2, mechHookAccelerationOffset.Value, 0);
		}

		// Token: 0x06026248 RID: 156232 RVA: 0x00539D7A File Offset: 0x00537F7A
		public static void AddSectorRange(FlatBufferBuilder builder, Offset<IInteractSectorRange> sectorRangeOffset)
		{
			builder.AddOffset(3, sectorRangeOffset.Value, 0);
		}

		// Token: 0x06026249 RID: 156233 RVA: 0x00539D8A File Offset: 0x00537F8A
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(4, radius, 0.0);
		}

		// Token: 0x0602624A RID: 156234 RVA: 0x00539D9D File Offset: 0x00537F9D
		public static void AddNonInteractiveInnerRadius(FlatBufferBuilder builder, float nonInteractiveInnerRadius)
		{
			builder.AddFloat(5, nonInteractiveInnerRadius, 0.0);
		}

		// Token: 0x0602624B RID: 156235 RVA: 0x00539DB0 File Offset: 0x00537FB0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602624C RID: 156236 RVA: 0x00539DBB File Offset: 0x00537FBB
		public static Offset<IMechHookInteractConfig> EndIMechHookInteractConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMechHookInteractConfig>(builder.EndTable());
		}

		// Token: 0x0602624D RID: 156237 RVA: 0x00539DC8 File Offset: 0x00537FC8
		public IMechHookInteractConfigT UnPack()
		{
			IMechHookInteractConfigT mechHookInteractConfigT = new IMechHookInteractConfigT();
			this.UnPackTo(mechHookInteractConfigT);
			return mechHookInteractConfigT;
		}

		// Token: 0x0602624E RID: 156238 RVA: 0x00539DE4 File Offset: 0x00537FE4
		public void UnPackTo(IMechHookInteractConfigT _o)
		{
			_o.InteractType = new TMechHookInteractTypeUnion();
			_o.InteractType.Type = this.InteractTypeType;
			switch (this.InteractTypeType)
			{
			case TMechHookInteractType.IMechBurrowHookInteract:
				_o.InteractType.Value = ((this.InteractType<IMechBurrowHookInteract>() != null) ? this.InteractType<IMechBurrowHookInteract>().Value.UnPack() : null);
				break;
			case TMechHookInteractType.IMechFixedPointHookInteract:
				_o.InteractType.Value = ((this.InteractType<IMechFixedPointHookInteract>() != null) ? this.InteractType<IMechFixedPointHookInteract>().Value.UnPack() : null);
				break;
			case TMechHookInteractType.IMechPullHookInteract:
				_o.InteractType.Value = ((this.InteractType<IMechPullHookInteract>() != null) ? this.InteractType<IMechPullHookInteract>().Value.UnPack() : null);
				break;
			}
			_o.MechHookAcceleration = ((this.MechHookAcceleration != null) ? this.MechHookAcceleration.Value.UnPack() : null);
			_o.SectorRange = ((this.SectorRange != null) ? this.SectorRange.Value.UnPack() : null);
			_o.Radius = this.Radius;
			_o.NonInteractiveInnerRadius = this.NonInteractiveInnerRadius;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602624F RID: 156239 RVA: 0x00539F5C File Offset: 0x0053815C
		public static Offset<IMechHookInteractConfig> Pack(FlatBufferBuilder builder, IMechHookInteractConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechHookInteractConfig>);
			}
			TMechHookInteractType interactType_type = (_o.InteractType == null) ? TMechHookInteractType.NONE : _o.InteractType.Type;
			int interactTypeOffset = (_o.InteractType == null) ? 0 : TMechHookInteractTypeUnion.Pack(builder, _o.InteractType);
			Offset<IMechHookAcceleration> mechHookAccelerationOffset = (_o.MechHookAcceleration == null) ? default(Offset<IMechHookAcceleration>) : IMechHookAcceleration.Pack(builder, _o.MechHookAcceleration);
			Offset<IInteractSectorRange> sectorRangeOffset = (_o.SectorRange == null) ? default(Offset<IInteractSectorRange>) : IInteractSectorRange.Pack(builder, _o.SectorRange);
			return IMechHookInteractConfig.CreateIMechHookInteractConfig(builder, interactType_type, interactTypeOffset, mechHookAccelerationOffset, sectorRangeOffset, _o.Radius, _o.NonInteractiveInnerRadius, _o.NullMask);
		}

		// Token: 0x0400F482 RID: 62594
		private Table __p;
	}
}

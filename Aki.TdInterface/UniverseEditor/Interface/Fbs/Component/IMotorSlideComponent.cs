using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055C9 RID: 21961
	public struct IMotorSlideComponent : IFlatbufferObject
	{
		// Token: 0x1700A259 RID: 41561
		// (get) Token: 0x06024647 RID: 149063 RVA: 0x005061CF File Offset: 0x005043CF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024648 RID: 149064 RVA: 0x005061DC File Offset: 0x005043DC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024649 RID: 149065 RVA: 0x005061E4 File Offset: 0x005043E4
		public static IMotorSlideComponent GetRootAsIMotorSlideComponent(ByteBuffer _bb)
		{
			return IMotorSlideComponent.GetRootAsIMotorSlideComponent(_bb, default(IMotorSlideComponent));
		}

		// Token: 0x0602464A RID: 149066 RVA: 0x00506200 File Offset: 0x00504400
		public static IMotorSlideComponent GetRootAsIMotorSlideComponent(ByteBuffer _bb, IMotorSlideComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602464B RID: 149067 RVA: 0x0050621D File Offset: 0x0050441D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602464C RID: 149068 RVA: 0x0050622C File Offset: 0x0050442C
		public IMotorSlideComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A25A RID: 41562
		// (get) Token: 0x0602464D RID: 149069 RVA: 0x0050623C File Offset: 0x0050443C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A25B RID: 41563
		// (get) Token: 0x0602464E RID: 149070 RVA: 0x0050627C File Offset: 0x0050447C
		public IConditionGroup? EnableConditions
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A25C RID: 41564
		// (get) Token: 0x0602464F RID: 149071 RVA: 0x005062DC File Offset: 0x005044DC
		public float MaxAngle
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A25D RID: 41565
		// (get) Token: 0x06024650 RID: 149072 RVA: 0x0050631C File Offset: 0x0050451C
		public string MotorSlideDtName
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024651 RID: 149073 RVA: 0x00506354 File Offset: 0x00504554
		public Span<byte> GetMotorSlideDtNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06024652 RID: 149074 RVA: 0x00506364 File Offset: 0x00504564
		public byte[] GetMotorSlideDtNameArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700A25E RID: 41566
		// (get) Token: 0x06024653 RID: 149075 RVA: 0x00506374 File Offset: 0x00504574
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

		// Token: 0x06024654 RID: 149076 RVA: 0x005063B1 File Offset: 0x005045B1
		public static Offset<IMotorSlideComponent> CreateIMotorSlideComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IConditionGroup> EnableConditionsOffset = default(Offset<IConditionGroup>), float MaxAngle = 0f, StringOffset MotorSlideDtNameOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IMotorSlideComponent.AddMotorSlideDtName(builder, MotorSlideDtNameOffset);
			IMotorSlideComponent.AddMaxAngle(builder, MaxAngle);
			IMotorSlideComponent.AddEnableConditions(builder, EnableConditionsOffset);
			IMotorSlideComponent.AddNullMask(builder, NullMask);
			IMotorSlideComponent.AddDisabled(builder, Disabled);
			return IMotorSlideComponent.EndIMotorSlideComponent(builder);
		}

		// Token: 0x06024655 RID: 149077 RVA: 0x005063E5 File Offset: 0x005045E5
		public static void StartIMotorSlideComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06024656 RID: 149078 RVA: 0x005063EE File Offset: 0x005045EE
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06024657 RID: 149079 RVA: 0x005063F9 File Offset: 0x005045F9
		public static void AddEnableConditions(FlatBufferBuilder builder, Offset<IConditionGroup> enableConditionsOffset)
		{
			builder.AddOffset(1, enableConditionsOffset.Value, 0);
		}

		// Token: 0x06024658 RID: 149080 RVA: 0x00506409 File Offset: 0x00504609
		public static void AddMaxAngle(FlatBufferBuilder builder, float maxAngle)
		{
			builder.AddFloat(2, maxAngle, 0.0);
		}

		// Token: 0x06024659 RID: 149081 RVA: 0x0050641C File Offset: 0x0050461C
		public static void AddMotorSlideDtName(FlatBufferBuilder builder, StringOffset motorSlideDtNameOffset)
		{
			builder.AddOffset(3, motorSlideDtNameOffset.Value, 0);
		}

		// Token: 0x0602465A RID: 149082 RVA: 0x0050642C File Offset: 0x0050462C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602465B RID: 149083 RVA: 0x00506437 File Offset: 0x00504637
		public static Offset<IMotorSlideComponent> EndIMotorSlideComponent(FlatBufferBuilder builder)
		{
			return new Offset<IMotorSlideComponent>(builder.EndTable());
		}

		// Token: 0x0602465C RID: 149084 RVA: 0x00506444 File Offset: 0x00504644
		public IMotorSlideComponentT UnPack()
		{
			IMotorSlideComponentT motorSlideComponentT = new IMotorSlideComponentT();
			this.UnPackTo(motorSlideComponentT);
			return motorSlideComponentT;
		}

		// Token: 0x0602465D RID: 149085 RVA: 0x00506460 File Offset: 0x00504660
		public void UnPackTo(IMotorSlideComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.EnableConditions = ((this.EnableConditions != null) ? this.EnableConditions.Value.UnPack() : null);
			_o.MaxAngle = this.MaxAngle;
			_o.MotorSlideDtName = this.MotorSlideDtName;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602465E RID: 149086 RVA: 0x005064CC File Offset: 0x005046CC
		public static Offset<IMotorSlideComponent> Pack(FlatBufferBuilder builder, IMotorSlideComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorSlideComponent>);
			}
			Offset<IConditionGroup> enableConditionsOffset = (_o.EnableConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.EnableConditions);
			StringOffset motorSlideDtNameOffset = (_o.MotorSlideDtName == null) ? default(StringOffset) : builder.CreateString(_o.MotorSlideDtName);
			return IMotorSlideComponent.CreateIMotorSlideComponent(builder, _o.Disabled, enableConditionsOffset, _o.MaxAngle, motorSlideDtNameOffset, _o.NullMask);
		}

		// Token: 0x0400E91B RID: 59675
		private Table __p;
	}
}

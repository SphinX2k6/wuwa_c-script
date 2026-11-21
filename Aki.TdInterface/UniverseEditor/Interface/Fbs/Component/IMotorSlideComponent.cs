using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B67 RID: 23399
	public struct IMotorSlideComponent : IFlatbufferObject
	{
		// Token: 0x1700AAE1 RID: 43745
		// (get) Token: 0x06026854 RID: 157780 RVA: 0x00546747 File Offset: 0x00544947
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026855 RID: 157781 RVA: 0x00546754 File Offset: 0x00544954
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026856 RID: 157782 RVA: 0x0054675C File Offset: 0x0054495C
		public static IMotorSlideComponent GetRootAsIMotorSlideComponent(ByteBuffer _bb)
		{
			return IMotorSlideComponent.GetRootAsIMotorSlideComponent(_bb, default(IMotorSlideComponent));
		}

		// Token: 0x06026857 RID: 157783 RVA: 0x00546778 File Offset: 0x00544978
		public static IMotorSlideComponent GetRootAsIMotorSlideComponent(ByteBuffer _bb, IMotorSlideComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026858 RID: 157784 RVA: 0x00546795 File Offset: 0x00544995
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026859 RID: 157785 RVA: 0x005467A4 File Offset: 0x005449A4
		public IMotorSlideComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AAE2 RID: 43746
		// (get) Token: 0x0602685A RID: 157786 RVA: 0x005467B4 File Offset: 0x005449B4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AAE3 RID: 43747
		// (get) Token: 0x0602685B RID: 157787 RVA: 0x005467F4 File Offset: 0x005449F4
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

		// Token: 0x1700AAE4 RID: 43748
		// (get) Token: 0x0602685C RID: 157788 RVA: 0x00546854 File Offset: 0x00544A54
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

		// Token: 0x1700AAE5 RID: 43749
		// (get) Token: 0x0602685D RID: 157789 RVA: 0x00546894 File Offset: 0x00544A94
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

		// Token: 0x0602685E RID: 157790 RVA: 0x005468CC File Offset: 0x00544ACC
		public Span<byte> GetMotorSlideDtNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602685F RID: 157791 RVA: 0x005468DC File Offset: 0x00544ADC
		public byte[] GetMotorSlideDtNameArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700AAE6 RID: 43750
		// (get) Token: 0x06026860 RID: 157792 RVA: 0x005468EC File Offset: 0x00544AEC
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

		// Token: 0x06026861 RID: 157793 RVA: 0x00546929 File Offset: 0x00544B29
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

		// Token: 0x06026862 RID: 157794 RVA: 0x0054695D File Offset: 0x00544B5D
		public static void StartIMotorSlideComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06026863 RID: 157795 RVA: 0x00546966 File Offset: 0x00544B66
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06026864 RID: 157796 RVA: 0x00546971 File Offset: 0x00544B71
		public static void AddEnableConditions(FlatBufferBuilder builder, Offset<IConditionGroup> enableConditionsOffset)
		{
			builder.AddOffset(1, enableConditionsOffset.Value, 0);
		}

		// Token: 0x06026865 RID: 157797 RVA: 0x00546981 File Offset: 0x00544B81
		public static void AddMaxAngle(FlatBufferBuilder builder, float maxAngle)
		{
			builder.AddFloat(2, maxAngle, 0.0);
		}

		// Token: 0x06026866 RID: 157798 RVA: 0x00546994 File Offset: 0x00544B94
		public static void AddMotorSlideDtName(FlatBufferBuilder builder, StringOffset motorSlideDtNameOffset)
		{
			builder.AddOffset(3, motorSlideDtNameOffset.Value, 0);
		}

		// Token: 0x06026867 RID: 157799 RVA: 0x005469A4 File Offset: 0x00544BA4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06026868 RID: 157800 RVA: 0x005469AF File Offset: 0x00544BAF
		public static Offset<IMotorSlideComponent> EndIMotorSlideComponent(FlatBufferBuilder builder)
		{
			return new Offset<IMotorSlideComponent>(builder.EndTable());
		}

		// Token: 0x06026869 RID: 157801 RVA: 0x005469BC File Offset: 0x00544BBC
		public IMotorSlideComponentT UnPack()
		{
			IMotorSlideComponentT motorSlideComponentT = new IMotorSlideComponentT();
			this.UnPackTo(motorSlideComponentT);
			return motorSlideComponentT;
		}

		// Token: 0x0602686A RID: 157802 RVA: 0x005469D8 File Offset: 0x00544BD8
		public void UnPackTo(IMotorSlideComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.EnableConditions = ((this.EnableConditions != null) ? this.EnableConditions.Value.UnPack() : null);
			_o.MaxAngle = this.MaxAngle;
			_o.MotorSlideDtName = this.MotorSlideDtName;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602686B RID: 157803 RVA: 0x00546A44 File Offset: 0x00544C44
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

		// Token: 0x0400F57D RID: 62845
		private Table __p;
	}
}

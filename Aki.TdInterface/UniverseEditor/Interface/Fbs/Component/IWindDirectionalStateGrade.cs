using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006193 RID: 24979
	public struct IWindDirectionalStateGrade : IFlatbufferObject
	{
		// Token: 0x1700BA4A RID: 47690
		// (get) Token: 0x0602A73F RID: 173887 RVA: 0x005CA9A6 File Offset: 0x005C8BA6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A740 RID: 173888 RVA: 0x005CA9B3 File Offset: 0x005C8BB3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A741 RID: 173889 RVA: 0x005CA9BC File Offset: 0x005C8BBC
		public static IWindDirectionalStateGrade GetRootAsIWindDirectionalStateGrade(ByteBuffer _bb)
		{
			return IWindDirectionalStateGrade.GetRootAsIWindDirectionalStateGrade(_bb, default(IWindDirectionalStateGrade));
		}

		// Token: 0x0602A742 RID: 173890 RVA: 0x005CA9D8 File Offset: 0x005C8BD8
		public static IWindDirectionalStateGrade GetRootAsIWindDirectionalStateGrade(ByteBuffer _bb, IWindDirectionalStateGrade obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A743 RID: 173891 RVA: 0x005CA9F5 File Offset: 0x005C8BF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A744 RID: 173892 RVA: 0x005CAA04 File Offset: 0x005C8C04
		public IWindDirectionalStateGrade __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA4B RID: 47691
		// (get) Token: 0x0602A745 RID: 173893 RVA: 0x005CAA14 File Offset: 0x005C8C14
		public string State
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A746 RID: 173894 RVA: 0x005CAA4B File Offset: 0x005C8C4B
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602A747 RID: 173895 RVA: 0x005CAA5A File Offset: 0x005C8C5A
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700BA4C RID: 47692
		// (get) Token: 0x0602A748 RID: 173896 RVA: 0x005CAA68 File Offset: 0x005C8C68
		public float Speed
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BA4D RID: 47693
		// (get) Token: 0x0602A749 RID: 173897 RVA: 0x005CAAA8 File Offset: 0x005C8CA8
		public float Strength
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

		// Token: 0x0602A74A RID: 173898 RVA: 0x005CAAE8 File Offset: 0x005C8CE8
		public static Offset<IWindDirectionalStateGrade> CreateIWindDirectionalStateGrade(FlatBufferBuilder builder, StringOffset StateOffset = default(StringOffset), float Speed = 0f, float Strength = 0f)
		{
			builder.StartTable(3);
			IWindDirectionalStateGrade.AddStrength(builder, Strength);
			IWindDirectionalStateGrade.AddSpeed(builder, Speed);
			IWindDirectionalStateGrade.AddState(builder, StateOffset);
			return IWindDirectionalStateGrade.EndIWindDirectionalStateGrade(builder);
		}

		// Token: 0x0602A74B RID: 173899 RVA: 0x005CAB0C File Offset: 0x005C8D0C
		public static void StartIWindDirectionalStateGrade(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602A74C RID: 173900 RVA: 0x005CAB15 File Offset: 0x005C8D15
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(0, stateOffset.Value, 0);
		}

		// Token: 0x0602A74D RID: 173901 RVA: 0x005CAB25 File Offset: 0x005C8D25
		public static void AddSpeed(FlatBufferBuilder builder, float speed)
		{
			builder.AddFloat(1, speed, 0.0);
		}

		// Token: 0x0602A74E RID: 173902 RVA: 0x005CAB38 File Offset: 0x005C8D38
		public static void AddStrength(FlatBufferBuilder builder, float strength)
		{
			builder.AddFloat(2, strength, 0.0);
		}

		// Token: 0x0602A74F RID: 173903 RVA: 0x005CAB4B File Offset: 0x005C8D4B
		public static Offset<IWindDirectionalStateGrade> EndIWindDirectionalStateGrade(FlatBufferBuilder builder)
		{
			return new Offset<IWindDirectionalStateGrade>(builder.EndTable());
		}

		// Token: 0x0602A750 RID: 173904 RVA: 0x005CAB58 File Offset: 0x005C8D58
		public IWindDirectionalStateGradeT UnPack()
		{
			IWindDirectionalStateGradeT windDirectionalStateGradeT = new IWindDirectionalStateGradeT();
			this.UnPackTo(windDirectionalStateGradeT);
			return windDirectionalStateGradeT;
		}

		// Token: 0x0602A751 RID: 173905 RVA: 0x005CAB73 File Offset: 0x005C8D73
		public void UnPackTo(IWindDirectionalStateGradeT _o)
		{
			_o.State = this.State;
			_o.Speed = this.Speed;
			_o.Strength = this.Strength;
		}

		// Token: 0x0602A752 RID: 173906 RVA: 0x005CAB9C File Offset: 0x005C8D9C
		public static Offset<IWindDirectionalStateGrade> Pack(FlatBufferBuilder builder, IWindDirectionalStateGradeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWindDirectionalStateGrade>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IWindDirectionalStateGrade.CreateIWindDirectionalStateGrade(builder, stateOffset, _o.Speed, _o.Strength);
		}

		// Token: 0x0400FFDD RID: 65501
		private Table __p;
	}
}

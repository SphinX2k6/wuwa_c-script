using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B7D RID: 23421
	public struct IWindDirectionalStateGrade : IFlatbufferObject
	{
		// Token: 0x1700B102 RID: 45314
		// (get) Token: 0x0602817B RID: 164219 RVA: 0x00582F16 File Offset: 0x00581116
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602817C RID: 164220 RVA: 0x00582F23 File Offset: 0x00581123
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602817D RID: 164221 RVA: 0x00582F2C File Offset: 0x0058112C
		public static IWindDirectionalStateGrade GetRootAsIWindDirectionalStateGrade(ByteBuffer _bb)
		{
			return IWindDirectionalStateGrade.GetRootAsIWindDirectionalStateGrade(_bb, default(IWindDirectionalStateGrade));
		}

		// Token: 0x0602817E RID: 164222 RVA: 0x00582F48 File Offset: 0x00581148
		public static IWindDirectionalStateGrade GetRootAsIWindDirectionalStateGrade(ByteBuffer _bb, IWindDirectionalStateGrade obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602817F RID: 164223 RVA: 0x00582F65 File Offset: 0x00581165
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028180 RID: 164224 RVA: 0x00582F74 File Offset: 0x00581174
		public IWindDirectionalStateGrade __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B103 RID: 45315
		// (get) Token: 0x06028181 RID: 164225 RVA: 0x00582F84 File Offset: 0x00581184
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

		// Token: 0x06028182 RID: 164226 RVA: 0x00582FBB File Offset: 0x005811BB
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06028183 RID: 164227 RVA: 0x00582FCA File Offset: 0x005811CA
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700B104 RID: 45316
		// (get) Token: 0x06028184 RID: 164228 RVA: 0x00582FD8 File Offset: 0x005811D8
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

		// Token: 0x1700B105 RID: 45317
		// (get) Token: 0x06028185 RID: 164229 RVA: 0x00583018 File Offset: 0x00581218
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

		// Token: 0x06028186 RID: 164230 RVA: 0x00583058 File Offset: 0x00581258
		public static Offset<IWindDirectionalStateGrade> CreateIWindDirectionalStateGrade(FlatBufferBuilder builder, StringOffset StateOffset = default(StringOffset), float Speed = 0f, float Strength = 0f)
		{
			builder.StartTable(3);
			IWindDirectionalStateGrade.AddStrength(builder, Strength);
			IWindDirectionalStateGrade.AddSpeed(builder, Speed);
			IWindDirectionalStateGrade.AddState(builder, StateOffset);
			return IWindDirectionalStateGrade.EndIWindDirectionalStateGrade(builder);
		}

		// Token: 0x06028187 RID: 164231 RVA: 0x0058307C File Offset: 0x0058127C
		public static void StartIWindDirectionalStateGrade(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06028188 RID: 164232 RVA: 0x00583085 File Offset: 0x00581285
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(0, stateOffset.Value, 0);
		}

		// Token: 0x06028189 RID: 164233 RVA: 0x00583095 File Offset: 0x00581295
		public static void AddSpeed(FlatBufferBuilder builder, float speed)
		{
			builder.AddFloat(1, speed, 0.0);
		}

		// Token: 0x0602818A RID: 164234 RVA: 0x005830A8 File Offset: 0x005812A8
		public static void AddStrength(FlatBufferBuilder builder, float strength)
		{
			builder.AddFloat(2, strength, 0.0);
		}

		// Token: 0x0602818B RID: 164235 RVA: 0x005830BB File Offset: 0x005812BB
		public static Offset<IWindDirectionalStateGrade> EndIWindDirectionalStateGrade(FlatBufferBuilder builder)
		{
			return new Offset<IWindDirectionalStateGrade>(builder.EndTable());
		}

		// Token: 0x0602818C RID: 164236 RVA: 0x005830C8 File Offset: 0x005812C8
		public IWindDirectionalStateGradeT UnPack()
		{
			IWindDirectionalStateGradeT windDirectionalStateGradeT = new IWindDirectionalStateGradeT();
			this.UnPackTo(windDirectionalStateGradeT);
			return windDirectionalStateGradeT;
		}

		// Token: 0x0602818D RID: 164237 RVA: 0x005830E3 File Offset: 0x005812E3
		public void UnPackTo(IWindDirectionalStateGradeT _o)
		{
			_o.State = this.State;
			_o.Speed = this.Speed;
			_o.Strength = this.Strength;
		}

		// Token: 0x0602818E RID: 164238 RVA: 0x0058310C File Offset: 0x0058130C
		public static Offset<IWindDirectionalStateGrade> Pack(FlatBufferBuilder builder, IWindDirectionalStateGradeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWindDirectionalStateGrade>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IWindDirectionalStateGrade.CreateIWindDirectionalStateGrade(builder, stateOffset, _o.Speed, _o.Strength);
		}

		// Token: 0x0400F2D7 RID: 62167
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B1B RID: 27419
	public struct IMotorEnterSlide : IFlatbufferObject
	{
		// Token: 0x1700CBCA RID: 52170
		// (get) Token: 0x060301FE RID: 197118 RVA: 0x0068ABB8 File Offset: 0x00688DB8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060301FF RID: 197119 RVA: 0x0068ABC5 File Offset: 0x00688DC5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030200 RID: 197120 RVA: 0x0068ABCC File Offset: 0x00688DCC
		public static IMotorEnterSlide GetRootAsIMotorEnterSlide(ByteBuffer _bb)
		{
			return IMotorEnterSlide.GetRootAsIMotorEnterSlide(_bb, default(IMotorEnterSlide));
		}

		// Token: 0x06030201 RID: 197121 RVA: 0x0068ABE8 File Offset: 0x00688DE8
		public static IMotorEnterSlide GetRootAsIMotorEnterSlide(ByteBuffer _bb, IMotorEnterSlide obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030202 RID: 197122 RVA: 0x0068AC05 File Offset: 0x00688E05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030203 RID: 197123 RVA: 0x0068AC14 File Offset: 0x00688E14
		public IMotorEnterSlide __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CBCB RID: 52171
		// (get) Token: 0x06030204 RID: 197124 RVA: 0x0068AC24 File Offset: 0x00688E24
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CBCC RID: 52172
		// (get) Token: 0x06030205 RID: 197125 RVA: 0x0068AC60 File Offset: 0x00688E60
		public int EntityId
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

		// Token: 0x1700CBCD RID: 52173
		// (get) Token: 0x06030206 RID: 197126 RVA: 0x0068AC9C File Offset: 0x00688E9C
		public EMotorEnterSlideMode EnterMode
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EMotorEnterSlideMode.Jump;
				}
				return (EMotorEnterSlideMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CBCE RID: 52174
		// (get) Token: 0x06030207 RID: 197127 RVA: 0x0068ACD8 File Offset: 0x00688ED8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030208 RID: 197128 RVA: 0x0068AD15 File Offset: 0x00688F15
		public static Offset<IMotorEnterSlide> CreateIMotorEnterSlide(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, int EntityId = 0, EMotorEnterSlideMode EnterMode = EMotorEnterSlideMode.Jump, byte NullMask = 0)
		{
			builder.StartTable(4);
			IMotorEnterSlide.AddEntityId(builder, EntityId);
			IMotorEnterSlide.AddNullMask(builder, NullMask);
			IMotorEnterSlide.AddEnterMode(builder, EnterMode);
			IMotorEnterSlide.AddType(builder, Type);
			return IMotorEnterSlide.EndIMotorEnterSlide(builder);
		}

		// Token: 0x06030209 RID: 197129 RVA: 0x0068AD41 File Offset: 0x00688F41
		public static void StartIMotorEnterSlide(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0603020A RID: 197130 RVA: 0x0068AD4A File Offset: 0x00688F4A
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603020B RID: 197131 RVA: 0x0068AD55 File Offset: 0x00688F55
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0603020C RID: 197132 RVA: 0x0068AD60 File Offset: 0x00688F60
		public static void AddEnterMode(FlatBufferBuilder builder, EMotorEnterSlideMode enterMode)
		{
			builder.AddByte(2, (byte)enterMode, 0);
		}

		// Token: 0x0603020D RID: 197133 RVA: 0x0068AD6B File Offset: 0x00688F6B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0603020E RID: 197134 RVA: 0x0068AD76 File Offset: 0x00688F76
		public static Offset<IMotorEnterSlide> EndIMotorEnterSlide(FlatBufferBuilder builder)
		{
			return new Offset<IMotorEnterSlide>(builder.EndTable());
		}

		// Token: 0x0603020F RID: 197135 RVA: 0x0068AD84 File Offset: 0x00688F84
		public IMotorEnterSlideT UnPack()
		{
			IMotorEnterSlideT motorEnterSlideT = new IMotorEnterSlideT();
			this.UnPackTo(motorEnterSlideT);
			return motorEnterSlideT;
		}

		// Token: 0x06030210 RID: 197136 RVA: 0x0068AD9F File Offset: 0x00688F9F
		public void UnPackTo(IMotorEnterSlideT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.EnterMode = this.EnterMode;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030211 RID: 197137 RVA: 0x0068ADD4 File Offset: 0x00688FD4
		public static Offset<IMotorEnterSlide> Pack(FlatBufferBuilder builder, IMotorEnterSlideT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorEnterSlide>);
			}
			return IMotorEnterSlide.CreateIMotorEnterSlide(builder, _o.Type, _o.EntityId, _o.EnterMode, _o.NullMask);
		}

		// Token: 0x040113AB RID: 70571
		private Table __p;
	}
}

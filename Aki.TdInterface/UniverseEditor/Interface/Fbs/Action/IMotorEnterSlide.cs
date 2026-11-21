using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007252 RID: 29266
	public struct IMotorEnterSlide : IFlatbufferObject
	{
		// Token: 0x1700D699 RID: 54937
		// (get) Token: 0x06032FD2 RID: 208850 RVA: 0x006E2270 File Offset: 0x006E0470
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032FD3 RID: 208851 RVA: 0x006E227D File Offset: 0x006E047D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032FD4 RID: 208852 RVA: 0x006E2284 File Offset: 0x006E0484
		public static IMotorEnterSlide GetRootAsIMotorEnterSlide(ByteBuffer _bb)
		{
			return IMotorEnterSlide.GetRootAsIMotorEnterSlide(_bb, default(IMotorEnterSlide));
		}

		// Token: 0x06032FD5 RID: 208853 RVA: 0x006E22A0 File Offset: 0x006E04A0
		public static IMotorEnterSlide GetRootAsIMotorEnterSlide(ByteBuffer _bb, IMotorEnterSlide obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032FD6 RID: 208854 RVA: 0x006E22BD File Offset: 0x006E04BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032FD7 RID: 208855 RVA: 0x006E22CC File Offset: 0x006E04CC
		public IMotorEnterSlide __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D69A RID: 54938
		// (get) Token: 0x06032FD8 RID: 208856 RVA: 0x006E22DC File Offset: 0x006E04DC
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

		// Token: 0x1700D69B RID: 54939
		// (get) Token: 0x06032FD9 RID: 208857 RVA: 0x006E2318 File Offset: 0x006E0518
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

		// Token: 0x1700D69C RID: 54940
		// (get) Token: 0x06032FDA RID: 208858 RVA: 0x006E2354 File Offset: 0x006E0554
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

		// Token: 0x1700D69D RID: 54941
		// (get) Token: 0x06032FDB RID: 208859 RVA: 0x006E2390 File Offset: 0x006E0590
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

		// Token: 0x06032FDC RID: 208860 RVA: 0x006E23CD File Offset: 0x006E05CD
		public static Offset<IMotorEnterSlide> CreateIMotorEnterSlide(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, int EntityId = 0, EMotorEnterSlideMode EnterMode = EMotorEnterSlideMode.Jump, byte NullMask = 0)
		{
			builder.StartTable(4);
			IMotorEnterSlide.AddEntityId(builder, EntityId);
			IMotorEnterSlide.AddNullMask(builder, NullMask);
			IMotorEnterSlide.AddEnterMode(builder, EnterMode);
			IMotorEnterSlide.AddType(builder, Type);
			return IMotorEnterSlide.EndIMotorEnterSlide(builder);
		}

		// Token: 0x06032FDD RID: 208861 RVA: 0x006E23F9 File Offset: 0x006E05F9
		public static void StartIMotorEnterSlide(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06032FDE RID: 208862 RVA: 0x006E2402 File Offset: 0x006E0602
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032FDF RID: 208863 RVA: 0x006E240D File Offset: 0x006E060D
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06032FE0 RID: 208864 RVA: 0x006E2418 File Offset: 0x006E0618
		public static void AddEnterMode(FlatBufferBuilder builder, EMotorEnterSlideMode enterMode)
		{
			builder.AddByte(2, (byte)enterMode, 0);
		}

		// Token: 0x06032FE1 RID: 208865 RVA: 0x006E2423 File Offset: 0x006E0623
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06032FE2 RID: 208866 RVA: 0x006E242E File Offset: 0x006E062E
		public static Offset<IMotorEnterSlide> EndIMotorEnterSlide(FlatBufferBuilder builder)
		{
			return new Offset<IMotorEnterSlide>(builder.EndTable());
		}

		// Token: 0x06032FE3 RID: 208867 RVA: 0x006E243C File Offset: 0x006E063C
		public IMotorEnterSlideT UnPack()
		{
			IMotorEnterSlideT motorEnterSlideT = new IMotorEnterSlideT();
			this.UnPackTo(motorEnterSlideT);
			return motorEnterSlideT;
		}

		// Token: 0x06032FE4 RID: 208868 RVA: 0x006E2457 File Offset: 0x006E0657
		public void UnPackTo(IMotorEnterSlideT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.EnterMode = this.EnterMode;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06032FE5 RID: 208869 RVA: 0x006E248C File Offset: 0x006E068C
		public static Offset<IMotorEnterSlide> Pack(FlatBufferBuilder builder, IMotorEnterSlideT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorEnterSlide>);
			}
			return IMotorEnterSlide.CreateIMotorEnterSlide(builder, _o.Type, _o.EntityId, _o.EnterMode, _o.NullMask);
		}

		// Token: 0x040122BE RID: 74430
		private Table __p;
	}
}

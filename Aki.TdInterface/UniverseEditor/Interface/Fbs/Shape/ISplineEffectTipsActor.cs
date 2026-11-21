using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004058 RID: 16472
	public struct ISplineEffectTipsActor : IFlatbufferObject
	{
		// Token: 0x1700700A RID: 28682
		// (get) Token: 0x06016A4D RID: 92749 RVA: 0x0033CE97 File Offset: 0x0033B097
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016A4E RID: 92750 RVA: 0x0033CEA4 File Offset: 0x0033B0A4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016A4F RID: 92751 RVA: 0x0033CEAC File Offset: 0x0033B0AC
		public static ISplineEffectTipsActor GetRootAsISplineEffectTipsActor(ByteBuffer _bb)
		{
			return ISplineEffectTipsActor.GetRootAsISplineEffectTipsActor(_bb, default(ISplineEffectTipsActor));
		}

		// Token: 0x06016A50 RID: 92752 RVA: 0x0033CEC8 File Offset: 0x0033B0C8
		public static ISplineEffectTipsActor GetRootAsISplineEffectTipsActor(ByteBuffer _bb, ISplineEffectTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016A51 RID: 92753 RVA: 0x0033CEE5 File Offset: 0x0033B0E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016A52 RID: 92754 RVA: 0x0033CEF4 File Offset: 0x0033B0F4
		public ISplineEffectTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700700B RID: 28683
		// (get) Token: 0x06016A53 RID: 92755 RVA: 0x0033CF04 File Offset: 0x0033B104
		public ETipsActorType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETipsActorType.Sphere;
				}
				return (ETipsActorType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700700C RID: 28684
		// (get) Token: 0x06016A54 RID: 92756 RVA: 0x0033CF40 File Offset: 0x0033B140
		public ETipsActorColorType ColorType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ETipsActorColorType.Inner;
				}
				return (ETipsActorColorType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700700D RID: 28685
		// (get) Token: 0x06016A55 RID: 92757 RVA: 0x0033CF7C File Offset: 0x0033B17C
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700700E RID: 28686
		// (get) Token: 0x06016A56 RID: 92758 RVA: 0x0033CFB8 File Offset: 0x0033B1B8
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

		// Token: 0x06016A57 RID: 92759 RVA: 0x0033CFF5 File Offset: 0x0033B1F5
		public static Offset<ISplineEffectTipsActor> CreateISplineEffectTipsActor(FlatBufferBuilder builder, ETipsActorType Type = ETipsActorType.Sphere, ETipsActorColorType ColorType = ETipsActorColorType.Inner, int EntityId = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ISplineEffectTipsActor.AddEntityId(builder, EntityId);
			ISplineEffectTipsActor.AddNullMask(builder, NullMask);
			ISplineEffectTipsActor.AddColorType(builder, ColorType);
			ISplineEffectTipsActor.AddType(builder, Type);
			return ISplineEffectTipsActor.EndISplineEffectTipsActor(builder);
		}

		// Token: 0x06016A58 RID: 92760 RVA: 0x0033D021 File Offset: 0x0033B221
		public static void StartISplineEffectTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06016A59 RID: 92761 RVA: 0x0033D02A File Offset: 0x0033B22A
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016A5A RID: 92762 RVA: 0x0033D035 File Offset: 0x0033B235
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x06016A5B RID: 92763 RVA: 0x0033D040 File Offset: 0x0033B240
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(2, entityId, 0);
		}

		// Token: 0x06016A5C RID: 92764 RVA: 0x0033D04B File Offset: 0x0033B24B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06016A5D RID: 92765 RVA: 0x0033D056 File Offset: 0x0033B256
		public static Offset<ISplineEffectTipsActor> EndISplineEffectTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<ISplineEffectTipsActor>(builder.EndTable());
		}

		// Token: 0x06016A5E RID: 92766 RVA: 0x0033D064 File Offset: 0x0033B264
		public ISplineEffectTipsActorT UnPack()
		{
			ISplineEffectTipsActorT splineEffectTipsActorT = new ISplineEffectTipsActorT();
			this.UnPackTo(splineEffectTipsActorT);
			return splineEffectTipsActorT;
		}

		// Token: 0x06016A5F RID: 92767 RVA: 0x0033D07F File Offset: 0x0033B27F
		public void UnPackTo(ISplineEffectTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.EntityId = this.EntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016A60 RID: 92768 RVA: 0x0033D0B4 File Offset: 0x0033B2B4
		public static Offset<ISplineEffectTipsActor> Pack(FlatBufferBuilder builder, ISplineEffectTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISplineEffectTipsActor>);
			}
			return ISplineEffectTipsActor.CreateISplineEffectTipsActor(builder, _o.Type, _o.ColorType, _o.EntityId, _o.NullMask);
		}

		// Token: 0x0400BBE3 RID: 48099
		private Table __p;
	}
}

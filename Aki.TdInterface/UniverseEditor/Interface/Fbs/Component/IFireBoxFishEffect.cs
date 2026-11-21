using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057C0 RID: 22464
	public struct IFireBoxFishEffect : IFlatbufferObject
	{
		// Token: 0x1700A262 RID: 41570
		// (get) Token: 0x06024435 RID: 148533 RVA: 0x004FBD84 File Offset: 0x004F9F84
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024436 RID: 148534 RVA: 0x004FBD91 File Offset: 0x004F9F91
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024437 RID: 148535 RVA: 0x004FBD98 File Offset: 0x004F9F98
		public static IFireBoxFishEffect GetRootAsIFireBoxFishEffect(ByteBuffer _bb)
		{
			return IFireBoxFishEffect.GetRootAsIFireBoxFishEffect(_bb, default(IFireBoxFishEffect));
		}

		// Token: 0x06024438 RID: 148536 RVA: 0x004FBDB4 File Offset: 0x004F9FB4
		public static IFireBoxFishEffect GetRootAsIFireBoxFishEffect(ByteBuffer _bb, IFireBoxFishEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024439 RID: 148537 RVA: 0x004FBDD1 File Offset: 0x004F9FD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602443A RID: 148538 RVA: 0x004FBDE0 File Offset: 0x004F9FE0
		public IFireBoxFishEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A263 RID: 41571
		// (get) Token: 0x0602443B RID: 148539 RVA: 0x004FBDF0 File Offset: 0x004F9FF0
		public EGraph3dEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGraph3dEffectType.FireBoxFish;
				}
				return (EGraph3dEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A264 RID: 41572
		// (get) Token: 0x0602443C RID: 148540 RVA: 0x004FBE2C File Offset: 0x004FA02C
		public string Effect
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602443D RID: 148541 RVA: 0x004FBE63 File Offset: 0x004FA063
		public Span<byte> GetEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602443E RID: 148542 RVA: 0x004FBE72 File Offset: 0x004FA072
		public byte[] GetEffectArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602443F RID: 148543 RVA: 0x004FBE80 File Offset: 0x004FA080
		public static Offset<IFireBoxFishEffect> CreateIFireBoxFishEffect(FlatBufferBuilder builder, EGraph3dEffectType Type = EGraph3dEffectType.FireBoxFish, StringOffset EffectOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFireBoxFishEffect.AddEffect(builder, EffectOffset);
			IFireBoxFishEffect.AddType(builder, Type);
			return IFireBoxFishEffect.EndIFireBoxFishEffect(builder);
		}

		// Token: 0x06024440 RID: 148544 RVA: 0x004FBE9D File Offset: 0x004FA09D
		public static void StartIFireBoxFishEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06024441 RID: 148545 RVA: 0x004FBEA6 File Offset: 0x004FA0A6
		public static void AddType(FlatBufferBuilder builder, EGraph3dEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024442 RID: 148546 RVA: 0x004FBEB1 File Offset: 0x004FA0B1
		public static void AddEffect(FlatBufferBuilder builder, StringOffset effectOffset)
		{
			builder.AddOffset(1, effectOffset.Value, 0);
		}

		// Token: 0x06024443 RID: 148547 RVA: 0x004FBEC1 File Offset: 0x004FA0C1
		public static Offset<IFireBoxFishEffect> EndIFireBoxFishEffect(FlatBufferBuilder builder)
		{
			return new Offset<IFireBoxFishEffect>(builder.EndTable());
		}

		// Token: 0x06024444 RID: 148548 RVA: 0x004FBED0 File Offset: 0x004FA0D0
		public IFireBoxFishEffectT UnPack()
		{
			IFireBoxFishEffectT fireBoxFishEffectT = new IFireBoxFishEffectT();
			this.UnPackTo(fireBoxFishEffectT);
			return fireBoxFishEffectT;
		}

		// Token: 0x06024445 RID: 148549 RVA: 0x004FBEEB File Offset: 0x004FA0EB
		public void UnPackTo(IFireBoxFishEffectT _o)
		{
			_o.Type = this.Type;
			_o.Effect = this.Effect;
		}

		// Token: 0x06024446 RID: 148550 RVA: 0x004FBF08 File Offset: 0x004FA108
		public static Offset<IFireBoxFishEffect> Pack(FlatBufferBuilder builder, IFireBoxFishEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFireBoxFishEffect>);
			}
			StringOffset effectOffset = (_o.Effect == null) ? default(StringOffset) : builder.CreateString(_o.Effect);
			return IFireBoxFishEffect.CreateIFireBoxFishEffect(builder, _o.Type, effectOffset);
		}

		// Token: 0x0400EFAF RID: 61359
		private Table __p;
	}
}

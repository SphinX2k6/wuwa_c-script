using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200688C RID: 26764
	public struct IBounce : IFlatbufferObject
	{
		// Token: 0x1700C4AB RID: 50347
		// (get) Token: 0x0602DBF7 RID: 187383 RVA: 0x00641079 File Offset: 0x0063F279
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DBF8 RID: 187384 RVA: 0x00641086 File Offset: 0x0063F286
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DBF9 RID: 187385 RVA: 0x00641090 File Offset: 0x0063F290
		public static IBounce GetRootAsIBounce(ByteBuffer _bb)
		{
			return IBounce.GetRootAsIBounce(_bb, default(IBounce));
		}

		// Token: 0x0602DBFA RID: 187386 RVA: 0x006410AC File Offset: 0x0063F2AC
		public static IBounce GetRootAsIBounce(ByteBuffer _bb, IBounce obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DBFB RID: 187387 RVA: 0x006410C9 File Offset: 0x0063F2C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DBFC RID: 187388 RVA: 0x006410D8 File Offset: 0x0063F2D8
		public IBounce __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C4AC RID: 50348
		// (get) Token: 0x0602DBFD RID: 187389 RVA: 0x006410E8 File Offset: 0x0063F2E8
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

		// Token: 0x1700C4AD RID: 50349
		// (get) Token: 0x0602DBFE RID: 187390 RVA: 0x00641124 File Offset: 0x0063F324
		public TCommonTarget TargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TCommonTarget.NONE;
				}
				return (TCommonTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DBFF RID: 187391 RVA: 0x00641160 File Offset: 0x0063F360
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602DC00 RID: 187392 RVA: 0x006411A4 File Offset: 0x0063F3A4
		public IAssistCharacterTarget TargetAsIAssistCharacterTarget()
		{
			return this.Target<IAssistCharacterTarget>().Value;
		}

		// Token: 0x0602DC01 RID: 187393 RVA: 0x006411C0 File Offset: 0x0063F3C0
		public IPlayerTarget TargetAsIPlayerTarget()
		{
			return this.Target<IPlayerTarget>().Value;
		}

		// Token: 0x1700C4AE RID: 50350
		// (get) Token: 0x0602DC02 RID: 187394 RVA: 0x006411DC File Offset: 0x0063F3DC
		public int Height
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C4AF RID: 50351
		// (get) Token: 0x0602DC03 RID: 187395 RVA: 0x0064121C File Offset: 0x0063F41C
		public float Time
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

		// Token: 0x1700C4B0 RID: 50352
		// (get) Token: 0x0602DC04 RID: 187396 RVA: 0x00641260 File Offset: 0x0063F460
		public string MotionCurve
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DC05 RID: 187397 RVA: 0x00641298 File Offset: 0x0063F498
		public Span<byte> GetMotionCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0602DC06 RID: 187398 RVA: 0x006412A8 File Offset: 0x0063F4A8
		public byte[] GetMotionCurveArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x1700C4B1 RID: 50353
		// (get) Token: 0x0602DC07 RID: 187399 RVA: 0x006412B8 File Offset: 0x0063F4B8
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

		// Token: 0x0602DC08 RID: 187400 RVA: 0x006412F8 File Offset: 0x0063F4F8
		public static Offset<IBounce> CreateIBounce(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, TCommonTarget Target_type = TCommonTarget.NONE, int TargetOffset = 0, int Height = 0, float Time = 0f, StringOffset MotionCurveOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(7);
			IBounce.AddMotionCurve(builder, MotionCurveOffset);
			IBounce.AddTime(builder, Time);
			IBounce.AddHeight(builder, Height);
			IBounce.AddTarget(builder, TargetOffset);
			IBounce.AddNullMask(builder, NullMask);
			IBounce.AddTargetType(builder, Target_type);
			IBounce.AddType(builder, Type);
			return IBounce.EndIBounce(builder);
		}

		// Token: 0x0602DC09 RID: 187401 RVA: 0x00641347 File Offset: 0x0063F547
		public static void StartIBounce(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602DC0A RID: 187402 RVA: 0x00641350 File Offset: 0x0063F550
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DC0B RID: 187403 RVA: 0x0064135B File Offset: 0x0063F55B
		public static void AddTargetType(FlatBufferBuilder builder, TCommonTarget targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0602DC0C RID: 187404 RVA: 0x00641366 File Offset: 0x0063F566
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0602DC0D RID: 187405 RVA: 0x00641371 File Offset: 0x0063F571
		public static void AddHeight(FlatBufferBuilder builder, int height)
		{
			builder.AddInt(3, height, 0);
		}

		// Token: 0x0602DC0E RID: 187406 RVA: 0x0064137C File Offset: 0x0063F57C
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(4, time, 0.0);
		}

		// Token: 0x0602DC0F RID: 187407 RVA: 0x0064138F File Offset: 0x0063F58F
		public static void AddMotionCurve(FlatBufferBuilder builder, StringOffset motionCurveOffset)
		{
			builder.AddOffset(5, motionCurveOffset.Value, 0);
		}

		// Token: 0x0602DC10 RID: 187408 RVA: 0x0064139F File Offset: 0x0063F59F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602DC11 RID: 187409 RVA: 0x006413AA File Offset: 0x0063F5AA
		public static Offset<IBounce> EndIBounce(FlatBufferBuilder builder)
		{
			return new Offset<IBounce>(builder.EndTable());
		}

		// Token: 0x0602DC12 RID: 187410 RVA: 0x006413B8 File Offset: 0x0063F5B8
		public IBounceT UnPack()
		{
			IBounceT bounceT = new IBounceT();
			this.UnPackTo(bounceT);
			return bounceT;
		}

		// Token: 0x0602DC13 RID: 187411 RVA: 0x006413D4 File Offset: 0x0063F5D4
		public void UnPackTo(IBounceT _o)
		{
			_o.Type = this.Type;
			_o.Target = new TCommonTargetUnion();
			_o.Target.Type = this.TargetType;
			TCommonTarget targetType = this.TargetType;
			if (targetType != TCommonTarget.IAssistCharacterTarget)
			{
				if (targetType == TCommonTarget.IPlayerTarget)
				{
					_o.Target.Value = ((this.Target<IPlayerTarget>() != null) ? this.Target<IPlayerTarget>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.Target.Value = ((this.Target<IAssistCharacterTarget>() != null) ? this.Target<IAssistCharacterTarget>().Value.UnPack() : null);
			}
			_o.Height = this.Height;
			_o.Time = this.Time;
			_o.MotionCurve = this.MotionCurve;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602DC14 RID: 187412 RVA: 0x006414B8 File Offset: 0x0063F6B8
		public static Offset<IBounce> Pack(FlatBufferBuilder builder, IBounceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBounce>);
			}
			TCommonTarget target_type = (_o.Target == null) ? TCommonTarget.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TCommonTargetUnion.Pack(builder, _o.Target);
			StringOffset motionCurveOffset = (_o.MotionCurve == null) ? default(StringOffset) : builder.CreateString(_o.MotionCurve);
			return IBounce.CreateIBounce(builder, _o.Type, target_type, targetOffset, _o.Height, _o.Time, motionCurveOffset, _o.NullMask);
		}

		// Token: 0x0401156C RID: 71020
		private Table __p;
	}
}

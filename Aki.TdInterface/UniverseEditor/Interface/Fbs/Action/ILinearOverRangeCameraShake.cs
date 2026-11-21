using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070DF RID: 28895
	public struct ILinearOverRangeCameraShake : IFlatbufferObject
	{
		// Token: 0x1700D39D RID: 54173
		// (get) Token: 0x060322D8 RID: 205528 RVA: 0x006C9DED File Offset: 0x006C7FED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060322D9 RID: 205529 RVA: 0x006C9DFA File Offset: 0x006C7FFA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060322DA RID: 205530 RVA: 0x006C9E04 File Offset: 0x006C8004
		public static ILinearOverRangeCameraShake GetRootAsILinearOverRangeCameraShake(ByteBuffer _bb)
		{
			return ILinearOverRangeCameraShake.GetRootAsILinearOverRangeCameraShake(_bb, default(ILinearOverRangeCameraShake));
		}

		// Token: 0x060322DB RID: 205531 RVA: 0x006C9E20 File Offset: 0x006C8020
		public static ILinearOverRangeCameraShake GetRootAsILinearOverRangeCameraShake(ByteBuffer _bb, ILinearOverRangeCameraShake obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060322DC RID: 205532 RVA: 0x006C9E3D File Offset: 0x006C803D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060322DD RID: 205533 RVA: 0x006C9E4C File Offset: 0x006C804C
		public ILinearOverRangeCameraShake __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D39E RID: 54174
		// (get) Token: 0x060322DE RID: 205534 RVA: 0x006C9E5C File Offset: 0x006C805C
		public ECameraShakeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECameraShakeType.Constant;
				}
				return (ECameraShakeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D39F RID: 54175
		// (get) Token: 0x060322DF RID: 205535 RVA: 0x006C9E98 File Offset: 0x006C8098
		public int CenterEntityId
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

		// Token: 0x1700D3A0 RID: 54176
		// (get) Token: 0x060322E0 RID: 205536 RVA: 0x006C9ED4 File Offset: 0x006C80D4
		public int MinRange
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

		// Token: 0x1700D3A1 RID: 54177
		// (get) Token: 0x060322E1 RID: 205537 RVA: 0x006C9F10 File Offset: 0x006C8110
		public int MaxRange
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

		// Token: 0x060322E2 RID: 205538 RVA: 0x006C9F4D File Offset: 0x006C814D
		public static Offset<ILinearOverRangeCameraShake> CreateILinearOverRangeCameraShake(FlatBufferBuilder builder, ECameraShakeType Type = ECameraShakeType.Constant, int CenterEntityId = 0, int MinRange = 0, int MaxRange = 0)
		{
			builder.StartTable(4);
			ILinearOverRangeCameraShake.AddMaxRange(builder, MaxRange);
			ILinearOverRangeCameraShake.AddMinRange(builder, MinRange);
			ILinearOverRangeCameraShake.AddCenterEntityId(builder, CenterEntityId);
			ILinearOverRangeCameraShake.AddType(builder, Type);
			return ILinearOverRangeCameraShake.EndILinearOverRangeCameraShake(builder);
		}

		// Token: 0x060322E3 RID: 205539 RVA: 0x006C9F79 File Offset: 0x006C8179
		public static void StartILinearOverRangeCameraShake(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060322E4 RID: 205540 RVA: 0x006C9F82 File Offset: 0x006C8182
		public static void AddType(FlatBufferBuilder builder, ECameraShakeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060322E5 RID: 205541 RVA: 0x006C9F8D File Offset: 0x006C818D
		public static void AddCenterEntityId(FlatBufferBuilder builder, int centerEntityId)
		{
			builder.AddInt(1, centerEntityId, 0);
		}

		// Token: 0x060322E6 RID: 205542 RVA: 0x006C9F98 File Offset: 0x006C8198
		public static void AddMinRange(FlatBufferBuilder builder, int minRange)
		{
			builder.AddInt(2, minRange, 0);
		}

		// Token: 0x060322E7 RID: 205543 RVA: 0x006C9FA3 File Offset: 0x006C81A3
		public static void AddMaxRange(FlatBufferBuilder builder, int maxRange)
		{
			builder.AddInt(3, maxRange, 0);
		}

		// Token: 0x060322E8 RID: 205544 RVA: 0x006C9FAE File Offset: 0x006C81AE
		public static Offset<ILinearOverRangeCameraShake> EndILinearOverRangeCameraShake(FlatBufferBuilder builder)
		{
			return new Offset<ILinearOverRangeCameraShake>(builder.EndTable());
		}

		// Token: 0x060322E9 RID: 205545 RVA: 0x006C9FBC File Offset: 0x006C81BC
		public ILinearOverRangeCameraShakeT UnPack()
		{
			ILinearOverRangeCameraShakeT linearOverRangeCameraShakeT = new ILinearOverRangeCameraShakeT();
			this.UnPackTo(linearOverRangeCameraShakeT);
			return linearOverRangeCameraShakeT;
		}

		// Token: 0x060322EA RID: 205546 RVA: 0x006C9FD7 File Offset: 0x006C81D7
		public void UnPackTo(ILinearOverRangeCameraShakeT _o)
		{
			_o.Type = this.Type;
			_o.CenterEntityId = this.CenterEntityId;
			_o.MinRange = this.MinRange;
			_o.MaxRange = this.MaxRange;
		}

		// Token: 0x060322EB RID: 205547 RVA: 0x006CA00C File Offset: 0x006C820C
		public static Offset<ILinearOverRangeCameraShake> Pack(FlatBufferBuilder builder, ILinearOverRangeCameraShakeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILinearOverRangeCameraShake>);
			}
			return ILinearOverRangeCameraShake.CreateILinearOverRangeCameraShake(builder, _o.Type, _o.CenterEntityId, _o.MinRange, _o.MaxRange);
		}

		// Token: 0x040120A7 RID: 73895
		private Table __p;
	}
}

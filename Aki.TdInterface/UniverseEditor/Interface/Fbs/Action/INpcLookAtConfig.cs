using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200732B RID: 29483
	public struct INpcLookAtConfig : IFlatbufferObject
	{
		// Token: 0x1700D814 RID: 55316
		// (get) Token: 0x06033697 RID: 210583 RVA: 0x006EE6B0 File Offset: 0x006EC8B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033698 RID: 210584 RVA: 0x006EE6BD File Offset: 0x006EC8BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033699 RID: 210585 RVA: 0x006EE6C4 File Offset: 0x006EC8C4
		public static INpcLookAtConfig GetRootAsINpcLookAtConfig(ByteBuffer _bb)
		{
			return INpcLookAtConfig.GetRootAsINpcLookAtConfig(_bb, default(INpcLookAtConfig));
		}

		// Token: 0x0603369A RID: 210586 RVA: 0x006EE6E0 File Offset: 0x006EC8E0
		public static INpcLookAtConfig GetRootAsINpcLookAtConfig(ByteBuffer _bb, INpcLookAtConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603369B RID: 210587 RVA: 0x006EE6FD File Offset: 0x006EC8FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603369C RID: 210588 RVA: 0x006EE70C File Offset: 0x006EC90C
		public INpcLookAtConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D815 RID: 55317
		// (get) Token: 0x0603369D RID: 210589 RVA: 0x006EE71C File Offset: 0x006EC91C
		public TNpcLookAtType TargetType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TNpcLookAtType.NONE;
				}
				return (TNpcLookAtType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603369E RID: 210590 RVA: 0x006EE758 File Offset: 0x006EC958
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603369F RID: 210591 RVA: 0x006EE79C File Offset: 0x006EC99C
		public INpcLookAtEntity TargetAsINpcLookAtEntity()
		{
			return this.Target<INpcLookAtEntity>().Value;
		}

		// Token: 0x060336A0 RID: 210592 RVA: 0x006EE7B8 File Offset: 0x006EC9B8
		public INpcLookAtPlayer TargetAsINpcLookAtPlayer()
		{
			return this.Target<INpcLookAtPlayer>().Value;
		}

		// Token: 0x060336A1 RID: 210593 RVA: 0x006EE7D4 File Offset: 0x006EC9D4
		public INpcLookAtPosition TargetAsINpcLookAtPosition()
		{
			return this.Target<INpcLookAtPosition>().Value;
		}

		// Token: 0x1700D816 RID: 55318
		// (get) Token: 0x060336A2 RID: 210594 RVA: 0x006EE7F0 File Offset: 0x006EC9F0
		public bool IsKeepOverAngle
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D817 RID: 55319
		// (get) Token: 0x060336A3 RID: 210595 RVA: 0x006EE830 File Offset: 0x006ECA30
		public float MaxDistance
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D818 RID: 55320
		// (get) Token: 0x060336A4 RID: 210596 RVA: 0x006EE874 File Offset: 0x006ECA74
		public float MaxAngle
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

		// Token: 0x1700D819 RID: 55321
		// (get) Token: 0x060336A5 RID: 210597 RVA: 0x006EE8B8 File Offset: 0x006ECAB8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060336A6 RID: 210598 RVA: 0x006EE8F5 File Offset: 0x006ECAF5
		public static Offset<INpcLookAtConfig> CreateINpcLookAtConfig(FlatBufferBuilder builder, TNpcLookAtType Target_type = TNpcLookAtType.NONE, int TargetOffset = 0, bool IsKeepOverAngle = false, float MaxDistance = 0f, float MaxAngle = 0f, byte NullMask = 0)
		{
			builder.StartTable(6);
			INpcLookAtConfig.AddMaxAngle(builder, MaxAngle);
			INpcLookAtConfig.AddMaxDistance(builder, MaxDistance);
			INpcLookAtConfig.AddTarget(builder, TargetOffset);
			INpcLookAtConfig.AddNullMask(builder, NullMask);
			INpcLookAtConfig.AddIsKeepOverAngle(builder, IsKeepOverAngle);
			INpcLookAtConfig.AddTargetType(builder, Target_type);
			return INpcLookAtConfig.EndINpcLookAtConfig(builder);
		}

		// Token: 0x060336A7 RID: 210599 RVA: 0x006EE931 File Offset: 0x006ECB31
		public static void StartINpcLookAtConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060336A8 RID: 210600 RVA: 0x006EE93A File Offset: 0x006ECB3A
		public static void AddTargetType(FlatBufferBuilder builder, TNpcLookAtType targetType)
		{
			builder.AddByte(0, (byte)targetType, 0);
		}

		// Token: 0x060336A9 RID: 210601 RVA: 0x006EE945 File Offset: 0x006ECB45
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(1, targetOffset, 0);
		}

		// Token: 0x060336AA RID: 210602 RVA: 0x006EE950 File Offset: 0x006ECB50
		public static void AddIsKeepOverAngle(FlatBufferBuilder builder, bool isKeepOverAngle)
		{
			builder.AddBool(2, isKeepOverAngle, false);
		}

		// Token: 0x060336AB RID: 210603 RVA: 0x006EE95B File Offset: 0x006ECB5B
		public static void AddMaxDistance(FlatBufferBuilder builder, float maxDistance)
		{
			builder.AddFloat(3, maxDistance, 0.0);
		}

		// Token: 0x060336AC RID: 210604 RVA: 0x006EE96E File Offset: 0x006ECB6E
		public static void AddMaxAngle(FlatBufferBuilder builder, float maxAngle)
		{
			builder.AddFloat(4, maxAngle, 0.0);
		}

		// Token: 0x060336AD RID: 210605 RVA: 0x006EE981 File Offset: 0x006ECB81
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060336AE RID: 210606 RVA: 0x006EE98C File Offset: 0x006ECB8C
		public static Offset<INpcLookAtConfig> EndINpcLookAtConfig(FlatBufferBuilder builder)
		{
			return new Offset<INpcLookAtConfig>(builder.EndTable());
		}

		// Token: 0x060336AF RID: 210607 RVA: 0x006EE99C File Offset: 0x006ECB9C
		public INpcLookAtConfigT UnPack()
		{
			INpcLookAtConfigT npcLookAtConfigT = new INpcLookAtConfigT();
			this.UnPackTo(npcLookAtConfigT);
			return npcLookAtConfigT;
		}

		// Token: 0x060336B0 RID: 210608 RVA: 0x006EE9B8 File Offset: 0x006ECBB8
		public void UnPackTo(INpcLookAtConfigT _o)
		{
			_o.Target = new TNpcLookAtTypeUnion();
			_o.Target.Type = this.TargetType;
			switch (this.TargetType)
			{
			case TNpcLookAtType.INpcLookAtEntity:
				_o.Target.Value = ((this.Target<INpcLookAtEntity>() != null) ? this.Target<INpcLookAtEntity>().Value.UnPack() : null);
				break;
			case TNpcLookAtType.INpcLookAtPlayer:
				_o.Target.Value = ((this.Target<INpcLookAtPlayer>() != null) ? this.Target<INpcLookAtPlayer>().Value.UnPack() : null);
				break;
			case TNpcLookAtType.INpcLookAtPosition:
				_o.Target.Value = ((this.Target<INpcLookAtPosition>() != null) ? this.Target<INpcLookAtPosition>().Value.UnPack() : null);
				break;
			}
			_o.IsKeepOverAngle = this.IsKeepOverAngle;
			_o.MaxDistance = this.MaxDistance;
			_o.MaxAngle = this.MaxAngle;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060336B1 RID: 210609 RVA: 0x006EEAD8 File Offset: 0x006ECCD8
		public static Offset<INpcLookAtConfig> Pack(FlatBufferBuilder builder, INpcLookAtConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcLookAtConfig>);
			}
			TNpcLookAtType target_type = (_o.Target == null) ? TNpcLookAtType.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TNpcLookAtTypeUnion.Pack(builder, _o.Target);
			return INpcLookAtConfig.CreateINpcLookAtConfig(builder, target_type, targetOffset, _o.IsKeepOverAngle, _o.MaxDistance, _o.MaxAngle, _o.NullMask);
		}

		// Token: 0x040123F3 RID: 74739
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BC7 RID: 27591
	public struct INpcLookAtConfig : IFlatbufferObject
	{
		// Token: 0x1700CD08 RID: 52488
		// (get) Token: 0x0603077B RID: 198523 RVA: 0x00694DB0 File Offset: 0x00692FB0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603077C RID: 198524 RVA: 0x00694DBD File Offset: 0x00692FBD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603077D RID: 198525 RVA: 0x00694DC4 File Offset: 0x00692FC4
		public static INpcLookAtConfig GetRootAsINpcLookAtConfig(ByteBuffer _bb)
		{
			return INpcLookAtConfig.GetRootAsINpcLookAtConfig(_bb, default(INpcLookAtConfig));
		}

		// Token: 0x0603077E RID: 198526 RVA: 0x00694DE0 File Offset: 0x00692FE0
		public static INpcLookAtConfig GetRootAsINpcLookAtConfig(ByteBuffer _bb, INpcLookAtConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603077F RID: 198527 RVA: 0x00694DFD File Offset: 0x00692FFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030780 RID: 198528 RVA: 0x00694E0C File Offset: 0x0069300C
		public INpcLookAtConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD09 RID: 52489
		// (get) Token: 0x06030781 RID: 198529 RVA: 0x00694E1C File Offset: 0x0069301C
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

		// Token: 0x06030782 RID: 198530 RVA: 0x00694E58 File Offset: 0x00693058
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030783 RID: 198531 RVA: 0x00694E9C File Offset: 0x0069309C
		public INpcLookAtEntity TargetAsINpcLookAtEntity()
		{
			return this.Target<INpcLookAtEntity>().Value;
		}

		// Token: 0x06030784 RID: 198532 RVA: 0x00694EB8 File Offset: 0x006930B8
		public INpcLookAtPlayer TargetAsINpcLookAtPlayer()
		{
			return this.Target<INpcLookAtPlayer>().Value;
		}

		// Token: 0x06030785 RID: 198533 RVA: 0x00694ED4 File Offset: 0x006930D4
		public INpcLookAtPosition TargetAsINpcLookAtPosition()
		{
			return this.Target<INpcLookAtPosition>().Value;
		}

		// Token: 0x1700CD0A RID: 52490
		// (get) Token: 0x06030786 RID: 198534 RVA: 0x00694EF0 File Offset: 0x006930F0
		public bool IsKeepOverAngle
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CD0B RID: 52491
		// (get) Token: 0x06030787 RID: 198535 RVA: 0x00694F30 File Offset: 0x00693130
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

		// Token: 0x1700CD0C RID: 52492
		// (get) Token: 0x06030788 RID: 198536 RVA: 0x00694F74 File Offset: 0x00693174
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

		// Token: 0x1700CD0D RID: 52493
		// (get) Token: 0x06030789 RID: 198537 RVA: 0x00694FB8 File Offset: 0x006931B8
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

		// Token: 0x0603078A RID: 198538 RVA: 0x00694FF5 File Offset: 0x006931F5
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

		// Token: 0x0603078B RID: 198539 RVA: 0x00695031 File Offset: 0x00693231
		public static void StartINpcLookAtConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0603078C RID: 198540 RVA: 0x0069503A File Offset: 0x0069323A
		public static void AddTargetType(FlatBufferBuilder builder, TNpcLookAtType targetType)
		{
			builder.AddByte(0, (byte)targetType, 0);
		}

		// Token: 0x0603078D RID: 198541 RVA: 0x00695045 File Offset: 0x00693245
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(1, targetOffset, 0);
		}

		// Token: 0x0603078E RID: 198542 RVA: 0x00695050 File Offset: 0x00693250
		public static void AddIsKeepOverAngle(FlatBufferBuilder builder, bool isKeepOverAngle)
		{
			builder.AddBool(2, isKeepOverAngle, false);
		}

		// Token: 0x0603078F RID: 198543 RVA: 0x0069505B File Offset: 0x0069325B
		public static void AddMaxDistance(FlatBufferBuilder builder, float maxDistance)
		{
			builder.AddFloat(3, maxDistance, 0.0);
		}

		// Token: 0x06030790 RID: 198544 RVA: 0x0069506E File Offset: 0x0069326E
		public static void AddMaxAngle(FlatBufferBuilder builder, float maxAngle)
		{
			builder.AddFloat(4, maxAngle, 0.0);
		}

		// Token: 0x06030791 RID: 198545 RVA: 0x00695081 File Offset: 0x00693281
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06030792 RID: 198546 RVA: 0x0069508C File Offset: 0x0069328C
		public static Offset<INpcLookAtConfig> EndINpcLookAtConfig(FlatBufferBuilder builder)
		{
			return new Offset<INpcLookAtConfig>(builder.EndTable());
		}

		// Token: 0x06030793 RID: 198547 RVA: 0x0069509C File Offset: 0x0069329C
		public INpcLookAtConfigT UnPack()
		{
			INpcLookAtConfigT npcLookAtConfigT = new INpcLookAtConfigT();
			this.UnPackTo(npcLookAtConfigT);
			return npcLookAtConfigT;
		}

		// Token: 0x06030794 RID: 198548 RVA: 0x006950B8 File Offset: 0x006932B8
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

		// Token: 0x06030795 RID: 198549 RVA: 0x006951D8 File Offset: 0x006933D8
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

		// Token: 0x040114A4 RID: 70820
		private Table __p;
	}
}

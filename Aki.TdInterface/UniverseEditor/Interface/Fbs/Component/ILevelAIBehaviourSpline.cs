using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054C4 RID: 21700
	public struct ILevelAIBehaviourSpline : IFlatbufferObject
	{
		// Token: 0x17009FE3 RID: 40931
		// (get) Token: 0x06023C18 RID: 146456 RVA: 0x004F18D4 File Offset: 0x004EFAD4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023C19 RID: 146457 RVA: 0x004F18E1 File Offset: 0x004EFAE1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023C1A RID: 146458 RVA: 0x004F18E8 File Offset: 0x004EFAE8
		public static ILevelAIBehaviourSpline GetRootAsILevelAIBehaviourSpline(ByteBuffer _bb)
		{
			return ILevelAIBehaviourSpline.GetRootAsILevelAIBehaviourSpline(_bb, default(ILevelAIBehaviourSpline));
		}

		// Token: 0x06023C1B RID: 146459 RVA: 0x004F1904 File Offset: 0x004EFB04
		public static ILevelAIBehaviourSpline GetRootAsILevelAIBehaviourSpline(ByteBuffer _bb, ILevelAIBehaviourSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023C1C RID: 146460 RVA: 0x004F1921 File Offset: 0x004EFB21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023C1D RID: 146461 RVA: 0x004F1930 File Offset: 0x004EFB30
		public ILevelAIBehaviourSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009FE4 RID: 40932
		// (get) Token: 0x06023C1E RID: 146462 RVA: 0x004F1940 File Offset: 0x004EFB40
		public ELevelAIBehaviourType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELevelAIBehaviourType.Spline;
				}
				return (ELevelAIBehaviourType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009FE5 RID: 40933
		// (get) Token: 0x06023C1F RID: 146463 RVA: 0x004F197C File Offset: 0x004EFB7C
		public int SplineEntityId
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

		// Token: 0x17009FE6 RID: 40934
		// (get) Token: 0x06023C20 RID: 146464 RVA: 0x004F19B8 File Offset: 0x004EFBB8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023C21 RID: 146465 RVA: 0x004F19F4 File Offset: 0x004EFBF4
		public static Offset<ILevelAIBehaviourSpline> CreateILevelAIBehaviourSpline(FlatBufferBuilder builder, ELevelAIBehaviourType Type = ELevelAIBehaviourType.Spline, int SplineEntityId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ILevelAIBehaviourSpline.AddSplineEntityId(builder, SplineEntityId);
			ILevelAIBehaviourSpline.AddNullMask(builder, NullMask);
			ILevelAIBehaviourSpline.AddType(builder, Type);
			return ILevelAIBehaviourSpline.EndILevelAIBehaviourSpline(builder);
		}

		// Token: 0x06023C22 RID: 146466 RVA: 0x004F1A18 File Offset: 0x004EFC18
		public static void StartILevelAIBehaviourSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06023C23 RID: 146467 RVA: 0x004F1A21 File Offset: 0x004EFC21
		public static void AddType(FlatBufferBuilder builder, ELevelAIBehaviourType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023C24 RID: 146468 RVA: 0x004F1A2C File Offset: 0x004EFC2C
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(1, splineEntityId, 0);
		}

		// Token: 0x06023C25 RID: 146469 RVA: 0x004F1A37 File Offset: 0x004EFC37
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06023C26 RID: 146470 RVA: 0x004F1A42 File Offset: 0x004EFC42
		public static Offset<ILevelAIBehaviourSpline> EndILevelAIBehaviourSpline(FlatBufferBuilder builder)
		{
			return new Offset<ILevelAIBehaviourSpline>(builder.EndTable());
		}

		// Token: 0x06023C27 RID: 146471 RVA: 0x004F1A50 File Offset: 0x004EFC50
		public ILevelAIBehaviourSplineT UnPack()
		{
			ILevelAIBehaviourSplineT levelAIBehaviourSplineT = new ILevelAIBehaviourSplineT();
			this.UnPackTo(levelAIBehaviourSplineT);
			return levelAIBehaviourSplineT;
		}

		// Token: 0x06023C28 RID: 146472 RVA: 0x004F1A6B File Offset: 0x004EFC6B
		public void UnPackTo(ILevelAIBehaviourSplineT _o)
		{
			_o.Type = this.Type;
			_o.SplineEntityId = this.SplineEntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023C29 RID: 146473 RVA: 0x004F1A94 File Offset: 0x004EFC94
		public static Offset<ILevelAIBehaviourSpline> Pack(FlatBufferBuilder builder, ILevelAIBehaviourSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelAIBehaviourSpline>);
			}
			return ILevelAIBehaviourSpline.CreateILevelAIBehaviourSpline(builder, _o.Type, _o.SplineEntityId, _o.NullMask);
		}

		// Token: 0x0400E77E RID: 59262
		private Table __p;
	}
}

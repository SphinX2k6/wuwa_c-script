using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E11 RID: 15889
	public struct IBvbCardFilterCheckIsCore : IFlatbufferObject
	{
		// Token: 0x17006B4D RID: 27469
		// (get) Token: 0x060155BA RID: 87482 RVA: 0x00315E72 File Offset: 0x00314072
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060155BB RID: 87483 RVA: 0x00315E7F File Offset: 0x0031407F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060155BC RID: 87484 RVA: 0x00315E88 File Offset: 0x00314088
		public static IBvbCardFilterCheckIsCore GetRootAsIBvbCardFilterCheckIsCore(ByteBuffer _bb)
		{
			return IBvbCardFilterCheckIsCore.GetRootAsIBvbCardFilterCheckIsCore(_bb, default(IBvbCardFilterCheckIsCore));
		}

		// Token: 0x060155BD RID: 87485 RVA: 0x00315EA4 File Offset: 0x003140A4
		public static IBvbCardFilterCheckIsCore GetRootAsIBvbCardFilterCheckIsCore(ByteBuffer _bb, IBvbCardFilterCheckIsCore obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060155BE RID: 87486 RVA: 0x00315EC1 File Offset: 0x003140C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060155BF RID: 87487 RVA: 0x00315ED0 File Offset: 0x003140D0
		public IBvbCardFilterCheckIsCore __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B4E RID: 27470
		// (get) Token: 0x060155C0 RID: 87488 RVA: 0x00315EE0 File Offset: 0x003140E0
		public EBvbCardFilterType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBvbCardFilterType.CompareCost;
				}
				return (EBvbCardFilterType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006B4F RID: 27471
		// (get) Token: 0x060155C1 RID: 87489 RVA: 0x00315F1C File Offset: 0x0031411C
		public bool IsCore
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060155C2 RID: 87490 RVA: 0x00315F5B File Offset: 0x0031415B
		public static Offset<IBvbCardFilterCheckIsCore> CreateIBvbCardFilterCheckIsCore(FlatBufferBuilder builder, EBvbCardFilterType Type = EBvbCardFilterType.CompareCost, bool IsCore = false)
		{
			builder.StartTable(2);
			IBvbCardFilterCheckIsCore.AddIsCore(builder, IsCore);
			IBvbCardFilterCheckIsCore.AddType(builder, Type);
			return IBvbCardFilterCheckIsCore.EndIBvbCardFilterCheckIsCore(builder);
		}

		// Token: 0x060155C3 RID: 87491 RVA: 0x00315F78 File Offset: 0x00314178
		public static void StartIBvbCardFilterCheckIsCore(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060155C4 RID: 87492 RVA: 0x00315F81 File Offset: 0x00314181
		public static void AddType(FlatBufferBuilder builder, EBvbCardFilterType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060155C5 RID: 87493 RVA: 0x00315F8C File Offset: 0x0031418C
		public static void AddIsCore(FlatBufferBuilder builder, bool isCore)
		{
			builder.AddBool(1, isCore, false);
		}

		// Token: 0x060155C6 RID: 87494 RVA: 0x00315F97 File Offset: 0x00314197
		public static Offset<IBvbCardFilterCheckIsCore> EndIBvbCardFilterCheckIsCore(FlatBufferBuilder builder)
		{
			return new Offset<IBvbCardFilterCheckIsCore>(builder.EndTable());
		}

		// Token: 0x060155C7 RID: 87495 RVA: 0x00315FA4 File Offset: 0x003141A4
		public IBvbCardFilterCheckIsCoreT UnPack()
		{
			IBvbCardFilterCheckIsCoreT bvbCardFilterCheckIsCoreT = new IBvbCardFilterCheckIsCoreT();
			this.UnPackTo(bvbCardFilterCheckIsCoreT);
			return bvbCardFilterCheckIsCoreT;
		}

		// Token: 0x060155C8 RID: 87496 RVA: 0x00315FBF File Offset: 0x003141BF
		public void UnPackTo(IBvbCardFilterCheckIsCoreT _o)
		{
			_o.Type = this.Type;
			_o.IsCore = this.IsCore;
		}

		// Token: 0x060155C9 RID: 87497 RVA: 0x00315FDC File Offset: 0x003141DC
		public static Offset<IBvbCardFilterCheckIsCore> Pack(FlatBufferBuilder builder, IBvbCardFilterCheckIsCoreT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbCardFilterCheckIsCore>);
			}
			return IBvbCardFilterCheckIsCore.CreateIBvbCardFilterCheckIsCore(builder, _o.Type, _o.IsCore);
		}

		// Token: 0x0400B7D7 RID: 47063
		private Table __p;
	}
}

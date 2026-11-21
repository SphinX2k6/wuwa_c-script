using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F93 RID: 24467
	public struct ISplineType : IFlatbufferObject
	{
		// Token: 0x1700B534 RID: 46388
		// (get) Token: 0x06029254 RID: 168532 RVA: 0x0059E5DB File Offset: 0x0059C7DB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029255 RID: 168533 RVA: 0x0059E5E8 File Offset: 0x0059C7E8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029256 RID: 168534 RVA: 0x0059E5F0 File Offset: 0x0059C7F0
		public static ISplineType GetRootAsISplineType(ByteBuffer _bb)
		{
			return ISplineType.GetRootAsISplineType(_bb, default(ISplineType));
		}

		// Token: 0x06029257 RID: 168535 RVA: 0x0059E60C File Offset: 0x0059C80C
		public static ISplineType GetRootAsISplineType(ByteBuffer _bb, ISplineType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029258 RID: 168536 RVA: 0x0059E629 File Offset: 0x0059C829
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029259 RID: 168537 RVA: 0x0059E638 File Offset: 0x0059C838
		public ISplineType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B535 RID: 46389
		// (get) Token: 0x0602925A RID: 168538 RVA: 0x0059E648 File Offset: 0x0059C848
		public ESplineType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESplineType.Common;
				}
				return (ESplineType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602925B RID: 168539 RVA: 0x0059E684 File Offset: 0x0059C884
		public static Offset<ISplineType> CreateISplineType(FlatBufferBuilder builder, ESplineType Type = ESplineType.Common)
		{
			builder.StartTable(1);
			ISplineType.AddType(builder, Type);
			return ISplineType.EndISplineType(builder);
		}

		// Token: 0x0602925C RID: 168540 RVA: 0x0059E69A File Offset: 0x0059C89A
		public static void StartISplineType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602925D RID: 168541 RVA: 0x0059E6A3 File Offset: 0x0059C8A3
		public static void AddType(FlatBufferBuilder builder, ESplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602925E RID: 168542 RVA: 0x0059E6AE File Offset: 0x0059C8AE
		public static Offset<ISplineType> EndISplineType(FlatBufferBuilder builder)
		{
			return new Offset<ISplineType>(builder.EndTable());
		}

		// Token: 0x0602925F RID: 168543 RVA: 0x0059E6BC File Offset: 0x0059C8BC
		public ISplineTypeT UnPack()
		{
			ISplineTypeT splineTypeT = new ISplineTypeT();
			this.UnPackTo(splineTypeT);
			return splineTypeT;
		}

		// Token: 0x06029260 RID: 168544 RVA: 0x0059E6D7 File Offset: 0x0059C8D7
		public void UnPackTo(ISplineTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06029261 RID: 168545 RVA: 0x0059E6E8 File Offset: 0x0059C8E8
		public static Offset<ISplineType> Pack(FlatBufferBuilder builder, ISplineTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISplineType>);
			}
			return ISplineType.CreateISplineType(builder, _o.Type);
		}

		// Token: 0x0400FC70 RID: 64624
		private Table __p;
	}
}

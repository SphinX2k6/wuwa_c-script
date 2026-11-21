using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FA7 RID: 28583
	public struct IHideRangeType : IFlatbufferObject
	{
		// Token: 0x1700D15C RID: 53596
		// (get) Token: 0x060317C3 RID: 202691 RVA: 0x006B532A File Offset: 0x006B352A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060317C4 RID: 202692 RVA: 0x006B5337 File Offset: 0x006B3537
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060317C5 RID: 202693 RVA: 0x006B5340 File Offset: 0x006B3540
		public static IHideRangeType GetRootAsIHideRangeType(ByteBuffer _bb)
		{
			return IHideRangeType.GetRootAsIHideRangeType(_bb, default(IHideRangeType));
		}

		// Token: 0x060317C6 RID: 202694 RVA: 0x006B535C File Offset: 0x006B355C
		public static IHideRangeType GetRootAsIHideRangeType(ByteBuffer _bb, IHideRangeType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060317C7 RID: 202695 RVA: 0x006B5379 File Offset: 0x006B3579
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060317C8 RID: 202696 RVA: 0x006B5388 File Offset: 0x006B3588
		public IHideRangeType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D15D RID: 53597
		// (get) Token: 0x060317C9 RID: 202697 RVA: 0x006B5398 File Offset: 0x006B3598
		public EHideType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHideType.WorldMonsterAndMonsterTreasure;
				}
				return (EHideType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060317CA RID: 202698 RVA: 0x006B53D4 File Offset: 0x006B35D4
		public static Offset<IHideRangeType> CreateIHideRangeType(FlatBufferBuilder builder, EHideType Type = EHideType.WorldMonsterAndMonsterTreasure)
		{
			builder.StartTable(1);
			IHideRangeType.AddType(builder, Type);
			return IHideRangeType.EndIHideRangeType(builder);
		}

		// Token: 0x060317CB RID: 202699 RVA: 0x006B53EA File Offset: 0x006B35EA
		public static void StartIHideRangeType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060317CC RID: 202700 RVA: 0x006B53F3 File Offset: 0x006B35F3
		public static void AddType(FlatBufferBuilder builder, EHideType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060317CD RID: 202701 RVA: 0x006B53FE File Offset: 0x006B35FE
		public static Offset<IHideRangeType> EndIHideRangeType(FlatBufferBuilder builder)
		{
			return new Offset<IHideRangeType>(builder.EndTable());
		}

		// Token: 0x060317CE RID: 202702 RVA: 0x006B540C File Offset: 0x006B360C
		public IHideRangeTypeT UnPack()
		{
			IHideRangeTypeT hideRangeTypeT = new IHideRangeTypeT();
			this.UnPackTo(hideRangeTypeT);
			return hideRangeTypeT;
		}

		// Token: 0x060317CF RID: 202703 RVA: 0x006B5427 File Offset: 0x006B3627
		public void UnPackTo(IHideRangeTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060317D0 RID: 202704 RVA: 0x006B5438 File Offset: 0x006B3638
		public static Offset<IHideRangeType> Pack(FlatBufferBuilder builder, IHideRangeTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHideRangeType>);
			}
			return IHideRangeType.CreateIHideRangeType(builder, _o.Type);
		}

		// Token: 0x04011ED0 RID: 73424
		private Table __p;
	}
}

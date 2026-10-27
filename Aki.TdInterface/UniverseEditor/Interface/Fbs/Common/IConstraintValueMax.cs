using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D79 RID: 23929
	public struct IConstraintValueMax : IFlatbufferObject
	{
		// Token: 0x1700B33A RID: 45882
		// (get) Token: 0x06028EFA RID: 167674 RVA: 0x0059F644 File Offset: 0x0059D844
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028EFB RID: 167675 RVA: 0x0059F651 File Offset: 0x0059D851
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028EFC RID: 167676 RVA: 0x0059F658 File Offset: 0x0059D858
		public static IConstraintValueMax GetRootAsIConstraintValueMax(ByteBuffer _bb)
		{
			return IConstraintValueMax.GetRootAsIConstraintValueMax(_bb, default(IConstraintValueMax));
		}

		// Token: 0x06028EFD RID: 167677 RVA: 0x0059F674 File Offset: 0x0059D874
		public static IConstraintValueMax GetRootAsIConstraintValueMax(ByteBuffer _bb, IConstraintValueMax obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028EFE RID: 167678 RVA: 0x0059F691 File Offset: 0x0059D891
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028EFF RID: 167679 RVA: 0x0059F6A0 File Offset: 0x0059D8A0
		public IConstraintValueMax __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B33B RID: 45883
		// (get) Token: 0x06028F00 RID: 167680 RVA: 0x0059F6B0 File Offset: 0x0059D8B0
		public EConstraintValueType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EConstraintValueType.Max;
				}
				return (EConstraintValueType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B33C RID: 45884
		// (get) Token: 0x06028F01 RID: 167681 RVA: 0x0059F6EC File Offset: 0x0059D8EC
		public float MaxValue
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028F02 RID: 167682 RVA: 0x0059F72C File Offset: 0x0059D92C
		public static Offset<IConstraintValueMax> CreateIConstraintValueMax(FlatBufferBuilder builder, EConstraintValueType Type = EConstraintValueType.Max, float MaxValue = 0f)
		{
			builder.StartTable(2);
			IConstraintValueMax.AddMaxValue(builder, MaxValue);
			IConstraintValueMax.AddType(builder, Type);
			return IConstraintValueMax.EndIConstraintValueMax(builder);
		}

		// Token: 0x06028F03 RID: 167683 RVA: 0x0059F749 File Offset: 0x0059D949
		public static void StartIConstraintValueMax(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06028F04 RID: 167684 RVA: 0x0059F752 File Offset: 0x0059D952
		public static void AddType(FlatBufferBuilder builder, EConstraintValueType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028F05 RID: 167685 RVA: 0x0059F75D File Offset: 0x0059D95D
		public static void AddMaxValue(FlatBufferBuilder builder, float maxValue)
		{
			builder.AddFloat(1, maxValue, 0.0);
		}

		// Token: 0x06028F06 RID: 167686 RVA: 0x0059F770 File Offset: 0x0059D970
		public static Offset<IConstraintValueMax> EndIConstraintValueMax(FlatBufferBuilder builder)
		{
			return new Offset<IConstraintValueMax>(builder.EndTable());
		}

		// Token: 0x06028F07 RID: 167687 RVA: 0x0059F780 File Offset: 0x0059D980
		public IConstraintValueMaxT UnPack()
		{
			IConstraintValueMaxT constraintValueMaxT = new IConstraintValueMaxT();
			this.UnPackTo(constraintValueMaxT);
			return constraintValueMaxT;
		}

		// Token: 0x06028F08 RID: 167688 RVA: 0x0059F79B File Offset: 0x0059D99B
		public void UnPackTo(IConstraintValueMaxT _o)
		{
			_o.Type = this.Type;
			_o.MaxValue = this.MaxValue;
		}

		// Token: 0x06028F09 RID: 167689 RVA: 0x0059F7B8 File Offset: 0x0059D9B8
		public static Offset<IConstraintValueMax> Pack(FlatBufferBuilder builder, IConstraintValueMaxT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConstraintValueMax>);
			}
			return IConstraintValueMax.CreateIConstraintValueMax(builder, _o.Type, _o.MaxValue);
		}

		// Token: 0x0400F744 RID: 63300
		private Table __p;
	}
}

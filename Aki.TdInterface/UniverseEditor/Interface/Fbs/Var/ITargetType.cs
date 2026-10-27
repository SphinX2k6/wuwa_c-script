using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AE7 RID: 15079
	public struct ITargetType : IFlatbufferObject
	{
		// Token: 0x17006770 RID: 26480
		// (get) Token: 0x060148B4 RID: 84148 RVA: 0x002FDF25 File Offset: 0x002FC125
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060148B5 RID: 84149 RVA: 0x002FDF32 File Offset: 0x002FC132
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060148B6 RID: 84150 RVA: 0x002FDF3C File Offset: 0x002FC13C
		public static ITargetType GetRootAsITargetType(ByteBuffer _bb)
		{
			return ITargetType.GetRootAsITargetType(_bb, default(ITargetType));
		}

		// Token: 0x060148B7 RID: 84151 RVA: 0x002FDF58 File Offset: 0x002FC158
		public static ITargetType GetRootAsITargetType(ByteBuffer _bb, ITargetType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060148B8 RID: 84152 RVA: 0x002FDF75 File Offset: 0x002FC175
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060148B9 RID: 84153 RVA: 0x002FDF84 File Offset: 0x002FC184
		public ITargetType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006771 RID: 26481
		// (get) Token: 0x060148BA RID: 84154 RVA: 0x002FDF94 File Offset: 0x002FC194
		public ETargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetType.Player;
				}
				return (ETargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060148BB RID: 84155 RVA: 0x002FDFD0 File Offset: 0x002FC1D0
		public static Offset<ITargetType> CreateITargetType(FlatBufferBuilder builder, ETargetType Type = ETargetType.Player)
		{
			builder.StartTable(1);
			ITargetType.AddType(builder, Type);
			return ITargetType.EndITargetType(builder);
		}

		// Token: 0x060148BC RID: 84156 RVA: 0x002FDFE6 File Offset: 0x002FC1E6
		public static void StartITargetType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060148BD RID: 84157 RVA: 0x002FDFEF File Offset: 0x002FC1EF
		public static void AddType(FlatBufferBuilder builder, ETargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060148BE RID: 84158 RVA: 0x002FDFFA File Offset: 0x002FC1FA
		public static Offset<ITargetType> EndITargetType(FlatBufferBuilder builder)
		{
			return new Offset<ITargetType>(builder.EndTable());
		}

		// Token: 0x060148BF RID: 84159 RVA: 0x002FE008 File Offset: 0x002FC208
		public ITargetTypeT UnPack()
		{
			ITargetTypeT targetTypeT = new ITargetTypeT();
			this.UnPackTo(targetTypeT);
			return targetTypeT;
		}

		// Token: 0x060148C0 RID: 84160 RVA: 0x002FE023 File Offset: 0x002FC223
		public void UnPackTo(ITargetTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060148C1 RID: 84161 RVA: 0x002FE034 File Offset: 0x002FC234
		public static Offset<ITargetType> Pack(FlatBufferBuilder builder, ITargetTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetType>);
			}
			return ITargetType.CreateITargetType(builder, _o.Type);
		}

		// Token: 0x0400AFA7 RID: 44967
		private Table __p;
	}
}

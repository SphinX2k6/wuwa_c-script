using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200539D RID: 21405
	public struct IAirWallAlongSplineStyle : IFlatbufferObject
	{
		// Token: 0x17009764 RID: 38756
		// (get) Token: 0x06021669 RID: 136809 RVA: 0x0049BDC9 File Offset: 0x00499FC9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602166A RID: 136810 RVA: 0x0049BDD6 File Offset: 0x00499FD6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602166B RID: 136811 RVA: 0x0049BDE0 File Offset: 0x00499FE0
		public static IAirWallAlongSplineStyle GetRootAsIAirWallAlongSplineStyle(ByteBuffer _bb)
		{
			return IAirWallAlongSplineStyle.GetRootAsIAirWallAlongSplineStyle(_bb, default(IAirWallAlongSplineStyle));
		}

		// Token: 0x0602166C RID: 136812 RVA: 0x0049BDFC File Offset: 0x00499FFC
		public static IAirWallAlongSplineStyle GetRootAsIAirWallAlongSplineStyle(ByteBuffer _bb, IAirWallAlongSplineStyle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602166D RID: 136813 RVA: 0x0049BE19 File Offset: 0x0049A019
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602166E RID: 136814 RVA: 0x0049BE28 File Offset: 0x0049A028
		public IAirWallAlongSplineStyle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009765 RID: 38757
		// (get) Token: 0x0602166F RID: 136815 RVA: 0x0049BE38 File Offset: 0x0049A038
		public EAirWallSpawnStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAirWallSpawnStyle.AlongSpline;
				}
				return (EAirWallSpawnStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009766 RID: 38758
		// (get) Token: 0x06021670 RID: 136816 RVA: 0x0049BE74 File Offset: 0x0049A074
		public EAirWallAlignType AlignType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EAirWallAlignType.Center;
				}
				return (EAirWallAlignType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009767 RID: 38759
		// (get) Token: 0x06021671 RID: 136817 RVA: 0x0049BEB0 File Offset: 0x0049A0B0
		public IAirWallCover? Cover
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IAirWallCover?(default(IAirWallCover).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06021672 RID: 136818 RVA: 0x0049BF0D File Offset: 0x0049A10D
		public static Offset<IAirWallAlongSplineStyle> CreateIAirWallAlongSplineStyle(FlatBufferBuilder builder, EAirWallSpawnStyle Type = EAirWallSpawnStyle.AlongSpline, EAirWallAlignType AlignType = EAirWallAlignType.Center, Offset<IAirWallCover> CoverOffset = default(Offset<IAirWallCover>))
		{
			builder.StartTable(3);
			IAirWallAlongSplineStyle.AddCover(builder, CoverOffset);
			IAirWallAlongSplineStyle.AddAlignType(builder, AlignType);
			IAirWallAlongSplineStyle.AddType(builder, Type);
			return IAirWallAlongSplineStyle.EndIAirWallAlongSplineStyle(builder);
		}

		// Token: 0x06021673 RID: 136819 RVA: 0x0049BF31 File Offset: 0x0049A131
		public static void StartIAirWallAlongSplineStyle(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06021674 RID: 136820 RVA: 0x0049BF3A File Offset: 0x0049A13A
		public static void AddType(FlatBufferBuilder builder, EAirWallSpawnStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021675 RID: 136821 RVA: 0x0049BF45 File Offset: 0x0049A145
		public static void AddAlignType(FlatBufferBuilder builder, EAirWallAlignType alignType)
		{
			builder.AddByte(1, (byte)alignType, 0);
		}

		// Token: 0x06021676 RID: 136822 RVA: 0x0049BF50 File Offset: 0x0049A150
		public static void AddCover(FlatBufferBuilder builder, Offset<IAirWallCover> coverOffset)
		{
			builder.AddOffset(2, coverOffset.Value, 0);
		}

		// Token: 0x06021677 RID: 136823 RVA: 0x0049BF60 File Offset: 0x0049A160
		public static Offset<IAirWallAlongSplineStyle> EndIAirWallAlongSplineStyle(FlatBufferBuilder builder)
		{
			return new Offset<IAirWallAlongSplineStyle>(builder.EndTable());
		}

		// Token: 0x06021678 RID: 136824 RVA: 0x0049BF70 File Offset: 0x0049A170
		public IAirWallAlongSplineStyleT UnPack()
		{
			IAirWallAlongSplineStyleT airWallAlongSplineStyleT = new IAirWallAlongSplineStyleT();
			this.UnPackTo(airWallAlongSplineStyleT);
			return airWallAlongSplineStyleT;
		}

		// Token: 0x06021679 RID: 136825 RVA: 0x0049BF8C File Offset: 0x0049A18C
		public void UnPackTo(IAirWallAlongSplineStyleT _o)
		{
			_o.Type = this.Type;
			_o.AlignType = this.AlignType;
			_o.Cover = ((this.Cover != null) ? this.Cover.Value.UnPack() : null);
		}

		// Token: 0x0602167A RID: 136826 RVA: 0x0049BFE0 File Offset: 0x0049A1E0
		public static Offset<IAirWallAlongSplineStyle> Pack(FlatBufferBuilder builder, IAirWallAlongSplineStyleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAirWallAlongSplineStyle>);
			}
			Offset<IAirWallCover> coverOffset = (_o.Cover == null) ? default(Offset<IAirWallCover>) : IAirWallCover.Pack(builder, _o.Cover);
			return IAirWallAlongSplineStyle.CreateIAirWallAlongSplineStyle(builder, _o.Type, _o.AlignType, coverOffset);
		}

		// Token: 0x0400E7D4 RID: 59348
		private Table __p;
	}
}

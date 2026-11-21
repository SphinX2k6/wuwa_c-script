using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005679 RID: 22137
	public struct IEffectSpline : IFlatbufferObject
	{
		// Token: 0x17009F25 RID: 40741
		// (get) Token: 0x06023668 RID: 145000 RVA: 0x004DE8A2 File Offset: 0x004DCAA2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023669 RID: 145001 RVA: 0x004DE8AF File Offset: 0x004DCAAF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602366A RID: 145002 RVA: 0x004DE8B8 File Offset: 0x004DCAB8
		public static IEffectSpline GetRootAsIEffectSpline(ByteBuffer _bb)
		{
			return IEffectSpline.GetRootAsIEffectSpline(_bb, default(IEffectSpline));
		}

		// Token: 0x0602366B RID: 145003 RVA: 0x004DE8D4 File Offset: 0x004DCAD4
		public static IEffectSpline GetRootAsIEffectSpline(ByteBuffer _bb, IEffectSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602366C RID: 145004 RVA: 0x004DE8F1 File Offset: 0x004DCAF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602366D RID: 145005 RVA: 0x004DE900 File Offset: 0x004DCB00
		public IEffectSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F26 RID: 40742
		// (get) Token: 0x0602366E RID: 145006 RVA: 0x004DE910 File Offset: 0x004DCB10
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

		// Token: 0x17009F27 RID: 40743
		// (get) Token: 0x0602366F RID: 145007 RVA: 0x004DE94C File Offset: 0x004DCB4C
		public string Effect
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023670 RID: 145008 RVA: 0x004DE983 File Offset: 0x004DCB83
		public Span<byte> GetEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06023671 RID: 145009 RVA: 0x004DE992 File Offset: 0x004DCB92
		public byte[] GetEffectArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009F28 RID: 40744
		// (get) Token: 0x06023672 RID: 145010 RVA: 0x004DE9A0 File Offset: 0x004DCBA0
		public TEffectSplineCreateOption CreateOptionType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TEffectSplineCreateOption.NONE;
				}
				return (TEffectSplineCreateOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023673 RID: 145011 RVA: 0x004DE9DC File Offset: 0x004DCBDC
		public TTable? CreateOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06023674 RID: 145012 RVA: 0x004DEA24 File Offset: 0x004DCC24
		public IEffectSplineEquidistantPointMode CreateOptionAsIEffectSplineEquidistantPointMode()
		{
			return this.CreateOption<IEffectSplineEquidistantPointMode>().Value;
		}

		// Token: 0x06023675 RID: 145013 RVA: 0x004DEA40 File Offset: 0x004DCC40
		public IEffectSplineWholeLineMode CreateOptionAsIEffectSplineWholeLineMode()
		{
			return this.CreateOption<IEffectSplineWholeLineMode>().Value;
		}

		// Token: 0x06023676 RID: 145014 RVA: 0x004DEA5C File Offset: 0x004DCC5C
		public ICommonSplinePoint? Points(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new ICommonSplinePoint?(default(ICommonSplinePoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009F29 RID: 40745
		// (get) Token: 0x06023677 RID: 145015 RVA: 0x004DEAC0 File Offset: 0x004DCCC0
		public int PointsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06023678 RID: 145016 RVA: 0x004DEAEC File Offset: 0x004DCCEC
		public static Offset<IEffectSpline> CreateIEffectSpline(FlatBufferBuilder builder, ESplineType Type = ESplineType.Common, StringOffset EffectOffset = default(StringOffset), TEffectSplineCreateOption CreateOption_type = TEffectSplineCreateOption.NONE, int CreateOptionOffset = 0, VectorOffset PointsOffset = default(VectorOffset))
		{
			builder.StartTable(5);
			IEffectSpline.AddPoints(builder, PointsOffset);
			IEffectSpline.AddCreateOption(builder, CreateOptionOffset);
			IEffectSpline.AddEffect(builder, EffectOffset);
			IEffectSpline.AddCreateOptionType(builder, CreateOption_type);
			IEffectSpline.AddType(builder, Type);
			return IEffectSpline.EndIEffectSpline(builder);
		}

		// Token: 0x06023679 RID: 145017 RVA: 0x004DEB20 File Offset: 0x004DCD20
		public static void StartIEffectSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602367A RID: 145018 RVA: 0x004DEB29 File Offset: 0x004DCD29
		public static void AddType(FlatBufferBuilder builder, ESplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602367B RID: 145019 RVA: 0x004DEB34 File Offset: 0x004DCD34
		public static void AddEffect(FlatBufferBuilder builder, StringOffset effectOffset)
		{
			builder.AddOffset(1, effectOffset.Value, 0);
		}

		// Token: 0x0602367C RID: 145020 RVA: 0x004DEB44 File Offset: 0x004DCD44
		public static void AddCreateOptionType(FlatBufferBuilder builder, TEffectSplineCreateOption createOptionType)
		{
			builder.AddByte(2, (byte)createOptionType, 0);
		}

		// Token: 0x0602367D RID: 145021 RVA: 0x004DEB4F File Offset: 0x004DCD4F
		public static void AddCreateOption(FlatBufferBuilder builder, int createOptionOffset)
		{
			builder.AddOffset(3, createOptionOffset, 0);
		}

		// Token: 0x0602367E RID: 145022 RVA: 0x004DEB5A File Offset: 0x004DCD5A
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(4, pointsOffset.Value, 0);
		}

		// Token: 0x0602367F RID: 145023 RVA: 0x004DEB6C File Offset: 0x004DCD6C
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<ICommonSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023680 RID: 145024 RVA: 0x004DEBAC File Offset: 0x004DCDAC
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<ICommonSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICommonSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023681 RID: 145025 RVA: 0x004DEBC6 File Offset: 0x004DCDC6
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICommonSplinePoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICommonSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023682 RID: 145026 RVA: 0x004DEBE4 File Offset: 0x004DCDE4
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICommonSplinePoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023683 RID: 145027 RVA: 0x004DEBFD File Offset: 0x004DCDFD
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023684 RID: 145028 RVA: 0x004DEC08 File Offset: 0x004DCE08
		public static Offset<IEffectSpline> EndIEffectSpline(FlatBufferBuilder builder)
		{
			return new Offset<IEffectSpline>(builder.EndTable());
		}

		// Token: 0x06023685 RID: 145029 RVA: 0x004DEC18 File Offset: 0x004DCE18
		public IEffectSplineT UnPack()
		{
			IEffectSplineT effectSplineT = new IEffectSplineT();
			this.UnPackTo(effectSplineT);
			return effectSplineT;
		}

		// Token: 0x06023686 RID: 145030 RVA: 0x004DEC34 File Offset: 0x004DCE34
		public void UnPackTo(IEffectSplineT _o)
		{
			_o.Type = this.Type;
			_o.Effect = this.Effect;
			_o.CreateOption = new TEffectSplineCreateOptionUnion();
			_o.CreateOption.Type = this.CreateOptionType;
			TEffectSplineCreateOption createOptionType = this.CreateOptionType;
			if (createOptionType != TEffectSplineCreateOption.IEffectSplineEquidistantPointMode)
			{
				if (createOptionType == TEffectSplineCreateOption.IEffectSplineWholeLineMode)
				{
					_o.CreateOption.Value = ((this.CreateOption<IEffectSplineWholeLineMode>() != null) ? this.CreateOption<IEffectSplineWholeLineMode>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.CreateOption.Value = ((this.CreateOption<IEffectSplineEquidistantPointMode>() != null) ? this.CreateOption<IEffectSplineEquidistantPointMode>().Value.UnPack() : null);
			}
			_o.Points = new List<ICommonSplinePointT>();
			for (int i = 0; i < this.PointsLength; i++)
			{
				_o.Points.Add((this.Points(i) != null) ? this.Points(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06023687 RID: 145031 RVA: 0x004DED4C File Offset: 0x004DCF4C
		public static Offset<IEffectSpline> Pack(FlatBufferBuilder builder, IEffectSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEffectSpline>);
			}
			StringOffset effectOffset = (_o.Effect == null) ? default(StringOffset) : builder.CreateString(_o.Effect);
			TEffectSplineCreateOption createOption_type = (_o.CreateOption == null) ? TEffectSplineCreateOption.NONE : _o.CreateOption.Type;
			int createOptionOffset = (_o.CreateOption == null) ? 0 : TEffectSplineCreateOptionUnion.Pack(builder, _o.CreateOption);
			VectorOffset pointsOffset = default(VectorOffset);
			if (_o.Points != null)
			{
				Offset<ICommonSplinePoint>[] array = new Offset<ICommonSplinePoint>[_o.Points.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICommonSplinePoint.Pack(builder, _o.Points[i]);
				}
				pointsOffset = IEffectSpline.CreatePointsVector(builder, array);
			}
			return IEffectSpline.CreateIEffectSpline(builder, _o.Type, effectOffset, createOption_type, createOptionOffset, pointsOffset);
		}

		// Token: 0x0400ED81 RID: 60801
		private Table __p;
	}
}

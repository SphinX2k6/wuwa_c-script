using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005114 RID: 20756
	public struct IEffectSpline : IFlatbufferObject
	{
		// Token: 0x17009738 RID: 38712
		// (get) Token: 0x06021714 RID: 136980 RVA: 0x004A4916 File Offset: 0x004A2B16
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021715 RID: 136981 RVA: 0x004A4923 File Offset: 0x004A2B23
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021716 RID: 136982 RVA: 0x004A492C File Offset: 0x004A2B2C
		public static IEffectSpline GetRootAsIEffectSpline(ByteBuffer _bb)
		{
			return IEffectSpline.GetRootAsIEffectSpline(_bb, default(IEffectSpline));
		}

		// Token: 0x06021717 RID: 136983 RVA: 0x004A4948 File Offset: 0x004A2B48
		public static IEffectSpline GetRootAsIEffectSpline(ByteBuffer _bb, IEffectSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021718 RID: 136984 RVA: 0x004A4965 File Offset: 0x004A2B65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021719 RID: 136985 RVA: 0x004A4974 File Offset: 0x004A2B74
		public IEffectSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009739 RID: 38713
		// (get) Token: 0x0602171A RID: 136986 RVA: 0x004A4984 File Offset: 0x004A2B84
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

		// Token: 0x1700973A RID: 38714
		// (get) Token: 0x0602171B RID: 136987 RVA: 0x004A49C0 File Offset: 0x004A2BC0
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

		// Token: 0x0602171C RID: 136988 RVA: 0x004A49F7 File Offset: 0x004A2BF7
		public Span<byte> GetEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602171D RID: 136989 RVA: 0x004A4A06 File Offset: 0x004A2C06
		public byte[] GetEffectArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700973B RID: 38715
		// (get) Token: 0x0602171E RID: 136990 RVA: 0x004A4A14 File Offset: 0x004A2C14
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

		// Token: 0x0602171F RID: 136991 RVA: 0x004A4A50 File Offset: 0x004A2C50
		public TTable? CreateOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06021720 RID: 136992 RVA: 0x004A4A98 File Offset: 0x004A2C98
		public IEffectSplineEquidistantPointMode CreateOptionAsIEffectSplineEquidistantPointMode()
		{
			return this.CreateOption<IEffectSplineEquidistantPointMode>().Value;
		}

		// Token: 0x06021721 RID: 136993 RVA: 0x004A4AB4 File Offset: 0x004A2CB4
		public IEffectSplineWholeLineMode CreateOptionAsIEffectSplineWholeLineMode()
		{
			return this.CreateOption<IEffectSplineWholeLineMode>().Value;
		}

		// Token: 0x06021722 RID: 136994 RVA: 0x004A4AD0 File Offset: 0x004A2CD0
		public ICommonSplinePoint? Points(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new ICommonSplinePoint?(default(ICommonSplinePoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700973C RID: 38716
		// (get) Token: 0x06021723 RID: 136995 RVA: 0x004A4B34 File Offset: 0x004A2D34
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

		// Token: 0x06021724 RID: 136996 RVA: 0x004A4B60 File Offset: 0x004A2D60
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

		// Token: 0x06021725 RID: 136997 RVA: 0x004A4B94 File Offset: 0x004A2D94
		public static void StartIEffectSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06021726 RID: 136998 RVA: 0x004A4B9D File Offset: 0x004A2D9D
		public static void AddType(FlatBufferBuilder builder, ESplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021727 RID: 136999 RVA: 0x004A4BA8 File Offset: 0x004A2DA8
		public static void AddEffect(FlatBufferBuilder builder, StringOffset effectOffset)
		{
			builder.AddOffset(1, effectOffset.Value, 0);
		}

		// Token: 0x06021728 RID: 137000 RVA: 0x004A4BB8 File Offset: 0x004A2DB8
		public static void AddCreateOptionType(FlatBufferBuilder builder, TEffectSplineCreateOption createOptionType)
		{
			builder.AddByte(2, (byte)createOptionType, 0);
		}

		// Token: 0x06021729 RID: 137001 RVA: 0x004A4BC3 File Offset: 0x004A2DC3
		public static void AddCreateOption(FlatBufferBuilder builder, int createOptionOffset)
		{
			builder.AddOffset(3, createOptionOffset, 0);
		}

		// Token: 0x0602172A RID: 137002 RVA: 0x004A4BCE File Offset: 0x004A2DCE
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(4, pointsOffset.Value, 0);
		}

		// Token: 0x0602172B RID: 137003 RVA: 0x004A4BE0 File Offset: 0x004A2DE0
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<ICommonSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602172C RID: 137004 RVA: 0x004A4C20 File Offset: 0x004A2E20
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<ICommonSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICommonSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602172D RID: 137005 RVA: 0x004A4C3A File Offset: 0x004A2E3A
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICommonSplinePoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICommonSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602172E RID: 137006 RVA: 0x004A4C58 File Offset: 0x004A2E58
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICommonSplinePoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602172F RID: 137007 RVA: 0x004A4C71 File Offset: 0x004A2E71
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021730 RID: 137008 RVA: 0x004A4C7C File Offset: 0x004A2E7C
		public static Offset<IEffectSpline> EndIEffectSpline(FlatBufferBuilder builder)
		{
			return new Offset<IEffectSpline>(builder.EndTable());
		}

		// Token: 0x06021731 RID: 137009 RVA: 0x004A4C8C File Offset: 0x004A2E8C
		public IEffectSplineT UnPack()
		{
			IEffectSplineT effectSplineT = new IEffectSplineT();
			this.UnPackTo(effectSplineT);
			return effectSplineT;
		}

		// Token: 0x06021732 RID: 137010 RVA: 0x004A4CA8 File Offset: 0x004A2EA8
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

		// Token: 0x06021733 RID: 137011 RVA: 0x004A4DC0 File Offset: 0x004A2FC0
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

		// Token: 0x0400E184 RID: 57732
		private Table __p;
	}
}

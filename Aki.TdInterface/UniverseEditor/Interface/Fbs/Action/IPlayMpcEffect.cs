using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D2F RID: 27951
	public struct IPlayMpcEffect : IFlatbufferObject
	{
		// Token: 0x1700D03E RID: 53310
		// (get) Token: 0x060314FC RID: 201980 RVA: 0x006B0259 File Offset: 0x006AE459
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060314FD RID: 201981 RVA: 0x006B0266 File Offset: 0x006AE466
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060314FE RID: 201982 RVA: 0x006B0270 File Offset: 0x006AE470
		public static IPlayMpcEffect GetRootAsIPlayMpcEffect(ByteBuffer _bb)
		{
			return IPlayMpcEffect.GetRootAsIPlayMpcEffect(_bb, default(IPlayMpcEffect));
		}

		// Token: 0x060314FF RID: 201983 RVA: 0x006B028C File Offset: 0x006AE48C
		public static IPlayMpcEffect GetRootAsIPlayMpcEffect(ByteBuffer _bb, IPlayMpcEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031500 RID: 201984 RVA: 0x006B02A9 File Offset: 0x006AE4A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031501 RID: 201985 RVA: 0x006B02B8 File Offset: 0x006AE4B8
		public IPlayMpcEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D03F RID: 53311
		// (get) Token: 0x06031502 RID: 201986 RVA: 0x006B02C8 File Offset: 0x006AE4C8
		public EEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEffectType.Effect;
				}
				return (EEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D040 RID: 53312
		// (get) Token: 0x06031503 RID: 201987 RVA: 0x006B0304 File Offset: 0x006AE504
		public string Path
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

		// Token: 0x06031504 RID: 201988 RVA: 0x006B033B File Offset: 0x006AE53B
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06031505 RID: 201989 RVA: 0x006B034A File Offset: 0x006AE54A
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D041 RID: 53313
		// (get) Token: 0x06031506 RID: 201990 RVA: 0x006B0358 File Offset: 0x006AE558
		public TPos2 Pos2Type
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TPos2.NONE;
				}
				return (TPos2)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031507 RID: 201991 RVA: 0x006B0394 File Offset: 0x006AE594
		public TTable? Pos2<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06031508 RID: 201992 RVA: 0x006B03DC File Offset: 0x006AE5DC
		public IAbsolutePos2 Pos2AsIAbsolutePos2()
		{
			return this.Pos2<IAbsolutePos2>().Value;
		}

		// Token: 0x06031509 RID: 201993 RVA: 0x006B03F8 File Offset: 0x006AE5F8
		public IEntityPos2 Pos2AsIEntityPos2()
		{
			return this.Pos2<IEntityPos2>().Value;
		}

		// Token: 0x0603150A RID: 201994 RVA: 0x006B0414 File Offset: 0x006AE614
		public IPlayerPos2 Pos2AsIPlayerPos2()
		{
			return this.Pos2<IPlayerPos2>().Value;
		}

		// Token: 0x0603150B RID: 201995 RVA: 0x006B0430 File Offset: 0x006AE630
		public IEffectPlayerPos2 Pos2AsIEffectPlayerPos2()
		{
			return this.Pos2<IEffectPlayerPos2>().Value;
		}

		// Token: 0x0603150C RID: 201996 RVA: 0x006B044C File Offset: 0x006AE64C
		public IEffectEntityPos2 Pos2AsIEffectEntityPos2()
		{
			return this.Pos2<IEffectEntityPos2>().Value;
		}

		// Token: 0x0603150D RID: 201997 RVA: 0x006B0468 File Offset: 0x006AE668
		public IPostProcessVolumeCenterPosition? Params(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IPostProcessVolumeCenterPosition?(default(IPostProcessVolumeCenterPosition).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D042 RID: 53314
		// (get) Token: 0x0603150E RID: 201998 RVA: 0x006B04CC File Offset: 0x006AE6CC
		public int ParamsLength
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

		// Token: 0x0603150F RID: 201999 RVA: 0x006B04F8 File Offset: 0x006AE6F8
		public static Offset<IPlayMpcEffect> CreateIPlayMpcEffect(FlatBufferBuilder builder, EEffectType Type = EEffectType.Effect, StringOffset PathOffset = default(StringOffset), TPos2 Pos2_type = TPos2.NONE, int Pos2Offset = 0, VectorOffset ParamsOffset = default(VectorOffset))
		{
			builder.StartTable(5);
			IPlayMpcEffect.AddParams(builder, ParamsOffset);
			IPlayMpcEffect.AddPos2(builder, Pos2Offset);
			IPlayMpcEffect.AddPath(builder, PathOffset);
			IPlayMpcEffect.AddPos2Type(builder, Pos2_type);
			IPlayMpcEffect.AddType(builder, Type);
			return IPlayMpcEffect.EndIPlayMpcEffect(builder);
		}

		// Token: 0x06031510 RID: 202000 RVA: 0x006B052C File Offset: 0x006AE72C
		public static void StartIPlayMpcEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06031511 RID: 202001 RVA: 0x006B0535 File Offset: 0x006AE735
		public static void AddType(FlatBufferBuilder builder, EEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031512 RID: 202002 RVA: 0x006B0540 File Offset: 0x006AE740
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x06031513 RID: 202003 RVA: 0x006B0550 File Offset: 0x006AE750
		public static void AddPos2Type(FlatBufferBuilder builder, TPos2 pos2Type)
		{
			builder.AddByte(2, (byte)pos2Type, 0);
		}

		// Token: 0x06031514 RID: 202004 RVA: 0x006B055B File Offset: 0x006AE75B
		public static void AddPos2(FlatBufferBuilder builder, int pos2Offset)
		{
			builder.AddOffset(3, pos2Offset, 0);
		}

		// Token: 0x06031515 RID: 202005 RVA: 0x006B0566 File Offset: 0x006AE766
		public static void AddParams(FlatBufferBuilder builder, VectorOffset paramsOffset)
		{
			builder.AddOffset(4, paramsOffset.Value, 0);
		}

		// Token: 0x06031516 RID: 202006 RVA: 0x006B0578 File Offset: 0x006AE778
		public static VectorOffset CreateParamsVector(FlatBufferBuilder builder, Offset<IPostProcessVolumeCenterPosition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06031517 RID: 202007 RVA: 0x006B05B8 File Offset: 0x006AE7B8
		public static VectorOffset CreateParamsVectorBlock(FlatBufferBuilder builder, Offset<IPostProcessVolumeCenterPosition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPostProcessVolumeCenterPosition>>(data);
			return builder.EndVector();
		}

		// Token: 0x06031518 RID: 202008 RVA: 0x006B05D2 File Offset: 0x006AE7D2
		public static VectorOffset CreateParamsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPostProcessVolumeCenterPosition>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPostProcessVolumeCenterPosition>>(data);
			return builder.EndVector();
		}

		// Token: 0x06031519 RID: 202009 RVA: 0x006B05F0 File Offset: 0x006AE7F0
		public static VectorOffset CreateParamsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPostProcessVolumeCenterPosition>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603151A RID: 202010 RVA: 0x006B0609 File Offset: 0x006AE809
		public static void StartParamsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603151B RID: 202011 RVA: 0x006B0614 File Offset: 0x006AE814
		public static Offset<IPlayMpcEffect> EndIPlayMpcEffect(FlatBufferBuilder builder)
		{
			return new Offset<IPlayMpcEffect>(builder.EndTable());
		}

		// Token: 0x0603151C RID: 202012 RVA: 0x006B0624 File Offset: 0x006AE824
		public IPlayMpcEffectT UnPack()
		{
			IPlayMpcEffectT playMpcEffectT = new IPlayMpcEffectT();
			this.UnPackTo(playMpcEffectT);
			return playMpcEffectT;
		}

		// Token: 0x0603151D RID: 202013 RVA: 0x006B0640 File Offset: 0x006AE840
		public void UnPackTo(IPlayMpcEffectT _o)
		{
			_o.Type = this.Type;
			_o.Path = this.Path;
			_o.Pos2 = new TPos2Union();
			_o.Pos2.Type = this.Pos2Type;
			switch (this.Pos2Type)
			{
			case TPos2.IAbsolutePos2:
				_o.Pos2.Value = ((this.Pos2<IAbsolutePos2>() != null) ? this.Pos2<IAbsolutePos2>().Value.UnPack() : null);
				break;
			case TPos2.IEntityPos2:
				_o.Pos2.Value = ((this.Pos2<IEntityPos2>() != null) ? this.Pos2<IEntityPos2>().Value.UnPack() : null);
				break;
			case TPos2.IPlayerPos2:
				_o.Pos2.Value = ((this.Pos2<IPlayerPos2>() != null) ? this.Pos2<IPlayerPos2>().Value.UnPack() : null);
				break;
			case TPos2.IEffectPlayerPos2:
				_o.Pos2.Value = ((this.Pos2<IEffectPlayerPos2>() != null) ? this.Pos2<IEffectPlayerPos2>().Value.UnPack() : null);
				break;
			case TPos2.IEffectEntityPos2:
				_o.Pos2.Value = ((this.Pos2<IEffectEntityPos2>() != null) ? this.Pos2<IEffectEntityPos2>().Value.UnPack() : null);
				break;
			}
			_o.Params = new List<IPostProcessVolumeCenterPositionT>();
			for (int i = 0; i < this.ParamsLength; i++)
			{
				_o.Params.Add((this.Params(i) != null) ? this.Params(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0603151E RID: 202014 RVA: 0x006B0820 File Offset: 0x006AEA20
		public static Offset<IPlayMpcEffect> Pack(FlatBufferBuilder builder, IPlayMpcEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayMpcEffect>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			TPos2 pos2_type = (_o.Pos2 == null) ? TPos2.NONE : _o.Pos2.Type;
			int pos2Offset = (_o.Pos2 == null) ? 0 : TPos2Union.Pack(builder, _o.Pos2);
			VectorOffset paramsOffset = default(VectorOffset);
			if (_o.Params != null)
			{
				Offset<IPostProcessVolumeCenterPosition>[] array = new Offset<IPostProcessVolumeCenterPosition>[_o.Params.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IPostProcessVolumeCenterPosition.Pack(builder, _o.Params[i]);
				}
				paramsOffset = IPlayMpcEffect.CreateParamsVector(builder, array);
			}
			return IPlayMpcEffect.CreateIPlayMpcEffect(builder, _o.Type, pathOffset, pos2_type, pos2Offset, paramsOffset);
		}

		// Token: 0x040116C1 RID: 71361
		private Table __p;
	}
}

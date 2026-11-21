using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074AA RID: 29866
	public struct IPlayMpcEffect : IFlatbufferObject
	{
		// Token: 0x1700DB86 RID: 56198
		// (get) Token: 0x060344F8 RID: 214264 RVA: 0x0070B944 File Offset: 0x00709B44
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060344F9 RID: 214265 RVA: 0x0070B951 File Offset: 0x00709B51
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060344FA RID: 214266 RVA: 0x0070B958 File Offset: 0x00709B58
		public static IPlayMpcEffect GetRootAsIPlayMpcEffect(ByteBuffer _bb)
		{
			return IPlayMpcEffect.GetRootAsIPlayMpcEffect(_bb, default(IPlayMpcEffect));
		}

		// Token: 0x060344FB RID: 214267 RVA: 0x0070B974 File Offset: 0x00709B74
		public static IPlayMpcEffect GetRootAsIPlayMpcEffect(ByteBuffer _bb, IPlayMpcEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060344FC RID: 214268 RVA: 0x0070B991 File Offset: 0x00709B91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060344FD RID: 214269 RVA: 0x0070B9A0 File Offset: 0x00709BA0
		public IPlayMpcEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DB87 RID: 56199
		// (get) Token: 0x060344FE RID: 214270 RVA: 0x0070B9B0 File Offset: 0x00709BB0
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

		// Token: 0x1700DB88 RID: 56200
		// (get) Token: 0x060344FF RID: 214271 RVA: 0x0070B9EC File Offset: 0x00709BEC
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

		// Token: 0x06034500 RID: 214272 RVA: 0x0070BA23 File Offset: 0x00709C23
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06034501 RID: 214273 RVA: 0x0070BA32 File Offset: 0x00709C32
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700DB89 RID: 56201
		// (get) Token: 0x06034502 RID: 214274 RVA: 0x0070BA40 File Offset: 0x00709C40
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

		// Token: 0x06034503 RID: 214275 RVA: 0x0070BA7C File Offset: 0x00709C7C
		public TTable? Pos2<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06034504 RID: 214276 RVA: 0x0070BAC4 File Offset: 0x00709CC4
		public IAbsolutePos2 Pos2AsIAbsolutePos2()
		{
			return this.Pos2<IAbsolutePos2>().Value;
		}

		// Token: 0x06034505 RID: 214277 RVA: 0x0070BAE0 File Offset: 0x00709CE0
		public IEntityPos2 Pos2AsIEntityPos2()
		{
			return this.Pos2<IEntityPos2>().Value;
		}

		// Token: 0x06034506 RID: 214278 RVA: 0x0070BAFC File Offset: 0x00709CFC
		public IPlayerPos2 Pos2AsIPlayerPos2()
		{
			return this.Pos2<IPlayerPos2>().Value;
		}

		// Token: 0x06034507 RID: 214279 RVA: 0x0070BB18 File Offset: 0x00709D18
		public IEffectPlayerPos2 Pos2AsIEffectPlayerPos2()
		{
			return this.Pos2<IEffectPlayerPos2>().Value;
		}

		// Token: 0x06034508 RID: 214280 RVA: 0x0070BB34 File Offset: 0x00709D34
		public IEffectEntityPos2 Pos2AsIEffectEntityPos2()
		{
			return this.Pos2<IEffectEntityPos2>().Value;
		}

		// Token: 0x06034509 RID: 214281 RVA: 0x0070BB50 File Offset: 0x00709D50
		public IPostProcessVolumeCenterPosition? Params(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IPostProcessVolumeCenterPosition?(default(IPostProcessVolumeCenterPosition).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DB8A RID: 56202
		// (get) Token: 0x0603450A RID: 214282 RVA: 0x0070BBB4 File Offset: 0x00709DB4
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

		// Token: 0x0603450B RID: 214283 RVA: 0x0070BBE0 File Offset: 0x00709DE0
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

		// Token: 0x0603450C RID: 214284 RVA: 0x0070BC14 File Offset: 0x00709E14
		public static void StartIPlayMpcEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0603450D RID: 214285 RVA: 0x0070BC1D File Offset: 0x00709E1D
		public static void AddType(FlatBufferBuilder builder, EEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603450E RID: 214286 RVA: 0x0070BC28 File Offset: 0x00709E28
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x0603450F RID: 214287 RVA: 0x0070BC38 File Offset: 0x00709E38
		public static void AddPos2Type(FlatBufferBuilder builder, TPos2 pos2Type)
		{
			builder.AddByte(2, (byte)pos2Type, 0);
		}

		// Token: 0x06034510 RID: 214288 RVA: 0x0070BC43 File Offset: 0x00709E43
		public static void AddPos2(FlatBufferBuilder builder, int pos2Offset)
		{
			builder.AddOffset(3, pos2Offset, 0);
		}

		// Token: 0x06034511 RID: 214289 RVA: 0x0070BC4E File Offset: 0x00709E4E
		public static void AddParams(FlatBufferBuilder builder, VectorOffset paramsOffset)
		{
			builder.AddOffset(4, paramsOffset.Value, 0);
		}

		// Token: 0x06034512 RID: 214290 RVA: 0x0070BC60 File Offset: 0x00709E60
		public static VectorOffset CreateParamsVector(FlatBufferBuilder builder, Offset<IPostProcessVolumeCenterPosition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06034513 RID: 214291 RVA: 0x0070BCA0 File Offset: 0x00709EA0
		public static VectorOffset CreateParamsVectorBlock(FlatBufferBuilder builder, Offset<IPostProcessVolumeCenterPosition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPostProcessVolumeCenterPosition>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034514 RID: 214292 RVA: 0x0070BCBA File Offset: 0x00709EBA
		public static VectorOffset CreateParamsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPostProcessVolumeCenterPosition>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPostProcessVolumeCenterPosition>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034515 RID: 214293 RVA: 0x0070BCD8 File Offset: 0x00709ED8
		public static VectorOffset CreateParamsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPostProcessVolumeCenterPosition>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034516 RID: 214294 RVA: 0x0070BCF1 File Offset: 0x00709EF1
		public static void StartParamsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06034517 RID: 214295 RVA: 0x0070BCFC File Offset: 0x00709EFC
		public static Offset<IPlayMpcEffect> EndIPlayMpcEffect(FlatBufferBuilder builder)
		{
			return new Offset<IPlayMpcEffect>(builder.EndTable());
		}

		// Token: 0x06034518 RID: 214296 RVA: 0x0070BD0C File Offset: 0x00709F0C
		public IPlayMpcEffectT UnPack()
		{
			IPlayMpcEffectT playMpcEffectT = new IPlayMpcEffectT();
			this.UnPackTo(playMpcEffectT);
			return playMpcEffectT;
		}

		// Token: 0x06034519 RID: 214297 RVA: 0x0070BD28 File Offset: 0x00709F28
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

		// Token: 0x0603451A RID: 214298 RVA: 0x0070BF08 File Offset: 0x0070A108
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

		// Token: 0x0401263D RID: 75325
		private Table __p;
	}
}

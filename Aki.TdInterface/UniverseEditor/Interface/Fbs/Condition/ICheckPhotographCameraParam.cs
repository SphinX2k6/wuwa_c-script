using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AD5 RID: 19157
	public struct ICheckPhotographCameraParam : IFlatbufferObject
	{
		// Token: 0x17008AE4 RID: 35556
		// (get) Token: 0x0601E15E RID: 123230 RVA: 0x00438758 File Offset: 0x00436958
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E15F RID: 123231 RVA: 0x00438765 File Offset: 0x00436965
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E160 RID: 123232 RVA: 0x0043876C File Offset: 0x0043696C
		public static ICheckPhotographCameraParam GetRootAsICheckPhotographCameraParam(ByteBuffer _bb)
		{
			return ICheckPhotographCameraParam.GetRootAsICheckPhotographCameraParam(_bb, default(ICheckPhotographCameraParam));
		}

		// Token: 0x0601E161 RID: 123233 RVA: 0x00438788 File Offset: 0x00436988
		public static ICheckPhotographCameraParam GetRootAsICheckPhotographCameraParam(ByteBuffer _bb, ICheckPhotographCameraParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E162 RID: 123234 RVA: 0x004387A5 File Offset: 0x004369A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E163 RID: 123235 RVA: 0x004387B4 File Offset: 0x004369B4
		public ICheckPhotographCameraParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008AE5 RID: 35557
		// (get) Token: 0x0601E164 RID: 123236 RVA: 0x004387C4 File Offset: 0x004369C4
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008AE6 RID: 35558
		// (get) Token: 0x0601E165 RID: 123237 RVA: 0x00438800 File Offset: 0x00436A00
		public ECommonMatchType CheckType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECommonMatchType.MatchAll;
				}
				return (ECommonMatchType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E166 RID: 123238 RVA: 0x0043883C File Offset: 0x00436A3C
		public TPhotographCameraCheckType CameraParamType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TPhotographCameraCheckType.NONE;
			}
			return (TPhotographCameraCheckType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008AE7 RID: 35559
		// (get) Token: 0x0601E167 RID: 123239 RVA: 0x0043887C File Offset: 0x00436A7C
		public int CameraParamTypeLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601E168 RID: 123240 RVA: 0x004388A7 File Offset: 0x00436AA7
		public Span<TPhotographCameraCheckType> GetCameraParamTypeBytes()
		{
			return this.__p.__vector_as_span<TPhotographCameraCheckType>(8, 1);
		}

		// Token: 0x0601E169 RID: 123241 RVA: 0x004388B8 File Offset: 0x00436AB8
		public TPhotographCameraCheckType[] GetCameraParamTypeArray()
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TPhotographCameraCheckType[] array = new TPhotographCameraCheckType[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TPhotographCameraCheckType)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0601E16A RID: 123242 RVA: 0x00438924 File Offset: 0x00436B24
		public TTable? CameraParam<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17008AE8 RID: 35560
		// (get) Token: 0x0601E16B RID: 123243 RVA: 0x0043896C File Offset: 0x00436B6C
		public int CameraParamLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601E16C RID: 123244 RVA: 0x00438998 File Offset: 0x00436B98
		public static Offset<ICheckPhotographCameraParam> CreateICheckPhotographCameraParam(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECommonMatchType CheckType = ECommonMatchType.MatchAll, VectorOffset CameraParam_typeOffset = default(VectorOffset), VectorOffset CameraParamOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			ICheckPhotographCameraParam.AddCameraParam(builder, CameraParamOffset);
			ICheckPhotographCameraParam.AddCameraParamType(builder, CameraParam_typeOffset);
			ICheckPhotographCameraParam.AddCheckType(builder, CheckType);
			ICheckPhotographCameraParam.AddType(builder, Type);
			return ICheckPhotographCameraParam.EndICheckPhotographCameraParam(builder);
		}

		// Token: 0x0601E16D RID: 123245 RVA: 0x004389C4 File Offset: 0x00436BC4
		public static void StartICheckPhotographCameraParam(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601E16E RID: 123246 RVA: 0x004389CD File Offset: 0x00436BCD
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E16F RID: 123247 RVA: 0x004389D8 File Offset: 0x00436BD8
		public static void AddCheckType(FlatBufferBuilder builder, ECommonMatchType checkType)
		{
			builder.AddByte(1, (byte)checkType, 0);
		}

		// Token: 0x0601E170 RID: 123248 RVA: 0x004389E3 File Offset: 0x00436BE3
		public static void AddCameraParamType(FlatBufferBuilder builder, VectorOffset cameraParamTypeOffset)
		{
			builder.AddOffset(2, cameraParamTypeOffset.Value, 0);
		}

		// Token: 0x0601E171 RID: 123249 RVA: 0x004389F4 File Offset: 0x00436BF4
		public static VectorOffset CreateCameraParamTypeVector(FlatBufferBuilder builder, TPhotographCameraCheckType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E172 RID: 123250 RVA: 0x00438A2B File Offset: 0x00436C2B
		public static VectorOffset CreateCameraParamTypeVectorBlock(FlatBufferBuilder builder, TPhotographCameraCheckType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TPhotographCameraCheckType>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E173 RID: 123251 RVA: 0x00438A45 File Offset: 0x00436C45
		public static VectorOffset CreateCameraParamTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TPhotographCameraCheckType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TPhotographCameraCheckType>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E174 RID: 123252 RVA: 0x00438A63 File Offset: 0x00436C63
		public static VectorOffset CreateCameraParamTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TPhotographCameraCheckType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E175 RID: 123253 RVA: 0x00438A7C File Offset: 0x00436C7C
		public static void StartCameraParamTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601E176 RID: 123254 RVA: 0x00438A87 File Offset: 0x00436C87
		public static void AddCameraParam(FlatBufferBuilder builder, VectorOffset cameraParamOffset)
		{
			builder.AddOffset(3, cameraParamOffset.Value, 0);
		}

		// Token: 0x0601E177 RID: 123255 RVA: 0x00438A98 File Offset: 0x00436C98
		public static VectorOffset CreateCameraParamVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E178 RID: 123256 RVA: 0x00438ACF File Offset: 0x00436CCF
		public static VectorOffset CreateCameraParamVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E179 RID: 123257 RVA: 0x00438AE9 File Offset: 0x00436CE9
		public static VectorOffset CreateCameraParamVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E17A RID: 123258 RVA: 0x00438B07 File Offset: 0x00436D07
		public static VectorOffset CreateCameraParamVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E17B RID: 123259 RVA: 0x00438B20 File Offset: 0x00436D20
		public static void StartCameraParamVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E17C RID: 123260 RVA: 0x00438B2B File Offset: 0x00436D2B
		public static Offset<ICheckPhotographCameraParam> EndICheckPhotographCameraParam(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPhotographCameraParam>(builder.EndTable());
		}

		// Token: 0x0601E17D RID: 123261 RVA: 0x00438B38 File Offset: 0x00436D38
		public ICheckPhotographCameraParamT UnPack()
		{
			ICheckPhotographCameraParamT checkPhotographCameraParamT = new ICheckPhotographCameraParamT();
			this.UnPackTo(checkPhotographCameraParamT);
			return checkPhotographCameraParamT;
		}

		// Token: 0x0601E17E RID: 123262 RVA: 0x00438B54 File Offset: 0x00436D54
		public void UnPackTo(ICheckPhotographCameraParamT _o)
		{
			_o.Type = this.Type;
			_o.CheckType = this.CheckType;
			_o.CameraParam = new List<TPhotographCameraCheckTypeUnion>();
			for (int i = 0; i < this.CameraParamLength; i++)
			{
				TPhotographCameraCheckTypeUnion tphotographCameraCheckTypeUnion = new TPhotographCameraCheckTypeUnion();
				tphotographCameraCheckTypeUnion.Type = this.CameraParamType(i);
				switch (this.CameraParamType(i))
				{
				case TPhotographCameraCheckType.IPhotographCameraCheckAspectRatioType:
					tphotographCameraCheckTypeUnion.Value = ((this.CameraParam<IPhotographCameraCheckAspectRatioType>(i) != null) ? this.CameraParam<IPhotographCameraCheckAspectRatioType>(i).Value.UnPack() : null);
					break;
				case TPhotographCameraCheckType.IPhotographCameraCheckBlurIntensity:
					tphotographCameraCheckTypeUnion.Value = ((this.CameraParam<IPhotographCameraCheckBlurIntensity>(i) != null) ? this.CameraParam<IPhotographCameraCheckBlurIntensity>(i).Value.UnPack() : null);
					break;
				case TPhotographCameraCheckType.IPhotographCameraCheckTemplate:
					tphotographCameraCheckTypeUnion.Value = ((this.CameraParam<IPhotographCameraCheckTemplate>(i) != null) ? this.CameraParam<IPhotographCameraCheckTemplate>(i).Value.UnPack() : null);
					break;
				}
				_o.CameraParam.Add(tphotographCameraCheckTypeUnion);
			}
		}

		// Token: 0x0601E17F RID: 123263 RVA: 0x00438C7C File Offset: 0x00436E7C
		public static Offset<ICheckPhotographCameraParam> Pack(FlatBufferBuilder builder, ICheckPhotographCameraParamT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPhotographCameraParam>);
			}
			VectorOffset cameraParam_typeOffset = default(VectorOffset);
			if (_o.CameraParam != null)
			{
				TPhotographCameraCheckType[] array = new TPhotographCameraCheckType[_o.CameraParam.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.CameraParam[i].Type;
				}
				cameraParam_typeOffset = ICheckPhotographCameraParam.CreateCameraParamTypeVector(builder, array);
			}
			VectorOffset cameraParamOffset = default(VectorOffset);
			if (_o.CameraParam != null)
			{
				int[] array2 = new int[_o.CameraParam.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TPhotographCameraCheckTypeUnion.Pack(builder, _o.CameraParam[j]);
				}
				cameraParamOffset = ICheckPhotographCameraParam.CreateCameraParamVector(builder, array2);
			}
			return ICheckPhotographCameraParam.CreateICheckPhotographCameraParam(builder, _o.Type, _o.CheckType, cameraParam_typeOffset, cameraParamOffset);
		}

		// Token: 0x0400D35E RID: 54110
		private Table __p;
	}
}

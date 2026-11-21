using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FA7 RID: 20391
	public struct ICheckPhotographCameraParam : IFlatbufferObject
	{
		// Token: 0x170091D6 RID: 37334
		// (get) Token: 0x0601FC5D RID: 130141 RVA: 0x0046A204 File Offset: 0x00468404
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FC5E RID: 130142 RVA: 0x0046A211 File Offset: 0x00468411
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FC5F RID: 130143 RVA: 0x0046A218 File Offset: 0x00468418
		public static ICheckPhotographCameraParam GetRootAsICheckPhotographCameraParam(ByteBuffer _bb)
		{
			return ICheckPhotographCameraParam.GetRootAsICheckPhotographCameraParam(_bb, default(ICheckPhotographCameraParam));
		}

		// Token: 0x0601FC60 RID: 130144 RVA: 0x0046A234 File Offset: 0x00468434
		public static ICheckPhotographCameraParam GetRootAsICheckPhotographCameraParam(ByteBuffer _bb, ICheckPhotographCameraParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FC61 RID: 130145 RVA: 0x0046A251 File Offset: 0x00468451
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FC62 RID: 130146 RVA: 0x0046A260 File Offset: 0x00468460
		public ICheckPhotographCameraParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170091D7 RID: 37335
		// (get) Token: 0x0601FC63 RID: 130147 RVA: 0x0046A270 File Offset: 0x00468470
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

		// Token: 0x170091D8 RID: 37336
		// (get) Token: 0x0601FC64 RID: 130148 RVA: 0x0046A2AC File Offset: 0x004684AC
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

		// Token: 0x0601FC65 RID: 130149 RVA: 0x0046A2E8 File Offset: 0x004684E8
		public TPhotographCameraCheckType CameraParamType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TPhotographCameraCheckType.NONE;
			}
			return (TPhotographCameraCheckType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170091D9 RID: 37337
		// (get) Token: 0x0601FC66 RID: 130150 RVA: 0x0046A328 File Offset: 0x00468528
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

		// Token: 0x0601FC67 RID: 130151 RVA: 0x0046A353 File Offset: 0x00468553
		public Span<TPhotographCameraCheckType> GetCameraParamTypeBytes()
		{
			return this.__p.__vector_as_span<TPhotographCameraCheckType>(8, 1);
		}

		// Token: 0x0601FC68 RID: 130152 RVA: 0x0046A364 File Offset: 0x00468564
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

		// Token: 0x0601FC69 RID: 130153 RVA: 0x0046A3D0 File Offset: 0x004685D0
		public TTable? CameraParam<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x170091DA RID: 37338
		// (get) Token: 0x0601FC6A RID: 130154 RVA: 0x0046A418 File Offset: 0x00468618
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

		// Token: 0x0601FC6B RID: 130155 RVA: 0x0046A444 File Offset: 0x00468644
		public static Offset<ICheckPhotographCameraParam> CreateICheckPhotographCameraParam(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECommonMatchType CheckType = ECommonMatchType.MatchAll, VectorOffset CameraParam_typeOffset = default(VectorOffset), VectorOffset CameraParamOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			ICheckPhotographCameraParam.AddCameraParam(builder, CameraParamOffset);
			ICheckPhotographCameraParam.AddCameraParamType(builder, CameraParam_typeOffset);
			ICheckPhotographCameraParam.AddCheckType(builder, CheckType);
			ICheckPhotographCameraParam.AddType(builder, Type);
			return ICheckPhotographCameraParam.EndICheckPhotographCameraParam(builder);
		}

		// Token: 0x0601FC6C RID: 130156 RVA: 0x0046A470 File Offset: 0x00468670
		public static void StartICheckPhotographCameraParam(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601FC6D RID: 130157 RVA: 0x0046A479 File Offset: 0x00468679
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FC6E RID: 130158 RVA: 0x0046A484 File Offset: 0x00468684
		public static void AddCheckType(FlatBufferBuilder builder, ECommonMatchType checkType)
		{
			builder.AddByte(1, (byte)checkType, 0);
		}

		// Token: 0x0601FC6F RID: 130159 RVA: 0x0046A48F File Offset: 0x0046868F
		public static void AddCameraParamType(FlatBufferBuilder builder, VectorOffset cameraParamTypeOffset)
		{
			builder.AddOffset(2, cameraParamTypeOffset.Value, 0);
		}

		// Token: 0x0601FC70 RID: 130160 RVA: 0x0046A4A0 File Offset: 0x004686A0
		public static VectorOffset CreateCameraParamTypeVector(FlatBufferBuilder builder, TPhotographCameraCheckType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601FC71 RID: 130161 RVA: 0x0046A4D7 File Offset: 0x004686D7
		public static VectorOffset CreateCameraParamTypeVectorBlock(FlatBufferBuilder builder, TPhotographCameraCheckType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TPhotographCameraCheckType>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FC72 RID: 130162 RVA: 0x0046A4F1 File Offset: 0x004686F1
		public static VectorOffset CreateCameraParamTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TPhotographCameraCheckType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TPhotographCameraCheckType>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FC73 RID: 130163 RVA: 0x0046A50F File Offset: 0x0046870F
		public static VectorOffset CreateCameraParamTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TPhotographCameraCheckType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601FC74 RID: 130164 RVA: 0x0046A528 File Offset: 0x00468728
		public static void StartCameraParamTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601FC75 RID: 130165 RVA: 0x0046A533 File Offset: 0x00468733
		public static void AddCameraParam(FlatBufferBuilder builder, VectorOffset cameraParamOffset)
		{
			builder.AddOffset(3, cameraParamOffset.Value, 0);
		}

		// Token: 0x0601FC76 RID: 130166 RVA: 0x0046A544 File Offset: 0x00468744
		public static VectorOffset CreateCameraParamVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601FC77 RID: 130167 RVA: 0x0046A57B File Offset: 0x0046877B
		public static VectorOffset CreateCameraParamVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FC78 RID: 130168 RVA: 0x0046A595 File Offset: 0x00468795
		public static VectorOffset CreateCameraParamVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FC79 RID: 130169 RVA: 0x0046A5B3 File Offset: 0x004687B3
		public static VectorOffset CreateCameraParamVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601FC7A RID: 130170 RVA: 0x0046A5CC File Offset: 0x004687CC
		public static void StartCameraParamVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601FC7B RID: 130171 RVA: 0x0046A5D7 File Offset: 0x004687D7
		public static Offset<ICheckPhotographCameraParam> EndICheckPhotographCameraParam(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPhotographCameraParam>(builder.EndTable());
		}

		// Token: 0x0601FC7C RID: 130172 RVA: 0x0046A5E4 File Offset: 0x004687E4
		public ICheckPhotographCameraParamT UnPack()
		{
			ICheckPhotographCameraParamT checkPhotographCameraParamT = new ICheckPhotographCameraParamT();
			this.UnPackTo(checkPhotographCameraParamT);
			return checkPhotographCameraParamT;
		}

		// Token: 0x0601FC7D RID: 130173 RVA: 0x0046A600 File Offset: 0x00468800
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

		// Token: 0x0601FC7E RID: 130174 RVA: 0x0046A728 File Offset: 0x00468928
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

		// Token: 0x0400DE46 RID: 56902
		private Table __p;
	}
}

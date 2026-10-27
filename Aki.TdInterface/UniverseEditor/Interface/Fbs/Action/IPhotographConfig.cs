using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CC0 RID: 27840
	public struct IPhotographConfig : IFlatbufferObject
	{
		// Token: 0x1700CF3F RID: 53055
		// (get) Token: 0x060310F1 RID: 200945 RVA: 0x006A8726 File Offset: 0x006A6926
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060310F2 RID: 200946 RVA: 0x006A8733 File Offset: 0x006A6933
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060310F3 RID: 200947 RVA: 0x006A873C File Offset: 0x006A693C
		public static IPhotographConfig GetRootAsIPhotographConfig(ByteBuffer _bb)
		{
			return IPhotographConfig.GetRootAsIPhotographConfig(_bb, default(IPhotographConfig));
		}

		// Token: 0x060310F4 RID: 200948 RVA: 0x006A8758 File Offset: 0x006A6958
		public static IPhotographConfig GetRootAsIPhotographConfig(ByteBuffer _bb, IPhotographConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060310F5 RID: 200949 RVA: 0x006A8775 File Offset: 0x006A6975
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060310F6 RID: 200950 RVA: 0x006A8784 File Offset: 0x006A6984
		public IPhotographConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060310F7 RID: 200951 RVA: 0x006A8794 File Offset: 0x006A6994
		public int PhotoTargets(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CF40 RID: 53056
		// (get) Token: 0x060310F8 RID: 200952 RVA: 0x006A87D4 File Offset: 0x006A69D4
		public int PhotoTargetsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060310F9 RID: 200953 RVA: 0x006A87FF File Offset: 0x006A69FF
		public Span<int> GetPhotoTargetsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x060310FA RID: 200954 RVA: 0x006A880E File Offset: 0x006A6A0E
		public int[] GetPhotoTargetsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700CF41 RID: 53057
		// (get) Token: 0x060310FB RID: 200955 RVA: 0x006A881C File Offset: 0x006A6A1C
		public IPhotographPlayerPerform? PlayerPerform
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPhotographPlayerPerform?(default(IPhotographPlayerPerform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CF42 RID: 53058
		// (get) Token: 0x060310FC RID: 200956 RVA: 0x006A887C File Offset: 0x006A6A7C
		public IPhotographCameraParams? CameraParams
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IPhotographCameraParams?(default(IPhotographCameraParams).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CF43 RID: 53059
		// (get) Token: 0x060310FD RID: 200957 RVA: 0x006A88DC File Offset: 0x006A6ADC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060310FE RID: 200958 RVA: 0x006A8919 File Offset: 0x006A6B19
		public static Offset<IPhotographConfig> CreateIPhotographConfig(FlatBufferBuilder builder, VectorOffset PhotoTargetsOffset = default(VectorOffset), Offset<IPhotographPlayerPerform> PlayerPerformOffset = default(Offset<IPhotographPlayerPerform>), Offset<IPhotographCameraParams> CameraParamsOffset = default(Offset<IPhotographCameraParams>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IPhotographConfig.AddCameraParams(builder, CameraParamsOffset);
			IPhotographConfig.AddPlayerPerform(builder, PlayerPerformOffset);
			IPhotographConfig.AddPhotoTargets(builder, PhotoTargetsOffset);
			IPhotographConfig.AddNullMask(builder, NullMask);
			return IPhotographConfig.EndIPhotographConfig(builder);
		}

		// Token: 0x060310FF RID: 200959 RVA: 0x006A8945 File Offset: 0x006A6B45
		public static void StartIPhotographConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06031100 RID: 200960 RVA: 0x006A894E File Offset: 0x006A6B4E
		public static void AddPhotoTargets(FlatBufferBuilder builder, VectorOffset photoTargetsOffset)
		{
			builder.AddOffset(0, photoTargetsOffset.Value, 0);
		}

		// Token: 0x06031101 RID: 200961 RVA: 0x006A8960 File Offset: 0x006A6B60
		public static VectorOffset CreatePhotoTargetsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06031102 RID: 200962 RVA: 0x006A8997 File Offset: 0x006A6B97
		public static VectorOffset CreatePhotoTargetsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06031103 RID: 200963 RVA: 0x006A89B1 File Offset: 0x006A6BB1
		public static VectorOffset CreatePhotoTargetsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06031104 RID: 200964 RVA: 0x006A89CF File Offset: 0x006A6BCF
		public static VectorOffset CreatePhotoTargetsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031105 RID: 200965 RVA: 0x006A89E8 File Offset: 0x006A6BE8
		public static void StartPhotoTargetsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031106 RID: 200966 RVA: 0x006A89F3 File Offset: 0x006A6BF3
		public static void AddPlayerPerform(FlatBufferBuilder builder, Offset<IPhotographPlayerPerform> playerPerformOffset)
		{
			builder.AddOffset(1, playerPerformOffset.Value, 0);
		}

		// Token: 0x06031107 RID: 200967 RVA: 0x006A8A03 File Offset: 0x006A6C03
		public static void AddCameraParams(FlatBufferBuilder builder, Offset<IPhotographCameraParams> cameraParamsOffset)
		{
			builder.AddOffset(2, cameraParamsOffset.Value, 0);
		}

		// Token: 0x06031108 RID: 200968 RVA: 0x006A8A13 File Offset: 0x006A6C13
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06031109 RID: 200969 RVA: 0x006A8A1E File Offset: 0x006A6C1E
		public static Offset<IPhotographConfig> EndIPhotographConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographConfig>(builder.EndTable());
		}

		// Token: 0x0603110A RID: 200970 RVA: 0x006A8A2C File Offset: 0x006A6C2C
		public IPhotographConfigT UnPack()
		{
			IPhotographConfigT photographConfigT = new IPhotographConfigT();
			this.UnPackTo(photographConfigT);
			return photographConfigT;
		}

		// Token: 0x0603110B RID: 200971 RVA: 0x006A8A48 File Offset: 0x006A6C48
		public void UnPackTo(IPhotographConfigT _o)
		{
			_o.PhotoTargets = new List<int>();
			for (int i = 0; i < this.PhotoTargetsLength; i++)
			{
				_o.PhotoTargets.Add(this.PhotoTargets(i));
			}
			_o.PlayerPerform = ((this.PlayerPerform != null) ? this.PlayerPerform.Value.UnPack() : null);
			_o.CameraParams = ((this.CameraParams != null) ? this.CameraParams.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603110C RID: 200972 RVA: 0x006A8AF0 File Offset: 0x006A6CF0
		public static Offset<IPhotographConfig> Pack(FlatBufferBuilder builder, IPhotographConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotographConfig>);
			}
			VectorOffset photoTargetsOffset = default(VectorOffset);
			if (_o.PhotoTargets != null)
			{
				int[] data = _o.PhotoTargets.ToArray();
				photoTargetsOffset = IPhotographConfig.CreatePhotoTargetsVector(builder, data);
			}
			Offset<IPhotographPlayerPerform> playerPerformOffset = (_o.PlayerPerform == null) ? default(Offset<IPhotographPlayerPerform>) : IPhotographPlayerPerform.Pack(builder, _o.PlayerPerform);
			Offset<IPhotographCameraParams> cameraParamsOffset = (_o.CameraParams == null) ? default(Offset<IPhotographCameraParams>) : IPhotographCameraParams.Pack(builder, _o.CameraParams);
			return IPhotographConfig.CreateIPhotographConfig(builder, photoTargetsOffset, playerPerformOffset, cameraParamsOffset, _o.NullMask);
		}

		// Token: 0x04011622 RID: 71202
		private Table __p;
	}
}

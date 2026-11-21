using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007436 RID: 29750
	public struct IPhotographConfig : IFlatbufferObject
	{
		// Token: 0x1700DA7C RID: 55932
		// (get) Token: 0x060340C8 RID: 213192 RVA: 0x0070395A File Offset: 0x00701B5A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060340C9 RID: 213193 RVA: 0x00703967 File Offset: 0x00701B67
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060340CA RID: 213194 RVA: 0x00703970 File Offset: 0x00701B70
		public static IPhotographConfig GetRootAsIPhotographConfig(ByteBuffer _bb)
		{
			return IPhotographConfig.GetRootAsIPhotographConfig(_bb, default(IPhotographConfig));
		}

		// Token: 0x060340CB RID: 213195 RVA: 0x0070398C File Offset: 0x00701B8C
		public static IPhotographConfig GetRootAsIPhotographConfig(ByteBuffer _bb, IPhotographConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060340CC RID: 213196 RVA: 0x007039A9 File Offset: 0x00701BA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060340CD RID: 213197 RVA: 0x007039B8 File Offset: 0x00701BB8
		public IPhotographConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060340CE RID: 213198 RVA: 0x007039C8 File Offset: 0x00701BC8
		public int PhotoTargets(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700DA7D RID: 55933
		// (get) Token: 0x060340CF RID: 213199 RVA: 0x00703A08 File Offset: 0x00701C08
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

		// Token: 0x060340D0 RID: 213200 RVA: 0x00703A33 File Offset: 0x00701C33
		public Span<int> GetPhotoTargetsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x060340D1 RID: 213201 RVA: 0x00703A42 File Offset: 0x00701C42
		public int[] GetPhotoTargetsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700DA7E RID: 55934
		// (get) Token: 0x060340D2 RID: 213202 RVA: 0x00703A50 File Offset: 0x00701C50
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

		// Token: 0x1700DA7F RID: 55935
		// (get) Token: 0x060340D3 RID: 213203 RVA: 0x00703AB0 File Offset: 0x00701CB0
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

		// Token: 0x1700DA80 RID: 55936
		// (get) Token: 0x060340D4 RID: 213204 RVA: 0x00703B10 File Offset: 0x00701D10
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

		// Token: 0x060340D5 RID: 213205 RVA: 0x00703B4D File Offset: 0x00701D4D
		public static Offset<IPhotographConfig> CreateIPhotographConfig(FlatBufferBuilder builder, VectorOffset PhotoTargetsOffset = default(VectorOffset), Offset<IPhotographPlayerPerform> PlayerPerformOffset = default(Offset<IPhotographPlayerPerform>), Offset<IPhotographCameraParams> CameraParamsOffset = default(Offset<IPhotographCameraParams>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IPhotographConfig.AddCameraParams(builder, CameraParamsOffset);
			IPhotographConfig.AddPlayerPerform(builder, PlayerPerformOffset);
			IPhotographConfig.AddPhotoTargets(builder, PhotoTargetsOffset);
			IPhotographConfig.AddNullMask(builder, NullMask);
			return IPhotographConfig.EndIPhotographConfig(builder);
		}

		// Token: 0x060340D6 RID: 213206 RVA: 0x00703B79 File Offset: 0x00701D79
		public static void StartIPhotographConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060340D7 RID: 213207 RVA: 0x00703B82 File Offset: 0x00701D82
		public static void AddPhotoTargets(FlatBufferBuilder builder, VectorOffset photoTargetsOffset)
		{
			builder.AddOffset(0, photoTargetsOffset.Value, 0);
		}

		// Token: 0x060340D8 RID: 213208 RVA: 0x00703B94 File Offset: 0x00701D94
		public static VectorOffset CreatePhotoTargetsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060340D9 RID: 213209 RVA: 0x00703BCB File Offset: 0x00701DCB
		public static VectorOffset CreatePhotoTargetsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060340DA RID: 213210 RVA: 0x00703BE5 File Offset: 0x00701DE5
		public static VectorOffset CreatePhotoTargetsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060340DB RID: 213211 RVA: 0x00703C03 File Offset: 0x00701E03
		public static VectorOffset CreatePhotoTargetsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060340DC RID: 213212 RVA: 0x00703C1C File Offset: 0x00701E1C
		public static void StartPhotoTargetsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060340DD RID: 213213 RVA: 0x00703C27 File Offset: 0x00701E27
		public static void AddPlayerPerform(FlatBufferBuilder builder, Offset<IPhotographPlayerPerform> playerPerformOffset)
		{
			builder.AddOffset(1, playerPerformOffset.Value, 0);
		}

		// Token: 0x060340DE RID: 213214 RVA: 0x00703C37 File Offset: 0x00701E37
		public static void AddCameraParams(FlatBufferBuilder builder, Offset<IPhotographCameraParams> cameraParamsOffset)
		{
			builder.AddOffset(2, cameraParamsOffset.Value, 0);
		}

		// Token: 0x060340DF RID: 213215 RVA: 0x00703C47 File Offset: 0x00701E47
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060340E0 RID: 213216 RVA: 0x00703C52 File Offset: 0x00701E52
		public static Offset<IPhotographConfig> EndIPhotographConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographConfig>(builder.EndTable());
		}

		// Token: 0x060340E1 RID: 213217 RVA: 0x00703C60 File Offset: 0x00701E60
		public IPhotographConfigT UnPack()
		{
			IPhotographConfigT photographConfigT = new IPhotographConfigT();
			this.UnPackTo(photographConfigT);
			return photographConfigT;
		}

		// Token: 0x060340E2 RID: 213218 RVA: 0x00703C7C File Offset: 0x00701E7C
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

		// Token: 0x060340E3 RID: 213219 RVA: 0x00703D24 File Offset: 0x00701F24
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

		// Token: 0x04012592 RID: 75154
		private Table __p;
	}
}

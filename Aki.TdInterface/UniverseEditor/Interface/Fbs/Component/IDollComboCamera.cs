using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005090 RID: 20624
	public struct IDollComboCamera : IFlatbufferObject
	{
		// Token: 0x170095C9 RID: 38345
		// (get) Token: 0x0602119F RID: 135583 RVA: 0x004997CC File Offset: 0x004979CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060211A0 RID: 135584 RVA: 0x004997D9 File Offset: 0x004979D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060211A1 RID: 135585 RVA: 0x004997E0 File Offset: 0x004979E0
		public static IDollComboCamera GetRootAsIDollComboCamera(ByteBuffer _bb)
		{
			return IDollComboCamera.GetRootAsIDollComboCamera(_bb, default(IDollComboCamera));
		}

		// Token: 0x060211A2 RID: 135586 RVA: 0x004997FC File Offset: 0x004979FC
		public static IDollComboCamera GetRootAsIDollComboCamera(ByteBuffer _bb, IDollComboCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060211A3 RID: 135587 RVA: 0x00499819 File Offset: 0x00497A19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060211A4 RID: 135588 RVA: 0x00499828 File Offset: 0x00497A28
		public IDollComboCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170095CA RID: 38346
		// (get) Token: 0x060211A5 RID: 135589 RVA: 0x00499838 File Offset: 0x00497A38
		public float Fov
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060211A6 RID: 135590 RVA: 0x00499878 File Offset: 0x00497A78
		public IDollComboCameraConfig? ComboCameras(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IDollComboCameraConfig?(default(IDollComboCameraConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170095CB RID: 38347
		// (get) Token: 0x060211A7 RID: 135591 RVA: 0x004998D8 File Offset: 0x00497AD8
		public int ComboCamerasLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060211A8 RID: 135592 RVA: 0x00499903 File Offset: 0x00497B03
		public static Offset<IDollComboCamera> CreateIDollComboCamera(FlatBufferBuilder builder, float Fov = 0f, VectorOffset ComboCamerasOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IDollComboCamera.AddComboCameras(builder, ComboCamerasOffset);
			IDollComboCamera.AddFov(builder, Fov);
			return IDollComboCamera.EndIDollComboCamera(builder);
		}

		// Token: 0x060211A9 RID: 135593 RVA: 0x00499920 File Offset: 0x00497B20
		public static void StartIDollComboCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060211AA RID: 135594 RVA: 0x00499929 File Offset: 0x00497B29
		public static void AddFov(FlatBufferBuilder builder, float fov)
		{
			builder.AddFloat(0, fov, 0.0);
		}

		// Token: 0x060211AB RID: 135595 RVA: 0x0049993C File Offset: 0x00497B3C
		public static void AddComboCameras(FlatBufferBuilder builder, VectorOffset comboCamerasOffset)
		{
			builder.AddOffset(1, comboCamerasOffset.Value, 0);
		}

		// Token: 0x060211AC RID: 135596 RVA: 0x0049994C File Offset: 0x00497B4C
		public static VectorOffset CreateComboCamerasVector(FlatBufferBuilder builder, Offset<IDollComboCameraConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060211AD RID: 135597 RVA: 0x0049998C File Offset: 0x00497B8C
		public static VectorOffset CreateComboCamerasVectorBlock(FlatBufferBuilder builder, Offset<IDollComboCameraConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDollComboCameraConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060211AE RID: 135598 RVA: 0x004999A6 File Offset: 0x00497BA6
		public static VectorOffset CreateComboCamerasVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDollComboCameraConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDollComboCameraConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060211AF RID: 135599 RVA: 0x004999C4 File Offset: 0x00497BC4
		public static VectorOffset CreateComboCamerasVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDollComboCameraConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060211B0 RID: 135600 RVA: 0x004999DD File Offset: 0x00497BDD
		public static void StartComboCamerasVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060211B1 RID: 135601 RVA: 0x004999E8 File Offset: 0x00497BE8
		public static Offset<IDollComboCamera> EndIDollComboCamera(FlatBufferBuilder builder)
		{
			return new Offset<IDollComboCamera>(builder.EndTable());
		}

		// Token: 0x060211B2 RID: 135602 RVA: 0x004999F8 File Offset: 0x00497BF8
		public IDollComboCameraT UnPack()
		{
			IDollComboCameraT dollComboCameraT = new IDollComboCameraT();
			this.UnPackTo(dollComboCameraT);
			return dollComboCameraT;
		}

		// Token: 0x060211B3 RID: 135603 RVA: 0x00499A14 File Offset: 0x00497C14
		public void UnPackTo(IDollComboCameraT _o)
		{
			_o.Fov = this.Fov;
			_o.ComboCameras = new List<IDollComboCameraConfigT>();
			for (int i = 0; i < this.ComboCamerasLength; i++)
			{
				_o.ComboCameras.Add((this.ComboCameras(i) != null) ? this.ComboCameras(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060211B4 RID: 135604 RVA: 0x00499A80 File Offset: 0x00497C80
		public static Offset<IDollComboCamera> Pack(FlatBufferBuilder builder, IDollComboCameraT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDollComboCamera>);
			}
			VectorOffset comboCamerasOffset = default(VectorOffset);
			if (_o.ComboCameras != null)
			{
				Offset<IDollComboCameraConfig>[] array = new Offset<IDollComboCameraConfig>[_o.ComboCameras.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IDollComboCameraConfig.Pack(builder, _o.ComboCameras[i]);
				}
				comboCamerasOffset = IDollComboCamera.CreateComboCamerasVector(builder, array);
			}
			return IDollComboCamera.CreateIDollComboCamera(builder, _o.Fov, comboCamerasOffset);
		}

		// Token: 0x0400E0A9 RID: 57513
		private Table __p;
	}
}

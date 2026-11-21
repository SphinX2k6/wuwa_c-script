using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055F5 RID: 22005
	public struct IDollComboCamera : IFlatbufferObject
	{
		// Token: 0x17009DB6 RID: 40374
		// (get) Token: 0x060230F3 RID: 143603 RVA: 0x004D3758 File Offset: 0x004D1958
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060230F4 RID: 143604 RVA: 0x004D3765 File Offset: 0x004D1965
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060230F5 RID: 143605 RVA: 0x004D376C File Offset: 0x004D196C
		public static IDollComboCamera GetRootAsIDollComboCamera(ByteBuffer _bb)
		{
			return IDollComboCamera.GetRootAsIDollComboCamera(_bb, default(IDollComboCamera));
		}

		// Token: 0x060230F6 RID: 143606 RVA: 0x004D3788 File Offset: 0x004D1988
		public static IDollComboCamera GetRootAsIDollComboCamera(ByteBuffer _bb, IDollComboCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060230F7 RID: 143607 RVA: 0x004D37A5 File Offset: 0x004D19A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060230F8 RID: 143608 RVA: 0x004D37B4 File Offset: 0x004D19B4
		public IDollComboCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009DB7 RID: 40375
		// (get) Token: 0x060230F9 RID: 143609 RVA: 0x004D37C4 File Offset: 0x004D19C4
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

		// Token: 0x060230FA RID: 143610 RVA: 0x004D3804 File Offset: 0x004D1A04
		public IDollComboCameraConfig? ComboCameras(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IDollComboCameraConfig?(default(IDollComboCameraConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009DB8 RID: 40376
		// (get) Token: 0x060230FB RID: 143611 RVA: 0x004D3864 File Offset: 0x004D1A64
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

		// Token: 0x060230FC RID: 143612 RVA: 0x004D388F File Offset: 0x004D1A8F
		public static Offset<IDollComboCamera> CreateIDollComboCamera(FlatBufferBuilder builder, float Fov = 0f, VectorOffset ComboCamerasOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IDollComboCamera.AddComboCameras(builder, ComboCamerasOffset);
			IDollComboCamera.AddFov(builder, Fov);
			return IDollComboCamera.EndIDollComboCamera(builder);
		}

		// Token: 0x060230FD RID: 143613 RVA: 0x004D38AC File Offset: 0x004D1AAC
		public static void StartIDollComboCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060230FE RID: 143614 RVA: 0x004D38B5 File Offset: 0x004D1AB5
		public static void AddFov(FlatBufferBuilder builder, float fov)
		{
			builder.AddFloat(0, fov, 0.0);
		}

		// Token: 0x060230FF RID: 143615 RVA: 0x004D38C8 File Offset: 0x004D1AC8
		public static void AddComboCameras(FlatBufferBuilder builder, VectorOffset comboCamerasOffset)
		{
			builder.AddOffset(1, comboCamerasOffset.Value, 0);
		}

		// Token: 0x06023100 RID: 143616 RVA: 0x004D38D8 File Offset: 0x004D1AD8
		public static VectorOffset CreateComboCamerasVector(FlatBufferBuilder builder, Offset<IDollComboCameraConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023101 RID: 143617 RVA: 0x004D3918 File Offset: 0x004D1B18
		public static VectorOffset CreateComboCamerasVectorBlock(FlatBufferBuilder builder, Offset<IDollComboCameraConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDollComboCameraConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023102 RID: 143618 RVA: 0x004D3932 File Offset: 0x004D1B32
		public static VectorOffset CreateComboCamerasVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDollComboCameraConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDollComboCameraConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023103 RID: 143619 RVA: 0x004D3950 File Offset: 0x004D1B50
		public static VectorOffset CreateComboCamerasVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDollComboCameraConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023104 RID: 143620 RVA: 0x004D3969 File Offset: 0x004D1B69
		public static void StartComboCamerasVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023105 RID: 143621 RVA: 0x004D3974 File Offset: 0x004D1B74
		public static Offset<IDollComboCamera> EndIDollComboCamera(FlatBufferBuilder builder)
		{
			return new Offset<IDollComboCamera>(builder.EndTable());
		}

		// Token: 0x06023106 RID: 143622 RVA: 0x004D3984 File Offset: 0x004D1B84
		public IDollComboCameraT UnPack()
		{
			IDollComboCameraT dollComboCameraT = new IDollComboCameraT();
			this.UnPackTo(dollComboCameraT);
			return dollComboCameraT;
		}

		// Token: 0x06023107 RID: 143623 RVA: 0x004D39A0 File Offset: 0x004D1BA0
		public void UnPackTo(IDollComboCameraT _o)
		{
			_o.Fov = this.Fov;
			_o.ComboCameras = new List<IDollComboCameraConfigT>();
			for (int i = 0; i < this.ComboCamerasLength; i++)
			{
				_o.ComboCameras.Add((this.ComboCameras(i) != null) ? this.ComboCameras(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06023108 RID: 143624 RVA: 0x004D3A0C File Offset: 0x004D1C0C
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

		// Token: 0x0400ECA6 RID: 60582
		private Table __p;
	}
}

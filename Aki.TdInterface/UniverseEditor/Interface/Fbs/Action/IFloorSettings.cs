using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067E9 RID: 26601
	public struct IFloorSettings : IFlatbufferObject
	{
		// Token: 0x1700C56A RID: 50538
		// (get) Token: 0x0602E4EF RID: 189679 RVA: 0x00652775 File Offset: 0x00650975
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E4F0 RID: 189680 RVA: 0x00652782 File Offset: 0x00650982
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E4F1 RID: 189681 RVA: 0x0065278C File Offset: 0x0065098C
		public static IFloorSettings GetRootAsIFloorSettings(ByteBuffer _bb)
		{
			return IFloorSettings.GetRootAsIFloorSettings(_bb, default(IFloorSettings));
		}

		// Token: 0x0602E4F2 RID: 189682 RVA: 0x006527A8 File Offset: 0x006509A8
		public static IFloorSettings GetRootAsIFloorSettings(ByteBuffer _bb, IFloorSettings obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E4F3 RID: 189683 RVA: 0x006527C5 File Offset: 0x006509C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E4F4 RID: 189684 RVA: 0x006527D4 File Offset: 0x006509D4
		public IFloorSettings __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C56B RID: 50539
		// (get) Token: 0x0602E4F5 RID: 189685 RVA: 0x006527E4 File Offset: 0x006509E4
		public string MeshPath
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E4F6 RID: 189686 RVA: 0x0065281B File Offset: 0x00650A1B
		public Span<byte> GetMeshPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602E4F7 RID: 189687 RVA: 0x0065282A File Offset: 0x00650A2A
		public byte[] GetMeshPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700C56C RID: 50540
		// (get) Token: 0x0602E4F8 RID: 189688 RVA: 0x00652838 File Offset: 0x00650A38
		public string MaterialPath
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

		// Token: 0x0602E4F9 RID: 189689 RVA: 0x0065286F File Offset: 0x00650A6F
		public Span<byte> GetMaterialPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602E4FA RID: 189690 RVA: 0x0065287E File Offset: 0x00650A7E
		public byte[] GetMaterialPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700C56D RID: 50541
		// (get) Token: 0x0602E4FB RID: 189691 RVA: 0x0065288C File Offset: 0x00650A8C
		public IVector2? Scale
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVector2?(default(IVector2).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C56E RID: 50542
		// (get) Token: 0x0602E4FC RID: 189692 RVA: 0x006528EC File Offset: 0x00650AEC
		public float ShowTime
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C56F RID: 50543
		// (get) Token: 0x0602E4FD RID: 189693 RVA: 0x00652930 File Offset: 0x00650B30
		public float DisappearTime
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E4FE RID: 189694 RVA: 0x00652971 File Offset: 0x00650B71
		public static Offset<IFloorSettings> CreateIFloorSettings(FlatBufferBuilder builder, StringOffset MeshPathOffset = default(StringOffset), StringOffset MaterialPathOffset = default(StringOffset), Offset<IVector2> ScaleOffset = default(Offset<IVector2>), float ShowTime = 0f, float DisappearTime = 0f)
		{
			builder.StartTable(5);
			IFloorSettings.AddDisappearTime(builder, DisappearTime);
			IFloorSettings.AddShowTime(builder, ShowTime);
			IFloorSettings.AddScale(builder, ScaleOffset);
			IFloorSettings.AddMaterialPath(builder, MaterialPathOffset);
			IFloorSettings.AddMeshPath(builder, MeshPathOffset);
			return IFloorSettings.EndIFloorSettings(builder);
		}

		// Token: 0x0602E4FF RID: 189695 RVA: 0x006529A5 File Offset: 0x00650BA5
		public static void StartIFloorSettings(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602E500 RID: 189696 RVA: 0x006529AE File Offset: 0x00650BAE
		public static void AddMeshPath(FlatBufferBuilder builder, StringOffset meshPathOffset)
		{
			builder.AddOffset(0, meshPathOffset.Value, 0);
		}

		// Token: 0x0602E501 RID: 189697 RVA: 0x006529BE File Offset: 0x00650BBE
		public static void AddMaterialPath(FlatBufferBuilder builder, StringOffset materialPathOffset)
		{
			builder.AddOffset(1, materialPathOffset.Value, 0);
		}

		// Token: 0x0602E502 RID: 189698 RVA: 0x006529CE File Offset: 0x00650BCE
		public static void AddScale(FlatBufferBuilder builder, Offset<IVector2> scaleOffset)
		{
			builder.AddOffset(2, scaleOffset.Value, 0);
		}

		// Token: 0x0602E503 RID: 189699 RVA: 0x006529DE File Offset: 0x00650BDE
		public static void AddShowTime(FlatBufferBuilder builder, float showTime)
		{
			builder.AddFloat(3, showTime, 0.0);
		}

		// Token: 0x0602E504 RID: 189700 RVA: 0x006529F1 File Offset: 0x00650BF1
		public static void AddDisappearTime(FlatBufferBuilder builder, float disappearTime)
		{
			builder.AddFloat(4, disappearTime, 0.0);
		}

		// Token: 0x0602E505 RID: 189701 RVA: 0x00652A04 File Offset: 0x00650C04
		public static Offset<IFloorSettings> EndIFloorSettings(FlatBufferBuilder builder)
		{
			return new Offset<IFloorSettings>(builder.EndTable());
		}

		// Token: 0x0602E506 RID: 189702 RVA: 0x00652A14 File Offset: 0x00650C14
		public IFloorSettingsT UnPack()
		{
			IFloorSettingsT floorSettingsT = new IFloorSettingsT();
			this.UnPackTo(floorSettingsT);
			return floorSettingsT;
		}

		// Token: 0x0602E507 RID: 189703 RVA: 0x00652A30 File Offset: 0x00650C30
		public void UnPackTo(IFloorSettingsT _o)
		{
			_o.MeshPath = this.MeshPath;
			_o.MaterialPath = this.MaterialPath;
			_o.Scale = ((this.Scale != null) ? this.Scale.Value.UnPack() : null);
			_o.ShowTime = this.ShowTime;
			_o.DisappearTime = this.DisappearTime;
		}

		// Token: 0x0602E508 RID: 189704 RVA: 0x00652A9C File Offset: 0x00650C9C
		public static Offset<IFloorSettings> Pack(FlatBufferBuilder builder, IFloorSettingsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFloorSettings>);
			}
			StringOffset meshPathOffset = (_o.MeshPath == null) ? default(StringOffset) : builder.CreateString(_o.MeshPath);
			StringOffset materialPathOffset = (_o.MaterialPath == null) ? default(StringOffset) : builder.CreateString(_o.MaterialPath);
			Offset<IVector2> scaleOffset = (_o.Scale == null) ? default(Offset<IVector2>) : IVector2.Pack(builder, _o.Scale);
			return IFloorSettings.CreateIFloorSettings(builder, meshPathOffset, materialPathOffset, scaleOffset, _o.ShowTime, _o.DisappearTime);
		}

		// Token: 0x04010F01 RID: 69377
		private Table __p;
	}
}

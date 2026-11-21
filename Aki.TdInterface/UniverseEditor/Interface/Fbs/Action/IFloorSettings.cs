using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E69 RID: 28265
	public struct IFloorSettings : IFlatbufferObject
	{
		// Token: 0x1700CF20 RID: 53024
		// (get) Token: 0x06030D35 RID: 199989 RVA: 0x0069FEB9 File Offset: 0x0069E0B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030D36 RID: 199990 RVA: 0x0069FEC6 File Offset: 0x0069E0C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030D37 RID: 199991 RVA: 0x0069FED0 File Offset: 0x0069E0D0
		public static IFloorSettings GetRootAsIFloorSettings(ByteBuffer _bb)
		{
			return IFloorSettings.GetRootAsIFloorSettings(_bb, default(IFloorSettings));
		}

		// Token: 0x06030D38 RID: 199992 RVA: 0x0069FEEC File Offset: 0x0069E0EC
		public static IFloorSettings GetRootAsIFloorSettings(ByteBuffer _bb, IFloorSettings obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030D39 RID: 199993 RVA: 0x0069FF09 File Offset: 0x0069E109
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030D3A RID: 199994 RVA: 0x0069FF18 File Offset: 0x0069E118
		public IFloorSettings __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF21 RID: 53025
		// (get) Token: 0x06030D3B RID: 199995 RVA: 0x0069FF28 File Offset: 0x0069E128
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

		// Token: 0x06030D3C RID: 199996 RVA: 0x0069FF5F File Offset: 0x0069E15F
		public Span<byte> GetMeshPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06030D3D RID: 199997 RVA: 0x0069FF6E File Offset: 0x0069E16E
		public byte[] GetMeshPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700CF22 RID: 53026
		// (get) Token: 0x06030D3E RID: 199998 RVA: 0x0069FF7C File Offset: 0x0069E17C
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

		// Token: 0x06030D3F RID: 199999 RVA: 0x0069FFB3 File Offset: 0x0069E1B3
		public Span<byte> GetMaterialPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06030D40 RID: 200000 RVA: 0x0069FFC2 File Offset: 0x0069E1C2
		public byte[] GetMaterialPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700CF23 RID: 53027
		// (get) Token: 0x06030D41 RID: 200001 RVA: 0x0069FFD0 File Offset: 0x0069E1D0
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

		// Token: 0x1700CF24 RID: 53028
		// (get) Token: 0x06030D42 RID: 200002 RVA: 0x006A0030 File Offset: 0x0069E230
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

		// Token: 0x1700CF25 RID: 53029
		// (get) Token: 0x06030D43 RID: 200003 RVA: 0x006A0074 File Offset: 0x0069E274
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

		// Token: 0x06030D44 RID: 200004 RVA: 0x006A00B5 File Offset: 0x0069E2B5
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

		// Token: 0x06030D45 RID: 200005 RVA: 0x006A00E9 File Offset: 0x0069E2E9
		public static void StartIFloorSettings(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06030D46 RID: 200006 RVA: 0x006A00F2 File Offset: 0x0069E2F2
		public static void AddMeshPath(FlatBufferBuilder builder, StringOffset meshPathOffset)
		{
			builder.AddOffset(0, meshPathOffset.Value, 0);
		}

		// Token: 0x06030D47 RID: 200007 RVA: 0x006A0102 File Offset: 0x0069E302
		public static void AddMaterialPath(FlatBufferBuilder builder, StringOffset materialPathOffset)
		{
			builder.AddOffset(1, materialPathOffset.Value, 0);
		}

		// Token: 0x06030D48 RID: 200008 RVA: 0x006A0112 File Offset: 0x0069E312
		public static void AddScale(FlatBufferBuilder builder, Offset<IVector2> scaleOffset)
		{
			builder.AddOffset(2, scaleOffset.Value, 0);
		}

		// Token: 0x06030D49 RID: 200009 RVA: 0x006A0122 File Offset: 0x0069E322
		public static void AddShowTime(FlatBufferBuilder builder, float showTime)
		{
			builder.AddFloat(3, showTime, 0.0);
		}

		// Token: 0x06030D4A RID: 200010 RVA: 0x006A0135 File Offset: 0x0069E335
		public static void AddDisappearTime(FlatBufferBuilder builder, float disappearTime)
		{
			builder.AddFloat(4, disappearTime, 0.0);
		}

		// Token: 0x06030D4B RID: 200011 RVA: 0x006A0148 File Offset: 0x0069E348
		public static Offset<IFloorSettings> EndIFloorSettings(FlatBufferBuilder builder)
		{
			return new Offset<IFloorSettings>(builder.EndTable());
		}

		// Token: 0x06030D4C RID: 200012 RVA: 0x006A0158 File Offset: 0x0069E358
		public IFloorSettingsT UnPack()
		{
			IFloorSettingsT floorSettingsT = new IFloorSettingsT();
			this.UnPackTo(floorSettingsT);
			return floorSettingsT;
		}

		// Token: 0x06030D4D RID: 200013 RVA: 0x006A0174 File Offset: 0x0069E374
		public void UnPackTo(IFloorSettingsT _o)
		{
			_o.MeshPath = this.MeshPath;
			_o.MaterialPath = this.MaterialPath;
			_o.Scale = ((this.Scale != null) ? this.Scale.Value.UnPack() : null);
			_o.ShowTime = this.ShowTime;
			_o.DisappearTime = this.DisappearTime;
		}

		// Token: 0x06030D4E RID: 200014 RVA: 0x006A01E0 File Offset: 0x0069E3E0
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

		// Token: 0x04011D33 RID: 73011
		private Table __p;
	}
}

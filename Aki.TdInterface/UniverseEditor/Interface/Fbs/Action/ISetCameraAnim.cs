using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200779A RID: 30618
	public struct ISetCameraAnim : IFlatbufferObject
	{
		// Token: 0x1700E054 RID: 57428
		// (get) Token: 0x06035BE3 RID: 220131 RVA: 0x00733627 File Offset: 0x00731827
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035BE4 RID: 220132 RVA: 0x00733634 File Offset: 0x00731834
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035BE5 RID: 220133 RVA: 0x0073363C File Offset: 0x0073183C
		public static ISetCameraAnim GetRootAsISetCameraAnim(ByteBuffer _bb)
		{
			return ISetCameraAnim.GetRootAsISetCameraAnim(_bb, default(ISetCameraAnim));
		}

		// Token: 0x06035BE6 RID: 220134 RVA: 0x00733658 File Offset: 0x00731858
		public static ISetCameraAnim GetRootAsISetCameraAnim(ByteBuffer _bb, ISetCameraAnim obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035BE7 RID: 220135 RVA: 0x00733675 File Offset: 0x00731875
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035BE8 RID: 220136 RVA: 0x00733684 File Offset: 0x00731884
		public ISetCameraAnim __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E055 RID: 57429
		// (get) Token: 0x06035BE9 RID: 220137 RVA: 0x00733694 File Offset: 0x00731894
		public string CameraAnimDataAsset
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

		// Token: 0x06035BEA RID: 220138 RVA: 0x007336CB File Offset: 0x007318CB
		public Span<byte> GetCameraAnimDataAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06035BEB RID: 220139 RVA: 0x007336DA File Offset: 0x007318DA
		public byte[] GetCameraAnimDataAssetArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700E056 RID: 57430
		// (get) Token: 0x06035BEC RID: 220140 RVA: 0x007336E8 File Offset: 0x007318E8
		public float Speed
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E057 RID: 57431
		// (get) Token: 0x06035BED RID: 220141 RVA: 0x00733728 File Offset: 0x00731928
		public bool UseNoise
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E058 RID: 57432
		// (get) Token: 0x06035BEE RID: 220142 RVA: 0x00733768 File Offset: 0x00731968
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

		// Token: 0x06035BEF RID: 220143 RVA: 0x007337A5 File Offset: 0x007319A5
		public static Offset<ISetCameraAnim> CreateISetCameraAnim(FlatBufferBuilder builder, StringOffset CameraAnimDataAssetOffset = default(StringOffset), float Speed = 0f, bool UseNoise = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			ISetCameraAnim.AddSpeed(builder, Speed);
			ISetCameraAnim.AddCameraAnimDataAsset(builder, CameraAnimDataAssetOffset);
			ISetCameraAnim.AddNullMask(builder, NullMask);
			ISetCameraAnim.AddUseNoise(builder, UseNoise);
			return ISetCameraAnim.EndISetCameraAnim(builder);
		}

		// Token: 0x06035BF0 RID: 220144 RVA: 0x007337D1 File Offset: 0x007319D1
		public static void StartISetCameraAnim(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06035BF1 RID: 220145 RVA: 0x007337DA File Offset: 0x007319DA
		public static void AddCameraAnimDataAsset(FlatBufferBuilder builder, StringOffset cameraAnimDataAssetOffset)
		{
			builder.AddOffset(0, cameraAnimDataAssetOffset.Value, 0);
		}

		// Token: 0x06035BF2 RID: 220146 RVA: 0x007337EA File Offset: 0x007319EA
		public static void AddSpeed(FlatBufferBuilder builder, float speed)
		{
			builder.AddFloat(1, speed, 0.0);
		}

		// Token: 0x06035BF3 RID: 220147 RVA: 0x007337FD File Offset: 0x007319FD
		public static void AddUseNoise(FlatBufferBuilder builder, bool useNoise)
		{
			builder.AddBool(2, useNoise, false);
		}

		// Token: 0x06035BF4 RID: 220148 RVA: 0x00733808 File Offset: 0x00731A08
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06035BF5 RID: 220149 RVA: 0x00733813 File Offset: 0x00731A13
		public static Offset<ISetCameraAnim> EndISetCameraAnim(FlatBufferBuilder builder)
		{
			return new Offset<ISetCameraAnim>(builder.EndTable());
		}

		// Token: 0x06035BF6 RID: 220150 RVA: 0x00733820 File Offset: 0x00731A20
		public ISetCameraAnimT UnPack()
		{
			ISetCameraAnimT setCameraAnimT = new ISetCameraAnimT();
			this.UnPackTo(setCameraAnimT);
			return setCameraAnimT;
		}

		// Token: 0x06035BF7 RID: 220151 RVA: 0x0073383B File Offset: 0x00731A3B
		public void UnPackTo(ISetCameraAnimT _o)
		{
			_o.CameraAnimDataAsset = this.CameraAnimDataAsset;
			_o.Speed = this.Speed;
			_o.UseNoise = this.UseNoise;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06035BF8 RID: 220152 RVA: 0x00733870 File Offset: 0x00731A70
		public static Offset<ISetCameraAnim> Pack(FlatBufferBuilder builder, ISetCameraAnimT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetCameraAnim>);
			}
			StringOffset cameraAnimDataAssetOffset = (_o.CameraAnimDataAsset == null) ? default(StringOffset) : builder.CreateString(_o.CameraAnimDataAsset);
			return ISetCameraAnim.CreateISetCameraAnim(builder, cameraAnimDataAssetOffset, _o.Speed, _o.UseNoise, _o.NullMask);
		}

		// Token: 0x040129C0 RID: 76224
		private Table __p;
	}
}

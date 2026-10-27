using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E67 RID: 3687
	public struct MotorScene : IFlatbufferObject
	{
		// Token: 0x17002203 RID: 8707
		// (get) Token: 0x06009BA5 RID: 39845 RVA: 0x00296390 File Offset: 0x00294590
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009BA6 RID: 39846 RVA: 0x0029639D File Offset: 0x0029459D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009BA7 RID: 39847 RVA: 0x002963A4 File Offset: 0x002945A4
		public static MotorScene GetRootAsMotorScene(ByteBuffer _bb)
		{
			return MotorScene.GetRootAsMotorScene(_bb, default(MotorScene));
		}

		// Token: 0x06009BA8 RID: 39848 RVA: 0x002963C0 File Offset: 0x002945C0
		public static MotorScene GetRootAsMotorScene(ByteBuffer _bb, MotorScene obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009BA9 RID: 39849 RVA: 0x002963DD File Offset: 0x002945DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009BAA RID: 39850 RVA: 0x002963EC File Offset: 0x002945EC
		public MotorScene __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002204 RID: 8708
		// (get) Token: 0x06009BAB RID: 39851 RVA: 0x002963FC File Offset: 0x002945FC
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002205 RID: 8709
		// (get) Token: 0x06009BAC RID: 39852 RVA: 0x00296438 File Offset: 0x00294638
		public int UnlockItem
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002206 RID: 8710
		// (get) Token: 0x06009BAD RID: 39853 RVA: 0x00296474 File Offset: 0x00294674
		public bool DefaultFlag
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002207 RID: 8711
		// (get) Token: 0x06009BAE RID: 39854 RVA: 0x002964B4 File Offset: 0x002946B4
		public string SceneId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009BAF RID: 39855 RVA: 0x002964EC File Offset: 0x002946EC
		public Span<byte> GetSceneIdBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009BB0 RID: 39856 RVA: 0x002964FC File Offset: 0x002946FC
		public byte[] GetSceneIdArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002208 RID: 8712
		// (get) Token: 0x06009BB1 RID: 39857 RVA: 0x00296514 File Offset: 0x00294714
		public string SceneName
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009BB2 RID: 39858 RVA: 0x0029654C File Offset: 0x0029474C
		public Span<byte> GetSceneNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009BB3 RID: 39859 RVA: 0x0029655C File Offset: 0x0029475C
		public byte[] GetSceneNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002209 RID: 8713
		// (get) Token: 0x06009BB4 RID: 39860 RVA: 0x00296574 File Offset: 0x00294774
		public string SceneIcon
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009BB5 RID: 39861 RVA: 0x002965AC File Offset: 0x002947AC
		public Span<byte> GetSceneIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009BB6 RID: 39862 RVA: 0x002965BC File Offset: 0x002947BC
		public byte[] GetSceneIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F13 RID: 20243
		private Table __p;
	}
}

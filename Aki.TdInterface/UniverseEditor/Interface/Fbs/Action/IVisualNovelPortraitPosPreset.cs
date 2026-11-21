using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DD3 RID: 32211
	public struct IVisualNovelPortraitPosPreset : IFlatbufferObject
	{
		// Token: 0x1700F14A RID: 61770
		// (get) Token: 0x0603A351 RID: 238417 RVA: 0x007D86B1 File Offset: 0x007D68B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A352 RID: 238418 RVA: 0x007D86BE File Offset: 0x007D68BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A353 RID: 238419 RVA: 0x007D86C8 File Offset: 0x007D68C8
		public static IVisualNovelPortraitPosPreset GetRootAsIVisualNovelPortraitPosPreset(ByteBuffer _bb)
		{
			return IVisualNovelPortraitPosPreset.GetRootAsIVisualNovelPortraitPosPreset(_bb, default(IVisualNovelPortraitPosPreset));
		}

		// Token: 0x0603A354 RID: 238420 RVA: 0x007D86E4 File Offset: 0x007D68E4
		public static IVisualNovelPortraitPosPreset GetRootAsIVisualNovelPortraitPosPreset(ByteBuffer _bb, IVisualNovelPortraitPosPreset obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A355 RID: 238421 RVA: 0x007D8701 File Offset: 0x007D6901
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A356 RID: 238422 RVA: 0x007D8710 File Offset: 0x007D6910
		public IVisualNovelPortraitPosPreset __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F14B RID: 61771
		// (get) Token: 0x0603A357 RID: 238423 RVA: 0x007D8720 File Offset: 0x007D6920
		public string Name
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

		// Token: 0x0603A358 RID: 238424 RVA: 0x007D8757 File Offset: 0x007D6957
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0603A359 RID: 238425 RVA: 0x007D8766 File Offset: 0x007D6966
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700F14C RID: 61772
		// (get) Token: 0x0603A35A RID: 238426 RVA: 0x007D8774 File Offset: 0x007D6974
		public int PosX
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

		// Token: 0x1700F14D RID: 61773
		// (get) Token: 0x0603A35B RID: 238427 RVA: 0x007D87B0 File Offset: 0x007D69B0
		public int PosY
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603A35C RID: 238428 RVA: 0x007D87EC File Offset: 0x007D69EC
		public static Offset<IVisualNovelPortraitPosPreset> CreateIVisualNovelPortraitPosPreset(FlatBufferBuilder builder, StringOffset NameOffset = default(StringOffset), int PosX = 0, int PosY = 0)
		{
			builder.StartTable(3);
			IVisualNovelPortraitPosPreset.AddPosY(builder, PosY);
			IVisualNovelPortraitPosPreset.AddPosX(builder, PosX);
			IVisualNovelPortraitPosPreset.AddName(builder, NameOffset);
			return IVisualNovelPortraitPosPreset.EndIVisualNovelPortraitPosPreset(builder);
		}

		// Token: 0x0603A35D RID: 238429 RVA: 0x007D8810 File Offset: 0x007D6A10
		public static void StartIVisualNovelPortraitPosPreset(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603A35E RID: 238430 RVA: 0x007D8819 File Offset: 0x007D6A19
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(0, nameOffset.Value, 0);
		}

		// Token: 0x0603A35F RID: 238431 RVA: 0x007D8829 File Offset: 0x007D6A29
		public static void AddPosX(FlatBufferBuilder builder, int posX)
		{
			builder.AddInt(1, posX, 0);
		}

		// Token: 0x0603A360 RID: 238432 RVA: 0x007D8834 File Offset: 0x007D6A34
		public static void AddPosY(FlatBufferBuilder builder, int posY)
		{
			builder.AddInt(2, posY, 0);
		}

		// Token: 0x0603A361 RID: 238433 RVA: 0x007D883F File Offset: 0x007D6A3F
		public static Offset<IVisualNovelPortraitPosPreset> EndIVisualNovelPortraitPosPreset(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPortraitPosPreset>(builder.EndTable());
		}

		// Token: 0x0603A362 RID: 238434 RVA: 0x007D884C File Offset: 0x007D6A4C
		public IVisualNovelPortraitPosPresetT UnPack()
		{
			IVisualNovelPortraitPosPresetT visualNovelPortraitPosPresetT = new IVisualNovelPortraitPosPresetT();
			this.UnPackTo(visualNovelPortraitPosPresetT);
			return visualNovelPortraitPosPresetT;
		}

		// Token: 0x0603A363 RID: 238435 RVA: 0x007D8867 File Offset: 0x007D6A67
		public void UnPackTo(IVisualNovelPortraitPosPresetT _o)
		{
			_o.Name = this.Name;
			_o.PosX = this.PosX;
			_o.PosY = this.PosY;
		}

		// Token: 0x0603A364 RID: 238436 RVA: 0x007D8890 File Offset: 0x007D6A90
		public static Offset<IVisualNovelPortraitPosPreset> Pack(FlatBufferBuilder builder, IVisualNovelPortraitPosPresetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPortraitPosPreset>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			return IVisualNovelPortraitPosPreset.CreateIVisualNovelPortraitPosPreset(builder, nameOffset, _o.PosX, _o.PosY);
		}

		// Token: 0x04013569 RID: 79209
		private Table __p;
	}
}

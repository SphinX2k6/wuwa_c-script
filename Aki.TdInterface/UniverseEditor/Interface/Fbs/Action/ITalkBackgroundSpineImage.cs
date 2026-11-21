using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A76 RID: 31350
	public struct ITalkBackgroundSpineImage : IFlatbufferObject
	{
		// Token: 0x1700E59D RID: 58781
		// (get) Token: 0x06037409 RID: 226313 RVA: 0x00760E8D File Offset: 0x0075F08D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603740A RID: 226314 RVA: 0x00760E9A File Offset: 0x0075F09A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603740B RID: 226315 RVA: 0x00760EA4 File Offset: 0x0075F0A4
		public static ITalkBackgroundSpineImage GetRootAsITalkBackgroundSpineImage(ByteBuffer _bb)
		{
			return ITalkBackgroundSpineImage.GetRootAsITalkBackgroundSpineImage(_bb, default(ITalkBackgroundSpineImage));
		}

		// Token: 0x0603740C RID: 226316 RVA: 0x00760EC0 File Offset: 0x0075F0C0
		public static ITalkBackgroundSpineImage GetRootAsITalkBackgroundSpineImage(ByteBuffer _bb, ITalkBackgroundSpineImage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603740D RID: 226317 RVA: 0x00760EDD File Offset: 0x0075F0DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603740E RID: 226318 RVA: 0x00760EEC File Offset: 0x0075F0EC
		public ITalkBackgroundSpineImage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E59E RID: 58782
		// (get) Token: 0x0603740F RID: 226319 RVA: 0x00760EFC File Offset: 0x0075F0FC
		public ETalkBackgroundType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkBackgroundType.Clean;
				}
				return (ETalkBackgroundType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E59F RID: 58783
		// (get) Token: 0x06037410 RID: 226320 RVA: 0x00760F38 File Offset: 0x0075F138
		public int Id
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

		// Token: 0x1700E5A0 RID: 58784
		// (get) Token: 0x06037411 RID: 226321 RVA: 0x00760F74 File Offset: 0x0075F174
		public bool IsLoop
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E5A1 RID: 58785
		// (get) Token: 0x06037412 RID: 226322 RVA: 0x00760FB4 File Offset: 0x0075F1B4
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

		// Token: 0x06037413 RID: 226323 RVA: 0x00760FF1 File Offset: 0x0075F1F1
		public static Offset<ITalkBackgroundSpineImage> CreateITalkBackgroundSpineImage(FlatBufferBuilder builder, ETalkBackgroundType Type = ETalkBackgroundType.Clean, int Id = 0, bool IsLoop = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			ITalkBackgroundSpineImage.AddId(builder, Id);
			ITalkBackgroundSpineImage.AddNullMask(builder, NullMask);
			ITalkBackgroundSpineImage.AddIsLoop(builder, IsLoop);
			ITalkBackgroundSpineImage.AddType(builder, Type);
			return ITalkBackgroundSpineImage.EndITalkBackgroundSpineImage(builder);
		}

		// Token: 0x06037414 RID: 226324 RVA: 0x0076101D File Offset: 0x0075F21D
		public static void StartITalkBackgroundSpineImage(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06037415 RID: 226325 RVA: 0x00761026 File Offset: 0x0075F226
		public static void AddType(FlatBufferBuilder builder, ETalkBackgroundType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06037416 RID: 226326 RVA: 0x00761031 File Offset: 0x0075F231
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06037417 RID: 226327 RVA: 0x0076103C File Offset: 0x0075F23C
		public static void AddIsLoop(FlatBufferBuilder builder, bool isLoop)
		{
			builder.AddBool(2, isLoop, false);
		}

		// Token: 0x06037418 RID: 226328 RVA: 0x00761047 File Offset: 0x0075F247
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06037419 RID: 226329 RVA: 0x00761052 File Offset: 0x0075F252
		public static Offset<ITalkBackgroundSpineImage> EndITalkBackgroundSpineImage(FlatBufferBuilder builder)
		{
			return new Offset<ITalkBackgroundSpineImage>(builder.EndTable());
		}

		// Token: 0x0603741A RID: 226330 RVA: 0x00761060 File Offset: 0x0075F260
		public ITalkBackgroundSpineImageT UnPack()
		{
			ITalkBackgroundSpineImageT talkBackgroundSpineImageT = new ITalkBackgroundSpineImageT();
			this.UnPackTo(talkBackgroundSpineImageT);
			return talkBackgroundSpineImageT;
		}

		// Token: 0x0603741B RID: 226331 RVA: 0x0076107B File Offset: 0x0075F27B
		public void UnPackTo(ITalkBackgroundSpineImageT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.IsLoop = this.IsLoop;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603741C RID: 226332 RVA: 0x007610B0 File Offset: 0x0075F2B0
		public static Offset<ITalkBackgroundSpineImage> Pack(FlatBufferBuilder builder, ITalkBackgroundSpineImageT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkBackgroundSpineImage>);
			}
			return ITalkBackgroundSpineImage.CreateITalkBackgroundSpineImage(builder, _o.Type, _o.Id, _o.IsLoop, _o.NullMask);
		}

		// Token: 0x04012DAF RID: 77231
		private Table __p;
	}
}

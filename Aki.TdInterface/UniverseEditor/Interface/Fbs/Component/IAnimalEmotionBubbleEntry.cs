using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053D0 RID: 21456
	public struct IAnimalEmotionBubbleEntry : IFlatbufferObject
	{
		// Token: 0x170097D6 RID: 38870
		// (get) Token: 0x0602183D RID: 137277 RVA: 0x0049F64D File Offset: 0x0049D84D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602183E RID: 137278 RVA: 0x0049F65A File Offset: 0x0049D85A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602183F RID: 137279 RVA: 0x0049F664 File Offset: 0x0049D864
		public static IAnimalEmotionBubbleEntry GetRootAsIAnimalEmotionBubbleEntry(ByteBuffer _bb)
		{
			return IAnimalEmotionBubbleEntry.GetRootAsIAnimalEmotionBubbleEntry(_bb, default(IAnimalEmotionBubbleEntry));
		}

		// Token: 0x06021840 RID: 137280 RVA: 0x0049F680 File Offset: 0x0049D880
		public static IAnimalEmotionBubbleEntry GetRootAsIAnimalEmotionBubbleEntry(ByteBuffer _bb, IAnimalEmotionBubbleEntry obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021841 RID: 137281 RVA: 0x0049F69D File Offset: 0x0049D89D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021842 RID: 137282 RVA: 0x0049F6AC File Offset: 0x0049D8AC
		public IAnimalEmotionBubbleEntry __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170097D7 RID: 38871
		// (get) Token: 0x06021843 RID: 137283 RVA: 0x0049F6BC File Offset: 0x0049D8BC
		public string MontagePath
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

		// Token: 0x06021844 RID: 137284 RVA: 0x0049F6F3 File Offset: 0x0049D8F3
		public Span<byte> GetMontagePathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06021845 RID: 137285 RVA: 0x0049F702 File Offset: 0x0049D902
		public byte[] GetMontagePathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170097D8 RID: 38872
		// (get) Token: 0x06021846 RID: 137286 RVA: 0x0049F710 File Offset: 0x0049D910
		public string EmotionName
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

		// Token: 0x06021847 RID: 137287 RVA: 0x0049F747 File Offset: 0x0049D947
		public Span<byte> GetEmotionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06021848 RID: 137288 RVA: 0x0049F756 File Offset: 0x0049D956
		public byte[] GetEmotionNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06021849 RID: 137289 RVA: 0x0049F764 File Offset: 0x0049D964
		public static Offset<IAnimalEmotionBubbleEntry> CreateIAnimalEmotionBubbleEntry(FlatBufferBuilder builder, StringOffset MontagePathOffset = default(StringOffset), StringOffset EmotionNameOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IAnimalEmotionBubbleEntry.AddEmotionName(builder, EmotionNameOffset);
			IAnimalEmotionBubbleEntry.AddMontagePath(builder, MontagePathOffset);
			return IAnimalEmotionBubbleEntry.EndIAnimalEmotionBubbleEntry(builder);
		}

		// Token: 0x0602184A RID: 137290 RVA: 0x0049F781 File Offset: 0x0049D981
		public static void StartIAnimalEmotionBubbleEntry(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602184B RID: 137291 RVA: 0x0049F78A File Offset: 0x0049D98A
		public static void AddMontagePath(FlatBufferBuilder builder, StringOffset montagePathOffset)
		{
			builder.AddOffset(0, montagePathOffset.Value, 0);
		}

		// Token: 0x0602184C RID: 137292 RVA: 0x0049F79A File Offset: 0x0049D99A
		public static void AddEmotionName(FlatBufferBuilder builder, StringOffset emotionNameOffset)
		{
			builder.AddOffset(1, emotionNameOffset.Value, 0);
		}

		// Token: 0x0602184D RID: 137293 RVA: 0x0049F7AA File Offset: 0x0049D9AA
		public static Offset<IAnimalEmotionBubbleEntry> EndIAnimalEmotionBubbleEntry(FlatBufferBuilder builder)
		{
			return new Offset<IAnimalEmotionBubbleEntry>(builder.EndTable());
		}

		// Token: 0x0602184E RID: 137294 RVA: 0x0049F7B8 File Offset: 0x0049D9B8
		public IAnimalEmotionBubbleEntryT UnPack()
		{
			IAnimalEmotionBubbleEntryT animalEmotionBubbleEntryT = new IAnimalEmotionBubbleEntryT();
			this.UnPackTo(animalEmotionBubbleEntryT);
			return animalEmotionBubbleEntryT;
		}

		// Token: 0x0602184F RID: 137295 RVA: 0x0049F7D3 File Offset: 0x0049D9D3
		public void UnPackTo(IAnimalEmotionBubbleEntryT _o)
		{
			_o.MontagePath = this.MontagePath;
			_o.EmotionName = this.EmotionName;
		}

		// Token: 0x06021850 RID: 137296 RVA: 0x0049F7F0 File Offset: 0x0049D9F0
		public static Offset<IAnimalEmotionBubbleEntry> Pack(FlatBufferBuilder builder, IAnimalEmotionBubbleEntryT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAnimalEmotionBubbleEntry>);
			}
			StringOffset montagePathOffset = (_o.MontagePath == null) ? default(StringOffset) : builder.CreateString(_o.MontagePath);
			StringOffset emotionNameOffset = (_o.EmotionName == null) ? default(StringOffset) : builder.CreateString(_o.EmotionName);
			return IAnimalEmotionBubbleEntry.CreateIAnimalEmotionBubbleEntry(builder, montagePathOffset, emotionNameOffset);
		}

		// Token: 0x0400E826 RID: 59430
		private Table __p;
	}
}

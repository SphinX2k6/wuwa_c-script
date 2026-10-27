using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EA7 RID: 20135
	public struct IAnimalEmotionBubbleEntry : IFlatbufferObject
	{
		// Token: 0x17009075 RID: 36981
		// (get) Token: 0x0601FB3C RID: 129852 RVA: 0x0046A1D4 File Offset: 0x004683D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FB3D RID: 129853 RVA: 0x0046A1E1 File Offset: 0x004683E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FB3E RID: 129854 RVA: 0x0046A1E8 File Offset: 0x004683E8
		public static IAnimalEmotionBubbleEntry GetRootAsIAnimalEmotionBubbleEntry(ByteBuffer _bb)
		{
			return IAnimalEmotionBubbleEntry.GetRootAsIAnimalEmotionBubbleEntry(_bb, default(IAnimalEmotionBubbleEntry));
		}

		// Token: 0x0601FB3F RID: 129855 RVA: 0x0046A204 File Offset: 0x00468404
		public static IAnimalEmotionBubbleEntry GetRootAsIAnimalEmotionBubbleEntry(ByteBuffer _bb, IAnimalEmotionBubbleEntry obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FB40 RID: 129856 RVA: 0x0046A221 File Offset: 0x00468421
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FB41 RID: 129857 RVA: 0x0046A230 File Offset: 0x00468430
		public IAnimalEmotionBubbleEntry __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009076 RID: 36982
		// (get) Token: 0x0601FB42 RID: 129858 RVA: 0x0046A240 File Offset: 0x00468440
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

		// Token: 0x0601FB43 RID: 129859 RVA: 0x0046A277 File Offset: 0x00468477
		public Span<byte> GetMontagePathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601FB44 RID: 129860 RVA: 0x0046A286 File Offset: 0x00468486
		public byte[] GetMontagePathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17009077 RID: 36983
		// (get) Token: 0x0601FB45 RID: 129861 RVA: 0x0046A294 File Offset: 0x00468494
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

		// Token: 0x0601FB46 RID: 129862 RVA: 0x0046A2CB File Offset: 0x004684CB
		public Span<byte> GetEmotionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601FB47 RID: 129863 RVA: 0x0046A2DA File Offset: 0x004684DA
		public byte[] GetEmotionNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601FB48 RID: 129864 RVA: 0x0046A2E8 File Offset: 0x004684E8
		public static Offset<IAnimalEmotionBubbleEntry> CreateIAnimalEmotionBubbleEntry(FlatBufferBuilder builder, StringOffset MontagePathOffset = default(StringOffset), StringOffset EmotionNameOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IAnimalEmotionBubbleEntry.AddEmotionName(builder, EmotionNameOffset);
			IAnimalEmotionBubbleEntry.AddMontagePath(builder, MontagePathOffset);
			return IAnimalEmotionBubbleEntry.EndIAnimalEmotionBubbleEntry(builder);
		}

		// Token: 0x0601FB49 RID: 129865 RVA: 0x0046A305 File Offset: 0x00468505
		public static void StartIAnimalEmotionBubbleEntry(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601FB4A RID: 129866 RVA: 0x0046A30E File Offset: 0x0046850E
		public static void AddMontagePath(FlatBufferBuilder builder, StringOffset montagePathOffset)
		{
			builder.AddOffset(0, montagePathOffset.Value, 0);
		}

		// Token: 0x0601FB4B RID: 129867 RVA: 0x0046A31E File Offset: 0x0046851E
		public static void AddEmotionName(FlatBufferBuilder builder, StringOffset emotionNameOffset)
		{
			builder.AddOffset(1, emotionNameOffset.Value, 0);
		}

		// Token: 0x0601FB4C RID: 129868 RVA: 0x0046A32E File Offset: 0x0046852E
		public static Offset<IAnimalEmotionBubbleEntry> EndIAnimalEmotionBubbleEntry(FlatBufferBuilder builder)
		{
			return new Offset<IAnimalEmotionBubbleEntry>(builder.EndTable());
		}

		// Token: 0x0601FB4D RID: 129869 RVA: 0x0046A33C File Offset: 0x0046853C
		public IAnimalEmotionBubbleEntryT UnPack()
		{
			IAnimalEmotionBubbleEntryT animalEmotionBubbleEntryT = new IAnimalEmotionBubbleEntryT();
			this.UnPackTo(animalEmotionBubbleEntryT);
			return animalEmotionBubbleEntryT;
		}

		// Token: 0x0601FB4E RID: 129870 RVA: 0x0046A357 File Offset: 0x00468557
		public void UnPackTo(IAnimalEmotionBubbleEntryT _o)
		{
			_o.MontagePath = this.MontagePath;
			_o.EmotionName = this.EmotionName;
		}

		// Token: 0x0601FB4F RID: 129871 RVA: 0x0046A374 File Offset: 0x00468574
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

		// Token: 0x0400DC8A RID: 56458
		private Table __p;
	}
}

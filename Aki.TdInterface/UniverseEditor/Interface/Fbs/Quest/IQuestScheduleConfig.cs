using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200401C RID: 16412
	public struct IQuestScheduleConfig : IFlatbufferObject
	{
		// Token: 0x17007366 RID: 29542
		// (get) Token: 0x06017B57 RID: 97111 RVA: 0x0036B76B File Offset: 0x0036996B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017B58 RID: 97112 RVA: 0x0036B778 File Offset: 0x00369978
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017B59 RID: 97113 RVA: 0x0036B780 File Offset: 0x00369980
		public static IQuestScheduleConfig GetRootAsIQuestScheduleConfig(ByteBuffer _bb)
		{
			return IQuestScheduleConfig.GetRootAsIQuestScheduleConfig(_bb, default(IQuestScheduleConfig));
		}

		// Token: 0x06017B5A RID: 97114 RVA: 0x0036B79C File Offset: 0x0036999C
		public static IQuestScheduleConfig GetRootAsIQuestScheduleConfig(ByteBuffer _bb, IQuestScheduleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017B5B RID: 97115 RVA: 0x0036B7B9 File Offset: 0x003699B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017B5C RID: 97116 RVA: 0x0036B7C8 File Offset: 0x003699C8
		public IQuestScheduleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007367 RID: 29543
		// (get) Token: 0x06017B5D RID: 97117 RVA: 0x0036B7D8 File Offset: 0x003699D8
		public EQuestScheduleUiType UiType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EQuestScheduleUiType.Task;
				}
				return (EQuestScheduleUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007368 RID: 29544
		// (get) Token: 0x06017B5E RID: 97118 RVA: 0x0036B814 File Offset: 0x00369A14
		public IQuestScheduleMainTitle? MainTitle
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IQuestScheduleMainTitle?(default(IQuestScheduleMainTitle).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06017B5F RID: 97119 RVA: 0x0036B874 File Offset: 0x00369A74
		public IQuestScheduleSubTitle? SubTitles(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IQuestScheduleSubTitle?(default(IQuestScheduleSubTitle).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007369 RID: 29545
		// (get) Token: 0x06017B60 RID: 97120 RVA: 0x0036B8D4 File Offset: 0x00369AD4
		public int SubTitlesLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700736A RID: 29546
		// (get) Token: 0x06017B61 RID: 97121 RVA: 0x0036B900 File Offset: 0x00369B00
		public ITrackTarget? TrackTarget
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ITrackTarget?(default(ITrackTarget).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700736B RID: 29547
		// (get) Token: 0x06017B62 RID: 97122 RVA: 0x0036B960 File Offset: 0x00369B60
		public ILevelPlayTrackRadius? TrackRadius
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new ILevelPlayTrackRadius?(default(ILevelPlayTrackRadius).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06017B63 RID: 97123 RVA: 0x0036B9BE File Offset: 0x00369BBE
		public static Offset<IQuestScheduleConfig> CreateIQuestScheduleConfig(FlatBufferBuilder builder, EQuestScheduleUiType UiType = EQuestScheduleUiType.Task, Offset<IQuestScheduleMainTitle> MainTitleOffset = default(Offset<IQuestScheduleMainTitle>), VectorOffset SubTitlesOffset = default(VectorOffset), Offset<ITrackTarget> TrackTargetOffset = default(Offset<ITrackTarget>), Offset<ILevelPlayTrackRadius> TrackRadiusOffset = default(Offset<ILevelPlayTrackRadius>))
		{
			builder.StartTable(5);
			IQuestScheduleConfig.AddTrackRadius(builder, TrackRadiusOffset);
			IQuestScheduleConfig.AddTrackTarget(builder, TrackTargetOffset);
			IQuestScheduleConfig.AddSubTitles(builder, SubTitlesOffset);
			IQuestScheduleConfig.AddMainTitle(builder, MainTitleOffset);
			IQuestScheduleConfig.AddUiType(builder, UiType);
			return IQuestScheduleConfig.EndIQuestScheduleConfig(builder);
		}

		// Token: 0x06017B64 RID: 97124 RVA: 0x0036B9F2 File Offset: 0x00369BF2
		public static void StartIQuestScheduleConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06017B65 RID: 97125 RVA: 0x0036B9FB File Offset: 0x00369BFB
		public static void AddUiType(FlatBufferBuilder builder, EQuestScheduleUiType uiType)
		{
			builder.AddByte(0, (byte)uiType, 0);
		}

		// Token: 0x06017B66 RID: 97126 RVA: 0x0036BA06 File Offset: 0x00369C06
		public static void AddMainTitle(FlatBufferBuilder builder, Offset<IQuestScheduleMainTitle> mainTitleOffset)
		{
			builder.AddOffset(1, mainTitleOffset.Value, 0);
		}

		// Token: 0x06017B67 RID: 97127 RVA: 0x0036BA16 File Offset: 0x00369C16
		public static void AddSubTitles(FlatBufferBuilder builder, VectorOffset subTitlesOffset)
		{
			builder.AddOffset(2, subTitlesOffset.Value, 0);
		}

		// Token: 0x06017B68 RID: 97128 RVA: 0x0036BA28 File Offset: 0x00369C28
		public static VectorOffset CreateSubTitlesVector(FlatBufferBuilder builder, Offset<IQuestScheduleSubTitle>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06017B69 RID: 97129 RVA: 0x0036BA68 File Offset: 0x00369C68
		public static VectorOffset CreateSubTitlesVectorBlock(FlatBufferBuilder builder, Offset<IQuestScheduleSubTitle>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IQuestScheduleSubTitle>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017B6A RID: 97130 RVA: 0x0036BA82 File Offset: 0x00369C82
		public static VectorOffset CreateSubTitlesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IQuestScheduleSubTitle>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IQuestScheduleSubTitle>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017B6B RID: 97131 RVA: 0x0036BAA0 File Offset: 0x00369CA0
		public static VectorOffset CreateSubTitlesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IQuestScheduleSubTitle>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017B6C RID: 97132 RVA: 0x0036BAB9 File Offset: 0x00369CB9
		public static void StartSubTitlesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017B6D RID: 97133 RVA: 0x0036BAC4 File Offset: 0x00369CC4
		public static void AddTrackTarget(FlatBufferBuilder builder, Offset<ITrackTarget> trackTargetOffset)
		{
			builder.AddOffset(3, trackTargetOffset.Value, 0);
		}

		// Token: 0x06017B6E RID: 97134 RVA: 0x0036BAD4 File Offset: 0x00369CD4
		public static void AddTrackRadius(FlatBufferBuilder builder, Offset<ILevelPlayTrackRadius> trackRadiusOffset)
		{
			builder.AddOffset(4, trackRadiusOffset.Value, 0);
		}

		// Token: 0x06017B6F RID: 97135 RVA: 0x0036BAE4 File Offset: 0x00369CE4
		public static Offset<IQuestScheduleConfig> EndIQuestScheduleConfig(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleConfig>(builder.EndTable());
		}

		// Token: 0x06017B70 RID: 97136 RVA: 0x0036BAF4 File Offset: 0x00369CF4
		public IQuestScheduleConfigT UnPack()
		{
			IQuestScheduleConfigT questScheduleConfigT = new IQuestScheduleConfigT();
			this.UnPackTo(questScheduleConfigT);
			return questScheduleConfigT;
		}

		// Token: 0x06017B71 RID: 97137 RVA: 0x0036BB10 File Offset: 0x00369D10
		public void UnPackTo(IQuestScheduleConfigT _o)
		{
			_o.UiType = this.UiType;
			_o.MainTitle = ((this.MainTitle != null) ? this.MainTitle.Value.UnPack() : null);
			_o.SubTitles = new List<IQuestScheduleSubTitleT>();
			for (int i = 0; i < this.SubTitlesLength; i++)
			{
				_o.SubTitles.Add((this.SubTitles(i) != null) ? this.SubTitles(i).Value.UnPack() : null);
			}
			_o.TrackTarget = ((this.TrackTarget != null) ? this.TrackTarget.Value.UnPack() : null);
			_o.TrackRadius = ((this.TrackRadius != null) ? this.TrackRadius.Value.UnPack() : null);
		}

		// Token: 0x06017B72 RID: 97138 RVA: 0x0036BC10 File Offset: 0x00369E10
		public static Offset<IQuestScheduleConfig> Pack(FlatBufferBuilder builder, IQuestScheduleConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestScheduleConfig>);
			}
			Offset<IQuestScheduleMainTitle> mainTitleOffset = (_o.MainTitle == null) ? default(Offset<IQuestScheduleMainTitle>) : IQuestScheduleMainTitle.Pack(builder, _o.MainTitle);
			VectorOffset subTitlesOffset = default(VectorOffset);
			if (_o.SubTitles != null)
			{
				Offset<IQuestScheduleSubTitle>[] array = new Offset<IQuestScheduleSubTitle>[_o.SubTitles.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IQuestScheduleSubTitle.Pack(builder, _o.SubTitles[i]);
				}
				subTitlesOffset = IQuestScheduleConfig.CreateSubTitlesVector(builder, array);
			}
			Offset<ITrackTarget> trackTargetOffset = (_o.TrackTarget == null) ? default(Offset<ITrackTarget>) : ITrackTarget.Pack(builder, _o.TrackTarget);
			Offset<ILevelPlayTrackRadius> trackRadiusOffset = (_o.TrackRadius == null) ? default(Offset<ILevelPlayTrackRadius>) : ILevelPlayTrackRadius.Pack(builder, _o.TrackRadius);
			return IQuestScheduleConfig.CreateIQuestScheduleConfig(builder, _o.UiType, mainTitleOffset, subTitlesOffset, trackTargetOffset, trackRadiusOffset);
		}

		// Token: 0x0400BB41 RID: 47937
		private Table __p;
	}
}

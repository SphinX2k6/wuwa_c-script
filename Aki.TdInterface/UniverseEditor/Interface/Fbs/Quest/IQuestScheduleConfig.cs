using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200445D RID: 17501
	public struct IQuestScheduleConfig : IFlatbufferObject
	{
		// Token: 0x17007968 RID: 31080
		// (get) Token: 0x060191F0 RID: 102896 RVA: 0x0039555F File Offset: 0x0039375F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060191F1 RID: 102897 RVA: 0x0039556C File Offset: 0x0039376C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060191F2 RID: 102898 RVA: 0x00395574 File Offset: 0x00393774
		public static IQuestScheduleConfig GetRootAsIQuestScheduleConfig(ByteBuffer _bb)
		{
			return IQuestScheduleConfig.GetRootAsIQuestScheduleConfig(_bb, default(IQuestScheduleConfig));
		}

		// Token: 0x060191F3 RID: 102899 RVA: 0x00395590 File Offset: 0x00393790
		public static IQuestScheduleConfig GetRootAsIQuestScheduleConfig(ByteBuffer _bb, IQuestScheduleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060191F4 RID: 102900 RVA: 0x003955AD File Offset: 0x003937AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060191F5 RID: 102901 RVA: 0x003955BC File Offset: 0x003937BC
		public IQuestScheduleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007969 RID: 31081
		// (get) Token: 0x060191F6 RID: 102902 RVA: 0x003955CC File Offset: 0x003937CC
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

		// Token: 0x1700796A RID: 31082
		// (get) Token: 0x060191F7 RID: 102903 RVA: 0x00395608 File Offset: 0x00393808
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

		// Token: 0x060191F8 RID: 102904 RVA: 0x00395668 File Offset: 0x00393868
		public IQuestScheduleSubTitle? SubTitles(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IQuestScheduleSubTitle?(default(IQuestScheduleSubTitle).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700796B RID: 31083
		// (get) Token: 0x060191F9 RID: 102905 RVA: 0x003956C8 File Offset: 0x003938C8
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

		// Token: 0x1700796C RID: 31084
		// (get) Token: 0x060191FA RID: 102906 RVA: 0x003956F4 File Offset: 0x003938F4
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

		// Token: 0x1700796D RID: 31085
		// (get) Token: 0x060191FB RID: 102907 RVA: 0x00395754 File Offset: 0x00393954
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

		// Token: 0x060191FC RID: 102908 RVA: 0x003957B2 File Offset: 0x003939B2
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

		// Token: 0x060191FD RID: 102909 RVA: 0x003957E6 File Offset: 0x003939E6
		public static void StartIQuestScheduleConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060191FE RID: 102910 RVA: 0x003957EF File Offset: 0x003939EF
		public static void AddUiType(FlatBufferBuilder builder, EQuestScheduleUiType uiType)
		{
			builder.AddByte(0, (byte)uiType, 0);
		}

		// Token: 0x060191FF RID: 102911 RVA: 0x003957FA File Offset: 0x003939FA
		public static void AddMainTitle(FlatBufferBuilder builder, Offset<IQuestScheduleMainTitle> mainTitleOffset)
		{
			builder.AddOffset(1, mainTitleOffset.Value, 0);
		}

		// Token: 0x06019200 RID: 102912 RVA: 0x0039580A File Offset: 0x00393A0A
		public static void AddSubTitles(FlatBufferBuilder builder, VectorOffset subTitlesOffset)
		{
			builder.AddOffset(2, subTitlesOffset.Value, 0);
		}

		// Token: 0x06019201 RID: 102913 RVA: 0x0039581C File Offset: 0x00393A1C
		public static VectorOffset CreateSubTitlesVector(FlatBufferBuilder builder, Offset<IQuestScheduleSubTitle>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019202 RID: 102914 RVA: 0x0039585C File Offset: 0x00393A5C
		public static VectorOffset CreateSubTitlesVectorBlock(FlatBufferBuilder builder, Offset<IQuestScheduleSubTitle>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IQuestScheduleSubTitle>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019203 RID: 102915 RVA: 0x00395876 File Offset: 0x00393A76
		public static VectorOffset CreateSubTitlesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IQuestScheduleSubTitle>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IQuestScheduleSubTitle>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019204 RID: 102916 RVA: 0x00395894 File Offset: 0x00393A94
		public static VectorOffset CreateSubTitlesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IQuestScheduleSubTitle>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019205 RID: 102917 RVA: 0x003958AD File Offset: 0x00393AAD
		public static void StartSubTitlesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019206 RID: 102918 RVA: 0x003958B8 File Offset: 0x00393AB8
		public static void AddTrackTarget(FlatBufferBuilder builder, Offset<ITrackTarget> trackTargetOffset)
		{
			builder.AddOffset(3, trackTargetOffset.Value, 0);
		}

		// Token: 0x06019207 RID: 102919 RVA: 0x003958C8 File Offset: 0x00393AC8
		public static void AddTrackRadius(FlatBufferBuilder builder, Offset<ILevelPlayTrackRadius> trackRadiusOffset)
		{
			builder.AddOffset(4, trackRadiusOffset.Value, 0);
		}

		// Token: 0x06019208 RID: 102920 RVA: 0x003958D8 File Offset: 0x00393AD8
		public static Offset<IQuestScheduleConfig> EndIQuestScheduleConfig(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleConfig>(builder.EndTable());
		}

		// Token: 0x06019209 RID: 102921 RVA: 0x003958E8 File Offset: 0x00393AE8
		public IQuestScheduleConfigT UnPack()
		{
			IQuestScheduleConfigT questScheduleConfigT = new IQuestScheduleConfigT();
			this.UnPackTo(questScheduleConfigT);
			return questScheduleConfigT;
		}

		// Token: 0x0601920A RID: 102922 RVA: 0x00395904 File Offset: 0x00393B04
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

		// Token: 0x0601920B RID: 102923 RVA: 0x00395A04 File Offset: 0x00393C04
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

		// Token: 0x0400C528 RID: 50472
		private Table __p;
	}
}

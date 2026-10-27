using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AF7 RID: 27383
	public struct IMontageData : IFlatbufferObject
	{
		// Token: 0x1700CB1E RID: 51998
		// (get) Token: 0x0602FFF0 RID: 196592 RVA: 0x00686724 File Offset: 0x00684924
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FFF1 RID: 196593 RVA: 0x00686731 File Offset: 0x00684931
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FFF2 RID: 196594 RVA: 0x00686738 File Offset: 0x00684938
		public static IMontageData GetRootAsIMontageData(ByteBuffer _bb)
		{
			return IMontageData.GetRootAsIMontageData(_bb, default(IMontageData));
		}

		// Token: 0x0602FFF3 RID: 196595 RVA: 0x00686754 File Offset: 0x00684954
		public static IMontageData GetRootAsIMontageData(ByteBuffer _bb, IMontageData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FFF4 RID: 196596 RVA: 0x00686771 File Offset: 0x00684971
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FFF5 RID: 196597 RVA: 0x00686780 File Offset: 0x00684980
		public IMontageData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CB1F RID: 51999
		// (get) Token: 0x0602FFF6 RID: 196598 RVA: 0x00686790 File Offset: 0x00684990
		public int ActorIndex
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

		// Token: 0x1700CB20 RID: 52000
		// (get) Token: 0x0602FFF7 RID: 196599 RVA: 0x006867CC File Offset: 0x006849CC
		public int MontageId
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

		// Token: 0x1700CB21 RID: 52001
		// (get) Token: 0x0602FFF8 RID: 196600 RVA: 0x00686808 File Offset: 0x00684A08
		public bool IsAbpMontage
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB22 RID: 52002
		// (get) Token: 0x0602FFF9 RID: 196601 RVA: 0x00686848 File Offset: 0x00684A48
		public bool IsLoop
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB23 RID: 52003
		// (get) Token: 0x0602FFFA RID: 196602 RVA: 0x00686888 File Offset: 0x00684A88
		public bool KeepPose
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB24 RID: 52004
		// (get) Token: 0x0602FFFB RID: 196603 RVA: 0x006868C8 File Offset: 0x00684AC8
		public float DelayTime
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CB25 RID: 52005
		// (get) Token: 0x0602FFFC RID: 196604 RVA: 0x0068690C File Offset: 0x00684B0C
		public bool EndLoopingMontage
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB26 RID: 52006
		// (get) Token: 0x0602FFFD RID: 196605 RVA: 0x0068694C File Offset: 0x00684B4C
		public bool EndMontageDirectly
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB27 RID: 52007
		// (get) Token: 0x0602FFFE RID: 196606 RVA: 0x0068698C File Offset: 0x00684B8C
		public bool StartFromLoop
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB28 RID: 52008
		// (get) Token: 0x0602FFFF RID: 196607 RVA: 0x006869CC File Offset: 0x00684BCC
		public IMontageParam? OverlayMontage
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return new IMontageParam?(default(IMontageParam).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CB29 RID: 52009
		// (get) Token: 0x06030000 RID: 196608 RVA: 0x00686A2C File Offset: 0x00684C2C
		public int FaceExpressionId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CB2A RID: 52010
		// (get) Token: 0x06030001 RID: 196609 RVA: 0x00686A6C File Offset: 0x00684C6C
		public bool KeepFaceExpression
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06030002 RID: 196610 RVA: 0x00686AAC File Offset: 0x00684CAC
		public IActorFxEmotePlay? FxEmote(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new IActorFxEmotePlay?(default(IActorFxEmotePlay).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700CB2B RID: 52011
		// (get) Token: 0x06030003 RID: 196611 RVA: 0x00686B10 File Offset: 0x00684D10
		public int FxEmoteLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700CB2C RID: 52012
		// (get) Token: 0x06030004 RID: 196612 RVA: 0x00686B3C File Offset: 0x00684D3C
		public ushort NullMask
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030005 RID: 196613 RVA: 0x00686B7C File Offset: 0x00684D7C
		public static Offset<IMontageData> CreateIMontageData(FlatBufferBuilder builder, int ActorIndex = 0, int MontageId = 0, bool IsAbpMontage = false, bool IsLoop = false, bool KeepPose = false, float DelayTime = 0f, bool EndLoopingMontage = false, bool EndMontageDirectly = false, bool StartFromLoop = false, Offset<IMontageParam> OverlayMontageOffset = default(Offset<IMontageParam>), int FaceExpressionId = 0, bool KeepFaceExpression = false, VectorOffset FxEmoteOffset = default(VectorOffset), ushort NullMask = 0)
		{
			builder.StartTable(14);
			IMontageData.AddFxEmote(builder, FxEmoteOffset);
			IMontageData.AddFaceExpressionId(builder, FaceExpressionId);
			IMontageData.AddOverlayMontage(builder, OverlayMontageOffset);
			IMontageData.AddDelayTime(builder, DelayTime);
			IMontageData.AddMontageId(builder, MontageId);
			IMontageData.AddActorIndex(builder, ActorIndex);
			IMontageData.AddNullMask(builder, NullMask);
			IMontageData.AddKeepFaceExpression(builder, KeepFaceExpression);
			IMontageData.AddStartFromLoop(builder, StartFromLoop);
			IMontageData.AddEndMontageDirectly(builder, EndMontageDirectly);
			IMontageData.AddEndLoopingMontage(builder, EndLoopingMontage);
			IMontageData.AddKeepPose(builder, KeepPose);
			IMontageData.AddIsLoop(builder, IsLoop);
			IMontageData.AddIsAbpMontage(builder, IsAbpMontage);
			return IMontageData.EndIMontageData(builder);
		}

		// Token: 0x06030006 RID: 196614 RVA: 0x00686C04 File Offset: 0x00684E04
		public static void StartIMontageData(FlatBufferBuilder builder)
		{
			builder.StartTable(14);
		}

		// Token: 0x06030007 RID: 196615 RVA: 0x00686C0E File Offset: 0x00684E0E
		public static void AddActorIndex(FlatBufferBuilder builder, int actorIndex)
		{
			builder.AddInt(0, actorIndex, 0);
		}

		// Token: 0x06030008 RID: 196616 RVA: 0x00686C19 File Offset: 0x00684E19
		public static void AddMontageId(FlatBufferBuilder builder, int montageId)
		{
			builder.AddInt(1, montageId, 0);
		}

		// Token: 0x06030009 RID: 196617 RVA: 0x00686C24 File Offset: 0x00684E24
		public static void AddIsAbpMontage(FlatBufferBuilder builder, bool isAbpMontage)
		{
			builder.AddBool(2, isAbpMontage, false);
		}

		// Token: 0x0603000A RID: 196618 RVA: 0x00686C2F File Offset: 0x00684E2F
		public static void AddIsLoop(FlatBufferBuilder builder, bool isLoop)
		{
			builder.AddBool(3, isLoop, false);
		}

		// Token: 0x0603000B RID: 196619 RVA: 0x00686C3A File Offset: 0x00684E3A
		public static void AddKeepPose(FlatBufferBuilder builder, bool keepPose)
		{
			builder.AddBool(4, keepPose, false);
		}

		// Token: 0x0603000C RID: 196620 RVA: 0x00686C45 File Offset: 0x00684E45
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(5, delayTime, 0.0);
		}

		// Token: 0x0603000D RID: 196621 RVA: 0x00686C58 File Offset: 0x00684E58
		public static void AddEndLoopingMontage(FlatBufferBuilder builder, bool endLoopingMontage)
		{
			builder.AddBool(6, endLoopingMontage, false);
		}

		// Token: 0x0603000E RID: 196622 RVA: 0x00686C63 File Offset: 0x00684E63
		public static void AddEndMontageDirectly(FlatBufferBuilder builder, bool endMontageDirectly)
		{
			builder.AddBool(7, endMontageDirectly, false);
		}

		// Token: 0x0603000F RID: 196623 RVA: 0x00686C6E File Offset: 0x00684E6E
		public static void AddStartFromLoop(FlatBufferBuilder builder, bool startFromLoop)
		{
			builder.AddBool(8, startFromLoop, false);
		}

		// Token: 0x06030010 RID: 196624 RVA: 0x00686C79 File Offset: 0x00684E79
		public static void AddOverlayMontage(FlatBufferBuilder builder, Offset<IMontageParam> overlayMontageOffset)
		{
			builder.AddOffset(9, overlayMontageOffset.Value, 0);
		}

		// Token: 0x06030011 RID: 196625 RVA: 0x00686C8A File Offset: 0x00684E8A
		public static void AddFaceExpressionId(FlatBufferBuilder builder, int faceExpressionId)
		{
			builder.AddInt(10, faceExpressionId, 0);
		}

		// Token: 0x06030012 RID: 196626 RVA: 0x00686C96 File Offset: 0x00684E96
		public static void AddKeepFaceExpression(FlatBufferBuilder builder, bool keepFaceExpression)
		{
			builder.AddBool(11, keepFaceExpression, false);
		}

		// Token: 0x06030013 RID: 196627 RVA: 0x00686CA2 File Offset: 0x00684EA2
		public static void AddFxEmote(FlatBufferBuilder builder, VectorOffset fxEmoteOffset)
		{
			builder.AddOffset(12, fxEmoteOffset.Value, 0);
		}

		// Token: 0x06030014 RID: 196628 RVA: 0x00686CB4 File Offset: 0x00684EB4
		public static VectorOffset CreateFxEmoteVector(FlatBufferBuilder builder, Offset<IActorFxEmotePlay>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06030015 RID: 196629 RVA: 0x00686CF4 File Offset: 0x00684EF4
		public static VectorOffset CreateFxEmoteVectorBlock(FlatBufferBuilder builder, Offset<IActorFxEmotePlay>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorFxEmotePlay>>(data);
			return builder.EndVector();
		}

		// Token: 0x06030016 RID: 196630 RVA: 0x00686D0E File Offset: 0x00684F0E
		public static VectorOffset CreateFxEmoteVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorFxEmotePlay>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorFxEmotePlay>>(data);
			return builder.EndVector();
		}

		// Token: 0x06030017 RID: 196631 RVA: 0x00686D2C File Offset: 0x00684F2C
		public static VectorOffset CreateFxEmoteVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorFxEmotePlay>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06030018 RID: 196632 RVA: 0x00686D45 File Offset: 0x00684F45
		public static void StartFxEmoteVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06030019 RID: 196633 RVA: 0x00686D50 File Offset: 0x00684F50
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(13, nullMask, 0);
		}

		// Token: 0x0603001A RID: 196634 RVA: 0x00686D5C File Offset: 0x00684F5C
		public static Offset<IMontageData> EndIMontageData(FlatBufferBuilder builder)
		{
			return new Offset<IMontageData>(builder.EndTable());
		}

		// Token: 0x0603001B RID: 196635 RVA: 0x00686D6C File Offset: 0x00684F6C
		public IMontageDataT UnPack()
		{
			IMontageDataT montageDataT = new IMontageDataT();
			this.UnPackTo(montageDataT);
			return montageDataT;
		}

		// Token: 0x0603001C RID: 196636 RVA: 0x00686D88 File Offset: 0x00684F88
		public void UnPackTo(IMontageDataT _o)
		{
			_o.ActorIndex = this.ActorIndex;
			_o.MontageId = this.MontageId;
			_o.IsAbpMontage = this.IsAbpMontage;
			_o.IsLoop = this.IsLoop;
			_o.KeepPose = this.KeepPose;
			_o.DelayTime = this.DelayTime;
			_o.EndLoopingMontage = this.EndLoopingMontage;
			_o.EndMontageDirectly = this.EndMontageDirectly;
			_o.StartFromLoop = this.StartFromLoop;
			_o.OverlayMontage = ((this.OverlayMontage != null) ? this.OverlayMontage.Value.UnPack() : null);
			_o.FaceExpressionId = this.FaceExpressionId;
			_o.KeepFaceExpression = this.KeepFaceExpression;
			_o.FxEmote = new List<IActorFxEmotePlayT>();
			for (int i = 0; i < this.FxEmoteLength; i++)
			{
				_o.FxEmote.Add((this.FxEmote(i) != null) ? this.FxEmote(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603001D RID: 196637 RVA: 0x00686EA8 File Offset: 0x006850A8
		public static Offset<IMontageData> Pack(FlatBufferBuilder builder, IMontageDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMontageData>);
			}
			Offset<IMontageParam> overlayMontageOffset = (_o.OverlayMontage == null) ? default(Offset<IMontageParam>) : IMontageParam.Pack(builder, _o.OverlayMontage);
			VectorOffset fxEmoteOffset = default(VectorOffset);
			if (_o.FxEmote != null)
			{
				Offset<IActorFxEmotePlay>[] array = new Offset<IActorFxEmotePlay>[_o.FxEmote.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActorFxEmotePlay.Pack(builder, _o.FxEmote[i]);
				}
				fxEmoteOffset = IMontageData.CreateFxEmoteVector(builder, array);
			}
			return IMontageData.CreateIMontageData(builder, _o.ActorIndex, _o.MontageId, _o.IsAbpMontage, _o.IsLoop, _o.KeepPose, _o.DelayTime, _o.EndLoopingMontage, _o.EndMontageDirectly, _o.StartFromLoop, overlayMontageOffset, _o.FaceExpressionId, _o.KeepFaceExpression, fxEmoteOffset, _o.NullMask);
		}

		// Token: 0x0401134F RID: 70479
		private Table __p;
	}
}

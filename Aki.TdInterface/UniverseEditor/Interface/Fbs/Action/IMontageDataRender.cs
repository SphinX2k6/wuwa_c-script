using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AFA RID: 27386
	public struct IMontageDataRender : IFlatbufferObject
	{
		// Token: 0x1700CB3B RID: 52027
		// (get) Token: 0x0603003C RID: 196668 RVA: 0x00687240 File Offset: 0x00685440
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603003D RID: 196669 RVA: 0x0068724D File Offset: 0x0068544D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603003E RID: 196670 RVA: 0x00687254 File Offset: 0x00685454
		public static IMontageDataRender GetRootAsIMontageDataRender(ByteBuffer _bb)
		{
			return IMontageDataRender.GetRootAsIMontageDataRender(_bb, default(IMontageDataRender));
		}

		// Token: 0x0603003F RID: 196671 RVA: 0x00687270 File Offset: 0x00685470
		public static IMontageDataRender GetRootAsIMontageDataRender(ByteBuffer _bb, IMontageDataRender obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030040 RID: 196672 RVA: 0x0068728D File Offset: 0x0068548D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030041 RID: 196673 RVA: 0x0068729C File Offset: 0x0068549C
		public IMontageDataRender __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CB3C RID: 52028
		// (get) Token: 0x06030042 RID: 196674 RVA: 0x006872AC File Offset: 0x006854AC
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

		// Token: 0x1700CB3D RID: 52029
		// (get) Token: 0x06030043 RID: 196675 RVA: 0x006872E8 File Offset: 0x006854E8
		public IMontageParam? BaseMontage
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IMontageParam?(default(IMontageParam).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CB3E RID: 52030
		// (get) Token: 0x06030044 RID: 196676 RVA: 0x00687348 File Offset: 0x00685548
		public bool EndLoopingMontage
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB3F RID: 52031
		// (get) Token: 0x06030045 RID: 196677 RVA: 0x00687388 File Offset: 0x00685588
		public bool EndMontageDirectly
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB40 RID: 52032
		// (get) Token: 0x06030046 RID: 196678 RVA: 0x006873C8 File Offset: 0x006855C8
		public bool StartFromLoop
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB41 RID: 52033
		// (get) Token: 0x06030047 RID: 196679 RVA: 0x00687408 File Offset: 0x00685608
		public IMontageParam? OverlayMontage
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IMontageParam?(default(IMontageParam).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CB42 RID: 52034
		// (get) Token: 0x06030048 RID: 196680 RVA: 0x00687468 File Offset: 0x00685668
		public int FaceExpressionId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CB43 RID: 52035
		// (get) Token: 0x06030049 RID: 196681 RVA: 0x006874A8 File Offset: 0x006856A8
		public bool KeepFaceExpression
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB44 RID: 52036
		// (get) Token: 0x0603004A RID: 196682 RVA: 0x006874E8 File Offset: 0x006856E8
		public float DelayTime
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603004B RID: 196683 RVA: 0x0068752C File Offset: 0x0068572C
		public IActorFxEmotePlay? FxEmote(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new IActorFxEmotePlay?(default(IActorFxEmotePlay).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700CB45 RID: 52037
		// (get) Token: 0x0603004C RID: 196684 RVA: 0x00687590 File Offset: 0x00685790
		public int FxEmoteLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700CB46 RID: 52038
		// (get) Token: 0x0603004D RID: 196685 RVA: 0x006875BC File Offset: 0x006857BC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603004E RID: 196686 RVA: 0x006875FC File Offset: 0x006857FC
		public static Offset<IMontageDataRender> CreateIMontageDataRender(FlatBufferBuilder builder, int ActorIndex = 0, Offset<IMontageParam> BaseMontageOffset = default(Offset<IMontageParam>), bool EndLoopingMontage = false, bool EndMontageDirectly = false, bool StartFromLoop = false, Offset<IMontageParam> OverlayMontageOffset = default(Offset<IMontageParam>), int FaceExpressionId = 0, bool KeepFaceExpression = false, float DelayTime = 0f, VectorOffset FxEmoteOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(11);
			IMontageDataRender.AddFxEmote(builder, FxEmoteOffset);
			IMontageDataRender.AddDelayTime(builder, DelayTime);
			IMontageDataRender.AddFaceExpressionId(builder, FaceExpressionId);
			IMontageDataRender.AddOverlayMontage(builder, OverlayMontageOffset);
			IMontageDataRender.AddBaseMontage(builder, BaseMontageOffset);
			IMontageDataRender.AddActorIndex(builder, ActorIndex);
			IMontageDataRender.AddNullMask(builder, NullMask);
			IMontageDataRender.AddKeepFaceExpression(builder, KeepFaceExpression);
			IMontageDataRender.AddStartFromLoop(builder, StartFromLoop);
			IMontageDataRender.AddEndMontageDirectly(builder, EndMontageDirectly);
			IMontageDataRender.AddEndLoopingMontage(builder, EndLoopingMontage);
			return IMontageDataRender.EndIMontageDataRender(builder);
		}

		// Token: 0x0603004F RID: 196687 RVA: 0x0068766C File Offset: 0x0068586C
		public static void StartIMontageDataRender(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x06030050 RID: 196688 RVA: 0x00687676 File Offset: 0x00685876
		public static void AddActorIndex(FlatBufferBuilder builder, int actorIndex)
		{
			builder.AddInt(0, actorIndex, 0);
		}

		// Token: 0x06030051 RID: 196689 RVA: 0x00687681 File Offset: 0x00685881
		public static void AddBaseMontage(FlatBufferBuilder builder, Offset<IMontageParam> baseMontageOffset)
		{
			builder.AddOffset(1, baseMontageOffset.Value, 0);
		}

		// Token: 0x06030052 RID: 196690 RVA: 0x00687691 File Offset: 0x00685891
		public static void AddEndLoopingMontage(FlatBufferBuilder builder, bool endLoopingMontage)
		{
			builder.AddBool(2, endLoopingMontage, false);
		}

		// Token: 0x06030053 RID: 196691 RVA: 0x0068769C File Offset: 0x0068589C
		public static void AddEndMontageDirectly(FlatBufferBuilder builder, bool endMontageDirectly)
		{
			builder.AddBool(3, endMontageDirectly, false);
		}

		// Token: 0x06030054 RID: 196692 RVA: 0x006876A7 File Offset: 0x006858A7
		public static void AddStartFromLoop(FlatBufferBuilder builder, bool startFromLoop)
		{
			builder.AddBool(4, startFromLoop, false);
		}

		// Token: 0x06030055 RID: 196693 RVA: 0x006876B2 File Offset: 0x006858B2
		public static void AddOverlayMontage(FlatBufferBuilder builder, Offset<IMontageParam> overlayMontageOffset)
		{
			builder.AddOffset(5, overlayMontageOffset.Value, 0);
		}

		// Token: 0x06030056 RID: 196694 RVA: 0x006876C2 File Offset: 0x006858C2
		public static void AddFaceExpressionId(FlatBufferBuilder builder, int faceExpressionId)
		{
			builder.AddInt(6, faceExpressionId, 0);
		}

		// Token: 0x06030057 RID: 196695 RVA: 0x006876CD File Offset: 0x006858CD
		public static void AddKeepFaceExpression(FlatBufferBuilder builder, bool keepFaceExpression)
		{
			builder.AddBool(7, keepFaceExpression, false);
		}

		// Token: 0x06030058 RID: 196696 RVA: 0x006876D8 File Offset: 0x006858D8
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(8, delayTime, 0.0);
		}

		// Token: 0x06030059 RID: 196697 RVA: 0x006876EB File Offset: 0x006858EB
		public static void AddFxEmote(FlatBufferBuilder builder, VectorOffset fxEmoteOffset)
		{
			builder.AddOffset(9, fxEmoteOffset.Value, 0);
		}

		// Token: 0x0603005A RID: 196698 RVA: 0x006876FC File Offset: 0x006858FC
		public static VectorOffset CreateFxEmoteVector(FlatBufferBuilder builder, Offset<IActorFxEmotePlay>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603005B RID: 196699 RVA: 0x0068773C File Offset: 0x0068593C
		public static VectorOffset CreateFxEmoteVectorBlock(FlatBufferBuilder builder, Offset<IActorFxEmotePlay>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorFxEmotePlay>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603005C RID: 196700 RVA: 0x00687756 File Offset: 0x00685956
		public static VectorOffset CreateFxEmoteVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorFxEmotePlay>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorFxEmotePlay>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603005D RID: 196701 RVA: 0x00687774 File Offset: 0x00685974
		public static VectorOffset CreateFxEmoteVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorFxEmotePlay>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603005E RID: 196702 RVA: 0x0068778D File Offset: 0x0068598D
		public static void StartFxEmoteVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603005F RID: 196703 RVA: 0x00687798 File Offset: 0x00685998
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x06030060 RID: 196704 RVA: 0x006877A4 File Offset: 0x006859A4
		public static Offset<IMontageDataRender> EndIMontageDataRender(FlatBufferBuilder builder)
		{
			return new Offset<IMontageDataRender>(builder.EndTable());
		}

		// Token: 0x06030061 RID: 196705 RVA: 0x006877B4 File Offset: 0x006859B4
		public IMontageDataRenderT UnPack()
		{
			IMontageDataRenderT montageDataRenderT = new IMontageDataRenderT();
			this.UnPackTo(montageDataRenderT);
			return montageDataRenderT;
		}

		// Token: 0x06030062 RID: 196706 RVA: 0x006877D0 File Offset: 0x006859D0
		public void UnPackTo(IMontageDataRenderT _o)
		{
			_o.ActorIndex = this.ActorIndex;
			_o.BaseMontage = ((this.BaseMontage != null) ? this.BaseMontage.Value.UnPack() : null);
			_o.EndLoopingMontage = this.EndLoopingMontage;
			_o.EndMontageDirectly = this.EndMontageDirectly;
			_o.StartFromLoop = this.StartFromLoop;
			_o.OverlayMontage = ((this.OverlayMontage != null) ? this.OverlayMontage.Value.UnPack() : null);
			_o.FaceExpressionId = this.FaceExpressionId;
			_o.KeepFaceExpression = this.KeepFaceExpression;
			_o.DelayTime = this.DelayTime;
			_o.FxEmote = new List<IActorFxEmotePlayT>();
			for (int i = 0; i < this.FxEmoteLength; i++)
			{
				_o.FxEmote.Add((this.FxEmote(i) != null) ? this.FxEmote(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030063 RID: 196707 RVA: 0x006878F0 File Offset: 0x00685AF0
		public static Offset<IMontageDataRender> Pack(FlatBufferBuilder builder, IMontageDataRenderT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMontageDataRender>);
			}
			Offset<IMontageParam> baseMontageOffset = (_o.BaseMontage == null) ? default(Offset<IMontageParam>) : IMontageParam.Pack(builder, _o.BaseMontage);
			Offset<IMontageParam> overlayMontageOffset = (_o.OverlayMontage == null) ? default(Offset<IMontageParam>) : IMontageParam.Pack(builder, _o.OverlayMontage);
			VectorOffset fxEmoteOffset = default(VectorOffset);
			if (_o.FxEmote != null)
			{
				Offset<IActorFxEmotePlay>[] array = new Offset<IActorFxEmotePlay>[_o.FxEmote.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActorFxEmotePlay.Pack(builder, _o.FxEmote[i]);
				}
				fxEmoteOffset = IMontageDataRender.CreateFxEmoteVector(builder, array);
			}
			return IMontageDataRender.CreateIMontageDataRender(builder, _o.ActorIndex, baseMontageOffset, _o.EndLoopingMontage, _o.EndMontageDirectly, _o.StartFromLoop, overlayMontageOffset, _o.FaceExpressionId, _o.KeepFaceExpression, _o.DelayTime, fxEmoteOffset, _o.NullMask);
		}

		// Token: 0x0401135E RID: 70494
		private Table __p;
	}
}

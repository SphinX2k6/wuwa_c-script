using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200722E RID: 29230
	public struct IMontageData : IFlatbufferObject
	{
		// Token: 0x1700D5ED RID: 54765
		// (get) Token: 0x06032DC4 RID: 208324 RVA: 0x006DDDDC File Offset: 0x006DBFDC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032DC5 RID: 208325 RVA: 0x006DDDE9 File Offset: 0x006DBFE9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032DC6 RID: 208326 RVA: 0x006DDDF0 File Offset: 0x006DBFF0
		public static IMontageData GetRootAsIMontageData(ByteBuffer _bb)
		{
			return IMontageData.GetRootAsIMontageData(_bb, default(IMontageData));
		}

		// Token: 0x06032DC7 RID: 208327 RVA: 0x006DDE0C File Offset: 0x006DC00C
		public static IMontageData GetRootAsIMontageData(ByteBuffer _bb, IMontageData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032DC8 RID: 208328 RVA: 0x006DDE29 File Offset: 0x006DC029
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032DC9 RID: 208329 RVA: 0x006DDE38 File Offset: 0x006DC038
		public IMontageData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D5EE RID: 54766
		// (get) Token: 0x06032DCA RID: 208330 RVA: 0x006DDE48 File Offset: 0x006DC048
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

		// Token: 0x1700D5EF RID: 54767
		// (get) Token: 0x06032DCB RID: 208331 RVA: 0x006DDE84 File Offset: 0x006DC084
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

		// Token: 0x1700D5F0 RID: 54768
		// (get) Token: 0x06032DCC RID: 208332 RVA: 0x006DDEC0 File Offset: 0x006DC0C0
		public bool IsAbpMontage
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D5F1 RID: 54769
		// (get) Token: 0x06032DCD RID: 208333 RVA: 0x006DDF00 File Offset: 0x006DC100
		public bool IsLoop
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D5F2 RID: 54770
		// (get) Token: 0x06032DCE RID: 208334 RVA: 0x006DDF40 File Offset: 0x006DC140
		public bool KeepPose
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D5F3 RID: 54771
		// (get) Token: 0x06032DCF RID: 208335 RVA: 0x006DDF80 File Offset: 0x006DC180
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

		// Token: 0x1700D5F4 RID: 54772
		// (get) Token: 0x06032DD0 RID: 208336 RVA: 0x006DDFC4 File Offset: 0x006DC1C4
		public bool EndLoopingMontage
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D5F5 RID: 54773
		// (get) Token: 0x06032DD1 RID: 208337 RVA: 0x006DE004 File Offset: 0x006DC204
		public bool EndMontageDirectly
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D5F6 RID: 54774
		// (get) Token: 0x06032DD2 RID: 208338 RVA: 0x006DE044 File Offset: 0x006DC244
		public bool StartFromLoop
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D5F7 RID: 54775
		// (get) Token: 0x06032DD3 RID: 208339 RVA: 0x006DE084 File Offset: 0x006DC284
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

		// Token: 0x1700D5F8 RID: 54776
		// (get) Token: 0x06032DD4 RID: 208340 RVA: 0x006DE0E4 File Offset: 0x006DC2E4
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

		// Token: 0x1700D5F9 RID: 54777
		// (get) Token: 0x06032DD5 RID: 208341 RVA: 0x006DE124 File Offset: 0x006DC324
		public bool KeepFaceExpression
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06032DD6 RID: 208342 RVA: 0x006DE164 File Offset: 0x006DC364
		public IActorFxEmotePlay? FxEmote(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new IActorFxEmotePlay?(default(IActorFxEmotePlay).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D5FA RID: 54778
		// (get) Token: 0x06032DD7 RID: 208343 RVA: 0x006DE1C8 File Offset: 0x006DC3C8
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

		// Token: 0x1700D5FB RID: 54779
		// (get) Token: 0x06032DD8 RID: 208344 RVA: 0x006DE1F4 File Offset: 0x006DC3F4
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

		// Token: 0x06032DD9 RID: 208345 RVA: 0x006DE234 File Offset: 0x006DC434
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

		// Token: 0x06032DDA RID: 208346 RVA: 0x006DE2BC File Offset: 0x006DC4BC
		public static void StartIMontageData(FlatBufferBuilder builder)
		{
			builder.StartTable(14);
		}

		// Token: 0x06032DDB RID: 208347 RVA: 0x006DE2C6 File Offset: 0x006DC4C6
		public static void AddActorIndex(FlatBufferBuilder builder, int actorIndex)
		{
			builder.AddInt(0, actorIndex, 0);
		}

		// Token: 0x06032DDC RID: 208348 RVA: 0x006DE2D1 File Offset: 0x006DC4D1
		public static void AddMontageId(FlatBufferBuilder builder, int montageId)
		{
			builder.AddInt(1, montageId, 0);
		}

		// Token: 0x06032DDD RID: 208349 RVA: 0x006DE2DC File Offset: 0x006DC4DC
		public static void AddIsAbpMontage(FlatBufferBuilder builder, bool isAbpMontage)
		{
			builder.AddBool(2, isAbpMontage, false);
		}

		// Token: 0x06032DDE RID: 208350 RVA: 0x006DE2E7 File Offset: 0x006DC4E7
		public static void AddIsLoop(FlatBufferBuilder builder, bool isLoop)
		{
			builder.AddBool(3, isLoop, false);
		}

		// Token: 0x06032DDF RID: 208351 RVA: 0x006DE2F2 File Offset: 0x006DC4F2
		public static void AddKeepPose(FlatBufferBuilder builder, bool keepPose)
		{
			builder.AddBool(4, keepPose, false);
		}

		// Token: 0x06032DE0 RID: 208352 RVA: 0x006DE2FD File Offset: 0x006DC4FD
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(5, delayTime, 0.0);
		}

		// Token: 0x06032DE1 RID: 208353 RVA: 0x006DE310 File Offset: 0x006DC510
		public static void AddEndLoopingMontage(FlatBufferBuilder builder, bool endLoopingMontage)
		{
			builder.AddBool(6, endLoopingMontage, false);
		}

		// Token: 0x06032DE2 RID: 208354 RVA: 0x006DE31B File Offset: 0x006DC51B
		public static void AddEndMontageDirectly(FlatBufferBuilder builder, bool endMontageDirectly)
		{
			builder.AddBool(7, endMontageDirectly, false);
		}

		// Token: 0x06032DE3 RID: 208355 RVA: 0x006DE326 File Offset: 0x006DC526
		public static void AddStartFromLoop(FlatBufferBuilder builder, bool startFromLoop)
		{
			builder.AddBool(8, startFromLoop, false);
		}

		// Token: 0x06032DE4 RID: 208356 RVA: 0x006DE331 File Offset: 0x006DC531
		public static void AddOverlayMontage(FlatBufferBuilder builder, Offset<IMontageParam> overlayMontageOffset)
		{
			builder.AddOffset(9, overlayMontageOffset.Value, 0);
		}

		// Token: 0x06032DE5 RID: 208357 RVA: 0x006DE342 File Offset: 0x006DC542
		public static void AddFaceExpressionId(FlatBufferBuilder builder, int faceExpressionId)
		{
			builder.AddInt(10, faceExpressionId, 0);
		}

		// Token: 0x06032DE6 RID: 208358 RVA: 0x006DE34E File Offset: 0x006DC54E
		public static void AddKeepFaceExpression(FlatBufferBuilder builder, bool keepFaceExpression)
		{
			builder.AddBool(11, keepFaceExpression, false);
		}

		// Token: 0x06032DE7 RID: 208359 RVA: 0x006DE35A File Offset: 0x006DC55A
		public static void AddFxEmote(FlatBufferBuilder builder, VectorOffset fxEmoteOffset)
		{
			builder.AddOffset(12, fxEmoteOffset.Value, 0);
		}

		// Token: 0x06032DE8 RID: 208360 RVA: 0x006DE36C File Offset: 0x006DC56C
		public static VectorOffset CreateFxEmoteVector(FlatBufferBuilder builder, Offset<IActorFxEmotePlay>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06032DE9 RID: 208361 RVA: 0x006DE3AC File Offset: 0x006DC5AC
		public static VectorOffset CreateFxEmoteVectorBlock(FlatBufferBuilder builder, Offset<IActorFxEmotePlay>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorFxEmotePlay>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032DEA RID: 208362 RVA: 0x006DE3C6 File Offset: 0x006DC5C6
		public static VectorOffset CreateFxEmoteVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorFxEmotePlay>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorFxEmotePlay>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032DEB RID: 208363 RVA: 0x006DE3E4 File Offset: 0x006DC5E4
		public static VectorOffset CreateFxEmoteVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorFxEmotePlay>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032DEC RID: 208364 RVA: 0x006DE3FD File Offset: 0x006DC5FD
		public static void StartFxEmoteVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032DED RID: 208365 RVA: 0x006DE408 File Offset: 0x006DC608
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(13, nullMask, 0);
		}

		// Token: 0x06032DEE RID: 208366 RVA: 0x006DE414 File Offset: 0x006DC614
		public static Offset<IMontageData> EndIMontageData(FlatBufferBuilder builder)
		{
			return new Offset<IMontageData>(builder.EndTable());
		}

		// Token: 0x06032DEF RID: 208367 RVA: 0x006DE424 File Offset: 0x006DC624
		public IMontageDataT UnPack()
		{
			IMontageDataT montageDataT = new IMontageDataT();
			this.UnPackTo(montageDataT);
			return montageDataT;
		}

		// Token: 0x06032DF0 RID: 208368 RVA: 0x006DE440 File Offset: 0x006DC640
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

		// Token: 0x06032DF1 RID: 208369 RVA: 0x006DE560 File Offset: 0x006DC760
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

		// Token: 0x04012262 RID: 74338
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007595 RID: 30101
	public struct IVisualNovelPerformanceActivityAction : IFlatbufferObject
	{
		// Token: 0x1700E43C RID: 58428
		// (get) Token: 0x06036C12 RID: 224274 RVA: 0x0076EBDC File Offset: 0x0076CDDC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036C13 RID: 224275 RVA: 0x0076EBE9 File Offset: 0x0076CDE9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036C14 RID: 224276 RVA: 0x0076EBF0 File Offset: 0x0076CDF0
		public static IVisualNovelPerformanceActivityAction GetRootAsIVisualNovelPerformanceActivityAction(ByteBuffer _bb)
		{
			return IVisualNovelPerformanceActivityAction.GetRootAsIVisualNovelPerformanceActivityAction(_bb, default(IVisualNovelPerformanceActivityAction));
		}

		// Token: 0x06036C15 RID: 224277 RVA: 0x0076EC0C File Offset: 0x0076CE0C
		public static IVisualNovelPerformanceActivityAction GetRootAsIVisualNovelPerformanceActivityAction(ByteBuffer _bb, IVisualNovelPerformanceActivityAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036C16 RID: 224278 RVA: 0x0076EC29 File Offset: 0x0076CE29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036C17 RID: 224279 RVA: 0x0076EC38 File Offset: 0x0076CE38
		public IVisualNovelPerformanceActivityAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E43D RID: 58429
		// (get) Token: 0x06036C18 RID: 224280 RVA: 0x0076EC48 File Offset: 0x0076CE48
		public EVisualNovelPerformanceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelPerformanceType.Enter;
				}
				return (EVisualNovelPerformanceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E43E RID: 58430
		// (get) Token: 0x06036C19 RID: 224281 RVA: 0x0076EC84 File Offset: 0x0076CE84
		public float StartTime
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E43F RID: 58431
		// (get) Token: 0x06036C1A RID: 224282 RVA: 0x0076ECC4 File Offset: 0x0076CEC4
		public IVisualNovelActivityActionSolarSchool? ActivityActionConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVisualNovelActivityActionSolarSchool?(default(IVisualNovelActivityActionSolarSchool).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E440 RID: 58432
		// (get) Token: 0x06036C1B RID: 224283 RVA: 0x0076ED24 File Offset: 0x0076CF24
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

		// Token: 0x06036C1C RID: 224284 RVA: 0x0076ED61 File Offset: 0x0076CF61
		public static Offset<IVisualNovelPerformanceActivityAction> CreateIVisualNovelPerformanceActivityAction(FlatBufferBuilder builder, EVisualNovelPerformanceType Type = EVisualNovelPerformanceType.Enter, float StartTime = 0f, Offset<IVisualNovelActivityActionSolarSchool> ActivityActionConfigOffset = default(Offset<IVisualNovelActivityActionSolarSchool>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IVisualNovelPerformanceActivityAction.AddActivityActionConfig(builder, ActivityActionConfigOffset);
			IVisualNovelPerformanceActivityAction.AddStartTime(builder, StartTime);
			IVisualNovelPerformanceActivityAction.AddNullMask(builder, NullMask);
			IVisualNovelPerformanceActivityAction.AddType(builder, Type);
			return IVisualNovelPerformanceActivityAction.EndIVisualNovelPerformanceActivityAction(builder);
		}

		// Token: 0x06036C1D RID: 224285 RVA: 0x0076ED8D File Offset: 0x0076CF8D
		public static void StartIVisualNovelPerformanceActivityAction(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06036C1E RID: 224286 RVA: 0x0076ED96 File Offset: 0x0076CF96
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036C1F RID: 224287 RVA: 0x0076EDA1 File Offset: 0x0076CFA1
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x06036C20 RID: 224288 RVA: 0x0076EDB4 File Offset: 0x0076CFB4
		public static void AddActivityActionConfig(FlatBufferBuilder builder, Offset<IVisualNovelActivityActionSolarSchool> activityActionConfigOffset)
		{
			builder.AddOffset(2, activityActionConfigOffset.Value, 0);
		}

		// Token: 0x06036C21 RID: 224289 RVA: 0x0076EDC4 File Offset: 0x0076CFC4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06036C22 RID: 224290 RVA: 0x0076EDCF File Offset: 0x0076CFCF
		public static Offset<IVisualNovelPerformanceActivityAction> EndIVisualNovelPerformanceActivityAction(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformanceActivityAction>(builder.EndTable());
		}

		// Token: 0x06036C23 RID: 224291 RVA: 0x0076EDDC File Offset: 0x0076CFDC
		public IVisualNovelPerformanceActivityActionT UnPack()
		{
			IVisualNovelPerformanceActivityActionT visualNovelPerformanceActivityActionT = new IVisualNovelPerformanceActivityActionT();
			this.UnPackTo(visualNovelPerformanceActivityActionT);
			return visualNovelPerformanceActivityActionT;
		}

		// Token: 0x06036C24 RID: 224292 RVA: 0x0076EDF8 File Offset: 0x0076CFF8
		public void UnPackTo(IVisualNovelPerformanceActivityActionT _o)
		{
			_o.Type = this.Type;
			_o.StartTime = this.StartTime;
			_o.ActivityActionConfig = ((this.ActivityActionConfig != null) ? this.ActivityActionConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06036C25 RID: 224293 RVA: 0x0076EE58 File Offset: 0x0076D058
		public static Offset<IVisualNovelPerformanceActivityAction> Pack(FlatBufferBuilder builder, IVisualNovelPerformanceActivityActionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPerformanceActivityAction>);
			}
			Offset<IVisualNovelActivityActionSolarSchool> activityActionConfigOffset = (_o.ActivityActionConfig == null) ? default(Offset<IVisualNovelActivityActionSolarSchool>) : IVisualNovelActivityActionSolarSchool.Pack(builder, _o.ActivityActionConfig);
			return IVisualNovelPerformanceActivityAction.CreateIVisualNovelPerformanceActivityAction(builder, _o.Type, _o.StartTime, activityActionConfigOffset, _o.NullMask);
		}

		// Token: 0x0401249F RID: 74911
		private Table __p;
	}
}

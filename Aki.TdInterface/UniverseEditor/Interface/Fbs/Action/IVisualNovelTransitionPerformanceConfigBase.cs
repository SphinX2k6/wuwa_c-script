using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075E9 RID: 30185
	public struct IVisualNovelTransitionPerformanceConfigBase : IFlatbufferObject
	{
		// Token: 0x1700E54F RID: 58703
		// (get) Token: 0x06036FBC RID: 225212 RVA: 0x00775FF8 File Offset: 0x007741F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036FBD RID: 225213 RVA: 0x00776005 File Offset: 0x00774205
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036FBE RID: 225214 RVA: 0x0077600C File Offset: 0x0077420C
		public static IVisualNovelTransitionPerformanceConfigBase GetRootAsIVisualNovelTransitionPerformanceConfigBase(ByteBuffer _bb)
		{
			return IVisualNovelTransitionPerformanceConfigBase.GetRootAsIVisualNovelTransitionPerformanceConfigBase(_bb, default(IVisualNovelTransitionPerformanceConfigBase));
		}

		// Token: 0x06036FBF RID: 225215 RVA: 0x00776028 File Offset: 0x00774228
		public static IVisualNovelTransitionPerformanceConfigBase GetRootAsIVisualNovelTransitionPerformanceConfigBase(ByteBuffer _bb, IVisualNovelTransitionPerformanceConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036FC0 RID: 225216 RVA: 0x00776045 File Offset: 0x00774245
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036FC1 RID: 225217 RVA: 0x00776054 File Offset: 0x00774254
		public IVisualNovelTransitionPerformanceConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E550 RID: 58704
		// (get) Token: 0x06036FC2 RID: 225218 RVA: 0x00776064 File Offset: 0x00774264
		public EVisualNovelSubType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelSubType.SolarSchool;
				}
				return (EVisualNovelSubType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036FC3 RID: 225219 RVA: 0x007760A0 File Offset: 0x007742A0
		public static Offset<IVisualNovelTransitionPerformanceConfigBase> CreateIVisualNovelTransitionPerformanceConfigBase(FlatBufferBuilder builder, EVisualNovelSubType Type = EVisualNovelSubType.SolarSchool)
		{
			builder.StartTable(1);
			IVisualNovelTransitionPerformanceConfigBase.AddType(builder, Type);
			return IVisualNovelTransitionPerformanceConfigBase.EndIVisualNovelTransitionPerformanceConfigBase(builder);
		}

		// Token: 0x06036FC4 RID: 225220 RVA: 0x007760B6 File Offset: 0x007742B6
		public static void StartIVisualNovelTransitionPerformanceConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036FC5 RID: 225221 RVA: 0x007760BF File Offset: 0x007742BF
		public static void AddType(FlatBufferBuilder builder, EVisualNovelSubType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036FC6 RID: 225222 RVA: 0x007760CA File Offset: 0x007742CA
		public static Offset<IVisualNovelTransitionPerformanceConfigBase> EndIVisualNovelTransitionPerformanceConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelTransitionPerformanceConfigBase>(builder.EndTable());
		}

		// Token: 0x06036FC7 RID: 225223 RVA: 0x007760D8 File Offset: 0x007742D8
		public IVisualNovelTransitionPerformanceConfigBaseT UnPack()
		{
			IVisualNovelTransitionPerformanceConfigBaseT visualNovelTransitionPerformanceConfigBaseT = new IVisualNovelTransitionPerformanceConfigBaseT();
			this.UnPackTo(visualNovelTransitionPerformanceConfigBaseT);
			return visualNovelTransitionPerformanceConfigBaseT;
		}

		// Token: 0x06036FC8 RID: 225224 RVA: 0x007760F3 File Offset: 0x007742F3
		public void UnPackTo(IVisualNovelTransitionPerformanceConfigBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036FC9 RID: 225225 RVA: 0x00776104 File Offset: 0x00774304
		public static Offset<IVisualNovelTransitionPerformanceConfigBase> Pack(FlatBufferBuilder builder, IVisualNovelTransitionPerformanceConfigBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelTransitionPerformanceConfigBase>);
			}
			return IVisualNovelTransitionPerformanceConfigBase.CreateIVisualNovelTransitionPerformanceConfigBase(builder, _o.Type);
		}

		// Token: 0x04012555 RID: 75093
		private Table __p;
	}
}

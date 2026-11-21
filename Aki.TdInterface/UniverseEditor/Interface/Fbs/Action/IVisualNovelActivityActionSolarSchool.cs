using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D4C RID: 32076
	public struct IVisualNovelActivityActionSolarSchool : IFlatbufferObject
	{
		// Token: 0x1700F00B RID: 61451
		// (get) Token: 0x06039E7A RID: 237178 RVA: 0x007CF6BA File Offset: 0x007CD8BA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039E7B RID: 237179 RVA: 0x007CF6C7 File Offset: 0x007CD8C7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039E7C RID: 237180 RVA: 0x007CF6D0 File Offset: 0x007CD8D0
		public static IVisualNovelActivityActionSolarSchool GetRootAsIVisualNovelActivityActionSolarSchool(ByteBuffer _bb)
		{
			return IVisualNovelActivityActionSolarSchool.GetRootAsIVisualNovelActivityActionSolarSchool(_bb, default(IVisualNovelActivityActionSolarSchool));
		}

		// Token: 0x06039E7D RID: 237181 RVA: 0x007CF6EC File Offset: 0x007CD8EC
		public static IVisualNovelActivityActionSolarSchool GetRootAsIVisualNovelActivityActionSolarSchool(ByteBuffer _bb, IVisualNovelActivityActionSolarSchool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039E7E RID: 237182 RVA: 0x007CF709 File Offset: 0x007CD909
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039E7F RID: 237183 RVA: 0x007CF718 File Offset: 0x007CD918
		public IVisualNovelActivityActionSolarSchool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F00C RID: 61452
		// (get) Token: 0x06039E80 RID: 237184 RVA: 0x007CF728 File Offset: 0x007CD928
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

		// Token: 0x1700F00D RID: 61453
		// (get) Token: 0x06039E81 RID: 237185 RVA: 0x007CF764 File Offset: 0x007CD964
		public int SolarSchoolActionId
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

		// Token: 0x06039E82 RID: 237186 RVA: 0x007CF7A0 File Offset: 0x007CD9A0
		public static Offset<IVisualNovelActivityActionSolarSchool> CreateIVisualNovelActivityActionSolarSchool(FlatBufferBuilder builder, EVisualNovelSubType Type = EVisualNovelSubType.SolarSchool, int SolarSchoolActionId = 0)
		{
			builder.StartTable(2);
			IVisualNovelActivityActionSolarSchool.AddSolarSchoolActionId(builder, SolarSchoolActionId);
			IVisualNovelActivityActionSolarSchool.AddType(builder, Type);
			return IVisualNovelActivityActionSolarSchool.EndIVisualNovelActivityActionSolarSchool(builder);
		}

		// Token: 0x06039E83 RID: 237187 RVA: 0x007CF7BD File Offset: 0x007CD9BD
		public static void StartIVisualNovelActivityActionSolarSchool(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06039E84 RID: 237188 RVA: 0x007CF7C6 File Offset: 0x007CD9C6
		public static void AddType(FlatBufferBuilder builder, EVisualNovelSubType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039E85 RID: 237189 RVA: 0x007CF7D1 File Offset: 0x007CD9D1
		public static void AddSolarSchoolActionId(FlatBufferBuilder builder, int solarSchoolActionId)
		{
			builder.AddInt(1, solarSchoolActionId, 0);
		}

		// Token: 0x06039E86 RID: 237190 RVA: 0x007CF7DC File Offset: 0x007CD9DC
		public static Offset<IVisualNovelActivityActionSolarSchool> EndIVisualNovelActivityActionSolarSchool(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelActivityActionSolarSchool>(builder.EndTable());
		}

		// Token: 0x06039E87 RID: 237191 RVA: 0x007CF7EC File Offset: 0x007CD9EC
		public IVisualNovelActivityActionSolarSchoolT UnPack()
		{
			IVisualNovelActivityActionSolarSchoolT visualNovelActivityActionSolarSchoolT = new IVisualNovelActivityActionSolarSchoolT();
			this.UnPackTo(visualNovelActivityActionSolarSchoolT);
			return visualNovelActivityActionSolarSchoolT;
		}

		// Token: 0x06039E88 RID: 237192 RVA: 0x007CF807 File Offset: 0x007CDA07
		public void UnPackTo(IVisualNovelActivityActionSolarSchoolT _o)
		{
			_o.Type = this.Type;
			_o.SolarSchoolActionId = this.SolarSchoolActionId;
		}

		// Token: 0x06039E89 RID: 237193 RVA: 0x007CF824 File Offset: 0x007CDA24
		public static Offset<IVisualNovelActivityActionSolarSchool> Pack(FlatBufferBuilder builder, IVisualNovelActivityActionSolarSchoolT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelActivityActionSolarSchool>);
			}
			return IVisualNovelActivityActionSolarSchool.CreateIVisualNovelActivityActionSolarSchool(builder, _o.Type, _o.SolarSchoolActionId);
		}

		// Token: 0x04013481 RID: 78977
		private Table __p;
	}
}

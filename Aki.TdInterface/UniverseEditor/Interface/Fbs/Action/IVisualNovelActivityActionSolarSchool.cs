using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007556 RID: 30038
	public struct IVisualNovelActivityActionSolarSchool : IFlatbufferObject
	{
		// Token: 0x1700E3E1 RID: 58337
		// (get) Token: 0x06036A64 RID: 223844 RVA: 0x0076C412 File Offset: 0x0076A612
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036A65 RID: 223845 RVA: 0x0076C41F File Offset: 0x0076A61F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036A66 RID: 223846 RVA: 0x0076C428 File Offset: 0x0076A628
		public static IVisualNovelActivityActionSolarSchool GetRootAsIVisualNovelActivityActionSolarSchool(ByteBuffer _bb)
		{
			return IVisualNovelActivityActionSolarSchool.GetRootAsIVisualNovelActivityActionSolarSchool(_bb, default(IVisualNovelActivityActionSolarSchool));
		}

		// Token: 0x06036A67 RID: 223847 RVA: 0x0076C444 File Offset: 0x0076A644
		public static IVisualNovelActivityActionSolarSchool GetRootAsIVisualNovelActivityActionSolarSchool(ByteBuffer _bb, IVisualNovelActivityActionSolarSchool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036A68 RID: 223848 RVA: 0x0076C461 File Offset: 0x0076A661
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036A69 RID: 223849 RVA: 0x0076C470 File Offset: 0x0076A670
		public IVisualNovelActivityActionSolarSchool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3E2 RID: 58338
		// (get) Token: 0x06036A6A RID: 223850 RVA: 0x0076C480 File Offset: 0x0076A680
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

		// Token: 0x1700E3E3 RID: 58339
		// (get) Token: 0x06036A6B RID: 223851 RVA: 0x0076C4BC File Offset: 0x0076A6BC
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

		// Token: 0x06036A6C RID: 223852 RVA: 0x0076C4F8 File Offset: 0x0076A6F8
		public static Offset<IVisualNovelActivityActionSolarSchool> CreateIVisualNovelActivityActionSolarSchool(FlatBufferBuilder builder, EVisualNovelSubType Type = EVisualNovelSubType.SolarSchool, int SolarSchoolActionId = 0)
		{
			builder.StartTable(2);
			IVisualNovelActivityActionSolarSchool.AddSolarSchoolActionId(builder, SolarSchoolActionId);
			IVisualNovelActivityActionSolarSchool.AddType(builder, Type);
			return IVisualNovelActivityActionSolarSchool.EndIVisualNovelActivityActionSolarSchool(builder);
		}

		// Token: 0x06036A6D RID: 223853 RVA: 0x0076C515 File Offset: 0x0076A715
		public static void StartIVisualNovelActivityActionSolarSchool(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036A6E RID: 223854 RVA: 0x0076C51E File Offset: 0x0076A71E
		public static void AddType(FlatBufferBuilder builder, EVisualNovelSubType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036A6F RID: 223855 RVA: 0x0076C529 File Offset: 0x0076A729
		public static void AddSolarSchoolActionId(FlatBufferBuilder builder, int solarSchoolActionId)
		{
			builder.AddInt(1, solarSchoolActionId, 0);
		}

		// Token: 0x06036A70 RID: 223856 RVA: 0x0076C534 File Offset: 0x0076A734
		public static Offset<IVisualNovelActivityActionSolarSchool> EndIVisualNovelActivityActionSolarSchool(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelActivityActionSolarSchool>(builder.EndTable());
		}

		// Token: 0x06036A71 RID: 223857 RVA: 0x0076C544 File Offset: 0x0076A744
		public IVisualNovelActivityActionSolarSchoolT UnPack()
		{
			IVisualNovelActivityActionSolarSchoolT visualNovelActivityActionSolarSchoolT = new IVisualNovelActivityActionSolarSchoolT();
			this.UnPackTo(visualNovelActivityActionSolarSchoolT);
			return visualNovelActivityActionSolarSchoolT;
		}

		// Token: 0x06036A72 RID: 223858 RVA: 0x0076C55F File Offset: 0x0076A75F
		public void UnPackTo(IVisualNovelActivityActionSolarSchoolT _o)
		{
			_o.Type = this.Type;
			_o.SolarSchoolActionId = this.SolarSchoolActionId;
		}

		// Token: 0x06036A73 RID: 223859 RVA: 0x0076C57C File Offset: 0x0076A77C
		public static Offset<IVisualNovelActivityActionSolarSchool> Pack(FlatBufferBuilder builder, IVisualNovelActivityActionSolarSchoolT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelActivityActionSolarSchool>);
			}
			return IVisualNovelActivityActionSolarSchool.CreateIVisualNovelActivityActionSolarSchool(builder, _o.Type, _o.SolarSchoolActionId);
		}

		// Token: 0x04012450 RID: 74832
		private Table __p;
	}
}

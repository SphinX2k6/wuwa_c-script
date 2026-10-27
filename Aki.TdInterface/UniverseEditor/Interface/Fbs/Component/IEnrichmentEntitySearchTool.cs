using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005147 RID: 20807
	public struct IEnrichmentEntitySearchTool : IFlatbufferObject
	{
		// Token: 0x170097C0 RID: 38848
		// (get) Token: 0x06021948 RID: 137544 RVA: 0x004A9514 File Offset: 0x004A7714
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021949 RID: 137545 RVA: 0x004A9521 File Offset: 0x004A7721
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602194A RID: 137546 RVA: 0x004A9528 File Offset: 0x004A7728
		public static IEnrichmentEntitySearchTool GetRootAsIEnrichmentEntitySearchTool(ByteBuffer _bb)
		{
			return IEnrichmentEntitySearchTool.GetRootAsIEnrichmentEntitySearchTool(_bb, default(IEnrichmentEntitySearchTool));
		}

		// Token: 0x0602194B RID: 137547 RVA: 0x004A9544 File Offset: 0x004A7744
		public static IEnrichmentEntitySearchTool GetRootAsIEnrichmentEntitySearchTool(ByteBuffer _bb, IEnrichmentEntitySearchTool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602194C RID: 137548 RVA: 0x004A9561 File Offset: 0x004A7761
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602194D RID: 137549 RVA: 0x004A9570 File Offset: 0x004A7770
		public IEnrichmentEntitySearchTool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170097C1 RID: 38849
		// (get) Token: 0x0602194E RID: 137550 RVA: 0x004A9580 File Offset: 0x004A7780
		public int TargetType
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

		// Token: 0x170097C2 RID: 38850
		// (get) Token: 0x0602194F RID: 137551 RVA: 0x004A95BC File Offset: 0x004A77BC
		public float Radius
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

		// Token: 0x170097C3 RID: 38851
		// (get) Token: 0x06021950 RID: 137552 RVA: 0x004A95FC File Offset: 0x004A77FC
		public float Height
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021951 RID: 137553 RVA: 0x004A963C File Offset: 0x004A783C
		public static Offset<IEnrichmentEntitySearchTool> CreateIEnrichmentEntitySearchTool(FlatBufferBuilder builder, int TargetType = 0, float Radius = 0f, float Height = 0f)
		{
			builder.StartTable(3);
			IEnrichmentEntitySearchTool.AddHeight(builder, Height);
			IEnrichmentEntitySearchTool.AddRadius(builder, Radius);
			IEnrichmentEntitySearchTool.AddTargetType(builder, TargetType);
			return IEnrichmentEntitySearchTool.EndIEnrichmentEntitySearchTool(builder);
		}

		// Token: 0x06021952 RID: 137554 RVA: 0x004A9660 File Offset: 0x004A7860
		public static void StartIEnrichmentEntitySearchTool(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06021953 RID: 137555 RVA: 0x004A9669 File Offset: 0x004A7869
		public static void AddTargetType(FlatBufferBuilder builder, int targetType)
		{
			builder.AddInt(0, targetType, 0);
		}

		// Token: 0x06021954 RID: 137556 RVA: 0x004A9674 File Offset: 0x004A7874
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(1, radius, 0.0);
		}

		// Token: 0x06021955 RID: 137557 RVA: 0x004A9687 File Offset: 0x004A7887
		public static void AddHeight(FlatBufferBuilder builder, float height)
		{
			builder.AddFloat(2, height, 0.0);
		}

		// Token: 0x06021956 RID: 137558 RVA: 0x004A969A File Offset: 0x004A789A
		public static Offset<IEnrichmentEntitySearchTool> EndIEnrichmentEntitySearchTool(FlatBufferBuilder builder)
		{
			return new Offset<IEnrichmentEntitySearchTool>(builder.EndTable());
		}

		// Token: 0x06021957 RID: 137559 RVA: 0x004A96A8 File Offset: 0x004A78A8
		public IEnrichmentEntitySearchToolT UnPack()
		{
			IEnrichmentEntitySearchToolT enrichmentEntitySearchToolT = new IEnrichmentEntitySearchToolT();
			this.UnPackTo(enrichmentEntitySearchToolT);
			return enrichmentEntitySearchToolT;
		}

		// Token: 0x06021958 RID: 137560 RVA: 0x004A96C3 File Offset: 0x004A78C3
		public void UnPackTo(IEnrichmentEntitySearchToolT _o)
		{
			_o.TargetType = this.TargetType;
			_o.Radius = this.Radius;
			_o.Height = this.Height;
		}

		// Token: 0x06021959 RID: 137561 RVA: 0x004A96EC File Offset: 0x004A78EC
		public static Offset<IEnrichmentEntitySearchTool> Pack(FlatBufferBuilder builder, IEnrichmentEntitySearchToolT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnrichmentEntitySearchTool>);
			}
			return IEnrichmentEntitySearchTool.CreateIEnrichmentEntitySearchTool(builder, _o.TargetType, _o.Radius, _o.Height);
		}

		// Token: 0x0400E1E2 RID: 57826
		private Table __p;
	}
}

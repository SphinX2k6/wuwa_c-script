using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056AC RID: 22188
	public struct IEnrichmentEntitySearchTool : IFlatbufferObject
	{
		// Token: 0x17009FAD RID: 40877
		// (get) Token: 0x0602389C RID: 145564 RVA: 0x004E34A0 File Offset: 0x004E16A0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602389D RID: 145565 RVA: 0x004E34AD File Offset: 0x004E16AD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602389E RID: 145566 RVA: 0x004E34B4 File Offset: 0x004E16B4
		public static IEnrichmentEntitySearchTool GetRootAsIEnrichmentEntitySearchTool(ByteBuffer _bb)
		{
			return IEnrichmentEntitySearchTool.GetRootAsIEnrichmentEntitySearchTool(_bb, default(IEnrichmentEntitySearchTool));
		}

		// Token: 0x0602389F RID: 145567 RVA: 0x004E34D0 File Offset: 0x004E16D0
		public static IEnrichmentEntitySearchTool GetRootAsIEnrichmentEntitySearchTool(ByteBuffer _bb, IEnrichmentEntitySearchTool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060238A0 RID: 145568 RVA: 0x004E34ED File Offset: 0x004E16ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060238A1 RID: 145569 RVA: 0x004E34FC File Offset: 0x004E16FC
		public IEnrichmentEntitySearchTool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009FAE RID: 40878
		// (get) Token: 0x060238A2 RID: 145570 RVA: 0x004E350C File Offset: 0x004E170C
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

		// Token: 0x17009FAF RID: 40879
		// (get) Token: 0x060238A3 RID: 145571 RVA: 0x004E3548 File Offset: 0x004E1748
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

		// Token: 0x17009FB0 RID: 40880
		// (get) Token: 0x060238A4 RID: 145572 RVA: 0x004E3588 File Offset: 0x004E1788
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

		// Token: 0x060238A5 RID: 145573 RVA: 0x004E35C8 File Offset: 0x004E17C8
		public static Offset<IEnrichmentEntitySearchTool> CreateIEnrichmentEntitySearchTool(FlatBufferBuilder builder, int TargetType = 0, float Radius = 0f, float Height = 0f)
		{
			builder.StartTable(3);
			IEnrichmentEntitySearchTool.AddHeight(builder, Height);
			IEnrichmentEntitySearchTool.AddRadius(builder, Radius);
			IEnrichmentEntitySearchTool.AddTargetType(builder, TargetType);
			return IEnrichmentEntitySearchTool.EndIEnrichmentEntitySearchTool(builder);
		}

		// Token: 0x060238A6 RID: 145574 RVA: 0x004E35EC File Offset: 0x004E17EC
		public static void StartIEnrichmentEntitySearchTool(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060238A7 RID: 145575 RVA: 0x004E35F5 File Offset: 0x004E17F5
		public static void AddTargetType(FlatBufferBuilder builder, int targetType)
		{
			builder.AddInt(0, targetType, 0);
		}

		// Token: 0x060238A8 RID: 145576 RVA: 0x004E3600 File Offset: 0x004E1800
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(1, radius, 0.0);
		}

		// Token: 0x060238A9 RID: 145577 RVA: 0x004E3613 File Offset: 0x004E1813
		public static void AddHeight(FlatBufferBuilder builder, float height)
		{
			builder.AddFloat(2, height, 0.0);
		}

		// Token: 0x060238AA RID: 145578 RVA: 0x004E3626 File Offset: 0x004E1826
		public static Offset<IEnrichmentEntitySearchTool> EndIEnrichmentEntitySearchTool(FlatBufferBuilder builder)
		{
			return new Offset<IEnrichmentEntitySearchTool>(builder.EndTable());
		}

		// Token: 0x060238AB RID: 145579 RVA: 0x004E3634 File Offset: 0x004E1834
		public IEnrichmentEntitySearchToolT UnPack()
		{
			IEnrichmentEntitySearchToolT enrichmentEntitySearchToolT = new IEnrichmentEntitySearchToolT();
			this.UnPackTo(enrichmentEntitySearchToolT);
			return enrichmentEntitySearchToolT;
		}

		// Token: 0x060238AC RID: 145580 RVA: 0x004E364F File Offset: 0x004E184F
		public void UnPackTo(IEnrichmentEntitySearchToolT _o)
		{
			_o.TargetType = this.TargetType;
			_o.Radius = this.Radius;
			_o.Height = this.Height;
		}

		// Token: 0x060238AD RID: 145581 RVA: 0x004E3678 File Offset: 0x004E1878
		public static Offset<IEnrichmentEntitySearchTool> Pack(FlatBufferBuilder builder, IEnrichmentEntitySearchToolT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnrichmentEntitySearchTool>);
			}
			return IEnrichmentEntitySearchTool.CreateIEnrichmentEntitySearchTool(builder, _o.TargetType, _o.Radius, _o.Height);
		}

		// Token: 0x0400EDDF RID: 60895
		private Table __p;
	}
}

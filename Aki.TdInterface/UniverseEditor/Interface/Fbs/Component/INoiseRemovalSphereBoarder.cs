using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200560B RID: 22027
	public struct INoiseRemovalSphereBoarder : IFlatbufferObject
	{
		// Token: 0x1700A300 RID: 41728
		// (get) Token: 0x060248E1 RID: 149729 RVA: 0x0050B6B4 File Offset: 0x005098B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060248E2 RID: 149730 RVA: 0x0050B6C1 File Offset: 0x005098C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060248E3 RID: 149731 RVA: 0x0050B6C8 File Offset: 0x005098C8
		public static INoiseRemovalSphereBoarder GetRootAsINoiseRemovalSphereBoarder(ByteBuffer _bb)
		{
			return INoiseRemovalSphereBoarder.GetRootAsINoiseRemovalSphereBoarder(_bb, default(INoiseRemovalSphereBoarder));
		}

		// Token: 0x060248E4 RID: 149732 RVA: 0x0050B6E4 File Offset: 0x005098E4
		public static INoiseRemovalSphereBoarder GetRootAsINoiseRemovalSphereBoarder(ByteBuffer _bb, INoiseRemovalSphereBoarder obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060248E5 RID: 149733 RVA: 0x0050B701 File Offset: 0x00509901
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060248E6 RID: 149734 RVA: 0x0050B710 File Offset: 0x00509910
		public INoiseRemovalSphereBoarder __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A301 RID: 41729
		// (get) Token: 0x060248E7 RID: 149735 RVA: 0x0050B720 File Offset: 0x00509920
		public ENoiseRemovalBoarderShape Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENoiseRemovalBoarderShape.Box;
				}
				return (ENoiseRemovalBoarderShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A302 RID: 41730
		// (get) Token: 0x060248E8 RID: 149736 RVA: 0x0050B75C File Offset: 0x0050995C
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

		// Token: 0x060248E9 RID: 149737 RVA: 0x0050B79C File Offset: 0x0050999C
		public static Offset<INoiseRemovalSphereBoarder> CreateINoiseRemovalSphereBoarder(FlatBufferBuilder builder, ENoiseRemovalBoarderShape Type = ENoiseRemovalBoarderShape.Box, float Radius = 0f)
		{
			builder.StartTable(2);
			INoiseRemovalSphereBoarder.AddRadius(builder, Radius);
			INoiseRemovalSphereBoarder.AddType(builder, Type);
			return INoiseRemovalSphereBoarder.EndINoiseRemovalSphereBoarder(builder);
		}

		// Token: 0x060248EA RID: 149738 RVA: 0x0050B7B9 File Offset: 0x005099B9
		public static void StartINoiseRemovalSphereBoarder(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060248EB RID: 149739 RVA: 0x0050B7C2 File Offset: 0x005099C2
		public static void AddType(FlatBufferBuilder builder, ENoiseRemovalBoarderShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060248EC RID: 149740 RVA: 0x0050B7CD File Offset: 0x005099CD
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(1, radius, 0.0);
		}

		// Token: 0x060248ED RID: 149741 RVA: 0x0050B7E0 File Offset: 0x005099E0
		public static Offset<INoiseRemovalSphereBoarder> EndINoiseRemovalSphereBoarder(FlatBufferBuilder builder)
		{
			return new Offset<INoiseRemovalSphereBoarder>(builder.EndTable());
		}

		// Token: 0x060248EE RID: 149742 RVA: 0x0050B7F0 File Offset: 0x005099F0
		public INoiseRemovalSphereBoarderT UnPack()
		{
			INoiseRemovalSphereBoarderT noiseRemovalSphereBoarderT = new INoiseRemovalSphereBoarderT();
			this.UnPackTo(noiseRemovalSphereBoarderT);
			return noiseRemovalSphereBoarderT;
		}

		// Token: 0x060248EF RID: 149743 RVA: 0x0050B80B File Offset: 0x00509A0B
		public void UnPackTo(INoiseRemovalSphereBoarderT _o)
		{
			_o.Type = this.Type;
			_o.Radius = this.Radius;
		}

		// Token: 0x060248F0 RID: 149744 RVA: 0x0050B828 File Offset: 0x00509A28
		public static Offset<INoiseRemovalSphereBoarder> Pack(FlatBufferBuilder builder, INoiseRemovalSphereBoarderT _o)
		{
			if (_o == null)
			{
				return default(Offset<INoiseRemovalSphereBoarder>);
			}
			return INoiseRemovalSphereBoarder.CreateINoiseRemovalSphereBoarder(builder, _o.Type, _o.Radius);
		}

		// Token: 0x0400E98B RID: 59787
		private Table __p;
	}
}

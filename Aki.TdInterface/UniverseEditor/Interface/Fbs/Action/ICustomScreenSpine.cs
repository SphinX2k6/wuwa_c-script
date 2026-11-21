using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B78 RID: 27512
	public struct ICustomScreenSpine : IFlatbufferObject
	{
		// Token: 0x1700C9E7 RID: 51687
		// (get) Token: 0x0602F577 RID: 193911 RVA: 0x00675E1A File Offset: 0x0067401A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F578 RID: 193912 RVA: 0x00675E27 File Offset: 0x00674027
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F579 RID: 193913 RVA: 0x00675E30 File Offset: 0x00674030
		public static ICustomScreenSpine GetRootAsICustomScreenSpine(ByteBuffer _bb)
		{
			return ICustomScreenSpine.GetRootAsICustomScreenSpine(_bb, default(ICustomScreenSpine));
		}

		// Token: 0x0602F57A RID: 193914 RVA: 0x00675E4C File Offset: 0x0067404C
		public static ICustomScreenSpine GetRootAsICustomScreenSpine(ByteBuffer _bb, ICustomScreenSpine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F57B RID: 193915 RVA: 0x00675E69 File Offset: 0x00674069
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F57C RID: 193916 RVA: 0x00675E78 File Offset: 0x00674078
		public ICustomScreenSpine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9E8 RID: 51688
		// (get) Token: 0x0602F57D RID: 193917 RVA: 0x00675E88 File Offset: 0x00674088
		public ECustomScreenType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECustomScreenType.Spine;
				}
				return (ECustomScreenType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C9E9 RID: 51689
		// (get) Token: 0x0602F57E RID: 193918 RVA: 0x00675EC4 File Offset: 0x006740C4
		public int SpineId
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

		// Token: 0x0602F57F RID: 193919 RVA: 0x00675F00 File Offset: 0x00674100
		public static Offset<ICustomScreenSpine> CreateICustomScreenSpine(FlatBufferBuilder builder, ECustomScreenType Type = ECustomScreenType.Spine, int SpineId = 0)
		{
			builder.StartTable(2);
			ICustomScreenSpine.AddSpineId(builder, SpineId);
			ICustomScreenSpine.AddType(builder, Type);
			return ICustomScreenSpine.EndICustomScreenSpine(builder);
		}

		// Token: 0x0602F580 RID: 193920 RVA: 0x00675F1D File Offset: 0x0067411D
		public static void StartICustomScreenSpine(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F581 RID: 193921 RVA: 0x00675F26 File Offset: 0x00674126
		public static void AddType(FlatBufferBuilder builder, ECustomScreenType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F582 RID: 193922 RVA: 0x00675F31 File Offset: 0x00674131
		public static void AddSpineId(FlatBufferBuilder builder, int spineId)
		{
			builder.AddInt(1, spineId, 0);
		}

		// Token: 0x0602F583 RID: 193923 RVA: 0x00675F3C File Offset: 0x0067413C
		public static Offset<ICustomScreenSpine> EndICustomScreenSpine(FlatBufferBuilder builder)
		{
			return new Offset<ICustomScreenSpine>(builder.EndTable());
		}

		// Token: 0x0602F584 RID: 193924 RVA: 0x00675F4C File Offset: 0x0067414C
		public ICustomScreenSpineT UnPack()
		{
			ICustomScreenSpineT customScreenSpineT = new ICustomScreenSpineT();
			this.UnPackTo(customScreenSpineT);
			return customScreenSpineT;
		}

		// Token: 0x0602F585 RID: 193925 RVA: 0x00675F67 File Offset: 0x00674167
		public void UnPackTo(ICustomScreenSpineT _o)
		{
			_o.Type = this.Type;
			_o.SpineId = this.SpineId;
		}

		// Token: 0x0602F586 RID: 193926 RVA: 0x00675F84 File Offset: 0x00674184
		public static Offset<ICustomScreenSpine> Pack(FlatBufferBuilder builder, ICustomScreenSpineT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomScreenSpine>);
			}
			return ICustomScreenSpine.CreateICustomScreenSpine(builder, _o.Type, _o.SpineId);
		}

		// Token: 0x04011966 RID: 72038
		private Table __p;
	}
}

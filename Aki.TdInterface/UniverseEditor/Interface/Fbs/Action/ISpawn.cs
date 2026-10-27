using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007169 RID: 29033
	public struct ISpawn : IFlatbufferObject
	{
		// Token: 0x1700D7B6 RID: 55222
		// (get) Token: 0x06033798 RID: 210840 RVA: 0x006EF408 File Offset: 0x006ED608
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033799 RID: 210841 RVA: 0x006EF415 File Offset: 0x006ED615
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603379A RID: 210842 RVA: 0x006EF41C File Offset: 0x006ED61C
		public static ISpawn GetRootAsISpawn(ByteBuffer _bb)
		{
			return ISpawn.GetRootAsISpawn(_bb, default(ISpawn));
		}

		// Token: 0x0603379B RID: 210843 RVA: 0x006EF438 File Offset: 0x006ED638
		public static ISpawn GetRootAsISpawn(ByteBuffer _bb, ISpawn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603379C RID: 210844 RVA: 0x006EF455 File Offset: 0x006ED655
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603379D RID: 210845 RVA: 0x006EF464 File Offset: 0x006ED664
		public ISpawn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D7B7 RID: 55223
		// (get) Token: 0x0603379E RID: 210846 RVA: 0x006EF474 File Offset: 0x006ED674
		public int TemplateGuid
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

		// Token: 0x1700D7B8 RID: 55224
		// (get) Token: 0x0603379F RID: 210847 RVA: 0x006EF4B0 File Offset: 0x006ED6B0
		public ITransform? Transform
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ITransform?(default(ITransform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060337A0 RID: 210848 RVA: 0x006EF50D File Offset: 0x006ED70D
		public static Offset<ISpawn> CreateISpawn(FlatBufferBuilder builder, int TemplateGuid = 0, Offset<ITransform> TransformOffset = default(Offset<ITransform>))
		{
			builder.StartTable(2);
			ISpawn.AddTransform(builder, TransformOffset);
			ISpawn.AddTemplateGuid(builder, TemplateGuid);
			return ISpawn.EndISpawn(builder);
		}

		// Token: 0x060337A1 RID: 210849 RVA: 0x006EF52A File Offset: 0x006ED72A
		public static void StartISpawn(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060337A2 RID: 210850 RVA: 0x006EF533 File Offset: 0x006ED733
		public static void AddTemplateGuid(FlatBufferBuilder builder, int templateGuid)
		{
			builder.AddInt(0, templateGuid, 0);
		}

		// Token: 0x060337A3 RID: 210851 RVA: 0x006EF53E File Offset: 0x006ED73E
		public static void AddTransform(FlatBufferBuilder builder, Offset<ITransform> transformOffset)
		{
			builder.AddOffset(1, transformOffset.Value, 0);
		}

		// Token: 0x060337A4 RID: 210852 RVA: 0x006EF54E File Offset: 0x006ED74E
		public static Offset<ISpawn> EndISpawn(FlatBufferBuilder builder)
		{
			return new Offset<ISpawn>(builder.EndTable());
		}

		// Token: 0x060337A5 RID: 210853 RVA: 0x006EF55C File Offset: 0x006ED75C
		public ISpawnT UnPack()
		{
			ISpawnT spawnT = new ISpawnT();
			this.UnPackTo(spawnT);
			return spawnT;
		}

		// Token: 0x060337A6 RID: 210854 RVA: 0x006EF578 File Offset: 0x006ED778
		public void UnPackTo(ISpawnT _o)
		{
			_o.TemplateGuid = this.TemplateGuid;
			_o.Transform = ((this.Transform != null) ? this.Transform.Value.UnPack() : null);
		}

		// Token: 0x060337A7 RID: 210855 RVA: 0x006EF5C0 File Offset: 0x006ED7C0
		public static Offset<ISpawn> Pack(FlatBufferBuilder builder, ISpawnT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpawn>);
			}
			Offset<ITransform> transformOffset = (_o.Transform == null) ? default(Offset<ITransform>) : ITransform.Pack(builder, _o.Transform);
			return ISpawn.CreateISpawn(builder, _o.TemplateGuid, transformOffset);
		}

		// Token: 0x04011C0C RID: 72716
		private Table __p;
	}
}

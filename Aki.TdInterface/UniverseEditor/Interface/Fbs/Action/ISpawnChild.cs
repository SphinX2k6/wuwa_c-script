using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200716C RID: 29036
	public struct ISpawnChild : IFlatbufferObject
	{
		// Token: 0x1700D7BB RID: 55227
		// (get) Token: 0x060337AE RID: 210862 RVA: 0x006EF694 File Offset: 0x006ED894
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060337AF RID: 210863 RVA: 0x006EF6A1 File Offset: 0x006ED8A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060337B0 RID: 210864 RVA: 0x006EF6A8 File Offset: 0x006ED8A8
		public static ISpawnChild GetRootAsISpawnChild(ByteBuffer _bb)
		{
			return ISpawnChild.GetRootAsISpawnChild(_bb, default(ISpawnChild));
		}

		// Token: 0x060337B1 RID: 210865 RVA: 0x006EF6C4 File Offset: 0x006ED8C4
		public static ISpawnChild GetRootAsISpawnChild(ByteBuffer _bb, ISpawnChild obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060337B2 RID: 210866 RVA: 0x006EF6E1 File Offset: 0x006ED8E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060337B3 RID: 210867 RVA: 0x006EF6F0 File Offset: 0x006ED8F0
		public ISpawnChild __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D7BC RID: 55228
		// (get) Token: 0x060337B4 RID: 210868 RVA: 0x006EF700 File Offset: 0x006ED900
		public string TemplateGuid
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060337B5 RID: 210869 RVA: 0x006EF737 File Offset: 0x006ED937
		public Span<byte> GetTemplateGuidBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060337B6 RID: 210870 RVA: 0x006EF746 File Offset: 0x006ED946
		public byte[] GetTemplateGuidArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700D7BD RID: 55229
		// (get) Token: 0x060337B7 RID: 210871 RVA: 0x006EF754 File Offset: 0x006ED954
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

		// Token: 0x060337B8 RID: 210872 RVA: 0x006EF7B1 File Offset: 0x006ED9B1
		public static Offset<ISpawnChild> CreateISpawnChild(FlatBufferBuilder builder, StringOffset TemplateGuidOffset = default(StringOffset), Offset<ITransform> TransformOffset = default(Offset<ITransform>))
		{
			builder.StartTable(2);
			ISpawnChild.AddTransform(builder, TransformOffset);
			ISpawnChild.AddTemplateGuid(builder, TemplateGuidOffset);
			return ISpawnChild.EndISpawnChild(builder);
		}

		// Token: 0x060337B9 RID: 210873 RVA: 0x006EF7CE File Offset: 0x006ED9CE
		public static void StartISpawnChild(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060337BA RID: 210874 RVA: 0x006EF7D7 File Offset: 0x006ED9D7
		public static void AddTemplateGuid(FlatBufferBuilder builder, StringOffset templateGuidOffset)
		{
			builder.AddOffset(0, templateGuidOffset.Value, 0);
		}

		// Token: 0x060337BB RID: 210875 RVA: 0x006EF7E7 File Offset: 0x006ED9E7
		public static void AddTransform(FlatBufferBuilder builder, Offset<ITransform> transformOffset)
		{
			builder.AddOffset(1, transformOffset.Value, 0);
		}

		// Token: 0x060337BC RID: 210876 RVA: 0x006EF7F7 File Offset: 0x006ED9F7
		public static Offset<ISpawnChild> EndISpawnChild(FlatBufferBuilder builder)
		{
			return new Offset<ISpawnChild>(builder.EndTable());
		}

		// Token: 0x060337BD RID: 210877 RVA: 0x006EF804 File Offset: 0x006EDA04
		public ISpawnChildT UnPack()
		{
			ISpawnChildT spawnChildT = new ISpawnChildT();
			this.UnPackTo(spawnChildT);
			return spawnChildT;
		}

		// Token: 0x060337BE RID: 210878 RVA: 0x006EF820 File Offset: 0x006EDA20
		public void UnPackTo(ISpawnChildT _o)
		{
			_o.TemplateGuid = this.TemplateGuid;
			_o.Transform = ((this.Transform != null) ? this.Transform.Value.UnPack() : null);
		}

		// Token: 0x060337BF RID: 210879 RVA: 0x006EF868 File Offset: 0x006EDA68
		public static Offset<ISpawnChild> Pack(FlatBufferBuilder builder, ISpawnChildT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpawnChild>);
			}
			StringOffset templateGuidOffset = (_o.TemplateGuid == null) ? default(StringOffset) : builder.CreateString(_o.TemplateGuid);
			Offset<ITransform> transformOffset = (_o.Transform == null) ? default(Offset<ITransform>) : ITransform.Pack(builder, _o.Transform);
			return ISpawnChild.CreateISpawnChild(builder, templateGuidOffset, transformOffset);
		}

		// Token: 0x04011C0F RID: 72719
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EE2 RID: 28386
	public struct IRoguePrefabConfig : IFlatbufferObject
	{
		// Token: 0x1700D32C RID: 54060
		// (get) Token: 0x06032287 RID: 205447 RVA: 0x006C771A File Offset: 0x006C591A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032288 RID: 205448 RVA: 0x006C7727 File Offset: 0x006C5927
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032289 RID: 205449 RVA: 0x006C7730 File Offset: 0x006C5930
		public static IRoguePrefabConfig GetRootAsIRoguePrefabConfig(ByteBuffer _bb)
		{
			return IRoguePrefabConfig.GetRootAsIRoguePrefabConfig(_bb, default(IRoguePrefabConfig));
		}

		// Token: 0x0603228A RID: 205450 RVA: 0x006C774C File Offset: 0x006C594C
		public static IRoguePrefabConfig GetRootAsIRoguePrefabConfig(ByteBuffer _bb, IRoguePrefabConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603228B RID: 205451 RVA: 0x006C7769 File Offset: 0x006C5969
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603228C RID: 205452 RVA: 0x006C7778 File Offset: 0x006C5978
		public IRoguePrefabConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D32D RID: 54061
		// (get) Token: 0x0603228D RID: 205453 RVA: 0x006C7788 File Offset: 0x006C5988
		public ECreatePrefabType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECreatePrefabType.PrefabId;
				}
				return (ECreatePrefabType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D32E RID: 54062
		// (get) Token: 0x0603228E RID: 205454 RVA: 0x006C77C4 File Offset: 0x006C59C4
		public int Index
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

		// Token: 0x0603228F RID: 205455 RVA: 0x006C7800 File Offset: 0x006C5A00
		public static Offset<IRoguePrefabConfig> CreateIRoguePrefabConfig(FlatBufferBuilder builder, ECreatePrefabType Type = ECreatePrefabType.PrefabId, int Index = 0)
		{
			builder.StartTable(2);
			IRoguePrefabConfig.AddIndex(builder, Index);
			IRoguePrefabConfig.AddType(builder, Type);
			return IRoguePrefabConfig.EndIRoguePrefabConfig(builder);
		}

		// Token: 0x06032290 RID: 205456 RVA: 0x006C781D File Offset: 0x006C5A1D
		public static void StartIRoguePrefabConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032291 RID: 205457 RVA: 0x006C7826 File Offset: 0x006C5A26
		public static void AddType(FlatBufferBuilder builder, ECreatePrefabType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032292 RID: 205458 RVA: 0x006C7831 File Offset: 0x006C5A31
		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
			builder.AddInt(1, index, 0);
		}

		// Token: 0x06032293 RID: 205459 RVA: 0x006C783C File Offset: 0x006C5A3C
		public static Offset<IRoguePrefabConfig> EndIRoguePrefabConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRoguePrefabConfig>(builder.EndTable());
		}

		// Token: 0x06032294 RID: 205460 RVA: 0x006C784C File Offset: 0x006C5A4C
		public IRoguePrefabConfigT UnPack()
		{
			IRoguePrefabConfigT roguePrefabConfigT = new IRoguePrefabConfigT();
			this.UnPackTo(roguePrefabConfigT);
			return roguePrefabConfigT;
		}

		// Token: 0x06032295 RID: 205461 RVA: 0x006C7867 File Offset: 0x006C5A67
		public void UnPackTo(IRoguePrefabConfigT _o)
		{
			_o.Type = this.Type;
			_o.Index = this.Index;
		}

		// Token: 0x06032296 RID: 205462 RVA: 0x006C7884 File Offset: 0x006C5A84
		public static Offset<IRoguePrefabConfig> Pack(FlatBufferBuilder builder, IRoguePrefabConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoguePrefabConfig>);
			}
			return IRoguePrefabConfig.CreateIRoguePrefabConfig(builder, _o.Type, _o.Index);
		}

		// Token: 0x040118D4 RID: 71892
		private Table __p;
	}
}

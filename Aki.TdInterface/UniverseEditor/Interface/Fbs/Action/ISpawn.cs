using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007935 RID: 31029
	public struct ISpawn : IFlatbufferObject
	{
		// Token: 0x1700E39B RID: 58267
		// (get) Token: 0x06036A42 RID: 223810 RVA: 0x0074FC14 File Offset: 0x0074DE14
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036A43 RID: 223811 RVA: 0x0074FC21 File Offset: 0x0074DE21
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036A44 RID: 223812 RVA: 0x0074FC28 File Offset: 0x0074DE28
		public static ISpawn GetRootAsISpawn(ByteBuffer _bb)
		{
			return ISpawn.GetRootAsISpawn(_bb, default(ISpawn));
		}

		// Token: 0x06036A45 RID: 223813 RVA: 0x0074FC44 File Offset: 0x0074DE44
		public static ISpawn GetRootAsISpawn(ByteBuffer _bb, ISpawn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036A46 RID: 223814 RVA: 0x0074FC61 File Offset: 0x0074DE61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036A47 RID: 223815 RVA: 0x0074FC70 File Offset: 0x0074DE70
		public ISpawn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E39C RID: 58268
		// (get) Token: 0x06036A48 RID: 223816 RVA: 0x0074FC80 File Offset: 0x0074DE80
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

		// Token: 0x1700E39D RID: 58269
		// (get) Token: 0x06036A49 RID: 223817 RVA: 0x0074FCBC File Offset: 0x0074DEBC
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

		// Token: 0x06036A4A RID: 223818 RVA: 0x0074FD19 File Offset: 0x0074DF19
		public static Offset<ISpawn> CreateISpawn(FlatBufferBuilder builder, int TemplateGuid = 0, Offset<ITransform> TransformOffset = default(Offset<ITransform>))
		{
			builder.StartTable(2);
			ISpawn.AddTransform(builder, TransformOffset);
			ISpawn.AddTemplateGuid(builder, TemplateGuid);
			return ISpawn.EndISpawn(builder);
		}

		// Token: 0x06036A4B RID: 223819 RVA: 0x0074FD36 File Offset: 0x0074DF36
		public static void StartISpawn(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036A4C RID: 223820 RVA: 0x0074FD3F File Offset: 0x0074DF3F
		public static void AddTemplateGuid(FlatBufferBuilder builder, int templateGuid)
		{
			builder.AddInt(0, templateGuid, 0);
		}

		// Token: 0x06036A4D RID: 223821 RVA: 0x0074FD4A File Offset: 0x0074DF4A
		public static void AddTransform(FlatBufferBuilder builder, Offset<ITransform> transformOffset)
		{
			builder.AddOffset(1, transformOffset.Value, 0);
		}

		// Token: 0x06036A4E RID: 223822 RVA: 0x0074FD5A File Offset: 0x0074DF5A
		public static Offset<ISpawn> EndISpawn(FlatBufferBuilder builder)
		{
			return new Offset<ISpawn>(builder.EndTable());
		}

		// Token: 0x06036A4F RID: 223823 RVA: 0x0074FD68 File Offset: 0x0074DF68
		public ISpawnT UnPack()
		{
			ISpawnT spawnT = new ISpawnT();
			this.UnPackTo(spawnT);
			return spawnT;
		}

		// Token: 0x06036A50 RID: 223824 RVA: 0x0074FD84 File Offset: 0x0074DF84
		public void UnPackTo(ISpawnT _o)
		{
			_o.TemplateGuid = this.TemplateGuid;
			_o.Transform = ((this.Transform != null) ? this.Transform.Value.UnPack() : null);
		}

		// Token: 0x06036A51 RID: 223825 RVA: 0x0074FDCC File Offset: 0x0074DFCC
		public static Offset<ISpawn> Pack(FlatBufferBuilder builder, ISpawnT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpawn>);
			}
			Offset<ITransform> transformOffset = (_o.Transform == null) ? default(Offset<ITransform>) : ITransform.Pack(builder, _o.Transform);
			return ISpawn.CreateISpawn(builder, _o.TemplateGuid, transformOffset);
		}

		// Token: 0x04012BFB RID: 76795
		private Table __p;
	}
}

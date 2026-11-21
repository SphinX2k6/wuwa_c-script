using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B62 RID: 19298
	public struct IHideRangeSource : IFlatbufferObject
	{
		// Token: 0x1700882B RID: 34859
		// (get) Token: 0x0601D504 RID: 120068 RVA: 0x0041DB60 File Offset: 0x0041BD60
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D505 RID: 120069 RVA: 0x0041DB6D File Offset: 0x0041BD6D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D506 RID: 120070 RVA: 0x0041DB74 File Offset: 0x0041BD74
		public static IHideRangeSource GetRootAsIHideRangeSource(ByteBuffer _bb)
		{
			return IHideRangeSource.GetRootAsIHideRangeSource(_bb, default(IHideRangeSource));
		}

		// Token: 0x0601D507 RID: 120071 RVA: 0x0041DB90 File Offset: 0x0041BD90
		public static IHideRangeSource GetRootAsIHideRangeSource(ByteBuffer _bb, IHideRangeSource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D508 RID: 120072 RVA: 0x0041DBAD File Offset: 0x0041BDAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D509 RID: 120073 RVA: 0x0041DBBC File Offset: 0x0041BDBC
		public IHideRangeSource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700882C RID: 34860
		// (get) Token: 0x0601D50A RID: 120074 RVA: 0x0041DBCC File Offset: 0x0041BDCC
		public TBehaviorTreeType TreeType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TBehaviorTreeType.BehaviorTreeFragment;
				}
				return (TBehaviorTreeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700882D RID: 34861
		// (get) Token: 0x0601D50B RID: 120075 RVA: 0x0041DC08 File Offset: 0x0041BE08
		public int TreeId
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

		// Token: 0x1700882E RID: 34862
		// (get) Token: 0x0601D50C RID: 120076 RVA: 0x0041DC44 File Offset: 0x0041BE44
		public int LevelId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700882F RID: 34863
		// (get) Token: 0x0601D50D RID: 120077 RVA: 0x0041DC80 File Offset: 0x0041BE80
		public int NodeId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008830 RID: 34864
		// (get) Token: 0x0601D50E RID: 120078 RVA: 0x0041DCC0 File Offset: 0x0041BEC0
		public int ActionId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008831 RID: 34865
		// (get) Token: 0x0601D50F RID: 120079 RVA: 0x0041DD00 File Offset: 0x0041BF00
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D510 RID: 120080 RVA: 0x0041DD3D File Offset: 0x0041BF3D
		public static Offset<IHideRangeSource> CreateIHideRangeSource(FlatBufferBuilder builder, TBehaviorTreeType TreeType = TBehaviorTreeType.BehaviorTreeFragment, int TreeId = 0, int LevelId = 0, int NodeId = 0, int ActionId = 0, byte NullMask = 0)
		{
			builder.StartTable(6);
			IHideRangeSource.AddActionId(builder, ActionId);
			IHideRangeSource.AddNodeId(builder, NodeId);
			IHideRangeSource.AddLevelId(builder, LevelId);
			IHideRangeSource.AddTreeId(builder, TreeId);
			IHideRangeSource.AddNullMask(builder, NullMask);
			IHideRangeSource.AddTreeType(builder, TreeType);
			return IHideRangeSource.EndIHideRangeSource(builder);
		}

		// Token: 0x0601D511 RID: 120081 RVA: 0x0041DD79 File Offset: 0x0041BF79
		public static void StartIHideRangeSource(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601D512 RID: 120082 RVA: 0x0041DD82 File Offset: 0x0041BF82
		public static void AddTreeType(FlatBufferBuilder builder, TBehaviorTreeType treeType)
		{
			builder.AddByte(0, (byte)treeType, 0);
		}

		// Token: 0x0601D513 RID: 120083 RVA: 0x0041DD8D File Offset: 0x0041BF8D
		public static void AddTreeId(FlatBufferBuilder builder, int treeId)
		{
			builder.AddInt(1, treeId, 0);
		}

		// Token: 0x0601D514 RID: 120084 RVA: 0x0041DD98 File Offset: 0x0041BF98
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(2, levelId, 0);
		}

		// Token: 0x0601D515 RID: 120085 RVA: 0x0041DDA3 File Offset: 0x0041BFA3
		public static void AddNodeId(FlatBufferBuilder builder, int nodeId)
		{
			builder.AddInt(3, nodeId, 0);
		}

		// Token: 0x0601D516 RID: 120086 RVA: 0x0041DDAE File Offset: 0x0041BFAE
		public static void AddActionId(FlatBufferBuilder builder, int actionId)
		{
			builder.AddInt(4, actionId, 0);
		}

		// Token: 0x0601D517 RID: 120087 RVA: 0x0041DDB9 File Offset: 0x0041BFB9
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601D518 RID: 120088 RVA: 0x0041DDC4 File Offset: 0x0041BFC4
		public static Offset<IHideRangeSource> EndIHideRangeSource(FlatBufferBuilder builder)
		{
			return new Offset<IHideRangeSource>(builder.EndTable());
		}

		// Token: 0x0601D519 RID: 120089 RVA: 0x0041DDD4 File Offset: 0x0041BFD4
		public IHideRangeSourceT UnPack()
		{
			IHideRangeSourceT hideRangeSourceT = new IHideRangeSourceT();
			this.UnPackTo(hideRangeSourceT);
			return hideRangeSourceT;
		}

		// Token: 0x0601D51A RID: 120090 RVA: 0x0041DDF0 File Offset: 0x0041BFF0
		public void UnPackTo(IHideRangeSourceT _o)
		{
			_o.TreeType = this.TreeType;
			_o.TreeId = this.TreeId;
			_o.LevelId = this.LevelId;
			_o.NodeId = this.NodeId;
			_o.ActionId = this.ActionId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601D51B RID: 120091 RVA: 0x0041DE48 File Offset: 0x0041C048
		public static Offset<IHideRangeSource> Pack(FlatBufferBuilder builder, IHideRangeSourceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHideRangeSource>);
			}
			return IHideRangeSource.CreateIHideRangeSource(builder, _o.TreeType, _o.TreeId, _o.LevelId, _o.NodeId, _o.ActionId, _o.NullMask);
		}

		// Token: 0x0400D3D6 RID: 54230
		private Table __p;
	}
}

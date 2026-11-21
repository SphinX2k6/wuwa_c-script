using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076C6 RID: 30406
	public struct ISceneItemNewSplineMoveTarget : IFlatbufferObject
	{
		// Token: 0x1700DEFD RID: 57085
		// (get) Token: 0x06035557 RID: 218455 RVA: 0x00727750 File Offset: 0x00725950
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035558 RID: 218456 RVA: 0x0072775D File Offset: 0x0072595D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035559 RID: 218457 RVA: 0x00727764 File Offset: 0x00725964
		public static ISceneItemNewSplineMoveTarget GetRootAsISceneItemNewSplineMoveTarget(ByteBuffer _bb)
		{
			return ISceneItemNewSplineMoveTarget.GetRootAsISceneItemNewSplineMoveTarget(_bb, default(ISceneItemNewSplineMoveTarget));
		}

		// Token: 0x0603555A RID: 218458 RVA: 0x00727780 File Offset: 0x00725980
		public static ISceneItemNewSplineMoveTarget GetRootAsISceneItemNewSplineMoveTarget(ByteBuffer _bb, ISceneItemNewSplineMoveTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603555B RID: 218459 RVA: 0x0072779D File Offset: 0x0072599D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603555C RID: 218460 RVA: 0x007277AC File Offset: 0x007259AC
		public ISceneItemNewSplineMoveTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DEFE RID: 57086
		// (get) Token: 0x0603555D RID: 218461 RVA: 0x007277BC File Offset: 0x007259BC
		public ENewSplineMoveTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENewSplineMoveTargetType.Player;
				}
				return (ENewSplineMoveTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DEFF RID: 57087
		// (get) Token: 0x0603555E RID: 218462 RVA: 0x007277F8 File Offset: 0x007259F8
		public int EntityId
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

		// Token: 0x1700DF00 RID: 57088
		// (get) Token: 0x0603555F RID: 218463 RVA: 0x00727834 File Offset: 0x00725A34
		public bool IsLookDir
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DF01 RID: 57089
		// (get) Token: 0x06035560 RID: 218464 RVA: 0x00727874 File Offset: 0x00725A74
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035561 RID: 218465 RVA: 0x007278B1 File Offset: 0x00725AB1
		public static Offset<ISceneItemNewSplineMoveTarget> CreateISceneItemNewSplineMoveTarget(FlatBufferBuilder builder, ENewSplineMoveTargetType Type = ENewSplineMoveTargetType.Player, int EntityId = 0, bool IsLookDir = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			ISceneItemNewSplineMoveTarget.AddEntityId(builder, EntityId);
			ISceneItemNewSplineMoveTarget.AddNullMask(builder, NullMask);
			ISceneItemNewSplineMoveTarget.AddIsLookDir(builder, IsLookDir);
			ISceneItemNewSplineMoveTarget.AddType(builder, Type);
			return ISceneItemNewSplineMoveTarget.EndISceneItemNewSplineMoveTarget(builder);
		}

		// Token: 0x06035562 RID: 218466 RVA: 0x007278DD File Offset: 0x00725ADD
		public static void StartISceneItemNewSplineMoveTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06035563 RID: 218467 RVA: 0x007278E6 File Offset: 0x00725AE6
		public static void AddType(FlatBufferBuilder builder, ENewSplineMoveTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035564 RID: 218468 RVA: 0x007278F1 File Offset: 0x00725AF1
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06035565 RID: 218469 RVA: 0x007278FC File Offset: 0x00725AFC
		public static void AddIsLookDir(FlatBufferBuilder builder, bool isLookDir)
		{
			builder.AddBool(2, isLookDir, false);
		}

		// Token: 0x06035566 RID: 218470 RVA: 0x00727907 File Offset: 0x00725B07
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06035567 RID: 218471 RVA: 0x00727912 File Offset: 0x00725B12
		public static Offset<ISceneItemNewSplineMoveTarget> EndISceneItemNewSplineMoveTarget(FlatBufferBuilder builder)
		{
			return new Offset<ISceneItemNewSplineMoveTarget>(builder.EndTable());
		}

		// Token: 0x06035568 RID: 218472 RVA: 0x00727920 File Offset: 0x00725B20
		public ISceneItemNewSplineMoveTargetT UnPack()
		{
			ISceneItemNewSplineMoveTargetT sceneItemNewSplineMoveTargetT = new ISceneItemNewSplineMoveTargetT();
			this.UnPackTo(sceneItemNewSplineMoveTargetT);
			return sceneItemNewSplineMoveTargetT;
		}

		// Token: 0x06035569 RID: 218473 RVA: 0x0072793B File Offset: 0x00725B3B
		public void UnPackTo(ISceneItemNewSplineMoveTargetT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.IsLookDir = this.IsLookDir;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603556A RID: 218474 RVA: 0x00727970 File Offset: 0x00725B70
		public static Offset<ISceneItemNewSplineMoveTarget> Pack(FlatBufferBuilder builder, ISceneItemNewSplineMoveTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneItemNewSplineMoveTarget>);
			}
			return ISceneItemNewSplineMoveTarget.CreateISceneItemNewSplineMoveTarget(builder, _o.Type, _o.EntityId, _o.IsLookDir, _o.NullMask);
		}

		// Token: 0x040128BC RID: 75964
		private Table __p;
	}
}

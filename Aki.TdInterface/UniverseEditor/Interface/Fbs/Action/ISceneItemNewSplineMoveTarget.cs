using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F3F RID: 28479
	public struct ISceneItemNewSplineMoveTarget : IFlatbufferObject
	{
		// Token: 0x1700D3A1 RID: 54177
		// (get) Token: 0x060324FF RID: 206079 RVA: 0x006CB7E8 File Offset: 0x006C99E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032500 RID: 206080 RVA: 0x006CB7F5 File Offset: 0x006C99F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032501 RID: 206081 RVA: 0x006CB7FC File Offset: 0x006C99FC
		public static ISceneItemNewSplineMoveTarget GetRootAsISceneItemNewSplineMoveTarget(ByteBuffer _bb)
		{
			return ISceneItemNewSplineMoveTarget.GetRootAsISceneItemNewSplineMoveTarget(_bb, default(ISceneItemNewSplineMoveTarget));
		}

		// Token: 0x06032502 RID: 206082 RVA: 0x006CB818 File Offset: 0x006C9A18
		public static ISceneItemNewSplineMoveTarget GetRootAsISceneItemNewSplineMoveTarget(ByteBuffer _bb, ISceneItemNewSplineMoveTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032503 RID: 206083 RVA: 0x006CB835 File Offset: 0x006C9A35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032504 RID: 206084 RVA: 0x006CB844 File Offset: 0x006C9A44
		public ISceneItemNewSplineMoveTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3A2 RID: 54178
		// (get) Token: 0x06032505 RID: 206085 RVA: 0x006CB854 File Offset: 0x006C9A54
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

		// Token: 0x1700D3A3 RID: 54179
		// (get) Token: 0x06032506 RID: 206086 RVA: 0x006CB890 File Offset: 0x006C9A90
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

		// Token: 0x1700D3A4 RID: 54180
		// (get) Token: 0x06032507 RID: 206087 RVA: 0x006CB8CC File Offset: 0x006C9ACC
		public bool IsLookDir
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D3A5 RID: 54181
		// (get) Token: 0x06032508 RID: 206088 RVA: 0x006CB90C File Offset: 0x006C9B0C
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

		// Token: 0x06032509 RID: 206089 RVA: 0x006CB949 File Offset: 0x006C9B49
		public static Offset<ISceneItemNewSplineMoveTarget> CreateISceneItemNewSplineMoveTarget(FlatBufferBuilder builder, ENewSplineMoveTargetType Type = ENewSplineMoveTargetType.Player, int EntityId = 0, bool IsLookDir = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			ISceneItemNewSplineMoveTarget.AddEntityId(builder, EntityId);
			ISceneItemNewSplineMoveTarget.AddNullMask(builder, NullMask);
			ISceneItemNewSplineMoveTarget.AddIsLookDir(builder, IsLookDir);
			ISceneItemNewSplineMoveTarget.AddType(builder, Type);
			return ISceneItemNewSplineMoveTarget.EndISceneItemNewSplineMoveTarget(builder);
		}

		// Token: 0x0603250A RID: 206090 RVA: 0x006CB975 File Offset: 0x006C9B75
		public static void StartISceneItemNewSplineMoveTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0603250B RID: 206091 RVA: 0x006CB97E File Offset: 0x006C9B7E
		public static void AddType(FlatBufferBuilder builder, ENewSplineMoveTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603250C RID: 206092 RVA: 0x006CB989 File Offset: 0x006C9B89
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0603250D RID: 206093 RVA: 0x006CB994 File Offset: 0x006C9B94
		public static void AddIsLookDir(FlatBufferBuilder builder, bool isLookDir)
		{
			builder.AddBool(2, isLookDir, false);
		}

		// Token: 0x0603250E RID: 206094 RVA: 0x006CB99F File Offset: 0x006C9B9F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0603250F RID: 206095 RVA: 0x006CB9AA File Offset: 0x006C9BAA
		public static Offset<ISceneItemNewSplineMoveTarget> EndISceneItemNewSplineMoveTarget(FlatBufferBuilder builder)
		{
			return new Offset<ISceneItemNewSplineMoveTarget>(builder.EndTable());
		}

		// Token: 0x06032510 RID: 206096 RVA: 0x006CB9B8 File Offset: 0x006C9BB8
		public ISceneItemNewSplineMoveTargetT UnPack()
		{
			ISceneItemNewSplineMoveTargetT sceneItemNewSplineMoveTargetT = new ISceneItemNewSplineMoveTargetT();
			this.UnPackTo(sceneItemNewSplineMoveTargetT);
			return sceneItemNewSplineMoveTargetT;
		}

		// Token: 0x06032511 RID: 206097 RVA: 0x006CB9D3 File Offset: 0x006C9BD3
		public void UnPackTo(ISceneItemNewSplineMoveTargetT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.IsLookDir = this.IsLookDir;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06032512 RID: 206098 RVA: 0x006CBA08 File Offset: 0x006C9C08
		public static Offset<ISceneItemNewSplineMoveTarget> Pack(FlatBufferBuilder builder, ISceneItemNewSplineMoveTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneItemNewSplineMoveTarget>);
			}
			return ISceneItemNewSplineMoveTarget.CreateISceneItemNewSplineMoveTarget(builder, _o.Type, _o.EntityId, _o.IsLookDir, _o.NullMask);
		}

		// Token: 0x04011934 RID: 71988
		private Table __p;
	}
}

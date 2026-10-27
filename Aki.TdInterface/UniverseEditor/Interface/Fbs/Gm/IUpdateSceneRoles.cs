using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046D5 RID: 18133
	public struct IUpdateSceneRoles : IFlatbufferObject
	{
		// Token: 0x170080D4 RID: 32980
		// (get) Token: 0x0601B921 RID: 112929 RVA: 0x003E925E File Offset: 0x003E745E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B922 RID: 112930 RVA: 0x003E926B File Offset: 0x003E746B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B923 RID: 112931 RVA: 0x003E9274 File Offset: 0x003E7474
		public static IUpdateSceneRoles GetRootAsIUpdateSceneRoles(ByteBuffer _bb)
		{
			return IUpdateSceneRoles.GetRootAsIUpdateSceneRoles(_bb, default(IUpdateSceneRoles));
		}

		// Token: 0x0601B924 RID: 112932 RVA: 0x003E9290 File Offset: 0x003E7490
		public static IUpdateSceneRoles GetRootAsIUpdateSceneRoles(ByteBuffer _bb, IUpdateSceneRoles obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B925 RID: 112933 RVA: 0x003E92AD File Offset: 0x003E74AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B926 RID: 112934 RVA: 0x003E92BC File Offset: 0x003E74BC
		public IUpdateSceneRoles __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170080D5 RID: 32981
		// (get) Token: 0x0601B927 RID: 112935 RVA: 0x003E92CC File Offset: 0x003E74CC
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170080D6 RID: 32982
		// (get) Token: 0x0601B928 RID: 112936 RVA: 0x003E9308 File Offset: 0x003E7508
		public string Group
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B929 RID: 112937 RVA: 0x003E933F File Offset: 0x003E753F
		public Span<byte> GetGroupBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601B92A RID: 112938 RVA: 0x003E934E File Offset: 0x003E754E
		public byte[] GetGroupArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601B92B RID: 112939 RVA: 0x003E935C File Offset: 0x003E755C
		public static Offset<IUpdateSceneRoles> CreateIUpdateSceneRoles(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, StringOffset GroupOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IUpdateSceneRoles.AddGroup(builder, GroupOffset);
			IUpdateSceneRoles.AddType(builder, Type);
			return IUpdateSceneRoles.EndIUpdateSceneRoles(builder);
		}

		// Token: 0x0601B92C RID: 112940 RVA: 0x003E9379 File Offset: 0x003E7579
		public static void StartIUpdateSceneRoles(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B92D RID: 112941 RVA: 0x003E9382 File Offset: 0x003E7582
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B92E RID: 112942 RVA: 0x003E938D File Offset: 0x003E758D
		public static void AddGroup(FlatBufferBuilder builder, StringOffset groupOffset)
		{
			builder.AddOffset(1, groupOffset.Value, 0);
		}

		// Token: 0x0601B92F RID: 112943 RVA: 0x003E939D File Offset: 0x003E759D
		public static Offset<IUpdateSceneRoles> EndIUpdateSceneRoles(FlatBufferBuilder builder)
		{
			return new Offset<IUpdateSceneRoles>(builder.EndTable());
		}

		// Token: 0x0601B930 RID: 112944 RVA: 0x003E93AC File Offset: 0x003E75AC
		public IUpdateSceneRolesT UnPack()
		{
			IUpdateSceneRolesT updateSceneRolesT = new IUpdateSceneRolesT();
			this.UnPackTo(updateSceneRolesT);
			return updateSceneRolesT;
		}

		// Token: 0x0601B931 RID: 112945 RVA: 0x003E93C7 File Offset: 0x003E75C7
		public void UnPackTo(IUpdateSceneRolesT _o)
		{
			_o.Type = this.Type;
			_o.Group = this.Group;
		}

		// Token: 0x0601B932 RID: 112946 RVA: 0x003E93E4 File Offset: 0x003E75E4
		public static Offset<IUpdateSceneRoles> Pack(FlatBufferBuilder builder, IUpdateSceneRolesT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUpdateSceneRoles>);
			}
			StringOffset groupOffset = (_o.Group == null) ? default(StringOffset) : builder.CreateString(_o.Group);
			return IUpdateSceneRoles.CreateIUpdateSceneRoles(builder, _o.Type, groupOffset);
		}

		// Token: 0x0400C8A7 RID: 51367
		private Table __p;
	}
}

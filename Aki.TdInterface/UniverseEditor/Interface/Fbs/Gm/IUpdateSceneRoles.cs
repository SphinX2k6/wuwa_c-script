using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B3D RID: 19261
	public struct IUpdateSceneRoles : IFlatbufferObject
	{
		// Token: 0x17008715 RID: 34581
		// (get) Token: 0x0601D0F6 RID: 119030 RVA: 0x004154FA File Offset: 0x004136FA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D0F7 RID: 119031 RVA: 0x00415507 File Offset: 0x00413707
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D0F8 RID: 119032 RVA: 0x00415510 File Offset: 0x00413710
		public static IUpdateSceneRoles GetRootAsIUpdateSceneRoles(ByteBuffer _bb)
		{
			return IUpdateSceneRoles.GetRootAsIUpdateSceneRoles(_bb, default(IUpdateSceneRoles));
		}

		// Token: 0x0601D0F9 RID: 119033 RVA: 0x0041552C File Offset: 0x0041372C
		public static IUpdateSceneRoles GetRootAsIUpdateSceneRoles(ByteBuffer _bb, IUpdateSceneRoles obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D0FA RID: 119034 RVA: 0x00415549 File Offset: 0x00413749
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D0FB RID: 119035 RVA: 0x00415558 File Offset: 0x00413758
		public IUpdateSceneRoles __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008716 RID: 34582
		// (get) Token: 0x0601D0FC RID: 119036 RVA: 0x00415568 File Offset: 0x00413768
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

		// Token: 0x17008717 RID: 34583
		// (get) Token: 0x0601D0FD RID: 119037 RVA: 0x004155A4 File Offset: 0x004137A4
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

		// Token: 0x0601D0FE RID: 119038 RVA: 0x004155DB File Offset: 0x004137DB
		public Span<byte> GetGroupBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601D0FF RID: 119039 RVA: 0x004155EA File Offset: 0x004137EA
		public byte[] GetGroupArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601D100 RID: 119040 RVA: 0x004155F8 File Offset: 0x004137F8
		public static Offset<IUpdateSceneRoles> CreateIUpdateSceneRoles(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, StringOffset GroupOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IUpdateSceneRoles.AddGroup(builder, GroupOffset);
			IUpdateSceneRoles.AddType(builder, Type);
			return IUpdateSceneRoles.EndIUpdateSceneRoles(builder);
		}

		// Token: 0x0601D101 RID: 119041 RVA: 0x00415615 File Offset: 0x00413815
		public static void StartIUpdateSceneRoles(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D102 RID: 119042 RVA: 0x0041561E File Offset: 0x0041381E
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D103 RID: 119043 RVA: 0x00415629 File Offset: 0x00413829
		public static void AddGroup(FlatBufferBuilder builder, StringOffset groupOffset)
		{
			builder.AddOffset(1, groupOffset.Value, 0);
		}

		// Token: 0x0601D104 RID: 119044 RVA: 0x00415639 File Offset: 0x00413839
		public static Offset<IUpdateSceneRoles> EndIUpdateSceneRoles(FlatBufferBuilder builder)
		{
			return new Offset<IUpdateSceneRoles>(builder.EndTable());
		}

		// Token: 0x0601D105 RID: 119045 RVA: 0x00415648 File Offset: 0x00413848
		public IUpdateSceneRolesT UnPack()
		{
			IUpdateSceneRolesT updateSceneRolesT = new IUpdateSceneRolesT();
			this.UnPackTo(updateSceneRolesT);
			return updateSceneRolesT;
		}

		// Token: 0x0601D106 RID: 119046 RVA: 0x00415663 File Offset: 0x00413863
		public void UnPackTo(IUpdateSceneRolesT _o)
		{
			_o.Type = this.Type;
			_o.Group = this.Group;
		}

		// Token: 0x0601D107 RID: 119047 RVA: 0x00415680 File Offset: 0x00413880
		public static Offset<IUpdateSceneRoles> Pack(FlatBufferBuilder builder, IUpdateSceneRolesT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUpdateSceneRoles>);
			}
			StringOffset groupOffset = (_o.Group == null) ? default(StringOffset) : builder.CreateString(_o.Group);
			return IUpdateSceneRoles.CreateIUpdateSceneRoles(builder, _o.Type, groupOffset);
		}

		// Token: 0x0400D2D6 RID: 53974
		private Table __p;
	}
}

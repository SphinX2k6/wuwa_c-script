using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043D3 RID: 17363
	public struct IPhotographTargetPlayer : IFlatbufferObject
	{
		// Token: 0x17007796 RID: 30614
		// (get) Token: 0x06018A6D RID: 100973 RVA: 0x00383FD5 File Offset: 0x003821D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018A6E RID: 100974 RVA: 0x00383FE2 File Offset: 0x003821E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018A6F RID: 100975 RVA: 0x00383FEC File Offset: 0x003821EC
		public static IPhotographTargetPlayer GetRootAsIPhotographTargetPlayer(ByteBuffer _bb)
		{
			return IPhotographTargetPlayer.GetRootAsIPhotographTargetPlayer(_bb, default(IPhotographTargetPlayer));
		}

		// Token: 0x06018A70 RID: 100976 RVA: 0x00384008 File Offset: 0x00382208
		public static IPhotographTargetPlayer GetRootAsIPhotographTargetPlayer(ByteBuffer _bb, IPhotographTargetPlayer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018A71 RID: 100977 RVA: 0x00384025 File Offset: 0x00382225
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018A72 RID: 100978 RVA: 0x00384034 File Offset: 0x00382234
		public IPhotographTargetPlayer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007797 RID: 30615
		// (get) Token: 0x06018A73 RID: 100979 RVA: 0x00384044 File Offset: 0x00382244
		public EPhotographTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhotographTargetType.Player;
				}
				return (EPhotographTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007798 RID: 30616
		// (get) Token: 0x06018A74 RID: 100980 RVA: 0x00384080 File Offset: 0x00382280
		public int RoleId
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

		// Token: 0x17007799 RID: 30617
		// (get) Token: 0x06018A75 RID: 100981 RVA: 0x003840BC File Offset: 0x003822BC
		public EOnCameraCheckType OnCameraCheckType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EOnCameraCheckType.All;
				}
				return (EOnCameraCheckType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700779A RID: 30618
		// (get) Token: 0x06018A76 RID: 100982 RVA: 0x003840F8 File Offset: 0x003822F8
		public IConditionGroup? CommonCondition
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700779B RID: 30619
		// (get) Token: 0x06018A77 RID: 100983 RVA: 0x00384158 File Offset: 0x00382358
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018A78 RID: 100984 RVA: 0x00384195 File Offset: 0x00382395
		public static Offset<IPhotographTargetPlayer> CreateIPhotographTargetPlayer(FlatBufferBuilder builder, EPhotographTargetType Type = EPhotographTargetType.Player, int RoleId = 0, EOnCameraCheckType OnCameraCheckType = EOnCameraCheckType.All, Offset<IConditionGroup> CommonConditionOffset = default(Offset<IConditionGroup>), byte NullMask = 0)
		{
			builder.StartTable(5);
			IPhotographTargetPlayer.AddCommonCondition(builder, CommonConditionOffset);
			IPhotographTargetPlayer.AddRoleId(builder, RoleId);
			IPhotographTargetPlayer.AddNullMask(builder, NullMask);
			IPhotographTargetPlayer.AddOnCameraCheckType(builder, OnCameraCheckType);
			IPhotographTargetPlayer.AddType(builder, Type);
			return IPhotographTargetPlayer.EndIPhotographTargetPlayer(builder);
		}

		// Token: 0x06018A79 RID: 100985 RVA: 0x003841C9 File Offset: 0x003823C9
		public static void StartIPhotographTargetPlayer(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06018A7A RID: 100986 RVA: 0x003841D2 File Offset: 0x003823D2
		public static void AddType(FlatBufferBuilder builder, EPhotographTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018A7B RID: 100987 RVA: 0x003841DD File Offset: 0x003823DD
		public static void AddRoleId(FlatBufferBuilder builder, int roleId)
		{
			builder.AddInt(1, roleId, 0);
		}

		// Token: 0x06018A7C RID: 100988 RVA: 0x003841E8 File Offset: 0x003823E8
		public static void AddOnCameraCheckType(FlatBufferBuilder builder, EOnCameraCheckType onCameraCheckType)
		{
			builder.AddByte(2, (byte)onCameraCheckType, 0);
		}

		// Token: 0x06018A7D RID: 100989 RVA: 0x003841F3 File Offset: 0x003823F3
		public static void AddCommonCondition(FlatBufferBuilder builder, Offset<IConditionGroup> commonConditionOffset)
		{
			builder.AddOffset(3, commonConditionOffset.Value, 0);
		}

		// Token: 0x06018A7E RID: 100990 RVA: 0x00384203 File Offset: 0x00382403
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06018A7F RID: 100991 RVA: 0x0038420E File Offset: 0x0038240E
		public static Offset<IPhotographTargetPlayer> EndIPhotographTargetPlayer(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographTargetPlayer>(builder.EndTable());
		}

		// Token: 0x06018A80 RID: 100992 RVA: 0x0038421C File Offset: 0x0038241C
		public IPhotographTargetPlayerT UnPack()
		{
			IPhotographTargetPlayerT photographTargetPlayerT = new IPhotographTargetPlayerT();
			this.UnPackTo(photographTargetPlayerT);
			return photographTargetPlayerT;
		}

		// Token: 0x06018A81 RID: 100993 RVA: 0x00384238 File Offset: 0x00382438
		public void UnPackTo(IPhotographTargetPlayerT _o)
		{
			_o.Type = this.Type;
			_o.RoleId = this.RoleId;
			_o.OnCameraCheckType = this.OnCameraCheckType;
			_o.CommonCondition = ((this.CommonCondition != null) ? this.CommonCondition.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06018A82 RID: 100994 RVA: 0x003842A4 File Offset: 0x003824A4
		public static Offset<IPhotographTargetPlayer> Pack(FlatBufferBuilder builder, IPhotographTargetPlayerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotographTargetPlayer>);
			}
			Offset<IConditionGroup> commonConditionOffset = (_o.CommonCondition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.CommonCondition);
			return IPhotographTargetPlayer.CreateIPhotographTargetPlayer(builder, _o.Type, _o.RoleId, _o.OnCameraCheckType, commonConditionOffset, _o.NullMask);
		}

		// Token: 0x0400C3D4 RID: 50132
		private Table __p;
	}
}

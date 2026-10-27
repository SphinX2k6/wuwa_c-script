using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F92 RID: 16274
	public struct IPhotographTargetPlayer : IFlatbufferObject
	{
		// Token: 0x17007198 RID: 29080
		// (get) Token: 0x060173DE RID: 95198 RVA: 0x0035A3BD File Offset: 0x003585BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060173DF RID: 95199 RVA: 0x0035A3CA File Offset: 0x003585CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060173E0 RID: 95200 RVA: 0x0035A3D4 File Offset: 0x003585D4
		public static IPhotographTargetPlayer GetRootAsIPhotographTargetPlayer(ByteBuffer _bb)
		{
			return IPhotographTargetPlayer.GetRootAsIPhotographTargetPlayer(_bb, default(IPhotographTargetPlayer));
		}

		// Token: 0x060173E1 RID: 95201 RVA: 0x0035A3F0 File Offset: 0x003585F0
		public static IPhotographTargetPlayer GetRootAsIPhotographTargetPlayer(ByteBuffer _bb, IPhotographTargetPlayer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060173E2 RID: 95202 RVA: 0x0035A40D File Offset: 0x0035860D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060173E3 RID: 95203 RVA: 0x0035A41C File Offset: 0x0035861C
		public IPhotographTargetPlayer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007199 RID: 29081
		// (get) Token: 0x060173E4 RID: 95204 RVA: 0x0035A42C File Offset: 0x0035862C
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

		// Token: 0x1700719A RID: 29082
		// (get) Token: 0x060173E5 RID: 95205 RVA: 0x0035A468 File Offset: 0x00358668
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

		// Token: 0x1700719B RID: 29083
		// (get) Token: 0x060173E6 RID: 95206 RVA: 0x0035A4A4 File Offset: 0x003586A4
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

		// Token: 0x1700719C RID: 29084
		// (get) Token: 0x060173E7 RID: 95207 RVA: 0x0035A4E0 File Offset: 0x003586E0
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

		// Token: 0x1700719D RID: 29085
		// (get) Token: 0x060173E8 RID: 95208 RVA: 0x0035A540 File Offset: 0x00358740
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

		// Token: 0x060173E9 RID: 95209 RVA: 0x0035A57D File Offset: 0x0035877D
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

		// Token: 0x060173EA RID: 95210 RVA: 0x0035A5B1 File Offset: 0x003587B1
		public static void StartIPhotographTargetPlayer(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060173EB RID: 95211 RVA: 0x0035A5BA File Offset: 0x003587BA
		public static void AddType(FlatBufferBuilder builder, EPhotographTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060173EC RID: 95212 RVA: 0x0035A5C5 File Offset: 0x003587C5
		public static void AddRoleId(FlatBufferBuilder builder, int roleId)
		{
			builder.AddInt(1, roleId, 0);
		}

		// Token: 0x060173ED RID: 95213 RVA: 0x0035A5D0 File Offset: 0x003587D0
		public static void AddOnCameraCheckType(FlatBufferBuilder builder, EOnCameraCheckType onCameraCheckType)
		{
			builder.AddByte(2, (byte)onCameraCheckType, 0);
		}

		// Token: 0x060173EE RID: 95214 RVA: 0x0035A5DB File Offset: 0x003587DB
		public static void AddCommonCondition(FlatBufferBuilder builder, Offset<IConditionGroup> commonConditionOffset)
		{
			builder.AddOffset(3, commonConditionOffset.Value, 0);
		}

		// Token: 0x060173EF RID: 95215 RVA: 0x0035A5EB File Offset: 0x003587EB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060173F0 RID: 95216 RVA: 0x0035A5F6 File Offset: 0x003587F6
		public static Offset<IPhotographTargetPlayer> EndIPhotographTargetPlayer(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographTargetPlayer>(builder.EndTable());
		}

		// Token: 0x060173F1 RID: 95217 RVA: 0x0035A604 File Offset: 0x00358804
		public IPhotographTargetPlayerT UnPack()
		{
			IPhotographTargetPlayerT photographTargetPlayerT = new IPhotographTargetPlayerT();
			this.UnPackTo(photographTargetPlayerT);
			return photographTargetPlayerT;
		}

		// Token: 0x060173F2 RID: 95218 RVA: 0x0035A620 File Offset: 0x00358820
		public void UnPackTo(IPhotographTargetPlayerT _o)
		{
			_o.Type = this.Type;
			_o.RoleId = this.RoleId;
			_o.OnCameraCheckType = this.OnCameraCheckType;
			_o.CommonCondition = ((this.CommonCondition != null) ? this.CommonCondition.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060173F3 RID: 95219 RVA: 0x0035A68C File Offset: 0x0035888C
		public static Offset<IPhotographTargetPlayer> Pack(FlatBufferBuilder builder, IPhotographTargetPlayerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotographTargetPlayer>);
			}
			Offset<IConditionGroup> commonConditionOffset = (_o.CommonCondition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.CommonCondition);
			return IPhotographTargetPlayer.CreateIPhotographTargetPlayer(builder, _o.Type, _o.RoleId, _o.OnCameraCheckType, commonConditionOffset, _o.NullMask);
		}

		// Token: 0x0400B9EF RID: 47599
		private Table __p;
	}
}

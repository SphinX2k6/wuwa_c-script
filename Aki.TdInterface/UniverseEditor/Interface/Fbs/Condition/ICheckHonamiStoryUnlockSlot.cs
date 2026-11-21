using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F32 RID: 20274
	public struct ICheckHonamiStoryUnlockSlot : IFlatbufferObject
	{
		// Token: 0x170090D0 RID: 37072
		// (get) Token: 0x0601F835 RID: 129077 RVA: 0x004629E8 File Offset: 0x00460BE8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F836 RID: 129078 RVA: 0x004629F5 File Offset: 0x00460BF5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F837 RID: 129079 RVA: 0x004629FC File Offset: 0x00460BFC
		public static ICheckHonamiStoryUnlockSlot GetRootAsICheckHonamiStoryUnlockSlot(ByteBuffer _bb)
		{
			return ICheckHonamiStoryUnlockSlot.GetRootAsICheckHonamiStoryUnlockSlot(_bb, default(ICheckHonamiStoryUnlockSlot));
		}

		// Token: 0x0601F838 RID: 129080 RVA: 0x00462A18 File Offset: 0x00460C18
		public static ICheckHonamiStoryUnlockSlot GetRootAsICheckHonamiStoryUnlockSlot(ByteBuffer _bb, ICheckHonamiStoryUnlockSlot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F839 RID: 129081 RVA: 0x00462A35 File Offset: 0x00460C35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F83A RID: 129082 RVA: 0x00462A44 File Offset: 0x00460C44
		public ICheckHonamiStoryUnlockSlot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170090D1 RID: 37073
		// (get) Token: 0x0601F83B RID: 129083 RVA: 0x00462A54 File Offset: 0x00460C54
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170090D2 RID: 37074
		// (get) Token: 0x0601F83C RID: 129084 RVA: 0x00462A90 File Offset: 0x00460C90
		public int ActivityId
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

		// Token: 0x170090D3 RID: 37075
		// (get) Token: 0x0601F83D RID: 129085 RVA: 0x00462ACC File Offset: 0x00460CCC
		public EHonamiStoryRoleSlot RoleSlot
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EHonamiStoryRoleSlot.None;
				}
				return (EHonamiStoryRoleSlot)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170090D4 RID: 37076
		// (get) Token: 0x0601F83E RID: 129086 RVA: 0x00462B08 File Offset: 0x00460D08
		public EHonamiStoryPluginSlot PluginSlot
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EHonamiStoryPluginSlot.None;
				}
				return (EHonamiStoryPluginSlot)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170090D5 RID: 37077
		// (get) Token: 0x0601F83F RID: 129087 RVA: 0x00462B48 File Offset: 0x00460D48
		public bool IsUnlocked
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601F840 RID: 129088 RVA: 0x00462B88 File Offset: 0x00460D88
		public static Offset<ICheckHonamiStoryUnlockSlot> CreateICheckHonamiStoryUnlockSlot(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int ActivityId = 0, EHonamiStoryRoleSlot RoleSlot = EHonamiStoryRoleSlot.None, EHonamiStoryPluginSlot PluginSlot = EHonamiStoryPluginSlot.None, bool IsUnlocked = false)
		{
			builder.StartTable(5);
			ICheckHonamiStoryUnlockSlot.AddActivityId(builder, ActivityId);
			ICheckHonamiStoryUnlockSlot.AddIsUnlocked(builder, IsUnlocked);
			ICheckHonamiStoryUnlockSlot.AddPluginSlot(builder, PluginSlot);
			ICheckHonamiStoryUnlockSlot.AddRoleSlot(builder, RoleSlot);
			ICheckHonamiStoryUnlockSlot.AddType(builder, Type);
			return ICheckHonamiStoryUnlockSlot.EndICheckHonamiStoryUnlockSlot(builder);
		}

		// Token: 0x0601F841 RID: 129089 RVA: 0x00462BBC File Offset: 0x00460DBC
		public static void StartICheckHonamiStoryUnlockSlot(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601F842 RID: 129090 RVA: 0x00462BC5 File Offset: 0x00460DC5
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F843 RID: 129091 RVA: 0x00462BD0 File Offset: 0x00460DD0
		public static void AddActivityId(FlatBufferBuilder builder, int activityId)
		{
			builder.AddInt(1, activityId, 0);
		}

		// Token: 0x0601F844 RID: 129092 RVA: 0x00462BDB File Offset: 0x00460DDB
		public static void AddRoleSlot(FlatBufferBuilder builder, EHonamiStoryRoleSlot roleSlot)
		{
			builder.AddByte(2, (byte)roleSlot, 0);
		}

		// Token: 0x0601F845 RID: 129093 RVA: 0x00462BE6 File Offset: 0x00460DE6
		public static void AddPluginSlot(FlatBufferBuilder builder, EHonamiStoryPluginSlot pluginSlot)
		{
			builder.AddByte(3, (byte)pluginSlot, 0);
		}

		// Token: 0x0601F846 RID: 129094 RVA: 0x00462BF1 File Offset: 0x00460DF1
		public static void AddIsUnlocked(FlatBufferBuilder builder, bool isUnlocked)
		{
			builder.AddBool(4, isUnlocked, false);
		}

		// Token: 0x0601F847 RID: 129095 RVA: 0x00462BFC File Offset: 0x00460DFC
		public static Offset<ICheckHonamiStoryUnlockSlot> EndICheckHonamiStoryUnlockSlot(FlatBufferBuilder builder)
		{
			return new Offset<ICheckHonamiStoryUnlockSlot>(builder.EndTable());
		}

		// Token: 0x0601F848 RID: 129096 RVA: 0x00462C0C File Offset: 0x00460E0C
		public ICheckHonamiStoryUnlockSlotT UnPack()
		{
			ICheckHonamiStoryUnlockSlotT checkHonamiStoryUnlockSlotT = new ICheckHonamiStoryUnlockSlotT();
			this.UnPackTo(checkHonamiStoryUnlockSlotT);
			return checkHonamiStoryUnlockSlotT;
		}

		// Token: 0x0601F849 RID: 129097 RVA: 0x00462C27 File Offset: 0x00460E27
		public void UnPackTo(ICheckHonamiStoryUnlockSlotT _o)
		{
			_o.Type = this.Type;
			_o.ActivityId = this.ActivityId;
			_o.RoleSlot = this.RoleSlot;
			_o.PluginSlot = this.PluginSlot;
			_o.IsUnlocked = this.IsUnlocked;
		}

		// Token: 0x0601F84A RID: 129098 RVA: 0x00462C68 File Offset: 0x00460E68
		public static Offset<ICheckHonamiStoryUnlockSlot> Pack(FlatBufferBuilder builder, ICheckHonamiStoryUnlockSlotT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckHonamiStoryUnlockSlot>);
			}
			return ICheckHonamiStoryUnlockSlot.CreateICheckHonamiStoryUnlockSlot(builder, _o.Type, _o.ActivityId, _o.RoleSlot, _o.PluginSlot, _o.IsUnlocked);
		}

		// Token: 0x0400DDAA RID: 56746
		private Table __p;
	}
}

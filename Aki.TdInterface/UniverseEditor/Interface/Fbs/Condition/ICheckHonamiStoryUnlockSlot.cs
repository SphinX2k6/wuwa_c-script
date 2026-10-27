using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A6C RID: 19052
	public struct ICheckHonamiStoryUnlockSlot : IFlatbufferObject
	{
		// Token: 0x170089F4 RID: 35316
		// (get) Token: 0x0601DD92 RID: 122258 RVA: 0x0043185C File Offset: 0x0042FA5C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DD93 RID: 122259 RVA: 0x00431869 File Offset: 0x0042FA69
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DD94 RID: 122260 RVA: 0x00431870 File Offset: 0x0042FA70
		public static ICheckHonamiStoryUnlockSlot GetRootAsICheckHonamiStoryUnlockSlot(ByteBuffer _bb)
		{
			return ICheckHonamiStoryUnlockSlot.GetRootAsICheckHonamiStoryUnlockSlot(_bb, default(ICheckHonamiStoryUnlockSlot));
		}

		// Token: 0x0601DD95 RID: 122261 RVA: 0x0043188C File Offset: 0x0042FA8C
		public static ICheckHonamiStoryUnlockSlot GetRootAsICheckHonamiStoryUnlockSlot(ByteBuffer _bb, ICheckHonamiStoryUnlockSlot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DD96 RID: 122262 RVA: 0x004318A9 File Offset: 0x0042FAA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DD97 RID: 122263 RVA: 0x004318B8 File Offset: 0x0042FAB8
		public ICheckHonamiStoryUnlockSlot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170089F5 RID: 35317
		// (get) Token: 0x0601DD98 RID: 122264 RVA: 0x004318C8 File Offset: 0x0042FAC8
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

		// Token: 0x170089F6 RID: 35318
		// (get) Token: 0x0601DD99 RID: 122265 RVA: 0x00431904 File Offset: 0x0042FB04
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

		// Token: 0x170089F7 RID: 35319
		// (get) Token: 0x0601DD9A RID: 122266 RVA: 0x00431940 File Offset: 0x0042FB40
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

		// Token: 0x170089F8 RID: 35320
		// (get) Token: 0x0601DD9B RID: 122267 RVA: 0x0043197C File Offset: 0x0042FB7C
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

		// Token: 0x170089F9 RID: 35321
		// (get) Token: 0x0601DD9C RID: 122268 RVA: 0x004319BC File Offset: 0x0042FBBC
		public bool IsUnlocked
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601DD9D RID: 122269 RVA: 0x004319FC File Offset: 0x0042FBFC
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

		// Token: 0x0601DD9E RID: 122270 RVA: 0x00431A30 File Offset: 0x0042FC30
		public static void StartICheckHonamiStoryUnlockSlot(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601DD9F RID: 122271 RVA: 0x00431A39 File Offset: 0x0042FC39
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DDA0 RID: 122272 RVA: 0x00431A44 File Offset: 0x0042FC44
		public static void AddActivityId(FlatBufferBuilder builder, int activityId)
		{
			builder.AddInt(1, activityId, 0);
		}

		// Token: 0x0601DDA1 RID: 122273 RVA: 0x00431A4F File Offset: 0x0042FC4F
		public static void AddRoleSlot(FlatBufferBuilder builder, EHonamiStoryRoleSlot roleSlot)
		{
			builder.AddByte(2, (byte)roleSlot, 0);
		}

		// Token: 0x0601DDA2 RID: 122274 RVA: 0x00431A5A File Offset: 0x0042FC5A
		public static void AddPluginSlot(FlatBufferBuilder builder, EHonamiStoryPluginSlot pluginSlot)
		{
			builder.AddByte(3, (byte)pluginSlot, 0);
		}

		// Token: 0x0601DDA3 RID: 122275 RVA: 0x00431A65 File Offset: 0x0042FC65
		public static void AddIsUnlocked(FlatBufferBuilder builder, bool isUnlocked)
		{
			builder.AddBool(4, isUnlocked, false);
		}

		// Token: 0x0601DDA4 RID: 122276 RVA: 0x00431A70 File Offset: 0x0042FC70
		public static Offset<ICheckHonamiStoryUnlockSlot> EndICheckHonamiStoryUnlockSlot(FlatBufferBuilder builder)
		{
			return new Offset<ICheckHonamiStoryUnlockSlot>(builder.EndTable());
		}

		// Token: 0x0601DDA5 RID: 122277 RVA: 0x00431A80 File Offset: 0x0042FC80
		public ICheckHonamiStoryUnlockSlotT UnPack()
		{
			ICheckHonamiStoryUnlockSlotT checkHonamiStoryUnlockSlotT = new ICheckHonamiStoryUnlockSlotT();
			this.UnPackTo(checkHonamiStoryUnlockSlotT);
			return checkHonamiStoryUnlockSlotT;
		}

		// Token: 0x0601DDA6 RID: 122278 RVA: 0x00431A9B File Offset: 0x0042FC9B
		public void UnPackTo(ICheckHonamiStoryUnlockSlotT _o)
		{
			_o.Type = this.Type;
			_o.ActivityId = this.ActivityId;
			_o.RoleSlot = this.RoleSlot;
			_o.PluginSlot = this.PluginSlot;
			_o.IsUnlocked = this.IsUnlocked;
		}

		// Token: 0x0601DDA7 RID: 122279 RVA: 0x00431ADC File Offset: 0x0042FCDC
		public static Offset<ICheckHonamiStoryUnlockSlot> Pack(FlatBufferBuilder builder, ICheckHonamiStoryUnlockSlotT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckHonamiStoryUnlockSlot>);
			}
			return ICheckHonamiStoryUnlockSlot.CreateICheckHonamiStoryUnlockSlot(builder, _o.Type, _o.ActivityId, _o.RoleSlot, _o.PluginSlot, _o.IsUnlocked);
		}

		// Token: 0x0400D2CF RID: 53967
		private Table __p;
	}
}

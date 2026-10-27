using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A66 RID: 19046
	public struct ICheckHonamiStoryTowerComplete : IFlatbufferObject
	{
		// Token: 0x170089E6 RID: 35302
		// (get) Token: 0x0601DD5E RID: 122206 RVA: 0x00431336 File Offset: 0x0042F536
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DD5F RID: 122207 RVA: 0x00431343 File Offset: 0x0042F543
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DD60 RID: 122208 RVA: 0x0043134C File Offset: 0x0042F54C
		public static ICheckHonamiStoryTowerComplete GetRootAsICheckHonamiStoryTowerComplete(ByteBuffer _bb)
		{
			return ICheckHonamiStoryTowerComplete.GetRootAsICheckHonamiStoryTowerComplete(_bb, default(ICheckHonamiStoryTowerComplete));
		}

		// Token: 0x0601DD61 RID: 122209 RVA: 0x00431368 File Offset: 0x0042F568
		public static ICheckHonamiStoryTowerComplete GetRootAsICheckHonamiStoryTowerComplete(ByteBuffer _bb, ICheckHonamiStoryTowerComplete obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DD62 RID: 122210 RVA: 0x00431385 File Offset: 0x0042F585
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DD63 RID: 122211 RVA: 0x00431394 File Offset: 0x0042F594
		public ICheckHonamiStoryTowerComplete __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170089E7 RID: 35303
		// (get) Token: 0x0601DD64 RID: 122212 RVA: 0x004313A4 File Offset: 0x0042F5A4
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

		// Token: 0x170089E8 RID: 35304
		// (get) Token: 0x0601DD65 RID: 122213 RVA: 0x004313E0 File Offset: 0x0042F5E0
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

		// Token: 0x170089E9 RID: 35305
		// (get) Token: 0x0601DD66 RID: 122214 RVA: 0x0043141C File Offset: 0x0042F61C
		public int Floor
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

		// Token: 0x0601DD67 RID: 122215 RVA: 0x00431458 File Offset: 0x0042F658
		public static Offset<ICheckHonamiStoryTowerComplete> CreateICheckHonamiStoryTowerComplete(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int ActivityId = 0, int Floor = 0)
		{
			builder.StartTable(3);
			ICheckHonamiStoryTowerComplete.AddFloor(builder, Floor);
			ICheckHonamiStoryTowerComplete.AddActivityId(builder, ActivityId);
			ICheckHonamiStoryTowerComplete.AddType(builder, Type);
			return ICheckHonamiStoryTowerComplete.EndICheckHonamiStoryTowerComplete(builder);
		}

		// Token: 0x0601DD68 RID: 122216 RVA: 0x0043147C File Offset: 0x0042F67C
		public static void StartICheckHonamiStoryTowerComplete(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601DD69 RID: 122217 RVA: 0x00431485 File Offset: 0x0042F685
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DD6A RID: 122218 RVA: 0x00431490 File Offset: 0x0042F690
		public static void AddActivityId(FlatBufferBuilder builder, int activityId)
		{
			builder.AddInt(1, activityId, 0);
		}

		// Token: 0x0601DD6B RID: 122219 RVA: 0x0043149B File Offset: 0x0042F69B
		public static void AddFloor(FlatBufferBuilder builder, int floor)
		{
			builder.AddInt(2, floor, 0);
		}

		// Token: 0x0601DD6C RID: 122220 RVA: 0x004314A6 File Offset: 0x0042F6A6
		public static Offset<ICheckHonamiStoryTowerComplete> EndICheckHonamiStoryTowerComplete(FlatBufferBuilder builder)
		{
			return new Offset<ICheckHonamiStoryTowerComplete>(builder.EndTable());
		}

		// Token: 0x0601DD6D RID: 122221 RVA: 0x004314B4 File Offset: 0x0042F6B4
		public ICheckHonamiStoryTowerCompleteT UnPack()
		{
			ICheckHonamiStoryTowerCompleteT checkHonamiStoryTowerCompleteT = new ICheckHonamiStoryTowerCompleteT();
			this.UnPackTo(checkHonamiStoryTowerCompleteT);
			return checkHonamiStoryTowerCompleteT;
		}

		// Token: 0x0601DD6E RID: 122222 RVA: 0x004314CF File Offset: 0x0042F6CF
		public void UnPackTo(ICheckHonamiStoryTowerCompleteT _o)
		{
			_o.Type = this.Type;
			_o.ActivityId = this.ActivityId;
			_o.Floor = this.Floor;
		}

		// Token: 0x0601DD6F RID: 122223 RVA: 0x004314F8 File Offset: 0x0042F6F8
		public static Offset<ICheckHonamiStoryTowerComplete> Pack(FlatBufferBuilder builder, ICheckHonamiStoryTowerCompleteT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckHonamiStoryTowerComplete>);
			}
			return ICheckHonamiStoryTowerComplete.CreateICheckHonamiStoryTowerComplete(builder, _o.Type, _o.ActivityId, _o.Floor);
		}

		// Token: 0x0400D2C7 RID: 53959
		private Table __p;
	}
}

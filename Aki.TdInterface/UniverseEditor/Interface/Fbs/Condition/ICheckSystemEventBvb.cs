using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B3B RID: 19259
	public struct ICheckSystemEventBvb : IFlatbufferObject
	{
		// Token: 0x17008BBA RID: 35770
		// (get) Token: 0x0601E4F2 RID: 124146 RVA: 0x0043F2BC File Offset: 0x0043D4BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E4F3 RID: 124147 RVA: 0x0043F2C9 File Offset: 0x0043D4C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E4F4 RID: 124148 RVA: 0x0043F2D0 File Offset: 0x0043D4D0
		public static ICheckSystemEventBvb GetRootAsICheckSystemEventBvb(ByteBuffer _bb)
		{
			return ICheckSystemEventBvb.GetRootAsICheckSystemEventBvb(_bb, default(ICheckSystemEventBvb));
		}

		// Token: 0x0601E4F5 RID: 124149 RVA: 0x0043F2EC File Offset: 0x0043D4EC
		public static ICheckSystemEventBvb GetRootAsICheckSystemEventBvb(ByteBuffer _bb, ICheckSystemEventBvb obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E4F6 RID: 124150 RVA: 0x0043F309 File Offset: 0x0043D509
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E4F7 RID: 124151 RVA: 0x0043F318 File Offset: 0x0043D518
		public ICheckSystemEventBvb __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008BBB RID: 35771
		// (get) Token: 0x0601E4F8 RID: 124152 RVA: 0x0043F328 File Offset: 0x0043D528
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

		// Token: 0x17008BBC RID: 35772
		// (get) Token: 0x0601E4F9 RID: 124153 RVA: 0x0043F364 File Offset: 0x0043D564
		public EBvbEventName EventName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EBvbEventName.AIEvolution;
				}
				return (EBvbEventName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E4FA RID: 124154 RVA: 0x0043F3A0 File Offset: 0x0043D5A0
		public static Offset<ICheckSystemEventBvb> CreateICheckSystemEventBvb(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, EBvbEventName EventName = EBvbEventName.AIEvolution)
		{
			builder.StartTable(2);
			ICheckSystemEventBvb.AddEventName(builder, EventName);
			ICheckSystemEventBvb.AddType(builder, Type);
			return ICheckSystemEventBvb.EndICheckSystemEventBvb(builder);
		}

		// Token: 0x0601E4FB RID: 124155 RVA: 0x0043F3BD File Offset: 0x0043D5BD
		public static void StartICheckSystemEventBvb(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E4FC RID: 124156 RVA: 0x0043F3C6 File Offset: 0x0043D5C6
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E4FD RID: 124157 RVA: 0x0043F3D1 File Offset: 0x0043D5D1
		public static void AddEventName(FlatBufferBuilder builder, EBvbEventName eventName)
		{
			builder.AddByte(1, (byte)eventName, 0);
		}

		// Token: 0x0601E4FE RID: 124158 RVA: 0x0043F3DC File Offset: 0x0043D5DC
		public static Offset<ICheckSystemEventBvb> EndICheckSystemEventBvb(FlatBufferBuilder builder)
		{
			return new Offset<ICheckSystemEventBvb>(builder.EndTable());
		}

		// Token: 0x0601E4FF RID: 124159 RVA: 0x0043F3EC File Offset: 0x0043D5EC
		public ICheckSystemEventBvbT UnPack()
		{
			ICheckSystemEventBvbT checkSystemEventBvbT = new ICheckSystemEventBvbT();
			this.UnPackTo(checkSystemEventBvbT);
			return checkSystemEventBvbT;
		}

		// Token: 0x0601E500 RID: 124160 RVA: 0x0043F407 File Offset: 0x0043D607
		public void UnPackTo(ICheckSystemEventBvbT _o)
		{
			_o.Type = this.Type;
			_o.EventName = this.EventName;
		}

		// Token: 0x0601E501 RID: 124161 RVA: 0x0043F424 File Offset: 0x0043D624
		public static Offset<ICheckSystemEventBvb> Pack(FlatBufferBuilder builder, ICheckSystemEventBvbT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckSystemEventBvb>);
			}
			return ICheckSystemEventBvb.CreateICheckSystemEventBvb(builder, _o.Type, _o.EventName);
		}

		// Token: 0x0400D3E3 RID: 54243
		private Table __p;
	}
}

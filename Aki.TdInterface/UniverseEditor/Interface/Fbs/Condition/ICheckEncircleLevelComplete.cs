using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049E8 RID: 18920
	public struct ICheckEncircleLevelComplete : IFlatbufferObject
	{
		// Token: 0x170088D7 RID: 35031
		// (get) Token: 0x0601D8F2 RID: 121074 RVA: 0x00429348 File Offset: 0x00427548
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D8F3 RID: 121075 RVA: 0x00429355 File Offset: 0x00427555
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D8F4 RID: 121076 RVA: 0x0042935C File Offset: 0x0042755C
		public static ICheckEncircleLevelComplete GetRootAsICheckEncircleLevelComplete(ByteBuffer _bb)
		{
			return ICheckEncircleLevelComplete.GetRootAsICheckEncircleLevelComplete(_bb, default(ICheckEncircleLevelComplete));
		}

		// Token: 0x0601D8F5 RID: 121077 RVA: 0x00429378 File Offset: 0x00427578
		public static ICheckEncircleLevelComplete GetRootAsICheckEncircleLevelComplete(ByteBuffer _bb, ICheckEncircleLevelComplete obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D8F6 RID: 121078 RVA: 0x00429395 File Offset: 0x00427595
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D8F7 RID: 121079 RVA: 0x004293A4 File Offset: 0x004275A4
		public ICheckEncircleLevelComplete __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170088D8 RID: 35032
		// (get) Token: 0x0601D8F8 RID: 121080 RVA: 0x004293B4 File Offset: 0x004275B4
		public ECheckSystemStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckSystemStateType.TrackMoonBuilding;
				}
				return (ECheckSystemStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170088D9 RID: 35033
		// (get) Token: 0x0601D8F9 RID: 121081 RVA: 0x004293F0 File Offset: 0x004275F0
		public int EncircleLevelId
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

		// Token: 0x170088DA RID: 35034
		// (get) Token: 0x0601D8FA RID: 121082 RVA: 0x0042942C File Offset: 0x0042762C
		public bool IsCompleted
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601D8FB RID: 121083 RVA: 0x0042946B File Offset: 0x0042766B
		public static Offset<ICheckEncircleLevelComplete> CreateICheckEncircleLevelComplete(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, int EncircleLevelId = 0, bool IsCompleted = false)
		{
			builder.StartTable(3);
			ICheckEncircleLevelComplete.AddEncircleLevelId(builder, EncircleLevelId);
			ICheckEncircleLevelComplete.AddIsCompleted(builder, IsCompleted);
			ICheckEncircleLevelComplete.AddType(builder, Type);
			return ICheckEncircleLevelComplete.EndICheckEncircleLevelComplete(builder);
		}

		// Token: 0x0601D8FC RID: 121084 RVA: 0x0042948F File Offset: 0x0042768F
		public static void StartICheckEncircleLevelComplete(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601D8FD RID: 121085 RVA: 0x00429498 File Offset: 0x00427698
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D8FE RID: 121086 RVA: 0x004294A3 File Offset: 0x004276A3
		public static void AddEncircleLevelId(FlatBufferBuilder builder, int encircleLevelId)
		{
			builder.AddInt(1, encircleLevelId, 0);
		}

		// Token: 0x0601D8FF RID: 121087 RVA: 0x004294AE File Offset: 0x004276AE
		public static void AddIsCompleted(FlatBufferBuilder builder, bool isCompleted)
		{
			builder.AddBool(2, isCompleted, false);
		}

		// Token: 0x0601D900 RID: 121088 RVA: 0x004294B9 File Offset: 0x004276B9
		public static Offset<ICheckEncircleLevelComplete> EndICheckEncircleLevelComplete(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEncircleLevelComplete>(builder.EndTable());
		}

		// Token: 0x0601D901 RID: 121089 RVA: 0x004294C8 File Offset: 0x004276C8
		public ICheckEncircleLevelCompleteT UnPack()
		{
			ICheckEncircleLevelCompleteT checkEncircleLevelCompleteT = new ICheckEncircleLevelCompleteT();
			this.UnPackTo(checkEncircleLevelCompleteT);
			return checkEncircleLevelCompleteT;
		}

		// Token: 0x0601D902 RID: 121090 RVA: 0x004294E3 File Offset: 0x004276E3
		public void UnPackTo(ICheckEncircleLevelCompleteT _o)
		{
			_o.Type = this.Type;
			_o.EncircleLevelId = this.EncircleLevelId;
			_o.IsCompleted = this.IsCompleted;
		}

		// Token: 0x0601D903 RID: 121091 RVA: 0x0042950C File Offset: 0x0042770C
		public static Offset<ICheckEncircleLevelComplete> Pack(FlatBufferBuilder builder, ICheckEncircleLevelCompleteT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckEncircleLevelComplete>);
			}
			return ICheckEncircleLevelComplete.CreateICheckEncircleLevelComplete(builder, _o.Type, _o.EncircleLevelId, _o.IsCompleted);
		}

		// Token: 0x0400D21A RID: 53786
		private Table __p;
	}
}

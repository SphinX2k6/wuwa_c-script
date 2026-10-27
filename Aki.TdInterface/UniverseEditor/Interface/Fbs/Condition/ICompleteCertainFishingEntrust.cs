using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BD4 RID: 19412
	public struct ICompleteCertainFishingEntrust : IFlatbufferObject
	{
		// Token: 0x17008D09 RID: 36105
		// (get) Token: 0x0601EA6B RID: 125547 RVA: 0x00449788 File Offset: 0x00447988
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EA6C RID: 125548 RVA: 0x00449795 File Offset: 0x00447995
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EA6D RID: 125549 RVA: 0x0044979C File Offset: 0x0044799C
		public static ICompleteCertainFishingEntrust GetRootAsICompleteCertainFishingEntrust(ByteBuffer _bb)
		{
			return ICompleteCertainFishingEntrust.GetRootAsICompleteCertainFishingEntrust(_bb, default(ICompleteCertainFishingEntrust));
		}

		// Token: 0x0601EA6E RID: 125550 RVA: 0x004497B8 File Offset: 0x004479B8
		public static ICompleteCertainFishingEntrust GetRootAsICompleteCertainFishingEntrust(ByteBuffer _bb, ICompleteCertainFishingEntrust obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EA6F RID: 125551 RVA: 0x004497D5 File Offset: 0x004479D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EA70 RID: 125552 RVA: 0x004497E4 File Offset: 0x004479E4
		public ICompleteCertainFishingEntrust __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D0A RID: 36106
		// (get) Token: 0x0601EA71 RID: 125553 RVA: 0x004497F4 File Offset: 0x004479F4
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

		// Token: 0x17008D0B RID: 36107
		// (get) Token: 0x0601EA72 RID: 125554 RVA: 0x00449830 File Offset: 0x00447A30
		public int Id
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

		// Token: 0x17008D0C RID: 36108
		// (get) Token: 0x0601EA73 RID: 125555 RVA: 0x0044986C File Offset: 0x00447A6C
		public int Count
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

		// Token: 0x0601EA74 RID: 125556 RVA: 0x004498A8 File Offset: 0x00447AA8
		public static Offset<ICompleteCertainFishingEntrust> CreateICompleteCertainFishingEntrust(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int Id = 0, int Count = 0)
		{
			builder.StartTable(3);
			ICompleteCertainFishingEntrust.AddCount(builder, Count);
			ICompleteCertainFishingEntrust.AddId(builder, Id);
			ICompleteCertainFishingEntrust.AddType(builder, Type);
			return ICompleteCertainFishingEntrust.EndICompleteCertainFishingEntrust(builder);
		}

		// Token: 0x0601EA75 RID: 125557 RVA: 0x004498CC File Offset: 0x00447ACC
		public static void StartICompleteCertainFishingEntrust(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601EA76 RID: 125558 RVA: 0x004498D5 File Offset: 0x00447AD5
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EA77 RID: 125559 RVA: 0x004498E0 File Offset: 0x00447AE0
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0601EA78 RID: 125560 RVA: 0x004498EB File Offset: 0x00447AEB
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(2, count, 0);
		}

		// Token: 0x0601EA79 RID: 125561 RVA: 0x004498F6 File Offset: 0x00447AF6
		public static Offset<ICompleteCertainFishingEntrust> EndICompleteCertainFishingEntrust(FlatBufferBuilder builder)
		{
			return new Offset<ICompleteCertainFishingEntrust>(builder.EndTable());
		}

		// Token: 0x0601EA7A RID: 125562 RVA: 0x00449904 File Offset: 0x00447B04
		public ICompleteCertainFishingEntrustT UnPack()
		{
			ICompleteCertainFishingEntrustT completeCertainFishingEntrustT = new ICompleteCertainFishingEntrustT();
			this.UnPackTo(completeCertainFishingEntrustT);
			return completeCertainFishingEntrustT;
		}

		// Token: 0x0601EA7B RID: 125563 RVA: 0x0044991F File Offset: 0x00447B1F
		public void UnPackTo(ICompleteCertainFishingEntrustT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Count = this.Count;
		}

		// Token: 0x0601EA7C RID: 125564 RVA: 0x00449948 File Offset: 0x00447B48
		public static Offset<ICompleteCertainFishingEntrust> Pack(FlatBufferBuilder builder, ICompleteCertainFishingEntrustT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompleteCertainFishingEntrust>);
			}
			return ICompleteCertainFishingEntrust.CreateICompleteCertainFishingEntrust(builder, _o.Type, _o.Id, _o.Count);
		}

		// Token: 0x0400D4C8 RID: 54472
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004592 RID: 17810
	public struct ISunSpiritProcess : IFlatbufferObject
	{
		// Token: 0x17007C8C RID: 31884
		// (get) Token: 0x06019F94 RID: 106388 RVA: 0x003B452D File Offset: 0x003B272D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019F95 RID: 106389 RVA: 0x003B453A File Offset: 0x003B273A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019F96 RID: 106390 RVA: 0x003B4544 File Offset: 0x003B2744
		public static ISunSpiritProcess GetRootAsISunSpiritProcess(ByteBuffer _bb)
		{
			return ISunSpiritProcess.GetRootAsISunSpiritProcess(_bb, default(ISunSpiritProcess));
		}

		// Token: 0x06019F97 RID: 106391 RVA: 0x003B4560 File Offset: 0x003B2760
		public static ISunSpiritProcess GetRootAsISunSpiritProcess(ByteBuffer _bb, ISunSpiritProcess obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019F98 RID: 106392 RVA: 0x003B457D File Offset: 0x003B277D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019F99 RID: 106393 RVA: 0x003B458C File Offset: 0x003B278C
		public ISunSpiritProcess __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C8D RID: 31885
		// (get) Token: 0x06019F9A RID: 106394 RVA: 0x003B459C File Offset: 0x003B279C
		public int LauncherId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007C8E RID: 31886
		// (get) Token: 0x06019F9B RID: 106395 RVA: 0x003B45D8 File Offset: 0x003B27D8
		public bool IsRecycle
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007C8F RID: 31887
		// (get) Token: 0x06019F9C RID: 106396 RVA: 0x003B4618 File Offset: 0x003B2818
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019F9D RID: 106397 RVA: 0x003B4654 File Offset: 0x003B2854
		public static Offset<ISunSpiritProcess> CreateISunSpiritProcess(FlatBufferBuilder builder, int LauncherId = 0, bool IsRecycle = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			ISunSpiritProcess.AddLauncherId(builder, LauncherId);
			ISunSpiritProcess.AddNullMask(builder, NullMask);
			ISunSpiritProcess.AddIsRecycle(builder, IsRecycle);
			return ISunSpiritProcess.EndISunSpiritProcess(builder);
		}

		// Token: 0x06019F9E RID: 106398 RVA: 0x003B4678 File Offset: 0x003B2878
		public static void StartISunSpiritProcess(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06019F9F RID: 106399 RVA: 0x003B4681 File Offset: 0x003B2881
		public static void AddLauncherId(FlatBufferBuilder builder, int launcherId)
		{
			builder.AddInt(0, launcherId, 0);
		}

		// Token: 0x06019FA0 RID: 106400 RVA: 0x003B468C File Offset: 0x003B288C
		public static void AddIsRecycle(FlatBufferBuilder builder, bool isRecycle)
		{
			builder.AddBool(1, isRecycle, false);
		}

		// Token: 0x06019FA1 RID: 106401 RVA: 0x003B4697 File Offset: 0x003B2897
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06019FA2 RID: 106402 RVA: 0x003B46A2 File Offset: 0x003B28A2
		public static Offset<ISunSpiritProcess> EndISunSpiritProcess(FlatBufferBuilder builder)
		{
			return new Offset<ISunSpiritProcess>(builder.EndTable());
		}

		// Token: 0x06019FA3 RID: 106403 RVA: 0x003B46B0 File Offset: 0x003B28B0
		public ISunSpiritProcessT UnPack()
		{
			ISunSpiritProcessT sunSpiritProcessT = new ISunSpiritProcessT();
			this.UnPackTo(sunSpiritProcessT);
			return sunSpiritProcessT;
		}

		// Token: 0x06019FA4 RID: 106404 RVA: 0x003B46CB File Offset: 0x003B28CB
		public void UnPackTo(ISunSpiritProcessT _o)
		{
			_o.LauncherId = this.LauncherId;
			_o.IsRecycle = this.IsRecycle;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06019FA5 RID: 106405 RVA: 0x003B46F4 File Offset: 0x003B28F4
		public static Offset<ISunSpiritProcess> Pack(FlatBufferBuilder builder, ISunSpiritProcessT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISunSpiritProcess>);
			}
			return ISunSpiritProcess.CreateISunSpiritProcess(builder, _o.LauncherId, _o.IsRecycle, _o.NullMask);
		}

		// Token: 0x0400C755 RID: 51029
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055F9 RID: 22009
	public struct INextSlideRail : IFlatbufferObject
	{
		// Token: 0x1700A2D9 RID: 41689
		// (get) Token: 0x06024841 RID: 149569 RVA: 0x0050A30C File Offset: 0x0050850C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024842 RID: 149570 RVA: 0x0050A319 File Offset: 0x00508519
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024843 RID: 149571 RVA: 0x0050A320 File Offset: 0x00508520
		public static INextSlideRail GetRootAsINextSlideRail(ByteBuffer _bb)
		{
			return INextSlideRail.GetRootAsINextSlideRail(_bb, default(INextSlideRail));
		}

		// Token: 0x06024844 RID: 149572 RVA: 0x0050A33C File Offset: 0x0050853C
		public static INextSlideRail GetRootAsINextSlideRail(ByteBuffer _bb, INextSlideRail obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024845 RID: 149573 RVA: 0x0050A359 File Offset: 0x00508559
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024846 RID: 149574 RVA: 0x0050A368 File Offset: 0x00508568
		public INextSlideRail __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A2DA RID: 41690
		// (get) Token: 0x06024847 RID: 149575 RVA: 0x0050A378 File Offset: 0x00508578
		public ETriggerKey TriggerKey
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETriggerKey.Left;
				}
				return (ETriggerKey)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A2DB RID: 41691
		// (get) Token: 0x06024848 RID: 149576 RVA: 0x0050A3B4 File Offset: 0x005085B4
		public int TargetRailEntityId
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

		// Token: 0x1700A2DC RID: 41692
		// (get) Token: 0x06024849 RID: 149577 RVA: 0x0050A3F0 File Offset: 0x005085F0
		public bool IsFallbackRail
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A2DD RID: 41693
		// (get) Token: 0x0602484A RID: 149578 RVA: 0x0050A430 File Offset: 0x00508630
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602484B RID: 149579 RVA: 0x0050A46D File Offset: 0x0050866D
		public static Offset<INextSlideRail> CreateINextSlideRail(FlatBufferBuilder builder, ETriggerKey TriggerKey = ETriggerKey.Left, int TargetRailEntityId = 0, bool IsFallbackRail = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			INextSlideRail.AddTargetRailEntityId(builder, TargetRailEntityId);
			INextSlideRail.AddNullMask(builder, NullMask);
			INextSlideRail.AddIsFallbackRail(builder, IsFallbackRail);
			INextSlideRail.AddTriggerKey(builder, TriggerKey);
			return INextSlideRail.EndINextSlideRail(builder);
		}

		// Token: 0x0602484C RID: 149580 RVA: 0x0050A499 File Offset: 0x00508699
		public static void StartINextSlideRail(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602484D RID: 149581 RVA: 0x0050A4A2 File Offset: 0x005086A2
		public static void AddTriggerKey(FlatBufferBuilder builder, ETriggerKey triggerKey)
		{
			builder.AddByte(0, (byte)triggerKey, 0);
		}

		// Token: 0x0602484E RID: 149582 RVA: 0x0050A4AD File Offset: 0x005086AD
		public static void AddTargetRailEntityId(FlatBufferBuilder builder, int targetRailEntityId)
		{
			builder.AddInt(1, targetRailEntityId, 0);
		}

		// Token: 0x0602484F RID: 149583 RVA: 0x0050A4B8 File Offset: 0x005086B8
		public static void AddIsFallbackRail(FlatBufferBuilder builder, bool isFallbackRail)
		{
			builder.AddBool(2, isFallbackRail, false);
		}

		// Token: 0x06024850 RID: 149584 RVA: 0x0050A4C3 File Offset: 0x005086C3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06024851 RID: 149585 RVA: 0x0050A4CE File Offset: 0x005086CE
		public static Offset<INextSlideRail> EndINextSlideRail(FlatBufferBuilder builder)
		{
			return new Offset<INextSlideRail>(builder.EndTable());
		}

		// Token: 0x06024852 RID: 149586 RVA: 0x0050A4DC File Offset: 0x005086DC
		public INextSlideRailT UnPack()
		{
			INextSlideRailT nextSlideRailT = new INextSlideRailT();
			this.UnPackTo(nextSlideRailT);
			return nextSlideRailT;
		}

		// Token: 0x06024853 RID: 149587 RVA: 0x0050A4F7 File Offset: 0x005086F7
		public void UnPackTo(INextSlideRailT _o)
		{
			_o.TriggerKey = this.TriggerKey;
			_o.TargetRailEntityId = this.TargetRailEntityId;
			_o.IsFallbackRail = this.IsFallbackRail;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024854 RID: 149588 RVA: 0x0050A52C File Offset: 0x0050872C
		public static Offset<INextSlideRail> Pack(FlatBufferBuilder builder, INextSlideRailT _o)
		{
			if (_o == null)
			{
				return default(Offset<INextSlideRail>);
			}
			return INextSlideRail.CreateINextSlideRail(builder, _o.TriggerKey, _o.TargetRailEntityId, _o.IsFallbackRail, _o.NullMask);
		}

		// Token: 0x0400E96F RID: 59759
		private Table __p;
	}
}

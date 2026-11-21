using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200537C RID: 21372
	public struct IAdviseItemComponent : IFlatbufferObject
	{
		// Token: 0x170096ED RID: 38637
		// (get) Token: 0x060214B3 RID: 136371 RVA: 0x0049808F File Offset: 0x0049628F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060214B4 RID: 136372 RVA: 0x0049809C File Offset: 0x0049629C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060214B5 RID: 136373 RVA: 0x004980A4 File Offset: 0x004962A4
		public static IAdviseItemComponent GetRootAsIAdviseItemComponent(ByteBuffer _bb)
		{
			return IAdviseItemComponent.GetRootAsIAdviseItemComponent(_bb, default(IAdviseItemComponent));
		}

		// Token: 0x060214B6 RID: 136374 RVA: 0x004980C0 File Offset: 0x004962C0
		public static IAdviseItemComponent GetRootAsIAdviseItemComponent(ByteBuffer _bb, IAdviseItemComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060214B7 RID: 136375 RVA: 0x004980DD File Offset: 0x004962DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060214B8 RID: 136376 RVA: 0x004980EC File Offset: 0x004962EC
		public IAdviseItemComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170096EE RID: 38638
		// (get) Token: 0x060214B9 RID: 136377 RVA: 0x004980FC File Offset: 0x004962FC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170096EF RID: 38639
		// (get) Token: 0x060214BA RID: 136378 RVA: 0x0049813C File Offset: 0x0049633C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060214BB RID: 136379 RVA: 0x00498178 File Offset: 0x00496378
		public static Offset<IAdviseItemComponent> CreateIAdviseItemComponent(FlatBufferBuilder builder, bool Disabled = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IAdviseItemComponent.AddNullMask(builder, NullMask);
			IAdviseItemComponent.AddDisabled(builder, Disabled);
			return IAdviseItemComponent.EndIAdviseItemComponent(builder);
		}

		// Token: 0x060214BC RID: 136380 RVA: 0x00498195 File Offset: 0x00496395
		public static void StartIAdviseItemComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060214BD RID: 136381 RVA: 0x0049819E File Offset: 0x0049639E
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060214BE RID: 136382 RVA: 0x004981A9 File Offset: 0x004963A9
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x060214BF RID: 136383 RVA: 0x004981B4 File Offset: 0x004963B4
		public static Offset<IAdviseItemComponent> EndIAdviseItemComponent(FlatBufferBuilder builder)
		{
			return new Offset<IAdviseItemComponent>(builder.EndTable());
		}

		// Token: 0x060214C0 RID: 136384 RVA: 0x004981C4 File Offset: 0x004963C4
		public IAdviseItemComponentT UnPack()
		{
			IAdviseItemComponentT adviseItemComponentT = new IAdviseItemComponentT();
			this.UnPackTo(adviseItemComponentT);
			return adviseItemComponentT;
		}

		// Token: 0x060214C1 RID: 136385 RVA: 0x004981DF File Offset: 0x004963DF
		public void UnPackTo(IAdviseItemComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060214C2 RID: 136386 RVA: 0x004981FC File Offset: 0x004963FC
		public static Offset<IAdviseItemComponent> Pack(FlatBufferBuilder builder, IAdviseItemComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAdviseItemComponent>);
			}
			return IAdviseItemComponent.CreateIAdviseItemComponent(builder, _o.Disabled, _o.NullMask);
		}

		// Token: 0x0400E78E RID: 59278
		private Table __p;
	}
}

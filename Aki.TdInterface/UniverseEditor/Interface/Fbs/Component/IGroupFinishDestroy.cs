using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058D9 RID: 22745
	public struct IGroupFinishDestroy : IFlatbufferObject
	{
		// Token: 0x1700A4EF RID: 42223
		// (get) Token: 0x06024EFA RID: 151290 RVA: 0x00512360 File Offset: 0x00510560
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024EFB RID: 151291 RVA: 0x0051236D File Offset: 0x0051056D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024EFC RID: 151292 RVA: 0x00512374 File Offset: 0x00510574
		public static IGroupFinishDestroy GetRootAsIGroupFinishDestroy(ByteBuffer _bb)
		{
			return IGroupFinishDestroy.GetRootAsIGroupFinishDestroy(_bb, default(IGroupFinishDestroy));
		}

		// Token: 0x06024EFD RID: 151293 RVA: 0x00512390 File Offset: 0x00510590
		public static IGroupFinishDestroy GetRootAsIGroupFinishDestroy(ByteBuffer _bb, IGroupFinishDestroy obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024EFE RID: 151294 RVA: 0x005123AD File Offset: 0x005105AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024EFF RID: 151295 RVA: 0x005123BC File Offset: 0x005105BC
		public IGroupFinishDestroy __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A4F0 RID: 42224
		// (get) Token: 0x06024F00 RID: 151296 RVA: 0x005123CC File Offset: 0x005105CC
		public EGroupFinishConfig Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGroupFinishConfig.Silence;
				}
				return (EGroupFinishConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A4F1 RID: 42225
		// (get) Token: 0x06024F01 RID: 151297 RVA: 0x00512408 File Offset: 0x00510608
		public IEntityState? SwitchSpecifiedStatus
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IEntityState?(default(IEntityState).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06024F02 RID: 151298 RVA: 0x00512465 File Offset: 0x00510665
		public static Offset<IGroupFinishDestroy> CreateIGroupFinishDestroy(FlatBufferBuilder builder, EGroupFinishConfig Type = EGroupFinishConfig.Silence, Offset<IEntityState> SwitchSpecifiedStatusOffset = default(Offset<IEntityState>))
		{
			builder.StartTable(2);
			IGroupFinishDestroy.AddSwitchSpecifiedStatus(builder, SwitchSpecifiedStatusOffset);
			IGroupFinishDestroy.AddType(builder, Type);
			return IGroupFinishDestroy.EndIGroupFinishDestroy(builder);
		}

		// Token: 0x06024F03 RID: 151299 RVA: 0x00512482 File Offset: 0x00510682
		public static void StartIGroupFinishDestroy(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06024F04 RID: 151300 RVA: 0x0051248B File Offset: 0x0051068B
		public static void AddType(FlatBufferBuilder builder, EGroupFinishConfig type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024F05 RID: 151301 RVA: 0x00512496 File Offset: 0x00510696
		public static void AddSwitchSpecifiedStatus(FlatBufferBuilder builder, Offset<IEntityState> switchSpecifiedStatusOffset)
		{
			builder.AddOffset(1, switchSpecifiedStatusOffset.Value, 0);
		}

		// Token: 0x06024F06 RID: 151302 RVA: 0x005124A6 File Offset: 0x005106A6
		public static Offset<IGroupFinishDestroy> EndIGroupFinishDestroy(FlatBufferBuilder builder)
		{
			return new Offset<IGroupFinishDestroy>(builder.EndTable());
		}

		// Token: 0x06024F07 RID: 151303 RVA: 0x005124B4 File Offset: 0x005106B4
		public IGroupFinishDestroyT UnPack()
		{
			IGroupFinishDestroyT groupFinishDestroyT = new IGroupFinishDestroyT();
			this.UnPackTo(groupFinishDestroyT);
			return groupFinishDestroyT;
		}

		// Token: 0x06024F08 RID: 151304 RVA: 0x005124D0 File Offset: 0x005106D0
		public void UnPackTo(IGroupFinishDestroyT _o)
		{
			_o.Type = this.Type;
			_o.SwitchSpecifiedStatus = ((this.SwitchSpecifiedStatus != null) ? this.SwitchSpecifiedStatus.Value.UnPack() : null);
		}

		// Token: 0x06024F09 RID: 151305 RVA: 0x00512518 File Offset: 0x00510718
		public static Offset<IGroupFinishDestroy> Pack(FlatBufferBuilder builder, IGroupFinishDestroyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGroupFinishDestroy>);
			}
			Offset<IEntityState> switchSpecifiedStatusOffset = (_o.SwitchSpecifiedStatus == null) ? default(Offset<IEntityState>) : IEntityState.Pack(builder, _o.SwitchSpecifiedStatus);
			return IGroupFinishDestroy.CreateIGroupFinishDestroy(builder, _o.Type, switchSpecifiedStatusOffset);
		}

		// Token: 0x0400F15A RID: 61786
		private Table __p;
	}
}

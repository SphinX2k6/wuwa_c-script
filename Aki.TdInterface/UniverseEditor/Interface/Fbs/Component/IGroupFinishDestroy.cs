using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005353 RID: 21331
	public struct IGroupFinishDestroy : IFlatbufferObject
	{
		// Token: 0x17009CB7 RID: 40119
		// (get) Token: 0x06022E46 RID: 142918 RVA: 0x004D548C File Offset: 0x004D368C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022E47 RID: 142919 RVA: 0x004D5499 File Offset: 0x004D3699
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022E48 RID: 142920 RVA: 0x004D54A0 File Offset: 0x004D36A0
		public static IGroupFinishDestroy GetRootAsIGroupFinishDestroy(ByteBuffer _bb)
		{
			return IGroupFinishDestroy.GetRootAsIGroupFinishDestroy(_bb, default(IGroupFinishDestroy));
		}

		// Token: 0x06022E49 RID: 142921 RVA: 0x004D54BC File Offset: 0x004D36BC
		public static IGroupFinishDestroy GetRootAsIGroupFinishDestroy(ByteBuffer _bb, IGroupFinishDestroy obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022E4A RID: 142922 RVA: 0x004D54D9 File Offset: 0x004D36D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022E4B RID: 142923 RVA: 0x004D54E8 File Offset: 0x004D36E8
		public IGroupFinishDestroy __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009CB8 RID: 40120
		// (get) Token: 0x06022E4C RID: 142924 RVA: 0x004D54F8 File Offset: 0x004D36F8
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

		// Token: 0x17009CB9 RID: 40121
		// (get) Token: 0x06022E4D RID: 142925 RVA: 0x004D5534 File Offset: 0x004D3734
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

		// Token: 0x06022E4E RID: 142926 RVA: 0x004D5591 File Offset: 0x004D3791
		public static Offset<IGroupFinishDestroy> CreateIGroupFinishDestroy(FlatBufferBuilder builder, EGroupFinishConfig Type = EGroupFinishConfig.Silence, Offset<IEntityState> SwitchSpecifiedStatusOffset = default(Offset<IEntityState>))
		{
			builder.StartTable(2);
			IGroupFinishDestroy.AddSwitchSpecifiedStatus(builder, SwitchSpecifiedStatusOffset);
			IGroupFinishDestroy.AddType(builder, Type);
			return IGroupFinishDestroy.EndIGroupFinishDestroy(builder);
		}

		// Token: 0x06022E4F RID: 142927 RVA: 0x004D55AE File Offset: 0x004D37AE
		public static void StartIGroupFinishDestroy(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06022E50 RID: 142928 RVA: 0x004D55B7 File Offset: 0x004D37B7
		public static void AddType(FlatBufferBuilder builder, EGroupFinishConfig type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022E51 RID: 142929 RVA: 0x004D55C2 File Offset: 0x004D37C2
		public static void AddSwitchSpecifiedStatus(FlatBufferBuilder builder, Offset<IEntityState> switchSpecifiedStatusOffset)
		{
			builder.AddOffset(1, switchSpecifiedStatusOffset.Value, 0);
		}

		// Token: 0x06022E52 RID: 142930 RVA: 0x004D55D2 File Offset: 0x004D37D2
		public static Offset<IGroupFinishDestroy> EndIGroupFinishDestroy(FlatBufferBuilder builder)
		{
			return new Offset<IGroupFinishDestroy>(builder.EndTable());
		}

		// Token: 0x06022E53 RID: 142931 RVA: 0x004D55E0 File Offset: 0x004D37E0
		public IGroupFinishDestroyT UnPack()
		{
			IGroupFinishDestroyT groupFinishDestroyT = new IGroupFinishDestroyT();
			this.UnPackTo(groupFinishDestroyT);
			return groupFinishDestroyT;
		}

		// Token: 0x06022E54 RID: 142932 RVA: 0x004D55FC File Offset: 0x004D37FC
		public void UnPackTo(IGroupFinishDestroyT _o)
		{
			_o.Type = this.Type;
			_o.SwitchSpecifiedStatus = ((this.SwitchSpecifiedStatus != null) ? this.SwitchSpecifiedStatus.Value.UnPack() : null);
		}

		// Token: 0x06022E55 RID: 142933 RVA: 0x004D5644 File Offset: 0x004D3844
		public static Offset<IGroupFinishDestroy> Pack(FlatBufferBuilder builder, IGroupFinishDestroyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGroupFinishDestroy>);
			}
			Offset<IEntityState> switchSpecifiedStatusOffset = (_o.SwitchSpecifiedStatus == null) ? default(Offset<IEntityState>) : IEntityState.Pack(builder, _o.SwitchSpecifiedStatus);
			return IGroupFinishDestroy.CreateIGroupFinishDestroy(builder, _o.Type, switchSpecifiedStatusOffset);
		}

		// Token: 0x0400E52A RID: 58666
		private Table __p;
	}
}

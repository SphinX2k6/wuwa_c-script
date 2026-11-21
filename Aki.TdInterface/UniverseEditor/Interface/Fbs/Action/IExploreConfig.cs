using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DBE RID: 28094
	public struct IExploreConfig : IFlatbufferObject
	{
		// Token: 0x1700CDF4 RID: 52724
		// (get) Token: 0x060307D5 RID: 198613 RVA: 0x006960E4 File Offset: 0x006942E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060307D6 RID: 198614 RVA: 0x006960F1 File Offset: 0x006942F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060307D7 RID: 198615 RVA: 0x006960F8 File Offset: 0x006942F8
		public static IExploreConfig GetRootAsIExploreConfig(ByteBuffer _bb)
		{
			return IExploreConfig.GetRootAsIExploreConfig(_bb, default(IExploreConfig));
		}

		// Token: 0x060307D8 RID: 198616 RVA: 0x00696114 File Offset: 0x00694314
		public static IExploreConfig GetRootAsIExploreConfig(ByteBuffer _bb, IExploreConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060307D9 RID: 198617 RVA: 0x00696131 File Offset: 0x00694331
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060307DA RID: 198618 RVA: 0x00696140 File Offset: 0x00694340
		public IExploreConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDF5 RID: 52725
		// (get) Token: 0x060307DB RID: 198619 RVA: 0x00696150 File Offset: 0x00694350
		public EExploreStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExploreStateType.TeleControl;
				}
				return (EExploreStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060307DC RID: 198620 RVA: 0x0069618C File Offset: 0x0069438C
		public static Offset<IExploreConfig> CreateIExploreConfig(FlatBufferBuilder builder, EExploreStateType Type = EExploreStateType.TeleControl)
		{
			builder.StartTable(1);
			IExploreConfig.AddType(builder, Type);
			return IExploreConfig.EndIExploreConfig(builder);
		}

		// Token: 0x060307DD RID: 198621 RVA: 0x006961A2 File Offset: 0x006943A2
		public static void StartIExploreConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060307DE RID: 198622 RVA: 0x006961AB File Offset: 0x006943AB
		public static void AddType(FlatBufferBuilder builder, EExploreStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060307DF RID: 198623 RVA: 0x006961B6 File Offset: 0x006943B6
		public static Offset<IExploreConfig> EndIExploreConfig(FlatBufferBuilder builder)
		{
			return new Offset<IExploreConfig>(builder.EndTable());
		}

		// Token: 0x060307E0 RID: 198624 RVA: 0x006961C4 File Offset: 0x006943C4
		public IExploreConfigT UnPack()
		{
			IExploreConfigT exploreConfigT = new IExploreConfigT();
			this.UnPackTo(exploreConfigT);
			return exploreConfigT;
		}

		// Token: 0x060307E1 RID: 198625 RVA: 0x006961DF File Offset: 0x006943DF
		public void UnPackTo(IExploreConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060307E2 RID: 198626 RVA: 0x006961F0 File Offset: 0x006943F0
		public static Offset<IExploreConfig> Pack(FlatBufferBuilder builder, IExploreConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExploreConfig>);
			}
			return IExploreConfig.CreateIExploreConfig(builder, _o.Type);
		}

		// Token: 0x04011C58 RID: 72792
		private Table __p;
	}
}

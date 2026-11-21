using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067F3 RID: 26611
	public struct IAlertSystemOption : IFlatbufferObject
	{
		// Token: 0x1700C3A7 RID: 50087
		// (get) Token: 0x0602D74D RID: 186189 RVA: 0x0063961E File Offset: 0x0063781E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D74E RID: 186190 RVA: 0x0063962B File Offset: 0x0063782B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D74F RID: 186191 RVA: 0x00639634 File Offset: 0x00637834
		public static IAlertSystemOption GetRootAsIAlertSystemOption(ByteBuffer _bb)
		{
			return IAlertSystemOption.GetRootAsIAlertSystemOption(_bb, default(IAlertSystemOption));
		}

		// Token: 0x0602D750 RID: 186192 RVA: 0x00639650 File Offset: 0x00637850
		public static IAlertSystemOption GetRootAsIAlertSystemOption(ByteBuffer _bb, IAlertSystemOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D751 RID: 186193 RVA: 0x0063966D File Offset: 0x0063786D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D752 RID: 186194 RVA: 0x0063967C File Offset: 0x0063787C
		public IAlertSystemOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C3A8 RID: 50088
		// (get) Token: 0x0602D753 RID: 186195 RVA: 0x0063968C File Offset: 0x0063788C
		public EAlertSystemOption Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAlertSystemOption.EnableAlertArea;
				}
				return (EAlertSystemOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C3A9 RID: 50089
		// (get) Token: 0x0602D754 RID: 186196 RVA: 0x006396C8 File Offset: 0x006378C8
		public int AreaId
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

		// Token: 0x0602D755 RID: 186197 RVA: 0x00639704 File Offset: 0x00637904
		public static Offset<IAlertSystemOption> CreateIAlertSystemOption(FlatBufferBuilder builder, EAlertSystemOption Type = EAlertSystemOption.EnableAlertArea, int AreaId = 0)
		{
			builder.StartTable(2);
			IAlertSystemOption.AddAreaId(builder, AreaId);
			IAlertSystemOption.AddType(builder, Type);
			return IAlertSystemOption.EndIAlertSystemOption(builder);
		}

		// Token: 0x0602D756 RID: 186198 RVA: 0x00639721 File Offset: 0x00637921
		public static void StartIAlertSystemOption(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D757 RID: 186199 RVA: 0x0063972A File Offset: 0x0063792A
		public static void AddType(FlatBufferBuilder builder, EAlertSystemOption type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D758 RID: 186200 RVA: 0x00639735 File Offset: 0x00637935
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(1, areaId, 0);
		}

		// Token: 0x0602D759 RID: 186201 RVA: 0x00639740 File Offset: 0x00637940
		public static Offset<IAlertSystemOption> EndIAlertSystemOption(FlatBufferBuilder builder)
		{
			return new Offset<IAlertSystemOption>(builder.EndTable());
		}

		// Token: 0x0602D75A RID: 186202 RVA: 0x00639750 File Offset: 0x00637950
		public IAlertSystemOptionT UnPack()
		{
			IAlertSystemOptionT alertSystemOptionT = new IAlertSystemOptionT();
			this.UnPackTo(alertSystemOptionT);
			return alertSystemOptionT;
		}

		// Token: 0x0602D75B RID: 186203 RVA: 0x0063976B File Offset: 0x0063796B
		public void UnPackTo(IAlertSystemOptionT _o)
		{
			_o.Type = this.Type;
			_o.AreaId = this.AreaId;
		}

		// Token: 0x0602D75C RID: 186204 RVA: 0x00639788 File Offset: 0x00637988
		public static Offset<IAlertSystemOption> Pack(FlatBufferBuilder builder, IAlertSystemOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAlertSystemOption>);
			}
			return IAlertSystemOption.CreateIAlertSystemOption(builder, _o.Type, _o.AreaId);
		}

		// Token: 0x0401149D RID: 70813
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E6B RID: 20075
	public struct IAdviseItemComponent : IFlatbufferObject
	{
		// Token: 0x17008FB4 RID: 36788
		// (get) Token: 0x0601F868 RID: 129128 RVA: 0x00464077 File Offset: 0x00462277
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F869 RID: 129129 RVA: 0x00464084 File Offset: 0x00462284
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F86A RID: 129130 RVA: 0x0046408C File Offset: 0x0046228C
		public static IAdviseItemComponent GetRootAsIAdviseItemComponent(ByteBuffer _bb)
		{
			return IAdviseItemComponent.GetRootAsIAdviseItemComponent(_bb, default(IAdviseItemComponent));
		}

		// Token: 0x0601F86B RID: 129131 RVA: 0x004640A8 File Offset: 0x004622A8
		public static IAdviseItemComponent GetRootAsIAdviseItemComponent(ByteBuffer _bb, IAdviseItemComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F86C RID: 129132 RVA: 0x004640C5 File Offset: 0x004622C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F86D RID: 129133 RVA: 0x004640D4 File Offset: 0x004622D4
		public IAdviseItemComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008FB5 RID: 36789
		// (get) Token: 0x0601F86E RID: 129134 RVA: 0x004640E4 File Offset: 0x004622E4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008FB6 RID: 36790
		// (get) Token: 0x0601F86F RID: 129135 RVA: 0x00464124 File Offset: 0x00462324
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

		// Token: 0x0601F870 RID: 129136 RVA: 0x00464160 File Offset: 0x00462360
		public static Offset<IAdviseItemComponent> CreateIAdviseItemComponent(FlatBufferBuilder builder, bool Disabled = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IAdviseItemComponent.AddNullMask(builder, NullMask);
			IAdviseItemComponent.AddDisabled(builder, Disabled);
			return IAdviseItemComponent.EndIAdviseItemComponent(builder);
		}

		// Token: 0x0601F871 RID: 129137 RVA: 0x0046417D File Offset: 0x0046237D
		public static void StartIAdviseItemComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F872 RID: 129138 RVA: 0x00464186 File Offset: 0x00462386
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0601F873 RID: 129139 RVA: 0x00464191 File Offset: 0x00462391
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x0601F874 RID: 129140 RVA: 0x0046419C File Offset: 0x0046239C
		public static Offset<IAdviseItemComponent> EndIAdviseItemComponent(FlatBufferBuilder builder)
		{
			return new Offset<IAdviseItemComponent>(builder.EndTable());
		}

		// Token: 0x0601F875 RID: 129141 RVA: 0x004641AC File Offset: 0x004623AC
		public IAdviseItemComponentT UnPack()
		{
			IAdviseItemComponentT adviseItemComponentT = new IAdviseItemComponentT();
			this.UnPackTo(adviseItemComponentT);
			return adviseItemComponentT;
		}

		// Token: 0x0601F876 RID: 129142 RVA: 0x004641C7 File Offset: 0x004623C7
		public void UnPackTo(IAdviseItemComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601F877 RID: 129143 RVA: 0x004641E4 File Offset: 0x004623E4
		public static Offset<IAdviseItemComponent> Pack(FlatBufferBuilder builder, IAdviseItemComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAdviseItemComponent>);
			}
			return IAdviseItemComponent.CreateIAdviseItemComponent(builder, _o.Disabled, _o.NullMask);
		}

		// Token: 0x0400DC14 RID: 56340
		private Table __p;
	}
}

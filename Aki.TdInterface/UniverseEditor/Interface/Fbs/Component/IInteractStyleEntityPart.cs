using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200547C RID: 21628
	public struct IInteractStyleEntityPart : IFlatbufferObject
	{
		// Token: 0x17009F2B RID: 40747
		// (get) Token: 0x06023935 RID: 145717 RVA: 0x004EB5B0 File Offset: 0x004E97B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023936 RID: 145718 RVA: 0x004EB5BD File Offset: 0x004E97BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023937 RID: 145719 RVA: 0x004EB5C4 File Offset: 0x004E97C4
		public static IInteractStyleEntityPart GetRootAsIInteractStyleEntityPart(ByteBuffer _bb)
		{
			return IInteractStyleEntityPart.GetRootAsIInteractStyleEntityPart(_bb, default(IInteractStyleEntityPart));
		}

		// Token: 0x06023938 RID: 145720 RVA: 0x004EB5E0 File Offset: 0x004E97E0
		public static IInteractStyleEntityPart GetRootAsIInteractStyleEntityPart(ByteBuffer _bb, IInteractStyleEntityPart obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023939 RID: 145721 RVA: 0x004EB5FD File Offset: 0x004E97FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602393A RID: 145722 RVA: 0x004EB60C File Offset: 0x004E980C
		public IInteractStyleEntityPart __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F2C RID: 40748
		// (get) Token: 0x0602393B RID: 145723 RVA: 0x004EB61C File Offset: 0x004E981C
		public EInteractStyleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractStyleType.Panorama;
				}
				return (EInteractStyleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009F2D RID: 40749
		// (get) Token: 0x0602393C RID: 145724 RVA: 0x004EB658 File Offset: 0x004E9858
		public TInteractEntityPartBind BindType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TInteractEntityPartBind.NONE;
				}
				return (TInteractEntityPartBind)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602393D RID: 145725 RVA: 0x004EB694 File Offset: 0x004E9894
		public TTable? Bind<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602393E RID: 145726 RVA: 0x004EB6D8 File Offset: 0x004E98D8
		public IInteractEntityPartModelBind BindAsIInteractEntityPartModelBind()
		{
			return this.Bind<IInteractEntityPartModelBind>().Value;
		}

		// Token: 0x0602393F RID: 145727 RVA: 0x004EB6F4 File Offset: 0x004E98F4
		public IInteractEntityPartPrefabBind BindAsIInteractEntityPartPrefabBind()
		{
			return this.Bind<IInteractEntityPartPrefabBind>().Value;
		}

		// Token: 0x17009F2E RID: 40750
		// (get) Token: 0x06023940 RID: 145728 RVA: 0x004EB710 File Offset: 0x004E9910
		public float ShowAngle
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009F2F RID: 40751
		// (get) Token: 0x06023941 RID: 145729 RVA: 0x004EB754 File Offset: 0x004E9954
		public float TriggerAngle
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023942 RID: 145730 RVA: 0x004EB795 File Offset: 0x004E9995
		public static Offset<IInteractStyleEntityPart> CreateIInteractStyleEntityPart(FlatBufferBuilder builder, EInteractStyleType Type = EInteractStyleType.Panorama, TInteractEntityPartBind Bind_type = TInteractEntityPartBind.NONE, int BindOffset = 0, float ShowAngle = 0f, float TriggerAngle = 0f)
		{
			builder.StartTable(5);
			IInteractStyleEntityPart.AddTriggerAngle(builder, TriggerAngle);
			IInteractStyleEntityPart.AddShowAngle(builder, ShowAngle);
			IInteractStyleEntityPart.AddBind(builder, BindOffset);
			IInteractStyleEntityPart.AddBindType(builder, Bind_type);
			IInteractStyleEntityPart.AddType(builder, Type);
			return IInteractStyleEntityPart.EndIInteractStyleEntityPart(builder);
		}

		// Token: 0x06023943 RID: 145731 RVA: 0x004EB7C9 File Offset: 0x004E99C9
		public static void StartIInteractStyleEntityPart(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06023944 RID: 145732 RVA: 0x004EB7D2 File Offset: 0x004E99D2
		public static void AddType(FlatBufferBuilder builder, EInteractStyleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023945 RID: 145733 RVA: 0x004EB7DD File Offset: 0x004E99DD
		public static void AddBindType(FlatBufferBuilder builder, TInteractEntityPartBind bindType)
		{
			builder.AddByte(1, (byte)bindType, 0);
		}

		// Token: 0x06023946 RID: 145734 RVA: 0x004EB7E8 File Offset: 0x004E99E8
		public static void AddBind(FlatBufferBuilder builder, int bindOffset)
		{
			builder.AddOffset(2, bindOffset, 0);
		}

		// Token: 0x06023947 RID: 145735 RVA: 0x004EB7F3 File Offset: 0x004E99F3
		public static void AddShowAngle(FlatBufferBuilder builder, float showAngle)
		{
			builder.AddFloat(3, showAngle, 0.0);
		}

		// Token: 0x06023948 RID: 145736 RVA: 0x004EB806 File Offset: 0x004E9A06
		public static void AddTriggerAngle(FlatBufferBuilder builder, float triggerAngle)
		{
			builder.AddFloat(4, triggerAngle, 0.0);
		}

		// Token: 0x06023949 RID: 145737 RVA: 0x004EB819 File Offset: 0x004E9A19
		public static Offset<IInteractStyleEntityPart> EndIInteractStyleEntityPart(FlatBufferBuilder builder)
		{
			return new Offset<IInteractStyleEntityPart>(builder.EndTable());
		}

		// Token: 0x0602394A RID: 145738 RVA: 0x004EB828 File Offset: 0x004E9A28
		public IInteractStyleEntityPartT UnPack()
		{
			IInteractStyleEntityPartT interactStyleEntityPartT = new IInteractStyleEntityPartT();
			this.UnPackTo(interactStyleEntityPartT);
			return interactStyleEntityPartT;
		}

		// Token: 0x0602394B RID: 145739 RVA: 0x004EB844 File Offset: 0x004E9A44
		public void UnPackTo(IInteractStyleEntityPartT _o)
		{
			_o.Type = this.Type;
			_o.Bind = new TInteractEntityPartBindUnion();
			_o.Bind.Type = this.BindType;
			TInteractEntityPartBind bindType = this.BindType;
			if (bindType != TInteractEntityPartBind.IInteractEntityPartModelBind)
			{
				if (bindType == TInteractEntityPartBind.IInteractEntityPartPrefabBind)
				{
					_o.Bind.Value = ((this.Bind<IInteractEntityPartPrefabBind>() != null) ? this.Bind<IInteractEntityPartPrefabBind>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.Bind.Value = ((this.Bind<IInteractEntityPartModelBind>() != null) ? this.Bind<IInteractEntityPartModelBind>().Value.UnPack() : null);
			}
			_o.ShowAngle = this.ShowAngle;
			_o.TriggerAngle = this.TriggerAngle;
		}

		// Token: 0x0602394C RID: 145740 RVA: 0x004EB910 File Offset: 0x004E9B10
		public static Offset<IInteractStyleEntityPart> Pack(FlatBufferBuilder builder, IInteractStyleEntityPartT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractStyleEntityPart>);
			}
			TInteractEntityPartBind bind_type = (_o.Bind == null) ? TInteractEntityPartBind.NONE : _o.Bind.Type;
			int bindOffset = (_o.Bind == null) ? 0 : TInteractEntityPartBindUnion.Pack(builder, _o.Bind);
			return IInteractStyleEntityPart.CreateIInteractStyleEntityPart(builder, _o.Type, bind_type, bindOffset, _o.ShowAngle, _o.TriggerAngle);
		}

		// Token: 0x0400E6FD RID: 59133
		private Table __p;
	}
}

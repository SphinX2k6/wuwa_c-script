using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A02 RID: 23042
	public struct IInteractStyleEntityPart : IFlatbufferObject
	{
		// Token: 0x1700A765 RID: 42853
		// (get) Token: 0x060259ED RID: 154093 RVA: 0x00528624 File Offset: 0x00526824
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060259EE RID: 154094 RVA: 0x00528631 File Offset: 0x00526831
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060259EF RID: 154095 RVA: 0x00528638 File Offset: 0x00526838
		public static IInteractStyleEntityPart GetRootAsIInteractStyleEntityPart(ByteBuffer _bb)
		{
			return IInteractStyleEntityPart.GetRootAsIInteractStyleEntityPart(_bb, default(IInteractStyleEntityPart));
		}

		// Token: 0x060259F0 RID: 154096 RVA: 0x00528654 File Offset: 0x00526854
		public static IInteractStyleEntityPart GetRootAsIInteractStyleEntityPart(ByteBuffer _bb, IInteractStyleEntityPart obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060259F1 RID: 154097 RVA: 0x00528671 File Offset: 0x00526871
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060259F2 RID: 154098 RVA: 0x00528680 File Offset: 0x00526880
		public IInteractStyleEntityPart __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A766 RID: 42854
		// (get) Token: 0x060259F3 RID: 154099 RVA: 0x00528690 File Offset: 0x00526890
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

		// Token: 0x1700A767 RID: 42855
		// (get) Token: 0x060259F4 RID: 154100 RVA: 0x005286CC File Offset: 0x005268CC
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

		// Token: 0x060259F5 RID: 154101 RVA: 0x00528708 File Offset: 0x00526908
		public TTable? Bind<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060259F6 RID: 154102 RVA: 0x0052874C File Offset: 0x0052694C
		public IInteractEntityPartModelBind BindAsIInteractEntityPartModelBind()
		{
			return this.Bind<IInteractEntityPartModelBind>().Value;
		}

		// Token: 0x060259F7 RID: 154103 RVA: 0x00528768 File Offset: 0x00526968
		public IInteractEntityPartPrefabBind BindAsIInteractEntityPartPrefabBind()
		{
			return this.Bind<IInteractEntityPartPrefabBind>().Value;
		}

		// Token: 0x1700A768 RID: 42856
		// (get) Token: 0x060259F8 RID: 154104 RVA: 0x00528784 File Offset: 0x00526984
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

		// Token: 0x1700A769 RID: 42857
		// (get) Token: 0x060259F9 RID: 154105 RVA: 0x005287C8 File Offset: 0x005269C8
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

		// Token: 0x060259FA RID: 154106 RVA: 0x00528809 File Offset: 0x00526A09
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

		// Token: 0x060259FB RID: 154107 RVA: 0x0052883D File Offset: 0x00526A3D
		public static void StartIInteractStyleEntityPart(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060259FC RID: 154108 RVA: 0x00528846 File Offset: 0x00526A46
		public static void AddType(FlatBufferBuilder builder, EInteractStyleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060259FD RID: 154109 RVA: 0x00528851 File Offset: 0x00526A51
		public static void AddBindType(FlatBufferBuilder builder, TInteractEntityPartBind bindType)
		{
			builder.AddByte(1, (byte)bindType, 0);
		}

		// Token: 0x060259FE RID: 154110 RVA: 0x0052885C File Offset: 0x00526A5C
		public static void AddBind(FlatBufferBuilder builder, int bindOffset)
		{
			builder.AddOffset(2, bindOffset, 0);
		}

		// Token: 0x060259FF RID: 154111 RVA: 0x00528867 File Offset: 0x00526A67
		public static void AddShowAngle(FlatBufferBuilder builder, float showAngle)
		{
			builder.AddFloat(3, showAngle, 0.0);
		}

		// Token: 0x06025A00 RID: 154112 RVA: 0x0052887A File Offset: 0x00526A7A
		public static void AddTriggerAngle(FlatBufferBuilder builder, float triggerAngle)
		{
			builder.AddFloat(4, triggerAngle, 0.0);
		}

		// Token: 0x06025A01 RID: 154113 RVA: 0x0052888D File Offset: 0x00526A8D
		public static Offset<IInteractStyleEntityPart> EndIInteractStyleEntityPart(FlatBufferBuilder builder)
		{
			return new Offset<IInteractStyleEntityPart>(builder.EndTable());
		}

		// Token: 0x06025A02 RID: 154114 RVA: 0x0052889C File Offset: 0x00526A9C
		public IInteractStyleEntityPartT UnPack()
		{
			IInteractStyleEntityPartT interactStyleEntityPartT = new IInteractStyleEntityPartT();
			this.UnPackTo(interactStyleEntityPartT);
			return interactStyleEntityPartT;
		}

		// Token: 0x06025A03 RID: 154115 RVA: 0x005288B8 File Offset: 0x00526AB8
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

		// Token: 0x06025A04 RID: 154116 RVA: 0x00528984 File Offset: 0x00526B84
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

		// Token: 0x0400F32E RID: 62254
		private Table __p;
	}
}

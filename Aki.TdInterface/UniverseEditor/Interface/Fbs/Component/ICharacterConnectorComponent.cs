using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054AB RID: 21675
	public struct ICharacterConnectorComponent : IFlatbufferObject
	{
		// Token: 0x17009A87 RID: 39559
		// (get) Token: 0x06022221 RID: 139809 RVA: 0x004B4735 File Offset: 0x004B2935
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022222 RID: 139810 RVA: 0x004B4742 File Offset: 0x004B2942
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022223 RID: 139811 RVA: 0x004B474C File Offset: 0x004B294C
		public static ICharacterConnectorComponent GetRootAsICharacterConnectorComponent(ByteBuffer _bb)
		{
			return ICharacterConnectorComponent.GetRootAsICharacterConnectorComponent(_bb, default(ICharacterConnectorComponent));
		}

		// Token: 0x06022224 RID: 139812 RVA: 0x004B4768 File Offset: 0x004B2968
		public static ICharacterConnectorComponent GetRootAsICharacterConnectorComponent(ByteBuffer _bb, ICharacterConnectorComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022225 RID: 139813 RVA: 0x004B4785 File Offset: 0x004B2985
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022226 RID: 139814 RVA: 0x004B4794 File Offset: 0x004B2994
		public ICharacterConnectorComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A88 RID: 39560
		// (get) Token: 0x06022227 RID: 139815 RVA: 0x004B47A4 File Offset: 0x004B29A4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009A89 RID: 39561
		// (get) Token: 0x06022228 RID: 139816 RVA: 0x004B47E4 File Offset: 0x004B29E4
		public ICharacterConnectorRange? LogicType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ICharacterConnectorRange?(default(ICharacterConnectorRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009A8A RID: 39562
		// (get) Token: 0x06022229 RID: 139817 RVA: 0x004B4844 File Offset: 0x004B2A44
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

		// Token: 0x0602222A RID: 139818 RVA: 0x004B4880 File Offset: 0x004B2A80
		public static Offset<ICharacterConnectorComponent> CreateICharacterConnectorComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<ICharacterConnectorRange> LogicTypeOffset = default(Offset<ICharacterConnectorRange>), byte NullMask = 0)
		{
			builder.StartTable(3);
			ICharacterConnectorComponent.AddLogicType(builder, LogicTypeOffset);
			ICharacterConnectorComponent.AddNullMask(builder, NullMask);
			ICharacterConnectorComponent.AddDisabled(builder, Disabled);
			return ICharacterConnectorComponent.EndICharacterConnectorComponent(builder);
		}

		// Token: 0x0602222B RID: 139819 RVA: 0x004B48A4 File Offset: 0x004B2AA4
		public static void StartICharacterConnectorComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602222C RID: 139820 RVA: 0x004B48AD File Offset: 0x004B2AAD
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602222D RID: 139821 RVA: 0x004B48B8 File Offset: 0x004B2AB8
		public static void AddLogicType(FlatBufferBuilder builder, Offset<ICharacterConnectorRange> logicTypeOffset)
		{
			builder.AddOffset(1, logicTypeOffset.Value, 0);
		}

		// Token: 0x0602222E RID: 139822 RVA: 0x004B48C8 File Offset: 0x004B2AC8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602222F RID: 139823 RVA: 0x004B48D3 File Offset: 0x004B2AD3
		public static Offset<ICharacterConnectorComponent> EndICharacterConnectorComponent(FlatBufferBuilder builder)
		{
			return new Offset<ICharacterConnectorComponent>(builder.EndTable());
		}

		// Token: 0x06022230 RID: 139824 RVA: 0x004B48E0 File Offset: 0x004B2AE0
		public ICharacterConnectorComponentT UnPack()
		{
			ICharacterConnectorComponentT characterConnectorComponentT = new ICharacterConnectorComponentT();
			this.UnPackTo(characterConnectorComponentT);
			return characterConnectorComponentT;
		}

		// Token: 0x06022231 RID: 139825 RVA: 0x004B48FC File Offset: 0x004B2AFC
		public void UnPackTo(ICharacterConnectorComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.LogicType = ((this.LogicType != null) ? this.LogicType.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022232 RID: 139826 RVA: 0x004B4950 File Offset: 0x004B2B50
		public static Offset<ICharacterConnectorComponent> Pack(FlatBufferBuilder builder, ICharacterConnectorComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICharacterConnectorComponent>);
			}
			Offset<ICharacterConnectorRange> logicTypeOffset = (_o.LogicType == null) ? default(Offset<ICharacterConnectorRange>) : ICharacterConnectorRange.Pack(builder, _o.LogicType);
			return ICharacterConnectorComponent.CreateICharacterConnectorComponent(builder, _o.Disabled, logicTypeOffset, _o.NullMask);
		}

		// Token: 0x0400E9CD RID: 59853
		private Table __p;
	}
}

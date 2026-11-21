using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005538 RID: 21816
	public struct IComponentBase : IFlatbufferObject
	{
		// Token: 0x17009BFD RID: 39933
		// (get) Token: 0x0602281F RID: 141343 RVA: 0x004C0E69 File Offset: 0x004BF069
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022820 RID: 141344 RVA: 0x004C0E76 File Offset: 0x004BF076
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022821 RID: 141345 RVA: 0x004C0E80 File Offset: 0x004BF080
		public static IComponentBase GetRootAsIComponentBase(ByteBuffer _bb)
		{
			return IComponentBase.GetRootAsIComponentBase(_bb, default(IComponentBase));
		}

		// Token: 0x06022822 RID: 141346 RVA: 0x004C0E9C File Offset: 0x004BF09C
		public static IComponentBase GetRootAsIComponentBase(ByteBuffer _bb, IComponentBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022823 RID: 141347 RVA: 0x004C0EB9 File Offset: 0x004BF0B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022824 RID: 141348 RVA: 0x004C0EC8 File Offset: 0x004BF0C8
		public IComponentBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009BFE RID: 39934
		// (get) Token: 0x06022825 RID: 141349 RVA: 0x004C0ED8 File Offset: 0x004BF0D8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009BFF RID: 39935
		// (get) Token: 0x06022826 RID: 141350 RVA: 0x004C0F18 File Offset: 0x004BF118
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

		// Token: 0x06022827 RID: 141351 RVA: 0x004C0F54 File Offset: 0x004BF154
		public static Offset<IComponentBase> CreateIComponentBase(FlatBufferBuilder builder, bool Disabled = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IComponentBase.AddNullMask(builder, NullMask);
			IComponentBase.AddDisabled(builder, Disabled);
			return IComponentBase.EndIComponentBase(builder);
		}

		// Token: 0x06022828 RID: 141352 RVA: 0x004C0F71 File Offset: 0x004BF171
		public static void StartIComponentBase(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06022829 RID: 141353 RVA: 0x004C0F7A File Offset: 0x004BF17A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602282A RID: 141354 RVA: 0x004C0F85 File Offset: 0x004BF185
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x0602282B RID: 141355 RVA: 0x004C0F90 File Offset: 0x004BF190
		public static Offset<IComponentBase> EndIComponentBase(FlatBufferBuilder builder)
		{
			return new Offset<IComponentBase>(builder.EndTable());
		}

		// Token: 0x0602282C RID: 141356 RVA: 0x004C0FA0 File Offset: 0x004BF1A0
		public IComponentBaseT UnPack()
		{
			IComponentBaseT componentBaseT = new IComponentBaseT();
			this.UnPackTo(componentBaseT);
			return componentBaseT;
		}

		// Token: 0x0602282D RID: 141357 RVA: 0x004C0FBB File Offset: 0x004BF1BB
		public void UnPackTo(IComponentBaseT _o)
		{
			_o.Disabled = this.Disabled;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602282E RID: 141358 RVA: 0x004C0FD8 File Offset: 0x004BF1D8
		public static Offset<IComponentBase> Pack(FlatBufferBuilder builder, IComponentBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IComponentBase>);
			}
			return IComponentBase.CreateIComponentBase(builder, _o.Disabled, _o.NullMask);
		}

		// Token: 0x0400EABC RID: 60092
		private Table __p;
	}
}

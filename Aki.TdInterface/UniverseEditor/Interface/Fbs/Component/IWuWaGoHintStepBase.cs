using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061C8 RID: 25032
	public struct IWuWaGoHintStepBase : IFlatbufferObject
	{
		// Token: 0x1700BAAB RID: 47787
		// (get) Token: 0x0602A8FB RID: 174331 RVA: 0x005CDE28 File Offset: 0x005CC028
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A8FC RID: 174332 RVA: 0x005CDE35 File Offset: 0x005CC035
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A8FD RID: 174333 RVA: 0x005CDE3C File Offset: 0x005CC03C
		public static IWuWaGoHintStepBase GetRootAsIWuWaGoHintStepBase(ByteBuffer _bb)
		{
			return IWuWaGoHintStepBase.GetRootAsIWuWaGoHintStepBase(_bb, default(IWuWaGoHintStepBase));
		}

		// Token: 0x0602A8FE RID: 174334 RVA: 0x005CDE58 File Offset: 0x005CC058
		public static IWuWaGoHintStepBase GetRootAsIWuWaGoHintStepBase(ByteBuffer _bb, IWuWaGoHintStepBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A8FF RID: 174335 RVA: 0x005CDE75 File Offset: 0x005CC075
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A900 RID: 174336 RVA: 0x005CDE84 File Offset: 0x005CC084
		public IWuWaGoHintStepBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BAAC RID: 47788
		// (get) Token: 0x0602A901 RID: 174337 RVA: 0x005CDE94 File Offset: 0x005CC094
		public EWuWaGoHintStepType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWuWaGoHintStepType.Move;
				}
				return (EWuWaGoHintStepType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A902 RID: 174338 RVA: 0x005CDED0 File Offset: 0x005CC0D0
		public static Offset<IWuWaGoHintStepBase> CreateIWuWaGoHintStepBase(FlatBufferBuilder builder, EWuWaGoHintStepType Type = EWuWaGoHintStepType.Move)
		{
			builder.StartTable(1);
			IWuWaGoHintStepBase.AddType(builder, Type);
			return IWuWaGoHintStepBase.EndIWuWaGoHintStepBase(builder);
		}

		// Token: 0x0602A903 RID: 174339 RVA: 0x005CDEE6 File Offset: 0x005CC0E6
		public static void StartIWuWaGoHintStepBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602A904 RID: 174340 RVA: 0x005CDEEF File Offset: 0x005CC0EF
		public static void AddType(FlatBufferBuilder builder, EWuWaGoHintStepType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A905 RID: 174341 RVA: 0x005CDEFA File Offset: 0x005CC0FA
		public static Offset<IWuWaGoHintStepBase> EndIWuWaGoHintStepBase(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoHintStepBase>(builder.EndTable());
		}

		// Token: 0x0602A906 RID: 174342 RVA: 0x005CDF08 File Offset: 0x005CC108
		public IWuWaGoHintStepBaseT UnPack()
		{
			IWuWaGoHintStepBaseT wuWaGoHintStepBaseT = new IWuWaGoHintStepBaseT();
			this.UnPackTo(wuWaGoHintStepBaseT);
			return wuWaGoHintStepBaseT;
		}

		// Token: 0x0602A907 RID: 174343 RVA: 0x005CDF23 File Offset: 0x005CC123
		public void UnPackTo(IWuWaGoHintStepBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602A908 RID: 174344 RVA: 0x005CDF34 File Offset: 0x005CC134
		public static Offset<IWuWaGoHintStepBase> Pack(FlatBufferBuilder builder, IWuWaGoHintStepBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoHintStepBase>);
			}
			return IWuWaGoHintStepBase.CreateIWuWaGoHintStepBase(builder, _o.Type);
		}

		// Token: 0x0401002E RID: 65582
		private Table __p;
	}
}

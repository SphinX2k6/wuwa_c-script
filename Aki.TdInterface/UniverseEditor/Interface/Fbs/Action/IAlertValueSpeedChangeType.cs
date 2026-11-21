using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067F9 RID: 26617
	public struct IAlertValueSpeedChangeType : IFlatbufferObject
	{
		// Token: 0x1700C3AE RID: 50094
		// (get) Token: 0x0602D775 RID: 186229 RVA: 0x006399EC File Offset: 0x00637BEC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D776 RID: 186230 RVA: 0x006399F9 File Offset: 0x00637BF9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D777 RID: 186231 RVA: 0x00639A00 File Offset: 0x00637C00
		public static IAlertValueSpeedChangeType GetRootAsIAlertValueSpeedChangeType(ByteBuffer _bb)
		{
			return IAlertValueSpeedChangeType.GetRootAsIAlertValueSpeedChangeType(_bb, default(IAlertValueSpeedChangeType));
		}

		// Token: 0x0602D778 RID: 186232 RVA: 0x00639A1C File Offset: 0x00637C1C
		public static IAlertValueSpeedChangeType GetRootAsIAlertValueSpeedChangeType(ByteBuffer _bb, IAlertValueSpeedChangeType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D779 RID: 186233 RVA: 0x00639A39 File Offset: 0x00637C39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D77A RID: 186234 RVA: 0x00639A48 File Offset: 0x00637C48
		public IAlertValueSpeedChangeType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C3AF RID: 50095
		// (get) Token: 0x0602D77B RID: 186235 RVA: 0x00639A58 File Offset: 0x00637C58
		public EValueChangeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EValueChangeType.AddOrSub;
				}
				return (EValueChangeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D77C RID: 186236 RVA: 0x00639A94 File Offset: 0x00637C94
		public static Offset<IAlertValueSpeedChangeType> CreateIAlertValueSpeedChangeType(FlatBufferBuilder builder, EValueChangeType Type = EValueChangeType.AddOrSub)
		{
			builder.StartTable(1);
			IAlertValueSpeedChangeType.AddType(builder, Type);
			return IAlertValueSpeedChangeType.EndIAlertValueSpeedChangeType(builder);
		}

		// Token: 0x0602D77D RID: 186237 RVA: 0x00639AAA File Offset: 0x00637CAA
		public static void StartIAlertValueSpeedChangeType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D77E RID: 186238 RVA: 0x00639AB3 File Offset: 0x00637CB3
		public static void AddType(FlatBufferBuilder builder, EValueChangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D77F RID: 186239 RVA: 0x00639ABE File Offset: 0x00637CBE
		public static Offset<IAlertValueSpeedChangeType> EndIAlertValueSpeedChangeType(FlatBufferBuilder builder)
		{
			return new Offset<IAlertValueSpeedChangeType>(builder.EndTable());
		}

		// Token: 0x0602D780 RID: 186240 RVA: 0x00639ACC File Offset: 0x00637CCC
		public IAlertValueSpeedChangeTypeT UnPack()
		{
			IAlertValueSpeedChangeTypeT alertValueSpeedChangeTypeT = new IAlertValueSpeedChangeTypeT();
			this.UnPackTo(alertValueSpeedChangeTypeT);
			return alertValueSpeedChangeTypeT;
		}

		// Token: 0x0602D781 RID: 186241 RVA: 0x00639AE7 File Offset: 0x00637CE7
		public void UnPackTo(IAlertValueSpeedChangeTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602D782 RID: 186242 RVA: 0x00639AF8 File Offset: 0x00637CF8
		public static Offset<IAlertValueSpeedChangeType> Pack(FlatBufferBuilder builder, IAlertValueSpeedChangeTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAlertValueSpeedChangeType>);
			}
			return IAlertValueSpeedChangeType.CreateIAlertValueSpeedChangeType(builder, _o.Type);
		}

		// Token: 0x040114A9 RID: 70825
		private Table __p;
	}
}

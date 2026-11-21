using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A2F RID: 27183
	public struct IClientExecEntityPrefabAction : IFlatbufferObject
	{
		// Token: 0x1700C7CA RID: 51146
		// (get) Token: 0x0602EA11 RID: 190993 RVA: 0x0065B8FC File Offset: 0x00659AFC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EA12 RID: 190994 RVA: 0x0065B909 File Offset: 0x00659B09
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EA13 RID: 190995 RVA: 0x0065B910 File Offset: 0x00659B10
		public static IClientExecEntityPrefabAction GetRootAsIClientExecEntityPrefabAction(ByteBuffer _bb)
		{
			return IClientExecEntityPrefabAction.GetRootAsIClientExecEntityPrefabAction(_bb, default(IClientExecEntityPrefabAction));
		}

		// Token: 0x0602EA14 RID: 190996 RVA: 0x0065B92C File Offset: 0x00659B2C
		public static IClientExecEntityPrefabAction GetRootAsIClientExecEntityPrefabAction(ByteBuffer _bb, IClientExecEntityPrefabAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EA15 RID: 190997 RVA: 0x0065B949 File Offset: 0x00659B49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EA16 RID: 190998 RVA: 0x0065B958 File Offset: 0x00659B58
		public IClientExecEntityPrefabAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7CB RID: 51147
		// (get) Token: 0x0602EA17 RID: 190999 RVA: 0x0065B968 File Offset: 0x00659B68
		public IClientModifyEntityPrefabParams? Option
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IClientModifyEntityPrefabParams?(default(IClientModifyEntityPrefabParams).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602EA18 RID: 191000 RVA: 0x0065B9C5 File Offset: 0x00659BC5
		public static Offset<IClientExecEntityPrefabAction> CreateIClientExecEntityPrefabAction(FlatBufferBuilder builder, Offset<IClientModifyEntityPrefabParams> OptionOffset = default(Offset<IClientModifyEntityPrefabParams>))
		{
			builder.StartTable(1);
			IClientExecEntityPrefabAction.AddOption(builder, OptionOffset);
			return IClientExecEntityPrefabAction.EndIClientExecEntityPrefabAction(builder);
		}

		// Token: 0x0602EA19 RID: 191001 RVA: 0x0065B9DB File Offset: 0x00659BDB
		public static void StartIClientExecEntityPrefabAction(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602EA1A RID: 191002 RVA: 0x0065B9E4 File Offset: 0x00659BE4
		public static void AddOption(FlatBufferBuilder builder, Offset<IClientModifyEntityPrefabParams> optionOffset)
		{
			builder.AddOffset(0, optionOffset.Value, 0);
		}

		// Token: 0x0602EA1B RID: 191003 RVA: 0x0065B9F4 File Offset: 0x00659BF4
		public static Offset<IClientExecEntityPrefabAction> EndIClientExecEntityPrefabAction(FlatBufferBuilder builder)
		{
			return new Offset<IClientExecEntityPrefabAction>(builder.EndTable());
		}

		// Token: 0x0602EA1C RID: 191004 RVA: 0x0065BA04 File Offset: 0x00659C04
		public IClientExecEntityPrefabActionT UnPack()
		{
			IClientExecEntityPrefabActionT clientExecEntityPrefabActionT = new IClientExecEntityPrefabActionT();
			this.UnPackTo(clientExecEntityPrefabActionT);
			return clientExecEntityPrefabActionT;
		}

		// Token: 0x0602EA1D RID: 191005 RVA: 0x0065BA20 File Offset: 0x00659C20
		public void UnPackTo(IClientExecEntityPrefabActionT _o)
		{
			_o.Option = ((this.Option != null) ? this.Option.Value.UnPack() : null);
		}

		// Token: 0x0602EA1E RID: 191006 RVA: 0x0065BA5C File Offset: 0x00659C5C
		public static Offset<IClientExecEntityPrefabAction> Pack(FlatBufferBuilder builder, IClientExecEntityPrefabActionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientExecEntityPrefabAction>);
			}
			Offset<IClientModifyEntityPrefabParams> optionOffset = (_o.Option == null) ? default(Offset<IClientModifyEntityPrefabParams>) : IClientModifyEntityPrefabParams.Pack(builder, _o.Option);
			return IClientExecEntityPrefabAction.CreateIClientExecEntityPrefabAction(builder, optionOffset);
		}

		// Token: 0x040117AB RID: 71595
		private Table __p;
	}
}

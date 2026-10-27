using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200618E RID: 24974
	public struct IAlertValueSpeedChangeType : IFlatbufferObject
	{
		// Token: 0x1700BA30 RID: 47664
		// (get) Token: 0x0602B044 RID: 176196 RVA: 0x005EF178 File Offset: 0x005ED378
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B045 RID: 176197 RVA: 0x005EF185 File Offset: 0x005ED385
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B046 RID: 176198 RVA: 0x005EF18C File Offset: 0x005ED38C
		public static IAlertValueSpeedChangeType GetRootAsIAlertValueSpeedChangeType(ByteBuffer _bb)
		{
			return IAlertValueSpeedChangeType.GetRootAsIAlertValueSpeedChangeType(_bb, default(IAlertValueSpeedChangeType));
		}

		// Token: 0x0602B047 RID: 176199 RVA: 0x005EF1A8 File Offset: 0x005ED3A8
		public static IAlertValueSpeedChangeType GetRootAsIAlertValueSpeedChangeType(ByteBuffer _bb, IAlertValueSpeedChangeType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B048 RID: 176200 RVA: 0x005EF1C5 File Offset: 0x005ED3C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B049 RID: 176201 RVA: 0x005EF1D4 File Offset: 0x005ED3D4
		public IAlertValueSpeedChangeType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA31 RID: 47665
		// (get) Token: 0x0602B04A RID: 176202 RVA: 0x005EF1E4 File Offset: 0x005ED3E4
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

		// Token: 0x0602B04B RID: 176203 RVA: 0x005EF220 File Offset: 0x005ED420
		public static Offset<IAlertValueSpeedChangeType> CreateIAlertValueSpeedChangeType(FlatBufferBuilder builder, EValueChangeType Type = EValueChangeType.AddOrSub)
		{
			builder.StartTable(1);
			IAlertValueSpeedChangeType.AddType(builder, Type);
			return IAlertValueSpeedChangeType.EndIAlertValueSpeedChangeType(builder);
		}

		// Token: 0x0602B04C RID: 176204 RVA: 0x005EF236 File Offset: 0x005ED436
		public static void StartIAlertValueSpeedChangeType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B04D RID: 176205 RVA: 0x005EF23F File Offset: 0x005ED43F
		public static void AddType(FlatBufferBuilder builder, EValueChangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B04E RID: 176206 RVA: 0x005EF24A File Offset: 0x005ED44A
		public static Offset<IAlertValueSpeedChangeType> EndIAlertValueSpeedChangeType(FlatBufferBuilder builder)
		{
			return new Offset<IAlertValueSpeedChangeType>(builder.EndTable());
		}

		// Token: 0x0602B04F RID: 176207 RVA: 0x005EF258 File Offset: 0x005ED458
		public IAlertValueSpeedChangeTypeT UnPack()
		{
			IAlertValueSpeedChangeTypeT alertValueSpeedChangeTypeT = new IAlertValueSpeedChangeTypeT();
			this.UnPackTo(alertValueSpeedChangeTypeT);
			return alertValueSpeedChangeTypeT;
		}

		// Token: 0x0602B050 RID: 176208 RVA: 0x005EF273 File Offset: 0x005ED473
		public void UnPackTo(IAlertValueSpeedChangeTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B051 RID: 176209 RVA: 0x005EF284 File Offset: 0x005ED484
		public static Offset<IAlertValueSpeedChangeType> Pack(FlatBufferBuilder builder, IAlertValueSpeedChangeTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAlertValueSpeedChangeType>);
			}
			return IAlertValueSpeedChangeType.CreateIAlertValueSpeedChangeType(builder, _o.Type);
		}

		// Token: 0x0401069A RID: 67226
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A8A RID: 19082
	public struct ICheckIsGlobalTimeScaleEnabled : IFlatbufferObject
	{
		// Token: 0x17008A3E RID: 35390
		// (get) Token: 0x0601DECC RID: 122572 RVA: 0x00433EC0 File Offset: 0x004320C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DECD RID: 122573 RVA: 0x00433ECD File Offset: 0x004320CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DECE RID: 122574 RVA: 0x00433ED4 File Offset: 0x004320D4
		public static ICheckIsGlobalTimeScaleEnabled GetRootAsICheckIsGlobalTimeScaleEnabled(ByteBuffer _bb)
		{
			return ICheckIsGlobalTimeScaleEnabled.GetRootAsICheckIsGlobalTimeScaleEnabled(_bb, default(ICheckIsGlobalTimeScaleEnabled));
		}

		// Token: 0x0601DECF RID: 122575 RVA: 0x00433EF0 File Offset: 0x004320F0
		public static ICheckIsGlobalTimeScaleEnabled GetRootAsICheckIsGlobalTimeScaleEnabled(ByteBuffer _bb, ICheckIsGlobalTimeScaleEnabled obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DED0 RID: 122576 RVA: 0x00433F0D File Offset: 0x0043210D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DED1 RID: 122577 RVA: 0x00433F1C File Offset: 0x0043211C
		public ICheckIsGlobalTimeScaleEnabled __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A3F RID: 35391
		// (get) Token: 0x0601DED2 RID: 122578 RVA: 0x00433F2C File Offset: 0x0043212C
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008A40 RID: 35392
		// (get) Token: 0x0601DED3 RID: 122579 RVA: 0x00433F68 File Offset: 0x00432168
		public bool Enabled
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601DED4 RID: 122580 RVA: 0x00433FA7 File Offset: 0x004321A7
		public static Offset<ICheckIsGlobalTimeScaleEnabled> CreateICheckIsGlobalTimeScaleEnabled(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool Enabled = false)
		{
			builder.StartTable(2);
			ICheckIsGlobalTimeScaleEnabled.AddEnabled(builder, Enabled);
			ICheckIsGlobalTimeScaleEnabled.AddType(builder, Type);
			return ICheckIsGlobalTimeScaleEnabled.EndICheckIsGlobalTimeScaleEnabled(builder);
		}

		// Token: 0x0601DED5 RID: 122581 RVA: 0x00433FC4 File Offset: 0x004321C4
		public static void StartICheckIsGlobalTimeScaleEnabled(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601DED6 RID: 122582 RVA: 0x00433FCD File Offset: 0x004321CD
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DED7 RID: 122583 RVA: 0x00433FD8 File Offset: 0x004321D8
		public static void AddEnabled(FlatBufferBuilder builder, bool enabled)
		{
			builder.AddBool(1, enabled, false);
		}

		// Token: 0x0601DED8 RID: 122584 RVA: 0x00433FE3 File Offset: 0x004321E3
		public static Offset<ICheckIsGlobalTimeScaleEnabled> EndICheckIsGlobalTimeScaleEnabled(FlatBufferBuilder builder)
		{
			return new Offset<ICheckIsGlobalTimeScaleEnabled>(builder.EndTable());
		}

		// Token: 0x0601DED9 RID: 122585 RVA: 0x00433FF0 File Offset: 0x004321F0
		public ICheckIsGlobalTimeScaleEnabledT UnPack()
		{
			ICheckIsGlobalTimeScaleEnabledT checkIsGlobalTimeScaleEnabledT = new ICheckIsGlobalTimeScaleEnabledT();
			this.UnPackTo(checkIsGlobalTimeScaleEnabledT);
			return checkIsGlobalTimeScaleEnabledT;
		}

		// Token: 0x0601DEDA RID: 122586 RVA: 0x0043400B File Offset: 0x0043220B
		public void UnPackTo(ICheckIsGlobalTimeScaleEnabledT _o)
		{
			_o.Type = this.Type;
			_o.Enabled = this.Enabled;
		}

		// Token: 0x0601DEDB RID: 122587 RVA: 0x00434028 File Offset: 0x00432228
		public static Offset<ICheckIsGlobalTimeScaleEnabled> Pack(FlatBufferBuilder builder, ICheckIsGlobalTimeScaleEnabledT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckIsGlobalTimeScaleEnabled>);
			}
			return ICheckIsGlobalTimeScaleEnabled.CreateICheckIsGlobalTimeScaleEnabled(builder, _o.Type, _o.Enabled);
		}

		// Token: 0x0400D2F9 RID: 54009
		private Table __p;
	}
}

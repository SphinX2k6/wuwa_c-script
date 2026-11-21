using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C72 RID: 23666
	public struct IPasserbyNpcExitTimingBase : IFlatbufferObject
	{
		// Token: 0x1700ADE5 RID: 44517
		// (get) Token: 0x06027421 RID: 160801 RVA: 0x0056094A File Offset: 0x0055EB4A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027422 RID: 160802 RVA: 0x00560957 File Offset: 0x0055EB57
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027423 RID: 160803 RVA: 0x00560960 File Offset: 0x0055EB60
		public static IPasserbyNpcExitTimingBase GetRootAsIPasserbyNpcExitTimingBase(ByteBuffer _bb)
		{
			return IPasserbyNpcExitTimingBase.GetRootAsIPasserbyNpcExitTimingBase(_bb, default(IPasserbyNpcExitTimingBase));
		}

		// Token: 0x06027424 RID: 160804 RVA: 0x0056097C File Offset: 0x0055EB7C
		public static IPasserbyNpcExitTimingBase GetRootAsIPasserbyNpcExitTimingBase(ByteBuffer _bb, IPasserbyNpcExitTimingBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027425 RID: 160805 RVA: 0x00560999 File Offset: 0x0055EB99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027426 RID: 160806 RVA: 0x005609A8 File Offset: 0x0055EBA8
		public IPasserbyNpcExitTimingBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ADE6 RID: 44518
		// (get) Token: 0x06027427 RID: 160807 RVA: 0x005609B8 File Offset: 0x0055EBB8
		public EPasserbyNpcExitTimingType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPasserbyNpcExitTimingType.LiftStop;
				}
				return (EPasserbyNpcExitTimingType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027428 RID: 160808 RVA: 0x005609F4 File Offset: 0x0055EBF4
		public static Offset<IPasserbyNpcExitTimingBase> CreateIPasserbyNpcExitTimingBase(FlatBufferBuilder builder, EPasserbyNpcExitTimingType Type = EPasserbyNpcExitTimingType.LiftStop)
		{
			builder.StartTable(1);
			IPasserbyNpcExitTimingBase.AddType(builder, Type);
			return IPasserbyNpcExitTimingBase.EndIPasserbyNpcExitTimingBase(builder);
		}

		// Token: 0x06027429 RID: 160809 RVA: 0x00560A0A File Offset: 0x0055EC0A
		public static void StartIPasserbyNpcExitTimingBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602742A RID: 160810 RVA: 0x00560A13 File Offset: 0x0055EC13
		public static void AddType(FlatBufferBuilder builder, EPasserbyNpcExitTimingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602742B RID: 160811 RVA: 0x00560A1E File Offset: 0x0055EC1E
		public static Offset<IPasserbyNpcExitTimingBase> EndIPasserbyNpcExitTimingBase(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcExitTimingBase>(builder.EndTable());
		}

		// Token: 0x0602742C RID: 160812 RVA: 0x00560A2C File Offset: 0x0055EC2C
		public IPasserbyNpcExitTimingBaseT UnPack()
		{
			IPasserbyNpcExitTimingBaseT passerbyNpcExitTimingBaseT = new IPasserbyNpcExitTimingBaseT();
			this.UnPackTo(passerbyNpcExitTimingBaseT);
			return passerbyNpcExitTimingBaseT;
		}

		// Token: 0x0602742D RID: 160813 RVA: 0x00560A47 File Offset: 0x0055EC47
		public void UnPackTo(IPasserbyNpcExitTimingBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602742E RID: 160814 RVA: 0x00560A58 File Offset: 0x0055EC58
		public static Offset<IPasserbyNpcExitTimingBase> Pack(FlatBufferBuilder builder, IPasserbyNpcExitTimingBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcExitTimingBase>);
			}
			return IPasserbyNpcExitTimingBase.CreateIPasserbyNpcExitTimingBase(builder, _o.Type);
		}

		// Token: 0x0400F774 RID: 63348
		private Table __p;
	}
}

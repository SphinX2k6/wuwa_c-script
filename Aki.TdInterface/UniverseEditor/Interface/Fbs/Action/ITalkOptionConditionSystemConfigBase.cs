using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007328 RID: 29480
	public struct ITalkOptionConditionSystemConfigBase : IFlatbufferObject
	{
		// Token: 0x1700DFF6 RID: 57334
		// (get) Token: 0x0603580E RID: 219150 RVA: 0x0074A1C2 File Offset: 0x007483C2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603580F RID: 219151 RVA: 0x0074A1CF File Offset: 0x007483CF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035810 RID: 219152 RVA: 0x0074A1D8 File Offset: 0x007483D8
		public static ITalkOptionConditionSystemConfigBase GetRootAsITalkOptionConditionSystemConfigBase(ByteBuffer _bb)
		{
			return ITalkOptionConditionSystemConfigBase.GetRootAsITalkOptionConditionSystemConfigBase(_bb, default(ITalkOptionConditionSystemConfigBase));
		}

		// Token: 0x06035811 RID: 219153 RVA: 0x0074A1F4 File Offset: 0x007483F4
		public static ITalkOptionConditionSystemConfigBase GetRootAsITalkOptionConditionSystemConfigBase(ByteBuffer _bb, ITalkOptionConditionSystemConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035812 RID: 219154 RVA: 0x0074A211 File Offset: 0x00748411
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035813 RID: 219155 RVA: 0x0074A220 File Offset: 0x00748420
		public ITalkOptionConditionSystemConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DFF7 RID: 57335
		// (get) Token: 0x06035814 RID: 219156 RVA: 0x0074A230 File Offset: 0x00748430
		public ETalkOptionConditionSystem Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkOptionConditionSystem.SolarSchool;
				}
				return (ETalkOptionConditionSystem)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035815 RID: 219157 RVA: 0x0074A26C File Offset: 0x0074846C
		public static Offset<ITalkOptionConditionSystemConfigBase> CreateITalkOptionConditionSystemConfigBase(FlatBufferBuilder builder, ETalkOptionConditionSystem Type = ETalkOptionConditionSystem.SolarSchool)
		{
			builder.StartTable(1);
			ITalkOptionConditionSystemConfigBase.AddType(builder, Type);
			return ITalkOptionConditionSystemConfigBase.EndITalkOptionConditionSystemConfigBase(builder);
		}

		// Token: 0x06035816 RID: 219158 RVA: 0x0074A282 File Offset: 0x00748482
		public static void StartITalkOptionConditionSystemConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035817 RID: 219159 RVA: 0x0074A28B File Offset: 0x0074848B
		public static void AddType(FlatBufferBuilder builder, ETalkOptionConditionSystem type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035818 RID: 219160 RVA: 0x0074A296 File Offset: 0x00748496
		public static Offset<ITalkOptionConditionSystemConfigBase> EndITalkOptionConditionSystemConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOptionConditionSystemConfigBase>(builder.EndTable());
		}

		// Token: 0x06035819 RID: 219161 RVA: 0x0074A2A4 File Offset: 0x007484A4
		public ITalkOptionConditionSystemConfigBaseT UnPack()
		{
			ITalkOptionConditionSystemConfigBaseT talkOptionConditionSystemConfigBaseT = new ITalkOptionConditionSystemConfigBaseT();
			this.UnPackTo(talkOptionConditionSystemConfigBaseT);
			return talkOptionConditionSystemConfigBaseT;
		}

		// Token: 0x0603581A RID: 219162 RVA: 0x0074A2BF File Offset: 0x007484BF
		public void UnPackTo(ITalkOptionConditionSystemConfigBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603581B RID: 219163 RVA: 0x0074A2D0 File Offset: 0x007484D0
		public static Offset<ITalkOptionConditionSystemConfigBase> Pack(FlatBufferBuilder builder, ITalkOptionConditionSystemConfigBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkOptionConditionSystemConfigBase>);
			}
			return ITalkOptionConditionSystemConfigBase.CreateITalkOptionConditionSystemConfigBase(builder, _o.Type);
		}

		// Token: 0x04012114 RID: 74004
		private Table __p;
	}
}

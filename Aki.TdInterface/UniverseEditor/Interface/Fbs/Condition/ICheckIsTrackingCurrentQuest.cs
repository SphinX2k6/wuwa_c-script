using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AA2 RID: 19106
	public struct ICheckIsTrackingCurrentQuest : IFlatbufferObject
	{
		// Token: 0x17008A76 RID: 35446
		// (get) Token: 0x0601DFA6 RID: 122790 RVA: 0x00435797 File Offset: 0x00433997
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DFA7 RID: 122791 RVA: 0x004357A4 File Offset: 0x004339A4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DFA8 RID: 122792 RVA: 0x004357AC File Offset: 0x004339AC
		public static ICheckIsTrackingCurrentQuest GetRootAsICheckIsTrackingCurrentQuest(ByteBuffer _bb)
		{
			return ICheckIsTrackingCurrentQuest.GetRootAsICheckIsTrackingCurrentQuest(_bb, default(ICheckIsTrackingCurrentQuest));
		}

		// Token: 0x0601DFA9 RID: 122793 RVA: 0x004357C8 File Offset: 0x004339C8
		public static ICheckIsTrackingCurrentQuest GetRootAsICheckIsTrackingCurrentQuest(ByteBuffer _bb, ICheckIsTrackingCurrentQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DFAA RID: 122794 RVA: 0x004357E5 File Offset: 0x004339E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DFAB RID: 122795 RVA: 0x004357F4 File Offset: 0x004339F4
		public ICheckIsTrackingCurrentQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A77 RID: 35447
		// (get) Token: 0x0601DFAC RID: 122796 RVA: 0x00435804 File Offset: 0x00433A04
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

		// Token: 0x0601DFAD RID: 122797 RVA: 0x00435840 File Offset: 0x00433A40
		public static Offset<ICheckIsTrackingCurrentQuest> CreateICheckIsTrackingCurrentQuest(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar)
		{
			builder.StartTable(1);
			ICheckIsTrackingCurrentQuest.AddType(builder, Type);
			return ICheckIsTrackingCurrentQuest.EndICheckIsTrackingCurrentQuest(builder);
		}

		// Token: 0x0601DFAE RID: 122798 RVA: 0x00435856 File Offset: 0x00433A56
		public static void StartICheckIsTrackingCurrentQuest(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601DFAF RID: 122799 RVA: 0x0043585F File Offset: 0x00433A5F
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DFB0 RID: 122800 RVA: 0x0043586A File Offset: 0x00433A6A
		public static Offset<ICheckIsTrackingCurrentQuest> EndICheckIsTrackingCurrentQuest(FlatBufferBuilder builder)
		{
			return new Offset<ICheckIsTrackingCurrentQuest>(builder.EndTable());
		}

		// Token: 0x0601DFB1 RID: 122801 RVA: 0x00435878 File Offset: 0x00433A78
		public ICheckIsTrackingCurrentQuestT UnPack()
		{
			ICheckIsTrackingCurrentQuestT checkIsTrackingCurrentQuestT = new ICheckIsTrackingCurrentQuestT();
			this.UnPackTo(checkIsTrackingCurrentQuestT);
			return checkIsTrackingCurrentQuestT;
		}

		// Token: 0x0601DFB2 RID: 122802 RVA: 0x00435893 File Offset: 0x00433A93
		public void UnPackTo(ICheckIsTrackingCurrentQuestT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601DFB3 RID: 122803 RVA: 0x004358A4 File Offset: 0x00433AA4
		public static Offset<ICheckIsTrackingCurrentQuest> Pack(FlatBufferBuilder builder, ICheckIsTrackingCurrentQuestT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckIsTrackingCurrentQuest>);
			}
			return ICheckIsTrackingCurrentQuest.CreateICheckIsTrackingCurrentQuest(builder, _o.Type);
		}

		// Token: 0x0400D319 RID: 54041
		private Table __p;
	}
}

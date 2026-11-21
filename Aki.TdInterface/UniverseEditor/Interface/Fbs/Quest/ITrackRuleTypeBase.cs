using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004670 RID: 18032
	public struct ITrackRuleTypeBase : IFlatbufferObject
	{
		// Token: 0x17007E5B RID: 32347
		// (get) Token: 0x0601A765 RID: 108389 RVA: 0x003C466D File Offset: 0x003C286D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A766 RID: 108390 RVA: 0x003C467A File Offset: 0x003C287A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A767 RID: 108391 RVA: 0x003C4684 File Offset: 0x003C2884
		public static ITrackRuleTypeBase GetRootAsITrackRuleTypeBase(ByteBuffer _bb)
		{
			return ITrackRuleTypeBase.GetRootAsITrackRuleTypeBase(_bb, default(ITrackRuleTypeBase));
		}

		// Token: 0x0601A768 RID: 108392 RVA: 0x003C46A0 File Offset: 0x003C28A0
		public static ITrackRuleTypeBase GetRootAsITrackRuleTypeBase(ByteBuffer _bb, ITrackRuleTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A769 RID: 108393 RVA: 0x003C46BD File Offset: 0x003C28BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A76A RID: 108394 RVA: 0x003C46CC File Offset: 0x003C28CC
		public ITrackRuleTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E5C RID: 32348
		// (get) Token: 0x0601A76B RID: 108395 RVA: 0x003C46DC File Offset: 0x003C28DC
		public ETrackRuleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrackRuleType.FindLastMatchState;
				}
				return (ETrackRuleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A76C RID: 108396 RVA: 0x003C4718 File Offset: 0x003C2918
		public static Offset<ITrackRuleTypeBase> CreateITrackRuleTypeBase(FlatBufferBuilder builder, ETrackRuleType Type = ETrackRuleType.FindLastMatchState)
		{
			builder.StartTable(1);
			ITrackRuleTypeBase.AddType(builder, Type);
			return ITrackRuleTypeBase.EndITrackRuleTypeBase(builder);
		}

		// Token: 0x0601A76D RID: 108397 RVA: 0x003C472E File Offset: 0x003C292E
		public static void StartITrackRuleTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A76E RID: 108398 RVA: 0x003C4737 File Offset: 0x003C2937
		public static void AddType(FlatBufferBuilder builder, ETrackRuleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A76F RID: 108399 RVA: 0x003C4742 File Offset: 0x003C2942
		public static Offset<ITrackRuleTypeBase> EndITrackRuleTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<ITrackRuleTypeBase>(builder.EndTable());
		}

		// Token: 0x0601A770 RID: 108400 RVA: 0x003C4750 File Offset: 0x003C2950
		public ITrackRuleTypeBaseT UnPack()
		{
			ITrackRuleTypeBaseT trackRuleTypeBaseT = new ITrackRuleTypeBaseT();
			this.UnPackTo(trackRuleTypeBaseT);
			return trackRuleTypeBaseT;
		}

		// Token: 0x0601A771 RID: 108401 RVA: 0x003C476B File Offset: 0x003C296B
		public void UnPackTo(ITrackRuleTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A772 RID: 108402 RVA: 0x003C477C File Offset: 0x003C297C
		public static Offset<ITrackRuleTypeBase> Pack(FlatBufferBuilder builder, ITrackRuleTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrackRuleTypeBase>);
			}
			return ITrackRuleTypeBase.CreateITrackRuleTypeBase(builder, _o.Type);
		}

		// Token: 0x0400C892 RID: 51346
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006684 RID: 26244
	public struct IEnableSkillOperation : IFlatbufferObject
	{
		// Token: 0x1700C30F RID: 49935
		// (get) Token: 0x0602D9CB RID: 186827 RVA: 0x0063E660 File Offset: 0x0063C860
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D9CC RID: 186828 RVA: 0x0063E66D File Offset: 0x0063C86D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D9CD RID: 186829 RVA: 0x0063E674 File Offset: 0x0063C874
		public static IEnableSkillOperation GetRootAsIEnableSkillOperation(ByteBuffer _bb)
		{
			return IEnableSkillOperation.GetRootAsIEnableSkillOperation(_bb, default(IEnableSkillOperation));
		}

		// Token: 0x0602D9CE RID: 186830 RVA: 0x0063E690 File Offset: 0x0063C890
		public static IEnableSkillOperation GetRootAsIEnableSkillOperation(ByteBuffer _bb, IEnableSkillOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D9CF RID: 186831 RVA: 0x0063E6AD File Offset: 0x0063C8AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D9D0 RID: 186832 RVA: 0x0063E6BC File Offset: 0x0063C8BC
		public IEnableSkillOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C310 RID: 49936
		// (get) Token: 0x0602D9D1 RID: 186833 RVA: 0x0063E6CC File Offset: 0x0063C8CC
		public ESkillOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESkillOperationType.Enable;
				}
				return (ESkillOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D9D2 RID: 186834 RVA: 0x0063E708 File Offset: 0x0063C908
		public static Offset<IEnableSkillOperation> CreateIEnableSkillOperation(FlatBufferBuilder builder, ESkillOperationType Type = ESkillOperationType.Enable)
		{
			builder.StartTable(1);
			IEnableSkillOperation.AddType(builder, Type);
			return IEnableSkillOperation.EndIEnableSkillOperation(builder);
		}

		// Token: 0x0602D9D3 RID: 186835 RVA: 0x0063E71E File Offset: 0x0063C91E
		public static void StartIEnableSkillOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D9D4 RID: 186836 RVA: 0x0063E727 File Offset: 0x0063C927
		public static void AddType(FlatBufferBuilder builder, ESkillOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D9D5 RID: 186837 RVA: 0x0063E732 File Offset: 0x0063C932
		public static Offset<IEnableSkillOperation> EndIEnableSkillOperation(FlatBufferBuilder builder)
		{
			return new Offset<IEnableSkillOperation>(builder.EndTable());
		}

		// Token: 0x0602D9D6 RID: 186838 RVA: 0x0063E740 File Offset: 0x0063C940
		public IEnableSkillOperationT UnPack()
		{
			IEnableSkillOperationT enableSkillOperationT = new IEnableSkillOperationT();
			this.UnPackTo(enableSkillOperationT);
			return enableSkillOperationT;
		}

		// Token: 0x0602D9D7 RID: 186839 RVA: 0x0063E75B File Offset: 0x0063C95B
		public void UnPackTo(IEnableSkillOperationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602D9D8 RID: 186840 RVA: 0x0063E76C File Offset: 0x0063C96C
		public static Offset<IEnableSkillOperation> Pack(FlatBufferBuilder builder, IEnableSkillOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableSkillOperation>);
			}
			return IEnableSkillOperation.CreateIEnableSkillOperation(builder, _o.Type);
		}

		// Token: 0x04010D3B RID: 68923
		private Table __p;
	}
}

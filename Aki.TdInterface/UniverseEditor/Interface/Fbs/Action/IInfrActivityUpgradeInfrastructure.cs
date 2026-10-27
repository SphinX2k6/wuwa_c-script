using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006954 RID: 26964
	public struct IInfrActivityUpgradeInfrastructure : IFlatbufferObject
	{
		// Token: 0x1700C803 RID: 51203
		// (get) Token: 0x0602F144 RID: 192836 RVA: 0x0066A826 File Offset: 0x00668A26
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F145 RID: 192837 RVA: 0x0066A833 File Offset: 0x00668A33
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F146 RID: 192838 RVA: 0x0066A83C File Offset: 0x00668A3C
		public static IInfrActivityUpgradeInfrastructure GetRootAsIInfrActivityUpgradeInfrastructure(ByteBuffer _bb)
		{
			return IInfrActivityUpgradeInfrastructure.GetRootAsIInfrActivityUpgradeInfrastructure(_bb, default(IInfrActivityUpgradeInfrastructure));
		}

		// Token: 0x0602F147 RID: 192839 RVA: 0x0066A858 File Offset: 0x00668A58
		public static IInfrActivityUpgradeInfrastructure GetRootAsIInfrActivityUpgradeInfrastructure(ByteBuffer _bb, IInfrActivityUpgradeInfrastructure obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F148 RID: 192840 RVA: 0x0066A875 File Offset: 0x00668A75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F149 RID: 192841 RVA: 0x0066A884 File Offset: 0x00668A84
		public IInfrActivityUpgradeInfrastructure __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C804 RID: 51204
		// (get) Token: 0x0602F14A RID: 192842 RVA: 0x0066A894 File Offset: 0x00668A94
		public int Level
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F14B RID: 192843 RVA: 0x0066A8D0 File Offset: 0x00668AD0
		public static Offset<IInfrActivityUpgradeInfrastructure> CreateIInfrActivityUpgradeInfrastructure(FlatBufferBuilder builder, int Level = 0)
		{
			builder.StartTable(1);
			IInfrActivityUpgradeInfrastructure.AddLevel(builder, Level);
			return IInfrActivityUpgradeInfrastructure.EndIInfrActivityUpgradeInfrastructure(builder);
		}

		// Token: 0x0602F14C RID: 192844 RVA: 0x0066A8E6 File Offset: 0x00668AE6
		public static void StartIInfrActivityUpgradeInfrastructure(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F14D RID: 192845 RVA: 0x0066A8EF File Offset: 0x00668AEF
		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(0, level, 0);
		}

		// Token: 0x0602F14E RID: 192846 RVA: 0x0066A8FA File Offset: 0x00668AFA
		public static Offset<IInfrActivityUpgradeInfrastructure> EndIInfrActivityUpgradeInfrastructure(FlatBufferBuilder builder)
		{
			return new Offset<IInfrActivityUpgradeInfrastructure>(builder.EndTable());
		}

		// Token: 0x0602F14F RID: 192847 RVA: 0x0066A908 File Offset: 0x00668B08
		public IInfrActivityUpgradeInfrastructureT UnPack()
		{
			IInfrActivityUpgradeInfrastructureT infrActivityUpgradeInfrastructureT = new IInfrActivityUpgradeInfrastructureT();
			this.UnPackTo(infrActivityUpgradeInfrastructureT);
			return infrActivityUpgradeInfrastructureT;
		}

		// Token: 0x0602F150 RID: 192848 RVA: 0x0066A923 File Offset: 0x00668B23
		public void UnPackTo(IInfrActivityUpgradeInfrastructureT _o)
		{
			_o.Level = this.Level;
		}

		// Token: 0x0602F151 RID: 192849 RVA: 0x0066A934 File Offset: 0x00668B34
		public static Offset<IInfrActivityUpgradeInfrastructure> Pack(FlatBufferBuilder builder, IInfrActivityUpgradeInfrastructureT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInfrActivityUpgradeInfrastructure>);
			}
			return IInfrActivityUpgradeInfrastructure.CreateIInfrActivityUpgradeInfrastructure(builder, _o.Level);
		}

		// Token: 0x040110D5 RID: 69845
		private Table __p;
	}
}

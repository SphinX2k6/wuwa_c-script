using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006951 RID: 26961
	public struct IInfrActivityRoadProcess : IFlatbufferObject
	{
		// Token: 0x1700C7FE RID: 51198
		// (get) Token: 0x0602F12E RID: 192814 RVA: 0x0066A626 File Offset: 0x00668826
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F12F RID: 192815 RVA: 0x0066A633 File Offset: 0x00668833
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F130 RID: 192816 RVA: 0x0066A63C File Offset: 0x0066883C
		public static IInfrActivityRoadProcess GetRootAsIInfrActivityRoadProcess(ByteBuffer _bb)
		{
			return IInfrActivityRoadProcess.GetRootAsIInfrActivityRoadProcess(_bb, default(IInfrActivityRoadProcess));
		}

		// Token: 0x0602F131 RID: 192817 RVA: 0x0066A658 File Offset: 0x00668858
		public static IInfrActivityRoadProcess GetRootAsIInfrActivityRoadProcess(ByteBuffer _bb, IInfrActivityRoadProcess obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F132 RID: 192818 RVA: 0x0066A675 File Offset: 0x00668875
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F133 RID: 192819 RVA: 0x0066A684 File Offset: 0x00668884
		public IInfrActivityRoadProcess __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7FF RID: 51199
		// (get) Token: 0x0602F134 RID: 192820 RVA: 0x0066A694 File Offset: 0x00668894
		public EInfrActivityBuildStageType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInfrActivityBuildStageType.Infrastructure;
				}
				return (EInfrActivityBuildStageType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C800 RID: 51200
		// (get) Token: 0x0602F135 RID: 192821 RVA: 0x0066A6D0 File Offset: 0x006688D0
		public int Id
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F136 RID: 192822 RVA: 0x0066A70C File Offset: 0x0066890C
		public static Offset<IInfrActivityRoadProcess> CreateIInfrActivityRoadProcess(FlatBufferBuilder builder, EInfrActivityBuildStageType Type = EInfrActivityBuildStageType.Infrastructure, int Id = 0)
		{
			builder.StartTable(2);
			IInfrActivityRoadProcess.AddId(builder, Id);
			IInfrActivityRoadProcess.AddType(builder, Type);
			return IInfrActivityRoadProcess.EndIInfrActivityRoadProcess(builder);
		}

		// Token: 0x0602F137 RID: 192823 RVA: 0x0066A729 File Offset: 0x00668929
		public static void StartIInfrActivityRoadProcess(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F138 RID: 192824 RVA: 0x0066A732 File Offset: 0x00668932
		public static void AddType(FlatBufferBuilder builder, EInfrActivityBuildStageType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F139 RID: 192825 RVA: 0x0066A73D File Offset: 0x0066893D
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602F13A RID: 192826 RVA: 0x0066A748 File Offset: 0x00668948
		public static Offset<IInfrActivityRoadProcess> EndIInfrActivityRoadProcess(FlatBufferBuilder builder)
		{
			return new Offset<IInfrActivityRoadProcess>(builder.EndTable());
		}

		// Token: 0x0602F13B RID: 192827 RVA: 0x0066A758 File Offset: 0x00668958
		public IInfrActivityRoadProcessT UnPack()
		{
			IInfrActivityRoadProcessT infrActivityRoadProcessT = new IInfrActivityRoadProcessT();
			this.UnPackTo(infrActivityRoadProcessT);
			return infrActivityRoadProcessT;
		}

		// Token: 0x0602F13C RID: 192828 RVA: 0x0066A773 File Offset: 0x00668973
		public void UnPackTo(IInfrActivityRoadProcessT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0602F13D RID: 192829 RVA: 0x0066A790 File Offset: 0x00668990
		public static Offset<IInfrActivityRoadProcess> Pack(FlatBufferBuilder builder, IInfrActivityRoadProcessT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInfrActivityRoadProcess>);
			}
			return IInfrActivityRoadProcess.CreateIInfrActivityRoadProcess(builder, _o.Type, _o.Id);
		}

		// Token: 0x040110D2 RID: 69842
		private Table __p;
	}
}

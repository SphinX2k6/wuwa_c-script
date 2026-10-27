using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063AC RID: 25516
	public struct IClientEventTarget : IFlatbufferObject
	{
		// Token: 0x1700BE32 RID: 48690
		// (get) Token: 0x0602C23F RID: 180799 RVA: 0x0060FD37 File Offset: 0x0060DF37
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C240 RID: 180800 RVA: 0x0060FD44 File Offset: 0x0060DF44
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C241 RID: 180801 RVA: 0x0060FD4C File Offset: 0x0060DF4C
		public static IClientEventTarget GetRootAsIClientEventTarget(ByteBuffer _bb)
		{
			return IClientEventTarget.GetRootAsIClientEventTarget(_bb, default(IClientEventTarget));
		}

		// Token: 0x0602C242 RID: 180802 RVA: 0x0060FD68 File Offset: 0x0060DF68
		public static IClientEventTarget GetRootAsIClientEventTarget(ByteBuffer _bb, IClientEventTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C243 RID: 180803 RVA: 0x0060FD85 File Offset: 0x0060DF85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C244 RID: 180804 RVA: 0x0060FD94 File Offset: 0x0060DF94
		public IClientEventTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE33 RID: 48691
		// (get) Token: 0x0602C245 RID: 180805 RVA: 0x0060FDA4 File Offset: 0x0060DFA4
		public EClientEventTarget Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientEventTarget.Self;
				}
				return (EClientEventTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C246 RID: 180806 RVA: 0x0060FDE0 File Offset: 0x0060DFE0
		public static Offset<IClientEventTarget> CreateIClientEventTarget(FlatBufferBuilder builder, EClientEventTarget Type = EClientEventTarget.Self)
		{
			builder.StartTable(1);
			IClientEventTarget.AddType(builder, Type);
			return IClientEventTarget.EndIClientEventTarget(builder);
		}

		// Token: 0x0602C247 RID: 180807 RVA: 0x0060FDF6 File Offset: 0x0060DFF6
		public static void StartIClientEventTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C248 RID: 180808 RVA: 0x0060FDFF File Offset: 0x0060DFFF
		public static void AddType(FlatBufferBuilder builder, EClientEventTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C249 RID: 180809 RVA: 0x0060FE0A File Offset: 0x0060E00A
		public static Offset<IClientEventTarget> EndIClientEventTarget(FlatBufferBuilder builder)
		{
			return new Offset<IClientEventTarget>(builder.EndTable());
		}

		// Token: 0x0602C24A RID: 180810 RVA: 0x0060FE18 File Offset: 0x0060E018
		public IClientEventTargetT UnPack()
		{
			IClientEventTargetT clientEventTargetT = new IClientEventTargetT();
			this.UnPackTo(clientEventTargetT);
			return clientEventTargetT;
		}

		// Token: 0x0602C24B RID: 180811 RVA: 0x0060FE33 File Offset: 0x0060E033
		public void UnPackTo(IClientEventTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602C24C RID: 180812 RVA: 0x0060FE44 File Offset: 0x0060E044
		public static Offset<IClientEventTarget> Pack(FlatBufferBuilder builder, IClientEventTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientEventTarget>);
			}
			return IClientEventTarget.CreateIClientEventTarget(builder, _o.Type);
		}

		// Token: 0x04010980 RID: 67968
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066D6 RID: 26326
	public struct IActionContextType : IFlatbufferObject
	{
		// Token: 0x1700BF66 RID: 48998
		// (get) Token: 0x0602C3C2 RID: 181186 RVA: 0x00606020 File Offset: 0x00604220
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C3C3 RID: 181187 RVA: 0x0060602D File Offset: 0x0060422D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C3C4 RID: 181188 RVA: 0x00606034 File Offset: 0x00604234
		public static IActionContextType GetRootAsIActionContextType(ByteBuffer _bb)
		{
			return IActionContextType.GetRootAsIActionContextType(_bb, default(IActionContextType));
		}

		// Token: 0x0602C3C5 RID: 181189 RVA: 0x00606050 File Offset: 0x00604250
		public static IActionContextType GetRootAsIActionContextType(ByteBuffer _bb, IActionContextType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C3C6 RID: 181190 RVA: 0x0060606D File Offset: 0x0060426D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C3C7 RID: 181191 RVA: 0x0060607C File Offset: 0x0060427C
		public IActionContextType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF67 RID: 48999
		// (get) Token: 0x0602C3C8 RID: 181192 RVA: 0x0060608C File Offset: 0x0060428C
		public TActionContextType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TActionContextType.commonBt;
				}
				return (TActionContextType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C3C9 RID: 181193 RVA: 0x006060C8 File Offset: 0x006042C8
		public static Offset<IActionContextType> CreateIActionContextType(FlatBufferBuilder builder, TActionContextType Type = TActionContextType.commonBt)
		{
			builder.StartTable(1);
			IActionContextType.AddType(builder, Type);
			return IActionContextType.EndIActionContextType(builder);
		}

		// Token: 0x0602C3CA RID: 181194 RVA: 0x006060DE File Offset: 0x006042DE
		public static void StartIActionContextType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C3CB RID: 181195 RVA: 0x006060E7 File Offset: 0x006042E7
		public static void AddType(FlatBufferBuilder builder, TActionContextType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C3CC RID: 181196 RVA: 0x006060F2 File Offset: 0x006042F2
		public static Offset<IActionContextType> EndIActionContextType(FlatBufferBuilder builder)
		{
			return new Offset<IActionContextType>(builder.EndTable());
		}

		// Token: 0x0602C3CD RID: 181197 RVA: 0x00606100 File Offset: 0x00604300
		public IActionContextTypeT UnPack()
		{
			IActionContextTypeT actionContextTypeT = new IActionContextTypeT();
			this.UnPackTo(actionContextTypeT);
			return actionContextTypeT;
		}

		// Token: 0x0602C3CE RID: 181198 RVA: 0x0060611B File Offset: 0x0060431B
		public void UnPackTo(IActionContextTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602C3CF RID: 181199 RVA: 0x0060612C File Offset: 0x0060432C
		public static Offset<IActionContextType> Pack(FlatBufferBuilder builder, IActionContextTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActionContextType>);
			}
			return IActionContextType.CreateIActionContextType(builder, _o.Type);
		}

		// Token: 0x04011031 RID: 69681
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A44 RID: 27204
	public struct ILongPressInteractStyleConfigDefault : IFlatbufferObject
	{
		// Token: 0x1700C9D8 RID: 51672
		// (get) Token: 0x0602FA1A RID: 195098 RVA: 0x0067BDAD File Offset: 0x00679FAD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FA1B RID: 195099 RVA: 0x0067BDBA File Offset: 0x00679FBA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FA1C RID: 195100 RVA: 0x0067BDC4 File Offset: 0x00679FC4
		public static ILongPressInteractStyleConfigDefault GetRootAsILongPressInteractStyleConfigDefault(ByteBuffer _bb)
		{
			return ILongPressInteractStyleConfigDefault.GetRootAsILongPressInteractStyleConfigDefault(_bb, default(ILongPressInteractStyleConfigDefault));
		}

		// Token: 0x0602FA1D RID: 195101 RVA: 0x0067BDE0 File Offset: 0x00679FE0
		public static ILongPressInteractStyleConfigDefault GetRootAsILongPressInteractStyleConfigDefault(ByteBuffer _bb, ILongPressInteractStyleConfigDefault obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FA1E RID: 195102 RVA: 0x0067BDFD File Offset: 0x00679FFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FA1F RID: 195103 RVA: 0x0067BE0C File Offset: 0x0067A00C
		public ILongPressInteractStyleConfigDefault __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9D9 RID: 51673
		// (get) Token: 0x0602FA20 RID: 195104 RVA: 0x0067BE1C File Offset: 0x0067A01C
		public ELongPressInteractStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELongPressInteractStyle.Default;
				}
				return (ELongPressInteractStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FA21 RID: 195105 RVA: 0x0067BE58 File Offset: 0x0067A058
		public static Offset<ILongPressInteractStyleConfigDefault> CreateILongPressInteractStyleConfigDefault(FlatBufferBuilder builder, ELongPressInteractStyle Type = ELongPressInteractStyle.Default)
		{
			builder.StartTable(1);
			ILongPressInteractStyleConfigDefault.AddType(builder, Type);
			return ILongPressInteractStyleConfigDefault.EndILongPressInteractStyleConfigDefault(builder);
		}

		// Token: 0x0602FA22 RID: 195106 RVA: 0x0067BE6E File Offset: 0x0067A06E
		public static void StartILongPressInteractStyleConfigDefault(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FA23 RID: 195107 RVA: 0x0067BE77 File Offset: 0x0067A077
		public static void AddType(FlatBufferBuilder builder, ELongPressInteractStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FA24 RID: 195108 RVA: 0x0067BE82 File Offset: 0x0067A082
		public static Offset<ILongPressInteractStyleConfigDefault> EndILongPressInteractStyleConfigDefault(FlatBufferBuilder builder)
		{
			return new Offset<ILongPressInteractStyleConfigDefault>(builder.EndTable());
		}

		// Token: 0x0602FA25 RID: 195109 RVA: 0x0067BE90 File Offset: 0x0067A090
		public ILongPressInteractStyleConfigDefaultT UnPack()
		{
			ILongPressInteractStyleConfigDefaultT longPressInteractStyleConfigDefaultT = new ILongPressInteractStyleConfigDefaultT();
			this.UnPackTo(longPressInteractStyleConfigDefaultT);
			return longPressInteractStyleConfigDefaultT;
		}

		// Token: 0x0602FA26 RID: 195110 RVA: 0x0067BEAB File Offset: 0x0067A0AB
		public void UnPackTo(ILongPressInteractStyleConfigDefaultT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FA27 RID: 195111 RVA: 0x0067BEBC File Offset: 0x0067A0BC
		public static Offset<ILongPressInteractStyleConfigDefault> Pack(FlatBufferBuilder builder, ILongPressInteractStyleConfigDefaultT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILongPressInteractStyleConfigDefault>);
			}
			return ILongPressInteractStyleConfigDefault.CreateILongPressInteractStyleConfigDefault(builder, _o.Type);
		}

		// Token: 0x0401125E RID: 70238
		private Table __p;
	}
}

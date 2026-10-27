using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AA3 RID: 27299
	public struct IMinAlertValue : IFlatbufferObject
	{
		// Token: 0x1700CA9A RID: 51866
		// (get) Token: 0x0602FD64 RID: 195940 RVA: 0x006820A0 File Offset: 0x006802A0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FD65 RID: 195941 RVA: 0x006820AD File Offset: 0x006802AD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FD66 RID: 195942 RVA: 0x006820B4 File Offset: 0x006802B4
		public static IMinAlertValue GetRootAsIMinAlertValue(ByteBuffer _bb)
		{
			return IMinAlertValue.GetRootAsIMinAlertValue(_bb, default(IMinAlertValue));
		}

		// Token: 0x0602FD67 RID: 195943 RVA: 0x006820D0 File Offset: 0x006802D0
		public static IMinAlertValue GetRootAsIMinAlertValue(ByteBuffer _bb, IMinAlertValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FD68 RID: 195944 RVA: 0x006820ED File Offset: 0x006802ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FD69 RID: 195945 RVA: 0x006820FC File Offset: 0x006802FC
		public IMinAlertValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA9B RID: 51867
		// (get) Token: 0x0602FD6A RID: 195946 RVA: 0x0068210C File Offset: 0x0068030C
		public EValueChangeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EValueChangeType.AddOrSub;
				}
				return (EValueChangeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FD6B RID: 195947 RVA: 0x00682148 File Offset: 0x00680348
		public static Offset<IMinAlertValue> CreateIMinAlertValue(FlatBufferBuilder builder, EValueChangeType Type = EValueChangeType.AddOrSub)
		{
			builder.StartTable(1);
			IMinAlertValue.AddType(builder, Type);
			return IMinAlertValue.EndIMinAlertValue(builder);
		}

		// Token: 0x0602FD6C RID: 195948 RVA: 0x0068215E File Offset: 0x0068035E
		public static void StartIMinAlertValue(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FD6D RID: 195949 RVA: 0x00682167 File Offset: 0x00680367
		public static void AddType(FlatBufferBuilder builder, EValueChangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FD6E RID: 195950 RVA: 0x00682172 File Offset: 0x00680372
		public static Offset<IMinAlertValue> EndIMinAlertValue(FlatBufferBuilder builder)
		{
			return new Offset<IMinAlertValue>(builder.EndTable());
		}

		// Token: 0x0602FD6F RID: 195951 RVA: 0x00682180 File Offset: 0x00680380
		public IMinAlertValueT UnPack()
		{
			IMinAlertValueT minAlertValueT = new IMinAlertValueT();
			this.UnPackTo(minAlertValueT);
			return minAlertValueT;
		}

		// Token: 0x0602FD70 RID: 195952 RVA: 0x0068219B File Offset: 0x0068039B
		public void UnPackTo(IMinAlertValueT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FD71 RID: 195953 RVA: 0x006821AC File Offset: 0x006803AC
		public static Offset<IMinAlertValue> Pack(FlatBufferBuilder builder, IMinAlertValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMinAlertValue>);
			}
			return IMinAlertValue.CreateIMinAlertValue(builder, _o.Type);
		}

		// Token: 0x040112E0 RID: 70368
		private Table __p;
	}
}

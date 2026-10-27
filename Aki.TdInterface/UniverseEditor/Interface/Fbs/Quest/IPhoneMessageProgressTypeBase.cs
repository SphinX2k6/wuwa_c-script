using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F7A RID: 16250
	public struct IPhoneMessageProgressTypeBase : IFlatbufferObject
	{
		// Token: 0x1700716F RID: 29039
		// (get) Token: 0x0601731E RID: 95006 RVA: 0x00358D38 File Offset: 0x00356F38
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601731F RID: 95007 RVA: 0x00358D45 File Offset: 0x00356F45
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017320 RID: 95008 RVA: 0x00358D4C File Offset: 0x00356F4C
		public static IPhoneMessageProgressTypeBase GetRootAsIPhoneMessageProgressTypeBase(ByteBuffer _bb)
		{
			return IPhoneMessageProgressTypeBase.GetRootAsIPhoneMessageProgressTypeBase(_bb, default(IPhoneMessageProgressTypeBase));
		}

		// Token: 0x06017321 RID: 95009 RVA: 0x00358D68 File Offset: 0x00356F68
		public static IPhoneMessageProgressTypeBase GetRootAsIPhoneMessageProgressTypeBase(ByteBuffer _bb, IPhoneMessageProgressTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017322 RID: 95010 RVA: 0x00358D85 File Offset: 0x00356F85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017323 RID: 95011 RVA: 0x00358D94 File Offset: 0x00356F94
		public IPhoneMessageProgressTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007170 RID: 29040
		// (get) Token: 0x06017324 RID: 95012 RVA: 0x00358DA4 File Offset: 0x00356FA4
		public EPhoneMessageProgressType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhoneMessageProgressType.CompleteMessage;
				}
				return (EPhoneMessageProgressType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017325 RID: 95013 RVA: 0x00358DE0 File Offset: 0x00356FE0
		public static Offset<IPhoneMessageProgressTypeBase> CreateIPhoneMessageProgressTypeBase(FlatBufferBuilder builder, EPhoneMessageProgressType Type = EPhoneMessageProgressType.CompleteMessage)
		{
			builder.StartTable(1);
			IPhoneMessageProgressTypeBase.AddType(builder, Type);
			return IPhoneMessageProgressTypeBase.EndIPhoneMessageProgressTypeBase(builder);
		}

		// Token: 0x06017326 RID: 95014 RVA: 0x00358DF6 File Offset: 0x00356FF6
		public static void StartIPhoneMessageProgressTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06017327 RID: 95015 RVA: 0x00358DFF File Offset: 0x00356FFF
		public static void AddType(FlatBufferBuilder builder, EPhoneMessageProgressType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017328 RID: 95016 RVA: 0x00358E0A File Offset: 0x0035700A
		public static Offset<IPhoneMessageProgressTypeBase> EndIPhoneMessageProgressTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<IPhoneMessageProgressTypeBase>(builder.EndTable());
		}

		// Token: 0x06017329 RID: 95017 RVA: 0x00358E18 File Offset: 0x00357018
		public IPhoneMessageProgressTypeBaseT UnPack()
		{
			IPhoneMessageProgressTypeBaseT phoneMessageProgressTypeBaseT = new IPhoneMessageProgressTypeBaseT();
			this.UnPackTo(phoneMessageProgressTypeBaseT);
			return phoneMessageProgressTypeBaseT;
		}

		// Token: 0x0601732A RID: 95018 RVA: 0x00358E33 File Offset: 0x00357033
		public void UnPackTo(IPhoneMessageProgressTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601732B RID: 95019 RVA: 0x00358E44 File Offset: 0x00357044
		public static Offset<IPhoneMessageProgressTypeBase> Pack(FlatBufferBuilder builder, IPhoneMessageProgressTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhoneMessageProgressTypeBase>);
			}
			return IPhoneMessageProgressTypeBase.CreateIPhoneMessageProgressTypeBase(builder, _o.Type);
		}

		// Token: 0x0400B9CD RID: 47565
		private Table __p;
	}
}

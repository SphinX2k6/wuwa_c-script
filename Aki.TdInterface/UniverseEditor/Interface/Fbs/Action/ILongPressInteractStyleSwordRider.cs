using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A50 RID: 27216
	public struct ILongPressInteractStyleSwordRider : IFlatbufferObject
	{
		// Token: 0x1700C9E9 RID: 51689
		// (get) Token: 0x0602FA70 RID: 195184 RVA: 0x0067C5C5 File Offset: 0x0067A7C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FA71 RID: 195185 RVA: 0x0067C5D2 File Offset: 0x0067A7D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FA72 RID: 195186 RVA: 0x0067C5DC File Offset: 0x0067A7DC
		public static ILongPressInteractStyleSwordRider GetRootAsILongPressInteractStyleSwordRider(ByteBuffer _bb)
		{
			return ILongPressInteractStyleSwordRider.GetRootAsILongPressInteractStyleSwordRider(_bb, default(ILongPressInteractStyleSwordRider));
		}

		// Token: 0x0602FA73 RID: 195187 RVA: 0x0067C5F8 File Offset: 0x0067A7F8
		public static ILongPressInteractStyleSwordRider GetRootAsILongPressInteractStyleSwordRider(ByteBuffer _bb, ILongPressInteractStyleSwordRider obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FA74 RID: 195188 RVA: 0x0067C615 File Offset: 0x0067A815
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FA75 RID: 195189 RVA: 0x0067C624 File Offset: 0x0067A824
		public ILongPressInteractStyleSwordRider __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9EA RID: 51690
		// (get) Token: 0x0602FA76 RID: 195190 RVA: 0x0067C634 File Offset: 0x0067A834
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

		// Token: 0x0602FA77 RID: 195191 RVA: 0x0067C670 File Offset: 0x0067A870
		public static Offset<ILongPressInteractStyleSwordRider> CreateILongPressInteractStyleSwordRider(FlatBufferBuilder builder, ELongPressInteractStyle Type = ELongPressInteractStyle.Default)
		{
			builder.StartTable(1);
			ILongPressInteractStyleSwordRider.AddType(builder, Type);
			return ILongPressInteractStyleSwordRider.EndILongPressInteractStyleSwordRider(builder);
		}

		// Token: 0x0602FA78 RID: 195192 RVA: 0x0067C686 File Offset: 0x0067A886
		public static void StartILongPressInteractStyleSwordRider(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FA79 RID: 195193 RVA: 0x0067C68F File Offset: 0x0067A88F
		public static void AddType(FlatBufferBuilder builder, ELongPressInteractStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FA7A RID: 195194 RVA: 0x0067C69A File Offset: 0x0067A89A
		public static Offset<ILongPressInteractStyleSwordRider> EndILongPressInteractStyleSwordRider(FlatBufferBuilder builder)
		{
			return new Offset<ILongPressInteractStyleSwordRider>(builder.EndTable());
		}

		// Token: 0x0602FA7B RID: 195195 RVA: 0x0067C6A8 File Offset: 0x0067A8A8
		public ILongPressInteractStyleSwordRiderT UnPack()
		{
			ILongPressInteractStyleSwordRiderT longPressInteractStyleSwordRiderT = new ILongPressInteractStyleSwordRiderT();
			this.UnPackTo(longPressInteractStyleSwordRiderT);
			return longPressInteractStyleSwordRiderT;
		}

		// Token: 0x0602FA7C RID: 195196 RVA: 0x0067C6C3 File Offset: 0x0067A8C3
		public void UnPackTo(ILongPressInteractStyleSwordRiderT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FA7D RID: 195197 RVA: 0x0067C6D4 File Offset: 0x0067A8D4
		public static Offset<ILongPressInteractStyleSwordRider> Pack(FlatBufferBuilder builder, ILongPressInteractStyleSwordRiderT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILongPressInteractStyleSwordRider>);
			}
			return ILongPressInteractStyleSwordRider.CreateILongPressInteractStyleSwordRider(builder, _o.Type);
		}

		// Token: 0x04011270 RID: 70256
		private Table __p;
	}
}

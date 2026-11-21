using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BD8 RID: 31704
	public struct IToggleAirWallType : IFlatbufferObject
	{
		// Token: 0x1700ED7D RID: 60797
		// (get) Token: 0x06039248 RID: 234056 RVA: 0x007B8C3B File Offset: 0x007B6E3B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039249 RID: 234057 RVA: 0x007B8C48 File Offset: 0x007B6E48
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603924A RID: 234058 RVA: 0x007B8C50 File Offset: 0x007B6E50
		public static IToggleAirWallType GetRootAsIToggleAirWallType(ByteBuffer _bb)
		{
			return IToggleAirWallType.GetRootAsIToggleAirWallType(_bb, default(IToggleAirWallType));
		}

		// Token: 0x0603924B RID: 234059 RVA: 0x007B8C6C File Offset: 0x007B6E6C
		public static IToggleAirWallType GetRootAsIToggleAirWallType(ByteBuffer _bb, IToggleAirWallType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603924C RID: 234060 RVA: 0x007B8C89 File Offset: 0x007B6E89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603924D RID: 234061 RVA: 0x007B8C98 File Offset: 0x007B6E98
		public IToggleAirWallType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ED7E RID: 60798
		// (get) Token: 0x0603924E RID: 234062 RVA: 0x007B8CA8 File Offset: 0x007B6EA8
		public EToggleAirWall Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EToggleAirWall.Open;
				}
				return (EToggleAirWall)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603924F RID: 234063 RVA: 0x007B8CE4 File Offset: 0x007B6EE4
		public static Offset<IToggleAirWallType> CreateIToggleAirWallType(FlatBufferBuilder builder, EToggleAirWall Type = EToggleAirWall.Open)
		{
			builder.StartTable(1);
			IToggleAirWallType.AddType(builder, Type);
			return IToggleAirWallType.EndIToggleAirWallType(builder);
		}

		// Token: 0x06039250 RID: 234064 RVA: 0x007B8CFA File Offset: 0x007B6EFA
		public static void StartIToggleAirWallType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06039251 RID: 234065 RVA: 0x007B8D03 File Offset: 0x007B6F03
		public static void AddType(FlatBufferBuilder builder, EToggleAirWall type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039252 RID: 234066 RVA: 0x007B8D0E File Offset: 0x007B6F0E
		public static Offset<IToggleAirWallType> EndIToggleAirWallType(FlatBufferBuilder builder)
		{
			return new Offset<IToggleAirWallType>(builder.EndTable());
		}

		// Token: 0x06039253 RID: 234067 RVA: 0x007B8D1C File Offset: 0x007B6F1C
		public IToggleAirWallTypeT UnPack()
		{
			IToggleAirWallTypeT toggleAirWallTypeT = new IToggleAirWallTypeT();
			this.UnPackTo(toggleAirWallTypeT);
			return toggleAirWallTypeT;
		}

		// Token: 0x06039254 RID: 234068 RVA: 0x007B8D37 File Offset: 0x007B6F37
		public void UnPackTo(IToggleAirWallTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06039255 RID: 234069 RVA: 0x007B8D48 File Offset: 0x007B6F48
		public static Offset<IToggleAirWallType> Pack(FlatBufferBuilder builder, IToggleAirWallTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IToggleAirWallType>);
			}
			return IToggleAirWallType.CreateIToggleAirWallType(builder, _o.Type);
		}

		// Token: 0x04013264 RID: 78436
		private Table __p;
	}
}

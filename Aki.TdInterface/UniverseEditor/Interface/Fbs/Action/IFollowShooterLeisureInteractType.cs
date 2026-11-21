using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EDE RID: 28382
	public struct IFollowShooterLeisureInteractType : IFlatbufferObject
	{
		// Token: 0x1700D026 RID: 53286
		// (get) Token: 0x060311B1 RID: 201137 RVA: 0x006A86A8 File Offset: 0x006A68A8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060311B2 RID: 201138 RVA: 0x006A86B5 File Offset: 0x006A68B5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060311B3 RID: 201139 RVA: 0x006A86BC File Offset: 0x006A68BC
		public static IFollowShooterLeisureInteractType GetRootAsIFollowShooterLeisureInteractType(ByteBuffer _bb)
		{
			return IFollowShooterLeisureInteractType.GetRootAsIFollowShooterLeisureInteractType(_bb, default(IFollowShooterLeisureInteractType));
		}

		// Token: 0x060311B4 RID: 201140 RVA: 0x006A86D8 File Offset: 0x006A68D8
		public static IFollowShooterLeisureInteractType GetRootAsIFollowShooterLeisureInteractType(ByteBuffer _bb, IFollowShooterLeisureInteractType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060311B5 RID: 201141 RVA: 0x006A86F5 File Offset: 0x006A68F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060311B6 RID: 201142 RVA: 0x006A8704 File Offset: 0x006A6904
		public IFollowShooterLeisureInteractType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D027 RID: 53287
		// (get) Token: 0x060311B7 RID: 201143 RVA: 0x006A8714 File Offset: 0x006A6914
		public EFollowShooterLeisureInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFollowShooterLeisureInteractType.ResetToPlayer;
				}
				return (EFollowShooterLeisureInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060311B8 RID: 201144 RVA: 0x006A8750 File Offset: 0x006A6950
		public static Offset<IFollowShooterLeisureInteractType> CreateIFollowShooterLeisureInteractType(FlatBufferBuilder builder, EFollowShooterLeisureInteractType Type = EFollowShooterLeisureInteractType.ResetToPlayer)
		{
			builder.StartTable(1);
			IFollowShooterLeisureInteractType.AddType(builder, Type);
			return IFollowShooterLeisureInteractType.EndIFollowShooterLeisureInteractType(builder);
		}

		// Token: 0x060311B9 RID: 201145 RVA: 0x006A8766 File Offset: 0x006A6966
		public static void StartIFollowShooterLeisureInteractType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060311BA RID: 201146 RVA: 0x006A876F File Offset: 0x006A696F
		public static void AddType(FlatBufferBuilder builder, EFollowShooterLeisureInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060311BB RID: 201147 RVA: 0x006A877A File Offset: 0x006A697A
		public static Offset<IFollowShooterLeisureInteractType> EndIFollowShooterLeisureInteractType(FlatBufferBuilder builder)
		{
			return new Offset<IFollowShooterLeisureInteractType>(builder.EndTable());
		}

		// Token: 0x060311BC RID: 201148 RVA: 0x006A8788 File Offset: 0x006A6988
		public IFollowShooterLeisureInteractTypeT UnPack()
		{
			IFollowShooterLeisureInteractTypeT followShooterLeisureInteractTypeT = new IFollowShooterLeisureInteractTypeT();
			this.UnPackTo(followShooterLeisureInteractTypeT);
			return followShooterLeisureInteractTypeT;
		}

		// Token: 0x060311BD RID: 201149 RVA: 0x006A87A3 File Offset: 0x006A69A3
		public void UnPackTo(IFollowShooterLeisureInteractTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060311BE RID: 201150 RVA: 0x006A87B4 File Offset: 0x006A69B4
		public static Offset<IFollowShooterLeisureInteractType> Pack(FlatBufferBuilder builder, IFollowShooterLeisureInteractTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowShooterLeisureInteractType>);
			}
			return IFollowShooterLeisureInteractType.CreateIFollowShooterLeisureInteractType(builder, _o.Type);
		}

		// Token: 0x04011DDC RID: 73180
		private Table __p;
	}
}

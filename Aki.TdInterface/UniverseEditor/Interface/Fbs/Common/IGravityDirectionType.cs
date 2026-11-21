using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006437 RID: 25655
	public struct IGravityDirectionType : IFlatbufferObject
	{
		// Token: 0x1700BD6D RID: 48493
		// (get) Token: 0x0602B96C RID: 178540 RVA: 0x005EF3A9 File Offset: 0x005ED5A9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B96D RID: 178541 RVA: 0x005EF3B6 File Offset: 0x005ED5B6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B96E RID: 178542 RVA: 0x005EF3C0 File Offset: 0x005ED5C0
		public static IGravityDirectionType GetRootAsIGravityDirectionType(ByteBuffer _bb)
		{
			return IGravityDirectionType.GetRootAsIGravityDirectionType(_bb, default(IGravityDirectionType));
		}

		// Token: 0x0602B96F RID: 178543 RVA: 0x005EF3DC File Offset: 0x005ED5DC
		public static IGravityDirectionType GetRootAsIGravityDirectionType(ByteBuffer _bb, IGravityDirectionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B970 RID: 178544 RVA: 0x005EF3F9 File Offset: 0x005ED5F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B971 RID: 178545 RVA: 0x005EF408 File Offset: 0x005ED608
		public IGravityDirectionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD6E RID: 48494
		// (get) Token: 0x0602B972 RID: 178546 RVA: 0x005EF418 File Offset: 0x005ED618
		public EGravityDirectionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGravityDirectionType.SelfRotation;
				}
				return (EGravityDirectionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B973 RID: 178547 RVA: 0x005EF454 File Offset: 0x005ED654
		public static Offset<IGravityDirectionType> CreateIGravityDirectionType(FlatBufferBuilder builder, EGravityDirectionType Type = EGravityDirectionType.SelfRotation)
		{
			builder.StartTable(1);
			IGravityDirectionType.AddType(builder, Type);
			return IGravityDirectionType.EndIGravityDirectionType(builder);
		}

		// Token: 0x0602B974 RID: 178548 RVA: 0x005EF46A File Offset: 0x005ED66A
		public static void StartIGravityDirectionType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B975 RID: 178549 RVA: 0x005EF473 File Offset: 0x005ED673
		public static void AddType(FlatBufferBuilder builder, EGravityDirectionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B976 RID: 178550 RVA: 0x005EF47E File Offset: 0x005ED67E
		public static Offset<IGravityDirectionType> EndIGravityDirectionType(FlatBufferBuilder builder)
		{
			return new Offset<IGravityDirectionType>(builder.EndTable());
		}

		// Token: 0x0602B977 RID: 178551 RVA: 0x005EF48C File Offset: 0x005ED68C
		public IGravityDirectionTypeT UnPack()
		{
			IGravityDirectionTypeT gravityDirectionTypeT = new IGravityDirectionTypeT();
			this.UnPackTo(gravityDirectionTypeT);
			return gravityDirectionTypeT;
		}

		// Token: 0x0602B978 RID: 178552 RVA: 0x005EF4A7 File Offset: 0x005ED6A7
		public void UnPackTo(IGravityDirectionTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B979 RID: 178553 RVA: 0x005EF4B8 File Offset: 0x005ED6B8
		public static Offset<IGravityDirectionType> Pack(FlatBufferBuilder builder, IGravityDirectionTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGravityDirectionType>);
			}
			return IGravityDirectionType.CreateIGravityDirectionType(builder, _o.Type);
		}

		// Token: 0x04010542 RID: 66882
		private Table __p;
	}
}

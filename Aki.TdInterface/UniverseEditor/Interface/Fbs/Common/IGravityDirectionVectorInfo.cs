using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200643D RID: 25661
	public struct IGravityDirectionVectorInfo : IFlatbufferObject
	{
		// Token: 0x1700BD72 RID: 48498
		// (get) Token: 0x0602B990 RID: 178576 RVA: 0x005EF6EC File Offset: 0x005ED8EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B991 RID: 178577 RVA: 0x005EF6F9 File Offset: 0x005ED8F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B992 RID: 178578 RVA: 0x005EF700 File Offset: 0x005ED900
		public static IGravityDirectionVectorInfo GetRootAsIGravityDirectionVectorInfo(ByteBuffer _bb)
		{
			return IGravityDirectionVectorInfo.GetRootAsIGravityDirectionVectorInfo(_bb, default(IGravityDirectionVectorInfo));
		}

		// Token: 0x0602B993 RID: 178579 RVA: 0x005EF71C File Offset: 0x005ED91C
		public static IGravityDirectionVectorInfo GetRootAsIGravityDirectionVectorInfo(ByteBuffer _bb, IGravityDirectionVectorInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B994 RID: 178580 RVA: 0x005EF739 File Offset: 0x005ED939
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B995 RID: 178581 RVA: 0x005EF748 File Offset: 0x005ED948
		public IGravityDirectionVectorInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD73 RID: 48499
		// (get) Token: 0x0602B996 RID: 178582 RVA: 0x005EF758 File Offset: 0x005ED958
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

		// Token: 0x1700BD74 RID: 48500
		// (get) Token: 0x0602B997 RID: 178583 RVA: 0x005EF794 File Offset: 0x005ED994
		public IVectorInfo? Direction
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602B998 RID: 178584 RVA: 0x005EF7F1 File Offset: 0x005ED9F1
		public static Offset<IGravityDirectionVectorInfo> CreateIGravityDirectionVectorInfo(FlatBufferBuilder builder, EGravityDirectionType Type = EGravityDirectionType.SelfRotation, Offset<IVectorInfo> DirectionOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IGravityDirectionVectorInfo.AddDirection(builder, DirectionOffset);
			IGravityDirectionVectorInfo.AddType(builder, Type);
			return IGravityDirectionVectorInfo.EndIGravityDirectionVectorInfo(builder);
		}

		// Token: 0x0602B999 RID: 178585 RVA: 0x005EF80E File Offset: 0x005EDA0E
		public static void StartIGravityDirectionVectorInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B99A RID: 178586 RVA: 0x005EF817 File Offset: 0x005EDA17
		public static void AddType(FlatBufferBuilder builder, EGravityDirectionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B99B RID: 178587 RVA: 0x005EF822 File Offset: 0x005EDA22
		public static void AddDirection(FlatBufferBuilder builder, Offset<IVectorInfo> directionOffset)
		{
			builder.AddOffset(1, directionOffset.Value, 0);
		}

		// Token: 0x0602B99C RID: 178588 RVA: 0x005EF832 File Offset: 0x005EDA32
		public static Offset<IGravityDirectionVectorInfo> EndIGravityDirectionVectorInfo(FlatBufferBuilder builder)
		{
			return new Offset<IGravityDirectionVectorInfo>(builder.EndTable());
		}

		// Token: 0x0602B99D RID: 178589 RVA: 0x005EF840 File Offset: 0x005EDA40
		public IGravityDirectionVectorInfoT UnPack()
		{
			IGravityDirectionVectorInfoT gravityDirectionVectorInfoT = new IGravityDirectionVectorInfoT();
			this.UnPackTo(gravityDirectionVectorInfoT);
			return gravityDirectionVectorInfoT;
		}

		// Token: 0x0602B99E RID: 178590 RVA: 0x005EF85C File Offset: 0x005EDA5C
		public void UnPackTo(IGravityDirectionVectorInfoT _o)
		{
			_o.Type = this.Type;
			_o.Direction = ((this.Direction != null) ? this.Direction.Value.UnPack() : null);
		}

		// Token: 0x0602B99F RID: 178591 RVA: 0x005EF8A4 File Offset: 0x005EDAA4
		public static Offset<IGravityDirectionVectorInfo> Pack(FlatBufferBuilder builder, IGravityDirectionVectorInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGravityDirectionVectorInfo>);
			}
			Offset<IVectorInfo> directionOffset = (_o.Direction == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Direction);
			return IGravityDirectionVectorInfo.CreateIGravityDirectionVectorInfo(builder, _o.Type, directionOffset);
		}

		// Token: 0x0401054D RID: 66893
		private Table __p;
	}
}

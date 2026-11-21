using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200642B RID: 25643
	public struct IGiantTriggerType : IFlatbufferObject
	{
		// Token: 0x1700BD60 RID: 48480
		// (get) Token: 0x0602B922 RID: 178466 RVA: 0x005EED30 File Offset: 0x005ECF30
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B923 RID: 178467 RVA: 0x005EED3D File Offset: 0x005ECF3D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B924 RID: 178468 RVA: 0x005EED44 File Offset: 0x005ECF44
		public static IGiantTriggerType GetRootAsIGiantTriggerType(ByteBuffer _bb)
		{
			return IGiantTriggerType.GetRootAsIGiantTriggerType(_bb, default(IGiantTriggerType));
		}

		// Token: 0x0602B925 RID: 178469 RVA: 0x005EED60 File Offset: 0x005ECF60
		public static IGiantTriggerType GetRootAsIGiantTriggerType(ByteBuffer _bb, IGiantTriggerType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B926 RID: 178470 RVA: 0x005EED7D File Offset: 0x005ECF7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B927 RID: 178471 RVA: 0x005EED8C File Offset: 0x005ECF8C
		public IGiantTriggerType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD61 RID: 48481
		// (get) Token: 0x0602B928 RID: 178472 RVA: 0x005EED9C File Offset: 0x005ECF9C
		public EGiantTriggerType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGiantTriggerType.RoleState;
				}
				return (EGiantTriggerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B929 RID: 178473 RVA: 0x005EEDD8 File Offset: 0x005ECFD8
		public static Offset<IGiantTriggerType> CreateIGiantTriggerType(FlatBufferBuilder builder, EGiantTriggerType Type = EGiantTriggerType.RoleState)
		{
			builder.StartTable(1);
			IGiantTriggerType.AddType(builder, Type);
			return IGiantTriggerType.EndIGiantTriggerType(builder);
		}

		// Token: 0x0602B92A RID: 178474 RVA: 0x005EEDEE File Offset: 0x005ECFEE
		public static void StartIGiantTriggerType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B92B RID: 178475 RVA: 0x005EEDF7 File Offset: 0x005ECFF7
		public static void AddType(FlatBufferBuilder builder, EGiantTriggerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B92C RID: 178476 RVA: 0x005EEE02 File Offset: 0x005ED002
		public static Offset<IGiantTriggerType> EndIGiantTriggerType(FlatBufferBuilder builder)
		{
			return new Offset<IGiantTriggerType>(builder.EndTable());
		}

		// Token: 0x0602B92D RID: 178477 RVA: 0x005EEE10 File Offset: 0x005ED010
		public IGiantTriggerTypeT UnPack()
		{
			IGiantTriggerTypeT giantTriggerTypeT = new IGiantTriggerTypeT();
			this.UnPackTo(giantTriggerTypeT);
			return giantTriggerTypeT;
		}

		// Token: 0x0602B92E RID: 178478 RVA: 0x005EEE2B File Offset: 0x005ED02B
		public void UnPackTo(IGiantTriggerTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B92F RID: 178479 RVA: 0x005EEE3C File Offset: 0x005ED03C
		public static Offset<IGiantTriggerType> Pack(FlatBufferBuilder builder, IGiantTriggerTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantTriggerType>);
			}
			return IGiantTriggerType.CreateIGiantTriggerType(builder, _o.Type);
		}

		// Token: 0x04010533 RID: 66867
		private Table __p;
	}
}

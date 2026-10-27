using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DEE RID: 24046
	public struct IGiantTriggerType : IFlatbufferObject
	{
		// Token: 0x1700B3FA RID: 46074
		// (get) Token: 0x06029298 RID: 168600 RVA: 0x005A6000 File Offset: 0x005A4200
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029299 RID: 168601 RVA: 0x005A600D File Offset: 0x005A420D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602929A RID: 168602 RVA: 0x005A6014 File Offset: 0x005A4214
		public static IGiantTriggerType GetRootAsIGiantTriggerType(ByteBuffer _bb)
		{
			return IGiantTriggerType.GetRootAsIGiantTriggerType(_bb, default(IGiantTriggerType));
		}

		// Token: 0x0602929B RID: 168603 RVA: 0x005A6030 File Offset: 0x005A4230
		public static IGiantTriggerType GetRootAsIGiantTriggerType(ByteBuffer _bb, IGiantTriggerType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602929C RID: 168604 RVA: 0x005A604D File Offset: 0x005A424D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602929D RID: 168605 RVA: 0x005A605C File Offset: 0x005A425C
		public IGiantTriggerType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B3FB RID: 46075
		// (get) Token: 0x0602929E RID: 168606 RVA: 0x005A606C File Offset: 0x005A426C
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

		// Token: 0x0602929F RID: 168607 RVA: 0x005A60A8 File Offset: 0x005A42A8
		public static Offset<IGiantTriggerType> CreateIGiantTriggerType(FlatBufferBuilder builder, EGiantTriggerType Type = EGiantTriggerType.RoleState)
		{
			builder.StartTable(1);
			IGiantTriggerType.AddType(builder, Type);
			return IGiantTriggerType.EndIGiantTriggerType(builder);
		}

		// Token: 0x060292A0 RID: 168608 RVA: 0x005A60BE File Offset: 0x005A42BE
		public static void StartIGiantTriggerType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060292A1 RID: 168609 RVA: 0x005A60C7 File Offset: 0x005A42C7
		public static void AddType(FlatBufferBuilder builder, EGiantTriggerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060292A2 RID: 168610 RVA: 0x005A60D2 File Offset: 0x005A42D2
		public static Offset<IGiantTriggerType> EndIGiantTriggerType(FlatBufferBuilder builder)
		{
			return new Offset<IGiantTriggerType>(builder.EndTable());
		}

		// Token: 0x060292A3 RID: 168611 RVA: 0x005A60E0 File Offset: 0x005A42E0
		public IGiantTriggerTypeT UnPack()
		{
			IGiantTriggerTypeT giantTriggerTypeT = new IGiantTriggerTypeT();
			this.UnPackTo(giantTriggerTypeT);
			return giantTriggerTypeT;
		}

		// Token: 0x060292A4 RID: 168612 RVA: 0x005A60FB File Offset: 0x005A42FB
		public void UnPackTo(IGiantTriggerTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060292A5 RID: 168613 RVA: 0x005A610C File Offset: 0x005A430C
		public static Offset<IGiantTriggerType> Pack(FlatBufferBuilder builder, IGiantTriggerTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantTriggerType>);
			}
			return IGiantTriggerType.CreateIGiantTriggerType(builder, _o.Type);
		}

		// Token: 0x0400F7D8 RID: 63448
		private Table __p;
	}
}

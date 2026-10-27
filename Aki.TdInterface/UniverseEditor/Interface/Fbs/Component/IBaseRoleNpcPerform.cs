using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EEC RID: 20204
	public struct IBaseRoleNpcPerform : IFlatbufferObject
	{
		// Token: 0x1700914C RID: 37196
		// (get) Token: 0x0601FE4B RID: 130635 RVA: 0x004704BC File Offset: 0x0046E6BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FE4C RID: 130636 RVA: 0x004704C9 File Offset: 0x0046E6C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FE4D RID: 130637 RVA: 0x004704D0 File Offset: 0x0046E6D0
		public static IBaseRoleNpcPerform GetRootAsIBaseRoleNpcPerform(ByteBuffer _bb)
		{
			return IBaseRoleNpcPerform.GetRootAsIBaseRoleNpcPerform(_bb, default(IBaseRoleNpcPerform));
		}

		// Token: 0x0601FE4E RID: 130638 RVA: 0x004704EC File Offset: 0x0046E6EC
		public static IBaseRoleNpcPerform GetRootAsIBaseRoleNpcPerform(ByteBuffer _bb, IBaseRoleNpcPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FE4F RID: 130639 RVA: 0x00470509 File Offset: 0x0046E709
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FE50 RID: 130640 RVA: 0x00470518 File Offset: 0x0046E718
		public IBaseRoleNpcPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700914D RID: 37197
		// (get) Token: 0x0601FE51 RID: 130641 RVA: 0x00470528 File Offset: 0x0046E728
		public ESpecialNpcType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpecialNpcType.BaseRoleNpc;
				}
				return (ESpecialNpcType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FE52 RID: 130642 RVA: 0x00470564 File Offset: 0x0046E764
		public static Offset<IBaseRoleNpcPerform> CreateIBaseRoleNpcPerform(FlatBufferBuilder builder, ESpecialNpcType Type = ESpecialNpcType.BaseRoleNpc)
		{
			builder.StartTable(1);
			IBaseRoleNpcPerform.AddType(builder, Type);
			return IBaseRoleNpcPerform.EndIBaseRoleNpcPerform(builder);
		}

		// Token: 0x0601FE53 RID: 130643 RVA: 0x0047057A File Offset: 0x0046E77A
		public static void StartIBaseRoleNpcPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601FE54 RID: 130644 RVA: 0x00470583 File Offset: 0x0046E783
		public static void AddType(FlatBufferBuilder builder, ESpecialNpcType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FE55 RID: 130645 RVA: 0x0047058E File Offset: 0x0046E78E
		public static Offset<IBaseRoleNpcPerform> EndIBaseRoleNpcPerform(FlatBufferBuilder builder)
		{
			return new Offset<IBaseRoleNpcPerform>(builder.EndTable());
		}

		// Token: 0x0601FE56 RID: 130646 RVA: 0x0047059C File Offset: 0x0046E79C
		public IBaseRoleNpcPerformT UnPack()
		{
			IBaseRoleNpcPerformT baseRoleNpcPerformT = new IBaseRoleNpcPerformT();
			this.UnPackTo(baseRoleNpcPerformT);
			return baseRoleNpcPerformT;
		}

		// Token: 0x0601FE57 RID: 130647 RVA: 0x004705B7 File Offset: 0x0046E7B7
		public void UnPackTo(IBaseRoleNpcPerformT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601FE58 RID: 130648 RVA: 0x004705C8 File Offset: 0x0046E7C8
		public static Offset<IBaseRoleNpcPerform> Pack(FlatBufferBuilder builder, IBaseRoleNpcPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBaseRoleNpcPerform>);
			}
			return IBaseRoleNpcPerform.CreateIBaseRoleNpcPerform(builder, _o.Type);
		}

		// Token: 0x0400DD19 RID: 56601
		private Table __p;
	}
}

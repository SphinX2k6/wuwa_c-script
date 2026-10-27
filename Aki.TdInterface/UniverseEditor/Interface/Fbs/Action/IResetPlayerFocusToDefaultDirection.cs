using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E91 RID: 28305
	public struct IResetPlayerFocusToDefaultDirection : IFlatbufferObject
	{
		// Token: 0x1700D2C7 RID: 53959
		// (get) Token: 0x06032071 RID: 204913 RVA: 0x006C4404 File Offset: 0x006C2604
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032072 RID: 204914 RVA: 0x006C4411 File Offset: 0x006C2611
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032073 RID: 204915 RVA: 0x006C4418 File Offset: 0x006C2618
		public static IResetPlayerFocusToDefaultDirection GetRootAsIResetPlayerFocusToDefaultDirection(ByteBuffer _bb)
		{
			return IResetPlayerFocusToDefaultDirection.GetRootAsIResetPlayerFocusToDefaultDirection(_bb, default(IResetPlayerFocusToDefaultDirection));
		}

		// Token: 0x06032074 RID: 204916 RVA: 0x006C4434 File Offset: 0x006C2634
		public static IResetPlayerFocusToDefaultDirection GetRootAsIResetPlayerFocusToDefaultDirection(ByteBuffer _bb, IResetPlayerFocusToDefaultDirection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032075 RID: 204917 RVA: 0x006C4451 File Offset: 0x006C2651
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032076 RID: 204918 RVA: 0x006C4460 File Offset: 0x006C2660
		public IResetPlayerFocusToDefaultDirection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D2C8 RID: 53960
		// (get) Token: 0x06032077 RID: 204919 RVA: 0x006C4470 File Offset: 0x006C2670
		public EResetPlayerFocusType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EResetPlayerFocusType.ResetToDefaultDirection;
				}
				return (EResetPlayerFocusType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032078 RID: 204920 RVA: 0x006C44AC File Offset: 0x006C26AC
		public static Offset<IResetPlayerFocusToDefaultDirection> CreateIResetPlayerFocusToDefaultDirection(FlatBufferBuilder builder, EResetPlayerFocusType Type = EResetPlayerFocusType.ResetToDefaultDirection)
		{
			builder.StartTable(1);
			IResetPlayerFocusToDefaultDirection.AddType(builder, Type);
			return IResetPlayerFocusToDefaultDirection.EndIResetPlayerFocusToDefaultDirection(builder);
		}

		// Token: 0x06032079 RID: 204921 RVA: 0x006C44C2 File Offset: 0x006C26C2
		public static void StartIResetPlayerFocusToDefaultDirection(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603207A RID: 204922 RVA: 0x006C44CB File Offset: 0x006C26CB
		public static void AddType(FlatBufferBuilder builder, EResetPlayerFocusType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603207B RID: 204923 RVA: 0x006C44D6 File Offset: 0x006C26D6
		public static Offset<IResetPlayerFocusToDefaultDirection> EndIResetPlayerFocusToDefaultDirection(FlatBufferBuilder builder)
		{
			return new Offset<IResetPlayerFocusToDefaultDirection>(builder.EndTable());
		}

		// Token: 0x0603207C RID: 204924 RVA: 0x006C44E4 File Offset: 0x006C26E4
		public IResetPlayerFocusToDefaultDirectionT UnPack()
		{
			IResetPlayerFocusToDefaultDirectionT resetPlayerFocusToDefaultDirectionT = new IResetPlayerFocusToDefaultDirectionT();
			this.UnPackTo(resetPlayerFocusToDefaultDirectionT);
			return resetPlayerFocusToDefaultDirectionT;
		}

		// Token: 0x0603207D RID: 204925 RVA: 0x006C44FF File Offset: 0x006C26FF
		public void UnPackTo(IResetPlayerFocusToDefaultDirectionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603207E RID: 204926 RVA: 0x006C4510 File Offset: 0x006C2710
		public static Offset<IResetPlayerFocusToDefaultDirection> Pack(FlatBufferBuilder builder, IResetPlayerFocusToDefaultDirectionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResetPlayerFocusToDefaultDirection>);
			}
			return IResetPlayerFocusToDefaultDirection.CreateIResetPlayerFocusToDefaultDirection(builder, _o.Type);
		}

		// Token: 0x04011880 RID: 71808
		private Table __p;
	}
}

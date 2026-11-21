using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B39 RID: 31545
	public struct ITargetEntityType : IFlatbufferObject
	{
		// Token: 0x1700EC4B RID: 60491
		// (get) Token: 0x06038CF9 RID: 232697 RVA: 0x007AED4E File Offset: 0x007ACF4E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038CFA RID: 232698 RVA: 0x007AED5B File Offset: 0x007ACF5B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038CFB RID: 232699 RVA: 0x007AED64 File Offset: 0x007ACF64
		public static ITargetEntityType GetRootAsITargetEntityType(ByteBuffer _bb)
		{
			return ITargetEntityType.GetRootAsITargetEntityType(_bb, default(ITargetEntityType));
		}

		// Token: 0x06038CFC RID: 232700 RVA: 0x007AED80 File Offset: 0x007ACF80
		public static ITargetEntityType GetRootAsITargetEntityType(ByteBuffer _bb, ITargetEntityType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038CFD RID: 232701 RVA: 0x007AED9D File Offset: 0x007ACF9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038CFE RID: 232702 RVA: 0x007AEDAC File Offset: 0x007ACFAC
		public ITargetEntityType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EC4C RID: 60492
		// (get) Token: 0x06038CFF RID: 232703 RVA: 0x007AEDBC File Offset: 0x007ACFBC
		public ETargetEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetEntityType.Target;
				}
				return (ETargetEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06038D00 RID: 232704 RVA: 0x007AEDF8 File Offset: 0x007ACFF8
		public static Offset<ITargetEntityType> CreateITargetEntityType(FlatBufferBuilder builder, ETargetEntityType Type = ETargetEntityType.Target)
		{
			builder.StartTable(1);
			ITargetEntityType.AddType(builder, Type);
			return ITargetEntityType.EndITargetEntityType(builder);
		}

		// Token: 0x06038D01 RID: 232705 RVA: 0x007AEE0E File Offset: 0x007AD00E
		public static void StartITargetEntityType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06038D02 RID: 232706 RVA: 0x007AEE17 File Offset: 0x007AD017
		public static void AddType(FlatBufferBuilder builder, ETargetEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038D03 RID: 232707 RVA: 0x007AEE22 File Offset: 0x007AD022
		public static Offset<ITargetEntityType> EndITargetEntityType(FlatBufferBuilder builder)
		{
			return new Offset<ITargetEntityType>(builder.EndTable());
		}

		// Token: 0x06038D04 RID: 232708 RVA: 0x007AEE30 File Offset: 0x007AD030
		public ITargetEntityTypeT UnPack()
		{
			ITargetEntityTypeT targetEntityTypeT = new ITargetEntityTypeT();
			this.UnPackTo(targetEntityTypeT);
			return targetEntityTypeT;
		}

		// Token: 0x06038D05 RID: 232709 RVA: 0x007AEE4B File Offset: 0x007AD04B
		public void UnPackTo(ITargetEntityTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06038D06 RID: 232710 RVA: 0x007AEE5C File Offset: 0x007AD05C
		public static Offset<ITargetEntityType> Pack(FlatBufferBuilder builder, ITargetEntityTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetEntityType>);
			}
			return ITargetEntityType.CreateITargetEntityType(builder, _o.Type);
		}

		// Token: 0x04013166 RID: 78182
		private Table __p;
	}
}

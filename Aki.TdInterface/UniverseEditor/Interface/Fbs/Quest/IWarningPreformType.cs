using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046F1 RID: 18161
	public struct IWarningPreformType : IFlatbufferObject
	{
		// Token: 0x17007F39 RID: 32569
		// (get) Token: 0x0601AB81 RID: 109441 RVA: 0x003CC231 File Offset: 0x003CA431
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AB82 RID: 109442 RVA: 0x003CC23E File Offset: 0x003CA43E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AB83 RID: 109443 RVA: 0x003CC248 File Offset: 0x003CA448
		public static IWarningPreformType GetRootAsIWarningPreformType(ByteBuffer _bb)
		{
			return IWarningPreformType.GetRootAsIWarningPreformType(_bb, default(IWarningPreformType));
		}

		// Token: 0x0601AB84 RID: 109444 RVA: 0x003CC264 File Offset: 0x003CA464
		public static IWarningPreformType GetRootAsIWarningPreformType(ByteBuffer _bb, IWarningPreformType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AB85 RID: 109445 RVA: 0x003CC281 File Offset: 0x003CA481
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AB86 RID: 109446 RVA: 0x003CC290 File Offset: 0x003CA490
		public IWarningPreformType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F3A RID: 32570
		// (get) Token: 0x0601AB87 RID: 109447 RVA: 0x003CC2A0 File Offset: 0x003CA4A0
		public EWarningPreformType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWarningPreformType.FadeInScreen;
				}
				return (EWarningPreformType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601AB88 RID: 109448 RVA: 0x003CC2DC File Offset: 0x003CA4DC
		public static Offset<IWarningPreformType> CreateIWarningPreformType(FlatBufferBuilder builder, EWarningPreformType Type = EWarningPreformType.FadeInScreen)
		{
			builder.StartTable(1);
			IWarningPreformType.AddType(builder, Type);
			return IWarningPreformType.EndIWarningPreformType(builder);
		}

		// Token: 0x0601AB89 RID: 109449 RVA: 0x003CC2F2 File Offset: 0x003CA4F2
		public static void StartIWarningPreformType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601AB8A RID: 109450 RVA: 0x003CC2FB File Offset: 0x003CA4FB
		public static void AddType(FlatBufferBuilder builder, EWarningPreformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AB8B RID: 109451 RVA: 0x003CC306 File Offset: 0x003CA506
		public static Offset<IWarningPreformType> EndIWarningPreformType(FlatBufferBuilder builder)
		{
			return new Offset<IWarningPreformType>(builder.EndTable());
		}

		// Token: 0x0601AB8C RID: 109452 RVA: 0x003CC314 File Offset: 0x003CA514
		public IWarningPreformTypeT UnPack()
		{
			IWarningPreformTypeT warningPreformTypeT = new IWarningPreformTypeT();
			this.UnPackTo(warningPreformTypeT);
			return warningPreformTypeT;
		}

		// Token: 0x0601AB8D RID: 109453 RVA: 0x003CC32F File Offset: 0x003CA52F
		public void UnPackTo(IWarningPreformTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601AB8E RID: 109454 RVA: 0x003CC340 File Offset: 0x003CA540
		public static Offset<IWarningPreformType> Pack(FlatBufferBuilder builder, IWarningPreformTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWarningPreformType>);
			}
			return IWarningPreformType.CreateIWarningPreformType(builder, _o.Type);
		}

		// Token: 0x0400C941 RID: 51521
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EC7 RID: 28359
	public struct IResumeSystemRewardPopupType : IFlatbufferObject
	{
		// Token: 0x1700D30D RID: 54029
		// (get) Token: 0x060321E7 RID: 205287 RVA: 0x006C694B File Offset: 0x006C4B4B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060321E8 RID: 205288 RVA: 0x006C6958 File Offset: 0x006C4B58
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060321E9 RID: 205289 RVA: 0x006C6960 File Offset: 0x006C4B60
		public static IResumeSystemRewardPopupType GetRootAsIResumeSystemRewardPopupType(ByteBuffer _bb)
		{
			return IResumeSystemRewardPopupType.GetRootAsIResumeSystemRewardPopupType(_bb, default(IResumeSystemRewardPopupType));
		}

		// Token: 0x060321EA RID: 205290 RVA: 0x006C697C File Offset: 0x006C4B7C
		public static IResumeSystemRewardPopupType GetRootAsIResumeSystemRewardPopupType(ByteBuffer _bb, IResumeSystemRewardPopupType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060321EB RID: 205291 RVA: 0x006C6999 File Offset: 0x006C4B99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060321EC RID: 205292 RVA: 0x006C69A8 File Offset: 0x006C4BA8
		public IResumeSystemRewardPopupType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D30E RID: 54030
		// (get) Token: 0x060321ED RID: 205293 RVA: 0x006C69B8 File Offset: 0x006C4BB8
		public ESystemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystemType.Shop;
				}
				return (ESystemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060321EE RID: 205294 RVA: 0x006C69F4 File Offset: 0x006C4BF4
		public static Offset<IResumeSystemRewardPopupType> CreateIResumeSystemRewardPopupType(FlatBufferBuilder builder, ESystemType Type = ESystemType.Shop)
		{
			builder.StartTable(1);
			IResumeSystemRewardPopupType.AddType(builder, Type);
			return IResumeSystemRewardPopupType.EndIResumeSystemRewardPopupType(builder);
		}

		// Token: 0x060321EF RID: 205295 RVA: 0x006C6A0A File Offset: 0x006C4C0A
		public static void StartIResumeSystemRewardPopupType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060321F0 RID: 205296 RVA: 0x006C6A13 File Offset: 0x006C4C13
		public static void AddType(FlatBufferBuilder builder, ESystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060321F1 RID: 205297 RVA: 0x006C6A1E File Offset: 0x006C4C1E
		public static Offset<IResumeSystemRewardPopupType> EndIResumeSystemRewardPopupType(FlatBufferBuilder builder)
		{
			return new Offset<IResumeSystemRewardPopupType>(builder.EndTable());
		}

		// Token: 0x060321F2 RID: 205298 RVA: 0x006C6A2C File Offset: 0x006C4C2C
		public IResumeSystemRewardPopupTypeT UnPack()
		{
			IResumeSystemRewardPopupTypeT resumeSystemRewardPopupTypeT = new IResumeSystemRewardPopupTypeT();
			this.UnPackTo(resumeSystemRewardPopupTypeT);
			return resumeSystemRewardPopupTypeT;
		}

		// Token: 0x060321F3 RID: 205299 RVA: 0x006C6A47 File Offset: 0x006C4C47
		public void UnPackTo(IResumeSystemRewardPopupTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060321F4 RID: 205300 RVA: 0x006C6A58 File Offset: 0x006C4C58
		public static Offset<IResumeSystemRewardPopupType> Pack(FlatBufferBuilder builder, IResumeSystemRewardPopupTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResumeSystemRewardPopupType>);
			}
			return IResumeSystemRewardPopupType.CreateIResumeSystemRewardPopupType(builder, _o.Type);
		}

		// Token: 0x040118B7 RID: 71863
		private Table __p;
	}
}

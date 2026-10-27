using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007223 RID: 29219
	public struct ISubtitleStyleBase : IFlatbufferObject
	{
		// Token: 0x1700D8E7 RID: 55527
		// (get) Token: 0x06033D50 RID: 212304 RVA: 0x006F9A21 File Offset: 0x006F7C21
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033D51 RID: 212305 RVA: 0x006F9A2E File Offset: 0x006F7C2E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033D52 RID: 212306 RVA: 0x006F9A38 File Offset: 0x006F7C38
		public static ISubtitleStyleBase GetRootAsISubtitleStyleBase(ByteBuffer _bb)
		{
			return ISubtitleStyleBase.GetRootAsISubtitleStyleBase(_bb, default(ISubtitleStyleBase));
		}

		// Token: 0x06033D53 RID: 212307 RVA: 0x006F9A54 File Offset: 0x006F7C54
		public static ISubtitleStyleBase GetRootAsISubtitleStyleBase(ByteBuffer _bb, ISubtitleStyleBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033D54 RID: 212308 RVA: 0x006F9A71 File Offset: 0x006F7C71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033D55 RID: 212309 RVA: 0x006F9A80 File Offset: 0x006F7C80
		public ISubtitleStyleBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D8E8 RID: 55528
		// (get) Token: 0x06033D56 RID: 212310 RVA: 0x006F9A90 File Offset: 0x006F7C90
		public ESubtitleStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESubtitleStyle.LevelA;
				}
				return (ESubtitleStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033D57 RID: 212311 RVA: 0x006F9ACC File Offset: 0x006F7CCC
		public static Offset<ISubtitleStyleBase> CreateISubtitleStyleBase(FlatBufferBuilder builder, ESubtitleStyle Type = ESubtitleStyle.LevelA)
		{
			builder.StartTable(1);
			ISubtitleStyleBase.AddType(builder, Type);
			return ISubtitleStyleBase.EndISubtitleStyleBase(builder);
		}

		// Token: 0x06033D58 RID: 212312 RVA: 0x006F9AE2 File Offset: 0x006F7CE2
		public static void StartISubtitleStyleBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033D59 RID: 212313 RVA: 0x006F9AEB File Offset: 0x006F7CEB
		public static void AddType(FlatBufferBuilder builder, ESubtitleStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033D5A RID: 212314 RVA: 0x006F9AF6 File Offset: 0x006F7CF6
		public static Offset<ISubtitleStyleBase> EndISubtitleStyleBase(FlatBufferBuilder builder)
		{
			return new Offset<ISubtitleStyleBase>(builder.EndTable());
		}

		// Token: 0x06033D5B RID: 212315 RVA: 0x006F9B04 File Offset: 0x006F7D04
		public ISubtitleStyleBaseT UnPack()
		{
			ISubtitleStyleBaseT subtitleStyleBaseT = new ISubtitleStyleBaseT();
			this.UnPackTo(subtitleStyleBaseT);
			return subtitleStyleBaseT;
		}

		// Token: 0x06033D5C RID: 212316 RVA: 0x006F9B1F File Offset: 0x006F7D1F
		public void UnPackTo(ISubtitleStyleBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033D5D RID: 212317 RVA: 0x006F9B30 File Offset: 0x006F7D30
		public static Offset<ISubtitleStyleBase> Pack(FlatBufferBuilder builder, ISubtitleStyleBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISubtitleStyleBase>);
			}
			return ISubtitleStyleBase.CreateISubtitleStyleBase(builder, _o.Type);
		}

		// Token: 0x04011D13 RID: 72979
		private Table __p;
	}
}

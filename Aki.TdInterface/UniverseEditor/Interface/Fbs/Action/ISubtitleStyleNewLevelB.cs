using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200722C RID: 29228
	public struct ISubtitleStyleNewLevelB : IFlatbufferObject
	{
		// Token: 0x1700D8EF RID: 55535
		// (get) Token: 0x06033D82 RID: 212354 RVA: 0x006F9E59 File Offset: 0x006F8059
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033D83 RID: 212355 RVA: 0x006F9E66 File Offset: 0x006F8066
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033D84 RID: 212356 RVA: 0x006F9E70 File Offset: 0x006F8070
		public static ISubtitleStyleNewLevelB GetRootAsISubtitleStyleNewLevelB(ByteBuffer _bb)
		{
			return ISubtitleStyleNewLevelB.GetRootAsISubtitleStyleNewLevelB(_bb, default(ISubtitleStyleNewLevelB));
		}

		// Token: 0x06033D85 RID: 212357 RVA: 0x006F9E8C File Offset: 0x006F808C
		public static ISubtitleStyleNewLevelB GetRootAsISubtitleStyleNewLevelB(ByteBuffer _bb, ISubtitleStyleNewLevelB obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033D86 RID: 212358 RVA: 0x006F9EA9 File Offset: 0x006F80A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033D87 RID: 212359 RVA: 0x006F9EB8 File Offset: 0x006F80B8
		public ISubtitleStyleNewLevelB __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D8F0 RID: 55536
		// (get) Token: 0x06033D88 RID: 212360 RVA: 0x006F9EC8 File Offset: 0x006F80C8
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

		// Token: 0x06033D89 RID: 212361 RVA: 0x006F9F04 File Offset: 0x006F8104
		public static Offset<ISubtitleStyleNewLevelB> CreateISubtitleStyleNewLevelB(FlatBufferBuilder builder, ESubtitleStyle Type = ESubtitleStyle.LevelA)
		{
			builder.StartTable(1);
			ISubtitleStyleNewLevelB.AddType(builder, Type);
			return ISubtitleStyleNewLevelB.EndISubtitleStyleNewLevelB(builder);
		}

		// Token: 0x06033D8A RID: 212362 RVA: 0x006F9F1A File Offset: 0x006F811A
		public static void StartISubtitleStyleNewLevelB(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033D8B RID: 212363 RVA: 0x006F9F23 File Offset: 0x006F8123
		public static void AddType(FlatBufferBuilder builder, ESubtitleStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033D8C RID: 212364 RVA: 0x006F9F2E File Offset: 0x006F812E
		public static Offset<ISubtitleStyleNewLevelB> EndISubtitleStyleNewLevelB(FlatBufferBuilder builder)
		{
			return new Offset<ISubtitleStyleNewLevelB>(builder.EndTable());
		}

		// Token: 0x06033D8D RID: 212365 RVA: 0x006F9F3C File Offset: 0x006F813C
		public ISubtitleStyleNewLevelBT UnPack()
		{
			ISubtitleStyleNewLevelBT subtitleStyleNewLevelBT = new ISubtitleStyleNewLevelBT();
			this.UnPackTo(subtitleStyleNewLevelBT);
			return subtitleStyleNewLevelBT;
		}

		// Token: 0x06033D8E RID: 212366 RVA: 0x006F9F57 File Offset: 0x006F8157
		public void UnPackTo(ISubtitleStyleNewLevelBT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033D8F RID: 212367 RVA: 0x006F9F68 File Offset: 0x006F8168
		public static Offset<ISubtitleStyleNewLevelB> Pack(FlatBufferBuilder builder, ISubtitleStyleNewLevelBT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISubtitleStyleNewLevelB>);
			}
			return ISubtitleStyleNewLevelB.CreateISubtitleStyleNewLevelB(builder, _o.Type);
		}

		// Token: 0x04011D1E RID: 72990
		private Table __p;
	}
}

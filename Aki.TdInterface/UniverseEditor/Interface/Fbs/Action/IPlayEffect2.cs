using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200745C RID: 29788
	public struct IPlayEffect2 : IFlatbufferObject
	{
		// Token: 0x1700DAE9 RID: 56041
		// (get) Token: 0x06034263 RID: 213603 RVA: 0x00706D18 File Offset: 0x00704F18
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034264 RID: 213604 RVA: 0x00706D25 File Offset: 0x00704F25
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034265 RID: 213605 RVA: 0x00706D2C File Offset: 0x00704F2C
		public static IPlayEffect2 GetRootAsIPlayEffect2(ByteBuffer _bb)
		{
			return IPlayEffect2.GetRootAsIPlayEffect2(_bb, default(IPlayEffect2));
		}

		// Token: 0x06034266 RID: 213606 RVA: 0x00706D48 File Offset: 0x00704F48
		public static IPlayEffect2 GetRootAsIPlayEffect2(ByteBuffer _bb, IPlayEffect2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034267 RID: 213607 RVA: 0x00706D65 File Offset: 0x00704F65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034268 RID: 213608 RVA: 0x00706D74 File Offset: 0x00704F74
		public IPlayEffect2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DAEA RID: 56042
		// (get) Token: 0x06034269 RID: 213609 RVA: 0x00706D84 File Offset: 0x00704F84
		public EEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEffectType.Effect;
				}
				return (EEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DAEB RID: 56043
		// (get) Token: 0x0603426A RID: 213610 RVA: 0x00706DC0 File Offset: 0x00704FC0
		public string Path
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603426B RID: 213611 RVA: 0x00706DF7 File Offset: 0x00704FF7
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0603426C RID: 213612 RVA: 0x00706E06 File Offset: 0x00705006
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0603426D RID: 213613 RVA: 0x00706E14 File Offset: 0x00705014
		public static Offset<IPlayEffect2> CreateIPlayEffect2(FlatBufferBuilder builder, EEffectType Type = EEffectType.Effect, StringOffset PathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IPlayEffect2.AddPath(builder, PathOffset);
			IPlayEffect2.AddType(builder, Type);
			return IPlayEffect2.EndIPlayEffect2(builder);
		}

		// Token: 0x0603426E RID: 213614 RVA: 0x00706E31 File Offset: 0x00705031
		public static void StartIPlayEffect2(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603426F RID: 213615 RVA: 0x00706E3A File Offset: 0x0070503A
		public static void AddType(FlatBufferBuilder builder, EEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034270 RID: 213616 RVA: 0x00706E45 File Offset: 0x00705045
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x06034271 RID: 213617 RVA: 0x00706E55 File Offset: 0x00705055
		public static Offset<IPlayEffect2> EndIPlayEffect2(FlatBufferBuilder builder)
		{
			return new Offset<IPlayEffect2>(builder.EndTable());
		}

		// Token: 0x06034272 RID: 213618 RVA: 0x00706E64 File Offset: 0x00705064
		public IPlayEffect2T UnPack()
		{
			IPlayEffect2T playEffect2T = new IPlayEffect2T();
			this.UnPackTo(playEffect2T);
			return playEffect2T;
		}

		// Token: 0x06034273 RID: 213619 RVA: 0x00706E7F File Offset: 0x0070507F
		public void UnPackTo(IPlayEffect2T _o)
		{
			_o.Type = this.Type;
			_o.Path = this.Path;
		}

		// Token: 0x06034274 RID: 213620 RVA: 0x00706E9C File Offset: 0x0070509C
		public static Offset<IPlayEffect2> Pack(FlatBufferBuilder builder, IPlayEffect2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayEffect2>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			return IPlayEffect2.CreateIPlayEffect2(builder, _o.Type, pathOffset);
		}

		// Token: 0x040125CF RID: 75215
		private Table __p;
	}
}

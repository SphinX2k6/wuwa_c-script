using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004C85 RID: 19589
	public struct IAreaConflictSelector : IFlatbufferObject
	{
		// Token: 0x17008ABC RID: 35516
		// (get) Token: 0x0601E030 RID: 122928 RVA: 0x00434ECC File Offset: 0x004330CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E031 RID: 122929 RVA: 0x00434ED9 File Offset: 0x004330D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E032 RID: 122930 RVA: 0x00434EE0 File Offset: 0x004330E0
		public static IAreaConflictSelector GetRootAsIAreaConflictSelector(ByteBuffer _bb)
		{
			return IAreaConflictSelector.GetRootAsIAreaConflictSelector(_bb, default(IAreaConflictSelector));
		}

		// Token: 0x0601E033 RID: 122931 RVA: 0x00434EFC File Offset: 0x004330FC
		public static IAreaConflictSelector GetRootAsIAreaConflictSelector(ByteBuffer _bb, IAreaConflictSelector obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E034 RID: 122932 RVA: 0x00434F19 File Offset: 0x00433119
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E035 RID: 122933 RVA: 0x00434F28 File Offset: 0x00433128
		public IAreaConflictSelector __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008ABD RID: 35517
		// (get) Token: 0x0601E036 RID: 122934 RVA: 0x00434F38 File Offset: 0x00433138
		public EAreaConflictSelector Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAreaConflictSelector.Quest;
				}
				return (EAreaConflictSelector)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E037 RID: 122935 RVA: 0x00434F74 File Offset: 0x00433174
		public static Offset<IAreaConflictSelector> CreateIAreaConflictSelector(FlatBufferBuilder builder, EAreaConflictSelector Type = EAreaConflictSelector.Quest)
		{
			builder.StartTable(1);
			IAreaConflictSelector.AddType(builder, Type);
			return IAreaConflictSelector.EndIAreaConflictSelector(builder);
		}

		// Token: 0x0601E038 RID: 122936 RVA: 0x00434F8A File Offset: 0x0043318A
		public static void StartIAreaConflictSelector(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601E039 RID: 122937 RVA: 0x00434F93 File Offset: 0x00433193
		public static void AddType(FlatBufferBuilder builder, EAreaConflictSelector type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E03A RID: 122938 RVA: 0x00434F9E File Offset: 0x0043319E
		public static Offset<IAreaConflictSelector> EndIAreaConflictSelector(FlatBufferBuilder builder)
		{
			return new Offset<IAreaConflictSelector>(builder.EndTable());
		}

		// Token: 0x0601E03B RID: 122939 RVA: 0x00434FAC File Offset: 0x004331AC
		public IAreaConflictSelectorT UnPack()
		{
			IAreaConflictSelectorT areaConflictSelectorT = new IAreaConflictSelectorT();
			this.UnPackTo(areaConflictSelectorT);
			return areaConflictSelectorT;
		}

		// Token: 0x0601E03C RID: 122940 RVA: 0x00434FC7 File Offset: 0x004331C7
		public void UnPackTo(IAreaConflictSelectorT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601E03D RID: 122941 RVA: 0x00434FD8 File Offset: 0x004331D8
		public static Offset<IAreaConflictSelector> Pack(FlatBufferBuilder builder, IAreaConflictSelectorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAreaConflictSelector>);
			}
			return IAreaConflictSelector.CreateIAreaConflictSelector(builder, _o.Type);
		}

		// Token: 0x0400D770 RID: 55152
		private Table __p;
	}
}

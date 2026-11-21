using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F2F RID: 20271
	public struct ICheckHonamiStoryUnlockMascot : IFlatbufferObject
	{
		// Token: 0x170090C9 RID: 37065
		// (get) Token: 0x0601F81B RID: 129051 RVA: 0x00462754 File Offset: 0x00460954
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F81C RID: 129052 RVA: 0x00462761 File Offset: 0x00460961
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F81D RID: 129053 RVA: 0x00462768 File Offset: 0x00460968
		public static ICheckHonamiStoryUnlockMascot GetRootAsICheckHonamiStoryUnlockMascot(ByteBuffer _bb)
		{
			return ICheckHonamiStoryUnlockMascot.GetRootAsICheckHonamiStoryUnlockMascot(_bb, default(ICheckHonamiStoryUnlockMascot));
		}

		// Token: 0x0601F81E RID: 129054 RVA: 0x00462784 File Offset: 0x00460984
		public static ICheckHonamiStoryUnlockMascot GetRootAsICheckHonamiStoryUnlockMascot(ByteBuffer _bb, ICheckHonamiStoryUnlockMascot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F81F RID: 129055 RVA: 0x004627A1 File Offset: 0x004609A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F820 RID: 129056 RVA: 0x004627B0 File Offset: 0x004609B0
		public ICheckHonamiStoryUnlockMascot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170090CA RID: 37066
		// (get) Token: 0x0601F821 RID: 129057 RVA: 0x004627C0 File Offset: 0x004609C0
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170090CB RID: 37067
		// (get) Token: 0x0601F822 RID: 129058 RVA: 0x004627FC File Offset: 0x004609FC
		public int MascotId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170090CC RID: 37068
		// (get) Token: 0x0601F823 RID: 129059 RVA: 0x00462838 File Offset: 0x00460A38
		public bool IsUnlocked
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601F824 RID: 129060 RVA: 0x00462877 File Offset: 0x00460A77
		public static Offset<ICheckHonamiStoryUnlockMascot> CreateICheckHonamiStoryUnlockMascot(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int MascotId = 0, bool IsUnlocked = false)
		{
			builder.StartTable(3);
			ICheckHonamiStoryUnlockMascot.AddMascotId(builder, MascotId);
			ICheckHonamiStoryUnlockMascot.AddIsUnlocked(builder, IsUnlocked);
			ICheckHonamiStoryUnlockMascot.AddType(builder, Type);
			return ICheckHonamiStoryUnlockMascot.EndICheckHonamiStoryUnlockMascot(builder);
		}

		// Token: 0x0601F825 RID: 129061 RVA: 0x0046289B File Offset: 0x00460A9B
		public static void StartICheckHonamiStoryUnlockMascot(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F826 RID: 129062 RVA: 0x004628A4 File Offset: 0x00460AA4
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F827 RID: 129063 RVA: 0x004628AF File Offset: 0x00460AAF
		public static void AddMascotId(FlatBufferBuilder builder, int mascotId)
		{
			builder.AddInt(1, mascotId, 0);
		}

		// Token: 0x0601F828 RID: 129064 RVA: 0x004628BA File Offset: 0x00460ABA
		public static void AddIsUnlocked(FlatBufferBuilder builder, bool isUnlocked)
		{
			builder.AddBool(2, isUnlocked, false);
		}

		// Token: 0x0601F829 RID: 129065 RVA: 0x004628C5 File Offset: 0x00460AC5
		public static Offset<ICheckHonamiStoryUnlockMascot> EndICheckHonamiStoryUnlockMascot(FlatBufferBuilder builder)
		{
			return new Offset<ICheckHonamiStoryUnlockMascot>(builder.EndTable());
		}

		// Token: 0x0601F82A RID: 129066 RVA: 0x004628D4 File Offset: 0x00460AD4
		public ICheckHonamiStoryUnlockMascotT UnPack()
		{
			ICheckHonamiStoryUnlockMascotT checkHonamiStoryUnlockMascotT = new ICheckHonamiStoryUnlockMascotT();
			this.UnPackTo(checkHonamiStoryUnlockMascotT);
			return checkHonamiStoryUnlockMascotT;
		}

		// Token: 0x0601F82B RID: 129067 RVA: 0x004628EF File Offset: 0x00460AEF
		public void UnPackTo(ICheckHonamiStoryUnlockMascotT _o)
		{
			_o.Type = this.Type;
			_o.MascotId = this.MascotId;
			_o.IsUnlocked = this.IsUnlocked;
		}

		// Token: 0x0601F82C RID: 129068 RVA: 0x00462918 File Offset: 0x00460B18
		public static Offset<ICheckHonamiStoryUnlockMascot> Pack(FlatBufferBuilder builder, ICheckHonamiStoryUnlockMascotT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckHonamiStoryUnlockMascot>);
			}
			return ICheckHonamiStoryUnlockMascot.CreateICheckHonamiStoryUnlockMascot(builder, _o.Type, _o.MascotId, _o.IsUnlocked);
		}

		// Token: 0x0400DDA6 RID: 56742
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A69 RID: 19049
	public struct ICheckHonamiStoryUnlockMascot : IFlatbufferObject
	{
		// Token: 0x170089ED RID: 35309
		// (get) Token: 0x0601DD78 RID: 122232 RVA: 0x004315C8 File Offset: 0x0042F7C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DD79 RID: 122233 RVA: 0x004315D5 File Offset: 0x0042F7D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DD7A RID: 122234 RVA: 0x004315DC File Offset: 0x0042F7DC
		public static ICheckHonamiStoryUnlockMascot GetRootAsICheckHonamiStoryUnlockMascot(ByteBuffer _bb)
		{
			return ICheckHonamiStoryUnlockMascot.GetRootAsICheckHonamiStoryUnlockMascot(_bb, default(ICheckHonamiStoryUnlockMascot));
		}

		// Token: 0x0601DD7B RID: 122235 RVA: 0x004315F8 File Offset: 0x0042F7F8
		public static ICheckHonamiStoryUnlockMascot GetRootAsICheckHonamiStoryUnlockMascot(ByteBuffer _bb, ICheckHonamiStoryUnlockMascot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DD7C RID: 122236 RVA: 0x00431615 File Offset: 0x0042F815
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DD7D RID: 122237 RVA: 0x00431624 File Offset: 0x0042F824
		public ICheckHonamiStoryUnlockMascot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170089EE RID: 35310
		// (get) Token: 0x0601DD7E RID: 122238 RVA: 0x00431634 File Offset: 0x0042F834
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

		// Token: 0x170089EF RID: 35311
		// (get) Token: 0x0601DD7F RID: 122239 RVA: 0x00431670 File Offset: 0x0042F870
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

		// Token: 0x170089F0 RID: 35312
		// (get) Token: 0x0601DD80 RID: 122240 RVA: 0x004316AC File Offset: 0x0042F8AC
		public bool IsUnlocked
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601DD81 RID: 122241 RVA: 0x004316EB File Offset: 0x0042F8EB
		public static Offset<ICheckHonamiStoryUnlockMascot> CreateICheckHonamiStoryUnlockMascot(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int MascotId = 0, bool IsUnlocked = false)
		{
			builder.StartTable(3);
			ICheckHonamiStoryUnlockMascot.AddMascotId(builder, MascotId);
			ICheckHonamiStoryUnlockMascot.AddIsUnlocked(builder, IsUnlocked);
			ICheckHonamiStoryUnlockMascot.AddType(builder, Type);
			return ICheckHonamiStoryUnlockMascot.EndICheckHonamiStoryUnlockMascot(builder);
		}

		// Token: 0x0601DD82 RID: 122242 RVA: 0x0043170F File Offset: 0x0042F90F
		public static void StartICheckHonamiStoryUnlockMascot(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601DD83 RID: 122243 RVA: 0x00431718 File Offset: 0x0042F918
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DD84 RID: 122244 RVA: 0x00431723 File Offset: 0x0042F923
		public static void AddMascotId(FlatBufferBuilder builder, int mascotId)
		{
			builder.AddInt(1, mascotId, 0);
		}

		// Token: 0x0601DD85 RID: 122245 RVA: 0x0043172E File Offset: 0x0042F92E
		public static void AddIsUnlocked(FlatBufferBuilder builder, bool isUnlocked)
		{
			builder.AddBool(2, isUnlocked, false);
		}

		// Token: 0x0601DD86 RID: 122246 RVA: 0x00431739 File Offset: 0x0042F939
		public static Offset<ICheckHonamiStoryUnlockMascot> EndICheckHonamiStoryUnlockMascot(FlatBufferBuilder builder)
		{
			return new Offset<ICheckHonamiStoryUnlockMascot>(builder.EndTable());
		}

		// Token: 0x0601DD87 RID: 122247 RVA: 0x00431748 File Offset: 0x0042F948
		public ICheckHonamiStoryUnlockMascotT UnPack()
		{
			ICheckHonamiStoryUnlockMascotT checkHonamiStoryUnlockMascotT = new ICheckHonamiStoryUnlockMascotT();
			this.UnPackTo(checkHonamiStoryUnlockMascotT);
			return checkHonamiStoryUnlockMascotT;
		}

		// Token: 0x0601DD88 RID: 122248 RVA: 0x00431763 File Offset: 0x0042F963
		public void UnPackTo(ICheckHonamiStoryUnlockMascotT _o)
		{
			_o.Type = this.Type;
			_o.MascotId = this.MascotId;
			_o.IsUnlocked = this.IsUnlocked;
		}

		// Token: 0x0601DD89 RID: 122249 RVA: 0x0043178C File Offset: 0x0042F98C
		public static Offset<ICheckHonamiStoryUnlockMascot> Pack(FlatBufferBuilder builder, ICheckHonamiStoryUnlockMascotT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckHonamiStoryUnlockMascot>);
			}
			return ICheckHonamiStoryUnlockMascot.CreateICheckHonamiStoryUnlockMascot(builder, _o.Type, _o.MascotId, _o.IsUnlocked);
		}

		// Token: 0x0400D2CB RID: 53963
		private Table __p;
	}
}

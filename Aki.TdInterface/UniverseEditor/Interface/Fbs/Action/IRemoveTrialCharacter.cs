using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E6D RID: 28269
	public struct IRemoveTrialCharacter : IFlatbufferObject
	{
		// Token: 0x1700D28C RID: 53900
		// (get) Token: 0x06031F46 RID: 204614 RVA: 0x006C1FF9 File Offset: 0x006C01F9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031F47 RID: 204615 RVA: 0x006C2006 File Offset: 0x006C0206
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031F48 RID: 204616 RVA: 0x006C2010 File Offset: 0x006C0210
		public static IRemoveTrialCharacter GetRootAsIRemoveTrialCharacter(ByteBuffer _bb)
		{
			return IRemoveTrialCharacter.GetRootAsIRemoveTrialCharacter(_bb, default(IRemoveTrialCharacter));
		}

		// Token: 0x06031F49 RID: 204617 RVA: 0x006C202C File Offset: 0x006C022C
		public static IRemoveTrialCharacter GetRootAsIRemoveTrialCharacter(ByteBuffer _bb, IRemoveTrialCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031F4A RID: 204618 RVA: 0x006C2049 File Offset: 0x006C0249
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031F4B RID: 204619 RVA: 0x006C2058 File Offset: 0x006C0258
		public IRemoveTrialCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D28D RID: 53901
		// (get) Token: 0x06031F4C RID: 204620 RVA: 0x006C2068 File Offset: 0x006C0268
		public int CharacterId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031F4D RID: 204621 RVA: 0x006C20A4 File Offset: 0x006C02A4
		public int CharacterGroup(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D28E RID: 53902
		// (get) Token: 0x06031F4E RID: 204622 RVA: 0x006C20E4 File Offset: 0x006C02E4
		public int CharacterGroupLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06031F4F RID: 204623 RVA: 0x006C210F File Offset: 0x006C030F
		public Span<int> GetCharacterGroupBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06031F50 RID: 204624 RVA: 0x006C211E File Offset: 0x006C031E
		public int[] GetCharacterGroupArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700D28F RID: 53903
		// (get) Token: 0x06031F51 RID: 204625 RVA: 0x006C212C File Offset: 0x006C032C
		public bool IsRemoveTips
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D290 RID: 53904
		// (get) Token: 0x06031F52 RID: 204626 RVA: 0x006C216C File Offset: 0x006C036C
		public bool EnableSeamlessTeamSwitch
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D291 RID: 53905
		// (get) Token: 0x06031F53 RID: 204627 RVA: 0x006C21AC File Offset: 0x006C03AC
		public bool OnlyLowMemoryDeviceExecute
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D292 RID: 53906
		// (get) Token: 0x06031F54 RID: 204628 RVA: 0x006C21EC File Offset: 0x006C03EC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031F55 RID: 204629 RVA: 0x006C2229 File Offset: 0x006C0429
		public static Offset<IRemoveTrialCharacter> CreateIRemoveTrialCharacter(FlatBufferBuilder builder, int CharacterId = 0, VectorOffset CharacterGroupOffset = default(VectorOffset), bool IsRemoveTips = false, bool EnableSeamlessTeamSwitch = false, bool OnlyLowMemoryDeviceExecute = false, byte NullMask = 0)
		{
			builder.StartTable(6);
			IRemoveTrialCharacter.AddCharacterGroup(builder, CharacterGroupOffset);
			IRemoveTrialCharacter.AddCharacterId(builder, CharacterId);
			IRemoveTrialCharacter.AddNullMask(builder, NullMask);
			IRemoveTrialCharacter.AddOnlyLowMemoryDeviceExecute(builder, OnlyLowMemoryDeviceExecute);
			IRemoveTrialCharacter.AddEnableSeamlessTeamSwitch(builder, EnableSeamlessTeamSwitch);
			IRemoveTrialCharacter.AddIsRemoveTips(builder, IsRemoveTips);
			return IRemoveTrialCharacter.EndIRemoveTrialCharacter(builder);
		}

		// Token: 0x06031F56 RID: 204630 RVA: 0x006C2265 File Offset: 0x006C0465
		public static void StartIRemoveTrialCharacter(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06031F57 RID: 204631 RVA: 0x006C226E File Offset: 0x006C046E
		public static void AddCharacterId(FlatBufferBuilder builder, int characterId)
		{
			builder.AddInt(0, characterId, 0);
		}

		// Token: 0x06031F58 RID: 204632 RVA: 0x006C2279 File Offset: 0x006C0479
		public static void AddCharacterGroup(FlatBufferBuilder builder, VectorOffset characterGroupOffset)
		{
			builder.AddOffset(1, characterGroupOffset.Value, 0);
		}

		// Token: 0x06031F59 RID: 204633 RVA: 0x006C228C File Offset: 0x006C048C
		public static VectorOffset CreateCharacterGroupVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06031F5A RID: 204634 RVA: 0x006C22C3 File Offset: 0x006C04C3
		public static VectorOffset CreateCharacterGroupVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06031F5B RID: 204635 RVA: 0x006C22DD File Offset: 0x006C04DD
		public static VectorOffset CreateCharacterGroupVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06031F5C RID: 204636 RVA: 0x006C22FB File Offset: 0x006C04FB
		public static VectorOffset CreateCharacterGroupVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031F5D RID: 204637 RVA: 0x006C2314 File Offset: 0x006C0514
		public static void StartCharacterGroupVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031F5E RID: 204638 RVA: 0x006C231F File Offset: 0x006C051F
		public static void AddIsRemoveTips(FlatBufferBuilder builder, bool isRemoveTips)
		{
			builder.AddBool(2, isRemoveTips, false);
		}

		// Token: 0x06031F5F RID: 204639 RVA: 0x006C232A File Offset: 0x006C052A
		public static void AddEnableSeamlessTeamSwitch(FlatBufferBuilder builder, bool enableSeamlessTeamSwitch)
		{
			builder.AddBool(3, enableSeamlessTeamSwitch, false);
		}

		// Token: 0x06031F60 RID: 204640 RVA: 0x006C2335 File Offset: 0x006C0535
		public static void AddOnlyLowMemoryDeviceExecute(FlatBufferBuilder builder, bool onlyLowMemoryDeviceExecute)
		{
			builder.AddBool(4, onlyLowMemoryDeviceExecute, false);
		}

		// Token: 0x06031F61 RID: 204641 RVA: 0x006C2340 File Offset: 0x006C0540
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06031F62 RID: 204642 RVA: 0x006C234B File Offset: 0x006C054B
		public static Offset<IRemoveTrialCharacter> EndIRemoveTrialCharacter(FlatBufferBuilder builder)
		{
			return new Offset<IRemoveTrialCharacter>(builder.EndTable());
		}

		// Token: 0x06031F63 RID: 204643 RVA: 0x006C2358 File Offset: 0x006C0558
		public IRemoveTrialCharacterT UnPack()
		{
			IRemoveTrialCharacterT removeTrialCharacterT = new IRemoveTrialCharacterT();
			this.UnPackTo(removeTrialCharacterT);
			return removeTrialCharacterT;
		}

		// Token: 0x06031F64 RID: 204644 RVA: 0x006C2374 File Offset: 0x006C0574
		public void UnPackTo(IRemoveTrialCharacterT _o)
		{
			_o.CharacterId = this.CharacterId;
			_o.CharacterGroup = new List<int>();
			for (int i = 0; i < this.CharacterGroupLength; i++)
			{
				_o.CharacterGroup.Add(this.CharacterGroup(i));
			}
			_o.IsRemoveTips = this.IsRemoveTips;
			_o.EnableSeamlessTeamSwitch = this.EnableSeamlessTeamSwitch;
			_o.OnlyLowMemoryDeviceExecute = this.OnlyLowMemoryDeviceExecute;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06031F65 RID: 204645 RVA: 0x006C23EC File Offset: 0x006C05EC
		public static Offset<IRemoveTrialCharacter> Pack(FlatBufferBuilder builder, IRemoveTrialCharacterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemoveTrialCharacter>);
			}
			VectorOffset characterGroupOffset = default(VectorOffset);
			if (_o.CharacterGroup != null)
			{
				int[] data = _o.CharacterGroup.ToArray();
				characterGroupOffset = IRemoveTrialCharacter.CreateCharacterGroupVector(builder, data);
			}
			return IRemoveTrialCharacter.CreateIRemoveTrialCharacter(builder, _o.CharacterId, characterGroupOffset, _o.IsRemoveTips, _o.EnableSeamlessTeamSwitch, _o.OnlyLowMemoryDeviceExecute, _o.NullMask);
		}

		// Token: 0x04011857 RID: 71767
		private Table __p;
	}
}

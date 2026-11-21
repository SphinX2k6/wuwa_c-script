using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A37 RID: 31287
	public struct ISwitchPermission : IFlatbufferObject
	{
		// Token: 0x1700E539 RID: 58681
		// (get) Token: 0x06037216 RID: 225814 RVA: 0x0075D9E0 File Offset: 0x0075BBE0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06037217 RID: 225815 RVA: 0x0075D9ED File Offset: 0x0075BBED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06037218 RID: 225816 RVA: 0x0075D9F4 File Offset: 0x0075BBF4
		public static ISwitchPermission GetRootAsISwitchPermission(ByteBuffer _bb)
		{
			return ISwitchPermission.GetRootAsISwitchPermission(_bb, default(ISwitchPermission));
		}

		// Token: 0x06037219 RID: 225817 RVA: 0x0075DA10 File Offset: 0x0075BC10
		public static ISwitchPermission GetRootAsISwitchPermission(ByteBuffer _bb, ISwitchPermission obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603721A RID: 225818 RVA: 0x0075DA2D File Offset: 0x0075BC2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603721B RID: 225819 RVA: 0x0075DA3C File Offset: 0x0075BC3C
		public ISwitchPermission __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E53A RID: 58682
		// (get) Token: 0x0603721C RID: 225820 RVA: 0x0075DA4C File Offset: 0x0075BC4C
		public ESwitchSubLevelsType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESwitchSubLevelsType.Directly;
				}
				return (ESwitchSubLevelsType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E53B RID: 58683
		// (get) Token: 0x0603721D RID: 225821 RVA: 0x0075DA88 File Offset: 0x0075BC88
		public bool IsAllowClientSwitch
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0603721E RID: 225822 RVA: 0x0075DAC8 File Offset: 0x0075BCC8
		public string Levels(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E53C RID: 58684
		// (get) Token: 0x0603721F RID: 225823 RVA: 0x0075DB04 File Offset: 0x0075BD04
		public int LevelsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06037220 RID: 225824 RVA: 0x0075DB2F File Offset: 0x0075BD2F
		public static Offset<ISwitchPermission> CreateISwitchPermission(FlatBufferBuilder builder, ESwitchSubLevelsType Type = ESwitchSubLevelsType.Directly, bool IsAllowClientSwitch = false, VectorOffset LevelsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ISwitchPermission.AddLevels(builder, LevelsOffset);
			ISwitchPermission.AddIsAllowClientSwitch(builder, IsAllowClientSwitch);
			ISwitchPermission.AddType(builder, Type);
			return ISwitchPermission.EndISwitchPermission(builder);
		}

		// Token: 0x06037221 RID: 225825 RVA: 0x0075DB53 File Offset: 0x0075BD53
		public static void StartISwitchPermission(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06037222 RID: 225826 RVA: 0x0075DB5C File Offset: 0x0075BD5C
		public static void AddType(FlatBufferBuilder builder, ESwitchSubLevelsType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06037223 RID: 225827 RVA: 0x0075DB67 File Offset: 0x0075BD67
		public static void AddIsAllowClientSwitch(FlatBufferBuilder builder, bool isAllowClientSwitch)
		{
			builder.AddBool(1, isAllowClientSwitch, false);
		}

		// Token: 0x06037224 RID: 225828 RVA: 0x0075DB72 File Offset: 0x0075BD72
		public static void AddLevels(FlatBufferBuilder builder, VectorOffset levelsOffset)
		{
			builder.AddOffset(2, levelsOffset.Value, 0);
		}

		// Token: 0x06037225 RID: 225829 RVA: 0x0075DB84 File Offset: 0x0075BD84
		public static VectorOffset CreateLevelsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06037226 RID: 225830 RVA: 0x0075DBC4 File Offset: 0x0075BDC4
		public static VectorOffset CreateLevelsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06037227 RID: 225831 RVA: 0x0075DBDE File Offset: 0x0075BDDE
		public static VectorOffset CreateLevelsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06037228 RID: 225832 RVA: 0x0075DBFC File Offset: 0x0075BDFC
		public static VectorOffset CreateLevelsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06037229 RID: 225833 RVA: 0x0075DC15 File Offset: 0x0075BE15
		public static void StartLevelsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603722A RID: 225834 RVA: 0x0075DC20 File Offset: 0x0075BE20
		public static Offset<ISwitchPermission> EndISwitchPermission(FlatBufferBuilder builder)
		{
			return new Offset<ISwitchPermission>(builder.EndTable());
		}

		// Token: 0x0603722B RID: 225835 RVA: 0x0075DC30 File Offset: 0x0075BE30
		public ISwitchPermissionT UnPack()
		{
			ISwitchPermissionT switchPermissionT = new ISwitchPermissionT();
			this.UnPackTo(switchPermissionT);
			return switchPermissionT;
		}

		// Token: 0x0603722C RID: 225836 RVA: 0x0075DC4C File Offset: 0x0075BE4C
		public void UnPackTo(ISwitchPermissionT _o)
		{
			_o.Type = this.Type;
			_o.IsAllowClientSwitch = this.IsAllowClientSwitch;
			_o.Levels = new List<string>();
			for (int i = 0; i < this.LevelsLength; i++)
			{
				_o.Levels.Add(this.Levels(i));
			}
		}

		// Token: 0x0603722D RID: 225837 RVA: 0x0075DCA0 File Offset: 0x0075BEA0
		public static Offset<ISwitchPermission> Pack(FlatBufferBuilder builder, ISwitchPermissionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISwitchPermission>);
			}
			VectorOffset levelsOffset = default(VectorOffset);
			if (_o.Levels != null)
			{
				StringOffset[] array = new StringOffset[_o.Levels.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.Levels[i]);
				}
				levelsOffset = ISwitchPermission.CreateLevelsVector(builder, array);
			}
			return ISwitchPermission.CreateISwitchPermission(builder, _o.Type, _o.IsAllowClientSwitch, levelsOffset);
		}

		// Token: 0x04012D60 RID: 77152
		private Table __p;
	}
}

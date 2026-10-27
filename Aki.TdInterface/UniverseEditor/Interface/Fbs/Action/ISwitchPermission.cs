using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007262 RID: 29282
	public struct ISwitchPermission : IFlatbufferObject
	{
		// Token: 0x1700D940 RID: 55616
		// (get) Token: 0x06033F14 RID: 212756 RVA: 0x006FC680 File Offset: 0x006FA880
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033F15 RID: 212757 RVA: 0x006FC68D File Offset: 0x006FA88D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033F16 RID: 212758 RVA: 0x006FC694 File Offset: 0x006FA894
		public static ISwitchPermission GetRootAsISwitchPermission(ByteBuffer _bb)
		{
			return ISwitchPermission.GetRootAsISwitchPermission(_bb, default(ISwitchPermission));
		}

		// Token: 0x06033F17 RID: 212759 RVA: 0x006FC6B0 File Offset: 0x006FA8B0
		public static ISwitchPermission GetRootAsISwitchPermission(ByteBuffer _bb, ISwitchPermission obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033F18 RID: 212760 RVA: 0x006FC6CD File Offset: 0x006FA8CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033F19 RID: 212761 RVA: 0x006FC6DC File Offset: 0x006FA8DC
		public ISwitchPermission __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D941 RID: 55617
		// (get) Token: 0x06033F1A RID: 212762 RVA: 0x006FC6EC File Offset: 0x006FA8EC
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

		// Token: 0x1700D942 RID: 55618
		// (get) Token: 0x06033F1B RID: 212763 RVA: 0x006FC728 File Offset: 0x006FA928
		public bool IsAllowClientSwitch
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06033F1C RID: 212764 RVA: 0x006FC768 File Offset: 0x006FA968
		public string Levels(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D943 RID: 55619
		// (get) Token: 0x06033F1D RID: 212765 RVA: 0x006FC7A4 File Offset: 0x006FA9A4
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

		// Token: 0x06033F1E RID: 212766 RVA: 0x006FC7CF File Offset: 0x006FA9CF
		public static Offset<ISwitchPermission> CreateISwitchPermission(FlatBufferBuilder builder, ESwitchSubLevelsType Type = ESwitchSubLevelsType.Directly, bool IsAllowClientSwitch = false, VectorOffset LevelsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ISwitchPermission.AddLevels(builder, LevelsOffset);
			ISwitchPermission.AddIsAllowClientSwitch(builder, IsAllowClientSwitch);
			ISwitchPermission.AddType(builder, Type);
			return ISwitchPermission.EndISwitchPermission(builder);
		}

		// Token: 0x06033F1F RID: 212767 RVA: 0x006FC7F3 File Offset: 0x006FA9F3
		public static void StartISwitchPermission(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06033F20 RID: 212768 RVA: 0x006FC7FC File Offset: 0x006FA9FC
		public static void AddType(FlatBufferBuilder builder, ESwitchSubLevelsType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033F21 RID: 212769 RVA: 0x006FC807 File Offset: 0x006FAA07
		public static void AddIsAllowClientSwitch(FlatBufferBuilder builder, bool isAllowClientSwitch)
		{
			builder.AddBool(1, isAllowClientSwitch, false);
		}

		// Token: 0x06033F22 RID: 212770 RVA: 0x006FC812 File Offset: 0x006FAA12
		public static void AddLevels(FlatBufferBuilder builder, VectorOffset levelsOffset)
		{
			builder.AddOffset(2, levelsOffset.Value, 0);
		}

		// Token: 0x06033F23 RID: 212771 RVA: 0x006FC824 File Offset: 0x006FAA24
		public static VectorOffset CreateLevelsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06033F24 RID: 212772 RVA: 0x006FC864 File Offset: 0x006FAA64
		public static VectorOffset CreateLevelsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06033F25 RID: 212773 RVA: 0x006FC87E File Offset: 0x006FAA7E
		public static VectorOffset CreateLevelsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06033F26 RID: 212774 RVA: 0x006FC89C File Offset: 0x006FAA9C
		public static VectorOffset CreateLevelsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033F27 RID: 212775 RVA: 0x006FC8B5 File Offset: 0x006FAAB5
		public static void StartLevelsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06033F28 RID: 212776 RVA: 0x006FC8C0 File Offset: 0x006FAAC0
		public static Offset<ISwitchPermission> EndISwitchPermission(FlatBufferBuilder builder)
		{
			return new Offset<ISwitchPermission>(builder.EndTable());
		}

		// Token: 0x06033F29 RID: 212777 RVA: 0x006FC8D0 File Offset: 0x006FAAD0
		public ISwitchPermissionT UnPack()
		{
			ISwitchPermissionT switchPermissionT = new ISwitchPermissionT();
			this.UnPackTo(switchPermissionT);
			return switchPermissionT;
		}

		// Token: 0x06033F2A RID: 212778 RVA: 0x006FC8EC File Offset: 0x006FAAEC
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

		// Token: 0x06033F2B RID: 212779 RVA: 0x006FC940 File Offset: 0x006FAB40
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

		// Token: 0x04011D5E RID: 73054
		private Table __p;
	}
}

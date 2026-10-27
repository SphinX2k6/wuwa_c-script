using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006933 RID: 26931
	public struct IHonamiStorySetFormation : IFlatbufferObject
	{
		// Token: 0x1700C7CB RID: 51147
		// (get) Token: 0x0602F040 RID: 192576 RVA: 0x00668C8E File Offset: 0x00666E8E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F041 RID: 192577 RVA: 0x00668C9B File Offset: 0x00666E9B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F042 RID: 192578 RVA: 0x00668CA4 File Offset: 0x00666EA4
		public static IHonamiStorySetFormation GetRootAsIHonamiStorySetFormation(ByteBuffer _bb)
		{
			return IHonamiStorySetFormation.GetRootAsIHonamiStorySetFormation(_bb, default(IHonamiStorySetFormation));
		}

		// Token: 0x0602F043 RID: 192579 RVA: 0x00668CC0 File Offset: 0x00666EC0
		public static IHonamiStorySetFormation GetRootAsIHonamiStorySetFormation(ByteBuffer _bb, IHonamiStorySetFormation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F044 RID: 192580 RVA: 0x00668CDD File Offset: 0x00666EDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F045 RID: 192581 RVA: 0x00668CEC File Offset: 0x00666EEC
		public IHonamiStorySetFormation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7CC RID: 51148
		// (get) Token: 0x0602F046 RID: 192582 RVA: 0x00668CFC File Offset: 0x00666EFC
		public int ActivityId
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

		// Token: 0x0602F047 RID: 192583 RVA: 0x00668D38 File Offset: 0x00666F38
		public IHonamiStoryRoleSetting? RoleSetting(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IHonamiStoryRoleSetting?(default(IHonamiStoryRoleSetting).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C7CD RID: 51149
		// (get) Token: 0x0602F048 RID: 192584 RVA: 0x00668D98 File Offset: 0x00666F98
		public int RoleSettingLength
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

		// Token: 0x0602F049 RID: 192585 RVA: 0x00668DC4 File Offset: 0x00666FC4
		public IHonamiStoryWeaponEquipSetting? WeaponSetting(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IHonamiStoryWeaponEquipSetting?(default(IHonamiStoryWeaponEquipSetting).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C7CE RID: 51150
		// (get) Token: 0x0602F04A RID: 192586 RVA: 0x00668E24 File Offset: 0x00667024
		public int WeaponSettingLength
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

		// Token: 0x0602F04B RID: 192587 RVA: 0x00668E50 File Offset: 0x00667050
		public IHonamiStoryPluginEquipSetting? PluginSetting(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IHonamiStoryPluginEquipSetting?(default(IHonamiStoryPluginEquipSetting).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C7CF RID: 51151
		// (get) Token: 0x0602F04C RID: 192588 RVA: 0x00668EB4 File Offset: 0x006670B4
		public int PluginSettingLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700C7D0 RID: 51152
		// (get) Token: 0x0602F04D RID: 192589 RVA: 0x00668EE0 File Offset: 0x006670E0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F04E RID: 192590 RVA: 0x00668F1D File Offset: 0x0066711D
		public static Offset<IHonamiStorySetFormation> CreateIHonamiStorySetFormation(FlatBufferBuilder builder, int ActivityId = 0, VectorOffset RoleSettingOffset = default(VectorOffset), VectorOffset WeaponSettingOffset = default(VectorOffset), VectorOffset PluginSettingOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IHonamiStorySetFormation.AddPluginSetting(builder, PluginSettingOffset);
			IHonamiStorySetFormation.AddWeaponSetting(builder, WeaponSettingOffset);
			IHonamiStorySetFormation.AddRoleSetting(builder, RoleSettingOffset);
			IHonamiStorySetFormation.AddActivityId(builder, ActivityId);
			IHonamiStorySetFormation.AddNullMask(builder, NullMask);
			return IHonamiStorySetFormation.EndIHonamiStorySetFormation(builder);
		}

		// Token: 0x0602F04F RID: 192591 RVA: 0x00668F51 File Offset: 0x00667151
		public static void StartIHonamiStorySetFormation(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602F050 RID: 192592 RVA: 0x00668F5A File Offset: 0x0066715A
		public static void AddActivityId(FlatBufferBuilder builder, int activityId)
		{
			builder.AddInt(0, activityId, 0);
		}

		// Token: 0x0602F051 RID: 192593 RVA: 0x00668F65 File Offset: 0x00667165
		public static void AddRoleSetting(FlatBufferBuilder builder, VectorOffset roleSettingOffset)
		{
			builder.AddOffset(1, roleSettingOffset.Value, 0);
		}

		// Token: 0x0602F052 RID: 192594 RVA: 0x00668F78 File Offset: 0x00667178
		public static VectorOffset CreateRoleSettingVector(FlatBufferBuilder builder, Offset<IHonamiStoryRoleSetting>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602F053 RID: 192595 RVA: 0x00668FB8 File Offset: 0x006671B8
		public static VectorOffset CreateRoleSettingVectorBlock(FlatBufferBuilder builder, Offset<IHonamiStoryRoleSetting>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IHonamiStoryRoleSetting>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F054 RID: 192596 RVA: 0x00668FD2 File Offset: 0x006671D2
		public static VectorOffset CreateRoleSettingVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IHonamiStoryRoleSetting>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IHonamiStoryRoleSetting>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F055 RID: 192597 RVA: 0x00668FF0 File Offset: 0x006671F0
		public static VectorOffset CreateRoleSettingVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IHonamiStoryRoleSetting>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602F056 RID: 192598 RVA: 0x00669009 File Offset: 0x00667209
		public static void StartRoleSettingVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602F057 RID: 192599 RVA: 0x00669014 File Offset: 0x00667214
		public static void AddWeaponSetting(FlatBufferBuilder builder, VectorOffset weaponSettingOffset)
		{
			builder.AddOffset(2, weaponSettingOffset.Value, 0);
		}

		// Token: 0x0602F058 RID: 192600 RVA: 0x00669024 File Offset: 0x00667224
		public static VectorOffset CreateWeaponSettingVector(FlatBufferBuilder builder, Offset<IHonamiStoryWeaponEquipSetting>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602F059 RID: 192601 RVA: 0x00669064 File Offset: 0x00667264
		public static VectorOffset CreateWeaponSettingVectorBlock(FlatBufferBuilder builder, Offset<IHonamiStoryWeaponEquipSetting>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IHonamiStoryWeaponEquipSetting>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F05A RID: 192602 RVA: 0x0066907E File Offset: 0x0066727E
		public static VectorOffset CreateWeaponSettingVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IHonamiStoryWeaponEquipSetting>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IHonamiStoryWeaponEquipSetting>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F05B RID: 192603 RVA: 0x0066909C File Offset: 0x0066729C
		public static VectorOffset CreateWeaponSettingVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IHonamiStoryWeaponEquipSetting>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602F05C RID: 192604 RVA: 0x006690B5 File Offset: 0x006672B5
		public static void StartWeaponSettingVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602F05D RID: 192605 RVA: 0x006690C0 File Offset: 0x006672C0
		public static void AddPluginSetting(FlatBufferBuilder builder, VectorOffset pluginSettingOffset)
		{
			builder.AddOffset(3, pluginSettingOffset.Value, 0);
		}

		// Token: 0x0602F05E RID: 192606 RVA: 0x006690D0 File Offset: 0x006672D0
		public static VectorOffset CreatePluginSettingVector(FlatBufferBuilder builder, Offset<IHonamiStoryPluginEquipSetting>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602F05F RID: 192607 RVA: 0x00669110 File Offset: 0x00667310
		public static VectorOffset CreatePluginSettingVectorBlock(FlatBufferBuilder builder, Offset<IHonamiStoryPluginEquipSetting>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IHonamiStoryPluginEquipSetting>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F060 RID: 192608 RVA: 0x0066912A File Offset: 0x0066732A
		public static VectorOffset CreatePluginSettingVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IHonamiStoryPluginEquipSetting>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IHonamiStoryPluginEquipSetting>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F061 RID: 192609 RVA: 0x00669148 File Offset: 0x00667348
		public static VectorOffset CreatePluginSettingVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IHonamiStoryPluginEquipSetting>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602F062 RID: 192610 RVA: 0x00669161 File Offset: 0x00667361
		public static void StartPluginSettingVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602F063 RID: 192611 RVA: 0x0066916C File Offset: 0x0066736C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602F064 RID: 192612 RVA: 0x00669177 File Offset: 0x00667377
		public static Offset<IHonamiStorySetFormation> EndIHonamiStorySetFormation(FlatBufferBuilder builder)
		{
			return new Offset<IHonamiStorySetFormation>(builder.EndTable());
		}

		// Token: 0x0602F065 RID: 192613 RVA: 0x00669184 File Offset: 0x00667384
		public IHonamiStorySetFormationT UnPack()
		{
			IHonamiStorySetFormationT honamiStorySetFormationT = new IHonamiStorySetFormationT();
			this.UnPackTo(honamiStorySetFormationT);
			return honamiStorySetFormationT;
		}

		// Token: 0x0602F066 RID: 192614 RVA: 0x006691A0 File Offset: 0x006673A0
		public void UnPackTo(IHonamiStorySetFormationT _o)
		{
			_o.ActivityId = this.ActivityId;
			_o.RoleSetting = new List<IHonamiStoryRoleSettingT>();
			for (int i = 0; i < this.RoleSettingLength; i++)
			{
				_o.RoleSetting.Add((this.RoleSetting(i) != null) ? this.RoleSetting(i).Value.UnPack() : null);
			}
			_o.WeaponSetting = new List<IHonamiStoryWeaponEquipSettingT>();
			for (int j = 0; j < this.WeaponSettingLength; j++)
			{
				_o.WeaponSetting.Add((this.WeaponSetting(j) != null) ? this.WeaponSetting(j).Value.UnPack() : null);
			}
			_o.PluginSetting = new List<IHonamiStoryPluginEquipSettingT>();
			for (int k = 0; k < this.PluginSettingLength; k++)
			{
				_o.PluginSetting.Add((this.PluginSetting(k) != null) ? this.PluginSetting(k).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602F067 RID: 192615 RVA: 0x006692C8 File Offset: 0x006674C8
		public static Offset<IHonamiStorySetFormation> Pack(FlatBufferBuilder builder, IHonamiStorySetFormationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHonamiStorySetFormation>);
			}
			VectorOffset roleSettingOffset = default(VectorOffset);
			if (_o.RoleSetting != null)
			{
				Offset<IHonamiStoryRoleSetting>[] array = new Offset<IHonamiStoryRoleSetting>[_o.RoleSetting.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IHonamiStoryRoleSetting.Pack(builder, _o.RoleSetting[i]);
				}
				roleSettingOffset = IHonamiStorySetFormation.CreateRoleSettingVector(builder, array);
			}
			VectorOffset weaponSettingOffset = default(VectorOffset);
			if (_o.WeaponSetting != null)
			{
				Offset<IHonamiStoryWeaponEquipSetting>[] array2 = new Offset<IHonamiStoryWeaponEquipSetting>[_o.WeaponSetting.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IHonamiStoryWeaponEquipSetting.Pack(builder, _o.WeaponSetting[j]);
				}
				weaponSettingOffset = IHonamiStorySetFormation.CreateWeaponSettingVector(builder, array2);
			}
			VectorOffset pluginSettingOffset = default(VectorOffset);
			if (_o.PluginSetting != null)
			{
				Offset<IHonamiStoryPluginEquipSetting>[] array3 = new Offset<IHonamiStoryPluginEquipSetting>[_o.PluginSetting.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IHonamiStoryPluginEquipSetting.Pack(builder, _o.PluginSetting[k]);
				}
				pluginSettingOffset = IHonamiStorySetFormation.CreatePluginSettingVector(builder, array3);
			}
			return IHonamiStorySetFormation.CreateIHonamiStorySetFormation(builder, _o.ActivityId, roleSettingOffset, weaponSettingOffset, pluginSettingOffset, _o.NullMask);
		}

		// Token: 0x040110AE RID: 69806
		private Table __p;
	}
}

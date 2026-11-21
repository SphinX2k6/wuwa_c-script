using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FE6 RID: 28646
	public struct IHonamiStorySetFormation : IFlatbufferObject
	{
		// Token: 0x1700D1CE RID: 53710
		// (get) Token: 0x06031A10 RID: 203280 RVA: 0x006B9176 File Offset: 0x006B7376
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031A11 RID: 203281 RVA: 0x006B9183 File Offset: 0x006B7383
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031A12 RID: 203282 RVA: 0x006B918C File Offset: 0x006B738C
		public static IHonamiStorySetFormation GetRootAsIHonamiStorySetFormation(ByteBuffer _bb)
		{
			return IHonamiStorySetFormation.GetRootAsIHonamiStorySetFormation(_bb, default(IHonamiStorySetFormation));
		}

		// Token: 0x06031A13 RID: 203283 RVA: 0x006B91A8 File Offset: 0x006B73A8
		public static IHonamiStorySetFormation GetRootAsIHonamiStorySetFormation(ByteBuffer _bb, IHonamiStorySetFormation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031A14 RID: 203284 RVA: 0x006B91C5 File Offset: 0x006B73C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031A15 RID: 203285 RVA: 0x006B91D4 File Offset: 0x006B73D4
		public IHonamiStorySetFormation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1CF RID: 53711
		// (get) Token: 0x06031A16 RID: 203286 RVA: 0x006B91E4 File Offset: 0x006B73E4
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

		// Token: 0x06031A17 RID: 203287 RVA: 0x006B9220 File Offset: 0x006B7420
		public IHonamiStoryRoleSetting? RoleSetting(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IHonamiStoryRoleSetting?(default(IHonamiStoryRoleSetting).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D1D0 RID: 53712
		// (get) Token: 0x06031A18 RID: 203288 RVA: 0x006B9280 File Offset: 0x006B7480
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

		// Token: 0x06031A19 RID: 203289 RVA: 0x006B92AC File Offset: 0x006B74AC
		public IHonamiStoryWeaponEquipSetting? WeaponSetting(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IHonamiStoryWeaponEquipSetting?(default(IHonamiStoryWeaponEquipSetting).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D1D1 RID: 53713
		// (get) Token: 0x06031A1A RID: 203290 RVA: 0x006B930C File Offset: 0x006B750C
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

		// Token: 0x06031A1B RID: 203291 RVA: 0x006B9338 File Offset: 0x006B7538
		public IHonamiStoryPluginEquipSetting? PluginSetting(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IHonamiStoryPluginEquipSetting?(default(IHonamiStoryPluginEquipSetting).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D1D2 RID: 53714
		// (get) Token: 0x06031A1C RID: 203292 RVA: 0x006B939C File Offset: 0x006B759C
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

		// Token: 0x1700D1D3 RID: 53715
		// (get) Token: 0x06031A1D RID: 203293 RVA: 0x006B93C8 File Offset: 0x006B75C8
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

		// Token: 0x06031A1E RID: 203294 RVA: 0x006B9405 File Offset: 0x006B7605
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

		// Token: 0x06031A1F RID: 203295 RVA: 0x006B9439 File Offset: 0x006B7639
		public static void StartIHonamiStorySetFormation(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06031A20 RID: 203296 RVA: 0x006B9442 File Offset: 0x006B7642
		public static void AddActivityId(FlatBufferBuilder builder, int activityId)
		{
			builder.AddInt(0, activityId, 0);
		}

		// Token: 0x06031A21 RID: 203297 RVA: 0x006B944D File Offset: 0x006B764D
		public static void AddRoleSetting(FlatBufferBuilder builder, VectorOffset roleSettingOffset)
		{
			builder.AddOffset(1, roleSettingOffset.Value, 0);
		}

		// Token: 0x06031A22 RID: 203298 RVA: 0x006B9460 File Offset: 0x006B7660
		public static VectorOffset CreateRoleSettingVector(FlatBufferBuilder builder, Offset<IHonamiStoryRoleSetting>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06031A23 RID: 203299 RVA: 0x006B94A0 File Offset: 0x006B76A0
		public static VectorOffset CreateRoleSettingVectorBlock(FlatBufferBuilder builder, Offset<IHonamiStoryRoleSetting>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IHonamiStoryRoleSetting>>(data);
			return builder.EndVector();
		}

		// Token: 0x06031A24 RID: 203300 RVA: 0x006B94BA File Offset: 0x006B76BA
		public static VectorOffset CreateRoleSettingVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IHonamiStoryRoleSetting>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IHonamiStoryRoleSetting>>(data);
			return builder.EndVector();
		}

		// Token: 0x06031A25 RID: 203301 RVA: 0x006B94D8 File Offset: 0x006B76D8
		public static VectorOffset CreateRoleSettingVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IHonamiStoryRoleSetting>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031A26 RID: 203302 RVA: 0x006B94F1 File Offset: 0x006B76F1
		public static void StartRoleSettingVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031A27 RID: 203303 RVA: 0x006B94FC File Offset: 0x006B76FC
		public static void AddWeaponSetting(FlatBufferBuilder builder, VectorOffset weaponSettingOffset)
		{
			builder.AddOffset(2, weaponSettingOffset.Value, 0);
		}

		// Token: 0x06031A28 RID: 203304 RVA: 0x006B950C File Offset: 0x006B770C
		public static VectorOffset CreateWeaponSettingVector(FlatBufferBuilder builder, Offset<IHonamiStoryWeaponEquipSetting>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06031A29 RID: 203305 RVA: 0x006B954C File Offset: 0x006B774C
		public static VectorOffset CreateWeaponSettingVectorBlock(FlatBufferBuilder builder, Offset<IHonamiStoryWeaponEquipSetting>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IHonamiStoryWeaponEquipSetting>>(data);
			return builder.EndVector();
		}

		// Token: 0x06031A2A RID: 203306 RVA: 0x006B9566 File Offset: 0x006B7766
		public static VectorOffset CreateWeaponSettingVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IHonamiStoryWeaponEquipSetting>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IHonamiStoryWeaponEquipSetting>>(data);
			return builder.EndVector();
		}

		// Token: 0x06031A2B RID: 203307 RVA: 0x006B9584 File Offset: 0x006B7784
		public static VectorOffset CreateWeaponSettingVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IHonamiStoryWeaponEquipSetting>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031A2C RID: 203308 RVA: 0x006B959D File Offset: 0x006B779D
		public static void StartWeaponSettingVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031A2D RID: 203309 RVA: 0x006B95A8 File Offset: 0x006B77A8
		public static void AddPluginSetting(FlatBufferBuilder builder, VectorOffset pluginSettingOffset)
		{
			builder.AddOffset(3, pluginSettingOffset.Value, 0);
		}

		// Token: 0x06031A2E RID: 203310 RVA: 0x006B95B8 File Offset: 0x006B77B8
		public static VectorOffset CreatePluginSettingVector(FlatBufferBuilder builder, Offset<IHonamiStoryPluginEquipSetting>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06031A2F RID: 203311 RVA: 0x006B95F8 File Offset: 0x006B77F8
		public static VectorOffset CreatePluginSettingVectorBlock(FlatBufferBuilder builder, Offset<IHonamiStoryPluginEquipSetting>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IHonamiStoryPluginEquipSetting>>(data);
			return builder.EndVector();
		}

		// Token: 0x06031A30 RID: 203312 RVA: 0x006B9612 File Offset: 0x006B7812
		public static VectorOffset CreatePluginSettingVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IHonamiStoryPluginEquipSetting>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IHonamiStoryPluginEquipSetting>>(data);
			return builder.EndVector();
		}

		// Token: 0x06031A31 RID: 203313 RVA: 0x006B9630 File Offset: 0x006B7830
		public static VectorOffset CreatePluginSettingVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IHonamiStoryPluginEquipSetting>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031A32 RID: 203314 RVA: 0x006B9649 File Offset: 0x006B7849
		public static void StartPluginSettingVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031A33 RID: 203315 RVA: 0x006B9654 File Offset: 0x006B7854
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06031A34 RID: 203316 RVA: 0x006B965F File Offset: 0x006B785F
		public static Offset<IHonamiStorySetFormation> EndIHonamiStorySetFormation(FlatBufferBuilder builder)
		{
			return new Offset<IHonamiStorySetFormation>(builder.EndTable());
		}

		// Token: 0x06031A35 RID: 203317 RVA: 0x006B966C File Offset: 0x006B786C
		public IHonamiStorySetFormationT UnPack()
		{
			IHonamiStorySetFormationT honamiStorySetFormationT = new IHonamiStorySetFormationT();
			this.UnPackTo(honamiStorySetFormationT);
			return honamiStorySetFormationT;
		}

		// Token: 0x06031A36 RID: 203318 RVA: 0x006B9688 File Offset: 0x006B7888
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

		// Token: 0x06031A37 RID: 203319 RVA: 0x006B97B0 File Offset: 0x006B79B0
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

		// Token: 0x04011F1A RID: 73498
		private Table __p;
	}
}

using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EA4 RID: 16036
	public struct ILightPlateParams : IFlatbufferObject
	{
		// Token: 0x17006C71 RID: 27761
		// (get) Token: 0x06015AA8 RID: 88744 RVA: 0x0031EDF8 File Offset: 0x0031CFF8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015AA9 RID: 88745 RVA: 0x0031EE05 File Offset: 0x0031D005
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015AAA RID: 88746 RVA: 0x0031EE0C File Offset: 0x0031D00C
		public static ILightPlateParams GetRootAsILightPlateParams(ByteBuffer _bb)
		{
			return ILightPlateParams.GetRootAsILightPlateParams(_bb, default(ILightPlateParams));
		}

		// Token: 0x06015AAB RID: 88747 RVA: 0x0031EE28 File Offset: 0x0031D028
		public static ILightPlateParams GetRootAsILightPlateParams(ByteBuffer _bb, ILightPlateParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015AAC RID: 88748 RVA: 0x0031EE45 File Offset: 0x0031D045
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015AAD RID: 88749 RVA: 0x0031EE54 File Offset: 0x0031D054
		public ILightPlateParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C72 RID: 27762
		// (get) Token: 0x06015AAE RID: 88750 RVA: 0x0031EE64 File Offset: 0x0031D064
		public EParamsPreset Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EParamsPreset.Decal;
				}
				return (EParamsPreset)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006C73 RID: 27763
		// (get) Token: 0x06015AAF RID: 88751 RVA: 0x0031EEA0 File Offset: 0x0031D0A0
		public float RayCastingDetectDis
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006C74 RID: 27764
		// (get) Token: 0x06015AB0 RID: 88752 RVA: 0x0031EEE0 File Offset: 0x0031D0E0
		public float MaxDegreeAngle
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006C75 RID: 27765
		// (get) Token: 0x06015AB1 RID: 88753 RVA: 0x0031EF20 File Offset: 0x0031D120
		public float ReturnSpeedDegreePerSecond
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006C76 RID: 27766
		// (get) Token: 0x06015AB2 RID: 88754 RVA: 0x0031EF64 File Offset: 0x0031D164
		public float FollowSpeedDegreePerSecond
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006C77 RID: 27767
		// (get) Token: 0x06015AB3 RID: 88755 RVA: 0x0031EFA8 File Offset: 0x0031D1A8
		public float MinActiveRadius
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006C78 RID: 27768
		// (get) Token: 0x06015AB4 RID: 88756 RVA: 0x0031EFEC File Offset: 0x0031D1EC
		public float MaxActiveRadius
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006C79 RID: 27769
		// (get) Token: 0x06015AB5 RID: 88757 RVA: 0x0031F030 File Offset: 0x0031D230
		public bool EnableLightPlate
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06015AB6 RID: 88758 RVA: 0x0031F070 File Offset: 0x0031D270
		public int IgnoreEntities(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006C7A RID: 27770
		// (get) Token: 0x06015AB7 RID: 88759 RVA: 0x0031F0B0 File Offset: 0x0031D2B0
		public int IgnoreEntitiesLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06015AB8 RID: 88760 RVA: 0x0031F0DC File Offset: 0x0031D2DC
		public Span<int> GetIgnoreEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x06015AB9 RID: 88761 RVA: 0x0031F0EC File Offset: 0x0031D2EC
		public int[] GetIgnoreEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(20);
		}

		// Token: 0x17006C7B RID: 27771
		// (get) Token: 0x06015ABA RID: 88762 RVA: 0x0031F0FC File Offset: 0x0031D2FC
		public bool DoNotNeedRayCasting
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006C7C RID: 27772
		// (get) Token: 0x06015ABB RID: 88763 RVA: 0x0031F13C File Offset: 0x0031D33C
		public bool MultiPlateMode
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006C7D RID: 27773
		// (get) Token: 0x06015ABC RID: 88764 RVA: 0x0031F17C File Offset: 0x0031D37C
		public bool LockCollisionMode
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006C7E RID: 27774
		// (get) Token: 0x06015ABD RID: 88765 RVA: 0x0031F1BC File Offset: 0x0031D3BC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015ABE RID: 88766 RVA: 0x0031F1FC File Offset: 0x0031D3FC
		public static Offset<ILightPlateParams> CreateILightPlateParams(FlatBufferBuilder builder, EParamsPreset Type = EParamsPreset.Decal, float RayCastingDetectDis = 0f, float MaxDegreeAngle = 0f, float ReturnSpeedDegreePerSecond = 0f, float FollowSpeedDegreePerSecond = 0f, float MinActiveRadius = 0f, float MaxActiveRadius = 0f, bool EnableLightPlate = false, VectorOffset IgnoreEntitiesOffset = default(VectorOffset), bool DoNotNeedRayCasting = false, bool MultiPlateMode = false, bool LockCollisionMode = false, byte NullMask = 0)
		{
			builder.StartTable(13);
			ILightPlateParams.AddIgnoreEntities(builder, IgnoreEntitiesOffset);
			ILightPlateParams.AddMaxActiveRadius(builder, MaxActiveRadius);
			ILightPlateParams.AddMinActiveRadius(builder, MinActiveRadius);
			ILightPlateParams.AddFollowSpeedDegreePerSecond(builder, FollowSpeedDegreePerSecond);
			ILightPlateParams.AddReturnSpeedDegreePerSecond(builder, ReturnSpeedDegreePerSecond);
			ILightPlateParams.AddMaxDegreeAngle(builder, MaxDegreeAngle);
			ILightPlateParams.AddRayCastingDetectDis(builder, RayCastingDetectDis);
			ILightPlateParams.AddNullMask(builder, NullMask);
			ILightPlateParams.AddLockCollisionMode(builder, LockCollisionMode);
			ILightPlateParams.AddMultiPlateMode(builder, MultiPlateMode);
			ILightPlateParams.AddDoNotNeedRayCasting(builder, DoNotNeedRayCasting);
			ILightPlateParams.AddEnableLightPlate(builder, EnableLightPlate);
			ILightPlateParams.AddType(builder, Type);
			return ILightPlateParams.EndILightPlateParams(builder);
		}

		// Token: 0x06015ABF RID: 88767 RVA: 0x0031F27C File Offset: 0x0031D47C
		public static void StartILightPlateParams(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x06015AC0 RID: 88768 RVA: 0x0031F286 File Offset: 0x0031D486
		public static void AddType(FlatBufferBuilder builder, EParamsPreset type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015AC1 RID: 88769 RVA: 0x0031F291 File Offset: 0x0031D491
		public static void AddRayCastingDetectDis(FlatBufferBuilder builder, float rayCastingDetectDis)
		{
			builder.AddFloat(1, rayCastingDetectDis, 0.0);
		}

		// Token: 0x06015AC2 RID: 88770 RVA: 0x0031F2A4 File Offset: 0x0031D4A4
		public static void AddMaxDegreeAngle(FlatBufferBuilder builder, float maxDegreeAngle)
		{
			builder.AddFloat(2, maxDegreeAngle, 0.0);
		}

		// Token: 0x06015AC3 RID: 88771 RVA: 0x0031F2B7 File Offset: 0x0031D4B7
		public static void AddReturnSpeedDegreePerSecond(FlatBufferBuilder builder, float returnSpeedDegreePerSecond)
		{
			builder.AddFloat(3, returnSpeedDegreePerSecond, 0.0);
		}

		// Token: 0x06015AC4 RID: 88772 RVA: 0x0031F2CA File Offset: 0x0031D4CA
		public static void AddFollowSpeedDegreePerSecond(FlatBufferBuilder builder, float followSpeedDegreePerSecond)
		{
			builder.AddFloat(4, followSpeedDegreePerSecond, 0.0);
		}

		// Token: 0x06015AC5 RID: 88773 RVA: 0x0031F2DD File Offset: 0x0031D4DD
		public static void AddMinActiveRadius(FlatBufferBuilder builder, float minActiveRadius)
		{
			builder.AddFloat(5, minActiveRadius, 0.0);
		}

		// Token: 0x06015AC6 RID: 88774 RVA: 0x0031F2F0 File Offset: 0x0031D4F0
		public static void AddMaxActiveRadius(FlatBufferBuilder builder, float maxActiveRadius)
		{
			builder.AddFloat(6, maxActiveRadius, 0.0);
		}

		// Token: 0x06015AC7 RID: 88775 RVA: 0x0031F303 File Offset: 0x0031D503
		public static void AddEnableLightPlate(FlatBufferBuilder builder, bool enableLightPlate)
		{
			builder.AddBool(7, enableLightPlate, false);
		}

		// Token: 0x06015AC8 RID: 88776 RVA: 0x0031F30E File Offset: 0x0031D50E
		public static void AddIgnoreEntities(FlatBufferBuilder builder, VectorOffset ignoreEntitiesOffset)
		{
			builder.AddOffset(8, ignoreEntitiesOffset.Value, 0);
		}

		// Token: 0x06015AC9 RID: 88777 RVA: 0x0031F320 File Offset: 0x0031D520
		public static VectorOffset CreateIgnoreEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06015ACA RID: 88778 RVA: 0x0031F357 File Offset: 0x0031D557
		public static VectorOffset CreateIgnoreEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06015ACB RID: 88779 RVA: 0x0031F371 File Offset: 0x0031D571
		public static VectorOffset CreateIgnoreEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06015ACC RID: 88780 RVA: 0x0031F38F File Offset: 0x0031D58F
		public static VectorOffset CreateIgnoreEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06015ACD RID: 88781 RVA: 0x0031F3A8 File Offset: 0x0031D5A8
		public static void StartIgnoreEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06015ACE RID: 88782 RVA: 0x0031F3B3 File Offset: 0x0031D5B3
		public static void AddDoNotNeedRayCasting(FlatBufferBuilder builder, bool doNotNeedRayCasting)
		{
			builder.AddBool(9, doNotNeedRayCasting, false);
		}

		// Token: 0x06015ACF RID: 88783 RVA: 0x0031F3BF File Offset: 0x0031D5BF
		public static void AddMultiPlateMode(FlatBufferBuilder builder, bool multiPlateMode)
		{
			builder.AddBool(10, multiPlateMode, false);
		}

		// Token: 0x06015AD0 RID: 88784 RVA: 0x0031F3CB File Offset: 0x0031D5CB
		public static void AddLockCollisionMode(FlatBufferBuilder builder, bool lockCollisionMode)
		{
			builder.AddBool(11, lockCollisionMode, false);
		}

		// Token: 0x06015AD1 RID: 88785 RVA: 0x0031F3D7 File Offset: 0x0031D5D7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(12, nullMask, 0);
		}

		// Token: 0x06015AD2 RID: 88786 RVA: 0x0031F3E3 File Offset: 0x0031D5E3
		public static Offset<ILightPlateParams> EndILightPlateParams(FlatBufferBuilder builder)
		{
			return new Offset<ILightPlateParams>(builder.EndTable());
		}

		// Token: 0x06015AD3 RID: 88787 RVA: 0x0031F3F0 File Offset: 0x0031D5F0
		public ILightPlateParamsT UnPack()
		{
			ILightPlateParamsT lightPlateParamsT = new ILightPlateParamsT();
			this.UnPackTo(lightPlateParamsT);
			return lightPlateParamsT;
		}

		// Token: 0x06015AD4 RID: 88788 RVA: 0x0031F40C File Offset: 0x0031D60C
		public void UnPackTo(ILightPlateParamsT _o)
		{
			_o.Type = this.Type;
			_o.RayCastingDetectDis = this.RayCastingDetectDis;
			_o.MaxDegreeAngle = this.MaxDegreeAngle;
			_o.ReturnSpeedDegreePerSecond = this.ReturnSpeedDegreePerSecond;
			_o.FollowSpeedDegreePerSecond = this.FollowSpeedDegreePerSecond;
			_o.MinActiveRadius = this.MinActiveRadius;
			_o.MaxActiveRadius = this.MaxActiveRadius;
			_o.EnableLightPlate = this.EnableLightPlate;
			_o.IgnoreEntities = new List<int>();
			for (int i = 0; i < this.IgnoreEntitiesLength; i++)
			{
				_o.IgnoreEntities.Add(this.IgnoreEntities(i));
			}
			_o.DoNotNeedRayCasting = this.DoNotNeedRayCasting;
			_o.MultiPlateMode = this.MultiPlateMode;
			_o.LockCollisionMode = this.LockCollisionMode;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06015AD5 RID: 88789 RVA: 0x0031F4D8 File Offset: 0x0031D6D8
		public static Offset<ILightPlateParams> Pack(FlatBufferBuilder builder, ILightPlateParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILightPlateParams>);
			}
			VectorOffset ignoreEntitiesOffset = default(VectorOffset);
			if (_o.IgnoreEntities != null)
			{
				int[] data = _o.IgnoreEntities.ToArray();
				ignoreEntitiesOffset = ILightPlateParams.CreateIgnoreEntitiesVector(builder, data);
			}
			return ILightPlateParams.CreateILightPlateParams(builder, _o.Type, _o.RayCastingDetectDis, _o.MaxDegreeAngle, _o.ReturnSpeedDegreePerSecond, _o.FollowSpeedDegreePerSecond, _o.MinActiveRadius, _o.MaxActiveRadius, _o.EnableLightPlate, ignoreEntitiesOffset, _o.DoNotNeedRayCasting, _o.MultiPlateMode, _o.LockCollisionMode, _o.NullMask);
		}

		// Token: 0x0400B88E RID: 47246
		private Table __p;
	}
}

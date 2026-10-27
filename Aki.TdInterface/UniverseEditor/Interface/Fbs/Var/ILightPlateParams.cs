using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AA2 RID: 15010
	public struct ILightPlateParams : IFlatbufferObject
	{
		// Token: 0x170066D6 RID: 26326
		// (get) Token: 0x06014602 RID: 83458 RVA: 0x002F8BEC File Offset: 0x002F6DEC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014603 RID: 83459 RVA: 0x002F8BF9 File Offset: 0x002F6DF9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014604 RID: 83460 RVA: 0x002F8C00 File Offset: 0x002F6E00
		public static ILightPlateParams GetRootAsILightPlateParams(ByteBuffer _bb)
		{
			return ILightPlateParams.GetRootAsILightPlateParams(_bb, default(ILightPlateParams));
		}

		// Token: 0x06014605 RID: 83461 RVA: 0x002F8C1C File Offset: 0x002F6E1C
		public static ILightPlateParams GetRootAsILightPlateParams(ByteBuffer _bb, ILightPlateParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014606 RID: 83462 RVA: 0x002F8C39 File Offset: 0x002F6E39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014607 RID: 83463 RVA: 0x002F8C48 File Offset: 0x002F6E48
		public ILightPlateParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170066D7 RID: 26327
		// (get) Token: 0x06014608 RID: 83464 RVA: 0x002F8C58 File Offset: 0x002F6E58
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

		// Token: 0x170066D8 RID: 26328
		// (get) Token: 0x06014609 RID: 83465 RVA: 0x002F8C94 File Offset: 0x002F6E94
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

		// Token: 0x170066D9 RID: 26329
		// (get) Token: 0x0601460A RID: 83466 RVA: 0x002F8CD4 File Offset: 0x002F6ED4
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

		// Token: 0x170066DA RID: 26330
		// (get) Token: 0x0601460B RID: 83467 RVA: 0x002F8D14 File Offset: 0x002F6F14
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

		// Token: 0x170066DB RID: 26331
		// (get) Token: 0x0601460C RID: 83468 RVA: 0x002F8D58 File Offset: 0x002F6F58
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

		// Token: 0x170066DC RID: 26332
		// (get) Token: 0x0601460D RID: 83469 RVA: 0x002F8D9C File Offset: 0x002F6F9C
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

		// Token: 0x170066DD RID: 26333
		// (get) Token: 0x0601460E RID: 83470 RVA: 0x002F8DE0 File Offset: 0x002F6FE0
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

		// Token: 0x170066DE RID: 26334
		// (get) Token: 0x0601460F RID: 83471 RVA: 0x002F8E24 File Offset: 0x002F7024
		public bool EnableLightPlate
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06014610 RID: 83472 RVA: 0x002F8E64 File Offset: 0x002F7064
		public int IgnoreEntities(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170066DF RID: 26335
		// (get) Token: 0x06014611 RID: 83473 RVA: 0x002F8EA4 File Offset: 0x002F70A4
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

		// Token: 0x06014612 RID: 83474 RVA: 0x002F8ED0 File Offset: 0x002F70D0
		public Span<int> GetIgnoreEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x06014613 RID: 83475 RVA: 0x002F8EE0 File Offset: 0x002F70E0
		public int[] GetIgnoreEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(20);
		}

		// Token: 0x170066E0 RID: 26336
		// (get) Token: 0x06014614 RID: 83476 RVA: 0x002F8EF0 File Offset: 0x002F70F0
		public bool DoNotNeedRayCasting
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170066E1 RID: 26337
		// (get) Token: 0x06014615 RID: 83477 RVA: 0x002F8F30 File Offset: 0x002F7130
		public bool MultiPlateMode
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170066E2 RID: 26338
		// (get) Token: 0x06014616 RID: 83478 RVA: 0x002F8F70 File Offset: 0x002F7170
		public bool LockCollisionMode
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170066E3 RID: 26339
		// (get) Token: 0x06014617 RID: 83479 RVA: 0x002F8FB0 File Offset: 0x002F71B0
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

		// Token: 0x06014618 RID: 83480 RVA: 0x002F8FF0 File Offset: 0x002F71F0
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

		// Token: 0x06014619 RID: 83481 RVA: 0x002F9070 File Offset: 0x002F7270
		public static void StartILightPlateParams(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x0601461A RID: 83482 RVA: 0x002F907A File Offset: 0x002F727A
		public static void AddType(FlatBufferBuilder builder, EParamsPreset type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601461B RID: 83483 RVA: 0x002F9085 File Offset: 0x002F7285
		public static void AddRayCastingDetectDis(FlatBufferBuilder builder, float rayCastingDetectDis)
		{
			builder.AddFloat(1, rayCastingDetectDis, 0.0);
		}

		// Token: 0x0601461C RID: 83484 RVA: 0x002F9098 File Offset: 0x002F7298
		public static void AddMaxDegreeAngle(FlatBufferBuilder builder, float maxDegreeAngle)
		{
			builder.AddFloat(2, maxDegreeAngle, 0.0);
		}

		// Token: 0x0601461D RID: 83485 RVA: 0x002F90AB File Offset: 0x002F72AB
		public static void AddReturnSpeedDegreePerSecond(FlatBufferBuilder builder, float returnSpeedDegreePerSecond)
		{
			builder.AddFloat(3, returnSpeedDegreePerSecond, 0.0);
		}

		// Token: 0x0601461E RID: 83486 RVA: 0x002F90BE File Offset: 0x002F72BE
		public static void AddFollowSpeedDegreePerSecond(FlatBufferBuilder builder, float followSpeedDegreePerSecond)
		{
			builder.AddFloat(4, followSpeedDegreePerSecond, 0.0);
		}

		// Token: 0x0601461F RID: 83487 RVA: 0x002F90D1 File Offset: 0x002F72D1
		public static void AddMinActiveRadius(FlatBufferBuilder builder, float minActiveRadius)
		{
			builder.AddFloat(5, minActiveRadius, 0.0);
		}

		// Token: 0x06014620 RID: 83488 RVA: 0x002F90E4 File Offset: 0x002F72E4
		public static void AddMaxActiveRadius(FlatBufferBuilder builder, float maxActiveRadius)
		{
			builder.AddFloat(6, maxActiveRadius, 0.0);
		}

		// Token: 0x06014621 RID: 83489 RVA: 0x002F90F7 File Offset: 0x002F72F7
		public static void AddEnableLightPlate(FlatBufferBuilder builder, bool enableLightPlate)
		{
			builder.AddBool(7, enableLightPlate, false);
		}

		// Token: 0x06014622 RID: 83490 RVA: 0x002F9102 File Offset: 0x002F7302
		public static void AddIgnoreEntities(FlatBufferBuilder builder, VectorOffset ignoreEntitiesOffset)
		{
			builder.AddOffset(8, ignoreEntitiesOffset.Value, 0);
		}

		// Token: 0x06014623 RID: 83491 RVA: 0x002F9114 File Offset: 0x002F7314
		public static VectorOffset CreateIgnoreEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06014624 RID: 83492 RVA: 0x002F914B File Offset: 0x002F734B
		public static VectorOffset CreateIgnoreEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06014625 RID: 83493 RVA: 0x002F9165 File Offset: 0x002F7365
		public static VectorOffset CreateIgnoreEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06014626 RID: 83494 RVA: 0x002F9183 File Offset: 0x002F7383
		public static VectorOffset CreateIgnoreEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06014627 RID: 83495 RVA: 0x002F919C File Offset: 0x002F739C
		public static void StartIgnoreEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06014628 RID: 83496 RVA: 0x002F91A7 File Offset: 0x002F73A7
		public static void AddDoNotNeedRayCasting(FlatBufferBuilder builder, bool doNotNeedRayCasting)
		{
			builder.AddBool(9, doNotNeedRayCasting, false);
		}

		// Token: 0x06014629 RID: 83497 RVA: 0x002F91B3 File Offset: 0x002F73B3
		public static void AddMultiPlateMode(FlatBufferBuilder builder, bool multiPlateMode)
		{
			builder.AddBool(10, multiPlateMode, false);
		}

		// Token: 0x0601462A RID: 83498 RVA: 0x002F91BF File Offset: 0x002F73BF
		public static void AddLockCollisionMode(FlatBufferBuilder builder, bool lockCollisionMode)
		{
			builder.AddBool(11, lockCollisionMode, false);
		}

		// Token: 0x0601462B RID: 83499 RVA: 0x002F91CB File Offset: 0x002F73CB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(12, nullMask, 0);
		}

		// Token: 0x0601462C RID: 83500 RVA: 0x002F91D7 File Offset: 0x002F73D7
		public static Offset<ILightPlateParams> EndILightPlateParams(FlatBufferBuilder builder)
		{
			return new Offset<ILightPlateParams>(builder.EndTable());
		}

		// Token: 0x0601462D RID: 83501 RVA: 0x002F91E4 File Offset: 0x002F73E4
		public ILightPlateParamsT UnPack()
		{
			ILightPlateParamsT lightPlateParamsT = new ILightPlateParamsT();
			this.UnPackTo(lightPlateParamsT);
			return lightPlateParamsT;
		}

		// Token: 0x0601462E RID: 83502 RVA: 0x002F9200 File Offset: 0x002F7400
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

		// Token: 0x0601462F RID: 83503 RVA: 0x002F92CC File Offset: 0x002F74CC
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

		// Token: 0x0400AF23 RID: 44835
		private Table __p;
	}
}

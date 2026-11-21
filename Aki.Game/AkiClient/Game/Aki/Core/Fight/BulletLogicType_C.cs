using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003258 RID: 12888
	[UnrealObjectPath("/Game/Aki/Core/Fight/BulletLogicType.BulletLogicType_C")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 163)]
	public class BulletLogicType_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020349 RID: 131913 RVA: 0x00940105 File Offset: 0x0093E305
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BulletLogicType_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/Fight/BulletLogicType.BulletLogicType_C");
			}
			return BulletLogicType_C._ClassPtr;
		}

		// Token: 0x0602034A RID: 131914 RVA: 0x0094012C File Offset: 0x0093E32C
		public BulletLogicType_C() : this(BuiltinUtils.AllocNativeUObject(BulletLogicType_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602034B RID: 131915 RVA: 0x00940154 File Offset: 0x0093E354
		[NullableContext(1)]
		public BulletLogicType_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BulletLogicType_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003DD1 RID: 15825
		// (get) Token: 0x0602034C RID: 131916 RVA: 0x00940187 File Offset: 0x0093E387
		// (set) Token: 0x0602034D RID: 131917 RVA: 0x00940197 File Offset: 0x0093E397
		public unsafe bool 次数为0时销毁
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_次数为0时销毁) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_次数为0时销毁) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DD2 RID: 15826
		// (get) Token: 0x0602034E RID: 131918 RVA: 0x009401A8 File Offset: 0x0093E3A8
		// (set) Token: 0x0602034F RID: 131919 RVA: 0x009401B8 File Offset: 0x0093E3B8
		public unsafe bool 是否可以触发拼刀
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_是否可以触发拼刀) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_是否可以触发拼刀) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DD3 RID: 15827
		// (get) Token: 0x06020350 RID: 131920 RVA: 0x009401C9 File Offset: 0x0093E3C9
		// (set) Token: 0x06020351 RID: 131921 RVA: 0x009401D9 File Offset: 0x0093E3D9
		public unsafe bool 是否可以触发极限闪避
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_是否可以触发极限闪避) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_是否可以触发极限闪避) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DD4 RID: 15828
		// (get) Token: 0x06020352 RID: 131922 RVA: 0x009401EA File Offset: 0x0093E3EA
		// (set) Token: 0x06020353 RID: 131923 RVA: 0x009401FA File Offset: 0x0093E3FA
		public unsafe bool 拼刀忽略距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_拼刀忽略距离) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_拼刀忽略距离) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DD5 RID: 15829
		// (get) Token: 0x06020354 RID: 131924 RVA: 0x0094020B File Offset: 0x0093E40B
		// (set) Token: 0x06020355 RID: 131925 RVA: 0x0094021B File Offset: 0x0093E41B
		public unsafe bool 拼刀忽略角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_拼刀忽略角度) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_拼刀忽略角度) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DD6 RID: 15830
		// (get) Token: 0x06020356 RID: 131926 RVA: 0x0094022C File Offset: 0x0093E42C
		// (set) Token: 0x06020357 RID: 131927 RVA: 0x0094023C File Offset: 0x0093E43C
		public unsafe bool 触发前摇拼刀
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_触发前摇拼刀) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_触发前摇拼刀) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DD7 RID: 15831
		// (get) Token: 0x06020358 RID: 131928 RVA: 0x0094024D File Offset: 0x0093E44D
		// (set) Token: 0x06020359 RID: 131929 RVA: 0x0094025D File Offset: 0x0093E45D
		public unsafe bool 是否可以触发对策
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_是否可以触发对策) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_是否可以触发对策) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DD8 RID: 15832
		// (get) Token: 0x0602035A RID: 131930 RVA: 0x0094026E File Offset: 0x0093E46E
		// (set) Token: 0x0602035B RID: 131931 RVA: 0x00940282 File Offset: 0x0093E482
		public unsafe FName 子弹碰撞预设
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_子弹碰撞预设);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_子弹碰撞预设) = value;
			}
		}

		// Token: 0x17003DD9 RID: 15833
		// (get) Token: 0x0602035C RID: 131932 RVA: 0x00940297 File Offset: 0x0093E497
		// (set) Token: 0x0602035D RID: 131933 RVA: 0x009402A7 File Offset: 0x0093E4A7
		public unsafe bool 子弹碰撞障碍销毁
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_子弹碰撞障碍销毁) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_子弹碰撞障碍销毁) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DDA RID: 15834
		// (get) Token: 0x0602035E RID: 131934 RVA: 0x009402B8 File Offset: 0x0093E4B8
		// (set) Token: 0x0602035F RID: 131935 RVA: 0x009402C8 File Offset: 0x0093E4C8
		public unsafe bool 子弹碰撞单位销毁
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_子弹碰撞单位销毁) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_子弹碰撞单位销毁) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DDB RID: 15835
		// (get) Token: 0x06020360 RID: 131936 RVA: 0x009402D9 File Offset: 0x0093E4D9
		// (set) Token: 0x06020361 RID: 131937 RVA: 0x009402ED File Offset: 0x0093E4ED
		public unsafe TEnumAsByte<AkiClient.Game.Aki.Character.BaseCharacter.EBulletType> 子弹类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_子弹类型);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_子弹类型) = value;
			}
		}

		// Token: 0x17003DDC RID: 15836
		// (get) Token: 0x06020362 RID: 131938 RVA: 0x00940302 File Offset: 0x0093E502
		// (set) Token: 0x06020363 RID: 131939 RVA: 0x00940316 File Offset: 0x0093E516
		public unsafe TEnumAsByte<AkiClient.Game.Aki.Character.BaseCharacter.EBulletHitDirectionType> 子弹受击类型角度判断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_子弹受击类型角度判断);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_子弹受击类型角度判断) = value;
			}
		}

		// Token: 0x17003DDD RID: 15837
		// (get) Token: 0x06020364 RID: 131940 RVA: 0x0094032B File Offset: 0x0093E52B
		// (set) Token: 0x06020365 RID: 131941 RVA: 0x0094033B File Offset: 0x0093E53B
		public unsafe int 弹反通道
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_弹反通道);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_弹反通道) = value;
			}
		}

		// Token: 0x17003DDE RID: 15838
		// (get) Token: 0x06020366 RID: 131942 RVA: 0x0094034C File Offset: 0x0093E54C
		// (set) Token: 0x06020367 RID: 131943 RVA: 0x0094035C File Offset: 0x0093E55C
		public unsafe bool 开启水面交互
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_开启水面交互) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_开启水面交互) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DDF RID: 15839
		// (get) Token: 0x06020368 RID: 131944 RVA: 0x00940370 File Offset: 0x0093E570
		// (set) Token: 0x06020369 RID: 131945 RVA: 0x009403A9 File Offset: 0x0093E5A9
		[Nullable(1)]
		public FGameplayTagContainer 预设标签
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._预设标签) == null)
				{
					result = (this._预设标签 = new FGameplayTagContainer(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_预设标签, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_预设标签, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003DE0 RID: 15840
		// (get) Token: 0x0602036A RID: 131946 RVA: 0x009403CA File Offset: 0x0093E5CA
		// (set) Token: 0x0602036B RID: 131947 RVA: 0x009403DE File Offset: 0x0093E5DE
		[Nullable(1)]
		public unsafe string 只碰撞胶囊体
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BulletLogicType_C.__PropertyOffset_只碰撞胶囊体)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BulletLogicType_C.__PropertyOffset_只碰撞胶囊体)), value);
			}
		}

		// Token: 0x17003DE1 RID: 15841
		// (get) Token: 0x0602036C RID: 131948 RVA: 0x009403F3 File Offset: 0x0093E5F3
		// (set) Token: 0x0602036D RID: 131949 RVA: 0x00940403 File Offset: 0x0093E603
		public unsafe bool 忽略水体
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_忽略水体) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_忽略水体) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DE2 RID: 15842
		// (get) Token: 0x0602036E RID: 131950 RVA: 0x00940414 File Offset: 0x0093E614
		// (set) Token: 0x0602036F RID: 131951 RVA: 0x00940424 File Offset: 0x0093E624
		public unsafe bool 冰冻时销毁
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_冰冻时销毁) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_冰冻时销毁) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DE3 RID: 15843
		// (get) Token: 0x06020370 RID: 131952 RVA: 0x00940435 File Offset: 0x0093E635
		// (set) Token: 0x06020371 RID: 131953 RVA: 0x00940445 File Offset: 0x0093E645
		public unsafe bool 开启空气墙交互
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_开启空气墙交互) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletLogicType_C.__PropertyOffset_开启空气墙交互) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020372 RID: 131954 RVA: 0x00940456 File Offset: 0x0093E656
		protected BulletLogicType_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011573 RID: 71027
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Core/Fight/BulletLogicType.BulletLogicType_C";

		// Token: 0x04011574 RID: 71028
		private static IntPtr _ClassPtr;

		// Token: 0x04011575 RID: 71029
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011576 RID: 71030
		internal static int __PropertyOffset_次数为0时销毁;

		// Token: 0x04011577 RID: 71031
		internal static int __PropertyOffset_是否可以触发拼刀;

		// Token: 0x04011578 RID: 71032
		internal static int __PropertyOffset_是否可以触发极限闪避;

		// Token: 0x04011579 RID: 71033
		internal static int __PropertyOffset_拼刀忽略距离;

		// Token: 0x0401157A RID: 71034
		internal static int __PropertyOffset_拼刀忽略角度;

		// Token: 0x0401157B RID: 71035
		internal static int __PropertyOffset_触发前摇拼刀;

		// Token: 0x0401157C RID: 71036
		internal static int __PropertyOffset_是否可以触发对策;

		// Token: 0x0401157D RID: 71037
		internal static int __PropertyOffset_子弹碰撞预设;

		// Token: 0x0401157E RID: 71038
		internal static int __PropertyOffset_子弹碰撞障碍销毁;

		// Token: 0x0401157F RID: 71039
		internal static int __PropertyOffset_子弹碰撞单位销毁;

		// Token: 0x04011580 RID: 71040
		internal static int __PropertyOffset_子弹类型;

		// Token: 0x04011581 RID: 71041
		internal static int __PropertyOffset_子弹受击类型角度判断;

		// Token: 0x04011582 RID: 71042
		internal static int __PropertyOffset_弹反通道;

		// Token: 0x04011583 RID: 71043
		internal static int __PropertyOffset_开启水面交互;

		// Token: 0x04011584 RID: 71044
		internal static int __PropertyOffset_预设标签;

		// Token: 0x04011585 RID: 71045
		[Nullable(2)]
		private FGameplayTagContainer _预设标签;

		// Token: 0x04011586 RID: 71046
		internal static int __PropertyOffset_只碰撞胶囊体;

		// Token: 0x04011587 RID: 71047
		internal static int __PropertyOffset_忽略水体;

		// Token: 0x04011588 RID: 71048
		internal static int __PropertyOffset_冰冻时销毁;

		// Token: 0x04011589 RID: 71049
		internal static int __PropertyOffset_开启空气墙交互;
	}
}

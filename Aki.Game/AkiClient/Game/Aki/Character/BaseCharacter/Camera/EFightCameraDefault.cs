using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033CA RID: 13258
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraDefault.EFightCameraDefault")]
	public enum EFightCameraDefault : byte
	{
		// Token: 0x040126AC RID: 75436
		None,
		// Token: 0x040126AD RID: 75437
		基础臂长,
		// Token: 0x040126AE RID: 75438
		最小臂长,
		// Token: 0x040126AF RID: 75439
		最大臂长,
		// Token: 0x040126B0 RID: 75440
		废弃1,
		// Token: 0x040126B1 RID: 75441
		Fov,
		// Token: 0x040126B2 RID: 75442
		相机臂偏移X,
		// Token: 0x040126B3 RID: 75443
		相机臂偏移Y,
		// Token: 0x040126B4 RID: 75444
		相机臂偏移Z,
		// Token: 0x040126B5 RID: 75445
		切换角色相机臂中心点过渡时间,
		// Token: 0x040126B6 RID: 75446
		在水中摄像机碰撞检测起点额外高度,
		// Token: 0x040126B7 RID: 75447
		障碍碰撞检测胶囊体半径,
		// Token: 0x040126B8 RID: 75448
		自动俯仰角输入水平偏移,
		// Token: 0x040126B9 RID: 75449
		自动俯仰角输入垂直偏移,
		// Token: 0x040126BA RID: 75450
		自动俯仰角输入下界,
		// Token: 0x040126BB RID: 75451
		自动俯仰角输入中界,
		// Token: 0x040126BC RID: 75452
		自动俯仰角输入上界,
		// Token: 0x040126BD RID: 75453
		自动俯仰角输出下界,
		// Token: 0x040126BE RID: 75454
		自动俯仰角输出中界,
		// Token: 0x040126BF RID: 75455
		自动俯仰角输出上界,
		// Token: 0x040126C0 RID: 75456
		弹簧臂中心点上下插值最小速度,
		// Token: 0x040126C1 RID: 75457
		弹簧臂中心点上下插值最大速度,
		// Token: 0x040126C2 RID: 75458
		弹簧臂中心点上下偏移距离下界,
		// Token: 0x040126C3 RID: 75459
		弹簧臂中心点上下偏移距离上界,
		// Token: 0x040126C4 RID: 75460
		最小上浮臂长,
		// Token: 0x040126C5 RID: 75461
		最大上浮臂长,
		// Token: 0x040126C6 RID: 75462
		弹簧臂中心点前后插值最小速度,
		// Token: 0x040126C7 RID: 75463
		弹簧臂中心点前后插值最大速度,
		// Token: 0x040126C8 RID: 75464
		弹簧臂中心点前后偏移距离下界,
		// Token: 0x040126C9 RID: 75465
		弹簧臂中心点前后偏移距离上界,
		// Token: 0x040126CA RID: 75466
		复查障碍碰撞检测胶囊体半径,
		// Token: 0x040126CB RID: 75467
		复查障碍碰撞检测间隔距离,
		// Token: 0x040126CC RID: 75468
		退出障碍碰撞检测胶囊体半径,
		// Token: 0x040126CD RID: 75469
		Yaw限制Min,
		// Token: 0x040126CE RID: 75470
		Yaw限制Max,
		// Token: 0x040126CF RID: 75471
		MaxDistance,
		// Token: 0x040126D0 RID: 75472
		InSpeed,
		// Token: 0x040126D1 RID: 75473
		OutSpeed,
		// Token: 0x040126D2 RID: 75474
		CollisionSizePercentage,
		// Token: 0x040126D3 RID: 75475
		CenterCollisionSize,
		// Token: 0x040126D4 RID: 75476
		角色开始虚化距离,
		// Token: 0x040126D5 RID: 75477
		角色最大虚化距离,
		// Token: 0x040126D6 RID: 75478
		角色开始虚化仰视角,
		// Token: 0x040126D7 RID: 75479
		角色最大虚化仰视角,
		// Token: 0x040126D8 RID: 75480
		角色虚化不透明度,
		// Token: 0x040126D9 RID: 75481
		Pitch限制Min,
		// Token: 0x040126DA RID: 75482
		Pitch限制Max,
		// Token: 0x040126DB RID: 75483
		弹簧臂中心点左右插值最小速度,
		// Token: 0x040126DC RID: 75484
		弹簧臂中心点左右插值最大速度,
		// Token: 0x040126DD RID: 75485
		弹簧臂中心点左右偏移距离下界,
		// Token: 0x040126DE RID: 75486
		弹簧臂中心点左右偏移距离上界,
		// Token: 0x040126DF RID: 75487
		瞄准射击俯视Z轴偏移,
		// Token: 0x040126E0 RID: 75488
		瞄准射击仰视Z轴偏移,
		// Token: 0x040126E1 RID: 75489
		游标目标旋转Alpha速率下界,
		// Token: 0x040126E2 RID: 75490
		游标目标旋转Alpha速率上界,
		// Token: 0x040126E3 RID: 75491
		游标目标旋转Alpha速率,
		// Token: 0x040126E4 RID: 75492
		禁用重置视角,
		// Token: 0x040126E5 RID: 75493
		额外Pitch最小叠加值,
		// Token: 0x040126E6 RID: 75494
		额外Pitch最大叠加值,
		// Token: 0x040126E7 RID: 75495
		额外Pitch叠加高度,
		// Token: 0x040126E8 RID: 75496
		WorldYaw限制Min,
		// Token: 0x040126E9 RID: 75497
		WorldYaw限制Max,
		// Token: 0x040126EA RID: 75498
		相机臂原点偏移X,
		// Token: 0x040126EB RID: 75499
		相机臂原点偏移Y,
		// Token: 0x040126EC RID: 75500
		相机臂原点偏移Z,
		// Token: 0x040126ED RID: 75501
		相机臂原点最小地面偏移Z,
		// Token: 0x040126EE RID: 75502
		Yaw软区Min,
		// Token: 0x040126EF RID: 75503
		Yaw软区Max,
		// Token: 0x040126F0 RID: 75504
		Yaw死区Min,
		// Token: 0x040126F1 RID: 75505
		Yaw死区Max,
		// Token: 0x040126F2 RID: 75506
		软区模式,
		// Token: 0x040126F3 RID: 75507
		Yaw区间最小速度,
		// Token: 0x040126F4 RID: 75508
		Yaw区间最大速度,
		// Token: 0x040126F5 RID: 75509
		Yaw死区到软区过渡速度倍率,
		// Token: 0x040126F6 RID: 75510
		Yaw回正速度倍率,
		// Token: 0x040126F7 RID: 75511
		弹簧臂中心点左右回正速度,
		// Token: 0x040126F8 RID: 75512
		弹簧臂中心点左右转向角度曲线参数范围,
		// Token: 0x040126F9 RID: 75513
		Yaw输入启用时间,
		// Token: 0x040126FA RID: 75514
		Yaw回正时间,
		// Token: 0x040126FB RID: 75515
		Pitch输入启动时间,
		// Token: 0x040126FC RID: 75516
		Pitch回正时间,
		// Token: 0x040126FD RID: 75517
		Pitch软区Min,
		// Token: 0x040126FE RID: 75518
		Pitch软区Max,
		// Token: 0x040126FF RID: 75519
		Pitch死区Min,
		// Token: 0x04012700 RID: 75520
		Pitch死区Max,
		// Token: 0x04012701 RID: 75521
		Pitch区域基准值,
		// Token: 0x04012702 RID: 75522
		Pitch区间最小速度,
		// Token: 0x04012703 RID: 75523
		Pitch区间最大速度,
		// Token: 0x04012704 RID: 75524
		相机臂Z随臂长变化自动偏移_最小臂长_,
		// Token: 0x04012705 RID: 75525
		相机臂Z随臂长变化自动偏移_最大臂长_,
		// Token: 0x04012706 RID: 75526
		相机臂Z随臂长变化自动偏移_最小Z偏移_,
		// Token: 0x04012707 RID: 75527
		相机臂Z随臂长变化自动偏移_最大Z偏移_,
		// Token: 0x04012708 RID: 75528
		角色叠加臂长,
		// Token: 0x04012709 RID: 75529
		角色叠加偏移Z,
		// Token: 0x0401270A RID: 75530
		战斗拍照角色开始虚化仰视角,
		// Token: 0x0401270B RID: 75531
		战斗拍照角色最大虚化仰视角,
		// Token: 0x0401270C RID: 75532
		战斗拍照角色开始虚化距离,
		// Token: 0x0401270D RID: 75533
		战斗拍照角色最大虚化距离,
		// Token: 0x0401270E RID: 75534
		战斗拍照角色虚化不透明度,
		// Token: 0x0401270F RID: 75535
		拍照界面npc开始虚化距离,
		// Token: 0x04012710 RID: 75536
		拍照界面npc最大虚化距离,
		// Token: 0x04012711 RID: 75537
		拍照界面npc虚化不透明度,
		// Token: 0x04012712 RID: 75538
		开启动态FOV,
		// Token: 0x04012713 RID: 75539
		动态FOV下界,
		// Token: 0x04012714 RID: 75540
		动态FOV上界,
		// Token: 0x04012715 RID: 75541
		动态FOV映射下界,
		// Token: 0x04012716 RID: 75542
		动态FOV映射上界,
		// Token: 0x04012717 RID: 75543
		动态FOV插值速度,
		// Token: 0x04012718 RID: 75544
		Yaw软区过渡速度倍率,
		// Token: 0x04012719 RID: 75545
		弹簧臂中心点上下输入启用时间,
		// Token: 0x0401271A RID: 75546
		弹簧臂中心点上下回正启用时间,
		// Token: 0x0401271B RID: 75547
		弹簧臂中心点左右输入启用时间,
		// Token: 0x0401271C RID: 75548
		弹簧臂中心点左右回正启用时间,
		// Token: 0x0401271D RID: 75549
		弹簧臂中心点前后输入启用时间,
		// Token: 0x0401271E RID: 75550
		弹簧臂中心点前后回正启用时间,
		// Token: 0x0401271F RID: 75551
		弹簧臂左右固定,
		// Token: 0x04012720 RID: 75552
		弹簧臂上下固定,
		// Token: 0x04012721 RID: 75553
		弹簧臂前后固定,
		// Token: 0x04012722 RID: 75554
		WorldRoll限制Min,
		// Token: 0x04012723 RID: 75555
		WorldRoll限制Max,
		// Token: 0x04012724 RID: 75556
		Yaw软区回正时间,
		// Token: 0x04012725 RID: 75557
		EFightCameraDefault_MAX
	}
}

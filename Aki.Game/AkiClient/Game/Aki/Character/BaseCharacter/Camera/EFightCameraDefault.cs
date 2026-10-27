using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043AC RID: 17324
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraDefault.EFightCameraDefault")]
	public enum EFightCameraDefault : byte
	{
		// Token: 0x04017B3A RID: 97082
		None,
		// Token: 0x04017B3B RID: 97083
		基础臂长,
		// Token: 0x04017B3C RID: 97084
		最小臂长,
		// Token: 0x04017B3D RID: 97085
		最大臂长,
		// Token: 0x04017B3E RID: 97086
		废弃1,
		// Token: 0x04017B3F RID: 97087
		Fov,
		// Token: 0x04017B40 RID: 97088
		相机臂偏移X,
		// Token: 0x04017B41 RID: 97089
		相机臂偏移Y,
		// Token: 0x04017B42 RID: 97090
		相机臂偏移Z,
		// Token: 0x04017B43 RID: 97091
		切换角色相机臂中心点过渡时间,
		// Token: 0x04017B44 RID: 97092
		在水中摄像机碰撞检测起点额外高度,
		// Token: 0x04017B45 RID: 97093
		障碍碰撞检测胶囊体半径,
		// Token: 0x04017B46 RID: 97094
		自动俯仰角输入水平偏移,
		// Token: 0x04017B47 RID: 97095
		自动俯仰角输入垂直偏移,
		// Token: 0x04017B48 RID: 97096
		自动俯仰角输入下界,
		// Token: 0x04017B49 RID: 97097
		自动俯仰角输入中界,
		// Token: 0x04017B4A RID: 97098
		自动俯仰角输入上界,
		// Token: 0x04017B4B RID: 97099
		自动俯仰角输出下界,
		// Token: 0x04017B4C RID: 97100
		自动俯仰角输出中界,
		// Token: 0x04017B4D RID: 97101
		自动俯仰角输出上界,
		// Token: 0x04017B4E RID: 97102
		弹簧臂中心点上下插值最小速度,
		// Token: 0x04017B4F RID: 97103
		弹簧臂中心点上下插值最大速度,
		// Token: 0x04017B50 RID: 97104
		弹簧臂中心点上下偏移距离下界,
		// Token: 0x04017B51 RID: 97105
		弹簧臂中心点上下偏移距离上界,
		// Token: 0x04017B52 RID: 97106
		最小上浮臂长,
		// Token: 0x04017B53 RID: 97107
		最大上浮臂长,
		// Token: 0x04017B54 RID: 97108
		弹簧臂中心点前后插值最小速度,
		// Token: 0x04017B55 RID: 97109
		弹簧臂中心点前后插值最大速度,
		// Token: 0x04017B56 RID: 97110
		弹簧臂中心点前后偏移距离下界,
		// Token: 0x04017B57 RID: 97111
		弹簧臂中心点前后偏移距离上界,
		// Token: 0x04017B58 RID: 97112
		复查障碍碰撞检测胶囊体半径,
		// Token: 0x04017B59 RID: 97113
		复查障碍碰撞检测间隔距离,
		// Token: 0x04017B5A RID: 97114
		退出障碍碰撞检测胶囊体半径,
		// Token: 0x04017B5B RID: 97115
		Yaw限制Min,
		// Token: 0x04017B5C RID: 97116
		Yaw限制Max,
		// Token: 0x04017B5D RID: 97117
		MaxDistance,
		// Token: 0x04017B5E RID: 97118
		InSpeed,
		// Token: 0x04017B5F RID: 97119
		OutSpeed,
		// Token: 0x04017B60 RID: 97120
		CollisionSizePercentage,
		// Token: 0x04017B61 RID: 97121
		CenterCollisionSize,
		// Token: 0x04017B62 RID: 97122
		角色开始虚化距离,
		// Token: 0x04017B63 RID: 97123
		角色最大虚化距离,
		// Token: 0x04017B64 RID: 97124
		角色开始虚化仰视角,
		// Token: 0x04017B65 RID: 97125
		角色最大虚化仰视角,
		// Token: 0x04017B66 RID: 97126
		角色虚化不透明度,
		// Token: 0x04017B67 RID: 97127
		Pitch限制Min,
		// Token: 0x04017B68 RID: 97128
		Pitch限制Max,
		// Token: 0x04017B69 RID: 97129
		弹簧臂中心点左右插值最小速度,
		// Token: 0x04017B6A RID: 97130
		弹簧臂中心点左右插值最大速度,
		// Token: 0x04017B6B RID: 97131
		弹簧臂中心点左右偏移距离下界,
		// Token: 0x04017B6C RID: 97132
		弹簧臂中心点左右偏移距离上界,
		// Token: 0x04017B6D RID: 97133
		瞄准射击俯视Z轴偏移,
		// Token: 0x04017B6E RID: 97134
		瞄准射击仰视Z轴偏移,
		// Token: 0x04017B6F RID: 97135
		游标目标旋转Alpha速率下界,
		// Token: 0x04017B70 RID: 97136
		游标目标旋转Alpha速率上界,
		// Token: 0x04017B71 RID: 97137
		游标目标旋转Alpha速率,
		// Token: 0x04017B72 RID: 97138
		禁用重置视角,
		// Token: 0x04017B73 RID: 97139
		额外Pitch最小叠加值,
		// Token: 0x04017B74 RID: 97140
		额外Pitch最大叠加值,
		// Token: 0x04017B75 RID: 97141
		额外Pitch叠加高度,
		// Token: 0x04017B76 RID: 97142
		WorldYaw限制Min,
		// Token: 0x04017B77 RID: 97143
		WorldYaw限制Max,
		// Token: 0x04017B78 RID: 97144
		相机臂原点偏移X,
		// Token: 0x04017B79 RID: 97145
		相机臂原点偏移Y,
		// Token: 0x04017B7A RID: 97146
		相机臂原点偏移Z,
		// Token: 0x04017B7B RID: 97147
		相机臂原点最小地面偏移Z,
		// Token: 0x04017B7C RID: 97148
		Yaw软区Min,
		// Token: 0x04017B7D RID: 97149
		Yaw软区Max,
		// Token: 0x04017B7E RID: 97150
		Yaw死区Min,
		// Token: 0x04017B7F RID: 97151
		Yaw死区Max,
		// Token: 0x04017B80 RID: 97152
		软区模式,
		// Token: 0x04017B81 RID: 97153
		Yaw区间最小速度,
		// Token: 0x04017B82 RID: 97154
		Yaw区间最大速度,
		// Token: 0x04017B83 RID: 97155
		Yaw死区到软区过渡速度倍率,
		// Token: 0x04017B84 RID: 97156
		Yaw回正速度倍率,
		// Token: 0x04017B85 RID: 97157
		弹簧臂中心点左右回正速度,
		// Token: 0x04017B86 RID: 97158
		弹簧臂中心点左右转向角度曲线参数范围,
		// Token: 0x04017B87 RID: 97159
		Yaw输入启用时间,
		// Token: 0x04017B88 RID: 97160
		Yaw回正时间,
		// Token: 0x04017B89 RID: 97161
		Pitch输入启动时间,
		// Token: 0x04017B8A RID: 97162
		Pitch回正时间,
		// Token: 0x04017B8B RID: 97163
		Pitch软区Min,
		// Token: 0x04017B8C RID: 97164
		Pitch软区Max,
		// Token: 0x04017B8D RID: 97165
		Pitch死区Min,
		// Token: 0x04017B8E RID: 97166
		Pitch死区Max,
		// Token: 0x04017B8F RID: 97167
		Pitch区域基准值,
		// Token: 0x04017B90 RID: 97168
		Pitch区间最小速度,
		// Token: 0x04017B91 RID: 97169
		Pitch区间最大速度,
		// Token: 0x04017B92 RID: 97170
		相机臂Z随臂长变化自动偏移_最小臂长_,
		// Token: 0x04017B93 RID: 97171
		相机臂Z随臂长变化自动偏移_最大臂长_,
		// Token: 0x04017B94 RID: 97172
		相机臂Z随臂长变化自动偏移_最小Z偏移_,
		// Token: 0x04017B95 RID: 97173
		相机臂Z随臂长变化自动偏移_最大Z偏移_,
		// Token: 0x04017B96 RID: 97174
		角色叠加臂长,
		// Token: 0x04017B97 RID: 97175
		角色叠加偏移Z,
		// Token: 0x04017B98 RID: 97176
		战斗拍照角色开始虚化仰视角,
		// Token: 0x04017B99 RID: 97177
		战斗拍照角色最大虚化仰视角,
		// Token: 0x04017B9A RID: 97178
		战斗拍照角色开始虚化距离,
		// Token: 0x04017B9B RID: 97179
		战斗拍照角色最大虚化距离,
		// Token: 0x04017B9C RID: 97180
		战斗拍照角色虚化不透明度,
		// Token: 0x04017B9D RID: 97181
		拍照界面npc开始虚化距离,
		// Token: 0x04017B9E RID: 97182
		拍照界面npc最大虚化距离,
		// Token: 0x04017B9F RID: 97183
		拍照界面npc虚化不透明度,
		// Token: 0x04017BA0 RID: 97184
		开启动态FOV,
		// Token: 0x04017BA1 RID: 97185
		动态FOV下界,
		// Token: 0x04017BA2 RID: 97186
		动态FOV上界,
		// Token: 0x04017BA3 RID: 97187
		动态FOV映射下界,
		// Token: 0x04017BA4 RID: 97188
		动态FOV映射上界,
		// Token: 0x04017BA5 RID: 97189
		动态FOV插值速度,
		// Token: 0x04017BA6 RID: 97190
		Yaw软区过渡速度倍率,
		// Token: 0x04017BA7 RID: 97191
		弹簧臂中心点上下输入启用时间,
		// Token: 0x04017BA8 RID: 97192
		弹簧臂中心点上下回正启用时间,
		// Token: 0x04017BA9 RID: 97193
		弹簧臂中心点左右输入启用时间,
		// Token: 0x04017BAA RID: 97194
		弹簧臂中心点左右回正启用时间,
		// Token: 0x04017BAB RID: 97195
		弹簧臂中心点前后输入启用时间,
		// Token: 0x04017BAC RID: 97196
		弹簧臂中心点前后回正启用时间,
		// Token: 0x04017BAD RID: 97197
		弹簧臂左右固定,
		// Token: 0x04017BAE RID: 97198
		弹簧臂上下固定,
		// Token: 0x04017BAF RID: 97199
		弹簧臂前后固定,
		// Token: 0x04017BB0 RID: 97200
		WorldRoll限制Min,
		// Token: 0x04017BB1 RID: 97201
		WorldRoll限制Max,
		// Token: 0x04017BB2 RID: 97202
		EFightCameraDefault_MAX
	}
}

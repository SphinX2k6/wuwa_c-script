using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035C3 RID: 13763
	[NullableContext(1)]
	[Nullable(0)]
	public class actionMappings
	{
		// Token: 0x060230FE RID: 143614 RVA: 0x009F87B5 File Offset: 0x009F69B5
		public static bool HasField(string actionName)
		{
			return actionMappings.ActionMappingValues.Contains(actionName);
		}

		// Token: 0x04013BED RID: 80877
		public const string 跳跃 = "跳跃";

		// Token: 0x04013BEE RID: 80878
		public const string 攀爬 = "攀爬";

		// Token: 0x04013BEF RID: 80879
		public const string 走跑切换 = "走跑切换";

		// Token: 0x04013BF0 RID: 80880
		public const string 攻击 = "攻击";

		// Token: 0x04013BF1 RID: 80881
		public const string 手柄主攻击 = "手柄主攻击";

		// Token: 0x04013BF2 RID: 80882
		public const string 手柄副攻击 = "手柄副攻击";

		// Token: 0x04013BF3 RID: 80883
		public const string 闪避 = "闪避";

		// Token: 0x04013BF4 RID: 80884
		public const string 技能1 = "技能1";

		// Token: 0x04013BF5 RID: 80885
		public const string 幻象1 = "幻象1";

		// Token: 0x04013BF6 RID: 80886
		public const string 大招 = "大招";

		// Token: 0x04013BF7 RID: 80887
		public const string 幻象2 = "幻象2";

		// Token: 0x04013BF8 RID: 80888
		public const string 切换角色1 = "切换角色1";

		// Token: 0x04013BF9 RID: 80889
		public const string 切换角色2 = "切换角色2";

		// Token: 0x04013BFA RID: 80890
		public const string 切换角色3 = "切换角色3";

		// Token: 0x04013BFB RID: 80891
		public const string 切换角色4 = "切换角色4";

		// Token: 0x04013BFC RID: 80892
		public const string 组合主键 = "组合主键";

		// Token: 0x04013BFD RID: 80893
		public const string 向前移动 = "向前移动";

		// Token: 0x04013BFE RID: 80894
		public const string 向后移动 = "向后移动";

		// Token: 0x04013BFF RID: 80895
		public const string 向左移动 = "向左移动";

		// Token: 0x04013C00 RID: 80896
		public const string 向右移动 = "向右移动";

		// Token: 0x04013C01 RID: 80897
		public const string 下降 = "下降";

		// Token: 0x04013C02 RID: 80898
		public const string 邮件 = "邮件";

		// Token: 0x04013C03 RID: 80899
		public const string 地图 = "地图";

		// Token: 0x04013C04 RID: 80900
		public const string 商店 = "商店";

		// Token: 0x04013C05 RID: 80901
		public const string 任务 = "任务";

		// Token: 0x04013C06 RID: 80902
		public const string 功能菜单 = "功能菜单";

		// Token: 0x04013C07 RID: 80903
		public const string 编队 = "编队";

		// Token: 0x04013C08 RID: 80904
		public const string 背包 = "背包";

		// Token: 0x04013C09 RID: 80905
		public const string 教程 = "教程";

		// Token: 0x04013C0A RID: 80906
		public const string 展开教程百科详情 = "展开教程百科详情";

		// Token: 0x04013C0B RID: 80907
		public const string 联机 = "联机";

		// Token: 0x04013C0C RID: 80908
		public const string Gm指令 = "GM指令";

		// Token: 0x04013C0D RID: 80909
		public const string 角色选择界面 = "角色选择界面";

		// Token: 0x04013C0E RID: 80910
		public const string 幻象列表界面 = "幻象列表界面";

		// Token: 0x04013C0F RID: 80911
		public const string 聊天 = "聊天";

		// Token: 0x04013C10 RID: 80912
		public const string 环境特性 = "环境特性";

		// Token: 0x04013C11 RID: 80913
		public const string 显示鼠标 = "显示鼠标";

		// Token: 0x04013C12 RID: 80914
		public const string 幻象探索选择界面 = "幻象探索选择界面";

		// Token: 0x04013C13 RID: 80915
		public const string 轮盘2 = "轮盘2";

		// Token: 0x04013C14 RID: 80916
		public const string Ui左键点击 = "UI左键点击";

		// Token: 0x04013C15 RID: 80917
		public const string Ui右键点击 = "UI右键点击";

		// Token: 0x04013C16 RID: 80918
		public const string 锁定目标 = "锁定目标";

		// Token: 0x04013C17 RID: 80919
		public const string 瞄准 = "瞄准";

		// Token: 0x04013C18 RID: 80920
		public const string 通用交互 = "通用交互";

		// Token: 0x04013C19 RID: 80921
		public const string QTE交互 = "QTE交互";

		// Token: 0x04013C1A RID: 80922
		public const string 任务追踪 = "任务追踪";

		// Token: 0x04013C1B RID: 80923
		public const string 切换交互 = "切换交互";

		// Token: 0x04013C1C RID: 80924
		public const string DebugTap = "DebugTap";

		// Token: 0x04013C1D RID: 80925
		public const string 拍照 = "拍照";

		// Token: 0x04013C1E RID: 80926
		public const string 玩法放弃 = "玩法放弃";

		// Token: 0x04013C1F RID: 80927
		public const string ZoomIn = "ZoomIn";

		// Token: 0x04013C20 RID: 80928
		public const string ZoomOut = "ZoomOut";

		// Token: 0x04013C21 RID: 80929
		public const string 轮盘切换 = "轮盘切换";

		// Token: 0x04013C22 RID: 80930
		public const string 小活动 = "小活动";

		// Token: 0x04013C23 RID: 80931
		public const string 调谐 = "调谐";

		// Token: 0x04013C24 RID: 80932
		public const string 变星 = "变星";

		// Token: 0x04013C25 RID: 80933
		public const string 拾音辑录 = "拾音辑录";

		// Token: 0x04013C26 RID: 80934
		public const string 放弃改键 = "放弃改键";

		// Token: 0x04013C27 RID: 80935
		public const string 重新挑战 = "重新挑战";

		// Token: 0x04013C28 RID: 80936
		public const string UI鼠标中键手柄特右 = "UI鼠标中键手柄特右";

		// Token: 0x04013C29 RID: 80937
		public const string 退出精简模式 = "退出精简模式";

		// Token: 0x04013C2A RID: 80938
		public const string 退出精简模式PC触摸板 = "退出精简模式PC触摸板";

		// Token: 0x04013C2B RID: 80939
		public const string 割草BUFF信息 = "割草BUFF信息";

		// Token: 0x04013C2C RID: 80940
		public const string 割草BUFF信息PC触摸板 = "割草BUFF信息PC触摸板";

		// Token: 0x04013C2D RID: 80941
		public const string Photo臂长隐藏 = "Photo臂长隐藏";

		// Token: 0x04013C2E RID: 80942
		public const string Photo手动对焦切换 = "Photo手动对焦切换";

		// Token: 0x04013C2F RID: 80943
		public const string Photo快门 = "Photo快门";

		// Token: 0x04013C30 RID: 80944
		public const string Photo模式切换 = "Photo模式切换";

		// Token: 0x04013C31 RID: 80945
		public const string Photo退出 = "Photo退出";

		// Token: 0x04013C32 RID: 80946
		public const string 滚动条切换 = "滚动条切换";

		// Token: 0x04013C33 RID: 80947
		public const string Ui返回 = "UI返回";

		// Token: 0x04013C34 RID: 80948
		public const string Ui方向上 = "UI方向上";

		// Token: 0x04013C35 RID: 80949
		public const string Ui方向下 = "UI方向下";

		// Token: 0x04013C36 RID: 80950
		public const string Ui方向左 = "UI方向左";

		// Token: 0x04013C37 RID: 80951
		public const string Ui方向右 = "UI方向右";

		// Token: 0x04013C38 RID: 80952
		public const string UI键盘F手柄A = "UI键盘F手柄A";

		// Token: 0x04013C39 RID: 80953
		public const string UI键盘R手柄X = "UI键盘R手柄X";

		// Token: 0x04013C3A RID: 80954
		public const string UI键盘T手柄Y = "UI键盘T手柄Y";

		// Token: 0x04013C3B RID: 80955
		public const string UI键盘Q手柄LB = "UI键盘Q手柄LB";

		// Token: 0x04013C3C RID: 80956
		public const string UI键盘E手柄RB = "UI键盘E手柄RB";

		// Token: 0x04013C3D RID: 80957
		public const string UI键盘Z手柄LT = "UI键盘Z手柄LT";

		// Token: 0x04013C3E RID: 80958
		public const string UI键盘C手柄RT = "UI键盘C手柄RT";

		// Token: 0x04013C3F RID: 80959
		public const string UI手柄右摇杆上 = "UI手柄右摇杆上";

		// Token: 0x04013C40 RID: 80960
		public const string UI手柄右摇杆下 = "UI手柄右摇杆下";

		// Token: 0x04013C41 RID: 80961
		public const string UI键盘G手柄特右 = "UI键盘G手柄特右";

		// Token: 0x04013C42 RID: 80962
		public const string UI键盘X手柄特左 = "UI键盘X手柄特左";

		// Token: 0x04013C43 RID: 80963
		public const string UI键盘U手柄左摇杆 = "UI键盘U手柄左摇杆";

		// Token: 0x04013C44 RID: 80964
		public const string UI键盘G手柄右摇杆 = "UI键盘G手柄右摇杆";

		// Token: 0x04013C45 RID: 80965
		public const string UI键盘Y手柄特右 = "UI键盘Y手柄特右";

		// Token: 0x04013C46 RID: 80966
		public const string UI键盘H手柄特左 = "UI键盘H手柄特左";

		// Token: 0x04013C47 RID: 80967
		public const string UI键盘ESC手柄B = "UI键盘ESC手柄B";

		// Token: 0x04013C48 RID: 80968
		public const string UI键盘N = "UI键盘N";

		// Token: 0x04013C49 RID: 80969
		public const string UI键鼠F空格 = "UI键鼠F空格";

		// Token: 0x04013C4A RID: 80970
		public const string UI手柄A方向右 = "UI手柄A方向右";

		// Token: 0x04013C4B RID: 80971
		public const string UI手柄B方向左 = "UI手柄B方向左";

		// Token: 0x04013C4C RID: 80972
		public const string 手柄引导下一步 = "手柄引导下一步";

		// Token: 0x04013C4D RID: 80973
		public const string UI左摇杆上 = "UI左摇杆上";

		// Token: 0x04013C4E RID: 80974
		public const string UI左摇杆下 = "UI左摇杆下";

		// Token: 0x04013C4F RID: 80975
		public const string UI左摇杆左 = "UI左摇杆左";

		// Token: 0x04013C50 RID: 80976
		public const string UI左摇杆右 = "UI左摇杆右";

		// Token: 0x04013C51 RID: 80977
		public const string UI鼠标侧键前 = "UI鼠标侧键前";

		// Token: 0x04013C52 RID: 80978
		public const string UI鼠标侧键后 = "UI鼠标侧键后";

		// Token: 0x04013C53 RID: 80979
		public const string UI键盘V手柄特左 = "UI键盘V手柄特左";

		// Token: 0x04013C54 RID: 80980
		public const string UI键盘子弹跳 = "UI键盘子弹跳";

		// Token: 0x04013C55 RID: 80981
		public const string UI键盘交互 = "UI键盘交互";

		// Token: 0x04013C56 RID: 80982
		public const string UI手柄退场技 = "UI手柄退场技";

		// Token: 0x04013C57 RID: 80983
		public const string UI手柄漂移 = "UI手柄漂移";

		// Token: 0x04013C58 RID: 80984
		public const string 激活聊天 = "激活聊天";

		// Token: 0x04013C59 RID: 80985
		public const string QTE数字1 = "QTE数字1";

		// Token: 0x04013C5A RID: 80986
		public const string QTE数字2 = "QTE数字2";

		// Token: 0x04013C5B RID: 80987
		public const string QTE数字3 = "QTE数字3";

		// Token: 0x04013C5C RID: 80988
		public const string QTE数字4 = "QTE数字4";

		// Token: 0x04013C5D RID: 80989
		public const string UI键盘数字1手柄上 = "UI键盘数字1手柄上";

		// Token: 0x04013C5E RID: 80990
		public const string UI键盘数字2手柄左 = "UI键盘数字2手柄左";

		// Token: 0x04013C5F RID: 80991
		public const string UI键盘数字3手柄右 = "UI键盘数字3手柄右";

		// Token: 0x04013C60 RID: 80992
		public const string UI键盘数字4手柄下 = "UI键盘数字4手柄下";

		// Token: 0x04013C61 RID: 80993
		public const string UI键盘回车 = "UI键盘回车";

		// Token: 0x04013C62 RID: 80994
		public const string Link大招 = "Link大招";

		// Token: 0x04013C63 RID: 80995
		public const string 团子养成 = "团子养成";

		// Token: 0x04013C64 RID: 80996
		public const string 团子商店 = "团子商店";

		// Token: 0x04013C65 RID: 80997
		public const string 退出团子副本 = "退出团子副本";

		// Token: 0x04013C66 RID: 80998
		public const string UI键盘空格 = "UI键盘空格";

		// Token: 0x04013C67 RID: 80999
		public const string 浴场同伴 = "浴场同伴";

		// Token: 0x04013C68 RID: 81000
		public const string 浴场切换视角 = "浴场切换视角";

		// Token: 0x04013C69 RID: 81001
		public const string 浴场快照 = "浴场快照";

		// Token: 0x04013C6A RID: 81002
		public const string 组合菜单键 = "组合菜单键";

		// Token: 0x04013C6B RID: 81003
		public const string 塔防射击 = "塔防射击";

		// Token: 0x04013C6C RID: 81004
		public const string 塔防旋转 = "塔防旋转";

		// Token: 0x04013C6D RID: 81005
		public const string 塔防回收机关 = "塔防回收机关";

		// Token: 0x04013C6E RID: 81006
		public const string 塔防整备 = "塔防整备";

		// Token: 0x04013C6F RID: 81007
		public const string 塔防开始 = "塔防开始";

		// Token: 0x04013C70 RID: 81008
		public const string 塔防选择1 = "塔防选择1";

		// Token: 0x04013C71 RID: 81009
		public const string 塔防选择2 = "塔防选择2";

		// Token: 0x04013C72 RID: 81010
		public const string 塔防选择3 = "塔防选择3";

		// Token: 0x04013C73 RID: 81011
		public const string 塔防选择4 = "塔防选择4";

		// Token: 0x04013C74 RID: 81012
		public const string 塔防选择5 = "塔防选择5";

		// Token: 0x04013C75 RID: 81013
		public const string 塔防选择6 = "塔防选择6";

		// Token: 0x04013C76 RID: 81014
		public const string 塔防选择7 = "塔防选择7";

		// Token: 0x04013C77 RID: 81015
		public const string 塔防选择8 = "塔防选择8";

		// Token: 0x04013C78 RID: 81016
		public const string 塔防跳跃 = "塔防跳跃";

		// Token: 0x04013C79 RID: 81017
		public const string 塔防冲刺 = "塔防冲刺";

		// Token: 0x04013C7A RID: 81018
		public const string 塔防选择上一个 = "塔防选择上一个";

		// Token: 0x04013C7B RID: 81019
		public const string 塔防选择下一个 = "塔防选择下一个";

		// Token: 0x04013C7C RID: 81020
		public const string 塔防组合主键 = "塔防组合主键";

		// Token: 0x04013C7D RID: 81021
		public const string 塔防商店 = "塔防商店";

		// Token: 0x04013C7E RID: 81022
		public const string 塔防轮盘 = "塔防轮盘";

		// Token: 0x04013C7F RID: 81023
		public const string 塔防道具 = "塔防道具";

		// Token: 0x04013C80 RID: 81024
		public const string 塔防地图 = "塔防地图";

		// Token: 0x04013C81 RID: 81025
		public const string 塔防走跑切换 = "塔防走跑切换";

		// Token: 0x04013C82 RID: 81026
		public const string 交互动态漫_向上拖动 = "交互动态漫-向上拖动";

		// Token: 0x04013C83 RID: 81027
		public const string 交互动态漫_向下拖动 = "交互动态漫-向下拖动";

		// Token: 0x04013C84 RID: 81028
		public const string 交互动态漫_转动 = "交互动态漫-转动";

		// Token: 0x04013C85 RID: 81029
		public const string 交互动态漫_点击 = "交互动态漫-点击";

		// Token: 0x04013C86 RID: 81030
		public const string 交互动态漫_长按 = "交互动态漫-长按";

		// Token: 0x04013C87 RID: 81031
		public const string QTE选项1 = "QTE选项1";

		// Token: 0x04013C88 RID: 81032
		public const string QTE选项2 = "QTE选项2";

		// Token: 0x04013C89 RID: 81033
		public const string QTE选项3 = "QTE选项3";

		// Token: 0x04013C8A RID: 81034
		public const string QTE选项4 = "QTE选项4";

		// Token: 0x04013C8B RID: 81035
		public const string QTE方向上 = "qte方向上";

		// Token: 0x04013C8C RID: 81036
		public const string QTE方向下 = "qte方向下";

		// Token: 0x04013C8D RID: 81037
		public const string QTE方向左 = "qte方向左";

		// Token: 0x04013C8E RID: 81038
		public const string QTE方向右 = "qte方向右";

		// Token: 0x04013C8F RID: 81039
		public const string QTE分体选项1_左 = "QTE分体选项1-左";

		// Token: 0x04013C90 RID: 81040
		public const string QTE分体选项2_右 = "QTE分体选项2-右";

		// Token: 0x04013C91 RID: 81041
		public const string QTE_R2攻击 = "QTE-R2攻击";

		// Token: 0x04013C92 RID: 81042
		public const string QTE_空格A = "QTE-空格和A键";

		// Token: 0x04013C93 RID: 81043
		public const string D级限时选项_1 = "D级限时选项-1";

		// Token: 0x04013C94 RID: 81044
		public const string D级限时选项_2 = "D级限时选项-2";

		// Token: 0x04013C95 RID: 81045
		public const string 载具漂移 = "载具漂移";

		// Token: 0x04013C96 RID: 81046
		public const string 载具子弹跳 = "载具子弹跳";

		// Token: 0x04013C97 RID: 81047
		public const string 载具子弹跳1 = "载具子弹跳1";

		// Token: 0x04013C98 RID: 81048
		public const string 载具退场技和下车 = "载具退场技和下车";

		// Token: 0x04013C99 RID: 81049
		public const string 载具探索工具 = "载具探索工具";

		// Token: 0x04013C9A RID: 81050
		public const string 载具氮气 = "载具氮气";

		// Token: 0x04013C9B RID: 81051
		public const string 载具视角切换 = "载具视角切换";

		// Token: 0x04013C9C RID: 81052
		public const string 载具空中抬升 = "载具空中抬升";

		// Token: 0x04013C9D RID: 81053
		public const string 载具音乐上一首 = "载具音乐上一首";

		// Token: 0x04013C9E RID: 81054
		public const string 载具音乐下一首 = "载具音乐下一首";

		// Token: 0x04013C9F RID: 81055
		public const string 载具音乐播放暂停 = "载具音乐播放暂停";

		// Token: 0x04013CA0 RID: 81056
		public const string 载具锁定目标 = "载具锁定目标";

		// Token: 0x04013CA1 RID: 81057
		public const string 载具辅助机攻击 = "载具辅助机攻击";

		// Token: 0x04013CA2 RID: 81058
		public const string 飞讯 = "飞讯";

		// Token: 0x04013CA3 RID: 81059
		public const string 弹珠挡板 = "弹珠挡板";

		// Token: 0x04013CA4 RID: 81060
		public const string 弹珠冲刺 = "弹珠冲刺";

		// Token: 0x04013CA5 RID: 81061
		public const string 全量点击继续 = "全量点击继续";

		// Token: 0x04013CA6 RID: 81062
		public const string 钢琴琴键J = "钢琴琴键J";

		// Token: 0x04013CA7 RID: 81063
		public const string 钢琴琴键K = "钢琴琴键K";

		// Token: 0x04013CA8 RID: 81064
		public const string 钢琴琴键L = "钢琴琴键L";

		// Token: 0x04013CA9 RID: 81065
		private static readonly IReadOnlySet<string> ActionMappingValues = new HashSet<string>
		{
			"跳跃",
			"攀爬",
			"走跑切换",
			"攻击",
			"手柄主攻击",
			"手柄副攻击",
			"闪避",
			"技能1",
			"幻象1",
			"大招",
			"幻象2",
			"切换角色1",
			"切换角色2",
			"切换角色3",
			"切换角色4",
			"组合主键",
			"向前移动",
			"向后移动",
			"向左移动",
			"向右移动",
			"下降",
			"邮件",
			"地图",
			"商店",
			"任务",
			"功能菜单",
			"编队",
			"背包",
			"教程",
			"展开教程百科详情",
			"联机",
			"GM指令",
			"角色选择界面",
			"幻象列表界面",
			"聊天",
			"环境特性",
			"显示鼠标",
			"幻象探索选择界面",
			"轮盘2",
			"UI左键点击",
			"UI右键点击",
			"锁定目标",
			"瞄准",
			"通用交互",
			"QTE交互",
			"任务追踪",
			"切换交互",
			"DebugTap",
			"拍照",
			"玩法放弃",
			"ZoomIn",
			"ZoomOut",
			"轮盘切换",
			"小活动",
			"调谐",
			"变星",
			"拾音辑录",
			"放弃改键",
			"重新挑战",
			"UI鼠标中键手柄特右",
			"退出精简模式",
			"退出精简模式PC触摸板",
			"割草BUFF信息",
			"割草BUFF信息PC触摸板",
			"Photo臂长隐藏",
			"Photo手动对焦切换",
			"Photo快门",
			"Photo模式切换",
			"Photo退出",
			"滚动条切换",
			"UI返回",
			"UI方向上",
			"UI方向下",
			"UI方向左",
			"UI方向右",
			"UI键盘F手柄A",
			"UI键盘R手柄X",
			"UI键盘T手柄Y",
			"UI键盘Q手柄LB",
			"UI键盘E手柄RB",
			"UI键盘Z手柄LT",
			"UI键盘C手柄RT",
			"UI手柄右摇杆上",
			"UI手柄右摇杆下",
			"UI键盘G手柄特右",
			"UI键盘X手柄特左",
			"UI键盘U手柄左摇杆",
			"UI键盘G手柄右摇杆",
			"UI键盘Y手柄特右",
			"UI键盘H手柄特左",
			"UI键盘ESC手柄B",
			"UI键盘N",
			"UI键鼠F空格",
			"UI手柄A方向右",
			"UI手柄B方向左",
			"手柄引导下一步",
			"UI左摇杆上",
			"UI左摇杆下",
			"UI左摇杆左",
			"UI左摇杆右",
			"UI鼠标侧键前",
			"UI鼠标侧键后",
			"UI键盘V手柄特左",
			"UI键盘子弹跳",
			"UI键盘交互",
			"UI手柄退场技",
			"UI手柄漂移",
			"激活聊天",
			"QTE数字1",
			"QTE数字2",
			"QTE数字3",
			"QTE数字4",
			"UI键盘数字1手柄上",
			"UI键盘数字2手柄左",
			"UI键盘数字3手柄右",
			"UI键盘数字4手柄下",
			"UI键盘回车",
			"Link大招",
			"团子养成",
			"团子商店",
			"退出团子副本",
			"UI键盘空格",
			"浴场同伴",
			"浴场切换视角",
			"浴场快照",
			"组合菜单键",
			"塔防射击",
			"塔防旋转",
			"塔防回收机关",
			"塔防整备",
			"塔防开始",
			"塔防选择1",
			"塔防选择2",
			"塔防选择3",
			"塔防选择4",
			"塔防选择5",
			"塔防选择6",
			"塔防选择7",
			"塔防选择8",
			"塔防跳跃",
			"塔防冲刺",
			"塔防选择上一个",
			"塔防选择下一个",
			"塔防组合主键",
			"塔防商店",
			"塔防轮盘",
			"塔防道具",
			"塔防地图",
			"塔防走跑切换",
			"交互动态漫-向上拖动",
			"交互动态漫-向下拖动",
			"交互动态漫-转动",
			"交互动态漫-点击",
			"交互动态漫-长按",
			"QTE选项1",
			"QTE选项2",
			"QTE选项3",
			"QTE选项4",
			"qte方向上",
			"qte方向下",
			"qte方向左",
			"qte方向右",
			"QTE分体选项1-左",
			"QTE分体选项2-右",
			"QTE-R2攻击",
			"QTE-空格和A键",
			"D级限时选项-1",
			"D级限时选项-2",
			"载具漂移",
			"载具子弹跳",
			"载具子弹跳1",
			"载具退场技和下车",
			"载具探索工具",
			"载具氮气",
			"载具视角切换",
			"载具空中抬升",
			"载具音乐上一首",
			"载具音乐下一首",
			"载具音乐播放暂停",
			"载具锁定目标",
			"载具辅助机攻击",
			"飞讯",
			"弹珠挡板",
			"弹珠冲刺",
			"全量点击继续",
			"钢琴琴键J",
			"钢琴琴键K",
			"钢琴琴键L"
		};
	}
}

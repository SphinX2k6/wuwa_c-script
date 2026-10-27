using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004692 RID: 18066
	[NullableContext(1)]
	[Nullable(0)]
	public class actionMappings
	{
		// Token: 0x0602E9B4 RID: 190900 RVA: 0x00ACAA81 File Offset: 0x00AC8C81
		public static bool HasField(string fieldName)
		{
			return typeof(actionMappings).GetField(fieldName) != null;
		}

		// Token: 0x04019546 RID: 103750
		public const string 跳跃 = "跳跃";

		// Token: 0x04019547 RID: 103751
		public const string 攀爬 = "攀爬";

		// Token: 0x04019548 RID: 103752
		public const string 走跑切换 = "走跑切换";

		// Token: 0x04019549 RID: 103753
		public const string 攻击 = "攻击";

		// Token: 0x0401954A RID: 103754
		public const string 手柄主攻击 = "手柄主攻击";

		// Token: 0x0401954B RID: 103755
		public const string 手柄副攻击 = "手柄副攻击";

		// Token: 0x0401954C RID: 103756
		public const string 闪避 = "闪避";

		// Token: 0x0401954D RID: 103757
		public const string 技能1 = "技能1";

		// Token: 0x0401954E RID: 103758
		public const string 幻象1 = "幻象1";

		// Token: 0x0401954F RID: 103759
		public const string 大招 = "大招";

		// Token: 0x04019550 RID: 103760
		public const string 幻象2 = "幻象2";

		// Token: 0x04019551 RID: 103761
		public const string 切换角色1 = "切换角色1";

		// Token: 0x04019552 RID: 103762
		public const string 切换角色2 = "切换角色2";

		// Token: 0x04019553 RID: 103763
		public const string 切换角色3 = "切换角色3";

		// Token: 0x04019554 RID: 103764
		public const string 切换角色4 = "切换角色4";

		// Token: 0x04019555 RID: 103765
		public const string 组合主键 = "组合主键";

		// Token: 0x04019556 RID: 103766
		public const string 向前移动 = "向前移动";

		// Token: 0x04019557 RID: 103767
		public const string 向后移动 = "向后移动";

		// Token: 0x04019558 RID: 103768
		public const string 向左移动 = "向左移动";

		// Token: 0x04019559 RID: 103769
		public const string 向右移动 = "向右移动";

		// Token: 0x0401955A RID: 103770
		public const string 下降 = "下降";

		// Token: 0x0401955B RID: 103771
		public const string 邮件 = "邮件";

		// Token: 0x0401955C RID: 103772
		public const string 地图 = "地图";

		// Token: 0x0401955D RID: 103773
		public const string 商店 = "商店";

		// Token: 0x0401955E RID: 103774
		public const string 任务 = "任务";

		// Token: 0x0401955F RID: 103775
		public const string 功能菜单 = "功能菜单";

		// Token: 0x04019560 RID: 103776
		public const string 编队 = "编队";

		// Token: 0x04019561 RID: 103777
		public const string 背包 = "背包";

		// Token: 0x04019562 RID: 103778
		public const string 教程 = "教程";

		// Token: 0x04019563 RID: 103779
		public const string 展开教程百科详情 = "展开教程百科详情";

		// Token: 0x04019564 RID: 103780
		public const string 联机 = "联机";

		// Token: 0x04019565 RID: 103781
		public const string Gm指令 = "GM指令";

		// Token: 0x04019566 RID: 103782
		public const string 角色选择界面 = "角色选择界面";

		// Token: 0x04019567 RID: 103783
		public const string 幻象列表界面 = "幻象列表界面";

		// Token: 0x04019568 RID: 103784
		public const string 聊天 = "聊天";

		// Token: 0x04019569 RID: 103785
		public const string 环境特性 = "环境特性";

		// Token: 0x0401956A RID: 103786
		public const string 显示鼠标 = "显示鼠标";

		// Token: 0x0401956B RID: 103787
		public const string 幻象探索选择界面 = "幻象探索选择界面";

		// Token: 0x0401956C RID: 103788
		public const string 轮盘2 = "轮盘2";

		// Token: 0x0401956D RID: 103789
		public const string Ui左键点击 = "UI左键点击";

		// Token: 0x0401956E RID: 103790
		public const string Ui右键点击 = "UI右键点击";

		// Token: 0x0401956F RID: 103791
		public const string 锁定目标 = "锁定目标";

		// Token: 0x04019570 RID: 103792
		public const string 瞄准 = "瞄准";

		// Token: 0x04019571 RID: 103793
		public const string 通用交互 = "通用交互";

		// Token: 0x04019572 RID: 103794
		public const string QTE交互 = "QTE交互";

		// Token: 0x04019573 RID: 103795
		public const string 任务追踪 = "任务追踪";

		// Token: 0x04019574 RID: 103796
		public const string 切换交互 = "切换交互";

		// Token: 0x04019575 RID: 103797
		public const string DebugTap = "DebugTap";

		// Token: 0x04019576 RID: 103798
		public const string 拍照 = "拍照";

		// Token: 0x04019577 RID: 103799
		public const string 玩法放弃 = "玩法放弃";

		// Token: 0x04019578 RID: 103800
		public const string ZoomIn = "ZoomIn";

		// Token: 0x04019579 RID: 103801
		public const string ZoomOut = "ZoomOut";

		// Token: 0x0401957A RID: 103802
		public const string 轮盘切换 = "轮盘切换";

		// Token: 0x0401957B RID: 103803
		public const string 小活动 = "小活动";

		// Token: 0x0401957C RID: 103804
		public const string 调谐 = "调谐";

		// Token: 0x0401957D RID: 103805
		public const string 变星 = "变星";

		// Token: 0x0401957E RID: 103806
		public const string 拾音辑录 = "拾音辑录";

		// Token: 0x0401957F RID: 103807
		public const string 放弃改键 = "放弃改键";

		// Token: 0x04019580 RID: 103808
		public const string 重新挑战 = "重新挑战";

		// Token: 0x04019581 RID: 103809
		public const string UI鼠标中键手柄特右 = "UI鼠标中键手柄特右";

		// Token: 0x04019582 RID: 103810
		public const string 退出精简模式 = "退出精简模式";

		// Token: 0x04019583 RID: 103811
		public const string 退出精简模式PC触摸板 = "退出精简模式PC触摸板";

		// Token: 0x04019584 RID: 103812
		public const string 割草BUFF信息 = "割草BUFF信息";

		// Token: 0x04019585 RID: 103813
		public const string 割草BUFF信息PC触摸板 = "割草BUFF信息PC触摸板";

		// Token: 0x04019586 RID: 103814
		public const string Photo臂长隐藏 = "Photo臂长隐藏";

		// Token: 0x04019587 RID: 103815
		public const string Photo手动对焦切换 = "Photo手动对焦切换";

		// Token: 0x04019588 RID: 103816
		public const string Photo快门 = "Photo快门";

		// Token: 0x04019589 RID: 103817
		public const string Photo模式切换 = "Photo模式切换";

		// Token: 0x0401958A RID: 103818
		public const string Photo退出 = "Photo退出";

		// Token: 0x0401958B RID: 103819
		public const string 滚动条切换 = "滚动条切换";

		// Token: 0x0401958C RID: 103820
		public const string Ui返回 = "UI返回";

		// Token: 0x0401958D RID: 103821
		public const string Ui方向上 = "UI方向上";

		// Token: 0x0401958E RID: 103822
		public const string Ui方向下 = "UI方向下";

		// Token: 0x0401958F RID: 103823
		public const string Ui方向左 = "UI方向左";

		// Token: 0x04019590 RID: 103824
		public const string Ui方向右 = "UI方向右";

		// Token: 0x04019591 RID: 103825
		public const string UI键盘F手柄A = "UI键盘F手柄A";

		// Token: 0x04019592 RID: 103826
		public const string UI键盘R手柄X = "UI键盘R手柄X";

		// Token: 0x04019593 RID: 103827
		public const string UI键盘T手柄Y = "UI键盘T手柄Y";

		// Token: 0x04019594 RID: 103828
		public const string UI键盘Q手柄LB = "UI键盘Q手柄LB";

		// Token: 0x04019595 RID: 103829
		public const string UI键盘E手柄RB = "UI键盘E手柄RB";

		// Token: 0x04019596 RID: 103830
		public const string UI键盘Z手柄LT = "UI键盘Z手柄LT";

		// Token: 0x04019597 RID: 103831
		public const string UI键盘C手柄RT = "UI键盘C手柄RT";

		// Token: 0x04019598 RID: 103832
		public const string UI手柄右摇杆上 = "UI手柄右摇杆上";

		// Token: 0x04019599 RID: 103833
		public const string UI手柄右摇杆下 = "UI手柄右摇杆下";

		// Token: 0x0401959A RID: 103834
		public const string UI键盘G手柄特右 = "UI键盘G手柄特右";

		// Token: 0x0401959B RID: 103835
		public const string UI键盘X手柄特左 = "UI键盘X手柄特左";

		// Token: 0x0401959C RID: 103836
		public const string UI键盘U手柄左摇杆 = "UI键盘U手柄左摇杆";

		// Token: 0x0401959D RID: 103837
		public const string UI键盘G手柄右摇杆 = "UI键盘G手柄右摇杆";

		// Token: 0x0401959E RID: 103838
		public const string UI键盘Y手柄特右 = "UI键盘Y手柄特右";

		// Token: 0x0401959F RID: 103839
		public const string UI键盘H手柄特左 = "UI键盘H手柄特左";

		// Token: 0x040195A0 RID: 103840
		public const string UI键盘ESC手柄B = "UI键盘ESC手柄B";

		// Token: 0x040195A1 RID: 103841
		public const string UI键盘N = "UI键盘N";

		// Token: 0x040195A2 RID: 103842
		public const string UI键鼠F空格 = "UI键鼠F空格";

		// Token: 0x040195A3 RID: 103843
		public const string UI手柄A方向右 = "UI手柄A方向右";

		// Token: 0x040195A4 RID: 103844
		public const string UI手柄B方向左 = "UI手柄B方向左";

		// Token: 0x040195A5 RID: 103845
		public const string 手柄引导下一步 = "手柄引导下一步";

		// Token: 0x040195A6 RID: 103846
		public const string UI左摇杆上 = "UI左摇杆上";

		// Token: 0x040195A7 RID: 103847
		public const string UI左摇杆下 = "UI左摇杆下";

		// Token: 0x040195A8 RID: 103848
		public const string UI左摇杆左 = "UI左摇杆左";

		// Token: 0x040195A9 RID: 103849
		public const string UI左摇杆右 = "UI左摇杆右";

		// Token: 0x040195AA RID: 103850
		public const string UI鼠标侧键前 = "UI鼠标侧键前";

		// Token: 0x040195AB RID: 103851
		public const string UI鼠标侧键后 = "UI鼠标侧键后";

		// Token: 0x040195AC RID: 103852
		public const string UI键盘V手柄特左 = "UI键盘V手柄特左";

		// Token: 0x040195AD RID: 103853
		public const string UI键盘子弹跳 = "UI键盘子弹跳";

		// Token: 0x040195AE RID: 103854
		public const string UI键盘交互 = "UI键盘交互";

		// Token: 0x040195AF RID: 103855
		public const string UI手柄退场技 = "UI手柄退场技";

		// Token: 0x040195B0 RID: 103856
		public const string UI手柄漂移 = "UI手柄漂移";

		// Token: 0x040195B1 RID: 103857
		public const string 激活聊天 = "激活聊天";

		// Token: 0x040195B2 RID: 103858
		public const string QTE数字1 = "QTE数字1";

		// Token: 0x040195B3 RID: 103859
		public const string QTE数字2 = "QTE数字2";

		// Token: 0x040195B4 RID: 103860
		public const string QTE数字3 = "QTE数字3";

		// Token: 0x040195B5 RID: 103861
		public const string QTE数字4 = "QTE数字4";

		// Token: 0x040195B6 RID: 103862
		public const string UI键盘数字1手柄上 = "UI键盘数字1手柄上";

		// Token: 0x040195B7 RID: 103863
		public const string UI键盘数字2手柄左 = "UI键盘数字2手柄左";

		// Token: 0x040195B8 RID: 103864
		public const string UI键盘数字3手柄右 = "UI键盘数字3手柄右";

		// Token: 0x040195B9 RID: 103865
		public const string UI键盘数字4手柄下 = "UI键盘数字4手柄下";

		// Token: 0x040195BA RID: 103866
		public const string UI键盘回车 = "UI键盘回车";

		// Token: 0x040195BB RID: 103867
		public const string Link大招 = "Link大招";

		// Token: 0x040195BC RID: 103868
		public const string 团子养成 = "团子养成";

		// Token: 0x040195BD RID: 103869
		public const string 团子商店 = "团子商店";

		// Token: 0x040195BE RID: 103870
		public const string 退出团子副本 = "退出团子副本";

		// Token: 0x040195BF RID: 103871
		public const string UI键盘空格 = "UI键盘空格";

		// Token: 0x040195C0 RID: 103872
		public const string 浴场同伴 = "浴场同伴";

		// Token: 0x040195C1 RID: 103873
		public const string 浴场切换视角 = "浴场切换视角";

		// Token: 0x040195C2 RID: 103874
		public const string 浴场快照 = "浴场快照";

		// Token: 0x040195C3 RID: 103875
		public const string 组合菜单键 = "组合菜单键";

		// Token: 0x040195C4 RID: 103876
		public const string 塔防射击 = "塔防射击";

		// Token: 0x040195C5 RID: 103877
		public const string 塔防旋转 = "塔防旋转";

		// Token: 0x040195C6 RID: 103878
		public const string 塔防回收机关 = "塔防回收机关";

		// Token: 0x040195C7 RID: 103879
		public const string 塔防整备 = "塔防整备";

		// Token: 0x040195C8 RID: 103880
		public const string 塔防开始 = "塔防开始";

		// Token: 0x040195C9 RID: 103881
		public const string 塔防选择1 = "塔防选择1";

		// Token: 0x040195CA RID: 103882
		public const string 塔防选择2 = "塔防选择2";

		// Token: 0x040195CB RID: 103883
		public const string 塔防选择3 = "塔防选择3";

		// Token: 0x040195CC RID: 103884
		public const string 塔防选择4 = "塔防选择4";

		// Token: 0x040195CD RID: 103885
		public const string 塔防选择5 = "塔防选择5";

		// Token: 0x040195CE RID: 103886
		public const string 塔防选择6 = "塔防选择6";

		// Token: 0x040195CF RID: 103887
		public const string 塔防选择7 = "塔防选择7";

		// Token: 0x040195D0 RID: 103888
		public const string 塔防选择8 = "塔防选择8";

		// Token: 0x040195D1 RID: 103889
		public const string 塔防跳跃 = "塔防跳跃";

		// Token: 0x040195D2 RID: 103890
		public const string 塔防冲刺 = "塔防冲刺";

		// Token: 0x040195D3 RID: 103891
		public const string 塔防选择上一个 = "塔防选择上一个";

		// Token: 0x040195D4 RID: 103892
		public const string 塔防选择下一个 = "塔防选择下一个";

		// Token: 0x040195D5 RID: 103893
		public const string 塔防组合主键 = "塔防组合主键";

		// Token: 0x040195D6 RID: 103894
		public const string 塔防商店 = "塔防商店";

		// Token: 0x040195D7 RID: 103895
		public const string 塔防轮盘 = "塔防轮盘";

		// Token: 0x040195D8 RID: 103896
		public const string 塔防道具 = "塔防道具";

		// Token: 0x040195D9 RID: 103897
		public const string 塔防地图 = "塔防地图";

		// Token: 0x040195DA RID: 103898
		public const string 塔防走跑切换 = "塔防走跑切换";

		// Token: 0x040195DB RID: 103899
		public const string 交互动态漫_向上拖动 = "交互动态漫-向上拖动";

		// Token: 0x040195DC RID: 103900
		public const string 交互动态漫_向下拖动 = "交互动态漫-向下拖动";

		// Token: 0x040195DD RID: 103901
		public const string 交互动态漫_转动 = "交互动态漫-转动";

		// Token: 0x040195DE RID: 103902
		public const string 交互动态漫_点击 = "交互动态漫-点击";

		// Token: 0x040195DF RID: 103903
		public const string 交互动态漫_长按 = "交互动态漫-长按";

		// Token: 0x040195E0 RID: 103904
		public const string QTE选项1 = "QTE选项1";

		// Token: 0x040195E1 RID: 103905
		public const string QTE选项2 = "QTE选项2";

		// Token: 0x040195E2 RID: 103906
		public const string QTE选项3 = "QTE选项3";

		// Token: 0x040195E3 RID: 103907
		public const string QTE选项4 = "QTE选项4";

		// Token: 0x040195E4 RID: 103908
		public const string QTE方向上 = "qte方向上";

		// Token: 0x040195E5 RID: 103909
		public const string QTE方向下 = "qte方向下";

		// Token: 0x040195E6 RID: 103910
		public const string QTE方向左 = "qte方向左";

		// Token: 0x040195E7 RID: 103911
		public const string QTE方向右 = "qte方向右";

		// Token: 0x040195E8 RID: 103912
		public const string QTE分体选项1_左 = "QTE分体选项1-左";

		// Token: 0x040195E9 RID: 103913
		public const string QTE分体选项2_右 = "QTE分体选项2-右";

		// Token: 0x040195EA RID: 103914
		public const string QTE_R2攻击 = "QTE-R2攻击";

		// Token: 0x040195EB RID: 103915
		public const string QTE_空格A = "QTE-空格和A键";

		// Token: 0x040195EC RID: 103916
		public const string D级限时选项_1 = "D级限时选项-1";

		// Token: 0x040195ED RID: 103917
		public const string D级限时选项_2 = "D级限时选项-2";

		// Token: 0x040195EE RID: 103918
		public const string 载具漂移 = "载具漂移";

		// Token: 0x040195EF RID: 103919
		public const string 载具子弹跳 = "载具子弹跳";

		// Token: 0x040195F0 RID: 103920
		public const string 载具子弹跳1 = "载具子弹跳1";

		// Token: 0x040195F1 RID: 103921
		public const string 载具退场技和下车 = "载具退场技和下车";

		// Token: 0x040195F2 RID: 103922
		public const string 载具探索工具 = "载具探索工具";

		// Token: 0x040195F3 RID: 103923
		public const string 载具氮气 = "载具氮气";

		// Token: 0x040195F4 RID: 103924
		public const string 载具视角切换 = "载具视角切换";

		// Token: 0x040195F5 RID: 103925
		public const string 载具空中抬升 = "载具空中抬升";

		// Token: 0x040195F6 RID: 103926
		public const string 载具音乐上一首 = "载具音乐上一首";

		// Token: 0x040195F7 RID: 103927
		public const string 载具音乐下一首 = "载具音乐下一首";

		// Token: 0x040195F8 RID: 103928
		public const string 载具音乐播放暂停 = "载具音乐播放暂停";

		// Token: 0x040195F9 RID: 103929
		public const string 载具锁定目标 = "载具锁定目标";

		// Token: 0x040195FA RID: 103930
		public const string 载具辅助机攻击 = "载具辅助机攻击";

		// Token: 0x040195FB RID: 103931
		public const string 飞讯 = "飞讯";

		// Token: 0x040195FC RID: 103932
		public const string 弹珠挡板 = "弹珠挡板";

		// Token: 0x040195FD RID: 103933
		public const string 弹珠冲刺 = "弹珠冲刺";

		// Token: 0x040195FE RID: 103934
		public const string 全量点击继续 = "全量点击继续";

		// Token: 0x040195FF RID: 103935
		public const string 黑潮声骸轮盘 = "黑潮声骸轮盘";

		// Token: 0x04019600 RID: 103936
		public const string 黑潮道具轮盘 = "黑潮道具轮盘";

		// Token: 0x04019601 RID: 103937
		public const string 黑潮选择1 = "黑潮选择1";

		// Token: 0x04019602 RID: 103938
		public const string 黑潮选择2 = "黑潮选择2";

		// Token: 0x04019603 RID: 103939
		public const string 黑潮选择3 = "黑潮选择3";

		// Token: 0x04019604 RID: 103940
		public const string 黑潮选择4 = "黑潮选择4";

		// Token: 0x04019605 RID: 103941
		public const string 黑潮背包 = "黑潮背包";
	}
}

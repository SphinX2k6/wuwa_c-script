using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200147D RID: 5245
	[NullableContext(1)]
	[Nullable(0)]
	public static class IActionDefine
	{
		// Token: 0x06007764 RID: 30564 RVA: 0x0011D468 File Offset: 0x0011B668
		public static bool IsStateTypeContainsState(string type, string state)
		{
			string entityStateKeyByTag = IActionDefine.GetEntityStateKeyByTag(type, state);
			return !string.IsNullOrEmpty(entityStateKeyByTag) && IActionDefine.GetStatesByType(type).Contains(entityStateKeyByTag);
		}

		// Token: 0x06007765 RID: 30565 RVA: 0x0011D494 File Offset: 0x0011B694
		public static ICollection<string> GetStatesByType(string type)
		{
			Dictionary<string, string> dictionary;
			if (IActionDefine.entityStateConfig.TryGetValue(type, out dictionary) && dictionary != null)
			{
				return dictionary.Keys;
			}
			return new List<string>();
		}

		// Token: 0x06007766 RID: 30566 RVA: 0x0011D4C0 File Offset: 0x0011B6C0
		public static string GetEntityStateTag(string type, string state)
		{
			Dictionary<string, string> dictionary;
			if (!IActionDefine.entityStateConfig.TryGetValue(type, out dictionary) || dictionary == null)
			{
				throw new KeyNotFoundException("getEntityStateTag: " + type + " is not exist");
			}
			return dictionary.GetValueOrDefault(state) ?? string.Empty;
		}

		// Token: 0x06007767 RID: 30567 RVA: 0x0011D508 File Offset: 0x0011B708
		[return: Nullable(2)]
		public static string GetEntityStateKeyByTag(string entityStateType, string gamePlayTag)
		{
			Dictionary<string, string> dictionary;
			if (IActionDefine.entityStateConfig.TryGetValue(entityStateType, out dictionary))
			{
				return dictionary.GetValueOrDefault(gamePlayTag);
			}
			return null;
		}

		// Token: 0x06007768 RID: 30568 RVA: 0x0011D530 File Offset: 0x0011B730
		// Note: this type is marked as 'beforefieldinit'.
		static IActionDefine()
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary["Info"] = "提示";
			dictionary["Warn"] = "警告";
			dictionary["Error"] = "错误";
			IActionDefine.logLevelConfig = dictionary;
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2["Idle"] = "待机";
			dictionary2["Open"] = "打开";
			dictionary2["Close"] = "关闭";
			IActionDefine.actorStateConfig = dictionary2;
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			dictionary3["Drama"] = "剧情相机";
			dictionary3["Follow"] = "跟随";
			dictionary3["FollowDrama"] = "跟随相机剧情模式";
			IActionDefine.cameraModeConfig = dictionary3;
			Dictionary<string, string> dictionary4 = new Dictionary<string, string>();
			dictionary4["LevelA"] = "A级演出";
			dictionary4["LevelB"] = "B级演出";
			dictionary4["LevelC"] = "C级演出";
			dictionary4["LevelD"] = "D级演出";
			dictionary4["SystemViewText"] = "界面文本";
			dictionary4["Prompt"] = "头像浮框";
			dictionary4["Reigns"] = "王权玩法";
			dictionary4["PhoneMessage"] = "手机短信";
			dictionary4["Avg"] = "弹珠AVG";
			dictionary4["ControlEntity"] = "实体控制";
			dictionary4["VisualNovel"] = "AVG视觉小说";
			IActionDefine.plotModeConfig = dictionary4;
			Dictionary<string, string> dictionary5 = new Dictionary<string, string>();
			dictionary5["One"] = "1角色";
			dictionary5["Two"] = "2角色";
			dictionary5["Three"] = "3角色";
			dictionary5["None"] = "无";
			IActionDefine.cameraBindModeConfig = dictionary5;
			Dictionary<string, string> dictionary6 = new Dictionary<string, string>();
			dictionary6["CS"] = "特写";
			dictionary6["MS"] = "中景";
			dictionary6["WS"] = "远景";
			dictionary6["None"] = "无";
			IActionDefine.cameraTypeConfig = dictionary6;
			Dictionary<string, string> dictionary7 = new Dictionary<string, string>();
			dictionary7["Add"] = "+";
			dictionary7["Sub"] = "-";
			dictionary7["Mut"] = "×";
			dictionary7["Div"] = "÷";
			IActionDefine.calOpTypeConfig = dictionary7;
			Dictionary<string, string> dictionary8 = new Dictionary<string, string>();
			dictionary8["Ge"] = ">=";
			dictionary8["Gt"] = ">";
			dictionary8["Le"] = "<=";
			dictionary8["Lt"] = "<";
			dictionary8["Eq"] = "==";
			dictionary8["Ne"] = "!=";
			IActionDefine.compareTypeConfig = dictionary8;
			Dictionary<string, string> dictionary9 = new Dictionary<string, string>();
			dictionary9["And"] = "与";
			dictionary9["Or"] = "或";
			IActionDefine.logicOpTypeConfig = dictionary9;
			Dictionary<string, Dictionary<string, string>> dictionary10 = new Dictionary<string, Dictionary<string, string>>();
			string key = "激活态";
			Dictionary<string, string> dictionary11 = new Dictionary<string, string>();
			dictionary11["常态"] = "关卡.Common.状态.常态";
			dictionary11["激活"] = "关卡.Common.状态.激活";
			dictionary10[key] = dictionary11;
			string key2 = "完成态";
			Dictionary<string, string> dictionary12 = new Dictionary<string, string>();
			dictionary12["常态"] = "关卡.Common.状态.常态";
			dictionary12["激活"] = "关卡.Common.状态.激活";
			dictionary12["完成"] = "关卡.Common.状态.完成";
			dictionary10[key2] = dictionary12;
			string key3 = "失败态";
			Dictionary<string, string> dictionary13 = new Dictionary<string, string>();
			dictionary13["常态"] = "关卡.Common.状态.常态";
			dictionary13["激活"] = "关卡.Common.状态.激活";
			dictionary13["完成"] = "关卡.Common.状态.完成";
			dictionary13["失败"] = "关卡.Common.状态.失败";
			dictionary10[key3] = dictionary13;
			string key4 = "封锁态";
			Dictionary<string, string> dictionary14 = new Dictionary<string, string>();
			dictionary14["封锁"] = "关卡.Common.状态.封锁";
			dictionary14["解锁"] = "关卡.Common.状态.解锁";
			dictionary14["常态"] = "关卡.Common.状态.常态";
			dictionary14["激活"] = "关卡.Common.状态.激活";
			dictionary14["完成"] = "关卡.Common.状态.完成";
			dictionary10[key4] = dictionary14;
			string key5 = "状态型打击机关";
			Dictionary<string, string> dictionary15 = new Dictionary<string, string>();
			dictionary15["状态1"] = "关卡.打击机关.状态1";
			dictionary15["状态5"] = "关卡.打击机关.状态5";
			dictionary15["完成"] = "关卡.Common.状态.完成";
			dictionary15["已废弃状态2"] = "关卡.打击机关.状态2";
			dictionary15["已废弃状态3"] = "关卡.打击机关.状态3";
			dictionary15["已废弃状态4"] = "关卡.打击机关.状态4";
			dictionary15["已废弃状态6"] = "关卡.打击机关.状态6";
			dictionary15["已废弃状态7"] = "关卡.打击机关.状态7";
			dictionary15["已废弃初始状态"] = "关卡.打击机关.初始状态";
			dictionary15["已废弃完成状态"] = "关卡.打击机关.完成状态";
			dictionary10[key5] = dictionary15;
			string key6 = "打击机关组";
			Dictionary<string, string> dictionary16 = new Dictionary<string, string>();
			dictionary16["激活"] = "关卡.Common.状态.激活";
			dictionary16["完成"] = "关卡.Common.状态.完成";
			dictionary10[key6] = dictionary16;
			string key7 = "射击靶";
			Dictionary<string, string> dictionary17 = new Dictionary<string, string>();
			dictionary17["数字状态1"] = "关卡.射击靶.状态1";
			dictionary17["数字状态2"] = "关卡.射击靶.状态2";
			dictionary17["数字状态3"] = "关卡.射击靶.状态3";
			dictionary17["数字状态4"] = "关卡.射击靶.状态4";
			dictionary17["完成状态"] = "关卡.射击靶.状态5";
			dictionary17["禁止状态"] = "关卡.射击靶.状态6";
			dictionary17["初始状态"] = "关卡.射击靶.状态7";
			dictionary17["禁止射击"] = "关卡.射击靶.禁止射击";
			dictionary17["允许射击"] = "关卡.射击靶.允许射击";
			dictionary17["完成射击"] = "关卡.射击靶.完成射击";
			dictionary10[key7] = dictionary17;
			string key8 = "射击靶组";
			Dictionary<string, string> dictionary18 = new Dictionary<string, string>();
			dictionary18["常态"] = "关卡.Common.状态.常态";
			dictionary18["激活"] = "关卡.Common.状态.激活";
			dictionary18["完成"] = "关卡.Common.状态.完成";
			dictionary10[key8] = dictionary18;
			string key9 = "鲸鱼冰面";
			Dictionary<string, string> dictionary19 = new Dictionary<string, string>();
			dictionary19["初始状态"] = "关卡.鲸鱼冰面.初始状态";
			dictionary19["战斗状态1"] = "关卡.鲸鱼冰面.战斗状态1";
			dictionary19["战斗状态2"] = "关卡.鲸鱼冰面.战斗状态2";
			dictionary19["战斗状态3"] = "关卡.鲸鱼冰面.战斗状态3";
			dictionary19["结束状态"] = "关卡.鲸鱼冰面.结束状态";
			dictionary10[key9] = dictionary19;
			string key10 = "多层电梯";
			Dictionary<string, string> dictionary20 = new Dictionary<string, string>();
			dictionary20["上升"] = "关卡.电梯.上升";
			dictionary20["下降"] = "关卡.电梯.下降";
			dictionary20["停靠"] = "关卡.电梯.停靠";
			dictionary10[key10] = dictionary20;
			string key11 = "声弦";
			Dictionary<string, string> dictionary21 = new Dictionary<string, string>();
			dictionary21["隐藏"] = "关卡.声弦.隐藏";
			dictionary21["常驻"] = "关卡.声弦.常驻";
			dictionary21["收缩"] = "关卡.声弦.收缩";
			dictionary21["爆炸"] = "关卡.声弦.爆炸";
			dictionary21["锁定"] = "关卡.Common.状态.锁定";
			dictionary10[key11] = dictionary21;
			string key12 = "无音区";
			Dictionary<string, string> dictionary22 = new Dictionary<string, string>();
			dictionary22["沉寂"] = "关卡.无音区.沉寂";
			dictionary22["激活"] = "关卡.无音区.激活";
			dictionary22["净化"] = "关卡.无音区.净化";
			dictionary10[key12] = dictionary22;
			string key13 = "副本入口";
			Dictionary<string, string> dictionary23 = new Dictionary<string, string>();
			dictionary23["可解锁"] = "物体.物体阶段.可解锁";
			dictionary23["常态"] = "关卡.Common.状态.常态";
			dictionary23["激活"] = "关卡.Common.状态.激活";
			dictionary23["交互中"] = "关卡.Common.状态.交互中";
			dictionary10[key13] = dictionary23;
			string key14 = "二态电压";
			Dictionary<string, string> dictionary24 = new Dictionary<string, string>();
			dictionary24["高压"] = "关卡.Common.状态.高压";
			dictionary24["低压"] = "关卡.Common.状态.低压";
			dictionary10[key14] = dictionary24;
			string key15 = "中枢乐器";
			Dictionary<string, string> dictionary25 = new Dictionary<string, string>();
			dictionary25["常态"] = "关卡.Common.状态.常态";
			dictionary25["一阶段"] = "关卡.中枢乐器.状态.一阶段";
			dictionary25["二阶段"] = "关卡.中枢乐器.状态.二阶段";
			dictionary25["三阶段"] = "关卡.中枢乐器.状态.三阶段";
			dictionary25["四阶段"] = "关卡.中枢乐器.状态.四阶段";
			dictionary25["五阶段"] = "关卡.中枢乐器.状态.五阶段";
			dictionary10[key15] = dictionary25;
			string key16 = "物体阶段";
			Dictionary<string, string> dictionary26 = new Dictionary<string, string>();
			dictionary26["完整"] = "物体.物体阶段.完整";
			dictionary26["轻微破损"] = "物体.物体阶段.轻微破损";
			dictionary26["严重破损"] = "物体.物体阶段.严重破损";
			dictionary26["完全破坏"] = "物体.物体阶段.完全破坏";
			dictionary10[key16] = dictionary26;
			string key17 = "时间回放";
			Dictionary<string, string> dictionary27 = new Dictionary<string, string>();
			dictionary27["状态1"] = "关卡.时间回放.状态1";
			dictionary27["状态2"] = "关卡.时间回放.状态2";
			dictionary27["状态3"] = "关卡.时间回放.状态3";
			dictionary27["状态4"] = "关卡.时间回放.状态4";
			dictionary27["状态5"] = "关卡.时间回放.状态5";
			dictionary27["状态6"] = "关卡.时间回放.状态6";
			dictionary27["状态7"] = "关卡.时间回放.状态7";
			dictionary27["状态8"] = "关卡.时间回放.状态8";
			dictionary27["状态9"] = "关卡.时间回放.状态9";
			dictionary27["状态10"] = "关卡.时间回放.状态10";
			dictionary27["占位"] = "关卡.时间回放.占位";
			dictionary10[key17] = dictionary27;
			string key18 = "场景交互";
			Dictionary<string, string> dictionary28 = new Dictionary<string, string>();
			dictionary28["常态"] = "关卡.Common.状态.常态";
			dictionary28["交互中"] = "关卡.Common.状态.场景物件交互中";
			dictionary10[key18] = dictionary28;
			string key19 = "屏障生成机关";
			Dictionary<string, string> dictionary29 = new Dictionary<string, string>();
			dictionary29["闭合"] = "关卡.屏障生成机关.闭合";
			dictionary29["启动"] = "关卡.屏障生成机关.启动";
			dictionary29["故障"] = "关卡.屏障生成机关.故障";
			dictionary29["完成"] = "关卡.屏障生成机关.完成";
			dictionary29["封锁"] = "关卡.屏障生成机关.封锁";
			dictionary10[key19] = dictionary29;
			string key20 = "LevelSeq标记";
			Dictionary<string, string> dictionary30 = new Dictionary<string, string>();
			dictionary30["标记A"] = "关卡.LevelSeq标记.标记A";
			dictionary30["标记B"] = "关卡.LevelSeq标记.标记B";
			dictionary30["标记C"] = "关卡.LevelSeq标记.标记C";
			dictionary30["标记D"] = "关卡.LevelSeq标记.标记D";
			dictionary30["标记E"] = "关卡.LevelSeq标记.标记E";
			dictionary30["标记F"] = "关卡.LevelSeq标记.标记F";
			dictionary30["标记G"] = "关卡.LevelSeq标记.标记G";
			dictionary30["标记H"] = "关卡.LevelSeq标记.标记H";
			dictionary30["标记I"] = "关卡.LevelSeq标记.标记I";
			dictionary30["标记J"] = "关卡.LevelSeq标记.标记J";
			dictionary30["标记K"] = "关卡.LevelSeq标记.标记K";
			dictionary30["标记L"] = "关卡.LevelSeq标记.标记L";
			dictionary30["标记M"] = "关卡.LevelSeq标记.标记M";
			dictionary30["标记N"] = "关卡.LevelSeq标记.标记N";
			dictionary30["标记O"] = "关卡.LevelSeq标记.标记O";
			dictionary30["标记P"] = "关卡.LevelSeq标记.标记P";
			dictionary30["标记Q"] = "关卡.LevelSeq标记.标记Q";
			dictionary30["标记R"] = "关卡.LevelSeq标记.标记R";
			dictionary30["标记S"] = "关卡.LevelSeq标记.标记S";
			dictionary30["标记T"] = "关卡.LevelSeq标记.标记T";
			dictionary30["标记U"] = "关卡.LevelSeq标记.标记U";
			dictionary30["标记V"] = "关卡.LevelSeq标记.标记V";
			dictionary30["标记W"] = "关卡.LevelSeq标记.标记W";
			dictionary30["标记X"] = "关卡.LevelSeq标记.标记X";
			dictionary30["标记Y"] = "关卡.LevelSeq标记.标记Y";
			dictionary30["标记Z"] = "关卡.LevelSeq标记.标记Z";
			dictionary10[key20] = dictionary30;
			string key21 = "黑海岸时针石柱";
			Dictionary<string, string> dictionary31 = new Dictionary<string, string>();
			dictionary31["常态"] = "关卡.黑海岸时针石柱.常态";
			dictionary31["可激活"] = "关卡.黑海岸时针石柱.可激活";
			dictionary31["激活"] = "关卡.黑海岸时针石柱.激活";
			dictionary31["完成"] = "关卡.黑海岸时针石柱.完成";
			dictionary10[key21] = dictionary31;
			string key22 = "采集物底座";
			Dictionary<string, string> dictionary32 = new Dictionary<string, string>();
			dictionary32["未采集"] = "关卡.采集物底座.未采集";
			dictionary32["完全采集"] = "关卡.采集物底座.完全采集";
			dictionary10[key22] = dictionary32;
			string key23 = "Npc生态事件";
			Dictionary<string, string> dictionary33 = new Dictionary<string, string>();
			dictionary33["事件1"] = "关卡.Npc生态事件.事件1";
			dictionary33["事件2"] = "关卡.Npc生态事件.事件2";
			dictionary33["事件3"] = "关卡.Npc生态事件.事件3";
			dictionary33["事件4"] = "关卡.Npc生态事件.事件4";
			dictionary33["事件5"] = "关卡.Npc生态事件.事件5";
			dictionary33["事件6"] = "关卡.Npc生态事件.事件6";
			dictionary33["事件7"] = "关卡.Npc生态事件.事件7";
			dictionary33["事件8"] = "关卡.Npc生态事件.事件8";
			dictionary10[key23] = dictionary33;
			string key24 = "踩踏机关";
			Dictionary<string, string> dictionary34 = new Dictionary<string, string>();
			dictionary34["顶部"] = "关卡.踩踏机关.顶部";
			dictionary34["下降中"] = "关卡.踩踏机关.下降中";
			dictionary34["上升中"] = "关卡.踩踏机关.上升中";
			dictionary34["底部"] = "关卡.踩踏机关.底部";
			dictionary10[key24] = dictionary34;
			string key25 = "传送门";
			Dictionary<string, string> dictionary35 = new Dictionary<string, string>();
			dictionary35["闲置"] = "关卡.传送门.闲置";
			dictionary35["激活"] = "关卡.传送门.激活";
			dictionary35["传送中"] = "关卡.传送门.传送中";
			dictionary35["传送完成"] = "关卡.传送门.传送完成";
			dictionary10[key25] = dictionary35;
			string key26 = "黑石囚笼";
			Dictionary<string, string> dictionary36 = new Dictionary<string, string>();
			dictionary36["完整"] = "关卡.黑石囚笼.完整";
			dictionary36["破损一阶段"] = "关卡.黑石囚笼.破损.一阶段";
			dictionary36["破损二阶段"] = "关卡.黑石囚笼.破损.二阶段";
			dictionary36["破损三阶段"] = "关卡.黑石囚笼.破损.三阶段";
			dictionary36["完全破坏"] = "关卡.黑石囚笼.完全破坏";
			dictionary10[key26] = dictionary36;
			string key27 = "乘霄山光线传导机关";
			Dictionary<string, string> dictionary37 = new Dictionary<string, string>();
			dictionary37["常态"] = "关卡.Common.状态.常态";
			dictionary37["激活"] = "关卡.Common.状态.激活";
			dictionary37["准备中"] = "关卡.Common.状态.准备中";
			dictionary37["完成"] = "关卡.Common.状态.完成";
			dictionary10[key27] = dictionary37;
			string key28 = "多层封锁态";
			Dictionary<string, string> dictionary38 = new Dictionary<string, string>();
			dictionary38["常态"] = "关卡.Common.状态.常态";
			dictionary38["一层"] = "关卡.多层封锁.一层";
			dictionary38["二层"] = "关卡.多层封锁.二层";
			dictionary38["三层"] = "关卡.多层封锁.三层";
			dictionary38["四层"] = "关卡.多层封锁.四层";
			dictionary38["五层"] = "关卡.多层封锁.五层";
			dictionary38["完成"] = "关卡.Common.状态.完成";
			dictionary10[key28] = dictionary38;
			string key29 = "多中间态";
			Dictionary<string, string> dictionary39 = new Dictionary<string, string>();
			dictionary39["常态"] = "关卡.Common.状态.常态";
			dictionary39["中间态1"] = "关卡.打击机关.状态1";
			dictionary39["中间态2"] = "关卡.打击机关.状态2";
			dictionary39["中间态3"] = "关卡.打击机关.状态3";
			dictionary39["中间态4"] = "关卡.打击机关.状态4";
			dictionary39["中间态5"] = "关卡.打击机关.状态5";
			dictionary39["中间态6"] = "关卡.打击机关.状态6";
			dictionary39["完成"] = "关卡.Common.状态.完成";
			dictionary10[key29] = dictionary39;
			string key30 = "大个布偶坚固岩石";
			Dictionary<string, string> dictionary40 = new Dictionary<string, string>();
			dictionary40["状态1"] = "关卡.打击机关.状态1";
			dictionary40["状态2"] = "关卡.打击机关.状态2";
			dictionary40["状态3"] = "关卡.打击机关.状态3";
			dictionary40["状态4"] = "关卡.打击机关.状态4";
			dictionary40["状态5"] = "关卡.打击机关.状态5";
			dictionary40["状态6"] = "关卡.打击机关.状态6";
			dictionary10[key30] = dictionary40;
			string key31 = "走图案玩法控制器";
			Dictionary<string, string> dictionary41 = new Dictionary<string, string>();
			dictionary41["常态"] = "关卡.打击机关.状态1";
			dictionary41["准备态"] = "关卡.打击机关.状态2";
			dictionary41["激活态"] = "关卡.打击机关.状态3";
			dictionary41["完成态"] = "关卡.打击机关.状态4";
			dictionary41["回放态"] = "关卡.打击机关.状态5";
			dictionary10[key31] = dictionary41;
			string key32 = "档位控制";
			Dictionary<string, string> dictionary42 = new Dictionary<string, string>();
			dictionary42["停止"] = "关卡.档位控制.停止";
			dictionary42["慢速"] = "关卡.档位控制.慢速";
			dictionary42["快速"] = "关卡.档位控制.快速";
			dictionary42["档位1"] = "关卡.档位控制.档位1";
			dictionary42["档位2"] = "关卡.档位控制.档位2";
			dictionary42["档位3"] = "关卡.档位控制.档位3";
			dictionary42["档位4"] = "关卡.档位控制.档位4";
			dictionary42["档位5"] = "关卡.档位控制.档位5";
			dictionary10[key32] = dictionary42;
			string key33 = "斩击状态";
			Dictionary<string, string> dictionary43 = new Dictionary<string, string>();
			dictionary43["激活"] = "关卡.Common.状态.激活";
			dictionary43["封锁"] = "关卡.Common.状态.封锁";
			dictionary43["完成"] = "关卡.Common.状态.完成";
			dictionary43["失败"] = "关卡.Common.状态.失败";
			dictionary10[key33] = dictionary43;
			string key34 = "神王频率状态";
			Dictionary<string, string> dictionary44 = new Dictionary<string, string>();
			dictionary44["普通常态"] = "关卡.打击机关.状态1";
			dictionary44["普通激活"] = "关卡.打击机关.状态2";
			dictionary44["普通完成"] = "关卡.打击机关.状态3";
			dictionary44["神王常态"] = "关卡.打击机关.状态4";
			dictionary44["神王激活"] = "关卡.打击机关.状态5";
			dictionary44["神王完成"] = "关卡.打击机关.状态6";
			dictionary10[key34] = dictionary44;
			string key35 = "呓语雕像状态";
			Dictionary<string, string> dictionary45 = new Dictionary<string, string>();
			dictionary45["完整状态"] = "关卡.打击机关.状态1";
			dictionary45["破坏阶段1"] = "关卡.打击机关.状态2";
			dictionary45["破坏阶段2"] = "关卡.打击机关.状态3";
			dictionary45["破坏阶段3"] = "关卡.打击机关.状态4";
			dictionary45["破坏阶段4"] = "关卡.打击机关.状态5";
			dictionary10[key35] = dictionary45;
			string key36 = "老虎机";
			Dictionary<string, string> dictionary46 = new Dictionary<string, string>();
			dictionary46["关闭"] = "关卡.老虎机.关闭";
			dictionary46["开启"] = "关卡.老虎机.开启";
			dictionary46["旋转状态1"] = "关卡.老虎机.旋转状态1";
			dictionary46["旋转状态2"] = "关卡.老虎机.旋转状态2";
			dictionary46["旋转状态3"] = "关卡.老虎机.旋转状态3";
			dictionary46["旋转状态4"] = "关卡.老虎机.旋转状态4";
			dictionary46["旋转状态5"] = "关卡.老虎机.旋转状态5";
			dictionary46["旋转状态6"] = "关卡.老虎机.旋转状态6";
			dictionary46["旋转状态7"] = "关卡.老虎机.旋转状态7";
			dictionary46["旋转状态8"] = "关卡.老虎机.旋转状态8";
			dictionary46["激活"] = "关卡.Common.状态.激活";
			dictionary46["失败"] = "关卡.Common.状态.失败";
			dictionary46["完成"] = "关卡.Common.状态.完成";
			dictionary10[key36] = dictionary46;
			string key37 = "音乐机关";
			Dictionary<string, string> dictionary47 = new Dictionary<string, string>();
			dictionary47["状态一"] = "关卡.Common.表现.音乐监听机关.状态一";
			dictionary47["状态二"] = "关卡.Common.表现.音乐监听机关.状态二";
			dictionary47["状态三"] = "关卡.Common.表现.音乐监听机关.状态三";
			dictionary47["状态四"] = "关卡.Common.表现.音乐监听机关.状态四";
			dictionary47["状态五"] = "关卡.Common.表现.音乐监听机关.状态五";
			dictionary47["状态六"] = "关卡.Common.表现.音乐监听机关.状态六";
			dictionary47["状态七"] = "关卡.Common.表现.音乐监听机关.状态七";
			dictionary47["状态八"] = "关卡.Common.表现.音乐监听机关.状态八";
			dictionary47["状态九"] = "关卡.Common.表现.音乐监听机关.状态九";
			dictionary47["状态十"] = "关卡.Common.表现.音乐监听机关.状态十";
			dictionary47["状态十一"] = "关卡.Common.表现.音乐监听机关.状态十一";
			dictionary10[key37] = dictionary47;
			string key38 = "死眼完成态";
			Dictionary<string, string> dictionary48 = new Dictionary<string, string>();
			dictionary48["常态"] = "关卡.Common.状态.常态";
			dictionary48["激活"] = "关卡.Common.状态.激活";
			dictionary48["完成"] = "关卡.Common.状态.完成";
			dictionary48["死眼命中"] = "关卡.Common.状态.死眼命中";
			dictionary10[key38] = dictionary48;
			string key39 = "黑白洞状态";
			Dictionary<string, string> dictionary49 = new Dictionary<string, string>();
			dictionary49["黑洞"] = "关卡.黑白洞机关.黑洞";
			dictionary49["白洞"] = "关卡.黑白洞机关.白洞";
			dictionary10[key39] = dictionary49;
			IActionDefine.entityStateConfig = dictionary10;
			Dictionary<string, Dictionary<string, string>> dictionary50 = new Dictionary<string, Dictionary<string, string>>();
			string key40 = "副本入口";
			Dictionary<string, string> dictionary51 = new Dictionary<string, string>();
			dictionary51["交互中"] = "关卡.Common.表现.交互中";
			dictionary50[key40] = dictionary51;
			string key41 = "反弹板";
			Dictionary<string, string> dictionary52 = new Dictionary<string, string>();
			dictionary52["隐藏特效"] = "关卡.Common.表现.隐藏";
			dictionary52["激活特效"] = "关卡.Common.表现.激活";
			dictionary50[key41] = dictionary52;
			string key42 = "光线传导机关";
			Dictionary<string, string> dictionary53 = new Dictionary<string, string>();
			dictionary53["启动未连接"] = "关卡.Common.表现.光线传导机关.启动.未连接";
			dictionary53["启动且被其他对象连接"] = "关卡.Common.表现.光线传导机关.启动.被连接";
			dictionary53["启动且连接到其他对象"] = "关卡.Common.表现.光线传导机关.启动.连接到对象";
			dictionary50[key42] = dictionary53;
			string key43 = "音乐机关";
			Dictionary<string, string> dictionary54 = new Dictionary<string, string>();
			dictionary54["状态一"] = "关卡.Common.表现.音乐监听机关.状态一";
			dictionary54["状态二"] = "关卡.Common.表现.音乐监听机关.状态二";
			dictionary50[key43] = dictionary54;
			string key44 = "量子门";
			Dictionary<string, string> dictionary55 = new Dictionary<string, string>();
			dictionary55["开碰撞"] = "关卡.Common.表现.量子门.开碰撞";
			dictionary55["关碰撞"] = "关卡.Common.表现.量子门.关碰撞";
			dictionary50[key44] = dictionary55;
			string key45 = "娃娃机展示柜";
			Dictionary<string, string> dictionary56 = new Dictionary<string, string>();
			dictionary56["常态"] = "关卡.Common.表现.娃娃机.常态";
			dictionary56["进行中"] = "关卡.Common.表现.娃娃机.进行中";
			dictionary50[key45] = dictionary56;
			string key46 = "变狐狸门空气墙";
			Dictionary<string, string> dictionary57 = new Dictionary<string, string>();
			dictionary57["空气墙关"] = "关卡.Common.表现.变狐狸门空气墙.关";
			dictionary57["空气墙开"] = "关卡.Common.表现.变狐狸门空气墙.开";
			dictionary50[key46] = dictionary57;
			IActionDefine.entityPrefabPerformanceConfig = dictionary50;
			Dictionary<string, string> dictionary58 = new Dictionary<string, string>();
			dictionary58["[EExploreSkillType.Hook]"] = "自由钩锁";
			dictionary58["[EExploreSkillType.Throw]"] = "投掷控物";
			dictionary58["[EExploreSkillType.Control]"] = "拉起控物";
			dictionary58["[EExploreSkillType.Scan]"] = "扫描";
			dictionary58["[EExploreSkillType.ShowVision]"] = "幻象展示";
			dictionary58["[EExploreSkillType.ShowVision2]"] = "声骸显像列表";
			dictionary58["[EExploreSkillType.Photo]"] = "拍照";
			dictionary58["[EExploreSkillType.PlaceTemporaryTeleport]"] = "放置临时传送点";
			dictionary58["[EExploreSkillType.DetectSoundBox]"] = "声匣探测";
			dictionary58["[EExploreSkillType.DetectTreasure]"] = "物资探测";
			dictionary58["[EExploreSkillType.FollowShooterEnter]"] = "辅助机进入";
			dictionary58["[EExploreSkillType.FollowShooterExit]"] = "辅助机退出";
			dictionary58["[EExploreSkillType.Soaring]"] = "翱翔";
			dictionary58["[EExploreSkillType.SummonMotorcycle]"] = "摩托召唤";
			dictionary58["[EExploreSkillType.SummonMotorcyclePark]"] = "摩托召唤-停靠（未实现）";
			dictionary58["[EExploreSkillType.MotorcycleCruise]"] = "摩托巡航";
			dictionary58["[EExploreSkillType.MotorcycleHook]"] = "摩托钩锁-定点无人机";
			dictionary58["[EExploreSkillType.MotorcycleCollect]"] = "摩托钩锁-采集";
			IActionDefine.exploreSkillTypeMapper = dictionary58;
			Dictionary<EInstrumentType, string> dictionary59 = new Dictionary<EInstrumentType, string>();
			dictionary59[EInstrumentType.ChineseZither] = "古琴";
			IActionDefine.InstrumentTypeCnMap = dictionary59;
		}

		// Token: 0x04004565 RID: 17765
		public static readonly IReadOnlyDictionary<string, string> logLevelConfig;

		// Token: 0x04004566 RID: 17766
		public static readonly IReadOnlyDictionary<string, string> actorStateConfig;

		// Token: 0x04004567 RID: 17767
		public static readonly IReadOnlyDictionary<string, string> cameraModeConfig;

		// Token: 0x04004568 RID: 17768
		public static readonly IReadOnlyDictionary<string, string> plotModeConfig;

		// Token: 0x04004569 RID: 17769
		public static readonly IReadOnlyDictionary<string, string> cameraBindModeConfig;

		// Token: 0x0400456A RID: 17770
		public static readonly IReadOnlyDictionary<string, string> cameraTypeConfig;

		// Token: 0x0400456B RID: 17771
		public static readonly IReadOnlyDictionary<string, string> calOpTypeConfig;

		// Token: 0x0400456C RID: 17772
		public static readonly IReadOnlyDictionary<string, string> compareTypeConfig;

		// Token: 0x0400456D RID: 17773
		public static readonly IReadOnlyDictionary<string, string> logicOpTypeConfig;

		// Token: 0x0400456E RID: 17774
		public static readonly IReadOnlyDictionary<string, Dictionary<string, string>> entityStateConfig;

		// Token: 0x0400456F RID: 17775
		public static readonly IReadOnlyDictionary<string, Dictionary<string, string>> entityPrefabPerformanceConfig;

		// Token: 0x04004570 RID: 17776
		public static readonly IReadOnlyDictionary<string, string> exploreSkillTypeMapper;

		// Token: 0x04004571 RID: 17777
		public static readonly IReadOnlyDictionary<EInstrumentType, string> InstrumentTypeCnMap;
	}
}

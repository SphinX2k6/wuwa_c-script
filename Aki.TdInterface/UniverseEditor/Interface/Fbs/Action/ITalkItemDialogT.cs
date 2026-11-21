using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AB0 RID: 31408
	public class ITalkItemDialogT
	{
		// Token: 0x1700E848 RID: 59464
		// (get) Token: 0x06037DD9 RID: 228825 RVA: 0x007805B1 File Offset: 0x0077E7B1
		// (set) Token: 0x06037DDA RID: 228826 RVA: 0x007805B9 File Offset: 0x0077E7B9
		public ETalkItemType Type { get; set; }

		// Token: 0x1700E849 RID: 59465
		// (get) Token: 0x06037DDB RID: 228827 RVA: 0x007805C2 File Offset: 0x0077E7C2
		// (set) Token: 0x06037DDC RID: 228828 RVA: 0x007805CA File Offset: 0x0077E7CA
		public int Id { get; set; }

		// Token: 0x1700E84A RID: 59466
		// (get) Token: 0x06037DDD RID: 228829 RVA: 0x007805D3 File Offset: 0x0077E7D3
		// (set) Token: 0x06037DDE RID: 228830 RVA: 0x007805DB File Offset: 0x0077E7DB
		public int PlotLineId { get; set; }

		// Token: 0x1700E84B RID: 59467
		// (get) Token: 0x06037DDF RID: 228831 RVA: 0x007805E4 File Offset: 0x0077E7E4
		// (set) Token: 0x06037DE0 RID: 228832 RVA: 0x007805EC File Offset: 0x0077E7EC
		public string PlotLineKey { get; set; }

		// Token: 0x1700E84C RID: 59468
		// (get) Token: 0x06037DE1 RID: 228833 RVA: 0x007805F5 File Offset: 0x0077E7F5
		// (set) Token: 0x06037DE2 RID: 228834 RVA: 0x007805FD File Offset: 0x0077E7FD
		public string Name { get; set; }

		// Token: 0x1700E84D RID: 59469
		// (get) Token: 0x06037DE3 RID: 228835 RVA: 0x00780606 File Offset: 0x0077E806
		// (set) Token: 0x06037DE4 RID: 228836 RVA: 0x0078060E File Offset: 0x0077E80E
		public bool _Folded { get; set; }

		// Token: 0x1700E84E RID: 59470
		// (get) Token: 0x06037DE5 RID: 228837 RVA: 0x00780617 File Offset: 0x0077E817
		// (set) Token: 0x06037DE6 RID: 228838 RVA: 0x0078061F File Offset: 0x0077E81F
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700E84F RID: 59471
		// (get) Token: 0x06037DE7 RID: 228839 RVA: 0x00780628 File Offset: 0x0077E828
		// (set) Token: 0x06037DE8 RID: 228840 RVA: 0x00780630 File Offset: 0x0077E830
		public int WhoId { get; set; }

		// Token: 0x1700E850 RID: 59472
		// (get) Token: 0x06037DE9 RID: 228841 RVA: 0x00780639 File Offset: 0x0077E839
		// (set) Token: 0x06037DEA RID: 228842 RVA: 0x00780641 File Offset: 0x0077E841
		public int TextId { get; set; }

		// Token: 0x1700E851 RID: 59473
		// (get) Token: 0x06037DEB RID: 228843 RVA: 0x0078064A File Offset: 0x0077E84A
		// (set) Token: 0x06037DEC RID: 228844 RVA: 0x00780652 File Offset: 0x0077E852
		public string TidTalk { get; set; }

		// Token: 0x1700E852 RID: 59474
		// (get) Token: 0x06037DED RID: 228845 RVA: 0x0078065B File Offset: 0x0077E85B
		// (set) Token: 0x06037DEE RID: 228846 RVA: 0x00780663 File Offset: 0x0077E863
		public float WaitTime { get; set; }

		// Token: 0x1700E853 RID: 59475
		// (get) Token: 0x06037DEF RID: 228847 RVA: 0x0078066C File Offset: 0x0077E86C
		// (set) Token: 0x06037DF0 RID: 228848 RVA: 0x00780674 File Offset: 0x0077E874
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700E854 RID: 59476
		// (get) Token: 0x06037DF1 RID: 228849 RVA: 0x0078067D File Offset: 0x0077E87D
		// (set) Token: 0x06037DF2 RID: 228850 RVA: 0x00780685 File Offset: 0x0077E885
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700E855 RID: 59477
		// (get) Token: 0x06037DF3 RID: 228851 RVA: 0x0078068E File Offset: 0x0077E88E
		// (set) Token: 0x06037DF4 RID: 228852 RVA: 0x00780696 File Offset: 0x0077E896
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700E856 RID: 59478
		// (get) Token: 0x06037DF5 RID: 228853 RVA: 0x0078069F File Offset: 0x0077E89F
		// (set) Token: 0x06037DF6 RID: 228854 RVA: 0x007806A7 File Offset: 0x0077E8A7
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700E857 RID: 59479
		// (get) Token: 0x06037DF7 RID: 228855 RVA: 0x007806B0 File Offset: 0x0077E8B0
		// (set) Token: 0x06037DF8 RID: 228856 RVA: 0x007806B8 File Offset: 0x0077E8B8
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700E858 RID: 59480
		// (get) Token: 0x06037DF9 RID: 228857 RVA: 0x007806C1 File Offset: 0x0077E8C1
		// (set) Token: 0x06037DFA RID: 228858 RVA: 0x007806C9 File Offset: 0x0077E8C9
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700E859 RID: 59481
		// (get) Token: 0x06037DFB RID: 228859 RVA: 0x007806D2 File Offset: 0x0077E8D2
		// (set) Token: 0x06037DFC RID: 228860 RVA: 0x007806DA File Offset: 0x0077E8DA
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700E85A RID: 59482
		// (get) Token: 0x06037DFD RID: 228861 RVA: 0x007806E3 File Offset: 0x0077E8E3
		// (set) Token: 0x06037DFE RID: 228862 RVA: 0x007806EB File Offset: 0x0077E8EB
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700E85B RID: 59483
		// (get) Token: 0x06037DFF RID: 228863 RVA: 0x007806F4 File Offset: 0x0077E8F4
		// (set) Token: 0x06037E00 RID: 228864 RVA: 0x007806FC File Offset: 0x0077E8FC
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700E85C RID: 59484
		// (get) Token: 0x06037E01 RID: 228865 RVA: 0x00780705 File Offset: 0x0077E905
		// (set) Token: 0x06037E02 RID: 228866 RVA: 0x0078070D File Offset: 0x0077E90D
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700E85D RID: 59485
		// (get) Token: 0x06037E03 RID: 228867 RVA: 0x00780716 File Offset: 0x0077E916
		// (set) Token: 0x06037E04 RID: 228868 RVA: 0x0078071E File Offset: 0x0077E91E
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700E85E RID: 59486
		// (get) Token: 0x06037E05 RID: 228869 RVA: 0x00780727 File Offset: 0x0077E927
		// (set) Token: 0x06037E06 RID: 228870 RVA: 0x0078072F File Offset: 0x0077E92F
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700E85F RID: 59487
		// (get) Token: 0x06037E07 RID: 228871 RVA: 0x00780738 File Offset: 0x0077E938
		// (set) Token: 0x06037E08 RID: 228872 RVA: 0x00780740 File Offset: 0x0077E940
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700E860 RID: 59488
		// (get) Token: 0x06037E09 RID: 228873 RVA: 0x00780749 File Offset: 0x0077E949
		// (set) Token: 0x06037E0A RID: 228874 RVA: 0x00780751 File Offset: 0x0077E951
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700E861 RID: 59489
		// (get) Token: 0x06037E0B RID: 228875 RVA: 0x0078075A File Offset: 0x0077E95A
		// (set) Token: 0x06037E0C RID: 228876 RVA: 0x00780762 File Offset: 0x0077E962
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700E862 RID: 59490
		// (get) Token: 0x06037E0D RID: 228877 RVA: 0x0078076B File Offset: 0x0077E96B
		// (set) Token: 0x06037E0E RID: 228878 RVA: 0x00780773 File Offset: 0x0077E973
		public bool PlayVoice { get; set; }

		// Token: 0x1700E863 RID: 59491
		// (get) Token: 0x06037E0F RID: 228879 RVA: 0x0078077C File Offset: 0x0077E97C
		// (set) Token: 0x06037E10 RID: 228880 RVA: 0x00780784 File Offset: 0x0077E984
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700E864 RID: 59492
		// (get) Token: 0x06037E11 RID: 228881 RVA: 0x0078078D File Offset: 0x0077E98D
		// (set) Token: 0x06037E12 RID: 228882 RVA: 0x00780795 File Offset: 0x0077E995
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700E865 RID: 59493
		// (get) Token: 0x06037E13 RID: 228883 RVA: 0x0078079E File Offset: 0x0077E99E
		// (set) Token: 0x06037E14 RID: 228884 RVA: 0x007807A6 File Offset: 0x0077E9A6
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700E866 RID: 59494
		// (get) Token: 0x06037E15 RID: 228885 RVA: 0x007807AF File Offset: 0x0077E9AF
		// (set) Token: 0x06037E16 RID: 228886 RVA: 0x007807B7 File Offset: 0x0077E9B7
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700E867 RID: 59495
		// (get) Token: 0x06037E17 RID: 228887 RVA: 0x007807C0 File Offset: 0x0077E9C0
		// (set) Token: 0x06037E18 RID: 228888 RVA: 0x007807C8 File Offset: 0x0077E9C8
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700E868 RID: 59496
		// (get) Token: 0x06037E19 RID: 228889 RVA: 0x007807D1 File Offset: 0x0077E9D1
		// (set) Token: 0x06037E1A RID: 228890 RVA: 0x007807D9 File Offset: 0x0077E9D9
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700E869 RID: 59497
		// (get) Token: 0x06037E1B RID: 228891 RVA: 0x007807E2 File Offset: 0x0077E9E2
		// (set) Token: 0x06037E1C RID: 228892 RVA: 0x007807EA File Offset: 0x0077E9EA
		public TTalkItemStyleUnion Style { get; set; }

		// Token: 0x1700E86A RID: 59498
		// (get) Token: 0x06037E1D RID: 228893 RVA: 0x007807F3 File Offset: 0x0077E9F3
		// (set) Token: 0x06037E1E RID: 228894 RVA: 0x007807FB File Offset: 0x0077E9FB
		public TShowTalkCameraMotionUnion CameraMotion { get; set; }

		// Token: 0x1700E86B RID: 59499
		// (get) Token: 0x06037E1F RID: 228895 RVA: 0x00780804 File Offset: 0x0077EA04
		// (set) Token: 0x06037E20 RID: 228896 RVA: 0x0078080C File Offset: 0x0077EA0C
		public ITalkItemAutoPlayConfigT AutoPlayConfig { get; set; }

		// Token: 0x1700E86C RID: 59500
		// (get) Token: 0x06037E21 RID: 228897 RVA: 0x00780815 File Offset: 0x0077EA15
		// (set) Token: 0x06037E22 RID: 228898 RVA: 0x0078081D File Offset: 0x0077EA1D
		public bool NoMouthAnim { get; set; }

		// Token: 0x1700E86D RID: 59501
		// (get) Token: 0x06037E23 RID: 228899 RVA: 0x00780826 File Offset: 0x0077EA26
		// (set) Token: 0x06037E24 RID: 228900 RVA: 0x0078082E File Offset: 0x0077EA2E
		public float OtherIsTypingDuration { get; set; }

		// Token: 0x1700E86E RID: 59502
		// (get) Token: 0x06037E25 RID: 228901 RVA: 0x00780837 File Offset: 0x0077EA37
		// (set) Token: 0x06037E26 RID: 228902 RVA: 0x0078083F File Offset: 0x0077EA3F
		public uint NullMask { get; set; }

		// Token: 0x06037E27 RID: 228903 RVA: 0x00780848 File Offset: 0x0077EA48
		public ITalkItemDialogT()
		{
			this.Type = ETalkItemType.Talk;
			this.Id = 0;
			this.PlotLineId = 0;
			this.PlotLineKey = null;
			this.Name = null;
			this._Folded = false;
			this._EditFlag = EEditFlag.Add;
			this.WhoId = 0;
			this.TextId = 0;
			this.TidTalk = null;
			this.WaitTime = 0f;
			this.CaptionParams = null;
			this.Actions = null;
			this.Options = null;
			this.Montage = null;
			this.CameraData = null;
			this.FlowTemplate = null;
			this.FlowTemplateList = null;
			this.ActorMontageArray = null;
			this.ActorFaceExpressionArray = null;
			this.ActorLookAtArray = null;
			this.ActorTurnToArray = null;
			this.TalkAkEvent = null;
			this.TalkEndAkEvent = null;
			this.UniversalTone = null;
			this.BackgroundConfig = null;
			this.PlayVoice = false;
			this.TimeLimitOptionGroup = null;
			this.GamepadShake = null;
			this.IntroActions = null;
			this.ActorFxEmoteArray = null;
			this.TalkEffectArray = null;
			this.ActorVisibilityArray = null;
			this.Style = null;
			this.CameraMotion = null;
			this.AutoPlayConfig = null;
			this.NoMouthAnim = false;
			this.OtherIsTypingDuration = 0f;
			this.NullMask = 0U;
		}
	}
}

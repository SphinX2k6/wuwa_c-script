using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004339 RID: 17209
	public class TWarningPreformConfigUnion
	{
		// Token: 0x17007988 RID: 31112
		// (get) Token: 0x0601983B RID: 104507 RVA: 0x003A7708 File Offset: 0x003A5908
		// (set) Token: 0x0601983C RID: 104508 RVA: 0x003A7710 File Offset: 0x003A5910
		public TWarningPreformConfig Type { get; set; }

		// Token: 0x17007989 RID: 31113
		// (get) Token: 0x0601983D RID: 104509 RVA: 0x003A7719 File Offset: 0x003A5919
		// (set) Token: 0x0601983E RID: 104510 RVA: 0x003A7721 File Offset: 0x003A5921
		public object Value { get; set; }

		// Token: 0x0601983F RID: 104511 RVA: 0x003A772A File Offset: 0x003A592A
		public TWarningPreformConfigUnion()
		{
			this.Type = TWarningPreformConfig.NONE;
			this.Value = null;
		}

		// Token: 0x06019840 RID: 104512 RVA: 0x003A7740 File Offset: 0x003A5940
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019841 RID: 104513 RVA: 0x003A7752 File Offset: 0x003A5952
		public IWarningPreformActivateStateRecordEntityT AsIWarningPreformActivateStateRecordEntity()
		{
			return this.As<IWarningPreformActivateStateRecordEntityT>();
		}

		// Token: 0x06019842 RID: 104514 RVA: 0x003A775A File Offset: 0x003A595A
		public static TWarningPreformConfigUnion FromIWarningPreformActivateStateRecordEntity(IWarningPreformActivateStateRecordEntityT _iwarningpreformactivatestaterecordentity)
		{
			return new TWarningPreformConfigUnion
			{
				Type = TWarningPreformConfig.IWarningPreformActivateStateRecordEntity,
				Value = _iwarningpreformactivatestaterecordentity
			};
		}

		// Token: 0x06019843 RID: 104515 RVA: 0x003A776F File Offset: 0x003A596F
		public IWarningPreformFadeInScreenT AsIWarningPreformFadeInScreen()
		{
			return this.As<IWarningPreformFadeInScreenT>();
		}

		// Token: 0x06019844 RID: 104516 RVA: 0x003A7777 File Offset: 0x003A5977
		public static TWarningPreformConfigUnion FromIWarningPreformFadeInScreen(IWarningPreformFadeInScreenT _iwarningpreformfadeinscreen)
		{
			return new TWarningPreformConfigUnion
			{
				Type = TWarningPreformConfig.IWarningPreformFadeInScreen,
				Value = _iwarningpreformfadeinscreen
			};
		}

		// Token: 0x06019845 RID: 104517 RVA: 0x003A778C File Offset: 0x003A598C
		public static int Pack(FlatBufferBuilder builder, TWarningPreformConfigUnion _o)
		{
			TWarningPreformConfig type = _o.Type;
			if (type == TWarningPreformConfig.IWarningPreformActivateStateRecordEntity)
			{
				return IWarningPreformActivateStateRecordEntity.Pack(builder, _o.AsIWarningPreformActivateStateRecordEntity()).Value;
			}
			if (type != TWarningPreformConfig.IWarningPreformFadeInScreen)
			{
				return 0;
			}
			return IWarningPreformFadeInScreen.Pack(builder, _o.AsIWarningPreformFadeInScreen()).Value;
		}
	}
}

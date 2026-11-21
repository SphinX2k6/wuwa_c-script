using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045D2 RID: 17874
	public class ITakePhoto2ModeBase_UnionUnion
	{
		// Token: 0x17007D00 RID: 32000
		// (get) Token: 0x0601A1A3 RID: 106915 RVA: 0x003B8441 File Offset: 0x003B6641
		// (set) Token: 0x0601A1A4 RID: 106916 RVA: 0x003B8449 File Offset: 0x003B6649
		public ITakePhoto2ModeBase_Union Type { get; set; }

		// Token: 0x17007D01 RID: 32001
		// (get) Token: 0x0601A1A5 RID: 106917 RVA: 0x003B8452 File Offset: 0x003B6652
		// (set) Token: 0x0601A1A6 RID: 106918 RVA: 0x003B845A File Offset: 0x003B665A
		public object Value { get; set; }

		// Token: 0x0601A1A7 RID: 106919 RVA: 0x003B8463 File Offset: 0x003B6663
		public ITakePhoto2ModeBase_UnionUnion()
		{
			this.Type = ITakePhoto2ModeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601A1A8 RID: 106920 RVA: 0x003B8479 File Offset: 0x003B6679
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601A1A9 RID: 106921 RVA: 0x003B848B File Offset: 0x003B668B
		public ITakePhoto2ModeBaseT AsITakePhoto2ModeBase()
		{
			return this.As<ITakePhoto2ModeBaseT>();
		}

		// Token: 0x0601A1AA RID: 106922 RVA: 0x003B8493 File Offset: 0x003B6693
		public static ITakePhoto2ModeBase_UnionUnion FromITakePhoto2ModeBase(ITakePhoto2ModeBaseT _itakephoto2modebase)
		{
			return new ITakePhoto2ModeBase_UnionUnion
			{
				Type = ITakePhoto2ModeBase_Union.ITakePhoto2ModeBase,
				Value = _itakephoto2modebase
			};
		}

		// Token: 0x0601A1AB RID: 106923 RVA: 0x003B84A8 File Offset: 0x003B66A8
		public ITakePhoto2BeforeYourEyesModeT AsITakePhoto2BeforeYourEyesMode()
		{
			return this.As<ITakePhoto2BeforeYourEyesModeT>();
		}

		// Token: 0x0601A1AC RID: 106924 RVA: 0x003B84B0 File Offset: 0x003B66B0
		public static ITakePhoto2ModeBase_UnionUnion FromITakePhoto2BeforeYourEyesMode(ITakePhoto2BeforeYourEyesModeT _itakephoto2beforeyoureyesmode)
		{
			return new ITakePhoto2ModeBase_UnionUnion
			{
				Type = ITakePhoto2ModeBase_Union.ITakePhoto2BeforeYourEyesMode,
				Value = _itakephoto2beforeyoureyesmode
			};
		}

		// Token: 0x0601A1AD RID: 106925 RVA: 0x003B84C8 File Offset: 0x003B66C8
		public static int Pack(FlatBufferBuilder builder, ITakePhoto2ModeBase_UnionUnion _o)
		{
			ITakePhoto2ModeBase_Union type = _o.Type;
			if (type == ITakePhoto2ModeBase_Union.ITakePhoto2ModeBase)
			{
				return ITakePhoto2ModeBase.Pack(builder, _o.AsITakePhoto2ModeBase()).Value;
			}
			if (type != ITakePhoto2ModeBase_Union.ITakePhoto2BeforeYourEyesMode)
			{
				return 0;
			}
			return ITakePhoto2BeforeYourEyesMode.Pack(builder, _o.AsITakePhoto2BeforeYourEyesMode()).Value;
		}
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007654 RID: 30292
	public class TCameraOperationUnion
	{
		// Token: 0x1700E5CB RID: 58827
		// (get) Token: 0x06037270 RID: 225904 RVA: 0x0077A4D6 File Offset: 0x007786D6
		// (set) Token: 0x06037271 RID: 225905 RVA: 0x0077A4DE File Offset: 0x007786DE
		public TCameraOperation Type { get; set; }

		// Token: 0x1700E5CC RID: 58828
		// (get) Token: 0x06037272 RID: 225906 RVA: 0x0077A4E7 File Offset: 0x007786E7
		// (set) Token: 0x06037273 RID: 225907 RVA: 0x0077A4EF File Offset: 0x007786EF
		public object Value { get; set; }

		// Token: 0x06037274 RID: 225908 RVA: 0x0077A4F8 File Offset: 0x007786F8
		public TCameraOperationUnion()
		{
			this.Type = TCameraOperation.NONE;
			this.Value = null;
		}

		// Token: 0x06037275 RID: 225909 RVA: 0x0077A50E File Offset: 0x0077870E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037276 RID: 225910 RVA: 0x0077A520 File Offset: 0x00778720
		public IDisableCameraOperationT AsIDisableCameraOperation()
		{
			return this.As<IDisableCameraOperationT>();
		}

		// Token: 0x06037277 RID: 225911 RVA: 0x0077A528 File Offset: 0x00778728
		public static TCameraOperationUnion FromIDisableCameraOperation(IDisableCameraOperationT _idisablecameraoperation)
		{
			return new TCameraOperationUnion
			{
				Type = TCameraOperation.IDisableCameraOperation,
				Value = _idisablecameraoperation
			};
		}

		// Token: 0x06037278 RID: 225912 RVA: 0x0077A53D File Offset: 0x0077873D
		public IEnableCameraOperationT AsIEnableCameraOperation()
		{
			return this.As<IEnableCameraOperationT>();
		}

		// Token: 0x06037279 RID: 225913 RVA: 0x0077A545 File Offset: 0x00778745
		public static TCameraOperationUnion FromIEnableCameraOperation(IEnableCameraOperationT _ienablecameraoperation)
		{
			return new TCameraOperationUnion
			{
				Type = TCameraOperation.IEnableCameraOperation,
				Value = _ienablecameraoperation
			};
		}

		// Token: 0x0603727A RID: 225914 RVA: 0x0077A55A File Offset: 0x0077875A
		public IEnableSectionalCameraOperationT AsIEnableSectionalCameraOperation()
		{
			return this.As<IEnableSectionalCameraOperationT>();
		}

		// Token: 0x0603727B RID: 225915 RVA: 0x0077A562 File Offset: 0x00778762
		public static TCameraOperationUnion FromIEnableSectionalCameraOperation(IEnableSectionalCameraOperationT _ienablesectionalcameraoperation)
		{
			return new TCameraOperationUnion
			{
				Type = TCameraOperation.IEnableSectionalCameraOperation,
				Value = _ienablesectionalcameraoperation
			};
		}

		// Token: 0x0603727C RID: 225916 RVA: 0x0077A578 File Offset: 0x00778778
		public static int Pack(FlatBufferBuilder builder, TCameraOperationUnion _o)
		{
			switch (_o.Type)
			{
			case TCameraOperation.IDisableCameraOperation:
				return IDisableCameraOperation.Pack(builder, _o.AsIDisableCameraOperation()).Value;
			case TCameraOperation.IEnableCameraOperation:
				return IEnableCameraOperation.Pack(builder, _o.AsIEnableCameraOperation()).Value;
			case TCameraOperation.IEnableSectionalCameraOperation:
				return IEnableSectionalCameraOperation.Pack(builder, _o.AsIEnableSectionalCameraOperation()).Value;
			default:
				return 0;
			}
		}
	}
}

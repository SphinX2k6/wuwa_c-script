using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072C1 RID: 29377
	[NullableContext(1)]
	[Nullable(0)]
	public class CameraAbsoluteNearClipAction : ICameraNearClipAction<CameraAbsoluteNearClipConfig>
	{
		// Token: 0x0604811C RID: 295196 RVA: 0x0127AB3E File Offset: 0x01278D3E
		public CameraAbsoluteNearClipAction(int id, CameraAbsoluteNearClipConfig nearClipConfig)
		{
		}

		// Token: 0x17009F2E RID: 40750
		// (get) Token: 0x0604811D RID: 295197 RVA: 0x0127AB54 File Offset: 0x01278D54
		public CameraAbsoluteNearClipConfig NearClipConfig
		{
			get
			{
				return this.<nearClipConfig>P;
			}
		} = nearClipConfig;

		// Token: 0x0604811E RID: 295198 RVA: 0x0127AB5C File Offset: 0x01278D5C
		public unsafe void Start()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[CameraNearClip][CameraAbsoluteNearClipAction]Start";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Type", this.<nearClipConfig>P.NearClipType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Distance", this.<nearClipConfig>P.Distance.ToString("F2"));
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			UKuroCameraFunctionLibrary.DelaySetNearClipPlane(this.<nearClipConfig>P.Distance);
		}

		// Token: 0x0604811F RID: 295199 RVA: 0x0127AC11 File Offset: 0x01278E11
		public bool IsPause()
		{
			return this.IsPauseState;
		}

		// Token: 0x06048120 RID: 295200 RVA: 0x0127AC1C File Offset: 0x01278E1C
		public unsafe void Pause()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[CameraNearClip][CameraAbsoluteNearClipAction]Pause";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Type", this.<nearClipConfig>P.NearClipType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Distance", this.<nearClipConfig>P.Distance.ToString("F2"));
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			this.IsPauseState = true;
		}

		// Token: 0x06048121 RID: 295201 RVA: 0x0127ACC8 File Offset: 0x01278EC8
		public unsafe void Resume()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[CameraNearClip][CameraAbsoluteNearClipAction]Resume";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Type", this.<nearClipConfig>P.NearClipType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Distance", this.<nearClipConfig>P.Distance.ToString("F2"));
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			this.IsPauseState = false;
			UKuroCameraFunctionLibrary.DelaySetNearClipPlane(this.<nearClipConfig>P.Distance);
		}

		// Token: 0x06048122 RID: 295202 RVA: 0x0127AD84 File Offset: 0x01278F84
		public unsafe void End()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[CameraNearClip][CameraAbsoluteNearClipAction]End";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Type", this.<nearClipConfig>P.NearClipType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Distance", this.<nearClipConfig>P.Distance.ToString("F2"));
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}

		// Token: 0x04026061 RID: 155745
		[CompilerGenerated]
		private CameraAbsoluteNearClipConfig <nearClipConfig>P;

		// Token: 0x04026062 RID: 155746
		public readonly int Id = id;

		// Token: 0x04026063 RID: 155747
		private bool IsPauseState;
	}
}

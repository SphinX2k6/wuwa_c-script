using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000162 RID: 354
	[NetMessage(EMessageId.BathChangeCameraRequest)]
	public sealed class BathChangeCameraRequest : IMessage<BathChangeCameraRequest>, IMessage, IEquatable<BathChangeCameraRequest>, IDeepCloneable<BathChangeCameraRequest>, IBufferMessage
	{
		// Token: 0x06002C43 RID: 11331 RVA: 0x00073462 File Offset: 0x00071662
		[NullableContext(1)]
		public static BathChangeCameraRequest Create()
		{
			return new BathChangeCameraRequest();
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06002C44 RID: 11332 RVA: 0x00073469 File Offset: 0x00071669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06002C45 RID: 11333 RVA: 0x0007346C File Offset: 0x0007166C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BathChangeCameraRequest.Descriptor;
			}
		}

		// Token: 0x06002C46 RID: 11334 RVA: 0x00073473 File Offset: 0x00071673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BathChangeCameraRequest()
		{
		}

		// Token: 0x06002C47 RID: 11335 RVA: 0x0007347B File Offset: 0x0007167B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BathChangeCameraRequest(BathChangeCameraRequest other) : this()
		{
			this.camera_ = other.camera_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002C48 RID: 11336 RVA: 0x000734A0 File Offset: 0x000716A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BathChangeCameraRequest Clone()
		{
			return new BathChangeCameraRequest(this);
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06002C49 RID: 11337 RVA: 0x000734A8 File Offset: 0x000716A8
		// (set) Token: 0x06002C4A RID: 11338 RVA: 0x000734B0 File Offset: 0x000716B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BathCameraType Camera
		{
			get
			{
				return this.camera_;
			}
			set
			{
				this.camera_ = value;
			}
		}

		// Token: 0x06002C4B RID: 11339 RVA: 0x000734B9 File Offset: 0x000716B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BathChangeCameraRequest);
		}

		// Token: 0x06002C4C RID: 11340 RVA: 0x000734C7 File Offset: 0x000716C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BathChangeCameraRequest other)
		{
			return other != null && (other == this || (this.Camera == other.Camera && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002C4D RID: 11341 RVA: 0x000734F8 File Offset: 0x000716F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Camera != BathCameraType.Third)
			{
				num ^= this.Camera.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002C4E RID: 11342 RVA: 0x0007353D File Offset: 0x0007173D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002C4F RID: 11343 RVA: 0x0007354A File Offset: 0x0007174A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002C50 RID: 11344 RVA: 0x00073553 File Offset: 0x00071753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Camera != BathCameraType.Third)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Camera);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002C51 RID: 11345 RVA: 0x00073588 File Offset: 0x00071788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Camera != BathCameraType.Third)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Camera);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002C52 RID: 11346 RVA: 0x000735C6 File Offset: 0x000717C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BathChangeCameraRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Camera != BathCameraType.Third)
			{
				this.Camera = other.Camera;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002C53 RID: 11347 RVA: 0x000735F7 File Offset: 0x000717F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002C54 RID: 11348 RVA: 0x00073600 File Offset: 0x00071800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Camera = (BathCameraType)input.ReadEnum();
				}
			}
		}

		// Token: 0x040027EF RID: 10223
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027F0 RID: 10224
		public const int CameraFieldNumber = 4;

		// Token: 0x040027F1 RID: 10225
		private BathCameraType camera_;
	}
}

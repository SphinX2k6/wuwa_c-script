using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000165 RID: 357
	[NetMessage(EMessageId.BathChangeCameraRequest)]
	public sealed class BathChangeCameraRequest : IMessage<BathChangeCameraRequest>, IMessage, IEquatable<BathChangeCameraRequest>, IDeepCloneable<BathChangeCameraRequest>, IBufferMessage
	{
		// Token: 0x06002CBA RID: 11450 RVA: 0x00074892 File Offset: 0x00072A92
		[NullableContext(1)]
		public static BathChangeCameraRequest Create()
		{
			return new BathChangeCameraRequest();
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06002CBB RID: 11451 RVA: 0x00074899 File Offset: 0x00072A99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06002CBC RID: 11452 RVA: 0x0007489C File Offset: 0x00072A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BathChangeCameraRequest.Descriptor;
			}
		}

		// Token: 0x06002CBD RID: 11453 RVA: 0x000748A3 File Offset: 0x00072AA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BathChangeCameraRequest()
		{
		}

		// Token: 0x06002CBE RID: 11454 RVA: 0x000748AB File Offset: 0x00072AAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BathChangeCameraRequest(BathChangeCameraRequest other) : this()
		{
			this.camera_ = other.camera_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002CBF RID: 11455 RVA: 0x000748D0 File Offset: 0x00072AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BathChangeCameraRequest Clone()
		{
			return new BathChangeCameraRequest(this);
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06002CC0 RID: 11456 RVA: 0x000748D8 File Offset: 0x00072AD8
		// (set) Token: 0x06002CC1 RID: 11457 RVA: 0x000748E0 File Offset: 0x00072AE0
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

		// Token: 0x06002CC2 RID: 11458 RVA: 0x000748E9 File Offset: 0x00072AE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BathChangeCameraRequest);
		}

		// Token: 0x06002CC3 RID: 11459 RVA: 0x000748F7 File Offset: 0x00072AF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BathChangeCameraRequest other)
		{
			return other != null && (other == this || (this.Camera == other.Camera && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002CC4 RID: 11460 RVA: 0x00074928 File Offset: 0x00072B28
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

		// Token: 0x06002CC5 RID: 11461 RVA: 0x0007496D File Offset: 0x00072B6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002CC6 RID: 11462 RVA: 0x0007497A File Offset: 0x00072B7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002CC7 RID: 11463 RVA: 0x00074983 File Offset: 0x00072B83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Camera != BathCameraType.Third)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Camera);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002CC8 RID: 11464 RVA: 0x000749B8 File Offset: 0x00072BB8
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

		// Token: 0x06002CC9 RID: 11465 RVA: 0x000749F6 File Offset: 0x00072BF6
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

		// Token: 0x06002CCA RID: 11466 RVA: 0x00074A27 File Offset: 0x00072C27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002CCB RID: 11467 RVA: 0x00074A30 File Offset: 0x00072C30
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Camera = (BathCameraType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002863 RID: 10339
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002864 RID: 10340
		public const int CameraFieldNumber = 15;

		// Token: 0x04002865 RID: 10341
		private BathCameraType camera_;
	}
}

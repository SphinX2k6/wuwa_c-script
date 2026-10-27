using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003CC RID: 972
	[NetMessage(EMessageId.DetectionInvisibleNotify)]
	public sealed class DetectionInvisibleNotify : IMessage<DetectionInvisibleNotify>, IMessage, IEquatable<DetectionInvisibleNotify>, IDeepCloneable<DetectionInvisibleNotify>, IBufferMessage
	{
		// Token: 0x06005ED7 RID: 24279 RVA: 0x000E58F3 File Offset: 0x000E3AF3
		[NullableContext(1)]
		public static DetectionInvisibleNotify Create()
		{
			return new DetectionInvisibleNotify();
		}

		// Token: 0x1700119E RID: 4510
		// (get) Token: 0x06005ED8 RID: 24280 RVA: 0x000E58FA File Offset: 0x000E3AFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700119F RID: 4511
		// (get) Token: 0x06005ED9 RID: 24281 RVA: 0x000E58FD File Offset: 0x000E3AFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DetectionInvisibleNotify.Descriptor;
			}
		}

		// Token: 0x06005EDA RID: 24282 RVA: 0x000E5904 File Offset: 0x000E3B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionInvisibleNotify()
		{
		}

		// Token: 0x06005EDB RID: 24283 RVA: 0x000E590C File Offset: 0x000E3B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionInvisibleNotify(DetectionInvisibleNotify other) : this()
		{
			this.targetChange_ = ((other.targetChange_ != null) ? other.targetChange_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005EDC RID: 24284 RVA: 0x000E5941 File Offset: 0x000E3B41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionInvisibleNotify Clone()
		{
			return new DetectionInvisibleNotify(this);
		}

		// Token: 0x170011A0 RID: 4512
		// (get) Token: 0x06005EDD RID: 24285 RVA: 0x000E5949 File Offset: 0x000E3B49
		// (set) Token: 0x06005EDE RID: 24286 RVA: 0x000E5951 File Offset: 0x000E3B51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionTarget TargetChange
		{
			get
			{
				return this.targetChange_;
			}
			set
			{
				this.targetChange_ = value;
			}
		}

		// Token: 0x06005EDF RID: 24287 RVA: 0x000E595A File Offset: 0x000E3B5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DetectionInvisibleNotify);
		}

		// Token: 0x06005EE0 RID: 24288 RVA: 0x000E5968 File Offset: 0x000E3B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DetectionInvisibleNotify other)
		{
			return other != null && (other == this || (object.Equals(this.TargetChange, other.TargetChange) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005EE1 RID: 24289 RVA: 0x000E599C File Offset: 0x000E3B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.targetChange_ != null)
			{
				num ^= this.TargetChange.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005EE2 RID: 24290 RVA: 0x000E59D8 File Offset: 0x000E3BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005EE3 RID: 24291 RVA: 0x000E59E5 File Offset: 0x000E3BE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005EE4 RID: 24292 RVA: 0x000E59EE File Offset: 0x000E3BEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.targetChange_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.TargetChange);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005EE5 RID: 24293 RVA: 0x000E5A20 File Offset: 0x000E3C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.targetChange_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetChange);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005EE6 RID: 24294 RVA: 0x000E5A60 File Offset: 0x000E3C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DetectionInvisibleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.targetChange_ != null)
			{
				if (this.targetChange_ == null)
				{
					this.TargetChange = new DetectionTarget();
				}
				this.TargetChange.MergeFrom(other.TargetChange);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005EE7 RID: 24295 RVA: 0x000E5AB4 File Offset: 0x000E3CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005EE8 RID: 24296 RVA: 0x000E5AC0 File Offset: 0x000E3CC0
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.targetChange_ == null)
					{
						this.TargetChange = new DetectionTarget();
					}
					input.ReadMessage(this.TargetChange);
				}
			}
		}

		// Token: 0x040036E3 RID: 14051
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036E4 RID: 14052
		public const int TargetChangeFieldNumber = 15;

		// Token: 0x040036E5 RID: 14053
		private DetectionTarget targetChange_;
	}
}

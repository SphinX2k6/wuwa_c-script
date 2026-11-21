using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003B5 RID: 949
	[NetMessage(EMessageId.DetectionInvisibleNotify)]
	public sealed class DetectionInvisibleNotify : IMessage<DetectionInvisibleNotify>, IMessage, IEquatable<DetectionInvisibleNotify>, IDeepCloneable<DetectionInvisibleNotify>, IBufferMessage
	{
		// Token: 0x06005D47 RID: 23879 RVA: 0x000E276F File Offset: 0x000E096F
		[NullableContext(1)]
		public static DetectionInvisibleNotify Create()
		{
			return new DetectionInvisibleNotify();
		}

		// Token: 0x17001149 RID: 4425
		// (get) Token: 0x06005D48 RID: 23880 RVA: 0x000E2776 File Offset: 0x000E0976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700114A RID: 4426
		// (get) Token: 0x06005D49 RID: 23881 RVA: 0x000E2779 File Offset: 0x000E0979
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DetectionInvisibleNotify.Descriptor;
			}
		}

		// Token: 0x06005D4A RID: 23882 RVA: 0x000E2780 File Offset: 0x000E0980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionInvisibleNotify()
		{
		}

		// Token: 0x06005D4B RID: 23883 RVA: 0x000E2788 File Offset: 0x000E0988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionInvisibleNotify(DetectionInvisibleNotify other) : this()
		{
			this.targetChange_ = ((other.targetChange_ != null) ? other.targetChange_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005D4C RID: 23884 RVA: 0x000E27BD File Offset: 0x000E09BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionInvisibleNotify Clone()
		{
			return new DetectionInvisibleNotify(this);
		}

		// Token: 0x1700114B RID: 4427
		// (get) Token: 0x06005D4D RID: 23885 RVA: 0x000E27C5 File Offset: 0x000E09C5
		// (set) Token: 0x06005D4E RID: 23886 RVA: 0x000E27CD File Offset: 0x000E09CD
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

		// Token: 0x06005D4F RID: 23887 RVA: 0x000E27D6 File Offset: 0x000E09D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DetectionInvisibleNotify);
		}

		// Token: 0x06005D50 RID: 23888 RVA: 0x000E27E4 File Offset: 0x000E09E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DetectionInvisibleNotify other)
		{
			return other != null && (other == this || (object.Equals(this.TargetChange, other.TargetChange) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005D51 RID: 23889 RVA: 0x000E2818 File Offset: 0x000E0A18
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

		// Token: 0x06005D52 RID: 23890 RVA: 0x000E2854 File Offset: 0x000E0A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005D53 RID: 23891 RVA: 0x000E2861 File Offset: 0x000E0A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005D54 RID: 23892 RVA: 0x000E286A File Offset: 0x000E0A6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.targetChange_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.TargetChange);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005D55 RID: 23893 RVA: 0x000E289C File Offset: 0x000E0A9C
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

		// Token: 0x06005D56 RID: 23894 RVA: 0x000E28DC File Offset: 0x000E0ADC
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

		// Token: 0x06005D57 RID: 23895 RVA: 0x000E2930 File Offset: 0x000E0B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005D58 RID: 23896 RVA: 0x000E293C File Offset: 0x000E0B3C
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
				if (num != 74U)
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

		// Token: 0x040036D0 RID: 14032
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036D1 RID: 14033
		public const int TargetChangeFieldNumber = 9;

		// Token: 0x040036D2 RID: 14034
		private DetectionTarget targetChange_;
	}
}

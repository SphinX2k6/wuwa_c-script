using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011FA RID: 4602
	[NetMessage(EMessageId.SelectDetectionTargetResponse)]
	public sealed class SelectDetectionTargetResponse : IMessage<SelectDetectionTargetResponse>, IMessage, IEquatable<SelectDetectionTargetResponse>, IDeepCloneable<SelectDetectionTargetResponse>, IBufferMessage
	{
		// Token: 0x06018993 RID: 100755 RVA: 0x00396D03 File Offset: 0x00394F03
		[NullableContext(1)]
		public static SelectDetectionTargetResponse Create()
		{
			return new SelectDetectionTargetResponse();
		}

		// Token: 0x1700531C RID: 21276
		// (get) Token: 0x06018994 RID: 100756 RVA: 0x00396D0A File Offset: 0x00394F0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700531D RID: 21277
		// (get) Token: 0x06018995 RID: 100757 RVA: 0x00396D0D File Offset: 0x00394F0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelectDetectionTargetResponse.Descriptor;
			}
		}

		// Token: 0x06018996 RID: 100758 RVA: 0x00396D14 File Offset: 0x00394F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectDetectionTargetResponse()
		{
		}

		// Token: 0x06018997 RID: 100759 RVA: 0x00396D1C File Offset: 0x00394F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectDetectionTargetResponse(SelectDetectionTargetResponse other) : this()
		{
			this.code_ = other.code_;
			this.selectDetectionTarget_ = ((other.selectDetectionTarget_ != null) ? other.selectDetectionTarget_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018998 RID: 100760 RVA: 0x00396D68 File Offset: 0x00394F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectDetectionTargetResponse Clone()
		{
			return new SelectDetectionTargetResponse(this);
		}

		// Token: 0x1700531E RID: 21278
		// (get) Token: 0x06018999 RID: 100761 RVA: 0x00396D70 File Offset: 0x00394F70
		// (set) Token: 0x0601899A RID: 100762 RVA: 0x00396D78 File Offset: 0x00394F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x1700531F RID: 21279
		// (get) Token: 0x0601899B RID: 100763 RVA: 0x00396D81 File Offset: 0x00394F81
		// (set) Token: 0x0601899C RID: 100764 RVA: 0x00396D89 File Offset: 0x00394F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectDetectionTarget SelectDetectionTarget
		{
			get
			{
				return this.selectDetectionTarget_;
			}
			set
			{
				this.selectDetectionTarget_ = value;
			}
		}

		// Token: 0x0601899D RID: 100765 RVA: 0x00396D92 File Offset: 0x00394F92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelectDetectionTargetResponse);
		}

		// Token: 0x0601899E RID: 100766 RVA: 0x00396DA0 File Offset: 0x00394FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SelectDetectionTargetResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this.SelectDetectionTarget, other.SelectDetectionTarget) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601899F RID: 100767 RVA: 0x00396DF0 File Offset: 0x00394FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.selectDetectionTarget_ != null)
			{
				num ^= this.SelectDetectionTarget.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060189A0 RID: 100768 RVA: 0x00396E4B File Offset: 0x0039504B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060189A1 RID: 100769 RVA: 0x00396E58 File Offset: 0x00395058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060189A2 RID: 100770 RVA: 0x00396E64 File Offset: 0x00395064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.selectDetectionTarget_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.SelectDetectionTarget);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060189A3 RID: 100771 RVA: 0x00396EC0 File Offset: 0x003950C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.selectDetectionTarget_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SelectDetectionTarget);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060189A4 RID: 100772 RVA: 0x00396F18 File Offset: 0x00395118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SelectDetectionTargetResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.selectDetectionTarget_ != null)
			{
				if (this.selectDetectionTarget_ == null)
				{
					this.SelectDetectionTarget = new SelectDetectionTarget();
				}
				this.SelectDetectionTarget.MergeFrom(other.SelectDetectionTarget);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060189A5 RID: 100773 RVA: 0x00396F80 File Offset: 0x00395180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060189A6 RID: 100774 RVA: 0x00396F8C File Offset: 0x0039518C
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
				if (num != 42U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Code = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.selectDetectionTarget_ == null)
					{
						this.SelectDetectionTarget = new SelectDetectionTarget();
					}
					input.ReadMessage(this.SelectDetectionTarget);
				}
			}
		}

		// Token: 0x04009255 RID: 37461
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009256 RID: 37462
		public const int CodeFieldNumber = 12;

		// Token: 0x04009257 RID: 37463
		private ErrorCode code_;

		// Token: 0x04009258 RID: 37464
		public const int SelectDetectionTargetFieldNumber = 5;

		// Token: 0x04009259 RID: 37465
		private SelectDetectionTarget selectDetectionTarget_;
	}
}

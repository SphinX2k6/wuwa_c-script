using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200129B RID: 4763
	[NetMessage(EMessageId.SneakResponse)]
	public sealed class SneakResponse : IMessage<SneakResponse>, IMessage, IEquatable<SneakResponse>, IDeepCloneable<SneakResponse>, IBufferMessage
	{
		// Token: 0x060196C1 RID: 104129 RVA: 0x003B527D File Offset: 0x003B347D
		[NullableContext(1)]
		public static SneakResponse Create()
		{
			return new SneakResponse();
		}

		// Token: 0x170055FF RID: 22015
		// (get) Token: 0x060196C2 RID: 104130 RVA: 0x003B5284 File Offset: 0x003B3484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005600 RID: 22016
		// (get) Token: 0x060196C3 RID: 104131 RVA: 0x003B5287 File Offset: 0x003B3487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SneakResponse.Descriptor;
			}
		}

		// Token: 0x060196C4 RID: 104132 RVA: 0x003B528E File Offset: 0x003B348E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakResponse()
		{
		}

		// Token: 0x060196C5 RID: 104133 RVA: 0x003B5296 File Offset: 0x003B3496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakResponse(SneakResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060196C6 RID: 104134 RVA: 0x003B52BB File Offset: 0x003B34BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakResponse Clone()
		{
			return new SneakResponse(this);
		}

		// Token: 0x17005601 RID: 22017
		// (get) Token: 0x060196C7 RID: 104135 RVA: 0x003B52C3 File Offset: 0x003B34C3
		// (set) Token: 0x060196C8 RID: 104136 RVA: 0x003B52CB File Offset: 0x003B34CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x060196C9 RID: 104137 RVA: 0x003B52D4 File Offset: 0x003B34D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SneakResponse);
		}

		// Token: 0x060196CA RID: 104138 RVA: 0x003B52E2 File Offset: 0x003B34E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SneakResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060196CB RID: 104139 RVA: 0x003B5310 File Offset: 0x003B3510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060196CC RID: 104140 RVA: 0x003B5355 File Offset: 0x003B3555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060196CD RID: 104141 RVA: 0x003B5362 File Offset: 0x003B3562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060196CE RID: 104142 RVA: 0x003B536B File Offset: 0x003B356B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060196CF RID: 104143 RVA: 0x003B53A0 File Offset: 0x003B35A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060196D0 RID: 104144 RVA: 0x003B53DE File Offset: 0x003B35DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SneakResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060196D1 RID: 104145 RVA: 0x003B540F File Offset: 0x003B360F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060196D2 RID: 104146 RVA: 0x003B5418 File Offset: 0x003B3618
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400964D RID: 38477
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400964E RID: 38478
		public const int ErrorIdFieldNumber = 7;

		// Token: 0x0400964F RID: 38479
		private ErrorCode errorId_;
	}
}

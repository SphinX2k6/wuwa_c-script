using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x02001699 RID: 5785
	[NetMessage(EMessageId.GetDebugInfoNotify)]
	public sealed class GetDebugInfoNotify : IMessage<GetDebugInfoNotify>, IMessage, IEquatable<GetDebugInfoNotify>, IDeepCloneable<GetDebugInfoNotify>, IBufferMessage
	{
		// Token: 0x0601CFEF RID: 118767 RVA: 0x0043EA6D File Offset: 0x0043CC6D
		[NullableContext(1)]
		public static GetDebugInfoNotify Create()
		{
			return new GetDebugInfoNotify();
		}

		// Token: 0x17006265 RID: 25189
		// (get) Token: 0x0601CFF0 RID: 118768 RVA: 0x0043EA74 File Offset: 0x0043CC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006266 RID: 25190
		// (get) Token: 0x0601CFF1 RID: 118769 RVA: 0x0043EA77 File Offset: 0x0043CC77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetDebugInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601CFF2 RID: 118770 RVA: 0x0043EA7E File Offset: 0x0043CC7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDebugInfoNotify()
		{
		}

		// Token: 0x0601CFF3 RID: 118771 RVA: 0x0043EA91 File Offset: 0x0043CC91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDebugInfoNotify(GetDebugInfoNotify other) : this()
		{
			this.logId_ = other.logId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CFF4 RID: 118772 RVA: 0x0043EAB6 File Offset: 0x0043CCB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDebugInfoNotify Clone()
		{
			return new GetDebugInfoNotify(this);
		}

		// Token: 0x17006267 RID: 25191
		// (get) Token: 0x0601CFF5 RID: 118773 RVA: 0x0043EABE File Offset: 0x0043CCBE
		// (set) Token: 0x0601CFF6 RID: 118774 RVA: 0x0043EAC6 File Offset: 0x0043CCC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string LogId
		{
			get
			{
				return this.logId_;
			}
			set
			{
				this.logId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0601CFF7 RID: 118775 RVA: 0x0043EAD9 File Offset: 0x0043CCD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetDebugInfoNotify);
		}

		// Token: 0x0601CFF8 RID: 118776 RVA: 0x0043EAE7 File Offset: 0x0043CCE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetDebugInfoNotify other)
		{
			return other != null && (other == this || (!(this.LogId != other.LogId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CFF9 RID: 118777 RVA: 0x0043EB1C File Offset: 0x0043CD1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LogId.Length != 0)
			{
				num ^= this.LogId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CFFA RID: 118778 RVA: 0x0043EB5D File Offset: 0x0043CD5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CFFB RID: 118779 RVA: 0x0043EB6A File Offset: 0x0043CD6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CFFC RID: 118780 RVA: 0x0043EB73 File Offset: 0x0043CD73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LogId.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.LogId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CFFD RID: 118781 RVA: 0x0043EBAC File Offset: 0x0043CDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LogId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.LogId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CFFE RID: 118782 RVA: 0x0043EBEF File Offset: 0x0043CDEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetDebugInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LogId.Length != 0)
			{
				this.LogId = other.LogId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CFFF RID: 118783 RVA: 0x0043EC25 File Offset: 0x0043CE25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D000 RID: 118784 RVA: 0x0043EC30 File Offset: 0x0043CE30
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LogId = input.ReadString();
				}
			}
		}

		// Token: 0x0400C3CD RID: 50125
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C3CE RID: 50126
		public const int LogIdFieldNumber = 10;

		// Token: 0x0400C3CF RID: 50127
		private string logId_ = "";
	}
}

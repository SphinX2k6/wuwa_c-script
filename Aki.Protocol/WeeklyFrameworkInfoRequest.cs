using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200150B RID: 5387
	[NetMessage(EMessageId.WeeklyFrameworkInfoRequest)]
	public sealed class WeeklyFrameworkInfoRequest : IMessage<WeeklyFrameworkInfoRequest>, IMessage, IEquatable<WeeklyFrameworkInfoRequest>, IDeepCloneable<WeeklyFrameworkInfoRequest>, IBufferMessage
	{
		// Token: 0x0601C793 RID: 116627 RVA: 0x0041CDBD File Offset: 0x0041AFBD
		[NullableContext(1)]
		public static WeeklyFrameworkInfoRequest Create()
		{
			return new WeeklyFrameworkInfoRequest();
		}

		// Token: 0x17005FFE RID: 24574
		// (get) Token: 0x0601C794 RID: 116628 RVA: 0x0041CDC4 File Offset: 0x0041AFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FFF RID: 24575
		// (get) Token: 0x0601C795 RID: 116629 RVA: 0x0041CDC7 File Offset: 0x0041AFC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeeklyFrameworkInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601C796 RID: 116630 RVA: 0x0041CDCE File Offset: 0x0041AFCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkInfoRequest()
		{
		}

		// Token: 0x0601C797 RID: 116631 RVA: 0x0041CDD6 File Offset: 0x0041AFD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkInfoRequest(WeeklyFrameworkInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C798 RID: 116632 RVA: 0x0041CDEF File Offset: 0x0041AFEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkInfoRequest Clone()
		{
			return new WeeklyFrameworkInfoRequest(this);
		}

		// Token: 0x0601C799 RID: 116633 RVA: 0x0041CDF7 File Offset: 0x0041AFF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeeklyFrameworkInfoRequest);
		}

		// Token: 0x0601C79A RID: 116634 RVA: 0x0041CE05 File Offset: 0x0041B005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeeklyFrameworkInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601C79B RID: 116635 RVA: 0x0041CE24 File Offset: 0x0041B024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C79C RID: 116636 RVA: 0x0041CE4A File Offset: 0x0041B04A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C79D RID: 116637 RVA: 0x0041CE57 File Offset: 0x0041B057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C79E RID: 116638 RVA: 0x0041CE60 File Offset: 0x0041B060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C79F RID: 116639 RVA: 0x0041CE78 File Offset: 0x0041B078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C7A0 RID: 116640 RVA: 0x0041CE9E File Offset: 0x0041B09E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeeklyFrameworkInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C7A1 RID: 116641 RVA: 0x0041CEBB File Offset: 0x0041B0BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C7A2 RID: 116642 RVA: 0x0041CEC4 File Offset: 0x0041B0C4
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A2FF RID: 41727
		private UnknownFieldSet _unknownFields;
	}
}

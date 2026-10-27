using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EDF RID: 3807
	[NetMessage(EMessageId.RegressDisposableRewardRequest)]
	public sealed class RegressDisposableRewardRequest : IMessage<RegressDisposableRewardRequest>, IMessage, IEquatable<RegressDisposableRewardRequest>, IDeepCloneable<RegressDisposableRewardRequest>, IBufferMessage
	{
		// Token: 0x0601468A RID: 83594 RVA: 0x002F775C File Offset: 0x002F595C
		[NullableContext(1)]
		public static RegressDisposableRewardRequest Create()
		{
			return new RegressDisposableRewardRequest();
		}

		// Token: 0x170043E2 RID: 17378
		// (get) Token: 0x0601468B RID: 83595 RVA: 0x002F7763 File Offset: 0x002F5963
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043E3 RID: 17379
		// (get) Token: 0x0601468C RID: 83596 RVA: 0x002F7766 File Offset: 0x002F5966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressDisposableRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601468D RID: 83597 RVA: 0x002F776D File Offset: 0x002F596D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressDisposableRewardRequest()
		{
		}

		// Token: 0x0601468E RID: 83598 RVA: 0x002F7775 File Offset: 0x002F5975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressDisposableRewardRequest(RegressDisposableRewardRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601468F RID: 83599 RVA: 0x002F778E File Offset: 0x002F598E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressDisposableRewardRequest Clone()
		{
			return new RegressDisposableRewardRequest(this);
		}

		// Token: 0x06014690 RID: 83600 RVA: 0x002F7796 File Offset: 0x002F5996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressDisposableRewardRequest);
		}

		// Token: 0x06014691 RID: 83601 RVA: 0x002F77A4 File Offset: 0x002F59A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressDisposableRewardRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06014692 RID: 83602 RVA: 0x002F77C4 File Offset: 0x002F59C4
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

		// Token: 0x06014693 RID: 83603 RVA: 0x002F77EA File Offset: 0x002F59EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014694 RID: 83604 RVA: 0x002F77F7 File Offset: 0x002F59F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014695 RID: 83605 RVA: 0x002F7800 File Offset: 0x002F5A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014696 RID: 83606 RVA: 0x002F7818 File Offset: 0x002F5A18
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

		// Token: 0x06014697 RID: 83607 RVA: 0x002F783E File Offset: 0x002F5A3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RegressDisposableRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014698 RID: 83608 RVA: 0x002F785B File Offset: 0x002F5A5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014699 RID: 83609 RVA: 0x002F7864 File Offset: 0x002F5A64
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

		// Token: 0x04007BEF RID: 31727
		private UnknownFieldSet _unknownFields;
	}
}

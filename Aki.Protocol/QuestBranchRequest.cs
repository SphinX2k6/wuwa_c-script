using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DF7 RID: 3575
	[NetMessage(EMessageId.QuestBranchRequest)]
	public sealed class QuestBranchRequest : IMessage<QuestBranchRequest>, IMessage, IEquatable<QuestBranchRequest>, IDeepCloneable<QuestBranchRequest>, IBufferMessage
	{
		// Token: 0x060133F8 RID: 78840 RVA: 0x002CDE3A File Offset: 0x002CC03A
		[NullableContext(1)]
		public static QuestBranchRequest Create()
		{
			return new QuestBranchRequest();
		}

		// Token: 0x17003FDF RID: 16351
		// (get) Token: 0x060133F9 RID: 78841 RVA: 0x002CDE41 File Offset: 0x002CC041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FE0 RID: 16352
		// (get) Token: 0x060133FA RID: 78842 RVA: 0x002CDE44 File Offset: 0x002CC044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestBranchRequest.Descriptor;
			}
		}

		// Token: 0x060133FB RID: 78843 RVA: 0x002CDE4B File Offset: 0x002CC04B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchRequest()
		{
		}

		// Token: 0x060133FC RID: 78844 RVA: 0x002CDE53 File Offset: 0x002CC053
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchRequest(QuestBranchRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060133FD RID: 78845 RVA: 0x002CDE6C File Offset: 0x002CC06C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchRequest Clone()
		{
			return new QuestBranchRequest(this);
		}

		// Token: 0x060133FE RID: 78846 RVA: 0x002CDE74 File Offset: 0x002CC074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestBranchRequest);
		}

		// Token: 0x060133FF RID: 78847 RVA: 0x002CDE82 File Offset: 0x002CC082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestBranchRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06013400 RID: 78848 RVA: 0x002CDEA0 File Offset: 0x002CC0A0
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

		// Token: 0x06013401 RID: 78849 RVA: 0x002CDEC6 File Offset: 0x002CC0C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013402 RID: 78850 RVA: 0x002CDED3 File Offset: 0x002CC0D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013403 RID: 78851 RVA: 0x002CDEDC File Offset: 0x002CC0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013404 RID: 78852 RVA: 0x002CDEF4 File Offset: 0x002CC0F4
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

		// Token: 0x06013405 RID: 78853 RVA: 0x002CDF1A File Offset: 0x002CC11A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestBranchRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013406 RID: 78854 RVA: 0x002CDF37 File Offset: 0x002CC137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013407 RID: 78855 RVA: 0x002CDF40 File Offset: 0x002CC140
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

		// Token: 0x040076D1 RID: 30417
		private UnknownFieldSet _unknownFields;
	}
}

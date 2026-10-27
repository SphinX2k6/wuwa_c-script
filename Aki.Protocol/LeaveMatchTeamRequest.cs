using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008EE RID: 2286
	[NetMessage(EMessageId.LeaveMatchTeamRequest)]
	public sealed class LeaveMatchTeamRequest : IMessage<LeaveMatchTeamRequest>, IMessage, IEquatable<LeaveMatchTeamRequest>, IDeepCloneable<LeaveMatchTeamRequest>, IBufferMessage
	{
		// Token: 0x0600CA24 RID: 51748 RVA: 0x001DD820 File Offset: 0x001DBA20
		[NullableContext(1)]
		public static LeaveMatchTeamRequest Create()
		{
			return new LeaveMatchTeamRequest();
		}

		// Token: 0x170028D2 RID: 10450
		// (get) Token: 0x0600CA25 RID: 51749 RVA: 0x001DD827 File Offset: 0x001DBA27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028D3 RID: 10451
		// (get) Token: 0x0600CA26 RID: 51750 RVA: 0x001DD82A File Offset: 0x001DBA2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveMatchTeamRequest.Descriptor;
			}
		}

		// Token: 0x0600CA27 RID: 51751 RVA: 0x001DD831 File Offset: 0x001DBA31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveMatchTeamRequest()
		{
		}

		// Token: 0x0600CA28 RID: 51752 RVA: 0x001DD839 File Offset: 0x001DBA39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveMatchTeamRequest(LeaveMatchTeamRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CA29 RID: 51753 RVA: 0x001DD852 File Offset: 0x001DBA52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveMatchTeamRequest Clone()
		{
			return new LeaveMatchTeamRequest(this);
		}

		// Token: 0x0600CA2A RID: 51754 RVA: 0x001DD85A File Offset: 0x001DBA5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveMatchTeamRequest);
		}

		// Token: 0x0600CA2B RID: 51755 RVA: 0x001DD868 File Offset: 0x001DBA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveMatchTeamRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600CA2C RID: 51756 RVA: 0x001DD888 File Offset: 0x001DBA88
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

		// Token: 0x0600CA2D RID: 51757 RVA: 0x001DD8AE File Offset: 0x001DBAAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CA2E RID: 51758 RVA: 0x001DD8BB File Offset: 0x001DBABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CA2F RID: 51759 RVA: 0x001DD8C4 File Offset: 0x001DBAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CA30 RID: 51760 RVA: 0x001DD8DC File Offset: 0x001DBADC
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

		// Token: 0x0600CA31 RID: 51761 RVA: 0x001DD902 File Offset: 0x001DBB02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LeaveMatchTeamRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CA32 RID: 51762 RVA: 0x001DD91F File Offset: 0x001DBB1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CA33 RID: 51763 RVA: 0x001DD928 File Offset: 0x001DBB28
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

		// Token: 0x04005617 RID: 22039
		private UnknownFieldSet _unknownFields;
	}
}

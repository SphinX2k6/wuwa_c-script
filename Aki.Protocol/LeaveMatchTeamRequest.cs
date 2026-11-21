using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008DD RID: 2269
	[NetMessage(EMessageId.LeaveMatchTeamRequest)]
	public sealed class LeaveMatchTeamRequest : IMessage<LeaveMatchTeamRequest>, IMessage, IEquatable<LeaveMatchTeamRequest>, IDeepCloneable<LeaveMatchTeamRequest>, IBufferMessage
	{
		// Token: 0x0600C908 RID: 51464 RVA: 0x001DB544 File Offset: 0x001D9744
		[NullableContext(1)]
		public static LeaveMatchTeamRequest Create()
		{
			return new LeaveMatchTeamRequest();
		}

		// Token: 0x17002893 RID: 10387
		// (get) Token: 0x0600C909 RID: 51465 RVA: 0x001DB54B File Offset: 0x001D974B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002894 RID: 10388
		// (get) Token: 0x0600C90A RID: 51466 RVA: 0x001DB54E File Offset: 0x001D974E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveMatchTeamRequest.Descriptor;
			}
		}

		// Token: 0x0600C90B RID: 51467 RVA: 0x001DB555 File Offset: 0x001D9755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveMatchTeamRequest()
		{
		}

		// Token: 0x0600C90C RID: 51468 RVA: 0x001DB55D File Offset: 0x001D975D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveMatchTeamRequest(LeaveMatchTeamRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C90D RID: 51469 RVA: 0x001DB576 File Offset: 0x001D9776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveMatchTeamRequest Clone()
		{
			return new LeaveMatchTeamRequest(this);
		}

		// Token: 0x0600C90E RID: 51470 RVA: 0x001DB57E File Offset: 0x001D977E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveMatchTeamRequest);
		}

		// Token: 0x0600C90F RID: 51471 RVA: 0x001DB58C File Offset: 0x001D978C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveMatchTeamRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C910 RID: 51472 RVA: 0x001DB5AC File Offset: 0x001D97AC
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

		// Token: 0x0600C911 RID: 51473 RVA: 0x001DB5D2 File Offset: 0x001D97D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C912 RID: 51474 RVA: 0x001DB5DF File Offset: 0x001D97DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C913 RID: 51475 RVA: 0x001DB5E8 File Offset: 0x001D97E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C914 RID: 51476 RVA: 0x001DB600 File Offset: 0x001D9800
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

		// Token: 0x0600C915 RID: 51477 RVA: 0x001DB626 File Offset: 0x001D9826
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

		// Token: 0x0600C916 RID: 51478 RVA: 0x001DB643 File Offset: 0x001D9843
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C917 RID: 51479 RVA: 0x001DB64C File Offset: 0x001D984C
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

		// Token: 0x0400561E RID: 22046
		private UnknownFieldSet _unknownFields;
	}
}

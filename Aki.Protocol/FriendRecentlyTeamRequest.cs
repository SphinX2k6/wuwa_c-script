using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000656 RID: 1622
	[NetMessage(EMessageId.FriendRecentlyTeamRequest)]
	public sealed class FriendRecentlyTeamRequest : IMessage<FriendRecentlyTeamRequest>, IMessage, IEquatable<FriendRecentlyTeamRequest>, IDeepCloneable<FriendRecentlyTeamRequest>, IBufferMessage
	{
		// Token: 0x0600950A RID: 38154 RVA: 0x00167E4B File Offset: 0x0016604B
		[NullableContext(1)]
		public static FriendRecentlyTeamRequest Create()
		{
			return new FriendRecentlyTeamRequest();
		}

		// Token: 0x17001DA9 RID: 7593
		// (get) Token: 0x0600950B RID: 38155 RVA: 0x00167E52 File Offset: 0x00166052
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DAA RID: 7594
		// (get) Token: 0x0600950C RID: 38156 RVA: 0x00167E55 File Offset: 0x00166055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendRecentlyTeamRequest.Descriptor;
			}
		}

		// Token: 0x0600950D RID: 38157 RVA: 0x00167E5C File Offset: 0x0016605C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRecentlyTeamRequest()
		{
		}

		// Token: 0x0600950E RID: 38158 RVA: 0x00167E64 File Offset: 0x00166064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRecentlyTeamRequest(FriendRecentlyTeamRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600950F RID: 38159 RVA: 0x00167E7D File Offset: 0x0016607D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRecentlyTeamRequest Clone()
		{
			return new FriendRecentlyTeamRequest(this);
		}

		// Token: 0x06009510 RID: 38160 RVA: 0x00167E85 File Offset: 0x00166085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendRecentlyTeamRequest);
		}

		// Token: 0x06009511 RID: 38161 RVA: 0x00167E93 File Offset: 0x00166093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendRecentlyTeamRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06009512 RID: 38162 RVA: 0x00167EB4 File Offset: 0x001660B4
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

		// Token: 0x06009513 RID: 38163 RVA: 0x00167EDA File Offset: 0x001660DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009514 RID: 38164 RVA: 0x00167EE7 File Offset: 0x001660E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009515 RID: 38165 RVA: 0x00167EF0 File Offset: 0x001660F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009516 RID: 38166 RVA: 0x00167F08 File Offset: 0x00166108
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

		// Token: 0x06009517 RID: 38167 RVA: 0x00167F2E File Offset: 0x0016612E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendRecentlyTeamRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009518 RID: 38168 RVA: 0x00167F4B File Offset: 0x0016614B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009519 RID: 38169 RVA: 0x00167F54 File Offset: 0x00166154
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

		// Token: 0x04004748 RID: 18248
		private UnknownFieldSet _unknownFields;
	}
}

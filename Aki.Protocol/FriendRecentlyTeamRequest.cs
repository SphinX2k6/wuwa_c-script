using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000642 RID: 1602
	[NetMessage(EMessageId.FriendRecentlyTeamRequest)]
	public sealed class FriendRecentlyTeamRequest : IMessage<FriendRecentlyTeamRequest>, IMessage, IEquatable<FriendRecentlyTeamRequest>, IDeepCloneable<FriendRecentlyTeamRequest>, IBufferMessage
	{
		// Token: 0x060093B4 RID: 37812 RVA: 0x00165417 File Offset: 0x00163617
		[NullableContext(1)]
		public static FriendRecentlyTeamRequest Create()
		{
			return new FriendRecentlyTeamRequest();
		}

		// Token: 0x17001D5F RID: 7519
		// (get) Token: 0x060093B5 RID: 37813 RVA: 0x0016541E File Offset: 0x0016361E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D60 RID: 7520
		// (get) Token: 0x060093B6 RID: 37814 RVA: 0x00165421 File Offset: 0x00163621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendRecentlyTeamRequest.Descriptor;
			}
		}

		// Token: 0x060093B7 RID: 37815 RVA: 0x00165428 File Offset: 0x00163628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRecentlyTeamRequest()
		{
		}

		// Token: 0x060093B8 RID: 37816 RVA: 0x00165430 File Offset: 0x00163630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRecentlyTeamRequest(FriendRecentlyTeamRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060093B9 RID: 37817 RVA: 0x00165449 File Offset: 0x00163649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRecentlyTeamRequest Clone()
		{
			return new FriendRecentlyTeamRequest(this);
		}

		// Token: 0x060093BA RID: 37818 RVA: 0x00165451 File Offset: 0x00163651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendRecentlyTeamRequest);
		}

		// Token: 0x060093BB RID: 37819 RVA: 0x0016545F File Offset: 0x0016365F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendRecentlyTeamRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060093BC RID: 37820 RVA: 0x00165480 File Offset: 0x00163680
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

		// Token: 0x060093BD RID: 37821 RVA: 0x001654A6 File Offset: 0x001636A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060093BE RID: 37822 RVA: 0x001654B3 File Offset: 0x001636B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060093BF RID: 37823 RVA: 0x001654BC File Offset: 0x001636BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060093C0 RID: 37824 RVA: 0x001654D4 File Offset: 0x001636D4
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

		// Token: 0x060093C1 RID: 37825 RVA: 0x001654FA File Offset: 0x001636FA
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

		// Token: 0x060093C2 RID: 37826 RVA: 0x00165517 File Offset: 0x00163717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060093C3 RID: 37827 RVA: 0x00165520 File Offset: 0x00163720
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

		// Token: 0x04004741 RID: 18241
		private UnknownFieldSet _unknownFields;
	}
}

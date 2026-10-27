using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000649 RID: 1609
	[NetMessage(EMessageId.FriendAllRequest)]
	public sealed class FriendAllRequest : IMessage<FriendAllRequest>, IMessage, IEquatable<FriendAllRequest>, IDeepCloneable<FriendAllRequest>, IBufferMessage
	{
		// Token: 0x06009411 RID: 37905 RVA: 0x00165FC8 File Offset: 0x001641C8
		[NullableContext(1)]
		public static FriendAllRequest Create()
		{
			return new FriendAllRequest();
		}

		// Token: 0x17001D7A RID: 7546
		// (get) Token: 0x06009412 RID: 37906 RVA: 0x00165FCF File Offset: 0x001641CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D7B RID: 7547
		// (get) Token: 0x06009413 RID: 37907 RVA: 0x00165FD2 File Offset: 0x001641D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendAllRequest.Descriptor;
			}
		}

		// Token: 0x06009414 RID: 37908 RVA: 0x00165FD9 File Offset: 0x001641D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendAllRequest()
		{
		}

		// Token: 0x06009415 RID: 37909 RVA: 0x00165FE1 File Offset: 0x001641E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendAllRequest(FriendAllRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009416 RID: 37910 RVA: 0x00165FFA File Offset: 0x001641FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendAllRequest Clone()
		{
			return new FriendAllRequest(this);
		}

		// Token: 0x06009417 RID: 37911 RVA: 0x00166002 File Offset: 0x00164202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendAllRequest);
		}

		// Token: 0x06009418 RID: 37912 RVA: 0x00166010 File Offset: 0x00164210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendAllRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06009419 RID: 37913 RVA: 0x00166030 File Offset: 0x00164230
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

		// Token: 0x0600941A RID: 37914 RVA: 0x00166056 File Offset: 0x00164256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600941B RID: 37915 RVA: 0x00166063 File Offset: 0x00164263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600941C RID: 37916 RVA: 0x0016606C File Offset: 0x0016426C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600941D RID: 37917 RVA: 0x00166084 File Offset: 0x00164284
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

		// Token: 0x0600941E RID: 37918 RVA: 0x001660AA File Offset: 0x001642AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendAllRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600941F RID: 37919 RVA: 0x001660C7 File Offset: 0x001642C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009420 RID: 37920 RVA: 0x001660D0 File Offset: 0x001642D0
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

		// Token: 0x0400470F RID: 18191
		private UnknownFieldSet _unknownFields;
	}
}

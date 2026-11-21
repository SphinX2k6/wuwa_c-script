using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000635 RID: 1589
	[NetMessage(EMessageId.FriendAllRequest)]
	public sealed class FriendAllRequest : IMessage<FriendAllRequest>, IMessage, IEquatable<FriendAllRequest>, IDeepCloneable<FriendAllRequest>, IBufferMessage
	{
		// Token: 0x060092BB RID: 37563 RVA: 0x00163598 File Offset: 0x00161798
		[NullableContext(1)]
		public static FriendAllRequest Create()
		{
			return new FriendAllRequest();
		}

		// Token: 0x17001D30 RID: 7472
		// (get) Token: 0x060092BC RID: 37564 RVA: 0x0016359F File Offset: 0x0016179F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D31 RID: 7473
		// (get) Token: 0x060092BD RID: 37565 RVA: 0x001635A2 File Offset: 0x001617A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendAllRequest.Descriptor;
			}
		}

		// Token: 0x060092BE RID: 37566 RVA: 0x001635A9 File Offset: 0x001617A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendAllRequest()
		{
		}

		// Token: 0x060092BF RID: 37567 RVA: 0x001635B1 File Offset: 0x001617B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendAllRequest(FriendAllRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060092C0 RID: 37568 RVA: 0x001635CA File Offset: 0x001617CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendAllRequest Clone()
		{
			return new FriendAllRequest(this);
		}

		// Token: 0x060092C1 RID: 37569 RVA: 0x001635D2 File Offset: 0x001617D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendAllRequest);
		}

		// Token: 0x060092C2 RID: 37570 RVA: 0x001635E0 File Offset: 0x001617E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendAllRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060092C3 RID: 37571 RVA: 0x00163600 File Offset: 0x00161800
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

		// Token: 0x060092C4 RID: 37572 RVA: 0x00163626 File Offset: 0x00161826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060092C5 RID: 37573 RVA: 0x00163633 File Offset: 0x00161833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060092C6 RID: 37574 RVA: 0x0016363C File Offset: 0x0016183C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060092C7 RID: 37575 RVA: 0x00163654 File Offset: 0x00161854
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

		// Token: 0x060092C8 RID: 37576 RVA: 0x0016367A File Offset: 0x0016187A
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

		// Token: 0x060092C9 RID: 37577 RVA: 0x00163697 File Offset: 0x00161897
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060092CA RID: 37578 RVA: 0x001636A0 File Offset: 0x001618A0
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

		// Token: 0x04004708 RID: 18184
		private UnknownFieldSet _unknownFields;
	}
}

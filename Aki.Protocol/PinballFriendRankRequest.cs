using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D37 RID: 3383
	[NetMessage(EMessageId.PinballFriendRankRequest)]
	public sealed class PinballFriendRankRequest : IMessage<PinballFriendRankRequest>, IMessage, IEquatable<PinballFriendRankRequest>, IDeepCloneable<PinballFriendRankRequest>, IBufferMessage
	{
		// Token: 0x06012471 RID: 74865 RVA: 0x002AB5B9 File Offset: 0x002A97B9
		[NullableContext(1)]
		public static PinballFriendRankRequest Create()
		{
			return new PinballFriendRankRequest();
		}

		// Token: 0x17003C90 RID: 15504
		// (get) Token: 0x06012472 RID: 74866 RVA: 0x002AB5C0 File Offset: 0x002A97C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C91 RID: 15505
		// (get) Token: 0x06012473 RID: 74867 RVA: 0x002AB5C3 File Offset: 0x002A97C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballFriendRankRequest.Descriptor;
			}
		}

		// Token: 0x06012474 RID: 74868 RVA: 0x002AB5CA File Offset: 0x002A97CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballFriendRankRequest()
		{
		}

		// Token: 0x06012475 RID: 74869 RVA: 0x002AB5D2 File Offset: 0x002A97D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballFriendRankRequest(PinballFriendRankRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012476 RID: 74870 RVA: 0x002AB5EB File Offset: 0x002A97EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballFriendRankRequest Clone()
		{
			return new PinballFriendRankRequest(this);
		}

		// Token: 0x06012477 RID: 74871 RVA: 0x002AB5F3 File Offset: 0x002A97F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballFriendRankRequest);
		}

		// Token: 0x06012478 RID: 74872 RVA: 0x002AB601 File Offset: 0x002A9801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballFriendRankRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06012479 RID: 74873 RVA: 0x002AB620 File Offset: 0x002A9820
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

		// Token: 0x0601247A RID: 74874 RVA: 0x002AB646 File Offset: 0x002A9846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601247B RID: 74875 RVA: 0x002AB653 File Offset: 0x002A9853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601247C RID: 74876 RVA: 0x002AB65C File Offset: 0x002A985C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601247D RID: 74877 RVA: 0x002AB674 File Offset: 0x002A9874
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

		// Token: 0x0601247E RID: 74878 RVA: 0x002AB69A File Offset: 0x002A989A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballFriendRankRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601247F RID: 74879 RVA: 0x002AB6B7 File Offset: 0x002A98B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012480 RID: 74880 RVA: 0x002AB6C0 File Offset: 0x002A98C0
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

		// Token: 0x04007260 RID: 29280
		private UnknownFieldSet _unknownFields;
	}
}

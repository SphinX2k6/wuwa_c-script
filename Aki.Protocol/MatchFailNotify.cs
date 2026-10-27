using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009BA RID: 2490
	[NetMessage(EMessageId.MatchFailNotify)]
	public sealed class MatchFailNotify : IMessage<MatchFailNotify>, IMessage, IEquatable<MatchFailNotify>, IDeepCloneable<MatchFailNotify>, IBufferMessage
	{
		// Token: 0x0600DA6F RID: 55919 RVA: 0x00201089 File Offset: 0x001FF289
		[NullableContext(1)]
		public static MatchFailNotify Create()
		{
			return new MatchFailNotify();
		}

		// Token: 0x17002C3B RID: 11323
		// (get) Token: 0x0600DA70 RID: 55920 RVA: 0x00201090 File Offset: 0x001FF290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C3C RID: 11324
		// (get) Token: 0x0600DA71 RID: 55921 RVA: 0x00201093 File Offset: 0x001FF293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchFailNotify.Descriptor;
			}
		}

		// Token: 0x0600DA72 RID: 55922 RVA: 0x0020109A File Offset: 0x001FF29A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchFailNotify()
		{
		}

		// Token: 0x0600DA73 RID: 55923 RVA: 0x002010A2 File Offset: 0x001FF2A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchFailNotify(MatchFailNotify other) : this()
		{
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DA74 RID: 55924 RVA: 0x002010C7 File Offset: 0x001FF2C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchFailNotify Clone()
		{
			return new MatchFailNotify(this);
		}

		// Token: 0x17002C3D RID: 11325
		// (get) Token: 0x0600DA75 RID: 55925 RVA: 0x002010CF File Offset: 0x001FF2CF
		// (set) Token: 0x0600DA76 RID: 55926 RVA: 0x002010D7 File Offset: 0x001FF2D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchFailReason Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x0600DA77 RID: 55927 RVA: 0x002010E0 File Offset: 0x001FF2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchFailNotify);
		}

		// Token: 0x0600DA78 RID: 55928 RVA: 0x002010EE File Offset: 0x001FF2EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchFailNotify other)
		{
			return other != null && (other == this || (this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DA79 RID: 55929 RVA: 0x0020111C File Offset: 0x001FF31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Reason != MatchFailReason.TimeOut)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DA7A RID: 55930 RVA: 0x00201161 File Offset: 0x001FF361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DA7B RID: 55931 RVA: 0x0020116E File Offset: 0x001FF36E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DA7C RID: 55932 RVA: 0x00201177 File Offset: 0x001FF377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != MatchFailReason.TimeOut)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DA7D RID: 55933 RVA: 0x002011AC File Offset: 0x001FF3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Reason != MatchFailReason.TimeOut)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DA7E RID: 55934 RVA: 0x002011EA File Offset: 0x001FF3EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchFailNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Reason != MatchFailReason.TimeOut)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DA7F RID: 55935 RVA: 0x0020121B File Offset: 0x001FF41B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DA80 RID: 55936 RVA: 0x00201224 File Offset: 0x001FF424
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Reason = (MatchFailReason)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005AB2 RID: 23218
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005AB3 RID: 23219
		public const int ReasonFieldNumber = 6;

		// Token: 0x04005AB4 RID: 23220
		private MatchFailReason reason_;
	}
}

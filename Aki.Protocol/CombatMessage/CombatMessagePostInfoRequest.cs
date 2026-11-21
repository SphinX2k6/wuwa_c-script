using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x020016FF RID: 5887
	[NetMessage(EMessageId.CombatMessagePostInfoRequest)]
	public sealed class CombatMessagePostInfoRequest : IMessage<CombatMessagePostInfoRequest>, IMessage, IEquatable<CombatMessagePostInfoRequest>, IDeepCloneable<CombatMessagePostInfoRequest>, IBufferMessage
	{
		// Token: 0x0601D69C RID: 120476 RVA: 0x0044194E File Offset: 0x0043FB4E
		[NullableContext(1)]
		public static CombatMessagePostInfoRequest Create()
		{
			return new CombatMessagePostInfoRequest();
		}

		// Token: 0x1700637C RID: 25468
		// (get) Token: 0x0601D69D RID: 120477 RVA: 0x00441955 File Offset: 0x0043FB55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700637D RID: 25469
		// (get) Token: 0x0601D69E RID: 120478 RVA: 0x00441958 File Offset: 0x0043FB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatMessagePostInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601D69F RID: 120479 RVA: 0x0044195F File Offset: 0x0043FB5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMessagePostInfoRequest()
		{
		}

		// Token: 0x0601D6A0 RID: 120480 RVA: 0x00441972 File Offset: 0x0043FB72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMessagePostInfoRequest(CombatMessagePostInfoRequest other) : this()
		{
			this.postId_ = other.postId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D6A1 RID: 120481 RVA: 0x00441997 File Offset: 0x0043FB97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMessagePostInfoRequest Clone()
		{
			return new CombatMessagePostInfoRequest(this);
		}

		// Token: 0x1700637E RID: 25470
		// (get) Token: 0x0601D6A2 RID: 120482 RVA: 0x0044199F File Offset: 0x0043FB9F
		// (set) Token: 0x0601D6A3 RID: 120483 RVA: 0x004419A7 File Offset: 0x0043FBA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ByteString PostId
		{
			get
			{
				return this.postId_;
			}
			set
			{
				this.postId_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x0601D6A4 RID: 120484 RVA: 0x004419BA File Offset: 0x0043FBBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatMessagePostInfoRequest);
		}

		// Token: 0x0601D6A5 RID: 120485 RVA: 0x004419C8 File Offset: 0x0043FBC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatMessagePostInfoRequest other)
		{
			return other != null && (other == this || (!(this.PostId != other.PostId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D6A6 RID: 120486 RVA: 0x004419FC File Offset: 0x0043FBFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PostId.Length != 0)
			{
				num ^= this.PostId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D6A7 RID: 120487 RVA: 0x00441A3D File Offset: 0x0043FC3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D6A8 RID: 120488 RVA: 0x00441A4A File Offset: 0x0043FC4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D6A9 RID: 120489 RVA: 0x00441A53 File Offset: 0x0043FC53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PostId.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteBytes(this.PostId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D6AA RID: 120490 RVA: 0x00441A8C File Offset: 0x0043FC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PostId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.PostId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D6AB RID: 120491 RVA: 0x00441ACF File Offset: 0x0043FCCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombatMessagePostInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PostId.Length != 0)
			{
				this.PostId = other.PostId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D6AC RID: 120492 RVA: 0x00441B05 File Offset: 0x0043FD05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D6AD RID: 120493 RVA: 0x00441B10 File Offset: 0x0043FD10
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PostId = input.ReadBytes();
				}
			}
		}

		// Token: 0x0400C737 RID: 50999
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C738 RID: 51000
		public const int PostIdFieldNumber = 15;

		// Token: 0x0400C739 RID: 51001
		private ByteString postId_ = ByteString.Empty;
	}
}

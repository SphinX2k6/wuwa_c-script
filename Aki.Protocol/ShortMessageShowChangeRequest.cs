using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001247 RID: 4679
	[NetMessage(EMessageId.ShortMessageShowChangeRequest)]
	public sealed class ShortMessageShowChangeRequest : IMessage<ShortMessageShowChangeRequest>, IMessage, IEquatable<ShortMessageShowChangeRequest>, IDeepCloneable<ShortMessageShowChangeRequest>, IBufferMessage
	{
		// Token: 0x06018FC4 RID: 102340 RVA: 0x003A476D File Offset: 0x003A296D
		[NullableContext(1)]
		public static ShortMessageShowChangeRequest Create()
		{
			return new ShortMessageShowChangeRequest();
		}

		// Token: 0x1700546F RID: 21615
		// (get) Token: 0x06018FC5 RID: 102341 RVA: 0x003A4774 File Offset: 0x003A2974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005470 RID: 21616
		// (get) Token: 0x06018FC6 RID: 102342 RVA: 0x003A4777 File Offset: 0x003A2977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageShowChangeRequest.Descriptor;
			}
		}

		// Token: 0x06018FC7 RID: 102343 RVA: 0x003A477E File Offset: 0x003A297E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageShowChangeRequest()
		{
		}

		// Token: 0x06018FC8 RID: 102344 RVA: 0x003A4786 File Offset: 0x003A2986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageShowChangeRequest(ShortMessageShowChangeRequest other) : this()
		{
			this.bubbleId_ = other.bubbleId_;
			this.chatBgId_ = other.chatBgId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018FC9 RID: 102345 RVA: 0x003A47B7 File Offset: 0x003A29B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageShowChangeRequest Clone()
		{
			return new ShortMessageShowChangeRequest(this);
		}

		// Token: 0x17005471 RID: 21617
		// (get) Token: 0x06018FCA RID: 102346 RVA: 0x003A47BF File Offset: 0x003A29BF
		// (set) Token: 0x06018FCB RID: 102347 RVA: 0x003A47C7 File Offset: 0x003A29C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BubbleId
		{
			get
			{
				return this.bubbleId_;
			}
			set
			{
				this.bubbleId_ = value;
			}
		}

		// Token: 0x17005472 RID: 21618
		// (get) Token: 0x06018FCC RID: 102348 RVA: 0x003A47D0 File Offset: 0x003A29D0
		// (set) Token: 0x06018FCD RID: 102349 RVA: 0x003A47D8 File Offset: 0x003A29D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChatBgId
		{
			get
			{
				return this.chatBgId_;
			}
			set
			{
				this.chatBgId_ = value;
			}
		}

		// Token: 0x06018FCE RID: 102350 RVA: 0x003A47E1 File Offset: 0x003A29E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageShowChangeRequest);
		}

		// Token: 0x06018FCF RID: 102351 RVA: 0x003A47EF File Offset: 0x003A29EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageShowChangeRequest other)
		{
			return other != null && (other == this || (this.BubbleId == other.BubbleId && this.ChatBgId == other.ChatBgId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018FD0 RID: 102352 RVA: 0x003A4830 File Offset: 0x003A2A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BubbleId != 0)
			{
				num ^= this.BubbleId.GetHashCode();
			}
			if (this.ChatBgId != 0)
			{
				num ^= this.ChatBgId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018FD1 RID: 102353 RVA: 0x003A4888 File Offset: 0x003A2A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018FD2 RID: 102354 RVA: 0x003A4895 File Offset: 0x003A2A95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018FD3 RID: 102355 RVA: 0x003A48A0 File Offset: 0x003A2AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChatBgId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ChatBgId);
			}
			if (this.BubbleId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.BubbleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018FD4 RID: 102356 RVA: 0x003A48FC File Offset: 0x003A2AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BubbleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BubbleId);
			}
			if (this.ChatBgId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChatBgId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018FD5 RID: 102357 RVA: 0x003A4954 File Offset: 0x003A2B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShortMessageShowChangeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BubbleId != 0)
			{
				this.BubbleId = other.BubbleId;
			}
			if (other.ChatBgId != 0)
			{
				this.ChatBgId = other.ChatBgId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018FD6 RID: 102358 RVA: 0x003A49A4 File Offset: 0x003A2BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018FD7 RID: 102359 RVA: 0x003A49B0 File Offset: 0x003A2BB0
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
				if (num != 16U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BubbleId = input.ReadInt32();
					}
				}
				else
				{
					this.ChatBgId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009429 RID: 37929
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400942A RID: 37930
		public const int BubbleIdFieldNumber = 5;

		// Token: 0x0400942B RID: 37931
		private int bubbleId_;

		// Token: 0x0400942C RID: 37932
		public const int ChatBgIdFieldNumber = 2;

		// Token: 0x0400942D RID: 37933
		private int chatBgId_;
	}
}

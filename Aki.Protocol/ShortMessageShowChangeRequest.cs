using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200120B RID: 4619
	[NetMessage(EMessageId.ShortMessageShowChangeRequest)]
	public sealed class ShortMessageShowChangeRequest : IMessage<ShortMessageShowChangeRequest>, IMessage, IEquatable<ShortMessageShowChangeRequest>, IDeepCloneable<ShortMessageShowChangeRequest>, IBufferMessage
	{
		// Token: 0x060189EA RID: 100842 RVA: 0x003948C9 File Offset: 0x00392AC9
		[NullableContext(1)]
		public static ShortMessageShowChangeRequest Create()
		{
			return new ShortMessageShowChangeRequest();
		}

		// Token: 0x170052F2 RID: 21234
		// (get) Token: 0x060189EB RID: 100843 RVA: 0x003948D0 File Offset: 0x00392AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170052F3 RID: 21235
		// (get) Token: 0x060189EC RID: 100844 RVA: 0x003948D3 File Offset: 0x00392AD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageShowChangeRequest.Descriptor;
			}
		}

		// Token: 0x060189ED RID: 100845 RVA: 0x003948DA File Offset: 0x00392ADA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageShowChangeRequest()
		{
		}

		// Token: 0x060189EE RID: 100846 RVA: 0x003948E2 File Offset: 0x00392AE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageShowChangeRequest(ShortMessageShowChangeRequest other) : this()
		{
			this.bubbleId_ = other.bubbleId_;
			this.chatBgId_ = other.chatBgId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060189EF RID: 100847 RVA: 0x00394913 File Offset: 0x00392B13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageShowChangeRequest Clone()
		{
			return new ShortMessageShowChangeRequest(this);
		}

		// Token: 0x170052F4 RID: 21236
		// (get) Token: 0x060189F0 RID: 100848 RVA: 0x0039491B File Offset: 0x00392B1B
		// (set) Token: 0x060189F1 RID: 100849 RVA: 0x00394923 File Offset: 0x00392B23
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

		// Token: 0x170052F5 RID: 21237
		// (get) Token: 0x060189F2 RID: 100850 RVA: 0x0039492C File Offset: 0x00392B2C
		// (set) Token: 0x060189F3 RID: 100851 RVA: 0x00394934 File Offset: 0x00392B34
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

		// Token: 0x060189F4 RID: 100852 RVA: 0x0039493D File Offset: 0x00392B3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageShowChangeRequest);
		}

		// Token: 0x060189F5 RID: 100853 RVA: 0x0039494B File Offset: 0x00392B4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageShowChangeRequest other)
		{
			return other != null && (other == this || (this.BubbleId == other.BubbleId && this.ChatBgId == other.ChatBgId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060189F6 RID: 100854 RVA: 0x0039498C File Offset: 0x00392B8C
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

		// Token: 0x060189F7 RID: 100855 RVA: 0x003949E4 File Offset: 0x00392BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060189F8 RID: 100856 RVA: 0x003949F1 File Offset: 0x00392BF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060189F9 RID: 100857 RVA: 0x003949FC File Offset: 0x00392BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChatBgId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ChatBgId);
			}
			if (this.BubbleId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.BubbleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060189FA RID: 100858 RVA: 0x00394A54 File Offset: 0x00392C54
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

		// Token: 0x060189FB RID: 100859 RVA: 0x00394AAC File Offset: 0x00392CAC
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

		// Token: 0x060189FC RID: 100860 RVA: 0x00394AFC File Offset: 0x00392CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060189FD RID: 100861 RVA: 0x00394B08 File Offset: 0x00392D08
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
				if (num != 8U)
				{
					if (num != 64U)
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

		// Token: 0x04009178 RID: 37240
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009179 RID: 37241
		public const int BubbleIdFieldNumber = 8;

		// Token: 0x0400917A RID: 37242
		private int bubbleId_;

		// Token: 0x0400917B RID: 37243
		public const int ChatBgIdFieldNumber = 1;

		// Token: 0x0400917C RID: 37244
		private int chatBgId_;
	}
}

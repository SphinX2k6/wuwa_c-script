using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DE0 RID: 3552
	[NetMessage(EMessageId.PrivateChatHistoryRequest)]
	public sealed class PrivateChatHistoryRequest : IMessage<PrivateChatHistoryRequest>, IMessage, IEquatable<PrivateChatHistoryRequest>, IDeepCloneable<PrivateChatHistoryRequest>, IBufferMessage
	{
		// Token: 0x060131CA RID: 78282 RVA: 0x002C8B75 File Offset: 0x002C6D75
		[NullableContext(1)]
		public static PrivateChatHistoryRequest Create()
		{
			return new PrivateChatHistoryRequest();
		}

		// Token: 0x17003F67 RID: 16231
		// (get) Token: 0x060131CB RID: 78283 RVA: 0x002C8B7C File Offset: 0x002C6D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F68 RID: 16232
		// (get) Token: 0x060131CC RID: 78284 RVA: 0x002C8B7F File Offset: 0x002C6D7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrivateChatHistoryRequest.Descriptor;
			}
		}

		// Token: 0x060131CD RID: 78285 RVA: 0x002C8B86 File Offset: 0x002C6D86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatHistoryRequest()
		{
		}

		// Token: 0x060131CE RID: 78286 RVA: 0x002C8B8E File Offset: 0x002C6D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatHistoryRequest(PrivateChatHistoryRequest other) : this()
		{
			this.targetUID_ = other.targetUID_;
			this.startIndex_ = other.startIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060131CF RID: 78287 RVA: 0x002C8BBF File Offset: 0x002C6DBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatHistoryRequest Clone()
		{
			return new PrivateChatHistoryRequest(this);
		}

		// Token: 0x17003F69 RID: 16233
		// (get) Token: 0x060131D0 RID: 78288 RVA: 0x002C8BC7 File Offset: 0x002C6DC7
		// (set) Token: 0x060131D1 RID: 78289 RVA: 0x002C8BCF File Offset: 0x002C6DCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetUID
		{
			get
			{
				return this.targetUID_;
			}
			set
			{
				this.targetUID_ = value;
			}
		}

		// Token: 0x17003F6A RID: 16234
		// (get) Token: 0x060131D2 RID: 78290 RVA: 0x002C8BD8 File Offset: 0x002C6DD8
		// (set) Token: 0x060131D3 RID: 78291 RVA: 0x002C8BE0 File Offset: 0x002C6DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StartIndex
		{
			get
			{
				return this.startIndex_;
			}
			set
			{
				this.startIndex_ = value;
			}
		}

		// Token: 0x060131D4 RID: 78292 RVA: 0x002C8BE9 File Offset: 0x002C6DE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrivateChatHistoryRequest);
		}

		// Token: 0x060131D5 RID: 78293 RVA: 0x002C8BF7 File Offset: 0x002C6DF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrivateChatHistoryRequest other)
		{
			return other != null && (other == this || (this.TargetUID == other.TargetUID && this.StartIndex == other.StartIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060131D6 RID: 78294 RVA: 0x002C8C38 File Offset: 0x002C6E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetUID != 0)
			{
				num ^= this.TargetUID.GetHashCode();
			}
			if (this.StartIndex != 0)
			{
				num ^= this.StartIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060131D7 RID: 78295 RVA: 0x002C8C90 File Offset: 0x002C6E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060131D8 RID: 78296 RVA: 0x002C8C9D File Offset: 0x002C6E9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060131D9 RID: 78297 RVA: 0x002C8CA8 File Offset: 0x002C6EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetUID != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.TargetUID);
			}
			if (this.StartIndex != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.StartIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060131DA RID: 78298 RVA: 0x002C8D04 File Offset: 0x002C6F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetUID != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetUID);
			}
			if (this.StartIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StartIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060131DB RID: 78299 RVA: 0x002C8D5C File Offset: 0x002C6F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PrivateChatHistoryRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetUID != 0)
			{
				this.TargetUID = other.TargetUID;
			}
			if (other.StartIndex != 0)
			{
				this.StartIndex = other.StartIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060131DC RID: 78300 RVA: 0x002C8DAC File Offset: 0x002C6FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060131DD RID: 78301 RVA: 0x002C8DB8 File Offset: 0x002C6FB8
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
				if (num != 72U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.StartIndex = input.ReadInt32();
					}
				}
				else
				{
					this.TargetUID = input.ReadInt32();
				}
			}
		}

		// Token: 0x040075CF RID: 30159
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075D0 RID: 30160
		public const int TargetUIDFieldNumber = 9;

		// Token: 0x040075D1 RID: 30161
		private int targetUID_;

		// Token: 0x040075D2 RID: 30162
		public const int StartIndexFieldNumber = 11;

		// Token: 0x040075D3 RID: 30163
		private int startIndex_;
	}
}

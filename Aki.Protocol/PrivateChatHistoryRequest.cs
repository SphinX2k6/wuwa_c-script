using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DD0 RID: 3536
	[NetMessage(EMessageId.PrivateChatHistoryRequest)]
	public sealed class PrivateChatHistoryRequest : IMessage<PrivateChatHistoryRequest>, IMessage, IEquatable<PrivateChatHistoryRequest>, IDeepCloneable<PrivateChatHistoryRequest>, IBufferMessage
	{
		// Token: 0x060130E5 RID: 78053 RVA: 0x002C74B1 File Offset: 0x002C56B1
		[NullableContext(1)]
		public static PrivateChatHistoryRequest Create()
		{
			return new PrivateChatHistoryRequest();
		}

		// Token: 0x17003F3D RID: 16189
		// (get) Token: 0x060130E6 RID: 78054 RVA: 0x002C74B8 File Offset: 0x002C56B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F3E RID: 16190
		// (get) Token: 0x060130E7 RID: 78055 RVA: 0x002C74BB File Offset: 0x002C56BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrivateChatHistoryRequest.Descriptor;
			}
		}

		// Token: 0x060130E8 RID: 78056 RVA: 0x002C74C2 File Offset: 0x002C56C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatHistoryRequest()
		{
		}

		// Token: 0x060130E9 RID: 78057 RVA: 0x002C74CA File Offset: 0x002C56CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatHistoryRequest(PrivateChatHistoryRequest other) : this()
		{
			this.targetUID_ = other.targetUID_;
			this.startIndex_ = other.startIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060130EA RID: 78058 RVA: 0x002C74FB File Offset: 0x002C56FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatHistoryRequest Clone()
		{
			return new PrivateChatHistoryRequest(this);
		}

		// Token: 0x17003F3F RID: 16191
		// (get) Token: 0x060130EB RID: 78059 RVA: 0x002C7503 File Offset: 0x002C5703
		// (set) Token: 0x060130EC RID: 78060 RVA: 0x002C750B File Offset: 0x002C570B
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

		// Token: 0x17003F40 RID: 16192
		// (get) Token: 0x060130ED RID: 78061 RVA: 0x002C7514 File Offset: 0x002C5714
		// (set) Token: 0x060130EE RID: 78062 RVA: 0x002C751C File Offset: 0x002C571C
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

		// Token: 0x060130EF RID: 78063 RVA: 0x002C7525 File Offset: 0x002C5725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrivateChatHistoryRequest);
		}

		// Token: 0x060130F0 RID: 78064 RVA: 0x002C7533 File Offset: 0x002C5733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrivateChatHistoryRequest other)
		{
			return other != null && (other == this || (this.TargetUID == other.TargetUID && this.StartIndex == other.StartIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060130F1 RID: 78065 RVA: 0x002C7574 File Offset: 0x002C5774
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

		// Token: 0x060130F2 RID: 78066 RVA: 0x002C75CC File Offset: 0x002C57CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060130F3 RID: 78067 RVA: 0x002C75D9 File Offset: 0x002C57D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060130F4 RID: 78068 RVA: 0x002C75E4 File Offset: 0x002C57E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StartIndex != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.StartIndex);
			}
			if (this.TargetUID != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.TargetUID);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060130F5 RID: 78069 RVA: 0x002C7640 File Offset: 0x002C5840
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

		// Token: 0x060130F6 RID: 78070 RVA: 0x002C7698 File Offset: 0x002C5898
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

		// Token: 0x060130F7 RID: 78071 RVA: 0x002C76E8 File Offset: 0x002C58E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060130F8 RID: 78072 RVA: 0x002C76F4 File Offset: 0x002C58F4
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
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TargetUID = input.ReadInt32();
					}
				}
				else
				{
					this.StartIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x040075F9 RID: 30201
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075FA RID: 30202
		public const int TargetUIDFieldNumber = 10;

		// Token: 0x040075FB RID: 30203
		private int targetUID_;

		// Token: 0x040075FC RID: 30204
		public const int StartIndexFieldNumber = 9;

		// Token: 0x040075FD RID: 30205
		private int startIndex_;
	}
}

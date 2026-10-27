using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000EB RID: 235
	[NetMessage(EMessageId.AnimationGameplayTagRequest)]
	public sealed class AnimationGameplayTagRequest : IMessage<AnimationGameplayTagRequest>, IMessage, IEquatable<AnimationGameplayTagRequest>, IDeepCloneable<AnimationGameplayTagRequest>, IBufferMessage
	{
		// Token: 0x0600220E RID: 8718 RVA: 0x0005AB57 File Offset: 0x00058D57
		[NullableContext(1)]
		public static AnimationGameplayTagRequest Create()
		{
			return new AnimationGameplayTagRequest();
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x0600220F RID: 8719 RVA: 0x0005AB5E File Offset: 0x00058D5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06002210 RID: 8720 RVA: 0x0005AB61 File Offset: 0x00058D61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimationGameplayTagRequest.Descriptor;
			}
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x0005AB68 File Offset: 0x00058D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationGameplayTagRequest()
		{
		}

		// Token: 0x06002212 RID: 8722 RVA: 0x0005AB70 File Offset: 0x00058D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationGameplayTagRequest(AnimationGameplayTagRequest other) : this()
		{
			this.changedTagId_ = other.changedTagId_;
			this.isAdd_ = other.isAdd_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x0005ABA1 File Offset: 0x00058DA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationGameplayTagRequest Clone()
		{
			return new AnimationGameplayTagRequest(this);
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06002214 RID: 8724 RVA: 0x0005ABA9 File Offset: 0x00058DA9
		// (set) Token: 0x06002215 RID: 8725 RVA: 0x0005ABB1 File Offset: 0x00058DB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChangedTagId
		{
			get
			{
				return this.changedTagId_;
			}
			set
			{
				this.changedTagId_ = value;
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06002216 RID: 8726 RVA: 0x0005ABBA File Offset: 0x00058DBA
		// (set) Token: 0x06002217 RID: 8727 RVA: 0x0005ABC2 File Offset: 0x00058DC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAdd
		{
			get
			{
				return this.isAdd_;
			}
			set
			{
				this.isAdd_ = value;
			}
		}

		// Token: 0x06002218 RID: 8728 RVA: 0x0005ABCB File Offset: 0x00058DCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimationGameplayTagRequest);
		}

		// Token: 0x06002219 RID: 8729 RVA: 0x0005ABD9 File Offset: 0x00058DD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimationGameplayTagRequest other)
		{
			return other != null && (other == this || (this.ChangedTagId == other.ChangedTagId && this.IsAdd == other.IsAdd && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600221A RID: 8730 RVA: 0x0005AC18 File Offset: 0x00058E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChangedTagId != 0)
			{
				num ^= this.ChangedTagId.GetHashCode();
			}
			if (this.IsAdd)
			{
				num ^= this.IsAdd.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600221B RID: 8731 RVA: 0x0005AC70 File Offset: 0x00058E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600221C RID: 8732 RVA: 0x0005AC7D File Offset: 0x00058E7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600221D RID: 8733 RVA: 0x0005AC88 File Offset: 0x00058E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChangedTagId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ChangedTagId);
			}
			if (this.IsAdd)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsAdd);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600221E RID: 8734 RVA: 0x0005ACE0 File Offset: 0x00058EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChangedTagId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChangedTagId);
			}
			if (this.IsAdd)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600221F RID: 8735 RVA: 0x0005AD2C File Offset: 0x00058F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimationGameplayTagRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChangedTagId != 0)
			{
				this.ChangedTagId = other.ChangedTagId;
			}
			if (other.IsAdd)
			{
				this.IsAdd = other.IsAdd;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002220 RID: 8736 RVA: 0x0005AD7C File Offset: 0x00058F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002221 RID: 8737 RVA: 0x0005AD88 File Offset: 0x00058F88
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
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsAdd = input.ReadBool();
					}
				}
				else
				{
					this.ChangedTagId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400245E RID: 9310
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400245F RID: 9311
		public const int ChangedTagIdFieldNumber = 1;

		// Token: 0x04002460 RID: 9312
		private int changedTagId_;

		// Token: 0x04002461 RID: 9313
		public const int IsAddFieldNumber = 9;

		// Token: 0x04002462 RID: 9314
		private bool isAdd_;
	}
}

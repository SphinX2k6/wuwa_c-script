using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000EA RID: 234
	[NetMessage(EMessageId.AnimationGameplayTagPush)]
	public sealed class AnimationGameplayTagPush : IMessage<AnimationGameplayTagPush>, IMessage, IEquatable<AnimationGameplayTagPush>, IDeepCloneable<AnimationGameplayTagPush>, IBufferMessage
	{
		// Token: 0x06002231 RID: 8753 RVA: 0x0005B39C File Offset: 0x0005959C
		[NullableContext(1)]
		public static AnimationGameplayTagPush Create()
		{
			return new AnimationGameplayTagPush();
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06002232 RID: 8754 RVA: 0x0005B3A3 File Offset: 0x000595A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06002233 RID: 8755 RVA: 0x0005B3A6 File Offset: 0x000595A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimationGameplayTagPush.Descriptor;
			}
		}

		// Token: 0x06002234 RID: 8756 RVA: 0x0005B3AD File Offset: 0x000595AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationGameplayTagPush()
		{
		}

		// Token: 0x06002235 RID: 8757 RVA: 0x0005B3B5 File Offset: 0x000595B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationGameplayTagPush(AnimationGameplayTagPush other) : this()
		{
			this.changedTagId_ = other.changedTagId_;
			this.isAdd_ = other.isAdd_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002236 RID: 8758 RVA: 0x0005B3E6 File Offset: 0x000595E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationGameplayTagPush Clone()
		{
			return new AnimationGameplayTagPush(this);
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06002237 RID: 8759 RVA: 0x0005B3EE File Offset: 0x000595EE
		// (set) Token: 0x06002238 RID: 8760 RVA: 0x0005B3F6 File Offset: 0x000595F6
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

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06002239 RID: 8761 RVA: 0x0005B3FF File Offset: 0x000595FF
		// (set) Token: 0x0600223A RID: 8762 RVA: 0x0005B407 File Offset: 0x00059607
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

		// Token: 0x0600223B RID: 8763 RVA: 0x0005B410 File Offset: 0x00059610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimationGameplayTagPush);
		}

		// Token: 0x0600223C RID: 8764 RVA: 0x0005B41E File Offset: 0x0005961E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimationGameplayTagPush other)
		{
			return other != null && (other == this || (this.ChangedTagId == other.ChangedTagId && this.IsAdd == other.IsAdd && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600223D RID: 8765 RVA: 0x0005B45C File Offset: 0x0005965C
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

		// Token: 0x0600223E RID: 8766 RVA: 0x0005B4B4 File Offset: 0x000596B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600223F RID: 8767 RVA: 0x0005B4C1 File Offset: 0x000596C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002240 RID: 8768 RVA: 0x0005B4CC File Offset: 0x000596CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChangedTagId != 0)
			{
				output.WriteRawTag(64);
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

		// Token: 0x06002241 RID: 8769 RVA: 0x0005B528 File Offset: 0x00059728
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

		// Token: 0x06002242 RID: 8770 RVA: 0x0005B574 File Offset: 0x00059774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimationGameplayTagPush other)
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

		// Token: 0x06002243 RID: 8771 RVA: 0x0005B5C4 File Offset: 0x000597C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002244 RID: 8772 RVA: 0x0005B5D0 File Offset: 0x000597D0
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
				if (num != 64U)
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

		// Token: 0x040024B8 RID: 9400
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024B9 RID: 9401
		public const int ChangedTagIdFieldNumber = 8;

		// Token: 0x040024BA RID: 9402
		private int changedTagId_;

		// Token: 0x040024BB RID: 9403
		public const int IsAddFieldNumber = 9;

		// Token: 0x040024BC RID: 9404
		private bool isAdd_;
	}
}

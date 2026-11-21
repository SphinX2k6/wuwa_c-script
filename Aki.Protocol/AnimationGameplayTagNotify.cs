using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000E9 RID: 233
	[NetMessage(EMessageId.AnimationGameplayTagNotify)]
	public sealed class AnimationGameplayTagNotify : IMessage<AnimationGameplayTagNotify>, IMessage, IEquatable<AnimationGameplayTagNotify>, IDeepCloneable<AnimationGameplayTagNotify>, IBufferMessage
	{
		// Token: 0x0600221D RID: 8733 RVA: 0x0005B10D File Offset: 0x0005930D
		[NullableContext(1)]
		public static AnimationGameplayTagNotify Create()
		{
			return new AnimationGameplayTagNotify();
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x0600221E RID: 8734 RVA: 0x0005B114 File Offset: 0x00059314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x0600221F RID: 8735 RVA: 0x0005B117 File Offset: 0x00059317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimationGameplayTagNotify.Descriptor;
			}
		}

		// Token: 0x06002220 RID: 8736 RVA: 0x0005B11E File Offset: 0x0005931E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationGameplayTagNotify()
		{
		}

		// Token: 0x06002221 RID: 8737 RVA: 0x0005B126 File Offset: 0x00059326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationGameplayTagNotify(AnimationGameplayTagNotify other) : this()
		{
			this.changedTagId_ = other.changedTagId_;
			this.isAdd_ = other.isAdd_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002222 RID: 8738 RVA: 0x0005B157 File Offset: 0x00059357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationGameplayTagNotify Clone()
		{
			return new AnimationGameplayTagNotify(this);
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06002223 RID: 8739 RVA: 0x0005B15F File Offset: 0x0005935F
		// (set) Token: 0x06002224 RID: 8740 RVA: 0x0005B167 File Offset: 0x00059367
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

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06002225 RID: 8741 RVA: 0x0005B170 File Offset: 0x00059370
		// (set) Token: 0x06002226 RID: 8742 RVA: 0x0005B178 File Offset: 0x00059378
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

		// Token: 0x06002227 RID: 8743 RVA: 0x0005B181 File Offset: 0x00059381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimationGameplayTagNotify);
		}

		// Token: 0x06002228 RID: 8744 RVA: 0x0005B18F File Offset: 0x0005938F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimationGameplayTagNotify other)
		{
			return other != null && (other == this || (this.ChangedTagId == other.ChangedTagId && this.IsAdd == other.IsAdd && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002229 RID: 8745 RVA: 0x0005B1D0 File Offset: 0x000593D0
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

		// Token: 0x0600222A RID: 8746 RVA: 0x0005B228 File Offset: 0x00059428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600222B RID: 8747 RVA: 0x0005B235 File Offset: 0x00059435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600222C RID: 8748 RVA: 0x0005B240 File Offset: 0x00059440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsAdd)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.IsAdd);
			}
			if (this.ChangedTagId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ChangedTagId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600222D RID: 8749 RVA: 0x0005B29C File Offset: 0x0005949C
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

		// Token: 0x0600222E RID: 8750 RVA: 0x0005B2E8 File Offset: 0x000594E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimationGameplayTagNotify other)
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

		// Token: 0x0600222F RID: 8751 RVA: 0x0005B338 File Offset: 0x00059538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002230 RID: 8752 RVA: 0x0005B344 File Offset: 0x00059544
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
				if (num != 96U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ChangedTagId = input.ReadInt32();
					}
				}
				else
				{
					this.IsAdd = input.ReadBool();
				}
			}
		}

		// Token: 0x040024B3 RID: 9395
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024B4 RID: 9396
		public const int ChangedTagIdFieldNumber = 14;

		// Token: 0x040024B5 RID: 9397
		private int changedTagId_;

		// Token: 0x040024B6 RID: 9398
		public const int IsAddFieldNumber = 12;

		// Token: 0x040024B7 RID: 9399
		private bool isAdd_;
	}
}

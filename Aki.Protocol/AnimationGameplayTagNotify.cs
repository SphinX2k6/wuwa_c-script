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
		// Token: 0x060021E6 RID: 8678 RVA: 0x0005A641 File Offset: 0x00058841
		[NullableContext(1)]
		public static AnimationGameplayTagNotify Create()
		{
			return new AnimationGameplayTagNotify();
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x060021E7 RID: 8679 RVA: 0x0005A648 File Offset: 0x00058848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x060021E8 RID: 8680 RVA: 0x0005A64B File Offset: 0x0005884B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimationGameplayTagNotify.Descriptor;
			}
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x0005A652 File Offset: 0x00058852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationGameplayTagNotify()
		{
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x0005A65A File Offset: 0x0005885A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationGameplayTagNotify(AnimationGameplayTagNotify other) : this()
		{
			this.changedTagId_ = other.changedTagId_;
			this.isAdd_ = other.isAdd_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x0005A68B File Offset: 0x0005888B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationGameplayTagNotify Clone()
		{
			return new AnimationGameplayTagNotify(this);
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x060021EC RID: 8684 RVA: 0x0005A693 File Offset: 0x00058893
		// (set) Token: 0x060021ED RID: 8685 RVA: 0x0005A69B File Offset: 0x0005889B
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

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x060021EE RID: 8686 RVA: 0x0005A6A4 File Offset: 0x000588A4
		// (set) Token: 0x060021EF RID: 8687 RVA: 0x0005A6AC File Offset: 0x000588AC
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

		// Token: 0x060021F0 RID: 8688 RVA: 0x0005A6B5 File Offset: 0x000588B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimationGameplayTagNotify);
		}

		// Token: 0x060021F1 RID: 8689 RVA: 0x0005A6C3 File Offset: 0x000588C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimationGameplayTagNotify other)
		{
			return other != null && (other == this || (this.ChangedTagId == other.ChangedTagId && this.IsAdd == other.IsAdd && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060021F2 RID: 8690 RVA: 0x0005A704 File Offset: 0x00058904
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

		// Token: 0x060021F3 RID: 8691 RVA: 0x0005A75C File Offset: 0x0005895C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x0005A769 File Offset: 0x00058969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x0005A774 File Offset: 0x00058974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsAdd)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsAdd);
			}
			if (this.ChangedTagId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ChangedTagId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x0005A7D0 File Offset: 0x000589D0
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

		// Token: 0x060021F7 RID: 8695 RVA: 0x0005A81C File Offset: 0x00058A1C
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

		// Token: 0x060021F8 RID: 8696 RVA: 0x0005A86C File Offset: 0x00058A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060021F9 RID: 8697 RVA: 0x0005A878 File Offset: 0x00058A78
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
				if (num != 40U)
				{
					if (num != 120U)
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

		// Token: 0x04002454 RID: 9300
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002455 RID: 9301
		public const int ChangedTagIdFieldNumber = 15;

		// Token: 0x04002456 RID: 9302
		private int changedTagId_;

		// Token: 0x04002457 RID: 9303
		public const int IsAddFieldNumber = 5;

		// Token: 0x04002458 RID: 9304
		private bool isAdd_;
	}
}

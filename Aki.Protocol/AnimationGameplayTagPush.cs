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
		// Token: 0x060021FA RID: 8698 RVA: 0x0005A8D0 File Offset: 0x00058AD0
		[NullableContext(1)]
		public static AnimationGameplayTagPush Create()
		{
			return new AnimationGameplayTagPush();
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x060021FB RID: 8699 RVA: 0x0005A8D7 File Offset: 0x00058AD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x060021FC RID: 8700 RVA: 0x0005A8DA File Offset: 0x00058ADA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimationGameplayTagPush.Descriptor;
			}
		}

		// Token: 0x060021FD RID: 8701 RVA: 0x0005A8E1 File Offset: 0x00058AE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationGameplayTagPush()
		{
		}

		// Token: 0x060021FE RID: 8702 RVA: 0x0005A8E9 File Offset: 0x00058AE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationGameplayTagPush(AnimationGameplayTagPush other) : this()
		{
			this.changedTagId_ = other.changedTagId_;
			this.isAdd_ = other.isAdd_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060021FF RID: 8703 RVA: 0x0005A91A File Offset: 0x00058B1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationGameplayTagPush Clone()
		{
			return new AnimationGameplayTagPush(this);
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06002200 RID: 8704 RVA: 0x0005A922 File Offset: 0x00058B22
		// (set) Token: 0x06002201 RID: 8705 RVA: 0x0005A92A File Offset: 0x00058B2A
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

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06002202 RID: 8706 RVA: 0x0005A933 File Offset: 0x00058B33
		// (set) Token: 0x06002203 RID: 8707 RVA: 0x0005A93B File Offset: 0x00058B3B
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

		// Token: 0x06002204 RID: 8708 RVA: 0x0005A944 File Offset: 0x00058B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimationGameplayTagPush);
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x0005A952 File Offset: 0x00058B52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimationGameplayTagPush other)
		{
			return other != null && (other == this || (this.ChangedTagId == other.ChangedTagId && this.IsAdd == other.IsAdd && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002206 RID: 8710 RVA: 0x0005A990 File Offset: 0x00058B90
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

		// Token: 0x06002207 RID: 8711 RVA: 0x0005A9E8 File Offset: 0x00058BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002208 RID: 8712 RVA: 0x0005A9F5 File Offset: 0x00058BF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002209 RID: 8713 RVA: 0x0005AA00 File Offset: 0x00058C00
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
				output.WriteRawTag(120);
				output.WriteBool(this.IsAdd);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600220A RID: 8714 RVA: 0x0005AA58 File Offset: 0x00058C58
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

		// Token: 0x0600220B RID: 8715 RVA: 0x0005AAA4 File Offset: 0x00058CA4
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

		// Token: 0x0600220C RID: 8716 RVA: 0x0005AAF4 File Offset: 0x00058CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x0005AB00 File Offset: 0x00058D00
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
					if (num != 120U)
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

		// Token: 0x04002459 RID: 9305
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400245A RID: 9306
		public const int ChangedTagIdFieldNumber = 1;

		// Token: 0x0400245B RID: 9307
		private int changedTagId_;

		// Token: 0x0400245C RID: 9308
		public const int IsAddFieldNumber = 15;

		// Token: 0x0400245D RID: 9309
		private bool isAdd_;
	}
}
